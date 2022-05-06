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
    internal abstract class GreaterThanInstruction : Instruction
    {
        private static Instruction s_SByte, s_int16, s_char, s_int32, s_int64, s_byte, s_UInt16, s_UInt32, s_UInt64, s_single, s_double;

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1498, 1056, 1073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 1062, 1071);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1498, 1056, 1073);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 1020, 1075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 1020, 1075);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1498, 1123, 1140);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 1129, 1138);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1498, 1123, 1140);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 1087, 1142);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 1087, 1142);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private GreaterThanInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1498, 1154, 1208);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1498, 1154, 1208);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 1154, 1208);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 1154, 1208);
            }
        }
        internal sealed class GreaterThanSByte : GreaterThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1498, 1308, 1523);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 1388, 1421);

                    sbyte
                    right = (sbyte)f_1498_1409_1420(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 1439, 1480);

                    f_1498_1439_1479(frame, ((sbyte)f_1498_1458_1469(frame)) > right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 1498, 1508);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1498, 1308, 1523);

                    object
                    f_1498_1409_1420(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 1409, 1420);
                        return return_v;
                    }


                    object
                    f_1498_1458_1469(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 1458, 1469);
                        return return_v;
                    }


                    int
                    f_1498_1439_1479(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 1439, 1479);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 1308, 1523);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 1308, 1523);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public GreaterThanSByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1498, 1220, 1534);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1498, 1220, 1534);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 1220, 1534);
            }


            static GreaterThanSByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1498, 1220, 1534);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1498, 1220, 1534);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 1220, 1534);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1498, 1220, 1534);
        }
        internal sealed class GreaterThanInt16 : GreaterThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1498, 1634, 1849);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 1714, 1747);

                    Int16
                    right = (Int16)f_1498_1735_1746(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 1765, 1806);

                    f_1498_1765_1805(frame, ((Int16)f_1498_1784_1795(frame)) > right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 1824, 1834);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1498, 1634, 1849);

                    object
                    f_1498_1735_1746(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 1735, 1746);
                        return return_v;
                    }


                    object
                    f_1498_1784_1795(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 1784, 1795);
                        return return_v;
                    }


                    int
                    f_1498_1765_1805(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 1765, 1805);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 1634, 1849);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 1634, 1849);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public GreaterThanInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1498, 1546, 1860);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1498, 1546, 1860);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 1546, 1860);
            }


            static GreaterThanInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1498, 1546, 1860);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1498, 1546, 1860);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 1546, 1860);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1498, 1546, 1860);
        }
        internal sealed class GreaterThanChar : GreaterThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1498, 1959, 2171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 2039, 2070);

                    char
                    right = (char)f_1498_2058_2069(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 2088, 2128);

                    f_1498_2088_2127(frame, ((char)f_1498_2106_2117(frame)) > right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 2146, 2156);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1498, 1959, 2171);

                    object
                    f_1498_2058_2069(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 2058, 2069);
                        return return_v;
                    }


                    object
                    f_1498_2106_2117(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 2106, 2117);
                        return return_v;
                    }


                    int
                    f_1498_2088_2127(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 2088, 2127);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 1959, 2171);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 1959, 2171);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public GreaterThanChar()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1498, 1872, 2182);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1498, 1872, 2182);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 1872, 2182);
            }


            static GreaterThanChar()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1498, 1872, 2182);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1498, 1872, 2182);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 1872, 2182);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1498, 1872, 2182);
        }
        internal sealed class GreaterThanInt32 : GreaterThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1498, 2282, 2497);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 2362, 2395);

                    Int32
                    right = (Int32)f_1498_2383_2394(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 2413, 2454);

                    f_1498_2413_2453(frame, ((Int32)f_1498_2432_2443(frame)) > right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 2472, 2482);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1498, 2282, 2497);

                    object
                    f_1498_2383_2394(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 2383, 2394);
                        return return_v;
                    }


                    object
                    f_1498_2432_2443(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 2432, 2443);
                        return return_v;
                    }


                    int
                    f_1498_2413_2453(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 2413, 2453);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 2282, 2497);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 2282, 2497);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public GreaterThanInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1498, 2194, 2508);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1498, 2194, 2508);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 2194, 2508);
            }


            static GreaterThanInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1498, 2194, 2508);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1498, 2194, 2508);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 2194, 2508);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1498, 2194, 2508);
        }
        internal sealed class GreaterThanInt64 : GreaterThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1498, 2608, 2823);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 2688, 2721);

                    Int64
                    right = (Int64)f_1498_2709_2720(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 2739, 2780);

                    f_1498_2739_2779(frame, ((Int64)f_1498_2758_2769(frame)) > right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 2798, 2808);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1498, 2608, 2823);

                    object
                    f_1498_2709_2720(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 2709, 2720);
                        return return_v;
                    }


                    object
                    f_1498_2758_2769(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 2758, 2769);
                        return return_v;
                    }


                    int
                    f_1498_2739_2779(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 2739, 2779);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 2608, 2823);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 2608, 2823);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public GreaterThanInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1498, 2520, 2834);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1498, 2520, 2834);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 2520, 2834);
            }


            static GreaterThanInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1498, 2520, 2834);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1498, 2520, 2834);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 2520, 2834);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1498, 2520, 2834);
        }
        internal sealed class GreaterThanByte : GreaterThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1498, 2933, 3145);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 3013, 3044);

                    byte
                    right = (byte)f_1498_3032_3043(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 3062, 3102);

                    f_1498_3062_3101(frame, ((byte)f_1498_3080_3091(frame)) > right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 3120, 3130);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1498, 2933, 3145);

                    object
                    f_1498_3032_3043(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 3032, 3043);
                        return return_v;
                    }


                    object
                    f_1498_3080_3091(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 3080, 3091);
                        return return_v;
                    }


                    int
                    f_1498_3062_3101(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 3062, 3101);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 2933, 3145);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 2933, 3145);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public GreaterThanByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1498, 2846, 3156);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1498, 2846, 3156);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 2846, 3156);
            }


            static GreaterThanByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1498, 2846, 3156);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1498, 2846, 3156);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 2846, 3156);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1498, 2846, 3156);
        }
        internal sealed class GreaterThanUInt16 : GreaterThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1498, 3257, 3475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 3337, 3372);

                    UInt16
                    right = (UInt16)f_1498_3360_3371(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 3390, 3432);

                    f_1498_3390_3431(frame, ((UInt16)f_1498_3410_3421(frame)) > right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 3450, 3460);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1498, 3257, 3475);

                    object
                    f_1498_3360_3371(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 3360, 3371);
                        return return_v;
                    }


                    object
                    f_1498_3410_3421(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 3410, 3421);
                        return return_v;
                    }


                    int
                    f_1498_3390_3431(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 3390, 3431);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 3257, 3475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 3257, 3475);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public GreaterThanUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1498, 3168, 3486);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1498, 3168, 3486);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 3168, 3486);
            }


            static GreaterThanUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1498, 3168, 3486);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1498, 3168, 3486);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 3168, 3486);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1498, 3168, 3486);
        }
        internal sealed class GreaterThanUInt32 : GreaterThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1498, 3587, 3805);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 3667, 3702);

                    UInt32
                    right = (UInt32)f_1498_3690_3701(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 3720, 3762);

                    f_1498_3720_3761(frame, ((UInt32)f_1498_3740_3751(frame)) > right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 3780, 3790);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1498, 3587, 3805);

                    object
                    f_1498_3690_3701(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 3690, 3701);
                        return return_v;
                    }


                    object
                    f_1498_3740_3751(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 3740, 3751);
                        return return_v;
                    }


                    int
                    f_1498_3720_3761(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 3720, 3761);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 3587, 3805);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 3587, 3805);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public GreaterThanUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1498, 3498, 3816);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1498, 3498, 3816);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 3498, 3816);
            }


            static GreaterThanUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1498, 3498, 3816);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1498, 3498, 3816);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 3498, 3816);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1498, 3498, 3816);
        }
        internal sealed class GreaterThanUInt64 : GreaterThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1498, 3917, 4135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 3997, 4032);

                    UInt64
                    right = (UInt64)f_1498_4020_4031(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 4050, 4092);

                    f_1498_4050_4091(frame, ((UInt64)f_1498_4070_4081(frame)) > right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 4110, 4120);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1498, 3917, 4135);

                    object
                    f_1498_4020_4031(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 4020, 4031);
                        return return_v;
                    }


                    object
                    f_1498_4070_4081(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 4070, 4081);
                        return return_v;
                    }


                    int
                    f_1498_4050_4091(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 4050, 4091);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 3917, 4135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 3917, 4135);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public GreaterThanUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1498, 3828, 4146);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1498, 3828, 4146);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 3828, 4146);
            }


            static GreaterThanUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1498, 3828, 4146);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1498, 3828, 4146);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 3828, 4146);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1498, 3828, 4146);
        }
        internal sealed class GreaterThanSingle : GreaterThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1498, 4247, 4465);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 4327, 4362);

                    Single
                    right = (Single)f_1498_4350_4361(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 4380, 4422);

                    f_1498_4380_4421(frame, ((Single)f_1498_4400_4411(frame)) > right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 4440, 4450);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1498, 4247, 4465);

                    object
                    f_1498_4350_4361(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 4350, 4361);
                        return return_v;
                    }


                    object
                    f_1498_4400_4411(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 4400, 4411);
                        return return_v;
                    }


                    int
                    f_1498_4380_4421(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 4380, 4421);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 4247, 4465);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 4247, 4465);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public GreaterThanSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1498, 4158, 4476);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1498, 4158, 4476);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 4158, 4476);
            }


            static GreaterThanSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1498, 4158, 4476);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1498, 4158, 4476);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 4158, 4476);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1498, 4158, 4476);
        }
        internal sealed class GreaterThanDouble : GreaterThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1498, 4577, 4795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 4657, 4692);

                    double
                    right = (double)f_1498_4680_4691(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 4710, 4752);

                    f_1498_4710_4751(frame, ((double)f_1498_4730_4741(frame)) > right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 4770, 4780);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1498, 4577, 4795);

                    object
                    f_1498_4680_4691(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 4680, 4691);
                        return return_v;
                    }


                    object
                    f_1498_4730_4741(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 4730, 4741);
                        return return_v;
                    }


                    int
                    f_1498_4710_4751(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 4710, 4751);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 4577, 4795);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 4577, 4795);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public GreaterThanDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1498, 4488, 4806);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1498, 4488, 4806);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 4488, 4806);
            }


            static GreaterThanDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1498, 4488, 4806);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1498, 4488, 4806);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 4488, 4806);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1498, 4488, 4806);
        }

        public static Instruction Create(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1498, 4818, 6094);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 4886, 4913);

                f_1498_4886_4912(f_1498_4899_4911_M(!type.IsEnum));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 4927, 6083);

                switch (f_1498_4935_4953(type))
                {

                    case TypeCode.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1498, 4927, 6083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 5008, 5061);

                        return s_SByte ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1498, 5015, 5060) ?? (s_SByte = f_1498_5037_5059()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1498, 4927, 6083);

                    case TypeCode.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1498, 4927, 6083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 5099, 5149);

                        return s_byte ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1498, 5106, 5148) ?? (s_byte = f_1498_5126_5147()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1498, 4927, 6083);

                    case TypeCode.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1498, 4927, 6083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 5187, 5237);

                        return s_char ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1498, 5194, 5236) ?? (s_char = f_1498_5214_5235()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1498, 4927, 6083);

                    case TypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1498, 4927, 6083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 5276, 5329);

                        return s_int16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1498, 5283, 5328) ?? (s_int16 = f_1498_5305_5327()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1498, 4927, 6083);

                    case TypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1498, 4927, 6083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 5368, 5421);

                        return s_int32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1498, 5375, 5420) ?? (s_int32 = f_1498_5397_5419()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1498, 4927, 6083);

                    case TypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1498, 4927, 6083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 5460, 5513);

                        return s_int64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1498, 5467, 5512) ?? (s_int64 = f_1498_5489_5511()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1498, 4927, 6083);

                    case TypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1498, 4927, 6083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 5553, 5609);

                        return s_UInt16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1498, 5560, 5608) ?? (s_UInt16 = f_1498_5584_5607()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1498, 4927, 6083);

                    case TypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1498, 4927, 6083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 5649, 5705);

                        return s_UInt32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1498, 5656, 5704) ?? (s_UInt32 = f_1498_5680_5703()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1498, 4927, 6083);

                    case TypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1498, 4927, 6083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 5745, 5801);

                        return s_UInt64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1498, 5752, 5800) ?? (s_UInt64 = f_1498_5776_5799()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1498, 4927, 6083);

                    case TypeCode.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1498, 4927, 6083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 5841, 5897);

                        return s_single ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1498, 5848, 5896) ?? (s_single = f_1498_5872_5895()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1498, 4927, 6083);

                    case TypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1498, 4927, 6083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 5937, 5993);

                        return s_double ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1498, 5944, 5992) ?? (s_double = f_1498_5968_5991()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1498, 4927, 6083);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1498, 4927, 6083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 6043, 6068);

                        throw f_1498_6049_6067();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1498, 4927, 6083);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1498, 4818, 6094);

                bool
                f_1498_4899_4911_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1498, 4899, 4911);
                    return return_v;
                }


                int
                f_1498_4886_4912(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 4886, 4912);
                    return 0;
                }


                System.TypeCode
                f_1498_4935_4953(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 4935, 4953);
                    return return_v;
                }


                System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanSByte
                f_1498_5037_5059()
                {
                    var return_v = new System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanSByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 5037, 5059);
                    return return_v;
                }


                System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanByte
                f_1498_5126_5147()
                {
                    var return_v = new System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 5126, 5147);
                    return return_v;
                }


                System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanChar
                f_1498_5214_5235()
                {
                    var return_v = new System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 5214, 5235);
                    return return_v;
                }


                System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanInt16
                f_1498_5305_5327()
                {
                    var return_v = new System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 5305, 5327);
                    return return_v;
                }


                System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanInt32
                f_1498_5397_5419()
                {
                    var return_v = new System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 5397, 5419);
                    return return_v;
                }


                System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanInt64
                f_1498_5489_5511()
                {
                    var return_v = new System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 5489, 5511);
                    return return_v;
                }


                System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanUInt16
                f_1498_5584_5607()
                {
                    var return_v = new System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 5584, 5607);
                    return return_v;
                }


                System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanUInt32
                f_1498_5680_5703()
                {
                    var return_v = new System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 5680, 5703);
                    return return_v;
                }


                System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanUInt64
                f_1498_5776_5799()
                {
                    var return_v = new System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanUInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 5776, 5799);
                    return return_v;
                }


                System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanSingle
                f_1498_5872_5895()
                {
                    var return_v = new System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanSingle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 5872, 5895);
                    return return_v;
                }


                System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanDouble
                f_1498_5968_5991()
                {
                    var return_v = new System.Management.Automation.Interpreter.GreaterThanInstruction.GreaterThanDouble();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1498, 5968, 5991);
                    return return_v;
                }


                System.Exception
                f_1498_6049_6067()
                {
                    var return_v = Assert.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1498, 6049, 6067);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 4818, 6094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 4818, 6094);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1498, 6106, 6198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 6164, 6187);

                return "GreaterThan()";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1498, 6106, 6198);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1498, 6106, 6198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 6106, 6198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static GreaterThanInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1498, 803, 6205);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 907, 914);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 916, 923);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 925, 931);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 933, 940);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 942, 949);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 951, 957);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 959, 967);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 969, 977);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 979, 987);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 989, 997);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1498, 999, 1007);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1498, 803, 6205);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1498, 803, 6205);
        }

        int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1498, 803, 6205);
    }
}
