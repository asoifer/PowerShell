// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Management.Automation.Host;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation.Internal
{
    internal static
        class StringUtil
    {
        internal static
                string
                Format(string formatSpec, object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1042, 336, 533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 437, 522);

                return f_1042_444_521(f_1042_458_505(), formatSpec, o);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1042, 336, 533);

                System.Globalization.CultureInfo
                f_1042_458_505()
                {
                    var return_v = System.Globalization.CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1042, 458, 505);
                    return return_v;
                }


                string
                f_1042_444_521(System.Globalization.CultureInfo
                provider, string
                format, object
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1042, 444, 521);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1042, 336, 533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1042, 336, 533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static
                string
                Format(string formatSpec, object o1, object o2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1042, 545, 759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 658, 748);

                return f_1042_665_747(f_1042_679_726(), formatSpec, o1, o2);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1042, 545, 759);

                System.Globalization.CultureInfo
                f_1042_679_726()
                {
                    var return_v = System.Globalization.CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1042, 679, 726);
                    return return_v;
                }


                string
                f_1042_665_747(System.Globalization.CultureInfo
                provider, string
                format, object
                arg0, object
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, arg0, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1042, 665, 747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1042, 545, 759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1042, 545, 759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static
                string
                Format(string formatSpec, params object[] o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1042, 771, 977);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 881, 966);

                return f_1042_888_965(f_1042_902_949(), formatSpec, o);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1042, 771, 977);

                System.Globalization.CultureInfo
                f_1042_902_949()
                {
                    var return_v = System.Globalization.CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1042, 902, 949);
                    return return_v;
                }


                string
                f_1042_888_965(System.Globalization.CultureInfo
                provider, string
                format, params object[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1042, 888, 965);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1042, 771, 977);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1042, 771, 977);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static
                string
                TruncateToBufferCellWidth(PSHostRawUserInterface rawUI, string toTruncate, int maxWidthInBufferCells)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1042, 989, 2120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 1156, 1202);

                f_1042_1156_1201(rawUI != null, "need a reference");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 1216, 1297);

                f_1042_1216_1296(maxWidthInBufferCells >= 0, "maxWidthInBufferCells must be positive");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 1313, 1327);

                string
                result
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 1341, 1400);

                int
                i = f_1042_1349_1399(f_1042_1358_1375(toTruncate), maxWidthInBufferCells)
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1042, 1416, 2079);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 1451, 1487);

                            result = f_1042_1460_1486(toTruncate, 0, i);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 1505, 1555);

                            int
                            cellCount = f_1042_1521_1554(rawUI, result)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 1573, 2050) || true) && (cellCount <= maxWidthInBufferCells)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1042, 1573, 2050);
                                DynAbs.Tracing.TraceSender.TraceBreak(1042, 1710, 1716);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1042, 1573, 2050);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1042, 1573, 2050);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 2027, 2031);

                                --i;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1042, 1573, 2050);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1042, 1416, 2079);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 1416, 2079) || true) && (true)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1042, 1416, 2079);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1042, 1416, 2079);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 2095, 2109);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1042, 989, 2120);

                int
                f_1042_1156_1201(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1042, 1156, 1201);
                    return 0;
                }


                int
                f_1042_1216_1296(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1042, 1216, 1296);
                    return 0;
                }


                int
                f_1042_1358_1375(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1042, 1358, 1375);
                    return return_v;
                }


                int
                f_1042_1349_1399(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1042, 1349, 1399);
                    return return_v;
                }


                string
                f_1042_1460_1486(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1042, 1460, 1486);
                    return return_v;
                }


                int
                f_1042_1521_1554(System.Management.Automation.Host.PSHostRawUserInterface
                this_param, string
                source)
                {
                    var return_v = this_param.LengthInBufferCells(source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1042, 1521, 1554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1042, 989, 2120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1042, 989, 2120);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const int
        IndentCacheMax = 120
        ;

        private static readonly string[] IndentCache;

        internal static string Padding(int countOfSpaces)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1042, 2370, 2868);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 2444, 2536) || true) && (countOfSpaces >= IndentCacheMax)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1042, 2444, 2536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 2498, 2536);

                    return f_1042_2505_2535(' ', countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1042, 2444, 2536);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 2552, 2592);

                var
                result = IndentCache[countOfSpaces]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 2608, 2827) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1042, 2608, 2827);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 2660, 2758);

                    f_1042_2660_2757(ref IndentCache[countOfSpaces], f_1042_2720_2750(' ', countOfSpaces), null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 2776, 2812);

                    result = IndentCache[countOfSpaces];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1042, 2608, 2827);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 2843, 2857);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1042, 2370, 2868);

                string
                f_1042_2505_2535(char
                c, int
                count)
                {
                    var return_v = new string(c, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1042, 2505, 2535);
                    return return_v;
                }


                string
                f_1042_2720_2750(char
                c, int
                count)
                {
                    var return_v = new string(c, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1042, 2720, 2750);
                    return return_v;
                }


                string
                f_1042_2660_2757(ref string
                location1, string
                value, string
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1042, 2660, 2757);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1042, 2370, 2868);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1042, 2370, 2868);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const int
        DashCacheMax = 120
        ;

        private static readonly string[] DashCache;

        internal static string DashPadding(int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1042, 3007, 3445);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 3077, 3151) || true) && (count >= DashCacheMax)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1042, 3077, 3151);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 3121, 3151);

                    return f_1042_3128_3150('-', count);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1042, 3077, 3151);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 3167, 3197);

                var
                result = DashCache[count]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 3213, 3404) || true) && (result == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1042, 3213, 3404);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 3265, 3345);

                    f_1042_3265_3344(ref DashCache[count], f_1042_3315_3337('-', count), null);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 3363, 3389);

                    result = DashCache[count];
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1042, 3213, 3404);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 3420, 3434);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1042, 3007, 3445);

                string
                f_1042_3128_3150(char
                c, int
                count)
                {
                    var return_v = new string(c, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1042, 3128, 3150);
                    return return_v;
                }


                string
                f_1042_3315_3337(char
                c, int
                count)
                {
                    var return_v = new string(c, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1042, 3315, 3337);
                    return return_v;
                }


                string
                f_1042_3265_3344(ref string
                location1, string
                value, string
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1042, 3265, 3344);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1042, 3007, 3445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1042, 3007, 3445);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static StringUtil()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1042, 282, 3452);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 2255, 2275);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 2319, 2359);
            IndentCache = new string[IndentCacheMax];
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 2898, 2916);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1042, 2960, 2996);
            DashCache = new string[DashCacheMax];
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1042, 282, 3452);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1042, 282, 3452);
        }

    }
}

