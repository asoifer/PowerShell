// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Globalization;

namespace System.Management.Automation
{
    internal static class FuzzyMatcher
    {
        public const int
        MinimumDistance = 5
        ;

        public static bool IsFuzzyMatch(string string1, string string2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1012, 643, 816);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 731, 805);

                return f_1012_738_785(string1, string2) <= MinimumDistance;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1012, 643, 816);

                int
                f_1012_738_785(string
                string1, string
                string2)
                {
                    var return_v = GetDamerauLevenshteinDistance(string1, string2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1012, 738, 785);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1012, 643, 816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1012, 643, 816);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static int GetDamerauLevenshteinDistance(string string1, string string2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1012, 1334, 2934);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1438, 1492);

                string1 = f_1012_1448_1491(string1, f_1012_1464_1490());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1506, 1560);

                string2 = f_1012_1516_1559(string2, f_1012_1532_1558());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1576, 1653);

                var
                bounds = new { Height = f_1012_1604_1618(string1) + 1, Width = f_1012_1632_1646(string2) + 1 }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1669, 1722);

                int[,]
                matrix = new int[f_1012_1693_1706(bounds), f_1012_1708_1720(bounds)]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1747, 1757);

                    for (int
        height = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1738, 1824) || true) && (height < f_1012_1768_1781(bounds))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1783, 1791)
        , height++, DynAbs.Tracing.TraceSender.TraceExitCondition(1012, 1738, 1824))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1012, 1738, 1824);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1795, 1822);

                        matrix[height, 0] = height;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1012, 1, 87);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1012, 1, 87);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1824, 1825);
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1848, 1857);
                    for (int
        width = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1839, 1919) || true) && (width < f_1012_1867_1879(bounds))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1881, 1888)
        , width++, DynAbs.Tracing.TraceSender.TraceExitCondition(1012, 1839, 1919))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1012, 1839, 1919);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1892, 1917);

                        matrix[0, width] = width;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1012, 1, 81);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1012, 1, 81);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1919, 1920);
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1945, 1955);

                    for (int
        height = 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1936, 2856) || true) && (height < f_1012_1966_1979(bounds))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 1981, 1989)
        , height++, DynAbs.Tracing.TraceSender.TraceExitCondition(1012, 1936, 2856))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1012, 1936, 2856);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 2032, 2041);
                            for (int
            width = 1
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 2023, 2841) || true) && (width < f_1012_2051_2063(bounds))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 2065, 2072)
            , width++, DynAbs.Tracing.TraceSender.TraceExitCondition(1012, 2023, 2841))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1012, 2023, 2841);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 2114, 2177);

                                int
                                cost = (DynAbs.Tracing.TraceSender.Conditional_F1(1012, 2125, 2168) || (((f_1012_2126_2145(string1, height - 1) == f_1012_2149_2167(string2, width - 1)) && DynAbs.Tracing.TraceSender.Conditional_F2(1012, 2171, 2172)) || DynAbs.Tracing.TraceSender.Conditional_F3(1012, 2175, 2176))) ? 0 : 1
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 2199, 2245);

                                int
                                insertion = matrix[height, width - 1] + 1
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 2267, 2312);

                                int
                                deletion = matrix[height - 1, width] + 1
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 2334, 2390);

                                int
                                substitution = matrix[height - 1, width - 1] + cost
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 2414, 2483);

                                int
                                distance = f_1012_2429_2482(insertion, f_1012_2449_2481(deletion, substitution))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 2507, 2765) || true) && (height > 1 && (DynAbs.Tracing.TraceSender.Expression_True(1012, 2511, 2534) && width > 1) && (DynAbs.Tracing.TraceSender.Expression_True(1012, 2511, 2579) && f_1012_2538_2557(string1, height - 1) == f_1012_2561_2579(string2, width - 2)) && (DynAbs.Tracing.TraceSender.Expression_True(1012, 2511, 2624) && f_1012_2583_2602(string1, height - 2) == f_1012_2606_2624(string2, width - 1)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1012, 2507, 2765);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 2674, 2742);

                                    distance = f_1012_2685_2741(distance, matrix[height - 2, width - 2] + cost);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1012, 2507, 2765);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 2789, 2822);

                                matrix[height, width] = distance;
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1012, 1, 819);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1012, 1, 819);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1012, 1, 921);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1012, 1, 921);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 2872, 2923);

                return matrix[f_1012_2886_2899(bounds) - 1, f_1012_2905_2917(bounds) - 1];
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1012, 1334, 2934);

                System.Globalization.CultureInfo
                f_1012_1464_1490()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 1464, 1490);
                    return return_v;
                }


                string
                f_1012_1448_1491(string
                this_param, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = this_param.ToUpper(culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1012, 1448, 1491);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1012_1532_1558()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 1532, 1558);
                    return return_v;
                }


                string
                f_1012_1516_1559(string
                this_param, System.Globalization.CultureInfo
                culture)
                {
                    var return_v = this_param.ToUpper(culture);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1012, 1516, 1559);
                    return return_v;
                }


                int
                f_1012_1604_1618(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 1604, 1618);
                    return return_v;
                }


                int
                f_1012_1632_1646(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 1632, 1646);
                    return return_v;
                }


                int
                f_1012_1693_1706(dynamic
                this_param)
                {
                    var return_v = this_param.Height;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 1693, 1706);
                    return return_v;
                }


                int
                f_1012_1708_1720(dynamic
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 1708, 1720);
                    return return_v;
                }


                int
                f_1012_1768_1781(dynamic
                this_param)
                {
                    var return_v = this_param.Height;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 1768, 1781);
                    return return_v;
                }


                int
                f_1012_1867_1879(dynamic
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 1867, 1879);
                    return return_v;
                }


                int
                f_1012_1966_1979(dynamic
                this_param)
                {
                    var return_v = this_param.Height;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 1966, 1979);
                    return return_v;
                }


                int
                f_1012_2051_2063(dynamic
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 2051, 2063);
                    return return_v;
                }


                char
                f_1012_2126_2145(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 2126, 2145);
                    return return_v;
                }


                char
                f_1012_2149_2167(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 2149, 2167);
                    return return_v;
                }


                int
                f_1012_2449_2481(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1012, 2449, 2481);
                    return return_v;
                }


                int
                f_1012_2429_2482(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1012, 2429, 2482);
                    return return_v;
                }


                char
                f_1012_2538_2557(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 2538, 2557);
                    return return_v;
                }


                char
                f_1012_2561_2579(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 2561, 2579);
                    return return_v;
                }


                char
                f_1012_2583_2602(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 2583, 2602);
                    return return_v;
                }


                char
                f_1012_2606_2624(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 2606, 2624);
                    return return_v;
                }


                int
                f_1012_2685_2741(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1012, 2685, 2741);
                    return return_v;
                }


                int
                f_1012_2886_2899(dynamic
                this_param)
                {
                    var return_v = this_param.Height;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 2886, 2899);
                    return return_v;
                }


                int
                f_1012_2905_2917(dynamic
                this_param)
                {
                    var return_v = this_param.Width;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1012, 2905, 2917);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1012, 1334, 2934);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1012, 1334, 2934);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static FuzzyMatcher()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1012, 193, 2941);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1012, 261, 280);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1012, 193, 2941);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1012, 193, 2941);
        }

    }
}
