// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

using Microsoft.PowerShell;
using Microsoft.PowerShell.DesiredStateConfiguration.Internal;

namespace System.Management.Automation.Language
{
internal class SemanticChecks : AstVisitor2, IAstPostVisitHandler
{
private readonly Parser _parser;

private static readonly IsConstantValueVisitor s_isConstantAttributeArgVisitor ;

private static readonly IsConstantValueVisitor s_isConstantAttributeArgForClassVisitor ;

private readonly Stack<MemberAst> _memberScopeStack;

private readonly Stack<ScriptBlockAst> _scopeStack;

internal static void CheckAst(Parser parser, ScriptBlockAst ast)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1555,1188,1732);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,1277,1337);

SemanticChecks 
semanticChecker = f_1555_1310_1336(parser)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,1351,1389);

f_1555_1351_1388(            semanticChecker._scopeStack, ast);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,1403,1438);

f_1555_1403_1437(            ast, semanticChecker);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,1452,1486);

f_1555_1452_1485(            semanticChecker._scopeStack);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,1500,1610);

f_1555_1500_1609(f_1555_1519_1558(semanticChecker._memberScopeStack)== 0, "Unbalanced push/pop of member scope stack");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,1624,1721);

f_1555_1624_1720(f_1555_1643_1676(semanticChecker._scopeStack)== 0, "Unbalanced push/pop of scope stack");
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1555,1188,1732);

System.Management.Automation.Language.SemanticChecks
f_1555_1310_1336(System.Management.Automation.Language.Parser
parser)
{
var return_v = new System.Management.Automation.Language.SemanticChecks( parser);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 1310, 1336);
return return_v;
}


int
f_1555_1351_1388(System.Collections.Generic.Stack<System.Management.Automation.Language.ScriptBlockAst>
this_param,System.Management.Automation.Language.ScriptBlockAst
item)
{
this_param.Push( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 1351, 1388);
return 0;
}


System.Management.Automation.Language.AstVisitAction
f_1555_1403_1437(System.Management.Automation.Language.ScriptBlockAst
this_param,System.Management.Automation.Language.SemanticChecks
visitor)
{
var return_v = this_param.InternalVisit( (System.Management.Automation.Language.AstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 1403, 1437);
return return_v;
}


System.Management.Automation.Language.ScriptBlockAst
f_1555_1452_1485(System.Collections.Generic.Stack<System.Management.Automation.Language.ScriptBlockAst>
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 1452, 1485);
return return_v;
}


int
f_1555_1519_1558(System.Collections.Generic.Stack<System.Management.Automation.Language.MemberAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 1519, 1558);
return return_v;
}


int
f_1555_1500_1609(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 1500, 1609);
return 0;
}


int
f_1555_1643_1676(System.Collections.Generic.Stack<System.Management.Automation.Language.ScriptBlockAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 1643, 1676);
return return_v;
}


int
f_1555_1624_1720(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 1624, 1720);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,1188,1732);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,1188,1732);
}
		}

private SemanticChecks(Parser parser)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1555,1744,1947);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,611,618);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,1097,1114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,1164,1175);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,1806,1823);

_parser = parser;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,1837,1880);

_memberScopeStack = f_1555_1857_1879();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,1894,1936);

_scopeStack = f_1555_1908_1935();
DynAbs.Tracing.TraceSender.TraceExitConstructor(1555,1744,1947);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,1744,1947);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,1744,1947);
}
		}

private bool AnalyzingStaticMember()
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,1959,2396);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,2020,2044);

MemberAst 
currentMember
=default(MemberAst);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,2058,2206) || true) && (f_1555_2062_2085(_memberScopeStack)== 0 ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 2062, 2144)||(currentMember = f_1555_2111_2135(_memberScopeStack)) == null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,2058,2206);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,2178,2191);

return false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,2058,2206);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,2222,2275);

var 
fnMemberAst = currentMember as FunctionMemberAst
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,2289,2385);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1555, 2296, 2315)||((fnMemberAst != null &&DynAbs.Tracing.TraceSender.Conditional_F2(1555, 2318, 2338))||DynAbs.Tracing.TraceSender.Conditional_F3(1555, 2341, 2384)))?f_1555_2318_2338(fnMemberAst):f_1555_2341_2384(((PropertyMemberAst)currentMember));
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,1959,2396);

int
f_1555_2062_2085(System.Collections.Generic.Stack<System.Management.Automation.Language.MemberAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 2062, 2085);
return return_v;
}


System.Management.Automation.Language.MemberAst
f_1555_2111_2135(System.Collections.Generic.Stack<System.Management.Automation.Language.MemberAst>
this_param)
{
var return_v = this_param.Peek();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 2111, 2135);
return return_v;
}


bool
f_1555_2318_2338(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.IsStatic ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 2318, 2338);
return return_v;
}


bool
f_1555_2341_2384(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.IsStatic;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 2341, 2384);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,1959,2396);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,1959,2396);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private bool IsValidAttributeArgument(Ast ast, IsConstantValueVisitor visitor)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,2408,2555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,2511,2544);

return (bool)f_1555_2524_2543(ast, visitor);
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,2408,2555);

object
f_1555_2524_2543(System.Management.Automation.Language.Ast
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.Accept( (System.Management.Automation.Language.ICustomAstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 2524, 2543);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,2408,2555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,2408,2555);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private (string id, string msg) GetNonConstantAttributeArgErrorExpr(IsConstantValueVisitor visitor)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,2567,3142);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,2691,2938) || true) && (f_1555_2695_2734(visitor))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,2691,2938);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,2768,2923);

return (nameof(ParserStrings.ParameterAttributeArgumentNeedsToBeConstant),
f_1555_2864_2921());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,2691,2938);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,2954,3131);

return (nameof(ParserStrings.ParameterAttributeArgumentNeedsToBeConstantOrScriptBlock),
f_1555_3059_3129());
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,2567,3142);

bool
f_1555_2695_2734(System.Management.Automation.Language.IsConstantValueVisitor
this_param)
{
var return_v = this_param.CheckingClassAttributeArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 2695, 2734);
return return_v;
}


string
f_1555_2864_2921()
{
var return_v =                     ParserStrings.ParameterAttributeArgumentNeedsToBeConstant;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 2864, 2921);
return return_v;
}


string
f_1555_3059_3129()
{
var return_v =                 ParserStrings.ParameterAttributeArgumentNeedsToBeConstantOrScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 3059, 3129);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,2567,3142);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,2567,3142);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void CheckForDuplicateParameters(ReadOnlyCollection<ParameterAst> parameters)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,3154,4616);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,3264,4605) || true) && (f_1555_3268_3284(parameters)> 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,3264,4605);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,3322,3408);

HashSet<string> 
parametersSet = f_1555_3354_3407(f_1555_3374_3406())
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,3426,4590);
foreach(var parameter in f_1555_3452_3462_I(parameters) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,3426,4590);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,3504,3564);

string 
parameterName = f_1555_3527_3563(f_1555_3527_3554(f_1555_3527_3541(parameter)))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,3586,4064) || true) && (f_1555_3590_3627(parametersSet, parameterName))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,3586,4064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,3677,3910);

f_1555_3677_3909(                        _parser, f_1555_3697_3718(f_1555_3697_3711(parameter)), nameof(ParserStrings.DuplicateFormalParameter), f_1555_3826_3864(), parameterName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,3586,4064);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,3586,4064);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,4008,4041);

f_1555_4008_4040(                        parametersSet, parameterName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,3586,4064);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,4088,4251);

var 
voidConstraint =
f_1555_4134_4250(f_1555_4134_4182(f_1555_4134_4154(parameter)), t => typeof(void) == t.TypeName.GetReflectionType())
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,4275,4571) || true) && (voidConstraint != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,4275,4571);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,4351,4548);

f_1555_4351_4547(                        _parser, f_1555_4371_4392(voidConstraint), nameof(ParserStrings.VoidTypeConstraintNotAllowed), f_1555_4504_4546());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,4275,4571);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,3426,4590);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,1165);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,1165);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1555,3264,4605);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,3154,4616);

int
f_1555_3268_3284(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 3268, 3284);
return return_v;
}


System.StringComparer
f_1555_3374_3406()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 3374, 3406);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1555_3354_3407(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.HashSet<string>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 3354, 3407);
return return_v;
}


System.Management.Automation.Language.VariableExpressionAst
f_1555_3527_3541(System.Management.Automation.Language.ParameterAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 3527, 3541);
return return_v;
}


System.Management.Automation.VariablePath
f_1555_3527_3554(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 3527, 3554);
return return_v;
}


string
f_1555_3527_3563(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UserPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 3527, 3563);
return return_v;
}


bool
f_1555_3590_3627(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 3590, 3627);
return return_v;
}


System.Management.Automation.Language.VariableExpressionAst
f_1555_3697_3711(System.Management.Automation.Language.ParameterAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 3697, 3711);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_3697_3718(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 3697, 3718);
return return_v;
}


string
f_1555_3826_3864()
{
var return_v =                             ParserStrings.DuplicateFormalParameter;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 3826, 3864);
return return_v;
}


int
f_1555_3677_3909(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 3677, 3909);
return 0;
}


bool
f_1555_4008_4040(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 4008, 4040);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeBaseAst>
f_1555_4134_4154(System.Management.Automation.Language.ParameterAst
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 4134, 4154);
return return_v;
}


System.Collections.Generic.IEnumerable<System.Management.Automation.Language.TypeConstraintAst>
f_1555_4134_4182(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeBaseAst>
source)
{
var return_v = source.OfType<System.Management.Automation.Language.TypeConstraintAst>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 4134, 4182);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_4134_4250(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.TypeConstraintAst>
source,System.Func<System.Management.Automation.Language.TypeConstraintAst, bool>
predicate)
{
var return_v = source.FirstOrDefault<System.Management.Automation.Language.TypeConstraintAst>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 4134, 4250);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_4371_4392(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 4371, 4392);
return return_v;
}


string
f_1555_4504_4546()
{
var return_v =                             ParserStrings.VoidTypeConstraintNotAllowed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 4504, 4546);
return return_v;
}


int
f_1555_4351_4547(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 4351, 4547);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
f_1555_3452_3462_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 3452, 3462);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,3154,4616);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,3154,4616);
}
		}

public override AstVisitAction VisitParamBlock(ParamBlockAst paramBlockAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,4628,4840);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,4728,4782);

f_1555_4728_4781(this, f_1555_4756_4780(paramBlockAst));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,4798,4829);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,4628,4840);

System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
f_1555_4756_4780(System.Management.Automation.Language.ParamBlockAst
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 4756, 4780);
return return_v;
}


int
f_1555_4728_4781(System.Management.Automation.Language.SemanticChecks
this_param,System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
parameters)
{
this_param.CheckForDuplicateParameters( parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 4728, 4781);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,4628,4840);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,4628,4840);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTypeConstraint(TypeConstraintAst typeConstraintAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,4852,5109);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,4964,5051);

f_1555_4964_5050(f_1555_4988_5014(typeConstraintAst), f_1555_5016_5040(typeConstraintAst), _parser);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,5067,5098);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,4852,5109);

System.Management.Automation.Language.ITypeName
f_1555_4988_5014(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 4988, 5014);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_5016_5040(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 5016, 5040);
return return_v;
}


int
f_1555_4964_5050(System.Management.Automation.Language.ITypeName
typeName,System.Management.Automation.Language.IScriptExtent
extent,System.Management.Automation.Language.Parser
parser)
{
CheckArrayTypeNameDepth( typeName, extent, parser);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 4964, 5050);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,4852,5109);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,4852,5109);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitAttribute(AttributeAst attributeAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,5121,11648);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,5218,5296);

HashSet<string> 
names = f_1555_5242_5295(f_1555_5262_5294())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,5312,5350);

bool 
checkingAttributeOnClass = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,5364,5426);

AttributeTargets 
attributeTargets = default(AttributeTargets)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,5442,5475);

var 
parent = f_1555_5455_5474(attributeAst)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,5489,5555);

TypeDefinitionAst 
typeDefinitionAst = parent as TypeDefinitionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,5569,6954) || true) && (typeDefinitionAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,5569,6954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,5632,5664);

checkingAttributeOnClass = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,5682,5924);

attributeTargets = (DynAbs.Tracing.TraceSender.Conditional_F1(1555, 5701, 5726)||((f_1555_5701_5726(typeDefinitionAst)&&DynAbs.Tracing.TraceSender.Conditional_F2(1555, 5750, 5772))||DynAbs.Tracing.TraceSender.Conditional_F3(1555, 5796, 5923)))?AttributeTargets.Class
:(DynAbs.Tracing.TraceSender.Conditional_F1(1555, 5796, 5820)||((f_1555_5796_5820(typeDefinitionAst)&&DynAbs.Tracing.TraceSender.Conditional_F2(1555, 5848, 5869))||DynAbs.Tracing.TraceSender.Conditional_F3(1555, 5897, 5923)))?AttributeTargets.Enum
:AttributeTargets.Interface;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,5569,6954);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,5569,6954);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,5958,6954) || true) && (parent is PropertyMemberAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,5958,6954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,6023,6055);

checkingAttributeOnClass = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,6073,6143);

attributeTargets = AttributeTargets.Property | AttributeTargets.Field;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,5958,6954);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,5958,6954);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,6209,6261);

var 
functionMemberAst = parent as FunctionMemberAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,6279,6939) || true) && (functionMemberAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,6279,6939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,6350,6382);

checkingAttributeOnClass = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,6404,6562);

attributeTargets = (DynAbs.Tracing.TraceSender.Conditional_F1(1555, 6423, 6454)||((f_1555_6423_6454(functionMemberAst)&&DynAbs.Tracing.TraceSender.Conditional_F2(1555, 6482, 6510))||DynAbs.Tracing.TraceSender.Conditional_F3(1555, 6538, 6561)))?AttributeTargets.Constructor
:AttributeTargets.Method;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,6279,6939);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,6279,6939);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,6604,6939) || true) && (parent is ParameterAst &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 6608, 6679)&&f_1555_6634_6658(_memberScopeStack)is FunctionMemberAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,6604,6939);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,6721,6753);

checkingAttributeOnClass = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,6874,6920);

attributeTargets = AttributeTargets.Parameter;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,6604,6939);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,6279,6939);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,5958,6954);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,5569,6954);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,6970,7132);

var 
constantValueVisitor = (DynAbs.Tracing.TraceSender.Conditional_F1(1555, 6997, 7021)||((checkingAttributeOnClass
&&DynAbs.Tracing.TraceSender.Conditional_F2(1555, 7041, 7080))||DynAbs.Tracing.TraceSender.Conditional_F3(1555, 7100, 7131)))?s_isConstantAttributeArgForClassVisitor
:s_isConstantAttributeArgVisitor
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,7148,10285) || true) && (checkingAttributeOnClass)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,7148,10285);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,7210,7281);

var 
attributeType = f_1555_7230_7280(f_1555_7230_7251(attributeAst))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,7299,10270) || true) && (attributeType == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,7299,10270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,7366,7467);

f_1555_7366_7466(f_1555_7385_7408(f_1555_7385_7402(_parser))> 0, "Symbol resolve should have reported error already");
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,7299,10270);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,7299,10270);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,7549,7625);

var 
usage = f_1555_7561_7624(attributeType, true)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,7647,8097) || true) && (usage != null &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 7651, 7707)&&(f_1555_7669_7682(usage)& attributeTargets) == 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,7647,8097);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,7757,8074);

f_1555_7757_8073(                        _parser, f_1555_7777_7796(attributeAst), nameof(ParserStrings.AttributeNotAllowedOnDeclaration), f_1555_7912_7958(), f_1555_7989_8028(attributeType), f_1555_8059_8072(usage));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,7647,8097);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,8121,10251);
foreach(var namedArg in f_1555_8146_8173_I(f_1555_8146_8173(attributeAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,8121,10251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,8223,8256);

var 
name = f_1555_8234_8255(namedArg)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,8282,8529);

var 
members = f_1555_8296_8528(attributeType, name, MemberTypes.Field | MemberTypes.Property, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance |
                            BindingFlags.FlattenHierarchy)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,8555,9158) || true) && (f_1555_8559_8573(members)!= 1 ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 8559, 8638)||!(members[0] is PropertyInfo ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 8584, 8637)||members[0] is FieldInfo))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,8555,9158);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,8696,9090);

f_1555_8696_9089(                            _parser, f_1555_8716_8731(namedArg), nameof(ParserStrings.PropertyNotFoundForAttribute), f_1555_8851_8893(), name, f_1555_8967_9006(attributeType), f_1555_9041_9088(attributeType));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,9122,9131);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,8555,9158);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,9186,9232);

var 
propertyInfo = members[0] as PropertyInfo
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,9258,9780) || true) && (propertyInfo != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,9258,9780);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,9340,9712) || true) && (f_1555_9344_9371(propertyInfo)== null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,9340,9712);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,9445,9681);

f_1555_9445_9680(                                _parser, f_1555_9465_9480(namedArg), nameof(ExtendedTypeSystem.ReadOnlyProperty), f_1555_9601_9636(), name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,9340,9712);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,9744,9753);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,9258,9780);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,9808,9846);

var 
fieldInfo = (FieldInfo)members[0]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,9872,10228) || true) && (f_1555_9876_9896(fieldInfo)||(DynAbs.Tracing.TraceSender.Expression_False(1555, 9876, 9919)||f_1555_9900_9919(fieldInfo)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,9872,10228);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,9977,10201);

f_1555_9977_10200(                            _parser, f_1555_9997_10012(namedArg), nameof(ExtendedTypeSystem.ReadOnlyProperty), f_1555_10125_10160(), name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,9872,10228);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,8121,10251);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,2131);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,2131);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1555,7299,10270);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,7148,10285);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,10301,11202);
foreach(var namedArg in f_1555_10326_10353_I(f_1555_10326_10353(attributeAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,10301,11202);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,10387,10423);

string 
name = f_1555_10401_10422(namedArg)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,10441,11187) || true) && (f_1555_10445_10465(names, name))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,10441,11187);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,10507,10709);

f_1555_10507_10708(                    _parser, f_1555_10527_10542(namedArg), nameof(ParserStrings.DuplicateNamedArgument), f_1555_10640_10676(), name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,10441,11187);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,10441,11187);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,10791,10807);

f_1555_10791_10806(                    names, name);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,10831,11168) || true) && (f_1555_10835_10862_M(!namedArg.ExpressionOmitted)&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 10835, 10932)&&!f_1555_10867_10932(this, f_1555_10892_10909(namedArg), constantValueVisitor)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,10831,11168);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,10982,11052);

var 
error = f_1555_10994_11051(this, constantValueVisitor)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,11078,11145);

f_1555_11078_11144(                        _parser, f_1555_11098_11122(f_1555_11098_11115(namedArg)), error.id, error.msg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,10831,11168);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,10441,11187);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,10301,11202);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,902);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,902);
}try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,11218,11590);
foreach(var posArg in f_1555_11241_11273_I(f_1555_11241_11273(attributeAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,11218,11590);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,11307,11575) || true) && (!f_1555_11312_11366(this, posArg, constantValueVisitor))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,11307,11575);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,11408,11478);

var 
error = f_1555_11420_11477(this, constantValueVisitor)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,11500,11556);

f_1555_11500_11555(                    _parser, f_1555_11520_11533(posArg), error.id, error.msg);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,11307,11575);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,11218,11590);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,373);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,373);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,11606,11637);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,5121,11648);

System.StringComparer
f_1555_5262_5294()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 5262, 5294);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1555_5242_5295(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.HashSet<string>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 5242, 5295);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_5455_5474(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 5455, 5474);
return return_v;
}


bool
f_1555_5701_5726(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.IsClass
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 5701, 5726);
return return_v;
}


bool
f_1555_5796_5820(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.IsEnum
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 5796, 5820);
return return_v;
}


bool
f_1555_6423_6454(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.IsConstructor
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 6423, 6454);
return return_v;
}


System.Management.Automation.Language.MemberAst
f_1555_6634_6658(System.Collections.Generic.Stack<System.Management.Automation.Language.MemberAst>
this_param)
{
var return_v = this_param.Peek();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 6634, 6658);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_7230_7251(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 7230, 7251);
return return_v;
}


System.Type
f_1555_7230_7280(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionAttributeType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 7230, 7280);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
f_1555_7385_7402(System.Management.Automation.Language.Parser
this_param)
{
var return_v = this_param.ErrorList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 7385, 7402);
return return_v;
}


int
f_1555_7385_7408(System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 7385, 7408);
return return_v;
}


int
f_1555_7366_7466(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 7366, 7466);
return 0;
}


System.AttributeUsageAttribute?
f_1555_7561_7624(System.Type
element,bool
inherit)
{
var return_v = element.GetCustomAttribute<System.AttributeUsageAttribute>( inherit);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 7561, 7624);
return return_v;
}


System.AttributeTargets
f_1555_7669_7682(System.AttributeUsageAttribute
this_param)
{
var return_v = this_param.ValidOn ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 7669, 7682);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_7777_7796(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 7777, 7796);
return return_v;
}


string
f_1555_7912_7958()
{
var return_v =                             ParserStrings.AttributeNotAllowedOnDeclaration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 7912, 7958);
return return_v;
}


string
f_1555_7989_8028(System.Type
type)
{
var return_v = ToStringCodeMethods.Type( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 7989, 8028);
return return_v;
}


System.AttributeTargets
f_1555_8059_8072(System.AttributeUsageAttribute
this_param)
{
var return_v = this_param.ValidOn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 8059, 8072);
return return_v;
}


int
f_1555_7757_8073(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg1,System.AttributeTargets
arg2)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 7757, 8073);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.NamedAttributeArgumentAst>
f_1555_8146_8173(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.NamedArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 8146, 8173);
return return_v;
}


string
f_1555_8234_8255(System.Management.Automation.Language.NamedAttributeArgumentAst
this_param)
{
var return_v = this_param.ArgumentName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 8234, 8255);
return return_v;
}


System.Reflection.MemberInfo[]
f_1555_8296_8528(System.Type
this_param,string
name,System.Reflection.MemberTypes
type,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetMember( name, type, bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 8296, 8528);
return return_v;
}


int
f_1555_8559_8573(System.Reflection.MemberInfo[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 8559, 8573);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_8716_8731(System.Management.Automation.Language.NamedAttributeArgumentAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 8716, 8731);
return return_v;
}


string
f_1555_8851_8893()
{
var return_v =                                 ParserStrings.PropertyNotFoundForAttribute;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 8851, 8893);
return return_v;
}


string
f_1555_8967_9006(System.Type
type)
{
var return_v = ToStringCodeMethods.Type( type);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 8967, 9006);
return return_v;
}


string
f_1555_9041_9088(System.Type
attributeType)
{
var return_v = GetValidNamedAttributeProperties( attributeType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 9041, 9088);
return return_v;
}


int
f_1555_8696_9089(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( extent, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 8696, 9089);
return 0;
}


System.Reflection.MethodInfo?
f_1555_9344_9371(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.GetSetMethod();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 9344, 9371);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_9465_9480(System.Management.Automation.Language.NamedAttributeArgumentAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 9465, 9480);
return return_v;
}


string
f_1555_9601_9636()
{
var return_v =                                     ExtendedTypeSystem.ReadOnlyProperty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 9601, 9636);
return return_v;
}


int
f_1555_9445_9680(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 9445, 9680);
return 0;
}


bool
f_1555_9876_9896(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.IsInitOnly ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 9876, 9896);
return return_v;
}


bool
f_1555_9900_9919(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.IsLiteral;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 9900, 9919);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_9997_10012(System.Management.Automation.Language.NamedAttributeArgumentAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 9997, 10012);
return return_v;
}


string
f_1555_10125_10160()
{
var return_v =                                 ExtendedTypeSystem.ReadOnlyProperty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 10125, 10160);
return return_v;
}


int
f_1555_9977_10200(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 9977, 10200);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.NamedAttributeArgumentAst>
f_1555_8146_8173_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.NamedAttributeArgumentAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 8146, 8173);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.NamedAttributeArgumentAst>
f_1555_10326_10353(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.NamedArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 10326, 10353);
return return_v;
}


string
f_1555_10401_10422(System.Management.Automation.Language.NamedAttributeArgumentAst
this_param)
{
var return_v = this_param.ArgumentName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 10401, 10422);
return return_v;
}


bool
f_1555_10445_10465(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 10445, 10465);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_10527_10542(System.Management.Automation.Language.NamedAttributeArgumentAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 10527, 10542);
return return_v;
}


string
f_1555_10640_10676()
{
var return_v =                         ParserStrings.DuplicateNamedArgument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 10640, 10676);
return return_v;
}


int
f_1555_10507_10708(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 10507, 10708);
return 0;
}


bool
f_1555_10791_10806(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 10791, 10806);
return return_v;
}


bool
f_1555_10835_10862_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 10835, 10862);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_10892_10909(System.Management.Automation.Language.NamedAttributeArgumentAst
this_param)
{
var return_v = this_param.Argument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 10892, 10909);
return return_v;
}


bool
f_1555_10867_10932(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ExpressionAst
ast,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.IsValidAttributeArgument( (System.Management.Automation.Language.Ast)ast, visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 10867, 10932);
return return_v;
}


(string id, string msg)
f_1555_10994_11051(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.GetNonConstantAttributeArgErrorExpr( visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 10994, 11051);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_11098_11115(System.Management.Automation.Language.NamedAttributeArgumentAst
this_param)
{
var return_v = this_param.Argument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 11098, 11115);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_11098_11122(System.Management.Automation.Language.ExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 11098, 11122);
return return_v;
}


int
f_1555_11078_11144(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 11078, 11144);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.NamedAttributeArgumentAst>
f_1555_10326_10353_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.NamedAttributeArgumentAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 10326, 10353);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1555_11241_11273(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.PositionalArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 11241, 11273);
return return_v;
}


bool
f_1555_11312_11366(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ExpressionAst
ast,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.IsValidAttributeArgument( (System.Management.Automation.Language.Ast)ast, visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 11312, 11366);
return return_v;
}


(string id, string msg)
f_1555_11420_11477(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.GetNonConstantAttributeArgErrorExpr( visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 11420, 11477);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_11520_11533(System.Management.Automation.Language.ExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 11520, 11533);
return return_v;
}


int
f_1555_11500_11555(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 11500, 11555);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1555_11241_11273_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 11241, 11273);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,5121,11648);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,5121,11648);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static string GetValidNamedAttributeProperties(Type attributeType)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1555,11660,12799);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,11759,11798);

var 
propertyNames = f_1555_11779_11797()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,11812,11971);

PropertyInfo[] 
properties = f_1555_11840_11970(attributeType, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,11994,11999);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,11985,12273) || true) && (i < f_1555_12005_12022(properties))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,12024,12027)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1555,11985,12273))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,11985,12273);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,12061,12103);

PropertyInfo 
propertyInfo = properties[i]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,12121,12258) || true) && (f_1555_12125_12152(propertyInfo)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,12121,12258);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,12202,12239);

f_1555_12202_12238(                    propertyNames, f_1555_12220_12237(propertyInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,12121,12258);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,289);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,289);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,12289,12437);

FieldInfo[] 
fields = f_1555_12310_12436(attributeType, BindingFlags.IgnoreCase | BindingFlags.Public | BindingFlags.Instance | BindingFlags.FlattenHierarchy)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,12460,12465);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,12451,12732) || true) && (i < f_1555_12471_12484(fields))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,12486,12489)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1555,12451,12732))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,12451,12732);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,12523,12555);

