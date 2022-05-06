// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;

namespace System.Management.Automation
{
    internal class ScriptBlockToPowerShellChecker : AstVisitor
    {
        private readonly HashSet<string> _validVariables;

        internal ScriptBlockAst ScriptBeingConverted { get; set; }

        internal bool UsesParameter { get; private set; }

        internal bool HasUsingExpr { get; private set; }

        public override AstVisitAction VisitParameter(ParameterAst parameterAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 832, 1151);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 929, 1093) || true) && (f_1564_933_976(f_1564_933_963(f_1564_933_950(parameterAst))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 929, 1093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 1010, 1078);

                    f_1564_1010_1077(_validVariables, f_1564_1030_1076(f_1564_1030_1060(f_1564_1030_1047(parameterAst))));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 929, 1093);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 1109, 1140);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 832, 1151);

                System.Management.Automation.Language.VariableExpressionAst
                f_1564_933_950(System.Management.Automation.Language.ParameterAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 933, 950);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1564_933_963(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 933, 963);
                    return return_v;
                }


                bool
                f_1564_933_976(System.Management.Automation.VariablePath
                variablePath)
                {
                    var return_v = variablePath.IsAnyLocal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 933, 976);
                    return return_v;
                }


                System.Management.Automation.Language.VariableExpressionAst
                f_1564_1030_1047(System.Management.Automation.Language.ParameterAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 1030, 1047);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1564_1030_1060(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 1030, 1060);
                    return return_v;
                }


                string
                f_1564_1030_1076(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 1030, 1076);
                    return return_v;
                }


                bool
                f_1564_1010_1077(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 1010, 1077);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 832, 1151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 832, 1151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitPipeline(PipelineAst pipelineAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 1163, 2764);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 1257, 2706) || true) && (f_1564_1261_1292(f_1564_1261_1289(pipelineAst), 0) is CommandExpressionAst)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 1257, 2706);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 2239, 2691) || true) && (f_1564_2243_2274(pipelineAst) == null || (DynAbs.Tracing.TraceSender.Expression_False(1564, 2243, 2335) || f_1564_2286_2311(f_1564_2286_2304(pipelineAst)) == f_1564_2315_2335()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 2239, 2691);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 2377, 2672);

                        f_1564_2377_2671(f_1564_2414_2632("CantConvertPipelineStartsWithExpression", null, f_1564_2571_2631()), pipelineAst);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 2239, 2691);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 1257, 2706);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 2722, 2753);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 1163, 2764);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1564_1261_1289(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 1261, 1289);
                    return return_v;
                }


                System.Management.Automation.Language.CommandBaseAst
                f_1564_1261_1292(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 1261, 1292);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1564_2243_2274(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.GetPureExpression();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 2243, 2274);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1564_2286_2304(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 2286, 2304);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1564_2286_2311(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 2286, 2311);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1564_2315_2335()
                {
                    var return_v = ScriptBeingConverted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 2315, 2335);
                    return return_v;
                }


                string
                f_1564_2571_2631()
                {
                    var return_v = AutomationExceptions.CantConvertPipelineStartsWithExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 2571, 2631);
                    return return_v;
                }


                System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                f_1564_2414_2632(string
                errorId, System.Exception
                innerException, string
                message, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ScriptBlockToPowerShellNotSupportedException(errorId, innerException, message, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 2414, 2632);
                    return return_v;
                }


                int
                f_1564_2377_2671(System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                ex, System.Management.Automation.Language.PipelineAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 2377, 2671);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 1163, 2764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 1163, 2764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitCommand(CommandAst commandAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 2776, 4491);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 2867, 3193) || true) && (f_1564_2871_2900(commandAst) == TokenKind.Dot)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 2867, 3193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 2951, 3178);

                    f_1564_2951_3177(f_1564_2984_3143("CantConvertWithDotSourcing", null, f_1564_3095_3142()), commandAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 2867, 3193);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 3686, 4035) || true) && (f_1564_3690_3721(f_1564_3690_3714(f_1564_3690_3707(commandAst))) != f_1564_3725_3745())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 3686, 4035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 3779, 4020);

                    f_1564_3779_4019(f_1564_3812_3985("CantConvertWithCommandInvocations", null, f_1564_3930_3984()), commandAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 3686, 4035);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 4051, 4433) || true) && (f_1564_4055_4084(f_1564_4055_4081(commandAst), 0) is ScriptBlockExpressionAst)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 4051, 4433);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 4146, 4418);

                    f_1564_4146_4417(f_1564_4179_4383("CantConvertWithScriptBlockInvocation", null, f_1564_4325_4382()), commandAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 4051, 4433);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 4449, 4480);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 2776, 4491);

                System.Management.Automation.Language.TokenKind
                f_1564_2871_2900(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.InvocationOperator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 2871, 2900);
                    return return_v;
                }


                string
                f_1564_3095_3142()
                {
                    var return_v = AutomationExceptions.CantConvertWithDotSourcing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 3095, 3142);
                    return return_v;
                }


                System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                f_1564_2984_3143(string
                errorId, System.Exception
                innerException, string
                message, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ScriptBlockToPowerShellNotSupportedException(errorId, innerException, message, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 2984, 3143);
                    return return_v;
                }


                int
                f_1564_2951_3177(System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                ex, System.Management.Automation.Language.CommandAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 2951, 3177);
                    return 0;
                }


                System.Management.Automation.Language.Ast
                f_1564_3690_3707(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 3690, 3707);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1564_3690_3714(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 3690, 3714);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1564_3690_3721(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 3690, 3721);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1564_3725_3745()
                {
                    var return_v = ScriptBeingConverted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 3725, 3745);
                    return return_v;
                }


                string
                f_1564_3930_3984()
                {
                    var return_v = AutomationExceptions.CantConvertWithCommandInvocations;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 3930, 3984);
                    return return_v;
                }


                System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                f_1564_3812_3985(string
                errorId, System.Exception
                innerException, string
                message, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ScriptBlockToPowerShellNotSupportedException(errorId, innerException, message, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 3812, 3985);
                    return return_v;
                }


                int
                f_1564_3779_4019(System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                ex, System.Management.Automation.Language.CommandAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 3779, 4019);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1564_4055_4081(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 4055, 4081);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1564_4055_4084(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 4055, 4084);
                    return return_v;
                }


                string
                f_1564_4325_4382()
                {
                    var return_v = AutomationExceptions.CantConvertWithScriptBlockInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 4325, 4382);
                    return return_v;
                }


                System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                f_1564_4179_4383(string
                errorId, System.Exception
                innerException, string
                message, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ScriptBlockToPowerShellNotSupportedException(errorId, innerException, message, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 4179, 4383);
                    return return_v;
                }


                int
                f_1564_4146_4417(System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                ex, System.Management.Automation.Language.CommandAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 4146, 4417);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 2776, 4491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 2776, 4491);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitMergingRedirection(MergingRedirectionAst redirectionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 4503, 5019);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 4620, 4961) || true) && (f_1564_4624_4647(redirectionAst) != RedirectionStream.Output)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 4620, 4961);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 4709, 4946);

                    f_1564_4709_4945(f_1564_4742_4907("CanConvertOneOutputErrorRedir", null, f_1564_4856_4906()), redirectionAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 4620, 4961);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 4977, 5008);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 4503, 5019);

                System.Management.Automation.Language.RedirectionStream
                f_1564_4624_4647(System.Management.Automation.Language.MergingRedirectionAst
                this_param)
                {
                    var return_v = this_param.ToStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 4624, 4647);
                    return return_v;
                }


                string
                f_1564_4856_4906()
                {
                    var return_v = AutomationExceptions.CanConvertOneOutputErrorRedir;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 4856, 4906);
                    return return_v;
                }


                System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                f_1564_4742_4907(string
                errorId, System.Exception
                innerException, string
                message, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ScriptBlockToPowerShellNotSupportedException(errorId, innerException, message, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 4742, 4907);
                    return return_v;
                }


                int
                f_1564_4709_4945(System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                ex, System.Management.Automation.Language.MergingRedirectionAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 4709, 4945);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 4503, 5019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 4503, 5019);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitFileRedirection(FileRedirectionAst redirectionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 5031, 5425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 5142, 5367);

                f_1564_5142_5366(f_1564_5171_5332("CanConvertOneOutputErrorRedir", null, f_1564_5281_5331()), redirectionAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 5383, 5414);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 5031, 5425);

                string
                f_1564_5281_5331()
                {
                    var return_v = AutomationExceptions.CanConvertOneOutputErrorRedir;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 5281, 5331);
                    return return_v;
                }


                System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                f_1564_5171_5332(string
                errorId, System.Exception
                innerException, string
                message, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ScriptBlockToPowerShellNotSupportedException(errorId, innerException, message, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 5171, 5332);
                    return return_v;
                }


                int
                f_1564_5142_5366(System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                ex, System.Management.Automation.Language.FileRedirectionAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 5142, 5366);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 5031, 5425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 5031, 5425);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitVariableExpression(VariableExpressionAst variableExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 5437, 6388);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 5561, 5610);

                bool
                usesParameterReference = f_1564_5591_5609(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 5624, 5725);

                bool
                ok = f_1564_5634_5724(variableExpressionAst, _validVariables, ref usesParameterReference)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 5739, 5880) || true) && (usesParameterReference != f_1564_5769_5787(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 5739, 5880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 5821, 5865);

                    this.UsesParameter = usesParameterReference;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 5739, 5880);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 5896, 6330) || true) && (!ok)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 5896, 6330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 5937, 6315);

                    f_1564_5937_6314(f_1564_5948_6262("CantConvertWithUndeclaredVariables", null, f_1564_6138_6193(), f_1564_6227_6261(variableExpressionAst)), variableExpressionAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 5896, 6330);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 6346, 6377);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 5437, 6388);

                bool
                f_1564_5591_5609(System.Management.Automation.ScriptBlockToPowerShellChecker
                this_param)
                {
                    var return_v = this_param.UsesParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 5591, 5609);
                    return return_v;
                }


                bool
                f_1564_5634_5724(System.Management.Automation.Language.VariableExpressionAst
                this_param, System.Collections.Generic.HashSet<string>
                validVariables, ref bool
                usesParameter)
                {
                    var return_v = this_param.IsSafeVariableReference(validVariables, ref usesParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 5634, 5724);
                    return return_v;
                }


                bool
                f_1564_5769_5787(System.Management.Automation.ScriptBlockToPowerShellChecker
                this_param)
                {
                    var return_v = this_param.UsesParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 5769, 5787);
                    return return_v;
                }


                string
                f_1564_6138_6193()
                {
                    var return_v = AutomationExceptions.CantConvertWithUndeclaredVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 6138, 6193);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1564_6227_6261(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 6227, 6261);
                    return return_v;
                }


                System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                f_1564_5948_6262(string
                errorId, System.Exception
                innerException, string
                message, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ScriptBlockToPowerShellNotSupportedException(errorId, innerException, message, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 5948, 6262);
                    return return_v;
                }


                int
                f_1564_5937_6314(System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                ex, System.Management.Automation.Language.VariableExpressionAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 5937, 6314);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 5437, 6388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 5437, 6388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 6400, 6878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 6533, 6816);

                f_1564_6533_6815(f_1564_6544_6764("CantConvertWithScriptBlocks", null, f_1564_6715_6763()), scriptBlockExpressionAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 6832, 6867);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 6400, 6878);

                string
                f_1564_6715_6763()
                {
                    var return_v = AutomationExceptions.CantConvertWithScriptBlocks;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 6715, 6763);
                    return return_v;
                }


                System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                f_1564_6544_6764(string
                errorId, System.Exception
                innerException, string
                message, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ScriptBlockToPowerShellNotSupportedException(errorId, innerException, message, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 6544, 6764);
                    return return_v;
                }


                int
                f_1564_6533_6815(System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                ex, System.Management.Automation.Language.ScriptBlockExpressionAst
                ast)
                {
                    ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 6533, 6815);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 6400, 6878);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 6400, 6878);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitUsingExpression(UsingExpressionAst usingExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 6890, 7360);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 7103, 7123);

                HasUsingExpr = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 7314, 7349);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 6890, 7360);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 6890, 7360);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 6890, 7360);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void ThrowError(ScriptBlockToPowerShellNotSupportedException ex, Ast ast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1564, 7372, 7588);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 7486, 7554);

                f_1564_7486_7553(ex, f_1564_7542_7552(ast));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 7568, 7577);

                throw ex;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1564, 7372, 7588);

                System.Management.Automation.Language.IScriptExtent
                f_1564_7542_7552(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 7542, 7552);
                    return return_v;
                }


                int
                f_1564_7486_7553(System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                exception, System.Management.Automation.Language.IScriptExtent
                extent)
                {
                    InterpreterError.UpdateExceptionErrorRecordPosition((System.Exception)exception, extent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 7486, 7553);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 7372, 7588);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 7372, 7588);
            }
        }

        public ScriptBlockToPowerShellChecker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1564, 451, 7595);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 559, 630);
            this._validVariables = f_1564_577_630(f_1564_597_629());
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 643, 701);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 711, 760);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 772, 820);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1564, 451, 7595);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 451, 7595);
        }


        static ScriptBlockToPowerShellChecker()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1564, 451, 7595);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1564, 451, 7595);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 451, 7595);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1564, 451, 7595);

        System.StringComparer
        f_1564_597_629()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 597, 629);
            return return_v;
        }


        System.Collections.Generic.HashSet<string>
        f_1564_577_630(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 577, 630);
            return return_v;
        }

    }
    internal class UsingExpressionAstSearcher : AstSearcher
    {
        internal static IEnumerable<Ast> FindAllUsingExpressionExceptForWorkflow(Ast ast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1564, 7675, 8092);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 7781, 7843);

                f_1564_7781_7842(ast != null, "caller to verify arguments");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 7859, 8001);

                var
                searcher = f_1564_7874_8000(astParam => astParam is UsingExpressionAst, stopOnFirst: false, searchNestedScriptBlocks: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 8015, 8043);

                f_1564_8015_8042(ast, searcher);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 8057, 8081);

                return searcher.Results;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1564, 7675, 8092);

                int
                f_1564_7781_7842(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 7781, 7842);
                    return 0;
                }


                System.Management.Automation.UsingExpressionAstSearcher
                f_1564_7874_8000(System.Func<System.Management.Automation.Language.Ast, bool>
                callback, bool
                stopOnFirst, bool
                searchNestedScriptBlocks)
                {
                    var return_v = new System.Management.Automation.UsingExpressionAstSearcher(callback, stopOnFirst: stopOnFirst, searchNestedScriptBlocks: searchNestedScriptBlocks);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 7874, 8000);
                    return return_v;
                }


                System.Management.Automation.Language.AstVisitAction
                f_1564_8015_8042(System.Management.Automation.Language.Ast
                this_param, System.Management.Automation.UsingExpressionAstSearcher
                visitor)
                {
                    var return_v = this_param.InternalVisit((System.Management.Automation.Language.AstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 8015, 8042);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 7675, 8092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 7675, 8092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private UsingExpressionAstSearcher(Func<Ast, bool> callback, bool stopOnFirst, bool searchNestedScriptBlocks)
        : base(f_1564_8234_8242_C(callback), stopOnFirst, searchNestedScriptBlocks)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1564, 8104, 8304);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1564, 8104, 8304);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 8104, 8304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 8104, 8304);
            }
        }

        public override AstVisitAction VisitFunctionDefinition(FunctionDefinitionAst ast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 8316, 8675);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 8517, 8619) || true) && (f_1564_8521_8535(ast))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 8517, 8619);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 8569, 8604);

                    return AstVisitAction.SkipChildren;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 8517, 8619);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 8635, 8664);

                return f_1564_8642_8663(this, ast);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 8316, 8675);

                bool
                f_1564_8521_8535(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.IsWorkflow;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 8521, 8535);
                    return return_v;
                }


                System.Management.Automation.Language.AstVisitAction
                f_1564_8642_8663(System.Management.Automation.UsingExpressionAstSearcher
                this_param, System.Management.Automation.Language.FunctionDefinitionAst
                ast)
                {
                    var return_v = this_param.CheckScriptBlock((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 8642, 8663);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 8316, 8675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 8316, 8675);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static UsingExpressionAstSearcher()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1564, 7603, 8682);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1564, 7603, 8682);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 7603, 8682);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1564, 7603, 8682);

        static System.Func<System.Management.Automation.Language.Ast, bool>
        f_1564_8234_8242_C(System.Func<System.Management.Automation.Language.Ast, bool>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1564, 8104, 8304);
            return return_v;
        }

    }
    internal class ScriptBlockToPowerShellConverter
    {
        private readonly PowerShell _powershell;

        private ExecutionContext _context;

        private Dictionary<string, object> _usingValueMap;

        private bool? _createLocalScope;

        private ScriptBlockToPowerShellConverter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1564, 9084, 9196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 8914, 8925);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 8961, 8969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 9015, 9029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 9054, 9071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 9151, 9185);

                _powershell = f_1564_9165_9184();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1564, 9084, 9196);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 9084, 9196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 9084, 9196);
            }
        }

        internal static PowerShell Convert(ScriptBlockAst body,
                                                   ReadOnlyCollection<ParameterAst> functionParameters,
                                                   bool isTrustedInput,
                                                   ExecutionContext context,
                                                   Dictionary<string, object> variables,
                                                   bool filterNonUsingVariables,
                                                   bool? createLocalScope,
                                                   object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1564, 9208, 14203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 9803, 9838);

                f_1564_9803_9837();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 9854, 9948) || true) && (args == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 9854, 9948);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 9904, 9933);

                    args = f_1564_9911_9932();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 9854, 9948);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 10456, 10471);

                string
                errorId
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 10485, 10501);

                string
                errorMsg
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 10515, 10571);

                f_1564_10515_10570(body, true, out errorId, out errorMsg);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 10585, 10733) || true) && (errorId != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 10585, 10733);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 10638, 10718);

                    throw f_1564_10644_10717(errorId, null, errorMsg);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 10585, 10733);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 10749, 10830);

                var
                checker = new ScriptBlockToPowerShellChecker { ScriptBeingConverted = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => body, 1564, 10763, 10829) }
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 10844, 11061) || true) && (functionParameters != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 10844, 11061);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 10908, 11046);
                        foreach (var parameter in f_1564_10934_10952_I(functionParameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 10908, 11046);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 10994, 11027);

                            f_1564_10994_11026(parameter, checker);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 10908, 11046);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1564, 1, 139);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1564, 1, 139);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 10844, 11061);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 11077, 11105);

                f_1564_11077_11104(
                            body, checker);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 11326, 11564) || true) && (context == null && (DynAbs.Tracing.TraceSender.Expression_True(1564, 11330, 11396) && (f_1564_11350_11370(checker) || (DynAbs.Tracing.TraceSender.Expression_False(1564, 11350, 11395) || f_1564_11374_11395(checker)))) && (DynAbs.Tracing.TraceSender.Expression_True(1564, 11330, 11419) && (variables == null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 11326, 11564);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 11453, 11549);

                    throw f_1564_11459_11548(f_1564_11491_11547());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 11326, 11564);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 11616, 11730);

                    var
                    converter = new ScriptBlockToPowerShellConverter { _context = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => context, 1564, 11632, 11729), _createLocalScope = createLocalScope }
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 11750, 11950) || true) && (f_1564_11754_11774(checker))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 11750, 11950);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 11816, 11931);

                        converter._usingValueMap = f_1564_11843_11930(f_1564_11843_11924(body, isTrustedInput, context, variables, filterNonUsingVariables));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 11750, 11950);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 11970, 13630) || true) && (f_1564_11974_11995(checker))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 11970, 13630);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 12138, 12196);

                        var
                        newScope = f_1564_12153_12195(f_1564_12153_12179(context), false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 12218, 12269);

                        f_1564_12218_12244(context).CurrentScope = newScope;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 12291, 12368);

                        f_1564_12291_12330(f_1564_12291_12317(context)).ScopeOrigin = CommandOrigin.Internal;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 12392, 12520);

                        var
                        locals =
                        f_1564_12430_12519(Compiler.DottedLocalsTupleType, Compiler.DottedLocalsNameIndexMap)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 12913, 12944);

                        bool
                        usesCmdletBinding = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 12966, 13262);

                        var
                        parameters = (DynAbs.Tracing.TraceSender.Conditional_F1(1564, 12983, 13009) || ((functionParameters != null
                        && DynAbs.Tracing.TraceSender.Conditional_F2(1564, 13054, 13132)) || DynAbs.Tracing.TraceSender.Conditional_F3(1564, 13177, 13261))) ? f_1564_13054_13132(functionParameters, true, ref usesCmdletBinding) : f_1564_13177_13261(((IParameterMetadataProvider)body), true, ref usesCmdletBinding)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 13284, 13461);

                        object[]
                        remainingArgs = f_1564_13309_13460(f_1564_13408_13423(parameters), args, context, false, null, locals)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 13483, 13559);

                        f_1564_13483_13558(locals, AutomaticVariable.Args, remainingArgs, context);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 13581, 13611);

                        newScope.LocalsTuple = locals;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 11970, 13630);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 13650, 13893);
                        foreach (var pipeline in f_1564_13675_13721_I(f_1564_13675_13721(f_1564_13675_13699(f_1564_13675_13688(body)))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 13650, 13893);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 13763, 13800);

                            f_1564_13763_13799(converter._powershell);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 13822, 13874);

                            f_1564_13822_13873(converter, pipeline, isTrustedInput);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 13650, 13893);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1564, 1, 244);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1564, 1, 244);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 13913, 13942);

                    return converter._powershell;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1564, 13971, 14192);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 14011, 14177) || true) && (f_1564_14015_14036(checker))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 14011, 14177);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 14078, 14158);

                        f_1564_14078_14157(f_1564_14078_14104(context), f_1564_14117_14156(f_1564_14117_14143(context)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 14011, 14177);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1564, 13971, 14192);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1564, 9208, 14203);

                int
                f_1564_9803_9837()
                {
                    ExecutionContext.CheckStackDepth();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 9803, 9837);
                    return 0;
                }


                object[]
                f_1564_9911_9932()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 9911, 9932);
                    return return_v;
                }


                System.Management.Automation.Language.PipelineAst
                f_1564_10515_10570(System.Management.Automation.Language.ScriptBlockAst
                this_param, bool
                allowMultiplePipelines, out string
                errorId, out string
                errorMsg)
                {
                    var return_v = this_param.GetSimplePipeline(allowMultiplePipelines, out errorId, out errorMsg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 10515, 10570);
                    return return_v;
                }


                System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                f_1564_10644_10717(string
                errorId, System.Exception
                innerException, string
                message, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ScriptBlockToPowerShellNotSupportedException(errorId, innerException, message, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 10644, 10717);
                    return return_v;
                }


                System.Management.Automation.Language.AstVisitAction
                f_1564_10994_11026(System.Management.Automation.Language.ParameterAst
                this_param, System.Management.Automation.ScriptBlockToPowerShellChecker
                visitor)
                {
                    var return_v = this_param.InternalVisit((System.Management.Automation.Language.AstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 10994, 11026);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                f_1564_10934_10952_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 10934, 10952);
                    return return_v;
                }


                System.Management.Automation.Language.AstVisitAction
                f_1564_11077_11104(System.Management.Automation.Language.ScriptBlockAst
                this_param, System.Management.Automation.ScriptBlockToPowerShellChecker
                visitor)
                {
                    var return_v = this_param.InternalVisit((System.Management.Automation.Language.AstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 11077, 11104);
                    return return_v;
                }


                bool
                f_1564_11350_11370(System.Management.Automation.ScriptBlockToPowerShellChecker
                this_param)
                {
                    var return_v = this_param.HasUsingExpr;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 11350, 11370);
                    return return_v;
                }


                bool
                f_1564_11374_11395(System.Management.Automation.ScriptBlockToPowerShellChecker
                this_param)
                {
                    var return_v = this_param.UsesParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 11374, 11395);
                    return return_v;
                }


                string
                f_1564_11491_11547()
                {
                    var return_v = AutomationExceptions.CantConvertScriptBlockWithNoContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 11491, 11547);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1564_11459_11548(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 11459, 11548);
                    return return_v;
                }


                bool
                f_1564_11754_11774(System.Management.Automation.ScriptBlockToPowerShellChecker
                this_param)
                {
                    var return_v = this_param.HasUsingExpr;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 11754, 11774);
                    return return_v;
                }


                System.Tuple<System.Collections.Generic.Dictionary<string, object>, object[]>
                f_1564_11843_11924(System.Management.Automation.Language.ScriptBlockAst
                body, bool
                isTrustedInput, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.Dictionary<string, object>
                variables, bool
                filterNonUsingVariables)
                {
                    var return_v = GetUsingValues((System.Management.Automation.Language.Ast)body, isTrustedInput, context, variables, filterNonUsingVariables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 11843, 11924);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1564_11843_11930(System.Tuple<System.Collections.Generic.Dictionary<string, object>, object[]>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 11843, 11930);
                    return return_v;
                }


                bool
                f_1564_11974_11995(System.Management.Automation.ScriptBlockToPowerShellChecker
                this_param)
                {
                    var return_v = this_param.UsesParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 11974, 11995);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1564_12153_12179(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 12153, 12179);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1564_12153_12195(System.Management.Automation.SessionStateInternal
                this_param, bool
                isScriptScope)
                {
                    var return_v = this_param.NewScope(isScriptScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 12153, 12195);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1564_12218_12244(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 12218, 12244);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1564_12291_12317(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 12291, 12317);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1564_12291_12330(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 12291, 12330);
                    return return_v;
                }


                System.Management.Automation.MutableTuple
                f_1564_12430_12519(System.Type
                tupleType, System.Collections.Generic.Dictionary<string, int>
                nameToIndexMap)
                {
                    var return_v = MutableTuple.MakeTuple(tupleType, nameToIndexMap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 12430, 12519);
                    return return_v;
                }


                System.Management.Automation.RuntimeDefinedParameterDictionary
                f_1564_13054_13132(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                parameters, bool
                automaticPositions, ref bool
                usesCmdletBinding)
                {
                    var return_v = Compiler.GetParameterMetaData(parameters, automaticPositions, ref usesCmdletBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 13054, 13132);
                    return return_v;
                }


                System.Management.Automation.RuntimeDefinedParameterDictionary
                f_1564_13177_13261(System.Management.Automation.Language.IParameterMetadataProvider
                this_param, bool
                automaticPositions, ref bool
                usesCmdletBinding)
                {
                    var return_v = this_param.GetParameterMetadata(automaticPositions, ref usesCmdletBinding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 13177, 13261);
                    return return_v;
                }


                object
                f_1564_13408_13423(System.Management.Automation.RuntimeDefinedParameterDictionary
                this_param)
                {
                    var return_v = this_param.Data;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 13408, 13423);
                    return return_v;
                }


                object[]
                f_1564_13309_13460(object
                parameters, object[]
                args, System.Management.Automation.ExecutionContext
                context, bool
                dotting, System.Collections.Generic.Dictionary<string, System.Management.Automation.PSVariable>
                backupWhenDotting, System.Management.Automation.MutableTuple
                locals)
                {
                    var return_v = ScriptBlock.BindArgumentsForScriptblockInvoke((System.Management.Automation.RuntimeDefinedParameter[])parameters, args, context, dotting, backupWhenDotting, locals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 13309, 13460);
                    return return_v;
                }


                int
                f_1564_13483_13558(System.Management.Automation.MutableTuple
                this_param, System.Management.Automation.AutomaticVariable
                auto, object[]
                value, System.Management.Automation.ExecutionContext
                context)
                {
                    this_param.SetAutomaticVariable(auto, (object)value, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 13483, 13558);
                    return 0;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1564_13675_13688(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 13675, 13688);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                f_1564_13675_13699(System.Management.Automation.Language.NamedBlockAst
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 13675, 13699);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.PipelineAst>
                f_1564_13675_13721(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                source)
                {
                    var return_v = source.OfType<System.Management.Automation.Language.PipelineAst>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 13675, 13721);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1564_13763_13799(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.AddStatement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 13763, 13799);
                    return return_v;
                }


                int
                f_1564_13822_13873(System.Management.Automation.ScriptBlockToPowerShellConverter
                this_param, System.Management.Automation.Language.PipelineAst
                pipelineAst, bool
                isTrustedInput)
                {
                    this_param.ConvertPipeline(pipelineAst, isTrustedInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 13822, 13873);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.PipelineAst>
                f_1564_13675_13721_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.PipelineAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 13675, 13721);
                    return return_v;
                }


                bool
                f_1564_14015_14036(System.Management.Automation.ScriptBlockToPowerShellChecker
                this_param)
                {
                    var return_v = this_param.UsesParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 14015, 14036);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1564_14078_14104(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 14078, 14104);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1564_14117_14143(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 14117, 14143);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1564_14117_14156(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 14117, 14156);
                    return return_v;
                }


                int
                f_1564_14078_14157(System.Management.Automation.SessionStateInternal
                this_param, System.Management.Automation.SessionStateScope
                scope)
                {
                    this_param.RemoveScope(scope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 14078, 14157);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 9208, 14203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 9208, 14203);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Dictionary<string, object> GetUsingValuesAsDictionary(ScriptBlock scriptBlock, bool isTrustedInput, ExecutionContext context, Dictionary<string, object> variables)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1564, 14316, 14619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 14520, 14608);

                return f_1564_14527_14607(f_1564_14527_14601(f_1564_14542_14557(scriptBlock), isTrustedInput, context, variables, false));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1564, 14316, 14619);

                System.Management.Automation.Language.Ast
                f_1564_14542_14557(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 14542, 14557);
                    return return_v;
                }


                System.Tuple<System.Collections.Generic.Dictionary<string, object>, object[]>
                f_1564_14527_14601(System.Management.Automation.Language.Ast
                body, bool
                isTrustedInput, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.Dictionary<string, object>
                variables, bool
                filterNonUsingVariables)
                {
                    var return_v = GetUsingValues(body, isTrustedInput, context, variables, filterNonUsingVariables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 14527, 14601);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1564_14527_14607(System.Tuple<System.Collections.Generic.Dictionary<string, object>, object[]>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 14527, 14607);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 14316, 14619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 14316, 14619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object[] GetUsingValuesAsArray(ScriptBlock scriptBlock, bool isTrustedInput, ExecutionContext context, Dictionary<string, object> variables)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1564, 14727, 15007);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 14908, 14996);

                return f_1564_14915_14995(f_1564_14915_14989(f_1564_14930_14945(scriptBlock), isTrustedInput, context, variables, false));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1564, 14727, 15007);

                System.Management.Automation.Language.Ast
                f_1564_14930_14945(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.Ast;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 14930, 14945);
                    return return_v;
                }


                System.Tuple<System.Collections.Generic.Dictionary<string, object>, object[]>
                f_1564_14915_14989(System.Management.Automation.Language.Ast
                body, bool
                isTrustedInput, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.Dictionary<string, object>
                variables, bool
                filterNonUsingVariables)
                {
                    var return_v = GetUsingValues(body, isTrustedInput, context, variables, filterNonUsingVariables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 14915, 14989);
                    return return_v;
                }


                object[]
                f_1564_14915_14995(System.Tuple<System.Collections.Generic.Dictionary<string, object>, object[]>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 14915, 14995);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 14727, 15007);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 14727, 15007);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Tuple<Dictionary<string, object>, object[]> GetUsingValues(Ast body, bool isTrustedInput, ExecutionContext context, Dictionary<string, object> variables, bool filterNonUsingVariables)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1564, 16090, 21874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 16313, 16431);

                f_1564_16313_16430(context != null || (DynAbs.Tracing.TraceSender.Expression_False(1564, 16332, 16368) || variables != null), "can't retrieve variables with no context and no variables");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 16447, 16545);

                var
                usingAsts = f_1564_16463_16544(f_1564_16463_16535(body))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 16559, 16609);

                var
                usingValueArray = new object[f_1564_16592_16607(usingAsts)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 16623, 16691);

                var
                usingValueMap = f_1564_16643_16690(f_1564_16674_16689(usingAsts))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 16705, 16815);

                HashSet<string>
                usingVarNames = (DynAbs.Tracing.TraceSender.Conditional_F1(1564, 16737, 16783) || (((variables != null && (DynAbs.Tracing.TraceSender.Expression_True(1564, 16738, 16782) && filterNonUsingVariables)) && DynAbs.Tracing.TraceSender.Conditional_F2(1564, 16786, 16807)) || DynAbs.Tracing.TraceSender.Conditional_F3(1564, 16810, 16814))) ? f_1564_16786_16807() : null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 16935, 16977);

                bool
                hasUsingExprInDifferentScope = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 16991, 17037);

                ScriptBlockAst
                sbClosestToPreUsingExpr = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 17053, 17088);

                UsingExpressionAst
                usingAst = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 17102, 17134);

                Version
                oldStrictVersion = null
                ;
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 17184, 17447) || true) && (context != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 17184, 17447);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 17245, 17322);

                        oldStrictVersion = f_1564_17264_17321(f_1564_17264_17303(f_1564_17264_17290(context)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 17344, 17428);

                        f_1564_17344_17383(f_1564_17344_17370(context)).StrictModeVersion = f_1564_17404_17427();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 17184, 17447);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 17476, 17481);

                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 17467, 20370) || true) && (i < f_1564_17487_17502(usingAsts))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 17504, 17507)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 17467, 20370))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 17467, 20370);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 17549, 17593);

                            usingAst = (UsingExpressionAst)f_1564_17580_17592(usingAsts, i);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 17615, 17635);

                            object
                            value = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 17784, 18802) || true) && (!hasUsingExprInDifferentScope && (DynAbs.Tracing.TraceSender.Expression_True(1564, 17788, 17902) && f_1564_17821_17902(usingAst, body, ref sbClosestToPreUsingExpr)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 17784, 18802);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 18743, 18779);

                                hasUsingExprInDifferentScope = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 17784, 18802);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 18826, 19903) || true) && (variables != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 18826, 19903);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 18897, 18963);

                                var
                                variableAst = f_1564_18915_18937(usingAst) as VariableExpressionAst
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 18989, 19391) || true) && (variableAst == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 18989, 19391);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 19070, 19364);

                                    throw f_1564_19076_19363(null, typeof(RuntimeException), f_1564_19182_19197(usingAst), "CantGetUsingExpressionValueWithSpecifiedVariableDictionary", f_1564_19261_19340(), f_1564_19342_19362(f_1564_19342_19357(usingAst)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 18989, 19391);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 19419, 19470);

                                string
                                varName = f_1564_19436_19469(f_1564_19436_19460(variableAst))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 19496, 19697) || true) && (varName != null && (DynAbs.Tracing.TraceSender.Expression_True(1564, 19500, 19560) && f_1564_19519_19560(variables, varName, out value)) && (DynAbs.Tracing.TraceSender.Expression_True(1564, 19500, 19585) && usingVarNames != null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 19496, 19697);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 19643, 19670);

                                    f_1564_19643_19669(usingVarNames, varName);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 19496, 19697);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 18826, 19903);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 18826, 19903);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 19795, 19880);

                                value = f_1564_19803_19879(f_1564_19831_19853(usingAst), isTrustedInput, context);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 18826, 19903);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 19993, 20020);

                            usingValueArray[i] = value;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 20114, 20175);

                            string
                            usingAstKey = f_1564_20135_20174(usingAst)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 20197, 20351) || true) && (!f_1564_20202_20240(usingValueMap, usingAstKey))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 20197, 20351);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 20290, 20328);

                                f_1564_20290_20327(usingValueMap, usingAstKey, value);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 20197, 20351);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1564, 1, 2904);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1564, 1, 2904);
                    }
                }
                catch (RuntimeException rte)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1564, 20399, 21085);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 20460, 21070) || true) && (f_1564_20464_20557(f_1564_20464_20501(f_1564_20464_20479(rte)), "VariableIsUndefined", StringComparison.Ordinal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 20460, 21070);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 20599, 20825);

                        throw f_1564_20605_20824(null, typeof(RuntimeException), f_1564_20703_20718(usingAst), "UsingVariableIsUndefined", f_1564_20748_20793(), f_1564_20795_20823(f_1564_20795_20810(rte)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 20460, 21070);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 20460, 21070);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 20867, 21070) || true) && (f_1564_20871_21003(f_1564_20871_20908(f_1564_20871_20886(rte)), "CantGetUsingExpressionValueWithSpecifiedVariableDictionary", StringComparison.Ordinal))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 20867, 21070);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 21045, 21051);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 20867, 21070);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 20460, 21070);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1564, 20399, 21085);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1564, 21099, 21311);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 21139, 21296) || true) && (context != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 21139, 21296);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 21200, 21277);

                        f_1564_21200_21239(f_1564_21200_21226(context)).StrictModeVersion = oldStrictVersion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 21139, 21296);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1564, 21099, 21311);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 21327, 21675) || true) && (usingVarNames != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 21327, 21675);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 21386, 21427);

                    string[]
                    keys = f_1564_21402_21426(f_1564_21402_21416(variables))
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 21445, 21660);
                        foreach (string key in f_1564_21468_21472_I(keys))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 21445, 21660);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 21514, 21641) || true) && (!f_1564_21519_21546(usingVarNames, key))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 21514, 21641);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 21596, 21618);

                                f_1564_21596_21617(variables, key);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 21514, 21641);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 21445, 21660);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1564, 1, 216);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1564, 1, 216);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 21327, 21675);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 21691, 21795) || true) && (hasUsingExprInDifferentScope)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 21691, 21795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 21757, 21780);

                    usingValueArray = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 21691, 21795);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 21811, 21863);

                return f_1564_21818_21862(usingValueMap, usingValueArray);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1564, 16090, 21874);

                int
                f_1564_16313_16430(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 16313, 16430);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                f_1564_16463_16535(System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = UsingExpressionAstSearcher.FindAllUsingExpressionExceptForWorkflow(ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 16463, 16535);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1564_16463_16544(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.Ast>
                source)
                {
                    var return_v = source.ToList<System.Management.Automation.Language.Ast>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 16463, 16544);
                    return return_v;
                }


                int
                f_1564_16592_16607(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 16592, 16607);
                    return return_v;
                }


                int
                f_1564_16674_16689(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 16674, 16689);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1564_16643_16690(int
                capacity)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, object>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 16643, 16690);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1564_16786_16807()
                {
                    var return_v = new System.Collections.Generic.HashSet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 16786, 16807);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1564_17264_17290(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 17264, 17290);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1564_17264_17303(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 17264, 17303);
                    return return_v;
                }


                System.Version
                f_1564_17264_17321(System.Management.Automation.SessionStateScope
                this_param)
                {
                    var return_v = this_param.StrictModeVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 17264, 17321);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1564_17344_17370(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 17344, 17370);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1564_17344_17383(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 17344, 17383);
                    return return_v;
                }


                System.Version
                f_1564_17404_17427()
                {
                    var return_v = PSVersionInfo.PSVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 17404, 17427);
                    return return_v;
                }


                int
                f_1564_17487_17502(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 17487, 17502);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1564_17580_17592(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 17580, 17592);
                    return return_v;
                }


                bool
                f_1564_17821_17902(System.Management.Automation.Language.UsingExpressionAst
                usingExpr, System.Management.Automation.Language.Ast
                topLevelParent, ref System.Management.Automation.Language.ScriptBlockAst
                sbClosestToPreviousUsingExpr)
                {
                    var return_v = HasUsingExpressionsInDifferentScopes(usingExpr, topLevelParent, ref sbClosestToPreviousUsingExpr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 17821, 17902);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1564_18915_18937(System.Management.Automation.Language.UsingExpressionAst
                this_param)
                {
                    var return_v = this_param.SubExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 18915, 18937);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1564_19182_19197(System.Management.Automation.Language.UsingExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 19182, 19197);
                    return return_v;
                }


                string
                f_1564_19261_19340()
                {
                    var return_v = AutomationExceptions.CantGetUsingExpressionValueWithSpecifiedVariableDictionary;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 19261, 19340);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1564_19342_19357(System.Management.Automation.Language.UsingExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 19342, 19357);
                    return return_v;
                }


                string
                f_1564_19342_19362(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 19342, 19362);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1564_19076_19363(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 19076, 19363);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1564_19436_19460(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 19436, 19460);
                    return return_v;
                }


                string
                f_1564_19436_19469(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UserPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 19436, 19469);
                    return return_v;
                }


                bool
                f_1564_19519_19560(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 19519, 19560);
                    return return_v;
                }


                bool
                f_1564_19643_19669(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 19643, 19669);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1564_19831_19853(System.Management.Automation.Language.UsingExpressionAst
                this_param)
                {
                    var return_v = this_param.SubExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 19831, 19853);
                    return return_v;
                }


                object
                f_1564_19803_19879(System.Management.Automation.Language.ExpressionAst
                expressionAst, bool
                isTrustedInput, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = Compiler.GetExpressionValue(expressionAst, isTrustedInput, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 19803, 19879);
                    return return_v;
                }


                string
                f_1564_20135_20174(System.Management.Automation.Language.UsingExpressionAst
                usingAst)
                {
                    var return_v = PsUtils.GetUsingExpressionKey(usingAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 20135, 20174);
                    return return_v;
                }


                bool
                f_1564_20202_20240(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 20202, 20240);
                    return return_v;
                }


                int
                f_1564_20290_20327(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 20290, 20327);
                    return 0;
                }


                System.Management.Automation.ErrorRecord
                f_1564_20464_20479(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 20464, 20479);
                    return return_v;
                }


                string
                f_1564_20464_20501(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 20464, 20501);
                    return return_v;
                }


                bool
                f_1564_20464_20557(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 20464, 20557);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1564_20703_20718(System.Management.Automation.Language.UsingExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 20703, 20718);
                    return return_v;
                }


                string
                f_1564_20748_20793()
                {
                    var return_v = AutomationExceptions.UsingVariableIsUndefined;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 20748, 20793);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1564_20795_20810(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 20795, 20810);
                    return return_v;
                }


                object
                f_1564_20795_20823(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.TargetObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 20795, 20823);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1564_20605_20824(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 20605, 20824);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1564_20871_20886(System.Management.Automation.RuntimeException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 20871, 20886);
                    return return_v;
                }


                string
                f_1564_20871_20908(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.FullyQualifiedErrorId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 20871, 20908);
                    return return_v;
                }


                bool
                f_1564_20871_21003(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 20871, 21003);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1564_21200_21226(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 21200, 21226);
                    return return_v;
                }


                System.Management.Automation.SessionStateScope
                f_1564_21200_21239(System.Management.Automation.SessionStateInternal
                this_param)
                {
                    var return_v = this_param.CurrentScope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 21200, 21239);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>.KeyCollection
                f_1564_21402_21416(System.Collections.Generic.Dictionary<string, object>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 21402, 21416);
                    return return_v;
                }


                string[]
                f_1564_21402_21426(System.Collections.Generic.Dictionary<string, object>.KeyCollection
                source)
                {
                    var return_v = source.ToArray<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 21402, 21426);
                    return return_v;
                }


                bool
                f_1564_21519_21546(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 21519, 21546);
                    return return_v;
                }


                bool
                f_1564_21596_21617(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 21596, 21617);
                    return return_v;
                }


                string[]
                f_1564_21468_21472_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 21468, 21472);
                    return return_v;
                }


                System.Tuple<System.Collections.Generic.Dictionary<string, object>, object[]>
                f_1564_21818_21862(System.Collections.Generic.Dictionary<string, object>
                item1, object[]
                item2)
                {
                    var return_v = Tuple.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 21818, 21862);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 16090, 21874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 16090, 21874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool HasUsingExpressionsInDifferentScopes(UsingExpressionAst usingExpr, Ast topLevelParent, ref ScriptBlockAst sbClosestToPreviousUsingExpr)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1564, 22703, 25992);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 22883, 23079);

                f_1564_22883_23078(topLevelParent is ScriptBlockAst || (DynAbs.Tracing.TraceSender.Expression_False(1564, 22902, 22977) || topLevelParent is FunctionDefinitionAst), "the top level parent should be either a ScriptBlockAst or FunctionDefinitionAst");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 23209, 23233);

                Ast
                current = usingExpr
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 23247, 25653);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 23282, 23307);

                            current = f_1564_23292_23306(current);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 23327, 23365);

                            var
                            sbAst = current as ScriptBlockAst
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 23383, 24362) || true) && (sbAst != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 23383, 24362);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 23633, 23911) || true) && (sbClosestToPreviousUsingExpr == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 23633, 23911);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 23812, 23849);

                                    sbClosestToPreviousUsingExpr = sbAst;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 23875, 23888);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 23633, 23911);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 23935, 24184) || true) && (sbAst == sbClosestToPreviousUsingExpr)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 23935, 24184);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 24148, 24161);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 23935, 24184);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 24331, 24343);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 23383, 24362);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 24382, 24429);

                            var
                            funcAst = current as FunctionDefinitionAst
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 24447, 25603) || true) && (funcAst != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 24447, 25603);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 24860, 25145) || true) && (sbClosestToPreviousUsingExpr == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 24860, 25145);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 25039, 25083);

                                    sbClosestToPreviousUsingExpr = f_1564_25070_25082(funcAst);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 25109, 25122);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 24860, 25145);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 25169, 25425) || true) && (f_1564_25173_25185(funcAst) == sbClosestToPreviousUsingExpr)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 25169, 25425);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 25389, 25402);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 25169, 25425);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 25572, 25584);

                                return true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 24447, 25603);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 23247, 25653);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 23247, 25653) || true) && (current != topLevelParent)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1564, 23247, 25653);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1564, 23247, 25653);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 25669, 25830);

                f_1564_25669_25829(false, "Unreachable Code. Top level parent is eitehr ScriptBlockAst or FunctionDefinitionAst, so it should return within the loop for sure.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 25969, 25981);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1564, 22703, 25992);

                int
                f_1564_22883_23078(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 22883, 23078);
                    return 0;
                }


                System.Management.Automation.Language.Ast
                f_1564_23292_23306(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Parent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 23292, 23306);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1564_25070_25082(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 25070, 25082);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1564_25173_25185(System.Management.Automation.Language.FunctionDefinitionAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 25173, 25185);
                    return return_v;
                }


                int
                f_1564_25669_25829(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 25669, 25829);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 22703, 25992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 22703, 25992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ConvertPipeline(PipelineAst pipelineAst, bool isTrustedInput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 26004, 26267);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 26103, 26256);
                    foreach (var command in f_1564_26127_26155_I(f_1564_26127_26155(pipelineAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 26103, 26256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 26189, 26241);

                        f_1564_26189_26240(this, command, isTrustedInput);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 26103, 26256);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1564, 1, 154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1564, 1, 154);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 26004, 26267);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1564_26127_26155(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 26127, 26155);
                    return return_v;
                }


                int
                f_1564_26189_26240(System.Management.Automation.ScriptBlockToPowerShellConverter
                this_param, System.Management.Automation.Language.CommandBaseAst
                commandAst, bool
                isTrustedInput)
                {
                    this_param.ConvertCommand((System.Management.Automation.Language.CommandAst)commandAst, isTrustedInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 26189, 26240);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1564_26127_26155_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 26127, 26155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 26004, 26267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 26004, 26267);
            }
        }

        private void ConvertCommand(CommandAst commandAst, bool isTrustedInput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 26279, 33521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 26416, 26496);

                var
                commandName = f_1564_26434_26495(this, f_1564_26449_26478(f_1564_26449_26475(commandAst), 0), isTrustedInput)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 26512, 26602);

                var
                command = f_1564_26526_26601(commandName, isScript: false, useLocalScope: _createLocalScope)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 26697, 28396) || true) && (f_1564_26701_26730(f_1564_26701_26724(commandAst)) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 26697, 28396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 26768, 26866);

                    f_1564_26768_26865(f_1564_26787_26816(f_1564_26787_26810(commandAst)) == 1, "only 1 kind of redirection is supported");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 26884, 26987);

                    f_1564_26884_26986(f_1564_26903_26929(f_1564_26903_26926(commandAst), 0) is MergingRedirectionAst, "unexpected redirection type");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 27007, 27063);

                    PipelineResultTypes
                    toType = PipelineResultTypes.Output
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 27081, 27110);

                    PipelineResultTypes
                    fromType
                    = default(PipelineResultTypes);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 27128, 28320);

                    switch (f_1564_27136_27173(f_1564_27136_27162(f_1564_27136_27159(commandAst), 0)))
                    {

                        case RedirectionStream.Error:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 27128, 28320);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 27270, 27307);

                            fromType = PipelineResultTypes.Error;
                            DynAbs.Tracing.TraceSender.TraceBreak(1564, 27333, 27339);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 27128, 28320);

                        case RedirectionStream.Warning:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 27128, 28320);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 27420, 27459);

                            fromType = PipelineResultTypes.Warning;
                            DynAbs.Tracing.TraceSender.TraceBreak(1564, 27485, 27491);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 27128, 28320);

                        case RedirectionStream.Verbose:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 27128, 28320);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 27572, 27611);

                            fromType = PipelineResultTypes.Verbose;
                            DynAbs.Tracing.TraceSender.TraceBreak(1564, 27637, 27643);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 27128, 28320);

                        case RedirectionStream.Debug:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 27128, 28320);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 27722, 27759);

                            fromType = PipelineResultTypes.Debug;
                            DynAbs.Tracing.TraceSender.TraceBreak(1564, 27785, 27791);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 27128, 28320);

                        case RedirectionStream.Information:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 27128, 28320);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 27876, 27919);

                            fromType = PipelineResultTypes.Information;
                            DynAbs.Tracing.TraceSender.TraceBreak(1564, 27945, 27951);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 27128, 28320);

                        case RedirectionStream.All:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 27128, 28320);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 28028, 28063);

                            fromType = PipelineResultTypes.All;
                            DynAbs.Tracing.TraceSender.TraceBreak(1564, 28089, 28095);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 27128, 28320);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 27128, 28320);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 28232, 28269);

                            fromType = PipelineResultTypes.Error;
                            DynAbs.Tracing.TraceSender.TraceBreak(1564, 28295, 28301);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 27128, 28320);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 28340, 28381);

                    f_1564_28340_28380(
                                    command, fromType, toType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 26697, 28396);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 28412, 28444);

                f_1564_28412_28443(
                            _powershell, command);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 28510, 33510);
                    foreach (var ast in f_1564_28530_28564_I(f_1564_28530_28564(f_1564_28530_28556(commandAst), 1)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 28510, 33510);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 28598, 28633);

                        var
                        exprAst = ast as ExpressionAst
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 28651, 33495) || true) && (exprAst != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 28651, 33495);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 28712, 28753);

                            VariableExpressionAst
                            variableAst = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 28777, 28822);

                            var
                            usingExprAst = ast as UsingExpressionAst
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 28844, 30702) || true) && (usingExprAst != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 28844, 30702);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 28918, 28983);

                                string
                                usingAstKey = f_1564_28939_28982(usingExprAst)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 29009, 29057);

                                object
                                usingValue = f_1564_29029_29056(_usingValueMap, usingAstKey)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 29083, 29149);

                                variableAst = f_1564_29097_29123(usingExprAst) as VariableExpressionAst;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 29175, 30642) || true) && (variableAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1564, 29179, 29222) && f_1564_29202_29222(variableAst)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 29175, 30642);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 29350, 29412);

                                    var
                                    parameters = usingValue as System.Collections.IDictionary
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 29442, 30465) || true) && (parameters != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 29442, 30465);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 29530, 29568);

                                        f_1564_29530_29567(_powershell, parameters);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 29442, 30465);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 29442, 30465);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 29768, 29829);

                                        var
                                        arguments = usingValue as System.Collections.IEnumerable
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 29863, 30434) || true) && (arguments != null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 29863, 30434);
                                            try
                                            {
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 29958, 30150);
                                                foreach (object argument in f_1564_29986_29995_I(arguments))
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 29958, 30150);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 30077, 30111);

                                                    f_1564_30077_30110(_powershell, argument);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 29958, 30150);
                                                }
                                            }
                                            catch (System.Exception)
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1564, 1, 193);
                                                throw;
                                            }
                                            finally
                                            {
                                                DynAbs.Tracing.TraceSender.TraceExitLoop(1564, 1, 193);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 29863, 30434);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 29863, 30434);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 30363, 30399);

                                            f_1564_30363_30398(                                    // Splat the object directly.
                                                                                _powershell, usingValue);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 29863, 30434);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 29442, 30465);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 29175, 30642);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 29175, 30642);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 30579, 30615);

                                    f_1564_30579_30614(_powershell, usingValue);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 29175, 30642);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 30670, 30679);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 28844, 30702);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 30726, 30769);

                            variableAst = ast as VariableExpressionAst;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 30791, 33339) || true) && (variableAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1564, 30795, 30838) && f_1564_30818_30838(variableAst)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 30791, 33339);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 30888, 30921);

                                f_1564_30888_30920(this, variableAst);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 30791, 33339);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 30791, 33339);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 31019, 31070);

                                var
                                constantExprAst = ast as ConstantExpressionAst
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 31096, 31112);

                                object
                                argument
                                = default(object);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 31138, 33254) || true) && (constantExprAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1564, 31142, 31257) && f_1564_31169_31257(f_1564_31198_31256(f_1564_31229_31255(constantExprAst)))))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 31138, 33254);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 31315, 31369);

                                    var
                                    commandArgumentText = f_1564_31341_31368(f_1564_31341_31363(constantExprAst))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 31399, 31432);

                                    argument = f_1564_31410_31431(constantExprAst);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 31462, 32082) || true) && (!f_1564_31467_31553(commandArgumentText, f_1564_31494_31526(f_1564_31494_31515(constantExprAst)), StringComparison.Ordinal))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 31462, 32082);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 31985, 32051);

                                        argument = f_1564_31996_32050(argument, commandArgumentText);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 31462, 32082);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 31138, 33254);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 31138, 33254);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 32196, 33227) || true) && (!isTrustedInput)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 32196, 33227);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 32357, 32472);

                                            argument = f_1564_32368_32471(exprAst, _context, GetSafeValueVisitor.SafeValueContext.GetPowerShell);
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1564, 32541, 33011);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 32638, 32976);

                                            throw f_1564_32644_32975("CantConvertWithDynamicExpression", null, f_1564_32859_32912(), f_1564_32955_32974(f_1564_32955_32969(exprAst)));
                                            DynAbs.Tracing.TraceSender.TraceExitCatch(1564, 32541, 33011);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 32196, 33227);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 32196, 33227);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 33141, 33196);

                                        argument = f_1564_33152_33195(this, exprAst, isTrustedInput);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 32196, 33227);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 31138, 33254);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 33282, 33316);

                                f_1564_33282_33315(
                                                        _powershell, argument);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 30791, 33339);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 28651, 33495);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 28651, 33495);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 33421, 33476);

                            f_1564_33421_33475(this, ast, isTrustedInput);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 28651, 33495);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 28510, 33510);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1564, 1, 5001);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1564, 1, 5001);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 26279, 33521);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1564_26449_26475(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 26449, 26475);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1564_26449_26478(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 26449, 26478);
                    return return_v;
                }


                string
                f_1564_26434_26495(System.Management.Automation.ScriptBlockToPowerShellConverter
                this_param, System.Management.Automation.Language.CommandElementAst
                commandNameAst, bool
                isTrustedInput)
                {
                    var return_v = this_param.GetCommandName(commandNameAst, isTrustedInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 26434, 26495);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1564_26526_26601(string
                command, bool
                isScript, bool?
                useLocalScope)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command, isScript: isScript, useLocalScope: useLocalScope);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 26526, 26601);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                f_1564_26701_26724(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.Redirections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 26701, 26724);
                    return return_v;
                }


                int
                f_1564_26701_26730(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 26701, 26730);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                f_1564_26787_26810(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.Redirections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 26787, 26810);
                    return return_v;
                }


                int
                f_1564_26787_26816(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 26787, 26816);
                    return return_v;
                }


                int
                f_1564_26768_26865(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 26768, 26865);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                f_1564_26903_26926(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.Redirections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 26903, 26926);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionAst
                f_1564_26903_26929(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 26903, 26929);
                    return return_v;
                }


                int
                f_1564_26884_26986(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 26884, 26986);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                f_1564_27136_27159(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.Redirections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 27136, 27159);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionAst
                f_1564_27136_27162(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 27136, 27162);
                    return return_v;
                }


                System.Management.Automation.Language.RedirectionStream
                f_1564_27136_27173(System.Management.Automation.Language.RedirectionAst
                this_param)
                {
                    var return_v = this_param.FromStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 27136, 27173);
                    return return_v;
                }


                int
                f_1564_28340_28380(System.Management.Automation.Runspaces.Command
                this_param, System.Management.Automation.Runspaces.PipelineResultTypes
                myResult, System.Management.Automation.Runspaces.PipelineResultTypes
                toResult)
                {
                    this_param.MergeMyResults(myResult, toResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 28340, 28380);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1564_28412_28443(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = this_param.AddCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 28412, 28443);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1564_28530_28556(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 28530, 28556);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.CommandElementAst>
                f_1564_28530_28564(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                source, int
                count)
                {
                    var return_v = source.Skip<System.Management.Automation.Language.CommandElementAst>(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 28530, 28564);
                    return return_v;
                }


                string
                f_1564_28939_28982(System.Management.Automation.Language.UsingExpressionAst
                usingAst)
                {
                    var return_v = PsUtils.GetUsingExpressionKey(usingAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 28939, 28982);
                    return return_v;
                }


                object
                f_1564_29029_29056(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 29029, 29056);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1564_29097_29123(System.Management.Automation.Language.UsingExpressionAst
                this_param)
                {
                    var return_v = this_param.SubExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 29097, 29123);
                    return return_v;
                }


                bool
                f_1564_29202_29222(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.Splatted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 29202, 29222);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1564_29530_29567(System.Management.Automation.PowerShell
                this_param, System.Collections.IDictionary
                parameters)
                {
                    var return_v = this_param.AddParameters(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 29530, 29567);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1564_30077_30110(System.Management.Automation.PowerShell
                this_param, object
                value)
                {
                    var return_v = this_param.AddArgument(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 30077, 30110);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1564_29986_29995_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 29986, 29995);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1564_30363_30398(System.Management.Automation.PowerShell
                this_param, object
                value)
                {
                    var return_v = this_param.AddArgument(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 30363, 30398);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1564_30579_30614(System.Management.Automation.PowerShell
                this_param, object
                value)
                {
                    var return_v = this_param.AddArgument(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 30579, 30614);
                    return return_v;
                }


                bool
                f_1564_30818_30838(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.Splatted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 30818, 30838);
                    return return_v;
                }


                int
                f_1564_30888_30920(System.Management.Automation.ScriptBlockToPowerShellConverter
                this_param, System.Management.Automation.Language.VariableExpressionAst
                variableAst)
                {
                    this_param.GetSplattedVariable(variableAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 30888, 30920);
                    return 0;
                }


                System.Type
                f_1564_31229_31255(System.Management.Automation.Language.ConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.StaticType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 31229, 31255);
                    return return_v;
                }


                System.TypeCode
                f_1564_31198_31256(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.GetTypeCode(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 31198, 31256);
                    return return_v;
                }


                bool
                f_1564_31169_31257(System.TypeCode
                typeCode)
                {
                    var return_v = LanguagePrimitives.IsNumeric(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 31169, 31257);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1564_31341_31363(System.Management.Automation.Language.ConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 31341, 31363);
                    return return_v;
                }


                string
                f_1564_31341_31368(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 31341, 31368);
                    return return_v;
                }


                object
                f_1564_31410_31431(System.Management.Automation.Language.ConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 31410, 31431);
                    return return_v;
                }


                object
                f_1564_31494_31515(System.Management.Automation.Language.ConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 31494, 31515);
                    return return_v;
                }


                string?
                f_1564_31494_31526(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 31494, 31526);
                    return return_v;
                }


                bool
                f_1564_31467_31553(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 31467, 31553);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1564_31996_32050(object
                data, string
                text)
                {
                    var return_v = ParserOps.WrappedNumber(data, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 31996, 32050);
                    return return_v;
                }


                object
                f_1564_32368_32471(System.Management.Automation.Language.ExpressionAst
                ast, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.GetSafeValueVisitor.SafeValueContext
                safeValueContext)
                {
                    var return_v = GetSafeValueVisitor.GetSafeValue((System.Management.Automation.Language.Ast)ast, context, safeValueContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 32368, 32471);
                    return return_v;
                }


                string
                f_1564_32859_32912()
                {
                    var return_v = AutomationExceptions.CantConvertWithDynamicExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 32859, 32912);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1564_32955_32969(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 32955, 32969);
                    return return_v;
                }


                string
                f_1564_32955_32974(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 32955, 32974);
                    return return_v;
                }


                System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                f_1564_32644_32975(string
                errorId, System.Exception
                innerException, string
                message, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ScriptBlockToPowerShellNotSupportedException(errorId, innerException, message, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 32644, 32975);
                    return return_v;
                }


                object
                f_1564_33152_33195(System.Management.Automation.ScriptBlockToPowerShellConverter
                this_param, System.Management.Automation.Language.ExpressionAst
                exprAst, bool
                isTrustedInput)
                {
                    var return_v = this_param.GetExpressionValue(exprAst, isTrustedInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 33152, 33195);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1564_33282_33315(System.Management.Automation.PowerShell
                this_param, object
                value)
                {
                    var return_v = this_param.AddArgument(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 33282, 33315);
                    return return_v;
                }


                int
                f_1564_33421_33475(System.Management.Automation.ScriptBlockToPowerShellConverter
                this_param, System.Management.Automation.Language.CommandElementAst
                commandParameterAst, bool
                isTrustedInput)
                {
                    this_param.AddParameter((System.Management.Automation.Language.CommandParameterAst)commandParameterAst, isTrustedInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 33421, 33475);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.CommandElementAst>
                f_1564_28530_28564_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.CommandElementAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 28530, 28564);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 26279, 33521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 26279, 33521);
            }
        }

        private string GetCommandName(CommandElementAst commandNameAst, bool isTrustedInput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 33533, 35249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 33642, 33688);

                var
                exprAst = commandNameAst as ExpressionAst
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 33702, 33721);

                string
                commandName
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 33735, 34816) || true) && (exprAst != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 33735, 34816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 33788, 33844);

                    var
                    value = f_1564_33800_33843(this, exprAst, isTrustedInput)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 33862, 34227) || true) && (value == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 33862, 34227);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 33921, 34208);

                        f_1564_33921_34207(f_1564_33989_34172("CantConvertWithScriptBlockInvocation", null, f_1564_34114_34171()), exprAst);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 33862, 34227);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 34247, 34484) || true) && (value is CommandInfo)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 34247, 34484);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 34313, 34353);

                        commandName = f_1564_34327_34352(((CommandInfo)value));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 34247, 34484);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 34247, 34484);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 34435, 34465);

                        commandName = value as string;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 34247, 34484);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 33735, 34816);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 33735, 34816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 34639, 34742);

                    f_1564_34639_34741(commandNameAst is CommandParameterAst, "Unexpected element not handled correctly.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 34760, 34801);

                    commandName = f_1564_34774_34800(f_1564_34774_34795(commandNameAst));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 33735, 34816);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 34832, 35203) || true) && (f_1564_34836_34874(commandName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 34832, 35203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 34964, 35188);

                    throw f_1564_34970_35187("CantConvertWithScriptBlockInvocation", null, f_1564_35129_35186());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 34832, 35203);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 35219, 35238);

                return commandName;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 33533, 35249);

                object
                f_1564_33800_33843(System.Management.Automation.ScriptBlockToPowerShellConverter
                this_param, System.Management.Automation.Language.ExpressionAst
                exprAst, bool
                isTrustedInput)
                {
                    var return_v = this_param.GetExpressionValue(exprAst, isTrustedInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 33800, 33843);
                    return return_v;
                }


                string
                f_1564_34114_34171()
                {
                    var return_v = AutomationExceptions.CantConvertWithScriptBlockInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 34114, 34171);
                    return return_v;
                }


                System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                f_1564_33989_34172(string
                errorId, System.Exception
                innerException, string
                message, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ScriptBlockToPowerShellNotSupportedException(errorId, innerException, message, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 33989, 34172);
                    return return_v;
                }


                int
                f_1564_33921_34207(System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                ex, System.Management.Automation.Language.ExpressionAst
                ast)
                {
                    ScriptBlockToPowerShellChecker.ThrowError(ex, (System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 33921, 34207);
                    return 0;
                }


                string
                f_1564_34327_34352(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 34327, 34352);
                    return return_v;
                }


                int
                f_1564_34639_34741(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 34639, 34741);
                    return 0;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1564_34774_34795(System.Management.Automation.Language.CommandElementAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 34774, 34795);
                    return return_v;
                }


                string
                f_1564_34774_34800(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 34774, 34800);
                    return return_v;
                }


                bool
                f_1564_34836_34874(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 34836, 34874);
                    return return_v;
                }


                string
                f_1564_35129_35186()
                {
                    var return_v = AutomationExceptions.CantConvertWithScriptBlockInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 35129, 35186);
                    return return_v;
                }


                System.Management.Automation.ScriptBlockToPowerShellNotSupportedException
                f_1564_34970_35187(string
                errorId, System.Exception
                innerException, string
                message, params object[]
                arguments)
                {
                    var return_v = new System.Management.Automation.ScriptBlockToPowerShellNotSupportedException(errorId, innerException, message, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 34970, 35187);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 33533, 35249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 33533, 35249);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetSplattedVariable(VariableExpressionAst variableAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 35261, 36291);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 35353, 35518) || true) && (_context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 35353, 35518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 35407, 35503);

                    throw f_1564_35413_35502(f_1564_35445_35501());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 35353, 35518);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 35875, 35950);

                object
                splattedValue = f_1564_35898_35949(_context, f_1564_35924_35948(variableAst))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 35964, 36280);
                    foreach (var splattedParameter in f_1564_35998_36043_I(f_1564_35998_36043(splattedValue, variableAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 35964, 36280);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 36077, 36177);

                        CommandParameter
                        publicParameter = f_1564_36112_36176(splattedParameter)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 36195, 36265);

                        f_1564_36195_36264(_powershell, f_1564_36220_36240(publicParameter), f_1564_36242_36263(publicParameter));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 35964, 36280);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1564, 1, 317);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1564, 1, 317);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 35261, 36291);

                string
                f_1564_35445_35501()
                {
                    var return_v = AutomationExceptions.CantConvertScriptBlockWithNoContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 35445, 35501);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1564_35413_35502(string
                message)
                {
                    var return_v = new System.Management.Automation.PSInvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 35413, 35502);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1564_35924_35948(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 35924, 35948);
                    return return_v;
                }


                object
                f_1564_35898_35949(System.Management.Automation.ExecutionContext
                this_param, System.Management.Automation.VariablePath
                path)
                {
                    var return_v = this_param.GetVariableValue(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 35898, 35949);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandParameterInternal>
                f_1564_35998_36043(object
                splattedValue, System.Management.Automation.Language.VariableExpressionAst
                splatAst)
                {
                    var return_v = PipelineOps.Splat(splattedValue, (System.Management.Automation.Language.Ast)splatAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 35998, 36043);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameter
                f_1564_36112_36176(System.Management.Automation.CommandParameterInternal
                internalParameter)
                {
                    var return_v = CommandParameter.FromCommandParameterInternal(internalParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 36112, 36176);
                    return return_v;
                }


                string
                f_1564_36220_36240(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 36220, 36240);
                    return return_v;
                }


                object
                f_1564_36242_36263(System.Management.Automation.Runspaces.CommandParameter
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 36242, 36263);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1564_36195_36264(System.Management.Automation.PowerShell
                this_param, string
                parameterName, object
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 36195, 36264);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CommandParameterInternal>
                f_1564_35998_36043_I(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandParameterInternal>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 35998, 36043);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 35261, 36291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 35261, 36291);
            }
        }

        private object GetExpressionValue(ExpressionAst exprAst, bool isTrustedInput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 36303, 37036);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 36460, 36676) || true) && (_context == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 36460, 36676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 36514, 36584);

                    var
                    rs = f_1564_36523_36583(f_1564_36554_36582())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 36602, 36612);

                    f_1564_36602_36611(rs);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 36630, 36661);

                    _context = f_1564_36641_36660(rs);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 36460, 36676);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 36692, 36923) || true) && (!isTrustedInput)
                ) // if it's not trusted, call the safe value visitor

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 36692, 36923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 36797, 36908);

                    return f_1564_36804_36907(exprAst, _context, GetSafeValueVisitor.SafeValueContext.GetPowerShell);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 36692, 36923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 36939, 37025);

                return f_1564_36946_37024(exprAst, isTrustedInput, _context, _usingValueMap);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 36303, 37036);

                System.Management.Automation.Runspaces.InitialSessionState
                f_1564_36554_36582()
                {
                    var return_v = InitialSessionState.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 36554, 36582);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1564_36523_36583(System.Management.Automation.Runspaces.InitialSessionState
                initialSessionState)
                {
                    var return_v = RunspaceFactory.CreateRunspace(initialSessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 36523, 36583);
                    return return_v;
                }


                int
                f_1564_36602_36611(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    this_param.Open();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 36602, 36611);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1564_36641_36660(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.ExecutionContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 36641, 36660);
                    return return_v;
                }


                object
                f_1564_36804_36907(System.Management.Automation.Language.ExpressionAst
                ast, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.GetSafeValueVisitor.SafeValueContext
                safeValueContext)
                {
                    var return_v = GetSafeValueVisitor.GetSafeValue((System.Management.Automation.Language.Ast)ast, context, safeValueContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 36804, 36907);
                    return return_v;
                }


                object
                f_1564_36946_37024(System.Management.Automation.Language.ExpressionAst
                expressionAst, bool
                isTrustedInput, System.Management.Automation.ExecutionContext
                context, System.Collections.Generic.Dictionary<string, object>
                usingValues)
                {
                    var return_v = Compiler.GetExpressionValue(expressionAst, isTrustedInput, context, (System.Collections.IDictionary)usingValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 36946, 37024);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 36303, 37036);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 36303, 37036);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void AddParameter(CommandParameterAst commandParameterAst, bool isTrustedInput)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1564, 37048, 38173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 37160, 37178);

                string
                nameSuffix
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 37192, 37208);

                object
                argument
                = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 37222, 37908) || true) && (f_1564_37226_37254(commandParameterAst) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 37222, 37908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 37296, 37335);

                    var
                    arg = f_1564_37306_37334(commandParameterAst)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 37353, 37402);

                    var
                    errorPos = f_1564_37368_37401(commandParameterAst)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 37420, 37607);

                    bool
                    spaceAfterParameter = (f_1564_37448_37470(errorPos) != f_1564_37474_37500(f_1564_37474_37484(arg)) || (DynAbs.Tracing.TraceSender.Expression_False(1564, 37448, 37605) || f_1564_37549_37573(errorPos) != f_1564_37577_37605(f_1564_37577_37587(arg))))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 37625, 37671);

                    nameSuffix = (DynAbs.Tracing.TraceSender.Conditional_F1(1564, 37638, 37657) || ((spaceAfterParameter && DynAbs.Tracing.TraceSender.Conditional_F2(1564, 37660, 37664)) || DynAbs.Tracing.TraceSender.Conditional_F3(1564, 37667, 37670))) ? ": " : ":";
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 37691, 37767);

                    argument = f_1564_37702_37766(this, f_1564_37721_37749(commandParameterAst), isTrustedInput);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 37222, 37908);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1564, 37222, 37908);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 37833, 37859);

                    nameSuffix = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 37877, 37893);

                    argument = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1564, 37222, 37908);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1564, 37989, 38162);

                f_1564_37989_38161(
                            // first character in parameter name must be a dash
                            _powershell, f_1564_38032_38133(f_1564_38046_38074(), "-{0}{1}", f_1564_38087_38120(commandParameterAst), nameSuffix), argument);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1564, 37048, 38173);

                System.Management.Automation.Language.ExpressionAst
                f_1564_37226_37254(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 37226, 37254);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1564_37306_37334(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 37306, 37334);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1564_37368_37401(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ErrorPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 37368, 37401);
                    return return_v;
                }


                int
                f_1564_37448_37470(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 37448, 37470);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1564_37474_37484(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 37474, 37484);
                    return return_v;
                }


                int
                f_1564_37474_37500(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 37474, 37500);
                    return return_v;
                }


                int
                f_1564_37549_37573(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 37549, 37573);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1564_37577_37587(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 37577, 37587);
                    return return_v;
                }


                int
                f_1564_37577_37605(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 37577, 37605);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1564_37721_37749(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 37721, 37749);
                    return return_v;
                }


                object
                f_1564_37702_37766(System.Management.Automation.ScriptBlockToPowerShellConverter
                this_param, System.Management.Automation.Language.ExpressionAst
                exprAst, bool
                isTrustedInput)
                {
                    var return_v = this_param.GetExpressionValue(exprAst, isTrustedInput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 37702, 37766);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1564_38046_38074()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 38046, 38074);
                    return return_v;
                }


                string
                f_1564_38087_38120(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1564, 38087, 38120);
                    return return_v;
                }


                string
                f_1564_38032_38133(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 38032, 38133);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1564_37989_38161(System.Management.Automation.PowerShell
                this_param, string
                parameterName, object
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 37989, 38161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1564, 37048, 38173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 37048, 38173);
            }
        }

        static ScriptBlockToPowerShellConverter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1564, 8822, 38180);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1564, 8822, 38180);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1564, 8822, 38180);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1564, 8822, 38180);

        System.Management.Automation.PowerShell
        f_1564_9165_9184()
        {
            var return_v = PowerShell.Create();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1564, 9165, 9184);
            return return_v;
        }

    }
}
