// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace System.Management.Automation.Language
{
    internal static class VariablePathExtensions
    {
        internal static bool IsAnyLocal(this VariablePath variablePath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 378, 566);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 466, 555);

                return f_1561_473_504(variablePath) || (DynAbs.Tracing.TraceSender.Expression_False(1561, 473, 528) || f_1561_508_528(variablePath)) || (DynAbs.Tracing.TraceSender.Expression_False(1561, 473, 554) || f_1561_532_554(variablePath));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 378, 566);

                bool
                f_1561_473_504(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsUnscopedVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 473, 504);
                    return return_v;
                }


                bool
                f_1561_508_528(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsLocal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 508, 528);
                    return return_v;
                }


                bool
                f_1561_532_554(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsPrivate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 532, 554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 378, 566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 378, 566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static VariablePathExtensions()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1561, 317, 573);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1561, 317, 573);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 317, 573);
        }

    }
    internal class VariableAnalysisDetails
    {
        internal VariableAnalysisDetails()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1561, 636, 744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 756, 789);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 799, 839);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 849, 879);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 889, 921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 931, 966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 976, 1020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 1030, 1064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 1074, 1127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 695, 733);

                this.AssociatedAsts = f_1561_717_732();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1561, 636, 744);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 636, 744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 636, 744);
            }
        }

        public int BitIndex { get; set; }

        public int LocalTupleIndex { get; set; }

        public Type Type { get; set; }

        public string Name { get; set; }

        public bool Automatic { get; set; }

        public bool PreferenceVariable { get; set; }

        public bool Assigned { get; set; }

        public List<Ast> AssociatedAsts { get; private set; }

        static VariableAnalysisDetails()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1561, 581, 1134);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1561, 581, 1134);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 581, 1134);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1561, 581, 1134);

        System.Collections.Generic.List<System.Management.Automation.Language.Ast>
        f_1561_717_732()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.Ast>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 717, 732);
            return return_v;
        }

    }
    internal class FindAllVariablesVisitor : AstVisitor
    {
        private static readonly HashSet<string> s_hashOfPessimizingCmdlets;

        private static readonly string[] s_pessimizingCmdlets;

        static FindAllVariablesVisitor()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1561, 2659, 2858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 1250, 1332);
                s_hashOfPessimizingCmdlets = f_1561_1279_1332(f_1561_1299_1331());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 1376, 2646);
                s_pessimizingCmdlets = new string[]
                                                                          {
                                                              "New-Variable",
                                                              "Remove-Variable",
                                                              "Set-Variable",
                                                              "Set-PSBreakpoint",
                                                              "Microsoft.PowerShell.Utility\\New-Variable",
                                                              "Microsoft.PowerShell.Utility\\Remove-Variable",
                                                              "Microsoft.PowerShell.Utility\\Set-Variable",
                                                              "Microsoft.PowerShell.Utility\\Set-PSBreakpoint",
                                                              "nv",
                                                              "rv",
                                                              "sbp",
                                                              "sv",
                                                              "set",
                                                                          };
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 2716, 2847);
                    foreach (var cmdlet in f_1561_2739_2759_I(s_pessimizingCmdlets))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 2716, 2847);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 2793, 2832);

                        f_1561_2793_2831(s_hashOfPessimizingCmdlets, cmdlet);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 2716, 2847);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 132);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 132);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1561, 2659, 2858);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 2659, 2858);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 2659, 2858);
            }
        }

        internal static Dictionary<string, VariableAnalysisDetails> Visit(TrapStatementAst trap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 2870, 3419);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 3230, 3321);

                var
                visitor = f_1561_3244_3320(disableOptimizations: true, scriptCmdlet: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 3335, 3368);

                f_1561_3335_3367(f_1561_3335_3344(trap), visitor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 3382, 3408);

                return visitor._variables;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 2870, 3419);

                System.Management.Automation.Language.FindAllVariablesVisitor
                f_1561_3244_3320(bool
                disableOptimizations, bool
                scriptCmdlet)
                {
                    var return_v = new System.Management.Automation.Language.FindAllVariablesVisitor(disableOptimizations: disableOptimizations, scriptCmdlet: scriptCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 3244, 3320);
                    return return_v;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1561_3335_3344(System.Management.Automation.Language.TrapStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 3335, 3344);
                    return return_v;
                }


                System.Management.Automation.Language.AstVisitAction
                f_1561_3335_3367(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.Language.FindAllVariablesVisitor
                visitor)
                {
                    var return_v = this_param.InternalVisit((System.Management.Automation.Language.AstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 3335, 3367);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 2870, 3419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 2870, 3419);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Dictionary<string, VariableAnalysisDetails> Visit(ExpressionAst exprAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 3526, 4102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 3915, 4006);

                var
                visitor = f_1561_3929_4005(disableOptimizations: true, scriptCmdlet: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 4020, 4051);

                f_1561_4020_4050(exprAst, visitor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 4065, 4091);

                return visitor._variables;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 3526, 4102);

                System.Management.Automation.Language.FindAllVariablesVisitor
                f_1561_3929_4005(bool
                disableOptimizations, bool
                scriptCmdlet)
                {
                    var return_v = new System.Management.Automation.Language.FindAllVariablesVisitor(disableOptimizations: disableOptimizations, scriptCmdlet: scriptCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 3929, 4005);
                    return return_v;
                }


                System.Management.Automation.Language.AstVisitAction
                f_1561_4020_4050(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.FindAllVariablesVisitor
                visitor)
                {
                    var return_v = this_param.InternalVisit((System.Management.Automation.Language.AstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 4020, 4050);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 3526, 4102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 3526, 4102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Dictionary<string, VariableAnalysisDetails> Visit(IParameterMetadataProvider ast,
                                                                                  bool disableOptimizations,
                                                                                  bool scriptCmdlet,
                                                                                  out int localsAllocated,
                                                                                  out bool forceNoOptimizing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 4114, 5352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 4635, 4713);

                var
                visitor = f_1561_4649_4712(disableOptimizations, scriptCmdlet)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 4934, 4966);

                f_1561_4934_4965(f_1561_4934_4942(ast), visitor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 4980, 5030);

                forceNoOptimizing = visitor._disableOptimizations;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 5046, 5161) || true) && (f_1561_5050_5064(ast) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 5046, 5161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 5106, 5146);

                    f_1561_5106_5145(visitor, f_1561_5130_5144(ast));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 5046, 5161);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 5177, 5301);

                localsAllocated = f_1561_5195_5300(f_1561_5195_5292(visitor._variables, details => details.Value.LocalTupleIndex != VariableAnalysis.Unanalyzed));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 5315, 5341);

                return visitor._variables;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 4114, 5352);

                System.Management.Automation.Language.FindAllVariablesVisitor
                f_1561_4649_4712(bool
                disableOptimizations, bool
                scriptCmdlet)
                {
                    var return_v = new System.Management.Automation.Language.FindAllVariablesVisitor(disableOptimizations, scriptCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 4649, 4712);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1561_4934_4942(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 4934, 4942);
                    return return_v;
                }


                System.Management.Automation.Language.AstVisitAction
                f_1561_4934_4965(System.Management.Automation.Language.ScriptBlockAst
                this_param, System.Management.Automation.Language.FindAllVariablesVisitor
                visitor)
                {
                    var return_v = this_param.InternalVisit((System.Management.Automation.Language.AstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 4934, 4965);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                f_1561_5050_5064(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 5050, 5064);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                f_1561_5130_5144(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 5130, 5144);
                    return return_v;
                }


                int
                f_1561_5106_5145(System.Management.Automation.Language.FindAllVariablesVisitor
                this_param, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                parameters)
                {
                    this_param.VisitParameters(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 5106, 5145);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Management.Automation.Language.VariableAnalysisDetails>>
                f_1561_5195_5292(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                source, System.Func<System.Collections.Generic.KeyValuePair<string, System.Management.Automation.Language.VariableAnalysisDetails>, bool>
                predicate)
                {
                    var return_v = source.Where<System.Collections.Generic.KeyValuePair<string, System.Management.Automation.Language.VariableAnalysisDetails>>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 5195, 5292);
                    return return_v;
                }


                int
                f_1561_5195_5300(System.Collections.Generic.IEnumerable<System.Collections.Generic.KeyValuePair<string, System.Management.Automation.Language.VariableAnalysisDetails>>
                source)
                {
                    var return_v = source.Count<System.Collections.Generic.KeyValuePair<string, System.Management.Automation.Language.VariableAnalysisDetails>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 5195, 5300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 4114, 5352);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 4114, 5352);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool _disableOptimizations;

        private readonly Dictionary<string, VariableAnalysisDetails> _variables
        ;

        private FindAllVariablesVisitor(bool disableOptimizations, bool scriptCmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1561, 5590, 8515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 5377, 5398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 5470, 5577);
                this._variables = f_1561_5496_5577(f_1561_5544_5576());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 12748, 12766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 5692, 5737);

                _disableOptimizations = disableOptimizations;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 5753, 5814);

                var
                automaticVariables = SpecialVariables.AutomaticVariables
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 5828, 6021);

                f_1561_5828_6020(f_1561_5847_5907(automaticVariables, SpecialVariables.Underbar) == (int)AutomaticVariable.Underbar, "automaticVariables order is incorrect (0)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 6035, 6220);

                f_1561_6035_6219(f_1561_6054_6110(automaticVariables, SpecialVariables.Args) == (int)AutomaticVariable.Args, "automaticVariables order is incorrect (1)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 6234, 6419);

                f_1561_6234_6418(f_1561_6253_6309(automaticVariables, SpecialVariables.This) == (int)AutomaticVariable.This, "automaticVariables order is incorrect (2)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 6433, 6620);

                f_1561_6433_6619(f_1561_6452_6509(automaticVariables, SpecialVariables.Input) == (int)AutomaticVariable.Input, "automaticVariables order is incorrect (3)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 6634, 6827);

                f_1561_6634_6826(f_1561_6653_6713(automaticVariables, SpecialVariables.PSCmdlet) == (int)AutomaticVariable.PSCmdlet, "automaticVariables order is incorrect (4)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 6841, 7052);

                f_1561_6841_7051(f_1561_6860_6929(automaticVariables, SpecialVariables.PSBoundParameters) == (int)AutomaticVariable.PSBoundParameters, "automaticVariables order is incorrect (5)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 7066, 7267);

                f_1561_7066_7266(f_1561_7085_7149(automaticVariables, SpecialVariables.MyInvocation) == (int)AutomaticVariable.MyInvocation, "automaticVariables order is incorrect (6)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 7281, 7482);

                f_1561_7281_7481(f_1561_7300_7364(automaticVariables, SpecialVariables.PSScriptRoot) == (int)AutomaticVariable.PSScriptRoot, "automaticVariables order is incorrect (7)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 7496, 7699);

                f_1561_7496_7698(f_1561_7515_7580(automaticVariables, SpecialVariables.PSCommandPath) == (int)AutomaticVariable.PSCommandPath, "automaticVariables order is incorrect (8)");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 7715, 7721);

                int
                i
                = default(int);
                try
                {
                    for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 7740, 7745)
   , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 7735, 7930) || true) && (i < f_1561_7751_7776(automaticVariables))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 7778, 7781)
   , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 7735, 7930))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 7735, 7930);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 7815, 7915);

                        f_1561_7815_7914(this, automaticVariables[i], i, SpecialVariables.AutomaticVariableTypes[i], automatic: true);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 196);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 196);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 7946, 8388) || true) && (scriptCmdlet)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 7946, 8388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 7996, 8059);

                    var
                    preferenceVariables = SpecialVariables.PreferenceVariables
                    ;
                    try
                    {
                        for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 8082, 8087)
   , i = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 8077, 8373) || true) && (i < f_1561_8093_8119(preferenceVariables))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 8121, 8124)
   , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 8077, 8373))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 8077, 8373);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 8166, 8354);

                            f_1561_8166_8353(this, preferenceVariables[i], i + (int)AutomaticVariable.NumberOfAutomaticVariables, SpecialVariables.PreferenceVariableTypes[i], preferenceVariable: true);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 297);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 297);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 7946, 8388);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 8404, 8504);

                f_1561_8404_8503(this, SpecialVariables.Question, VariableAnalysis.Unanalyzed, typeof(bool), automatic: true);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1561, 5590, 8515);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 5590, 8515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 5590, 8515);
            }
        }

        private void VisitParameters(ReadOnlyCollection<ParameterAst> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 8527, 10412);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 8625, 10401);
                    foreach (ParameterAst t in f_1561_8652_8662_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 8625, 10401);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 8696, 8731);

                        var
                        variableExpressionAst = f_1561_8724_8730(t)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 8749, 8798);

                        var
                        varPath = f_1561_8763_8797(variableExpressionAst)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 8818, 10386) || true) && (f_1561_8822_8842(varPath))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 8818, 10386);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 8884, 8954);

                            var
                            variableName = f_1561_8903_8953(varPath)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 8976, 9016);

                            VariableAnalysisDetails
                            analysisDetails
                            = default(VariableAnalysisDetails);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 9038, 10367) || true) && (f_1561_9042_9099(_variables, variableName, out analysisDetails))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 9038, 10367);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 9362, 9398);

                                analysisDetails.Type = f_1561_9385_9397(t);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 9912, 9926);

                                object
                                unused
                                = default(object);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 9952, 10176) || true) && (!f_1561_9957_10027(f_1561_9994_10014(analysisDetails), out unused))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 9952, 10176);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 10085, 10149);

                                    analysisDetails.LocalTupleIndex = VariableAnalysis.ForceDynamic;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 9952, 10176);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 9038, 10367);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 9038, 10367);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 10274, 10344);

                                f_1561_10274_10343(this, variableName, VariableAnalysis.Unanalyzed, f_1561_10330_10342(t));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 9038, 10367);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 8818, 10386);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 8625, 10401);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 1777);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 1777);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 8527, 10412);

                System.Management.Automation.Language.VariableExpressionAst
                f_1561_8724_8730(System.Management.Automation.Language.ParameterAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 8724, 8730);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1561_8763_8797(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 8763, 8797);
                    return return_v;
                }


                bool
                f_1561_8822_8842(System.Management.Automation.VariablePath
                variablePath)
                {
                    var return_v = variablePath.IsAnyLocal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 8822, 8842);
                    return return_v;
                }


                string
                f_1561_8903_8953(System.Management.Automation.VariablePath
                varPath)
                {
                    var return_v = VariableAnalysis.GetUnaliasedVariableName(varPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 8903, 8953);
                    return return_v;
                }


                bool
                f_1561_9042_9099(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                this_param, string
                key, out System.Management.Automation.Language.VariableAnalysisDetails
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 9042, 9099);
                    return return_v;
                }


                System.Type
                f_1561_9385_9397(System.Management.Automation.Language.ParameterAst
                this_param)
                {
                    var return_v = this_param.StaticType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 9385, 9397);
                    return return_v;
                }


                System.Type
                f_1561_9994_10014(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 9994, 10014);
                    return return_v;
                }


                bool
                f_1561_9957_10027(System.Type
                type, out object
                value)
                {
                    var return_v = Compiler.TryGetDefaultParameterValue(type, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 9957, 10027);
                    return return_v;
                }


                System.Type
                f_1561_10330_10342(System.Management.Automation.Language.ParameterAst
                this_param)
                {
                    var return_v = this_param.StaticType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 10330, 10342);
                    return return_v;
                }


                int
                f_1561_10274_10343(System.Management.Automation.Language.FindAllVariablesVisitor
                this_param, string
                variableName, int
                index, System.Type
                type)
                {
                    this_param.NoteVariable(variableName, index, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 10274, 10343);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                f_1561_8652_8662_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 8652, 8662);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 8527, 10412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 8527, 10412);
            }
        }

        private void NoteVariable(string variableName, int index, Type type, bool automatic = false, bool preferenceVariable = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 10478, 11182);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 10628, 11171) || true) && (!f_1561_10633_10669(_variables, variableName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 10628, 11171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 10703, 11100);

                    var
                    details = new VariableAnalysisDetails
                    {
                        BitIndex = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1561_10796_10812(_variables), 1561, 10717, 11099),
                        LocalTupleIndex = index,
                        Name = variableName,
                        Type = type,
                        Automatic = automatic,
                        PreferenceVariable = preferenceVariable,
                        Assigned = false
                    }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 11118, 11156);

                    f_1561_11118_11155(_variables, variableName, details);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 10628, 11171);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 10478, 11182);

                bool
                f_1561_10633_10669(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 10633, 10669);
                    return return_v;
                }


                int
                f_1561_10796_10812(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 10796, 10812);
                    return return_v;
                }


                int
                f_1561_11118_11155(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                this_param, string
                key, System.Management.Automation.Language.VariableAnalysisDetails
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 11118, 11155);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 10478, 11182);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 10478, 11182);
            }
        }

        public override AstVisitAction VisitDataStatement(DataStatementAst dataStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 11194, 11522);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 11303, 11464) || true) && (f_1561_11307_11332(dataStatementAst) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 11303, 11464);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 11374, 11449);

                    f_1561_11374_11448(this, f_1561_11387_11412(dataStatementAst), VariableAnalysis.Unanalyzed, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 11303, 11464);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 11480, 11511);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 11194, 11522);

                string
                f_1561_11307_11332(System.Management.Automation.Language.DataStatementAst
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 11307, 11332);
                    return return_v;
                }


                string
                f_1561_11387_11412(System.Management.Automation.Language.DataStatementAst
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 11387, 11412);
                    return return_v;
                }


                int
                f_1561_11374_11448(System.Management.Automation.Language.FindAllVariablesVisitor
                this_param, string
                variableName, int
                index, System.Type
                type)
                {
                    this_param.NoteVariable(variableName, index, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 11374, 11448);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 11194, 11522);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 11194, 11522);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitSwitchStatement(SwitchStatementAst switchStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 11534, 11796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 11649, 11738);

                f_1561_11649_11737(this, SpecialVariables.@switch, VariableAnalysis.Unanalyzed, typeof(IEnumerator));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 11754, 11785);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 11534, 11796);

                int
                f_1561_11649_11737(System.Management.Automation.Language.FindAllVariablesVisitor
                this_param, string
                variableName, int
                index, System.Type
                type)
                {
                    this_param.NoteVariable(variableName, index, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 11649, 11737);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 11534, 11796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 11534, 11796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitForEachStatement(ForEachStatementAst forEachStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 11808, 12074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 11926, 12016);

                f_1561_11926_12015(this, SpecialVariables.@foreach, VariableAnalysis.Unanalyzed, typeof(IEnumerator));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 12032, 12063);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 11808, 12074);

                int
                f_1561_11926_12015(System.Management.Automation.Language.FindAllVariablesVisitor
                this_param, string
                variableName, int
                index, System.Type
                type)
                {
                    this_param.NoteVariable(variableName, index, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 11926, 12015);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 11808, 12074);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 11808, 12074);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitVariableExpression(VariableExpressionAst variableExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 12086, 12724);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 12210, 12259);

                var
                varPath = f_1561_12224_12258(variableExpressionAst)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 12273, 12666) || true) && (f_1561_12277_12297(varPath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 12273, 12666);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 12331, 12531) || true) && (f_1561_12335_12352(varPath))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 12331, 12531);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 12483, 12512);

                        _disableOptimizations = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 12331, 12531);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 12551, 12651);

                    f_1561_12551_12650(this, f_1561_12564_12614(varPath), VariableAnalysis.Unanalyzed, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 12273, 12666);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 12682, 12713);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 12086, 12724);

                System.Management.Automation.VariablePath
                f_1561_12224_12258(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 12224, 12258);
                    return return_v;
                }


                bool
                f_1561_12277_12297(System.Management.Automation.VariablePath
                variablePath)
                {
                    var return_v = variablePath.IsAnyLocal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 12277, 12297);
                    return return_v;
                }


                bool
                f_1561_12335_12352(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.IsPrivate;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 12335, 12352);
                    return return_v;
                }


                string
                f_1561_12564_12614(System.Management.Automation.VariablePath
                varPath)
                {
                    var return_v = VariableAnalysis.GetUnaliasedVariableName(varPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 12564, 12614);
                    return return_v;
                }


                int
                f_1561_12551_12650(System.Management.Automation.Language.FindAllVariablesVisitor
                this_param, string
                variableName, int
                index, System.Type
                type)
                {
                    this_param.NoteVariable(variableName, index, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 12551, 12650);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 12086, 12724);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 12086, 12724);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int _runtimeUsingIndex;

        public override AstVisitAction VisitUsingExpression(UsingExpressionAst usingExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 12777, 13656);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 13266, 13419) || true) && (f_1561_13270_13306(usingExpressionAst) == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 13266, 13419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 13346, 13404);

                    usingExpressionAst.RuntimeUsingIndex = _runtimeUsingIndex;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 13266, 13419);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 13435, 13560);

                f_1561_13435_13559(f_1561_13454_13490(usingExpressionAst) == _runtimeUsingIndex, "Logic error in visiting using expressions.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 13574, 13598);

                _runtimeUsingIndex += 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 13614, 13645);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 12777, 13656);

                int
                f_1561_13270_13306(System.Management.Automation.Language.UsingExpressionAst
                this_param)
                {
                    var return_v = this_param.RuntimeUsingIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 13270, 13306);
                    return return_v;
                }


                int
                f_1561_13454_13490(System.Management.Automation.Language.UsingExpressionAst
                this_param)
                {
                    var return_v = this_param.RuntimeUsingIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 13454, 13490);
                    return return_v;
                }


                int
                f_1561_13435_13559(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 13435, 13559);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 12777, 13656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 12777, 13656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitCommand(CommandAst commandAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 13668, 15194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 13759, 13838);

                var
                commandName = f_1561_13777_13806(f_1561_13777_13803(commandAst), 0) as StringConstantExpressionAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 13852, 14146) || true) && (commandName != null && (DynAbs.Tracing.TraceSender.Expression_True(1561, 13856, 13933) && f_1561_13879_13933(s_hashOfPessimizingCmdlets, f_1561_13915_13932(commandName))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 13852, 14146);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 14102, 14131);

                    _disableOptimizations = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 13852, 14146);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 14162, 15136) || true) && (f_1561_14166_14195(commandAst) == TokenKind.Dot)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 14162, 15136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 15092, 15121);

                    _disableOptimizations = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 14162, 15136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 15152, 15183);

                return AstVisitAction.Continue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 13668, 15194);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1561_13777_13803(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 13777, 13803);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1561_13777_13806(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 13777, 13806);
                    return return_v;
                }


                string
                f_1561_13915_13932(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 13915, 13932);
                    return return_v;
                }


                bool
                f_1561_13879_13933(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 13879, 13933);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1561_14166_14195(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.InvocationOperator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 14166, 14195);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 13668, 15194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 13668, 15194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 15206, 15480);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 15434, 15469);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 15206, 15480);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 15206, 15480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 15206, 15480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 15492, 15783);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 15737, 15772);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 15492, 15783);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 15492, 15783);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 15492, 15783);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override AstVisitAction VisitTrap(TrapStatementAst trapStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 15795, 16034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 15988, 16023);

                return AstVisitAction.SkipChildren;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 15795, 16034);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 15795, 16034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 15795, 16034);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1561, 1142, 16041);

        static System.StringComparer
        f_1561_1299_1331()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 1299, 1331);
            return return_v;
        }


        static System.Collections.Generic.HashSet<string>
        f_1561_1279_1332(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 1279, 1332);
            return return_v;
        }


        static bool
        f_1561_2793_2831(System.Collections.Generic.HashSet<string>
        this_param, string
        item)
        {
            var return_v = this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 2793, 2831);
            return return_v;
        }


        static string[]
        f_1561_2739_2759_I(string[]
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 2739, 2759);
            return return_v;
        }


        System.StringComparer
        f_1561_5544_5576()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 5544, 5576);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
        f_1561_5496_5577(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 5496, 5577);
            return return_v;
        }


        int
        f_1561_5847_5907(string[]
        array, string
        value)
        {
            var return_v = Array.IndexOf(array, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 5847, 5907);
            return return_v;
        }


        int
        f_1561_5828_6020(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 5828, 6020);
            return 0;
        }


        int
        f_1561_6054_6110(string[]
        array, string
        value)
        {
            var return_v = Array.IndexOf(array, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 6054, 6110);
            return return_v;
        }


        int
        f_1561_6035_6219(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 6035, 6219);
            return 0;
        }


        int
        f_1561_6253_6309(string[]
        array, string
        value)
        {
            var return_v = Array.IndexOf(array, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 6253, 6309);
            return return_v;
        }


        int
        f_1561_6234_6418(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 6234, 6418);
            return 0;
        }


        int
        f_1561_6452_6509(string[]
        array, string
        value)
        {
            var return_v = Array.IndexOf(array, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 6452, 6509);
            return return_v;
        }


        int
        f_1561_6433_6619(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 6433, 6619);
            return 0;
        }


        int
        f_1561_6653_6713(string[]
        array, string
        value)
        {
            var return_v = Array.IndexOf(array, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 6653, 6713);
            return return_v;
        }


        int
        f_1561_6634_6826(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 6634, 6826);
            return 0;
        }


        int
        f_1561_6860_6929(string[]
        array, string
        value)
        {
            var return_v = Array.IndexOf(array, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 6860, 6929);
            return return_v;
        }


        int
        f_1561_6841_7051(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 6841, 7051);
            return 0;
        }


        int
        f_1561_7085_7149(string[]
        array, string
        value)
        {
            var return_v = Array.IndexOf(array, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 7085, 7149);
            return return_v;
        }


        int
        f_1561_7066_7266(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 7066, 7266);
            return 0;
        }


        int
        f_1561_7300_7364(string[]
        array, string
        value)
        {
            var return_v = Array.IndexOf(array, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 7300, 7364);
            return return_v;
        }


        int
        f_1561_7281_7481(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 7281, 7481);
            return 0;
        }


        int
        f_1561_7515_7580(string[]
        array, string
        value)
        {
            var return_v = Array.IndexOf(array, value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 7515, 7580);
            return return_v;
        }


        int
        f_1561_7496_7698(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 7496, 7698);
            return 0;
        }


        int
        f_1561_7751_7776(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 7751, 7776);
            return return_v;
        }


        int
        f_1561_7815_7914(System.Management.Automation.Language.FindAllVariablesVisitor
        this_param, string
        variableName, int
        index, System.Type
        type, bool
        automatic)
        {
            this_param.NoteVariable(variableName, index, type, automatic: automatic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 7815, 7914);
            return 0;
        }


        int
        f_1561_8093_8119(string[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 8093, 8119);
            return return_v;
        }


        int
        f_1561_8166_8353(System.Management.Automation.Language.FindAllVariablesVisitor
        this_param, string
        variableName, int
        index, System.Type
        type, bool
        preferenceVariable)
        {
            this_param.NoteVariable(variableName, index, type, preferenceVariable: preferenceVariable);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 8166, 8353);
            return 0;
        }


        int
        f_1561_8404_8503(System.Management.Automation.Language.FindAllVariablesVisitor
        this_param, string
        variableName, int
        index, System.Type
        type, bool
        automatic)
        {
            this_param.NoteVariable(variableName, index, type, automatic: automatic);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 8404, 8503);
            return 0;
        }

    }
    internal class VariableAnalysis : ICustomAstVisitor2
    {
        internal const int
        Unanalyzed = -1
        ;

        internal const int
        ForceDynamic = -2
        ;
        private class LoopGotoTargets
        {
            internal LoopGotoTargets(string label, Block breakTarget, Block continueTarget)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1561, 17150, 17400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17416, 17459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17475, 17523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17539, 17590);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17262, 17281);

                    this.Label = label;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17299, 17330);

                    this.BreakTarget = breakTarget;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17348, 17385);

                    this.ContinueTarget = continueTarget;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1561, 17150, 17400);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 17150, 17400);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 17150, 17400);
                }
            }

            internal string Label { get; private set; }

            internal Block BreakTarget { get; private set; }

            internal Block ContinueTarget { get; private set; }

            static LoopGotoTargets()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1561, 17096, 17601);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1561, 17096, 17601);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 17096, 17601);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1561, 17096, 17601);
        }
        private class Block
        {
            internal readonly List<Ast> _asts;

            private readonly List<Block> _successors;

            internal readonly List<Block> _predecessors;

            internal object _visitData;

            internal bool _throws;

            internal bool _returns;

            internal bool _unreachable { get; private set; }

            public Block()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1561, 18285, 18372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17685, 17708);
                    this._asts = f_1561_17693_17708();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17752, 17783);
                    this._successors = f_1561_17766_17783();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17828, 17861);
                    this._predecessors = f_1561_17844_17861();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17894, 17904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17933, 17940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17969, 17977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17992, 18040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 18332, 18357);

                    this._unreachable = true;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1561, 18285, 18372);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 18285, 18372);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 18285, 18372);
                }
            }

            public static Block NewEntryBlock()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 18388, 18508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 18456, 18493);

                    return f_1561_18463_18492(unreachable: false);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 18388, 18508);

                    System.Management.Automation.Language.VariableAnalysis.Block
                    f_1561_18463_18492(bool
                    unreachable)
                    {
                        var return_v = new System.Management.Automation.Language.VariableAnalysis.Block(unreachable: unreachable);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 18463, 18492);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 18388, 18508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 18388, 18508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private Block(bool unreachable)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1561, 18524, 18635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17685, 17708);
                    this._asts = f_1561_17693_17708();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17752, 17783);
                    this._successors = f_1561_17766_17783();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17828, 17861);
                    this._predecessors = f_1561_17844_17861();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17894, 17904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17933, 17940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17969, 17977);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17992, 18040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 18588, 18620);

                    this._unreachable = unreachable;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1561, 18524, 18635);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 18524, 18635);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 18524, 18635);
                }
            }

            internal void FlowsTo(Block next)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 18827, 19215);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 18893, 19200) || true) && (f_1561_18897_18922(_successors, next) < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 18893, 19200);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 18968, 19084) || true) && (f_1561_18972_18985_M(!_unreachable))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 18968, 19084);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 19035, 19061);

                            next._unreachable = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 18968, 19084);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 19108, 19130);

                        f_1561_19108_19129(
                                            _successors, next);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 19152, 19181);

                        f_1561_19152_19180(next._predecessors, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 18893, 19200);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 18827, 19215);

                    int
                    f_1561_18897_18922(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                    this_param, System.Management.Automation.Language.VariableAnalysis.Block
                    item)
                    {
                        var return_v = this_param.IndexOf(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 18897, 18922);
                        return return_v;
                    }


                    bool
                    f_1561_18972_18985_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 18972, 18985);
                        return return_v;
                    }


                    int
                    f_1561_19108_19129(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                    this_param, System.Management.Automation.Language.VariableAnalysis.Block
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 19108, 19129);
                        return 0;
                    }


                    int
                    f_1561_19152_19180(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                    this_param, System.Management.Automation.Language.VariableAnalysis.Block
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 19152, 19180);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 18827, 19215);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 18827, 19215);
                }
            }

            internal void AddAst(Ast ast)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 19231, 19503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 19293, 19455);

                    f_1561_19293_19454(ast is VariableExpressionAst || (DynAbs.Tracing.TraceSender.Expression_False(1561, 19312, 19367) || ast is AssignmentTarget) || (DynAbs.Tracing.TraceSender.Expression_False(1561, 19312, 19394) || ast is DataStatementAst), "Only add variables and assignments");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 19473, 19488);

                    f_1561_19473_19487(_asts, ast);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 19231, 19503);

                    int
                    f_1561_19293_19454(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 19293, 19454);
                        return 0;
                    }


                    int
                    f_1561_19473_19487(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                    this_param, System.Management.Automation.Language.Ast
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 19473, 19487);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 19231, 19503);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 19231, 19503);
                }
            }

            internal static List<Block> GenerateReverseDepthFirstOrder(Block block)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 19519, 19946);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 19623, 19662);

                    List<Block>
                    result = f_1561_19644_19661()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 19682, 19718);

                    f_1561_19682_19717(block, result);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 19736, 19753);

                    f_1561_19736_19752(result);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 19780, 19785);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 19771, 19897) || true) && (i < f_1561_19791_19803(result))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 19805, 19808)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 19771, 19897))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 19771, 19897);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 19850, 19878);

                            f_1561_19850_19859(result, i)._visitData = null;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 127);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 127);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 19917, 19931);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 19519, 19946);

                    System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                    f_1561_19644_19661()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 19644, 19661);
                        return return_v;
                    }


                    int
                    f_1561_19682_19717(System.Management.Automation.Language.VariableAnalysis.Block
                    block, System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                    visitData)
                    {
                        VisitDepthFirstOrder(block, visitData);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 19682, 19717);
                        return 0;
                    }


                    int
                    f_1561_19736_19752(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                    this_param)
                    {
                        this_param.Reverse();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 19736, 19752);
                        return 0;
                    }


                    int
                    f_1561_19791_19803(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 19791, 19803);
                        return return_v;
                    }


                    System.Management.Automation.Language.VariableAnalysis.Block
                    f_1561_19850_19859(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 19850, 19859);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 19519, 19946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 19519, 19946);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static void VisitDepthFirstOrder(Block block, List<Block> visitData)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 19962, 20413);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 20071, 20149) || true) && (f_1561_20075_20119(block._visitData, visitData))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 20071, 20149);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 20142, 20149);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 20071, 20149);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 20169, 20198);

                    block._visitData = visitData;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 20218, 20357);
                        foreach (Block succ in f_1561_20241_20258_I(block._successors))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 20218, 20357);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 20300, 20338);

                            f_1561_20300_20337(succ, visitData);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 20218, 20357);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 140);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 140);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 20377, 20398);

                    f_1561_20377_20397(
                                    visitData, block);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 19962, 20413);

                    bool
                    f_1561_20075_20119(object
                    objA, System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                    objB)
                    {
                        var return_v = ReferenceEquals(objA, (object)objB);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 20075, 20119);
                        return return_v;
                    }


                    int
                    f_1561_20300_20337(System.Management.Automation.Language.VariableAnalysis.Block
                    block, System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                    visitData)
                    {
                        VisitDepthFirstOrder(block, visitData);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 20300, 20337);
                        return 0;
                    }


                    System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                    f_1561_20241_20258_I(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 20241, 20258);
                        return return_v;
                    }


                    int
                    f_1561_20377_20397(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                    this_param, System.Management.Automation.Language.VariableAnalysis.Block
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 20377, 20397);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 19962, 20413);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 19962, 20413);
                }
            }

            static Block()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1561, 17613, 20424);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1561, 17613, 20424);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 17613, 20424);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1561, 17613, 20424);

            System.Collections.Generic.List<System.Management.Automation.Language.Ast>
            f_1561_17693_17708()
            {
                var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.Ast>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 17693, 17708);
                return return_v;
            }


            System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
            f_1561_17766_17783()
            {
                var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 17766, 17783);
                return return_v;
            }


            System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
            f_1561_17844_17861()
            {
                var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 17844, 17861);
                return return_v;
            }

        }
        private class AssignmentTarget : Ast
        {
            internal readonly ExpressionAst _targetAst;

            internal readonly string _variableName;

            internal readonly Type _type;

            public AssignmentTarget(ExpressionAst targetExpressionAst)
            : base(f_1561_20735_20764_C(f_1561_20735_20764()))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1561, 20652, 20851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 20529, 20539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 20579, 20592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 20630, 20635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 20798, 20836);

                    this._targetAst = targetExpressionAst;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1561, 20652, 20851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 20652, 20851);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 20652, 20851);
                }
            }

            public AssignmentTarget(string variableName, Type type)
            : base(f_1561_20947_20976_C(f_1561_20947_20976()))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1561, 20867, 21095);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 20529, 20539);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 20579, 20592);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 20630, 20635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 21010, 21044);

                    this._variableName = variableName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 21062, 21080);

                    this._type = type;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1561, 20867, 21095);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 20867, 21095);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 20867, 21095);
                }
            }

            public override Ast Copy()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 21111, 21270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 21170, 21225);

                    f_1561_21170_21224(false, "This code is unreachable.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 21243, 21255);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 21111, 21270);

                    int
                    f_1561_21170_21224(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 21170, 21224);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 21111, 21270);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 21111, 21270);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override object Accept(ICustomAstVisitor visitor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 21286, 21477);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 21377, 21432);

                    f_1561_21377_21431(false, "This code is unreachable.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 21450, 21462);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 21286, 21477);

                    int
                    f_1561_21377_21431(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 21377, 21431);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 21286, 21477);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 21286, 21477);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            internal override AstVisitAction InternalVisit(AstVisitor visitor)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 21493, 21711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 21592, 21647);

                    f_1561_21592_21646(false, "This code is unreachable.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 21665, 21696);

                    return AstVisitAction.Continue;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 21493, 21711);

                    int
                    f_1561_21592_21646(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 21592, 21646);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 21493, 21711);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 21493, 21711);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static AssignmentTarget()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1561, 20436, 21722);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1561, 20436, 21722);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 20436, 21722);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1561, 20436, 21722);

            static System.Management.Automation.Language.IScriptExtent
            f_1561_20735_20764()
            {
                var return_v = PositionUtilities.EmptyExtent;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 20735, 20764);
                return return_v;
            }


            static System.Management.Automation.Language.IScriptExtent
            f_1561_20735_20764_C(System.Management.Automation.Language.IScriptExtent
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1561, 20652, 20851);
                return return_v;
            }


            static System.Management.Automation.Language.IScriptExtent
            f_1561_20947_20976()
            {
                var return_v = PositionUtilities.EmptyExtent;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 20947, 20976);
                return return_v;
            }


            static System.Management.Automation.Language.IScriptExtent
            f_1561_20947_20976_C(System.Management.Automation.Language.IScriptExtent
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1561, 20867, 21095);
                return return_v;
            }

        }

        internal static string GetUnaliasedVariableName(string varName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 21734, 22002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 21822, 21991);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1561, 21829, 21904) || ((f_1561_21829_21904(varName, SpecialVariables.PSItem, StringComparison.OrdinalIgnoreCase) && DynAbs.Tracing.TraceSender.Conditional_F2(1561, 21931, 21956)) || DynAbs.Tracing.TraceSender.Conditional_F3(1561, 21983, 21990))) ? SpecialVariables.Underbar
                : varName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 21734, 22002);

                bool
                f_1561_21829_21904(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 21829, 21904);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 21734, 22002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 21734, 22002);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetUnaliasedVariableName(VariablePath varPath)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 22014, 22176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 22108, 22165);

                return f_1561_22115_22164(f_1561_22140_22163(varPath));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 22014, 22176);

                string
                f_1561_22140_22163(System.Management.Automation.VariablePath
                this_param)
                {
                    var return_v = this_param.UnqualifiedPath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 22140, 22163);
                    return return_v;
                }


                string
                f_1561_22115_22164(string
                varName)
                {
                    var return_v = GetUnaliasedVariableName(varName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 22115, 22164);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 22014, 22176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 22014, 22176);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly ConcurrentDictionary<string, bool> s_allScopeVariables;

        internal static void NoteAllScopeVariable(string variableName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 22774, 22921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 22861, 22910);

                f_1561_22861_22909(s_allScopeVariables, variableName, true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 22774, 22921);

                bool
                f_1561_22861_22909(System.Collections.Concurrent.ConcurrentDictionary<string, bool>
                this_param, string
                key, bool
                value)
                {
                    var return_v = this_param.GetOrAdd(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 22861, 22909);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 22774, 22921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 22774, 22921);
            }
        }

        internal static bool AnyVariablesCouldBeAllScope(Dictionary<string, int> variableNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 22933, 23148);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 23045, 23137);

                return f_1561_23052_23136(variableNames, keyValuePair => s_allScopeVariables.ContainsKey(keyValuePair.Key));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 22933, 23148);

                bool
                f_1561_23052_23136(System.Collections.Generic.Dictionary<string, int>
                source, System.Func<System.Collections.Generic.KeyValuePair<string, int>, bool>
                predicate)
                {
                    var return_v = source.Any<System.Collections.Generic.KeyValuePair<string, int>>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 23052, 23136);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 22933, 23148);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 22933, 23148);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Dictionary<string, VariableAnalysisDetails> _variables;

        private Block _entryBlock;

        private Block _exitBlock;

        private Block _currentBlock;

        private bool _disableOptimizations;

        private readonly List<LoopGotoTargets> _loopTargets;

        private int _localsAllocated;

        internal static Tuple<Type, Dictionary<string, int>> AnalyzeExpression(ExpressionAst exprAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 23615, 23797);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 23733, 23786);

                return f_1561_23740_23785((f_1561_23741_23763()), exprAst);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 23615, 23797);

                System.Management.Automation.Language.VariableAnalysis
                f_1561_23741_23763()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 23741, 23763);
                    return return_v;
                }


                System.Tuple<System.Type, System.Collections.Generic.Dictionary<string, int>>
                f_1561_23740_23785(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Management.Automation.Language.ExpressionAst
                exprAst)
                {
                    var return_v = this_param.AnalyzeImpl(exprAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 23740, 23785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 23615, 23797);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 23615, 23797);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tuple<Type, Dictionary<string, int>> AnalyzeImpl(ExpressionAst exprAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 23809, 24562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 23913, 23965);

                _variables = f_1561_23926_23964(exprAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 24258, 24287);

                _disableOptimizations = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 24301, 24308);

                f_1561_24301_24307(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 24324, 24386);

                _localsAllocated = f_1561_24343_24385(SpecialVariables.AutomaticVariables);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 24400, 24428);

                _currentBlock = _entryBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 24442, 24463);

                f_1561_24442_24462(exprAst, this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 24477, 24511);

                f_1561_24477_24510(_currentBlock, _exitBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 24527, 24551);

                return f_1561_24534_24550(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 23809, 24562);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                f_1561_23926_23964(System.Management.Automation.Language.ExpressionAst
                exprAst)
                {
                    var return_v = FindAllVariablesVisitor.Visit(exprAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 23926, 23964);
                    return return_v;
                }


                int
                f_1561_24301_24307(System.Management.Automation.Language.VariableAnalysis
                this_param)
                {
                    this_param.Init();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 24301, 24307);
                    return 0;
                }


                int
                f_1561_24343_24385(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 24343, 24385);
                    return return_v;
                }


                object
                f_1561_24442_24462(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 24442, 24462);
                    return return_v;
                }


                int
                f_1561_24477_24510(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 24477, 24510);
                    return 0;
                }


                System.Tuple<System.Type, System.Collections.Generic.Dictionary<string, int>>
                f_1561_24534_24550(System.Management.Automation.Language.VariableAnalysis
                this_param)
                {
                    var return_v = this_param.FinishAnalysis();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 24534, 24550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 23809, 24562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 23809, 24562);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static Tuple<Type, Dictionary<string, int>> AnalyzeTrap(TrapStatementAst trap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 24574, 24747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 24686, 24736);

                return f_1561_24693_24735((f_1561_24694_24716()), trap);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 24574, 24747);

                System.Management.Automation.Language.VariableAnalysis
                f_1561_24694_24716()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 24694, 24716);
                    return return_v;
                }


                System.Tuple<System.Type, System.Collections.Generic.Dictionary<string, int>>
                f_1561_24693_24735(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Management.Automation.Language.TrapStatementAst
                trap)
                {
                    var return_v = this_param.AnalyzeImpl(trap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 24693, 24735);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 24574, 24747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 24574, 24747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tuple<Type, Dictionary<string, int>> AnalyzeImpl(TrapStatementAst trap)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 24759, 25481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 24863, 24912);

                _variables = f_1561_24876_24911(trap);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 25175, 25204);

                _disableOptimizations = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 25218, 25225);

                f_1561_25218_25224(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 25241, 25303);

                _localsAllocated = f_1561_25260_25302(SpecialVariables.AutomaticVariables);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 25317, 25345);

                _currentBlock = _entryBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 25359, 25382);

                f_1561_25359_25381(f_1561_25359_25368(trap), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 25396, 25430);

                f_1561_25396_25429(_currentBlock, _exitBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 25446, 25470);

                return f_1561_25453_25469(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 24759, 25481);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                f_1561_24876_24911(System.Management.Automation.Language.TrapStatementAst
                trap)
                {
                    var return_v = FindAllVariablesVisitor.Visit(trap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 24876, 24911);
                    return return_v;
                }


                int
                f_1561_25218_25224(System.Management.Automation.Language.VariableAnalysis
                this_param)
                {
                    this_param.Init();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 25218, 25224);
                    return 0;
                }


                int
                f_1561_25260_25302(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 25260, 25302);
                    return return_v;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1561_25359_25368(System.Management.Automation.Language.TrapStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 25359, 25368);
                    return return_v;
                }


                object
                f_1561_25359_25381(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 25359, 25381);
                    return return_v;
                }


                int
                f_1561_25396_25429(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 25396, 25429);
                    return 0;
                }


                System.Tuple<System.Type, System.Collections.Generic.Dictionary<string, int>>
                f_1561_25453_25469(System.Management.Automation.Language.VariableAnalysis
                this_param)
                {
                    var return_v = this_param.FinishAnalysis();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 25453, 25469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 24759, 25481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 24759, 25481);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void Init()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 25493, 25623);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 25537, 25573);

                _entryBlock = f_1561_25551_25572();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 25587, 25612);

                _exitBlock = f_1561_25600_25611();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 25493, 25623);

                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_25551_25572()
                {
                    var return_v = Block.NewEntryBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 25551, 25572);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_25600_25611()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 25600, 25611);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 25493, 25623);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 25493, 25623);
            }
        }

        internal static Tuple<Type, Dictionary<string, int>> Analyze(IParameterMetadataProvider ast, bool disableOptimizations, bool scriptCmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 25635, 25894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 25798, 25883);

                return f_1561_25805_25882((f_1561_25806_25828()), ast, disableOptimizations, scriptCmdlet);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 25635, 25894);

                System.Management.Automation.Language.VariableAnalysis
                f_1561_25806_25828()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 25806, 25828);
                    return return_v;
                }


                System.Tuple<System.Type, System.Collections.Generic.Dictionary<string, int>>
                f_1561_25805_25882(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Management.Automation.Language.IParameterMetadataProvider
                ast, bool
                disableOptimizations, bool
                scriptCmdlet)
                {
                    var return_v = this_param.AnalyzeImpl(ast, disableOptimizations, scriptCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 25805, 25882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 25635, 25894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 25635, 25894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool AnalyzeMemberFunction(FunctionMemberAst ast)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 26235, 26532);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 26325, 26372);

                VariableAnalysis
                va = (f_1561_26348_26370())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 26386, 26420);

                f_1561_26386_26419(va, ast, false, false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 26434, 26521);

                return f_1561_26441_26520(va._exitBlock._predecessors, b => b._returns || b._throws || b._unreachable);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 26235, 26532);

                System.Management.Automation.Language.VariableAnalysis
                f_1561_26348_26370()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 26348, 26370);
                    return return_v;
                }


                System.Tuple<System.Type, System.Collections.Generic.Dictionary<string, int>>
                f_1561_26386_26419(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Management.Automation.Language.FunctionMemberAst
                ast, bool
                disableOptimizations, bool
                scriptCmdlet)
                {
                    var return_v = this_param.AnalyzeImpl((System.Management.Automation.Language.IParameterMetadataProvider)ast, disableOptimizations, scriptCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 26386, 26419);
                    return return_v;
                }


                bool
                f_1561_26441_26520(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                source, System.Func<System.Management.Automation.Language.VariableAnalysis.Block, bool>
                predicate)
                {
                    var return_v = source.All<System.Management.Automation.Language.VariableAnalysis.Block>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 26441, 26520);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 26235, 26532);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 26235, 26532);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tuple<Type, Dictionary<string, int>> AnalyzeImpl(IParameterMetadataProvider ast, bool disableOptimizations, bool scriptCmdlet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 26544, 30423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 26703, 26836);

                _variables = f_1561_26716_26835(ast, disableOptimizations, scriptCmdlet, out _localsAllocated, out _disableOptimizations);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 26850, 26857);

                f_1561_26850_26856(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 26873, 30322) || true) && (f_1561_26877_26891(ast) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 26873, 30322);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 26933, 30307);
                        foreach (var parameter in f_1561_26959_26973_I(f_1561_26959_26973(ast)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 26933, 30307);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 27015, 27062);

                            var
                            variablePath = f_1561_27034_27061(f_1561_27034_27048(parameter))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 27084, 30288) || true) && (f_1561_27088_27113(variablePath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 27084, 30288);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 27163, 27190);

                                bool
                                anyAttributes = false
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 27216, 27239);

                                int
                                countConverts = -1
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 27332, 27349);

                                Type
                                type = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 27375, 27407);

                                bool
                                anyUnresolvedTypes = false
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 27433, 28964);
                                    foreach (var paramAst in f_1561_27458_27478_I(f_1561_27458_27478(parameter)))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 27433, 28964);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 27536, 28937) || true) && (paramAst is TypeConstraintAst)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 27536, 28937);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 27635, 27654);

                                            countConverts += 1;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 27688, 28059) || true) && (type == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 27688, 28059);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 27778, 27823);

                                                type = f_1561_27785_27822(f_1561_27785_27802(paramAst));

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 27861, 28024) || true) && (type == null)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 27861, 28024);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 27959, 27985);

                                                    anyUnresolvedTypes = true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 27861, 28024);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 27688, 28059);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 27536, 28937);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 27536, 28937);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 28189, 28251);

                                            var
                                            attrType = f_1561_28204_28250(f_1561_28204_28221(paramAst))
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 28285, 28906) || true) && (attrType == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 28285, 28906);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 28379, 28405);

                                                anyUnresolvedTypes = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 28285, 28906);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 28285, 28906);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 28479, 28906) || true) && (f_1561_28483_28544(typeof(ValidateArgumentsAttribute), attrType) || (DynAbs.Tracing.TraceSender.Expression_False(1561, 28483, 28651) || f_1561_28585_28651(typeof(ArgumentTransformationAttribute), attrType)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 28479, 28906);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 28850, 28871);

                                                    anyAttributes = true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 28479, 28906);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 28285, 28906);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 27536, 28937);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 27433, 28964);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 1532);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 1532);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 28992, 29045);

                                var
                                varName = f_1561_29006_29044(variablePath)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 29071, 29105);

                                var
                                details = f_1561_29085_29104(_variables, varName)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 29131, 29155);

                                details.Assigned = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 29181, 29227);

                                type = type ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type>(1561, 29188, 29226) ?? f_1561_29196_29208(details) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type>(1561, 29196, 29226) ?? typeof(object)));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 29846, 30181) || true) && ((anyAttributes || (DynAbs.Tracing.TraceSender.Expression_False(1561, 29851, 29886) || anyUnresolvedTypes) || (DynAbs.Tracing.TraceSender.Expression_False(1561, 29851, 29907) || countConverts > 0) || (DynAbs.Tracing.TraceSender.Expression_False(1561, 29851, 29953) || f_1561_29911_29953(typeof(PSReference), type)) || (DynAbs.Tracing.TraceSender.Expression_False(1561, 29851, 29974) || f_1561_29957_29974(type))) && (DynAbs.Tracing.TraceSender.Expression_True(1561, 29850, 30026) && f_1561_30008_30026_M(!details.Automatic)) && (DynAbs.Tracing.TraceSender.Expression_True(1561, 29850, 30057) && f_1561_30030_30057_M(!details.PreferenceVariable)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 29846, 30181);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 30115, 30154);

                                    details.LocalTupleIndex = ForceDynamic;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 29846, 30181);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 30209, 30265);

                                f_1561_30209_30264(
                                                        _entryBlock, f_1561_30228_30263(varName, type));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 27084, 30288);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 26933, 30307);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 3375);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 3375);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 26873, 30322);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 30338, 30360);

                f_1561_30338_30359(f_1561_30338_30346(ast), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 30376, 30412);

                return f_1561_30383_30411(this, scriptCmdlet);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 26544, 30423);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                f_1561_26716_26835(System.Management.Automation.Language.IParameterMetadataProvider
                ast, bool
                disableOptimizations, bool
                scriptCmdlet, out int
                localsAllocated, out bool
                forceNoOptimizing)
                {
                    var return_v = FindAllVariablesVisitor.Visit(ast, disableOptimizations, scriptCmdlet, out localsAllocated, out forceNoOptimizing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 26716, 26835);
                    return return_v;
                }


                int
                f_1561_26850_26856(System.Management.Automation.Language.VariableAnalysis
                this_param)
                {
                    this_param.Init();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 26850, 26856);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                f_1561_26877_26891(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 26877, 26891);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                f_1561_26959_26973(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 26959, 26973);
                    return return_v;
                }


                System.Management.Automation.Language.VariableExpressionAst
                f_1561_27034_27048(System.Management.Automation.Language.ParameterAst
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 27034, 27048);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1561_27034_27061(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 27034, 27061);
                    return return_v;
                }


                bool
                f_1561_27088_27113(System.Management.Automation.VariablePath
                variablePath)
                {
                    var return_v = variablePath.IsAnyLocal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 27088, 27113);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeBaseAst>
                f_1561_27458_27478(System.Management.Automation.Language.ParameterAst
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 27458, 27478);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1561_27785_27802(System.Management.Automation.Language.AttributeBaseAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 27785, 27802);
                    return return_v;
                }


                System.Type
                f_1561_27785_27822(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.GetReflectionType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 27785, 27822);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1561_28204_28221(System.Management.Automation.Language.AttributeBaseAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 28204, 28221);
                    return return_v;
                }


                System.Type
                f_1561_28204_28250(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.GetReflectionAttributeType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 28204, 28250);
                    return return_v;
                }


                bool
                f_1561_28483_28544(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 28483, 28544);
                    return return_v;
                }


                bool
                f_1561_28585_28651(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 28585, 28651);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeBaseAst>
                f_1561_27458_27478_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.AttributeBaseAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 27458, 27478);
                    return return_v;
                }


                string
                f_1561_29006_29044(System.Management.Automation.VariablePath
                varPath)
                {
                    var return_v = GetUnaliasedVariableName(varPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 29006, 29044);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysisDetails
                f_1561_29085_29104(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 29085, 29104);
                    return return_v;
                }


                System.Type
                f_1561_29196_29208(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 29196, 29208);
                    return return_v;
                }


                bool
                f_1561_29911_29953(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 29911, 29953);
                    return return_v;
                }


                bool
                f_1561_29957_29974(System.Type
                type)
                {
                    var return_v = MustBeBoxed(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 29957, 29974);
                    return return_v;
                }


                bool
                f_1561_30008_30026_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 30008, 30026);
                    return return_v;
                }


                bool
                f_1561_30030_30057_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 30030, 30057);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.AssignmentTarget
                f_1561_30228_30263(string
                variableName, System.Type
                type)
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.AssignmentTarget(variableName, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 30228, 30263);
                    return return_v;
                }


                int
                f_1561_30209_30264(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.AssignmentTarget
                ast)
                {
                    this_param.AddAst((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 30209, 30264);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                f_1561_26959_26973_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ParameterAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 26959, 26973);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1561_30338_30346(System.Management.Automation.Language.IParameterMetadataProvider
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 30338, 30346);
                    return return_v;
                }


                object
                f_1561_30338_30359(System.Management.Automation.Language.ScriptBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 30338, 30359);
                    return return_v;
                }


                System.Tuple<System.Type, System.Collections.Generic.Dictionary<string, int>>
                f_1561_30383_30411(System.Management.Automation.Language.VariableAnalysis
                this_param, bool
                scriptCmdlet)
                {
                    var return_v = this_param.FinishAnalysis(scriptCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 30383, 30411);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 26544, 30423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 26544, 30423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Tuple<Type, Dictionary<string, int>> FinishAnalysis(bool scriptCmdlet = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 30435, 34835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 30546, 30609);

                var
                blocks = f_1561_30559_30608(_entryBlock)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 30731, 30777);

                var
                bitArray = f_1561_30746_30776(f_1561_30759_30775(_variables))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 30791, 30823);

                f_1561_30791_30800(blocks, 0)._visitData = bitArray;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 30837, 30871);

                f_1561_30837_30870(this, bitArray, f_1561_30860_30869(blocks, 0));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 30896, 30905);

                    for (int
        index = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 30887, 31798) || true) && (index < f_1561_30915_30927(blocks))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 30929, 30936)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 30887, 31798))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 30887, 31798);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 30970, 30996);

                        var
                        block = f_1561_30982_30995(blocks, index)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 31016, 31058);

                        bitArray = f_1561_31027_31057(f_1561_31040_31056(_variables));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 31076, 31098);

                        f_1561_31076_31097(bitArray, true);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 31116, 31144);

                        block._visitData = bitArray;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 31164, 31182);

                        int
                        predCount = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 31200, 31582);
                            foreach (var pred in f_1561_31221_31240_I(block._predecessors))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 31200, 31582);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 31382, 31563) || true) && (pred._visitData != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 31382, 31563);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 31459, 31474);

                                    predCount += 1;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 31500, 31540);

                                    f_1561_31500_31539(bitArray, pred._visitData);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 31382, 31563);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 31200, 31582);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 383);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 383);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 31602, 31733);

                        f_1561_31602_31732(predCount != 0, "If we didn't and anything, there is a flaw in the logic and incorrect code may be generated.");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 31753, 31783);

                        f_1561_31753_31782(this, bitArray, block);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 912);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 912);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 31814, 31957);

                f_1561_31814_31956(f_1561_31833_31910(_exitBlock._predecessors, p => p._unreachable || p._visitData is BitArray), "VisitData wasn't set on a reachable block");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 31973, 32367);
                    foreach (var details in f_1561_31997_32014_I(f_1561_31997_32014(_variables)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 31973, 32367);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 32048, 32352) || true) && (f_1561_32052_32075(details) == ForceDynamic)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 32048, 32352);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 32133, 32333);
                                foreach (var ast in f_1561_32153_32175_I(f_1561_32153_32175(details)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 32133, 32333);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 32225, 32258);

                                    f_1561_32225_32257(ast, ForceDynamic);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 32284, 32310);

                                    f_1561_32284_32309(ast, details);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 32133, 32333);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 201);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 201);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 32048, 32352);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 31973, 32367);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 395);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 395);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 32881, 33392);

                var
                orderedLocals = f_1561_32901_33391((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from details in _variables.Values
                                                                                                            where (details.LocalTupleIndex >= 0 || (details.LocalTupleIndex == ForceDynamic &&
                                                                                                                                    details.Automatic &&
                                                                                                                                    details.Name != SpecialVariables.Question))
                                                                                                            orderby details.LocalTupleIndex
                                                                                                            select details, 1561, 32902, 33380)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 33408, 33742);

                f_1561_33408_33741(!_disableOptimizations
                || (DynAbs.Tracing.TraceSender.Expression_False(1561, 33427, 33635) || f_1561_33470_33490(orderedLocals) == (int)AutomaticVariable.NumberOfAutomaticVariables +
                                        ((DynAbs.Tracing.TraceSender.Conditional_F1(1561, 33572, 33584) || ((scriptCmdlet && DynAbs.Tracing.TraceSender.Conditional_F2(1561, 33587, 33630)) || DynAbs.Tracing.TraceSender.Conditional_F3(1561, 33633, 33634))) ? f_1561_33587_33630(SpecialVariables.PreferenceVariables) : 0)), "analysis is incorrectly allocating number of locals when optimizations are disabled.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 33758, 33844);

                var
                nameToIndexMap = f_1561_33779_33843(0, f_1561_33810_33842())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 33867, 33872);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 33858, 34653) || true) && (i < f_1561_33878_33898(orderedLocals))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 33900, 33903)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 33858, 34653))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 33858, 34653);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 33937, 33968);

                        var
                        details = orderedLocals[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 33986, 34010);

                        var
                        name = f_1561_33997_34009(details)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 34028, 34056);

                        f_1561_34028_34055(nameToIndexMap, name, i);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 34076, 34306) || true) && (f_1561_34080_34103(details) != i)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 34076, 34306);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 34150, 34287);
                                foreach (var ast in f_1561_34170_34192_I(f_1561_34170_34192(details)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 34150, 34287);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 34242, 34264);

                                    f_1561_34242_34263(ast, i);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 34150, 34287);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 138);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 138);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 34076, 34306);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 34562, 34638);

                        f_1561_34562_34637(f_1561_34581_34593(details) != null, "Type should be resolved already");
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 796);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 796);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 34669, 34763);

                var
                tupleType = f_1561_34685_34762(f_1561_34712_34761((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from l in orderedLocals select l.Type, 1561, 34713, 34750))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 34777, 34824);

                return f_1561_34784_34823(tupleType, nameToIndexMap);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 30435, 34835);

                System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                f_1561_30559_30608(System.Management.Automation.Language.VariableAnalysis.Block
                block)
                {
                    var return_v = Block.GenerateReverseDepthFirstOrder(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 30559, 30608);
                    return return_v;
                }


                int
                f_1561_30759_30775(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 30759, 30775);
                    return return_v;
                }


                System.Collections.BitArray
                f_1561_30746_30776(int
                length)
                {
                    var return_v = new System.Collections.BitArray(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 30746, 30776);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_30791_30800(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 30791, 30800);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_30860_30869(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 30860, 30869);
                    return return_v;
                }


                int
                f_1561_30837_30870(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Collections.BitArray
                assignedBitArray, System.Management.Automation.Language.VariableAnalysis.Block
                block)
                {
                    this_param.AnalyzeBlock(assignedBitArray, block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 30837, 30870);
                    return 0;
                }


                int
                f_1561_30915_30927(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 30915, 30927);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_30982_30995(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 30982, 30995);
                    return return_v;
                }


                int
                f_1561_31040_31056(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 31040, 31056);
                    return return_v;
                }


                System.Collections.BitArray
                f_1561_31027_31057(int
                length)
                {
                    var return_v = new System.Collections.BitArray(length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 31027, 31057);
                    return return_v;
                }


                int
                f_1561_31076_31097(System.Collections.BitArray
                this_param, bool
                value)
                {
                    this_param.SetAll(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 31076, 31097);
                    return 0;
                }


                System.Collections.BitArray
                f_1561_31500_31539(System.Collections.BitArray
                this_param, object
                value)
                {
                    var return_v = this_param.And((System.Collections.BitArray)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 31500, 31539);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                f_1561_31221_31240_I(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 31221, 31240);
                    return return_v;
                }


                int
                f_1561_31602_31732(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 31602, 31732);
                    return 0;
                }


                int
                f_1561_31753_31782(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Collections.BitArray
                assignedBitArray, System.Management.Automation.Language.VariableAnalysis.Block
                block)
                {
                    this_param.AnalyzeBlock(assignedBitArray, block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 31753, 31782);
                    return 0;
                }


                bool
                f_1561_31833_31910(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.Block>
                source, System.Func<System.Management.Automation.Language.VariableAnalysis.Block, bool>
                predicate)
                {
                    var return_v = source.All<System.Management.Automation.Language.VariableAnalysis.Block>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 31833, 31910);
                    return return_v;
                }


                int
                f_1561_31814_31956(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 31814, 31956);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>.ValueCollection
                f_1561_31997_32014(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 31997, 32014);
                    return return_v;
                }


                int
                f_1561_32052_32075(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.LocalTupleIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 32052, 32075);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1561_32153_32175(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.AssociatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 32153, 32175);
                    return return_v;
                }


                int
                f_1561_32225_32257(System.Management.Automation.Language.Ast
                ast, int
                newIndex)
                {
                    FixTupleIndex(ast, newIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 32225, 32257);
                    return 0;
                }


                int
                f_1561_32284_32309(System.Management.Automation.Language.Ast
                ast, System.Management.Automation.Language.VariableAnalysisDetails
                details)
                {
                    FixAssigned(ast, details);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 32284, 32309);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1561_32153_32175_I(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 32153, 32175);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>.ValueCollection
                f_1561_31997_32014_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 31997, 32014);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysisDetails[]
                f_1561_32901_33391(System.Linq.IOrderedEnumerable<System.Management.Automation.Language.VariableAnalysisDetails>
                source)
                {
                    var return_v = source.ToArray<System.Management.Automation.Language.VariableAnalysisDetails>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 32901, 33391);
                    return return_v;
                }


                int
                f_1561_33470_33490(System.Management.Automation.Language.VariableAnalysisDetails[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 33470, 33490);
                    return return_v;
                }


                int
                f_1561_33587_33630(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 33587, 33630);
                    return return_v;
                }


                int
                f_1561_33408_33741(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 33408, 33741);
                    return 0;
                }


                System.StringComparer
                f_1561_33810_33842()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 33810, 33842);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, int>
                f_1561_33779_33843(int
                capacity, System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, int>(capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 33779, 33843);
                    return return_v;
                }


                int
                f_1561_33878_33898(System.Management.Automation.Language.VariableAnalysisDetails[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 33878, 33898);
                    return return_v;
                }


                string
                f_1561_33997_34009(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 33997, 34009);
                    return return_v;
                }


                int
                f_1561_34028_34055(System.Collections.Generic.Dictionary<string, int>
                this_param, string
                key, int
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 34028, 34055);
                    return 0;
                }


                int
                f_1561_34080_34103(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.LocalTupleIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 34080, 34103);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1561_34170_34192(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.AssociatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 34170, 34192);
                    return return_v;
                }


                int
                f_1561_34242_34263(System.Management.Automation.Language.Ast
                ast, int
                newIndex)
                {
                    FixTupleIndex(ast, newIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 34242, 34263);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1561_34170_34192_I(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 34170, 34192);
                    return return_v;
                }


                System.Type
                f_1561_34581_34593(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 34581, 34593);
                    return return_v;
                }


                int
                f_1561_34562_34637(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 34562, 34637);
                    return 0;
                }


                System.Type[]
                f_1561_34712_34761(System.Collections.Generic.IEnumerable<System.Type>
                source)
                {
                    var return_v = source.ToArray<System.Type>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 34712, 34761);
                    return return_v;
                }


                System.Type
                f_1561_34685_34762(params System.Type[]
                types)
                {
                    var return_v = MutableTuple.MakeTupleType(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 34685, 34762);
                    return return_v;
                }


                System.Tuple<System.Type, System.Collections.Generic.Dictionary<string, int>>
                f_1561_34784_34823(System.Type
                item1, System.Collections.Generic.Dictionary<string, int>
                item2)
                {
                    var return_v = Tuple.Create(item1, item2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 34784, 34823);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 30435, 34835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 30435, 34835);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool MustBeBoxed(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 34847, 35267);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 35140, 35256);

                return (f_1561_35148_35164(type) && (DynAbs.Tracing.TraceSender.Expression_True(1561, 35148, 35219) && f_1561_35168_35219(type))) && (DynAbs.Tracing.TraceSender.Expression_True(1561, 35147, 35255) && typeof(SwitchParameter) != type);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 34847, 35267);

                bool
                f_1561_35148_35164(System.Type
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 35148, 35164);
                    return return_v;
                }


                bool
                f_1561_35168_35219(System.Type
                type)
                {
                    var return_v = PSVariableAssignmentBinder.IsValueTypeMutable(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 35168, 35219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 34847, 35267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 34847, 35267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void FixTupleIndex(Ast ast, int newIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 35279, 36020);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 35360, 35407);

                var
                variableAst = ast as VariableExpressionAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 35421, 36009) || true) && (variableAst != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 35421, 36009);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 35478, 35615) || true) && (f_1561_35482_35504(variableAst) != ForceDynamic)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 35478, 35615);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 35562, 35596);

                        variableAst.TupleIndex = newIndex;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 35478, 35615);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 35421, 36009);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 35421, 36009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 35681, 35728);

                    var
                    dataStatementAst = ast as DataStatementAst
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 35746, 35994) || true) && (dataStatementAst != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 35746, 35994);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 35816, 35975) || true) && (f_1561_35820_35847(dataStatementAst) != ForceDynamic)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 35816, 35975);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 35913, 35952);

                            dataStatementAst.TupleIndex = newIndex;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 35816, 35975);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 35746, 35994);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 35421, 36009);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 35279, 36020);

                int
                f_1561_35482_35504(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.TupleIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 35482, 35504);
                    return return_v;
                }


                int
                f_1561_35820_35847(System.Management.Automation.Language.DataStatementAst
                this_param)
                {
                    var return_v = this_param.TupleIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 35820, 35847);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 35279, 36020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 35279, 36020);
            }
        }

        private static void FixAssigned(Ast ast, VariableAnalysisDetails details)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 36032, 36322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 36130, 36177);

                var
                variableAst = ast as VariableExpressionAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 36191, 36311) || true) && (variableAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1561, 36195, 36234) && f_1561_36218_36234(details)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 36191, 36311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 36268, 36296);

                    variableAst.Assigned = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 36191, 36311);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 36032, 36322);

                bool
                f_1561_36218_36234(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.Assigned;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 36218, 36234);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 36032, 36322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 36032, 36322);
            }
        }

        private void AnalyzeBlock(BitArray assignedBitArray, Block block)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 36334, 38755);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 36424, 38744);
                    foreach (var ast in f_1561_36444_36455_I(block._asts))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 36424, 38744);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 36489, 36546);

                        var
                        variableExpressionAst = ast as VariableExpressionAst
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 36564, 37636) || true) && (variableExpressionAst != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 36564, 37636);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 36639, 36688);

                            var
                            varPath = f_1561_36653_36687(variableExpressionAst)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 36710, 37584) || true) && (f_1561_36714_36734(varPath))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 36710, 37584);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 36784, 36832);

                                var
                                varName = f_1561_36798_36831(varPath)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 36858, 36892);

                                var
                                details = f_1561_36872_36891(_variables, varName)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 36918, 37561) || true) && (f_1561_36922_36939(details))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 36918, 37561);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 36997, 37056);

                                    variableExpressionAst.TupleIndex = f_1561_37032_37055(details);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 37086, 37125);

                                    variableExpressionAst.Automatic = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 36918, 37561);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 36918, 37561);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 37239, 37534);

                                    variableExpressionAst.TupleIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(1561, 37274, 37339) || ((f_1561_37274_37308(assignedBitArray, f_1561_37291_37307(details)) && (DynAbs.Tracing.TraceSender.Expression_True(1561, 37274, 37339) && f_1561_37312_37339_M(!details.PreferenceVariable)) && DynAbs.Tracing.TraceSender.Conditional_F2(1561, 37410, 37433)) || DynAbs.Tracing.TraceSender.Conditional_F3(1561, 37504, 37533))) ? f_1561_37410_37433(details) : VariableAnalysis.ForceDynamic;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 36918, 37561);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 36710, 37584);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 37608, 37617);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 36564, 37636);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 37656, 37703);

                        var
                        assignmentTarget = ast as AssignmentTarget
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 37721, 38207) || true) && (assignmentTarget != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 37721, 38207);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 37791, 38155) || true) && (assignmentTarget._targetAst != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 37791, 38155);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 37880, 37942);

                                f_1561_37880_37941(this, assignmentTarget._targetAst, assignedBitArray);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 37791, 38155);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 37791, 38155);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 38040, 38132);

                                f_1561_38040_38131(this, assignmentTarget._variableName, assignedBitArray, assignmentTarget._type);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 37791, 38155);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 38179, 38188);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 37721, 38207);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 38227, 38274);

                        var
                        dataStatementAst = ast as DataStatementAst
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 38292, 38648) || true) && (dataStatementAst != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 38292, 38648);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 38362, 38455);

                            var
                            details = f_1561_38376_38454(this, f_1561_38394_38419(dataStatementAst), assignedBitArray, typeof(object))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 38477, 38531);

                            dataStatementAst.TupleIndex = f_1561_38507_38530(details);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 38553, 38598);

                            f_1561_38553_38597(f_1561_38553_38575(details), dataStatementAst);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 38620, 38629);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 38292, 38648);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 38668, 38729);

                        f_1561_38668_38728(false, "Unexpected type in list of ASTs");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 36424, 38744);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 2321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 2321);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 36334, 38755);

                System.Management.Automation.VariablePath
                f_1561_36653_36687(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 36653, 36687);
                    return return_v;
                }


                bool
                f_1561_36714_36734(System.Management.Automation.VariablePath
                variablePath)
                {
                    var return_v = variablePath.IsAnyLocal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 36714, 36734);
                    return return_v;
                }


                string
                f_1561_36798_36831(System.Management.Automation.VariablePath
                varPath)
                {
                    var return_v = GetUnaliasedVariableName(varPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 36798, 36831);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysisDetails
                f_1561_36872_36891(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 36872, 36891);
                    return return_v;
                }


                bool
                f_1561_36922_36939(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.Automatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 36922, 36939);
                    return return_v;
                }


                int
                f_1561_37032_37055(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.LocalTupleIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 37032, 37055);
                    return return_v;
                }


                int
                f_1561_37291_37307(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.BitIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 37291, 37307);
                    return return_v;
                }


                bool
                f_1561_37274_37308(System.Collections.BitArray
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 37274, 37308);
                    return return_v;
                }


                bool
                f_1561_37312_37339_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 37312, 37339);
                    return return_v;
                }


                int
                f_1561_37410_37433(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.LocalTupleIndex
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 37410, 37433);
                    return return_v;
                }


                int
                f_1561_37880_37941(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Management.Automation.Language.ExpressionAst
                lhs, System.Collections.BitArray
                assignedBitArray)
                {
                    this_param.CheckLHSAssign(lhs, assignedBitArray);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 37880, 37941);
                    return 0;
                }


                System.Management.Automation.Language.VariableAnalysisDetails
                f_1561_38040_38131(System.Management.Automation.Language.VariableAnalysis
                this_param, string
                variableName, System.Collections.BitArray
                assignedBitArray, System.Type
                convertType)
                {
                    var return_v = this_param.CheckLHSAssignVar(variableName, assignedBitArray, convertType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 38040, 38131);
                    return return_v;
                }


                string
                f_1561_38394_38419(System.Management.Automation.Language.DataStatementAst
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 38394, 38419);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysisDetails
                f_1561_38376_38454(System.Management.Automation.Language.VariableAnalysis
                this_param, string
                variableName, System.Collections.BitArray
                assignedBitArray, System.Type
                convertType)
                {
                    var return_v = this_param.CheckLHSAssignVar(variableName, assignedBitArray, convertType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 38376, 38454);
                    return return_v;
                }


                int
                f_1561_38507_38530(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.LocalTupleIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 38507, 38530);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1561_38553_38575(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.AssociatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 38553, 38575);
                    return return_v;
                }


                int
                f_1561_38553_38597(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, System.Management.Automation.Language.DataStatementAst
                item)
                {
                    this_param.Add((System.Management.Automation.Language.Ast)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 38553, 38597);
                    return 0;
                }


                int
                f_1561_38668_38728(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 38668, 38728);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1561_36444_36455_I(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 36444, 36455);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 36334, 38755);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 36334, 38755);
            }
        }

        private void CheckLHSAssign(ExpressionAst lhs, BitArray assignedBitArray)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 38767, 40546);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 38865, 38911);

                var
                convertExpr = lhs as ConvertExpressionAst
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 38925, 38949);

                Type
                convertType = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 38963, 39114) || true) && (convertExpr != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 38963, 39114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 39020, 39044);

                    lhs = f_1561_39026_39043(convertExpr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 39062, 39099);

                    convertType = f_1561_39076_39098(convertExpr);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 38963, 39114);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 39130, 39173);

                var
                varExpr = lhs as VariableExpressionAst
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 39187, 39253);

                f_1561_39187_39252(varExpr != null, "unexpected ast type on lhs");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 39269, 39304);

                var
                varPath = f_1561_39283_39303(varExpr)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 39318, 40535) || true) && (f_1561_39322_39342(varPath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 39318, 40535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 39376, 39424);

                    var
                    varName = f_1561_39390_39423(varPath)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 39442, 40034) || true) && (convertType == null && (DynAbs.Tracing.TraceSender.Expression_True(1561, 39446, 39671) && (f_1561_39491_39568(varName, SpecialVariables.@foreach, StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1561, 39491, 39670) || f_1561_39594_39670(varName, SpecialVariables.@switch, StringComparison.OrdinalIgnoreCase)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 39442, 40034);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 39986, 40015);

                        convertType = typeof(object);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 39442, 40034);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 40054, 40154);

                    VariableAnalysisDetails
                    analysisDetails = f_1561_40096_40153(this, varName, assignedBitArray, convertType)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 40174, 40218);

                    f_1561_40174_40217(f_1561_40174_40204(analysisDetails), varExpr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 40236, 40268);

                    analysisDetails.Assigned = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 40286, 40339);

                    varExpr.TupleIndex = f_1561_40307_40338(analysisDetails);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 40357, 40403);

                    varExpr.Automatic = f_1561_40377_40402(analysisDetails);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 39318, 40535);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 39318, 40535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 40469, 40520);

                    varExpr.TupleIndex = VariableAnalysis.ForceDynamic;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 39318, 40535);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 38767, 40546);

                System.Management.Automation.Language.ExpressionAst
                f_1561_39026_39043(System.Management.Automation.Language.ConvertExpressionAst
                this_param)
                {
                    var return_v = this_param.Child;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 39026, 39043);
                    return return_v;
                }


                System.Type
                f_1561_39076_39098(System.Management.Automation.Language.ConvertExpressionAst
                this_param)
                {
                    var return_v = this_param.StaticType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 39076, 39098);
                    return return_v;
                }


                int
                f_1561_39187_39252(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 39187, 39252);
                    return 0;
                }


                System.Management.Automation.VariablePath
                f_1561_39283_39303(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 39283, 39303);
                    return return_v;
                }


                bool
                f_1561_39322_39342(System.Management.Automation.VariablePath
                variablePath)
                {
                    var return_v = variablePath.IsAnyLocal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 39322, 39342);
                    return return_v;
                }


                string
                f_1561_39390_39423(System.Management.Automation.VariablePath
                varPath)
                {
                    var return_v = GetUnaliasedVariableName(varPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 39390, 39423);
                    return return_v;
                }


                bool
                f_1561_39491_39568(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 39491, 39568);
                    return return_v;
                }


                bool
                f_1561_39594_39670(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 39594, 39670);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysisDetails
                f_1561_40096_40153(System.Management.Automation.Language.VariableAnalysis
                this_param, string
                variableName, System.Collections.BitArray
                assignedBitArray, System.Type
                convertType)
                {
                    var return_v = this_param.CheckLHSAssignVar(variableName, assignedBitArray, convertType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 40096, 40153);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1561_40174_40204(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.AssociatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 40174, 40204);
                    return return_v;
                }


                int
                f_1561_40174_40217(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, System.Management.Automation.Language.VariableExpressionAst
                item)
                {
                    this_param.Add((System.Management.Automation.Language.Ast)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 40174, 40217);
                    return 0;
                }


                int
                f_1561_40307_40338(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.LocalTupleIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 40307, 40338);
                    return return_v;
                }


                bool
                f_1561_40377_40402(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.Automatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 40377, 40402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 38767, 40546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 38767, 40546);
            }
        }

        private VariableAnalysisDetails CheckLHSAssignVar(string variableName, BitArray assignedBitArray, Type convertType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 40558, 42720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 40698, 40745);

                var
                analysisDetails = f_1561_40720_40744(_variables, variableName)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 40759, 41142) || true) && (f_1561_40763_40794(analysisDetails) == VariableAnalysis.Unanalyzed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 40759, 41142);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 40859, 41127);

                    analysisDetails.LocalTupleIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(1561, 40893, 40963) || ((_disableOptimizations || (DynAbs.Tracing.TraceSender.Expression_False(1561, 40893, 40963) || f_1561_40918_40963(s_allScopeVariables, variableName)) && DynAbs.Tracing.TraceSender.Conditional_F2(1561, 41021, 41050)) || DynAbs.Tracing.TraceSender.Conditional_F3(1561, 41108, 41126))) ? VariableAnalysis.ForceDynamic
                    : _localsAllocated++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 40759, 41142);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 41158, 41322) || true) && (convertType != null && (DynAbs.Tracing.TraceSender.Expression_True(1561, 41162, 41209) && f_1561_41185_41209(convertType)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 41158, 41322);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 41243, 41307);

                    analysisDetails.LocalTupleIndex = VariableAnalysis.ForceDynamic;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 41158, 41322);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 41338, 41370);

                var
                type = f_1561_41349_41369(analysisDetails)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 41384, 42601) || true) && (type == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 41384, 42601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 41434, 41487);

                    analysisDetails.Type = convertType ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Type>(1561, 41457, 41486) ?? typeof(object));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 41384, 42601);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 41384, 42601);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 41553, 41964) || true) && (f_1561_41557_41600_M(!assignedBitArray[f_1561_41575_41599(analysisDetails)]) && (DynAbs.Tracing.TraceSender.Expression_True(1561, 41557, 41623) && convertType == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 41553, 41964);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 41916, 41945);

                        convertType = typeof(object);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 41553, 41964);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 41984, 42586) || true) && (convertType != null && (DynAbs.Tracing.TraceSender.Expression_True(1561, 41988, 42036) && !f_1561_42012_42036(convertType, type)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 41984, 42586);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 42078, 42567) || true) && (f_1561_42082_42107(analysisDetails) || (DynAbs.Tracing.TraceSender.Expression_False(1561, 42082, 42145) || f_1561_42111_42145(analysisDetails)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 42078, 42567);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 42361, 42399);

                            analysisDetails.Type = typeof(object);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 42078, 42567);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 42078, 42567);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 42497, 42544);

                            analysisDetails.LocalTupleIndex = ForceDynamic;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 42078, 42567);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 41984, 42586);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 41384, 42601);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 42617, 42670);

                f_1561_42617_42669(
                            assignedBitArray, f_1561_42638_42662(analysisDetails), true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 42686, 42709);

                return analysisDetails;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 40558, 42720);

                System.Management.Automation.Language.VariableAnalysisDetails
                f_1561_40720_40744(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 40720, 40744);
                    return return_v;
                }


                int
                f_1561_40763_40794(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.LocalTupleIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 40763, 40794);
                    return return_v;
                }


                bool
                f_1561_40918_40963(System.Collections.Concurrent.ConcurrentDictionary<string, bool>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 40918, 40963);
                    return return_v;
                }


                bool
                f_1561_41185_41209(System.Type
                type)
                {
                    var return_v = MustBeBoxed(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 41185, 41209);
                    return return_v;
                }


                System.Type
                f_1561_41349_41369(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 41349, 41369);
                    return return_v;
                }


                int
                f_1561_41575_41599(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.BitIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 41575, 41599);
                    return return_v;
                }


                bool
                f_1561_41557_41600_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 41557, 41600);
                    return return_v;
                }


                bool
                f_1561_42012_42036(System.Type
                this_param, System.Type
                o)
                {
                    var return_v = this_param.Equals(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 42012, 42036);
                    return return_v;
                }


                bool
                f_1561_42082_42107(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.Automatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 42082, 42107);
                    return return_v;
                }


                bool
                f_1561_42111_42145(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.PreferenceVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 42111, 42145);
                    return return_v;
                }


                int
                f_1561_42638_42662(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.BitIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 42638, 42662);
                    return return_v;
                }


                int
                f_1561_42617_42669(System.Collections.BitArray
                this_param, int
                index, bool
                value)
                {
                    this_param.Set(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 42617, 42669);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 40558, 42720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 40558, 42720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitErrorStatement(ErrorStatementAst errorStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 42732, 42850);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 42827, 42839);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 42732, 42850);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 42732, 42850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 42732, 42850);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitErrorExpression(ErrorExpressionAst errorExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 42862, 42983);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 42960, 42972);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 42862, 42983);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 42862, 42983);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 42862, 42983);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitScriptBlock(ScriptBlockAst scriptBlockAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 42995, 43776);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 43081, 43109);

                _currentBlock = _entryBlock;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 43125, 43264) || true) && (f_1561_43129_43161(scriptBlockAst) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 43125, 43264);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 43203, 43249);

                    f_1561_43203_43248(f_1561_43203_43235(scriptBlockAst), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 43125, 43264);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 43280, 43405) || true) && (f_1561_43284_43309(scriptBlockAst) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 43280, 43405);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 43351, 43390);

                    f_1561_43351_43389(f_1561_43351_43376(scriptBlockAst), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 43280, 43405);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 43421, 43550) || true) && (f_1561_43425_43452(scriptBlockAst) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 43421, 43550);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 43494, 43535);

                    f_1561_43494_43534(f_1561_43494_43521(scriptBlockAst), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 43421, 43550);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 43566, 43687) || true) && (f_1561_43570_43593(scriptBlockAst) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 43566, 43687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 43635, 43672);

                    f_1561_43635_43671(f_1561_43635_43658(scriptBlockAst), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 43566, 43687);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 43703, 43737);

                f_1561_43703_43736(
                            _currentBlock, _exitBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 43753, 43765);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 42995, 43776);

                System.Management.Automation.Language.NamedBlockAst
                f_1561_43129_43161(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.DynamicParamBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 43129, 43161);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1561_43203_43235(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.DynamicParamBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 43203, 43235);
                    return return_v;
                }


                object
                f_1561_43203_43248(System.Management.Automation.Language.NamedBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 43203, 43248);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1561_43284_43309(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.BeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 43284, 43309);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1561_43351_43376(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.BeginBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 43351, 43376);
                    return return_v;
                }


                object
                f_1561_43351_43389(System.Management.Automation.Language.NamedBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 43351, 43389);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1561_43425_43452(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 43425, 43452);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1561_43494_43521(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.ProcessBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 43494, 43521);
                    return return_v;
                }


                object
                f_1561_43494_43534(System.Management.Automation.Language.NamedBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 43494, 43534);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1561_43570_43593(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 43570, 43593);
                    return return_v;
                }


                System.Management.Automation.Language.NamedBlockAst
                f_1561_43635_43658(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.EndBlock;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 43635, 43658);
                    return return_v;
                }


                object
                f_1561_43635_43671(System.Management.Automation.Language.NamedBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 43635, 43671);
                    return return_v;
                }


                int
                f_1561_43703_43736(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 43703, 43736);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 42995, 43776);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 42995, 43776);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitParamBlock(ParamBlockAst paramBlockAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 43788, 43894);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 43871, 43883);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 43788, 43894);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 43788, 43894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 43788, 43894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitNamedBlock(NamedBlockAst namedBlockAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 43906, 44114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 44050, 44103);

                return f_1561_44057_44102(this, f_1561_44077_44101(namedBlockAst));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 43906, 44114);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                f_1561_44077_44101(System.Management.Automation.Language.NamedBlockAst
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 44077, 44101);
                    return return_v;
                }


                object
                f_1561_44057_44102(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                statements)
                {
                    var return_v = this_param.VisitStatementBlock(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 44057, 44102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 43906, 44114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 43906, 44114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitTypeConstraint(TypeConstraintAst typeConstraintAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 44126, 44307);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 44221, 44270);

                f_1561_44221_44269(false, "Code is unreachable");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 44284, 44296);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 44126, 44307);

                int
                f_1561_44221_44269(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 44221, 44269);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 44126, 44307);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 44126, 44307);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitAttribute(AttributeAst attributeAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 44319, 44485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 44399, 44448);

                f_1561_44399_44447(false, "Code is unreachable");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 44462, 44474);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 44319, 44485);

                int
                f_1561_44399_44447(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 44399, 44447);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 44319, 44485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 44319, 44485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitNamedAttributeArgument(NamedAttributeArgumentAst namedAttributeArgumentAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 44497, 44702);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 44616, 44665);

                f_1561_44616_44664(false, "Code is unreachable");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 44679, 44691);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 44497, 44702);

                int
                f_1561_44616_44664(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 44616, 44664);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 44497, 44702);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 44497, 44702);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitParameter(ParameterAst parameterAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 44714, 45000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 44914, 44963);

                f_1561_44914_44962(false, "Code is unreachable");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 44977, 44989);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 44714, 45000);

                int
                f_1561_44914_44962(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 44914, 44962);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 44714, 45000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 44714, 45000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitFunctionDefinition(FunctionDefinitionAst functionDefinitionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 45012, 45297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 45274, 45286);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 45012, 45297);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 45012, 45297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 45012, 45297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitStatementBlock(StatementBlockAst statementBlockAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 45309, 45533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 45465, 45522);

                return f_1561_45472_45521(this, f_1561_45492_45520(statementBlockAst));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 45309, 45533);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                f_1561_45492_45520(System.Management.Automation.Language.StatementBlockAst
                this_param)
                {
                    var return_v = this_param.Statements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 45492, 45520);
                    return return_v;
                }


                object
                f_1561_45472_45521(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                statements)
                {
                    var return_v = this_param.VisitStatementBlock(statements);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 45472, 45521);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 45309, 45533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 45309, 45533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private object VisitStatementBlock(ReadOnlyCollection<StatementAst> statements)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 45545, 45786);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 45649, 45747);
                    foreach (var stmt in f_1561_45670_45680_I(statements))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 45649, 45747);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 45714, 45732);

                        f_1561_45714_45731(stmt, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 45649, 45747);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 99);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 99);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 45763, 45775);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 45545, 45786);

                object
                f_1561_45714_45731(System.Management.Automation.Language.StatementAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 45714, 45731);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                f_1561_45670_45680_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.StatementAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 45670, 45680);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 45545, 45786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 45545, 45786);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitIfStatement(IfStatementAst ifStmtAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 45798, 47125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 45879, 45909);

                Block
                afterStmt = f_1561_45897_45908()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 45925, 46112) || true) && (f_1561_45929_45949(ifStmtAst) == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 45925, 46112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46064, 46097);

                    f_1561_46064_46096(                // There is no else, flow can go straight to afterStmt.
                                    _currentBlock, afterStmt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 45925, 46112);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46128, 46170);

                int
                clauseCount = f_1561_46146_46169(f_1561_46146_46163(ifStmtAst))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46193, 46198);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46184, 46864) || true) && (i < clauseCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46217, 46220)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 46184, 46864))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 46184, 46864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46254, 46288);

                        var
                        clause = f_1561_46267_46287(f_1561_46267_46284(ifStmtAst), i)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46306, 46383);

                        bool
                        isLastClause = (i == (clauseCount - 1) && (DynAbs.Tracing.TraceSender.Expression_True(1561, 46327, 46381) && f_1561_46353_46373(ifStmtAst) == null))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46401, 46433);

                        Block
                        clauseBlock = f_1561_46421_46432()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46451, 46508);

                        Block
                        nextBlock = (DynAbs.Tracing.TraceSender.Conditional_F1(1561, 46469, 46481) || ((isLastClause && DynAbs.Tracing.TraceSender.Conditional_F2(1561, 46484, 46493)) || DynAbs.Tracing.TraceSender.Conditional_F3(1561, 46496, 46507))) ? afterStmt : f_1561_46496_46507()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46528, 46554);

                        f_1561_46528_46553(f_1561_46528_46540(clause), this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46574, 46609);

                        f_1561_46574_46608(
                                        _currentBlock, clauseBlock);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46627, 46660);

                        f_1561_46627_46659(_currentBlock, nextBlock);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46678, 46706);

                        _currentBlock = clauseBlock;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46726, 46752);

                        f_1561_46726_46751(f_1561_46726_46738(clause), this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46772, 46805);

                        f_1561_46772_46804(
                                        _currentBlock, afterStmt);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46823, 46849);

                        _currentBlock = nextBlock;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 681);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 681);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46880, 47046) || true) && (f_1561_46884_46904(ifStmtAst) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 46880, 47046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46946, 46980);

                    f_1561_46946_46979(f_1561_46946_46966(ifStmtAst), this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 46998, 47031);

                    f_1561_46998_47030(_currentBlock, afterStmt);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 46880, 47046);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47062, 47088);

                _currentBlock = afterStmt;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47102, 47114);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 45798, 47125);

                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_45897_45908()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 45897, 45908);
                    return return_v;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1561_45929_45949(System.Management.Automation.Language.IfStatementAst
                this_param)
                {
                    var return_v = this_param.ElseClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 45929, 45949);
                    return return_v;
                }


                int
                f_1561_46064_46096(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 46064, 46096);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.PipelineBaseAst, System.Management.Automation.Language.StatementBlockAst>>
                f_1561_46146_46163(System.Management.Automation.Language.IfStatementAst
                this_param)
                {
                    var return_v = this_param.Clauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 46146, 46163);
                    return return_v;
                }


                int
                f_1561_46146_46169(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.PipelineBaseAst, System.Management.Automation.Language.StatementBlockAst>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 46146, 46169);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.PipelineBaseAst, System.Management.Automation.Language.StatementBlockAst>>
                f_1561_46267_46284(System.Management.Automation.Language.IfStatementAst
                this_param)
                {
                    var return_v = this_param.Clauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 46267, 46284);
                    return return_v;
                }


                System.Tuple<System.Management.Automation.Language.PipelineBaseAst, System.Management.Automation.Language.StatementBlockAst>
                f_1561_46267_46287(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.PipelineBaseAst, System.Management.Automation.Language.StatementBlockAst>>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 46267, 46287);
                    return return_v;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1561_46353_46373(System.Management.Automation.Language.IfStatementAst
                this_param)
                {
                    var return_v = this_param.ElseClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 46353, 46373);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_46421_46432()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 46421, 46432);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_46496_46507()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 46496, 46507);
                    return return_v;
                }


                System.Management.Automation.Language.PipelineBaseAst
                f_1561_46528_46540(System.Tuple<System.Management.Automation.Language.PipelineBaseAst, System.Management.Automation.Language.StatementBlockAst>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 46528, 46540);
                    return return_v;
                }


                object
                f_1561_46528_46553(System.Management.Automation.Language.PipelineBaseAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 46528, 46553);
                    return return_v;
                }


                int
                f_1561_46574_46608(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 46574, 46608);
                    return 0;
                }


                int
                f_1561_46627_46659(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 46627, 46659);
                    return 0;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1561_46726_46738(System.Tuple<System.Management.Automation.Language.PipelineBaseAst, System.Management.Automation.Language.StatementBlockAst>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 46726, 46738);
                    return return_v;
                }


                object
                f_1561_46726_46751(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 46726, 46751);
                    return return_v;
                }


                int
                f_1561_46772_46804(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 46772, 46804);
                    return 0;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1561_46884_46904(System.Management.Automation.Language.IfStatementAst
                this_param)
                {
                    var return_v = this_param.ElseClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 46884, 46904);
                    return return_v;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1561_46946_46966(System.Management.Automation.Language.IfStatementAst
                this_param)
                {
                    var return_v = this_param.ElseClause;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 46946, 46966);
                    return return_v;
                }


                object
                f_1561_46946_46979(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 46946, 46979);
                    return return_v;
                }


                int
                f_1561_46998_47030(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 46998, 47030);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 45798, 47125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 45798, 47125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitTernaryExpression(TernaryExpressionAst ternaryExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 47137, 47844);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47241, 47266);

                var
                ifTrue = f_1561_47254_47265()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47280, 47306);

                var
                ifFalse = f_1561_47294_47305()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47320, 47344);

                var
                after = f_1561_47332_47343()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47360, 47404);

                f_1561_47360_47403(f_1561_47360_47390(ternaryExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47418, 47448);

                f_1561_47418_47447(_currentBlock, ifTrue);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47462, 47493);

                f_1561_47462_47492(_currentBlock, ifFalse);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47507, 47530);

                _currentBlock = ifTrue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47546, 47587);

                f_1561_47546_47586(f_1561_47546_47573(ternaryExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47601, 47630);

                f_1561_47601_47629(_currentBlock, after);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47644, 47668);

                _currentBlock = ifFalse;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47684, 47726);

                f_1561_47684_47725(f_1561_47684_47712(ternaryExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47740, 47769);

                f_1561_47740_47768(_currentBlock, after);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47783, 47805);

                _currentBlock = after;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47821, 47833);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 47137, 47844);

                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_47254_47265()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 47254, 47265);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_47294_47305()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 47294, 47305);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_47332_47343()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 47332, 47343);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1561_47360_47390(System.Management.Automation.Language.TernaryExpressionAst
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 47360, 47390);
                    return return_v;
                }


                object
                f_1561_47360_47403(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 47360, 47403);
                    return return_v;
                }


                int
                f_1561_47418_47447(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 47418, 47447);
                    return 0;
                }


                int
                f_1561_47462_47492(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 47462, 47492);
                    return 0;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1561_47546_47573(System.Management.Automation.Language.TernaryExpressionAst
                this_param)
                {
                    var return_v = this_param.IfTrue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 47546, 47573);
                    return return_v;
                }


                object
                f_1561_47546_47586(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 47546, 47586);
                    return return_v;
                }


                int
                f_1561_47601_47629(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 47601, 47629);
                    return 0;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1561_47684_47712(System.Management.Automation.Language.TernaryExpressionAst
                this_param)
                {
                    var return_v = this_param.IfFalse;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 47684, 47712);
                    return return_v;
                }


                object
                f_1561_47684_47725(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 47684, 47725);
                    return return_v;
                }


                int
                f_1561_47740_47768(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 47740, 47768);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 47137, 47844);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 47137, 47844);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitTrap(TrapStatementAst trapStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 47856, 48011);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47939, 47974);

                f_1561_47939_47973(f_1561_47939_47960(trapStatementAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 47988, 48000);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 47856, 48011);

                System.Management.Automation.Language.StatementBlockAst
                f_1561_47939_47960(System.Management.Automation.Language.TrapStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 47939, 47960);
                    return return_v;
                }


                object
                f_1561_47939_47973(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 47939, 47973);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 47856, 48011);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 47856, 48011);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitSwitchStatement(SwitchStatementAst switchStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 48023, 50334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 48121, 48172);

                var
                details = f_1561_48135_48171(_variables, SpecialVariables.@switch)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 48186, 48364) || true) && (f_1561_48190_48213(details) == VariableAnalysis.Unanalyzed && (DynAbs.Tracing.TraceSender.Expression_True(1561, 48190, 48270) && !_disableOptimizations))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 48186, 48364);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 48304, 48349);

                    details.LocalTupleIndex = _localsAllocated++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 48186, 48364);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 48380, 48680);

                Action
                generateCondition = () =>
                            {
                                switchStatementAst.Condition.Accept(this);

                // $switch is set after evaluating the condition.
                _currentBlock.AddAst(new AssignmentTarget(SpecialVariables.@switch, typeof(IEnumerator)));
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 48696, 50195);

                Action
                switchBodyGenerator = () =>
                            {
                                bool hasDefault = (switchStatementAst.Default != null);
                                Block afterStmt = new Block();

                                int clauseCount = switchStatementAst.Clauses.Count;
                                for (int i = 0; i < clauseCount; i++)
                                {
                                    var clause = switchStatementAst.Clauses[i];
                                    Block clauseBlock = new Block();
                                    bool isLastClause = (i == (clauseCount - 1) && !hasDefault);
                                    Block nextBlock = isLastClause ? afterStmt : new Block();

                                    clause.Item1.Accept(this);

                                    _currentBlock.FlowsTo(nextBlock);
                                    _currentBlock.FlowsTo(clauseBlock);
                                    _currentBlock = clauseBlock;

                                    clause.Item2.Accept(this);

                                    if (!isLastClause)
                                    {
                                        _currentBlock.FlowsTo(nextBlock);
                                        _currentBlock = nextBlock;
                                    }
                                }

                                if (hasDefault)
                                {
                    // If any clause was executed, we skip the default, so there is always a branch over the default.
                    _currentBlock.FlowsTo(afterStmt);
                                    switchStatementAst.Default.Accept(this);
                                }

                                _currentBlock.FlowsTo(afterStmt);
                                _currentBlock = afterStmt;
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 50211, 50295);

                f_1561_50211_50294(this, f_1561_50229_50253(switchStatementAst), generateCondition, switchBodyGenerator);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 50311, 50323);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 48023, 50334);

                System.Management.Automation.Language.VariableAnalysisDetails
                f_1561_48135_48171(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 48135, 48171);
                    return return_v;
                }


                int
                f_1561_48190_48213(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.LocalTupleIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 48190, 48213);
                    return return_v;
                }


                string
                f_1561_50229_50253(System.Management.Automation.Language.SwitchStatementAst
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 50229, 50253);
                    return return_v;
                }


                int
                f_1561_50211_50294(System.Management.Automation.Language.VariableAnalysis
                this_param, string
                loopLabel, System.Action
                generateCondition, System.Action
                generateLoopBody)
                {
                    this_param.GenerateWhileLoop(loopLabel, generateCondition, generateLoopBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 50211, 50294);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 48023, 50334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 48023, 50334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitDataStatement(DataStatementAst dataStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 50346, 50651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 50438, 50473);

                f_1561_50438_50472(f_1561_50438_50459(dataStatementAst), this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 50487, 50612) || true) && (f_1561_50491_50516(dataStatementAst) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 50487, 50612);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 50558, 50597);

                    f_1561_50558_50596(_currentBlock, dataStatementAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 50487, 50612);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 50628, 50640);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 50346, 50651);

                System.Management.Automation.Language.StatementBlockAst
                f_1561_50438_50459(System.Management.Automation.Language.DataStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 50438, 50459);
                    return return_v;
                }


                object
                f_1561_50438_50472(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 50438, 50472);
                    return return_v;
                }


                string
                f_1561_50491_50516(System.Management.Automation.Language.DataStatementAst
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 50491, 50516);
                    return return_v;
                }


                int
                f_1561_50558_50596(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.DataStatementAst
                ast)
                {
                    this_param.AddAst((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 50558, 50596);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 50346, 50651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 50346, 50651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GenerateWhileLoop(string loopLabel,
                                               Action generateCondition,
                                               Action generateLoopBody,
                                               Ast continueAction = null)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 50663, 52862);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 51468, 51500);

                var
                continueBlock = f_1561_51488_51499()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 51516, 52138) || true) && (continueAction != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 51516, 52138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 51576, 51613);

                    var
                    blockAfterContinue = f_1561_51601_51612()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 51719, 51761);

                    f_1561_51719_51760(
                                    // Represent the goto over the condition before the first iteration.
                                    _currentBlock, blockAfterContinue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 51781, 51811);

                    _currentBlock = continueBlock;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 51829, 51857);

                    f_1561_51829_51856(continueAction, this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 51877, 51919);

                    f_1561_51877_51918(
                                    _currentBlock, blockAfterContinue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 51937, 51972);

                    _currentBlock = blockAfterContinue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 51516, 52138);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 51516, 52138);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 52038, 52075);

                    f_1561_52038_52074(_currentBlock, continueBlock);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 52093, 52123);

                    _currentBlock = continueBlock;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 51516, 52138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 52154, 52182);

                var
                bodyBlock = f_1561_52170_52181()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 52196, 52225);

                var
                breakBlock = f_1561_52213_52224()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 52317, 52467) || true) && (generateCondition != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 52317, 52467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 52380, 52400);

                    f_1561_52380_52399(generateCondition);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 52418, 52452);

                    f_1561_52418_52451(_currentBlock, breakBlock);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 52317, 52467);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 52483, 52575);

                f_1561_52483_52574(
                            _loopTargets, f_1561_52500_52573(loopLabel ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1561, 52520, 52545) ?? string.Empty), breakBlock, continueBlock));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 52589, 52622);

                f_1561_52589_52621(_currentBlock, bodyBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 52636, 52662);

                _currentBlock = bodyBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 52676, 52695);

                f_1561_52676_52694(generateLoopBody);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 52709, 52746);

                f_1561_52709_52745(_currentBlock, continueBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 52762, 52789);

                _currentBlock = breakBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 52805, 52851);

                f_1561_52805_52850(
                            _loopTargets, f_1561_52827_52845(_loopTargets) - 1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 50663, 52862);

                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_51488_51499()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 51488, 51499);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_51601_51612()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 51601, 51612);
                    return return_v;
                }


                int
                f_1561_51719_51760(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 51719, 51760);
                    return 0;
                }


                object
                f_1561_51829_51856(System.Management.Automation.Language.Ast
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 51829, 51856);
                    return return_v;
                }


                int
                f_1561_51877_51918(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 51877, 51918);
                    return 0;
                }


                int
                f_1561_52038_52074(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 52038, 52074);
                    return 0;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_52170_52181()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 52170, 52181);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_52213_52224()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 52213, 52224);
                    return return_v;
                }


                int
                f_1561_52380_52399(System.Action
                this_param)
                {
                    this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 52380, 52399);
                    return 0;
                }


                int
                f_1561_52418_52451(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 52418, 52451);
                    return 0;
                }


                System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets
                f_1561_52500_52573(string
                label, System.Management.Automation.Language.VariableAnalysis.Block
                breakTarget, System.Management.Automation.Language.VariableAnalysis.Block
                continueTarget)
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets(label, breakTarget, continueTarget);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 52500, 52573);
                    return return_v;
                }


                int
                f_1561_52483_52574(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>
                this_param, System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 52483, 52574);
                    return 0;
                }


                int
                f_1561_52589_52621(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 52589, 52621);
                    return 0;
                }


                int
                f_1561_52676_52694(System.Action
                this_param)
                {
                    this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 52676, 52694);
                    return 0;
                }


                int
                f_1561_52709_52745(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 52709, 52745);
                    return 0;
                }


                int
                f_1561_52827_52845(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 52827, 52845);
                    return return_v;
                }


                int
                f_1561_52805_52850(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 52805, 52850);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 50663, 52862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 50663, 52862);
            }
        }

        private void GenerateDoLoop(LoopStatementAst loopStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 52874, 54270);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 53368, 53400);

                var
                continueBlock = f_1561_53388_53399()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 53414, 53442);

                var
                bodyBlock = f_1561_53430_53441()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 53456, 53485);

                var
                breakBlock = f_1561_53473_53484()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 53499, 53539);

                var
                gotoRepeatTargetBlock = f_1561_53527_53538()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 53555, 53657);

                f_1561_53555_53656(
                            _loopTargets, f_1561_53572_53655(f_1561_53592_53611(loopStatement) ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1561, 53592, 53627) ?? string.Empty), breakBlock, continueBlock));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 53673, 53706);

                f_1561_53673_53705(
                            _currentBlock, bodyBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 53720, 53746);

                _currentBlock = bodyBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 53762, 53794);

                f_1561_53762_53793(f_1561_53762_53780(loopStatement), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 53810, 53847);

                f_1561_53810_53846(
                            _currentBlock, continueBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 53861, 53891);

                _currentBlock = continueBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 53907, 53944);

                f_1561_53907_53943(f_1561_53907_53930(loopStatement), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 53960, 53994);

                f_1561_53960_53993(
                            _currentBlock, breakBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 54008, 54053);

                f_1561_54008_54052(_currentBlock, gotoRepeatTargetBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 54069, 54107);

                _currentBlock = gotoRepeatTargetBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 54121, 54154);

                f_1561_54121_54153(_currentBlock, bodyBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 54170, 54197);

                _currentBlock = breakBlock;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 54213, 54259);

                f_1561_54213_54258(
                            _loopTargets, f_1561_54235_54253(_loopTargets) - 1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 52874, 54270);

                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_53388_53399()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 53388, 53399);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_53430_53441()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 53430, 53441);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_53473_53484()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 53473, 53484);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_53527_53538()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 53527, 53538);
                    return return_v;
                }


                string
                f_1561_53592_53611(System.Management.Automation.Language.LoopStatementAst
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 53592, 53611);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets
                f_1561_53572_53655(string
                label, System.Management.Automation.Language.VariableAnalysis.Block
                breakTarget, System.Management.Automation.Language.VariableAnalysis.Block
                continueTarget)
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets(label, breakTarget, continueTarget);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 53572, 53655);
                    return return_v;
                }


                int
                f_1561_53555_53656(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>
                this_param, System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 53555, 53656);
                    return 0;
                }


                int
                f_1561_53673_53705(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 53673, 53705);
                    return 0;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1561_53762_53780(System.Management.Automation.Language.LoopStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 53762, 53780);
                    return return_v;
                }


                object
                f_1561_53762_53793(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 53762, 53793);
                    return return_v;
                }


                int
                f_1561_53810_53846(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 53810, 53846);
                    return 0;
                }


                System.Management.Automation.Language.PipelineBaseAst
                f_1561_53907_53930(System.Management.Automation.Language.LoopStatementAst
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 53907, 53930);
                    return return_v;
                }


                object
                f_1561_53907_53943(System.Management.Automation.Language.PipelineBaseAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 53907, 53943);
                    return return_v;
                }


                int
                f_1561_53960_53993(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 53960, 53993);
                    return 0;
                }


                int
                f_1561_54008_54052(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 54008, 54052);
                    return 0;
                }


                int
                f_1561_54121_54153(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 54121, 54153);
                    return 0;
                }


                int
                f_1561_54235_54253(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 54235, 54253);
                    return return_v;
                }


                int
                f_1561_54213_54258(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 54213, 54258);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 52874, 54270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 52874, 54270);
            }
        }

        public object VisitForEachStatement(ForEachStatementAst forEachStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 54282, 55512);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 54383, 54442);

                var
                foreachDetails = f_1561_54404_54441(_variables, SpecialVariables.@foreach)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 54456, 54648) || true) && (f_1561_54460_54490(foreachDetails) == VariableAnalysis.Unanalyzed && (DynAbs.Tracing.TraceSender.Expression_True(1561, 54460, 54547) && !_disableOptimizations))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 54456, 54648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 54581, 54633);

                    foreachDetails.LocalTupleIndex = _localsAllocated++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 54456, 54648);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 54664, 54691);

                var
                afterFor = f_1561_54679_54690()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 54707, 55261);

                Action
                generateCondition = () =>
                            {
                                forEachStatementAst.Condition.Accept(this);

                // The loop might not be executed, so add flow around the loop.
                _currentBlock.FlowsTo(afterFor);

                // $foreach and the iterator variable are set after evaluating the condition.
                _currentBlock.AddAst(new AssignmentTarget(SpecialVariables.@foreach, typeof(IEnumerator)));
                                _currentBlock.AddAst(new AssignmentTarget(forEachStatementAst.Variable));
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 55277, 55386);

                f_1561_55277_55385(this, f_1561_55295_55320(forEachStatementAst), generateCondition, () => forEachStatementAst.Body.Accept(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 55402, 55434);

                f_1561_55402_55433(
                            _currentBlock, afterFor);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 55448, 55473);

                _currentBlock = afterFor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 55489, 55501);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 54282, 55512);

                System.Management.Automation.Language.VariableAnalysisDetails
                f_1561_54404_54441(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 54404, 54441);
                    return return_v;
                }


                int
                f_1561_54460_54490(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.LocalTupleIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 54460, 54490);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_54679_54690()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 54679, 54690);
                    return return_v;
                }


                string
                f_1561_55295_55320(System.Management.Automation.Language.ForEachStatementAst
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 55295, 55320);
                    return return_v;
                }


                int
                f_1561_55277_55385(System.Management.Automation.Language.VariableAnalysis
                this_param, string
                loopLabel, System.Action
                generateCondition, System.Action
                generateLoopBody)
                {
                    this_param.GenerateWhileLoop(loopLabel, generateCondition, generateLoopBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 55277, 55385);
                    return 0;
                }


                int
                f_1561_55402_55433(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 55402, 55433);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 54282, 55512);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 54282, 55512);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitDoWhileStatement(DoWhileStatementAst doWhileStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 55524, 55698);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 55625, 55661);

                f_1561_55625_55660(this, doWhileStatementAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 55675, 55687);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 55524, 55698);

                int
                f_1561_55625_55660(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Management.Automation.Language.DoWhileStatementAst
                loopStatement)
                {
                    this_param.GenerateDoLoop((System.Management.Automation.Language.LoopStatementAst)loopStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 55625, 55660);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 55524, 55698);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 55524, 55698);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitDoUntilStatement(DoUntilStatementAst doUntilStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 55710, 55884);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 55811, 55847);

                f_1561_55811_55846(this, doUntilStatementAst);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 55861, 55873);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 55710, 55884);

                int
                f_1561_55811_55846(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Management.Automation.Language.DoUntilStatementAst
                loopStatement)
                {
                    this_param.GenerateDoLoop((System.Management.Automation.Language.LoopStatementAst)loopStatement);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 55811, 55846);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 55710, 55884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 55710, 55884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitForStatement(ForStatementAst forStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 55896, 56495);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 55985, 56114) || true) && (f_1561_55989_56016(forStatementAst) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 55985, 56114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 56058, 56099);

                    f_1561_56058_56098(f_1561_56058_56085(forStatementAst), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 55985, 56114);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 56130, 56284);

                var
                generateCondition = (DynAbs.Tracing.TraceSender.Conditional_F1(1561, 56154, 56187) || ((f_1561_56154_56179(forStatementAst) != null
                && DynAbs.Tracing.TraceSender.Conditional_F2(1561, 56207, 56251)) || DynAbs.Tracing.TraceSender.Conditional_F3(1561, 56271, 56283))) ? () => forStatementAst.Condition.Accept(this)
                : (Action)null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 56300, 56458);

                f_1561_56300_56457(this, f_1561_56318_56339(forStatementAst), generateCondition, () => forStatementAst.Body.Accept(this), f_1561_56432_56456(forStatementAst));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 56472, 56484);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 55896, 56495);

                System.Management.Automation.Language.PipelineBaseAst
                f_1561_55989_56016(System.Management.Automation.Language.ForStatementAst
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 55989, 56016);
                    return return_v;
                }


                System.Management.Automation.Language.PipelineBaseAst
                f_1561_56058_56085(System.Management.Automation.Language.ForStatementAst
                this_param)
                {
                    var return_v = this_param.Initializer;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 56058, 56085);
                    return return_v;
                }


                object
                f_1561_56058_56098(System.Management.Automation.Language.PipelineBaseAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 56058, 56098);
                    return return_v;
                }


                System.Management.Automation.Language.PipelineBaseAst
                f_1561_56154_56179(System.Management.Automation.Language.ForStatementAst
                this_param)
                {
                    var return_v = this_param.Condition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 56154, 56179);
                    return return_v;
                }


                string
                f_1561_56318_56339(System.Management.Automation.Language.ForStatementAst
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 56318, 56339);
                    return return_v;
                }


                System.Management.Automation.Language.PipelineBaseAst
                f_1561_56432_56456(System.Management.Automation.Language.ForStatementAst
                this_param)
                {
                    var return_v = this_param.Iterator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 56432, 56456);
                    return return_v;
                }


                int
                f_1561_56300_56457(System.Management.Automation.Language.VariableAnalysis
                this_param, string
                loopLabel, System.Action
                generateCondition, System.Action
                generateLoopBody, System.Management.Automation.Language.PipelineBaseAst
                continueAction)
                {
                    this_param.GenerateWhileLoop(loopLabel, generateCondition, generateLoopBody, (System.Management.Automation.Language.Ast)continueAction);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 56300, 56457);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 55896, 56495);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 55896, 56495);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitWhileStatement(WhileStatementAst whileStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 56507, 56835);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 56602, 56798);

                f_1561_56602_56797(this, f_1561_56620_56643(whileStatementAst), () => whileStatementAst.Condition.Accept(this), () => whileStatementAst.Body.Accept(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 56812, 56824);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 56507, 56835);

                string
                f_1561_56620_56643(System.Management.Automation.Language.WhileStatementAst
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 56620, 56643);
                    return return_v;
                }


                int
                f_1561_56602_56797(System.Management.Automation.Language.VariableAnalysis
                this_param, string
                loopLabel, System.Action
                generateCondition, System.Action
                generateLoopBody)
                {
                    this_param.GenerateWhileLoop(loopLabel, generateCondition, generateLoopBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 56602, 56797);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 56507, 56835);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 56507, 56835);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitCatchClause(CatchClauseAst catchClauseAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 56847, 57003);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 56933, 56966);

                f_1561_56933_56965(f_1561_56933_56952(catchClauseAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 56980, 56992);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 56847, 57003);

                System.Management.Automation.Language.StatementBlockAst
                f_1561_56933_56952(System.Management.Automation.Language.CatchClauseAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 56933, 56952);
                    return return_v;
                }


                object
                f_1561_56933_56965(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 56933, 56965);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 56847, 57003);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 56847, 57003);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitTryStatement(TryStatementAst tryStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 57015, 59998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 57460, 57495);

                var
                blockBeforeTry = _currentBlock
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 57509, 57537);

                _currentBlock = f_1561_57525_57536();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 57551, 57589);

                f_1561_57551_57588(blockBeforeTry, _currentBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 57605, 57639);

                f_1561_57605_57638(f_1561_57605_57625(tryStatementAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 57655, 57692);

                Block
                lastBlockInTry = _currentBlock
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 57706, 57783);

                var
                finallyFirstBlock = (DynAbs.Tracing.TraceSender.Conditional_F1(1561, 57730, 57761) || ((f_1561_57730_57753(tryStatementAst) == null && DynAbs.Tracing.TraceSender.Conditional_F2(1561, 57764, 57768)) || DynAbs.Tracing.TraceSender.Conditional_F3(1561, 57771, 57782))) ? null : f_1561_57771_57782()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 57797, 57827);

                Block
                finallyLastBlock = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 57931, 57958);

                var
                afterTry = f_1561_57946_57957()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 57974, 58005);

                bool
                isCatchAllPresent = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 58021, 58675);
                    foreach (var catchAst in f_1561_58046_58074_I(f_1561_58046_58074(tryStatementAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 58021, 58675);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 58108, 58217) || true) && (f_1561_58112_58131(catchAst))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 58108, 58217);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 58173, 58198);

                            isCatchAllPresent = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 58108, 58217);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 58465, 58493);

                        _currentBlock = f_1561_58481_58492();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 58511, 58549);

                        f_1561_58511_58548(blockBeforeTry, _currentBlock);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 58567, 58589);

                        f_1561_58567_58588(catchAst, this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 58607, 58660);

                        f_1561_58607_58659(_currentBlock, finallyFirstBlock ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Language.VariableAnalysis.Block>(1561, 58629, 58658) ?? afterTry));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 58021, 58675);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 655);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 655);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 58691, 59918) || true) && (finallyFirstBlock != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 58691, 59918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 58754, 58796);

                    f_1561_58754_58795(lastBlockInTry, finallyFirstBlock);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 58816, 58850);

                    _currentBlock = finallyFirstBlock;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 58868, 58905);

                    f_1561_58868_58904(f_1561_58868_58891(tryStatementAst), this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 58923, 58955);

                    f_1561_58923_58954(_currentBlock, afterTry);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 58975, 59008);

                    finallyLastBlock = _currentBlock;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 59223, 59704) || true) && (!isCatchAllPresent)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 59223, 59704);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 59374, 59416);

                        f_1561_59374_59415(                    // This flow exist only, if there is no catch for all exceptions.
                                            blockBeforeTry, finallyFirstBlock);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 59440, 59483);

                        var
                        rethrowAfterFinallyBlock = f_1561_59471_59482()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 59505, 59556);

                        f_1561_59505_59555(finallyLastBlock, rethrowAfterFinallyBlock);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 59578, 59618);

                        rethrowAfterFinallyBlock._throws = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 59640, 59685);

                        f_1561_59640_59684(rethrowAfterFinallyBlock, _exitBlock);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 59223, 59704);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 59769, 59804);

                    f_1561_59769_59803(
                                    // This flow always exists.
                                    finallyLastBlock, afterTry);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 58691, 59918);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 58691, 59918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 59870, 59903);

                    f_1561_59870_59902(lastBlockInTry, afterTry);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 58691, 59918);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 59934, 59959);

                _currentBlock = afterTry;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 59975, 59987);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 57015, 59998);

                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_57525_57536()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 57525, 57536);
                    return return_v;
                }


                int
                f_1561_57551_57588(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 57551, 57588);
                    return 0;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1561_57605_57625(System.Management.Automation.Language.TryStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 57605, 57625);
                    return return_v;
                }


                object
                f_1561_57605_57638(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 57605, 57638);
                    return return_v;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1561_57730_57753(System.Management.Automation.Language.TryStatementAst
                this_param)
                {
                    var return_v = this_param.Finally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 57730, 57753);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_57771_57782()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 57771, 57782);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_57946_57957()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 57946, 57957);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
                f_1561_58046_58074(System.Management.Automation.Language.TryStatementAst
                this_param)
                {
                    var return_v = this_param.CatchClauses;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 58046, 58074);
                    return return_v;
                }


                bool
                f_1561_58112_58131(System.Management.Automation.Language.CatchClauseAst
                this_param)
                {
                    var return_v = this_param.IsCatchAll;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 58112, 58131);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_58481_58492()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 58481, 58492);
                    return return_v;
                }


                int
                f_1561_58511_58548(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 58511, 58548);
                    return 0;
                }


                object
                f_1561_58567_58588(System.Management.Automation.Language.CatchClauseAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 58567, 58588);
                    return return_v;
                }


                int
                f_1561_58607_58659(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 58607, 58659);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
                f_1561_58046_58074_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CatchClauseAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 58046, 58074);
                    return return_v;
                }


                int
                f_1561_58754_58795(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 58754, 58795);
                    return 0;
                }


                System.Management.Automation.Language.StatementBlockAst
                f_1561_58868_58891(System.Management.Automation.Language.TryStatementAst
                this_param)
                {
                    var return_v = this_param.Finally;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 58868, 58891);
                    return return_v;
                }


                object
                f_1561_58868_58904(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 58868, 58904);
                    return return_v;
                }


                int
                f_1561_58923_58954(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 58923, 58954);
                    return 0;
                }


                int
                f_1561_59374_59415(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 59374, 59415);
                    return 0;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_59471_59482()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 59471, 59482);
                    return return_v;
                }


                int
                f_1561_59505_59555(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 59505, 59555);
                    return 0;
                }


                int
                f_1561_59640_59684(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 59640, 59684);
                    return 0;
                }


                int
                f_1561_59769_59803(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 59769, 59803);
                    return 0;
                }


                int
                f_1561_59870_59902(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 59870, 59902);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 57015, 59998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 57015, 59998);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void BreakOrContinue(ExpressionAst label, Func<LoopGotoTargets, Block> fieldSelector)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 60010, 61403);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 60128, 60153);

                Block
                targetBlock = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 60167, 60904) || true) && (label != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 60167, 60904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 60218, 60237);

                    f_1561_60218_60236(label, this);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 60255, 60746) || true) && (f_1561_60259_60277(_loopTargets))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 60255, 60746);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 60319, 60374);

                        var
                        labelStrAst = label as StringConstantExpressionAst
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 60396, 60727) || true) && (labelStrAst != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 60396, 60727);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 60469, 60704);

                            targetBlock = f_1561_60483_60703((DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => from t in _loopTargets
                                                                                                                      where t.Label.Equals(labelStrAst.Value, StringComparison.OrdinalIgnoreCase)
                                                                                                                      select fieldSelector(t), 1561, 60484, 60686)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 60396, 60727);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 60255, 60746);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 60167, 60904);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 60167, 60904);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 60780, 60904) || true) && (f_1561_60784_60802(_loopTargets) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 60780, 60904);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 60840, 60889);

                        targetBlock = f_1561_60854_60888(fieldSelector, f_1561_60868_60887(_loopTargets));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 60780, 60904);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 60167, 60904);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 60920, 61252) || true) && (targetBlock == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 60920, 61252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 61055, 61089);

                    f_1561_61055_61088(                // We need to report an error about bad break statement here
                                    _currentBlock, _exitBlock);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 61107, 61136);

                    _currentBlock._throws = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 60920, 61252);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 60920, 61252);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 61202, 61237);

                    f_1561_61202_61236(_currentBlock, targetBlock);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 60920, 61252);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 61364, 61392);

                _currentBlock = f_1561_61380_61391();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 60010, 61403);

                object
                f_1561_60218_60236(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 60218, 60236);
                    return return_v;
                }


                bool
                f_1561_60259_60277(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 60259, 60277);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_60483_60703(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.VariableAnalysis.Block>
                source)
                {
                    var return_v = source.LastOrDefault<System.Management.Automation.Language.VariableAnalysis.Block>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 60483, 60703);
                    return return_v;
                }


                int
                f_1561_60784_60802(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 60784, 60802);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets
                f_1561_60868_60887(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>
                source)
                {
                    var return_v = source.Last<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 60868, 60887);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_60854_60888(System.Func<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets, System.Management.Automation.Language.VariableAnalysis.Block>
                this_param, System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 60854, 60888);
                    return return_v;
                }


                int
                f_1561_61055_61088(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 61055, 61088);
                    return 0;
                }


                int
                f_1561_61202_61236(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 61202, 61236);
                    return 0;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_61380_61391()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 61380, 61391);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 60010, 61403);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 60010, 61403);
            }
        }

        public object VisitBreakStatement(BreakStatementAst breakStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 61415, 61608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 61510, 61571);

                f_1561_61510_61570(this, f_1561_61526_61549(breakStatementAst), t => t.BreakTarget);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 61585, 61597);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 61415, 61608);

                System.Management.Automation.Language.ExpressionAst
                f_1561_61526_61549(System.Management.Automation.Language.BreakStatementAst
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 61526, 61549);
                    return return_v;
                }


                int
                f_1561_61510_61570(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Management.Automation.Language.ExpressionAst
                label, System.Func<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets, System.Management.Automation.Language.VariableAnalysis.Block>
                fieldSelector)
                {
                    this_param.BreakOrContinue(label, fieldSelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 61510, 61570);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 61415, 61608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 61415, 61608);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitContinueStatement(ContinueStatementAst continueStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 61620, 61828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 61724, 61791);

                f_1561_61724_61790(this, f_1561_61740_61766(continueStatementAst), t => t.ContinueTarget);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 61805, 61817);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 61620, 61828);

                System.Management.Automation.Language.ExpressionAst
                f_1561_61740_61766(System.Management.Automation.Language.ContinueStatementAst
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 61740, 61766);
                    return return_v;
                }


                int
                f_1561_61724_61790(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Management.Automation.Language.ExpressionAst
                label, System.Func<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets, System.Management.Automation.Language.VariableAnalysis.Block>
                fieldSelector)
                {
                    this_param.BreakOrContinue(label, fieldSelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 61724, 61790);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 61620, 61828);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 61620, 61828);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Block ControlFlowStatement(PipelineBaseAst pipelineAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 61840, 62229);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 61928, 62025) || true) && (pipelineAst != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 61928, 62025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 61985, 62010);

                    f_1561_61985_62009(pipelineAst, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 61928, 62025);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 62041, 62075);

                f_1561_62041_62074(
                            _currentBlock, _exitBlock);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 62089, 62130);

                var
                lastBlockInStatement = _currentBlock
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 62146, 62174);

                _currentBlock = f_1561_62162_62173();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 62190, 62218);

                return lastBlockInStatement;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 61840, 62229);

                object
                f_1561_61985_62009(System.Management.Automation.Language.PipelineBaseAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 61985, 62009);
                    return return_v;
                }


                int
                f_1561_62041_62074(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 62041, 62074);
                    return 0;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_62162_62173()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 62162, 62173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 61840, 62229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 61840, 62229);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitReturnStatement(ReturnStatementAst returnStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 62241, 62442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 62339, 62405);

                f_1561_62339_62388(this, f_1561_62360_62387(returnStatementAst))._returns = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 62419, 62431);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 62241, 62442);

                System.Management.Automation.Language.PipelineBaseAst
                f_1561_62360_62387(System.Management.Automation.Language.ReturnStatementAst
                this_param)
                {
                    var return_v = this_param.Pipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 62360, 62387);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_62339_62388(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Management.Automation.Language.PipelineBaseAst
                pipelineAst)
                {
                    var return_v = this_param.ControlFlowStatement(pipelineAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 62339, 62388);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 62241, 62442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 62241, 62442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitExitStatement(ExitStatementAst exitStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 62454, 62646);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 62546, 62609);

                f_1561_62546_62593(this, f_1561_62567_62592(exitStatementAst))._throws = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 62623, 62635);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 62454, 62646);

                System.Management.Automation.Language.PipelineBaseAst
                f_1561_62567_62592(System.Management.Automation.Language.ExitStatementAst
                this_param)
                {
                    var return_v = this_param.Pipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 62567, 62592);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_62546_62593(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Management.Automation.Language.PipelineBaseAst
                pipelineAst)
                {
                    var return_v = this_param.ControlFlowStatement(pipelineAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 62546, 62593);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 62454, 62646);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 62454, 62646);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitThrowStatement(ThrowStatementAst throwStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 62658, 63116);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 63015, 63079);

                f_1561_63015_63063(this, f_1561_63036_63062(throwStatementAst))._throws = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 63093, 63105);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 62658, 63116);

                System.Management.Automation.Language.PipelineBaseAst
                f_1561_63036_63062(System.Management.Automation.Language.ThrowStatementAst
                this_param)
                {
                    var return_v = this_param.Pipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 63036, 63062);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_63015_63063(System.Management.Automation.Language.VariableAnalysis
                this_param, System.Management.Automation.Language.PipelineBaseAst
                pipelineAst)
                {
                    var return_v = this_param.ControlFlowStatement(pipelineAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 63015, 63063);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 62658, 63116);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 62658, 63116);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<ExpressionAst> GetAssignmentTargets(ExpressionAst expressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1561, 63128, 64035);

                var listYield = new List<ExpressionAst>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 63244, 63296);

                var
                parenExpr = expressionAst as ParenExpressionAst
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 63310, 64024) || true) && (parenExpr != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 63310, 64024);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 63365, 63519);
                        foreach (var e in f_1561_63383_63443_I(f_1561_63383_63443(f_1561_63404_63442(f_1561_63404_63422(parenExpr)))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 63365, 63519);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 63485, 63500);

                            listYield.Add(e);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 63365, 63519);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 155);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 155);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 63310, 64024);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 63310, 64024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 63585, 63637);

                    var
                    arrayLiteral = expressionAst as ArrayLiteralAst
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 63655, 64009) || true) && (arrayLiteral != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 63655, 64009);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 63721, 63881);
                            foreach (var e in f_1561_63739_63793_I(f_1561_63739_63793(f_1561_63739_63760(arrayLiteral), GetAssignmentTargets)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 63721, 63881);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 63843, 63858);

                                listYield.Add(e);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 63721, 63881);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 161);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 161);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 63655, 64009);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 63655, 64009);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 63963, 63990);

                        listYield.Add(expressionAst);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 63655, 64009);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 63310, 64024);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1561, 63128, 64035);

                return listYield;

                System.Management.Automation.Language.PipelineBaseAst
                f_1561_63404_63422(System.Management.Automation.Language.ParenExpressionAst
                this_param)
                {
                    var return_v = this_param.Pipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 63404, 63422);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1561_63404_63442(System.Management.Automation.Language.PipelineBaseAst
                this_param)
                {
                    var return_v = this_param.GetPureExpression();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 63404, 63442);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ExpressionAst>
                f_1561_63383_63443(System.Management.Automation.Language.ExpressionAst
                expressionAst)
                {
                    var return_v = GetAssignmentTargets(expressionAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 63383, 63443);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ExpressionAst>
                f_1561_63383_63443_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ExpressionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 63383, 63443);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1561_63739_63760(System.Management.Automation.Language.ArrayLiteralAst
                this_param)
                {
                    var return_v = this_param.Elements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 63739, 63760);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ExpressionAst>
                f_1561_63739_63793(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                source, System.Func<System.Management.Automation.Language.ExpressionAst, System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ExpressionAst>>
                selector)
                {
                    var return_v = source.SelectMany<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.ExpressionAst>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 63739, 63793);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ExpressionAst>
                f_1561_63739_63793_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ExpressionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 63739, 63793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 63128, 64035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 63128, 64035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitAssignmentStatement(AssignmentStatementAst assignmentStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 64047, 66562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 64157, 64199);

                f_1561_64157_64198(f_1561_64157_64185(assignmentStatementAst), this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 64215, 66523);
                    foreach (var assignTarget in f_1561_64244_64293_I(f_1561_64244_64293(f_1561_64265_64292(assignmentStatementAst))))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 64215, 66523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 64327, 64354);

                        bool
                        anyAttributes = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 64372, 64393);

                        int
                        convertCount = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 64411, 64450);

                        ConvertExpressionAst
                        convertAst = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 64468, 64495);

                        var
                        leftAst = assignTarget
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 64513, 64913) || true) && (leftAst is AttributedExpressionAst)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 64513, 64913);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 64596, 64614);

                                convertCount += 1;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 64636, 64681);

                                convertAst = leftAst as ConvertExpressionAst;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 64703, 64819) || true) && (convertAst == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 64703, 64819);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 64775, 64796);

                                    anyAttributes = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 64703, 64819);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 64843, 64894);

                                leftAst = f_1561_64853_64893(((AttributedExpressionAst)leftAst));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 64513, 64913);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 64513, 64913);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 64513, 64913);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 64933, 66508) || true) && (leftAst is VariableExpressionAst)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 64933, 66508);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 65471, 66010) || true) && (anyAttributes || (DynAbs.Tracing.TraceSender.Expression_False(1561, 65475, 65508) || convertCount > 1) || (DynAbs.Tracing.TraceSender.Expression_False(1561, 65475, 65613) || (convertAst != null && (DynAbs.Tracing.TraceSender.Expression_True(1561, 65538, 65612) && f_1561_65560_65604(f_1561_65560_65584(f_1561_65560_65575(convertAst))) == null))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 65471, 66010);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 65663, 65723);

                                var
                                varPath = f_1561_65677_65722(((VariableExpressionAst)leftAst))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 65749, 65987) || true) && (f_1561_65753_65773(varPath))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 65749, 65987);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 65831, 65891);

                                    var
                                    details = f_1561_65845_65890(_variables, f_1561_65856_65889(varPath))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 65921, 65960);

                                    details.LocalTupleIndex = ForceDynamic;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 65749, 65987);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 65471, 66010);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 66034, 66203) || true) && (!anyAttributes && (DynAbs.Tracing.TraceSender.Expression_True(1561, 66038, 66073) && convertCount <= 1))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 66034, 66203);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 66123, 66180);

                                f_1561_66123_66179(_currentBlock, f_1561_66144_66178(assignTarget));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 66034, 66203);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 64933, 66508);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 64933, 66508);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 66463, 66489);

                            f_1561_66463_66488(                    // We're not assigning to a simple variable, so visit the left so that variable references get
                                                                   // marked with their proper tuple slots.
                                                assignTarget, this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 64933, 66508);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 64215, 66523);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 2309);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 2309);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 66539, 66551);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 64047, 66562);

                System.Management.Automation.Language.StatementAst
                f_1561_64157_64185(System.Management.Automation.Language.AssignmentStatementAst
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 64157, 64185);
                    return return_v;
                }


                object
                f_1561_64157_64198(System.Management.Automation.Language.StatementAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 64157, 64198);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1561_64265_64292(System.Management.Automation.Language.AssignmentStatementAst
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 64265, 64292);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ExpressionAst>
                f_1561_64244_64293(System.Management.Automation.Language.ExpressionAst
                expressionAst)
                {
                    var return_v = GetAssignmentTargets(expressionAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 64244, 64293);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1561_64853_64893(System.Management.Automation.Language.AttributedExpressionAst
                this_param)
                {
                    var return_v = this_param.Child;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 64853, 64893);
                    return return_v;
                }


                System.Management.Automation.Language.TypeConstraintAst
                f_1561_65560_65575(System.Management.Automation.Language.ConvertExpressionAst
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 65560, 65575);
                    return return_v;
                }


                System.Management.Automation.Language.ITypeName
                f_1561_65560_65584(System.Management.Automation.Language.TypeConstraintAst
                this_param)
                {
                    var return_v = this_param.TypeName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 65560, 65584);
                    return return_v;
                }


                System.Type
                f_1561_65560_65604(System.Management.Automation.Language.ITypeName
                this_param)
                {
                    var return_v = this_param.GetReflectionType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 65560, 65604);
                    return return_v;
                }


                System.Management.Automation.VariablePath
                f_1561_65677_65722(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 65677, 65722);
                    return return_v;
                }


                bool
                f_1561_65753_65773(System.Management.Automation.VariablePath
                variablePath)
                {
                    var return_v = variablePath.IsAnyLocal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 65753, 65773);
                    return return_v;
                }


                string
                f_1561_65856_65889(System.Management.Automation.VariablePath
                varPath)
                {
                    var return_v = GetUnaliasedVariableName(varPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 65856, 65889);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysisDetails
                f_1561_65845_65890(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 65845, 65890);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.AssignmentTarget
                f_1561_66144_66178(System.Management.Automation.Language.ExpressionAst
                targetExpressionAst)
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.AssignmentTarget(targetExpressionAst);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 66144, 66178);
                    return return_v;
                }


                int
                f_1561_66123_66179(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.AssignmentTarget
                ast)
                {
                    this_param.AddAst((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 66123, 66179);
                    return 0;
                }


                object
                f_1561_66463_66488(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 66463, 66488);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ExpressionAst>
                f_1561_64244_64293_I(System.Collections.Generic.IEnumerable<System.Management.Automation.Language.ExpressionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 64244, 64293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 64047, 66562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 64047, 66562);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitPipeline(PipelineAst pipelineAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 66574, 68171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 66651, 66679);

                bool
                invokesCommand = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 66693, 67083);
                    foreach (var command in f_1561_66717_66745_I(f_1561_66717_66745(pipelineAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 66693, 67083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 66779, 66800);

                        f_1561_66779_66799(command, this);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 66818, 66926) || true) && (command is CommandAst)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 66818, 66926);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 66885, 66907);

                            invokesCommand = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 66818, 66926);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 66946, 67068);
                            foreach (var redir in f_1561_66968_66988_I(f_1561_66968_66988(command)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 66946, 67068);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 67030, 67049);

                                f_1561_67030_67048(redir, this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 66946, 67068);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 123);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 123);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 66693, 67083);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 391);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 67588, 68132) || true) && (invokesCommand && (DynAbs.Tracing.TraceSender.Expression_True(1561, 67592, 67628) && f_1561_67610_67628(_loopTargets)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 67588, 68132);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 67662, 67879);
                        foreach (var loopTarget in f_1561_67689_67701_I(_loopTargets))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 67662, 67879);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 67743, 67789);

                            f_1561_67743_67788(_currentBlock, f_1561_67765_67787(loopTarget));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 67811, 67860);

                            f_1561_67811_67859(_currentBlock, f_1561_67833_67858(loopTarget));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 67662, 67879);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 218);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 218);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 67997, 68024);

                    var
                    newBlock = f_1561_68012_68023()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 68042, 68074);

                    f_1561_68042_68073(_currentBlock, newBlock);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 68092, 68117);

                    _currentBlock = newBlock;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 67588, 68132);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 68148, 68160);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 66574, 68171);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1561_66717_66745(System.Management.Automation.Language.PipelineAst
                this_param)
                {
                    var return_v = this_param.PipelineElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 66717, 66745);
                    return return_v;
                }


                object
                f_1561_66779_66799(System.Management.Automation.Language.CommandBaseAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 66779, 66799);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                f_1561_66968_66988(System.Management.Automation.Language.CommandBaseAst
                this_param)
                {
                    var return_v = this_param.Redirections;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 66968, 66988);
                    return return_v;
                }


                object
                f_1561_67030_67048(System.Management.Automation.Language.RedirectionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 67030, 67048);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                f_1561_66968_66988_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.RedirectionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 66968, 66988);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                f_1561_66717_66745_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandBaseAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 66717, 66745);
                    return return_v;
                }


                bool
                f_1561_67610_67628(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>
                source)
                {
                    var return_v = source.Any<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 67610, 67628);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_67765_67787(System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets
                this_param)
                {
                    var return_v = this_param.BreakTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 67765, 67787);
                    return return_v;
                }


                int
                f_1561_67743_67788(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 67743, 67788);
                    return 0;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_67833_67858(System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets
                this_param)
                {
                    var return_v = this_param.ContinueTarget;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 67833, 67858);
                    return return_v;
                }


                int
                f_1561_67811_67859(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 67811, 67859);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>
                f_1561_67689_67701_I(System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 67689, 67701);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_68012_68023()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 68012, 68023);
                    return return_v;
                }


                int
                f_1561_68042_68073(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 68042, 68073);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 66574, 68171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 66574, 68171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitCommand(CommandAst commandAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 68183, 68416);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 68257, 68377);
                    foreach (var element in f_1561_68281_68307_I(f_1561_68281_68307(commandAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 68257, 68377);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 68341, 68362);

                        f_1561_68341_68361(element, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 68257, 68377);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 121);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 121);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 68393, 68405);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 68183, 68416);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1561_68281_68307(System.Management.Automation.Language.CommandAst
                this_param)
                {
                    var return_v = this_param.CommandElements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 68281, 68307);
                    return return_v;
                }


                object
                f_1561_68341_68361(System.Management.Automation.Language.CommandElementAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 68341, 68361);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                f_1561_68281_68307_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.CommandElementAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 68281, 68307);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 68183, 68416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 68183, 68416);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitCommandExpression(CommandExpressionAst commandExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 68428, 68614);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 68532, 68577);

                f_1561_68532_68576(f_1561_68532_68563(commandExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 68591, 68603);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 68428, 68614);

                System.Management.Automation.Language.ExpressionAst
                f_1561_68532_68563(System.Management.Automation.Language.CommandExpressionAst
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 68532, 68563);
                    return return_v;
                }


                object
                f_1561_68532_68576(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 68532, 68576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 68428, 68614);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 68428, 68614);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitCommandParameter(CommandParameterAst commandParameterAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 68626, 68897);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 68727, 68858) || true) && (f_1561_68731_68759(commandParameterAst) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 68727, 68858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 68801, 68843);

                    f_1561_68801_68842(f_1561_68801_68829(commandParameterAst), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 68727, 68858);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 68874, 68886);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 68626, 68897);

                System.Management.Automation.Language.ExpressionAst
                f_1561_68731_68759(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 68731, 68759);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1561_68801_68829(System.Management.Automation.Language.CommandParameterAst
                this_param)
                {
                    var return_v = this_param.Argument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 68801, 68829);
                    return return_v;
                }


                object
                f_1561_68801_68842(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 68801, 68842);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 68626, 68897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 68626, 68897);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitFileRedirection(FileRedirectionAst fileRedirectionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 68909, 69085);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 69007, 69048);

                f_1561_69007_69047(f_1561_69007_69034(fileRedirectionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 69062, 69074);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 68909, 69085);

                System.Management.Automation.Language.ExpressionAst
                f_1561_69007_69034(System.Management.Automation.Language.FileRedirectionAst
                this_param)
                {
                    var return_v = this_param.Location;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 69007, 69034);
                    return return_v;
                }


                object
                f_1561_69007_69047(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 69007, 69047);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 68909, 69085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 68909, 69085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitMergingRedirection(MergingRedirectionAst mergingRedirectionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 69097, 69227);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 69204, 69216);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 69097, 69227);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 69097, 69227);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 69097, 69227);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitBinaryExpression(BinaryExpressionAst binaryExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 69239, 70634);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 69340, 70595) || true) && (f_1561_69344_69372(binaryExpressionAst) == TokenKind.And || (DynAbs.Tracing.TraceSender.Expression_False(1561, 69344, 69437) || f_1561_69393_69421(binaryExpressionAst) == TokenKind.Or))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 69340, 70595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 69679, 69717);

                    f_1561_69679_69716(f_1561_69679_69703(binaryExpressionAst), this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70035, 70065);

                    var
                    targetBlock = f_1561_70053_70064()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70083, 70111);

                    var
                    nextBlock = f_1561_70099_70110()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70129, 70164);

                    f_1561_70129_70163(_currentBlock, targetBlock);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70182, 70215);

                    f_1561_70182_70214(_currentBlock, nextBlock);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70233, 70259);

                    _currentBlock = nextBlock;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70279, 70318);

                    f_1561_70279_70317(f_1561_70279_70304(binaryExpressionAst), this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70338, 70373);

                    f_1561_70338_70372(
                                    _currentBlock, targetBlock);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70391, 70419);

                    _currentBlock = targetBlock;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 69340, 70595);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 69340, 70595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70485, 70523);

                    f_1561_70485_70522(f_1561_70485_70509(binaryExpressionAst), this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70541, 70580);

                    f_1561_70541_70579(f_1561_70541_70566(binaryExpressionAst), this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 69340, 70595);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70611, 70623);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 69239, 70634);

                System.Management.Automation.Language.TokenKind
                f_1561_69344_69372(System.Management.Automation.Language.BinaryExpressionAst
                this_param)
                {
                    var return_v = this_param.Operator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 69344, 69372);
                    return return_v;
                }


                System.Management.Automation.Language.TokenKind
                f_1561_69393_69421(System.Management.Automation.Language.BinaryExpressionAst
                this_param)
                {
                    var return_v = this_param.Operator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 69393, 69421);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1561_69679_69703(System.Management.Automation.Language.BinaryExpressionAst
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 69679, 69703);
                    return return_v;
                }


                object
                f_1561_69679_69716(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 69679, 69716);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_70053_70064()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 70053, 70064);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysis.Block
                f_1561_70099_70110()
                {
                    var return_v = new System.Management.Automation.Language.VariableAnalysis.Block();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 70099, 70110);
                    return return_v;
                }


                int
                f_1561_70129_70163(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 70129, 70163);
                    return 0;
                }


                int
                f_1561_70182_70214(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 70182, 70214);
                    return 0;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1561_70279_70304(System.Management.Automation.Language.BinaryExpressionAst
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 70279, 70304);
                    return return_v;
                }


                object
                f_1561_70279_70317(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 70279, 70317);
                    return return_v;
                }


                int
                f_1561_70338_70372(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableAnalysis.Block
                next)
                {
                    this_param.FlowsTo(next);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 70338, 70372);
                    return 0;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1561_70485_70509(System.Management.Automation.Language.BinaryExpressionAst
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 70485, 70509);
                    return return_v;
                }


                object
                f_1561_70485_70522(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 70485, 70522);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1561_70541_70566(System.Management.Automation.Language.BinaryExpressionAst
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 70541, 70566);
                    return return_v;
                }


                object
                f_1561_70541_70579(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 70541, 70579);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 69239, 70634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 69239, 70634);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitUnaryExpression(UnaryExpressionAst unaryExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 70646, 70819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70744, 70782);

                f_1561_70744_70781(f_1561_70744_70768(unaryExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70796, 70808);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 70646, 70819);

                System.Management.Automation.Language.ExpressionAst
                f_1561_70744_70768(System.Management.Automation.Language.UnaryExpressionAst
                this_param)
                {
                    var return_v = this_param.Child;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 70744, 70768);
                    return return_v;
                }


                object
                f_1561_70744_70781(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 70744, 70781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 70646, 70819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 70646, 70819);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitConvertExpression(ConvertExpressionAst convertExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 70831, 71012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70935, 70975);

                f_1561_70935_70974(f_1561_70935_70961(convertExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 70989, 71001);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 70831, 71012);

                System.Management.Automation.Language.ExpressionAst
                f_1561_70935_70961(System.Management.Automation.Language.ConvertExpressionAst
                this_param)
                {
                    var return_v = this_param.Child;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 70935, 70961);
                    return return_v;
                }


                object
                f_1561_70935_70974(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 70935, 70974);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 70831, 71012);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 70831, 71012);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitConstantExpression(ConstantExpressionAst constantExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 71024, 71154);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 71131, 71143);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 71024, 71154);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 71024, 71154);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 71024, 71154);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitStringConstantExpression(StringConstantExpressionAst stringConstantExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 71166, 71314);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 71291, 71303);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 71166, 71314);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 71166, 71314);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 71166, 71314);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitSubExpression(SubExpressionAst subExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 71326, 71499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 71418, 71462);

                f_1561_71418_71461(f_1561_71418_71448(subExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 71476, 71488);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 71326, 71499);

                System.Management.Automation.Language.StatementBlockAst
                f_1561_71418_71448(System.Management.Automation.Language.SubExpressionAst
                this_param)
                {
                    var return_v = this_param.SubExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 71418, 71448);
                    return return_v;
                }


                object
                f_1561_71418_71461(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 71418, 71461);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 71326, 71499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 71326, 71499);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitUsingExpression(UsingExpressionAst usingExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 71511, 71798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 71775, 71787);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 71511, 71798);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 71511, 71798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 71511, 71798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitVariableExpression(VariableExpressionAst variableExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 71810, 73297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 71917, 71966);

                var
                varPath = f_1561_71931_71965(variableExpressionAst)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 71980, 73258) || true) && (f_1561_71984_72004(varPath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 71980, 73258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 72038, 72098);

                    var
                    details = f_1561_72052_72097(_variables, f_1561_72063_72096(varPath))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 72221, 72857) || true) && (f_1561_72225_72248(details) != VariableAnalysis.Unanalyzed)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 72221, 72857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 72321, 72424);

                        variableExpressionAst.TupleIndex = (DynAbs.Tracing.TraceSender.Conditional_F1(1561, 72356, 72382) || ((f_1561_72356_72382(details) && DynAbs.Tracing.TraceSender.Conditional_F2(1561, 72385, 72397)) || DynAbs.Tracing.TraceSender.Conditional_F3(1561, 72400, 72423))) ? ForceDynamic : f_1561_72400_72423(details);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 72446, 72498);

                        variableExpressionAst.Automatic = f_1561_72480_72497(details);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 72221, 72857);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 72221, 72857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 72794, 72838);

                        f_1561_72794_72837(                    // Save the variable reference in the current block so it can be marked later with
                                                               // the allocated tuple index if the variable is assigned in all paths to this reference.
                                            _currentBlock, variableExpressionAst);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 72221, 72857);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 73062, 73112);

                    f_1561_73062_73111(f_1561_73062_73084(details), variableExpressionAst);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 71980, 73258);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 71980, 73258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 73178, 73243);

                    variableExpressionAst.TupleIndex = VariableAnalysis.ForceDynamic;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 71980, 73258);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 73274, 73286);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 71810, 73297);

                System.Management.Automation.VariablePath
                f_1561_71931_71965(System.Management.Automation.Language.VariableExpressionAst
                this_param)
                {
                    var return_v = this_param.VariablePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 71931, 71965);
                    return return_v;
                }


                bool
                f_1561_71984_72004(System.Management.Automation.VariablePath
                variablePath)
                {
                    var return_v = variablePath.IsAnyLocal();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 71984, 72004);
                    return return_v;
                }


                string
                f_1561_72063_72096(System.Management.Automation.VariablePath
                varPath)
                {
                    var return_v = GetUnaliasedVariableName(varPath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 72063, 72096);
                    return return_v;
                }


                System.Management.Automation.Language.VariableAnalysisDetails
                f_1561_72052_72097(System.Collections.Generic.Dictionary<string, System.Management.Automation.Language.VariableAnalysisDetails>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 72052, 72097);
                    return return_v;
                }


                int
                f_1561_72225_72248(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.LocalTupleIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 72225, 72248);
                    return return_v;
                }


                bool
                f_1561_72356_72382(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.PreferenceVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 72356, 72382);
                    return return_v;
                }


                int
                f_1561_72400_72423(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.LocalTupleIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 72400, 72423);
                    return return_v;
                }


                bool
                f_1561_72480_72497(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.Automatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 72480, 72497);
                    return return_v;
                }


                int
                f_1561_72794_72837(System.Management.Automation.Language.VariableAnalysis.Block
                this_param, System.Management.Automation.Language.VariableExpressionAst
                ast)
                {
                    this_param.AddAst((System.Management.Automation.Language.Ast)ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 72794, 72837);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                f_1561_73062_73084(System.Management.Automation.Language.VariableAnalysisDetails
                this_param)
                {
                    var return_v = this_param.AssociatedAsts;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 73062, 73084);
                    return return_v;
                }


                int
                f_1561_73062_73111(System.Collections.Generic.List<System.Management.Automation.Language.Ast>
                this_param, System.Management.Automation.Language.VariableExpressionAst
                item)
                {
                    this_param.Add((System.Management.Automation.Language.Ast)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 73062, 73111);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 71810, 73297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 71810, 73297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitTypeExpression(TypeExpressionAst typeExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 73309, 73427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 73404, 73416);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 73309, 73427);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 73309, 73427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 73309, 73427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitMemberExpression(MemberExpressionAst memberExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 73439, 73675);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 73540, 73584);

                f_1561_73540_73583(f_1561_73540_73570(memberExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 73598, 73638);

                f_1561_73598_73637(f_1561_73598_73624(memberExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 73652, 73664);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 73439, 73675);

                System.Management.Automation.Language.ExpressionAst
                f_1561_73540_73570(System.Management.Automation.Language.MemberExpressionAst
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 73540, 73570);
                    return return_v;
                }


                object
                f_1561_73540_73583(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 73540, 73583);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1561_73598_73624(System.Management.Automation.Language.MemberExpressionAst
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 73598, 73624);
                    return return_v;
                }


                object
                f_1561_73598_73637(System.Management.Automation.Language.CommandElementAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 73598, 73637);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 73439, 73675);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 73439, 73675);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitInvokeMemberExpression(InvokeMemberExpressionAst invokeMemberExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 73687, 74198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 73806, 73856);

                f_1561_73806_73855(f_1561_73806_73842(invokeMemberExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 73870, 73916);

                f_1561_73870_73915(f_1561_73870_73902(invokeMemberExpressionAst), this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 73930, 74159) || true) && (f_1561_73934_73969(invokeMemberExpressionAst) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 73930, 74159);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 74011, 74144);
                        foreach (var arg in f_1561_74031_74066_I(f_1561_74031_74066(invokeMemberExpressionAst)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 74011, 74144);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 74108, 74125);

                            f_1561_74108_74124(arg, this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 74011, 74144);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 134);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 134);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 73930, 74159);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 74175, 74187);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 73687, 74198);

                System.Management.Automation.Language.ExpressionAst
                f_1561_73806_73842(System.Management.Automation.Language.InvokeMemberExpressionAst
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 73806, 73842);
                    return return_v;
                }


                object
                f_1561_73806_73855(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 73806, 73855);
                    return return_v;
                }


                System.Management.Automation.Language.CommandElementAst
                f_1561_73870_73902(System.Management.Automation.Language.InvokeMemberExpressionAst
                this_param)
                {
                    var return_v = this_param.Member;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 73870, 73902);
                    return return_v;
                }


                object
                f_1561_73870_73915(System.Management.Automation.Language.CommandElementAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 73870, 73915);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1561_73934_73969(System.Management.Automation.Language.InvokeMemberExpressionAst
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 73934, 73969);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1561_74031_74066(System.Management.Automation.Language.InvokeMemberExpressionAst
                this_param)
                {
                    var return_v = this_param.Arguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 74031, 74066);
                    return return_v;
                }


                object
                f_1561_74108_74124(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 74108, 74124);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1561_74031_74066_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 74031, 74066);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 73687, 74198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 73687, 74198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitArrayExpression(ArrayExpressionAst arrayExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 74210, 74391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 74308, 74354);

                f_1561_74308_74353(f_1561_74308_74340(arrayExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 74368, 74380);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 74210, 74391);

                System.Management.Automation.Language.StatementBlockAst
                f_1561_74308_74340(System.Management.Automation.Language.ArrayExpressionAst
                this_param)
                {
                    var return_v = this_param.SubExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 74308, 74340);
                    return return_v;
                }


                object
                f_1561_74308_74353(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 74308, 74353);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 74210, 74391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 74210, 74391);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitArrayLiteral(ArrayLiteralAst arrayLiteralAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 74403, 74649);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 74492, 74610);
                    foreach (var element in f_1561_74516_74540_I(f_1561_74516_74540(arrayLiteralAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 74492, 74610);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 74574, 74595);

                        f_1561_74574_74594(element, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 74492, 74610);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 74626, 74638);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 74403, 74649);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1561_74516_74540(System.Management.Automation.Language.ArrayLiteralAst
                this_param)
                {
                    var return_v = this_param.Elements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 74516, 74540);
                    return return_v;
                }


                object
                f_1561_74574_74594(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 74574, 74594);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1561_74516_74540_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 74516, 74540);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 74403, 74649);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 74403, 74649);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitHashtable(HashtableAst hashtableAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 74661, 74942);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 74741, 74903);
                    foreach (var pair in f_1561_74762_74788_I(f_1561_74762_74788(hashtableAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 74741, 74903);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 74822, 74846);

                        f_1561_74822_74845(f_1561_74822_74832(pair), this);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 74864, 74888);

                        f_1561_74864_74887(f_1561_74864_74874(pair), this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 74741, 74903);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 163);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 74919, 74931);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 74661, 74942);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                f_1561_74762_74788(System.Management.Automation.Language.HashtableAst
                this_param)
                {
                    var return_v = this_param.KeyValuePairs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 74762, 74788);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1561_74822_74832(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 74822, 74832);
                    return return_v;
                }


                object
                f_1561_74822_74845(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 74822, 74845);
                    return return_v;
                }


                System.Management.Automation.Language.StatementAst
                f_1561_74864_74874(System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 74864, 74874);
                    return return_v;
                }


                object
                f_1561_74864_74887(System.Management.Automation.Language.StatementAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 74864, 74887);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                f_1561_74762_74788_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Tuple<System.Management.Automation.Language.ExpressionAst, System.Management.Automation.Language.StatementAst>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 74762, 74788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 74661, 74942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 74661, 74942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitScriptBlockExpression(ScriptBlockExpressionAst scriptBlockExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 74954, 75241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 75218, 75230);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 74954, 75241);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 74954, 75241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 74954, 75241);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitParenExpression(ParenExpressionAst parenExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 75253, 75429);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 75351, 75392);

                f_1561_75351_75391(f_1561_75351_75378(parenExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 75406, 75418);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 75253, 75429);

                System.Management.Automation.Language.PipelineBaseAst
                f_1561_75351_75378(System.Management.Automation.Language.ParenExpressionAst
                this_param)
                {
                    var return_v = this_param.Pipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 75351, 75378);
                    return return_v;
                }


                object
                f_1561_75351_75391(System.Management.Automation.Language.PipelineBaseAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 75351, 75391);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 75253, 75429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 75253, 75429);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitExpandableStringExpression(ExpandableStringExpressionAst expandableStringExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 75441, 75746);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 75572, 75707);
                    foreach (var expr in f_1561_75593_75640_I(f_1561_75593_75640(expandableStringExpressionAst)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1561, 75572, 75707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 75674, 75692);

                        f_1561_75674_75691(expr, this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1561, 75572, 75707);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1561, 1, 136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1561, 1, 136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 75723, 75735);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 75441, 75746);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1561_75593_75640(System.Management.Automation.Language.ExpandableStringExpressionAst
                this_param)
                {
                    var return_v = this_param.NestedExpressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 75593, 75640);
                    return return_v;
                }


                object
                f_1561_75674_75691(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 75674, 75691);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1561_75593_75640_I(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 75593, 75640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 75441, 75746);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 75441, 75746);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitIndexExpression(IndexExpressionAst indexExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 75758, 75984);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 75856, 75895);

                f_1561_75856_75894(f_1561_75856_75881(indexExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 75909, 75947);

                f_1561_75909_75946(f_1561_75909_75933(indexExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 75961, 75973);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 75758, 75984);

                System.Management.Automation.Language.ExpressionAst
                f_1561_75856_75881(System.Management.Automation.Language.IndexExpressionAst
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 75856, 75881);
                    return return_v;
                }


                object
                f_1561_75856_75894(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 75856, 75894);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1561_75909_75933(System.Management.Automation.Language.IndexExpressionAst
                this_param)
                {
                    var return_v = this_param.Index;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 75909, 75933);
                    return return_v;
                }


                object
                f_1561_75909_75946(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 75909, 75946);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 75758, 75984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 75758, 75984);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitAttributedExpression(AttributedExpressionAst attributedExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 75996, 76189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 76109, 76152);

                f_1561_76109_76151(f_1561_76109_76138(attributedExpressionAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 76166, 76178);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 75996, 76189);

                System.Management.Automation.Language.ExpressionAst
                f_1561_76109_76138(System.Management.Automation.Language.AttributedExpressionAst
                this_param)
                {
                    var return_v = this_param.Child;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 76109, 76138);
                    return return_v;
                }


                object
                f_1561_76109_76151(System.Management.Automation.Language.ExpressionAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 76109, 76151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 75996, 76189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 75996, 76189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitBlockStatement(BlockStatementAst blockStatementAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 76201, 76369);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 76296, 76332);

                f_1561_76296_76331(f_1561_76296_76318(blockStatementAst), this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 76346, 76358);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 76201, 76369);

                System.Management.Automation.Language.StatementBlockAst
                f_1561_76296_76318(System.Management.Automation.Language.BlockStatementAst
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 76296, 76318);
                    return return_v;
                }


                object
                f_1561_76296_76331(System.Management.Automation.Language.StatementBlockAst
                this_param, System.Management.Automation.Language.VariableAnalysis
                visitor)
                {
                    var return_v = this_param.Accept((System.Management.Automation.Language.ICustomAstVisitor)visitor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 76296, 76331);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 76201, 76369);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 76201, 76369);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitTypeDefinition(TypeDefinitionAst typeDefinitionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 76452, 76459);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 76455, 76459);
                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 76452, 76459);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 76452, 76459);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 76452, 76459);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitPropertyMember(PropertyMemberAst propertyMemberAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 76543, 76550);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 76546, 76550);
                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 76543, 76550);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 76543, 76550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 76543, 76550);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitFunctionMember(FunctionMemberAst functionMemberAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 76634, 76641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 76637, 76641);
                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 76634, 76641);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 76634, 76641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 76634, 76641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitBaseCtorInvokeMemberExpression(BaseCtorInvokeMemberExpressionAst baseCtorInvokeMemberExpressionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 76773, 76780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 76776, 76780);
                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 76773, 76780);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 76773, 76780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 76773, 76780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitUsingStatement(UsingStatementAst usingStatement)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 76861, 76868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 76864, 76868);
                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 76861, 76868);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 76861, 76868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 76861, 76868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitConfigurationDefinition(ConfigurationDefinitionAst configurationDefinitionAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 76979, 76986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 76982, 76986);
                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 76979, 76986);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 76979, 76986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 76979, 76986);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public object VisitDynamicKeywordStatement(DynamicKeywordStatementAst dynamicKeywordAst)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1561, 77088, 77095);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 77091, 77095);
                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1561, 77088, 77095);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1561, 77088, 77095);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 77088, 77095);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public VariableAnalysis()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1561, 16049, 77103);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 23212, 23222);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 23247, 23258);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 23283, 23293);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 23318, 23331);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 23355, 23376);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 23426, 23468);
            this._loopTargets = f_1561_23441_23468();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 23491, 23507);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1561, 16049, 77103);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 16049, 77103);
        }


        static VariableAnalysis()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1561, 16049, 77103);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 16354, 16369);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 17066, 17083);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1561, 22660, 22761);
            s_allScopeVariables = f_1561_22682_22761(1, 16, f_1561_22728_22760());
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1561, 16049, 77103);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1561, 16049, 77103);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1561, 16049, 77103);

        static System.StringComparer
        f_1561_22728_22760()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1561, 22728, 22760);
            return return_v;
        }


        static System.Collections.Concurrent.ConcurrentDictionary<string, bool>
        f_1561_22682_22761(int
        concurrencyLevel, int
        capacity, System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Concurrent.ConcurrentDictionary<string, bool>(concurrencyLevel, capacity, (System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 22682, 22761);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>
        f_1561_23441_23468()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.Language.VariableAnalysis.LoopGotoTargets>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1561, 23441, 23468);
            return return_v;
        }

    }
}
