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

using System.Runtime.CompilerServices;

namespace System.Management.Automation.Interpreter
{
    internal sealed partial class DynamicInstructionN : Instruction
    {
        private readonly CallInstruction _target;

        private readonly object _targetDelegate;

        private readonly CallSite _site;

        private readonly int _argumentCount;

        private readonly bool _isVoid;

        public DynamicInstructionN(Type delegateType, CallSite site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1493, 1127, 1565);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 929, 936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 971, 986);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 1023, 1028);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 1060, 1074);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 1107, 1114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 1212, 1262);

                var
                methodInfo = f_1493_1229_1261(delegateType, "Invoke")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 1276, 1320);

                var
                parameters = f_1493_1293_1319(methodInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 1336, 1393);

                _target = f_1493_1346_1392(methodInfo, parameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 1407, 1420);

                _site = site;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 1434, 1473);

                _argumentCount = f_1493_1451_1468(parameters) - 1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 1487, 1554);

                _targetDelegate = f_1493_1505_1553(f_1493_1505_1538(f_1493_1505_1519(site), "Target"), site);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1493, 1127, 1565);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1493, 1127, 1565);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1493, 1127, 1565);
            }
        }

        public DynamicInstructionN(Type delegateType, CallSite site, bool isVoid)
        : this(f_1493_1671_1683_C(delegateType), site)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1493, 1577, 1743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 1715, 1732);

                _isVoid = isVoid;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1493, 1577, 1743);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1493, 1577, 1743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1493, 1577, 1743);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1493, 1791, 1822);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 1797, 1820);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1493, 1804, 1811) || ((_isVoid && DynAbs.Tracing.TraceSender.Conditional_F2(1493, 1814, 1815)) || DynAbs.Tracing.TraceSender.Conditional_F3(1493, 1818, 1819))) ? 0 : 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1493, 1791, 1822);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1493, 1755, 1824);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1493, 1755, 1824);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1493, 1872, 1902);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 1878, 1900);

                    return _argumentCount;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1493, 1872, 1902);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1493, 1836, 1904);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1493, 1836, 1904);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1493, 1916, 2610);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 1988, 2034);

                int
                first = frame.StackIndex - _argumentCount
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 2048, 2095);

                object[]
                args = new object[1 + _argumentCount]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 2109, 2125);

                args[0] = _site;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 2148, 2153);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 2139, 2263) || true) && (i < _argumentCount)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 2175, 2178)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1493, 2139, 2263))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1493, 2139, 2263);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 2212, 2248);

                        args[1 + i] = frame.Data[first + i];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1493, 1, 125);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1493, 1, 125);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 2279, 2338);

                object
                ret = f_1493_2292_2337(_target, _targetDelegate, args)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 2352, 2574) || true) && (_isVoid)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1493, 2352, 2574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 2397, 2422);

                    frame.StackIndex = first;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1493, 2352, 2574);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1493, 2352, 2574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 2488, 2512);

                    frame.Data[first] = ret;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 2530, 2559);

                    frame.StackIndex = first + 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1493, 2352, 2574);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 2590, 2599);

                return 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1493, 1916, 2610);

                object
                f_1493_2292_2337(System.Management.Automation.Interpreter.CallInstruction
                this_param, object
                instance, params object[]
                args)
                {
                    var return_v = this_param.InvokeInstance(instance, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1493, 2292, 2337);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1493, 1916, 2610);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1493, 1916, 2610);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1493, 2622, 2735);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1493, 2680, 2724);

                return "DynamicInstructionN(" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_site).ToString(), 1493, 2712, 2717) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1493, 2622, 2735);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1493, 2622, 2735);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1493, 2622, 2735);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DynamicInstructionN()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1493, 816, 2742);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1493, 816, 2742);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1493, 816, 2742);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1493, 816, 2742);

        System.Reflection.MethodInfo?
        f_1493_1229_1261(System.Type
        this_param, string
        name)
        {
            var return_v = this_param.GetMethod(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1493, 1229, 1261);
            return return_v;
        }


        System.Reflection.ParameterInfo[]
        f_1493_1293_1319(System.Reflection.MethodInfo
        this_param)
        {
            var return_v = this_param.GetParameters();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1493, 1293, 1319);
            return return_v;
        }


        System.Management.Automation.Interpreter.CallInstruction
        f_1493_1346_1392(System.Reflection.MethodInfo
        info, System.Reflection.ParameterInfo[]
        parameters)
        {
            var return_v = CallInstruction.Create(info, parameters);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1493, 1346, 1392);
            return return_v;
        }


        int
        f_1493_1451_1468(System.Reflection.ParameterInfo[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1493, 1451, 1468);
            return return_v;
        }


        System.Type
        f_1493_1505_1519(System.Runtime.CompilerServices.CallSite
        this_param)
        {
            var return_v = this_param.GetType();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1493, 1505, 1519);
            return return_v;
        }


        System.Reflection.FieldInfo?
        f_1493_1505_1538(System.Type
        this_param, string
        name)
        {
            var return_v = this_param.GetField(name);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1493, 1505, 1538);
            return return_v;
        }


        object?
        f_1493_1505_1553(System.Reflection.FieldInfo
        this_param, System.Runtime.CompilerServices.CallSite
        obj)
        {
            var return_v = this_param.GetValue((object)obj);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1493, 1505, 1553);
            return return_v;
        }


        static System.Type
        f_1493_1671_1683_C(System.Type
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1493, 1577, 1743);
            return return_v;
        }

    }
}
