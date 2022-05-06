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

using System.Reflection;
using System.Runtime.CompilerServices;

namespace System.Management.Automation.Interpreter
{
    internal sealed class CreateDelegateInstruction : Instruction
    {
        private readonly LightDelegateCreator _creator;

        internal CreateDelegateInstruction(LightDelegateCreator delegateCreator)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1522, 979, 1114);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 958, 966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 1076, 1103);

                _creator = delegateCreator;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1522, 979, 1114);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 979, 1114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 979, 1114);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 1162, 1210);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 1168, 1208);

                    return f_1522_1175_1207(f_1522_1175_1195(_creator));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 1162, 1210);

                    System.Management.Automation.Interpreter.Interpreter
                    f_1522_1175_1195(System.Management.Automation.Interpreter.LightDelegateCreator
                    this_param)
                    {
                        var return_v = this_param.Interpreter;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1522, 1175, 1195);
                        return return_v;
                    }


                    int
                    f_1522_1175_1207(System.Management.Automation.Interpreter.Interpreter
                    this_param)
                    {
                        var return_v = this_param.ClosureSize;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1522, 1175, 1207);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 1126, 1212);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 1126, 1212);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 1260, 1277);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 1266, 1275);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 1260, 1277);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 1224, 1279);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 1224, 1279);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 1291, 1897);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 1363, 1391);

                StrongBox<object>[]
                closure
                = default(StrongBox<object>[]);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 1405, 1770) || true) && (f_1522_1409_1422() > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1522, 1405, 1770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 1460, 1507);

                    closure = new StrongBox<object>[f_1522_1492_1505()];
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 1534, 1556);
                        for (int
        i = f_1522_1538_1552(closure) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 1525, 1674) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 1566, 1569)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(1522, 1525, 1674))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1522, 1525, 1674);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 1611, 1655);

                            closure[i] = (StrongBox<object>)f_1522_1643_1654(frame);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1522, 1, 150);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1522, 1, 150);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1522, 1405, 1770);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1522, 1405, 1770);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 1740, 1755);

                    closure = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1522, 1405, 1770);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 1786, 1832);

                Delegate
                d = f_1522_1799_1831(_creator, closure)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 1848, 1862);

                f_1522_1848_1861(
                            frame, d);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 1876, 1886);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 1291, 1897);

                int
                f_1522_1409_1422()
                {
                    var return_v = ConsumedStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1522, 1409, 1422);
                    return return_v;
                }


                int
                f_1522_1492_1505()
                {
                    var return_v = ConsumedStack;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1522, 1492, 1505);
                    return return_v;
                }


                int
                f_1522_1538_1552(System.Runtime.CompilerServices.StrongBox<object>[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1522, 1538, 1552);
                    return return_v;
                }


                object
                f_1522_1643_1654(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 1643, 1654);
                    return return_v;
                }


                System.Delegate
                f_1522_1799_1831(System.Management.Automation.Interpreter.LightDelegateCreator
                this_param, System.Runtime.CompilerServices.StrongBox<object>[]
                closure)
                {
                    var return_v = this_param.CreateDelegate(closure);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 1799, 1831);
                    return return_v;
                }


                int
                f_1522_1848_1861(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, System.Delegate
                value)
                {
                    this_param.Push((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 1848, 1861);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 1291, 1897);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 1291, 1897);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CreateDelegateInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1522, 842, 1904);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1522, 842, 1904);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 842, 1904);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1522, 842, 1904);
    }
    internal sealed class NewInstruction : Instruction
    {
        private readonly ConstructorInfo _constructor;

        private readonly int _argCount;

        public NewInstruction(ConstructorInfo constructor)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1522, 2078, 2252);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2012, 2024);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2056, 2065);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2153, 2180);

                _constructor = constructor;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2194, 2241);

                _argCount = f_1522_2206_2240(f_1522_2206_2233(constructor));
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1522, 2078, 2252);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 2078, 2252);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 2078, 2252);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 2300, 2325);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2306, 2323);

                    return _argCount;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 2300, 2325);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 2264, 2327);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 2264, 2327);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 2375, 2392);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2381, 2390);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 2375, 2392);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 2339, 2394);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 2339, 2394);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 2406, 3021);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2478, 2516);

                object[]
                args = new object[_argCount]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2539, 2556);
                    for (int
        i = _argCount - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2530, 2640) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2566, 2569)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(1522, 2530, 2640))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1522, 2530, 2640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2603, 2625);

                        args[i] = f_1522_2613_2624(frame);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1522, 1, 111);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1522, 1, 111);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2656, 2667);

                object
                ret
                = default(object);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2717, 2749);

                    ret = f_1522_2723_2748(_constructor, args);
                }
                catch (TargetInvocationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1522, 2778, 2954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2846, 2898);

                    f_1522_2846_2897(f_1522_2880_2896(e));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2916, 2939);

                    throw f_1522_2922_2938(e);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1522, 2778, 2954);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 2970, 2986);

                f_1522_2970_2985(
                            frame, ret);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 3000, 3010);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 2406, 3021);

                object
                f_1522_2613_2624(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 2613, 2624);
                    return return_v;
                }


                object
                f_1522_2723_2748(System.Reflection.ConstructorInfo
                this_param, object[]
                parameters)
                {
                    var return_v = this_param.Invoke(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 2723, 2748);
                    return return_v;
                }


                System.Exception
                f_1522_2880_2896(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1522, 2880, 2896);
                    return return_v;
                }


                System.Exception
                f_1522_2846_2897(System.Exception
                rethrow)
                {
                    var return_v = ExceptionHelpers.UpdateForRethrow(rethrow);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 2846, 2897);
                    return return_v;
                }


                System.Exception
                f_1522_2922_2938(System.Reflection.TargetInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1522, 2922, 2938);
                    return return_v;
                }


                int
                f_1522_2970_2985(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, object
                value)
                {
                    this_param.Push(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 2970, 2985);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 2406, 3021);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 2406, 3021);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 3033, 3177);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 3091, 3166);

                return "New " + f_1522_3107_3138(f_1522_3107_3133(_constructor)) + "(" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_constructor).ToString(), 1522, 3147, 3159) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 3033, 3177);

                System.Type
                f_1522_3107_3133(System.Reflection.ConstructorInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1522, 3107, 3133);
                    return return_v;
                }


                string
                f_1522_3107_3138(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1522, 3107, 3138);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 3033, 3177);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 3033, 3177);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NewInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1522, 1912, 3184);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1522, 1912, 3184);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 1912, 3184);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1522, 1912, 3184);

        System.Reflection.ParameterInfo[]
        f_1522_2206_2233(System.Reflection.ConstructorInfo
        this_param)
        {
            var return_v = this_param.GetParameters();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 2206, 2233);
            return return_v;
        }


        int
        f_1522_2206_2240(System.Reflection.ParameterInfo[]
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1522, 2206, 2240);
            return return_v;
        }

    }
    internal sealed class DefaultValueInstruction<T> : Instruction
    {
        internal DefaultValueInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1522, 3271, 3309);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1522, 3271, 3309);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 3271, 3309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 3271, 3309);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 3357, 3374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 3363, 3372);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 3357, 3374);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 3321, 3376);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 3321, 3376);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 3424, 3441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 3430, 3439);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 3424, 3441);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 3388, 3443);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 3388, 3443);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 3455, 3585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 3527, 3550);

                f_1522_3527_3549(frame, default(T));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 3564, 3574);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 3455, 3585);

                int
                f_1522_3527_3549(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, T
                value)
                {
                    this_param.Push((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 3527, 3549);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 3455, 3585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 3455, 3585);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 3597, 3692);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 3655, 3681);

                return "New " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (typeof(T)).ToString(), 1522, 3671, 3680);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 3597, 3692);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 3597, 3692);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 3597, 3692);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DefaultValueInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1522, 3192, 3699);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1522, 3192, 3699);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 3192, 3699);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1522, 3192, 3699);
    }
    internal sealed class TypeIsInstruction<T> : Instruction
    {
        internal TypeIsInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1522, 3780, 3812);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1522, 3780, 3812);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 3780, 3812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 3780, 3812);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 3860, 3877);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 3866, 3875);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 3860, 3877);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 3824, 3879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 3824, 3879);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 3927, 3944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 3933, 3942);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 3927, 3944);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 3891, 3946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 3891, 3946);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 3958, 4244);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 4139, 4209);

                f_1522_4139_4208(            // unfortunately Type.IsInstanceOfType() is 35-times slower than "is T" so we use generic code:
                            frame, f_1522_4150_4207(f_1522_4190_4201(frame) is T));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 4223, 4233);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 3958, 4244);

                object
                f_1522_4190_4201(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 4190, 4201);
                    return return_v;
                }


                object
                f_1522_4150_4207(bool
                b)
                {
                    var return_v = ScriptingRuntimeHelpers.BooleanToObject(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 4150, 4207);
                    return return_v;
                }


                int
                f_1522_4139_4208(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, object
                value)
                {
                    this_param.Push(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 4139, 4208);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 3958, 4244);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 3958, 4244);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 4256, 4359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 4314, 4348);

                return "TypeIs " + f_1522_4333_4347(typeof(T));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 4256, 4359);

                string
                f_1522_4333_4347(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1522, 4333, 4347);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 4256, 4359);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 4256, 4359);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeIsInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1522, 3707, 4366);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1522, 3707, 4366);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 3707, 4366);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1522, 3707, 4366);
    }
    internal sealed class TypeAsInstruction<T> : Instruction
    {
        internal TypeAsInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1522, 4447, 4479);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1522, 4447, 4479);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 4447, 4479);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 4447, 4479);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 4527, 4544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 4533, 4542);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 4527, 4544);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 4491, 4546);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 4491, 4546);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 4594, 4611);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 4600, 4609);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 4594, 4611);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 4558, 4613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 4558, 4613);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 4625, 4991);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 4749, 4776);

                object
                value = f_1522_4764_4775(frame)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 4790, 4954) || true) && (value is T)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1522, 4790, 4954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 4838, 4856);

                    f_1522_4838_4855(frame, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1522, 4790, 4954);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1522, 4790, 4954);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 4922, 4939);

                    f_1522_4922_4938(frame, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1522, 4790, 4954);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 4970, 4980);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 4625, 4991);

                object
                f_1522_4764_4775(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 4764, 4775);
                    return return_v;
                }


                int
                f_1522_4838_4855(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, object
                value)
                {
                    this_param.Push(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 4838, 4855);
                    return 0;
                }


                int
                f_1522_4922_4938(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, object
                value)
                {
                    this_param.Push(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 4922, 4938);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 4625, 4991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 4625, 4991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 5003, 5106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 5061, 5095);

                return "TypeAs " + f_1522_5080_5094(typeof(T));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 5003, 5106);

                string
                f_1522_5080_5094(System.Type
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1522, 5080, 5094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 5003, 5106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 5003, 5106);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static TypeAsInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1522, 4374, 5113);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1522, 4374, 5113);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 4374, 5113);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1522, 4374, 5113);
    }
    internal sealed class TypeEqualsInstruction : Instruction
    {
        public static readonly TypeEqualsInstruction Instance;

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 5327, 5344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 5333, 5342);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 5327, 5344);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 5291, 5346);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 5291, 5346);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 5394, 5411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 5400, 5409);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 5394, 5411);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 5358, 5413);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 5358, 5413);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private TypeEqualsInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1522, 5425, 5478);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1522, 5425, 5478);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 5425, 5478);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 5425, 5478);
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 5490, 5774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 5562, 5588);

                object
                type = f_1522_5576_5587(frame)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 5602, 5627);

                object
                obj = f_1522_5615_5626(frame)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 5641, 5739);

                f_1522_5641_5738(frame, f_1522_5652_5737(obj != null && (DynAbs.Tracing.TraceSender.Expression_True(1522, 5692, 5736) && (object)f_1522_5715_5728(obj) == type)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 5753, 5763);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 5490, 5774);

                object
                f_1522_5576_5587(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 5576, 5587);
                    return return_v;
                }


                object
                f_1522_5615_5626(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 5615, 5626);
                    return return_v;
                }


                System.Type
                f_1522_5715_5728(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 5715, 5728);
                    return return_v;
                }


                object
                f_1522_5652_5737(bool
                b)
                {
                    var return_v = ScriptingRuntimeHelpers.BooleanToObject(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 5652, 5737);
                    return return_v;
                }


                int
                f_1522_5641_5738(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, object
                value)
                {
                    this_param.Push(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 5641, 5738);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 5490, 5774);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 5490, 5774);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string InstructionName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1522, 5849, 5879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 5855, 5877);

                    return "TypeEquals()";
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1522, 5849, 5879);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1522, 5786, 5890);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 5786, 5890);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        static TypeEqualsInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1522, 5121, 5897);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1522, 5240, 5278);
            Instance = f_1522_5251_5278();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1522, 5121, 5897);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1522, 5121, 5897);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1522, 5121, 5897);

        static System.Management.Automation.Interpreter.TypeEqualsInstruction
        f_1522_5251_5278()
        {
            var return_v = new System.Management.Automation.Interpreter.TypeEqualsInstruction();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1522, 5251, 5278);
            return return_v;
        }

    }
}
