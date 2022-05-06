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

namespace System.Management.Automation.Interpreter
{
    internal abstract class EqualInstruction : Instruction
    {
        private static Instruction s_reference, s_boolean, s_SByte, s_int16, s_char, s_int32, s_int64, s_byte, s_UInt16, s_UInt32, s_UInt64, s_single, s_double;

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 1141, 1158);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1147, 1156);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 1141, 1158);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 1105, 1160);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 1105, 1160);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 1208, 1225);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1214, 1223);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 1208, 1225);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 1172, 1227);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 1172, 1227);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private EqualInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1496, 1239, 1287);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1496, 1239, 1287);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 1239, 1287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 1239, 1287);
            }
        }
        internal sealed class EqualBoolean : EqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 1377, 1555);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1457, 1512);

                    f_1496_1457_1511(frame, ((bool)f_1496_1475_1486(frame)) == ((bool)f_1496_1498_1509(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1530, 1540);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 1377, 1555);

                    object
                    f_1496_1475_1486(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 1475, 1486);
                        return return_v;
                    }


                    object
                    f_1496_1498_1509(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 1498, 1509);
                        return return_v;
                    }


                    int
                    f_1496_1457_1511(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 1457, 1511);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 1377, 1555);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 1377, 1555);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EqualBoolean()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1496, 1299, 1566);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1496, 1299, 1566);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 1299, 1566);
            }


            static EqualBoolean()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1496, 1299, 1566);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1496, 1299, 1566);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 1299, 1566);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1496, 1299, 1566);
        }
        internal sealed class EqualSByte : EqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 1654, 1834);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1734, 1791);

                    f_1496_1734_1790(frame, ((sbyte)f_1496_1753_1764(frame)) == ((sbyte)f_1496_1777_1788(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1809, 1819);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 1654, 1834);

                    object
                    f_1496_1753_1764(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 1753, 1764);
                        return return_v;
                    }


                    object
                    f_1496_1777_1788(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 1777, 1788);
                        return return_v;
                    }


                    int
                    f_1496_1734_1790(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 1734, 1790);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 1654, 1834);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 1654, 1834);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EqualSByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1496, 1578, 1845);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1496, 1578, 1845);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 1578, 1845);
            }


            static EqualSByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1496, 1578, 1845);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1496, 1578, 1845);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 1578, 1845);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1496, 1578, 1845);
        }
        internal sealed class EqualInt16 : EqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 1933, 2113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 2013, 2070);

                    f_1496_2013_2069(frame, ((Int16)f_1496_2032_2043(frame)) == ((Int16)f_1496_2056_2067(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 2088, 2098);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 1933, 2113);

                    object
                    f_1496_2032_2043(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 2032, 2043);
                        return return_v;
                    }


                    object
                    f_1496_2056_2067(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 2056, 2067);
                        return return_v;
                    }


                    int
                    f_1496_2013_2069(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 2013, 2069);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 1933, 2113);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 1933, 2113);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EqualInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1496, 1857, 2124);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1496, 1857, 2124);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 1857, 2124);
            }


            static EqualInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1496, 1857, 2124);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1496, 1857, 2124);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 1857, 2124);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1496, 1857, 2124);
        }
        internal sealed class EqualChar : EqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 2211, 2389);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 2291, 2346);

                    f_1496_2291_2345(frame, ((char)f_1496_2309_2320(frame)) == ((char)f_1496_2332_2343(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 2364, 2374);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 2211, 2389);

                    object
                    f_1496_2309_2320(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 2309, 2320);
                        return return_v;
                    }


                    object
                    f_1496_2332_2343(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 2332, 2343);
                        return return_v;
                    }


                    int
                    f_1496_2291_2345(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 2291, 2345);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 2211, 2389);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 2211, 2389);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EqualChar()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1496, 2136, 2400);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1496, 2136, 2400);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 2136, 2400);
            }


            static EqualChar()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1496, 2136, 2400);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1496, 2136, 2400);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 2136, 2400);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1496, 2136, 2400);
        }
        internal sealed class EqualInt32 : EqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 2488, 2668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 2568, 2625);

                    f_1496_2568_2624(frame, ((Int32)f_1496_2587_2598(frame)) == ((Int32)f_1496_2611_2622(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 2643, 2653);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 2488, 2668);

                    object
                    f_1496_2587_2598(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 2587, 2598);
                        return return_v;
                    }


                    object
                    f_1496_2611_2622(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 2611, 2622);
                        return return_v;
                    }


                    int
                    f_1496_2568_2624(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 2568, 2624);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 2488, 2668);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 2488, 2668);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EqualInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1496, 2412, 2679);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1496, 2412, 2679);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 2412, 2679);
            }


            static EqualInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1496, 2412, 2679);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1496, 2412, 2679);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 2412, 2679);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1496, 2412, 2679);
        }
        internal sealed class EqualInt64 : EqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 2767, 2947);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 2847, 2904);

                    f_1496_2847_2903(frame, ((Int64)f_1496_2866_2877(frame)) == ((Int64)f_1496_2890_2901(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 2922, 2932);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 2767, 2947);

                    object
                    f_1496_2866_2877(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 2866, 2877);
                        return return_v;
                    }


                    object
                    f_1496_2890_2901(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 2890, 2901);
                        return return_v;
                    }


                    int
                    f_1496_2847_2903(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 2847, 2903);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 2767, 2947);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 2767, 2947);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EqualInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1496, 2691, 2958);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1496, 2691, 2958);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 2691, 2958);
            }


            static EqualInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1496, 2691, 2958);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1496, 2691, 2958);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 2691, 2958);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1496, 2691, 2958);
        }
        internal sealed class EqualByte : EqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 3045, 3223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 3125, 3180);

                    f_1496_3125_3179(frame, ((byte)f_1496_3143_3154(frame)) == ((byte)f_1496_3166_3177(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 3198, 3208);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 3045, 3223);

                    object
                    f_1496_3143_3154(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 3143, 3154);
                        return return_v;
                    }


                    object
                    f_1496_3166_3177(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 3166, 3177);
                        return return_v;
                    }


                    int
                    f_1496_3125_3179(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 3125, 3179);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 3045, 3223);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 3045, 3223);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EqualByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1496, 2970, 3234);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1496, 2970, 3234);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 2970, 3234);
            }


            static EqualByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1496, 2970, 3234);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1496, 2970, 3234);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 2970, 3234);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1496, 2970, 3234);
        }
        internal sealed class EqualUInt16 : EqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 3323, 3505);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 3403, 3462);

                    f_1496_3403_3461(frame, ((UInt16)f_1496_3423_3434(frame)) == ((UInt16)f_1496_3448_3459(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 3480, 3490);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 3323, 3505);

                    object
                    f_1496_3423_3434(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 3423, 3434);
                        return return_v;
                    }


                    object
                    f_1496_3448_3459(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 3448, 3459);
                        return return_v;
                    }


                    int
                    f_1496_3403_3461(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 3403, 3461);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 3323, 3505);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 3323, 3505);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EqualUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1496, 3246, 3516);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1496, 3246, 3516);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 3246, 3516);
            }


            static EqualUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1496, 3246, 3516);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1496, 3246, 3516);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 3246, 3516);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1496, 3246, 3516);
        }
        internal sealed class EqualUInt32 : EqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 3605, 3787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 3685, 3744);

                    f_1496_3685_3743(frame, ((UInt32)f_1496_3705_3716(frame)) == ((UInt32)f_1496_3730_3741(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 3762, 3772);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 3605, 3787);

                    object
                    f_1496_3705_3716(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 3705, 3716);
                        return return_v;
                    }


                    object
                    f_1496_3730_3741(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 3730, 3741);
                        return return_v;
                    }


                    int
                    f_1496_3685_3743(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 3685, 3743);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 3605, 3787);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 3605, 3787);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EqualUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1496, 3528, 3798);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1496, 3528, 3798);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 3528, 3798);
            }


            static EqualUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1496, 3528, 3798);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1496, 3528, 3798);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 3528, 3798);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1496, 3528, 3798);
        }
        internal sealed class EqualUInt64 : EqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 3887, 4069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 3967, 4026);

                    f_1496_3967_4025(frame, ((UInt64)f_1496_3987_3998(frame)) == ((UInt64)f_1496_4012_4023(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 4044, 4054);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 3887, 4069);

                    object
                    f_1496_3987_3998(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 3987, 3998);
                        return return_v;
                    }


                    object
                    f_1496_4012_4023(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 4012, 4023);
                        return return_v;
                    }


                    int
                    f_1496_3967_4025(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 3967, 4025);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 3887, 4069);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 3887, 4069);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EqualUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1496, 3810, 4080);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1496, 3810, 4080);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 3810, 4080);
            }


            static EqualUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1496, 3810, 4080);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1496, 3810, 4080);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 3810, 4080);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1496, 3810, 4080);
        }
        internal sealed class EqualSingle : EqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 4169, 4351);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 4249, 4308);

                    f_1496_4249_4307(frame, ((Single)f_1496_4269_4280(frame)) == ((Single)f_1496_4294_4305(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 4326, 4336);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 4169, 4351);

                    object
                    f_1496_4269_4280(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 4269, 4280);
                        return return_v;
                    }


                    object
                    f_1496_4294_4305(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 4294, 4305);
                        return return_v;
                    }


                    int
                    f_1496_4249_4307(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 4249, 4307);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 4169, 4351);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 4169, 4351);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EqualSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1496, 4092, 4362);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1496, 4092, 4362);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 4092, 4362);
            }


            static EqualSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1496, 4092, 4362);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1496, 4092, 4362);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 4092, 4362);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1496, 4092, 4362);
        }
        internal sealed class EqualDouble : EqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 4451, 4633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 4531, 4590);

                    f_1496_4531_4589(frame, ((double)f_1496_4551_4562(frame)) == ((double)f_1496_4576_4587(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 4608, 4618);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 4451, 4633);

                    object
                    f_1496_4551_4562(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 4551, 4562);
                        return return_v;
                    }


                    object
                    f_1496_4576_4587(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 4576, 4587);
                        return return_v;
                    }


                    int
                    f_1496_4531_4589(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 4531, 4589);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 4451, 4633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 4451, 4633);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EqualDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1496, 4374, 4644);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1496, 4374, 4644);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 4374, 4644);
            }


            static EqualDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1496, 4374, 4644);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1496, 4374, 4644);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 4374, 4644);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1496, 4374, 4644);
        }
        internal sealed class EqualReference : EqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 4736, 4898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 4816, 4855);

                    f_1496_4816_4854(frame, f_1496_4827_4838(frame) == f_1496_4842_4853(frame));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 4873, 4883);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 4736, 4898);

                    object
                    f_1496_4827_4838(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 4827, 4838);
                        return return_v;
                    }


                    object
                    f_1496_4842_4853(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 4842, 4853);
                        return return_v;
                    }


                    int
                    f_1496_4816_4854(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 4816, 4854);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 4736, 4898);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 4736, 4898);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public EqualReference()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1496, 4656, 4909);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1496, 4656, 4909);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 4656, 4909);
            }


            static EqualReference()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1496, 4656, 4909);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1496, 4656, 4909);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 4656, 4909);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1496, 4656, 4909);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public static Instruction Create(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1496, 4921, 6790);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 5182, 5248);

                var
                typeToUse = (DynAbs.Tracing.TraceSender.Conditional_F1(1496, 5198, 5209) || ((f_1496_5198_5209(type) && DynAbs.Tracing.TraceSender.Conditional_F2(1496, 5212, 5240)) || DynAbs.Tracing.TraceSender.Conditional_F3(1496, 5243, 5247))) ? f_1496_5212_5240(type) : type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 5262, 6779);

                switch (f_1496_5270_5293(typeToUse))
                {

                    case TypeCode.Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 5262, 6779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 5350, 5403);

                        return s_boolean ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1496, 5357, 5402) ?? (s_boolean = f_1496_5383_5401()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 5262, 6779);

                    case TypeCode.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 5262, 6779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 5442, 5489);

                        return s_SByte ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1496, 5449, 5488) ?? (s_SByte = f_1496_5471_5487()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 5262, 6779);

                    case TypeCode.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 5262, 6779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 5527, 5571);

                        return s_byte ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1496, 5534, 5570) ?? (s_byte = f_1496_5554_5569()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 5262, 6779);

                    case TypeCode.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 5262, 6779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 5609, 5653);

                        return s_char ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1496, 5616, 5652) ?? (s_char = f_1496_5636_5651()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 5262, 6779);

                    case TypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 5262, 6779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 5692, 5739);

                        return s_int16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1496, 5699, 5738) ?? (s_int16 = f_1496_5721_5737()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 5262, 6779);

                    case TypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 5262, 6779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 5778, 5825);

                        return s_int32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1496, 5785, 5824) ?? (s_int32 = f_1496_5807_5823()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 5262, 6779);

                    case TypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 5262, 6779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 5864, 5911);

                        return s_int64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1496, 5871, 5910) ?? (s_int64 = f_1496_5893_5909()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 5262, 6779);

                    case TypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 5262, 6779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 5953, 6002);

                        return s_UInt16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1496, 5960, 6001) ?? (s_UInt16 = f_1496_5984_6000()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 5262, 6779);

                    case TypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 5262, 6779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 6042, 6091);

                        return s_UInt32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1496, 6049, 6090) ?? (s_UInt32 = f_1496_6073_6089()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 5262, 6779);

                    case TypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 5262, 6779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 6131, 6180);

                        return s_UInt64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1496, 6138, 6179) ?? (s_UInt64 = f_1496_6162_6178()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 5262, 6779);

                    case TypeCode.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 5262, 6779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 6222, 6272);

                        return s_single ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1496, 6229, 6271) ?? (s_single = f_1496_6253_6270()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 5262, 6779);

                    case TypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 5262, 6779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 6312, 6362);

                        return s_double ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1496, 6319, 6361) ?? (s_double = f_1496_6343_6360()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 5262, 6779);

                    case TypeCode.Object:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 5262, 6779);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 6425, 6578) || true) && (f_1496_6429_6446_M(!type.IsValueType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 6425, 6578);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 6496, 6555);

                            return s_reference ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1496, 6503, 6554) ?? (s_reference = f_1496_6533_6553()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 6425, 6578);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 6642, 6678);

                        throw f_1496_6648_6677();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 5262, 6779);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1496, 5262, 6779);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 6728, 6764);

                        throw f_1496_6734_6763();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1496, 5262, 6779);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1496, 4921, 6790);

                bool
                f_1496_5198_5209(System.Type
                this_param)
                {
                    var return_v = this_param.IsEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1496, 5198, 5209);
                    return return_v;
                }


                System.Type
                f_1496_5212_5240(System.Type
                enumType)
                {
                    var return_v = Enum.GetUnderlyingType(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 5212, 5240);
                    return return_v;
                }


                System.TypeCode
                f_1496_5270_5293(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 5270, 5293);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EqualInstruction.EqualBoolean
                f_1496_5383_5401()
                {
                    var return_v = new System.Management.Automation.Interpreter.EqualInstruction.EqualBoolean();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 5383, 5401);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EqualInstruction.EqualSByte
                f_1496_5471_5487()
                {
                    var return_v = new System.Management.Automation.Interpreter.EqualInstruction.EqualSByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 5471, 5487);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EqualInstruction.EqualByte
                f_1496_5554_5569()
                {
                    var return_v = new System.Management.Automation.Interpreter.EqualInstruction.EqualByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 5554, 5569);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EqualInstruction.EqualChar
                f_1496_5636_5651()
                {
                    var return_v = new System.Management.Automation.Interpreter.EqualInstruction.EqualChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 5636, 5651);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EqualInstruction.EqualInt16
                f_1496_5721_5737()
                {
                    var return_v = new System.Management.Automation.Interpreter.EqualInstruction.EqualInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 5721, 5737);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EqualInstruction.EqualInt32
                f_1496_5807_5823()
                {
                    var return_v = new System.Management.Automation.Interpreter.EqualInstruction.EqualInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 5807, 5823);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EqualInstruction.EqualInt64
                f_1496_5893_5909()
                {
                    var return_v = new System.Management.Automation.Interpreter.EqualInstruction.EqualInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 5893, 5909);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EqualInstruction.EqualInt16
                f_1496_5984_6000()
                {
                    var return_v = new System.Management.Automation.Interpreter.EqualInstruction.EqualInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 5984, 6000);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EqualInstruction.EqualInt32
                f_1496_6073_6089()
                {
                    var return_v = new System.Management.Automation.Interpreter.EqualInstruction.EqualInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 6073, 6089);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EqualInstruction.EqualInt64
                f_1496_6162_6178()
                {
                    var return_v = new System.Management.Automation.Interpreter.EqualInstruction.EqualInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 6162, 6178);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EqualInstruction.EqualSingle
                f_1496_6253_6270()
                {
                    var return_v = new System.Management.Automation.Interpreter.EqualInstruction.EqualSingle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 6253, 6270);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EqualInstruction.EqualDouble
                f_1496_6343_6360()
                {
                    var return_v = new System.Management.Automation.Interpreter.EqualInstruction.EqualDouble();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 6343, 6360);
                    return return_v;
                }


                bool
                f_1496_6429_6446_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1496, 6429, 6446);
                    return return_v;
                }


                System.Management.Automation.Interpreter.EqualInstruction.EqualReference
                f_1496_6533_6553()
                {
                    var return_v = new System.Management.Automation.Interpreter.EqualInstruction.EqualReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 6533, 6553);
                    return return_v;
                }


                System.NotImplementedException
                f_1496_6648_6677()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 6648, 6677);
                    return return_v;
                }


                System.NotImplementedException
                f_1496_6734_6763()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1496, 6734, 6763);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 4921, 6790);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 4921, 6790);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1496, 6802, 6888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 6860, 6877);

                return "Equal()";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1496, 6802, 6888);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1496, 6802, 6888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 6802, 6888);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static EqualInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1496, 802, 6895);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 968, 979);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 981, 990);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 992, 999);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1001, 1008);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1010, 1016);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1018, 1025);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1027, 1034);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1036, 1042);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1044, 1052);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1054, 1062);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1064, 1072);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1074, 1082);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1496, 1084, 1092);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1496, 802, 6895);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1496, 802, 6895);
        }

        int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1496, 802, 6895);
    }
}
