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
using System.Diagnostics;
using System.Runtime.CompilerServices;

//using Microsoft.Scripting.Generation;

namespace System.Management.Automation.Interpreter
{
    internal sealed class LightDelegateCreator
    {
        private readonly Interpreter _interpreter;

        private readonly Expression _lambda;

        private Type _compiledDelegateType;

        private Delegate _compiled;

        private readonly object _compileLock;

        internal LightDelegateCreator(Interpreter interpreter, LambdaExpression lambda)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1508, 1498, 1708);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 1239, 1251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 1290, 1297);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 1365, 1386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 1414, 1423);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 1458, 1485);
                this._compileLock = f_1508_1473_1485();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 1602, 1625);

                f_1508_1602_1624(lambda);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 1639, 1666);

                _interpreter = interpreter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 1680, 1697);

                _lambda = lambda;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1508, 1498, 1708);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1508, 1498, 1708);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1508, 1498, 1708);
            }
        }

        internal Interpreter Interpreter
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1508, 2007, 2035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 2013, 2033);

                    return _interpreter;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1508, 2007, 2035);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1508, 1950, 2046);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1508, 1950, 2046);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool HasClosure
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1508, 2106, 2174);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 2112, 2172);

                    return _interpreter != null && (DynAbs.Tracing.TraceSender.Expression_True(1508, 2119, 2171) && f_1508_2143_2167(_interpreter) > 0);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1508, 2106, 2174);

                    int
                    f_1508_2143_2167(System.Management.Automation.Interpreter.Interpreter
                    this_param)
                    {
                        var return_v = this_param.ClosureSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 2143, 2167);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1508, 2058, 2185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1508, 2058, 2185);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool HasCompiled
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1508, 2247, 2280);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 2253, 2278);

                    return _compiled != null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1508, 2247, 2280);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1508, 2197, 2291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1508, 2197, 2291);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool SameDelegateType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1508, 2544, 2597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 2550, 2595);

                    return _compiledDelegateType == f_1508_2582_2594();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1508, 2544, 2597);

                    System.Type
                    f_1508_2582_2594()
                    {
                        var return_v = DelegateType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 2582, 2594);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1508, 2489, 2608);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1508, 2489, 2608);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public Delegate CreateDelegate()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1508, 2620, 2716);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 2677, 2705);

                return f_1508_2684_2704(this, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1508, 2620, 2716);

                System.Delegate
                f_1508_2684_2704(System.Management.Automation.Interpreter.LightDelegateCreator
                this_param, System.Runtime.CompilerServices.StrongBox<object>[]
                closure)
                {
                    var return_v = this_param.CreateDelegate(closure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 2684, 2704);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1508, 2620, 2716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1508, 2620, 2716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Delegate CreateDelegate(StrongBox<object>[] closure)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1508, 2728, 4045);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 2814, 3517) || true) && (_compiled != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1508, 2814, 3517);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 3382, 3502) || true) && (f_1508_3386_3402())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1508, 3382, 3502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 3444, 3483);

                        return f_1508_3451_3482(this, closure);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1508, 3382, 3502);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1508, 2814, 3517);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 3533, 3850) || true) && (_interpreter == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1508, 3533, 3850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 3650, 3664);

                    f_1508_3650_3663(this, null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 3682, 3734);

                    Delegate
                    compiled = f_1508_3702_3733(this, closure)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 3752, 3801);

                    f_1508_3752_3800(f_1508_3765_3783(compiled) == f_1508_3787_3799());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 3819, 3835);

                    return compiled;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1508, 3533, 3850);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 3933, 4034);

                return f_1508_3940_4033(f_1508_3940_4006(this, closure, _interpreter._compilationThreshold), f_1508_4020_4032());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1508, 2728, 4045);

                bool
                f_1508_3386_3402()
                {
                    var return_v = SameDelegateType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 3386, 3402);
                    return return_v;
                }


                System.Delegate
                f_1508_3451_3482(System.Management.Automation.Interpreter.LightDelegateCreator
                this_param, System.Runtime.CompilerServices.StrongBox<object>[]
                closure)
                {
                    var return_v = this_param.CreateCompiledDelegate(closure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 3451, 3482);
                    return return_v;
                }


                int
                f_1508_3650_3663(System.Management.Automation.Interpreter.LightDelegateCreator
                this_param, object
                state)
                {
                    this_param.Compile(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 3650, 3663);
                    return 0;
                }


                System.Delegate
                f_1508_3702_3733(System.Management.Automation.Interpreter.LightDelegateCreator
                this_param, System.Runtime.CompilerServices.StrongBox<object>[]
                closure)
                {
                    var return_v = this_param.CreateCompiledDelegate(closure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 3702, 3733);
                    return return_v;
                }


                System.Type
                f_1508_3765_3783(System.Delegate
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 3765, 3783);
                    return return_v;
                }


                System.Type
                f_1508_3787_3799()
                {
                    var return_v = DelegateType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 3787, 3799);
                    return return_v;
                }


                int
                f_1508_3752_3800(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 3752, 3800);
                    return 0;
                }


                System.Management.Automation.Interpreter.LightLambda
                f_1508_3940_4006(System.Management.Automation.Interpreter.LightDelegateCreator
                delegateCreator, System.Runtime.CompilerServices.StrongBox<object>[]
                closure, int
                compilationThreshold)
                {
                    var return_v = new System.Management.Automation.Interpreter.LightLambda(delegateCreator, closure, compilationThreshold);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 3940, 4006);
                    return return_v;
                }


                System.Type
                f_1508_4020_4032()
                {
                    var return_v = DelegateType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 4020, 4032);
                    return return_v;
                }


                System.Delegate
                f_1508_3940_4033(System.Management.Automation.Interpreter.LightLambda
                this_param, System.Type
                delegateType)
                {
                    var return_v = this_param.MakeDelegate(delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 3940, 4033);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1508, 2728, 4045);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1508, 2728, 4045);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Type DelegateType
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1508, 4107, 4414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 4143, 4193);

                    LambdaExpression
                    le = _lambda as LambdaExpression
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 4211, 4301) || true) && (le != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1508, 4211, 4301);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 4267, 4282);

                        return f_1508_4274_4281(le);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1508, 4211, 4301);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 4321, 4333);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1508, 4107, 4414);

                    System.Type
                    f_1508_4274_4281(System.Linq.Expressions.LambdaExpression
                    this_param)
                    {
                        var return_v = this_param.Type;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 4274, 4281);
                        return return_v;
                    }

                    // return ((LightLambdaExpression)_lambda).Type;
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1508, 4057, 4425);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1508, 4057, 4425);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal Delegate CreateCompiledDelegate(StrongBox<object>[] closure)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1508, 4547, 5000);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 4641, 4687);

                f_1508_4641_4686(f_1508_4654_4664() == (closure != null));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 4703, 4956) || true) && (f_1508_4707_4717())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1508, 4703, 4956);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 4828, 4894);

                    var
                    applyClosure = (Func<StrongBox<object>[], Delegate>)_compiled
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 4912, 4941);

                    return f_1508_4919_4940(applyClosure, closure);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1508, 4703, 4956);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 4972, 4989);

                return _compiled;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1508, 4547, 5000);

                bool
                f_1508_4654_4664()
                {
                    var return_v = HasClosure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 4654, 4664);
                    return return_v;
                }


                int
                f_1508_4641_4686(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 4641, 4686);
                    return 0;
                }


                bool
                f_1508_4707_4717()
                {
                    var return_v = HasClosure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 4707, 4717);
                    return return_v;
                }


                System.Delegate
                f_1508_4919_4940(System.Func<System.Runtime.CompilerServices.StrongBox<object>[], System.Delegate>
                this_param, System.Runtime.CompilerServices.StrongBox<object>[]
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 4919, 4940);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1508, 4547, 5000);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1508, 4547, 5000);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Compile(object state)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1508, 5238, 6680);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 5298, 5375) || true) && (_compiled != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1508, 5298, 5375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 5353, 5360);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1508, 5298, 5375);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 5467, 5479);

                // Compilation is expensive, we only want to do it once.
                lock (_compileLock)
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 5513, 5602) || true) && (_compiled != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1508, 5513, 5602);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 5576, 5583);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1508, 5513, 5602);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 5970, 6026);

                    LambdaExpression
                    lambda = (_lambda as LambdaExpression)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 6110, 6360) || true) && (_interpreter != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1508, 6110, 6360);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 6176, 6224);

                        _compiledDelegateType = f_1508_6200_6223(lambda);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 6246, 6341);

                        lambda = f_1508_6255_6340(_compiledDelegateType, f_1508_6296_6307(lambda), f_1508_6309_6320(lambda), f_1508_6322_6339(lambda));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1508, 6110, 6360);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 6380, 6654) || true) && (f_1508_6384_6394())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1508, 6380, 6654);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 6436, 6524);

                        _compiled = f_1508_6448_6523(lambda, f_1508_6493_6522(_interpreter));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1508, 6380, 6654);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1508, 6380, 6654);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 6606, 6635);

                        _compiled = f_1508_6618_6634(lambda);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1508, 6380, 6654);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1508, 5238, 6680);

                System.Type
                f_1508_6200_6223(System.Linq.Expressions.LambdaExpression
                lambda)
                {
                    var return_v = GetFuncOrAction(lambda);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 6200, 6223);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1508_6296_6307(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.Body;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 6296, 6307);
                    return return_v;
                }


                string
                f_1508_6309_6320(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 6309, 6320);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1508_6322_6339(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 6322, 6339);
                    return return_v;
                }


                System.Linq.Expressions.LambdaExpression
                f_1508_6255_6340(System.Type
                delegateType, System.Linq.Expressions.Expression
                body, string
                name, System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                parameters)
                {
                    var return_v = Expression.Lambda(delegateType, body, name, (System.Collections.Generic.IEnumerable<System.Linq.Expressions.ParameterExpression>)parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 6255, 6340);
                    return return_v;
                }


                bool
                f_1508_6384_6394()
                {
                    var return_v = HasClosure;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 6384, 6394);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                f_1508_6493_6522(System.Management.Automation.Interpreter.Interpreter
                this_param)
                {
                    var return_v = this_param.ClosureVariables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 6493, 6522);
                    return return_v;
                }


                System.Func<System.Runtime.CompilerServices.StrongBox<object>[], System.Delegate>
                f_1508_6448_6523(System.Linq.Expressions.LambdaExpression
                lambda, System.Collections.Generic.Dictionary<System.Linq.Expressions.ParameterExpression, System.Management.Automation.Interpreter.LocalVariable>
                closureVariables)
                {
                    var return_v = LightLambdaClosureVisitor.BindLambda(lambda, closureVariables);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 6448, 6523);
                    return return_v;
                }


                System.Delegate
                f_1508_6618_6634(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.Compile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 6618, 6634);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1508, 5238, 6680);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1508, 5238, 6680);
            }
        }

        private static Type GetFuncOrAction(LambdaExpression lambda)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1508, 6692, 7764);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 6777, 6795);

                Type
                delegateType
                = default(Type);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 6809, 6857);

                bool
                isVoid = f_1508_6823_6840(lambda) == typeof(void)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 7143, 7230);

                Type[]
                types = f_1508_7158_7229(f_1508_7158_7175(lambda), p => p.IsByRef ? p.Type.MakeByRefType() : p.Type)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 7244, 7700) || true) && (isVoid)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1508, 7244, 7700);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 7288, 7425) || true) && (f_1508_7292_7344(types, out delegateType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1508, 7288, 7425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 7386, 7406);

                        return delegateType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1508, 7288, 7425);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1508, 7244, 7700);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1508, 7244, 7700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 7491, 7532);

                    types = f_1508_7499_7531(types, f_1508_7513_7530(lambda));

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 7550, 7685) || true) && (f_1508_7554_7604(types, out delegateType))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1508, 7550, 7685);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 7646, 7666);

                        return delegateType;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1508, 7550, 7685);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1508, 7244, 7700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1508, 7716, 7735);

                return f_1508_7723_7734(lambda);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1508, 6692, 7764);

                System.Type
                f_1508_6823_6840(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 6823, 6840);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                f_1508_7158_7175(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 7158, 7175);
                    return return_v;
                }


                System.Type[]
                f_1508_7158_7229(System.Collections.ObjectModel.ReadOnlyCollection<System.Linq.Expressions.ParameterExpression>
                collection, System.Func<System.Linq.Expressions.ParameterExpression, System.Type>
                select)
                {
                    var return_v = collection.Map<System.Linq.Expressions.ParameterExpression, System.Type>(select);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 7158, 7229);
                    return return_v;
                }


                bool
                f_1508_7292_7344(System.Type[]
                typeArgs, out System.Type
                actionType)
                {
                    var return_v = Expression.TryGetActionType(typeArgs, out actionType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 7292, 7344);
                    return return_v;
                }


                System.Type
                f_1508_7513_7530(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 7513, 7530);
                    return return_v;
                }


                System.Type[]
                f_1508_7499_7531(System.Type[]
                list, System.Type
                item)
                {
                    var return_v = list.AddLast<System.Type>(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 7499, 7531);
                    return return_v;
                }


                bool
                f_1508_7554_7604(System.Type[]
                typeArgs, out System.Type
                funcType)
                {
                    var return_v = Expression.TryGetFuncType(typeArgs, out funcType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 7554, 7604);
                    return return_v;
                }


                System.Type
                f_1508_7723_7734(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1508, 7723, 7734);
                    return return_v;
                }

                // }
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1508, 6692, 7764);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1508, 6692, 7764);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LightDelegateCreator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1508, 1106, 7771);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1508, 1106, 7771);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1508, 1106, 7771);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1508, 1106, 7771);

        object
        f_1508_1473_1485()
        {
            var return_v = new object();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 1473, 1485);
            return return_v;
        }


        int
        f_1508_1602_1624(System.Linq.Expressions.LambdaExpression
        var)
        {
            Assert.NotNull((object)var);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1508, 1602, 1624);
            return 0;
        }

    }
}