FieldInfo 
fieldInfo = fields[i]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,12573,12717) || true) && (f_1555_12577_12598_M(!fieldInfo.IsInitOnly)&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 12577, 12622)&&f_1555_12602_12622_M(!fieldInfo.IsLiteral)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,12573,12717);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,12664,12698);

f_1555_12664_12697(                    propertyNames, f_1555_12682_12696(fieldInfo));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,12573,12717);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,282);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,282);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,12748,12788);

return f_1555_12755_12787(", ", propertyNames);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1555,11660,12799);

System.Collections.Generic.List<string>
f_1555_11779_11797()
{
var return_v = new System.Collections.Generic.List<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 11779, 11797);
return return_v;
}


System.Reflection.PropertyInfo[]
f_1555_11840_11970(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetProperties( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 11840, 11970);
return return_v;
}


int
f_1555_12005_12022(System.Reflection.PropertyInfo[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 12005, 12022);
return return_v;
}


System.Reflection.MethodInfo?
f_1555_12125_12152(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.GetSetMethod();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 12125, 12152);
return return_v;
}


string
f_1555_12220_12237(System.Reflection.PropertyInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 12220, 12237);
return return_v;
}


int
f_1555_12202_12238(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 12202, 12238);
return 0;
}


System.Reflection.FieldInfo[]
f_1555_12310_12436(System.Type
this_param,System.Reflection.BindingFlags
bindingAttr)
{
var return_v = this_param.GetFields( bindingAttr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 12310, 12436);
return return_v;
}


int
f_1555_12471_12484(System.Reflection.FieldInfo[]
this_param)
{
var return_v = this_param.Length;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 12471, 12484);
return return_v;
}


bool
f_1555_12577_12598_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 12577, 12598);
return return_v;
}


bool
f_1555_12602_12622_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 12602, 12622);
return return_v;
}


string
f_1555_12682_12696(System.Reflection.FieldInfo
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 12682, 12696);
return return_v;
}


int
f_1555_12664_12697(System.Collections.Generic.List<string>
this_param,string
item)
{
this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 12664, 12697);
return 0;
}


string
f_1555_12755_12787(string
separator,System.Collections.Generic.List<string>
values)
{
var return_v = string.Join( separator, (System.Collections.Generic.IEnumerable<string?>)values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 12755, 12787);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,11660,12799);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,11660,12799);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitParameter(ParameterAst parameterAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,12811,14422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,12908,12977);

bool 
isClassMethod = f_1555_12929_12955(f_1555_12929_12948(parameterAst))is FunctionMemberAst
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,12991,13023);

bool 
isParamTypeDefined = false
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,13037,14364);
foreach(AttributeBaseAst attribute in f_1555_13076_13099_I(f_1555_13076_13099(parameterAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,13037,14364);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,13133,14349) || true) && (attribute is TypeConstraintAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,13133,14349);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,13209,14330) || true) && (f_1555_13213_13320(f_1555_13213_13240(f_1555_13213_13231(attribute)), LanguagePrimitives.OrderedAttribute, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,13209,14330);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,13370,13638);

f_1555_13370_13637(                        _parser, f_1555_13390_13406(attribute), nameof(ParserStrings.OrderedAttributeOnlyOnHashLiteralNode), f_1555_13527_13578(), f_1555_13609_13636(f_1555_13609_13627(attribute)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,13209,14330);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,13209,14330);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,13736,14307) || true) && (isClassMethod)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,13736,14307);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,13879,14222) || true) && (isParamTypeDefined)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,13879,14222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,13967,14191);

f_1555_13967_14190(                                _parser, f_1555_13987_14003(attribute), nameof(ParserStrings.MultipleTypeConstraintsOnMethodParam), f_1555_14139_14189());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,13879,14222);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,14254,14280);

isParamTypeDefined = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,13736,14307);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,13209,14330);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,13133,14349);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,13037,14364);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,1328);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,1328);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,14380,14411);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,12811,14422);

System.Management.Automation.Language.Ast
f_1555_12929_12948(System.Management.Automation.Language.ParameterAst
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 12929, 12948);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_12929_12955(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 12929, 12955);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeBaseAst>
f_1555_13076_13099(System.Management.Automation.Language.ParameterAst
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 13076, 13099);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_13213_13231(System.Management.Automation.Language.AttributeBaseAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 13213, 13231);
return return_v;
}


string
f_1555_13213_13240(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 13213, 13240);
return return_v;
}


bool
f_1555_13213_13320(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 13213, 13320);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_13390_13406(System.Management.Automation.Language.AttributeBaseAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 13390, 13406);
return return_v;
}


string
f_1555_13527_13578()
{
var return_v =                             ParserStrings.OrderedAttributeOnlyOnHashLiteralNode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 13527, 13578);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_13609_13627(System.Management.Automation.Language.AttributeBaseAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 13609, 13627);
return return_v;
}


string
f_1555_13609_13636(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 13609, 13636);
return return_v;
}


int
f_1555_13370_13637(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 13370, 13637);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1555_13987_14003(System.Management.Automation.Language.AttributeBaseAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 13987, 14003);
return return_v;
}


string
f_1555_14139_14189()
{
var return_v =                                     ParserStrings.MultipleTypeConstraintsOnMethodParam;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 14139, 14189);
return return_v;
}


int
f_1555_13967_14190(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 13967, 14190);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeBaseAst>
f_1555_13076_13099_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeBaseAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 13076, 13099);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,12811,14422);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,12811,14422);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTypeExpression(TypeExpressionAst typeExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,14434,14944);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,14546,14633);

f_1555_14546_14632(f_1555_14570_14596(typeExpressionAst), f_1555_14598_14622(typeExpressionAst), _parser);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,14725,14886) || true) && (typeof(Type) == f_1555_14745_14791(f_1555_14745_14771(typeExpressionAst)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,14725,14886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,14825,14871);

f_1555_14825_14870(this, typeExpressionAst);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,14725,14886);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,14902,14933);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,14434,14944);

System.Management.Automation.Language.ITypeName
f_1555_14570_14596(System.Management.Automation.Language.TypeExpressionAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 14570, 14596);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_14598_14622(System.Management.Automation.Language.TypeExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 14598, 14622);
return return_v;
}


int
f_1555_14546_14632(System.Management.Automation.Language.ITypeName
typeName,System.Management.Automation.Language.IScriptExtent
extent,System.Management.Automation.Language.Parser
parser)
{
CheckArrayTypeNameDepth( typeName, extent, parser);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 14546, 14632);
return 0;
}


System.Management.Automation.Language.ITypeName
f_1555_14745_14771(System.Management.Automation.Language.TypeExpressionAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 14745, 14771);
return return_v;
}


System.Type
f_1555_14745_14791(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 14745, 14791);
return return_v;
}


int
f_1555_14825_14870(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.TypeExpressionAst
ast)
{
this_param.MarkAstParentsAsSuspicious( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 14825, 14870);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,14434,14944);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,14434,14944);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

internal static void CheckArrayTypeNameDepth(ITypeName typeName, IScriptExtent extent, Parser parser)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1555,14956,15766);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,15082,15096);

int 
count = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,15110,15136);

ITypeName 
type = typeName
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,15150,15755) || true) && ((type is TypeName) == false)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,15150,15755);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,15218,15226);

count++;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,15244,15505) || true) && (count > 200)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,15244,15505);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,15301,15458);

f_1555_15301_15457(                    parser, extent, nameof(ParserStrings.ScriptTooComplicated), f_1555_15422_15456());
DynAbs.Tracing.TraceSender.TraceBreak(1555,15480,15486);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,15244,15505);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,15525,15740) || true) && (type is ArrayTypeName)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,15525,15740);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,15592,15633);

type = f_1555_15599_15632(((ArrayTypeName)type));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,15525,15740);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,15525,15740);
DynAbs.Tracing.TraceSender.TraceBreak(1555,15715,15721);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,15525,15740);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,15150,15755);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,15150,15755);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,15150,15755);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1555,14956,15766);

string
f_1555_15422_15456()
{
var return_v =                         ParserStrings.ScriptTooComplicated;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 15422, 15456);
return return_v;
}


int
f_1555_15301_15457(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 15301, 15457);
return 0;
}


System.Management.Automation.Language.ITypeName
f_1555_15599_15632(System.Management.Automation.Language.ArrayTypeName
this_param)
{
var return_v = this_param.ElementType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 15599, 15632);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,14956,15766);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,14956,15766);
}
		}

public override AstVisitAction VisitTypeDefinition(TypeDefinitionAst typeDefinitionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,15778,16555);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,15890,15934);

AttributeAst 
dscResourceAttributeAst = null
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,15957,15962);
            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,15948,16315) || true) && (i < f_1555_15968_16002(f_1555_15968_15996(typeDefinitionAst)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,16004,16007)
,i++,DynAbs.Tracing.TraceSender.TraceExitCondition(1555,15948,16315))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,15948,16315);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,16041,16084);

var 
attr = f_1555_16052_16083(f_1555_16052_16080(typeDefinitionAst), i)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,16102,16300) || true) && (f_1555_16106_16148(f_1555_16106_16119(attr))== typeof(DscResourceAttribute))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,16102,16300);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,16222,16253);

dscResourceAttributeAst = attr;
DynAbs.Tracing.TraceSender.TraceBreak(1555,16275,16281);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,16102,16300);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,368);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,368);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,16331,16497) || true) && (dscResourceAttributeAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,16331,16497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,16400,16482);

f_1555_16400_16481(_parser, typeDefinitionAst, dscResourceAttributeAst);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,16331,16497);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,16513,16544);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,15778,16555);

System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
f_1555_15968_15996(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 15968, 15996);
return return_v;
}


int
f_1555_15968_16002(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 15968, 16002);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
f_1555_16052_16080(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 16052, 16080);
return return_v;
}


System.Management.Automation.Language.AttributeAst
f_1555_16052_16083(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 16052, 16083);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_16106_16119(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 16106, 16119);
return return_v;
}


System.Type
f_1555_16106_16148(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionAttributeType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 16106, 16148);
return return_v;
}


int
f_1555_16400_16481(System.Management.Automation.Language.Parser
parser,System.Management.Automation.Language.TypeDefinitionAst
typeDefinitionAst,System.Management.Automation.Language.AttributeAst
dscResourceAttributeAst)
{
DscResourceChecker.CheckType( parser, typeDefinitionAst, dscResourceAttributeAst);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 16400, 16481);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,15778,16555);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,15778,16555);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitFunctionMember(FunctionMemberAst functionMemberAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,16567,18459);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,16679,16721);

f_1555_16679_16720(            _memberScopeStack, functionMemberAst);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,16737,16771);

var 
body = f_1555_16748_16770(functionMemberAst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,16785,17043) || true) && (f_1555_16789_16804(body)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,16785,17043);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,16846,17028);

f_1555_16846_17027(                _parser, f_1555_16866_16888(f_1555_16866_16881(body)), nameof(ParserStrings.ParamBlockNotAllowedInMethod), f_1555_16984_17026());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,16785,17043);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,17059,17534) || true) && (f_1555_17063_17078(body)!= null ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 17063, 17132)||f_1555_17107_17124(body)!= null )||(DynAbs.Tracing.TraceSender.Expression_False(1555, 17063, 17183)||f_1555_17153_17175(body)!= null )||(DynAbs.Tracing.TraceSender.Expression_False(1555, 17063, 17226)||f_1555_17204_17226_M(!f_1555_17205_17218(body).Unnamed)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,17059,17534);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,17260,17519);

f_1555_17260_17518(                _parser, f_1555_17280_17379(f_1555_17305_17327(body), f_1555_17329_17344(body), f_1555_17346_17363(body), f_1555_17365_17378(body)), nameof(ParserStrings.NamedBlockNotAllowedInMethod), f_1555_17475_17517());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,17059,17534);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,17550,17871) || true) && (f_1555_17554_17585(functionMemberAst)&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 17554, 17625)&&f_1555_17589_17617(functionMemberAst)!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,17550,17871);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,17659,17856);

f_1555_17659_17855(                _parser, f_1555_17679_17714(f_1555_17679_17707(functionMemberAst)), nameof(ParserStrings.ConstructorCantHaveReturnType), f_1555_17811_17854());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,17550,17871);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,17975,18060);

var 
allCodePathsReturned = f_1555_18002_18059(functionMemberAst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,18074,18401) || true) && (!allCodePathsReturned &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 18078, 18140)&&!f_1555_18104_18140(functionMemberAst)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,18074,18401);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,18174,18386);

f_1555_18174_18385(                _parser, f_1555_18194_18222(functionMemberAst)??(DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.IScriptExtent>(1555, 18194, 18250)??f_1555_18226_18250(functionMemberAst)), nameof(ParserStrings.MethodHasCodePathNotReturn), f_1555_18344_18384());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,18074,18401);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,18417,18448);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,16567,18459);

int
f_1555_16679_16720(System.Collections.Generic.Stack<System.Management.Automation.Language.MemberAst>
this_param,System.Management.Automation.Language.FunctionMemberAst
item)
{
this_param.Push( (System.Management.Automation.Language.MemberAst)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 16679, 16720);
return 0;
}


System.Management.Automation.Language.ScriptBlockAst
f_1555_16748_16770(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 16748, 16770);
return return_v;
}


System.Management.Automation.Language.ParamBlockAst
f_1555_16789_16804(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.ParamBlock ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 16789, 16804);
return return_v;
}


System.Management.Automation.Language.ParamBlockAst
f_1555_16866_16881(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.ParamBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 16866, 16881);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_16866_16888(System.Management.Automation.Language.ParamBlockAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 16866, 16888);
return return_v;
}


string
f_1555_16984_17026()
{
var return_v =                     ParserStrings.ParamBlockNotAllowedInMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 16984, 17026);
return return_v;
}


int
f_1555_16846_17027(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 16846, 17027);
return 0;
}


System.Management.Automation.Language.NamedBlockAst
f_1555_17063_17078(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.BeginBlock ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17063, 17078);
return return_v;
}


System.Management.Automation.Language.NamedBlockAst
f_1555_17107_17124(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.ProcessBlock ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17107, 17124);
return return_v;
}


System.Management.Automation.Language.NamedBlockAst
f_1555_17153_17175(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.DynamicParamBlock ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17153, 17175);
return return_v;
}


System.Management.Automation.Language.NamedBlockAst
f_1555_17205_17218(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.EndBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17205, 17218);
return return_v;
}


bool
f_1555_17204_17226_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17204, 17226);
return return_v;
}


System.Management.Automation.Language.NamedBlockAst
f_1555_17305_17327(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.DynamicParamBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17305, 17327);
return return_v;
}


System.Management.Automation.Language.NamedBlockAst
f_1555_17329_17344(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.BeginBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17329, 17344);
return return_v;
}


System.Management.Automation.Language.NamedBlockAst
f_1555_17346_17363(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.ProcessBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17346, 17363);
return return_v;
}


System.Management.Automation.Language.NamedBlockAst
f_1555_17365_17378(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.EndBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17365, 17378);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_17280_17379(params object[]
objs)
{
var return_v = Parser.ExtentFromFirstOf( objs);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 17280, 17379);
return return_v;
}


string
f_1555_17475_17517()
{
var return_v =                     ParserStrings.NamedBlockNotAllowedInMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17475, 17517);
return return_v;
}


int
f_1555_17260_17518(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 17260, 17518);
return 0;
}


bool
f_1555_17554_17585(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.IsConstructor ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17554, 17585);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_17589_17617(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.ReturnType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17589, 17617);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_17679_17707(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17679, 17707);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_17679_17714(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17679, 17714);
return return_v;
}


string
f_1555_17811_17854()
{
var return_v =                     ParserStrings.ConstructorCantHaveReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 17811, 17854);
return return_v;
}


int
f_1555_17659_17855(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 17659, 17855);
return 0;
}


bool
f_1555_18002_18059(System.Management.Automation.Language.FunctionMemberAst
ast)
{
var return_v = VariableAnalysis.AnalyzeMemberFunction( ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 18002, 18059);
return return_v;
}


bool
f_1555_18104_18140(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.IsReturnTypeVoid();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 18104, 18140);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_18194_18222(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.NameExtent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 18194, 18222);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_18226_18250(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 18226, 18250);
return return_v;
}


string
f_1555_18344_18384()
{
var return_v =                     ParserStrings.MethodHasCodePathNotReturn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 18344, 18384);
return return_v;
}


int
f_1555_18174_18385(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 18174, 18385);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,16567,18459);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,16567,18459);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,18471,19493);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,18595,19130) || true) && (f_1555_18599_18631(functionDefinitionAst)!= null
&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 18599, 18705)&&f_1555_18660_18697(f_1555_18660_18686(functionDefinitionAst))!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,18595,19130);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,18739,18941);

f_1555_18739_18940(                _parser, f_1555_18759_18803(f_1555_18759_18796(f_1555_18759_18785(functionDefinitionAst))), nameof(ParserStrings.OnlyOneParameterListAllowed), f_1555_18898_18939());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,18595,19130);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,18595,19130);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,18975,19130) || true) && (f_1555_18979_19011(functionDefinitionAst)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,18975,19130);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,19053,19115);

f_1555_19053_19114(this, f_1555_19081_19113(functionDefinitionAst));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,18975,19130);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,18595,19130);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,19146,19435) || true) && (f_1555_19150_19182(functionDefinitionAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,19146,19435);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,19216,19420);

f_1555_19216_19419(                _parser, f_1555_19236_19264(functionDefinitionAst), nameof(ParserStrings.WorkflowNotSupportedInPowerShellCore), f_1555_19368_19418());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,19146,19435);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,19451,19482);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,18471,19493);

System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
f_1555_18599_18631(System.Management.Automation.Language.FunctionDefinitionAst
this_param)
{
var return_v = this_param.Parameters ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 18599, 18631);
return return_v;
}


System.Management.Automation.Language.ScriptBlockAst
f_1555_18660_18686(System.Management.Automation.Language.FunctionDefinitionAst
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 18660, 18686);
return return_v;
}


System.Management.Automation.Language.ParamBlockAst
f_1555_18660_18697(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.ParamBlock ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 18660, 18697);
return return_v;
}


System.Management.Automation.Language.ScriptBlockAst
f_1555_18759_18785(System.Management.Automation.Language.FunctionDefinitionAst
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 18759, 18785);
return return_v;
}


System.Management.Automation.Language.ParamBlockAst
f_1555_18759_18796(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.ParamBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 18759, 18796);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_18759_18803(System.Management.Automation.Language.ParamBlockAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 18759, 18803);
return return_v;
}


string
f_1555_18898_18939()
{
var return_v =                     ParserStrings.OnlyOneParameterListAllowed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 18898, 18939);
return return_v;
}


int
f_1555_18739_18940(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 18739, 18940);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
f_1555_18979_19011(System.Management.Automation.Language.FunctionDefinitionAst
this_param)
{
var return_v = this_param.Parameters ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 18979, 19011);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
f_1555_19081_19113(System.Management.Automation.Language.FunctionDefinitionAst
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 19081, 19113);
return return_v;
}


int
f_1555_19053_19114(System.Management.Automation.Language.SemanticChecks
this_param,System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
parameters)
{
this_param.CheckForDuplicateParameters( parameters);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 19053, 19114);
return 0;
}


bool
f_1555_19150_19182(System.Management.Automation.Language.FunctionDefinitionAst
this_param)
{
var return_v = this_param.IsWorkflow;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 19150, 19182);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_19236_19264(System.Management.Automation.Language.FunctionDefinitionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 19236, 19264);
return return_v;
}


string
f_1555_19368_19418()
{
var return_v =                     ParserStrings.WorkflowNotSupportedInPowerShellCore;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 19368, 19418);
return return_v;
}


int
f_1555_19216_19419(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 19216, 19419);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,18471,19493);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,18471,19493);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitSwitchStatement(SwitchStatementAst switchStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,19505,20133);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,19662,20075) || true) && ((f_1555_19667_19691(switchStatementAst)& SwitchFlags.Parallel) == SwitchFlags.Parallel)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,19662,20075);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,19773,20060);

f_1555_19773_20059(                _parser, f_1555_19815_19840(switchStatementAst), nameof(ParserStrings.KeywordParameterReservedForFutureUse), f_1555_19944_19994(), "switch", "parallel");
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,19662,20075);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,20091,20122);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,19505,20133);

System.Management.Automation.Language.SwitchFlags
f_1555_19667_19691(System.Management.Automation.Language.SwitchStatementAst
this_param)
{
var return_v = this_param.Flags ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 19667, 19691);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_19815_19840(System.Management.Automation.Language.SwitchStatementAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 19815, 19840);
return return_v;
}


string
f_1555_19944_19994()
{
var return_v =                     ParserStrings.KeywordParameterReservedForFutureUse;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 19944, 19994);
return return_v;
}


int
f_1555_19773_20059(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg1,string
arg2)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 19773, 20059);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,19505,20133);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,19505,20133);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static IEnumerable<string> GetConstantDataStatementAllowedCommands(DataStatementAst dataStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1555,20145,20505);

var listYield= new List<String>();
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,20279,20317);

listYield.Add("ConvertFrom-StringData");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,20331,20494);
foreach(var allowed in f_1555_20355_20387_I(f_1555_20355_20387(dataStatementAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,20331,20494);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,20421,20479);

listYield.Add(f_1555_20434_20478(((StringConstantExpressionAst)allowed)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,20331,20494);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,164);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,164);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1555,20145,20505);

return listYield;

System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1555_20355_20387(System.Management.Automation.Language.DataStatementAst
this_param)
{
var return_v = this_param.CommandsAllowed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 20355, 20387);
return return_v;
}


string
f_1555_20434_20478(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 20434, 20478);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1555_20355_20387_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 20355, 20387);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,20145,20505);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,20145,20505);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitDataStatement(DataStatementAst dataStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,20517,21030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,20626,20794);

IEnumerable<string> 
allowedCommands =
(DynAbs.Tracing.TraceSender.Conditional_F1(1555, 20681, 20726)||((f_1555_20681_20726(dataStatementAst)&&DynAbs.Tracing.TraceSender.Conditional_F2(1555, 20729, 20733))||DynAbs.Tracing.TraceSender.Conditional_F3(1555, 20736, 20793)))?null :f_1555_20736_20793(dataStatementAst)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,20808,20913);

RestrictedLanguageChecker 
checker = f_1555_20844_20912(_parser, allowedCommands, null, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,20927,20972);

f_1555_20927_20971(f_1555_20927_20948(dataStatementAst), checker);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,20988,21019);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,20517,21030);

bool
f_1555_20681_20726(System.Management.Automation.Language.DataStatementAst
this_param)
{
var return_v = this_param.HasNonConstantAllowedCommand ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 20681, 20726);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_1555_20736_20793(System.Management.Automation.Language.DataStatementAst
dataStatementAst)
{
var return_v = GetConstantDataStatementAllowedCommands( dataStatementAst);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 20736, 20793);
return return_v;
}


System.Management.Automation.Language.RestrictedLanguageChecker
f_1555_20844_20912(System.Management.Automation.Language.Parser
parser,System.Collections.Generic.IEnumerable<string>
allowedCommands,System.Collections.Generic.IEnumerable<string>
allowedVariables,bool
allowEnvironmentVariables)
{
var return_v = new System.Management.Automation.Language.RestrictedLanguageChecker( parser, allowedCommands, allowedVariables, allowEnvironmentVariables);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 20844, 20912);
return return_v;
}


System.Management.Automation.Language.StatementBlockAst
f_1555_20927_20948(System.Management.Automation.Language.DataStatementAst
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 20927, 20948);
return return_v;
}


System.Management.Automation.Language.AstVisitAction
f_1555_20927_20971(System.Management.Automation.Language.StatementBlockAst
this_param,System.Management.Automation.Language.RestrictedLanguageChecker
visitor)
{
var return_v = this_param.InternalVisit( (System.Management.Automation.Language.AstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 20927, 20971);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,20517,21030);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,20517,21030);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitForEachStatement(ForEachStatementAst forEachStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,21042,22578);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,21202,21620) || true) && ((f_1555_21207_21232(forEachStatementAst)& ForEachFlags.Parallel) == ForEachFlags.Parallel)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,21202,21620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,21316,21605);

f_1555_21316_21604(                _parser, f_1555_21358_21384(forEachStatementAst), nameof(ParserStrings.KeywordParameterReservedForFutureUse), f_1555_21488_21538(), "foreach", "parallel");
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,21202,21620);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,21636,22024) || true) && (f_1555_21640_21673(forEachStatementAst)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,21636,22024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,21715,22009);

f_1555_21715_22008(                _parser, f_1555_21757_21783(forEachStatementAst), nameof(ParserStrings.KeywordParameterReservedForFutureUse), f_1555_21887_21937(), "foreach", "throttlelimit");
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,21636,22024);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,22107,22520) || true) && ((f_1555_22112_22145(forEachStatementAst)!= null) &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 22111, 22253)&&                ((f_1555_22177_22202(forEachStatementAst)& ForEachFlags.Parallel) != ForEachFlags.Parallel)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,22107,22520);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,22287,22505);

f_1555_22287_22504(                _parser, f_1555_22329_22355(forEachStatementAst), nameof(ParserStrings.ThrottleLimitRequiresParallelFlag), f_1555_22456_22503());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,22107,22520);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,22536,22567);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,21042,22578);

System.Management.Automation.Language.ForEachFlags
f_1555_21207_21232(System.Management.Automation.Language.ForEachStatementAst
this_param)
{
var return_v = this_param.Flags ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 21207, 21232);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_21358_21384(System.Management.Automation.Language.ForEachStatementAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 21358, 21384);
return return_v;
}


string
f_1555_21488_21538()
{
var return_v =                     ParserStrings.KeywordParameterReservedForFutureUse;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 21488, 21538);
return return_v;
}


int
f_1555_21316_21604(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg1,string
arg2)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 21316, 21604);
return 0;
}


System.Management.Automation.Language.ExpressionAst
f_1555_21640_21673(System.Management.Automation.Language.ForEachStatementAst
this_param)
{
var return_v = this_param.ThrottleLimit ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 21640, 21673);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_21757_21783(System.Management.Automation.Language.ForEachStatementAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 21757, 21783);
return return_v;
}


string
f_1555_21887_21937()
{
var return_v =                     ParserStrings.KeywordParameterReservedForFutureUse;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 21887, 21937);
return return_v;
}


int
f_1555_21715_22008(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg1,string
arg2)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 21715, 22008);
return 0;
}


System.Management.Automation.Language.ExpressionAst
f_1555_22112_22145(System.Management.Automation.Language.ForEachStatementAst
this_param)
{
var return_v = this_param.ThrottleLimit ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 22112, 22145);
return return_v;
}


System.Management.Automation.Language.ForEachFlags
f_1555_22177_22202(System.Management.Automation.Language.ForEachStatementAst
this_param)
{
var return_v = this_param.Flags ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 22177, 22202);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_22329_22355(System.Management.Automation.Language.ForEachStatementAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 22329, 22355);
return return_v;
}


string
f_1555_22456_22503()
{
var return_v =                     ParserStrings.ThrottleLimitRequiresParallelFlag;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 22456, 22503);
return return_v;
}


