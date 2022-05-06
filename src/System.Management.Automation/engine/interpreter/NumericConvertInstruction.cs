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

namespace System.Management.Automation.Interpreter
{
    internal abstract class NumericConvertInstruction : Instruction
    {
        internal readonly TypeCode _from, _to;

        protected NumericConvertInstruction(TypeCode from, TypeCode to)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1517, 904, 1039);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 881, 886);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 888, 891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 992, 1005);

                _from = from;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 1019, 1028);

                _to = to;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1517, 904, 1039);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 904, 1039);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 904, 1039);
            }
        }

        public override int ConsumedStack
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 1087, 1104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 1093, 1102);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 1087, 1104);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 1051, 1106);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 1051, 1106);
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
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 1154, 1171);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 1160, 1169);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 1154, 1171);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 1118, 1173);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 1118, 1173);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 1185, 1310);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 1243, 1299);

                return f_1517_1250_1265() + "(" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_from).ToString(), 1517, 1274, 1279) + "->" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (_to).ToString(), 1517, 1289, 1292) + ")";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 1185, 1310);

                string
                f_1517_1250_1265()
                {
                    var return_v = InstructionName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1517, 1250, 1265);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 1185, 1310);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 1185, 1310);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        internal sealed class Unchecked : NumericConvertInstruction
        {
            public override string InstructionName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 1566, 1600);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 1572, 1598);

                        return "UncheckedConvert";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 1566, 1600);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 1525, 1602);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 1525, 1602);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public Unchecked(TypeCode from, TypeCode to)
            : base(f_1517_1687_1691_C(from), to)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1517, 1618, 1726);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1517, 1618, 1726);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 1618, 1726);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 1618, 1726);
                }
            }

            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 1742, 1898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 1822, 1855);

                    f_1517_1822_1854(frame, f_1517_1833_1853(this, f_1517_1841_1852(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 1873, 1883);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 1742, 1898);

                    object
                    f_1517_1841_1852(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 1841, 1852);
                        return return_v;
                    }


                    object
                    f_1517_1833_1853(System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked
                    this_param, object
                    obj)
                    {
                        var return_v = this_param.Convert(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 1833, 1853);
                        return return_v;
                    }


                    int
                    f_1517_1822_1854(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, object
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 1822, 1854);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 1742, 1898);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 1742, 1898);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private object Convert(object obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 1914, 2938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 1981, 2923);

                    switch (_from)
                    {

                        case TypeCode.Byte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 1981, 2923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 2056, 2087);

                            return f_1517_2063_2086(this, (byte)obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 1981, 2923);

                        case TypeCode.SByte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 1981, 2923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 2130, 2162);

                            return f_1517_2137_2161(this, (sbyte)obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 1981, 2923);

                        case TypeCode.Int16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 1981, 2923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 2205, 2237);

                            return f_1517_2212_2236(this, (short)obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 1981, 2923);

                        case TypeCode.Char:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 1981, 2923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 2279, 2310);

                            return f_1517_2286_2309(this, (char)obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 1981, 2923);

                        case TypeCode.Int32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 1981, 2923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 2353, 2385);

                            return f_1517_2360_2384(this, obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 1981, 2923);

                        case TypeCode.Int64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 1981, 2923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 2428, 2460);

                            return f_1517_2435_2459(this, obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 1981, 2923);

                        case TypeCode.UInt16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 1981, 2923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 2504, 2537);

                            return f_1517_2511_2536(this, (ushort)obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 1981, 2923);

                        case TypeCode.UInt32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 1981, 2923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 2581, 2614);

                            return f_1517_2588_2613(this, (uint)obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 1981, 2923);

                        case TypeCode.UInt64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 1981, 2923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 2658, 2692);

                            return f_1517_2665_2691(this, obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 1981, 2923);

                        case TypeCode.Single:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 1981, 2923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 2736, 2770);

                            return f_1517_2743_2769(this, (float)obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 1981, 2923);

                        case TypeCode.Double:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 1981, 2923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 2814, 2848);

                            return f_1517_2821_2847(this, obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 1981, 2923);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 1981, 2923);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 2879, 2904);

                            throw f_1517_2885_2903();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 1981, 2923);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 1914, 2938);

                    object
                    f_1517_2063_2086(System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked
                    this_param, byte
                    obj)
                    {
                        var return_v = this_param.ConvertInt32((int)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 2063, 2086);
                        return return_v;
                    }


                    object
                    f_1517_2137_2161(System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked
                    this_param, sbyte
                    obj)
                    {
                        var return_v = this_param.ConvertInt32((int)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 2137, 2161);
                        return return_v;
                    }


                    object
                    f_1517_2212_2236(System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked
                    this_param, short
                    obj)
                    {
                        var return_v = this_param.ConvertInt32((int)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 2212, 2236);
                        return return_v;
                    }


                    object
                    f_1517_2286_2309(System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked
                    this_param, char
                    obj)
                    {
                        var return_v = this_param.ConvertInt32((int)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 2286, 2309);
                        return return_v;
                    }


                    object
                    f_1517_2360_2384(System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked
                    this_param, object
                    obj)
                    {
                        var return_v = this_param.ConvertInt32((int)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 2360, 2384);
                        return return_v;
                    }


                    object
                    f_1517_2435_2459(System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked
                    this_param, object
                    obj)
                    {
                        var return_v = this_param.ConvertInt64((long)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 2435, 2459);
                        return return_v;
                    }


                    object
                    f_1517_2511_2536(System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked
                    this_param, ushort
                    obj)
                    {
                        var return_v = this_param.ConvertInt32((int)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 2511, 2536);
                        return return_v;
                    }


                    object
                    f_1517_2588_2613(System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked
                    this_param, uint
                    obj)
                    {
                        var return_v = this_param.ConvertInt64((long)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 2588, 2613);
                        return return_v;
                    }


                    object
                    f_1517_2665_2691(System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked
                    this_param, object
                    obj)
                    {
                        var return_v = this_param.ConvertUInt64((ulong)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 2665, 2691);
                        return return_v;
                    }


                    object
                    f_1517_2743_2769(System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked
                    this_param, float
                    obj)
                    {
                        var return_v = this_param.ConvertDouble((double)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 2743, 2769);
                        return return_v;
                    }


                    object
                    f_1517_2821_2847(System.Management.Automation.Interpreter.NumericConvertInstruction.Unchecked
                    this_param, object
                    obj)
                    {
                        var return_v = this_param.ConvertDouble((double)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 2821, 2847);
                        return return_v;
                    }


                    System.Exception
                    f_1517_2885_2903()
                    {
                        var return_v = Assert.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1517, 2885, 2903);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 1914, 2938);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 1914, 2938);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private object ConvertInt32(int obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 2954, 3946);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 3073, 3912);

                        switch (_to)
                        {

                            case TypeCode.Byte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 3073, 3912);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 3154, 3171);

                                return (byte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 3073, 3912);

                            case TypeCode.SByte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 3073, 3912);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 3218, 3236);

                                return (sbyte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 3073, 3912);

                            case TypeCode.Int16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 3073, 3912);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 3283, 3301);

                                return (Int16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 3073, 3912);

                            case TypeCode.Char:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 3073, 3912);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 3347, 3364);

                                return (char)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 3073, 3912);

                            case TypeCode.Int32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 3073, 3912);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 3411, 3429);

                                return (Int32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 3073, 3912);

                            case TypeCode.Int64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 3073, 3912);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 3476, 3494);

                                return (Int64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 3073, 3912);

                            case TypeCode.UInt16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 3073, 3912);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 3542, 3561);

                                return (UInt16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 3073, 3912);

                            case TypeCode.UInt32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 3073, 3912);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 3609, 3628);

                                return (UInt32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 3073, 3912);

                            case TypeCode.UInt64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 3073, 3912);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 3676, 3695);

                                return (UInt64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 3073, 3912);

                            case TypeCode.Single:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 3073, 3912);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 3743, 3762);

                                return (Single)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 3073, 3912);

                            case TypeCode.Double:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 3073, 3912);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 3810, 3829);

                                return (double)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 3073, 3912);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 3073, 3912);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 3864, 3889);

                                throw f_1517_3870_3888();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 3073, 3912);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 2954, 3946);

                    System.Exception
                    f_1517_3870_3888()
                    {
                        var return_v = Assert.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1517, 3870, 3888);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 2954, 3946);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 2954, 3946);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private object ConvertInt64(Int64 obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 3962, 4956);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 4083, 4922);

                        switch (_to)
                        {

                            case TypeCode.Byte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 4083, 4922);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 4164, 4181);

                                return (byte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 4083, 4922);

                            case TypeCode.SByte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 4083, 4922);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 4228, 4246);

                                return (sbyte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 4083, 4922);

                            case TypeCode.Int16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 4083, 4922);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 4293, 4311);

                                return (Int16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 4083, 4922);

                            case TypeCode.Char:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 4083, 4922);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 4357, 4374);

                                return (char)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 4083, 4922);

                            case TypeCode.Int32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 4083, 4922);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 4421, 4439);

                                return (Int32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 4083, 4922);

                            case TypeCode.Int64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 4083, 4922);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 4486, 4504);

                                return (Int64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 4083, 4922);

                            case TypeCode.UInt16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 4083, 4922);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 4552, 4571);

                                return (UInt16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 4083, 4922);

                            case TypeCode.UInt32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 4083, 4922);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 4619, 4638);

                                return (UInt32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 4083, 4922);

                            case TypeCode.UInt64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 4083, 4922);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 4686, 4705);

                                return (UInt64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 4083, 4922);

                            case TypeCode.Single:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 4083, 4922);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 4753, 4772);

                                return (Single)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 4083, 4922);

                            case TypeCode.Double:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 4083, 4922);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 4820, 4839);

                                return (double)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 4083, 4922);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 4083, 4922);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 4874, 4899);

                                throw f_1517_4880_4898();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 4083, 4922);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 3962, 4956);

                    System.Exception
                    f_1517_4880_4898()
                    {
                        var return_v = Assert.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1517, 4880, 4898);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 3962, 4956);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 3962, 4956);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private object ConvertUInt64(UInt64 obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 4972, 5968);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 5095, 5934);

                        switch (_to)
                        {

                            case TypeCode.Byte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 5095, 5934);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 5176, 5193);

                                return (byte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 5095, 5934);

                            case TypeCode.SByte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 5095, 5934);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 5240, 5258);

                                return (sbyte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 5095, 5934);

                            case TypeCode.Int16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 5095, 5934);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 5305, 5323);

                                return (Int16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 5095, 5934);

                            case TypeCode.Char:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 5095, 5934);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 5369, 5386);

                                return (char)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 5095, 5934);

                            case TypeCode.Int32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 5095, 5934);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 5433, 5451);

                                return (Int32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 5095, 5934);

                            case TypeCode.Int64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 5095, 5934);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 5498, 5516);

                                return (Int64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 5095, 5934);

                            case TypeCode.UInt16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 5095, 5934);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 5564, 5583);

                                return (UInt16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 5095, 5934);

                            case TypeCode.UInt32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 5095, 5934);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 5631, 5650);

                                return (UInt32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 5095, 5934);

                            case TypeCode.UInt64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 5095, 5934);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 5698, 5717);

                                return (UInt64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 5095, 5934);

                            case TypeCode.Single:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 5095, 5934);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 5765, 5784);

                                return (Single)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 5095, 5934);

                            case TypeCode.Double:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 5095, 5934);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 5832, 5851);

                                return (double)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 5095, 5934);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 5095, 5934);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 5886, 5911);

                                throw f_1517_5892_5910();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 5095, 5934);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 4972, 5968);

                    System.Exception
                    f_1517_5892_5910()
                    {
                        var return_v = Assert.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1517, 5892, 5910);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 4972, 5968);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 4972, 5968);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private object ConvertDouble(double obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 5984, 6980);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 6107, 6946);

                        switch (_to)
                        {

                            case TypeCode.Byte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 6107, 6946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 6188, 6205);

                                return (byte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 6107, 6946);

                            case TypeCode.SByte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 6107, 6946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 6252, 6270);

                                return (sbyte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 6107, 6946);

                            case TypeCode.Int16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 6107, 6946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 6317, 6335);

                                return (Int16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 6107, 6946);

                            case TypeCode.Char:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 6107, 6946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 6381, 6398);

                                return (char)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 6107, 6946);

                            case TypeCode.Int32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 6107, 6946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 6445, 6463);

                                return (Int32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 6107, 6946);

                            case TypeCode.Int64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 6107, 6946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 6510, 6528);

                                return (Int64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 6107, 6946);

                            case TypeCode.UInt16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 6107, 6946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 6576, 6595);

                                return (UInt16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 6107, 6946);

                            case TypeCode.UInt32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 6107, 6946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 6643, 6662);

                                return (UInt32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 6107, 6946);

                            case TypeCode.UInt64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 6107, 6946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 6710, 6729);

                                return (UInt64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 6107, 6946);

                            case TypeCode.Single:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 6107, 6946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 6777, 6796);

                                return (Single)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 6107, 6946);

                            case TypeCode.Double:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 6107, 6946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 6844, 6863);

                                return (double)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 6107, 6946);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 6107, 6946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 6898, 6923);

                                throw f_1517_6904_6922();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 6107, 6946);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 5984, 6980);

                    System.Exception
                    f_1517_6904_6922()
                    {
                        var return_v = Assert.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1517, 6904, 6922);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 5984, 6980);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 5984, 6980);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static Unchecked()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1517, 1322, 6991);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1517, 1322, 6991);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 1322, 6991);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1517, 1322, 6991);

            static System.TypeCode
            f_1517_1687_1691_C(System.TypeCode
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1517, 1618, 1726);
                return return_v;
            }

        }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Design", "CA1034:NestedTypesShouldNotBeVisible")]
        internal sealed class Checked : NumericConvertInstruction
        {
            public override string InstructionName
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 7245, 7277);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 7251, 7275);

                        return "CheckedConvert";
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 7245, 7277);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 7204, 7279);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 7204, 7279);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            public Checked(TypeCode from, TypeCode to)
            : base(f_1517_7362_7366_C(from), to)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1517, 7295, 7401);
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1517, 7295, 7401);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 7295, 7401);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 7295, 7401);
                }
            }

            public override int Run(InterpretedFrame frame)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 7417, 7573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 7497, 7530);

                    f_1517_7497_7529(frame, f_1517_7508_7528(this, f_1517_7516_7527(frame)));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 7548, 7558);

                    return +1;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 7417, 7573);

                    object
                    f_1517_7516_7527(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param)
                    {
                        var return_v = this_param.Pop();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 7516, 7527);
                        return return_v;
                    }


                    object
                    f_1517_7508_7528(System.Management.Automation.Interpreter.NumericConvertInstruction.Checked
                    this_param, object
                    obj)
                    {
                        var return_v = this_param.Convert(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 7508, 7528);
                        return return_v;
                    }


                    int
                    f_1517_7497_7529(System.Management.Automation.Interpreter.InterpretedFrame
                    this_param, object
                    value)
                    {
                        this_param.Push(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 7497, 7529);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 7417, 7573);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 7417, 7573);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private object Convert(object obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 7589, 8613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 7656, 8598);

                    switch (_from)
                    {

                        case TypeCode.Byte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 7656, 8598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 7731, 7762);

                            return f_1517_7738_7761(this, (byte)obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 7656, 8598);

                        case TypeCode.SByte:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 7656, 8598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 7805, 7837);

                            return f_1517_7812_7836(this, (sbyte)obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 7656, 8598);

                        case TypeCode.Int16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 7656, 8598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 7880, 7912);

                            return f_1517_7887_7911(this, (short)obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 7656, 8598);

                        case TypeCode.Char:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 7656, 8598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 7954, 7985);

                            return f_1517_7961_7984(this, (char)obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 7656, 8598);

                        case TypeCode.Int32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 7656, 8598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 8028, 8060);

                            return f_1517_8035_8059(this, obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 7656, 8598);

                        case TypeCode.Int64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 7656, 8598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 8103, 8135);

                            return f_1517_8110_8134(this, obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 7656, 8598);

                        case TypeCode.UInt16:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 7656, 8598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 8179, 8212);

                            return f_1517_8186_8211(this, (ushort)obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 7656, 8598);

                        case TypeCode.UInt32:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 7656, 8598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 8256, 8289);

                            return f_1517_8263_8288(this, (uint)obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 7656, 8598);

                        case TypeCode.UInt64:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 7656, 8598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 8333, 8367);

                            return f_1517_8340_8366(this, obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 7656, 8598);

                        case TypeCode.Single:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 7656, 8598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 8411, 8445);

                            return f_1517_8418_8444(this, (float)obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 7656, 8598);

                        case TypeCode.Double:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 7656, 8598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 8489, 8523);

                            return f_1517_8496_8522(this, obj);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 7656, 8598);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 7656, 8598);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 8554, 8579);

                            throw f_1517_8560_8578();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 7656, 8598);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 7589, 8613);

                    object
                    f_1517_7738_7761(System.Management.Automation.Interpreter.NumericConvertInstruction.Checked
                    this_param, byte
                    obj)
                    {
                        var return_v = this_param.ConvertInt32((int)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 7738, 7761);
                        return return_v;
                    }


                    object
                    f_1517_7812_7836(System.Management.Automation.Interpreter.NumericConvertInstruction.Checked
                    this_param, sbyte
                    obj)
                    {
                        var return_v = this_param.ConvertInt32((int)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 7812, 7836);
                        return return_v;
                    }


                    object
                    f_1517_7887_7911(System.Management.Automation.Interpreter.NumericConvertInstruction.Checked
                    this_param, short
                    obj)
                    {
                        var return_v = this_param.ConvertInt32((int)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 7887, 7911);
                        return return_v;
                    }


                    object
                    f_1517_7961_7984(System.Management.Automation.Interpreter.NumericConvertInstruction.Checked
                    this_param, char
                    obj)
                    {
                        var return_v = this_param.ConvertInt32((int)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 7961, 7984);
                        return return_v;
                    }


                    object
                    f_1517_8035_8059(System.Management.Automation.Interpreter.NumericConvertInstruction.Checked
                    this_param, object
                    obj)
                    {
                        var return_v = this_param.ConvertInt32((int)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 8035, 8059);
                        return return_v;
                    }


                    object
                    f_1517_8110_8134(System.Management.Automation.Interpreter.NumericConvertInstruction.Checked
                    this_param, object
                    obj)
                    {
                        var return_v = this_param.ConvertInt64((long)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 8110, 8134);
                        return return_v;
                    }


                    object
                    f_1517_8186_8211(System.Management.Automation.Interpreter.NumericConvertInstruction.Checked
                    this_param, ushort
                    obj)
                    {
                        var return_v = this_param.ConvertInt32((int)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 8186, 8211);
                        return return_v;
                    }


                    object
                    f_1517_8263_8288(System.Management.Automation.Interpreter.NumericConvertInstruction.Checked
                    this_param, uint
                    obj)
                    {
                        var return_v = this_param.ConvertInt64((long)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 8263, 8288);
                        return return_v;
                    }


                    object
                    f_1517_8340_8366(System.Management.Automation.Interpreter.NumericConvertInstruction.Checked
                    this_param, object
                    obj)
                    {
                        var return_v = this_param.ConvertUInt64((ulong)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 8340, 8366);
                        return return_v;
                    }


                    object
                    f_1517_8418_8444(System.Management.Automation.Interpreter.NumericConvertInstruction.Checked
                    this_param, float
                    obj)
                    {
                        var return_v = this_param.ConvertDouble((double)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 8418, 8444);
                        return return_v;
                    }


                    object
                    f_1517_8496_8522(System.Management.Automation.Interpreter.NumericConvertInstruction.Checked
                    this_param, object
                    obj)
                    {
                        var return_v = this_param.ConvertDouble((double)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1517, 8496, 8522);
                        return return_v;
                    }


                    System.Exception
                    f_1517_8560_8578()
                    {
                        var return_v = Assert.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1517, 8560, 8578);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 7589, 8613);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 7589, 8613);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private object ConvertInt32(int obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 8629, 9619);
                    checked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 8746, 9585);

                        switch (_to)
                        {

                            case TypeCode.Byte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 8746, 9585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 8827, 8844);

                                return (byte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 8746, 9585);

                            case TypeCode.SByte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 8746, 9585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 8891, 8909);

                                return (sbyte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 8746, 9585);

                            case TypeCode.Int16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 8746, 9585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 8956, 8974);

                                return (Int16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 8746, 9585);

                            case TypeCode.Char:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 8746, 9585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 9020, 9037);

                                return (char)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 8746, 9585);

                            case TypeCode.Int32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 8746, 9585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 9084, 9102);

                                return (Int32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 8746, 9585);

                            case TypeCode.Int64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 8746, 9585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 9149, 9167);

                                return (Int64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 8746, 9585);

                            case TypeCode.UInt16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 8746, 9585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 9215, 9234);

                                return (UInt16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 8746, 9585);

                            case TypeCode.UInt32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 8746, 9585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 9282, 9301);

                                return (UInt32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 8746, 9585);

                            case TypeCode.UInt64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 8746, 9585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 9349, 9368);

                                return (UInt64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 8746, 9585);

                            case TypeCode.Single:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 8746, 9585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 9416, 9435);

                                return (Single)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 8746, 9585);

                            case TypeCode.Double:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 8746, 9585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 9483, 9502);

                                return (double)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 8746, 9585);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 8746, 9585);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 9537, 9562);

                                throw f_1517_9543_9561();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 8746, 9585);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 8629, 9619);

                    System.Exception
                    f_1517_9543_9561()
                    {
                        var return_v = Assert.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1517, 9543, 9561);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 8629, 9619);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 8629, 9619);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private object ConvertInt64(Int64 obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 9635, 10627);
                    checked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 9754, 10593);

                        switch (_to)
                        {

                            case TypeCode.Byte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 9754, 10593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 9835, 9852);

                                return (byte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 9754, 10593);

                            case TypeCode.SByte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 9754, 10593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 9899, 9917);

                                return (sbyte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 9754, 10593);

                            case TypeCode.Int16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 9754, 10593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 9964, 9982);

                                return (Int16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 9754, 10593);

                            case TypeCode.Char:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 9754, 10593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 10028, 10045);

                                return (char)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 9754, 10593);

                            case TypeCode.Int32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 9754, 10593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 10092, 10110);

                                return (Int32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 9754, 10593);

                            case TypeCode.Int64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 9754, 10593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 10157, 10175);

                                return (Int64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 9754, 10593);

                            case TypeCode.UInt16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 9754, 10593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 10223, 10242);

                                return (UInt16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 9754, 10593);

                            case TypeCode.UInt32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 9754, 10593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 10290, 10309);

                                return (UInt32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 9754, 10593);

                            case TypeCode.UInt64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 9754, 10593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 10357, 10376);

                                return (UInt64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 9754, 10593);

                            case TypeCode.Single:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 9754, 10593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 10424, 10443);

                                return (Single)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 9754, 10593);

                            case TypeCode.Double:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 9754, 10593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 10491, 10510);

                                return (double)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 9754, 10593);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 9754, 10593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 10545, 10570);

                                throw f_1517_10551_10569();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 9754, 10593);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 9635, 10627);

                    System.Exception
                    f_1517_10551_10569()
                    {
                        var return_v = Assert.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1517, 10551, 10569);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 9635, 10627);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 9635, 10627);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private object ConvertUInt64(UInt64 obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 10643, 11637);
                    checked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 10764, 11603);

                        switch (_to)
                        {

                            case TypeCode.Byte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 10764, 11603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 10845, 10862);

                                return (byte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 10764, 11603);

                            case TypeCode.SByte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 10764, 11603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 10909, 10927);

                                return (sbyte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 10764, 11603);

                            case TypeCode.Int16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 10764, 11603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 10974, 10992);

                                return (Int16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 10764, 11603);

                            case TypeCode.Char:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 10764, 11603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 11038, 11055);

                                return (char)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 10764, 11603);

                            case TypeCode.Int32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 10764, 11603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 11102, 11120);

                                return (Int32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 10764, 11603);

                            case TypeCode.Int64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 10764, 11603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 11167, 11185);

                                return (Int64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 10764, 11603);

                            case TypeCode.UInt16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 10764, 11603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 11233, 11252);

                                return (UInt16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 10764, 11603);

                            case TypeCode.UInt32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 10764, 11603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 11300, 11319);

                                return (UInt32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 10764, 11603);

                            case TypeCode.UInt64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 10764, 11603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 11367, 11386);

                                return (UInt64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 10764, 11603);

                            case TypeCode.Single:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 10764, 11603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 11434, 11453);

                                return (Single)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 10764, 11603);

                            case TypeCode.Double:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 10764, 11603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 11501, 11520);

                                return (double)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 10764, 11603);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 10764, 11603);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 11555, 11580);

                                throw f_1517_11561_11579();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 10764, 11603);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 10643, 11637);

                    System.Exception
                    f_1517_11561_11579()
                    {
                        var return_v = Assert.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1517, 11561, 11579);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 10643, 11637);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 10643, 11637);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private object ConvertDouble(double obj)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1517, 11653, 12647);
                    checked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 11774, 12613);

                        switch (_to)
                        {

                            case TypeCode.Byte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 11774, 12613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 11855, 11872);

                                return (byte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 11774, 12613);

                            case TypeCode.SByte:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 11774, 12613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 11919, 11937);

                                return (sbyte)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 11774, 12613);

                            case TypeCode.Int16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 11774, 12613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 11984, 12002);

                                return (Int16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 11774, 12613);

                            case TypeCode.Char:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 11774, 12613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 12048, 12065);

                                return (char)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 11774, 12613);

                            case TypeCode.Int32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 11774, 12613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 12112, 12130);

                                return (Int32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 11774, 12613);

                            case TypeCode.Int64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 11774, 12613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 12177, 12195);

                                return (Int64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 11774, 12613);

                            case TypeCode.UInt16:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 11774, 12613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 12243, 12262);

                                return (UInt16)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 11774, 12613);

                            case TypeCode.UInt32:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 11774, 12613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 12310, 12329);

                                return (UInt32)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 11774, 12613);

                            case TypeCode.UInt64:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 11774, 12613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 12377, 12396);

                                return (UInt64)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 11774, 12613);

                            case TypeCode.Single:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 11774, 12613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 12444, 12463);

                                return (Single)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 11774, 12613);

                            case TypeCode.Double:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 11774, 12613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 12511, 12530);

                                return (double)obj;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 11774, 12613);

                            default:
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1517, 11774, 12613);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1517, 12565, 12590);

                                throw f_1517_12571_12589();
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1517, 11774, 12613);
                        }
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1517, 11653, 12647);

                    System.Exception
                    f_1517_12571_12589()
                    {
                        var return_v = Assert.Unreachable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1517, 12571, 12589);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1517, 11653, 12647);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 11653, 12647);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static Checked()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1517, 7003, 12658);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1517, 7003, 12658);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 7003, 12658);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1517, 7003, 12658);

            static System.TypeCode
            f_1517_7362_7366_C(System.TypeCode
            i)
            {
                var return_v = i;
                DynAbs.Tracing.TraceSender.TraceBaseCall(1517, 7295, 7401);
                return return_v;
            }

        }

        static NumericConvertInstruction()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1517, 774, 12665);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1517, 774, 12665);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1517, 774, 12665);
        }

        int ___ignore_me___2 = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1517, 774, 12665);
    }
}
