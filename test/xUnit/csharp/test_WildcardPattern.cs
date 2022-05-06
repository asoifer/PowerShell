// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Management.Automation;
using Xunit;

namespace PSTests.Parallel
{
    public class WildcardPatternTests
    {
        [Fact]
        public void TestEscape_Null()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(966, 253, 452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 323, 441);

                f_966_323_440(delegate
                { WildcardPattern.Escape(null); });
                DynAbs.Tracing.TraceSender.TraceExitMethod(966, 253, 452);

                System.Management.Automation.PSArgumentNullException
                f_966_323_440(System.Action
                testCode)
                {
                    var return_v = CustomAssert.Throws<System.Management.Automation.PSArgumentNullException>(testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 323, 440);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(966, 253, 452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 253, 452);
            }
        }

        [Fact]
        public void TestEscape_Empty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(966, 464, 617);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 535, 606);

                f_966_535_605(f_966_554_590(string.Empty), string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(966, 464, 617);

                string
                f_966_554_590(string
                pattern)
                {
                    var return_v = WildcardPattern.Escape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 554, 590);
                    return return_v;
                }


                bool
                f_966_535_605(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 535, 605);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(966, 464, 617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 464, 617);
            }
        }

        [Fact]
        public void TestEscape_String_A()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(966, 706, 922);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 780, 800);

                string
                source = "a"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 814, 836);

                string
                expected = "a"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 850, 911);

                f_966_850_910(f_966_869_899(source), expected);
                DynAbs.Tracing.TraceSender.TraceExitMethod(966, 706, 922);

                string
                f_966_869_899(string
                pattern)
                {
                    var return_v = WildcardPattern.Escape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 869, 899);
                    return return_v;
                }


                bool
                f_966_850_910(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 850, 910);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(966, 706, 922);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 706, 922);
            }
        }

        [Fact]
        public void TestEscape_String_B()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(966, 934, 1153);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 1008, 1029);

                string
                source = "a*"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 1043, 1067);

                string
                expected = "a`*"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 1081, 1142);

                f_966_1081_1141(f_966_1100_1130(source), expected);
                DynAbs.Tracing.TraceSender.TraceExitMethod(966, 934, 1153);

                string
                f_966_1100_1130(string
                pattern)
                {
                    var return_v = WildcardPattern.Escape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 1100, 1130);
                    return return_v;
                }


                bool
                f_966_1081_1141(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 1081, 1141);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(966, 934, 1153);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 934, 1153);
            }
        }

        [Fact]
        public void TestEscape_String_C()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(966, 1165, 1391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 1239, 1262);

                string
                source = "*?[]"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 1276, 1305);

                string
                expected = "`*`?`[`]"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 1319, 1380);

                f_966_1319_1379(f_966_1338_1368(source), expected);
                DynAbs.Tracing.TraceSender.TraceExitMethod(966, 1165, 1391);

                string
                f_966_1338_1368(string
                pattern)
                {
                    var return_v = WildcardPattern.Escape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 1338, 1368);
                    return return_v;
                }


                bool
                f_966_1319_1379(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 1319, 1379);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(966, 1165, 1391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 1165, 1391);
            }
        }

        [Fact]
        public void TestEscape_String_NotEscape_A()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(966, 1403, 1659);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 1487, 1507);

                string
                source = "a"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 1521, 1543);

                string
                expected = "a"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 1557, 1648);

                f_966_1557_1647(f_966_1576_1636(source, new[] { '*', '?', '[', ']' }), expected);
                DynAbs.Tracing.TraceSender.TraceExitMethod(966, 1403, 1659);

                string
                f_966_1576_1636(string
                pattern, char[]
                charsNotToEscape)
                {
                    var return_v = WildcardPattern.Escape(pattern, charsNotToEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 1576, 1636);
                    return return_v;
                }


                bool
                f_966_1557_1647(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 1557, 1647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(966, 1403, 1659);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 1403, 1659);
            }
        }

        [Fact]
        public void TestEscape_String_NotEscape_B()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(966, 1671, 1929);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 1755, 1776);

                string
                source = "a*"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 1790, 1813);

                string
                expected = "a*"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 1827, 1918);

                f_966_1827_1917(f_966_1846_1906(source, new[] { '*', '?', '[', ']' }), expected);
                DynAbs.Tracing.TraceSender.TraceExitMethod(966, 1671, 1929);

                string
                f_966_1846_1906(string
                pattern, char[]
                charsNotToEscape)
                {
                    var return_v = WildcardPattern.Escape(pattern, charsNotToEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 1846, 1906);
                    return return_v;
                }


                bool
                f_966_1827_1917(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 1827, 1917);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(966, 1671, 1929);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 1671, 1929);
            }
        }

        [Fact]
        public void TestEscape_String_NotEscape_C()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(966, 1941, 2203);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 2025, 2048);

                string
                source = "*?[]"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 2062, 2087);

                string
                expected = "*?[]"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 2101, 2192);

                f_966_2101_2191(f_966_2120_2180(source, new[] { '*', '?', '[', ']' }), expected);
                DynAbs.Tracing.TraceSender.TraceExitMethod(966, 1941, 2203);

                string
                f_966_2120_2180(string
                pattern, char[]
                charsNotToEscape)
                {
                    var return_v = WildcardPattern.Escape(pattern, charsNotToEscape);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 2120, 2180);
                    return return_v;
                }


                bool
                f_966_2101_2191(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 2101, 2191);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(966, 1941, 2203);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 1941, 2203);
            }
        }

        [Fact]
        public void TestUnescape_Null()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(966, 2215, 2418);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 2287, 2407);

                f_966_2287_2406(delegate
                { WildcardPattern.Unescape(null); });
                DynAbs.Tracing.TraceSender.TraceExitMethod(966, 2215, 2418);

                System.Management.Automation.PSArgumentNullException
                f_966_2287_2406(System.Action
                testCode)
                {
                    var return_v = CustomAssert.Throws<System.Management.Automation.PSArgumentNullException>(testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 2287, 2406);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(966, 2215, 2418);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 2215, 2418);
            }
        }

        [Fact]
        public void TestUnescape_Empty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(966, 2430, 2587);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 2503, 2576);

                f_966_2503_2575(f_966_2522_2560(string.Empty), string.Empty);
                DynAbs.Tracing.TraceSender.TraceExitMethod(966, 2430, 2587);

                string
                f_966_2522_2560(string
                pattern)
                {
                    var return_v = WildcardPattern.Unescape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 2522, 2560);
                    return return_v;
                }


                bool
                f_966_2503_2575(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 2503, 2575);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(966, 2430, 2587);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 2430, 2587);
            }
        }

        [Fact]
        public void TestUnescape_String_A()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(966, 2599, 2819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 2675, 2695);

                string
                source = "a"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 2709, 2731);

                string
                expected = "a"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 2745, 2808);

                f_966_2745_2807(f_966_2764_2796(source), expected);
                DynAbs.Tracing.TraceSender.TraceExitMethod(966, 2599, 2819);

                string
                f_966_2764_2796(string
                pattern)
                {
                    var return_v = WildcardPattern.Unescape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 2764, 2796);
                    return return_v;
                }


                bool
                f_966_2745_2807(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 2745, 2807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(966, 2599, 2819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 2599, 2819);
            }
        }

        [Fact]
        public void TestUnescape_String_B()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(966, 2831, 3054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 2907, 2929);

                string
                source = "a`*"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 2943, 2966);

                string
                expected = "a*"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 2980, 3043);

                f_966_2980_3042(f_966_2999_3031(source), expected);
                DynAbs.Tracing.TraceSender.TraceExitMethod(966, 2831, 3054);

                string
                f_966_2999_3031(string
                pattern)
                {
                    var return_v = WildcardPattern.Unescape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 2999, 3031);
                    return return_v;
                }


                bool
                f_966_2980_3042(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 2980, 3042);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(966, 2831, 3054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 2831, 3054);
            }
        }

        [Fact]
        public void TestUnescape_String_C()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(966, 3066, 3296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 3142, 3169);

                string
                source = "`*`?`[`]"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 3183, 3208);

                string
                expected = "*?[]"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(966, 3222, 3285);

                f_966_3222_3284(f_966_3241_3273(source), expected);
                DynAbs.Tracing.TraceSender.TraceExitMethod(966, 3066, 3296);

                string
                f_966_3241_3273(string
                pattern)
                {
                    var return_v = WildcardPattern.Unescape(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 3241, 3273);
                    return return_v;
                }


                bool
                f_966_3222_3284(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(966, 3222, 3284);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(966, 3066, 3296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 3066, 3296);
            }
        }

        public WildcardPatternTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(966, 203, 3303);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(966, 203, 3303);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 203, 3303);
        }


        static WildcardPatternTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(966, 203, 3303);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(966, 203, 3303);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(966, 203, 3303);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(966, 203, 3303);
    }
}