int
f_1555_22287_22504(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 22287, 22504);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,21042,22578);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,21042,22578);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTryStatement(TryStatementAst tryStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,22590,24860);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,22696,22772) || true) && (f_1555_22700_22734(f_1555_22700_22728(tryStatementAst))<= 1)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,22696,22772);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,22741,22772);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,22696,22772);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,22797,22802);

            for (int 
i = 0
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,22788,24802) || true) && (i < f_1555_22808_22842(f_1555_22808_22836(tryStatementAst))- 1)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,22848,22851)
,++i,DynAbs.Tracing.TraceSender.TraceExitCondition(1555,22788,24802))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,22788,24802);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,22885,22941);

CatchClauseAst 
block1 = f_1555_22909_22940(f_1555_22909_22937(tryStatementAst), i)
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,22968,22977);
                for (int 
j = i + 1
; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,22959,24787) || true) && (j < f_1555_22983_23017(f_1555_22983_23011(tryStatementAst)))
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,23019,23022)
,++j,DynAbs.Tracing.TraceSender.TraceExitCondition(1555,22959,24787))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,22959,24787);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,23064,23120);

CatchClauseAst 
block2 = f_1555_23088_23119(f_1555_23088_23116(tryStatementAst), j)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,23144,23452) || true) && (f_1555_23148_23165(block1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,23144,23452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,23215,23397);

f_1555_23215_23396(                        _parser, f_1555_23235_23263(f_1555_23249_23262(block2)), nameof(ParserStrings.EmptyCatchNotLast), f_1555_23364_23395());
DynAbs.Tracing.TraceSender.TraceBreak(1555,23423,23429);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,23144,23452);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,23476,23508) || true) && (f_1555_23480_23497(block2))
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,23476,23508);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,23499,23508);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,23476,23508);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,23532,24768);
foreach(TypeConstraintAst typeLiteral1 in f_1555_23575_23592_I(f_1555_23575_23592(block1)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,23532,24768);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,23642,23697);

Type 
type1 = f_1555_23655_23696(f_1555_23655_23676(typeLiteral1))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,23826,23883) || true) && (type1 == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,23826,23883);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,23874,23883);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,23826,23883);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,23911,24745);
foreach(TypeConstraintAst typeLiteral2 in f_1555_23954_23971_I(f_1555_23954_23971(block2)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,23911,24745);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,24029,24084);

Type 
type2 = f_1555_24042_24083(f_1555_24042_24063(typeLiteral2))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,24221,24282) || true) && (type2 == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,24221,24282);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,24273,24282);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,24221,24282);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,24314,24718) || true) && (type1 == type2 ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 24318, 24361)||f_1555_24336_24361(type2, type1)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,24314,24718);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,24427,24687);

f_1555_24427_24686(                                _parser, f_1555_24447_24466(typeLiteral2), nameof(ParserStrings.ExceptionTypeAlreadyCaught), f_1555_24592_24632(), f_1555_24671_24685(type2));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,24314,24718);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,23911,24745);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,835);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,835);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1555,23532,24768);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,1237);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,1237);
}}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,1829);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,1829);
}}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,2015);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,2015);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,24818,24849);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,22590,24860);

System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
f_1555_22700_22728(System.Management.Automation.Language.TryStatementAst
this_param)
{
var return_v = this_param.CatchClauses;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 22700, 22728);
return return_v;
}


int
f_1555_22700_22734(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 22700, 22734);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
f_1555_22808_22836(System.Management.Automation.Language.TryStatementAst
this_param)
{
var return_v = this_param.CatchClauses;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 22808, 22836);
return return_v;
}


int
f_1555_22808_22842(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 22808, 22842);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
f_1555_22909_22937(System.Management.Automation.Language.TryStatementAst
this_param)
{
var return_v = this_param.CatchClauses;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 22909, 22937);
return return_v;
}


System.Management.Automation.Language.CatchClauseAst
f_1555_22909_22940(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 22909, 22940);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
f_1555_22983_23011(System.Management.Automation.Language.TryStatementAst
this_param)
{
var return_v = this_param.CatchClauses;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 22983, 23011);
return return_v;
}


int
f_1555_22983_23017(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
this_param)
{
var return_v = this_param.Count;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 22983, 23017);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
f_1555_23088_23116(System.Management.Automation.Language.TryStatementAst
this_param)
{
var return_v = this_param.CatchClauses;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 23088, 23116);
return return_v;
}


System.Management.Automation.Language.CatchClauseAst
f_1555_23088_23119(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 23088, 23119);
return return_v;
}


bool
f_1555_23148_23165(System.Management.Automation.Language.CatchClauseAst
this_param)
{
var return_v = this_param.IsCatchAll;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 23148, 23165);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_23249_23262(System.Management.Automation.Language.CatchClauseAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 23249, 23262);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_23235_23263(System.Management.Automation.Language.IScriptExtent
extent)
{
var return_v = Parser.Before( extent);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 23235, 23263);
return return_v;
}


string
f_1555_23364_23395()
{
var return_v =                             ParserStrings.EmptyCatchNotLast;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 23364, 23395);
return return_v;
}


int
f_1555_23215_23396(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 23215, 23396);
return 0;
}


bool
f_1555_23480_23497(System.Management.Automation.Language.CatchClauseAst
this_param)
{
var return_v = this_param.IsCatchAll;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 23480, 23497);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
f_1555_23575_23592(System.Management.Automation.Language.CatchClauseAst
this_param)
{
var return_v = this_param.CatchTypes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 23575, 23592);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_23655_23676(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 23655, 23676);
return return_v;
}


System.Type
f_1555_23655_23696(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 23655, 23696);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
f_1555_23954_23971(System.Management.Automation.Language.CatchClauseAst
this_param)
{
var return_v = this_param.CatchTypes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 23954, 23971);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_24042_24063(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 24042, 24063);
return return_v;
}


System.Type
f_1555_24042_24083(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 24042, 24083);
return return_v;
}


bool
f_1555_24336_24361(System.Type
this_param,System.Type
c)
{
var return_v = this_param.IsSubclassOf( c);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 24336, 24361);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_24447_24466(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 24447, 24466);
return return_v;
}


string
f_1555_24592_24632()
{
var return_v =                                     ParserStrings.ExceptionTypeAlreadyCaught;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 24592, 24632);
return return_v;
}


string
f_1555_24671_24685(System.Type
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 24671, 24685);
return return_v;
}


int
f_1555_24427_24686(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 24427, 24686);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
f_1555_23954_23971_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 23954, 23971);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
f_1555_23575_23592_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 23575, 23592);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,22590,24860);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,22590,24860);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void CheckLabelExists(StatementAst ast, string label)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,25211,26235);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,25297,25384) || true) && (f_1555_25301_25328(label))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,25297,25384);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,25362,25369);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,25297,25384);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,25400,25411);

Ast 
parent
=default(Ast);
try {            for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,25430,25449)
,parent = f_1555_25439_25449(ast); (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,25425,26224) || true) && (parent != null)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,25467,25489)
,parent = f_1555_25476_25489(parent),DynAbs.Tracing.TraceSender.TraceExitCondition(1555,25425,26224))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,25425,26224);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,25523,25952) || true) && (parent is FunctionDefinitionAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,25523,25952);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,25600,25903) || true) && (f_1555_25604_25617(parent)is FunctionMemberAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,25600,25903);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,25688,25880);

f_1555_25688_25879(                        _parser, f_1555_25708_25718(ast), nameof(ParserStrings.LabelNotFound), f_1555_25815_25842(), label);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,25600,25903);
}
DynAbs.Tracing.TraceSender.TraceBreak(1555,25927,25933);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,25523,25952);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,25972,26010);

var 
loop = parent as LoopStatementAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,26028,26209) || true) && (loop != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,26028,26209);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,26086,26190) || true) && (f_1555_26090_26157(label, f_1555_26130_26140(loop)??(DynAbs.Tracing.TraceSender.Expression_Null<string>(1555, 26130, 26156)??string.Empty)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,26086,26190);
DynAbs.Tracing.TraceSender.TraceBreak(1555,26184,26190);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,26086,26190);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,26028,26209);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,800);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,800);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1555,25211,26235);

bool
f_1555_25301_25328(string
value)
{
var return_v = string.IsNullOrEmpty( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 25301, 25328);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_25439_25449(System.Management.Automation.Language.StatementAst
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 25439, 25449);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_25476_25489(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 25476, 25489);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_25604_25617(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 25604, 25617);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_25708_25718(System.Management.Automation.Language.StatementAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 25708, 25718);
return return_v;
}


string
f_1555_25815_25842()
{
var return_v =                             ParserStrings.LabelNotFound;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 25815, 25842);
return return_v;
}


int
f_1555_25688_25879(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 25688, 25879);
return 0;
}


string
f_1555_26130_26140(System.Management.Automation.Language.LoopStatementAst
this_param)
{
var return_v = this_param.Label ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 26130, 26140);
return return_v;
}


bool
f_1555_26090_26157(string
flowLabel,string
loopLabel)
{
var return_v = LoopFlowException.MatchLoopLabel( flowLabel, loopLabel);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 26090, 26157);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,25211,26235);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,25211,26235);
}
		}

private void CheckForFlowOutOfFinally(Ast ast, string label)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,26641,28448);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,26726,26737);

Ast 
parent
=default(Ast);
try {            for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,26756,26775)
,parent = f_1555_26765_26775(ast); (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,26751,28437) || true) && (parent != null)
; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,26793,26815)
,parent = f_1555_26802_26815(parent),DynAbs.Tracing.TraceSender.TraceExitCondition(1555,26751,28437))

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,26751,28437);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,26849,27324) || true) && (parent is NamedBlockAst ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 26853, 26906)||parent is TrapStatementAst )||(DynAbs.Tracing.TraceSender.Expression_False(1555, 26853, 26934)||parent is ScriptBlockAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,26849,27324);
DynAbs.Tracing.TraceSender.TraceBreak(1555,27299,27305);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,26849,27324);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,27594,27834) || true) && (label != null &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 27598, 27644)&&parent is LabeledStatementAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,27594,27834);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,27686,27815) || true) && (f_1555_27690_27782(label, f_1555_27730_27765(((LabeledStatementAst)parent))??(DynAbs.Tracing.TraceSender.Expression_Null<string>(1555, 27730, 27781)??string.Empty)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,27686,27815);
DynAbs.Tracing.TraceSender.TraceBreak(1555,27809,27815);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,27686,27815);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,27594,27834);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,27854,27898);

var 
stmtBlock = parent as StatementBlockAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,27916,28422) || true) && (stmtBlock != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,27916,28422);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,27979,28037);

var 
tryStatementAst = f_1555_28001_28017(stmtBlock)as TryStatementAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,28059,28403) || true) && (tryStatementAst != null &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 28063, 28126)&&f_1555_28090_28113(tryStatementAst)== stmtBlock))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,28059,28403);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,28176,28348);

f_1555_28176_28347(                        _parser, f_1555_28196_28206(ast), nameof(ParserStrings.ControlLeavingFinally), f_1555_28311_28346());
DynAbs.Tracing.TraceSender.TraceBreak(1555,28374,28380);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,28059,28403);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,27916,28422);
}
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,1687);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,1687);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1555,26641,28448);

System.Management.Automation.Language.Ast
f_1555_26765_26775(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 26765, 26775);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_26802_26815(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 26802, 26815);
return return_v;
}


string
f_1555_27730_27765(System.Management.Automation.Language.LabeledStatementAst
this_param)
{
var return_v = this_param.Label ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 27730, 27765);
return return_v;
}


bool
f_1555_27690_27782(string
flowLabel,string
loopLabel)
{
var return_v = LoopFlowException.MatchLoopLabel( flowLabel, loopLabel);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 27690, 27782);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_28001_28017(System.Management.Automation.Language.StatementBlockAst
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 28001, 28017);
return return_v;
}


System.Management.Automation.Language.StatementBlockAst
f_1555_28090_28113(System.Management.Automation.Language.TryStatementAst
this_param)
{
var return_v = this_param.Finally ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 28090, 28113);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_28196_28206(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 28196, 28206);
return return_v;
}


string
f_1555_28311_28346()
{
var return_v =                             ParserStrings.ControlLeavingFinally;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 28311, 28346);
return return_v;
}


int
f_1555_28176_28347(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 28176, 28347);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,26641,28448);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,26641,28448);
}
		}

private static string GetLabel(ExpressionAst expr)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1555,28460,28896);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,28686,28771) || true) && (expr == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,28686,28771);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,28736,28756);

return string.Empty;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,28686,28771);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,28787,28833);

var 
str = expr as StringConstantExpressionAst
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,28847,28885);

return (DynAbs.Tracing.TraceSender.Conditional_F1(1555, 28854, 28865)||((str != null &&DynAbs.Tracing.TraceSender.Conditional_F2(1555, 28868, 28877))||DynAbs.Tracing.TraceSender.Conditional_F3(1555, 28880, 28884)))?f_1555_28868_28877(str):null;
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1555,28460,28896);

string
f_1555_28868_28877(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Value ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 28868, 28877);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,28460,28896);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,28460,28896);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitBreakStatement(BreakStatementAst breakStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,28908,29249);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,29020,29069);

string 
label = f_1555_29035_29068(f_1555_29044_29067(breakStatementAst))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,29083,29134);

f_1555_29083_29133(this, breakStatementAst, label);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,29148,29191);

f_1555_29148_29190(this, breakStatementAst, label);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,29207,29238);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,28908,29249);

System.Management.Automation.Language.ExpressionAst
f_1555_29044_29067(System.Management.Automation.Language.BreakStatementAst
this_param)
{
var return_v = this_param.Label;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 29044, 29067);
return return_v;
}


string
f_1555_29035_29068(System.Management.Automation.Language.ExpressionAst
expr)
{
var return_v = GetLabel( expr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 29035, 29068);
return return_v;
}


int
f_1555_29083_29133(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.BreakStatementAst
ast,string
label)
{
this_param.CheckForFlowOutOfFinally( (System.Management.Automation.Language.Ast)ast, label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 29083, 29133);
return 0;
}


int
f_1555_29148_29190(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.BreakStatementAst
ast,string
label)
{
this_param.CheckLabelExists( (System.Management.Automation.Language.StatementAst)ast, label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 29148, 29190);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,28908,29249);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,28908,29249);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitContinueStatement(ContinueStatementAst continueStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,29261,29620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,29382,29434);

string 
label = f_1555_29397_29433(f_1555_29406_29432(continueStatementAst))
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,29448,29502);

f_1555_29448_29501(this, continueStatementAst, label);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,29516,29562);

f_1555_29516_29561(this, continueStatementAst, label);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,29578,29609);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,29261,29620);

System.Management.Automation.Language.ExpressionAst
f_1555_29406_29432(System.Management.Automation.Language.ContinueStatementAst
this_param)
{
var return_v = this_param.Label;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 29406, 29432);
return return_v;
}


string
f_1555_29397_29433(System.Management.Automation.Language.ExpressionAst
expr)
{
var return_v = GetLabel( expr);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 29397, 29433);
return return_v;
}


int
f_1555_29448_29501(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ContinueStatementAst
ast,string
label)
{
this_param.CheckForFlowOutOfFinally( (System.Management.Automation.Language.Ast)ast, label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 29448, 29501);
return 0;
}


int
f_1555_29516_29561(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ContinueStatementAst
ast,string
label)
{
this_param.CheckLabelExists( (System.Management.Automation.Language.StatementAst)ast, label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 29516, 29561);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,29261,29620);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,29261,29620);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void CheckForReturnStatement(ReturnStatementAst ast)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,29632,30599);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,29717,29787);

var 
functionMemberAst = f_1555_29741_29765(_memberScopeStack)as FunctionMemberAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,29801,29886) || true) && (functionMemberAst == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,29801,29886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,29864,29871);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,29801,29886);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,29902,30588) || true) && (f_1555_29906_29918(ast)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,29902,30588);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,29960,30221) || true) && (f_1555_29964_30000(functionMemberAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,29960,30221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,30042,30202);

f_1555_30042_30201(                    _parser, f_1555_30062_30072(ast), nameof(ParserStrings.VoidMethodHasReturn), f_1555_30167_30200());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,29960,30221);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,29902,30588);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,29902,30588);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,30287,30573) || true) && (!f_1555_30292_30328(functionMemberAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,30287,30573);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,30370,30554);

f_1555_30370_30553(                    _parser, f_1555_30390_30400(ast), nameof(ParserStrings.NonVoidMethodMissingReturnValue), f_1555_30507_30552());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,30287,30573);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,29902,30588);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,29632,30599);

System.Management.Automation.Language.MemberAst
f_1555_29741_29765(System.Collections.Generic.Stack<System.Management.Automation.Language.MemberAst>
this_param)
{
var return_v = this_param.Peek();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 29741, 29765);
return return_v;
}


System.Management.Automation.Language.PipelineBaseAst
f_1555_29906_29918(System.Management.Automation.Language.ReturnStatementAst
this_param)
{
var return_v = this_param.Pipeline ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 29906, 29918);
return return_v;
}


bool
f_1555_29964_30000(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.IsReturnTypeVoid();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 29964, 30000);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_30062_30072(System.Management.Automation.Language.ReturnStatementAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 30062, 30072);
return return_v;
}


string
f_1555_30167_30200()
{
var return_v =                         ParserStrings.VoidMethodHasReturn;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 30167, 30200);
return return_v;
}


int
f_1555_30042_30201(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 30042, 30201);
return 0;
}


bool
f_1555_30292_30328(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.IsReturnTypeVoid();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 30292, 30328);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_30390_30400(System.Management.Automation.Language.ReturnStatementAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 30390, 30400);
return return_v;
}


string
f_1555_30507_30552()
{
var return_v =                         ParserStrings.NonVoidMethodMissingReturnValue;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 30507, 30552);
return return_v;
}


int
f_1555_30370_30553(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 30370, 30553);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,29632,30599);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,29632,30599);
}
		}

public override AstVisitAction VisitReturnStatement(ReturnStatementAst returnStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,30611,30891);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,30726,30777);

f_1555_30726_30776(this, returnStatementAst, null);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,30791,30835);

f_1555_30791_30834(this, returnStatementAst);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,30849,30880);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,30611,30891);

int
f_1555_30726_30776(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ReturnStatementAst
ast,string
label)
{
this_param.CheckForFlowOutOfFinally( (System.Management.Automation.Language.Ast)ast, label);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 30726, 30776);
return 0;
}


int
f_1555_30791_30834(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ReturnStatementAst
ast)
{
this_param.CheckForReturnStatement( ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 30791, 30834);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,30611,30891);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,30611,30891);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void CheckAssignmentTarget(ExpressionAst ast, bool simpleAssignment, Action<Ast> reportError)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,31345,36753);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,31471,31528);

ArrayLiteralAst 
arrayLiteralAst = ast as ArrayLiteralAst
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,31542,31562);

Ast 
errorAst = null
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,31576,36635) || true) && (arrayLiteralAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,31576,36635);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,31637,31885) || true) && (simpleAssignment)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,31637,31885);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,31699,31757);

f_1555_31699_31756(this, arrayLiteralAst, reportError);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,31637,31885);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,31637,31885);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,31839,31866);

errorAst = arrayLiteralAst;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,31637,31885);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,31576,36635);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,31576,36635);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,31951,32017);

ParenExpressionAst 
parenExpressionAst = ast as ParenExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,32035,36620) || true) && (parenExpressionAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,32035,36620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,32107,32176);

ExpressionAst 
expr = f_1555_32128_32175(f_1555_32128_32155(parenExpressionAst))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,32198,32483) || true) && (expr == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,32198,32483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,32264,32303);

errorAst = f_1555_32275_32302(parenExpressionAst);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,32198,32483);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,32198,32483);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,32401,32460);

f_1555_32401_32459(this, expr, simpleAssignment, reportError);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,32198,32483);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,32035,36620);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,32035,36620);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,32525,36620) || true) && (!(ast is ISupportsAssignment))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,32525,36620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,32600,32615);

errorAst = ast;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,32525,36620);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,32525,36620);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,32657,36620) || true) && (ast is MemberExpressionAst memberExprAst &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 32661, 32734)&&f_1555_32705_32734(memberExprAst)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,32657,36620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,32776,32791);

errorAst = ast;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,32657,36620);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,32657,36620);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,32833,36620) || true) && (ast is IndexExpressionAst indexExprAst &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 32837, 32907)&&f_1555_32879_32907(indexExprAst)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,32833,36620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,32949,32964);

errorAst = ast;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,32833,36620);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,32833,36620);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,33006,36620) || true) && (ast is AttributedExpressionAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,33006,36620);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,33152,33177);

ExpressionAst 
expr = ast
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,33199,33216);

int 
converts = 0
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,33238,33273);

IScriptExtent 
errorPosition = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,33295,33323);

Type 
lastConvertType = null
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,33345,34409) || true) && (expr is AttributedExpressionAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,33345,34409);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,33433,33480);

var 
convertExpr = expr as ConvertExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,33506,34313) || true) && (convertExpr != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,33506,34313);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,33587,33601);

converts += 1;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,33631,33695);

lastConvertType = f_1555_33649_33694(f_1555_33649_33674(f_1555_33649_33665(convertExpr)));

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,33725,34286) || true) && (typeof(PSReference) == lastConvertType)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,33725,34286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,33833,33873);

errorPosition = f_1555_33849_33872(f_1555_33849_33865(convertExpr));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,33725,34286);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,33725,34286);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,33939,34286) || true) && (typeof(void) == lastConvertType)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,33939,34286);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,34040,34255);

f_1555_34040_34254(                                _parser, f_1555_34060_34083(f_1555_34060_34076(convertExpr)), nameof(ParserStrings.VoidTypeConstraintNotAllowed), f_1555_34211_34253());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,33939,34286);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,33725,34286);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,33506,34313);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,34341,34386);

expr = f_1555_34348_34385(((AttributedExpressionAst)expr));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,33345,34409);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,33345,34409);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,33345,34409);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,34433,36601) || true) && ((errorPosition != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 34437, 34476)&&converts > 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,34433,36601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,34526,34743);

f_1555_34526_34742(                        _parser, errorPosition, nameof(ParserStrings.ReferenceNeedsToBeByItselfInTypeConstraint), f_1555_34685_34741());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,34433,36601);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,34433,36601);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,34841,34888);

var 
varExprAst = expr as VariableExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,34914,36491) || true) && (varExprAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,34914,36491);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,34994,35032);

var 
varPath = f_1555_35008_35031(varExprAst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,35062,36464) || true) && (f_1555_35066_35084(varPath)&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 35066, 35108)&&f_1555_35088_35108(varPath)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,35062,36464);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,35174,35195);

var 
specialIndex = 0
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,35229,36433) || true) && (specialIndex < (int)AutomaticVariable.NumberOfAutomaticVariables)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,35229,36433);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,35374,36340) || true) && (f_1555_35378_35495(f_1555_35378_35401(varPath), SpecialVariables.AutomaticVariables[specialIndex], StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,35374,36340);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,35577,35650);

var 
expectedType = SpecialVariables.AutomaticVariableTypes[specialIndex]
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,35692,36251) || true) && (expectedType != lastConvertType)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,35692,36251);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,35817,36208);

f_1555_35817_36207(                                            _parser, f_1555_35837_35847(ast), nameof(ParserStrings.AssignmentStatementToAutomaticNotSupported), f_1555_36013_36069(), f_1555_36120_36143(varPath), expectedType);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,35692,36251);
}
DynAbs.Tracing.TraceSender.TraceBreak(1555,36295,36301);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,35374,36340);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,36380,36398);

specialIndex += 1;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,35229,36433);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,35229,36433);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,35229,36433);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1555,35062,36464);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,34914,36491);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,36519,36578);

f_1555_36519_36577(this, expr, simpleAssignment, reportError);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,34433,36601);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,33006,36620);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,32833,36620);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,32657,36620);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,32525,36620);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,32035,36620);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,31576,36635);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,36651,36742) || true) && (errorAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,36651,36742);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,36705,36727);

f_1555_36705_36726(reportError, errorAst);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,36651,36742);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,31345,36753);

int
f_1555_31699_31756(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ArrayLiteralAst
ast,System.Action<System.Management.Automation.Language.Ast>
reportError)
{
this_param.CheckArrayLiteralAssignment( ast, reportError);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 31699, 31756);
return 0;
}


System.Management.Automation.Language.PipelineBaseAst
f_1555_32128_32155(System.Management.Automation.Language.ParenExpressionAst
this_param)
{
var return_v = this_param.Pipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 32128, 32155);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_32128_32175(System.Management.Automation.Language.PipelineBaseAst
this_param)
{
var return_v = this_param.GetPureExpression();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 32128, 32175);
return return_v;
}


System.Management.Automation.Language.PipelineBaseAst
f_1555_32275_32302(System.Management.Automation.Language.ParenExpressionAst
this_param)
{
var return_v = this_param.Pipeline;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 32275, 32302);
return return_v;
}


int
f_1555_32401_32459(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ExpressionAst
ast,bool
simpleAssignment,System.Action<System.Management.Automation.Language.Ast>
reportError)
{
this_param.CheckAssignmentTarget( ast, simpleAssignment, reportError);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 32401, 32459);
return 0;
}


bool
f_1555_32705_32734(System.Management.Automation.Language.MemberExpressionAst
this_param)
{
var return_v = this_param.NullConditional;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 32705, 32734);
return return_v;
}


bool
f_1555_32879_32907(System.Management.Automation.Language.IndexExpressionAst
this_param)
{
var return_v = this_param.NullConditional;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 32879, 32907);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_33649_33665(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 33649, 33665);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_33649_33674(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 33649, 33674);
return return_v;
}


System.Type
f_1555_33649_33694(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 33649, 33694);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_33849_33865(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 33849, 33865);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_33849_33872(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 33849, 33872);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_34060_34076(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 34060, 34076);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_34060_34083(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 34060, 34083);
return return_v;
}


string
f_1555_34211_34253()
{
var return_v =                                     ParserStrings.VoidTypeConstraintNotAllowed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 34211, 34253);
return return_v;
}


int
f_1555_34040_34254(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 34040, 34254);
return 0;
}


System.Management.Automation.Language.ExpressionAst
f_1555_34348_34385(System.Management.Automation.Language.AttributedExpressionAst
this_param)
{
var return_v = this_param.Child;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 34348, 34385);
return return_v;
}


string
f_1555_34685_34741()
{
var return_v =                             ParserStrings.ReferenceNeedsToBeByItselfInTypeConstraint;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 34685, 34741);
return return_v;
}


int
f_1555_34526_34742(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 34526, 34742);
return 0;
}


System.Management.Automation.VariablePath
f_1555_35008_35031(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 35008, 35031);
return return_v;
}


bool
f_1555_35066_35084(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.IsVariable ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 35066, 35084);
return return_v;
}


bool
f_1555_35088_35108(System.Management.Automation.VariablePath
variablePath)
{
var return_v = variablePath.IsAnyLocal();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 35088, 35108);
return return_v;
}


string
f_1555_35378_35401(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UnqualifiedPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 35378, 35401);
return return_v;
}


bool
f_1555_35378_35495(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 35378, 35495);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_35837_35847(System.Management.Automation.Language.ExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 35837, 35847);
return return_v;
}


string
f_1555_36013_36069()
{
var return_v =                                                 ParserStrings.AssignmentStatementToAutomaticNotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 36013, 36069);
return return_v;
}


string
f_1555_36120_36143(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UnqualifiedPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 36120, 36143);
return return_v;
}


int
f_1555_35817_36207(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg1,System.Type
arg2)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 35817, 36207);
return 0;
}


