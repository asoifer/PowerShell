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
using System.Reflection;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security;
using System.Threading;

//using Microsoft.Scripting.Generation;

using AstUtils = System.Management.Automation.Interpreter.Utils;

namespace System.Management.Automation.Interpreter
{
    internal sealed class LightLambdaCompileEventArgs : EventArgs
    {
        public Delegate Compiled { get; private set; }

        internal LightLambdaCompileEventArgs(Delegate compiled)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1509, 1259, 1370);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 1201, 1247);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 1339, 1359);

                Compiled = compiled;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1509, 1259, 1370);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1509, 1259, 1370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1509, 1259, 1370);
            }
        }

        static LightLambdaCompileEventArgs()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1509, 1123, 1377);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1509, 1123, 1377);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1509, 1123, 1377);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1509, 1123, 1377);
    }
    internal partial class LightLambda
    {
        private readonly StrongBox<object>[] _closure;

        private readonly Interpreter _interpreter;

        private static readonly CacheDict<Type, Func<LightLambda, Delegate>> s_runCache;

        private readonly LightDelegateCreator _delegateCreator;

        private Delegate _compiled;

        private int _compilationThreshold;

        /// <summary>
        /// Provides notification that the LightLambda has been compiled.
        /// </summary>
        public event EventHandler<LightLambdaCompileEventArgs>
Compile
;

        internal LightLambda(LightDelegateCreator delegateCreator, StrongBox<object>[] closure, int compilationThreshold)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1509, 2078, 2411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 1473, 1481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 1521, 1533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 1771, 1787);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 1815, 1824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 1847, 1868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 2216, 2251);

                _delegateCreator = delegateCreator;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 2265, 2284);

                _closure = closure;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 2298, 2341);

                _interpreter = f_1509_2313_2340(delegateCreator);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 2355, 2400);

                _compilationThreshold = compilationThreshold;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1509, 2078, 2411);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1509, 2078, 2411);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1509, 2078, 2411);
            }
        }

        private static Func<LightLambda, Delegate> GetRunDelegateCtor(Type delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1509, 2423, 2851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 2534, 2544);
                lock (s_runCache)
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 2578, 2615);

                    Func<LightLambda, Delegate>
                    fastCtor
                    = default(Func<LightLambda, Delegate>);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 2633, 2764) || true) && (f_1509_2637_2687(s_runCache, delegateType, out fastCtor))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 2633, 2764);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 2729, 2745);

                        return fastCtor;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 2633, 2764);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 2784, 2825);

                    return f_1509_2791_2824(delegateType);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1509, 2423, 2851);

                bool
                f_1509_2637_2687(System.Management.Automation.Interpreter.CacheDict<System.Type, System.Func<System.Management.Automation.Interpreter.LightLambda, System.Delegate>>
                this_param, System.Type
                key, out System.Func<System.Management.Automation.Interpreter.LightLambda, System.Delegate>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 2637, 2687);
                    return return_v;
                }


                System.Func<System.Management.Automation.Interpreter.LightLambda, System.Delegate>
                f_1509_2791_2824(System.Type
                delegateType)
                {
                    var return_v = MakeRunDelegateCtor(delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 2791, 2824);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1509, 2423, 2851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1509, 2423, 2851);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Func<LightLambda, Delegate> MakeRunDelegateCtor(Type delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1509, 2863, 6521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 2969, 3015);

                var
                method = f_1509_2982_3014(delegateType, "Invoke")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 3029, 3069);

                var
                paramInfos = f_1509_3046_3068(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 3083, 3101);

                Type[]
                paramTypes
                = default(Type[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 3115, 3135);

                string
                name = "Run"
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 3151, 3250) || true) && (f_1509_3155_3172(paramInfos) >= MaxParameters)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 3151, 3250);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 3223, 3235);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 3151, 3250);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 3266, 3609) || true) && (f_1509_3270_3287(method) == typeof(void))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 3266, 3609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 3337, 3352);

                    name += "Void";
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 3370, 3411);

                    paramTypes = new Type[f_1509_3392_3409(paramInfos)];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 3266, 3609);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 3266, 3609);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 3477, 3522);

                    paramTypes = new Type[f_1509_3499_3516(paramInfos) + 1];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 3540, 3594);

                    paramTypes[f_1509_3551_3568(paramTypes) - 1] = f_1509_3576_3593(method);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 3266, 3609);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 3625, 3646);

                MethodInfo
                runMethod
                = default(MethodInfo);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 3662, 5336) || true) && (f_1509_3666_3683(method) == typeof(void) && (DynAbs.Tracing.TraceSender.Expression_True(1509, 3666, 3725) && f_1509_3703_3720(paramTypes) == 2) && (DynAbs.Tracing.TraceSender.Expression_True(1509, 3666, 3781) && f_1509_3746_3781(f_1509_3746_3773(paramInfos[0]))) && (DynAbs.Tracing.TraceSender.Expression_True(1509, 3666, 3820) && f_1509_3785_3820(f_1509_3785_3812(paramInfos[1]))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 3662, 5336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 3854, 3959);

                    runMethod = f_1509_3866_3958(typeof(LightLambda), "RunVoidRef2", BindingFlags.NonPublic | BindingFlags.Instance);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 3977, 4038);

                    paramTypes[0] = f_1509_3993_4037(f_1509_3993_4020(paramInfos[0]));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 4056, 4117);

                    paramTypes[1] = f_1509_4072_4116(f_1509_4072_4099(paramInfos[1]));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 3662, 5336);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 3662, 5336);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 4151, 5336) || true) && (f_1509_4155_4172(method) == typeof(void) && (DynAbs.Tracing.TraceSender.Expression_True(1509, 4155, 4214) && f_1509_4192_4209(paramTypes) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 4151, 5336);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 4248, 4350);

                        runMethod = f_1509_4260_4349(typeof(LightLambda), "RunVoid0", BindingFlags.NonPublic | BindingFlags.Instance);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 4151, 5336);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 4151, 5336);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 4425, 4430);
                            for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 4416, 4695) || true) && (i < f_1509_4436_4453(paramInfos))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 4455, 4458)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 4416, 4695))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 4416, 4695);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 4500, 4544);

                                paramTypes[i] = f_1509_4516_4543(paramInfos[i]);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 4566, 4676) || true) && (f_1509_4570_4591(paramTypes[i]))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 4566, 4676);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 4641, 4653);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 4566, 4676);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1509, 1, 280);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1509, 1, 280);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 4715, 5185) || true) && (f_1509_4719_4759(paramTypes) == delegateType)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 4715, 5185);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 4817, 4858);

                            name = "Make" + name + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_1509_4840_4857(paramInfos)).ToString(), 1509, 4840, 4857);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 4882, 5018);

                            MethodInfo
                            ctorMethod = f_1509_4906_5017(f_1509_4906_4987(typeof(LightLambda), name, BindingFlags.NonPublic | BindingFlags.Static), paramTypes)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 5040, 5166);

                            return s_runCache[delegateType] = (Func<LightLambda, Delegate>)f_1509_5103_5165(ctorMethod, typeof(Func<LightLambda, Delegate>));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 4715, 5185);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 5205, 5321);

                        runMethod = f_1509_5217_5320(typeof(LightLambda), name + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_1509_5254_5271(paramInfos)).ToString(), 1509, 5254, 5271), BindingFlags.NonPublic | BindingFlags.Instance);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 4151, 5336);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 3662, 5336);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 5406, 5531);

                    DynamicMethod
                    dm = f_1509_5425_5530("FastCtor", typeof(Delegate), new[] { typeof(LightLambda) }, typeof(LightLambda), true)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 5549, 5581);

                    var
                    ilgen = f_1509_5561_5580(dm)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 5599, 5627);

                    f_1509_5599_5626(ilgen, OpCodes.Ldarg_0);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 5645, 5762);

                    f_1509_5645_5761(ilgen, OpCodes.Ldftn, (DynAbs.Tracing.TraceSender.Conditional_F1(1509, 5671, 5706) || ((f_1509_5671_5706(runMethod) && DynAbs.Tracing.TraceSender.Conditional_F2(1509, 5709, 5748)) || DynAbs.Tracing.TraceSender.Conditional_F3(1509, 5751, 5760))) ? f_1509_5709_5748(runMethod, paramTypes) : runMethod);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 5780, 5878);

                    f_1509_5780_5877(ilgen, OpCodes.Newobj, f_1509_5807_5876(delegateType, new[] { typeof(object), typeof(IntPtr) }));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 5896, 5920);

                    f_1509_5896_5919(ilgen, OpCodes.Ret);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 5938, 6056);

                    return s_runCache[delegateType] = (Func<LightLambda, Delegate>)f_1509_6001_6055(dm, typeof(Func<LightLambda, Delegate>));
                }
                catch (SecurityException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1509, 6085, 6140);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1509, 6085, 6140);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 6293, 6402);

                var
                targetMethod = (DynAbs.Tracing.TraceSender.Conditional_F1(1509, 6312, 6347) || ((f_1509_6312_6347(runMethod) && DynAbs.Tracing.TraceSender.Conditional_F2(1509, 6350, 6389)) || DynAbs.Tracing.TraceSender.Conditional_F3(1509, 6392, 6401))) ? f_1509_6350_6389(runMethod, paramTypes) : runMethod
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 6416, 6510);

                return s_runCache[delegateType] = lambda => targetMethod.CreateDelegate(delegateType, lambda);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1509, 2863, 6521);

                System.Reflection.MethodInfo?
                f_1509_2982_3014(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetMethod(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 2982, 3014);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_1509_3046_3068(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 3046, 3068);
                    return return_v;
                }


                int
                f_1509_3155_3172(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 3155, 3172);
                    return return_v;
                }


                System.Type
                f_1509_3270_3287(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 3270, 3287);
                    return return_v;
                }


                int
                f_1509_3392_3409(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 3392, 3409);
                    return return_v;
                }


                int
                f_1509_3499_3516(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 3499, 3516);
                    return return_v;
                }


                int
                f_1509_3551_3568(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 3551, 3568);
                    return return_v;
                }


                System.Type
                f_1509_3576_3593(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 3576, 3593);
                    return return_v;
                }


                System.Type
                f_1509_3666_3683(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 3666, 3683);
                    return return_v;
                }


                int
                f_1509_3703_3720(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 3703, 3720);
                    return return_v;
                }


                System.Type
                f_1509_3746_3773(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 3746, 3773);
                    return return_v;
                }


                bool
                f_1509_3746_3781(System.Type
                this_param)
                {
                    var return_v = this_param.IsByRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 3746, 3781);
                    return return_v;
                }


                System.Type
                f_1509_3785_3812(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 3785, 3812);
                    return return_v;
                }


                bool
                f_1509_3785_3820(System.Type
                this_param)
                {
                    var return_v = this_param.IsByRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 3785, 3820);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1509_3866_3958(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 3866, 3958);
                    return return_v;
                }


                System.Type
                f_1509_3993_4020(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 3993, 4020);
                    return return_v;
                }


                System.Type?
                f_1509_3993_4037(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 3993, 4037);
                    return return_v;
                }


                System.Type
                f_1509_4072_4099(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 4072, 4099);
                    return return_v;
                }


                System.Type?
                f_1509_4072_4116(System.Type
                this_param)
                {
                    var return_v = this_param.GetElementType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 4072, 4116);
                    return return_v;
                }


                System.Type
                f_1509_4155_4172(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 4155, 4172);
                    return return_v;
                }


                int
                f_1509_4192_4209(System.Type[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 4192, 4209);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1509_4260_4349(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 4260, 4349);
                    return return_v;
                }


                int
                f_1509_4436_4453(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 4436, 4453);
                    return return_v;
                }


                System.Type
                f_1509_4516_4543(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 4516, 4543);
                    return return_v;
                }


                bool
                f_1509_4570_4591(System.Type
                this_param)
                {
                    var return_v = this_param.IsByRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 4570, 4591);
                    return return_v;
                }


                System.Type
                f_1509_4719_4759(System.Type[]
                types)
                {
                    var return_v = DelegateHelpers.MakeDelegate(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 4719, 4759);
                    return return_v;
                }


                int
                f_1509_4840_4857(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 4840, 4857);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1509_4906_4987(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 4906, 4987);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1509_4906_5017(System.Reflection.MethodInfo
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericMethod(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 4906, 5017);
                    return return_v;
                }


                System.Delegate
                f_1509_5103_5165(System.Reflection.MethodInfo
                this_param, System.Type
                delegateType)
                {
                    var return_v = this_param.CreateDelegate(delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 5103, 5165);
                    return return_v;
                }


                int
                f_1509_5254_5271(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 5254, 5271);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1509_5217_5320(System.Type
                this_param, string
                name, System.Reflection.BindingFlags
                bindingAttr)
                {
                    var return_v = this_param.GetMethod(name, bindingAttr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 5217, 5320);
                    return return_v;
                }


                System.Reflection.Emit.DynamicMethod
                f_1509_5425_5530(string
                name, System.Type
                returnType, System.Type[]
                parameterTypes, System.Type
                owner, bool
                skipVisibility)
                {
                    var return_v = new System.Reflection.Emit.DynamicMethod(name, returnType, parameterTypes, owner, skipVisibility);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 5425, 5530);
                    return return_v;
                }


                System.Reflection.Emit.ILGenerator
                f_1509_5561_5580(System.Reflection.Emit.DynamicMethod
                this_param)
                {
                    var return_v = this_param.GetILGenerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 5561, 5580);
                    return return_v;
                }


                int
                f_1509_5599_5626(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 5599, 5626);
                    return 0;
                }


                bool
                f_1509_5671_5706(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.IsGenericMethodDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 5671, 5706);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1509_5709_5748(System.Reflection.MethodInfo
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericMethod(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 5709, 5748);
                    return return_v;
                }


                int
                f_1509_5645_5761(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, System.Reflection.MethodInfo
                meth)
                {
                    this_param.Emit(opcode, meth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 5645, 5761);
                    return 0;
                }


                System.Reflection.ConstructorInfo?
                f_1509_5807_5876(System.Type
                this_param, System.Type[]
                types)
                {
                    var return_v = this_param.GetConstructor(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 5807, 5876);
                    return return_v;
                }


                int
                f_1509_5780_5877(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode, System.Reflection.ConstructorInfo
                con)
                {
                    this_param.Emit(opcode, con);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 5780, 5877);
                    return 0;
                }


                int
                f_1509_5896_5919(System.Reflection.Emit.ILGenerator
                this_param, System.Reflection.Emit.OpCode
                opcode)
                {
                    this_param.Emit(opcode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 5896, 5919);
                    return 0;
                }


                System.Delegate
                f_1509_6001_6055(System.Reflection.Emit.DynamicMethod
                this_param, System.Type
                delegateType)
                {
                    var return_v = this_param.CreateDelegate(delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 6001, 6055);
                    return return_v;
                }


                bool
                f_1509_6312_6347(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.IsGenericMethodDefinition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 6312, 6347);
                    return return_v;
                }


                System.Reflection.MethodInfo
                f_1509_6350_6389(System.Reflection.MethodInfo
                this_param, params System.Type[]
                typeArguments)
                {
                    var return_v = this_param.MakeGenericMethod(typeArguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 6350, 6389);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1509, 2863, 6521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1509, 2863, 6521);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Delegate CreateCustomDelegate(Type delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1509, 6591, 7805);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 6787, 6833);

                var
                method = f_1509_6800_6832(delegateType, "Invoke")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 6847, 6887);

                var
                paramInfos = f_1509_6864_6886(method)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 6901, 6961);

                var
                parameters = new ParameterExpression[f_1509_6942_6959(paramInfos)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 6975, 7034);

                var
                parametersAsObject = new Expression[f_1509_7015_7032(paramInfos)]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 7057, 7062);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 7048, 7373) || true) && (i < f_1509_7068_7085(paramInfos))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 7087, 7090)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 7048, 7373))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 7048, 7373);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 7124, 7226);

                        ParameterExpression
                        parameter = f_1509_7156_7225(f_1509_7177_7204(paramInfos[i]), f_1509_7206_7224(paramInfos[i]))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 7244, 7270);

                        parameters[i] = parameter;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 7288, 7358);

                        parametersAsObject[i] = f_1509_7312_7357(parameter, typeof(object));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1509, 1, 326);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1509, 1, 326);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 7389, 7460);

                var
                data = f_1509_7400_7459(typeof(object), parametersAsObject)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 7474, 7509);

                var
                self = f_1509_7485_7508(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 7523, 7576);

                var
                runMethod = f_1509_7539_7575(typeof(LightLambda), "Run")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 7590, 7679);

                var
                body = f_1509_7601_7678(f_1509_7620_7658(self, runMethod, data), f_1509_7660_7677(method))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 7693, 7756);

                var
                lambda = f_1509_7706_7755(delegateType, body, parameters)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 7770, 7794);

                return f_1509_7777_7793(lambda);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1509, 6591, 7805);

                System.Reflection.MethodInfo?
                f_1509_6800_6832(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetMethod(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 6800, 6832);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_1509_6864_6886(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 6864, 6886);
                    return return_v;
                }


                int
                f_1509_6942_6959(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 6942, 6959);
                    return return_v;
                }


                int
                f_1509_7015_7032(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 7015, 7032);
                    return return_v;
                }


                int
                f_1509_7068_7085(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 7068, 7085);
                    return return_v;
                }


                System.Type
                f_1509_7177_7204(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 7177, 7204);
                    return return_v;
                }


                string
                f_1509_7206_7224(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 7206, 7224);
                    return return_v;
                }


                System.Linq.Expressions.ParameterExpression
                f_1509_7156_7225(System.Type
                type, string
                name)
                {
                    var return_v = Expression.Parameter(type, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 7156, 7225);
                    return return_v;
                }


                System.Linq.Expressions.UnaryExpression
                f_1509_7312_7357(System.Linq.Expressions.ParameterExpression
                expression, System.Type
                type)
                {
                    var return_v = Expression.Convert((System.Linq.Expressions.Expression)expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 7312, 7357);
                    return return_v;
                }


                System.Linq.Expressions.NewArrayExpression
                f_1509_7400_7459(System.Type
                type, params System.Linq.Expressions.Expression[]
                initializers)
                {
                    var return_v = Expression.NewArrayInit(type, initializers);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 7400, 7459);
                    return return_v;
                }


                System.Linq.Expressions.Expression
                f_1509_7485_7508(System.Management.Automation.Interpreter.LightLambda
                value)
                {
                    var return_v = AstUtils.Constant((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 7485, 7508);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1509_7539_7575(System.Type
                this_param, string
                name)
                {
                    var return_v = this_param.GetMethod(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 7539, 7575);
                    return return_v;
                }


                System.Linq.Expressions.MethodCallExpression
                f_1509_7620_7658(System.Linq.Expressions.Expression
                instance, System.Reflection.MethodInfo
                method, params System.Linq.Expressions.Expression[]
                arguments)
                {
                    var return_v = Expression.Call(instance, method, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 7620, 7658);
                    return return_v;
                }


                System.Type
                f_1509_7660_7677(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 7660, 7677);
                    return return_v;
                }


                System.Linq.Expressions.UnaryExpression
                f_1509_7601_7678(System.Linq.Expressions.MethodCallExpression
                expression, System.Type
                type)
                {
                    var return_v = Expression.Convert((System.Linq.Expressions.Expression)expression, type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 7601, 7678);
                    return return_v;
                }


                System.Linq.Expressions.LambdaExpression
                f_1509_7706_7755(System.Type
                delegateType, System.Linq.Expressions.UnaryExpression
                body, params System.Linq.Expressions.ParameterExpression[]
                parameters)
                {
                    var return_v = Expression.Lambda(delegateType, (System.Linq.Expressions.Expression)body, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 7706, 7755);
                    return return_v;
                }


                System.Delegate
                f_1509_7777_7793(System.Linq.Expressions.LambdaExpression
                this_param)
                {
                    var return_v = this_param.Compile();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 7777, 7793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1509, 6591, 7805);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1509, 6591, 7805);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Delegate MakeDelegate(Type delegateType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1509, 7817, 8187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 7891, 7963);

                Func<LightLambda, Delegate>
                fastCtor = f_1509_7930_7962(delegateType)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 7977, 8176) || true) && (fastCtor != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 7977, 8176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 8031, 8053);

                    return f_1509_8038_8052(fastCtor, this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 7977, 8176);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 7977, 8176);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 8119, 8161);

                    return f_1509_8126_8160(this, delegateType);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 7977, 8176);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1509, 7817, 8187);

                System.Func<System.Management.Automation.Interpreter.LightLambda, System.Delegate>
                f_1509_7930_7962(System.Type
                delegateType)
                {
                    var return_v = GetRunDelegateCtor(delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 7930, 7962);
                    return return_v;
                }


                System.Delegate
                f_1509_8038_8052(System.Func<System.Management.Automation.Interpreter.LightLambda, System.Delegate>
                this_param, System.Management.Automation.Interpreter.LightLambda
                arg)
                {
                    var return_v = this_param.Invoke(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 8038, 8052);
                    return return_v;
                }


                System.Delegate
                f_1509_8126_8160(System.Management.Automation.Interpreter.LightLambda
                this_param, System.Type
                delegateType)
                {
                    var return_v = this_param.CreateCustomDelegate(delegateType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 8126, 8160);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1509, 7817, 8187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1509, 7817, 8187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool TryGetCompiled()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1509, 8199, 10187);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 8309, 8790) || true) && (f_1509_8313_8341(_delegateCreator))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 8309, 8790);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 8375, 8437);

                    _compiled = f_1509_8387_8436(_delegateCreator, _closure);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 8513, 8540);

                    var
                    compileEvent = Compile
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 8558, 8743) || true) && (compileEvent != null && (DynAbs.Tracing.TraceSender.Expression_True(1509, 8562, 8619) && f_1509_8586_8619(_delegateCreator)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 8558, 8743);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 8661, 8724);

                        f_1509_8661_8723(compileEvent, this, f_1509_8680_8722(_compiled));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 8558, 8743);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 8763, 8775);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 8309, 8790);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 9440, 10147) || true) && (unchecked(_compilationThreshold--) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 9440, 10147);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 9724, 10132) || true) && (f_1509_9728_9761(_interpreter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 9724, 10132);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 9803, 9834);

                        f_1509_9803_9833(_delegateCreator, null);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 9856, 9880);

                        return f_1509_9863_9879(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 9724, 10132);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 9724, 10132);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 10052, 10113);

                        f_1509_10052_10112(_delegateCreator.Compile, null);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 9724, 10132);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 9440, 10147);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 10163, 10176);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1509, 8199, 10187);

                bool
                f_1509_8313_8341(System.Management.Automation.Interpreter.LightDelegateCreator
                this_param)
                {
                    var return_v = this_param.HasCompiled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 8313, 8341);
                    return return_v;
                }


                System.Delegate
                f_1509_8387_8436(System.Management.Automation.Interpreter.LightDelegateCreator
                this_param, System.Runtime.CompilerServices.StrongBox<object>[]
                closure)
                {
                    var return_v = this_param.CreateCompiledDelegate(closure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 8387, 8436);
                    return return_v;
                }


                bool
                f_1509_8586_8619(System.Management.Automation.Interpreter.LightDelegateCreator
                this_param)
                {
                    var return_v = this_param.SameDelegateType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 8586, 8619);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LightLambdaCompileEventArgs
                f_1509_8680_8722(System.Delegate
                compiled)
                {
                    var return_v = new System.Management.Automation.Interpreter.LightLambdaCompileEventArgs(compiled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 8680, 8722);
                    return return_v;
                }


                int
                f_1509_8661_8723(System.EventHandler<System.Management.Automation.Interpreter.LightLambdaCompileEventArgs>
                this_param, System.Management.Automation.Interpreter.LightLambda
                sender, System.Management.Automation.Interpreter.LightLambdaCompileEventArgs
                e)
                {
                    this_param.Invoke((object)sender, e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 8661, 8723);
                    return 0;
                }


                bool
                f_1509_9728_9761(System.Management.Automation.Interpreter.Interpreter
                this_param)
                {
                    var return_v = this_param.CompileSynchronously;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 9728, 9761);
                    return return_v;
                }


                int
                f_1509_9803_9833(System.Management.Automation.Interpreter.LightDelegateCreator
                this_param, object
                state)
                {
                    this_param.Compile(state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 9803, 9833);
                    return 0;
                }


                bool
                f_1509_9863_9879(System.Management.Automation.Interpreter.LightLambda
                this_param)
                {
                    var return_v = this_param.TryGetCompiled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 9863, 9879);
                    return return_v;
                }


                bool
                f_1509_10052_10112(System.Threading.WaitCallback
                callBack, object?
                state)
                {
                    var return_v = ThreadPool.QueueUserWorkItem(callBack, state);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 10052, 10112);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1509, 8199, 10187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1509, 8199, 10187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private InterpretedFrame MakeFrame()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1509, 10199, 10323);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 10260, 10312);

                return f_1509_10267_10311(_interpreter, _closure);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1509, 10199, 10323);

                System.Management.Automation.Interpreter.InterpretedFrame
                f_1509_10267_10311(System.Management.Automation.Interpreter.Interpreter
                interpreter, System.Runtime.CompilerServices.StrongBox<object>[]
                closure)
                {
                    var return_v = new System.Management.Automation.Interpreter.InterpretedFrame(interpreter, closure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 10267, 10311);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1509, 10199, 10323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1509, 10199, 10323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void RunVoidRef2<T0, T1>(ref T0 arg0, ref T1 arg1)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1509, 10335, 11070);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 10648, 10672);

                var
                frame = f_1509_10660_10671(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 10686, 10707);

                frame.Data[0] = arg0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 10721, 10742);

                frame.Data[1] = arg1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 10756, 10789);

                var
                currentFrame = f_1509_10775_10788(frame)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 10839, 10863);

                    f_1509_10839_10862(_interpreter, frame);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1509, 10892, 11059);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 10932, 10958);

                    f_1509_10932_10957(frame, currentFrame);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 10976, 11001);

                    arg0 = (T0)frame.Data[0];
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 11019, 11044);

                    arg1 = (T1)frame.Data[1];
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1509, 10892, 11059);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1509, 10335, 11070);

                System.Management.Automation.Interpreter.InterpretedFrame
                f_1509_10660_10671(System.Management.Automation.Interpreter.LightLambda
                this_param)
                {
                    var return_v = this_param.MakeFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 10660, 10671);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ThreadLocal<System.Management.Automation.Interpreter.InterpretedFrame>.StorageInfo
                f_1509_10775_10788(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Enter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 10775, 10788);
                    return return_v;
                }


                int
                f_1509_10839_10862(System.Management.Automation.Interpreter.Interpreter
                this_param, System.Management.Automation.Interpreter.InterpretedFrame
                frame)
                {
                    this_param.Run(frame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 10839, 10862);
                    return 0;
                }


                int
                f_1509_10932_10957(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, System.Management.Automation.Interpreter.ThreadLocal<System.Management.Automation.Interpreter.InterpretedFrame>.StorageInfo
                currentFrame)
                {
                    this_param.Leave(currentFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 10932, 10957);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1509, 10335, 11070);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1509, 10335, 11070);
            }
        }

        public object Run(params object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1509, 11082, 11735);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 11151, 11283) || true) && (_compiled != null || (DynAbs.Tracing.TraceSender.Expression_False(1509, 11155, 11192) || f_1509_11176_11192(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 11151, 11283);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 11226, 11268);

                    return f_1509_11233_11267(_compiled, arguments);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 11151, 11283);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 11299, 11323);

                var
                frame = f_1509_11311_11322(this)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 11346, 11351);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 11337, 11456) || true) && (i < f_1509_11357_11373(arguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 11375, 11378)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1509, 11337, 11456))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1509, 11337, 11456);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 11412, 11441);

                        frame.Data[i] = arguments[i];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1509, 1, 120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1509, 1, 120);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 11472, 11505);

                var
                currentFrame = f_1509_11491_11504(frame)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 11555, 11579);

                    f_1509_11555_11578(_interpreter, frame);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1509, 11608, 11689);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 11648, 11674);

                    f_1509_11648_11673(frame, currentFrame);
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1509, 11608, 11689);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 11705, 11724);

                return f_1509_11712_11723(frame);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1509, 11082, 11735);

                bool
                f_1509_11176_11192(System.Management.Automation.Interpreter.LightLambda
                this_param)
                {
                    var return_v = this_param.TryGetCompiled();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 11176, 11192);
                    return return_v;
                }


                object?
                f_1509_11233_11267(System.Delegate
                this_param, params object[]
                args)
                {
                    var return_v = this_param.DynamicInvoke(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 11233, 11267);
                    return return_v;
                }


                System.Management.Automation.Interpreter.InterpretedFrame
                f_1509_11311_11322(System.Management.Automation.Interpreter.LightLambda
                this_param)
                {
                    var return_v = this_param.MakeFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 11311, 11322);
                    return return_v;
                }


                int
                f_1509_11357_11373(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 11357, 11373);
                    return return_v;
                }


                System.Management.Automation.Interpreter.ThreadLocal<System.Management.Automation.Interpreter.InterpretedFrame>.StorageInfo
                f_1509_11491_11504(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Enter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 11491, 11504);
                    return return_v;
                }


                int
                f_1509_11555_11578(System.Management.Automation.Interpreter.Interpreter
                this_param, System.Management.Automation.Interpreter.InterpretedFrame
                frame)
                {
                    this_param.Run(frame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 11555, 11578);
                    return 0;
                }


                int
                f_1509_11648_11673(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, System.Management.Automation.Interpreter.ThreadLocal<System.Management.Automation.Interpreter.InterpretedFrame>.StorageInfo
                currentFrame)
                {
                    this_param.Leave(currentFrame);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 11648, 11673);
                    return 0;
                }


                object
                f_1509_11712_11723(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 11712, 11723);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1509, 11082, 11735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1509, 11082, 11735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LightLambda()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1509, 1385, 11742);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1509, 1613, 1679);
            s_runCache = f_1509_1626_1679(100);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1510, 1107, 1125);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1509, 1385, 11742);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1509, 1385, 11742);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1509, 1385, 11742);

        static System.Management.Automation.Interpreter.CacheDict<System.Type, System.Func<System.Management.Automation.Interpreter.LightLambda, System.Delegate>>
        f_1509_1626_1679(int
        maxSize)
        {
            var return_v = new System.Management.Automation.Interpreter.CacheDict<System.Type, System.Func<System.Management.Automation.Interpreter.LightLambda, System.Delegate>>(maxSize);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1509, 1626, 1679);
            return return_v;
        }


        System.Management.Automation.Interpreter.Interpreter
        f_1509_2313_2340(System.Management.Automation.Interpreter.LightDelegateCreator
        this_param)
        {
            var return_v = this_param.Interpreter;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1509, 2313, 2340);
            return return_v;
        }

    }
}
