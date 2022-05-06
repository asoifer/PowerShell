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
using System.Reflection;

namespace System.Management.Automation.Interpreter
{
    internal sealed class LoadStaticFieldInstruction : Instruction
    {
        private readonly FieldInfo _field;

        public LoadStaticFieldInstruction(FieldInfo field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1497, 954, 1098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 935, 941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 1029, 1058);

                f_1497_1029_1057(f_1497_1042_1056(field));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 1072, 1087);

                _field = field;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1497, 954, 1098);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 954, 1098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 954, 1098);
            }
        }

        public override int ProducedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1497, 1146, 1163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 1152, 1161);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1497, 1146, 1163);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 1110, 1165);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 1110, 1165);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1497, 1177, 1318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 1249, 1283);

                f_1497_1249_1282(frame, f_1497_1260_1281(_field, null));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 1297, 1307);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1497, 1177, 1318);

                object?
                f_1497_1260_1281(System.Reflection.FieldInfo
                this_param, object?
                obj)
                {
                    var return_v = this_param.GetValue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1497, 1260, 1281);
                    return return_v;
                }


                int
                f_1497_1249_1282(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, object
                value)
                {
                    this_param.Push(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1497, 1249, 1282);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 1177, 1318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 1177, 1318);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LoadStaticFieldInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1497, 829, 1325);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1497, 829, 1325);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 829, 1325);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1497, 829, 1325);

        bool
        f_1497_1042_1056(System.Reflection.FieldInfo
        this_param)
        {
            var return_v = this_param.IsStatic;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1497, 1042, 1056);
            return return_v;
        }


        int
        f_1497_1029_1057(bool
        condition)
        {
            Debug.Assert(condition);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1497, 1029, 1057);
            return 0;
        }

    }
    internal sealed class LoadFieldInstruction : Instruction
    {
        private readonly FieldInfo _field;

        public LoadFieldInstruction(FieldInfo field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1497, 1452, 1583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 1433, 1439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 1521, 1543);

                f_1497_1521_1542(field);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 1557, 1572);

                _field = field;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1497, 1452, 1583);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 1452, 1583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 1452, 1583);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1497, 1631, 1648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 1637, 1646);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1497, 1631, 1648);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 1595, 1650);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 1595, 1650);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1497, 1698, 1715);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 1704, 1713);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1497, 1698, 1715);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 1662, 1717);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 1662, 1717);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1497, 1729, 1877);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 1801, 1842);

                f_1497_1801_1841(frame, f_1497_1812_1840(_field, f_1497_1828_1839(frame)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 1856, 1866);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1497, 1729, 1877);

                object
                f_1497_1828_1839(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1497, 1828, 1839);
                    return return_v;
                }


                object?
                f_1497_1812_1840(System.Reflection.FieldInfo
                this_param, object
                obj)
                {
                    var return_v = this_param.GetValue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1497, 1812, 1840);
                    return return_v;
                }


                int
                f_1497_1801_1841(System.Management.Automation.Interpreter.InterpretedFrame
                this_param, object
                value)
                {
                    this_param.Push(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1497, 1801, 1841);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 1729, 1877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 1729, 1877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LoadFieldInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1497, 1333, 1884);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1497, 1333, 1884);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 1333, 1884);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1497, 1333, 1884);

        int
        f_1497_1521_1542(System.Reflection.FieldInfo
        var)
        {
            Assert.NotNull((object)var);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1497, 1521, 1542);
            return 0;
        }

    }
    internal sealed class StoreFieldInstruction : Instruction
    {
        private readonly FieldInfo _field;

        public StoreFieldInstruction(FieldInfo field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1497, 2012, 2144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 1993, 1999);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 2082, 2104);

                f_1497_2082_2103(field);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 2118, 2133);

                _field = field;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1497, 2012, 2144);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 2012, 2144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 2012, 2144);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1497, 2192, 2209);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 2198, 2207);

                    return 2;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1497, 2192, 2209);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 2156, 2211);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 2156, 2211);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1497, 2259, 2276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 2265, 2274);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1497, 2259, 2276);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 2223, 2278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 2223, 2278);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1497, 2290, 2507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 2362, 2389);

                object
                value = f_1497_2377_2388(frame)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 2403, 2429);

                object
                self = f_1497_2417_2428(frame)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 2443, 2472);

                f_1497_2443_2471(_field, self, value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 2486, 2496);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1497, 2290, 2507);

                object
                f_1497_2377_2388(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1497, 2377, 2388);
                    return return_v;
                }


                object
                f_1497_2417_2428(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1497, 2417, 2428);
                    return return_v;
                }


                int
                f_1497_2443_2471(System.Reflection.FieldInfo
                this_param, object
                obj, object
                value)
                {
                    this_param.SetValue(obj, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1497, 2443, 2471);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 2290, 2507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 2290, 2507);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StoreFieldInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1497, 1892, 2514);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1497, 1892, 2514);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 1892, 2514);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1497, 1892, 2514);

        int
        f_1497_2082_2103(System.Reflection.FieldInfo
        var)
        {
            Assert.NotNull((object)var);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1497, 2082, 2103);
            return 0;
        }

    }
    internal sealed class StoreStaticFieldInstruction : Instruction
    {
        private readonly FieldInfo _field;

        public StoreStaticFieldInstruction(FieldInfo field)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1497, 2648, 2786);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 2629, 2635);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 2724, 2746);

                f_1497_2724_2745(field);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 2760, 2775);

                _field = field;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1497, 2648, 2786);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 2648, 2786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 2648, 2786);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1497, 2834, 2851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 2840, 2849);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1497, 2834, 2851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 2798, 2853);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 2798, 2853);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1497, 2901, 2918);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 2907, 2916);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1497, 2901, 2918);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 2865, 2920);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 2865, 2920);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override int Run(InterpretedFrame frame)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1497, 2932, 3109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 3004, 3031);

                object
                value = f_1497_3019_3030(frame)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 3045, 3074);

                f_1497_3045_3073(_field, null, value);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1497, 3088, 3098);

                return +1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1497, 2932, 3109);

                object
                f_1497_3019_3030(System.Management.Automation.Interpreter.InterpretedFrame
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1497, 3019, 3030);
                    return return_v;
                }


                int
                f_1497_3045_3073(System.Reflection.FieldInfo
                this_param, object?
                obj, object
                value)
                {
                    this_param.SetValue(obj, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1497, 3045, 3073);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1497, 2932, 3109);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 2932, 3109);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StoreStaticFieldInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1497, 2522, 3116);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1497, 2522, 3116);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1497, 2522, 3116);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1497, 2522, 3116);

        int
        f_1497_2724_2745(System.Reflection.FieldInfo
        var)
        {
            Assert.NotNull((object)var);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1497, 2724, 2745);
            return 0;
        }

    }
}