int
f_1555_36519_36577(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ExpressionAst
ast,bool
simpleAssignment,System.Action<System.Management.Automation.Language.Ast>
reportError)
{
this_param.CheckAssignmentTarget( ast, simpleAssignment, reportError);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 36519, 36577);
return 0;
}


int
f_1555_36705_36726(System.Action<System.Management.Automation.Language.Ast>
this_param,System.Management.Automation.Language.Ast
obj)
{
this_param.Invoke( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 36705, 36726);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,31345,36753);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,31345,36753);
}
		}

private void CheckArrayLiteralAssignment(ArrayLiteralAst ast, Action<Ast> reportError)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,36765,37084);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,36876,36924);

f_1555_36876_36923();
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,36938,37073);
foreach(var element in f_1555_36962_36974_I(f_1555_36962_36974(ast)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,36938,37073);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,37008,37058);

f_1555_37008_37057(this, element, true, reportError);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,36938,37073);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,136);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,136);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1555,36765,37084);

int
f_1555_36876_36923()
{
RuntimeHelpers.EnsureSufficientExecutionStack();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 36876, 36923);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1555_36962_36974(System.Management.Automation.Language.ArrayLiteralAst
this_param)
{
var return_v = this_param.Elements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 36962, 36974);
return return_v;
}


int
f_1555_37008_37057(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ExpressionAst
ast,bool
simpleAssignment,System.Action<System.Management.Automation.Language.Ast>
reportError)
{
this_param.CheckAssignmentTarget( ast, simpleAssignment, reportError);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 37008, 37057);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1555_36962_36974_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 36962, 36974);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,36765,37084);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,36765,37084);
}
		}

public override AstVisitAction VisitAssignmentStatement(AssignmentStatementAst assignmentStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,37096,37630);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,37291,37572);

f_1555_37291_37571(this, f_1555_37313_37340(assignmentStatementAst), f_1555_37342_37373(assignmentStatementAst)== TokenKind.Equals, ast => _parser.ReportError(ast.Extent,
                    nameof(ParserStrings.InvalidLeftHandSide),
                    ParserStrings.InvalidLeftHandSide));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,37588,37619);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,37096,37630);

System.Management.Automation.Language.ExpressionAst
f_1555_37313_37340(System.Management.Automation.Language.AssignmentStatementAst
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 37313, 37340);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1555_37342_37373(System.Management.Automation.Language.AssignmentStatementAst
this_param)
{
var return_v = this_param.Operator ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 37342, 37373);
return return_v;
}


int
f_1555_37291_37571(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ExpressionAst
ast,bool
simpleAssignment,System.Action<System.Management.Automation.Language.Ast>
reportError)
{
this_param.CheckAssignmentTarget( ast, simpleAssignment, reportError);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 37291, 37571);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,37096,37630);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,37096,37630);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitBinaryExpression(BinaryExpressionAst binaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,37642,38213);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,37760,38155) || true) && (f_1555_37764_37792(binaryExpressionAst)== TokenKind.AndAnd
||(DynAbs.Tracing.TraceSender.Expression_False(1555, 37764, 37879)||f_1555_37833_37861(binaryExpressionAst)== TokenKind.OrOr))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,37760,38155);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,37913,38140);

f_1555_37913_38139(                _parser, f_1555_37933_37966(binaryExpressionAst), nameof(ParserStrings.InvalidEndOfLine), f_1555_38050_38080(), f_1555_38103_38138(f_1555_38103_38131(binaryExpressionAst)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,37760,38155);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,38171,38202);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,37642,38213);

System.Management.Automation.Language.TokenKind
f_1555_37764_37792(System.Management.Automation.Language.BinaryExpressionAst
this_param)
{
var return_v = this_param.Operator ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 37764, 37792);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1555_37833_37861(System.Management.Automation.Language.BinaryExpressionAst
this_param)
{
var return_v = this_param.Operator ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 37833, 37861);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_37933_37966(System.Management.Automation.Language.BinaryExpressionAst
this_param)
{
var return_v = this_param.ErrorPosition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 37933, 37966);
return return_v;
}


string
f_1555_38050_38080()
{
var return_v =                     ParserStrings.InvalidEndOfLine;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 38050, 38080);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1555_38103_38131(System.Management.Automation.Language.BinaryExpressionAst
this_param)
{
var return_v = this_param.Operator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 38103, 38131);
return return_v;
}


string
f_1555_38103_38138(System.Management.Automation.Language.TokenKind
kind)
{
var return_v = kind.Text();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 38103, 38138);
return return_v;
}


int
f_1555_37913_38139(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 37913, 38139);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,37642,38213);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,37642,38213);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitUnaryExpression(UnaryExpressionAst unaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,38225,39053);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,38340,38995);

switch (f_1555_38348_38376(unaryExpressionAst))
            {

case TokenKind.PlusPlus:
                case TokenKind.PostfixPlusPlus:
                case TokenKind.MinusMinus:
                case TokenKind.PostfixMinusMinus:
DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,38340,38995);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,38600,38952);

f_1555_38600_38951(this, f_1555_38622_38646(unaryExpressionAst), false, ast => _parser.ReportError(ast.Extent,
                            nameof(ParserStrings.OperatorRequiresVariableOrProperty),
                            ParserStrings.OperatorRequiresVariableOrProperty,
                            unaryExpressionAst.TokenKind.Text()));
DynAbs.Tracing.TraceSender.TraceBreak(1555,38974,38980);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,38340,38995);
            }
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,39011,39042);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,38225,39053);

System.Management.Automation.Language.TokenKind
f_1555_38348_38376(System.Management.Automation.Language.UnaryExpressionAst
this_param)
{
var return_v = this_param.TokenKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 38348, 38376);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_38622_38646(System.Management.Automation.Language.UnaryExpressionAst
this_param)
{
var return_v = this_param.Child;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 38622, 38646);
return return_v;
}


int
f_1555_38600_38951(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ExpressionAst
ast,bool
simpleAssignment,System.Action<System.Management.Automation.Language.Ast>
reportError)
{
this_param.CheckAssignmentTarget( ast, simpleAssignment, reportError);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 38600, 38951);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,38225,39053);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,38225,39053);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitConvertExpression(ConvertExpressionAst convertExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,39065,43562);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,39186,39944) || true) && (f_1555_39190_39313(f_1555_39190_39233(f_1555_39190_39224(f_1555_39190_39215(convertExpressionAst))), LanguagePrimitives.OrderedAttribute, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,39186,39944);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,39347,39929) || true) && (!(f_1555_39353_39379(convertExpressionAst)is HashtableAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,39347,39929);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,39627,39910);

f_1555_39627_39909(                    // We allow the ordered attribute only on hashliteral node.
                    // This check covers the following scenario
                    //   $a = [ordered]10
                    _parser, f_1555_39647_39674(convertExpressionAst), nameof(ParserStrings.OrderedAttributeOnlyOnHashLiteralNode), f_1555_39787_39838(), f_1555_39865_39908(f_1555_39865_39899(f_1555_39865_39890(convertExpressionAst))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,39347,39929);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,39186,39944);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,39960,43267) || true) && (typeof(PSReference) == f_1555_39987_40041(f_1555_39987_40021(f_1555_39987_40012(convertExpressionAst))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,39960,43267);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,40116,40165);

ExpressionAst 
child = f_1555_40138_40164(convertExpressionAst)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,40183,40209);

bool 
multipleRefs = false
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,40227,41172) || true) && (true)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,40227,41172);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,40280,40333);

var 
childAttrExpr = child as AttributedExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,40355,41123) || true) && (childAttrExpr != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,40355,41123);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,40430,40487);

var 
childConvert = childAttrExpr as ConvertExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,40513,41009) || true) && (childConvert != null &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 40517, 40610)&&typeof(PSReference) == f_1555_40564_40610(f_1555_40564_40590(f_1555_40564_40581(childConvert)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,40513,41009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,40668,40688);

multipleRefs = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,40718,40982);

f_1555_40718_40981(                            _parser, f_1555_40738_40762(f_1555_40738_40755(childConvert)), nameof(ParserStrings.ReferenceNeedsToBeByItselfInTypeSequence), f_1555_40926_40980());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,40513,41009);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,41037,41065);

child = f_1555_41045_41064(childAttrExpr);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,41091,41100);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,40355,41123);
}
DynAbs.Tracing.TraceSender.TraceBreak(1555,41147,41153);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,40227,41172);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,40227,41172);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,40227,41172);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,41279,41347);

var 
parent = f_1555_41292_41319(convertExpressionAst)as AttributedExpressionAst
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,41365,43252) || true) && (parent != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,41365,43252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,41428,41479);

var 
parentConvert = parent as ConvertExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,41501,43160) || true) && (parentConvert != null &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 41505, 41543)&&!multipleRefs))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,41501,43160);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,41593,41758) || true) && (typeof(PSReference) == f_1555_41620_41667(f_1555_41620_41647(f_1555_41620_41638(parentConvert))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,41593,41758);
DynAbs.Tracing.TraceSender.TraceBreak(1555,41725,41731);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,41593,41758);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,41964,41988);

var 
ast = f_1555_41974_41987(parent)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,42014,42037);

bool 
skipError = false
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,42063,42734) || true) && (ast != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,42063,42734);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,42139,42188);

var 
statementAst = ast as AssignmentStatementAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,42218,42492) || true) && (statementAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,42218,42492);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,42308,42421);

skipError = f_1555_42320_42412(f_1555_42320_42337(statementAst), ast1 => ast1 == convertExpressionAst, searchNestedScriptBlocks: true)!= null;
DynAbs.Tracing.TraceSender.TraceBreak(1555,42455,42461);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,42218,42492);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,42524,42658) || true) && (ast is CommandExpressionAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,42524,42658);
DynAbs.Tracing.TraceSender.TraceBreak(1555,42621,42627);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,42524,42658);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,42690,42707);

ast = f_1555_42696_42706(ast);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,42063,42734);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,42063,42734);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,42063,42734);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,42762,43137) || true) && (!skipError)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,42762,43137);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,42834,43110);

f_1555_42834_43109(                            _parser, f_1555_42854_42886(f_1555_42854_42879(convertExpressionAst)), nameof(ParserStrings.ReferenceNeedsToBeLastTypeInTypeConversion), f_1555_43052_43108());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,42762,43137);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,41501,43160);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,43184,43233);

parent = f_1555_43193_43205(parent)as AttributedExpressionAst;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,41365,43252);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,41365,43252);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,41365,43252);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1555,39960,43267);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,43332,43504) || true) && (typeof(Type) == f_1555_43352_43406(f_1555_43352_43386(f_1555_43352_43377(convertExpressionAst))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,43332,43504);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,43440,43489);

f_1555_43440_43488(this, convertExpressionAst);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,43332,43504);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,43520,43551);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,39065,43562);

System.Management.Automation.Language.TypeConstraintAst
f_1555_39190_39215(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 39190, 39215);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_39190_39224(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 39190, 39224);
return return_v;
}


string
f_1555_39190_39233(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 39190, 39233);
return return_v;
}


bool
f_1555_39190_39313(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 39190, 39313);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_39353_39379(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Child ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 39353, 39379);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_39647_39674(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 39647, 39674);
return return_v;
}


string
f_1555_39787_39838()
{
var return_v =                         ParserStrings.OrderedAttributeOnlyOnHashLiteralNode;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 39787, 39838);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_39865_39890(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 39865, 39890);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_39865_39899(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 39865, 39899);
return return_v;
}


string
f_1555_39865_39908(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 39865, 39908);
return return_v;
}


int
f_1555_39627_39909(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 39627, 39909);
return 0;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_39987_40012(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 39987, 40012);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_39987_40021(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 39987, 40021);
return return_v;
}


System.Type
f_1555_39987_40041(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 39987, 40041);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_40138_40164(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Child;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 40138, 40164);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_40564_40581(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 40564, 40581);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_40564_40590(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 40564, 40590);
return return_v;
}


System.Type
f_1555_40564_40610(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 40564, 40610);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_40738_40755(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 40738, 40755);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_40738_40762(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 40738, 40762);
return return_v;
}


string
f_1555_40926_40980()
{
var return_v =                                                 ParserStrings.ReferenceNeedsToBeByItselfInTypeSequence;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 40926, 40980);
return return_v;
}


int
f_1555_40718_40981(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 40718, 40981);
return 0;
}


System.Management.Automation.Language.ExpressionAst
f_1555_41045_41064(System.Management.Automation.Language.AttributedExpressionAst
this_param)
{
var return_v = this_param.Child;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 41045, 41064);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_41292_41319(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 41292, 41319);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_41620_41638(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 41620, 41638);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_41620_41647(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 41620, 41647);
return return_v;
}


System.Type
f_1555_41620_41667(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 41620, 41667);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_41974_41987(System.Management.Automation.Language.AttributedExpressionAst
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 41974, 41987);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_42320_42337(System.Management.Automation.Language.AssignmentStatementAst
this_param)
{
var return_v = this_param.Left;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 42320, 42337);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_42320_42412(System.Management.Automation.Language.ExpressionAst
this_param,System.Func<System.Management.Automation.Language.Ast, bool>
predicate,bool
searchNestedScriptBlocks)
{
var return_v = this_param.Find( predicate, searchNestedScriptBlocks: searchNestedScriptBlocks);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 42320, 42412);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_42696_42706(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 42696, 42706);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_42854_42879(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 42854, 42879);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_42854_42886(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 42854, 42886);
return return_v;
}


string
f_1555_43052_43108()
{
var return_v =                                                 ParserStrings.ReferenceNeedsToBeLastTypeInTypeConversion;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 43052, 43108);
return return_v;
}


int
f_1555_42834_43109(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 42834, 43109);
return 0;
}


System.Management.Automation.Language.ExpressionAst
f_1555_43193_43205(System.Management.Automation.Language.AttributedExpressionAst
this_param)
{
var return_v = this_param.Child ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 43193, 43205);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_43352_43377(System.Management.Automation.Language.ConvertExpressionAst
this_param)
{
var return_v = this_param.Type;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 43352, 43377);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_43352_43386(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 43352, 43386);
return return_v;
}


System.Type
f_1555_43352_43406(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 43352, 43406);
return return_v;
}


int
f_1555_43440_43488(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ConvertExpressionAst
ast)
{
this_param.MarkAstParentsAsSuspicious( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 43440, 43488);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,39065,43562);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,39065,43562);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitUsingExpression(UsingExpressionAst usingExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,43574,44332);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,43925,43972);

var 
exprAst = f_1555_43939_43971(usingExpressionAst)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,43986,44030);

var 
badExpr = f_1555_44000_44029(this, exprAst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,44044,44274) || true) && (badExpr != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,44044,44274);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,44097,44259);

f_1555_44097_44258(                _parser, f_1555_44117_44131(badExpr), nameof(ParserStrings.InvalidUsingExpression), f_1555_44221_44257());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,44044,44274);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,44290,44321);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,43574,44332);

System.Management.Automation.Language.ExpressionAst
f_1555_43939_43971(System.Management.Automation.Language.UsingExpressionAst
this_param)
{
var return_v = this_param.SubExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 43939, 43971);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_44000_44029(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ExpressionAst
exprAst)
{
var return_v = this_param.CheckUsingExpression( exprAst);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 44000, 44029);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_44117_44131(System.Management.Automation.Language.ExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 44117, 44131);
return return_v;
}


string
f_1555_44221_44257()
{
var return_v =                     ParserStrings.InvalidUsingExpression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 44221, 44257);
return return_v;
}


int
f_1555_44097_44258(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 44097, 44258);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,43574,44332);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,43574,44332);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private ExpressionAst CheckUsingExpression(ExpressionAst exprAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,44344,45310);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,44434,44482);

f_1555_44434_44481();

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,44496,44593) || true) && (exprAst is VariableExpressionAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,44496,44593);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,44566,44578);

return null;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,44496,44593);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,44609,44657);

var 
memberExpr = exprAst as MemberExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,44671,44893) || true) && (memberExpr != null &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 44675, 44739)&&!(memberExpr is InvokeMemberExpressionAst) )&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 44675, 44793)&&(f_1555_44744_44761(memberExpr)is StringConstantExpressionAst)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,44671,44893);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,44827,44878);

return f_1555_44834_44877(this, f_1555_44855_44876(memberExpr));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,44671,44893);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,44909,44955);

var 
indexExpr = exprAst as IndexExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,44969,45268) || true) && (indexExpr != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,44969,45268);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,45024,45187) || true) && (!f_1555_45029_45103(this, f_1555_45054_45069(indexExpr), s_isConstantAttributeArgVisitor))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,45024,45187);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,45145,45168);

return f_1555_45152_45167(indexExpr);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,45024,45187);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,45207,45253);

return f_1555_45214_45252(this, f_1555_45235_45251(indexExpr));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,44969,45268);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,45284,45299);

return exprAst;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,44344,45310);

int
f_1555_44434_44481()
{
RuntimeHelpers.EnsureSufficientExecutionStack();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 44434, 44481);
return 0;
}


System.Management.Automation.Language.CommandElementAst
f_1555_44744_44761(System.Management.Automation.Language.MemberExpressionAst
this_param)
{
var return_v = this_param.Member ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 44744, 44761);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_44855_44876(System.Management.Automation.Language.MemberExpressionAst
this_param)
{
var return_v = this_param.Expression;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 44855, 44876);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_44834_44877(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ExpressionAst
exprAst)
{
var return_v = this_param.CheckUsingExpression( exprAst);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 44834, 44877);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_45054_45069(System.Management.Automation.Language.IndexExpressionAst
this_param)
{
var return_v = this_param.Index;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 45054, 45069);
return return_v;
}


bool
f_1555_45029_45103(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ExpressionAst
ast,System.Management.Automation.Language.IsConstantValueVisitor
visitor)
{
var return_v = this_param.IsValidAttributeArgument( (System.Management.Automation.Language.Ast)ast, visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 45029, 45103);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_45152_45167(System.Management.Automation.Language.IndexExpressionAst
this_param)
{
var return_v = this_param.Index;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 45152, 45167);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_45235_45251(System.Management.Automation.Language.IndexExpressionAst
this_param)
{
var return_v = this_param.Target;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 45235, 45251);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_45214_45252(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.ExpressionAst
exprAst)
{
var return_v = this_param.CheckUsingExpression( exprAst);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 45214, 45252);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,44344,45310);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,44344,45310);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitVariableExpression(VariableExpressionAst variableExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,45322,47816);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,45446,46414) || true) && (f_1555_45450_45480(variableExpressionAst)&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 45450, 45529)&&!(f_1555_45486_45514(variableExpressionAst)is CommandAst) )&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 45450, 45586)&&!(f_1555_45535_45563(variableExpressionAst)is UsingExpressionAst)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,45446,46414);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,45620,46399) || true) && (f_1555_45624_45652(variableExpressionAst)is ArrayLiteralAst &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 45624, 45724)&&f_1555_45675_45710(f_1555_45675_45703(variableExpressionAst))is CommandAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,45620,46399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,45766,46046);

f_1555_45766_46045(                    _parser, f_1555_45786_45814(variableExpressionAst), nameof(ParserStrings.SplattingNotPermittedInArgumentList), f_1555_45925_45974(), f_1555_46001_46044(f_1555_46001_46035(variableExpressionAst)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,45620,46399);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,45620,46399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,46128,46380);

f_1555_46128_46379(                    _parser, f_1555_46148_46176(variableExpressionAst), nameof(ParserStrings.SplattingNotPermitted), f_1555_46273_46308(), f_1555_46335_46378(f_1555_46335_46369(variableExpressionAst)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,45620,46399);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,45446,46414);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,46430,47212) || true) && (f_1555_46434_46479(f_1555_46434_46468(variableExpressionAst)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,46430,47212);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,46513,47197) || true) && (f_1555_46517_46549(variableExpressionAst)== VariableAnalysis.ForceDynamic
&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 46517, 46638)&&f_1555_46607_46638_M(!variableExpressionAst.Assigned))&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 46517, 46707)&&f_1555_46663_46707_M(!f_1555_46664_46698(variableExpressionAst).IsGlobal))&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 46517, 46776)&&f_1555_46732_46776_M(!f_1555_46733_46767(variableExpressionAst).IsScript))&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 46517, 46844)&&!f_1555_46802_46844(variableExpressionAst))&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 46517, 46964)&&!f_1555_46870_46964(f_1555_46929_46963(variableExpressionAst))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,46513,47197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,47006,47178);

f_1555_47006_47177(                    _parser, f_1555_47026_47054(variableExpressionAst), nameof(ParserStrings.VariableNotLocal), f_1555_47146_47176());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,46513,47197);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,46430,47212);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,47228,47758) || true) && (f_1555_47232_47341(f_1555_47232_47275(f_1555_47232_47266(variableExpressionAst)), SpecialVariables.This, StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,47228,47758);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,47375,47743) || true) && (f_1555_47379_47402(this))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,47375,47743);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,47444,47724);

f_1555_47444_47723(                    _parser, f_1555_47464_47492(variableExpressionAst), nameof(ParserStrings.NonStaticMemberAccessInStaticMember), f_1555_47603_47652(), f_1555_47679_47722(f_1555_47679_47713(variableExpressionAst)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,47375,47743);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,47228,47758);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,47774,47805);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,45322,47816);

bool
f_1555_45450_45480(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.Splatted ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 45450, 45480);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_45486_45514(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 45486, 45514);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_45535_45563(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 45535, 45563);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_45624_45652(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 45624, 45652);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_45675_45703(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 45675, 45703);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_45675_45710(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 45675, 45710);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_45786_45814(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 45786, 45814);
return return_v;
}


string
f_1555_45925_45974()
{
var return_v =                         ParserStrings.SplattingNotPermittedInArgumentList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 45925, 45974);
return return_v;
}


System.Management.Automation.VariablePath
f_1555_46001_46035(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46001, 46035);
return return_v;
}


string
f_1555_46001_46044(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UserPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46001, 46044);
return return_v;
}


int
f_1555_45766_46045(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 45766, 46045);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1555_46148_46176(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46148, 46176);
return return_v;
}


string
f_1555_46273_46308()
{
var return_v =                         ParserStrings.SplattingNotPermitted;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46273, 46308);
return return_v;
}


System.Management.Automation.VariablePath
f_1555_46335_46369(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46335, 46369);
return return_v;
}


string
f_1555_46335_46378(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UserPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46335, 46378);
return return_v;
}


int
f_1555_46128_46379(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 46128, 46379);
return 0;
}


System.Management.Automation.VariablePath
f_1555_46434_46468(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46434, 46468);
return return_v;
}


bool
f_1555_46434_46479(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.IsVariable;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46434, 46479);
return return_v;
}


int
f_1555_46517_46549(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.TupleIndex ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46517, 46549);
return return_v;
}


bool
f_1555_46607_46638_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46607, 46638);
return return_v;
}


System.Management.Automation.VariablePath
f_1555_46664_46698(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46664, 46698);
return return_v;
}


bool
f_1555_46663_46707_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46663, 46707);
return return_v;
}


System.Management.Automation.VariablePath
f_1555_46733_46767(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46733, 46767);
return return_v;
}


bool
f_1555_46732_46776_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46732, 46776);
return return_v;
}


bool
f_1555_46802_46844(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.IsConstantVariable();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 46802, 46844);
return return_v;
}


System.Management.Automation.VariablePath
f_1555_46929_46963(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 46929, 46963);
return return_v;
}


bool
f_1555_46870_46964(System.Management.Automation.VariablePath
variablePath)
{
var return_v = SpecialVariables.IsImplicitVariableAccessibleInClassMethod( variablePath);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 46870, 46964);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_47026_47054(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 47026, 47054);
return return_v;
}


string
f_1555_47146_47176()
{
var return_v =                         ParserStrings.VariableNotLocal;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 47146, 47176);
return return_v;
}


int
f_1555_47006_47177(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 47006, 47177);
return 0;
}


System.Management.Automation.VariablePath
f_1555_47232_47266(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 47232, 47266);
return return_v;
}


string
f_1555_47232_47275(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UserPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 47232, 47275);
return return_v;
}


bool
f_1555_47232_47341(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 47232, 47341);
return return_v;
}


bool
f_1555_47379_47402(System.Management.Automation.Language.SemanticChecks
this_param)
{
var return_v = this_param.AnalyzingStaticMember();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 47379, 47402);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_47464_47492(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 47464, 47492);
return return_v;
}


string
f_1555_47603_47652()
{
var return_v =                         ParserStrings.NonStaticMemberAccessInStaticMember;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 47603, 47652);
return return_v;
}


System.Management.Automation.VariablePath
f_1555_47679_47713(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 47679, 47713);
return return_v;
}


string
f_1555_47679_47722(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UserPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 47679, 47722);
return return_v;
}


int
f_1555_47444_47723(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 47444, 47723);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,45322,47816);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,45322,47816);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitHashtable(HashtableAst hashtableAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,47828,49310);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,47925,48002);

HashSet<string> 
keys = f_1555_47948_48001(f_1555_47968_48000())
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,48016,49252);
foreach(var entry in f_1555_48038_48064_I(f_1555_48038_48064(hashtableAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,48016,49252);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,48098,48151);

var 
keyStrAst = f_1555_48114_48125(entry)as ConstantExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,48169,49237) || true) && (keyStrAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,48169,49237);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,48232,48272);

var 
keyStr = f_1555_48245_48271(f_1555_48245_48260(keyStrAst))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,48294,49218) || true) && (f_1555_48298_48319(keys, keyStr))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,48294,49218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,48369,48384);

string 
errorId
=default(string);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,48410,48426);

string 
errorMsg
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,48452,48985) || true) && (f_1555_48456_48484(hashtableAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,48452,48985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,48542,48612);

errorId = nameof(ParserStrings.DuplicatePropertyInInstanceDefinition);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,48642,48705);

errorMsg = f_1555_48653_48704();
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,48452,48985);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,48452,48985);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,48819,48877);

errorId = nameof(ParserStrings.DuplicateKeyInHashLiteral);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,48907,48958);

errorMsg = f_1555_48918_48957();
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,48452,48985);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,49013,49080);

f_1555_49013_49079(
                        _parser, f_1555_49033_49051(f_1555_49033_49044(entry)), errorId, errorMsg, keyStr);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,48294,49218);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,48294,49218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,49178,49195);

f_1555_49178_49194(                        keys, keyStr);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,48294,49218);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,48169,49237);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,48016,49252);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,1237);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,1237);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,49268,49299);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,47828,49310);

System.StringComparer
f_1555_47968_48000()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 47968, 48000);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1555_47948_48001(System.StringComparer
comparer)
{
var return_v = new System.Collections.Generic.HashSet<string>( (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 47948, 48001);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
f_1555_48038_48064(System.Management.Automation.Language.HashtableAst
this_param)
{
var return_v = this_param.KeyValuePairs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 48038, 48064);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_48114_48125(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
this_param)
{
var return_v = this_param.Item1 ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 48114, 48125);
return return_v;
}


object
f_1555_48245_48260(System.Management.Automation.Language.ConstantExpressionAst
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 48245, 48260);
return return_v;
}


string?
f_1555_48245_48271(object
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 48245, 48271);
return return_v;
}


bool
f_1555_48298_48319(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 48298, 48319);
return return_v;
}


bool
f_1555_48456_48484(System.Management.Automation.Language.HashtableAst
this_param)
{
var return_v = this_param.IsSchemaElement;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 48456, 48484);
return return_v;
}


