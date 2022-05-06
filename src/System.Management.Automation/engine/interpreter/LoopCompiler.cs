/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation.
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A
 * copy of the license can be found in the License.html file at the root of this distribution. If
 * you cannot locate the Apache License, Version 2.0, please send an email to
 * dlr@microsoft.com. By using this source code in any fashion, you are agreeing to be bound
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

using System.Linq.Expressions;
using System.Collections.Generic;
using System.Diagnostics;
using System.Management.Automation.Language;
using System.Runtime.CompilerServices;

namespace System.Management.Automation.Interpreter
{
    using AstUtils = System.Management.Automation.Interpreter.Utils;
    using LoopFunc = Func<object[], StrongBox<object>[], InterpretedFrame, int>;
    internal sealed class LoopCompiler : ExpressionVisitor
    {
        private struct LoopVariable
        {

            public ExpressionAccess Access;

            public ParameterExpression BoxStorage;

            public LoopVariable(ExpressionAccess access, ParameterExpression box)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1514, 1432, 1600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 1534, 1550);

                    Access = access;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 1568, 1585);

                    BoxStorage = box;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1514, 1432, 1600);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 1432, 1600);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 1432, 1600);
                }
            }

            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1514, 1616, 1741);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 1682, 1726);

                    // LAFHIS
                    var temp1 = f_1514_1689_1706(Access);
                    var temp2 = BoxStorage.ToString(); //DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (BoxStorage).ToString(), 1514, 1715, 1725);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 1715, 1725);
                    return temp1 + " " + temp2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1514, 1616, 1741);

                    string
                    f_1514_1689_1706(System.Management.Automation.Interpreter.ExpressionAccess
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 1689, 1706);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 1616, 1741);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 1616, 1741);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            static LoopVariable()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1514, 1200, 1752);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1514, 1200, 1752);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 1200, 1752);
            }
        }

        private readonly ParameterExpression _frameDataVar;

        private readonly ParameterExpression _frameClosureVar;

        private readonly ParameterExpression _frameVar;

        private readonly LabelTarget _returnLabel;

        private readonly Dictionary<ParameterExpression, LocalVariable> _outerVariables, _closureVariables;

        private readonly PowerShellLoopExpression _loop;

        private List<ParameterExpression> _temps;

        private readonly Dictionary<ParameterExpression, LoopVariable> _loopVariables;

        private HashSet<ParameterExpression> _loopLocals;

        private readonly HybridReferenceDictionary<LabelTarget, BranchLabel> _labelMapping;

        private readonly int _loopStartInstructionIndex;

        private readonly int _loopEndInstructionIndex;

        internal LoopCompiler(PowerShellLoopExpression loop,
                                      HybridReferenceDictionary<LabelTarget, BranchLabel> labelMapping,
                                      Dictionary<ParameterExpression, LocalVariable> locals,
                                      Dictionary<ParameterExpression, LocalVariable> closureVariables,
                                      int loopStartInstructionIndex,
                                      int loopEndInstructionIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1514, 2783, 3919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 1801, 1814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 1862, 1878);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 1926, 1935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 1975, 1987);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 2128, 2143);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 2145, 2162);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 2215, 2220);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 2265, 2271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 2423, 2437);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 2550, 2561);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 2643, 2656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 2688, 2714);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 2746, 2770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 3261, 3274);

                _loop = loop;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 3288, 3313);

                _outerVariables = locals;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 3327, 3364);

                _closureVariables = closureVariables;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 3378, 3433);

                _frameDataVar = f_1514_3394_3432(typeof(object[]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 3447, 3516);

                _frameClosureVar = f_1514_3466_3515(typeof(StrongBox<object>[]));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 3530, 3589);

                _frameVar = f_1514_3542_3588(typeof(InterpretedFrame));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 3603, 3672);

                _loopVariables = f_1514_3620_3671();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 3686, 3731);

                _returnLabel = f_1514_3701_3730(typeof(int));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 3745, 3774);

                _labelMapping = labelMapping;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 3788, 3843);

                _loopStartInstructionIndex = loopStartInstructionIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 3857, 3908);

                _loopEndInstructionIndex = loopEndInstructionIndex;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1514, 2783, 3919);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 2783, 3919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 2783, 3919);
            }
        }

        internal LoopFunc CreateDelegate()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1514, 3931, 6222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 3990, 4014);

                var
                loop = f_1514_4001_4013(this, _loop)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 4028, 4062);

                var
                body = f_1514_4039_4061()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 4076, 4119);

                var
                finallyClause = f_1514_4096_4118()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 4135, 5562);
                    foreach (var variable in f_1514_4160_4174_I(_loopVariables))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 4135, 5562);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 4208, 4228);

                        LocalVariable
                        local
                        = default(LocalVariable);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 4246, 4404) || true) && (!f_1514_4251_4303(_outerVariables, variable.Key, out local))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 4246, 4404);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 4345, 4385);

                            local = f_1514_4353_4384(_closureVariables, variable.Key);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 4246, 4404);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 4424, 4498);

                        Expression
                        elemRef = f_1514_4445_4497(local, _frameDataVar, _frameClosureVar)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 4518, 5547) || true) && (f_1514_4522_4544(local))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 4518, 5547);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 4586, 4622);

                            var
                            box = variable.Value.BoxStorage
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 4644, 4670);

                            f_1514_4644_4669(box != null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 4692, 4734);

                            f_1514_4692_4733(body, f_1514_4701_4732(box, elemRef));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 4756, 4769);

                            f_1514_4756_4768(this, box);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 4518, 5547);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 4518, 5547);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 5166, 5254);

                            f_1514_5166_5253(                    // Always initialize the variable even if it is only written to.
                                                                 // If a write-only variable is actually not assigned during execution of the loop we will still write some value back.
                                                                 // This value must be the original value, which we assign at entry.
                                                body, f_1514_5175_5252(variable.Key, f_1514_5207_5251(elemRef, f_1514_5233_5250(variable.Key))));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 5278, 5482) || true) && ((variable.Value.Access & ExpressionAccess.Write) != 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 5278, 5482);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 5385, 5459);

                                f_1514_5385_5458(finallyClause, f_1514_5403_5457(elemRef, f_1514_5430_5456(variable.Key)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 5278, 5482);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 5506, 5528);

                            f_1514_5506_5527(this, variable.Key);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 4518, 5547);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 4135, 5562);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1514, 1, 1428);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1514, 1, 1428);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 5578, 5806) || true) && (f_1514_5582_5601(finallyClause) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 5578, 5806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 5639, 5710);

                    f_1514_5639_5709(body, f_1514_5648_5708(loop, f_1514_5676_5707(finallyClause)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 5578, 5806);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 5578, 5806);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 5776, 5791);

                    f_1514_5776_5790(body, loop);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 5578, 5806);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 5822, 5939);

                f_1514_5822_5938(
                            body, f_1514_5831_5937(_returnLabel, f_1514_5862_5936(_loopEndInstructionIndex - _loopStartInstructionIndex)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 5955, 6173);

                var
                lambda = f_1514_5968_6172((DynAbs.Tracing.TraceSender.Conditional_F1(1514, 6014, 6028) || ((_temps != null && DynAbs.Tracing.TraceSender.Conditional_F2(1514, 6031, 6061)) || DynAbs.Tracing.TraceSender.Conditional_F3(1514, 6064, 6086))) ? f_1514_6031_6061(_temps, body) : f_1514_6064_6086(body), new[] { _frameDataVar, _frameClosureVar, _frameVar })
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 6187, 6211);

                return f_1514_6194_6210(lambda);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1514, 3931, 6222);

                System.Linq.Expressions.Expression
                f_1514_4001_4013(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Management.Automation.Language.PowerShellLoopExpression
                node)
                {
                    var return_v = this_param.Visit((System.Linq.Expressions.Expression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 4001, 4013);
                    return return_v;
                }


                System.Collections.Generic.List<System.Linq.Expressions.Expression>
                f_1514_4039_4061()
                {
                    var return_v = new System.Collections.Generic.List<System.Linq.Expressions.Expression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 4039, 4061);
                    return return_v;
                }


                System.Collections.Generic.List<System.Linq.Expressions.Expression>
                f_1514_4096_4118()
                {
                    var return_v = new System.Collections.Generic.List<System.Linq.Expressions.Expression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 4096, 4118);
                    return return_v;
                }


                bool
                f_1514_4251_4303(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                this_param, System.Linq.Expressions.ParameterExpression
                key, out System.Management.Automation.Interpreter.LocalVariable
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 4251, 4303);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LocalVariable
                f_1514_4353_4384(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                this_param, System.Linq.Expressions.ParameterExpression
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 4353, 4384);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_4445_4497(System.Management.Automation.Interpreter.LocalVariable
                this_param, System.Linq.Expressions.ParameterExpression
                frameData, System.Linq.Expressions.ParameterExpression
                closure)
                {
                    var return_v = this_param.LoadFromArray((System.Linq.Expressions.Expression)frameData, (System.Linq.Expressions.Expression)closure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 4445, 4497);
                    return return_v;
                }


                bool
                f_1514_4522_4544(System.Management.Automation.Interpreter.LocalVariable
                this_param)
                {
                    var return_v = this_param.InClosureOrBoxed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 4522, 4544);
                    return return_v;
                }


                int
                f_1514_4644_4669(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 4644, 4669);
                    return 0;
                }


                System.Linq.Expressions.BinaryExpression
                f_1514_4701_4732(System.Linq.Expressions.ParameterExpression
                left, System.Linq.Expressions.Expression
                right)
                {
                    var return_v = Expression.Assign((System.Linq.Expressions.Expression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 4701, 4732);
                    return return_v;
                }


                int
                f_1514_4692_4733(System.Collections.Generic.List<System.Linq.Expressions.Expression>
                this_param, System.Linq.Expressions.BinaryExpression
                item)
                {
                    this_param.Add((System.Linq.Expressions.Expression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 4692, 4733);
                    return 0;
                }


                System.Linq.Expressions.ParameterExpression
                f_1514_4756_4768(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                variable)
                {
                    var return_v = this_param.AddTemp(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 4756, 4768);
                    return return_v;
                }


                System.Type
                f_1514_5233_5250(System.Linq.Expressions.ParameterExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 5233, 5250);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_5207_5251(System.Linq.Expressions.Expression
                expression, System.Type
                type)
                {
                    var return_v = AstUtils.Convert(expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5207, 5251);
                    return return_v;
                }


                System.Linq.Expressions.BinaryExpression
                f_1514_5175_5252(System.Linq.Expressions.ParameterExpression
                left, System.Linq.Expressions.Expression
                right)
                {
                    var return_v = Expression.Assign((System.Linq.Expressions.Expression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5175, 5252);
                    return return_v;
                }


                int
                f_1514_5166_5253(System.Collections.Generic.List<System.Linq.Expressions.Expression>
                this_param, System.Linq.Expressions.BinaryExpression
                item)
                {
                    this_param.Add((System.Linq.Expressions.Expression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5166, 5253);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1514_5430_5456(System.Linq.Expressions.ParameterExpression
                expression)
                {
                    var return_v = AstUtils.Box((System.Linq.Expressions.Expression)expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5430, 5456);
                    return return_v;
                }


                System.Linq.Expressions.BinaryExpression
                f_1514_5403_5457(System.Linq.Expressions.Expression
                left, System.Linq.Expressions.Expression
                right)
                {
                    var return_v = Expression.Assign(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5403, 5457);
                    return return_v;
                }


                int
                f_1514_5385_5458(System.Collections.Generic.List<System.Linq.Expressions.Expression>
                this_param, System.Linq.Expressions.BinaryExpression
                item)
                {
                    this_param.Add((System.Linq.Expressions.Expression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5385, 5458);
                    return 0;
                }


                System.Linq.Expressions.ParameterExpression
                f_1514_5506_5527(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                variable)
                {
                    var return_v = this_param.AddTemp(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5506, 5527);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LoopCompiler.LoopVariable>
                f_1514_4160_4174_I(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LoopCompiler.LoopVariable>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 4160, 4174);
                    return return_v;
                }


                int
                f_1514_5582_5601(System.Collections.Generic.List<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 5582, 5601);
                    return return_v;
                }


                System.Linq.Expressions.BlockExpression
                f_1514_5676_5707(System.Collections.Generic.List<System.Linq.Expressions.Expression>
                expressions)
                {
                    var return_v = Expression.Block((System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression>)expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5676, 5707);
                    return return_v;
                }


                System.Linq.Expressions.TryExpression
                f_1514_5648_5708(System.Linq.Expressions.Expression
                body, System.Linq.Expressions.BlockExpression
                @finally)
                {
                    var return_v = Expression.TryFinally(body, (System.Linq.Expressions.Expression)@finally);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5648, 5708);
                    return return_v;
                }


                int
                f_1514_5639_5709(System.Collections.Generic.List<System.Linq.Expressions.Expression>
                this_param, System.Linq.Expressions.TryExpression
                item)
                {
                    this_param.Add((System.Linq.Expressions.Expression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5639, 5709);
                    return 0;
                }


                int
                f_1514_5776_5790(System.Collections.Generic.List<System.Linq.Expressions.Expression>
                this_param, System.Linq.Expressions.Expression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5776, 5790);
                    return 0;
                }


                System.Linq.Expressions.ConstantExpression
                f_1514_5862_5936(int
                value)
                {
                    var return_v = Expression.Constant((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5862, 5936);
                    return return_v;
                }


                System.Linq.Expressions.LabelExpression
                f_1514_5831_5937(System.Linq.Expressions.LabelTarget
                target, System.Linq.Expressions.ConstantExpression
                defaultValue)
                {
                    var return_v = Expression.Label(target, (System.Linq.Expressions.Expression)defaultValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5831, 5937);
                    return return_v;
                }


                int
                f_1514_5822_5938(System.Collections.Generic.List<System.Linq.Expressions.Expression>
                this_param, System.Linq.Expressions.LabelExpression
                item)
                {
                    this_param.Add((System.Linq.Expressions.Expression)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5822, 5938);
                    return 0;
                }


                System.Linq.Expressions.BlockExpression
                f_1514_6031_6061(System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>
                variables, System.Collections.Generic.List<System.Linq.Expressions.Expression>
                expressions)
                {
                    var return_v = Expression.Block((System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression>)variables, (System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression>)expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 6031, 6061);
                    return return_v;
                }


                System.Linq.Expressions.BlockExpression
                f_1514_6064_6086(System.Collections.Generic.List<System.Linq.Expressions.Expression>
                expressions)
                {
                    var return_v = Expression.Block((System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression>)expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 6064, 6086);
                    return return_v;
                }


                System.Linq.Expressions.Expression<System.Func<object[], System.Runtime.CompilerServices.StrongBox<object>[], System.Management.Automation.Interpreter.InterpretedFrame, int>>
                f_1514_5968_6172(System.Linq.Expressions.BlockExpression
                body, params System.Linq.Expressions.ParameterExpression[]
                parameters)
                {
                    var return_v = Expression.Lambda<LoopFunc>((System.Linq.Expressions.Expression)body, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 5968, 6172);
                    return return_v;
                }


                System.Func<object[], System.Runtime.CompilerServices.StrongBox<object>[], System.Management.Automation.Interpreter.InterpretedFrame, int>
                f_1514_6194_6210(System.Linq.Expressions.Expression<System.Func<object[], System.Runtime.CompilerServices.StrongBox<object>[], System.Management.Automation.Interpreter.InterpretedFrame, int>>
                this_param)
                {
                    var return_v = this_param.Compile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 6194, 6210);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 3931, 6222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 3931, 6222);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Expression VisitExtension(Expression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1514, 6234, 6674);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 6519, 6614) || true) && (f_1514_6523_6537(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 6519, 6614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 6571, 6599);

                    return f_1514_6578_6598(this, f_1514_6584_6597(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 6519, 6614);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 6630, 6663);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitExtension(node), 1514, 6637, 6662);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1514, 6234, 6674);

                bool
                f_1514_6523_6537(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.CanReduce;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 6523, 6537);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_6584_6597(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Reduce();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 6584, 6597);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_6578_6598(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Linq.Expressions.Expression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 6578, 6598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 6234, 6674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 6234, 6674);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Expression VisitGoto(GotoExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1514, 6711, 7920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 6796, 6814);

                BranchLabel
                label
                = default(BranchLabel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 6830, 6855);

                var
                target = f_1514_6843_6854(node)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 6869, 6899);

                var
                value = f_1514_6881_6898(this, f_1514_6887_6897(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 7113, 7245) || true) && (!f_1514_7118_7162(_labelMapping, target, out label))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 7113, 7245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 7196, 7230);

                    return f_1514_7203_7229(node, target, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 7113, 7245);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 7306, 7488) || true) && (f_1514_7310_7327(label) >= _loopStartInstructionIndex && (DynAbs.Tracing.TraceSender.Expression_True(1514, 7310, 7405) && f_1514_7361_7378(label) < _loopEndInstructionIndex))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 7306, 7488);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 7439, 7473);

                    return f_1514_7446_7472(node, target, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 7306, 7488);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 7504, 7909);

                return f_1514_7511_7908(_returnLabel, (DynAbs.Tracing.TraceSender.Conditional_F1(1514, 7560, 7605) || (((value != null && (DynAbs.Tracing.TraceSender.Expression_True(1514, 7561, 7604) && f_1514_7578_7588(value) != typeof(void))) && DynAbs.Tracing.TraceSender.Conditional_F2(1514, 7629, 7744)) || DynAbs.Tracing.TraceSender.Conditional_F3(1514, 7768, 7866))) ? f_1514_7629_7744(_frameVar, f_1514_7656_7683(), f_1514_7685_7722(f_1514_7705_7721(label)), f_1514_7724_7743(value)) : f_1514_7768_7866(_frameVar, f_1514_7795_7826(), f_1514_7828_7865(f_1514_7848_7864(label))), f_1514_7885_7894(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1514, 6711, 7920);

                System.Linq.Expressions.LabelTarget
                f_1514_6843_6854(System.Linq.Expressions.GotoExpression
                this_param)
                {
                    var return_v = this_param.Target;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 6843, 6854);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_6887_6897(System.Linq.Expressions.GotoExpression
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 6887, 6897);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_6881_6898(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Linq.Expressions.Expression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 6881, 6898);
                    return return_v;
                }


                bool
                f_1514_7118_7162(System.Management.Automation.Interpreter.HybridReferenceDictionary<System.Linq.Expressions.LabelTarget, System.Management.Automation.Interpreter.BranchLabel>
                this_param, System.Linq.Expressions.LabelTarget
                key, out System.Management.Automation.Interpreter.BranchLabel
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 7118, 7162);
                    return return_v;
                }


                System.Linq.Expressions.GotoExpression
                f_1514_7203_7229(System.Linq.Expressions.GotoExpression
                this_param, System.Linq.Expressions.LabelTarget
                target, System.Linq.Expressions.Expression
                value)
                {
                    var return_v = this_param.Update(target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 7203, 7229);
                    return return_v;
                }


                int
                f_1514_7310_7327(System.Management.Automation.Interpreter.BranchLabel
                this_param)
                {
                    var return_v = this_param.TargetIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 7310, 7327);
                    return return_v;
                }


                int
                f_1514_7361_7378(System.Management.Automation.Interpreter.BranchLabel
                this_param)
                {
                    var return_v = this_param.TargetIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 7361, 7378);
                    return return_v;
                }


                System.Linq.Expressions.GotoExpression
                f_1514_7446_7472(System.Linq.Expressions.GotoExpression
                this_param, System.Linq.Expressions.LabelTarget
                target, System.Linq.Expressions.Expression
                value)
                {
                    var return_v = this_param.Update(target, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 7446, 7472);
                    return return_v;
                }


                System.Type
                f_1514_7578_7588(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 7578, 7588);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1514_7656_7683()
                {
                    var return_v = InterpretedFrame.GotoMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 7656, 7683);
                    return return_v;
                }


                int
                f_1514_7705_7721(System.Management.Automation.Interpreter.BranchLabel
                this_param)
                {
                    var return_v = this_param.LabelIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 7705, 7721);
                    return return_v;
                }


                System.Linq.Expressions.ConstantExpression
                f_1514_7685_7722(int
                value)
                {
                    var return_v = Expression.Constant((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 7685, 7722);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_7724_7743(System.Linq.Expressions.Expression
                expression)
                {
                    var return_v = AstUtils.Box(expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 7724, 7743);
                    return return_v;
                }


                System.Linq.Expressions.MethodCallExpression
                f_1514_7629_7744(System.Linq.Expressions.ParameterExpression
                instance, System.Reflection.MethodInfo
                method, System.Linq.Expressions.ConstantExpression
                arg0, System.Linq.Expressions.Expression
                arg1)
                {
                    var return_v = Expression.Call((System.Linq.Expressions.Expression)instance, method, (System.Linq.Expressions.Expression)arg0, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 7629, 7744);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1514_7795_7826()
                {
                    var return_v = InterpretedFrame.VoidGotoMethod;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 7795, 7826);
                    return return_v;
                }


                int
                f_1514_7848_7864(System.Management.Automation.Interpreter.BranchLabel
                this_param)
                {
                    var return_v = this_param.LabelIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 7848, 7864);
                    return return_v;
                }


                System.Linq.Expressions.ConstantExpression
                f_1514_7828_7865(int
                value)
                {
                    var return_v = Expression.Constant((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 7828, 7865);
                    return return_v;
                }


                System.Linq.Expressions.MethodCallExpression
                f_1514_7768_7866(System.Linq.Expressions.ParameterExpression
                instance, System.Reflection.MethodInfo
                method, params System.Linq.Expressions.Expression[]
                arguments)
                {
                    var return_v = Expression.Call((System.Linq.Expressions.Expression)instance, method, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 7768, 7866);
                    return return_v;
                }


                System.Type
                f_1514_7885_7894(System.Linq.Expressions.GotoExpression
                this_param)
                {
                    var return_v = this_param.Type
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 7885, 7894);
                    return return_v;
                }


                System.Linq.Expressions.GotoExpression
                f_1514_7511_7908(System.Linq.Expressions.LabelTarget
                target, System.Linq.Expressions.MethodCallExpression
                value, System.Type
                type)
                {
                    var return_v = Expression.Return(target, (System.Linq.Expressions.Expression)value, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 7511, 7908);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 6711, 7920);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 6711, 7920);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Expression VisitBlock(BlockExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1514, 8313, 8641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 8400, 8450);

                var
                variables = f_1514_8416_8449(((BlockExpression)node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 8464, 8511);

                var
                prevLocals = f_1514_8481_8510(this, variables)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 8527, 8559);

                var
                res = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBlock(node), 1514, 8537, 8558)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 8575, 8605);

                f_1514_8575_8604(this, prevLocals);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 8619, 8630);

                return res;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1514, 8313, 8641);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1514_8416_8449(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 8416, 8449);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                f_1514_8481_8510(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                variables)
                {
                    var return_v = this_param.EnterVariableScope((System.Collections.Generic.ICollection<System.Linq.Expressions.ParameterExpression>)variables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 8481, 8510);
                    return return_v;
                }


                int
                f_1514_8575_8604(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                prevLocals)
                {
                    this_param.ExitVariableScope(prevLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 8575, 8604);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 8313, 8641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 8313, 8641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private HashSet<ParameterExpression> EnterVariableScope(ICollection<ParameterExpression> variables)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1514, 8653, 9106);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 8777, 8937) || true) && (_loopLocals == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 8777, 8937);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 8834, 8892);

                    _loopLocals = f_1514_8848_8891(variables);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 8910, 8922);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 8777, 8937);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 8953, 9016);

                var
                prevLocals = f_1514_8970_9015(_loopLocals)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 9030, 9063);

                f_1514_9030_9062(_loopLocals, variables);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 9077, 9095);

                return prevLocals;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1514, 8653, 9106);

                System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                f_1514_8848_8891(System.Collections.Generic.ICollection<System.Linq.Expressions.ParameterExpression>
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>((System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 8848, 8891);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                f_1514_8970_9015(System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>((System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 8970, 9015);
                    return return_v;
                }


                int
                f_1514_9030_9062(System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                this_param, System.Collections.Generic.ICollection<System.Linq.Expressions.ParameterExpression>
                other)
                {
                    this_param.UnionWith((System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression>)other);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 9030, 9062);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 8653, 9106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 8653, 9106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CatchBlock VisitCatchBlock(CatchBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1514, 9118, 9583);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 9205, 9572) || true) && (f_1514_9209_9222(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 9205, 9572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 9264, 9325);

                    var
                    prevLocals = f_1514_9281_9324(this, new[] { f_1514_9308_9321(node) })
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 9343, 9380);

                    var
                    res = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCatchBlock(node), 1514, 9353, 9379)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 9398, 9428);

                    f_1514_9398_9427(this, prevLocals);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 9446, 9457);

                    return res;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 9205, 9572);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 9205, 9572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 9523, 9557);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitCatchBlock(node), 1514, 9530, 9556);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 9205, 9572);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1514, 9118, 9583);

                System.Linq.Expressions.ParameterExpression
                f_1514_9209_9222(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 9209, 9222);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1514_9308_9321(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 9308, 9321);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                f_1514_9281_9324(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Linq.Expressions.ParameterExpression[]
                variables)
                {
                    var return_v = this_param.EnterVariableScope((System.Collections.Generic.ICollection<System.Linq.Expressions.ParameterExpression>)variables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 9281, 9324);
                    return return_v;
                }


                int
                f_1514_9398_9427(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                prevLocals)
                {
                    this_param.ExitVariableScope(prevLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 9398, 9427);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 9118, 9583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 9118, 9583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1514, 9595, 9945);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 9684, 9737);

                var
                prevLocals = f_1514_9701_9736(this, f_1514_9720_9735(node))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 9787, 9820);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitLambda<T>(node), 1514, 9794, 9819);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1514, 9849, 9934);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 9889, 9919);

                    f_1514_9889_9918(this, prevLocals);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1514, 9849, 9934);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1514, 9595, 9945);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1514_9720_9735(System.Linq.Expressions.Expression<T>
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 9720, 9735);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                f_1514_9701_9736(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                variables)
                {
                    var return_v = this_param.EnterVariableScope((System.Collections.Generic.ICollection<System.Linq.Expressions.ParameterExpression>)variables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 9701, 9736);
                    return return_v;
                }


                int
                f_1514_9889_9918(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                prevLocals)
                {
                    this_param.ExitVariableScope(prevLocals);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 9889, 9918);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 9595, 9945);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 9595, 9945);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ExitVariableScope(HashSet<ParameterExpression> prevLocals)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1514, 9957, 10089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 10053, 10078);

                _loopLocals = prevLocals;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1514, 9957, 10089);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 9957, 10089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 9957, 10089);
            }
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1514, 10101, 11887);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 10235, 10330) || true) && (f_1514_10239_10253(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 10235, 10330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 10287, 10315);

                    return f_1514_10294_10314(this, f_1514_10300_10313(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 10235, 10330);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 10346, 10399);

                f_1514_10346_10398(!f_1514_10360_10397(f_1514_10360_10373(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 10415, 10460);

                var
                param = f_1514_10427_10436(node) as ParameterExpression
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 10474, 11876) || true) && (param != null && (DynAbs.Tracing.TraceSender.Expression_True(1514, 10478, 10533) && f_1514_10495_10508(node) == ExpressionType.Assign))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 10474, 11876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 10567, 10623);

                    var
                    left = f_1514_10578_10622(this, param, ExpressionAccess.Write)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 10641, 10671);

                    var
                    right = f_1514_10653_10670(this, f_1514_10659_10669(node))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 10747, 11765) || true) && (f_1514_10751_10760(left) != f_1514_10764_10774(param))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 10747, 11765);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 10816, 10858);

                        f_1514_10816_10857(f_1514_10829_10838(left) == typeof(object));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 10882, 10902);

                        Expression
                        rightVar
                        = default(Expression);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 10924, 11432) || true) && (f_1514_10928_10942(right) != ExpressionType.Parameter)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 10924, 11432);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 11104, 11157);

                            rightVar = f_1514_11115_11156(this, f_1514_11123_11155(f_1514_11144_11154(right)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 11183, 11226);

                            right = f_1514_11191_11225(rightVar, right);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 10924, 11432);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 10924, 11432);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 11392, 11409);

                            rightVar = right;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 10924, 11432);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 11456, 11626);

                        return f_1514_11463_11625(f_1514_11506_11567(node, left, null, f_1514_11530_11566(right, f_1514_11556_11565(left))), rightVar);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 10747, 11765);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 10747, 11765);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 11708, 11746);

                        return f_1514_11715_11745(node, left, null, right);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 10747, 11765);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 10474, 11876);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 10474, 11876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 11831, 11861);

                    return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBinary(node), 1514, 11838, 11860);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 10474, 11876);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1514, 10101, 11887);

                bool
                f_1514_10239_10253(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.CanReduce;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 10239, 10253);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_10300_10313(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Reduce();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 10300, 10313);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_10294_10314(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Linq.Expressions.Expression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 10294, 10314);
                    return return_v;
                }


                System.Linq.Expressions.ExpressionType
                f_1514_10360_10373(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 10360, 10373);
                    return return_v;
                }


                bool
                f_1514_10360_10397(System.Linq.Expressions.ExpressionType
                type)
                {
                    var return_v = type.IsReadWriteAssignment();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 10360, 10397);
                    return return_v;
                }


                int
                f_1514_10346_10398(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 10346, 10398);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1514_10427_10436(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 10427, 10436);
                    return return_v;
                }


                System.Linq.Expressions.ExpressionType
                f_1514_10495_10508(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 10495, 10508);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_10578_10622(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                node, System.Management.Automation.Interpreter.ExpressionAccess
                access)
                {
                    var return_v = this_param.VisitVariable(node, access);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 10578, 10622);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_10659_10669(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 10659, 10669);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_10653_10670(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Linq.Expressions.Expression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 10653, 10670);
                    return return_v;
                }


                System.Type
                f_1514_10751_10760(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 10751, 10760);
                    return return_v;
                }


                System.Type
                f_1514_10764_10774(System.Linq.Expressions.ParameterExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 10764, 10774);
                    return return_v;
                }


                System.Type
                f_1514_10829_10838(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 10829, 10838);
                    return return_v;
                }


                int
                f_1514_10816_10857(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 10816, 10857);
                    return 0;
                }


                System.Linq.Expressions.ExpressionType
                f_1514_10928_10942(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 10928, 10942);
                    return return_v;
                }


                System.Type
                f_1514_11144_11154(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 11144, 11154);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1514_11123_11155(System.Type
                type)
                {
                    var return_v = Expression.Parameter(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 11123, 11155);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1514_11115_11156(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                variable)
                {
                    var return_v = this_param.AddTemp(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 11115, 11156);
                    return return_v;
                }


                System.Linq.Expressions.BinaryExpression
                f_1514_11191_11225(System.Linq.Expressions.Expression
                left, System.Linq.Expressions.Expression
                right)
                {
                    var return_v = Expression.Assign(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 11191, 11225);
                    return return_v;
                }


                System.Type
                f_1514_11556_11565(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 11556, 11565);
                    return return_v;
                }


                System.Linq.Expressions.UnaryExpression
                f_1514_11530_11566(System.Linq.Expressions.Expression
                expression, System.Type
                type)
                {
                    var return_v = Expression.Convert(expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 11530, 11566);
                    return return_v;
                }


                System.Linq.Expressions.BinaryExpression
                f_1514_11506_11567(System.Linq.Expressions.BinaryExpression
                this_param, System.Linq.Expressions.Expression
                left, System.Linq.Expressions.LambdaExpression
                conversion, System.Linq.Expressions.UnaryExpression
                right)
                {
                    var return_v = this_param.Update(left, conversion, (System.Linq.Expressions.Expression)right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 11506, 11567);
                    return return_v;
                }


                System.Linq.Expressions.BlockExpression
                f_1514_11463_11625(System.Linq.Expressions.BinaryExpression
                arg0, System.Linq.Expressions.Expression
                arg1)
                {
                    var return_v = Expression.Block((System.Linq.Expressions.Expression)arg0, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 11463, 11625);
                    return return_v;
                }


                System.Linq.Expressions.BinaryExpression
                f_1514_11715_11745(System.Linq.Expressions.BinaryExpression
                this_param, System.Linq.Expressions.Expression
                left, System.Linq.Expressions.LambdaExpression
                conversion, System.Linq.Expressions.Expression
                right)
                {
                    var return_v = this_param.Update(left, conversion, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 11715, 11745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 10101, 11887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 10101, 11887);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Expression VisitUnary(UnaryExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1514, 11899, 12256);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 12038, 12133) || true) && (f_1514_12042_12056(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 12038, 12133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 12090, 12118);

                    return f_1514_12097_12117(this, f_1514_12103_12116(node));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 12038, 12133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 12149, 12202);

                f_1514_12149_12201(!f_1514_12163_12200(f_1514_12163_12176(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 12216, 12245);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitUnary(node), 1514, 12223, 12244);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1514, 11899, 12256);

                bool
                f_1514_12042_12056(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.CanReduce;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 12042, 12056);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_12103_12116(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.Reduce();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 12103, 12116);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_12097_12117(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Linq.Expressions.Expression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 12097, 12117);
                    return return_v;
                }


                System.Linq.Expressions.ExpressionType
                f_1514_12163_12176(System.Linq.Expressions.UnaryExpression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 12163, 12176);
                    return return_v;
                }


                bool
                f_1514_12163_12200(System.Linq.Expressions.ExpressionType
                type)
                {
                    var return_v = type.IsReadWriteAssignment();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 12163, 12200);
                    return return_v;
                }


                int
                f_1514_12149_12201(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 12149, 12201);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 11899, 12256);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 11899, 12256);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1514, 12408, 12564);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 12503, 12553);

                return f_1514_12510_12552(this, node, ExpressionAccess.Read);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1514, 12408, 12564);

                System.Linq.Expressions.Expression
                f_1514_12510_12552(System.Management.Automation.Interpreter.LoopCompiler
                this_param, System.Linq.Expressions.ParameterExpression
                node, System.Management.Automation.Interpreter.ExpressionAccess
                access)
                {
                    var return_v = this_param.VisitVariable(node, access);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 12510, 12552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 12408, 12564);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 12408, 12564);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Expression VisitVariable(ParameterExpression node, ExpressionAccess access)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1514, 12576, 14504);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 12684, 12708);

                ParameterExpression
                box
                = default(ParameterExpression);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 12722, 12744);

                LoopVariable
                existing
                = default(LoopVariable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 12758, 12776);

                LocalVariable
                loc
                = default(LocalVariable);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 12792, 13885) || true) && (f_1514_12796_12822(_loopLocals, node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 12792, 13885);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 12921, 12933);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 12792, 13885);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 12792, 13885);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 12967, 13885) || true) && (f_1514_12971_13017(_loopVariables, node, out existing))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 12967, 13885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 13124, 13150);

                        box = existing.BoxStorage;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 13168, 13239);

                        _loopVariables[node] = f_1514_13191_13238(existing.Access | access, box);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 12967, 13885);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 12967, 13885);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 13273, 13885) || true) && (f_1514_13277_13319(_outerVariables, node, out loc) || (DynAbs.Tracing.TraceSender.Expression_False(1514, 13277, 13413) || (_closureVariables != null && (DynAbs.Tracing.TraceSender.Expression_True(1514, 13339, 13412) && f_1514_13368_13412(_closureVariables, node, out loc)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 13273, 13885);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 13552, 13647);

                            box = (DynAbs.Tracing.TraceSender.Conditional_F1(1514, 13558, 13578) || ((f_1514_13558_13578(loc) && DynAbs.Tracing.TraceSender.Conditional_F2(1514, 13581, 13639)) || DynAbs.Tracing.TraceSender.Conditional_F3(1514, 13642, 13646))) ? f_1514_13581_13639(typeof(StrongBox<object>), f_1514_13629_13638(node)) : null;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 13665, 13718);

                            _loopVariables[node] = f_1514_13688_13717(access, box);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 13273, 13885);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 13273, 13885);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 13858, 13870);

                            return node;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 13273, 13885);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 12967, 13885);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 12792, 13885);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 13901, 14465) || true) && (box != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 13901, 14465);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 13950, 14450) || true) && ((access & ExpressionAccess.Write) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 13950, 14450);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 14093, 14145);

                        f_1514_14093_14144((access & ExpressionAccess.Read) == 0);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 14217, 14249);

                        return f_1514_14224_14248(box);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 13950, 14450);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 13950, 14450);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 14368, 14431);

                        return f_1514_14375_14430(f_1514_14394_14418(box), f_1514_14420_14429(node));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 13950, 14450);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 13901, 14465);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 14481, 14493);

                return node;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1514, 12576, 14504);

                bool
                f_1514_12796_12822(System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                this_param, System.Linq.Expressions.ParameterExpression
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 12796, 12822);
                    return return_v;
                }


                bool
                f_1514_12971_13017(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LoopCompiler.LoopVariable>
                this_param, System.Linq.Expressions.ParameterExpression
                key, out System.Management.Automation.Interpreter.LoopCompiler.LoopVariable
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 12971, 13017);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LoopCompiler.LoopVariable
                f_1514_13191_13238(System.Management.Automation.Interpreter.ExpressionAccess
                access, System.Linq.Expressions.ParameterExpression
                box)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoopCompiler.LoopVariable(access, box);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 13191, 13238);
                    return return_v;
                }


                bool
                f_1514_13277_13319(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                this_param, System.Linq.Expressions.ParameterExpression
                key, out System.Management.Automation.Interpreter.LocalVariable
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 13277, 13319);
                    return return_v;
                }


                bool
                f_1514_13368_13412(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                this_param, System.Linq.Expressions.ParameterExpression
                key, out System.Management.Automation.Interpreter.LocalVariable
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 13368, 13412);
                    return return_v;
                }


                bool
                f_1514_13558_13578(System.Management.Automation.Interpreter.LocalVariable
                this_param)
                {
                    var return_v = this_param.InClosureOrBoxed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 13558, 13578);
                    return return_v;
                }


                string
                f_1514_13629_13638(System.Linq.Expressions.ParameterExpression
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 13629, 13638);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1514_13581_13639(System.Type
                type, string
                name)
                {
                    var return_v = Expression.Parameter(type, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 13581, 13639);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LoopCompiler.LoopVariable
                f_1514_13688_13717(System.Management.Automation.Interpreter.ExpressionAccess
                access, System.Linq.Expressions.ParameterExpression
                box)
                {
                    var return_v = new System.Management.Automation.Interpreter.LoopCompiler.LoopVariable(access, box);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 13688, 13717);
                    return return_v;
                }


                int
                f_1514_14093_14144(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 14093, 14144);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1514_14224_14248(System.Linq.Expressions.ParameterExpression
                strongBoxExpression)
                {
                    var return_v = LightCompiler.Unbox((System.Linq.Expressions.Expression)strongBoxExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 14224, 14248);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1514_14394_14418(System.Linq.Expressions.ParameterExpression
                strongBoxExpression)
                {
                    var return_v = LightCompiler.Unbox((System.Linq.Expressions.Expression)strongBoxExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 14394, 14418);
                    return return_v;
                }


                System.Type
                f_1514_14420_14429(System.Linq.Expressions.ParameterExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1514, 14420, 14429);
                    return return_v;
                }


                System.Linq.Expressions.UnaryExpression
                f_1514_14375_14430(System.Linq.Expressions.Expression
                expression, System.Type
                type)
                {
                    var return_v = Expression.Convert(expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 14375, 14430);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 12576, 14504);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 12576, 14504);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterExpression AddTemp(ParameterExpression variable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1514, 14516, 14792);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 14606, 14714) || true) && (_temps == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1514, 14606, 14714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 14658, 14699);

                    _temps = f_1514_14667_14698();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1514, 14606, 14714);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 14730, 14751);

                f_1514_14730_14750(
                            _temps, variable);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1514, 14765, 14781);

                return variable;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1514, 14516, 14792);

                System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>
                f_1514_14667_14698()
                {
                    var return_v = new System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 14667, 14698);
                    return return_v;
                }


                int
                f_1514_14730_14750(System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>
                this_param, System.Linq.Expressions.ParameterExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 14730, 14750);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1514, 14516, 14792);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 14516, 14792);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LoopCompiler()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1514, 1129, 14821);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1514, 1129, 14821);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1514, 1129, 14821);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1514, 1129, 14821);

        System.Linq.Expressions.ParameterExpression
        f_1514_3394_3432(System.Type
        type)
        {
            var return_v = Expression.Parameter(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 3394, 3432);
            return return_v;
        }


        System.Linq.Expressions.ParameterExpression
        f_1514_3466_3515(System.Type
        type)
        {
            var return_v = Expression.Parameter(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 3466, 3515);
            return return_v;
        }


        System.Linq.Expressions.ParameterExpression
        f_1514_3542_3588(System.Type
        type)
        {
            var return_v = Expression.Parameter(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 3542, 3588);
            return return_v;
        }


        System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LoopCompiler.LoopVariable>
        f_1514_3620_3671()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LoopCompiler.LoopVariable>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 3620, 3671);
            return return_v;
        }


        System.Linq.Expressions.LabelTarget
        f_1514_3701_3730(System.Type
        type)
        {
            var return_v = Expression.Label(type);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1514, 3701, 3730);
            return return_v;
        }

    }
}
