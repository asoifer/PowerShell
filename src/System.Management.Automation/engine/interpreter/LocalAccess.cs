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
using System.Collections.Generic;

namespace System.Management.Automation.Interpreter
{
    internal interface IBoxableInstruction
    {

        Instruction BoxIfIndexMatches(int index);
    }
    internal abstract class LocalAccessInstruction : Instruction
    {
        internal readonly int _index;

        protected LocalAccessInstruction(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 1164, 1258);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 1145, 1151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 1232, 1247);

                _index = index;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 1164, 1258);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 1164, 1258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 1164, 1258);
            }
        }

        public override string ToDebugString(int instructionIndex, object cookie, Func<int, int> labelIndexer, IList<object> objects)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 1270, 1581);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 1420, 1570);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1512, 1427, 1441) || ((cookie == null && DynAbs.Tracing.TraceSender.Conditional_F2(1512, 1461, 1497)) || DynAbs.Tracing.TraceSender.Conditional_F3(1512, 1517, 1569))) ? f_1512_1461_1476() + "(" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_index).ToString(), 1512, 1485, 1491) + ")" : f_1512_1517_1532() + "(" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (cookie).ToString(), 1512, 1541, 1547) + ": " + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_index).ToString(), 1512, 1557, 1563) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 1270, 1581);

                string
                f_1512_1461_1476()
                {
                    var return_v = InstructionName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1512, 1461, 1476);
                    return return_v;
                }


                string
                f_1512_1517_1532()
                {
                    var return_v = InstructionName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1512, 1517, 1532);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 1270, 1581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 1270, 1581);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LocalAccessInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 1046, 1588);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 1046, 1588);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 1046, 1588);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 1046, 1588);
    }
    internal sealed class LoadLocalInstruction : LocalAccessInstruction, IBoxableInstruction
    {
        internal LoadLocalInstruction(int index)
        : base(f_1512_1782_1787_C(index))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 1721, 1810);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 1721, 1810);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 1721, 1810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 1721, 1810);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 1858, 1875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 1864, 1873);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 1858, 1875);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 1822, 1877);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 1822, 1877);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 1889, 2096);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 1961, 2013);

                frame.Data[frame.StackIndex++] = frame.Data[_index];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 2075, 2085);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 1889, 2096);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 1889, 2096);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 1889, 2096);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Instruction BoxIfIndexMatches(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 2108, 2263);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 2180, 2252);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1512, 2187, 2204) || (((index == _index) && DynAbs.Tracing.TraceSender.Conditional_F2(1512, 2207, 2244)) || DynAbs.Tracing.TraceSender.Conditional_F3(1512, 2247, 2251))) ? f_1512_2207_2244(index) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 2108, 2263);

                System.Management.Automation.Interpreter.Instruction
                f_1512_2207_2244(int
                index)
                {
                    var return_v = InstructionList.LoadLocalBoxed(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 2207, 2244);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 2108, 2263);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 2108, 2263);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LoadLocalInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 1616, 2270);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 1616, 2270);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 1616, 2270);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 1616, 2270);

        static int
        f_1512_1782_1787_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 1721, 1810);
            return return_v;
        }

    }
    internal sealed class LoadLocalBoxedInstruction : LocalAccessInstruction
    {
        internal LoadLocalBoxedInstruction(int index)
        : base(f_1512_2433_2438_C(index))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 2367, 2461);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 2367, 2461);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 2367, 2461);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 2367, 2461);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 2509, 2526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 2515, 2524);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 2509, 2526);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 2473, 2528);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 2473, 2528);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 2540, 2752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 2612, 2660);

                var
                box = (StrongBox<object>)frame.Data[_index]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 2674, 2717);

                frame.Data[frame.StackIndex++] = box.Value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 2731, 2741);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 2540, 2752);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 2540, 2752);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 2540, 2752);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LoadLocalBoxedInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 2278, 2759);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 2278, 2759);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 2278, 2759);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 2278, 2759);

        static int
        f_1512_2433_2438_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 2367, 2461);
            return return_v;
        }

    }
    internal sealed class LoadLocalFromClosureInstruction : LocalAccessInstruction
    {
        internal LoadLocalFromClosureInstruction(int index)
        : base(f_1512_2934_2939_C(index))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 2862, 2962);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 2862, 2962);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 2862, 2962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 2862, 2962);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 3010, 3027);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 3016, 3025);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 3010, 3027);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 2974, 3029);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 2974, 3029);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 3041, 3237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 3113, 3145);

                var
                box = frame.Closure[_index]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 3159, 3202);

                frame.Data[frame.StackIndex++] = box.Value;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 3216, 3226);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 3041, 3237);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 3041, 3237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 3041, 3237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LoadLocalFromClosureInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 2767, 3244);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 2767, 3244);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 2767, 3244);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 2767, 3244);

        static int
        f_1512_2934_2939_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 2862, 2962);
            return return_v;
        }

    }
    internal sealed class LoadLocalFromClosureBoxedInstruction : LocalAccessInstruction
    {
        internal LoadLocalFromClosureBoxedInstruction(int index)
        : base(f_1512_3429_3434_C(index))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 3352, 3457);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 3352, 3457);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 3352, 3457);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 3352, 3457);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 3505, 3522);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 3511, 3520);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 3505, 3522);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 3469, 3524);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 3469, 3524);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 3536, 3726);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 3608, 3640);

                var
                box = frame.Closure[_index]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 3654, 3691);

                frame.Data[frame.StackIndex++] = box;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 3705, 3715);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 3536, 3726);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 3536, 3726);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 3536, 3726);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LoadLocalFromClosureBoxedInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 3252, 3733);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 3252, 3733);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 3252, 3733);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 3252, 3733);

        static int
        f_1512_3429_3434_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 3352, 3457);
            return return_v;
        }

    }
    internal sealed class AssignLocalInstruction : LocalAccessInstruction, IBoxableInstruction
    {
        internal AssignLocalInstruction(int index)
        : base(f_1512_3958_3963_C(index))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 3895, 3986);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 3895, 3986);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 3895, 3986);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 3895, 3986);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 4034, 4051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 4040, 4049);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 4034, 4051);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 3998, 4053);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 3998, 4053);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 4101, 4118);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 4107, 4116);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 4101, 4118);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 4065, 4120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 4065, 4120);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 4132, 4273);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 4204, 4238);

                frame.Data[_index] = f_1512_4225_4237(frame);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 4252, 4262);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 4132, 4273);

                object
                f_1512_4225_4237(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 4225, 4237);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 4132, 4273);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 4132, 4273);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Instruction BoxIfIndexMatches(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 4285, 4442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 4357, 4431);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1512, 4364, 4381) || (((index == _index) && DynAbs.Tracing.TraceSender.Conditional_F2(1512, 4384, 4423)) || DynAbs.Tracing.TraceSender.Conditional_F3(1512, 4426, 4430))) ? f_1512_4384_4423(index) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 4285, 4442);

                System.Management.Automation.Interpreter.Instruction
                f_1512_4384_4423(int
                index)
                {
                    var return_v = InstructionList.AssignLocalBoxed(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 4384, 4423);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 4285, 4442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 4285, 4442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AssignLocalInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 3788, 4449);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 3788, 4449);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 3788, 4449);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 3788, 4449);

        static int
        f_1512_3958_3963_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 3895, 3986);
            return return_v;
        }

    }
    internal sealed class StoreLocalInstruction : LocalAccessInstruction, IBoxableInstruction
    {
        internal StoreLocalInstruction(int index)
        : base(f_1512_4625_4630_C(index))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 4563, 4653);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 4563, 4653);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 4563, 4653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 4563, 4653);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 4701, 4718);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 4707, 4716);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 4701, 4718);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 4665, 4720);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 4665, 4720);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 4732, 4941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 4804, 4856);

                frame.Data[_index] = frame.Data[--frame.StackIndex];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 4920, 4930);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 4732, 4941);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 4732, 4941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 4732, 4941);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Instruction BoxIfIndexMatches(int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 4953, 5109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 5025, 5098);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1512, 5032, 5049) || (((index == _index) && DynAbs.Tracing.TraceSender.Conditional_F2(1512, 5052, 5090)) || DynAbs.Tracing.TraceSender.Conditional_F3(1512, 5093, 5097))) ? f_1512_5052_5090(index) : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 4953, 5109);

                System.Management.Automation.Interpreter.Instruction
                f_1512_5052_5090(int
                index)
                {
                    var return_v = InstructionList.StoreLocalBoxed(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 5052, 5090);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 4953, 5109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 4953, 5109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StoreLocalInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 4457, 5116);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 4457, 5116);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 4457, 5116);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 4457, 5116);

        static int
        f_1512_4625_4630_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 4563, 4653);
            return return_v;
        }

    }
    internal sealed class AssignLocalBoxedInstruction : LocalAccessInstruction
    {
        internal AssignLocalBoxedInstruction(int index)
        : base(f_1512_5283_5288_C(index))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 5215, 5311);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 5215, 5311);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 5215, 5311);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 5215, 5311);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 5359, 5376);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 5365, 5374);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 5359, 5376);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 5323, 5378);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 5323, 5378);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 5426, 5443);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 5432, 5441);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 5426, 5443);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 5390, 5445);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 5390, 5445);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 5457, 5651);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 5529, 5577);

                var
                box = (StrongBox<object>)frame.Data[_index]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 5591, 5616);

                box.Value = f_1512_5603_5615(frame);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 5630, 5640);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 5457, 5651);

                object
                f_1512_5603_5615(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 5603, 5615);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 5457, 5651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 5457, 5651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AssignLocalBoxedInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 5124, 5658);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 5124, 5658);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 5124, 5658);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 5124, 5658);

        static int
        f_1512_5283_5288_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 5215, 5311);
            return return_v;
        }

    }
    internal sealed class StoreLocalBoxedInstruction : LocalAccessInstruction
    {
        internal StoreLocalBoxedInstruction(int index)
        : base(f_1512_5823_5828_C(index))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 5756, 5851);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 5756, 5851);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 5756, 5851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 5756, 5851);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 5899, 5916);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 5905, 5914);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 5899, 5916);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 5863, 5918);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 5863, 5918);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 5966, 5983);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 5972, 5981);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 5966, 5983);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 5930, 5985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 5930, 5985);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 5997, 6209);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 6069, 6117);

                var
                box = (StrongBox<object>)frame.Data[_index]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 6131, 6174);

                box.Value = frame.Data[--frame.StackIndex];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 6188, 6198);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 5997, 6209);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 5997, 6209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 5997, 6209);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StoreLocalBoxedInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 5666, 6216);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 5666, 6216);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 5666, 6216);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 5666, 6216);

        static int
        f_1512_5823_5828_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 5756, 5851);
            return return_v;
        }

    }
    internal sealed class AssignLocalToClosureInstruction : LocalAccessInstruction
    {
        internal AssignLocalToClosureInstruction(int index)
        : base(f_1512_6391_6396_C(index))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 6319, 6419);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 6319, 6419);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 6319, 6419);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 6319, 6419);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 6467, 6484);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 6473, 6482);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 6467, 6484);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 6431, 6486);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 6431, 6486);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 6534, 6551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 6540, 6549);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 6534, 6551);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 6498, 6553);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 6498, 6553);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 6565, 6743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 6637, 6669);

                var
                box = frame.Closure[_index]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 6683, 6708);

                box.Value = f_1512_6695_6707(frame);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 6722, 6732);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 6565, 6743);

                object
                f_1512_6695_6707(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 6695, 6707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 6565, 6743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 6565, 6743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AssignLocalToClosureInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 6224, 6750);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 6224, 6750);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 6224, 6750);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 6224, 6750);

        static int
        f_1512_6391_6396_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 6319, 6419);
            return return_v;
        }

    }
    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1012:AbstractTypesShouldNotHaveConstructors")]
    internal abstract class InitializeLocalInstruction : LocalAccessInstruction
    {
        internal InitializeLocalInstruction(int index)
        : base(f_1512_7085_7090_C(index))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 7018, 7113);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 7018, 7113);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 7018, 7113);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 7018, 7113);
            }
        }
        internal sealed class Reference : InitializeLocalInstruction, IBoxableInstruction
        {
            internal Reference(int index)
            : base(f_1512_7285_7290_C(index))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 7231, 7321);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 7231, 7321);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 7231, 7321);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 7231, 7321);
                }
            }

            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 7337, 7485);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 7417, 7443);

                    frame.Data[_index] = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 7461, 7470);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 7337, 7485);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 7337, 7485);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 7337, 7485);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public Instruction BoxIfIndexMatches(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 7501, 7673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 7581, 7658);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1512, 7588, 7605) || (((index == _index) && DynAbs.Tracing.TraceSender.Conditional_F2(1512, 7608, 7650)) || DynAbs.Tracing.TraceSender.Conditional_F3(1512, 7653, 7657))) ? f_1512_7608_7650(index) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 7501, 7673);

                    System.Management.Automation.Interpreter.Instruction
                    f_1512_7608_7650(int
                    index)
                    {
                        var return_v = InstructionList.InitImmutableRefBox(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 7608, 7650);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 7501, 7673);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 7501, 7673);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override string InstructionName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 7760, 7785);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 7766, 7783);

                        return "InitRef";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 7760, 7785);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 7689, 7800);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 7689, 7800);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static Reference()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 7125, 7811);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 7125, 7811);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 7125, 7811);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 7125, 7811);

            static int
            f_1512_7285_7290_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 7231, 7321);
                return return_v;
            }

        }
        internal sealed class ImmutableValue : InitializeLocalInstruction, IBoxableInstruction
        {
            private readonly object _defaultValue;

            internal ImmutableValue(int index, object defaultValue)
            : base(f_1512_8068_8073_C(index))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 7988, 8151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 7958, 7971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 8107, 8136);

                    _defaultValue = defaultValue;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 7988, 8151);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 7988, 8151);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 7988, 8151);
                }
            }

            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 8167, 8324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 8247, 8282);

                    frame.Data[_index] = _defaultValue;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 8300, 8309);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 8167, 8324);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 8167, 8324);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 8167, 8324);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public Instruction BoxIfIndexMatches(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 8340, 8508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 8420, 8493);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1512, 8427, 8444) || (((index == _index) && DynAbs.Tracing.TraceSender.Conditional_F2(1512, 8447, 8485)) || DynAbs.Tracing.TraceSender.Conditional_F3(1512, 8488, 8492))) ? f_1512_8447_8485(index, _defaultValue) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 8340, 8508);

                    System.Management.Automation.Interpreter.InitializeLocalInstruction.ImmutableBox
                    f_1512_8447_8485(int
                    index, object
                    defaultValue)
                    {
                        var return_v = new System.Management.Automation.Interpreter.InitializeLocalInstruction.ImmutableBox(index, defaultValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 8447, 8485);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 8340, 8508);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 8340, 8508);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override string InstructionName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 8595, 8631);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 8601, 8629);

                        return "InitImmutableValue";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 8595, 8631);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 8524, 8646);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 8524, 8646);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ImmutableValue()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 7823, 8657);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 7823, 8657);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 7823, 8657);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 7823, 8657);

            static int
            f_1512_8068_8073_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 7988, 8151);
                return return_v;
            }

        }
        internal sealed class ImmutableBox : InitializeLocalInstruction
        {
            private readonly object _defaultValue;

            internal ImmutableBox(int index, object defaultValue)
            : base(f_1512_8922_8927_C(index))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 8844, 9005);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 8814, 8827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 8961, 8990);

                    _defaultValue = defaultValue;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 8844, 9005);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 8844, 9005);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 8844, 9005);
                }
            }

            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 9021, 9201);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 9101, 9159);

                    frame.Data[_index] = f_1512_9122_9158(_defaultValue);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 9177, 9186);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 9021, 9201);

                    System.Runtime.CompilerServices.StrongBox<object>
                    f_1512_9122_9158(object
                    value)
                    {
                        var return_v = new System.Runtime.CompilerServices.StrongBox<object>(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 9122, 9158);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 9021, 9201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 9021, 9201);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override string InstructionName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 9288, 9322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 9294, 9320);

                        return "InitImmutableBox";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 9288, 9322);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 9217, 9337);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 9217, 9337);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static ImmutableBox()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 8669, 9348);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 8669, 9348);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 8669, 9348);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 8669, 9348);

            static int
            f_1512_8922_8927_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 8844, 9005);
                return return_v;
            }

        }
        internal sealed class ParameterBox : InitializeLocalInstruction
        {
            public ParameterBox(int index)
            : base(f_1512_9503_9508_C(index))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 9448, 9539);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 9448, 9539);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 9448, 9539);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 9448, 9539);
                }
            }

            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 9555, 9740);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 9635, 9698);

                    frame.Data[_index] = f_1512_9656_9697(frame.Data[_index]);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 9716, 9725);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 9555, 9740);

                    System.Runtime.CompilerServices.StrongBox<object>
                    f_1512_9656_9697(object
                    value)
                    {
                        var return_v = new System.Runtime.CompilerServices.StrongBox<object>(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 9656, 9697);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 9555, 9740);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 9555, 9740);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static ParameterBox()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 9360, 9751);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 9360, 9751);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 9360, 9751);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 9360, 9751);

            static int
            f_1512_9503_9508_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 9448, 9539);
                return return_v;
            }

        }
        internal sealed class Parameter : InitializeLocalInstruction, IBoxableInstruction
        {
            internal Parameter(int index)
            : base(f_1512_9923_9928_C(index))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 9869, 9959);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 9869, 9959);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 9869, 9959);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 9869, 9959);
                }
            }

            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 9975, 10103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 10079, 10088);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 9975, 10103);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 9975, 10103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 9975, 10103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public Instruction BoxIfIndexMatches(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 10119, 10369);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 10199, 10322) || true) && (index == _index)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1512, 10199, 10322);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 10260, 10303);

                        return f_1512_10267_10302(index);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1512, 10199, 10322);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 10342, 10354);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 10119, 10369);

                    System.Management.Automation.Interpreter.Instruction
                    f_1512_10267_10302(int
                    index)
                    {
                        var return_v = InstructionList.ParameterBox(index);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 10267, 10302);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 10119, 10369);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 10119, 10369);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override string InstructionName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 10456, 10487);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 10462, 10485);

                        return "InitParameter";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 10456, 10487);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 10385, 10502);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 10385, 10502);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static Parameter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 9763, 10513);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 9763, 10513);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 9763, 10513);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 9763, 10513);

            static int
            f_1512_9923_9928_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 9869, 9959);
                return return_v;
            }

        }
        internal sealed class MutableValue : InitializeLocalInstruction, IBoxableInstruction
        {
            private readonly Type _type;

            internal MutableValue(int index, Type type)
            : base(f_1512_10746_10751_C(index))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 10678, 10813);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 10656, 10661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 10785, 10798);

                    _type = type;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 10678, 10813);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 10678, 10813);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 10678, 10813);
                }
            }

            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 10829, 11279);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 10953, 11006);

                        frame.Data[_index] = f_1512_10974_11005(_type);
                    }
                    catch (TargetInvocationException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1512, 11043, 11235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 11119, 11171);

                        f_1512_11119_11170(f_1512_11153_11169(e));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 11193, 11216);

                        throw f_1512_11199_11215(e);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1512, 11043, 11235);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 11255, 11264);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 10829, 11279);

                    object?
                    f_1512_10974_11005(System.Type
                    type)
                    {
                        var return_v = Activator.CreateInstance(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 10974, 11005);
                        return return_v;
                    }


                    System.Exception
                    f_1512_11153_11169(System.Reflection.TargetInvocationException
                    this_param)
                    {
                        var return_v = this_param.InnerException;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1512, 11153, 11169);
                        return return_v;
                    }


                    System.Exception
                    f_1512_11119_11170(System.Exception
                    rethrow)
                    {
                        var return_v = ExceptionHelpers.UpdateForRethrow(rethrow);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 11119, 11170);
                        return return_v;
                    }


                    System.Exception
                    f_1512_11199_11215(System.Reflection.TargetInvocationException
                    this_param)
                    {
                        var return_v = this_param.InnerException;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1512, 11199, 11215);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 10829, 11279);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 10829, 11279);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public Instruction BoxIfIndexMatches(int index)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 11295, 11453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 11375, 11438);

                    return (DynAbs.Tracing.TraceSender.Conditional_F1(1512, 11382, 11399) || (((index == _index) && DynAbs.Tracing.TraceSender.Conditional_F2(1512, 11402, 11430)) || DynAbs.Tracing.TraceSender.Conditional_F3(1512, 11433, 11437))) ? f_1512_11402_11430(index, _type) : null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 11295, 11453);

                    System.Management.Automation.Interpreter.InitializeLocalInstruction.MutableBox
                    f_1512_11402_11430(int
                    index, System.Type
                    type)
                    {
                        var return_v = new System.Management.Automation.Interpreter.InitializeLocalInstruction.MutableBox(index, type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 11402, 11430);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 11295, 11453);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 11295, 11453);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override string InstructionName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 11540, 11574);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 11546, 11572);

                        return "InitMutableValue";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 11540, 11574);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 11469, 11589);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 11469, 11589);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static MutableValue()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 10525, 11600);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 10525, 11600);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 10525, 11600);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 10525, 11600);

            static int
            f_1512_10746_10751_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 10678, 10813);
                return return_v;
            }

        }
        internal sealed class MutableBox : InitializeLocalInstruction
        {
            private readonly Type _type;

            internal MutableBox(int index, Type type)
            : base(f_1512_11808_11813_C(index))
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 11742, 11875);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 11720, 11725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 11847, 11860);

                    _type = type;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 11742, 11875);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 11742, 11875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 11742, 11875);
                }
            }

            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 11891, 12089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 11971, 12047);

                    frame.Data[_index] = f_1512_11992_12046(f_1512_12014_12045(_type));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 12065, 12074);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 11891, 12089);

                    object?
                    f_1512_12014_12045(System.Type
                    type)
                    {
                        var return_v = Activator.CreateInstance(type);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 12014, 12045);
                        return return_v;
                    }


                    System.Runtime.CompilerServices.StrongBox<object>
                    f_1512_11992_12046(object
                    value)
                    {
                        var return_v = new System.Runtime.CompilerServices.StrongBox<object>(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 11992, 12046);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 11891, 12089);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 11891, 12089);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public override string InstructionName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 12176, 12208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 12182, 12206);

                        return "InitMutableBox";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 12176, 12208);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 12105, 12223);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 12105, 12223);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            static MutableBox()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 11612, 12234);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 11612, 12234);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 11612, 12234);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 11612, 12234);

            static int
            f_1512_11808_11813_C(int
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 11742, 11875);
                return return_v;
            }

        }

        static InitializeLocalInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 6802, 12241);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 6802, 12241);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 6802, 12241);
        }

        int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 6802, 12241);

        static int
        f_1512_7085_7090_C(int
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1512, 7018, 7113);
            return return_v;
        }

    }
    internal sealed class RuntimeVariablesInstruction : Instruction
    {
        private readonly int _count;

        public RuntimeVariablesInstruction(int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1512, 12419, 12515);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 12400, 12406);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 12489, 12504);

                _count = count;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1512, 12419, 12515);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 12419, 12515);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 12419, 12515);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 12563, 12580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 12569, 12578);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 12563, 12580);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 12527, 12582);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 12527, 12582);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 12630, 12652);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 12636, 12650);

                    return _count;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 12630, 12652);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 12594, 12654);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 12594, 12654);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 12666, 12999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 12738, 12771);

                var
                ret = new IStrongBox[_count]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 12794, 12812);
                    for (int
        i = f_1512_12798_12808(ret) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 12785, 12907) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 12822, 12825)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(1512, 12785, 12907))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1512, 12785, 12907);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 12859, 12892);

                        ret[i] = (IStrongBox)f_1512_12880_12891(frame);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1512, 1, 123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1512, 1, 123);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 12923, 12964);

                f_1512_12923_12963(
                            frame, f_1512_12934_12962(ret));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 12978, 12988);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 12666, 12999);

                int
                f_1512_12798_12808(System.Runtime.CompilerServices.IStrongBox[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1512, 12798, 12808);
                    return return_v;
                }


                object
                f_1512_12880_12891(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 12880, 12891);
                    return return_v;
                }


                System.Runtime.CompilerServices.IRuntimeVariables
                f_1512_12934_12962(System.Runtime.CompilerServices.IStrongBox[]
                boxes)
                {
                    var return_v = RuntimeVariables.Create(boxes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 12934, 12962);
                    return return_v;
                }


                int
                f_1512_12923_12963(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, System.Runtime.CompilerServices.IRuntimeVariables
                value)
                {
                    this_param.Push((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1512, 12923, 12963);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 12666, 12999);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 12666, 12999);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1512, 13011, 13111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1512, 13069, 13100);

                return "GetRuntimeVariables()";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1512, 13011, 13111);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1512, 13011, 13111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 13011, 13111);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static RuntimeVariablesInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1512, 12299, 13118);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1512, 12299, 13118);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1512, 12299, 13118);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1512, 12299, 13118);
    }

}