string
f_1555_48653_48704()
{
var return_v = ParserStrings.DuplicatePropertyInInstanceDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 48653, 48704);
return return_v;
}


string
f_1555_48918_48957()
{
var return_v = ParserStrings.DuplicateKeyInHashLiteral;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 48918, 48957);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_49033_49044(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
this_param)
{
var return_v = this_param.Item1;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 49033, 49044);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_49033_49051(System.Management.Automation.Language.ExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 49033, 49051);
return return_v;
}


int
f_1555_49013_49079(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 49013, 49079);
return 0;
}


bool
f_1555_49178_49194(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Add( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 49178, 49194);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
f_1555_48038_48064_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 48038, 48064);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,47828,49310);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,47828,49310);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitAttributedExpression(AttributedExpressionAst attributedExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,49322,50215);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,49544,49593);

var 
errorAst = f_1555_49559_49592(attributedExpressionAst)
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,49607,49947) || true) && (attributedExpressionAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,49607,49947);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,49679,49829) || true) && (f_1555_49683_49712(attributedExpressionAst)is VariableExpressionAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,49679,49829);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,49779,49810);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,49679,49829);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,49849,49932);

attributedExpressionAst = f_1555_49875_49904(attributedExpressionAst)as AttributedExpressionAst;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,49607,49947);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,49607,49947);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,49607,49947);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,49963,50157);

f_1555_49963_50156(
            _parser, f_1555_49983_49998(errorAst), nameof(ParserStrings.UnexpectedAttribute), f_1555_50077_50110(), f_1555_50129_50155(f_1555_50129_50146(errorAst)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,50173,50204);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,49322,50215);

System.Management.Automation.Language.AttributeBaseAst
f_1555_49559_49592(System.Management.Automation.Language.AttributedExpressionAst
this_param)
{
var return_v = this_param.Attribute;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 49559, 49592);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_49683_49712(System.Management.Automation.Language.AttributedExpressionAst
this_param)
{
var return_v = this_param.Child ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 49683, 49712);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_49875_49904(System.Management.Automation.Language.AttributedExpressionAst
this_param)
{
var return_v = this_param.Child ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 49875, 49904);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_49983_49998(System.Management.Automation.Language.AttributeBaseAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 49983, 49998);
return return_v;
}


string
f_1555_50077_50110()
{
var return_v =                 ParserStrings.UnexpectedAttribute;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 50077, 50110);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_50129_50146(System.Management.Automation.Language.AttributeBaseAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 50129, 50146);
return return_v;
}


string
f_1555_50129_50155(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 50129, 50155);
return return_v;
}


int
f_1555_49963_50156(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 49963, 50156);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,49322,50215);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,49322,50215);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitBlockStatement(BlockStatementAst blockStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,50227,50734);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,50339,50455) || true) && (f_1555_50343_50375(blockStatementAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,50339,50455);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,50409,50440);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,50339,50455);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,50471,50676);

f_1555_50471_50675(
            _parser, f_1555_50491_50520(f_1555_50491_50513(blockStatementAst)), nameof(ParserStrings.UnexpectedKeyword), f_1555_50597_50628(), f_1555_50647_50674(f_1555_50647_50669(blockStatementAst)));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,50692,50723);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,50227,50734);

bool
f_1555_50343_50375(System.Management.Automation.Language.BlockStatementAst
this_param)
{
var return_v = this_param.IsInWorkflow();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 50343, 50375);
return return_v;
}


System.Management.Automation.Language.Token
f_1555_50491_50513(System.Management.Automation.Language.BlockStatementAst
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 50491, 50513);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_50491_50520(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 50491, 50520);
return return_v;
}


string
f_1555_50597_50628()
{
var return_v =                 ParserStrings.UnexpectedKeyword;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 50597, 50628);
return return_v;
}


System.Management.Automation.Language.Token
f_1555_50647_50669(System.Management.Automation.Language.BlockStatementAst
this_param)
{
var return_v = this_param.Kind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 50647, 50669);
return return_v;
}


string
f_1555_50647_50674(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 50647, 50674);
return return_v;
}


int
f_1555_50471_50675(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 50471, 50675);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,50227,50734);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,50227,50734);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitMemberExpression(MemberExpressionAst memberExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,50746,50959);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,50864,50903);

f_1555_50864_50902(this, memberExpressionAst);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,50917,50948);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,50746,50959);

int
f_1555_50864_50902(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.MemberExpressionAst
ast)
{
this_param.CheckMemberAccess( ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 50864, 50902);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,50746,50959);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,50746,50959);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitInvokeMemberExpression(InvokeMemberExpressionAst memberExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,50971,51196);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,51101,51140);

f_1555_51101_51139(this, memberExpressionAst);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,51154,51185);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,50971,51196);

int
f_1555_51101_51139(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.InvokeMemberExpressionAst
ast)
{
this_param.CheckMemberAccess( (System.Management.Automation.Language.MemberExpressionAst)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 51101, 51139);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,50971,51196);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,50971,51196);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void CheckMemberAccess(MemberExpressionAst ast)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,51208,51811);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,51374,51497) || true) && (!(f_1555_51380_51390(ast)is ConstantExpressionAst))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,51374,51497);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,51450,51482);

f_1555_51450_51481(this, ast);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,51374,51497);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,51513,51584);

TypeExpressionAst 
typeExpression = f_1555_51548_51562(ast)as TypeExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,51677,51800) || true) && (f_1555_51681_51691(ast)&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 51681, 51719)&&(typeExpression == null)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,51677,51800);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,51753,51785);

f_1555_51753_51784(this, ast);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,51677,51800);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,51208,51811);

System.Management.Automation.Language.CommandElementAst
f_1555_51380_51390(System.Management.Automation.Language.MemberExpressionAst
this_param)
{
var return_v = this_param.Member ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 51380, 51390);
return return_v;
}


int
f_1555_51450_51481(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.MemberExpressionAst
ast)
{
this_param.MarkAstParentsAsSuspicious( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 51450, 51481);
return 0;
}


System.Management.Automation.Language.ExpressionAst
f_1555_51548_51562(System.Management.Automation.Language.MemberExpressionAst
this_param)
{
var return_v = this_param.Expression ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 51548, 51562);
return return_v;
}


bool
f_1555_51681_51691(System.Management.Automation.Language.MemberExpressionAst
this_param)
{
var return_v = this_param.Static ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 51681, 51691);
return return_v;
}


int
f_1555_51753_51784(System.Management.Automation.Language.SemanticChecks
this_param,System.Management.Automation.Language.MemberExpressionAst
ast)
{
this_param.MarkAstParentsAsSuspicious( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 51753, 51784);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,51208,51811);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,51208,51811);
}
		}

private void MarkAstParentsAsSuspicious(Ast ast)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,51883,52222);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,51956,51976);

Ast 
targetAst = ast
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,51990,52007);

var 
parent = ast
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,52023,52211) || true) && (parent != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,52023,52211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,52078,52097);

targetAst = parent;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,52115,52153);

targetAst.HasSuspiciousContent = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,52173,52196);

parent = f_1555_52182_52195(parent);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,52023,52211);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,52023,52211);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,52023,52211);
}DynAbs.Tracing.TraceSender.TraceExitMethod(1555,51883,52222);

System.Management.Automation.Language.Ast
f_1555_52182_52195(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 52182, 52195);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,51883,52222);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,51883,52222);
}
		}

public override AstVisitAction VisitScriptBlock(ScriptBlockAst scriptBlockAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,52234,52662);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,52337,52370);

f_1555_52337_52369(            _scopeStack, scriptBlockAst);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,52384,52604) || true) && (f_1555_52388_52409(scriptBlockAst)== null ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 52388, 52470)||f_1555_52421_52442(scriptBlockAst)is ScriptBlockExpressionAst )||(DynAbs.Tracing.TraceSender.Expression_False(1555, 52388, 52526)||!(f_1555_52476_52504(f_1555_52476_52497(scriptBlockAst))is FunctionMemberAst)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,52384,52604);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,52560,52589);

f_1555_52560_52588(                _memberScopeStack, null);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,52384,52604);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,52620,52651);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,52234,52662);

int
f_1555_52337_52369(System.Collections.Generic.Stack<System.Management.Automation.Language.ScriptBlockAst>
this_param,System.Management.Automation.Language.ScriptBlockAst
item)
{
this_param.Push( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 52337, 52369);
return 0;
}


System.Management.Automation.Language.Ast
f_1555_52388_52409(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 52388, 52409);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_52421_52442(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 52421, 52442);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_52476_52497(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 52476, 52497);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_52476_52504(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 52476, 52504);
return return_v;
}


int
f_1555_52560_52588(System.Collections.Generic.Stack<System.Management.Automation.Language.MemberAst>
this_param,System.Management.Automation.Language.MemberAst
item)
{
this_param.Push( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 52560, 52588);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,52234,52662);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,52234,52662);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,52674,56660);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,52807,52919);

ConfigurationDefinitionAst 
configAst = f_1555_52846_52918(scriptBlockExpressionAst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,53839,56602) || true) && (configAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,53839,56602);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,53894,53936);

var 
ast = f_1555_53904_53935(scriptBlockExpressionAst)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,54005,54037);

PipelineAst 
statementAst = null
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,54125,54151);

int 
ancestorNodeLevel = 0
;
try {
while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,54262,56587) || true) && ((ast != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 54269, 54310)&&(ancestorNodeLevel <= 2)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,54262,56587);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,54460,54503);

var 
namedBlockedAst = ast as NamedBlockAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,54525,56429) || true) && ((namedBlockedAst != null) &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 54529, 54580)&&(statementAst != null) )&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 54529, 54608)&&(ancestorNodeLevel == 2)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,54525,56429);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,54658,54719);

int 
index = f_1555_54670_54718(f_1555_54670_54696(namedBlockedAst), statementAst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,54745,56372) || true) && (index > 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,54745,56372);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,54954,55025);

var 
pipelineAst = f_1555_54972_55009(f_1555_54972_54998(namedBlockedAst), index - 1)as PipelineAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,55055,56345) || true) && (pipelineAst != null &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 55059, 55121)&&f_1555_55082_55116(f_1555_55082_55110(pipelineAst))== 1))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,55055,56345);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,55187,55250);

var 
commandAst = f_1555_55204_55235(f_1555_55204_55232(pipelineAst), 0)as CommandAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,55284,56314) || true) && (commandAst != null &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 55288, 55384)&&f_1555_55347_55379(f_1555_55347_55373(commandAst))<= 2 )&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 55288, 55459)&&f_1555_55425_55451(commandAst)== null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,55284,56314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,55730,55812);

var 
commandNameAst = f_1555_55751_55780(f_1555_55751_55777(commandAst), 0)as StringConstantExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,55850,56279) || true) && (commandNameAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,55850,56279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,55958,56240);

f_1555_55958_56239(                                        _parser, f_1555_55978_55999(commandNameAst), nameof(ParserStrings.ResourceNotDefined), f_1555_56133_56165(), f_1555_56212_56238(f_1555_56212_56233(commandNameAst)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,55850,56279);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,55284,56314);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,55055,56345);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,54745,56372);
}
DynAbs.Tracing.TraceSender.TraceBreak(1555,56400,56406);

break;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,54525,56429);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,56453,56487);

statementAst = ast as PipelineAst;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,56509,56529);

ancestorNodeLevel++;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,56551,56568);

ast = f_1555_56557_56567(ast);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,54262,56587);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,54262,56587);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,54262,56587);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1555,53839,56602);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,56618,56649);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,52674,56660);

System.Management.Automation.Language.ConfigurationDefinitionAst
f_1555_52846_52918(System.Management.Automation.Language.ScriptBlockExpressionAst
ast)
{
var return_v = Ast.GetAncestorAst<ConfigurationDefinitionAst>( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 52846, 52918);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_53904_53935(System.Management.Automation.Language.ScriptBlockExpressionAst
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 53904, 53935);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
f_1555_54670_54696(System.Management.Automation.Language.NamedBlockAst
this_param)
{
var return_v = this_param.Statements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 54670, 54696);
return return_v;
}


int
f_1555_54670_54718(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
this_param,System.Management.Automation.Language.PipelineAst
value)
{
var return_v = this_param.IndexOf( (System.Management.Automation.Language.StatementAst)value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 54670, 54718);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
f_1555_54972_54998(System.Management.Automation.Language.NamedBlockAst
this_param)
{
var return_v = this_param.Statements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 54972, 54998);
return return_v;
}


System.Management.Automation.Language.StatementAst
f_1555_54972_55009(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 54972, 55009);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
f_1555_55082_55110(System.Management.Automation.Language.PipelineAst
this_param)
{
var return_v = this_param.PipelineElements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 55082, 55110);
return return_v;
}


int
f_1555_55082_55116(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 55082, 55116);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
f_1555_55204_55232(System.Management.Automation.Language.PipelineAst
this_param)
{
var return_v = this_param.PipelineElements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 55204, 55232);
return return_v;
}


System.Management.Automation.Language.CommandBaseAst
f_1555_55204_55235(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 55204, 55235);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
f_1555_55347_55373(System.Management.Automation.Language.CommandAst
this_param)
{
var return_v = this_param.CommandElements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 55347, 55373);
return return_v;
}


int
f_1555_55347_55379(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 55347, 55379);
return return_v;
}


System.Management.Automation.Language.DynamicKeyword
f_1555_55425_55451(System.Management.Automation.Language.CommandAst
this_param)
{
var return_v = this_param.DefiningKeyword ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 55425, 55451);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
f_1555_55751_55777(System.Management.Automation.Language.CommandAst
this_param)
{
var return_v = this_param.CommandElements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 55751, 55777);
return return_v;
}


System.Management.Automation.Language.CommandElementAst
f_1555_55751_55780(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 55751, 55780);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_55978_55999(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 55978, 55999);
return return_v;
}


string
f_1555_56133_56165()
{
var return_v =                                             ParserStrings.ResourceNotDefined;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 56133, 56165);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_56212_56233(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 56212, 56233);
return return_v;
}


string
f_1555_56212_56238(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 56212, 56238);
return return_v;
}


int
f_1555_55958_56239(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 55958, 56239);
return 0;
}


System.Management.Automation.Language.Ast
f_1555_56557_56567(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 56557, 56567);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,52674,56660);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,52674,56660);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitUsingStatement(UsingStatementAst usingStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,56672,57473);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,56784,57097);

bool 
usingKindSupported = f_1555_56810_56846(usingStatementAst)== UsingStatementKind.Namespace ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 56810, 56988)||f_1555_56921_56957(usingStatementAst)== UsingStatementKind.Assembly )||(DynAbs.Tracing.TraceSender.Expression_False(1555, 56810, 57096)||f_1555_57031_57067(usingStatementAst)== UsingStatementKind.Module)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,57111,57415) || true) && (!usingKindSupported ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 57115, 57186)||f_1555_57155_57178(usingStatementAst)!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,57111,57415);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,57220,57400);

f_1555_57220_57399(                _parser, f_1555_57240_57264(usingStatementAst), nameof(ParserStrings.UsingStatementNotSupported), f_1555_57358_57398());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,57111,57415);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,57431,57462);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,56672,57473);

System.Management.Automation.Language.UsingStatementKind
f_1555_56810_56846(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.UsingStatementKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 56810, 56846);
return return_v;
}


System.Management.Automation.Language.UsingStatementKind
f_1555_56921_56957(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.UsingStatementKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 56921, 56957);
return return_v;
}


System.Management.Automation.Language.UsingStatementKind
f_1555_57031_57067(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.UsingStatementKind ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 57031, 57067);
return return_v;
}


System.Management.Automation.Language.StringConstantExpressionAst
f_1555_57155_57178(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.Alias ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 57155, 57178);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_57240_57264(System.Management.Automation.Language.UsingStatementAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 57240, 57264);
return return_v;
}


string
f_1555_57358_57398()
{
var return_v =                     ParserStrings.UsingStatementNotSupported;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 57358, 57398);
return return_v;
}


int
f_1555_57220_57399(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 57220, 57399);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,56672,57473);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,56672,57473);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitConfigurationDefinition(ConfigurationDefinitionAst configurationDefinitionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,57485,58758);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,57748,57820);

ScriptBlockAst 
configBody = f_1555_57776_57819(f_1555_57776_57807(configurationDefinitionAst))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,57834,58700) || true) && (f_1555_57838_57859(configBody)!= null ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 57838, 57902)||f_1555_57871_57894(configBody)!= null )||(DynAbs.Tracing.TraceSender.Expression_False(1555, 57838, 57942)||f_1555_57906_57934(configBody)!= null))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,57834,58700);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,57976,58106);

var 
unsupportedNamedBlocks = new NamedBlockAst[] { f_1555_58027_58048(configBody), f_1555_58050_58073(configBody), f_1555_58075_58103(configBody)}
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,58124,58557);
foreach(NamedBlockAst namedBlock in f_1555_58161_58183_I(unsupportedNamedBlocks) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,58124,58557);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,58225,58538) || true) && (namedBlock != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,58225,58538);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,58297,58515);

f_1555_58297_58514(                        _parser, f_1555_58317_58343(namedBlock), nameof(ParserStrings.UnsupportedNamedBlockInConfiguration), f_1555_58463_58513());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,58225,58538);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,58124,58557);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,434);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,434);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1555,57834,58700);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,58716,58747);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,57485,58758);

System.Management.Automation.Language.ScriptBlockExpressionAst
f_1555_57776_57807(System.Management.Automation.Language.ConfigurationDefinitionAst
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 57776, 57807);
return return_v;
}


System.Management.Automation.Language.ScriptBlockAst
f_1555_57776_57819(System.Management.Automation.Language.ScriptBlockExpressionAst
this_param)
{
var return_v = this_param.ScriptBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 57776, 57819);
return return_v;
}


System.Management.Automation.Language.NamedBlockAst
f_1555_57838_57859(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.BeginBlock ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 57838, 57859);
return return_v;
}


System.Management.Automation.Language.NamedBlockAst
f_1555_57871_57894(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.ProcessBlock ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 57871, 57894);
return return_v;
}


System.Management.Automation.Language.NamedBlockAst
f_1555_57906_57934(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.DynamicParamBlock ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 57906, 57934);
return return_v;
}


System.Management.Automation.Language.NamedBlockAst
f_1555_58027_58048(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.BeginBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 58027, 58048);
return return_v;
}


System.Management.Automation.Language.NamedBlockAst
f_1555_58050_58073(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.ProcessBlock;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 58050, 58073);
return return_v;
}


System.Management.Automation.Language.NamedBlockAst
f_1555_58075_58103(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.DynamicParamBlock ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 58075, 58103);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_58317_58343(System.Management.Automation.Language.NamedBlockAst
this_param)
{
var return_v = this_param.OpenCurlyExtent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 58317, 58343);
return return_v;
}


string
f_1555_58463_58513()
{
var return_v =                             ParserStrings.UnsupportedNamedBlockInConfiguration;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 58463, 58513);
return return_v;
}


int
f_1555_58297_58514(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 58297, 58514);
return 0;
}


System.Management.Automation.Language.NamedBlockAst[]
f_1555_58161_58183_I(System.Management.Automation.Language.NamedBlockAst[]
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 58161, 58183);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,57485,58758);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,57485,58758);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitDynamicKeywordStatement(DynamicKeywordStatementAst dynamicKeywordStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,58770,63289);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,59165,60004) || true) && (f_1555_59169_59217(f_1555_59169_59203(dynamicKeywordStatementAst))!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,59165,60004);
                try
                {
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,59303,59402);

ParseError[] 
errors = f_1555_59325_59401(f_1555_59325_59359(dynamicKeywordStatementAst), dynamicKeywordStatementAst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,59424,59543) || true) && (errors != null &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 59428, 59463)&&f_1555_59446_59459(errors)> 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,59424,59543);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,59490,59543);

f_1555_59490_59542(f_1555_59490_59505(                        errors), e => _parser.ReportError(e));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,59424,59543);
}
                }
                catch (Exception e)
                {
DynAbs.Tracing.TraceSender.TraceEnterCatch(1555,59580,59989);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,59640,59970);

f_1555_59640_59969(                    _parser, f_1555_59660_59693(dynamicKeywordStatementAst), nameof(ParserStrings.DynamicKeywordSemanticCheckException), f_1555_59805_59855(), f_1555_59882_59929(f_1555_59882_59916(dynamicKeywordStatementAst)), f_1555_59956_59968(                        e));
DynAbs.Tracing.TraceSender.TraceExitCatch(1555,59580,59989);
                }
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,59165,60004);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,60020,60080);

DynamicKeyword 
keyword = f_1555_60045_60079(dynamicKeywordStatementAst)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,60094,60177);

HashtableAst 
hashtable = f_1555_60119_60160(dynamicKeywordStatementAst)as HashtableAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,60191,61649) || true) && (hashtable != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,60191,61649);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,60382,61634);
foreach(var keyValueTuple in f_1555_60412_60435_I(f_1555_60412_60435(hashtable)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,60382,61634);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,60477,60543);

var 
propName = f_1555_60492_60511(keyValueTuple)as StringConstantExpressionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,60565,61615) || true) && (propName == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,60565,61615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,60635,60979);

f_1555_60635_60978(                        _parser, f_1555_60655_60681(f_1555_60655_60674(keyValueTuple)), nameof(ParserStrings.ConfigurationInvalidPropertyName), f_1555_60797_60843(), f_1555_60874_60920(f_1555_60874_60913(dynamicKeywordStatementAst)), f_1555_60951_60977(f_1555_60951_60970(keyValueTuple)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,60565,61615);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,60565,61615);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,61029,61615) || true) && (!f_1555_61034_61080(f_1555_61034_61052(keyword), f_1555_61065_61079(propName)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,61029,61615);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,61130,61277);

IOrderedEnumerable<string> 
tableKeys = f_1555_61169_61276(f_1555_61169_61192(f_1555_61169_61187(keyword)), key => key, f_1555_61243_61275())
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,61305,61592);

f_1555_61305_61591(
                        _parser, f_1555_61325_61340(propName), nameof(ParserStrings.InvalidInstanceProperty), f_1555_61447_61484(), f_1555_61515_61529(propName), f_1555_61560_61590("', '", tableKeys));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,61029,61615);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,60565,61615);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,60382,61634);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,1253);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,1253);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1555,60191,61649);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,61772,61886);

ConfigurationDefinitionAst 
configAst = f_1555_61811_61885(dynamicKeywordStatementAst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,61900,63231) || true) && (configAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,61900,63231);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,61955,62070);

StringConstantExpressionAst 
nameAst = f_1555_61993_62038(f_1555_61993_62035(dynamicKeywordStatementAst), 0)as StringConstantExpressionAst
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,62088,62156);

f_1555_62088_62155(nameAst != null, "nameAst should never be null");

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,62174,63216) || true) && (!f_1555_62179_62249(DscClassCache.SystemResourceNames, f_1555_62222_62248(f_1555_62222_62241(f_1555_62222_62236(nameAst)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,62174,63216);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,62291,63197) || true) && (f_1555_62295_62322(configAst)== ConfigurationType.Meta &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 62295, 62407)&&!f_1555_62353_62407(f_1555_62353_62387(dynamicKeywordStatementAst))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,62291,63197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,62457,62703);

f_1555_62457_62702(                        _parser, f_1555_62477_62491(nameAst), nameof(ParserStrings.RegularResourceUsedInMetaConfig), f_1555_62606_62651(), f_1555_62682_62701(f_1555_62682_62696(nameAst)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,62291,63197);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,62291,63197);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,62753,63197) || true) && (f_1555_62757_62784(configAst)!= ConfigurationType.Meta &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 62757, 62868)&&f_1555_62814_62868(f_1555_62814_62848(dynamicKeywordStatementAst))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,62753,63197);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,62918,63174);

f_1555_62918_63173(                        _parser, f_1555_62938_62952(nameAst), nameof(ParserStrings.MetaConfigurationUsedInRegularConfig), f_1555_63072_63122(), f_1555_63153_63172(f_1555_63153_63167(nameAst)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,62753,63197);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,62291,63197);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,62174,63216);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,61900,63231);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,63247,63278);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,58770,63289);

System.Management.Automation.Language.DynamicKeyword
f_1555_59169_59203(System.Management.Automation.Language.DynamicKeywordStatementAst
this_param)
{
var return_v = this_param.Keyword;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 59169, 59203);
return return_v;
}


System.Func<System.Management.Automation.Language.DynamicKeywordStatementAst, System.Management.Automation.Language.ParseError[]>
f_1555_59169_59217(System.Management.Automation.Language.DynamicKeyword
this_param)
{
var return_v = this_param.SemanticCheck ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 59169, 59217);
return return_v;
}


System.Management.Automation.Language.DynamicKeyword
f_1555_59325_59359(System.Management.Automation.Language.DynamicKeywordStatementAst
this_param)
{
var return_v = this_param.Keyword;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 59325, 59359);
return return_v;
}


System.Management.Automation.Language.ParseError[]
f_1555_59325_59401(System.Management.Automation.Language.DynamicKeyword
this_param,System.Management.Automation.Language.DynamicKeywordStatementAst
arg)
{
var return_v = this_param.SemanticCheck( arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 59325, 59401);
return return_v;
}


int
f_1555_59446_59459(System.Management.Automation.Language.ParseError[]
this_param)
{
var return_v = this_param.Length ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 59446, 59459);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
f_1555_59490_59505(System.Management.Automation.Language.ParseError[]
source)
{
var return_v = source.ToList<System.Management.Automation.Language.ParseError>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 59490, 59505);
return return_v;
}


int
f_1555_59490_59542(System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
this_param,System.Action<System.Management.Automation.Language.ParseError>
action)
{
this_param.ForEach( action);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 59490, 59542);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1555_59660_59693(System.Management.Automation.Language.DynamicKeywordStatementAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 59660, 59693);
return return_v;
}


string
f_1555_59805_59855()
{
var return_v =                         ParserStrings.DynamicKeywordSemanticCheckException;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 59805, 59855);
return return_v;
}


System.Management.Automation.Language.DynamicKeyword
f_1555_59882_59916(System.Management.Automation.Language.DynamicKeywordStatementAst
this_param)
{
var return_v = this_param.Keyword;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 59882, 59916);
return return_v;
}


string
f_1555_59882_59929(System.Management.Automation.Language.DynamicKeyword
this_param)
{
var return_v = this_param.ResourceName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 59882, 59929);
return return_v;
}


string
f_1555_59956_59968(System.Exception
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 59956, 59968);
return return_v;
}


int
f_1555_59640_59969(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg1,string
arg2)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 59640, 59969);
return 0;
}


System.Management.Automation.Language.DynamicKeyword
f_1555_60045_60079(System.Management.Automation.Language.DynamicKeywordStatementAst
this_param)
{
var return_v = this_param.Keyword;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 60045, 60079);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_60119_60160(System.Management.Automation.Language.DynamicKeywordStatementAst
this_param)
{
var return_v = this_param.BodyExpression ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 60119, 60160);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
f_1555_60412_60435(System.Management.Automation.Language.HashtableAst
this_param)
{
var return_v = this_param.KeyValuePairs;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 60412, 60435);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_60492_60511(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
this_param)
{
var return_v = this_param.Item1 ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 60492, 60511);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_60655_60674(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
this_param)
{
var return_v = this_param.Item1;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 60655, 60674);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_60655_60681(System.Management.Automation.Language.ExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 60655, 60681);
return return_v;
}


