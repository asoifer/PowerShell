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
    internal abstract class LessThanInstruction : Instruction
    {
        private static Instruction s_SByte, s_int16, s_char, s_int32, s_int64, s_byte, s_UInt16, s_UInt32, s_UInt64, s_single, s_double;

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1506, 1053, 1070);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 1059, 1068);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1506, 1053, 1070);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 1017, 1072);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 1017, 1072);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1506, 1120, 1137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 1126, 1135);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1506, 1120, 1137);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 1084, 1139);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 1084, 1139);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private LessThanInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1506, 1151, 1202);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1506, 1151, 1202);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 1151, 1202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 1151, 1202);
            }
        }
        internal sealed class LessThanSByte : LessThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1506, 1296, 1511);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 1376, 1409);

                    sbyte
                    right = (sbyte)f_1506_1397_1408(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 1427, 1468);

                    f_1506_1427_1467(frame, ((sbyte)f_1506_1446_1457(frame)) < right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 1486, 1496);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1506, 1296, 1511);

                    object
                    f_1506_1397_1408(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 1397, 1408);
                        return return_v;
                    }


                    object
                    f_1506_1446_1457(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 1446, 1457);
                        return return_v;
                    }


                    int
                    f_1506_1427_1467(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 1427, 1467);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 1296, 1511);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 1296, 1511);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LessThanSByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1506, 1214, 1522);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1506, 1214, 1522);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 1214, 1522);
            }


            static LessThanSByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1506, 1214, 1522);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1506, 1214, 1522);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 1214, 1522);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1506, 1214, 1522);
        }
        internal sealed class LessThanInt16 : LessThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1506, 1616, 1831);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 1696, 1729);

                    Int16
                    right = (Int16)f_1506_1717_1728(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 1747, 1788);

                    f_1506_1747_1787(frame, ((Int16)f_1506_1766_1777(frame)) < right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 1806, 1816);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1506, 1616, 1831);

                    object
                    f_1506_1717_1728(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 1717, 1728);
                        return return_v;
                    }


                    object
                    f_1506_1766_1777(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 1766, 1777);
                        return return_v;
                    }


                    int
                    f_1506_1747_1787(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 1747, 1787);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 1616, 1831);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 1616, 1831);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LessThanInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1506, 1534, 1842);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1506, 1534, 1842);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 1534, 1842);
            }


            static LessThanInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1506, 1534, 1842);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1506, 1534, 1842);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 1534, 1842);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1506, 1534, 1842);
        }
        internal sealed class LessThanChar : LessThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1506, 1935, 2147);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 2015, 2046);

                    char
                    right = (char)f_1506_2034_2045(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 2064, 2104);

                    f_1506_2064_2103(frame, ((char)f_1506_2082_2093(frame)) < right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 2122, 2132);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1506, 1935, 2147);

                    object
                    f_1506_2034_2045(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 2034, 2045);
                        return return_v;
                    }


                    object
                    f_1506_2082_2093(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 2082, 2093);
                        return return_v;
                    }


                    int
                    f_1506_2064_2103(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 2064, 2103);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 1935, 2147);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 1935, 2147);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LessThanChar()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1506, 1854, 2158);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1506, 1854, 2158);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 1854, 2158);
            }


            static LessThanChar()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1506, 1854, 2158);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1506, 1854, 2158);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 1854, 2158);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1506, 1854, 2158);
        }
        internal sealed class LessThanInt32 : LessThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1506, 2252, 2467);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 2332, 2365);

                    Int32
                    right = (Int32)f_1506_2353_2364(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 2383, 2424);

                    f_1506_2383_2423(frame, ((Int32)f_1506_2402_2413(frame)) < right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 2442, 2452);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1506, 2252, 2467);

                    object
                    f_1506_2353_2364(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 2353, 2364);
                        return return_v;
                    }


                    object
                    f_1506_2402_2413(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 2402, 2413);
                        return return_v;
                    }


                    int
                    f_1506_2383_2423(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 2383, 2423);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 2252, 2467);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 2252, 2467);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LessThanInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1506, 2170, 2478);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1506, 2170, 2478);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 2170, 2478);
            }


            static LessThanInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1506, 2170, 2478);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1506, 2170, 2478);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 2170, 2478);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1506, 2170, 2478);
        }
        internal sealed class LessThanInt64 : LessThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1506, 2572, 2787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 2652, 2685);

                    Int64
                    right = (Int64)f_1506_2673_2684(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 2703, 2744);

                    f_1506_2703_2743(frame, ((Int64)f_1506_2722_2733(frame)) < right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 2762, 2772);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1506, 2572, 2787);

                    object
                    f_1506_2673_2684(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 2673, 2684);
                        return return_v;
                    }


                    object
                    f_1506_2722_2733(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 2722, 2733);
                        return return_v;
                    }


                    int
                    f_1506_2703_2743(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 2703, 2743);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 2572, 2787);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 2572, 2787);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LessThanInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1506, 2490, 2798);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1506, 2490, 2798);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 2490, 2798);
            }


            static LessThanInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1506, 2490, 2798);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1506, 2490, 2798);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 2490, 2798);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1506, 2490, 2798);
        }
        internal sealed class LessThanByte : LessThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1506, 2891, 3103);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 2971, 3002);

                    byte
                    right = (byte)f_1506_2990_3001(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 3020, 3060);

                    f_1506_3020_3059(frame, ((byte)f_1506_3038_3049(frame)) < right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 3078, 3088);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1506, 2891, 3103);

                    object
                    f_1506_2990_3001(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 2990, 3001);
                        return return_v;
                    }


                    object
                    f_1506_3038_3049(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 3038, 3049);
                        return return_v;
                    }


                    int
                    f_1506_3020_3059(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 3020, 3059);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 2891, 3103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 2891, 3103);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LessThanByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1506, 2810, 3114);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1506, 2810, 3114);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 2810, 3114);
            }


            static LessThanByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1506, 2810, 3114);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1506, 2810, 3114);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 2810, 3114);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1506, 2810, 3114);
        }
        internal sealed class LessThanUInt16 : LessThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1506, 3209, 3427);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 3289, 3324);

                    UInt16
                    right = (UInt16)f_1506_3312_3323(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 3342, 3384);

                    f_1506_3342_3383(frame, ((UInt16)f_1506_3362_3373(frame)) < right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 3402, 3412);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1506, 3209, 3427);

                    object
                    f_1506_3312_3323(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 3312, 3323);
                        return return_v;
                    }


                    object
                    f_1506_3362_3373(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 3362, 3373);
                        return return_v;
                    }


                    int
                    f_1506_3342_3383(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 3342, 3383);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 3209, 3427);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 3209, 3427);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LessThanUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1506, 3126, 3438);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1506, 3126, 3438);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 3126, 3438);
            }


            static LessThanUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1506, 3126, 3438);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1506, 3126, 3438);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 3126, 3438);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1506, 3126, 3438);
        }
        internal sealed class LessThanUInt32 : LessThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1506, 3533, 3751);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 3613, 3648);

                    UInt32
                    right = (UInt32)f_1506_3636_3647(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 3666, 3708);

                    f_1506_3666_3707(frame, ((UInt32)f_1506_3686_3697(frame)) < right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 3726, 3736);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1506, 3533, 3751);

                    object
                    f_1506_3636_3647(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 3636, 3647);
                        return return_v;
                    }


                    object
                    f_1506_3686_3697(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 3686, 3697);
                        return return_v;
                    }


                    int
                    f_1506_3666_3707(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 3666, 3707);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 3533, 3751);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 3533, 3751);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LessThanUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1506, 3450, 3762);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1506, 3450, 3762);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 3450, 3762);
            }


            static LessThanUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1506, 3450, 3762);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1506, 3450, 3762);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 3450, 3762);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1506, 3450, 3762);
        }
        internal sealed class LessThanUInt64 : LessThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1506, 3857, 4075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 3937, 3972);

                    UInt64
                    right = (UInt64)f_1506_3960_3971(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 3990, 4032);

                    f_1506_3990_4031(frame, ((UInt64)f_1506_4010_4021(frame)) < right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 4050, 4060);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1506, 3857, 4075);

                    object
                    f_1506_3960_3971(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 3960, 3971);
                        return return_v;
                    }


                    object
                    f_1506_4010_4021(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 4010, 4021);
                        return return_v;
                    }


                    int
                    f_1506_3990_4031(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 3990, 4031);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 3857, 4075);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 3857, 4075);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LessThanUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1506, 3774, 4086);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1506, 3774, 4086);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 3774, 4086);
            }


            static LessThanUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1506, 3774, 4086);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1506, 3774, 4086);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 3774, 4086);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1506, 3774, 4086);
        }
        internal sealed class LessThanSingle : LessThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1506, 4181, 4399);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 4261, 4296);

                    Single
                    right = (Single)f_1506_4284_4295(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 4314, 4356);

                    f_1506_4314_4355(frame, ((Single)f_1506_4334_4345(frame)) < right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 4374, 4384);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1506, 4181, 4399);

                    object
                    f_1506_4284_4295(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 4284, 4295);
                        return return_v;
                    }


                    object
                    f_1506_4334_4345(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 4334, 4345);
                        return return_v;
                    }


                    int
                    f_1506_4314_4355(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 4314, 4355);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 4181, 4399);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 4181, 4399);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LessThanSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1506, 4098, 4410);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1506, 4098, 4410);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 4098, 4410);
            }


            static LessThanSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1506, 4098, 4410);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1506, 4098, 4410);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 4098, 4410);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1506, 4098, 4410);
        }
        internal sealed class LessThanDouble : LessThanInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1506, 4505, 4723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 4585, 4620);

                    double
                    right = (double)f_1506_4608_4619(frame)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 4638, 4680);

                    f_1506_4638_4679(frame, ((double)f_1506_4658_4669(frame)) < right);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 4698, 4708);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1506, 4505, 4723);

                    object
                    f_1506_4608_4619(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 4608, 4619);
                        return return_v;
                    }


                    object
                    f_1506_4658_4669(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 4658, 4669);
                        return return_v;
                    }


                    int
                    f_1506_4638_4679(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 4638, 4679);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 4505, 4723);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 4505, 4723);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public LessThanDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1506, 4422, 4734);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1506, 4422, 4734);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 4422, 4734);
            }


            static LessThanDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1506, 4422, 4734);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1506, 4422, 4734);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 4422, 4734);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1506, 4422, 4734);
        }

        public static Instruction Create(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1506, 4746, 5989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 4814, 4841);

                f_1506_4814_4840(f_1506_4827_4839_M(!type.IsEnum));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 4855, 5978);

                switch (f_1506_4863_4881(type))
                {

                    case TypeCode.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1506, 4855, 5978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 4936, 4986);

                        return s_SByte ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1506, 4943, 4985) ?? (s_SByte = f_1506_4965_4984()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1506, 4855, 5978);

                    case TypeCode.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1506, 4855, 5978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 5024, 5071);

                        return s_byte ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1506, 5031, 5070) ?? (s_byte = f_1506_5051_5069()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1506, 4855, 5978);

                    case TypeCode.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1506, 4855, 5978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 5109, 5156);

                        return s_char ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1506, 5116, 5155) ?? (s_char = f_1506_5136_5154()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1506, 4855, 5978);

                    case TypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1506, 4855, 5978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 5195, 5245);

                        return s_int16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1506, 5202, 5244) ?? (s_int16 = f_1506_5224_5243()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1506, 4855, 5978);

                    case TypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1506, 4855, 5978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 5284, 5334);

                        return s_int32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1506, 5291, 5333) ?? (s_int32 = f_1506_5313_5332()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1506, 4855, 5978);

                    case TypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1506, 4855, 5978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 5373, 5423);

                        return s_int64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1506, 5380, 5422) ?? (s_int64 = f_1506_5402_5421()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1506, 4855, 5978);

                    case TypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1506, 4855, 5978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 5463, 5516);

                        return s_UInt16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1506, 5470, 5515) ?? (s_UInt16 = f_1506_5494_5514()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1506, 4855, 5978);

                    case TypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1506, 4855, 5978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 5556, 5609);

                        return s_UInt32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1506, 5563, 5608) ?? (s_UInt32 = f_1506_5587_5607()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1506, 4855, 5978);

                    case TypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1506, 4855, 5978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 5649, 5702);

                        return s_UInt64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1506, 5656, 5701) ?? (s_UInt64 = f_1506_5680_5700()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1506, 4855, 5978);

                    case TypeCode.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1506, 4855, 5978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 5742, 5795);

                        return s_single ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1506, 5749, 5794) ?? (s_single = f_1506_5773_5793()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1506, 4855, 5978);

                    case TypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1506, 4855, 5978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 5835, 5888);

                        return s_double ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1506, 5842, 5887) ?? (s_double = f_1506_5866_5886()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1506, 4855, 5978);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1506, 4855, 5978);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 5938, 5963);

                        throw f_1506_5944_5962();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1506, 4855, 5978);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1506, 4746, 5989);

                bool
                f_1506_4827_4839_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1506, 4827, 4839);
                    return return_v;
                }


                int
                f_1506_4814_4840(bool
                condition)
                {
                    Debug.Assert(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 4814, 4840);
                    return 0;
                }


                System.TypeCode
                f_1506_4863_4881(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 4863, 4881);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LessThanInstruction.LessThanSByte
                f_1506_4965_4984()
                {
                    var return_v = new System.Management.Automation.Interpreter.LessThanInstruction.LessThanSByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 4965, 4984);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LessThanInstruction.LessThanByte
                f_1506_5051_5069()
                {
                    var return_v = new System.Management.Automation.Interpreter.LessThanInstruction.LessThanByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 5051, 5069);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LessThanInstruction.LessThanChar
                f_1506_5136_5154()
                {
                    var return_v = new System.Management.Automation.Interpreter.LessThanInstruction.LessThanChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 5136, 5154);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LessThanInstruction.LessThanInt16
                f_1506_5224_5243()
                {
                    var return_v = new System.Management.Automation.Interpreter.LessThanInstruction.LessThanInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 5224, 5243);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LessThanInstruction.LessThanInt32
                f_1506_5313_5332()
                {
                    var return_v = new System.Management.Automation.Interpreter.LessThanInstruction.LessThanInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 5313, 5332);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LessThanInstruction.LessThanInt64
                f_1506_5402_5421()
                {
                    var return_v = new System.Management.Automation.Interpreter.LessThanInstruction.LessThanInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 5402, 5421);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LessThanInstruction.LessThanUInt16
                f_1506_5494_5514()
                {
                    var return_v = new System.Management.Automation.Interpreter.LessThanInstruction.LessThanUInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 5494, 5514);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LessThanInstruction.LessThanUInt32
                f_1506_5587_5607()
                {
                    var return_v = new System.Management.Automation.Interpreter.LessThanInstruction.LessThanUInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 5587, 5607);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LessThanInstruction.LessThanUInt64
                f_1506_5680_5700()
                {
                    var return_v = new System.Management.Automation.Interpreter.LessThanInstruction.LessThanUInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 5680, 5700);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LessThanInstruction.LessThanSingle
                f_1506_5773_5793()
                {
                    var return_v = new System.Management.Automation.Interpreter.LessThanInstruction.LessThanSingle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 5773, 5793);
                    return return_v;
                }


                System.Management.Automation.Interpreter.LessThanInstruction.LessThanDouble
                f_1506_5866_5886()
                {
                    var return_v = new System.Management.Automation.Interpreter.LessThanInstruction.LessThanDouble();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1506, 5866, 5886);
                    return return_v;
                }


                System.Exception
                f_1506_5944_5962()
                {
                    var return_v = Assert.Unreachable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1506, 5944, 5962);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 4746, 5989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 4746, 5989);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1506, 6001, 6090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 6059, 6079);

                return "LessThan()";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1506, 6001, 6090);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1506, 6001, 6090);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 6001, 6090);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LessThanInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1506, 803, 6097);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 904, 911);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 913, 920);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 922, 928);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 930, 937);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 939, 946);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 948, 954);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 956, 964);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 966, 974);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 976, 984);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 986, 994);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1506, 996, 1004);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1506, 803, 6097);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1506, 803, 6097);
        }

        int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1506, 803, 6097);
    }
}
