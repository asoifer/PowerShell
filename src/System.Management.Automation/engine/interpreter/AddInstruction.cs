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

using System.Diagnostics;

namespace System.Management.Automation.Interpreter
{
    internal abstract class AddInstruction : Instruction
    {
        private static Instruction s_int16, s_int32, s_int64, s_UInt16, s_UInt32, s_UInt64, s_single, s_double;

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 1023, 1040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 1029, 1038);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 1023, 1040);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 987, 1042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 987, 1042);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 1090, 1107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 1096, 1105);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 1090, 1107);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 1054, 1109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 1054, 1109);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private AddInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 1121, 1167);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 1121, 1167);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 1121, 1167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 1121, 1167);
            }
        }
        internal sealed class AddInt32 : AddInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 1251, 1640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 1331, 1375);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 1393, 1437);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 1455, 1560);

                    frame.Data[frame.StackIndex - 2] = f_1486_1490_1559(unchecked((Int32)l + (Int32)r));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 1578, 1597);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 1615, 1625);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 1251, 1640);

                    object
                    f_1486_1490_1559(int
                    i)
                    {
                        var return_v = ScriptingRuntimeHelpers.Int32ToObject(i);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 1490, 1559);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 1251, 1640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 1251, 1640);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 1179, 1651);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 1179, 1651);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 1179, 1651);
            }


            static AddInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 1179, 1651);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 1179, 1651);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 1179, 1651);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 1179, 1651);
        }
        internal sealed class AddInt16 : AddInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 1735, 2092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 1815, 1859);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 1877, 1921);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 1939, 2012);

                    frame.Data[frame.StackIndex - 2] = (Int16)unchecked((Int16)l + (Int16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 2030, 2049);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 2067, 2077);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 1735, 2092);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 1735, 2092);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 1735, 2092);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 1663, 2103);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 1663, 2103);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 1663, 2103);
            }


            static AddInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 1663, 2103);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 1663, 2103);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 1663, 2103);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 1663, 2103);
        }
        internal sealed class AddInt64 : AddInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 2187, 2544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 2267, 2311);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 2329, 2373);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 2391, 2464);

                    frame.Data[frame.StackIndex - 2] = (Int64)unchecked((Int64)l + (Int64)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 2482, 2501);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 2519, 2529);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 2187, 2544);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 2187, 2544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 2187, 2544);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 2115, 2555);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 2115, 2555);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 2115, 2555);
            }


            static AddInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 2115, 2555);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 2115, 2555);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 2115, 2555);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 2115, 2555);
        }
        internal sealed class AddUInt16 : AddInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 2640, 3000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 2720, 2764);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 2782, 2826);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 2844, 2920);

                    frame.Data[frame.StackIndex - 2] = (UInt16)unchecked((UInt16)l + (UInt16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 2938, 2957);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 2975, 2985);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 2640, 3000);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 2640, 3000);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 2640, 3000);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 2567, 3011);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 2567, 3011);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 2567, 3011);
            }


            static AddUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 2567, 3011);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 2567, 3011);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 2567, 3011);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 2567, 3011);
        }
        internal sealed class AddUInt32 : AddInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 3096, 3456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 3176, 3220);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 3238, 3282);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 3300, 3376);

                    frame.Data[frame.StackIndex - 2] = (UInt32)unchecked((UInt32)l + (UInt32)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 3394, 3413);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 3431, 3441);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 3096, 3456);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 3096, 3456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 3096, 3456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 3023, 3467);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 3023, 3467);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 3023, 3467);
            }


            static AddUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 3023, 3467);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 3023, 3467);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 3023, 3467);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 3023, 3467);
        }
        internal sealed class AddUInt64 : AddInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 3552, 3910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 3632, 3676);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 3694, 3738);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 3756, 3830);

                    frame.Data[frame.StackIndex - 2] = (UInt64)unchecked((Int16)l + (Int16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 3848, 3867);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 3885, 3895);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 3552, 3910);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 3552, 3910);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 3552, 3910);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 3479, 3921);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 3479, 3921);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 3479, 3921);
            }


            static AddUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 3479, 3921);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 3479, 3921);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 3479, 3921);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 3479, 3921);
        }
        internal sealed class AddSingle : AddInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 4006, 4357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 4086, 4130);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 4148, 4192);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 4210, 4277);

                    frame.Data[frame.StackIndex - 2] = (Single)((Single)l + (Single)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 4295, 4314);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 4332, 4342);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 4006, 4357);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 4006, 4357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 4006, 4357);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 3933, 4368);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 3933, 4368);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 3933, 4368);
            }


            static AddSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 3933, 4368);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 3933, 4368);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 3933, 4368);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 3933, 4368);
        }
        internal sealed class AddDouble : AddInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 4453, 4794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 4533, 4577);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 4595, 4639);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 4657, 4714);

                    frame.Data[frame.StackIndex - 2] = (double)l + (double)r;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 4732, 4751);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 4769, 4779);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 4453, 4794);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 4453, 4794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 4453, 4794);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 4380, 4805);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 4380, 4805);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 4380, 4805);
            }


            static AddDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 4380, 4805);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 4380, 4805);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 4380, 4805);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 4380, 4805);
        }

        public static Instruction Create(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1486, 4817, 5761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 4885, 4912);

                f_1486_4885_4911(f_1486_4898_4910_M(!type.IsEnum));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 4926, 5750);

                switch (f_1486_4934_4952(type))
                {

                    case TypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 5007, 5052);

                        return s_int16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 5014, 5051) ?? (s_int16 = f_1486_5036_5050()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 4926, 5750);

                    case TypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 5091, 5136);

                        return s_int32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 5098, 5135) ?? (s_int32 = f_1486_5120_5134()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 4926, 5750);

                    case TypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 5175, 5220);

                        return s_int64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 5182, 5219) ?? (s_int64 = f_1486_5204_5218()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 4926, 5750);

                    case TypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 5260, 5308);

                        return s_UInt16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 5267, 5307) ?? (s_UInt16 = f_1486_5291_5306()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 4926, 5750);

                    case TypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 5348, 5396);

                        return s_UInt32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 5355, 5395) ?? (s_UInt32 = f_1486_5379_5394()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 4926, 5750);

                    case TypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 5436, 5484);

                        return s_UInt64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 5443, 5483) ?? (s_UInt64 = f_1486_5467_5482()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 4926, 5750);

                    case TypeCode.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 5524, 5572);

                        return s_single ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 5531, 5571) ?? (s_single = f_1486_5555_5570()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 4926, 5750);

                    case TypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 5612, 5660);

                        return s_double ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 5619, 5659) ?? (s_double = f_1486_5643_5658()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 4926, 5750);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 5710, 5735);

                        throw f_1486_5716_5734();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 4926, 5750);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1486, 4817, 5761);

                bool
                f_1486_4898_4910_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1486, 4898, 4910);
                    return return_v;
                }


                int
                f_1486_4885_4911(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 4885, 4911);
                    return 0;
                }


                System.TypeCode
                f_1486_4934_4952(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 4934, 4952);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddInstruction.AddInt16
                f_1486_5036_5050()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddInstruction.AddInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 5036, 5050);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddInstruction.AddInt32
                f_1486_5120_5134()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddInstruction.AddInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 5120, 5134);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddInstruction.AddInt64
                f_1486_5204_5218()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddInstruction.AddInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 5204, 5218);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddInstruction.AddUInt16
                f_1486_5291_5306()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddInstruction.AddUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 5291, 5306);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddInstruction.AddUInt32
                f_1486_5379_5394()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddInstruction.AddUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 5379, 5394);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddInstruction.AddUInt64
                f_1486_5467_5482()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddInstruction.AddUInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 5467, 5482);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddInstruction.AddSingle
                f_1486_5555_5570()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddInstruction.AddSingle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 5555, 5570);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddInstruction.AddDouble
                f_1486_5643_5658()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddInstruction.AddDouble();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 5643, 5658);
                    return return_v;
                }


                System.Exception
                f_1486_5716_5734()
                {
                    var return_v = Assert.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1486, 5716, 5734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 4817, 5761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 4817, 5761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 5773, 5857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 5831, 5846);

                return "Add()";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 5773, 5857);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 5773, 5857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 5773, 5857);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AddInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 803, 5864);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 899, 906);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 908, 915);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 917, 924);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 926, 934);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 936, 944);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 946, 954);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 956, 964);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 966, 974);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 803, 5864);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 803, 5864);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 803, 5864);
    }
    internal abstract class AddOvfInstruction : Instruction
    {
        private static Instruction s_int16, s_int32, s_int64, s_UInt16, s_UInt32, s_UInt64, s_single, s_double;

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 6095, 6112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 6101, 6110);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 6095, 6112);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 6059, 6114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 6059, 6114);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 6162, 6179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 6168, 6177);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 6162, 6179);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 6126, 6181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 6126, 6181);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private AddOvfInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 6193, 6242);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 6193, 6242);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 6193, 6242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 6193, 6242);
            }
        }
        internal sealed class AddOvfInt32 : AddOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 6332, 6719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 6412, 6456);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 6474, 6518);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 6536, 6639);

                    frame.Data[frame.StackIndex - 2] = f_1486_6571_6638(checked((Int32)l + (Int32)r));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 6657, 6676);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 6694, 6704);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 6332, 6719);

                    object
                    f_1486_6571_6638(int
                    i)
                    {
                        var return_v = ScriptingRuntimeHelpers.Int32ToObject(i);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 6571, 6638);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 6332, 6719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 6332, 6719);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddOvfInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 6254, 6730);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 6254, 6730);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 6254, 6730);
            }


            static AddOvfInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 6254, 6730);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 6254, 6730);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 6254, 6730);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 6254, 6730);
        }
        internal sealed class AddOvfInt16 : AddOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 6820, 7175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 6900, 6944);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 6962, 7006);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 7024, 7095);

                    frame.Data[frame.StackIndex - 2] = (Int16)checked((Int16)l + (Int16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 7113, 7132);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 7150, 7160);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 6820, 7175);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 6820, 7175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 6820, 7175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddOvfInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 6742, 7186);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 6742, 7186);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 6742, 7186);
            }


            static AddOvfInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 6742, 7186);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 6742, 7186);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 6742, 7186);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 6742, 7186);
        }
        internal sealed class AddOvfInt64 : AddOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 7276, 7631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 7356, 7400);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 7418, 7462);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 7480, 7551);

                    frame.Data[frame.StackIndex - 2] = (Int64)checked((Int64)l + (Int64)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 7569, 7588);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 7606, 7616);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 7276, 7631);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 7276, 7631);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 7276, 7631);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddOvfInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 7198, 7642);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 7198, 7642);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 7198, 7642);
            }


            static AddOvfInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 7198, 7642);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 7198, 7642);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 7198, 7642);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 7198, 7642);
        }
        internal sealed class AddOvfUInt16 : AddOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 7733, 8091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 7813, 7857);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 7875, 7919);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 7937, 8011);

                    frame.Data[frame.StackIndex - 2] = (UInt16)checked((UInt16)l + (UInt16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 8029, 8048);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 8066, 8076);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 7733, 8091);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 7733, 8091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 7733, 8091);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddOvfUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 7654, 8102);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 7654, 8102);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 7654, 8102);
            }


            static AddOvfUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 7654, 8102);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 7654, 8102);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 7654, 8102);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 7654, 8102);
        }
        internal sealed class AddOvfUInt32 : AddOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 8193, 8551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 8273, 8317);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 8335, 8379);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 8397, 8471);

                    frame.Data[frame.StackIndex - 2] = (UInt32)checked((UInt32)l + (UInt32)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 8489, 8508);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 8526, 8536);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 8193, 8551);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 8193, 8551);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 8193, 8551);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddOvfUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 8114, 8562);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 8114, 8562);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 8114, 8562);
            }


            static AddOvfUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 8114, 8562);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 8114, 8562);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 8114, 8562);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 8114, 8562);
        }
        internal sealed class AddOvfUInt64 : AddOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 8653, 9009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 8733, 8777);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 8795, 8839);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 8857, 8929);

                    frame.Data[frame.StackIndex - 2] = (UInt64)checked((Int16)l + (Int16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 8947, 8966);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 8984, 8994);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 8653, 9009);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 8653, 9009);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 8653, 9009);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddOvfUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 8574, 9020);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 8574, 9020);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 8574, 9020);
            }


            static AddOvfUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 8574, 9020);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 8574, 9020);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 8574, 9020);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 8574, 9020);
        }
        internal sealed class AddOvfSingle : AddOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 9111, 9462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 9191, 9235);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 9253, 9297);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 9315, 9382);

                    frame.Data[frame.StackIndex - 2] = (Single)((Single)l + (Single)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 9400, 9419);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 9437, 9447);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 9111, 9462);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 9111, 9462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 9111, 9462);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddOvfSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 9032, 9473);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 9032, 9473);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 9032, 9473);
            }


            static AddOvfSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 9032, 9473);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 9032, 9473);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 9032, 9473);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 9032, 9473);
        }
        internal sealed class AddOvfDouble : AddOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 9564, 9905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 9644, 9688);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 9706, 9750);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 9768, 9825);

                    frame.Data[frame.StackIndex - 2] = (double)l + (double)r;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 9843, 9862);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 9880, 9890);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 9564, 9905);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 9564, 9905);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 9564, 9905);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public AddOvfDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1486, 9485, 9916);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1486, 9485, 9916);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 9485, 9916);
            }


            static AddOvfDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 9485, 9916);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 9485, 9916);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 9485, 9916);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 9485, 9916);
        }

        public static Instruction Create(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1486, 9928, 10896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 9996, 10023);

                f_1486_9996_10022(f_1486_10009_10021_M(!type.IsEnum));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 10037, 10885);

                switch (f_1486_10045_10063(type))
                {

                    case TypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 10118, 10166);

                        return s_int16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 10125, 10165) ?? (s_int16 = f_1486_10147_10164()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 10037, 10885);

                    case TypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 10205, 10253);

                        return s_int32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 10212, 10252) ?? (s_int32 = f_1486_10234_10251()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 10037, 10885);

                    case TypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 10292, 10340);

                        return s_int64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 10299, 10339) ?? (s_int64 = f_1486_10321_10338()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 10037, 10885);

                    case TypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 10380, 10431);

                        return s_UInt16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 10387, 10430) ?? (s_UInt16 = f_1486_10411_10429()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 10037, 10885);

                    case TypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 10471, 10522);

                        return s_UInt32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 10478, 10521) ?? (s_UInt32 = f_1486_10502_10520()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 10037, 10885);

                    case TypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 10562, 10613);

                        return s_UInt64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 10569, 10612) ?? (s_UInt64 = f_1486_10593_10611()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 10037, 10885);

                    case TypeCode.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 10653, 10704);

                        return s_single ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 10660, 10703) ?? (s_single = f_1486_10684_10702()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 10037, 10885);

                    case TypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 10744, 10795);

                        return s_double ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1486, 10751, 10794) ?? (s_double = f_1486_10775_10793()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 10037, 10885);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1486, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 10845, 10870);

                        throw f_1486_10851_10869();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1486, 10037, 10885);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1486, 9928, 10896);

                bool
                f_1486_10009_10021_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1486, 10009, 10021);
                    return return_v;
                }


                int
                f_1486_9996_10022(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 9996, 10022);
                    return 0;
                }


                System.TypeCode
                f_1486_10045_10063(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 10045, 10063);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfInt16
                f_1486_10147_10164()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 10147, 10164);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfInt32
                f_1486_10234_10251()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 10234, 10251);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfInt64
                f_1486_10321_10338()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 10321, 10338);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfUInt16
                f_1486_10411_10429()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 10411, 10429);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfUInt32
                f_1486_10502_10520()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 10502, 10520);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfUInt64
                f_1486_10593_10611()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfUInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 10593, 10611);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfSingle
                f_1486_10684_10702()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfSingle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 10684, 10702);
                    return return_v;
                }


                System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfDouble
                f_1486_10775_10793()
                {
                    var return_v = new System.Management.Automation.Interpreter.AddOvfInstruction.AddOvfDouble();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1486, 10775, 10793);
                    return return_v;
                }


                System.Exception
                f_1486_10851_10869()
                {
                    var return_v = Assert.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1486, 10851, 10869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 9928, 10896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 9928, 10896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1486, 10908, 10995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 10966, 10984);

                return "AddOvf()";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1486, 10908, 10995);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1486, 10908, 10995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 10908, 10995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static AddOvfInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1486, 5872, 11002);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 5971, 5978);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 5980, 5987);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 5989, 5996);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 5998, 6006);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 6008, 6016);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 6018, 6026);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 6028, 6036);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1486, 6038, 6046);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1486, 5872, 11002);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1486, 5872, 11002);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1486, 5872, 11002);
    }
}