string
f_1555_60797_60843()
{
var return_v =                             ParserStrings.ConfigurationInvalidPropertyName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 60797, 60843);
return return_v;
}


System.Management.Automation.Language.Token
f_1555_60874_60913(System.Management.Automation.Language.DynamicKeywordStatementAst
this_param)
{
var return_v = this_param.FunctionName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 60874, 60913);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_60874_60920(System.Management.Automation.Language.Token
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 60874, 60920);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_60951_60970(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
this_param)
{
var return_v = this_param.Item1;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 60951, 60970);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_60951_60977(System.Management.Automation.Language.ExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 60951, 60977);
return return_v;
}


int
f_1555_60635_60978(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,System.Management.Automation.Language.IScriptExtent
arg1,System.Management.Automation.Language.IScriptExtent
arg2)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 60635, 60978);
return 0;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>
f_1555_61034_61052(System.Management.Automation.Language.DynamicKeyword
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 61034, 61052);
return return_v;
}


string
f_1555_61065_61079(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 61065, 61079);
return return_v;
}


bool
f_1555_61034_61080(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>
this_param,string
key)
{
var return_v = this_param.ContainsKey( key);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 61034, 61080);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>
f_1555_61169_61187(System.Management.Automation.Language.DynamicKeyword
this_param)
{
var return_v = this_param.Properties;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 61169, 61187);
return return_v;
}


System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>.KeyCollection
f_1555_61169_61192(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>
this_param)
{
var return_v = this_param.Keys
;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 61169, 61192);
return return_v;
}


System.StringComparer
f_1555_61243_61275()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 61243, 61275);
return return_v;
}


System.Linq.IOrderedEnumerable<string>
f_1555_61169_61276(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.DynamicKeywordProperty>.KeyCollection
source,System.Func<string, string>
keySelector,System.StringComparer
comparer)
{
var return_v = source.OrderBy<string,string>( keySelector, (System.Collections.Generic.IComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 61169, 61276);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_61325_61340(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 61325, 61340);
return return_v;
}


string
f_1555_61447_61484()
{
var return_v =                             ParserStrings.InvalidInstanceProperty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 61447, 61484);
return return_v;
}


string
f_1555_61515_61529(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Value;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 61515, 61529);
return return_v;
}


string
f_1555_61560_61590(string
separator,System.Linq.IOrderedEnumerable<string>
values)
{
var return_v = string.Join( separator, (System.Collections.Generic.IEnumerable<string?>)values);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 61560, 61590);
return return_v;
}


int
f_1555_61305_61591(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg1,string
arg2)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg1, (object)arg2);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 61305, 61591);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
f_1555_60412_60435_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 60412, 60435);
return return_v;
}


System.Management.Automation.Language.ConfigurationDefinitionAst
f_1555_61811_61885(System.Management.Automation.Language.DynamicKeywordStatementAst
ast)
{
var return_v = Ast.GetAncestorAst<ConfigurationDefinitionAst>( (System.Management.Automation.Language.Ast)ast);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 61811, 61885);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
f_1555_61993_62035(System.Management.Automation.Language.DynamicKeywordStatementAst
this_param)
{
var return_v = this_param.CommandElements;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 61993, 62035);
return return_v;
}


System.Management.Automation.Language.CommandElementAst
f_1555_61993_62038(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 61993, 62038);
return return_v;
}


int
f_1555_62088_62155(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 62088, 62155);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1555_62222_62236(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 62222, 62236);
return return_v;
}


string
f_1555_62222_62241(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 62222, 62241);
return return_v;
}


string
f_1555_62222_62248(string
this_param)
{
var return_v = this_param.Trim();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 62222, 62248);
return return_v;
}


bool
f_1555_62179_62249(System.Collections.Generic.HashSet<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 62179, 62249);
return return_v;
}


System.Management.Automation.Language.ConfigurationType
f_1555_62295_62322(System.Management.Automation.Language.ConfigurationDefinitionAst
this_param)
{
var return_v = this_param.ConfigurationType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 62295, 62322);
return return_v;
}


System.Management.Automation.Language.DynamicKeyword
f_1555_62353_62387(System.Management.Automation.Language.DynamicKeywordStatementAst
this_param)
{
var return_v = this_param.Keyword;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 62353, 62387);
return return_v;
}


bool
f_1555_62353_62407(System.Management.Automation.Language.DynamicKeyword
keyword)
{
var return_v = keyword.IsMetaDSCResource();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 62353, 62407);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_62477_62491(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 62477, 62491);
return return_v;
}


string
f_1555_62606_62651()
{
var return_v =                             ParserStrings.RegularResourceUsedInMetaConfig;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 62606, 62651);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_62682_62696(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 62682, 62696);
return return_v;
}


string
f_1555_62682_62701(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 62682, 62701);
return return_v;
}


int
f_1555_62457_62702(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 62457, 62702);
return 0;
}


System.Management.Automation.Language.ConfigurationType
f_1555_62757_62784(System.Management.Automation.Language.ConfigurationDefinitionAst
this_param)
{
var return_v = this_param.ConfigurationType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 62757, 62784);
return return_v;
}


System.Management.Automation.Language.DynamicKeyword
f_1555_62814_62848(System.Management.Automation.Language.DynamicKeywordStatementAst
this_param)
{
var return_v = this_param.Keyword;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 62814, 62848);
return return_v;
}


bool
f_1555_62814_62868(System.Management.Automation.Language.DynamicKeyword
keyword)
{
var return_v = keyword.IsMetaDSCResource();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 62814, 62868);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_62938_62952(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 62938, 62952);
return return_v;
}


string
f_1555_63072_63122()
{
var return_v =                             ParserStrings.MetaConfigurationUsedInRegularConfig;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 63072, 63122);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_63153_63167(System.Management.Automation.Language.StringConstantExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 63153, 63167);
return return_v;
}


string
f_1555_63153_63172(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 63153, 63172);
return return_v;
}


int
f_1555_62918_63173(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 62918, 63173);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,58770,63289);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,58770,63289);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitPropertyMember(PropertyMemberAst propertyMemberAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,63301,64225);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,63413,64111) || true) && (f_1555_63417_63447(propertyMemberAst)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,63413,64111);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,63596,63667);

var 
type = f_1555_63607_63666(f_1555_63607_63646(f_1555_63607_63637(propertyMemberAst)))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,63687,64096) || true) && (type != null &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 63691, 63761)&&(type == typeof(void) ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 63708, 63760)||f_1555_63732_63760(type)))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,63687,64096);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,63803,64077);

f_1555_63803_64076(                    _parser, f_1555_63823_63860(f_1555_63823_63853(propertyMemberAst)), nameof(ParserStrings.TypeNotAllowedForProperty), f_1555_63961_64000(), f_1555_64027_64075(f_1555_64027_64066(f_1555_64027_64057(propertyMemberAst))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,63687,64096);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,63413,64111);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,64127,64169);

f_1555_64127_64168(
            _memberScopeStack, propertyMemberAst);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,64183,64214);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,63301,64225);

System.Management.Automation.Language.TypeConstraintAst
f_1555_63417_63447(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.PropertyType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 63417, 63447);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_63607_63637(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.PropertyType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 63607, 63637);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_63607_63646(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 63607, 63646);
return return_v;
}


System.Type
f_1555_63607_63666(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 63607, 63666);
return return_v;
}


bool
f_1555_63732_63760(System.Type
this_param)
{
var return_v = this_param.IsGenericTypeDefinition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 63732, 63760);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_63823_63853(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.PropertyType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 63823, 63853);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_63823_63860(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 63823, 63860);
return return_v;
}


string
f_1555_63961_64000()
{
var return_v =                         ParserStrings.TypeNotAllowedForProperty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 63961, 64000);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_64027_64057(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.PropertyType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 64027, 64057);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_64027_64066(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 64027, 64066);
return return_v;
}


string
f_1555_64027_64075(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 64027, 64075);
return return_v;
}


int
f_1555_63803_64076(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 63803, 64076);
return 0;
}


int
f_1555_64127_64168(System.Collections.Generic.Stack<System.Management.Automation.Language.MemberAst>
this_param,System.Management.Automation.Language.PropertyMemberAst
item)
{
this_param.Push( (System.Management.Automation.Language.MemberAst)item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 64127, 64168);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,63301,64225);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,63301,64225);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public void PostVisit(Ast ast)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,64237,65160);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,64292,64335);

var 
scriptBlockAst = ast as ScriptBlockAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,64349,65149) || true) && (scriptBlockAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,64349,65149);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,64409,64636) || true) && (f_1555_64413_64434(scriptBlockAst)== null ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 64413, 64495)||f_1555_64446_64467(scriptBlockAst)is ScriptBlockExpressionAst )||(DynAbs.Tracing.TraceSender.Expression_False(1555, 64413, 64551)||!(f_1555_64501_64529(f_1555_64501_64522(scriptBlockAst))is FunctionMemberAst)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,64409,64636);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,64593,64617);

f_1555_64593_64616(                    _memberScopeStack);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,64409,64636);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,64656,64674);

f_1555_64656_64673(
                _scopeStack);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,64692,64739);

scriptBlockAst.PostParseChecksPerformed = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,64966,65022);

scriptBlockAst.HadErrors |= DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => f_1555_64994_65017(f_1555_64994_65011(_parser))> 0,1555,64966,64990);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,64349,65149);
}

else 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,64349,65149);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,65056,65149) || true) && (ast is MemberAst)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,65056,65149);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,65110,65134);

f_1555_65110_65133(                _memberScopeStack);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,65056,65149);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,64349,65149);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,64237,65160);

System.Management.Automation.Language.Ast
f_1555_64413_64434(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 64413, 64434);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_64446_64467(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 64446, 64467);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_64501_64522(System.Management.Automation.Language.ScriptBlockAst
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 64501, 64522);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_64501_64529(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Parent ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 64501, 64529);
return return_v;
}


System.Management.Automation.Language.MemberAst
f_1555_64593_64616(System.Collections.Generic.Stack<System.Management.Automation.Language.MemberAst>
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 64593, 64616);
return return_v;
}


System.Management.Automation.Language.ScriptBlockAst
f_1555_64656_64673(System.Collections.Generic.Stack<System.Management.Automation.Language.ScriptBlockAst>
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 64656, 64673);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
f_1555_64994_65011(System.Management.Automation.Language.Parser
this_param)
{
var return_v = this_param.ErrorList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 64994, 65011);
return return_v;
}


int
f_1555_64994_65017(System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 64994, 65017);
return return_v;
}


System.Management.Automation.Language.MemberAst
f_1555_65110_65133(System.Collections.Generic.Stack<System.Management.Automation.Language.MemberAst>
this_param)
{
var return_v = this_param.Pop();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 65110, 65133);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,64237,65160);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,64237,65160);
}
		}

static SemanticChecks()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1555,505,65167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,676,805);
s_isConstantAttributeArgVisitor = new IsConstantValueVisitor
        {
            CheckingAttributeArgument = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true,1555,710,805)        };DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,863,1052);
s_isConstantAttributeArgForClassVisitor = new IsConstantValueVisitor
        {
            CheckingAttributeArgument = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => true,1555,905,1052),            CheckingClassAttributeArguments = true
        };DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1555,505,65167);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,505,65167);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1555,505,65167);

System.Collections.Generic.Stack<System.Management.Automation.Language.MemberAst>
f_1555_1857_1879()
{
var return_v = new System.Collections.Generic.Stack<System.Management.Automation.Language.MemberAst>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 1857, 1879);
return return_v;
}


System.Collections.Generic.Stack<System.Management.Automation.Language.ScriptBlockAst>
f_1555_1908_1935()
{
var return_v = new System.Collections.Generic.Stack<System.Management.Automation.Language.ScriptBlockAst>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 1908, 1935);
return return_v;
}

}
internal static class DscResourceChecker
{
internal static void CheckType(Parser parser, TypeDefinitionAst typeDefinitionAst, AttributeAst dscResourceAttributeAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1555,65495,68921);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,65640,65660);

bool 
hasSet = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,65674,65695);

bool 
hasTest = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,65709,65729);

bool 
hasGet = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,65743,65771);

bool 
hasDefaultCtor = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,65785,65816);

bool 
hasNonDefaultCtor = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,65830,65850);

bool 
hasKey = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,65866,66004);

f_1555_65866_66003(dscResourceAttributeAst != null, "CheckType called only for DSC resources. dscResourceAttributeAst must be non-null.");
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,66020,67107);
foreach(var member in f_1555_66043_66068_I(f_1555_66043_66068(typeDefinitionAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,66020,67107);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,66102,66154);

var 
functionMemberAst = member as FunctionMemberAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,66174,67092) || true) && (functionMemberAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,66174,67092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,66245,66285);

f_1555_66245_66284(functionMemberAst, ref hasSet);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,66307,66355);

f_1555_66307_66354(parser, functionMemberAst, ref hasGet);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,66377,66419);

f_1555_66377_66418(functionMemberAst, ref hasTest);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,66443,66871) || true) && (f_1555_66447_66478(functionMemberAst)&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 66447, 66509)&&f_1555_66482_66509_M(!functionMemberAst.IsStatic)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,66443,66871);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,66559,66848) || true) && (f_1555_66563_66597(f_1555_66563_66591(functionMemberAst))== 0)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,66559,66848);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,66660,66682);

hasDefaultCtor = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,66559,66848);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,66559,66848);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,66796,66821);

hasNonDefaultCtor = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,66559,66848);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,66443,66871);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,66174,67092);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,66174,67092);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,66953,67003);

var 
propertyMemberAst = (PropertyMemberAst)member
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,67025,67073);

f_1555_67025_67072(parser, propertyMemberAst, ref hasKey);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,66174,67092);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,66020,67107);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,1088);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,1088);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,67123,67356) || true) && (f_1555_67127_67154(typeDefinitionAst)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 67127, 67209)&&(!hasSet ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 67167, 67185)||!hasGet )||(DynAbs.Tracing.TraceSender.Expression_False(1555, 67167, 67197)||!hasTest )||(DynAbs.Tracing.TraceSender.Expression_False(1555, 67167, 67208)||!hasKey))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,67123,67356);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,67243,67341);

f_1555_67243_67340(parser, typeDefinitionAst, ref hasSet, ref hasGet, ref hasTest, ref hasKey);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,67123,67356);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,67372,67406);

var 
name = f_1555_67383_67405(typeDefinitionAst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,67422,67696) || true) && (!hasSet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,67422,67696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,67467,67681);

f_1555_67467_67680(                parser, f_1555_67486_67516(dscResourceAttributeAst), nameof(ParserStrings.DscResourceMissingSetMethod), f_1555_67611_67652(), name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,67422,67696);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,67712,67986) || true) && (!hasGet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,67712,67986);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,67757,67971);

f_1555_67757_67970(                parser, f_1555_67776_67806(dscResourceAttributeAst), nameof(ParserStrings.DscResourceMissingGetMethod), f_1555_67901_67942(), name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,67712,67986);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,68002,68279) || true) && (!hasTest)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,68002,68279);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,68048,68264);

f_1555_68048_68263(                parser, f_1555_68067_68097(dscResourceAttributeAst), nameof(ParserStrings.DscResourceMissingTestMethod), f_1555_68193_68235(), name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,68002,68279);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,68295,68616) || true) && (!hasDefaultCtor &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 68299, 68335)&&hasNonDefaultCtor))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,68295,68616);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,68369,68601);

f_1555_68369_68600(                parser, f_1555_68388_68418(dscResourceAttributeAst), nameof(ParserStrings.DscResourceMissingDefaultConstructor), f_1555_68522_68572(), name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,68295,68616);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,68632,68910) || true) && (!hasKey)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,68632,68910);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,68677,68895);

f_1555_68677_68894(                parser, f_1555_68696_68726(dscResourceAttributeAst), nameof(ParserStrings.DscResourceMissingKeyProperty), f_1555_68823_68866(), name);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,68632,68910);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1555,65495,68921);

int
f_1555_65866_66003(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 65866, 66003);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
f_1555_66043_66068(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Members;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 66043, 66068);
return return_v;
}


int
f_1555_66245_66284(System.Management.Automation.Language.FunctionMemberAst
functionMemberAst,ref bool
hasSet)
{
CheckSet( functionMemberAst, ref hasSet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 66245, 66284);
return 0;
}


int
f_1555_66307_66354(System.Management.Automation.Language.Parser
parser,System.Management.Automation.Language.FunctionMemberAst
functionMemberAst,ref bool
hasGet)
{
CheckGet( parser, functionMemberAst, ref hasGet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 66307, 66354);
return 0;
}


int
f_1555_66377_66418(System.Management.Automation.Language.FunctionMemberAst
functionMemberAst,ref bool
hasTest)
{
CheckTest( functionMemberAst, ref hasTest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 66377, 66418);
return 0;
}


bool
f_1555_66447_66478(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.IsConstructor ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 66447, 66478);
return return_v;
}


bool
f_1555_66482_66509_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 66482, 66509);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
f_1555_66563_66591(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 66563, 66591);
return return_v;
}


int
f_1555_66563_66597(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 66563, 66597);
return return_v;
}


int
f_1555_67025_67072(System.Management.Automation.Language.Parser
parser,System.Management.Automation.Language.PropertyMemberAst
propertyMemberAst,ref bool
hasKey)
{
CheckKey( parser, propertyMemberAst, ref hasKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 67025, 67072);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
f_1555_66043_66068_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 66043, 66068);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
f_1555_67127_67154(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.BaseTypes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 67127, 67154);
return return_v;
}


int
f_1555_67243_67340(System.Management.Automation.Language.Parser
parser,System.Management.Automation.Language.TypeDefinitionAst
typeDefinitionAst,ref bool
hasSet,ref bool
hasGet,ref bool
hasTest,ref bool
hasKey)
{
LookupRequiredMembers( parser, typeDefinitionAst, ref hasSet, ref hasGet, ref hasTest, ref hasKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 67243, 67340);
return 0;
}


string
f_1555_67383_67405(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 67383, 67405);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_67486_67516(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 67486, 67516);
return return_v;
}


string
f_1555_67611_67652()
{
var return_v =                     ParserStrings.DscResourceMissingSetMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 67611, 67652);
return return_v;
}


int
f_1555_67467_67680(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 67467, 67680);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1555_67776_67806(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 67776, 67806);
return return_v;
}


string
f_1555_67901_67942()
{
var return_v =                     ParserStrings.DscResourceMissingGetMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 67901, 67942);
return return_v;
}


int
f_1555_67757_67970(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 67757, 67970);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1555_68067_68097(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 68067, 68097);
return return_v;
}


string
f_1555_68193_68235()
{
var return_v =                     ParserStrings.DscResourceMissingTestMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 68193, 68235);
return return_v;
}


int
f_1555_68048_68263(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 68048, 68263);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1555_68388_68418(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 68388, 68418);
return return_v;
}


string
f_1555_68522_68572()
{
var return_v =                     ParserStrings.DscResourceMissingDefaultConstructor;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 68522, 68572);
return return_v;
}


int
f_1555_68369_68600(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 68369, 68600);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1555_68696_68726(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 68696, 68726);
return return_v;
}


string
f_1555_68823_68866()
{
var return_v =                     ParserStrings.DscResourceMissingKeyProperty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 68823, 68866);
return return_v;
}


int
f_1555_68677_68894(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 68677, 68894);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,65495,68921);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,65495,68921);
}
		}

private static void LookupRequiredMembers(Parser parser, TypeDefinitionAst typeDefinitionAst, ref bool hasSet, ref bool hasGet, ref bool hasTest, ref bool hasKey)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1555,69573,71482);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,69760,69845) || true) && (typeDefinitionAst == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,69760,69845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,69823,69830);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,69760,69845);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,69861,69958) || true) && (hasSet &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 69865, 69881)&&hasGet )&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 69865, 69892)&&hasTest )&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 69865, 69902)&&hasKey))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,69861,69958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,69936,69943);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,69861,69958);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,69974,71471);
foreach(var baseType in f_1555_69999_70026_I(f_1555_69999_70026(typeDefinitionAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,69974,71471);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,70060,70109);

var 
baseTypeName = f_1555_70079_70096(baseType)as TypeName
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,70127,70221) || true) && (baseTypeName == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,70127,70221);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,70193,70202);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,70127,70221);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,70241,70315);

TypeDefinitionAst 
baseTypeDefinitionAst = baseTypeName._typeDefinitionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,70333,70470) || true) && (baseTypeDefinitionAst == null ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 70337, 70400)||f_1555_70370_70400_M(!baseTypeDefinitionAst.IsClass)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,70333,70470);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,70442,70451);

continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,70333,70470);
}
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,70490,71183);
foreach(var member in f_1555_70513_70542_I(f_1555_70513_70542(baseTypeDefinitionAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,70490,71183);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,70584,70636);

var 
functionMemberAst = member as FunctionMemberAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,70658,71164) || true) && (functionMemberAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,70658,71164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,70737,70777);

f_1555_70737_70776(functionMemberAst, ref hasSet);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,70803,70851);

f_1555_70803_70850(parser, functionMemberAst, ref hasGet);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,70877,70919);

f_1555_70877_70918(functionMemberAst, ref hasTest);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,70658,71164);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,70658,71164);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,71017,71067);

var 
propertyMemberAst = (PropertyMemberAst)member
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,71093,71141);

f_1555_71093_71140(parser, propertyMemberAst, ref hasKey);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,70658,71164);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,70490,71183);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,694);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,694);
}
if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,71203,71456) || true) && (f_1555_71207_71238(baseTypeDefinitionAst)!= null &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 71207, 71293)&&(!hasSet ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 71251, 71269)||!hasGet )||(DynAbs.Tracing.TraceSender.Expression_False(1555, 71251, 71281)||!hasTest )||(DynAbs.Tracing.TraceSender.Expression_False(1555, 71251, 71292)||!hasKey))))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,71203,71456);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,71335,71437);

f_1555_71335_71436(parser, baseTypeDefinitionAst, ref hasSet, ref hasGet, ref hasTest, ref hasKey);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,71203,71456);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,69974,71471);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,1498);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,1498);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1555,69573,71482);

System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
f_1555_69999_70026(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.BaseTypes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 69999, 70026);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_70079_70096(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 70079, 70096);
return return_v;
}


bool
f_1555_70370_70400_M(bool
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 70370, 70400);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
f_1555_70513_70542(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Members;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 70513, 70542);
return return_v;
}


int
f_1555_70737_70776(System.Management.Automation.Language.FunctionMemberAst
functionMemberAst,ref bool
hasSet)
{
CheckSet( functionMemberAst, ref hasSet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 70737, 70776);
return 0;
}


int
f_1555_70803_70850(System.Management.Automation.Language.Parser
parser,System.Management.Automation.Language.FunctionMemberAst
functionMemberAst,ref bool
hasGet)
{
CheckGet( parser, functionMemberAst, ref hasGet);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 70803, 70850);
return 0;
}


int
f_1555_70877_70918(System.Management.Automation.Language.FunctionMemberAst
functionMemberAst,ref bool
hasTest)
{
CheckTest( functionMemberAst, ref hasTest);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 70877, 70918);
return 0;
}


int
f_1555_71093_71140(System.Management.Automation.Language.Parser
parser,System.Management.Automation.Language.PropertyMemberAst
propertyMemberAst,ref bool
hasKey)
{
CheckKey( parser, propertyMemberAst, ref hasKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 71093, 71140);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
f_1555_70513_70542_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.MemberAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 70513, 70542);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
f_1555_71207_71238(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.BaseTypes ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 71207, 71238);
return return_v;
}


int
f_1555_71335_71436(System.Management.Automation.Language.Parser
parser,System.Management.Automation.Language.TypeDefinitionAst
typeDefinitionAst,ref bool
hasSet,ref bool
hasGet,ref bool
hasTest,ref bool
hasKey)
{
LookupRequiredMembers( parser, typeDefinitionAst, ref hasSet, ref hasGet, ref hasTest, ref hasKey);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 71335, 71436);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
f_1555_69999_70026_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.TypeConstraintAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 69999, 70026);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,69573,71482);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,69573,71482);
}
		}

private static void CheckGet(Parser parser, FunctionMemberAst functionMemberAst, ref bool hasGet)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1555,71870,73730);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,71992,72058) || true) && (hasGet)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,71992,72058);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,72036,72043);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,71992,72058);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,72074,73719) || true) && (f_1555_72078_72150(f_1555_72078_72100(functionMemberAst), "Get", StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 72078, 72210)&&f_1555_72171_72205(f_1555_72171_72199(functionMemberAst))== 0))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,72074,73719);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,72244,73567) || true) && (f_1555_72248_72276(functionMemberAst)!= null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,72244,73567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,72478,72553);

var 
arrayTypeName = f_1555_72498_72535(f_1555_72498_72526(functionMemberAst))as ArrayTypeName
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,72575,72748);

var 
typeName =
                        ((DynAbs.Tracing.TraceSender.Conditional_F1(1555, 72616, 72637)||((arrayTypeName != null &&DynAbs.Tracing.TraceSender.Conditional_F2(1555, 72640, 72665))||DynAbs.Tracing.TraceSender.Conditional_F3(1555, 72668, 72705)))?f_1555_72640_72665(arrayTypeName):f_1555_72668_72705(f_1555_72668_72696(functionMemberAst))) as
                            TypeName
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,72770,73200) || true) && (typeName == null ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 72774, 72849)||typeName._typeDefinitionAst != f_1555_72825_72849(functionMemberAst)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,72770,73200);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,72899,73177);

f_1555_72899_73176(                        parser, f_1555_72918_72942(functionMemberAst), nameof(ParserStrings.DscResourceInvalidGetMethod), f_1555_73053_73094(), f_1555_73125_73175(((TypeDefinitionAst)f_1555_73145_73169(functionMemberAst))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,72770,73200);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,72244,73567);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,72244,73567);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,73282,73548);

f_1555_73282_73547(                    parser, f_1555_73301_73325(functionMemberAst), nameof(ParserStrings.DscResourceInvalidGetMethod), f_1555_73428_73469(), f_1555_73496_73546(((TypeDefinitionAst)f_1555_73516_73540(functionMemberAst))));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,72244,73567);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,73665,73679);

hasGet = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,73697,73704);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,72074,73719);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1555,71870,73730);

string
f_1555_72078_72100(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 72078, 72100);
return return_v;
}


bool
f_1555_72078_72150(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 72078, 72150);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
f_1555_72171_72199(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 72171, 72199);
return return_v;
}


int
f_1555_72171_72205(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 72171, 72205);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_72248_72276(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.ReturnType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 72248, 72276);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_72498_72526(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 72498, 72526);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_72498_72535(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 72498, 72535);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_72640_72665(System.Management.Automation.Language.ArrayTypeName
this_param)
{
var return_v = this_param.ElementType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 72640, 72665);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_72668_72696(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 72668, 72696);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_72668_72705(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 72668, 72705);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_72825_72849(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 72825, 72849);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_72918_72942(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 72918, 72942);
return return_v;
}


string
f_1555_73053_73094()
{
var return_v =                             ParserStrings.DscResourceInvalidGetMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 73053, 73094);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_73145_73169(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 73145, 73169);
return return_v;
}


string
f_1555_73125_73175(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 73125, 73175);
return return_v;
}


int
f_1555_72899_73176(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 72899, 73176);
return 0;
}


System.Management.Automation.Language.IScriptExtent
f_1555_73301_73325(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 73301, 73325);
return return_v;
}


