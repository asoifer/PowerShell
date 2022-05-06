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
    internal abstract class NotEqualInstruction : Instruction
    {
        private static Instruction s_reference, s_boolean, s_SByte, s_int16, s_char, s_int32, s_int64, s_byte, s_UInt16, s_UInt32, s_UInt64, s_single, s_double;

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 1144, 1161);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1150, 1159);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 1144, 1161);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 1108, 1163);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 1108, 1163);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 1211, 1228);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1217, 1226);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 1211, 1228);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 1175, 1230);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 1175, 1230);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private NotEqualInstruction()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1516, 1242, 1293);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1516, 1242, 1293);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 1242, 1293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 1242, 1293);
            }
        }
        internal sealed class NotEqualBoolean : NotEqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 1389, 1567);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1469, 1524);

                    f_1516_1469_1523(frame, ((bool)f_1516_1487_1498(frame)) != ((bool)f_1516_1510_1521(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1542, 1552);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 1389, 1567);

                    object
                    f_1516_1487_1498(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 1487, 1498);
                        return return_v;
                    }


                    object
                    f_1516_1510_1521(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 1510, 1521);
                        return return_v;
                    }


                    int
                    f_1516_1469_1523(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 1469, 1523);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 1389, 1567);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 1389, 1567);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NotEqualBoolean()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1516, 1305, 1578);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1516, 1305, 1578);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 1305, 1578);
            }


            static NotEqualBoolean()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1516, 1305, 1578);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1516, 1305, 1578);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 1305, 1578);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1516, 1305, 1578);
        }
        internal sealed class NotEqualSByte : NotEqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 1672, 1852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1752, 1809);

                    f_1516_1752_1808(frame, ((sbyte)f_1516_1771_1782(frame)) != ((sbyte)f_1516_1795_1806(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1827, 1837);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 1672, 1852);

                    object
                    f_1516_1771_1782(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 1771, 1782);
                        return return_v;
                    }


                    object
                    f_1516_1795_1806(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 1795, 1806);
                        return return_v;
                    }


                    int
                    f_1516_1752_1808(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 1752, 1808);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 1672, 1852);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 1672, 1852);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NotEqualSByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1516, 1590, 1863);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1516, 1590, 1863);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 1590, 1863);
            }


            static NotEqualSByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1516, 1590, 1863);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1516, 1590, 1863);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 1590, 1863);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1516, 1590, 1863);
        }
        internal sealed class NotEqualInt16 : NotEqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 1957, 2137);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 2037, 2094);

                    f_1516_2037_2093(frame, ((Int16)f_1516_2056_2067(frame)) != ((Int16)f_1516_2080_2091(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 2112, 2122);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 1957, 2137);

                    object
                    f_1516_2056_2067(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 2056, 2067);
                        return return_v;
                    }


                    object
                    f_1516_2080_2091(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 2080, 2091);
                        return return_v;
                    }


                    int
                    f_1516_2037_2093(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 2037, 2093);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 1957, 2137);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 1957, 2137);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NotEqualInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1516, 1875, 2148);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1516, 1875, 2148);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 1875, 2148);
            }


            static NotEqualInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1516, 1875, 2148);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1516, 1875, 2148);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 1875, 2148);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1516, 1875, 2148);
        }
        internal sealed class NotEqualChar : NotEqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 2241, 2419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 2321, 2376);

                    f_1516_2321_2375(frame, ((char)f_1516_2339_2350(frame)) != ((char)f_1516_2362_2373(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 2394, 2404);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 2241, 2419);

                    object
                    f_1516_2339_2350(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 2339, 2350);
                        return return_v;
                    }


                    object
                    f_1516_2362_2373(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 2362, 2373);
                        return return_v;
                    }


                    int
                    f_1516_2321_2375(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 2321, 2375);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 2241, 2419);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 2241, 2419);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NotEqualChar()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1516, 2160, 2430);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1516, 2160, 2430);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 2160, 2430);
            }


            static NotEqualChar()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1516, 2160, 2430);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1516, 2160, 2430);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 2160, 2430);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1516, 2160, 2430);
        }
        internal sealed class NotEqualInt32 : NotEqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 2524, 2704);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 2604, 2661);

                    f_1516_2604_2660(frame, ((Int32)f_1516_2623_2634(frame)) != ((Int32)f_1516_2647_2658(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 2679, 2689);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 2524, 2704);

                    object
                    f_1516_2623_2634(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 2623, 2634);
                        return return_v;
                    }


                    object
                    f_1516_2647_2658(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 2647, 2658);
                        return return_v;
                    }


                    int
                    f_1516_2604_2660(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 2604, 2660);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 2524, 2704);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 2524, 2704);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NotEqualInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1516, 2442, 2715);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1516, 2442, 2715);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 2442, 2715);
            }


            static NotEqualInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1516, 2442, 2715);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1516, 2442, 2715);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 2442, 2715);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1516, 2442, 2715);
        }
        internal sealed class NotEqualInt64 : NotEqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 2809, 2989);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 2889, 2946);

                    f_1516_2889_2945(frame, ((Int64)f_1516_2908_2919(frame)) != ((Int64)f_1516_2932_2943(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 2964, 2974);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 2809, 2989);

                    object
                    f_1516_2908_2919(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 2908, 2919);
                        return return_v;
                    }


                    object
                    f_1516_2932_2943(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 2932, 2943);
                        return return_v;
                    }


                    int
                    f_1516_2889_2945(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 2889, 2945);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 2809, 2989);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 2809, 2989);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NotEqualInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1516, 2727, 3000);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1516, 2727, 3000);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 2727, 3000);
            }


            static NotEqualInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1516, 2727, 3000);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1516, 2727, 3000);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 2727, 3000);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1516, 2727, 3000);
        }
        internal sealed class NotEqualByte : NotEqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 3093, 3271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 3173, 3228);

                    f_1516_3173_3227(frame, ((byte)f_1516_3191_3202(frame)) != ((byte)f_1516_3214_3225(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 3246, 3256);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 3093, 3271);

                    object
                    f_1516_3191_3202(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 3191, 3202);
                        return return_v;
                    }


                    object
                    f_1516_3214_3225(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 3214, 3225);
                        return return_v;
                    }


                    int
                    f_1516_3173_3227(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 3173, 3227);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 3093, 3271);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 3093, 3271);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NotEqualByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1516, 3012, 3282);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1516, 3012, 3282);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 3012, 3282);
            }


            static NotEqualByte()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1516, 3012, 3282);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1516, 3012, 3282);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 3012, 3282);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1516, 3012, 3282);
        }
        internal sealed class NotEqualUInt16 : NotEqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 3377, 3559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 3457, 3516);

                    f_1516_3457_3515(frame, ((UInt16)f_1516_3477_3488(frame)) != ((UInt16)f_1516_3502_3513(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 3534, 3544);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 3377, 3559);

                    object
                    f_1516_3477_3488(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 3477, 3488);
                        return return_v;
                    }


                    object
                    f_1516_3502_3513(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 3502, 3513);
                        return return_v;
                    }


                    int
                    f_1516_3457_3515(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 3457, 3515);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 3377, 3559);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 3377, 3559);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NotEqualUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1516, 3294, 3570);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1516, 3294, 3570);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 3294, 3570);
            }


            static NotEqualUInt16()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1516, 3294, 3570);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1516, 3294, 3570);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 3294, 3570);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1516, 3294, 3570);
        }
        internal sealed class NotEqualUInt32 : NotEqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 3665, 3847);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 3745, 3804);

                    f_1516_3745_3803(frame, ((UInt32)f_1516_3765_3776(frame)) != ((UInt32)f_1516_3790_3801(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 3822, 3832);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 3665, 3847);

                    object
                    f_1516_3765_3776(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 3765, 3776);
                        return return_v;
                    }


                    object
                    f_1516_3790_3801(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 3790, 3801);
                        return return_v;
                    }


                    int
                    f_1516_3745_3803(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 3745, 3803);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 3665, 3847);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 3665, 3847);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NotEqualUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1516, 3582, 3858);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1516, 3582, 3858);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 3582, 3858);
            }


            static NotEqualUInt32()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1516, 3582, 3858);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1516, 3582, 3858);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 3582, 3858);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1516, 3582, 3858);
        }
        internal sealed class NotEqualUInt64 : NotEqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 3953, 4135);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 4033, 4092);

                    f_1516_4033_4091(frame, ((UInt64)f_1516_4053_4064(frame)) != ((UInt64)f_1516_4078_4089(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 4110, 4120);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 3953, 4135);

                    object
                    f_1516_4053_4064(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 4053, 4064);
                        return return_v;
                    }


                    object
                    f_1516_4078_4089(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 4078, 4089);
                        return return_v;
                    }


                    int
                    f_1516_4033_4091(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 4033, 4091);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 3953, 4135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 3953, 4135);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NotEqualUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1516, 3870, 4146);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1516, 3870, 4146);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 3870, 4146);
            }


            static NotEqualUInt64()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1516, 3870, 4146);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1516, 3870, 4146);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 3870, 4146);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1516, 3870, 4146);
        }
        internal sealed class NotEqualSingle : NotEqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 4241, 4423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 4321, 4380);

                    f_1516_4321_4379(frame, ((Single)f_1516_4341_4352(frame)) != ((Single)f_1516_4366_4377(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 4398, 4408);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 4241, 4423);

                    object
                    f_1516_4341_4352(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 4341, 4352);
                        return return_v;
                    }


                    object
                    f_1516_4366_4377(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 4366, 4377);
                        return return_v;
                    }


                    int
                    f_1516_4321_4379(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 4321, 4379);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 4241, 4423);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 4241, 4423);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NotEqualSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1516, 4158, 4434);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1516, 4158, 4434);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 4158, 4434);
            }


            static NotEqualSingle()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1516, 4158, 4434);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1516, 4158, 4434);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 4158, 4434);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1516, 4158, 4434);
        }
        internal sealed class NotEqualDouble : NotEqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 4529, 4711);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 4609, 4668);

                    f_1516_4609_4667(frame, ((double)f_1516_4629_4640(frame)) != ((double)f_1516_4654_4665(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 4686, 4696);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 4529, 4711);

                    object
                    f_1516_4629_4640(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 4629, 4640);
                        return return_v;
                    }


                    object
                    f_1516_4654_4665(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 4654, 4665);
                        return return_v;
                    }


                    int
                    f_1516_4609_4667(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 4609, 4667);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 4529, 4711);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 4529, 4711);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NotEqualDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1516, 4446, 4722);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1516, 4446, 4722);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 4446, 4722);
            }


            static NotEqualDouble()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1516, 4446, 4722);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1516, 4446, 4722);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 4446, 4722);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1516, 4446, 4722);
        }
        internal sealed class NotEqualReference : NotEqualInstruction
        {
            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 4820, 4982);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 4900, 4939);

                    f_1516_4900_4938(frame, f_1516_4911_4922(frame) != f_1516_4926_4937(frame));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 4957, 4967);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 4820, 4982);

                    object
                    f_1516_4911_4922(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 4911, 4922);
                        return return_v;
                    }


                    object
                    f_1516_4926_4937(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 4926, 4937);
                        return return_v;
                    }


                    int
                    f_1516_4900_4938(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, bool
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 4900, 4938);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 4820, 4982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 4820, 4982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public NotEqualReference()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1516, 4734, 4993);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1516, 4734, 4993);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 4734, 4993);
            }


            static NotEqualReference()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1516, 4734, 4993);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1516, 4734, 4993);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 4734, 4993);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1516, 4734, 4993);
        }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        public static Instruction Create(Type type)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1516, 5005, 6913);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 5266, 5332);

                var
                typeToUse = (DynAbs.Tracing.TraceSender.Conditional_F1(1516, 5282, 5293) || ((f_1516_5282_5293(type) && DynAbs.Tracing.TraceSender.Conditional_F2(1516, 5296, 5324)) || DynAbs.Tracing.TraceSender.Conditional_F3(1516, 5327, 5331))) ? f_1516_5296_5324(type) : type
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 5346, 6902);

                switch (f_1516_5354_5377(typeToUse))
                {

                    case TypeCode.Boolean:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 5346, 6902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 5434, 5490);

                        return s_boolean ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1516, 5441, 5489) ?? (s_boolean = f_1516_5467_5488()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 5346, 6902);

                    case TypeCode.SByte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 5346, 6902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 5529, 5579);

                        return s_SByte ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1516, 5536, 5578) ?? (s_SByte = f_1516_5558_5577()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 5346, 6902);

                    case TypeCode.Byte:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 5346, 6902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 5617, 5664);

                        return s_byte ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1516, 5624, 5663) ?? (s_byte = f_1516_5644_5662()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 5346, 6902);

                    case TypeCode.Char:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 5346, 6902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 5702, 5749);

                        return s_char ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1516, 5709, 5748) ?? (s_char = f_1516_5729_5747()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 5346, 6902);

                    case TypeCode.Int16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 5346, 6902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 5788, 5838);

                        return s_int16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1516, 5795, 5837) ?? (s_int16 = f_1516_5817_5836()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 5346, 6902);

                    case TypeCode.Int32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 5346, 6902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 5877, 5927);

                        return s_int32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1516, 5884, 5926) ?? (s_int32 = f_1516_5906_5925()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 5346, 6902);

                    case TypeCode.Int64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 5346, 6902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 5966, 6016);

                        return s_int64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1516, 5973, 6015) ?? (s_int64 = f_1516_5995_6014()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 5346, 6902);

                    case TypeCode.UInt16:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 5346, 6902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 6058, 6110);

                        return s_UInt16 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1516, 6065, 6109) ?? (s_UInt16 = f_1516_6089_6108()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 5346, 6902);

                    case TypeCode.UInt32:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 5346, 6902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 6150, 6202);

                        return s_UInt32 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1516, 6157, 6201) ?? (s_UInt32 = f_1516_6181_6200()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 5346, 6902);

                    case TypeCode.UInt64:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 5346, 6902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 6242, 6294);

                        return s_UInt64 ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1516, 6249, 6293) ?? (s_UInt64 = f_1516_6273_6292()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 5346, 6902);

                    case TypeCode.Single:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 5346, 6902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 6336, 6389);

                        return s_single ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1516, 6343, 6388) ?? (s_single = f_1516_6367_6387()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 5346, 6902);

                    case TypeCode.Double:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 5346, 6902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 6429, 6482);

                        return s_double ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1516, 6436, 6481) ?? (s_double = f_1516_6460_6480()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 5346, 6902);

                    case TypeCode.Object:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 5346, 6902);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 6545, 6701) || true) && (f_1516_6549_6566_M(!type.IsValueType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 6545, 6701);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 6616, 6678);

                            return s_reference ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Interpreter.Instruction>(1516, 6623, 6677) ?? (s_reference = f_1516_6653_6676()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 6545, 6701);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 6765, 6801);

                        throw f_1516_6771_6800();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 5346, 6902);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1516, 5346, 6902);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 6851, 6887);

                        throw f_1516_6857_6886();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1516, 5346, 6902);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1516, 5005, 6913);

                bool
                f_1516_5282_5293(System.Type
                this_param)
                {
                    var return_v = this_param.IsEnum;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1516, 5282, 5293);
                    return return_v;
                }


                System.Type
                f_1516_5296_5324(System.Type
                enumType)
                {
                    var return_v = Enum.GetUnderlyingType(enumType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 5296, 5324);
                    return return_v;
                }


                System.TypeCode
                f_1516_5354_5377(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 5354, 5377);
                    return return_v;
                }


                System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualBoolean
                f_1516_5467_5488()
                {
                    var return_v = new System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualBoolean();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 5467, 5488);
                    return return_v;
                }


                System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualSByte
                f_1516_5558_5577()
                {
                    var return_v = new System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualSByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 5558, 5577);
                    return return_v;
                }


                System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualByte
                f_1516_5644_5662()
                {
                    var return_v = new System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualByte();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 5644, 5662);
                    return return_v;
                }


                System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualChar
                f_1516_5729_5747()
                {
                    var return_v = new System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualChar();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 5729, 5747);
                    return return_v;
                }


                System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualInt16
                f_1516_5817_5836()
                {
                    var return_v = new System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 5817, 5836);
                    return return_v;
                }


                System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualInt32
                f_1516_5906_5925()
                {
                    var return_v = new System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 5906, 5925);
                    return return_v;
                }


                System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualInt64
                f_1516_5995_6014()
                {
                    var return_v = new System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 5995, 6014);
                    return return_v;
                }


                System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualInt16
                f_1516_6089_6108()
                {
                    var return_v = new System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualInt16();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 6089, 6108);
                    return return_v;
                }


                System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualInt32
                f_1516_6181_6200()
                {
                    var return_v = new System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualInt32();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 6181, 6200);
                    return return_v;
                }


                System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualInt64
                f_1516_6273_6292()
                {
                    var return_v = new System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualInt64();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 6273, 6292);
                    return return_v;
                }


                System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualSingle
                f_1516_6367_6387()
                {
                    var return_v = new System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualSingle();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 6367, 6387);
                    return return_v;
                }


                System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualDouble
                f_1516_6460_6480()
                {
                    var return_v = new System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualDouble();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 6460, 6480);
                    return return_v;
                }


                bool
                f_1516_6549_6566_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1516, 6549, 6566);
                    return return_v;
                }


                System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualReference
                f_1516_6653_6676()
                {
                    var return_v = new System.Management.Automation.Interpreter.NotEqualInstruction.NotEqualReference();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 6653, 6676);
                    return return_v;
                }


                System.NotImplementedException
                f_1516_6771_6800()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 6771, 6800);
                    return return_v;
                }


                System.NotImplementedException
                f_1516_6857_6886()
                {
                    var return_v = new System.NotImplementedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1516, 6857, 6886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 5005, 6913);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 5005, 6913);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1516, 6925, 7014);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 6983, 7003);

                return "NotEqual()";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1516, 6925, 7014);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1516, 6925, 7014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 6925, 7014);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static NotEqualInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1516, 802, 7021);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 971, 982);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 984, 993);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 995, 1002);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1004, 1011);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1013, 1019);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1021, 1028);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1030, 1037);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1039, 1045);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1047, 1055);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1057, 1065);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1067, 1075);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1077, 1085);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1516, 1087, 1095);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1516, 802, 7021);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1516, 802, 7021);
        }

        int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1516, 802, 7021);
    }
}

