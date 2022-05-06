// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Specialized;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Threading;
using System.Reflection;
using Microsoft.PowerShell.Commands;
using Xunit;

namespace PSTests.Parallel
{
    public static class UtilsTests
    {
        [SkippableFact]
        public static void TestIsWinPEHost()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(965, 451, 633);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 537, 568);

                f_965_537_567(f_965_548_566());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 582, 622);

                f_965_582_621(f_965_601_620());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(965, 451, 633);

                bool
                f_965_548_566()
                {
                    var return_v = Platform.IsWindows;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(965, 548, 566);
                    return return_v;
                }


                int
                f_965_537_567(bool
                condition)
                {
                    Skip.IfNot(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 537, 567);
                    return 0;
                }


                bool
                f_965_601_620()
                {
                    var return_v = Utils.IsWinPEHost();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 601, 620);
                    return return_v;
                }


                bool
                f_965_582_621(bool
                condition)
                {
                    var return_v = CustomAssert.False(condition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 582, 621);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(965, 451, 633);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(965, 451, 633);
            }
        }

        [Fact]
        public static void TestHistoryStack()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(965, 645, 2261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 723, 771);

                var
                historyStack = f_965_742_770(20)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 785, 831);

                f_965_785_830(0, f_965_807_829(historyStack));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 845, 891);

                f_965_845_890(0, f_965_867_889(historyStack));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 907, 939);

                f_965_907_938(
                            historyStack, "first item");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 953, 986);

                f_965_953_985(historyStack, "second item");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 1000, 1046);

                f_965_1000_1045(2, f_965_1022_1044(historyStack));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 1060, 1106);

                f_965_1060_1105(0, f_965_1082_1104(historyStack));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 1122, 1190);

                f_965_1122_1189("second item", f_965_1156_1188(historyStack, "second item"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 1204, 1270);

                f_965_1204_1269("first item", f_965_1237_1268(historyStack, "first item"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 1284, 1330);

                f_965_1284_1329(0, f_965_1306_1328(historyStack));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 1344, 1390);

                f_965_1344_1389(2, f_965_1366_1388(historyStack));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 1406, 1472);

                f_965_1406_1471("first item", f_965_1439_1470(historyStack, "first item"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 1486, 1532);

                f_965_1486_1531(1, f_965_1508_1530(historyStack));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 1546, 1592);

                f_965_1546_1591(1, f_965_1568_1590(historyStack));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 1675, 1707);

                f_965_1675_1706(
                            // Pushing a new item should invalidate the RedoCount
                            historyStack, "third item");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 1721, 1767);

                f_965_1721_1766(2, f_965_1743_1765(historyStack));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 1781, 1827);

                f_965_1781_1826(0, f_965_1803_1825(historyStack));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 1926, 2005);

                f_965_1926_2004(() => historyStack.Redo("bar"));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2019, 2051);

                f_965_2019_2050(historyStack, "third item");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2065, 2097);

                f_965_2065_2096(historyStack, "first item");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2111, 2157);

                f_965_2111_2156(0, f_965_2133_2155(historyStack));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2171, 2250);

                f_965_2171_2249(() => historyStack.Undo("foo"));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(965, 645, 2261);

                System.Management.Automation.Internal.HistoryStack<string>
                f_965_742_770(int
                capacity)
                {
                    var return_v = new System.Management.Automation.Internal.HistoryStack<string>((uint)capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 742, 770);
                    return return_v;
                }


                int
                f_965_807_829(System.Management.Automation.Internal.HistoryStack<string>
                this_param)
                {
                    var return_v = this_param.UndoCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(965, 807, 829);
                    return return_v;
                }


                bool
                f_965_785_830(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 785, 830);
                    return return_v;
                }


                int
                f_965_867_889(System.Management.Automation.Internal.HistoryStack<string>
                this_param)
                {
                    var return_v = this_param.RedoCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(965, 867, 889);
                    return return_v;
                }


                bool
                f_965_845_890(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 845, 890);
                    return return_v;
                }


                int
                f_965_907_938(System.Management.Automation.Internal.HistoryStack<string>
                this_param, string
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 907, 938);
                    return 0;
                }


                int
                f_965_953_985(System.Management.Automation.Internal.HistoryStack<string>
                this_param, string
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 953, 985);
                    return 0;
                }


                int
                f_965_1022_1044(System.Management.Automation.Internal.HistoryStack<string>
                this_param)
                {
                    var return_v = this_param.UndoCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(965, 1022, 1044);
                    return return_v;
                }


                bool
                f_965_1000_1045(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1000, 1045);
                    return return_v;
                }


                int
                f_965_1082_1104(System.Management.Automation.Internal.HistoryStack<string>
                this_param)
                {
                    var return_v = this_param.RedoCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(965, 1082, 1104);
                    return return_v;
                }


                bool
                f_965_1060_1105(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1060, 1105);
                    return return_v;
                }


                string
                f_965_1156_1188(System.Management.Automation.Internal.HistoryStack<string>
                this_param, string
                currentItem)
                {
                    var return_v = this_param.Undo(currentItem);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1156, 1188);
                    return return_v;
                }


                bool
                f_965_1122_1189(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1122, 1189);
                    return return_v;
                }


                string
                f_965_1237_1268(System.Management.Automation.Internal.HistoryStack<string>
                this_param, string
                currentItem)
                {
                    var return_v = this_param.Undo(currentItem);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1237, 1268);
                    return return_v;
                }


                bool
                f_965_1204_1269(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1204, 1269);
                    return return_v;
                }


                int
                f_965_1306_1328(System.Management.Automation.Internal.HistoryStack<string>
                this_param)
                {
                    var return_v = this_param.UndoCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(965, 1306, 1328);
                    return return_v;
                }


                bool
                f_965_1284_1329(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1284, 1329);
                    return return_v;
                }


                int
                f_965_1366_1388(System.Management.Automation.Internal.HistoryStack<string>
                this_param)
                {
                    var return_v = this_param.RedoCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(965, 1366, 1388);
                    return return_v;
                }


                bool
                f_965_1344_1389(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1344, 1389);
                    return return_v;
                }


                string
                f_965_1439_1470(System.Management.Automation.Internal.HistoryStack<string>
                this_param, string
                currentItem)
                {
                    var return_v = this_param.Redo(currentItem);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1439, 1470);
                    return return_v;
                }


                bool
                f_965_1406_1471(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1406, 1471);
                    return return_v;
                }


                int
                f_965_1508_1530(System.Management.Automation.Internal.HistoryStack<string>
                this_param)
                {
                    var return_v = this_param.UndoCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(965, 1508, 1530);
                    return return_v;
                }


                bool
                f_965_1486_1531(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1486, 1531);
                    return return_v;
                }


                int
                f_965_1568_1590(System.Management.Automation.Internal.HistoryStack<string>
                this_param)
                {
                    var return_v = this_param.RedoCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(965, 1568, 1590);
                    return return_v;
                }


                bool
                f_965_1546_1591(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1546, 1591);
                    return return_v;
                }


                int
                f_965_1675_1706(System.Management.Automation.Internal.HistoryStack<string>
                this_param, string
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1675, 1706);
                    return 0;
                }


                int
                f_965_1743_1765(System.Management.Automation.Internal.HistoryStack<string>
                this_param)
                {
                    var return_v = this_param.UndoCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(965, 1743, 1765);
                    return return_v;
                }


                bool
                f_965_1721_1766(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1721, 1766);
                    return return_v;
                }


                int
                f_965_1803_1825(System.Management.Automation.Internal.HistoryStack<string>
                this_param)
                {
                    var return_v = this_param.RedoCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(965, 1803, 1825);
                    return return_v;
                }


                bool
                f_965_1781_1826(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1781, 1826);
                    return return_v;
                }


                System.InvalidOperationException
                f_965_1926_2004(System.Func<object>
                testCode)
                {
                    var return_v = CustomAssert.Throws<InvalidOperationException>(testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 1926, 2004);
                    return return_v;
                }


                string
                f_965_2019_2050(System.Management.Automation.Internal.HistoryStack<string>
                this_param, string
                currentItem)
                {
                    var return_v = this_param.Undo(currentItem);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 2019, 2050);
                    return return_v;
                }


                string
                f_965_2065_2096(System.Management.Automation.Internal.HistoryStack<string>
                this_param, string
                currentItem)
                {
                    var return_v = this_param.Undo(currentItem);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 2065, 2096);
                    return return_v;
                }


                int
                f_965_2133_2155(System.Management.Automation.Internal.HistoryStack<string>
                this_param)
                {
                    var return_v = this_param.UndoCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(965, 2133, 2155);
                    return return_v;
                }


                bool
                f_965_2111_2156(int
                expected, int
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 2111, 2156);
                    return return_v;
                }


                System.InvalidOperationException
                f_965_2171_2249(System.Func<object>
                testCode)
                {
                    var return_v = CustomAssert.Throws<InvalidOperationException>(testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 2171, 2249);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(965, 645, 2261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(965, 645, 2261);
            }
        }

        [Fact]
        public static void TestBoundedStack()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(965, 2273, 2949);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2351, 2370);

                uint
                capacity = 20
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2384, 2438);

                var
                boundedStack = f_965_2403_2437(capacity)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2452, 2525);

                f_965_2452_2524(() => boundedStack.Pop());
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2550, 2555);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2541, 2649) || true) && (i < capacity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2571, 2574)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(965, 2541, 2649))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(965, 2541, 2649);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2608, 2634);

                        f_965_2608_2633(boundedStack, $"{i}");
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(965, 1, 109);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(965, 1, 109);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2674, 2679);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2665, 2849) || true) && (i < capacity)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2695, 2698)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(965, 2665, 2849))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(965, 2665, 2849);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2732, 2768);

                        var
                        poppedItem = f_965_2749_2767(boundedStack)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2786, 2834);

                        f_965_2786_2833($"{20 - 1 - i}", poppedItem);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(965, 1, 185);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(965, 1, 185);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 2865, 2938);

                f_965_2865_2937(() => boundedStack.Pop());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(965, 2273, 2949);

                System.Management.Automation.Internal.BoundedStack<string>
                f_965_2403_2437(uint
                capacity)
                {
                    var return_v = new System.Management.Automation.Internal.BoundedStack<string>(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 2403, 2437);
                    return return_v;
                }


                System.InvalidOperationException
                f_965_2452_2524(System.Func<object>
                testCode)
                {
                    var return_v = CustomAssert.Throws<InvalidOperationException>(testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 2452, 2524);
                    return return_v;
                }


                int
                f_965_2608_2633(System.Management.Automation.Internal.BoundedStack<string>
                this_param, string
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 2608, 2633);
                    return 0;
                }


                string
                f_965_2749_2767(System.Management.Automation.Internal.BoundedStack<string>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 2749, 2767);
                    return return_v;
                }


                bool
                f_965_2786_2833(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 2786, 2833);
                    return return_v;
                }


                System.InvalidOperationException
                f_965_2865_2937(System.Func<object>
                testCode)
                {
                    var return_v = CustomAssert.Throws<InvalidOperationException>(testCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 2865, 2937);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(965, 2273, 2949);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(965, 2273, 2949);
            }
        }

        [Fact]
        public static void TestConvertToJsonBasic()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(965, 2961, 3822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 3045, 3153);

                var
                context = f_965_3059_3152(maxDepth: 1, enumsAsStrings: false, compressOutput: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 3167, 3224);

                string
                expected = "{\"name\":\"req\",\"type\":\"http\"}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 3238, 3370);

                OrderedDictionary
                hash = new OrderedDictionary {
                {DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "name",965,3263,3369),"req"},                {"type", "http"}
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 3384, 3441);

                string
                json = f_965_3398_3440(hash, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 3455, 3490);

                f_965_3455_3489(expected, json);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 3506, 3529);

                f_965_3506_3528(
                            hash, "self", hash);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 3543, 3590);

                json = f_965_3550_3589(hash, context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 3604, 3762);

                expected = "{\"name\":\"req\",\"type\":\"http\",\"self\":{\"name\":\"req\",\"type\":\"http\",\"self\":\"System.Collections.Specialized.OrderedDictionary\"}}";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 3776, 3811);

                f_965_3776_3810(expected, json);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(965, 2961, 3822);

                Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext
                f_965_3059_3152(int
                maxDepth, bool
                enumsAsStrings, bool
                compressOutput)
                {
                    var return_v = new Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext(maxDepth: maxDepth, enumsAsStrings: enumsAsStrings, compressOutput: compressOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 3059, 3152);
                    return return_v;
                }


                string
                f_965_3398_3440(System.Collections.Specialized.OrderedDictionary
                objectToProcess, Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext
                context)
                {
                    var return_v = JsonObject.ConvertToJson((object)objectToProcess, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 3398, 3440);
                    return return_v;
                }


                bool
                f_965_3455_3489(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 3455, 3489);
                    return return_v;
                }


                int
                f_965_3506_3528(System.Collections.Specialized.OrderedDictionary
                this_param, string
                key, System.Collections.Specialized.OrderedDictionary
                value)
                {
                    this_param.Add((object)key, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 3506, 3528);
                    return 0;
                }


                string
                f_965_3550_3589(System.Collections.Specialized.OrderedDictionary
                objectToProcess, Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext
                context)
                {
                    var return_v = JsonObject.ConvertToJson((object)objectToProcess, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 3550, 3589);
                    return return_v;
                }


                bool
                f_965_3776_3810(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 3776, 3810);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(965, 2961, 3822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(965, 2961, 3822);
            }
        }

        [Fact]
        public static void TestConvertToJsonWithEnum()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(965, 3834, 4595);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 3921, 4029);

                var
                context = f_965_3935_4028(maxDepth: 1, enumsAsStrings: false, compressOutput: true)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 4043, 4076);

                string
                expected = "{\"type\":1}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 4090, 4184);

                Hashtable
                hash = new Hashtable {
                {DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "type",965,4107,4183),CommandTypes.Alias}
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 4198, 4255);

                string
                json = f_965_4212_4254(hash, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 4269, 4304);

                f_965_4269_4303(expected, json);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 4320, 4423);

                context = f_965_4330_4422(maxDepth: 1, enumsAsStrings: true, compressOutput: true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 4437, 4487);

                json = f_965_4444_4486(hash, context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 4501, 4535);

                expected = "{\"type\":\"Alias\"}";
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 4549, 4584);

                f_965_4549_4583(expected, json);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(965, 3834, 4595);

                Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext
                f_965_3935_4028(int
                maxDepth, bool
                enumsAsStrings, bool
                compressOutput)
                {
                    var return_v = new Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext(maxDepth: maxDepth, enumsAsStrings: enumsAsStrings, compressOutput: compressOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 3935, 4028);
                    return return_v;
                }


                string
                f_965_4212_4254(System.Collections.Hashtable
                objectToProcess, Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext
                context)
                {
                    var return_v = JsonObject.ConvertToJson((object)objectToProcess, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 4212, 4254);
                    return return_v;
                }


                bool
                f_965_4269_4303(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 4269, 4303);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext
                f_965_4330_4422(int
                maxDepth, bool
                enumsAsStrings, bool
                compressOutput)
                {
                    var return_v = new Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext(maxDepth: maxDepth, enumsAsStrings: enumsAsStrings, compressOutput: compressOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 4330, 4422);
                    return return_v;
                }


                string
                f_965_4444_4486(System.Collections.Hashtable
                objectToProcess, Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext
                context)
                {
                    var return_v = JsonObject.ConvertToJson((object)objectToProcess, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 4444, 4486);
                    return return_v;
                }


                bool
                f_965_4549_4583(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 4549, 4583);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(965, 3834, 4595);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(965, 3834, 4595);
            }
        }

        [Fact]
        public static void TestConvertToJsonWithoutCompress()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(965, 4607, 5111);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 4701, 4809);

                var
                context = f_965_4715_4808(maxDepth: 1, enumsAsStrings: true, compressOutput: false)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 4823, 4872);

                string
                expected = @"{
  ""type"": ""Alias""
}"
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 4886, 4980);

                Hashtable
                hash = new Hashtable {
                {DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "type",965,4903,4979),CommandTypes.Alias}
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 4994, 5051);

                string
                json = f_965_5008_5050(hash, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 5065, 5100);

                f_965_5065_5099(expected, json);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(965, 4607, 5111);

                Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext
                f_965_4715_4808(int
                maxDepth, bool
                enumsAsStrings, bool
                compressOutput)
                {
                    var return_v = new Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext(maxDepth: maxDepth, enumsAsStrings: enumsAsStrings, compressOutput: compressOutput);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 4715, 4808);
                    return return_v;
                }


                string
                f_965_5008_5050(System.Collections.Hashtable
                objectToProcess, Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext
                context)
                {
                    var return_v = JsonObject.ConvertToJson((object)objectToProcess, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 5008, 5050);
                    return return_v;
                }


                bool
                f_965_5065_5099(string
                expected, string
                actual)
                {
                    var return_v = CustomAssert.Equal(expected, actual);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 5065, 5099);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(965, 4607, 5111);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(965, 4607, 5111);
            }
        }

        [Fact]
        public static void TestConvertToJsonCancellation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(965, 5123, 5824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 5214, 5257);

                var
                source = f_965_5227_5256()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 5271, 5562);

                var
                context = f_965_5285_5561(maxDepth: 1, enumsAsStrings: true, compressOutput: false, f_965_5448_5460(source), Newtonsoft.Json.StringEscapeHandling.Default, targetCmdlet: null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 5578, 5594);

                f_965_5578_5593(
                            source);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 5608, 5702);

                Hashtable
                hash = new Hashtable {
                {DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "type",965,5625,5701),CommandTypes.Alias}
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 5718, 5775);

                string
                json = f_965_5732_5774(hash, context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(965, 5789, 5813);

                f_965_5789_5812(json);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(965, 5123, 5824);

                System.Threading.CancellationTokenSource
                f_965_5227_5256()
                {
                    var return_v = new System.Threading.CancellationTokenSource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 5227, 5256);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_965_5448_5460(System.Threading.CancellationTokenSource
                this_param)
                {
                    var return_v = this_param.Token;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(965, 5448, 5460);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext
                f_965_5285_5561(int
                maxDepth, bool
                enumsAsStrings, bool
                compressOutput, System.Threading.CancellationToken
                cancellationToken, Newtonsoft.Json.StringEscapeHandling
                stringEscapeHandling, System.Management.Automation.PSCmdlet
                targetCmdlet)
                {
                    var return_v = new Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext(maxDepth: maxDepth, enumsAsStrings: enumsAsStrings, compressOutput: compressOutput, cancellationToken, stringEscapeHandling, targetCmdlet: targetCmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 5285, 5561);
                    return return_v;
                }


                int
                f_965_5578_5593(System.Threading.CancellationTokenSource
                this_param)
                {
                    this_param.Cancel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 5578, 5593);
                    return 0;
                }


                string
                f_965_5732_5774(System.Collections.Hashtable
                objectToProcess, Microsoft.PowerShell.Commands.JsonObject.ConvertToJsonContext
                context)
                {
                    var return_v = JsonObject.ConvertToJson((object)objectToProcess, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 5732, 5774);
                    return return_v;
                }


                bool
                f_965_5789_5812(string
                @object)
                {
                    var return_v = CustomAssert.Null((object)@object);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(965, 5789, 5812);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(965, 5123, 5824);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(965, 5123, 5824);
            }
        }

        static UtilsTests()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(965, 404, 5831);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(965, 404, 5831);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(965, 404, 5831);
        }

    }
}