string
f_1555_73428_73469()
{
var return_v =                         ParserStrings.DscResourceInvalidGetMethod;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 73428, 73469);
return return_v;
}


System.Management.Automation.Language.Ast
f_1555_73516_73540(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Parent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 73516, 73540);
return return_v;
}


string
f_1555_73496_73546(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 73496, 73546);
return return_v;
}


int
f_1555_73282_73547(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,string
arg)
{
this_param.ReportError( extent, errorId, errorMsg, (object)arg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 73282, 73547);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,71870,73730);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,71870,73730);
}
		}

private static void CheckTest(FunctionMemberAst functionMemberAst, ref bool hasTest)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1555,74080,74543);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,74189,74209) || true) && (hasTest)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,74189,74209);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,74202,74209);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,74189,74209);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,74223,74532);

hasTest = (f_1555_74234_74307(f_1555_74234_74256(functionMemberAst), "Test", StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 74234, 74371)&&f_1555_74332_74366(f_1555_74332_74360(functionMemberAst))== 0 )&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 74234, 74432)&&f_1555_74396_74424(functionMemberAst)!= null )&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 74234, 74530)&&f_1555_74457_74514(f_1555_74457_74494(f_1555_74457_74485(functionMemberAst)))== typeof(bool)));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1555,74080,74543);

string
f_1555_74234_74256(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 74234, 74256);
return return_v;
}


bool
f_1555_74234_74307(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 74234, 74307);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
f_1555_74332_74360(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 74332, 74360);
return return_v;
}


int
f_1555_74332_74366(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 74332, 74366);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_74396_74424(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.ReturnType ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 74396, 74424);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_74457_74485(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.ReturnType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 74457, 74485);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_74457_74494(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 74457, 74494);
return return_v;
}


System.Type
f_1555_74457_74514(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 74457, 74514);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,74080,74543);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,74080,74543);
}
		}

private static void CheckSet(FunctionMemberAst functionMemberAst, ref bool hasSet)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1555,74888,75248);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,74995,75014) || true) && (hasSet)
) 
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,74995,75014);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,75007,75014);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,74995,75014);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,75028,75237);

hasSet = (f_1555_75038_75110(f_1555_75038_75060(functionMemberAst), "Set", StringComparison.OrdinalIgnoreCase)&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 75038, 75174)&&f_1555_75135_75169(f_1555_75135_75163(functionMemberAst))== 0 )&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 75038, 75235)&&f_1555_75199_75235(                    functionMemberAst)));
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1555,74888,75248);

string
f_1555_75038_75060(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Name;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 75038, 75060);
return return_v;
}


bool
f_1555_75038_75110(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 75038, 75110);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
f_1555_75135_75163(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.Parameters;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 75135, 75163);
return return_v;
}


int
f_1555_75135_75169(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 75135, 75169);
return return_v;
}


bool
f_1555_75199_75235(System.Management.Automation.Language.FunctionMemberAst
this_param)
{
var return_v = this_param.IsReturnTypeVoid();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 75199, 75235);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,74888,75248);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,74888,75248);
}
		}

private static void CheckKey(Parser parser, PropertyMemberAst propertyMemberAst, ref bool hasKey)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1555,75561,78336);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,75683,78325);
foreach(var attr in f_1555_75704_75732_I(f_1555_75704_75732(propertyMemberAst)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,75683,78325);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,75766,78310) || true) && (f_1555_75770_75812(f_1555_75770_75783(attr))== typeof(DscPropertyAttribute))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,75766,78310);
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,75886,78291);
foreach(var na in f_1555_75905_75924_I(f_1555_75905_75924(attr)) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,75886,78291);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,75974,78268) || true) && (f_1555_75978_76043(f_1555_75978_75993(na), "Key", StringComparison.OrdinalIgnoreCase))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,75974,78268);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,76101,76121);

object 
attrArgValue
=default(object);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,76151,78241) || true) && (f_1555_76155_76259(f_1555_76189_76200(na), out attrArgValue, forAttribute: true, forRequires: false)&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 76155, 76335)&&f_1555_76296_76335(attrArgValue)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,76151,78241);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,76401,76415);

hasKey = true;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,76451,76487);

bool 
keyPropertyTypeAllowed = false
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,76521,76571);

var 
propertyType = f_1555_76540_76570(propertyMemberAst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,76605,77770) || true) && (propertyType != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,76605,77770);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,76703,76757);

TypeName 
typeName = f_1555_76723_76744(propertyType)as TypeName
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,76795,77735) || true) && (typeName != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,76795,77735);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,76897,76937);

var 
type = f_1555_76908_76936(typeName)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,76979,77696) || true) && (type != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,76979,77696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,77085,77153);

keyPropertyTypeAllowed = type == typeof(string) ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 77110, 77152)||f_1555_77136_77152(type));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,76979,77696);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,76979,77696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,77331,77383);

var 
typeDefinitionAst = typeName._typeDefinitionAst
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,77429,77653) || true) && (typeDefinitionAst != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,77429,77653);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,77556,77606);

keyPropertyTypeAllowed = f_1555_77581_77605(typeDefinitionAst);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,77429,77653);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,76979,77696);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,76795,77735);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,76605,77770);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,77806,78167) || true) && (!keyPropertyTypeAllowed)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,77806,78167);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,77907,78132);

f_1555_77907_78131(                                    parser, f_1555_77926_77950(propertyMemberAst), nameof(ParserStrings.DscResourceInvalidKeyProperty), f_1555_78087_78130());
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,77806,78167);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,78203,78210);

return;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,76151,78241);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,75974,78268);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,75886,78291);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,2406);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,2406);
}DynAbs.Tracing.TraceSender.TraceExitCondition(1555,75766,78310);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,75683,78325);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,2643);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,2643);
}DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1555,75561,78336);

System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
f_1555_75704_75732(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.Attributes;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 75704, 75732);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_75770_75783(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 75770, 75783);
return return_v;
}


System.Type
f_1555_75770_75812(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionAttributeType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 75770, 75812);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.NamedAttributeArgumentAst>
f_1555_75905_75924(System.Management.Automation.Language.AttributeAst
this_param)
{
var return_v = this_param.NamedArguments;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 75905, 75924);
return return_v;
}


string
f_1555_75978_75993(System.Management.Automation.Language.NamedAttributeArgumentAst
this_param)
{
var return_v = this_param.ArgumentName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 75978, 75993);
return return_v;
}


bool
f_1555_75978_76043(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 75978, 76043);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_76189_76200(System.Management.Automation.Language.NamedAttributeArgumentAst
this_param)
{
var return_v = this_param.Argument;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 76189, 76200);
return return_v;
}


bool
f_1555_76155_76259(System.Management.Automation.Language.ExpressionAst
ast,out object
constantValue,bool
forAttribute,bool
forRequires)
{
var return_v = IsConstantValueVisitor.IsConstant( (System.Management.Automation.Language.Ast)ast, out constantValue, forAttribute: forAttribute, forRequires: forRequires);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 76155, 76259);
return return_v;
}


bool
f_1555_76296_76335(object
obj)
{
var return_v = LanguagePrimitives.IsTrue( obj);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 76296, 76335);
return return_v;
}


System.Management.Automation.Language.TypeConstraintAst
f_1555_76540_76570(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.PropertyType;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 76540, 76570);
return return_v;
}


System.Management.Automation.Language.ITypeName
f_1555_76723_76744(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 76723, 76744);
return return_v;
}


System.Type
f_1555_76908_76936(System.Management.Automation.Language.TypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 76908, 76936);
return return_v;
}


bool
f_1555_77136_77152(System.Type
type)
{
var return_v = type.IsInteger();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 77136, 77152);
return return_v;
}


bool
f_1555_77581_77605(System.Management.Automation.Language.TypeDefinitionAst
this_param)
{
var return_v = this_param.IsEnum;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 77581, 77605);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_77926_77950(System.Management.Automation.Language.PropertyMemberAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 77926, 77950);
return return_v;
}


string
f_1555_78087_78130()
{
var return_v =                                         ParserStrings.DscResourceInvalidKeyProperty;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 78087, 78130);
return return_v;
}


int
f_1555_77907_78131(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 77907, 78131);
return 0;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.NamedAttributeArgumentAst>
f_1555_75905_75924_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.NamedAttributeArgumentAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 75905, 75924);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
f_1555_75704_75732_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeAst>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 75704, 75732);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,75561,78336);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,75561,78336);
}
		}

static DscResourceChecker()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1555,65175,78343);
DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1555,65175,78343);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,65175,78343);
}

}
internal class RestrictedLanguageChecker : AstVisitor
{
private readonly Parser _parser;

private readonly IEnumerable<string> _allowedCommands;

private readonly IEnumerable<string> _allowedVariables;

private readonly bool _allVariablesAreAllowed;

private readonly bool _allowEnvironmentVariables;

internal RestrictedLanguageChecker(Parser parser, IEnumerable<string> allowedCommands, IEnumerable<string> allowedVariables, bool allowEnvironmentVariables)
		{
			try
{DynAbs.Tracing.TraceSender.TraceEnterConstructor(1555,78709,80001);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,78445,78452);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,78500,78516);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,78564,78581);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,78614,78637);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,78670,78696);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,80013,80185);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,78890,78907);

_parser = parser;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,78921,78956);

_allowedCommands = allowedCommands;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,78972,79919) || true) && (allowedVariables != null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,78972,79919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,79226,79316);

var 
allowedVariablesList = allowedVariables as IList<string> ??(DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.IList<string>>(1555, 79253, 79315)??f_1555_79290_79315(allowedVariables))
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,79334,79792) || true) && (f_1555_79338_79364(allowedVariablesList)== 1 &&(DynAbs.Tracing.TraceSender.Expression_True(1555, 79338, 79407)&&f_1555_79373_79407(allowedVariablesList, "*")))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,79334,79792);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,79449,79480);

_allVariablesAreAllowed = true;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,79334,79792);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,79334,79792);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,79678,79773);

_allowedVariables = f_1555_79698_79772(f_1555_79698_79744(s_defaultAllowedVariables), allowedVariablesList);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,79334,79792);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,78972,79919);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,78972,79919);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,79858,79904);

_allowedVariables = s_defaultAllowedVariables;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,78972,79919);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,79935,79990);

_allowEnvironmentVariables = allowEnvironmentVariables;
DynAbs.Tracing.TraceSender.TraceExitConstructor(1555,78709,80001);
}catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,78709,80001);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,78709,80001);
}
		}

private bool FoundError
{            [SuppressMessage("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
            get;
            set;
}

internal static void CheckDataStatementLanguageModeAtRuntime(DataStatementAst dataStatementAst, ExecutionContext executionContext)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1555,80197,80969);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,80508,80958) || true) && (f_1555_80512_80541(executionContext)== PSLanguageMode.ConstrainedLanguage)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,80508,80958);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,80613,80639);

var 
parser = f_1555_80626_80638()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,80657,80872);

f_1555_80657_80871(                parser, f_1555_80676_80718(f_1555_80676_80711(f_1555_80676_80708(dataStatementAst), 0)), nameof(ParserStrings.DataSectionAllowedCommandDisallowed), f_1555_80821_80870());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,80890,80943);

throw f_1555_80896_80942(f_1555_80915_80941(f_1555_80915_80931(parser)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,80508,80958);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1555,80197,80969);

System.Management.Automation.PSLanguageMode
f_1555_80512_80541(System.Management.Automation.ExecutionContext
this_param)
{
var return_v = this_param.LanguageMode ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 80512, 80541);
return return_v;
}


System.Management.Automation.Language.Parser
f_1555_80626_80638()
{
var return_v = new System.Management.Automation.Language.Parser();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 80626, 80638);
return return_v;
}


System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
f_1555_80676_80708(System.Management.Automation.Language.DataStatementAst
this_param)
{
var return_v = this_param.CommandsAllowed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 80676, 80708);
return return_v;
}


System.Management.Automation.Language.ExpressionAst
f_1555_80676_80711(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
this_param,int
i0)
{
var return_v = this_param[ i0];
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 80676, 80711);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_80676_80718(System.Management.Automation.Language.ExpressionAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 80676, 80718);
return return_v;
}


string
f_1555_80821_80870()
{
var return_v =                     ParserStrings.DataSectionAllowedCommandDisallowed;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 80821, 80870);
return return_v;
}


int
f_1555_80657_80871(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg)
{
this_param.ReportError( extent, errorId, errorMsg);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 80657, 80871);
return 0;
}


System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
f_1555_80915_80931(System.Management.Automation.Language.Parser
this_param)
{
var return_v = this_param.ErrorList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 80915, 80931);
return return_v;
}


System.Management.Automation.Language.ParseError[]
f_1555_80915_80941(System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 80915, 80941);
return return_v;
}


System.Management.Automation.ParseException
f_1555_80896_80942(System.Management.Automation.Language.ParseError[]
errors)
{
var return_v = new System.Management.Automation.ParseException( errors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 80896, 80942);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,80197,80969);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,80197,80969);
}
		}

internal static void CheckDataStatementAstAtRuntime(DataStatementAst dataStatementAst, string[] allowedCommands)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1555,80981,81444);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,81118,81144);

var 
parser = f_1555_81131_81143()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,81158,81236);

var 
rlc = f_1555_81168_81235(parser, allowedCommands, null, false)
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,81250,81291);

f_1555_81250_81290(f_1555_81250_81271(dataStatementAst), rlc);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,81305,81433) || true) && (f_1555_81309_81331(f_1555_81309_81325(parser)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,81305,81433);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,81365,81418);

throw f_1555_81371_81417(f_1555_81390_81416(f_1555_81390_81406(parser)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,81305,81433);
}
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1555,80981,81444);

System.Management.Automation.Language.Parser
f_1555_81131_81143()
{
var return_v = new System.Management.Automation.Language.Parser();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 81131, 81143);
return return_v;
}


System.Management.Automation.Language.RestrictedLanguageChecker
f_1555_81168_81235(System.Management.Automation.Language.Parser
parser,string[]
allowedCommands,System.Collections.Generic.IEnumerable<string>
allowedVariables,bool
allowEnvironmentVariables)
{
var return_v = new System.Management.Automation.Language.RestrictedLanguageChecker( parser, (System.Collections.Generic.IEnumerable<string>)allowedCommands, allowedVariables, allowEnvironmentVariables);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 81168, 81235);
return return_v;
}


System.Management.Automation.Language.StatementBlockAst
f_1555_81250_81271(System.Management.Automation.Language.DataStatementAst
this_param)
{
var return_v = this_param.Body;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 81250, 81271);
return return_v;
}


System.Management.Automation.Language.AstVisitAction
f_1555_81250_81290(System.Management.Automation.Language.StatementBlockAst
this_param,System.Management.Automation.Language.RestrictedLanguageChecker
visitor)
{
var return_v = this_param.InternalVisit( (System.Management.Automation.Language.AstVisitor)visitor);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 81250, 81290);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
f_1555_81309_81325(System.Management.Automation.Language.Parser
this_param)
{
var return_v = this_param.ErrorList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 81309, 81325);
return return_v;
}


bool
f_1555_81309_81331(System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
source)
{
var return_v = source.Any<System.Management.Automation.Language.ParseError>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 81309, 81331);
return return_v;
}


System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
f_1555_81390_81406(System.Management.Automation.Language.Parser
this_param)
{
var return_v = this_param.ErrorList;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 81390, 81406);
return return_v;
}


System.Management.Automation.Language.ParseError[]
f_1555_81390_81416(System.Collections.Generic.List<System.Management.Automation.Language.ParseError>
this_param)
{
var return_v = this_param.ToArray();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 81390, 81416);
return return_v;
}


System.Management.Automation.ParseException
f_1555_81371_81417(System.Management.Automation.Language.ParseError[]
errors)
{
var return_v = new System.Management.Automation.ParseException( errors);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 81371, 81417);
return return_v;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,80981,81444);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,80981,81444);
}
		}

internal static void EnsureUtilityModuleLoaded(ExecutionContext context)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1555,81456,81630);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,81553,81619);

f_1555_81553_81618("Microsoft.PowerShell.Utility", context);
DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1555,81456,81630);

int
f_1555_81553_81618(string
module,System.Management.Automation.ExecutionContext
context)
{
Utils.EnsureModuleLoaded( module, context);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 81553, 81618);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,81456,81630);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,81456,81630);
}
		}

private void ReportError(Ast ast, string errorId, string errorMsg, params object[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,81642,81847);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,81755,81804);

f_1555_81755_81803(this, f_1555_81767_81777(ast), errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,81818,81836);

FoundError = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,81642,81847);

System.Management.Automation.Language.IScriptExtent
f_1555_81767_81777(System.Management.Automation.Language.Ast
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 81767, 81777);
return return_v;
}


int
f_1555_81755_81803(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( extent, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 81755, 81803);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,81642,81847);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,81642,81847);
}
		}

private void ReportError(IScriptExtent extent, string errorId, string errorMsg, params object[] args)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,81859,82081);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,81985,82038);

f_1555_81985_82037(            _parser, extent, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,82052,82070);

FoundError = true;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,81859,82081);

int
f_1555_81985_82037(System.Management.Automation.Language.Parser
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( extent, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 81985, 82037);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,81859,82081);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,81859,82081);
}
		}

public override AstVisitAction VisitScriptBlock(ScriptBlockAst scriptBlockAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,82093,82428);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,82196,82370);

f_1555_82196_82369(this, scriptBlockAst, nameof(ParserStrings.ScriptBlockNotSupportedInDataSection), f_1555_82318_82368());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,82386,82417);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,82093,82428);

string
f_1555_82318_82368()
{
var return_v =                 ParserStrings.ScriptBlockNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 82318, 82368);
return return_v;
}


int
f_1555_82196_82369(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.ScriptBlockAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 82196, 82369);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,82093,82428);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,82093,82428);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitParamBlock(ParamBlockAst paramBlockAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,82440,82789);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,82540,82731);

f_1555_82540_82730(this, paramBlockAst, nameof(ParserStrings.ParameterDeclarationNotSupportedInDataSection), f_1555_82670_82729());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,82747,82778);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,82440,82789);

string
f_1555_82670_82729()
{
var return_v =                 ParserStrings.ParameterDeclarationNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 82670, 82729);
return return_v;
}


int
f_1555_82540_82730(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.ParamBlockAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 82540, 82730);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,82440,82789);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,82440,82789);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitNamedBlock(NamedBlockAst namedBlockAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,82801,83078);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,82901,83020);

f_1555_82901_83019(_allowEnvironmentVariables ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 82920, 82960)||f_1555_82950_82960()), "VisitScriptBlock should have already reported an error");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,83036,83067);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,82801,83078);

bool
f_1555_82950_82960()
{
var return_v = FoundError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 82950, 82960);
return return_v;
}


int
f_1555_82901_83019(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 82901, 83019);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,82801,83078);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,82801,83078);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private void CheckTypeName(Ast ast, ITypeName typename)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,83090,84035);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,83170,83211);

Type 
type = f_1555_83182_83210(typename)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,83682,84024) || true) && (type == null ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 83686, 83782)||(f_1555_83703_83762(((DynAbs.Tracing.TraceSender.Conditional_F1(1555, 83704, 83716)||((f_1555_83704_83716(type)&&DynAbs.Tracing.TraceSender.Conditional_F2(1555, 83719, 83740))||DynAbs.Tracing.TraceSender.Conditional_F3(1555, 83743, 83747)))?f_1555_83719_83740(type):type))== TypeCode.Object)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,83682,84024);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,83816,84009);

f_1555_83816_84008(this, ast, nameof(ParserStrings.TypeNotAllowedInDataSection), f_1555_83926_83967(), f_1555_83990_84007(typename));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,83682,84024);
}
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,83090,84035);

System.Type
f_1555_83182_83210(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.GetReflectionType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 83182, 83210);
return return_v;
}


bool
f_1555_83704_83716(System.Type
this_param)
{
var return_v = this_param.IsArray ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 83704, 83716);
return return_v;
}


System.Type?
f_1555_83719_83740(System.Type
this_param)
{
var return_v = this_param.GetElementType();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 83719, 83740);
return return_v;
}


System.TypeCode
f_1555_83703_83762(System.Type
type)
{
var return_v = type.GetTypeCode();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 83703, 83762);
return return_v;
}


string
f_1555_83926_83967()
{
var return_v =                     ParserStrings.TypeNotAllowedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 83926, 83967);
return return_v;
}


string
f_1555_83990_84007(System.Management.Automation.Language.ITypeName
this_param)
{
var return_v = this_param.FullName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 83990, 84007);
return return_v;
}


int
f_1555_83816_84008(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.Ast
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 83816, 84008);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,83090,84035);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,83090,84035);
}
		}

public override AstVisitAction VisitTypeConstraint(TypeConstraintAst typeConstraintAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,84047,84278);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,84159,84220);

f_1555_84159_84219(this, typeConstraintAst, f_1555_84192_84218(typeConstraintAst));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,84236,84267);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,84047,84278);

System.Management.Automation.Language.ITypeName
f_1555_84192_84218(System.Management.Automation.Language.TypeConstraintAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 84192, 84218);
return return_v;
}


int
f_1555_84159_84219(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.TypeConstraintAst
ast,System.Management.Automation.Language.ITypeName
typename)
{
this_param.CheckTypeName( (System.Management.Automation.Language.Ast)ast, typename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 84159, 84219);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,84047,84278);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,84047,84278);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitAttribute(AttributeAst attributeAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,84290,84728);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,84387,84488);

f_1555_84387_84487(f_1555_84406_84416(), "an error should have been reported elsewhere, making this redunant");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,84502,84670);

f_1555_84502_84669(this, attributeAst, nameof(ParserStrings.AttributeNotSupportedInDataSection), f_1555_84620_84668());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,84686,84717);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,84290,84728);

bool
f_1555_84406_84416()
{
var return_v = FoundError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 84406, 84416);
return return_v;
}


int
f_1555_84387_84487(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 84387, 84487);
return 0;
}


string
f_1555_84620_84668()
{
var return_v =                 ParserStrings.AttributeNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 84620, 84668);
return return_v;
}


int
f_1555_84502_84669(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.AttributeAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 84502, 84669);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,84290,84728);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,84290,84728);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitParameter(ParameterAst parameterAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,84740,85011);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,84837,84953);

f_1555_84837_84952(f_1555_84856_84866(), "VisitParamBlock or VisitFunctionDeclaration should have already reported an error");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,84969,85000);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,84740,85011);

bool
f_1555_84856_84866()
{
var return_v = FoundError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 84856, 84866);
return return_v;
}


int
f_1555_84837_84952(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 84837, 84952);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,84740,85011);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,84740,85011);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTypeExpression(TypeExpressionAst typeExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,85023,85254);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,85135,85196);

f_1555_85135_85195(this, typeExpressionAst, f_1555_85168_85194(typeExpressionAst));
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,85212,85243);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,85023,85254);

System.Management.Automation.Language.ITypeName
f_1555_85168_85194(System.Management.Automation.Language.TypeExpressionAst
this_param)
{
var return_v = this_param.TypeName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 85168, 85194);
return return_v;
}


int
f_1555_85135_85195(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.TypeExpressionAst
ast,System.Management.Automation.Language.ITypeName
typename)
{
this_param.CheckTypeName( (System.Management.Automation.Language.Ast)ast, typename);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 85135, 85195);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,85023,85254);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,85023,85254);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,85266,85645);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,85390,85587);

f_1555_85390_85586(this, functionDefinitionAst, nameof(ParserStrings.FunctionDeclarationNotSupportedInDataSection), f_1555_85527_85585());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,85603,85634);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,85266,85645);

string
f_1555_85527_85585()
{
var return_v =                 ParserStrings.FunctionDeclarationNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 85527, 85585);
return return_v;
}


int
f_1555_85390_85586(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.FunctionDefinitionAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 85390, 85586);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,85266,85645);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,85266,85645);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitStatementBlock(StatementBlockAst statementBlockAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,85657,85882);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,85840,85871);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,85657,85882);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,85657,85882);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,85657,85882);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitIfStatement(IfStatementAst ifStmtAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,85894,86124);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,86082,86113);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,85894,86124);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,85894,86124);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,85894,86124);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTrap(TrapStatementAst trapStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,86136,86474);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,86236,86416);

f_1555_86236_86415(this, trapStatementAst, nameof(ParserStrings.TrapStatementNotSupportedInDataSection), f_1555_86362_86414());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,86432,86463);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,86136,86474);

string
f_1555_86362_86414()
{
var return_v =                 ParserStrings.TrapStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 86362, 86414);
return return_v;
}


int
f_1555_86236_86415(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.TrapStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 86236, 86415);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,86136,86474);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,86136,86474);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitSwitchStatement(SwitchStatementAst switchStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,86486,86845);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,86601,86787);

f_1555_86601_86786(this, switchStatementAst, nameof(ParserStrings.SwitchStatementNotSupportedInDataSection), f_1555_86731_86785());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,86803,86834);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,86486,86845);

string
f_1555_86731_86785()
{
var return_v =                 ParserStrings.SwitchStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 86731, 86785);
return return_v;
}


int
f_1555_86601_86786(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.SwitchStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 86601, 86786);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,86486,86845);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,86486,86845);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitDataStatement(DataStatementAst dataStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,86857,87218);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,86966,87160);

f_1555_86966_87159(this, dataStatementAst, nameof(ParserStrings.DataSectionStatementNotSupportedInDataSection), f_1555_87099_87158());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,87176,87207);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,86857,87218);

string
f_1555_87099_87158()
{
var return_v =                 ParserStrings.DataSectionStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 87099, 87158);
return return_v;
}


int
f_1555_86966_87159(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.DataStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 86966, 87159);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,86857,87218);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,86857,87218);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitForEachStatement(ForEachStatementAst forEachStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,87230,87595);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,87348,87537);

f_1555_87348_87536(this, forEachStatementAst, nameof(ParserStrings.ForeachStatementNotSupportedInDataSection), f_1555_87480_87535());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,87553,87584);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,87230,87595);

string
f_1555_87480_87535()
{
var return_v =                 ParserStrings.ForeachStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 87480, 87535);
return return_v;
}


int
f_1555_87348_87536(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.ForEachStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 87348, 87536);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,87230,87595);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,87230,87595);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitDoWhileStatement(DoWhileStatementAst doWhileStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,87607,87972);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,87725,87914);

f_1555_87725_87913(this, doWhileStatementAst, nameof(ParserStrings.DoWhileStatementNotSupportedInDataSection), f_1555_87857_87912());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,87930,87961);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,87607,87972);

string
f_1555_87857_87912()
{
var return_v =                 ParserStrings.DoWhileStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 87857, 87912);
return return_v;
}


int
f_1555_87725_87913(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.DoWhileStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 87725, 87913);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,87607,87972);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,87607,87972);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitForStatement(ForStatementAst forStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,87984,88335);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,88090,88277);

f_1555_88090_88276(this, forStatementAst, nameof(ParserStrings.ForWhileStatementNotSupportedInDataSection), f_1555_88219_88275());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,88293,88324);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,87984,88335);

string
f_1555_88219_88275()
{
var return_v =                 ParserStrings.ForWhileStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 88219, 88275);
return return_v;
}


int
f_1555_88090_88276(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.ForStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 88090, 88276);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,87984,88335);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,87984,88335);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitWhileStatement(WhileStatementAst whileStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,88347,88706);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,88459,88648);

