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
    internal abstract class DivInstruction : Instruction
    {
        private static Instruction s_int16, s_int32, s_int64, s_UInt16, s_UInt32, s_UInt64, s_single, s_double;

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1492, 1023, 1040);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 1029, 1038);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1492, 1023, 1040);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1492, 987, 1042);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 987, 1042);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1492, 1090, 1107);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 1096, 1105);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1492, 1090, 1107);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1492, 1054, 1109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 1054, 1109);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private DivInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1492, 1121, 1167);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1492, 1121, 1167);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1492, 1121, 1167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 1121, 1167);
            }
        }
        internal sealed class DivInt32 : DivInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1492, 1251, 1628);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 1331, 1375);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 1393, 1437);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 1455, 1549);

                    frame.Data[frame.StackIndex - 2] = f_1492_1490_1548((Int32)l / (Int32)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 1567, 1586);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 1604, 1613);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1492, 1251, 1628);

                    object
                    f_1492_1490_1548(int
                    i)
                    {
                        var return_v = ScriptingRuntimeHelpers.Int32ToObject(i);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1492, 1490, 1548);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1492, 1251, 1628);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 1251, 1628);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public DivInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1492, 1179, 1639);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1492, 1179, 1639);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 1179, 1639);
            }


            static DivInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1492, 1179, 1639);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1492, 1179, 1639);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 1179, 1639);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1492, 1179, 1639);
        }
        internal sealed class DivInt16 : DivInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1492, 1723, 2070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 1803, 1847);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 1865, 1909);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 1927, 1991);

                    frame.Data[frame.StackIndex - 2] = (Int16)((Int16)l / (Int16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 2009, 2028);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 2046, 2055);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1492, 1723, 2070);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1492, 1723, 2070);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 1723, 2070);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public DivInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1492, 1651, 2081);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1492, 1651, 2081);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 1651, 2081);
            }


            static DivInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1492, 1651, 2081);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1492, 1651, 2081);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 1651, 2081);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1492, 1651, 2081);
        }
        internal sealed class DivInt64 : DivInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1492, 2165, 2512);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 2245, 2289);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 2307, 2351);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 2369, 2433);

                    frame.Data[frame.StackIndex - 2] = (Int64)((Int64)l / (Int64)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 2451, 2470);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 2488, 2497);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1492, 2165, 2512);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1492, 2165, 2512);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 2165, 2512);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public DivInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1492, 2093, 2523);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1492, 2093, 2523);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 2093, 2523);
            }


            static DivInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1492, 2093, 2523);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1492, 2093, 2523);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 2093, 2523);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1492, 2093, 2523);
        }
        internal sealed class DivUInt16 : DivInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1492, 2608, 2958);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 2688, 2732);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 2750, 2794);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 2812, 2879);

                    frame.Data[frame.StackIndex - 2] = (UInt16)((UInt16)l / (UInt16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 2897, 2916);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 2934, 2943);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1492, 2608, 2958);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1492, 2608, 2958);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 2608, 2958);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public DivUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1492, 2535, 2969);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1492, 2535, 2969);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 2535, 2969);
            }


            static DivUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1492, 2535, 2969);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1492, 2535, 2969);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 2535, 2969);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1492, 2535, 2969);
        }
        internal sealed class DivUInt32 : DivInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1492, 3054, 3404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 3134, 3178);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 3196, 3240);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 3258, 3325);

                    frame.Data[frame.StackIndex - 2] = (UInt32)((UInt32)l / (UInt32)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 3343, 3362);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 3380, 3389);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1492, 3054, 3404);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1492, 3054, 3404);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 3054, 3404);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public DivUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1492, 2981, 3415);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1492, 2981, 3415);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 2981, 3415);
            }


            static DivUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1492, 2981, 3415);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1492, 2981, 3415);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 2981, 3415);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1492, 2981, 3415);
        }
        internal sealed class DivUInt64 : DivInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1492, 3500, 3848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 3580, 3624);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 3642, 3686);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 3704, 3769);

                    frame.Data[frame.StackIndex - 2] = (UInt64)((Int16)l / (Int16)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 3787, 3806);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 3824, 3833);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1492, 3500, 3848);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1492, 3500, 3848);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 3500, 3848);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public DivUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1492, 3427, 3859);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1492, 3427, 3859);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 3427, 3859);
            }


            static DivUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1492, 3427, 3859);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1492, 3427, 3859);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 3427, 3859);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1492, 3427, 3859);
        }
        internal sealed class DivSingle : DivInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1492, 3944, 4294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 4024, 4068);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 4086, 4130);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 4148, 4215);

                    frame.Data[frame.StackIndex - 2] = (Single)((Single)l / (Single)r);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 4233, 4252);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 4270, 4279);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1492, 3944, 4294);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1492, 3944, 4294);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 3944, 4294);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public DivSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1492, 3871, 4305);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1492, 3871, 4305);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 3871, 4305);
            }


            static DivSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1492, 3871, 4305);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1492, 3871, 4305);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 3871, 4305);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1492, 3871, 4305);
        }
        internal sealed class DivDouble : DivInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1492, 4390, 4730);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 4470, 4514);

                    object
                    l = frame.Data[frame.StackIndex - 2]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 4532, 4576);

                    object
                    r = frame.Data[frame.StackIndex - 1]
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 4594, 4651);

                    frame.Data[frame.StackIndex - 2] = (double)l / (double)r;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 4669, 4688);

                    frame.StackIndex--;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 4706, 4715);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1492, 4390, 4730);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1492, 4390, 4730);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 4390, 4730);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public DivDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1492, 4317, 4741);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1492, 4317, 4741);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 4317, 4741);
            }


            static DivDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1492, 4317, 4741);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1492, 4317, 4741);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 4317, 4741);
            }

            int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1492, 4317, 4741);
        }

        public static Instruction Create(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1492, 4753, 5697);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 4821, 4848);

                f_1492_4821_4847(f_1492_4834_4846_M(!type.IsEnum));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 4862, 5686);

                switch (f_1492_4870_4888(type))
                {

                    case TypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1492, 4862, 5686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 4943, 4988);

                        return s_int16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1492, 4950, 4987) ?? (s_int16 = f_1492_4972_4986()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1492, 4862, 5686);

                    case TypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1492, 4862, 5686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 5027, 5072);

                        return s_int32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1492, 5034, 5071) ?? (s_int32 = f_1492_5056_5070()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1492, 4862, 5686);

                    case TypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1492, 4862, 5686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 5111, 5156);

                        return s_int64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1492, 5118, 5155) ?? (s_int64 = f_1492_5140_5154()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1492, 4862, 5686);

                    case TypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1492, 4862, 5686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 5196, 5244);

                        return s_UInt16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1492, 5203, 5243) ?? (s_UInt16 = f_1492_5227_5242()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1492, 4862, 5686);

                    case TypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1492, 4862, 5686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 5284, 5332);

                        return s_UInt32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1492, 5291, 5331) ?? (s_UInt32 = f_1492_5315_5330()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1492, 4862, 5686);

                    case TypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1492, 4862, 5686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 5372, 5420);

                        return s_UInt64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1492, 5379, 5419) ?? (s_UInt64 = f_1492_5403_5418()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1492, 4862, 5686);

                    case TypeCode.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1492, 4862, 5686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 5460, 5508);

                        return s_single ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1492, 5467, 5507) ?? (s_single = f_1492_5491_5506()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1492, 4862, 5686);

                    case TypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1492, 4862, 5686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 5548, 5596);

                        return s_double ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1492, 5555, 5595) ?? (s_double = f_1492_5579_5594()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1492, 4862, 5686);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1492, 4862, 5686);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 5646, 5671);

                        throw f_1492_5652_5670();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1492, 4862, 5686);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1492, 4753, 5697);

                bool
                f_1492_4834_4846_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1492, 4834, 4846);
                    return return_v;
                }


                int
                f_1492_4821_4847(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1492, 4821, 4847);
                    return 0;
                }


                System.TypeCode
                f_1492_4870_4888(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1492, 4870, 4888);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DivInstruction.DivInt16
                f_1492_4972_4986()
                {
                    var return_v = new System.Management.Automation.Interpreter.DivInstruction.DivInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1492, 4972, 4986);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DivInstruction.DivInt32
                f_1492_5056_5070()
                {
                    var return_v = new System.Management.Automation.Interpreter.DivInstruction.DivInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1492, 5056, 5070);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DivInstruction.DivInt64
                f_1492_5140_5154()
                {
                    var return_v = new System.Management.Automation.Interpreter.DivInstruction.DivInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1492, 5140, 5154);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DivInstruction.DivUInt16
                f_1492_5227_5242()
                {
                    var return_v = new System.Management.Automation.Interpreter.DivInstruction.DivUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1492, 5227, 5242);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DivInstruction.DivUInt32
                f_1492_5315_5330()
                {
                    var return_v = new System.Management.Automation.Interpreter.DivInstruction.DivUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1492, 5315, 5330);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DivInstruction.DivUInt64
                f_1492_5403_5418()
                {
                    var return_v = new System.Management.Automation.Interpreter.DivInstruction.DivUInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1492, 5403, 5418);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DivInstruction.DivSingle
                f_1492_5491_5506()
                {
                    var return_v = new System.Management.Automation.Interpreter.DivInstruction.DivSingle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1492, 5491, 5506);
                    return return_v;
                }


                System.Management.Automation.Interpreter.DivInstruction.DivDouble
                f_1492_5579_5594()
                {
                    var return_v = new System.Management.Automation.Interpreter.DivInstruction.DivDouble();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1492, 5579, 5594);
                    return return_v;
                }


                System.Exception
                f_1492_5652_5670()
                {
                    var return_v = Assert.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1492, 5652, 5670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1492, 4753, 5697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 4753, 5697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1492, 5709, 5793);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 5767, 5782);

                return "Div()";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1492, 5709, 5793);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1492, 5709, 5793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 5709, 5793);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DivInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1492, 803, 5800);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 899, 906);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 908, 915);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 917, 924);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 926, 934);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 936, 944);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 946, 954);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 956, 964);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1492, 966, 974);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1492, 803, 5800);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1492, 803, 5800);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1492, 803, 5800);
    }
}
