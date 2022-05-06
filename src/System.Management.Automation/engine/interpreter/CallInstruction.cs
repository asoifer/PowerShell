/* ****************************************************************************
 *
 * Copyright (c) Microsoft Corporation.
 *
 * This source code is subject to terms and conditions of the Apache License, Version 2.0. A
 * copy of the license can be found in the License.html file at the root of this distribution. If
 * you cannot locate the Apache License, Version 2.0, please send an email to
 * ironpy@microsoft.com. By using this source code in any fashion, you are agreeing to be bound
 * by the terms of the Apache License, Version 2.0.
 *
 * You must not remove this notice, or any other, from this software.
 *
 *
 * ***************************************************************************/

using System.Collections.Generic;
using System.Reflection;
using System.Reflection.Emit;

namespace System.Management.Automation.Interpreter
{
    internal abstract partial class CallInstruction : Instruction
    {
        public abstract MethodInfo Info { get; }

        public abstract int ArgumentCount { get; }

        internal CallInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1489, 1210, 1240);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1489, 1210, 1240);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 1210, 1240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 1210, 1240);
            }
        }

        private static readonly Dictionary<MethodInfo, CallInstruction> s_cache;

        public static CallInstruction Create(MethodInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1489, 1384, 1515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 1462, 1504);

                return f_1489_1469_1503(info, f_1489_1482_1502(info));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1489, 1384, 1515);

                System.Reflection.ParameterInfo[]
                f_1489_1482_1502(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.GetParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 1482, 1502);
                    return return_v;
                }


                System.Management.Automation.Interpreter.CallInstruction
                f_1489_1469_1503(System.Reflection.MethodInfo
                info, System.Reflection.ParameterInfo[]
                parameters)
                {
                    var return_v = Create(info, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 1469, 1503);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 1384, 1515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 1384, 1515);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CallInstruction Create(MethodInfo info, ParameterInfo[] parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1489, 1678, 4796);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 1784, 1822);

                int
                argumentCount = f_1489_1804_1821(parameters)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 1836, 1919) || true) && (f_1489_1840_1854_M(!info.IsStatic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 1836, 1919);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 1888, 1904);

                    argumentCount++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 1836, 1919);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 2107, 2307) || true) && (f_1489_2111_2129(info) != null && (DynAbs.Tracing.TraceSender.Expression_True(1489, 2111, 2167) && f_1489_2141_2167(f_1489_2141_2159(info))) && (DynAbs.Tracing.TraceSender.Expression_True(1489, 2111, 2213) && (f_1489_2172_2181(info) == "Get" || (DynAbs.Tracing.TraceSender.Expression_False(1489, 2172, 2212) || f_1489_2194_2203(info) == "Set"))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 2107, 2307);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 2247, 2292);

                    return f_1489_2254_2291(info, argumentCount);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 2107, 2307);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 2323, 2507) || true) && (info is DynamicMethod || (DynAbs.Tracing.TraceSender.Expression_False(1489, 2327, 2400) || f_1489_2352_2366_M(!info.IsStatic) && (DynAbs.Tracing.TraceSender.Expression_True(1489, 2352, 2400) && f_1489_2370_2400(f_1489_2370_2388(info)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 2323, 2507);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 2434, 2492);

                    return f_1489_2441_2491(info, argumentCount);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 2323, 2507);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 2523, 2738) || true) && (argumentCount >= MaxHelpers)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 2523, 2738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 2665, 2723);

                    return f_1489_2672_2722(info, argumentCount);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 2523, 2738);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 2754, 3053);
                    foreach (ParameterInfo pi in f_1489_2783_2793_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 2754, 3053);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 2827, 3038) || true) && (f_1489_2831_2855(f_1489_2831_2847(pi)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 2827, 3038);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 2961, 3019);

                            return f_1489_2968_3018(info, argumentCount);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 2827, 3038);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 2754, 3053);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1489, 1, 300);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1489, 1, 300);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 3124, 3144);

                CallInstruction
                res
                = default(CallInstruction);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 3158, 3424) || true) && (f_1489_3162_3179(info))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 3158, 3424);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 3219, 3226);
                    lock (s_cache)
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 3268, 3390) || true) && (f_1489_3272_3306(s_cache, info, out res))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 3268, 3390);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 3356, 3367);

                            return res;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 3268, 3390);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 3158, 3424);
                }

                // create it
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 3502, 3742) || true) && (argumentCount < MaxArgs)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 3502, 3742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 3571, 3606);

                        res = f_1489_3577_3605(info, parameters);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 3502, 3742);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 3502, 3742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 3688, 3723);

                        res = f_1489_3694_3722(info, parameters);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 3502, 3742);
                    }
                }
                catch (TargetInvocationException tie)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1489, 3771, 4050);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 3841, 3958) || true) && (!(f_1489_3847_3865(tie) is NotSupportedException))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 3841, 3958);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 3933, 3939);

                        throw;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 3841, 3958);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 3978, 4035);

                    res = f_1489_3984_4034(info, argumentCount);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1489, 3771, 4050);
                }
                catch (NotSupportedException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1489, 4064, 4499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 4427, 4484);

                    res = f_1489_4433_4483(info, argumentCount);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1489, 4064, 4499);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 4594, 4758) || true) && (f_1489_4598_4615(info))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 4594, 4758);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 4655, 4662);
                    lock (s_cache)
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 4704, 4724);

                        s_cache[info] = res;
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 4594, 4758);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 4774, 4785);

                return res;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1489, 1678, 4796);

                int
                f_1489_1804_1821(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 1804, 1821);
                    return return_v;
                }


                bool
                f_1489_1840_1854_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 1840, 1854);
                    return return_v;
                }


                System.Type
                f_1489_2111_2129(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 2111, 2129);
                    return return_v;
                }


                System.Type
                f_1489_2141_2159(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 2141, 2159);
                    return return_v;
                }


                bool
                f_1489_2141_2167(System.Type
                this_param)
                {
                    var return_v = this_param.IsArray;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 2141, 2167);
                    return return_v;
                }


                string
                f_1489_2172_2181(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 2172, 2181);
                    return return_v;
                }


                string
                f_1489_2194_2203(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 2194, 2203);
                    return return_v;
                }


                System.Management.Automation.Interpreter.CallInstruction
                f_1489_2254_2291(System.Reflection.MethodInfo
                info, int
                argumentCount)
                {
                    var return_v = GetArrayAccessor(info, argumentCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 2254, 2291);
                    return return_v;
                }


                bool
                f_1489_2352_2366_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 2352, 2366);
                    return return_v;
                }


                System.Type
                f_1489_2370_2388(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 2370, 2388);
                    return return_v;
                }


                bool
                f_1489_2370_2400(System.Type
                this_param)
                {
                    var return_v = this_param.IsValueType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 2370, 2400);
                    return return_v;
                }


                System.Management.Automation.Interpreter.MethodInfoCallInstruction
                f_1489_2441_2491(System.Reflection.MethodInfo
                target, int
                argumentCount)
                {
                    var return_v = new System.Management.Automation.Interpreter.MethodInfoCallInstruction(target, argumentCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 2441, 2491);
                    return return_v;
                }


                System.Management.Automation.Interpreter.MethodInfoCallInstruction
                f_1489_2672_2722(System.Reflection.MethodInfo
                target, int
                argumentCount)
                {
                    var return_v = new System.Management.Automation.Interpreter.MethodInfoCallInstruction(target, argumentCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 2672, 2722);
                    return return_v;
                }


                System.Type
                f_1489_2831_2847(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 2831, 2847);
                    return return_v;
                }


                bool
                f_1489_2831_2855(System.Type
                this_param)
                {
                    var return_v = this_param.IsByRef;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 2831, 2855);
                    return return_v;
                }


                System.Management.Automation.Interpreter.MethodInfoCallInstruction
                f_1489_2968_3018(System.Reflection.MethodInfo
                target, int
                argumentCount)
                {
                    var return_v = new System.Management.Automation.Interpreter.MethodInfoCallInstruction(target, argumentCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 2968, 3018);
                    return return_v;
                }


                System.Reflection.ParameterInfo[]
                f_1489_2783_2793_I(System.Reflection.ParameterInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 2783, 2793);
                    return return_v;
                }


                bool
                f_1489_3162_3179(System.Reflection.MethodInfo
                info)
                {
                    var return_v = ShouldCache(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 3162, 3179);
                    return return_v;
                }


                bool
                f_1489_3272_3306(System.Collections.Generic.Dictionary<System.Reflection.MethodInfo, System.Management.Automation.Interpreter.CallInstruction>
                this_param, System.Reflection.MethodInfo
                key, out System.Management.Automation.Interpreter.CallInstruction
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 3272, 3306);
                    return return_v;
                }


                System.Management.Automation.Interpreter.CallInstruction
                f_1489_3577_3605(System.Reflection.MethodInfo
                target, System.Reflection.ParameterInfo[]
                pi)
                {
                    var return_v = FastCreate(target, pi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 3577, 3605);
                    return return_v;
                }


                System.Management.Automation.Interpreter.CallInstruction
                f_1489_3694_3722(System.Reflection.MethodInfo
                info, System.Reflection.ParameterInfo[]
                pis)
                {
                    var return_v = SlowCreate(info, pis);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 3694, 3722);
                    return return_v;
                }


                System.Exception
                f_1489_3847_3865(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 3847, 3865);
                    return return_v;
                }


                System.Management.Automation.Interpreter.MethodInfoCallInstruction
                f_1489_3984_4034(System.Reflection.MethodInfo
                target, int
                argumentCount)
                {
                    var return_v = new System.Management.Automation.Interpreter.MethodInfoCallInstruction(target, argumentCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 3984, 4034);
                    return return_v;
                }


                System.Management.Automation.Interpreter.MethodInfoCallInstruction
                f_1489_4433_4483(System.Reflection.MethodInfo
                target, int
                argumentCount)
                {
                    var return_v = new System.Management.Automation.Interpreter.MethodInfoCallInstruction(target, argumentCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 4433, 4483);
                    return return_v;
                }


                bool
                f_1489_4598_4615(System.Reflection.MethodInfo
                info)
                {
                    var return_v = ShouldCache(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 4598, 4615);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 1678, 4796);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 1678, 4796);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CallInstruction GetArrayAccessor(MethodInfo info, int argumentCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1489, 4808, 6056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 4916, 4952);

                Type
                arrayType = f_1489_4933_4951(info)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 4966, 5001);

                bool
                isGetter = f_1489_4982_4991(info) == "Get"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 5015, 6045);

                switch (f_1489_5023_5047(arrayType))
                {

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 5015, 6045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 5110, 5330);

                        return f_1489_5117_5329((DynAbs.Tracing.TraceSender.Conditional_F1(1489, 5124, 5132) || ((isGetter && DynAbs.Tracing.TraceSender.Conditional_F2(1489, 5160, 5214)) || DynAbs.Tracing.TraceSender.Conditional_F3(1489, 5242, 5306))) ? f_1489_5160_5214(arrayType, "GetValue", new[] { typeof(int) }) : f_1489_5242_5306(new Action<Array, int, object>(ArrayItemSetter1)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 5015, 6045);

                    case 2:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 5015, 6045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 5379, 5617);

                        return f_1489_5386_5616((DynAbs.Tracing.TraceSender.Conditional_F1(1489, 5393, 5401) || ((isGetter && DynAbs.Tracing.TraceSender.Conditional_F2(1489, 5429, 5496)) || DynAbs.Tracing.TraceSender.Conditional_F3(1489, 5524, 5593))) ? f_1489_5429_5496(arrayType, "GetValue", new[] { typeof(int), typeof(int) }) : f_1489_5524_5593(new Action<Array, int, int, object>(ArrayItemSetter2)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 5015, 6045);

                    case 3:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 5015, 6045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 5666, 5922);

                        return f_1489_5673_5921((DynAbs.Tracing.TraceSender.Conditional_F1(1489, 5680, 5688) || ((isGetter && DynAbs.Tracing.TraceSender.Conditional_F2(1489, 5716, 5796)) || DynAbs.Tracing.TraceSender.Conditional_F3(1489, 5824, 5898))) ? f_1489_5716_5796(arrayType, "GetValue", new[] { typeof(int), typeof(int), typeof(int) }) : f_1489_5824_5898(new Action<Array, int, int, int, object>(ArrayItemSetter3)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 5015, 6045);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 5015, 6045);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 5972, 6030);

                        return f_1489_5979_6029(info, argumentCount);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 5015, 6045);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1489, 4808, 6056);

                System.Type
                f_1489_4933_4951(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 4933, 4951);
                    return return_v;
                }


                string
                f_1489_4982_4991(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 4982, 4991);
                    return return_v;
                }


                int
                f_1489_5023_5047(System.Type
                this_param)
                {
                    var return_v = this_param.GetArrayRank();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 5023, 5047);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1489_5160_5214(System.Type
                this_param, string
                name, System.Type[]
                types)
                {
                    var return_v = this_param.GetMethod(name, types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 5160, 5214);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1489_5242_5306(System.Action<System.Array, int, object>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 5242, 5306);
                    return return_v;
                }


                System.Management.Automation.Interpreter.CallInstruction
                f_1489_5117_5329(System.Reflection.MethodInfo
                info)
                {
                    var return_v = Create(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 5117, 5329);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1489_5429_5496(System.Type
                this_param, string
                name, System.Type[]
                types)
                {
                    var return_v = this_param.GetMethod(name, types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 5429, 5496);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1489_5524_5593(System.Action<System.Array, int, int, object>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 5524, 5593);
                    return return_v;
                }


                System.Management.Automation.Interpreter.CallInstruction
                f_1489_5386_5616(System.Reflection.MethodInfo
                info)
                {
                    var return_v = Create(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 5386, 5616);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1489_5716_5796(System.Type
                this_param, string
                name, System.Type[]
                types)
                {
                    var return_v = this_param.GetMethod(name, types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 5716, 5796);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1489_5824_5898(System.Action<System.Array, int, int, int, object>
                del)
                {
                    var return_v = del.GetMethodInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 5824, 5898);
                    return return_v;
                }


                System.Management.Automation.Interpreter.CallInstruction
                f_1489_5673_5921(System.Reflection.MethodInfo
                info)
                {
                    var return_v = Create(info);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 5673, 5921);
                    return return_v;
                }


                System.Management.Automation.Interpreter.MethodInfoCallInstruction
                f_1489_5979_6029(System.Reflection.MethodInfo
                target, int
                argumentCount)
                {
                    var return_v = new System.Management.Automation.Interpreter.MethodInfoCallInstruction(target, argumentCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 5979, 6029);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 4808, 6056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 4808, 6056);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static void ArrayItemSetter1(Array array, int index0, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1489, 6068, 6208);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 6167, 6197);

                f_1489_6167_6196(array, value, index0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1489, 6068, 6208);

                int
                f_1489_6167_6196(System.Array
                this_param, object
                value, int
                index)
                {
                    this_param.SetValue(value, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 6167, 6196);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 6068, 6208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 6068, 6208);
            }
        }

        public static void ArrayItemSetter2(Array array, int index0, int index1, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1489, 6220, 6380);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 6331, 6369);

                f_1489_6331_6368(array, value, index0, index1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1489, 6220, 6380);

                int
                f_1489_6331_6368(System.Array
                this_param, object
                value, int
                index1, int
                index2)
                {
                    this_param.SetValue(value, index1, index2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 6331, 6368);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 6220, 6380);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 6220, 6380);
            }
        }

        public static void ArrayItemSetter3(Array array, int index0, int index1, int index2, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1489, 6392, 6572);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 6515, 6561);

                f_1489_6515_6560(array, value, index0, index1, index2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1489, 6392, 6572);

                int
                f_1489_6515_6560(System.Array
                this_param, object
                value, int
                index1, int
                index2, int
                index3)
                {
                    this_param.SetValue(value, index1, index2, index3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 6515, 6560);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 6392, 6572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 6392, 6572);
            }
        }

        private static bool ShouldCache(MethodInfo info)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1489, 6584, 6700);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 6657, 6689);

                return !(info is DynamicMethod);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1489, 6584, 6700);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 6584, 6700);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 6584, 6700);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Type TryGetParameterOrReturnType(MethodInfo target, ParameterInfo[] pi, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1489, 6831, 7587);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 6953, 7150) || true) && (f_1489_6957_6973_M(!target.IsStatic))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 6953, 7150);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 7007, 7015);

                    index--;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 7033, 7135) || true) && (index < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 7033, 7135);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 7088, 7116);

                        return f_1489_7095_7115(target);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 7033, 7135);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 6953, 7150);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 7166, 7305) || true) && (index < f_1489_7178_7187(pi))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 7166, 7305);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 7259, 7290);

                    return f_1489_7266_7289(pi[index]);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 7166, 7305);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 7321, 7479) || true) && (f_1489_7325_7342(target) == typeof(void) || (DynAbs.Tracing.TraceSender.Expression_False(1489, 7325, 7379) || index > f_1489_7370_7379(pi)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 7321, 7479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 7452, 7464);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 7321, 7479);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 7551, 7576);

                return f_1489_7558_7575(target);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1489, 6831, 7587);

                bool
                f_1489_6957_6973_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 6957, 6973);
                    return return_v;
                }


                System.Type
                f_1489_7095_7115(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 7095, 7115);
                    return return_v;
                }


                int
                f_1489_7178_7187(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 7178, 7187);
                    return return_v;
                }


                System.Type
                f_1489_7266_7289(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 7266, 7289);
                    return return_v;
                }


                System.Type
                f_1489_7325_7342(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 7325, 7342);
                    return return_v;
                }


                int
                f_1489_7370_7379(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 7370, 7379);
                    return return_v;
                }


                System.Type
                f_1489_7558_7575(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 7558, 7575);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 6831, 7587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 6831, 7587);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IndexIsNotReturnType(int index, MethodInfo target, ParameterInfo[] pi)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1489, 7599, 7771);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 7714, 7760);

                return f_1489_7721_7730(pi) != index || (DynAbs.Tracing.TraceSender.Expression_False(1489, 7721, 7759) || f_1489_7743_7759_M(!target.IsStatic));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1489, 7599, 7771);

                int
                f_1489_7721_7730(System.Reflection.ParameterInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 7721, 7730);
                    return return_v;
                }


                bool
                f_1489_7743_7759_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 7743, 7759);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 7599, 7771);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 7599, 7771);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CallInstruction SlowCreate(MethodInfo info, ParameterInfo[] pis)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1489, 7918, 8535);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 8022, 8058);

                List<Type>
                types = f_1489_8041_8057()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 8072, 8122) || true) && (f_1489_8076_8090_M(!info.IsStatic))
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 8072, 8122);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 8092, 8122);

                    f_1489_8092_8121(types, f_1489_8102_8120(info));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 8072, 8122);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 8136, 8245);
                    foreach (ParameterInfo pi in f_1489_8165_8168_I(pis))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 8136, 8245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 8202, 8230);

                        f_1489_8202_8229(types, f_1489_8212_8228(pi));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 8136, 8245);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1489, 1, 110);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1489, 1, 110);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 8261, 8372) || true) && (f_1489_8265_8280(info) != typeof(void))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 8261, 8372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 8330, 8357);

                    f_1489_8330_8356(types, f_1489_8340_8355(info));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 8261, 8372);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 8388, 8422);

                Type[]
                arrTypes = f_1489_8406_8421(types)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 8438, 8524);

                return (CallInstruction)f_1489_8462_8523(f_1489_8487_8516(info, arrTypes), info);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1489, 7918, 8535);

                System.Collections.Generic.List<System.Type>
                f_1489_8041_8057()
                {
                    var return_v = new System.Collections.Generic.List<System.Type>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 8041, 8057);
                    return return_v;
                }


                bool
                f_1489_8076_8090_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 8076, 8090);
                    return return_v;
                }


                System.Type
                f_1489_8102_8120(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 8102, 8120);
                    return return_v;
                }


                int
                f_1489_8092_8121(System.Collections.Generic.List<System.Type>
                this_param, System.Type
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 8092, 8121);
                    return 0;
                }


                System.Type
                f_1489_8212_8228(System.Reflection.ParameterInfo
                this_param)
                {
                    var return_v = this_param.ParameterType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 8212, 8228);
                    return return_v;
                }


                int
                f_1489_8202_8229(System.Collections.Generic.List<System.Type>
                this_param, System.Type
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 8202, 8229);
                    return 0;
                }


                System.Reflection.ParameterInfo[]
                f_1489_8165_8168_I(System.Reflection.ParameterInfo[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 8165, 8168);
                    return return_v;
                }


                System.Type
                f_1489_8265_8280(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 8265, 8280);
                    return return_v;
                }


                System.Type
                f_1489_8340_8355(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 8340, 8355);
                    return return_v;
                }


                int
                f_1489_8330_8356(System.Collections.Generic.List<System.Type>
                this_param, System.Type
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 8330, 8356);
                    return 0;
                }


                System.Type[]
                f_1489_8406_8421(System.Collections.Generic.List<System.Type>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 8406, 8421);
                    return return_v;
                }


                System.Type
                f_1489_8487_8516(System.Reflection.MethodInfo
                info, System.Type[]
                arrTypes)
                {
                    var return_v = GetHelperType(info, arrTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 8487, 8516);
                    return return_v;
                }


                object?
                f_1489_8462_8523(System.Type
                type, params object?[]
                args)
                {
                    var return_v = Activator.CreateInstance(type, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 8462, 8523);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 7918, 8535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 7918, 8535);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1489, 8643, 8698);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 8649, 8696);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1489, 8656, 8687) || ((f_1489_8656_8671(f_1489_8656_8660()) == typeof(void) && DynAbs.Tracing.TraceSender.Conditional_F2(1489, 8690, 8691)) || DynAbs.Tracing.TraceSender.Conditional_F3(1489, 8694, 8695))) ? 0 : 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1489, 8643, 8698);

                    System.Reflection.MethodInfo
                    f_1489_8656_8660()
                    {
                        var return_v = Info;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 8656, 8660);
                        return return_v;
                    }


                    System.Type
                    f_1489_8656_8671(System.Reflection.MethodInfo
                    this_param)
                    {
                        var return_v = this_param.ReturnType;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 8656, 8671);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 8600, 8700);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 8600, 8700);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1489, 8755, 8784);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 8761, 8782);

                    return f_1489_8768_8781();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1489, 8755, 8784);

                    int
                    f_1489_8768_8781()
                    {
                        var return_v = ArgumentCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 8768, 8781);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 8712, 8786);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 8712, 8786);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public sealed override string InstructionName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1489, 8868, 8890);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 8874, 8888);

                    return "Call";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1489, 8868, 8890);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 8798, 8901);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 8798, 8901);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1489, 8913, 9010);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 8971, 8999);

                return "Call(" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (f_1489_8988_8992()).ToString(), 1489, 8988, 8992) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1489, 8913, 9010);

                System.Reflection.MethodInfo
                f_1489_8988_8992()
                {
                    var return_v = Info;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 8988, 8992);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 8913, 9010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 8913, 9010);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CallInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1489, 871, 9039);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 1316, 1371);
            s_cache = f_1489_1326_1371();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 1243, 1258);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1490, 1287, 1298);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1489, 871, 9039);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 871, 9039);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1489, 871, 9039);

        static System.Collections.Generic.Dictionary<System.Reflection.MethodInfo, System.Management.Automation.Interpreter.CallInstruction>
        f_1489_1326_1371()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Reflection.MethodInfo, System.Management.Automation.Interpreter.CallInstruction>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 1326, 1371);
            return return_v;
        }

    }
    internal sealed partial class MethodInfoCallInstruction : CallInstruction
    {
        private readonly MethodInfo _target;

        private readonly int _argumentCount;

        public override MethodInfo Info
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1489, 9265, 9288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 9271, 9286);

                    return _target;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1489, 9265, 9288);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 9231, 9290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 9231, 9290);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ArgumentCount
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1489, 9338, 9368);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 9344, 9366);

                    return _argumentCount;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1489, 9338, 9368);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 9302, 9370);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 9302, 9370);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal MethodInfoCallInstruction(MethodInfo target, int argumentCount)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1489, 9382, 9552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 9165, 9172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 9204, 9218);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 9479, 9496);

                _target = target;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 9510, 9541);

                _argumentCount = argumentCount;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1489, 9382, 9552);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 9382, 9552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 9382, 9552);
            }
        }

        public override object Invoke(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1489, 9564, 9677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 9640, 9666);

                return f_1489_9647_9665(this, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1489, 9564, 9677);

                object
                f_1489_9647_9665(System.Management.Automation.Interpreter.MethodInfoCallInstruction
                this_param, params object[]
                args)
                {
                    var return_v = this_param.InvokeWorker(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 9647, 9665);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 9564, 9677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 9564, 9677);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override object InvokeInstance(object instance, params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1489, 9689, 10398);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 9790, 10127) || true) && (f_1489_9794_9810(_target))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 9790, 10127);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 9888, 9922);

                        return f_1489_9895_9921(_target, null, args);
                    }
                    catch (TargetInvocationException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1489, 9959, 10112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 10035, 10093);

                        throw f_1489_10041_10092(f_1489_10075_10091(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1489, 9959, 10112);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 9790, 10127);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 10179, 10217);

                    return f_1489_10186_10216(_target, instance, args);
                }
                catch (TargetInvocationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1489, 10246, 10387);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 10314, 10372);

                    throw f_1489_10320_10371(f_1489_10354_10370(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1489, 10246, 10387);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1489, 9689, 10398);

                bool
                f_1489_9794_9810(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 9794, 9810);
                    return return_v;
                }


                object?
                f_1489_9895_9921(System.Reflection.MethodInfo
                this_param, object?
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 9895, 9921);
                    return return_v;
                }


                System.Exception
                f_1489_10075_10091(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 10075, 10091);
                    return return_v;
                }


                System.Exception
                f_1489_10041_10092(System.Exception
                rethrow)
                {
                    var return_v = ExceptionHelpers.UpdateForRethrow(rethrow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 10041, 10092);
                    return return_v;
                }


                object?
                f_1489_10186_10216(System.Reflection.MethodInfo
                this_param, object
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 10186, 10216);
                    return return_v;
                }


                System.Exception
                f_1489_10354_10370(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 10354, 10370);
                    return return_v;
                }


                System.Exception
                f_1489_10320_10371(System.Exception
                rethrow)
                {
                    var return_v = ExceptionHelpers.UpdateForRethrow(rethrow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 10320, 10371);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 9689, 10398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 9689, 10398);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private object InvokeWorker(params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1489, 10410, 11109);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 10484, 10821) || true) && (f_1489_10488_10504(_target))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 10484, 10821);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 10582, 10616);

                        return f_1489_10589_10615(_target, null, args);
                    }
                    catch (TargetInvocationException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1489, 10653, 10806);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 10729, 10787);

                        throw f_1489_10735_10786(f_1489_10769_10785(e));
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1489, 10653, 10806);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 10484, 10821);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 10873, 10928);

                    return f_1489_10880_10927(_target, args[0], f_1489_10904_10926(args));
                }
                catch (TargetInvocationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1489, 10957, 11098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11025, 11083);

                    throw f_1489_11031_11082(f_1489_11065_11081(e));
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1489, 10957, 11098);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1489, 10410, 11109);

                bool
                f_1489_10488_10504(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.IsStatic;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 10488, 10504);
                    return return_v;
                }


                object?
                f_1489_10589_10615(System.Reflection.MethodInfo
                this_param, object?
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 10589, 10615);
                    return return_v;
                }


                System.Exception
                f_1489_10769_10785(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 10769, 10785);
                    return return_v;
                }


                System.Exception
                f_1489_10735_10786(System.Exception
                rethrow)
                {
                    var return_v = ExceptionHelpers.UpdateForRethrow(rethrow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 10735, 10786);
                    return return_v;
                }


                object[]
                f_1489_10904_10926(object[]
                args)
                {
                    var return_v = GetNonStaticArgs(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 10904, 10926);
                    return return_v;
                }


                object?
                f_1489_10880_10927(System.Reflection.MethodInfo
                this_param, object
                obj, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(obj, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 10880, 10927);
                    return return_v;
                }


                System.Exception
                f_1489_11065_11081(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 11065, 11081);
                    return return_v;
                }


                System.Exception
                f_1489_11031_11082(System.Exception
                rethrow)
                {
                    var return_v = ExceptionHelpers.UpdateForRethrow(rethrow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 11031, 11082);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 10410, 11109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 10410, 11109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object[] GetNonStaticArgs(object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1489, 11121, 11417);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11201, 11248);

                object[]
                newArgs = new object[f_1489_11231_11242(args) - 1]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11271, 11276);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11262, 11375) || true) && (i < f_1489_11282_11296(newArgs))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11298, 11301)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 11262, 11375))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 11262, 11375);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11335, 11360);

                        newArgs[i] = args[i + 1];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1489, 1, 114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1489, 1, 114);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11391, 11406);

                return newArgs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1489, 11121, 11417);

                int
                f_1489_11231_11242(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 11231, 11242);
                    return return_v;
                }


                int
                f_1489_11282_11296(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 11282, 11296);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 11121, 11417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 11121, 11417);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public sealed override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1489, 11429, 12083);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11508, 11554);

                int
                first = frame.StackIndex - _argumentCount
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11568, 11611);

                object[]
                args = new object[_argumentCount]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11634, 11639);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11625, 11742) || true) && (i < f_1489_11645_11656(args))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11658, 11661)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 11625, 11742))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 11625, 11742);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11695, 11727);

                        args[i] = frame.Data[first + i];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1489, 1, 118);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1489, 1, 118);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11758, 11784);

                object
                ret = f_1489_11771_11783(this, args)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11798, 12047) || true) && (f_1489_11802_11820(_target) != typeof(void))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 11798, 12047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11870, 11894);

                    frame.Data[first] = ret;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 11912, 11941);

                    frame.StackIndex = first + 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 11798, 12047);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1489, 11798, 12047);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 12007, 12032);

                    frame.StackIndex = first;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1489, 11798, 12047);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1489, 12063, 12072);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1489, 11429, 12083);

                int
                f_1489_11645_11656(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 11645, 11656);
                    return return_v;
                }


                object
                f_1489_11771_11783(System.Management.Automation.Interpreter.MethodInfoCallInstruction
                this_param, params object[]
                args)
                {
                    var return_v = this_param.Invoke(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1489, 11771, 11783);
                    return return_v;
                }


                System.Type
                f_1489_11802_11820(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.ReturnType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1489, 11802, 11820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1489, 11429, 12083);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 11429, 12083);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MethodInfoCallInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1489, 9047, 12090);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1489, 9047, 12090);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1489, 9047, 12090);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1489, 9047, 12090);
    }
}
