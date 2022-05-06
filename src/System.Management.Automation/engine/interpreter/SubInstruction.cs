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
    internal abstract class SubInstruction : Instruction
    {
        private static Instruction s_int16, s_int32, s_int64, s_UInt16, s_UInt32, s_UInt64, s_single, s_double;

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 1023, 1040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 1029, 1038);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 1023, 1040);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 987, 1042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 987, 1042);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 1090, 1107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 1096, 1105);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 1090, 1107);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 1054, 1109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 1054, 1109);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SubInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 1121, 1167);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 1121, 1167);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 1121, 1167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 1121, 1167);
            }
        }
        internal sealed class SubInt32 : SubInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 1251, 1640);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 1331, 1375);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 1393, 1437);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 1455, 1560);

                    frame.Data[frame.StackIndex - 2] = f_1521_1490_1559(unchecked((Int32)l - (Int32)r));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 1578, 1597);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 1615, 1625);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 1251, 1640);

                    object
                    f_1521_1490_1559(int
                    i)
                    {
                        var return_v = ScriptingRuntimeHelpers.Int32ToObject(i);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 1490, 1559);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 1251, 1640);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 1251, 1640);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 1179, 1651);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 1179, 1651);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 1179, 1651);
            }


            static SubInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 1179, 1651);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 1179, 1651);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 1179, 1651);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 1179, 1651);
        }
        internal sealed class SubInt16 : SubInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 1735, 2092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 1815, 1859);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 1877, 1921);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 1939, 2012);

                    frame.Data[frame.StackIndex - 2] = (Int16)unchecked((Int16)l - (Int16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 2030, 2049);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 2067, 2077);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 1735, 2092);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 1735, 2092);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 1735, 2092);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 1663, 2103);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 1663, 2103);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 1663, 2103);
            }


            static SubInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 1663, 2103);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 1663, 2103);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 1663, 2103);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 1663, 2103);
        }
        internal sealed class SubInt64 : SubInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 2187, 2544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 2267, 2311);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 2329, 2373);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 2391, 2464);

                    frame.Data[frame.StackIndex - 2] = (Int64)unchecked((Int64)l - (Int64)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 2482, 2501);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 2519, 2529);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 2187, 2544);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 2187, 2544);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 2187, 2544);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 2115, 2555);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 2115, 2555);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 2115, 2555);
            }


            static SubInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 2115, 2555);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 2115, 2555);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 2115, 2555);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 2115, 2555);
        }
        internal sealed class SubUInt16 : SubInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 2640, 3000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 2720, 2764);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 2782, 2826);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 2844, 2920);

                    frame.Data[frame.StackIndex - 2] = (UInt16)unchecked((UInt16)l - (UInt16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 2938, 2957);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 2975, 2985);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 2640, 3000);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 2640, 3000);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 2640, 3000);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 2567, 3011);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 2567, 3011);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 2567, 3011);
            }


            static SubUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 2567, 3011);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 2567, 3011);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 2567, 3011);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 2567, 3011);
        }
        internal sealed class SubUInt32 : SubInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 3096, 3456);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 3176, 3220);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 3238, 3282);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 3300, 3376);

                    frame.Data[frame.StackIndex - 2] = (UInt32)unchecked((UInt32)l - (UInt32)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 3394, 3413);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 3431, 3441);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 3096, 3456);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 3096, 3456);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 3096, 3456);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 3023, 3467);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 3023, 3467);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 3023, 3467);
            }


            static SubUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 3023, 3467);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 3023, 3467);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 3023, 3467);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 3023, 3467);
        }
        internal sealed class SubUInt64 : SubInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 3552, 3910);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 3632, 3676);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 3694, 3738);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 3756, 3830);

                    frame.Data[frame.StackIndex - 2] = (UInt64)unchecked((Int16)l - (Int16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 3848, 3867);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 3885, 3895);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 3552, 3910);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 3552, 3910);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 3552, 3910);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 3479, 3921);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 3479, 3921);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 3479, 3921);
            }


            static SubUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 3479, 3921);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 3479, 3921);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 3479, 3921);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 3479, 3921);
        }
        internal sealed class SubSingle : SubInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 4006, 4357);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 4086, 4130);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 4148, 4192);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 4210, 4277);

                    frame.Data[frame.StackIndex - 2] = (Single)((Single)l - (Single)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 4295, 4314);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 4332, 4342);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 4006, 4357);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 4006, 4357);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 4006, 4357);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 3933, 4368);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 3933, 4368);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 3933, 4368);
            }


            static SubSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 3933, 4368);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 3933, 4368);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 3933, 4368);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 3933, 4368);
        }
        internal sealed class SubDouble : SubInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 4453, 4794);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 4533, 4577);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 4595, 4639);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 4657, 4714);

                    frame.Data[frame.StackIndex - 2] = (double)l - (double)r;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 4732, 4751);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 4769, 4779);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 4453, 4794);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 4453, 4794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 4453, 4794);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 4380, 4805);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 4380, 4805);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 4380, 4805);
            }


            static SubDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 4380, 4805);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 4380, 4805);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 4380, 4805);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 4380, 4805);
        }

        public static Instruction Create(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1521, 4817, 5761);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 4885, 4912);

                f_1521_4885_4911(f_1521_4898_4910_M(!type.IsEnum));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 4926, 5750);

                switch (f_1521_4934_4952(type))
                {

                    case TypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 5007, 5052);

                        return s_int16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 5014, 5051) ?? (s_int16 = f_1521_5036_5050()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 4926, 5750);

                    case TypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 5091, 5136);

                        return s_int32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 5098, 5135) ?? (s_int32 = f_1521_5120_5134()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 4926, 5750);

                    case TypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 5175, 5220);

                        return s_int64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 5182, 5219) ?? (s_int64 = f_1521_5204_5218()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 4926, 5750);

                    case TypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 5260, 5308);

                        return s_UInt16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 5267, 5307) ?? (s_UInt16 = f_1521_5291_5306()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 4926, 5750);

                    case TypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 5348, 5396);

                        return s_UInt32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 5355, 5395) ?? (s_UInt32 = f_1521_5379_5394()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 4926, 5750);

                    case TypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 5436, 5484);

                        return s_UInt64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 5443, 5483) ?? (s_UInt64 = f_1521_5467_5482()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 4926, 5750);

                    case TypeCode.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 5524, 5572);

                        return s_single ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 5531, 5571) ?? (s_single = f_1521_5555_5570()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 4926, 5750);

                    case TypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 5612, 5660);

                        return s_double ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 5619, 5659) ?? (s_double = f_1521_5643_5658()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 4926, 5750);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 4926, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 5710, 5735);

                        throw f_1521_5716_5734();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 4926, 5750);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1521, 4817, 5761);

                bool
                f_1521_4898_4910_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1521, 4898, 4910);
                    return return_v;
                }


                int
                f_1521_4885_4911(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 4885, 4911);
                    return 0;
                }


                System.TypeCode
                f_1521_4934_4952(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 4934, 4952);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubInstruction.SubInt16
                f_1521_5036_5050()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubInstruction.SubInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 5036, 5050);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubInstruction.SubInt32
                f_1521_5120_5134()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubInstruction.SubInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 5120, 5134);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubInstruction.SubInt64
                f_1521_5204_5218()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubInstruction.SubInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 5204, 5218);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubInstruction.SubUInt16
                f_1521_5291_5306()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubInstruction.SubUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 5291, 5306);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubInstruction.SubUInt32
                f_1521_5379_5394()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubInstruction.SubUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 5379, 5394);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubInstruction.SubUInt64
                f_1521_5467_5482()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubInstruction.SubUInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 5467, 5482);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubInstruction.SubSingle
                f_1521_5555_5570()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubInstruction.SubSingle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 5555, 5570);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubInstruction.SubDouble
                f_1521_5643_5658()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubInstruction.SubDouble();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 5643, 5658);
                    return return_v;
                }


                System.Exception
                f_1521_5716_5734()
                {
                    var return_v = Assert.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1521, 5716, 5734);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 4817, 5761);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 4817, 5761);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 5773, 5857);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 5831, 5846);

                return "Sub()";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 5773, 5857);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 5773, 5857);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 5773, 5857);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SubInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 803, 5864);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 899, 906);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 908, 915);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 917, 924);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 926, 934);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 936, 944);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 946, 954);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 956, 964);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 966, 974);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 803, 5864);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 803, 5864);
        }

        int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 803, 5864);
    }
    internal abstract class SubOvfInstruction : Instruction
    {
        private static Instruction s_int16, s_int32, s_int64, s_UInt16, s_UInt32, s_UInt64, s_single, s_double;

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 6095, 6112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 6101, 6110);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 6095, 6112);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 6059, 6114);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 6059, 6114);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 6162, 6179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 6168, 6177);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 6162, 6179);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 6126, 6181);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 6126, 6181);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private SubOvfInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 6193, 6242);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 6193, 6242);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 6193, 6242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 6193, 6242);
            }
        }
        internal sealed class SubOvfInt32 : SubOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 6332, 6719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 6412, 6456);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 6474, 6518);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 6536, 6639);

                    frame.Data[frame.StackIndex - 2] = f_1521_6571_6638(checked((Int32)l - (Int32)r));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 6657, 6676);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 6694, 6704);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 6332, 6719);

                    object
                    f_1521_6571_6638(int
                    i)
                    {
                        var return_v = ScriptingRuntimeHelpers.Int32ToObject(i);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 6571, 6638);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 6332, 6719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 6332, 6719);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubOvfInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 6254, 6730);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 6254, 6730);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 6254, 6730);
            }


            static SubOvfInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 6254, 6730);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 6254, 6730);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 6254, 6730);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 6254, 6730);
        }
        internal sealed class SubOvfInt16 : SubOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 6820, 7175);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 6900, 6944);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 6962, 7006);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 7024, 7095);

                    frame.Data[frame.StackIndex - 2] = (Int16)checked((Int16)l - (Int16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 7113, 7132);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 7150, 7160);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 6820, 7175);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 6820, 7175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 6820, 7175);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubOvfInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 6742, 7186);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 6742, 7186);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 6742, 7186);
            }


            static SubOvfInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 6742, 7186);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 6742, 7186);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 6742, 7186);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 6742, 7186);
        }
        internal sealed class SubOvfInt64 : SubOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 7276, 7631);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 7356, 7400);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 7418, 7462);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 7480, 7551);

                    frame.Data[frame.StackIndex - 2] = (Int64)checked((Int64)l - (Int64)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 7569, 7588);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 7606, 7616);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 7276, 7631);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 7276, 7631);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 7276, 7631);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubOvfInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 7198, 7642);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 7198, 7642);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 7198, 7642);
            }


            static SubOvfInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 7198, 7642);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 7198, 7642);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 7198, 7642);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 7198, 7642);
        }
        internal sealed class SubOvfUInt16 : SubOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 7733, 8091);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 7813, 7857);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 7875, 7919);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 7937, 8011);

                    frame.Data[frame.StackIndex - 2] = (UInt16)checked((UInt16)l - (UInt16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 8029, 8048);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 8066, 8076);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 7733, 8091);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 7733, 8091);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 7733, 8091);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubOvfUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 7654, 8102);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 7654, 8102);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 7654, 8102);
            }


            static SubOvfUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 7654, 8102);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 7654, 8102);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 7654, 8102);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 7654, 8102);
        }
        internal sealed class SubOvfUInt32 : SubOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 8193, 8551);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 8273, 8317);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 8335, 8379);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 8397, 8471);

                    frame.Data[frame.StackIndex - 2] = (UInt32)checked((UInt32)l - (UInt32)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 8489, 8508);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 8526, 8536);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 8193, 8551);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 8193, 8551);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 8193, 8551);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubOvfUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 8114, 8562);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 8114, 8562);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 8114, 8562);
            }


            static SubOvfUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 8114, 8562);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 8114, 8562);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 8114, 8562);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 8114, 8562);
        }
        internal sealed class SubOvfUInt64 : SubOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 8653, 9009);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 8733, 8777);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 8795, 8839);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 8857, 8929);

                    frame.Data[frame.StackIndex - 2] = (UInt64)checked((Int16)l - (Int16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 8947, 8966);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 8984, 8994);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 8653, 9009);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 8653, 9009);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 8653, 9009);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubOvfUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 8574, 9020);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 8574, 9020);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 8574, 9020);
            }


            static SubOvfUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 8574, 9020);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 8574, 9020);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 8574, 9020);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 8574, 9020);
        }
        internal sealed class SubOvfSingle : SubOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 9111, 9462);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 9191, 9235);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 9253, 9297);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 9315, 9382);

                    frame.Data[frame.StackIndex - 2] = (Single)((Single)l - (Single)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 9400, 9419);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 9437, 9447);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 9111, 9462);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 9111, 9462);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 9111, 9462);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubOvfSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 9032, 9473);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 9032, 9473);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 9032, 9473);
            }


            static SubOvfSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 9032, 9473);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 9032, 9473);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 9032, 9473);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 9032, 9473);
        }
        internal sealed class SubOvfDouble : SubOvfInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 9564, 9905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 9644, 9688);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 9706, 9750);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 9768, 9825);

                    frame.Data[frame.StackIndex - 2] = (double)l - (double)r;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 9843, 9862);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 9880, 9890);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 9564, 9905);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 9564, 9905);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 9564, 9905);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public SubOvfDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1521, 9485, 9916);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1521, 9485, 9916);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 9485, 9916);
            }


            static SubOvfDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 9485, 9916);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 9485, 9916);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 9485, 9916);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 9485, 9916);
        }

        public static Instruction Create(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1521, 9928, 10896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 9996, 10023);

                f_1521_9996_10022(f_1521_10009_10021_M(!type.IsEnum));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 10037, 10885);

                switch (f_1521_10045_10063(type))
                {

                    case TypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 10118, 10166);

                        return s_int16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 10125, 10165) ?? (s_int16 = f_1521_10147_10164()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 10037, 10885);

                    case TypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 10205, 10253);

                        return s_int32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 10212, 10252) ?? (s_int32 = f_1521_10234_10251()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 10037, 10885);

                    case TypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 10292, 10340);

                        return s_int64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 10299, 10339) ?? (s_int64 = f_1521_10321_10338()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 10037, 10885);

                    case TypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 10380, 10431);

                        return s_UInt16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 10387, 10430) ?? (s_UInt16 = f_1521_10411_10429()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 10037, 10885);

                    case TypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 10471, 10522);

                        return s_UInt32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 10478, 10521) ?? (s_UInt32 = f_1521_10502_10520()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 10037, 10885);

                    case TypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 10562, 10613);

                        return s_UInt64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 10569, 10612) ?? (s_UInt64 = f_1521_10593_10611()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 10037, 10885);

                    case TypeCode.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 10653, 10704);

                        return s_single ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 10660, 10703) ?? (s_single = f_1521_10684_10702()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 10037, 10885);

                    case TypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 10744, 10795);

                        return s_double ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1521, 10751, 10794) ?? (s_double = f_1521_10775_10793()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 10037, 10885);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1521, 10037, 10885);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 10845, 10870);

                        throw f_1521_10851_10869();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1521, 10037, 10885);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1521, 9928, 10896);

                bool
                f_1521_10009_10021_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1521, 10009, 10021);
                    return return_v;
                }


                int
                f_1521_9996_10022(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 9996, 10022);
                    return 0;
                }


                System.TypeCode
                f_1521_10045_10063(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 10045, 10063);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfInt16
                f_1521_10147_10164()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 10147, 10164);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfInt32
                f_1521_10234_10251()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 10234, 10251);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfInt64
                f_1521_10321_10338()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 10321, 10338);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfUInt16
                f_1521_10411_10429()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 10411, 10429);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfUInt32
                f_1521_10502_10520()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 10502, 10520);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfUInt64
                f_1521_10593_10611()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfUInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 10593, 10611);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfSingle
                f_1521_10684_10702()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfSingle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 10684, 10702);
                    return return_v;
                }


                System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfDouble
                f_1521_10775_10793()
                {
                    var return_v = new System.Management.Automation.Interpreter.SubOvfInstruction.SubOvfDouble();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1521, 10775, 10793);
                    return return_v;
                }


                System.Exception
                f_1521_10851_10869()
                {
                    var return_v = Assert.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1521, 10851, 10869);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 9928, 10896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 9928, 10896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1521, 10908, 10995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 10966, 10984);

                return "SubOvf()";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1521, 10908, 10995);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1521, 10908, 10995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 10908, 10995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static SubOvfInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1521, 5872, 11002);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 5971, 5978);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 5980, 5987);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 5989, 5996);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 5998, 6006);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 6008, 6016);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 6018, 6026);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 6028, 6036);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1521, 6038, 6046);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1521, 5872, 11002);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1521, 5872, 11002);
        }

        int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1521, 5872, 11002);
    }
}