f_1555_88459_88647(this, whileStatementAst, nameof(ParserStrings.ForWhileStatementNotSupportedInDataSection), f_1555_88590_88646());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,88664,88695);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,88347,88706);

string
f_1555_88590_88646()
{
var return_v =                 ParserStrings.ForWhileStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 88590, 88646);
return return_v;
}


int
f_1555_88459_88647(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.WhileStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 88459, 88647);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,88347,88706);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,88347,88706);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitCatchClause(CatchClauseAst catchClauseAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,88718,88961);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,88821,88903);

f_1555_88821_88902(f_1555_88840_88850(), "VisitTryStatement should have reported an error");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,88919,88950);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,88718,88961);

bool
f_1555_88840_88850()
{
var return_v = FoundError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 88840, 88850);
return return_v;
}


int
f_1555_88821_88902(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 88821, 88902);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,88718,88961);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,88718,88961);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitTryStatement(TryStatementAst tryStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,88973,89314);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,89079,89256);

f_1555_89079_89255(this, tryStatementAst, nameof(ParserStrings.TryStatementNotSupportedInDataSection), f_1555_89203_89254());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,89272,89303);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,88973,89314);

string
f_1555_89203_89254()
{
var return_v =                 ParserStrings.TryStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 89203, 89254);
return return_v;
}


int
f_1555_89079_89255(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.TryStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 89079, 89255);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,88973,89314);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,88973,89314);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitBreakStatement(BreakStatementAst breakStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,89326,89691);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,89438,89633);

f_1555_89438_89632(this, breakStatementAst, nameof(ParserStrings.FlowControlStatementNotSupportedInDataSection), f_1555_89572_89631());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,89649,89680);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,89326,89691);

string
f_1555_89572_89631()
{
var return_v =                 ParserStrings.FlowControlStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 89572, 89631);
return return_v;
}


int
f_1555_89438_89632(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.BreakStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 89438, 89632);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,89326,89691);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,89326,89691);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitContinueStatement(ContinueStatementAst continueStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,89703,90080);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,89824,90022);

f_1555_89824_90021(this, continueStatementAst, nameof(ParserStrings.FlowControlStatementNotSupportedInDataSection), f_1555_89961_90020());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,90038,90069);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,89703,90080);

string
f_1555_89961_90020()
{
var return_v =                 ParserStrings.FlowControlStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 89961, 90020);
return return_v;
}


int
f_1555_89824_90021(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.ContinueStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 89824, 90021);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,89703,90080);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,89703,90080);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitReturnStatement(ReturnStatementAst returnStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,90092,90461);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,90207,90403);

f_1555_90207_90402(this, returnStatementAst, nameof(ParserStrings.FlowControlStatementNotSupportedInDataSection), f_1555_90342_90401());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,90419,90450);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,90092,90461);

string
f_1555_90342_90401()
{
var return_v =                 ParserStrings.FlowControlStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 90342, 90401);
return return_v;
}


int
f_1555_90207_90402(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.ReturnStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 90207, 90402);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,90092,90461);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,90092,90461);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitExitStatement(ExitStatementAst exitStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,90473,90834);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,90582,90776);

f_1555_90582_90775(this, exitStatementAst, nameof(ParserStrings.FlowControlStatementNotSupportedInDataSection), f_1555_90715_90774());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,90792,90823);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,90473,90834);

string
f_1555_90715_90774()
{
var return_v =                 ParserStrings.FlowControlStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 90715, 90774);
return return_v;
}


int
f_1555_90582_90775(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.ExitStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 90582, 90775);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,90473,90834);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,90473,90834);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitThrowStatement(ThrowStatementAst throwStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,90846,91211);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,90958,91153);

f_1555_90958_91152(this, throwStatementAst, nameof(ParserStrings.FlowControlStatementNotSupportedInDataSection), f_1555_91092_91151());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,91169,91200);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,90846,91211);

string
f_1555_91092_91151()
{
var return_v =                 ParserStrings.FlowControlStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 91092, 91151);
return return_v;
}


int
f_1555_90958_91152(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.ThrowStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 90958, 91152);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,90846,91211);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,90846,91211);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitDoUntilStatement(DoUntilStatementAst doUntilStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,91223,91588);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,91341,91530);

f_1555_91341_91529(this, doUntilStatementAst, nameof(ParserStrings.DoWhileStatementNotSupportedInDataSection), f_1555_91473_91528());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,91546,91577);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,91223,91588);

string
f_1555_91473_91528()
{
var return_v =                 ParserStrings.DoWhileStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 91473, 91528);
return return_v;
}


int
f_1555_91341_91529(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.DoUntilStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 91341, 91529);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,91223,91588);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,91223,91588);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitAssignmentStatement(AssignmentStatementAst assignmentStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,91600,92030);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,91774,91972);

f_1555_91774_91971(this, assignmentStatementAst, nameof(ParserStrings.AssignmentStatementNotSupportedInDataSection), f_1555_91912_91970());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,91988,92019);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,91600,92030);

string
f_1555_91912_91970()
{
var return_v =                 ParserStrings.AssignmentStatementNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 91912, 91970);
return return_v;
}


int
f_1555_91774_91971(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.AssignmentStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 91774, 91971);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,91600,92030);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,91600,92030);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitPipeline(PipelineAst pipelineAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,92042,92265);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,92223,92254);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,92042,92265);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,92042,92265);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,92042,92265);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitCommand(CommandAst commandAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,92277,94362);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,92589,92915) || true) && (f_1555_92593_92622(commandAst)== TokenKind.Dot)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,92589,92915);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,92673,92851);

f_1555_92673_92850(this, commandAst, nameof(ParserStrings.DotSourcingNotSupportedInDataSection), f_1555_92799_92849());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,92869,92900);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,92589,92915);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,92931,93009) || true) && (_allowedCommands == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,92931,93009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,92978,93009);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,92931,93009);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,93025,93074);

string 
commandName = f_1555_93046_93073(commandAst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,93088,93878) || true) && (commandName == null)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,93088,93878);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,93145,93812) || true) && (f_1555_93149_93178(commandAst)== TokenKind.Ampersand)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,93145,93812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,93243,93476);

f_1555_93243_93475(this, commandAst, nameof(ParserStrings.OperatorNotSupportedInDataSection), f_1555_93374_93421(), f_1555_93448_93474(                        TokenKind.Ampersand));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,93145,93812);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,93145,93812);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,93558,93793);

f_1555_93558_93792(this, commandAst, nameof(ParserStrings.CmdletNotInAllowedListForDataSection), f_1555_93692_93742(), f_1555_93769_93791(f_1555_93769_93786(commandAst)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,93145,93812);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,93832,93863);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,93088,93878);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,93894,94088) || true) && (f_1555_93898_94008(_allowedCommands, allowedCommand => allowedCommand.Equals(commandName, StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,93894,94088);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,94042,94073);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,93894,94088);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,94104,94304);

f_1555_94104_94303(this, commandAst, nameof(ParserStrings.CmdletNotInAllowedListForDataSection), f_1555_94222_94272(), commandName);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,94320,94351);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,92277,94362);

System.Management.Automation.Language.TokenKind
f_1555_92593_92622(System.Management.Automation.Language.CommandAst
this_param)
{
var return_v = this_param.InvocationOperator ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 92593, 92622);
return return_v;
}


string
f_1555_92799_92849()
{
var return_v =                     ParserStrings.DotSourcingNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 92799, 92849);
return return_v;
}


int
f_1555_92673_92850(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.CommandAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 92673, 92850);
return 0;
}


string
f_1555_93046_93073(System.Management.Automation.Language.CommandAst
this_param)
{
var return_v = this_param.GetCommandName();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 93046, 93073);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1555_93149_93178(System.Management.Automation.Language.CommandAst
this_param)
{
var return_v = this_param.InvocationOperator ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 93149, 93178);
return return_v;
}


string
f_1555_93374_93421()
{
var return_v =                         ParserStrings.OperatorNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 93374, 93421);
return return_v;
}


string
f_1555_93448_93474(System.Management.Automation.Language.TokenKind
kind)
{
var return_v = kind.Text();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 93448, 93474);
return return_v;
}


int
f_1555_93243_93475(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.CommandAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 93243, 93475);
return 0;
}


string
f_1555_93692_93742()
{
var return_v =                         ParserStrings.CmdletNotInAllowedListForDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 93692, 93742);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_93769_93786(System.Management.Automation.Language.CommandAst
this_param)
{
var return_v = this_param.Extent;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 93769, 93786);
return return_v;
}


string
f_1555_93769_93791(System.Management.Automation.Language.IScriptExtent
this_param)
{
var return_v = this_param.Text;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 93769, 93791);
return return_v;
}


int
f_1555_93558_93792(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.CommandAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 93558, 93792);
return 0;
}


bool
f_1555_93898_94008(System.Collections.Generic.IEnumerable<string>
source,System.Func<string, bool>
predicate)
{
var return_v = source.Any<string>( predicate);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 93898, 94008);
return return_v;
}


string
f_1555_94222_94272()
{
var return_v =                 ParserStrings.CmdletNotInAllowedListForDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 94222, 94272);
return return_v;
}


int
f_1555_94104_94303(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.CommandAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 94104, 94303);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,92277,94362);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,92277,94362);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitCommandExpression(CommandExpressionAst commandExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,94374,94598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,94556,94587);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,94374,94598);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,94374,94598);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,94374,94598);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitCommandParameter(CommandParameterAst commandParameterAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,94610,94860);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,94818,94849);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,94610,94860);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,94610,94860);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,94610,94860);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitMergingRedirection(MergingRedirectionAst mergingRedirectionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,94872,95235);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,94996,95177);

f_1555_94996_95176(this, mergingRedirectionAst, nameof(ParserStrings.RedirectionNotSupportedInDataSection), f_1555_95125_95175());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,95193,95224);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,94872,95235);

string
f_1555_95125_95175()
{
var return_v =                 ParserStrings.RedirectionNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 95125, 95175);
return return_v;
}


int
f_1555_94996_95176(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.MergingRedirectionAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 94996, 95176);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,94872,95235);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,94872,95235);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitFileRedirection(FileRedirectionAst fileRedirectionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,95247,95598);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,95362,95540);

f_1555_95362_95539(this, fileRedirectionAst, nameof(ParserStrings.RedirectionNotSupportedInDataSection), f_1555_95488_95538());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,95556,95587);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,95247,95598);

string
f_1555_95488_95538()
{
var return_v =                 ParserStrings.RedirectionNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 95488, 95538);
return return_v;
}


int
f_1555_95362_95539(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.FileRedirectionAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 95362, 95539);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,95247,95598);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,95247,95598);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitBinaryExpression(BinaryExpressionAst binaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,95610,96992);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,96552,96934) || true) && (f_1555_96556_96632(f_1555_96556_96584(binaryExpressionAst), TokenFlags.DisallowedInRestrictedMode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,96552,96934);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,96666,96919);

f_1555_96666_96918(this, f_1555_96678_96711(binaryExpressionAst), nameof(ParserStrings.OperatorNotSupportedInDataSection), f_1555_96812_96859(), f_1555_96882_96917(f_1555_96882_96910(binaryExpressionAst)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,96552,96934);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,96950,96981);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,95610,96992);

System.Management.Automation.Language.TokenKind
f_1555_96556_96584(System.Management.Automation.Language.BinaryExpressionAst
this_param)
{
var return_v = this_param.Operator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 96556, 96584);
return return_v;
}


bool
f_1555_96556_96632(System.Management.Automation.Language.TokenKind
kind,System.Management.Automation.Language.TokenFlags
flag)
{
var return_v = kind.HasTrait( flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 96556, 96632);
return return_v;
}


System.Management.Automation.Language.IScriptExtent
f_1555_96678_96711(System.Management.Automation.Language.BinaryExpressionAst
this_param)
{
var return_v = this_param.ErrorPosition;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 96678, 96711);
return return_v;
}


string
f_1555_96812_96859()
{
var return_v =                     ParserStrings.OperatorNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 96812, 96859);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1555_96882_96910(System.Management.Automation.Language.BinaryExpressionAst
this_param)
{
var return_v = this_param.Operator;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 96882, 96910);
return return_v;
}


string
f_1555_96882_96917(System.Management.Automation.Language.TokenKind
kind)
{
var return_v = kind.Text();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 96882, 96917);
return return_v;
}


int
f_1555_96666_96918(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.IScriptExtent
extent,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( extent, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 96666, 96918);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,95610,96992);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,95610,96992);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitUnaryExpression(UnaryExpressionAst unaryExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,97004,97544);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,97119,97486) || true) && (f_1555_97123_97199(f_1555_97123_97151(unaryExpressionAst), TokenFlags.DisallowedInRestrictedMode))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,97119,97486);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,97233,97471);

f_1555_97233_97470(this, unaryExpressionAst, nameof(ParserStrings.OperatorNotSupportedInDataSection), f_1555_97364_97411(), f_1555_97434_97469(f_1555_97434_97462(unaryExpressionAst)));
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,97119,97486);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,97502,97533);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,97004,97544);

System.Management.Automation.Language.TokenKind
f_1555_97123_97151(System.Management.Automation.Language.UnaryExpressionAst
this_param)
{
var return_v = this_param.TokenKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 97123, 97151);
return return_v;
}


bool
f_1555_97123_97199(System.Management.Automation.Language.TokenKind
kind,System.Management.Automation.Language.TokenFlags
flag)
{
var return_v = kind.HasTrait( flag);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 97123, 97199);
return return_v;
}


string
f_1555_97364_97411()
{
var return_v =                     ParserStrings.OperatorNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 97364, 97411);
return return_v;
}


System.Management.Automation.Language.TokenKind
f_1555_97434_97462(System.Management.Automation.Language.UnaryExpressionAst
this_param)
{
var return_v = this_param.TokenKind;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 97434, 97462);
return return_v;
}


string
f_1555_97434_97469(System.Management.Automation.Language.TokenKind
kind)
{
var return_v = kind.Text();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 97434, 97469);
return return_v;
}


int
f_1555_97233_97470(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.UnaryExpressionAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 97233, 97470);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,97004,97544);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,97004,97544);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitConvertExpression(ConvertExpressionAst convertExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,97556,97790);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,97748,97779);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,97556,97790);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,97556,97790);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,97556,97790);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitConstantExpression(ConstantExpressionAst constantExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,97802,98009);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,97967,97998);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,97802,98009);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,97802,98009);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,97802,98009);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitStringConstantExpression(StringConstantExpressionAst stringConstantExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,98021,98246);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,98204,98235);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,98021,98246);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,98021,98246);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,98021,98246);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitSubExpression(SubExpressionAst subExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,98258,98488);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,98446,98477);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,98258,98488);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,98258,98488);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,98258,98488);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitUsingExpression(UsingExpressionAst usingExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,98500,98737);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,98695,98726);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,98500,98737);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,98500,98737);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,98500,98737);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

private static readonly HashSet<string> s_defaultAllowedVariables ;

public override AstVisitAction VisitVariableExpression(VariableExpressionAst variableExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,99006,100882);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,99130,99188);

VariablePath 
varPath = f_1555_99153_99187(variableExpressionAst)
;

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,99317,99476) || true) && (_allVariablesAreAllowed ||(DynAbs.Tracing.TraceSender.Expression_False(1555, 99321, 99426)||f_1555_99348_99426(_allowedVariables, f_1555_99375_99391(varPath), f_1555_99393_99425())))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,99317,99476);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,99445,99476);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,99317,99476);
}

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,99492,99805) || true) && (_allowEnvironmentVariables)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,99492,99805);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,99637,99790) || true) && (f_1555_99641_99665(varPath)&&(DynAbs.Tracing.TraceSender.Expression_True(1555, 99641, 99736)&&f_1555_99669_99736(f_1555_99669_99686(varPath), "env", StringComparison.OrdinalIgnoreCase)))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,99637,99790);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,99759,99790);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,99637,99790);
}
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,99492,99805);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,99821,99840);

string 
resourceArg
=default(string);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,99854,100585) || true) && (f_1555_99858_99919(_allowedVariables, s_defaultAllowedVariables))
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,99854,100585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,99953,100018);

resourceArg = f_1555_99967_100017();
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,99854,100585);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,99854,100585);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,100084,100131);

StringBuilder 
argBuilder = f_1555_100111_100130()
;
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,100149,100167);

bool 
first = true
;
try {DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,100187,100514);
foreach(string varName in f_1555_100214_100231_I(_allowedVariables) )
{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,100187,100514);

if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,100273,100399) || true) && (first)
)

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,100273,100399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,100309,100323);

first = false;
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,100273,100399);
}

else

{DynAbs.Tracing.TraceSender.TraceEnterCondition(1555,100273,100399);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,100375,100399);

f_1555_100375_100398(                        argBuilder, ", ");
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,100273,100399);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,100423,100446);

f_1555_100423_100445(
                    argBuilder, "$");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,100468,100495);

f_1555_100468_100494(                    argBuilder, varName);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,100187,100514);
}
}catch(System.Exception) { DynAbs.Tracing.TraceSender.TraceExitLoopByException(1555,1,328);
 throw; }finally{DynAbs.Tracing.TraceSender.TraceExitLoop(1555,1,328);
}DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,100534,100570);

resourceArg = f_1555_100548_100569(argBuilder);
DynAbs.Tracing.TraceSender.TraceExitCondition(1555,99854,100585);
}
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,100601,100824);

f_1555_100601_100823(this, variableExpressionAst, nameof(ParserStrings.VariableReferenceNotSupportedInDataSection), f_1555_100736_100792(), resourceArg);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,100840,100871);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,99006,100882);

System.Management.Automation.VariablePath
f_1555_99153_99187(System.Management.Automation.Language.VariableExpressionAst
this_param)
{
var return_v = this_param.VariablePath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 99153, 99187);
return return_v;
}


string
f_1555_99375_99391(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.UserPath;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 99375, 99391);
return return_v;
}


System.StringComparer
f_1555_99393_99425()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 99393, 99425);
return return_v;
}


bool
f_1555_99348_99426(System.Collections.Generic.IEnumerable<string>
source,string
value,System.StringComparer
comparer)
{
var return_v = source.Contains<string>( value, (System.Collections.Generic.IEqualityComparer<string>)comparer);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 99348, 99426);
return return_v;
}


bool
f_1555_99641_99665(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.IsDriveQualified ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 99641, 99665);
return return_v;
}


string
f_1555_99669_99686(System.Management.Automation.VariablePath
this_param)
{
var return_v = this_param.DriveName;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 99669, 99686);
return return_v;
}


bool
f_1555_99669_99736(string
this_param,string
value,System.StringComparison
comparisonType)
{
var return_v = this_param.Equals( value, comparisonType);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 99669, 99736);
return return_v;
}


bool
f_1555_99858_99919(System.Collections.Generic.IEnumerable<string>
objA,System.Collections.Generic.HashSet<string>
objB)
{
var return_v = ReferenceEquals( (object)objA, (object)objB);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 99858, 99919);
return return_v;
}


string
f_1555_99967_100017()
{
var return_v = ParserStrings.DefaultAllowedVariablesInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 99967, 100017);
return return_v;
}


System.Text.StringBuilder
f_1555_100111_100130()
{
var return_v = new System.Text.StringBuilder();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 100111, 100130);
return return_v;
}


System.Text.StringBuilder
f_1555_100375_100398(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 100375, 100398);
return return_v;
}


System.Text.StringBuilder
f_1555_100423_100445(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 100423, 100445);
return return_v;
}


System.Text.StringBuilder
f_1555_100468_100494(System.Text.StringBuilder
this_param,string
value)
{
var return_v = this_param.Append( value);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 100468, 100494);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_1555_100214_100231_I(System.Collections.Generic.IEnumerable<string>
i)
{
var return_v = i;
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 100214, 100231);
return return_v;
}


string
f_1555_100548_100569(System.Text.StringBuilder
this_param)
{
var return_v = this_param.ToString();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 100548, 100569);
return return_v;
}


string
f_1555_100736_100792()
{
var return_v =                 ParserStrings.VariableReferenceNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 100736, 100792);
return return_v;
}


int
f_1555_100601_100823(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.VariableExpressionAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 100601, 100823);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,99006,100882);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,99006,100882);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitMemberExpression(MemberExpressionAst memberExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,100894,101261);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,101012,101203);

f_1555_101012_101202(this, memberExpressionAst, nameof(ParserStrings.PropertyReferenceNotSupportedInDataSection), f_1555_101145_101201());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,101219,101250);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,100894,101261);

string
f_1555_101145_101201()
{
var return_v =                 ParserStrings.PropertyReferenceNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 101145, 101201);
return return_v;
}


int
f_1555_101012_101202(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.MemberExpressionAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 101012, 101202);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,100894,101261);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,100894,101261);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitInvokeMemberExpression(InvokeMemberExpressionAst methodCallAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,101273,101626);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,101397,101568);

f_1555_101397_101567(this, methodCallAst, nameof(ParserStrings.MethodCallNotSupportedInDataSection), f_1555_101517_101566());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,101584,101615);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,101273,101626);

string
f_1555_101517_101566()
{
var return_v =                 ParserStrings.MethodCallNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 101517, 101566);
return return_v;
}


int
f_1555_101397_101567(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.InvokeMemberExpressionAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 101397, 101567);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,101273,101626);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,101273,101626);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitArrayExpression(ArrayExpressionAst arrayExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,101638,101844);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,101802,101833);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,101638,101844);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,101638,101844);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,101638,101844);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitArrayLiteral(ArrayLiteralAst arrayLiteralAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,101856,102055);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,102013,102044);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,101856,102055);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,101856,102055);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,101856,102055);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitHashtable(HashtableAst hashtableAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,102067,102288);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,102246,102277);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,102067,102288);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,102067,102288);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,102067,102288);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,102300,102675);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,102433,102617);

f_1555_102433_102616(this, scriptBlockExpressionAst, nameof(ParserStrings.ScriptBlockNotSupportedInDataSection), f_1555_102565_102615());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,102633,102664);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,102300,102675);

string
f_1555_102565_102615()
{
var return_v =                 ParserStrings.ScriptBlockNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 102565, 102615);
return return_v;
}


int
f_1555_102433_102616(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.ScriptBlockExpressionAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 102433, 102616);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,102300,102675);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,102300,102675);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitParenExpression(ParenExpressionAst parenExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,102687,102904);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,102862,102893);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,102687,102904);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,102687,102904);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,102687,102904);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitExpandableStringExpression(ExpandableStringExpressionAst expandableStringExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,102916,103427);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,103385,103416);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,102916,103427);
        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,102916,103427);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,102916,103427);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitIndexExpression(IndexExpressionAst indexExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,103439,103886);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,103644,103828);

f_1555_103644_103827(this, indexExpressionAst, nameof(ParserStrings.ArrayReferenceNotSupportedInDataSection), f_1555_103773_103826());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,103844,103875);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,103439,103886);

string
f_1555_103773_103826()
{
var return_v =                 ParserStrings.ArrayReferenceNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 103773, 103826);
return return_v;
}


int
f_1555_103644_103827(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.IndexExpressionAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 103644, 103827);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,103439,103886);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,103439,103886);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitAttributedExpression(AttributedExpressionAst attributedExpressionAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,103898,104350);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,104113,104292);

f_1555_104113_104291(this, attributedExpressionAst, nameof(ParserStrings.AttributeNotSupportedInDataSection), f_1555_104242_104290());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,104308,104339);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,103898,104350);

string
f_1555_104242_104290()
{
var return_v =                 ParserStrings.AttributeNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 104242, 104290);
return return_v;
}


int
f_1555_104113_104291(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.AttributedExpressionAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 104113, 104291);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,103898,104350);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,103898,104350);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitBlockStatement(BlockStatementAst blockStatementAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,104362,104782);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,104521,104724);

f_1555_104521_104723(this, blockStatementAst, nameof(ParserStrings.ParallelAndSequenceBlockNotSupportedInDataSection), f_1555_104659_104722());
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,104740,104771);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,104362,104782);

string
f_1555_104659_104722()
{
var return_v =                 ParserStrings.ParallelAndSequenceBlockNotSupportedInDataSection;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 104659, 104722);
return return_v;
}


int
f_1555_104521_104723(System.Management.Automation.Language.RestrictedLanguageChecker
this_param,System.Management.Automation.Language.BlockStatementAst
ast,string
errorId,string
errorMsg,params object[]
args)
{
this_param.ReportError( (System.Management.Automation.Language.Ast)ast, errorId, errorMsg, args);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 104521, 104723);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,104362,104782);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,104362,104782);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

public override AstVisitAction VisitNamedAttributeArgument(NamedAttributeArgumentAst namedAttributeArgumentAst)
		{
			try
        {
DynAbs.Tracing.TraceSender.TraceEnterMethod(1555,104794,105114);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,104930,105056);

f_1555_104930_105055(f_1555_104949_104959(), "VisitAttributedExpression or VisitParameter or VisitParamBlock should have issued an error.");
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,105072,105103);

return AstVisitAction.Continue;
DynAbs.Tracing.TraceSender.TraceExitMethod(1555,104794,105114);

bool
f_1555_104949_104959()
{
var return_v = FoundError;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 104949, 104959);
return return_v;
}


int
f_1555_104930_105055(bool
condition,string
whyThisShouldNeverHappen)
{
Diagnostics.Assert( condition, whyThisShouldNeverHappen);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 104930, 105055);
return 0;
}

        }
catch
{
DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1555,104794,105114);
throw;
}
finally
{
DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,104794,105114);
}
			throw new System.Exception("Slicer error: unreachable code");
		}

static RestrictedLanguageChecker()
{
DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1555,78351,105121);
DynAbs.Tracing.TraceSender.TraceSimpleStatement(1555,98789,98993);
s_defaultAllowedVariables = new HashSet<string>(f_1555_98837_98869())
                                                                    {DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "PSCulture",1555,98817,98993),"PSUICulture","true","false","null"};DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1555,78351,105121);

DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1555,78351,105121);
}

		int ___ignore_me___=DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1555,78351,105121);

System.Collections.Generic.List<string>
f_1555_79290_79315(System.Collections.Generic.IEnumerable<string>
source)
{
var return_v = source.ToList<string>();
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 79290, 79315);
return return_v;
}


int
f_1555_79338_79364(System.Collections.Generic.IList<string>
this_param)
{
var return_v = this_param.Count ;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 79338, 79364);
return return_v;
}


bool
f_1555_79373_79407(System.Collections.Generic.IList<string>
this_param,string
item)
{
var return_v = this_param.Contains( item);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 79373, 79407);
return return_v;
}


System.Collections.Generic.HashSet<string>
f_1555_79698_79744(System.Collections.Generic.HashSet<string>
collection)
{
var return_v = new System.Collections.Generic.HashSet<string>( (System.Collections.Generic.IEnumerable<string>)collection);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 79698, 79744);
return return_v;
}


System.Collections.Generic.IEnumerable<string>
f_1555_79698_79772(System.Collections.Generic.HashSet<string>
first,System.Collections.Generic.IList<string>
second)
{
var return_v = first.Union<string>( (System.Collections.Generic.IEnumerable<string>)second);
DynAbs.Tracing.TraceSender.TraceEndInvocation(1555, 79698, 79772);
return return_v;
}


static System.StringComparer
f_1555_98837_98869()
{
var return_v = StringComparer.OrdinalIgnoreCase;
DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1555, 98837, 98869);
return return_v;
}

}
}
