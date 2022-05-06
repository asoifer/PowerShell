// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// ReSharper disable UnusedMember.Global
// ReSharper disable RedundantCast

namespace System.Management.Automation
{
    internal static class Boxed
    {
        internal static object True;

        internal static object False;

        static Boxed()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1665, 227, 376);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 294, 313);
            True = (object)true;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 347, 368);
            False = (object)false;
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1665, 227, 376);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 227, 376);
        }

    }
    internal static class IntOps
    {
        internal static object Add(int lhs, int rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 429, 717);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 498, 534);

                long
                result = (long)lhs + (long)rhs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 548, 668) || true) && (result <= int.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 552, 600) && result >= int.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 548, 668);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 634, 653);

                    return (int)result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 548, 668);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 684, 706);

                return (double)result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 429, 717);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 429, 717);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 429, 717);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Sub(int lhs, int rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 729, 1017);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 798, 834);

                long
                result = (long)lhs - (long)rhs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 848, 968) || true) && (result <= int.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 852, 900) && result >= int.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 848, 968);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 934, 953);

                    return (int)result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 848, 968);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 984, 1006);

                return (double)result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 729, 1017);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 729, 1017);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 729, 1017);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Multiply(int lhs, int rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 1029, 1322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 1103, 1139);

                long
                result = (long)lhs * (long)rhs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 1153, 1273) || true) && (result <= int.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 1157, 1205) && result >= int.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 1153, 1273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 1239, 1258);

                    return (int)result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 1153, 1273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 1289, 1311);

                return (double)result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 1029, 1322);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 1029, 1322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 1029, 1322);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Divide(int lhs, int rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 1334, 2192);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 1541, 1724) || true) && (rhs == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 1541, 1724);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 1587, 1644);

                    DivideByZeroException
                    dbze = f_1665_1616_1643()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 1662, 1709);

                    throw f_1665_1668_1708(f_1665_1689_1701(dbze), dbze);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 1541, 1724);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 1740, 1940) || true) && (lhs == int.MinValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 1744, 1776) && rhs == -1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 1740, 1940);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 1892, 1925);

                    return (double)lhs / (double)rhs;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 1740, 1940);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 2046, 2132) || true) && ((lhs % rhs) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 2046, 2132);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 2100, 2117);

                    return lhs / rhs;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 2046, 2132);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 2148, 2181);

                return (double)lhs / (double)rhs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 1334, 2192);

                System.DivideByZeroException
                f_1665_1616_1643()
                {
                    var return_v = new System.DivideByZeroException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 1616, 1643);
                    return return_v;
                }


                string
                f_1665_1689_1701(System.DivideByZeroException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 1689, 1701);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_1668_1708(string
                message, System.DivideByZeroException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 1668, 1708);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 1334, 2192);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 1334, 2192);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Remainder(int lhs, int rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 2204, 2942);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 2414, 2597) || true) && (rhs == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 2414, 2597);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 2460, 2517);

                    DivideByZeroException
                    dbze = f_1665_2489_2516()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 2535, 2582);

                    throw f_1665_2541_2581(f_1665_2562_2574(dbze), dbze);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 2414, 2597);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 2613, 2898) || true) && (lhs == int.MinValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 2617, 2649) && rhs == -1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 2613, 2898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 2874, 2883);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 2613, 2898);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 2914, 2931);

                return lhs % rhs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 2204, 2942);

                System.DivideByZeroException
                f_1665_2489_2516()
                {
                    var return_v = new System.DivideByZeroException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 2489, 2516);
                    return return_v;
                }


                string
                f_1665_2562_2574(System.DivideByZeroException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 2562, 2574);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_2541_2581(string
                message, System.DivideByZeroException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 2541, 2581);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 2204, 2942);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 2204, 2942);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareEq(int lhs, int rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 2954, 3056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 3007, 3054);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 3014, 3026) || (((lhs == rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 3029, 3039)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 3042, 3053))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 2954, 3056);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 2954, 3056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 2954, 3056);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareNe(int lhs, int rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 3068, 3170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 3121, 3168);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 3128, 3140) || (((lhs != rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 3143, 3153)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 3156, 3167))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 3068, 3170);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 3068, 3170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 3068, 3170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLt(int lhs, int rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 3182, 3283);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 3235, 3281);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 3242, 3253) || (((lhs < rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 3256, 3266)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 3269, 3280))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 3182, 3283);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 3182, 3283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 3182, 3283);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLe(int lhs, int rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 3295, 3397);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 3348, 3395);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 3355, 3367) || (((lhs <= rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 3370, 3380)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 3383, 3394))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 3295, 3397);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 3295, 3397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 3295, 3397);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGt(int lhs, int rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 3409, 3510);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 3462, 3508);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 3469, 3480) || (((lhs > rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 3483, 3493)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 3496, 3507))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 3409, 3510);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 3409, 3510);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 3409, 3510);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGe(int lhs, int rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 3522, 3624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 3575, 3622);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 3582, 3594) || (((lhs >= rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 3597, 3607)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 3610, 3621))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 3522, 3624);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 3522, 3624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 3522, 3624);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object[] Range(int lower, int upper)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 3636, 4257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 3713, 3761);

                int
                absRange = f_1665_3728_3760(checked(upper - lower))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 3777, 3816);

                object[]
                ra = new object[absRange + 1]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 3830, 4220) || true) && (lower > upper)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 3830, 4220);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 3926, 3936);
                        // 3 .. 1 => 3 2 1
                        for (int
        offset = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 3917, 4010) || true) && (offset < f_1665_3947_3956(ra))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 3958, 3966)
        , offset++, DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 3917, 4010))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 3917, 4010);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 3989, 4010);

                            ra[offset] = lower--;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1665, 1, 94);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1665, 1, 94);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 3830, 4220);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 3830, 4220);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 4121, 4131);
                        // 1 .. 3 => 1 2 3
                        for (int
        offset = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 4112, 4205) || true) && (offset < f_1665_4142_4151(ra))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 4153, 4161)
        , offset++, DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 4112, 4205))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 4112, 4205);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 4184, 4205);

                            ra[offset] = lower++;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1665, 1, 94);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1665, 1, 94);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 3830, 4220);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 4236, 4246);

                return ra;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 3636, 4257);

                int
                f_1665_3728_3760(int
                value)
                {
                    var return_v = Math.Abs(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 3728, 3760);
                    return return_v;
                }


                int
                f_1665_3947_3956(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 3947, 3956);
                    return return_v;
                }


                int
                f_1665_4142_4151(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 4142, 4151);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 3636, 4257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 3636, 4257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static IntOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1665, 384, 4264);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1665, 384, 4264);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 384, 4264);
        }

    }
    internal static class UIntOps
    {
        internal static object Add(uint lhs, uint rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 4318, 4587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 4389, 4428);

                ulong
                result = (ulong)lhs + (ulong)rhs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 4442, 4538) || true) && (result <= uint.MaxValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 4442, 4538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 4503, 4523);

                    return (uint)result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 4442, 4538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 4554, 4576);

                return (double)result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 4318, 4587);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 4318, 4587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 4318, 4587);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Sub(uint lhs, uint rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 4599, 4865);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 4670, 4706);

                long
                result = (long)lhs - (long)rhs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 4720, 4816) || true) && (result >= uint.MinValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 4720, 4816);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 4781, 4801);

                    return (uint)result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 4720, 4816);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 4832, 4854);

                return (double)result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 4599, 4865);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 4599, 4865);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 4599, 4865);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Multiply(uint lhs, uint rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 4877, 5151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 4953, 4992);

                ulong
                result = (ulong)lhs * (ulong)rhs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 5006, 5102) || true) && (result <= uint.MaxValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 5006, 5102);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 5067, 5087);

                    return (uint)result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 5006, 5102);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 5118, 5140);

                return (double)result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 4877, 5151);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 4877, 5151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 4877, 5151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Divide(uint lhs, uint rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 5163, 5807);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 5372, 5555) || true) && (rhs == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 5372, 5555);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 5418, 5475);

                    DivideByZeroException
                    dbze = f_1665_5447_5474()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 5493, 5540);

                    throw f_1665_5499_5539(f_1665_5520_5532(dbze), dbze);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 5372, 5555);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 5661, 5747) || true) && ((lhs % rhs) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 5661, 5747);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 5715, 5732);

                    return lhs / rhs;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 5661, 5747);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 5763, 5796);

                return (double)lhs / (double)rhs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 5163, 5807);

                System.DivideByZeroException
                f_1665_5447_5474()
                {
                    var return_v = new System.DivideByZeroException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 5447, 5474);
                    return return_v;
                }


                string
                f_1665_5520_5532(System.DivideByZeroException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 5520, 5532);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_5499_5539(string
                message, System.DivideByZeroException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 5499, 5539);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 5163, 5807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 5163, 5807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Remainder(uint lhs, uint rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 5819, 6258);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 6031, 6214) || true) && (rhs == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 6031, 6214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 6077, 6134);

                    DivideByZeroException
                    dbze = f_1665_6106_6133()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 6152, 6199);

                    throw f_1665_6158_6198(f_1665_6179_6191(dbze), dbze);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 6031, 6214);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 6230, 6247);

                return lhs % rhs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 5819, 6258);

                System.DivideByZeroException
                f_1665_6106_6133()
                {
                    var return_v = new System.DivideByZeroException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 6106, 6133);
                    return return_v;
                }


                string
                f_1665_6179_6191(System.DivideByZeroException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 6179, 6191);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_6158_6198(string
                message, System.DivideByZeroException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 6158, 6198);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 5819, 6258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 5819, 6258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareEq(uint lhs, uint rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 6270, 6374);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 6325, 6372);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 6332, 6344) || (((lhs == rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 6347, 6357)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 6360, 6371))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 6270, 6374);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 6270, 6374);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 6270, 6374);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareNe(uint lhs, uint rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 6386, 6490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 6441, 6488);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 6448, 6460) || (((lhs != rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 6463, 6473)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 6476, 6487))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 6386, 6490);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 6386, 6490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 6386, 6490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLt(uint lhs, uint rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 6502, 6605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 6557, 6603);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 6564, 6575) || (((lhs < rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 6578, 6588)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 6591, 6602))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 6502, 6605);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 6502, 6605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 6502, 6605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLe(uint lhs, uint rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 6617, 6721);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 6672, 6719);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 6679, 6691) || (((lhs <= rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 6694, 6704)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 6707, 6718))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 6617, 6721);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 6617, 6721);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 6617, 6721);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGt(uint lhs, uint rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 6733, 6836);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 6788, 6834);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 6795, 6806) || (((lhs > rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 6809, 6819)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 6822, 6833))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 6733, 6836);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 6733, 6836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 6733, 6836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGe(uint lhs, uint rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 6848, 6952);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 6903, 6950);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 6910, 6922) || (((lhs >= rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 6925, 6935)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 6938, 6949))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 6848, 6952);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 6848, 6952);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 6848, 6952);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static UIntOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1665, 4272, 6959);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1665, 4272, 6959);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 4272, 6959);
        }

    }
    internal static class LongOps
    {
        internal static object Add(long lhs, long rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 7013, 7315);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 7084, 7129);

                decimal
                result = (decimal)lhs + (decimal)rhs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 7143, 7266) || true) && (result <= long.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 7147, 7197) && result >= long.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 7143, 7266);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 7231, 7251);

                    return (long)result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 7143, 7266);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 7282, 7304);

                return (double)result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 7013, 7315);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 7013, 7315);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 7013, 7315);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Sub(long lhs, long rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 7327, 7629);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 7398, 7443);

                decimal
                result = (decimal)lhs - (decimal)rhs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 7457, 7580) || true) && (result <= long.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 7461, 7511) && result >= long.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 7457, 7580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 7545, 7565);

                    return (long)result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 7457, 7580);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 7596, 7618);

                return (double)result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 7327, 7629);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 7327, 7629);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 7327, 7629);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Multiply(long lhs, long rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 7641, 8071);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 7717, 7756);

                System.Numerics.BigInteger
                biLhs = lhs
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 7770, 7809);

                System.Numerics.BigInteger
                biRhs = rhs
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 7823, 7875);

                System.Numerics.BigInteger
                biResult = biLhs * biRhs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 7891, 8020) || true) && (biResult <= long.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 7895, 7949) && biResult >= long.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 7891, 8020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 7983, 8005);

                    return (long)biResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 7891, 8020);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 8036, 8060);

                return (double)biResult;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 7641, 8071);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 7641, 8071);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 7641, 8071);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Divide(long lhs, long rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 8083, 8977);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 8292, 8475) || true) && (rhs == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 8292, 8475);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 8338, 8395);

                    DivideByZeroException
                    dbze = f_1665_8367_8394()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 8413, 8460);

                    throw f_1665_8419_8459(f_1665_8440_8452(dbze), dbze);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 8292, 8475);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 8606, 8725) || true) && (lhs == long.MinValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 8610, 8643) && rhs == -1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 8606, 8725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 8677, 8710);

                    return (double)lhs / (double)rhs;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 8606, 8725);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 8831, 8917) || true) && ((lhs % rhs) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 8831, 8917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 8885, 8902);

                    return lhs / rhs;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 8831, 8917);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 8933, 8966);

                return (double)lhs / (double)rhs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 8083, 8977);

                System.DivideByZeroException
                f_1665_8367_8394()
                {
                    var return_v = new System.DivideByZeroException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 8367, 8394);
                    return return_v;
                }


                string
                f_1665_8440_8452(System.DivideByZeroException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 8440, 8452);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_8419_8459(string
                message, System.DivideByZeroException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 8419, 8459);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 8083, 8977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 8083, 8977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Remainder(long lhs, long rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 8989, 9731);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 9201, 9384) || true) && (rhs == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 9201, 9384);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 9247, 9304);

                    DivideByZeroException
                    dbze = f_1665_9276_9303()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 9322, 9369);

                    throw f_1665_9328_9368(f_1665_9349_9361(dbze), dbze);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 9201, 9384);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 9400, 9687) || true) && (lhs == long.MinValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 9404, 9437) && rhs == -1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 9400, 9687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 9662, 9672);

                    return 0L;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 9400, 9687);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 9703, 9720);

                return lhs % rhs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 8989, 9731);

                System.DivideByZeroException
                f_1665_9276_9303()
                {
                    var return_v = new System.DivideByZeroException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 9276, 9303);
                    return return_v;
                }


                string
                f_1665_9349_9361(System.DivideByZeroException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 9349, 9361);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_9328_9368(string
                message, System.DivideByZeroException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 9328, 9368);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 8989, 9731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 8989, 9731);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareEq(long lhs, long rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 9743, 9847);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 9798, 9845);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 9805, 9817) || (((lhs == rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 9820, 9830)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 9833, 9844))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 9743, 9847);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 9743, 9847);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 9743, 9847);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareNe(long lhs, long rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 9859, 9963);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 9914, 9961);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 9921, 9933) || (((lhs != rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 9936, 9946)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 9949, 9960))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 9859, 9963);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 9859, 9963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 9859, 9963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLt(long lhs, long rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 9975, 10078);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 10030, 10076);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 10037, 10048) || (((lhs < rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 10051, 10061)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 10064, 10075))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 9975, 10078);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 9975, 10078);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 9975, 10078);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLe(long lhs, long rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 10090, 10194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 10145, 10192);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 10152, 10164) || (((lhs <= rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 10167, 10177)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 10180, 10191))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 10090, 10194);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 10090, 10194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 10090, 10194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGt(long lhs, long rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 10206, 10309);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 10261, 10307);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 10268, 10279) || (((lhs > rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 10282, 10292)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 10295, 10306))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 10206, 10309);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 10206, 10309);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 10206, 10309);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGe(long lhs, long rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 10321, 10425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 10376, 10423);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 10383, 10395) || (((lhs >= rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 10398, 10408)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 10411, 10422))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 10321, 10425);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 10321, 10425);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 10321, 10425);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static LongOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1665, 6967, 10432);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1665, 6967, 10432);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 6967, 10432);
        }

    }
    internal static class ULongOps
    {
        internal static object Add(ulong lhs, ulong rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 10487, 10766);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 10560, 10605);

                decimal
                result = (decimal)lhs + (decimal)rhs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 10619, 10717) || true) && (result <= ulong.MaxValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 10619, 10717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 10681, 10702);

                    return (ulong)result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 10619, 10717);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 10733, 10755);

                return (double)result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 10487, 10766);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 10487, 10766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 10487, 10766);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Sub(ulong lhs, ulong rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 10778, 11057);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 10851, 10896);

                decimal
                result = (decimal)lhs - (decimal)rhs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 10910, 11008) || true) && (result >= ulong.MinValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 10910, 11008);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 10972, 10993);

                    return (ulong)result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 10910, 11008);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 11024, 11046);

                return (double)result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 10778, 11057);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 10778, 11057);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 10778, 11057);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Multiply(ulong lhs, ulong rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 11069, 11474);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 11147, 11186);

                System.Numerics.BigInteger
                biLhs = lhs
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 11200, 11239);

                System.Numerics.BigInteger
                biRhs = rhs
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 11253, 11305);

                System.Numerics.BigInteger
                biResult = biLhs * biRhs
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 11321, 11423) || true) && (biResult <= ulong.MaxValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 11321, 11423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 11385, 11408);

                    return (ulong)biResult;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 11321, 11423);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 11439, 11463);

                return (double)biResult;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 11069, 11474);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 11069, 11474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 11069, 11474);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Divide(ulong lhs, ulong rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 11486, 12132);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 11697, 11880) || true) && (rhs == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 11697, 11880);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 11743, 11800);

                    DivideByZeroException
                    dbze = f_1665_11772_11799()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 11818, 11865);

                    throw f_1665_11824_11864(f_1665_11845_11857(dbze), dbze);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 11697, 11880);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 11986, 12072) || true) && ((lhs % rhs) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 11986, 12072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 12040, 12057);

                    return lhs / rhs;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 11986, 12072);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 12088, 12121);

                return (double)lhs / (double)rhs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 11486, 12132);

                System.DivideByZeroException
                f_1665_11772_11799()
                {
                    var return_v = new System.DivideByZeroException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 11772, 11799);
                    return return_v;
                }


                string
                f_1665_11845_11857(System.DivideByZeroException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 11845, 11857);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_11824_11864(string
                message, System.DivideByZeroException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 11824, 11864);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 11486, 12132);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 11486, 12132);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Remainder(ulong lhs, ulong rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 12144, 12585);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 12358, 12541) || true) && (rhs == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 12358, 12541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 12404, 12461);

                    DivideByZeroException
                    dbze = f_1665_12433_12460()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 12479, 12526);

                    throw f_1665_12485_12525(f_1665_12506_12518(dbze), dbze);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 12358, 12541);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 12557, 12574);

                return lhs % rhs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 12144, 12585);

                System.DivideByZeroException
                f_1665_12433_12460()
                {
                    var return_v = new System.DivideByZeroException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 12433, 12460);
                    return return_v;
                }


                string
                f_1665_12506_12518(System.DivideByZeroException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 12506, 12518);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_12485_12525(string
                message, System.DivideByZeroException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 12485, 12525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 12144, 12585);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 12144, 12585);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareEq(ulong lhs, ulong rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 12597, 12703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 12654, 12701);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 12661, 12673) || (((lhs == rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 12676, 12686)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 12689, 12700))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 12597, 12703);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 12597, 12703);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 12597, 12703);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareNe(ulong lhs, ulong rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 12715, 12821);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 12772, 12819);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 12779, 12791) || (((lhs != rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 12794, 12804)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 12807, 12818))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 12715, 12821);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 12715, 12821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 12715, 12821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLt(ulong lhs, ulong rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 12833, 12938);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 12890, 12936);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 12897, 12908) || (((lhs < rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 12911, 12921)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 12924, 12935))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 12833, 12938);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 12833, 12938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 12833, 12938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLe(ulong lhs, ulong rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 12950, 13056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 13007, 13054);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 13014, 13026) || (((lhs <= rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 13029, 13039)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 13042, 13053))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 12950, 13056);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 12950, 13056);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 12950, 13056);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGt(ulong lhs, ulong rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 13068, 13173);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 13125, 13171);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 13132, 13143) || (((lhs > rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 13146, 13156)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 13159, 13170))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 13068, 13173);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 13068, 13173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 13068, 13173);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGe(ulong lhs, ulong rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 13185, 13291);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 13242, 13289);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 13249, 13261) || (((lhs >= rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 13264, 13274)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 13277, 13288))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 13185, 13291);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 13185, 13291);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 13185, 13291);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ULongOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1665, 10440, 13298);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1665, 10440, 13298);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 10440, 13298);
        }

    }
    internal static class DecimalOps
    {
        internal static object Add(decimal lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 13355, 13653);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 13468, 13494);

                    return checked(lhs + rhs);
                }
                catch (OverflowException oe)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1665, 13523, 13642);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 13584, 13627);

                    throw f_1665_13590_13626(f_1665_13611_13621(oe), oe);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1665, 13523, 13642);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 13355, 13653);

                string
                f_1665_13611_13621(System.OverflowException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 13611, 13621);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_13590_13626(string
                message, System.OverflowException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 13590, 13626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 13355, 13653);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 13355, 13653);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Sub(decimal lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 13665, 13963);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 13778, 13804);

                    return checked(lhs - rhs);
                }
                catch (OverflowException oe)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1665, 13833, 13952);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 13894, 13937);

                    throw f_1665_13900_13936(f_1665_13921_13931(oe), oe);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1665, 13833, 13952);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 13665, 13963);

                string
                f_1665_13921_13931(System.OverflowException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 13921, 13931);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_13900_13936(string
                message, System.OverflowException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 13900, 13936);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 13665, 13963);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 13665, 13963);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Multiply(decimal lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 13975, 14278);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 14093, 14119);

                    return checked(lhs * rhs);
                }
                catch (OverflowException oe)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1665, 14148, 14267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 14209, 14252);

                    throw f_1665_14215_14251(f_1665_14236_14246(oe), oe);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1665, 14148, 14267);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 13975, 14278);

                string
                f_1665_14236_14246(System.OverflowException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 14236, 14246);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_14215_14251(string
                message, System.OverflowException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 14215, 14251);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 13975, 14278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 13975, 14278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Divide(decimal lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 14290, 14734);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 14406, 14432);

                    return checked(lhs / rhs);
                }
                catch (OverflowException oe)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1665, 14461, 14580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 14522, 14565);

                    throw f_1665_14528_14564(f_1665_14549_14559(oe), oe);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1665, 14461, 14580);
                }
                catch (DivideByZeroException dbze)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1665, 14594, 14723);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 14661, 14708);

                    throw f_1665_14667_14707(f_1665_14688_14700(dbze), dbze);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1665, 14594, 14723);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 14290, 14734);

                string
                f_1665_14549_14559(System.OverflowException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 14549, 14559);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_14528_14564(string
                message, System.OverflowException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 14528, 14564);
                    return return_v;
                }


                string
                f_1665_14688_14700(System.DivideByZeroException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 14688, 14700);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_14667_14707(string
                message, System.DivideByZeroException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 14667, 14707);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 14290, 14734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 14290, 14734);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Remainder(decimal lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 14746, 15193);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 14865, 14891);

                    return checked(lhs % rhs);
                }
                catch (OverflowException oe)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1665, 14920, 15039);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 14981, 15024);

                    throw f_1665_14987_15023(f_1665_15008_15018(oe), oe);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1665, 14920, 15039);
                }
                catch (DivideByZeroException dbze)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1665, 15053, 15182);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 15120, 15167);

                    throw f_1665_15126_15166(f_1665_15147_15159(dbze), dbze);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1665, 15053, 15182);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 14746, 15193);

                string
                f_1665_15008_15018(System.OverflowException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 15008, 15018);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_14987_15023(string
                message, System.OverflowException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 14987, 15023);
                    return return_v;
                }


                string
                f_1665_15147_15159(System.DivideByZeroException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 15147, 15159);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1665_15126_15166(string
                message, System.DivideByZeroException
                innerException)
                {
                    var return_v = new System.Management.Automation.RuntimeException(message, (System.Exception)innerException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 15126, 15166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 14746, 15193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 14746, 15193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object BNot(decimal val)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 15205, 16173);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 15270, 15423) || true) && (val <= int.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 15274, 15316) && val >= int.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 15270, 15423);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 15350, 15408);

                    return unchecked(~f_1665_15368_15406(val));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 15270, 15423);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 15439, 15595) || true) && (val <= uint.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 15443, 15487) && val >= uint.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 15439, 15595);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 15521, 15580);

                    return unchecked(~f_1665_15539_15578(val));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 15439, 15595);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 15611, 15767) || true) && (val <= long.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 15615, 15659) && val >= long.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 15611, 15767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 15693, 15752);

                    return unchecked(~f_1665_15711_15750(val));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 15611, 15767);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 15783, 15942) || true) && (val <= ulong.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 15787, 15833) && val >= ulong.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 15783, 15942);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 15867, 15927);

                    return unchecked(~f_1665_15885_15925(val));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 15783, 15942);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 15958, 16021);

                f_1665_15958_16020(val, typeof(int));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 16035, 16136);

                f_1665_16035_16135(false, "an exception is raised by LanguagePrimitives.ThrowInvalidCastException.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 16150, 16162);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 15205, 16173);

                int
                f_1665_15368_15406(decimal
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<int>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 15368, 15406);
                    return return_v;
                }


                uint
                f_1665_15539_15578(decimal
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<uint>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 15539, 15578);
                    return return_v;
                }


                long
                f_1665_15711_15750(decimal
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<long>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 15711, 15750);
                    return return_v;
                }


                ulong
                f_1665_15885_15925(decimal
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<ulong>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 15885, 15925);
                    return return_v;
                }


                object
                f_1665_15958_16020(decimal
                valueToConvert, System.Type
                resultType)
                {
                    var return_v = LanguagePrimitives.ThrowInvalidCastException((object)valueToConvert, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 15958, 16020);
                    return return_v;
                }


                int
                f_1665_16035_16135(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 16035, 16135);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 15205, 16173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 15205, 16173);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object BOr(decimal lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 16185, 16619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 16262, 16292);

                ulong
                l = f_1665_16272_16291(lhs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 16306, 16336);

                ulong
                r = f_1665_16316_16335(rhs)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 16418, 16579) || true) && (lhs < 0 || (DynAbs.Tracing.TraceSender.Expression_False(1665, 16422, 16440) || rhs < 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 16418, 16579);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 16524, 16545);

                        return (long)(l | r);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 16418, 16579);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 16595, 16608);

                return l | r;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 16185, 16619);

                ulong
                f_1665_16272_16291(decimal
                val)
                {
                    var return_v = ConvertToUlong(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 16272, 16291);
                    return return_v;
                }


                ulong
                f_1665_16316_16335(decimal
                val)
                {
                    var return_v = ConvertToUlong(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 16316, 16335);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 16185, 16619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 16185, 16619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object BXor(decimal lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 16631, 17066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 16709, 16739);

                ulong
                l = f_1665_16719_16738(lhs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 16753, 16783);

                ulong
                r = f_1665_16763_16782(rhs)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 16865, 17026) || true) && (lhs < 0 || (DynAbs.Tracing.TraceSender.Expression_False(1665, 16869, 16887) || rhs < 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 16865, 17026);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 16971, 16992);

                        return (long)(l ^ r);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 16865, 17026);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 17042, 17055);

                return l ^ r;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 16631, 17066);

                ulong
                f_1665_16719_16738(decimal
                val)
                {
                    var return_v = ConvertToUlong(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 16719, 16738);
                    return return_v;
                }


                ulong
                f_1665_16763_16782(decimal
                val)
                {
                    var return_v = ConvertToUlong(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 16763, 16782);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 16631, 17066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 16631, 17066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object BAnd(decimal lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 17078, 17513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 17156, 17186);

                ulong
                l = f_1665_17166_17185(lhs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 17200, 17230);

                ulong
                r = f_1665_17210_17229(rhs)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 17312, 17473) || true) && (lhs < 0 || (DynAbs.Tracing.TraceSender.Expression_False(1665, 17316, 17334) || rhs < 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 17312, 17473);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 17418, 17439);

                        return (long)(l & r);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 17312, 17473);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 17489, 17502);

                return l & r;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 17078, 17513);

                ulong
                f_1665_17166_17185(decimal
                val)
                {
                    var return_v = ConvertToUlong(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 17166, 17185);
                    return return_v;
                }


                ulong
                f_1665_17210_17229(decimal
                val)
                {
                    var return_v = ConvertToUlong(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 17210, 17229);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 17078, 17513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 17078, 17513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ulong ConvertToUlong(decimal val)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 17855, 18167);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 17928, 18092) || true) && (val < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 17928, 18092);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 17973, 18027);

                    long
                    lValue = f_1665_17987_18026(val)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 18045, 18077);

                    return unchecked((ulong)lValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 17928, 18092);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 18108, 18156);

                return f_1665_18115_18155(val);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 17855, 18167);

                long
                f_1665_17987_18026(decimal
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<long>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 17987, 18026);
                    return return_v;
                }


                ulong
                f_1665_18115_18155(decimal
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<ulong>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 18115, 18155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 17855, 18167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 17855, 18167);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object LeftShift(decimal val, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 18179, 19195);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 18260, 18421) || true) && (val <= int.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 18264, 18306) && val >= int.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 18260, 18421);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 18340, 18406);

                    return unchecked(f_1665_18357_18395(val) << count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 18260, 18421);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 18437, 18601) || true) && (val <= uint.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 18441, 18485) && val >= uint.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 18437, 18601);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 18519, 18586);

                    return unchecked(f_1665_18536_18575(val) << count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 18437, 18601);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 18617, 18781) || true) && (val <= long.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 18621, 18665) && val >= long.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 18617, 18781);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 18699, 18766);

                    return unchecked(f_1665_18716_18755(val) << count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 18617, 18781);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 18797, 18964) || true) && (val <= ulong.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 18801, 18847) && val >= ulong.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 18797, 18964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 18881, 18949);

                    return unchecked(f_1665_18898_18938(val) << count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 18797, 18964);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 18980, 19043);

                f_1665_18980_19042(val, typeof(int));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 19057, 19158);

                f_1665_19057_19157(false, "an exception is raised by LanguagePrimitives.ThrowInvalidCastException.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 19172, 19184);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 18179, 19195);

                int
                f_1665_18357_18395(decimal
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<int>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 18357, 18395);
                    return return_v;
                }


                uint
                f_1665_18536_18575(decimal
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<uint>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 18536, 18575);
                    return return_v;
                }


                long
                f_1665_18716_18755(decimal
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<long>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 18716, 18755);
                    return return_v;
                }


                ulong
                f_1665_18898_18938(decimal
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<ulong>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 18898, 18938);
                    return return_v;
                }


                object
                f_1665_18980_19042(decimal
                valueToConvert, System.Type
                resultType)
                {
                    var return_v = LanguagePrimitives.ThrowInvalidCastException((object)valueToConvert, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 18980, 19042);
                    return return_v;
                }


                int
                f_1665_19057_19157(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 19057, 19157);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 18179, 19195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 18179, 19195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object RightShift(decimal val, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 19207, 20224);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 19289, 19450) || true) && (val <= int.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 19293, 19335) && val >= int.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 19289, 19450);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 19369, 19435);

                    return unchecked(f_1665_19386_19424(val) >> count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 19289, 19450);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 19466, 19630) || true) && (val <= uint.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 19470, 19514) && val >= uint.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 19466, 19630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 19548, 19615);

                    return unchecked(f_1665_19565_19604(val) >> count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 19466, 19630);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 19646, 19810) || true) && (val <= long.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 19650, 19694) && val >= long.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 19646, 19810);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 19728, 19795);

                    return unchecked(f_1665_19745_19784(val) >> count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 19646, 19810);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 19826, 19993) || true) && (val <= ulong.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 19830, 19876) && val >= ulong.MinValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 19826, 19993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 19910, 19978);

                    return unchecked(f_1665_19927_19967(val) >> count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 19826, 19993);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 20009, 20072);

                f_1665_20009_20071(val, typeof(int));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 20086, 20187);

                f_1665_20086_20186(false, "an exception is raised by LanguagePrimitives.ThrowInvalidCastException.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 20201, 20213);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 19207, 20224);

                int
                f_1665_19386_19424(decimal
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<int>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 19386, 19424);
                    return return_v;
                }


                uint
                f_1665_19565_19604(decimal
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<uint>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 19565, 19604);
                    return return_v;
                }


                long
                f_1665_19745_19784(decimal
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<long>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 19745, 19784);
                    return return_v;
                }


                ulong
                f_1665_19927_19967(decimal
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<ulong>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 19927, 19967);
                    return return_v;
                }


                object
                f_1665_20009_20071(decimal
                valueToConvert, System.Type
                resultType)
                {
                    var return_v = LanguagePrimitives.ThrowInvalidCastException((object)valueToConvert, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 20009, 20071);
                    return return_v;
                }


                int
                f_1665_20086_20186(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 20086, 20186);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 19207, 20224);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 19207, 20224);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareEq(decimal lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 20236, 20346);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 20297, 20344);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 20304, 20316) || (((lhs == rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 20319, 20329)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 20332, 20343))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 20236, 20346);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 20236, 20346);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 20236, 20346);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareNe(decimal lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 20358, 20468);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 20419, 20466);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 20426, 20438) || (((lhs != rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 20441, 20451)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 20454, 20465))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 20358, 20468);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 20358, 20468);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 20358, 20468);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLt(decimal lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 20480, 20589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 20541, 20587);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 20548, 20559) || (((lhs < rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 20562, 20572)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 20575, 20586))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 20480, 20589);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 20480, 20589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 20480, 20589);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLe(decimal lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 20601, 20711);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 20662, 20709);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 20669, 20681) || (((lhs <= rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 20684, 20694)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 20697, 20708))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 20601, 20711);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 20601, 20711);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 20601, 20711);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGt(decimal lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 20723, 20832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 20784, 20830);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 20791, 20802) || (((lhs > rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 20805, 20815)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 20818, 20829))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 20723, 20832);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 20723, 20832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 20723, 20832);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGe(decimal lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 20844, 20954);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 20905, 20952);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 20912, 20924) || (((lhs >= rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 20927, 20937)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 20940, 20951))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 20844, 20954);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 20844, 20954);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 20844, 20954);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object CompareWithDouble(decimal left, double right,
                                                        Func<double, double, object> doubleComparer,
                                                        Func<decimal, decimal, object> decimalComparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 20966, 21571);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 21249, 21272);

                decimal
                rightAsDecimal
                = default(decimal);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 21322, 21354);

                    rightAsDecimal = (decimal)right;
                }
                catch (OverflowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1665, 21383, 21499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 21441, 21484);

                    return f_1665_21448_21483(doubleComparer, left, right);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1665, 21383, 21499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 21515, 21560);

                return f_1665_21522_21559(decimalComparer, left, rightAsDecimal);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 20966, 21571);

                object
                f_1665_21448_21483(System.Func<double, double, object>
                this_param, decimal
                arg1, double
                arg2)
                {
                    var return_v = this_param.Invoke((double)arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 21448, 21483);
                    return return_v;
                }


                object
                f_1665_21522_21559(System.Func<decimal, decimal, object>
                this_param, decimal
                arg1, decimal
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 21522, 21559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 20966, 21571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 20966, 21571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static object CompareWithDouble(double left, decimal right,
                                                        Func<double, double, object> doubleComparer,
                                                        Func<decimal, decimal, object> decimalComparer)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 21583, 22185);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 21866, 21888);

                decimal
                leftAsDecimal
                = default(decimal);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 21938, 21968);

                    leftAsDecimal = (decimal)left;
                }
                catch (OverflowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1665, 21997, 22113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 22055, 22098);

                    return f_1665_22062_22097(doubleComparer, left, right);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1665, 21997, 22113);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 22129, 22174);

                return f_1665_22136_22173(decimalComparer, leftAsDecimal, right);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 21583, 22185);

                object
                f_1665_22062_22097(System.Func<double, double, object>
                this_param, double
                arg1, decimal
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, (double)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 22062, 22097);
                    return return_v;
                }


                object
                f_1665_22136_22173(System.Func<decimal, decimal, object>
                this_param, decimal
                arg1, decimal
                arg2)
                {
                    var return_v = this_param.Invoke(arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 22136, 22173);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 21583, 22185);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 21583, 22185);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareEq1(double lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 22197, 22327);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 22258, 22325);

                return f_1665_22265_22324(lhs, rhs, DoubleOps.CompareEq, CompareEq);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 22197, 22327);

                object
                f_1665_22265_22324(double
                left, decimal
                right, System.Func<double, double, object>
                doubleComparer, System.Func<decimal, decimal, object>
                decimalComparer)
                {
                    var return_v = CompareWithDouble(left, right, doubleComparer, decimalComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 22265, 22324);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 22197, 22327);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 22197, 22327);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareNe1(double lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 22339, 22469);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 22400, 22467);

                return f_1665_22407_22466(lhs, rhs, DoubleOps.CompareNe, CompareNe);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 22339, 22469);

                object
                f_1665_22407_22466(double
                left, decimal
                right, System.Func<double, double, object>
                doubleComparer, System.Func<decimal, decimal, object>
                decimalComparer)
                {
                    var return_v = CompareWithDouble(left, right, doubleComparer, decimalComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 22407, 22466);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 22339, 22469);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 22339, 22469);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLt1(double lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 22481, 22611);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 22542, 22609);

                return f_1665_22549_22608(lhs, rhs, DoubleOps.CompareLt, CompareLt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 22481, 22611);

                object
                f_1665_22549_22608(double
                left, decimal
                right, System.Func<double, double, object>
                doubleComparer, System.Func<decimal, decimal, object>
                decimalComparer)
                {
                    var return_v = CompareWithDouble(left, right, doubleComparer, decimalComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 22549, 22608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 22481, 22611);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 22481, 22611);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLe1(double lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 22623, 22753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 22684, 22751);

                return f_1665_22691_22750(lhs, rhs, DoubleOps.CompareLe, CompareLe);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 22623, 22753);

                object
                f_1665_22691_22750(double
                left, decimal
                right, System.Func<double, double, object>
                doubleComparer, System.Func<decimal, decimal, object>
                decimalComparer)
                {
                    var return_v = CompareWithDouble(left, right, doubleComparer, decimalComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 22691, 22750);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 22623, 22753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 22623, 22753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGt1(double lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 22765, 22895);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 22826, 22893);

                return f_1665_22833_22892(lhs, rhs, DoubleOps.CompareGt, CompareGt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 22765, 22895);

                object
                f_1665_22833_22892(double
                left, decimal
                right, System.Func<double, double, object>
                doubleComparer, System.Func<decimal, decimal, object>
                decimalComparer)
                {
                    var return_v = CompareWithDouble(left, right, doubleComparer, decimalComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 22833, 22892);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 22765, 22895);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 22765, 22895);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGe1(double lhs, decimal rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 22907, 23037);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 22968, 23035);

                return f_1665_22975_23034(lhs, rhs, DoubleOps.CompareGe, CompareGe);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 22907, 23037);

                object
                f_1665_22975_23034(double
                left, decimal
                right, System.Func<double, double, object>
                doubleComparer, System.Func<decimal, decimal, object>
                decimalComparer)
                {
                    var return_v = CompareWithDouble(left, right, doubleComparer, decimalComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 22975, 23034);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 22907, 23037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 22907, 23037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareEq2(decimal lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 23049, 23179);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 23110, 23177);

                return f_1665_23117_23176(lhs, rhs, DoubleOps.CompareEq, CompareEq);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 23049, 23179);

                object
                f_1665_23117_23176(decimal
                left, double
                right, System.Func<double, double, object>
                doubleComparer, System.Func<decimal, decimal, object>
                decimalComparer)
                {
                    var return_v = CompareWithDouble(left, right, doubleComparer, decimalComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 23117, 23176);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 23049, 23179);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 23049, 23179);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareNe2(decimal lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 23191, 23321);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 23252, 23319);

                return f_1665_23259_23318(lhs, rhs, DoubleOps.CompareNe, CompareNe);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 23191, 23321);

                object
                f_1665_23259_23318(decimal
                left, double
                right, System.Func<double, double, object>
                doubleComparer, System.Func<decimal, decimal, object>
                decimalComparer)
                {
                    var return_v = CompareWithDouble(left, right, doubleComparer, decimalComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 23259, 23318);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 23191, 23321);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 23191, 23321);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLt2(decimal lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 23333, 23463);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 23394, 23461);

                return f_1665_23401_23460(lhs, rhs, DoubleOps.CompareLt, CompareLt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 23333, 23463);

                object
                f_1665_23401_23460(decimal
                left, double
                right, System.Func<double, double, object>
                doubleComparer, System.Func<decimal, decimal, object>
                decimalComparer)
                {
                    var return_v = CompareWithDouble(left, right, doubleComparer, decimalComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 23401, 23460);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 23333, 23463);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 23333, 23463);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLe2(decimal lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 23475, 23605);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 23536, 23603);

                return f_1665_23543_23602(lhs, rhs, DoubleOps.CompareLe, CompareLe);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 23475, 23605);

                object
                f_1665_23543_23602(decimal
                left, double
                right, System.Func<double, double, object>
                doubleComparer, System.Func<decimal, decimal, object>
                decimalComparer)
                {
                    var return_v = CompareWithDouble(left, right, doubleComparer, decimalComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 23543, 23602);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 23475, 23605);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 23475, 23605);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGt2(decimal lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 23617, 23747);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 23678, 23745);

                return f_1665_23685_23744(lhs, rhs, DoubleOps.CompareGt, CompareGt);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 23617, 23747);

                object
                f_1665_23685_23744(decimal
                left, double
                right, System.Func<double, double, object>
                doubleComparer, System.Func<decimal, decimal, object>
                decimalComparer)
                {
                    var return_v = CompareWithDouble(left, right, doubleComparer, decimalComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 23685, 23744);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 23617, 23747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 23617, 23747);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGe2(decimal lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 23759, 23889);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 23820, 23887);

                return f_1665_23827_23886(lhs, rhs, DoubleOps.CompareGe, CompareGe);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 23759, 23889);

                object
                f_1665_23827_23886(decimal
                left, double
                right, System.Func<double, double, object>
                doubleComparer, System.Func<decimal, decimal, object>
                decimalComparer)
                {
                    var return_v = CompareWithDouble(left, right, doubleComparer, decimalComparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 23827, 23886);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 23759, 23889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 23759, 23889);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DecimalOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1665, 13306, 23896);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1665, 13306, 23896);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 13306, 23896);
        }

    }
    internal static class DoubleOps
    {
        internal static object Add(double lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 23952, 24055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 24027, 24044);

                return lhs + rhs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 23952, 24055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 23952, 24055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 23952, 24055);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Sub(double lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 24067, 24170);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 24142, 24159);

                return lhs - rhs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 24067, 24170);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 24067, 24170);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 24067, 24170);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Multiply(double lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 24182, 24290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 24262, 24279);

                return lhs * rhs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 24182, 24290);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 24182, 24290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 24182, 24290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Divide(double lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 24302, 24408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 24380, 24397);

                return lhs / rhs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 24302, 24408);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 24302, 24408);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 24302, 24408);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object Remainder(double lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 24420, 24529);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 24501, 24518);

                return lhs % rhs;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 24420, 24529);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 24420, 24529);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 24420, 24529);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object BNot(double val)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 24541, 25773);
                try
                {
                    checked
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 24689, 24855) || true) && (val <= int.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 24693, 24735) && val >= int.MinValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 24689, 24855);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 24785, 24832);

                            return ~f_1665_24793_24831(val);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 24689, 24855);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 24879, 25048) || true) && (val <= uint.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 24883, 24927) && val >= uint.MinValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 24879, 25048);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 24977, 25025);

                            return ~f_1665_24985_25024(val);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 24879, 25048);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 25072, 25241) || true) && (val <= long.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 25076, 25120) && val >= long.MinValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 25072, 25241);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 25170, 25218);

                            return ~f_1665_25178_25217(val);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 25072, 25241);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 25265, 25437) || true) && (val <= ulong.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 25269, 25315) && val >= ulong.MinValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 25265, 25437);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 25365, 25414);

                            return ~f_1665_25373_25413(val);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 25265, 25437);
                        }
                    }
                }
                catch (OverflowException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1665, 25485, 25540);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1665, 25485, 25540);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 25556, 25621);

                f_1665_25556_25620(val, typeof(ulong));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 25635, 25736);

                f_1665_25635_25735(false, "an exception is raised by LanguagePrimitives.ThrowInvalidCastException.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 25750, 25762);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 24541, 25773);

                int
                f_1665_24793_24831(double
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<int>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 24793, 24831);
                    return return_v;
                }


                uint
                f_1665_24985_25024(double
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<uint>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 24985, 25024);
                    return return_v;
                }


                long
                f_1665_25178_25217(double
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<long>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 25178, 25217);
                    return return_v;
                }


                ulong
                f_1665_25373_25413(double
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<ulong>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 25373, 25413);
                    return return_v;
                }


                object
                f_1665_25556_25620(double
                valueToConvert, System.Type
                resultType)
                {
                    var return_v = LanguagePrimitives.ThrowInvalidCastException((object)valueToConvert, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 25556, 25620);
                    return return_v;
                }


                int
                f_1665_25635_25735(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 25635, 25735);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 24541, 25773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 24541, 25773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object BOr(double lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 25785, 26217);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 25860, 25890);

                ulong
                l = f_1665_25870_25889(lhs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 25904, 25934);

                ulong
                r = f_1665_25914_25933(rhs)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 26016, 26177) || true) && (lhs < 0 || (DynAbs.Tracing.TraceSender.Expression_False(1665, 26020, 26038) || rhs < 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 26016, 26177);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 26122, 26143);

                        return (long)(l | r);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 26016, 26177);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 26193, 26206);

                return l | r;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 25785, 26217);

                ulong
                f_1665_25870_25889(double
                val)
                {
                    var return_v = ConvertToUlong(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 25870, 25889);
                    return return_v;
                }


                ulong
                f_1665_25914_25933(double
                val)
                {
                    var return_v = ConvertToUlong(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 25914, 25933);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 25785, 26217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 25785, 26217);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object BXor(double lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 26229, 26662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 26305, 26335);

                ulong
                l = f_1665_26315_26334(lhs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 26349, 26379);

                ulong
                r = f_1665_26359_26378(rhs)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 26461, 26622) || true) && (lhs < 0 || (DynAbs.Tracing.TraceSender.Expression_False(1665, 26465, 26483) || rhs < 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 26461, 26622);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 26567, 26588);

                        return (long)(l ^ r);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 26461, 26622);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 26638, 26651);

                return l ^ r;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 26229, 26662);

                ulong
                f_1665_26315_26334(double
                val)
                {
                    var return_v = ConvertToUlong(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 26315, 26334);
                    return return_v;
                }


                ulong
                f_1665_26359_26378(double
                val)
                {
                    var return_v = ConvertToUlong(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 26359, 26378);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 26229, 26662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 26229, 26662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object BAnd(double lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 26674, 27107);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 26750, 26780);

                ulong
                l = f_1665_26760_26779(lhs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 26794, 26824);

                ulong
                r = f_1665_26804_26823(rhs)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 26906, 27067) || true) && (lhs < 0 || (DynAbs.Tracing.TraceSender.Expression_False(1665, 26910, 26928) || rhs < 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 26906, 27067);
                    unchecked
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 27012, 27033);

                        return (long)(l & r);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 26906, 27067);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 27083, 27096);

                return l & r;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 26674, 27107);

                ulong
                f_1665_26760_26779(double
                val)
                {
                    var return_v = ConvertToUlong(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 26760, 26779);
                    return return_v;
                }


                ulong
                f_1665_26804_26823(double
                val)
                {
                    var return_v = ConvertToUlong(val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 26804, 26823);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 26674, 27107);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 26674, 27107);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ulong ConvertToUlong(double val)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 27448, 27759);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 27520, 27684) || true) && (val < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 27520, 27684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 27565, 27619);

                    long
                    lValue = f_1665_27579_27618(val)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 27637, 27669);

                    return unchecked((ulong)lValue);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 27520, 27684);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 27700, 27748);

                return f_1665_27707_27747(val);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 27448, 27759);

                long
                f_1665_27579_27618(double
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<long>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 27579, 27618);
                    return return_v;
                }


                ulong
                f_1665_27707_27747(double
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<ulong>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 27707, 27747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 27448, 27759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 27448, 27759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object LeftShift(double val, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 27771, 28859);
                checked
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 27891, 28053) || true) && (val <= int.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 27895, 27937) && val >= int.MinValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 27891, 28053);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 27979, 28034);

                        return f_1665_27986_28024(val) << count;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 27891, 28053);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 28073, 28238) || true) && (val <= uint.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 28077, 28121) && val >= uint.MinValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 28073, 28238);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 28163, 28219);

                        return f_1665_28170_28209(val) << count;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 28073, 28238);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 28258, 28423) || true) && (val <= long.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 28262, 28306) && val >= long.MinValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 28258, 28423);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 28348, 28404);

                        return f_1665_28355_28394(val) << count;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 28258, 28423);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 28443, 28611) || true) && (val <= ulong.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 28447, 28493) && val >= ulong.MinValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 28443, 28611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 28535, 28592);

                        return f_1665_28542_28582(val) << count;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 28443, 28611);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 28642, 28707);

                f_1665_28642_28706(val, typeof(ulong));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 28721, 28822);

                f_1665_28721_28821(false, "an exception is raised by LanguagePrimitives.ThrowInvalidCastException.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 28836, 28848);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 27771, 28859);

                int
                f_1665_27986_28024(double
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<int>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 27986, 28024);
                    return return_v;
                }


                uint
                f_1665_28170_28209(double
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<uint>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 28170, 28209);
                    return return_v;
                }


                long
                f_1665_28355_28394(double
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<long>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 28355, 28394);
                    return return_v;
                }


                ulong
                f_1665_28542_28582(double
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<ulong>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 28542, 28582);
                    return return_v;
                }


                object
                f_1665_28642_28706(double
                valueToConvert, System.Type
                resultType)
                {
                    var return_v = LanguagePrimitives.ThrowInvalidCastException((object)valueToConvert, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 28642, 28706);
                    return return_v;
                }


                int
                f_1665_28721_28821(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 28721, 28821);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 27771, 28859);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 27771, 28859);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object RightShift(double val, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 28871, 29960);
                checked
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 28992, 29154) || true) && (val <= int.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 28996, 29038) && val >= int.MinValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 28992, 29154);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 29080, 29135);

                        return f_1665_29087_29125(val) >> count;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 28992, 29154);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 29174, 29339) || true) && (val <= uint.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 29178, 29222) && val >= uint.MinValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 29174, 29339);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 29264, 29320);

                        return f_1665_29271_29310(val) >> count;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 29174, 29339);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 29359, 29524) || true) && (val <= long.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 29363, 29407) && val >= long.MinValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 29359, 29524);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 29449, 29505);

                        return f_1665_29456_29495(val) >> count;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 29359, 29524);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 29544, 29712) || true) && (val <= ulong.MaxValue && (DynAbs.Tracing.TraceSender.Expression_True(1665, 29548, 29594) && val >= ulong.MinValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 29544, 29712);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 29636, 29693);

                        return f_1665_29643_29683(val) >> count;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 29544, 29712);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 29743, 29808);

                f_1665_29743_29807(val, typeof(ulong));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 29822, 29923);

                f_1665_29822_29922(false, "an exception is raised by LanguagePrimitives.ThrowInvalidCastException.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 29937, 29949);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 28871, 29960);

                int
                f_1665_29087_29125(double
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<int>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 29087, 29125);
                    return return_v;
                }


                uint
                f_1665_29271_29310(double
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<uint>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 29271, 29310);
                    return return_v;
                }


                long
                f_1665_29456_29495(double
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<long>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 29456, 29495);
                    return return_v;
                }


                ulong
                f_1665_29643_29683(double
                valueToConvert)
                {
                    var return_v = LanguagePrimitives.ConvertTo<ulong>((object)valueToConvert);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 29643, 29683);
                    return return_v;
                }


                object
                f_1665_29743_29807(double
                valueToConvert, System.Type
                resultType)
                {
                    var return_v = LanguagePrimitives.ThrowInvalidCastException((object)valueToConvert, resultType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 29743, 29807);
                    return return_v;
                }


                int
                f_1665_29822_29922(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 29822, 29922);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 28871, 29960);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 28871, 29960);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareEq(double lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 29972, 30080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 30031, 30078);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 30038, 30050) || (((lhs == rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 30053, 30063)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 30066, 30077))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 29972, 30080);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 29972, 30080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 29972, 30080);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareNe(double lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 30092, 30200);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 30151, 30198);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 30158, 30170) || (((lhs != rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 30173, 30183)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 30186, 30197))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 30092, 30200);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 30092, 30200);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 30092, 30200);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLt(double lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 30212, 30319);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 30271, 30317);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 30278, 30289) || (((lhs < rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 30292, 30302)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 30305, 30316))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 30212, 30319);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 30212, 30319);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 30212, 30319);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareLe(double lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 30331, 30439);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 30390, 30437);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 30397, 30409) || (((lhs <= rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 30412, 30422)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 30425, 30436))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 30331, 30439);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 30331, 30439);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 30331, 30439);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGt(double lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 30451, 30558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 30510, 30556);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 30517, 30528) || (((lhs > rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 30531, 30541)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 30544, 30555))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 30451, 30558);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 30451, 30558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 30451, 30558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareGe(double lhs, double rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 30570, 30678);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 30629, 30676);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 30636, 30648) || (((lhs >= rhs) && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 30651, 30661)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 30664, 30675))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 30570, 30678);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 30570, 30678);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 30570, 30678);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DoubleOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1665, 23904, 30685);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1665, 23904, 30685);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 23904, 30685);
        }

    }
    internal static class CharOps
    {
        internal static object CompareStringIeq(char lhs, string rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 30739, 30970);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 30825, 30912) || true) && (f_1665_30829_30839(rhs) != 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 30825, 30912);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 30878, 30897);

                    return Boxed.False;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 30825, 30912);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 30928, 30959);

                return f_1665_30935_30958(lhs, f_1665_30951_30957(rhs, 0));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 30739, 30970);

                int
                f_1665_30829_30839(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 30829, 30839);
                    return return_v;
                }


                char
                f_1665_30951_30957(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 30951, 30957);
                    return return_v;
                }


                object
                f_1665_30935_30958(char
                lhs, char
                rhs)
                {
                    var return_v = CompareIeq(lhs, rhs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 30935, 30958);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 30739, 30970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 30739, 30970);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareStringIne(char lhs, string rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 30982, 31212);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 31068, 31154) || true) && (f_1665_31072_31082(rhs) != 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 31068, 31154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 31121, 31139);

                    return Boxed.True;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 31068, 31154);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 31170, 31201);

                return f_1665_31177_31200(lhs, f_1665_31193_31199(rhs, 0));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 30982, 31212);

                int
                f_1665_31072_31082(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 31072, 31082);
                    return return_v;
                }


                char
                f_1665_31193_31199(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 31193, 31199);
                    return return_v;
                }


                object
                f_1665_31177_31200(char
                lhs, char
                rhs)
                {
                    var return_v = CompareIne(lhs, rhs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 31177, 31200);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 30982, 31212);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 30982, 31212);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareIeq(char lhs, char rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 31224, 31500);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 31302, 31349);

                char
                firstAsUpper = f_1665_31322_31348(lhs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 31363, 31411);

                char
                secondAsUpper = f_1665_31384_31410(rhs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 31425, 31489);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 31432, 31461) || ((firstAsUpper == secondAsUpper && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 31464, 31474)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 31477, 31488))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 31224, 31500);

                char
                f_1665_31322_31348(char
                c)
                {
                    var return_v = char.ToUpperInvariant(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 31322, 31348);
                    return return_v;
                }


                char
                f_1665_31384_31410(char
                c)
                {
                    var return_v = char.ToUpperInvariant(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 31384, 31410);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 31224, 31500);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 31224, 31500);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object CompareIne(char lhs, char rhs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 31512, 31788);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 31590, 31637);

                char
                firstAsUpper = f_1665_31610_31636(lhs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 31651, 31699);

                char
                secondAsUpper = f_1665_31672_31698(rhs)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 31713, 31777);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1665, 31720, 31749) || ((firstAsUpper != secondAsUpper && DynAbs.Tracing.TraceSender.Conditional_F2(1665, 31752, 31762)) || DynAbs.Tracing.TraceSender.Conditional_F3(1665, 31765, 31776))) ? Boxed.True : Boxed.False;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 31512, 31788);

                char
                f_1665_31610_31636(char
                c)
                {
                    var return_v = char.ToUpperInvariant(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 31610, 31636);
                    return return_v;
                }


                char
                f_1665_31672_31698(char
                c)
                {
                    var return_v = char.ToUpperInvariant(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 31672, 31698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 31512, 31788);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 31512, 31788);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object[] Range(char start, char end)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1665, 31800, 32507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 31877, 31900);

                int
                lower = (int)start
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 31914, 31935);

                int
                upper = (int)end
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 31951, 31999);

                int
                absRange = f_1665_31966_31998(checked(upper - lower))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 32015, 32054);

                object[]
                ra = new object[absRange + 1]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 32068, 32470) || true) && (lower > upper)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 32068, 32470);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 32164, 32174);
                        // 3 .. 1 => 3 2 1
                        for (int
        offset = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 32155, 32254) || true) && (offset < f_1665_32185_32194(ra))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 32196, 32204)
        , offset++, DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 32155, 32254))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 32155, 32254);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 32227, 32254);

                            ra[offset] = (char)lower--;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1665, 1, 100);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1665, 1, 100);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 32068, 32470);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 32068, 32470);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 32365, 32375);
                        // 1 .. 3 => 1 2 3
                        for (int
        offset = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 32356, 32455) || true) && (offset < f_1665_32386_32395(ra))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 32397, 32405)
        , offset++, DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 32356, 32455))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1665, 32356, 32455);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 32428, 32455);

                            ra[offset] = (char)lower++;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1665, 1, 100);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1665, 1, 100);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1665, 32068, 32470);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1665, 32486, 32496);

                return ra;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1665, 31800, 32507);

                int
                f_1665_31966_31998(int
                value)
                {
                    var return_v = Math.Abs(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1665, 31966, 31998);
                    return return_v;
                }


                int
                f_1665_32185_32194(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 32185, 32194);
                    return return_v;
                }


                int
                f_1665_32386_32395(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1665, 32386, 32395);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1665, 31800, 32507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 31800, 32507);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static CharOps()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1665, 30693, 32514);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1665, 30693, 32514);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1665, 30693, 32514);
        }

    }
}
