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
using System.Runtime.CompilerServices;
using AstUtils = System.Management.Automation.Interpreter.Utils;

namespace System.Management.Automation.Interpreter
{
    internal sealed class LightLambdaClosureVisitor : ExpressionVisitor
    {
        private readonly Dictionary<ParameterExpression, LocalVariable> _closureVars;

        private readonly ParameterExpression _closureArray;

        private readonly Stack<HashSet<ParameterExpression>> _shadowedVars;

        private LightLambdaClosureVisitor(Dictionary<ParameterExpression, LocalVariable> closureVariables, ParameterExpression closureArray)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1511, 2202, 2506);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 1584, 1596);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 1802, 1815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 2132, 2189);
                this._shadowedVars = f_1511_2148_2189();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 2359, 2406);

                f_1511_2359_2405(closureVariables, closureArray);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 2420, 2449);

                _closureArray = closureArray;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 2463, 2495);

                _closureVars = closureVariables;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1511, 2202, 2506);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 2202, 2506);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 2202, 2506);
            }
        }

        internal static Func<StrongBox<object>[], Delegate> BindLambda(LambdaExpression lambda, Dictionary<ParameterExpression, LocalVariable> closureVariables)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1511, 3023, 3758);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 3235, 3310);

                var
                closure = f_1511_3249_3309(typeof(StrongBox<object>[]), "closure")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 3324, 3395);

                var
                visitor = f_1511_3338_3394(closureVariables, closure)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 3447, 3496);

                lambda = (LambdaExpression)f_1511_3474_3495(visitor, lambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 3592, 3677);

                var
                result = f_1511_3605_3676(lambda, closure)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 3723, 3747);

                return f_1511_3730_3746(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1511, 3023, 3758);

                System.Linq.Expressions.ParameterExpression
                f_1511_3249_3309(System.Type
                type, string
                name)
                {
                    var return_v = Expression.Parameter(type, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 3249, 3309);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LightLambdaClosureVisitor
                f_1511_3338_3394(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                closureVariables, System.Linq.Expressions.ParameterExpression
                closureArray)
                {
                    var return_v = new System.Management.Automation.Interpreter.LightLambdaClosureVisitor(closureVariables, closureArray);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 3338, 3394);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_3474_3495(System.Management.Automation.Interpreter.LightLambdaClosureVisitor
                this_param, System.Linq.Expressions.LambdaExpression
                node)
                {
                    var return_v = this_param.Visit((System.Linq.Expressions.Expression)node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 3474, 3495);
                    return return_v;
                }


                System.Linq.Expressions.Expression<System.Func<System.Runtime.CompilerServices.StrongBox<object>[], System.Delegate>>
                f_1511_3605_3676(System.Linq.Expressions.LambdaExpression
                body, params System.Linq.Expressions.ParameterExpression[]
                parameters)
                {
                    var return_v = Expression.Lambda<Func<StrongBox<object>[], Delegate>>((System.Linq.Expressions.Expression)body, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 3605, 3676);
                    return return_v;
                }


                System.Func<System.Runtime.CompilerServices.StrongBox<object>[], System.Delegate>
                f_1511_3730_3746(System.Linq.Expressions.Expression<System.Func<System.Runtime.CompilerServices.StrongBox<object>[], System.Delegate>>
                this_param)
                {
                    var return_v = this_param.Compile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 3730, 3746);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 3023, 3758);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 3023, 3758);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Expression VisitLambda<T>(Expression<T> node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1511, 3798, 4231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 3887, 3957);

                f_1511_3887_3956(_shadowedVars, f_1511_3906_3955(f_1511_3939_3954(node)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 3971, 4003);

                Expression
                b = f_1511_3986_4002(this, f_1511_3992_4001(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 4017, 4037);

                f_1511_4017_4036(_shadowedVars);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 4051, 4130) || true) && (b == f_1511_4060_4069(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 4051, 4130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 4103, 4115);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 4051, 4130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 4146, 4220);

                return f_1511_4153_4219(b, f_1511_4177_4186(node), f_1511_4188_4201(node), f_1511_4203_4218(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1511, 3798, 4231);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1511_3939_3954(System.Linq.Expressions.Expression<T>
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 3939, 3954);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                f_1511_3906_3955(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>((System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 3906, 3955);
                    return return_v;
                }


                int
                f_1511_3887_3956(System.Collections.Generic.Stack<System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>>
                this_param, System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 3887, 3956);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1511_3992_4001(System.Linq.Expressions.Expression<T>
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 3992, 4001);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_3986_4002(System.Management.Automation.Interpreter.LightLambdaClosureVisitor
                this_param, System.Linq.Expressions.Expression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 3986, 4002);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                f_1511_4017_4036(System.Collections.Generic.Stack<System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 4017, 4036);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_4060_4069(System.Linq.Expressions.Expression<T>
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 4060, 4069);
                    return return_v;
                }


                string
                f_1511_4177_4186(System.Linq.Expressions.Expression<T>
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 4177, 4186);
                    return return_v;
                }


                bool
                f_1511_4188_4201(System.Linq.Expressions.Expression<T>
                this_param)
                {
                    var return_v = this_param.TailCall;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 4188, 4201);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1511_4203_4218(System.Linq.Expressions.Expression<T>
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 4203, 4218);
                    return return_v;
                }


                System.Linq.Expressions.Expression<T>
                f_1511_4153_4219(System.Linq.Expressions.Expression
                body, string
                name, bool
                tailCall, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                parameters)
                {
                    var return_v = Expression.Lambda<T>(body, name, tailCall, (System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression>)parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 4153, 4219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 3798, 4231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 3798, 4231);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Expression VisitBlock(BlockExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1511, 4243, 4807);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 4330, 4476) || true) && (f_1511_4334_4354(f_1511_4334_4348(node)) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 4330, 4476);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 4392, 4461);

                    f_1511_4392_4460(_shadowedVars, f_1511_4411_4459(f_1511_4444_4458(node)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 4330, 4476);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 4492, 4524);

                var
                b = f_1511_4500_4523(this, f_1511_4506_4522(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 4538, 4635) || true) && (f_1511_4542_4562(f_1511_4542_4556(node)) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 4538, 4635);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 4600, 4620);

                    f_1511_4600_4619(_shadowedVars);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 4538, 4635);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 4651, 4737) || true) && (b == f_1511_4660_4676(node))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 4651, 4737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 4710, 4722);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 4651, 4737);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 4753, 4796);

                return f_1511_4760_4795(f_1511_4777_4791(node), b);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1511, 4243, 4807);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1511_4334_4348(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 4334, 4348);
                    return return_v;
                }


                int
                f_1511_4334_4354(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 4334, 4354);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1511_4444_4458(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 4444, 4458);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                f_1511_4411_4459(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>((System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 4411, 4459);
                    return return_v;
                }


                int
                f_1511_4392_4460(System.Collections.Generic.Stack<System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>>
                this_param, System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 4392, 4460);
                    return 0;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1511_4506_4522(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 4506, 4522);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1511_4500_4523(System.Management.Automation.Interpreter.LightLambdaClosureVisitor
                this_param, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                nodes)
                {
                    var return_v = this_param.Visit(nodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 4500, 4523);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1511_4542_4556(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 4542, 4556);
                    return return_v;
                }


                int
                f_1511_4542_4562(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 4542, 4562);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                f_1511_4600_4619(System.Collections.Generic.Stack<System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 4600, 4619);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                f_1511_4660_4676(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Expressions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 4660, 4676);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1511_4777_4791(System.Linq.Expressions.BlockExpression
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 4777, 4791);
                    return return_v;
                }


                System.Linq.Expressions.BlockExpression
                f_1511_4760_4795(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                variables, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.Expression>
                expressions)
                {
                    var return_v = Expression.Block((System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression>)variables, (System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression>)expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 4760, 4795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 4243, 4807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 4243, 4807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override CatchBlock VisitCatchBlock(CatchBlock node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1511, 4819, 5469);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 4906, 5058) || true) && (f_1511_4910_4923(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 4906, 5058);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 4965, 5043);

                    f_1511_4965_5042(_shadowedVars, f_1511_4984_5041(new[] { f_1511_5025_5038(node) }));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 4906, 5058);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5074, 5106);

                Expression
                b = f_1511_5089_5105(this, f_1511_5095_5104(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5120, 5154);

                Expression
                f = f_1511_5135_5153(this, f_1511_5141_5152(node))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5168, 5262) || true) && (f_1511_5172_5185(node) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 5168, 5262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5227, 5247);

                    f_1511_5227_5246(_shadowedVars);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 5168, 5262);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5278, 5377) || true) && (b == f_1511_5287_5296(node) && (DynAbs.Tracing.TraceSender.Expression_True(1511, 5282, 5316) && f == f_1511_5305_5316(node)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 5278, 5377);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5350, 5362);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 5278, 5377);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5393, 5458);

                return f_1511_5400_5457(f_1511_5426_5435(node), f_1511_5437_5450(node), b, f);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1511, 4819, 5469);

                System.Linq.Expressions.ParameterExpression
                f_1511_4910_4923(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 4910, 4923);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1511_5025_5038(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 5025, 5038);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                f_1511_4984_5041(System.Linq.Expressions.ParameterExpression[]
                collection)
                {
                    var return_v = new System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>((System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 4984, 5041);
                    return return_v;
                }


                int
                f_1511_4965_5042(System.Collections.Generic.Stack<System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>>
                this_param, System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 4965, 5042);
                    return 0;
                }


                System.Linq.Expressions.Expression
                f_1511_5095_5104(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 5095, 5104);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_5089_5105(System.Management.Automation.Interpreter.LightLambdaClosureVisitor
                this_param, System.Linq.Expressions.Expression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 5089, 5105);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_5141_5152(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 5141, 5152);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_5135_5153(System.Management.Automation.Interpreter.LightLambdaClosureVisitor
                this_param, System.Linq.Expressions.Expression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 5135, 5153);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1511_5172_5185(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 5172, 5185);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                f_1511_5227_5246(System.Collections.Generic.Stack<System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 5227, 5246);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_5287_5296(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 5287, 5296);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_5305_5316(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Filter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 5305, 5316);
                    return return_v;
                }


                System.Type
                f_1511_5426_5435(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Test;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 5426, 5435);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1511_5437_5450(System.Linq.Expressions.CatchBlock
                this_param)
                {
                    var return_v = this_param.Variable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 5437, 5450);
                    return return_v;
                }


                System.Linq.Expressions.CatchBlock
                f_1511_5400_5457(System.Type
                type, System.Linq.Expressions.ParameterExpression
                variable, System.Linq.Expressions.Expression
                body, System.Linq.Expressions.Expression
                filter)
                {
                    var return_v = Expression.MakeCatchBlock(type, variable, body, filter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 5400, 5457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 4819, 5469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 4819, 5469);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Expression VisitRuntimeVariables(RuntimeVariablesExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1511, 5481, 7230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5590, 5623);

                int
                count = f_1511_5602_5622(f_1511_5602_5616(node))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5637, 5672);

                var
                boxes = f_1511_5649_5671()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5686, 5729);

                var
                vars = f_1511_5697_5728()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5743, 5772);

                var
                indexes = new int[count]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5795, 5800);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5786, 6240) || true) && (i < count)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5813, 5816)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 5786, 6240))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 5786, 6240);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5850, 5908);

                        Expression
                        box = f_1511_5867_5907(this, f_1511_5882_5899(f_1511_5882_5896(node), i), false)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5926, 6225) || true) && (box == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 5926, 6225);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 5983, 6007);

                            indexes[i] = f_1511_5996_6006(vars);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 6029, 6057);

                            f_1511_6029_6056(vars, f_1511_6038_6055(f_1511_6038_6052(node), i));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 5926, 6225);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 5926, 6225);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 6139, 6169);

                            indexes[i] = -1 - f_1511_6157_6168(boxes);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 6191, 6206);

                            f_1511_6191_6205(boxes, box);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 5926, 6225);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1511, 1, 455);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1511, 1, 455);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 6332, 6413) || true) && (f_1511_6336_6347(boxes) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 6332, 6413);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 6386, 6398);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 6332, 6413);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 6429, 6497);

                var
                boxesArray = f_1511_6446_6496(typeof(IStrongBox), boxes)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 6631, 6882) || true) && (f_1511_6635_6645(vars) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 6631, 6882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 6684, 6867);

                    return f_1511_6691_6866(f_1511_6731_6814(RuntimeVariables.Create), boxesArray);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 6631, 6882);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 6970, 7078);

                Func<IRuntimeVariables, IRuntimeVariables, int[], IRuntimeVariables>
                helper = MergedRuntimeVariables.Create
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 7092, 7219);

                return f_1511_7099_7218(f_1511_7117_7142(helper), f_1511_7144_7177(vars), boxesArray, f_1511_7191_7217(indexes));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1511, 5481, 7230);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1511_5602_5616(System.Linq.Expressions.RuntimeVariablesExpression
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 5602, 5616);
                    return return_v;
                }


                int
                f_1511_5602_5622(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 5602, 5622);
                    return return_v;
                }


                System.Collections.Generic.List<System.Linq.Expressions.Expression>
                f_1511_5649_5671()
                {
                    var return_v = new System.Collections.Generic.List<System.Linq.Expressions.Expression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 5649, 5671);
                    return return_v;
                }


                System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>
                f_1511_5697_5728()
                {
                    var return_v = new System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 5697, 5728);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1511_5882_5896(System.Linq.Expressions.RuntimeVariablesExpression
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 5882, 5896);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1511_5882_5899(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 5882, 5899);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_5867_5907(System.Management.Automation.Interpreter.LightLambdaClosureVisitor
                this_param, System.Linq.Expressions.ParameterExpression
                variable, bool
                unbox)
                {
                    var return_v = this_param.GetClosureItem(variable, unbox);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 5867, 5907);
                    return return_v;
                }


                int
                f_1511_5996_6006(System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 5996, 6006);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1511_6038_6052(System.Linq.Expressions.RuntimeVariablesExpression
                this_param)
                {
                    var return_v = this_param.Variables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 6038, 6052);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1511_6038_6055(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 6038, 6055);
                    return return_v;
                }


                int
                f_1511_6029_6056(System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>
                this_param, System.Linq.Expressions.ParameterExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 6029, 6056);
                    return 0;
                }


                int
                f_1511_6157_6168(System.Collections.Generic.List<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 6157, 6168);
                    return return_v;
                }


                int
                f_1511_6191_6205(System.Collections.Generic.List<System.Linq.Expressions.Expression>
                this_param, System.Linq.Expressions.Expression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 6191, 6205);
                    return 0;
                }


                int
                f_1511_6336_6347(System.Collections.Generic.List<System.Linq.Expressions.Expression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 6336, 6347);
                    return return_v;
                }


                System.Linq.Expressions.NewArrayExpression
                f_1511_6446_6496(System.Type
                type, System.Collections.Generic.List<System.Linq.Expressions.Expression>
                initializers)
                {
                    var return_v = Expression.NewArrayInit(type, (System.Collections.Generic.IEnumerable<System.Linq.Expressions.Expression>)initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 6446, 6496);
                    return return_v;
                }


                int
                f_1511_6635_6645(System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 6635, 6645);
                    return return_v;
                }


                System.Linq.Expressions.ConstantExpression
                f_1511_6731_6814(System.Func<System.Runtime.CompilerServices.IStrongBox[], System.Runtime.CompilerServices.IRuntimeVariables>
                value)
                {
                    var return_v = Expression.Constant((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 6731, 6814);
                    return return_v;
                }


                System.Linq.Expressions.InvocationExpression
                f_1511_6691_6866(System.Linq.Expressions.ConstantExpression
                expression, params System.Linq.Expressions.Expression[]
                arguments)
                {
                    var return_v = Expression.Invoke((System.Linq.Expressions.Expression)expression, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 6691, 6866);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_7117_7142(System.Func<System.Runtime.CompilerServices.IRuntimeVariables, System.Runtime.CompilerServices.IRuntimeVariables, int[], System.Runtime.CompilerServices.IRuntimeVariables>
                value)
                {
                    var return_v = AstUtils.Constant((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 7117, 7142);
                    return return_v;
                }


                System.Linq.Expressions.RuntimeVariablesExpression
                f_1511_7144_7177(System.Collections.Generic.List<System.Linq.Expressions.ParameterExpression>
                variables)
                {
                    var return_v = Expression.RuntimeVariables((System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression>)variables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 7144, 7177);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_7191_7217(int[]
                value)
                {
                    var return_v = AstUtils.Constant((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 7191, 7217);
                    return return_v;
                }


                System.Linq.Expressions.InvocationExpression
                f_1511_7099_7218(System.Linq.Expressions.Expression
                expression, params System.Linq.Expressions.Expression[]
                arguments)
                {
                    var return_v = Expression.Invoke(expression, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 7099, 7218);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 5481, 7230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 5481, 7230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Expression VisitParameter(ParameterExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1511, 7242, 7637);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 7337, 7389);

                Expression
                closureItem = f_1511_7362_7388(this, node, true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 7403, 7487) || true) && (closureItem == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 7403, 7487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 7460, 7472);

                    return node;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 7403, 7487);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 7578, 7626);

                return f_1511_7585_7625(closureItem, f_1511_7615_7624(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1511, 7242, 7637);

                System.Linq.Expressions.Expression
                f_1511_7362_7388(System.Management.Automation.Interpreter.LightLambdaClosureVisitor
                this_param, System.Linq.Expressions.ParameterExpression
                variable, bool
                unbox)
                {
                    var return_v = this_param.GetClosureItem(variable, unbox);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 7362, 7388);
                    return return_v;
                }


                System.Type
                f_1511_7615_7624(System.Linq.Expressions.ParameterExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 7615, 7624);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_7585_7625(System.Linq.Expressions.Expression
                expression, System.Type
                type)
                {
                    var return_v = AstUtils.Convert(expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 7585, 7625);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 7242, 7637);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 7242, 7637);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Expression VisitBinary(BinaryExpression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1511, 7649, 8560);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 7738, 8503) || true) && (f_1511_7742_7755(node) == ExpressionType.Assign && (DynAbs.Tracing.TraceSender.Expression_True(1511, 7742, 7847) && f_1511_7801_7819(f_1511_7801_7810(node)) == ExpressionType.Parameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 7738, 8503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 7881, 7927);

                    var
                    variable = (ParameterExpression)f_1511_7917_7926(node)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 7945, 8001);

                    Expression
                    closureItem = f_1511_7970_8000(this, variable, true)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 8019, 8488) || true) && (closureItem != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 8019, 8488);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 8168, 8469);

                        return f_1511_8175_8468(new[] { variable }, f_1511_8263_8309(variable, f_1511_8291_8308(this, f_1511_8297_8307(node))), f_1511_8336_8410(closureItem, f_1511_8367_8409(variable, typeof(object))), variable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 8019, 8488);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 7738, 8503);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 8519, 8549);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.VisitBinary(node), 1511, 8526, 8548);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1511, 7649, 8560);

                System.Linq.Expressions.ExpressionType
                f_1511_7742_7755(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 7742, 7755);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_7801_7810(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 7801, 7810);
                    return return_v;
                }


                System.Linq.Expressions.ExpressionType
                f_1511_7801_7819(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.NodeType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 7801, 7819);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_7917_7926(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Left;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 7917, 7926);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_7970_8000(System.Management.Automation.Interpreter.LightLambdaClosureVisitor
                this_param, System.Linq.Expressions.ParameterExpression
                variable, bool
                unbox)
                {
                    var return_v = this_param.GetClosureItem(variable, unbox);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 7970, 8000);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_8297_8307(System.Linq.Expressions.BinaryExpression
                this_param)
                {
                    var return_v = this_param.Right;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 8297, 8307);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_8291_8308(System.Management.Automation.Interpreter.LightLambdaClosureVisitor
                this_param, System.Linq.Expressions.Expression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 8291, 8308);
                    return return_v;
                }


                System.Linq.Expressions.BinaryExpression
                f_1511_8263_8309(System.Linq.Expressions.ParameterExpression
                left, System.Linq.Expressions.Expression
                right)
                {
                    var return_v = Expression.Assign((System.Linq.Expressions.Expression)left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 8263, 8309);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_8367_8409(System.Linq.Expressions.ParameterExpression
                expression, System.Type
                type)
                {
                    var return_v = AstUtils.Convert((System.Linq.Expressions.Expression)expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 8367, 8409);
                    return return_v;
                }


                System.Linq.Expressions.BinaryExpression
                f_1511_8336_8410(System.Linq.Expressions.Expression
                left, System.Linq.Expressions.Expression
                right)
                {
                    var return_v = Expression.Assign(left, right);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 8336, 8410);
                    return return_v;
                }


                System.Linq.Expressions.BlockExpression
                f_1511_8175_8468(System.Linq.Expressions.ParameterExpression[]
                variables, params System.Linq.Expressions.Expression[]
                expressions)
                {
                    var return_v = Expression.Block((System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression>)variables, expressions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 8175, 8468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 7649, 8560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 7649, 8560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Expression GetClosureItem(ParameterExpression variable, bool unbox)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1511, 8572, 9324);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 8746, 8958);
                    foreach (HashSet<ParameterExpression> hidden in f_1511_8794_8807_I(_shadowedVars))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 8746, 8958);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 8841, 8943) || true) && (f_1511_8845_8870(hidden, variable))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 8841, 8943);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 8912, 8924);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 8841, 8943);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 8746, 8958);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1511, 1, 213);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1511, 1, 213);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 8974, 8992);

                LocalVariable
                loc
                = default(LocalVariable);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 9006, 9177) || true) && (!f_1511_9011_9054(_closureVars, variable, out loc))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 9006, 9177);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 9088, 9162);

                    throw f_1511_9094_9161("unbound variable: " + f_1511_9147_9160(variable));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 9006, 9177);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 9193, 9245);

                var
                result = f_1511_9206_9244(loc, null, _closureArray)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 9259, 9313);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1511, 9266, 9273) || (((unbox) && DynAbs.Tracing.TraceSender.Conditional_F2(1511, 9276, 9303)) || DynAbs.Tracing.TraceSender.Conditional_F3(1511, 9306, 9312))) ? f_1511_9276_9303(result) : result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1511, 8572, 9324);

                bool
                f_1511_8845_8870(System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>
                this_param, System.Linq.Expressions.ParameterExpression
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 8845, 8870);
                    return return_v;
                }


                System.Collections.Generic.Stack<System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>>
                f_1511_8794_8807_I(System.Collections.Generic.Stack<System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 8794, 8807);
                    return return_v;
                }


                bool
                f_1511_9011_9054(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                this_param, System.Linq.Expressions.ParameterExpression
                key, out System.Management.Automation.Interpreter.LocalVariable
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 9011, 9054);
                    return return_v;
                }


                string
                f_1511_9147_9160(System.Linq.Expressions.ParameterExpression
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 9147, 9160);
                    return return_v;
                }


                System.InvalidOperationException
                f_1511_9094_9161(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 9094, 9161);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_9206_9244(System.Management.Automation.Interpreter.LocalVariable
                this_param, System.Linq.Expressions.Expression
                frameData, System.Linq.Expressions.ParameterExpression
                closure)
                {
                    var return_v = this_param.LoadFromArray(frameData, (System.Linq.Expressions.Expression)closure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 9206, 9244);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_9276_9303(System.Linq.Expressions.Expression
                strongBoxExpression)
                {
                    var return_v = LightCompiler.Unbox(strongBoxExpression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 9276, 9303);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 8572, 9324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 8572, 9324);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Expression VisitExtension(Expression node)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1511, 9336, 9543);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 9494, 9532);

                return f_1511_9501_9531(this, f_1511_9507_9530(node));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1511, 9336, 9543);

                System.Linq.Expressions.Expression
                f_1511_9507_9530(System.Linq.Expressions.Expression
                this_param)
                {
                    var return_v = this_param.ReduceExtensions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 9507, 9530);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1511_9501_9531(System.Management.Automation.Interpreter.LightLambdaClosureVisitor
                this_param, System.Linq.Expressions.Expression
                node)
                {
                    var return_v = this_param.Visit(node);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 9501, 9531);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 9336, 9543);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 9336, 9543);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class MergedRuntimeVariables : IRuntimeVariables
        {
            private readonly IRuntimeVariables _first;

            private readonly IRuntimeVariables _second;

            private readonly int[] _indexes;

            private MergedRuntimeVariables(IRuntimeVariables first, IRuntimeVariables second, int[] indexes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1511, 10127, 10358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 9847, 9853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 9903, 9910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 10102, 10110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 10256, 10271);

                    _first = first;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 10289, 10306);

                    _second = second;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 10324, 10343);

                    _indexes = indexes;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1511, 10127, 10358);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 10127, 10358);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 10127, 10358);
                }
            }

            internal static IRuntimeVariables Create(IRuntimeVariables first, IRuntimeVariables second, int[] indexes)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1511, 10374, 10586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 10513, 10571);

                    return f_1511_10520_10570(first, second, indexes);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1511, 10374, 10586);

                    System.Management.Automation.Interpreter.LightLambdaClosureVisitor.MergedRuntimeVariables
                    f_1511_10520_10570(System.Runtime.CompilerServices.IRuntimeVariables
                    first, System.Runtime.CompilerServices.IRuntimeVariables
                    second, int[]
                    indexes)
                    {
                        var return_v = new System.Management.Automation.Interpreter.LightLambdaClosureVisitor.MergedRuntimeVariables(first, second, indexes);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 10520, 10570);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 10374, 10586);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 10374, 10586);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            int IRuntimeVariables.Count
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1511, 10662, 10693);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 10668, 10691);

                        return f_1511_10675_10690(_indexes);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1511, 10662, 10693);

                        int
                        f_1511_10675_10690(int[]
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 10675, 10690);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 10602, 10708);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 10602, 10708);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            object IRuntimeVariables.this[int index]
            {

                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1511, 10797, 10964);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 10841, 10865);

                        index = _indexes[index];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 10887, 10945);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(1511, 10894, 10906) || (((index >= 0) && DynAbs.Tracing.TraceSender.Conditional_F2(1511, 10909, 10922)) || DynAbs.Tracing.TraceSender.Conditional_F3(1511, 10925, 10944))) ? f_1511_10909_10922(_first, index) : f_1511_10925_10944(_second, -1 - index);
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1511, 10797, 10964);

                        object
                        f_1511_10909_10922(System.Runtime.CompilerServices.IRuntimeVariables
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 10909, 10922);
                            return return_v;
                        }


                        object
                        f_1511_10925_10944(System.Runtime.CompilerServices.IRuntimeVariables
                        this_param, int
                        i0)
                        {
                            var return_v = this_param[i0];
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1511, 10925, 10944);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 10797, 10964);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 10797, 10964);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }

                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1511, 10984, 11328);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 11028, 11052);

                        index = _indexes[index];

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 11074, 11309) || true) && (index >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 11074, 11309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 11138, 11160);

                            _first[index] = value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 11074, 11309);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1511, 11074, 11309);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1511, 11258, 11286);

                            _second[-1 - index] = value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1511, 11074, 11309);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1511, 10984, 11328);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1511, 10984, 11328);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 10984, 11328);
                    }
                }
            }

            static MergedRuntimeVariables()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1511, 9724, 11354);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1511, 9724, 11354);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 9724, 11354);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1511, 9724, 11354);
        }

        static LightLambdaClosureVisitor()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1511, 1352, 11403);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1511, 1352, 11403);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1511, 1352, 11403);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1511, 1352, 11403);

        System.Collections.Generic.Stack<System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>>
        f_1511_2148_2189()
        {
            var return_v = new System.Collections.Generic.Stack<System.Collections.Generic.HashSet<System.Linq.Expressions.ParameterExpression>>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 2148, 2189);
            return return_v;
        }


        int
        f_1511_2359_2405(System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
        var1, System.Linq.Expressions.ParameterExpression
        var2)
        {
            Assert.NotNull((object)var1, (object)var2);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1511, 2359, 2405);
            return 0;
        }

    }
}
