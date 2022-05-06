// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Management.Automation.Internal;
using System.Text;

using Microsoft.PowerShell.Commands.Internal.Format;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal class TableWriter
    {
        private class ColumnInfo
        {
            internal int startCol;

            internal int width;

            internal int alignment;

            public ColumnInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1101, 522, 703);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 584, 596);
                this.startCol = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 624, 633);
                this.width = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 661, 691);
                this.alignment = TextAlignment.Left;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1101, 522, 703);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1101, 522, 703);
            }


            static ColumnInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1101, 522, 703);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1101, 522, 703);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1101, 522, 703);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1101, 522, 703);
        }
        private class ScreenInfo
        {
            internal int screenColumns;

            internal int screenRows;

            internal const int
            separatorCharacterCount = 1
            ;

            internal const int
            minimumScreenColumns = 5
            ;

            internal const int
            minimumColumnWidth = 1
            ;

            internal ColumnInfo[] columnInfo;

            public ScreenInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1101, 828, 1198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 890, 907);
                this.screenColumns = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 935, 949);
                this.screenRows = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 1169, 1186);
                this.columnInfo = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1101, 828, 1198);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1101, 828, 1198);
            }


            static ScreenInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1101, 828, 1198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 985, 1012);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 1048, 1072);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 1108, 1130);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1101, 828, 1198);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1101, 828, 1198);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1101, 828, 1198);
        }

        private ScreenInfo _si;

        private const char
        ESC = '\u001b'
        ;

        private const string
        ResetConsoleVt100Code = "\u001b[m"
        ;

        private List<string> _header;

        internal static int ComputeWideViewBestItemsPerRowFit(int stringLen, int screenColumns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1101, 1394, 2496);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 1506, 1573) || true) && (stringLen <= 0 || (DynAbs.Tracing.TraceSender.Expression_False(1101, 1510, 1545) || screenColumns < 1))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 1506, 1573);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 1564, 1573);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 1506, 1573);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 1589, 1765) || true) && (stringLen >= screenColumns)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 1589, 1765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 1741, 1750);

                    return 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 1589, 1765);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 1871, 1892);

                int
                columnNumber = 1
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 1906, 2485) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 1906, 2485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 2006, 2039);

                        int
                        nextValue = columnNumber + 1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 2124, 2213);

                        int
                        width = stringLen * nextValue + (nextValue - 1) * ScreenInfo.separatorCharacterCount
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 2233, 2397) || true) && (width >= screenColumns)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 2233, 2397);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 2358, 2378);

                            return columnNumber;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 2233, 2397);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 2455, 2470);

                        columnNumber++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 1906, 2485);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1906, 2485);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1906, 2485);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1101, 1394, 2496);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1101, 1394, 2496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1101, 1394, 2496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void Initialize(int leftMarginIndent, int screenColumns, Span<int> columnWidths, ReadOnlySpan<int> alignment, bool suppressHeader, int screenRows = int.MaxValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1101, 3109, 5228);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 3304, 3398) || true) && (leftMarginIndent < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 3304, 3398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 3362, 3383);

                    leftMarginIndent = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 3304, 3398);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 3414, 3575) || true) && (screenColumns - leftMarginIndent < ScreenInfo.minimumScreenColumns)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 3414, 3575);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 3518, 3535);

                    _disabled = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 3553, 3560);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 3414, 3575);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 3591, 3623);

                _startColumn = leftMarginIndent;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 3637, 3666);

                _hideHeader = suppressHeader;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 3771, 3976);

                ColumnWidthManager
                manager = f_1101_3800_3975(screenColumns - leftMarginIndent, ScreenInfo.minimumColumnWidth, ScreenInfo.separatorCharacterCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 3992, 4036);

                f_1101_3992_4035(
                            manager, columnWidths);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4112, 4134);

                bool
                oneValid = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4159, 4164);

                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4150, 4400) || true) && (k < columnWidths.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4191, 4194)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 4150, 4400))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 4150, 4400);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4228, 4385) || true) && (columnWidths[k] >= ScreenInfo.minimumColumnWidth)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 4228, 4385);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4322, 4338);

                            oneValid = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1101, 4360, 4366);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 4228, 4385);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 251);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 251);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4416, 4520) || true) && (!oneValid)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 4416, 4520);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4463, 4480);

                    _disabled = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4498, 4505);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 4416, 4520);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4589, 4612);

                _si = f_1101_4595_4611();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4626, 4660);

                _si.screenColumns = screenColumns;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4674, 4702);

                _si.screenRows = screenRows;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4716, 4769);

                _si.columnInfo = new ColumnInfo[columnWidths.Length];
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4785, 4813);

                int
                startCol = _startColumn
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4836, 4841);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4827, 5217) || true) && (k < columnWidths.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4868, 4871)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 4827, 5217))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 4827, 5217);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4905, 4942);

                        _si.columnInfo[k] = f_1101_4925_4941();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 4960, 4998);

                        _si.columnInfo[k].startCol = startCol;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 5016, 5058);

                        _si.columnInfo[k].width = columnWidths[k];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 5076, 5119);

                        _si.columnInfo[k].alignment = alignment[k];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 5137, 5202);

                        startCol += columnWidths[k] + ScreenInfo.separatorCharacterCount;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 391);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1101, 3109, 5228);

                Microsoft.PowerShell.Commands.Internal.Format.ColumnWidthManager
                f_1101_3800_3975(int
                tableWidth, int
                minimumColumnWidth, int
                separatorWidth)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ColumnWidthManager(tableWidth, minimumColumnWidth, separatorWidth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 3800, 3975);
                    return return_v;
                }


                int
                f_1101_3992_4035(Microsoft.PowerShell.Commands.Internal.Format.ColumnWidthManager
                this_param, System.Span<int>
                columnWidths)
                {
                    this_param.CalculateColumnWidths(columnWidths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 3992, 4035);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableWriter.ScreenInfo
                f_1101_4595_4611()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableWriter.ScreenInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 4595, 4611);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableWriter.ColumnInfo
                f_1101_4925_4941()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableWriter.ColumnInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 4925, 4941);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1101, 3109, 5228);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1101, 3109, 5228);
            }
        }

        internal int GenerateHeader(string[] values, LineOutput lo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1101, 5240, 7089);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 5324, 5649) || true) && (_disabled || (DynAbs.Tracing.TraceSender.Expression_False(1101, 5328, 5352) || _hideHeader))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 5324, 5649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 5386, 5395);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 5324, 5649);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 5324, 5649);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 5429, 5649) || true) && (_header != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 5429, 5649);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 5482, 5593);
                            foreach (string line in f_1101_5506_5513_I(_header))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 5482, 5593);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 5555, 5574);

                                f_1101_5555_5573(lo, line);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 5482, 5593);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 112);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 112);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 5613, 5634);

                        return f_1101_5620_5633(_header);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 5429, 5649);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 5324, 5649);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 5665, 5694);

                _header = f_1101_5675_5693();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 5766, 5828);

                f_1101_5766_5827(this, values, lo, true, null, f_1101_5802_5817(lo), _header);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 5951, 5998);

                string[]
                breakLine = new string[f_1101_5983_5996(values)]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 6021, 6026);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 6012, 6961) || true) && (k < f_1101_6032_6048(breakLine))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 6050, 6053)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 6012, 6961))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 6012, 6961);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 6132, 6284) || true) && (_si.columnInfo[k].width <= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 6132, 6284);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 6206, 6234);

                            breakLine[k] = string.Empty;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 6256, 6265);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 6132, 6284);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 6361, 6397);

                        int
                        count = _si.columnInfo[k].width
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 6415, 6674) || true) && (!f_1101_6420_6451(values[k]))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 6415, 6674);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 6493, 6551);

                            int
                            labelDisplayCells = f_1101_6517_6550(f_1101_6517_6532(lo), values[k])
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 6573, 6655) || true) && (labelDisplayCells < count)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 6573, 6655);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 6629, 6655);

                                count = labelDisplayCells;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 6573, 6655);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 6415, 6674);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 6901, 6946);

                        breakLine[k] = f_1101_6916_6945(count);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 950);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 950);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 6977, 7043);

                f_1101_6977_7042(this, breakLine, lo, false, null, f_1101_7017_7032(lo), _header);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 7057, 7078);

                return f_1101_7064_7077(_header);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1101, 5240, 7089);

                int
                f_1101_5555_5573(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, string
                s)
                {
                    this_param.WriteLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 5555, 5573);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1101_5506_5513_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 5506, 5513);
                    return return_v;
                }


                int
                f_1101_5620_5633(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 5620, 5633);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1101_5675_5693()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 5675, 5693);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                f_1101_5802_5817(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.DisplayCells;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 5802, 5817);
                    return return_v;
                }


                int
                f_1101_5766_5827(Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                this_param, string[]
                values, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                lo, bool
                multiLine, int[]
                alignment, Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                dc, System.Collections.Generic.List<string>
                generatedRows)
                {
                    this_param.GenerateRow(values, lo, multiLine, (System.ReadOnlySpan<int>)alignment, dc, generatedRows);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 5766, 5827);
                    return 0;
                }


                int
                f_1101_5983_5996(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 5983, 5996);
                    return return_v;
                }


                int
                f_1101_6032_6048(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 6032, 6048);
                    return return_v;
                }


                bool
                f_1101_6420_6451(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 6420, 6451);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                f_1101_6517_6532(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.DisplayCells;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 6517, 6532);
                    return return_v;
                }


                int
                f_1101_6517_6550(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 6517, 6550);
                    return return_v;
                }


                string
                f_1101_6916_6945(int
                count)
                {
                    var return_v = StringUtil.DashPadding(count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 6916, 6945);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                f_1101_7017_7032(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.DisplayCells;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 7017, 7032);
                    return return_v;
                }


                int
                f_1101_6977_7042(Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                this_param, string[]
                values, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                lo, bool
                multiLine, int[]
                alignment, Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                dc, System.Collections.Generic.List<string>
                generatedRows)
                {
                    this_param.GenerateRow(values, lo, multiLine, (System.ReadOnlySpan<int>)alignment, dc, generatedRows);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 6977, 7042);
                    return 0;
                }


                int
                f_1101_7064_7077(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 7064, 7077);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1101, 5240, 7089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1101, 5240, 7089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void GenerateRow(string[] values, LineOutput lo, bool multiLine, ReadOnlySpan<int> alignment, DisplayCells dc, List<string> generatedRows)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1101, 7101, 8672);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 7273, 7312) || true) && (_disabled)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 7273, 7312);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 7305, 7312);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 7273, 7312);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 7385, 7418);

                int
                cols = f_1101_7396_7417(_si.columnInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 7432, 7544);

                Span<int>
                currentAlignment = (DynAbs.Tracing.TraceSender.Conditional_F1(1101, 7461, 7504) || ((cols <= OutCommandInner.StackAllocThreshold && DynAbs.Tracing.TraceSender.Conditional_F2(1101, 7507, 7527)) || DynAbs.Tracing.TraceSender.Conditional_F3(1101, 7530, 7543))) ? stackalloc int[cols] : new int[cols]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 7560, 8171) || true) && (alignment == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 7560, 8171);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 7624, 7629);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 7615, 7774) || true) && (i < currentAlignment.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 7660, 7663)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 7615, 7774))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 7615, 7774);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 7705, 7755);

                            currentAlignment[i] = _si.columnInfo[i].alignment;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 160);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 160);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 7560, 8171);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 7560, 8171);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 7849, 7854);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 7840, 8156) || true) && (i < currentAlignment.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 7885, 7888)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 7840, 8156))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 7840, 8156);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 7930, 8137) || true) && (alignment[i] == TextAlignment.Undefined)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 7930, 8137);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 8000, 8050);

                                currentAlignment[i] = _si.columnInfo[i].alignment;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 7930, 8137);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 7930, 8137);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 8102, 8137);

                                currentAlignment[i] = alignment[i];
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 7930, 8137);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 317);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 317);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 7560, 8171);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 8187, 8661) || true) && (multiLine)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 8187, 8661);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 8234, 8444);
                        foreach (string line in f_1101_8258_8317_I(f_1101_8258_8317(this, values, currentAlignment, f_1101_8301_8316(lo))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 8234, 8444);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 8359, 8384);

                            DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(generatedRows, 1101, 8359, 8383)?.Add(line), 1101, 8373, 8383);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 8406, 8425);

                            f_1101_8406_8424(lo, line);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 8234, 8444);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 211);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 211);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 8187, 8661);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 8187, 8661);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 8510, 8566);

                    string
                    line = f_1101_8524_8565(this, values, currentAlignment, dc)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 8584, 8609);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(generatedRows, 1101, 8584, 8608)?.Add(line), 1101, 8598, 8608);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 8627, 8646);

                    f_1101_8627_8645(lo, line);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 8187, 8661);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1101, 7101, 8672);

                int
                f_1101_7396_7417(Microsoft.PowerShell.Commands.Internal.Format.TableWriter.ColumnInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 7396, 7417);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                f_1101_8301_8316(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.DisplayCells;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 8301, 8316);
                    return return_v;
                }


                string[]
                f_1101_8258_8317(Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                this_param, string[]
                values, System.Span<int>
                alignment, Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                ds)
                {
                    var return_v = this_param.GenerateTableRow(values, (System.ReadOnlySpan<int>)alignment, ds);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 8258, 8317);
                    return return_v;
                }


                int
                f_1101_8406_8424(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, string
                s)
                {
                    this_param.WriteLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 8406, 8424);
                    return 0;
                }


                string[]
                f_1101_8258_8317_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 8258, 8317);
                    return return_v;
                }


                string
                f_1101_8524_8565(Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                this_param, string[]
                values, System.Span<int>
                alignment, Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                dc)
                {
                    var return_v = this_param.GenerateRow(values, (System.ReadOnlySpan<int>)alignment, dc);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 8524, 8565);
                    return return_v;
                }


                int
                f_1101_8627_8645(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, string
                s)
                {
                    this_param.WriteLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 8627, 8645);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1101, 7101, 8672);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1101, 7101, 8672);
            }
        }

        private string[] GenerateTableRow(string[] values, ReadOnlySpan<int> alignment, DisplayCells ds)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1101, 8684, 14661);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 8866, 9029);

                Span<int>
                validColumnArray = (DynAbs.Tracing.TraceSender.Conditional_F1(1101, 8895, 8955) || ((f_1101_8895_8916(_si.columnInfo) <= OutCommandInner.StackAllocThreshold && DynAbs.Tracing.TraceSender.Conditional_F2(1101, 8958, 8995)) || DynAbs.Tracing.TraceSender.Conditional_F3(1101, 8998, 9028))) ? stackalloc int[f_1101_8973_8994(_si.columnInfo)] : new int[f_1101_9006_9027(_si.columnInfo)]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9043, 9068);

                int
                validColumnCount = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9091, 9096);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9082, 9310) || true) && (k < f_1101_9102_9123(_si.columnInfo))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9125, 9128)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 9082, 9310))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 9082, 9310);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9162, 9295) || true) && (_si.columnInfo[k].width > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 9162, 9295);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9235, 9276);

                            validColumnArray[validColumnCount++] = k;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 9162, 9295);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 229);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9326, 9412) || true) && (validColumnCount == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 9326, 9412);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9385, 9397);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 9326, 9412);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9428, 9496);

                StringCollection[]
                scArray = new StringCollection[validColumnCount]
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9510, 9533);

                bool
                addPadding = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9556, 9561);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9547, 11021) || true) && (k < f_1101_9567_9581(scArray))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9583, 9586)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 9547, 11021))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 9547, 11021);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9695, 9802) || true) && (k == f_1101_9704_9718(scArray) - 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 9695, 9802);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9764, 9783);

                            addPadding = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 9695, 9802);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 9880, 10038);

                        scArray[k] = f_1101_9893_10037(this, values[validColumnArray[k]], validColumnArray[k], alignment[validColumnArray[k]], ds, addPadding);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 10228, 11006) || true) && (k > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 10228, 11006);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 10371, 10376);
                                // skipping the first ones, add a separator for concatenation
                                for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 10362, 10563) || true) && (j < f_1101_10382_10398(scArray[k]))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 10400, 10403)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 10362, 10563))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 10362, 10563);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 10453, 10540);

                                    scArray[k][j] = f_1101_10469_10523(ScreenInfo.separatorCharacterCount) + f_1101_10526_10539(scArray[k], j);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 202);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 202);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 10228, 11006);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 10228, 11006);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 10703, 10987) || true) && (_startColumn > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 10703, 10987);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 10782, 10787);
                                    for (int
            j = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 10773, 10964) || true) && (j < f_1101_10793_10809(scArray[k]))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 10811, 10814)
            , j++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 10773, 10964))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 10773, 10964);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 10872, 10937);

                                        scArray[k][j] = f_1101_10888_10920(_startColumn) + f_1101_10923_10936(scArray[k], j);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 192);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 192);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 10703, 10987);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 10228, 11006);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 1475);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 1475);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 11164, 11183);

                int
                screenRows = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 11206, 11211);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 11197, 11371) || true) && (k < f_1101_11217_11231(scArray))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 11233, 11236)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 11197, 11371))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 11197, 11371);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 11270, 11356) || true) && (f_1101_11274_11290(scArray[k]) > screenRows)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 11270, 11356);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 11326, 11356);

                            screenRows = f_1101_11339_11355(scArray[k]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 11270, 11356);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 175);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 175);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 11815, 11954);

                System.Span<int>
                lastColWithContent = (DynAbs.Tracing.TraceSender.Conditional_F1(1101, 11853, 11902) || ((screenRows <= OutCommandInner.StackAllocThreshold && DynAbs.Tracing.TraceSender.Conditional_F2(1101, 11905, 11931)) || DynAbs.Tracing.TraceSender.Conditional_F3(1101, 11934, 11953))) ? stackalloc int[screenRows] : new int[screenRows]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 11977, 11984);
                    for (int
        row = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 11968, 12295) || true) && (row < screenRows)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12004, 12009)
        , row++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 11968, 12295))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 11968, 12295);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12052, 12059);
                            for (int
            col = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12043, 12280) || true) && (col < f_1101_12067_12081(scArray))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12083, 12088)
            , col++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 12043, 12280))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 12043, 12280);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12130, 12261) || true) && (f_1101_12134_12152(scArray[col]) > row)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 12130, 12261);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12208, 12238);

                                    lastColWithContent[row] = col;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 12130, 12261);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 238);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 238);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 328);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 328);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12381, 12388);

                    // add padding for the columns that are shorter
                    for (int
        col = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12372, 13721) || true) && (col < f_1101_12396_12410(scArray))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12412, 12417)
        , col++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 12372, 13721))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 12372, 13721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12451, 12473);

                        int
                        paddingBlanks = 0
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12538, 12973) || true) && (col < f_1101_12548_12562(scArray) - 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 12538, 12973);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12608, 12668);

                            paddingBlanks = _si.columnInfo[validColumnArray[col]].width;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12690, 12954) || true) && (col > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 12690, 12954);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12751, 12803);

                                paddingBlanks += ScreenInfo.separatorCharacterCount;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 12690, 12954);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 12690, 12954);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12901, 12931);

                                paddingBlanks += _startColumn;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 12690, 12954);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 12538, 12973);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 12993, 13046);

                        int
                        paddingEntries = screenRows - f_1101_13027_13045(scArray[col])
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 13064, 13706) || true) && (paddingEntries > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 13064, 13706);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 13137, 13170);
                                for (int
            row = screenRows - paddingEntries
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 13128, 13687) || true) && (row < screenRows)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 13190, 13195)
            , row++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 13128, 13687))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 13128, 13687);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 13349, 13664) || true) && (col > lastColWithContent[row])
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 13349, 13664);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 13440, 13471);

                                        f_1101_13440_13470(scArray[col], string.Empty);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 13349, 13664);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 13349, 13664);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 13585, 13637);

                                        f_1101_13585_13636(scArray[col], f_1101_13602_13635(paddingBlanks));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 13349, 13664);
                                    }
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 560);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 560);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 13064, 13706);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 1350);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 1350);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 13788, 13827);

                string[]
                rows = new string[screenRows]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 13850, 13857);
                    for (int
        row = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 13841, 14622) || true) && (row < screenRows)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 13877, 13882)
        , row++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 13841, 14622))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 13841, 14622);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 13916, 13955);

                        StringBuilder
                        sb = f_1101_13935_13954()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 14036, 14043);
                            // for a given row, walk the columns
                            for (int
            col = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 14027, 14561) || true) && (col < f_1101_14051_14065(scArray))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 14067, 14072)
            , col++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 14027, 14561))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 14027, 14561);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 14251, 14542) || true) && (col == lastColWithContent[row] && (DynAbs.Tracing.TraceSender.Expression_True(1101, 14255, 14303) && screenRows > 1))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 14251, 14542);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 14353, 14392);

                                    f_1101_14353_14391(sb, f_1101_14363_14390(f_1101_14363_14380(scArray[col], row)));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 14251, 14542);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 14251, 14542);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 14490, 14519);

                                    f_1101_14490_14518(sb, f_1101_14500_14517(scArray[col], row));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 14251, 14542);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 535);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 535);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 14581, 14607);

                        rows[row] = f_1101_14593_14606(sb);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 782);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 782);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 14638, 14650);

                return rows;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1101, 8684, 14661);

                int
                f_1101_8895_8916(Microsoft.PowerShell.Commands.Internal.Format.TableWriter.ColumnInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 8895, 8916);
                    return return_v;
                }


                int
                f_1101_8973_8994(Microsoft.PowerShell.Commands.Internal.Format.TableWriter.ColumnInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 8973, 8994);
                    return return_v;
                }


                int
                f_1101_9006_9027(Microsoft.PowerShell.Commands.Internal.Format.TableWriter.ColumnInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 9006, 9027);
                    return return_v;
                }


                int
                f_1101_9102_9123(Microsoft.PowerShell.Commands.Internal.Format.TableWriter.ColumnInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 9102, 9123);
                    return return_v;
                }


                int
                f_1101_9567_9581(System.Collections.Specialized.StringCollection[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 9567, 9581);
                    return return_v;
                }


                int
                f_1101_9704_9718(System.Collections.Specialized.StringCollection[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 9704, 9718);
                    return return_v;
                }


                System.Collections.Specialized.StringCollection
                f_1101_9893_10037(Microsoft.PowerShell.Commands.Internal.Format.TableWriter
                this_param, string
                val, int
                k, int
                alignment, Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                dc, bool
                addPadding)
                {
                    var return_v = this_param.GenerateMultiLineRowField(val, k, alignment, dc, addPadding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 9893, 10037);
                    return return_v;
                }


                int
                f_1101_10382_10398(System.Collections.Specialized.StringCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 10382, 10398);
                    return return_v;
                }


                string
                f_1101_10469_10523(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 10469, 10523);
                    return return_v;
                }


                string
                f_1101_10526_10539(System.Collections.Specialized.StringCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 10526, 10539);
                    return return_v;
                }


                int
                f_1101_10793_10809(System.Collections.Specialized.StringCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 10793, 10809);
                    return return_v;
                }


                string
                f_1101_10888_10920(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 10888, 10920);
                    return return_v;
                }


                string
                f_1101_10923_10936(System.Collections.Specialized.StringCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 10923, 10936);
                    return return_v;
                }


                int
                f_1101_11217_11231(System.Collections.Specialized.StringCollection[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 11217, 11231);
                    return return_v;
                }


                int
                f_1101_11274_11290(System.Collections.Specialized.StringCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 11274, 11290);
                    return return_v;
                }


                int
                f_1101_11339_11355(System.Collections.Specialized.StringCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 11339, 11355);
                    return return_v;
                }


                int
                f_1101_12067_12081(System.Collections.Specialized.StringCollection[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 12067, 12081);
                    return return_v;
                }


                int
                f_1101_12134_12152(System.Collections.Specialized.StringCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 12134, 12152);
                    return return_v;
                }


                int
                f_1101_12396_12410(System.Collections.Specialized.StringCollection[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 12396, 12410);
                    return return_v;
                }


                int
                f_1101_12548_12562(System.Collections.Specialized.StringCollection[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 12548, 12562);
                    return return_v;
                }


                int
                f_1101_13027_13045(System.Collections.Specialized.StringCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 13027, 13045);
                    return return_v;
                }


                int
                f_1101_13440_13470(System.Collections.Specialized.StringCollection
                this_param, string
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 13440, 13470);
                    return return_v;
                }


                string
                f_1101_13602_13635(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 13602, 13635);
                    return return_v;
                }


                int
                f_1101_13585_13636(System.Collections.Specialized.StringCollection
                this_param, string
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 13585, 13636);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1101_13935_13954()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 13935, 13954);
                    return return_v;
                }


                int
                f_1101_14051_14065(System.Collections.Specialized.StringCollection[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 14051, 14065);
                    return return_v;
                }


                string
                f_1101_14363_14380(System.Collections.Specialized.StringCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 14363, 14380);
                    return return_v;
                }


                string
                f_1101_14363_14390(string
                this_param)
                {
                    var return_v = this_param.TrimEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 14363, 14390);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1101_14353_14391(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 14353, 14391);
                    return return_v;
                }


                string
                f_1101_14500_14517(System.Collections.Specialized.StringCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 14500, 14517);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1101_14490_14518(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 14490, 14518);
                    return return_v;
                }


                string
                f_1101_14593_14606(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 14593, 14606);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1101, 8684, 14661);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1101, 8684, 14661);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private StringCollection GenerateMultiLineRowField(string val, int k, int alignment, DisplayCells dc, bool addPadding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1101, 14673, 15485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 14816, 14977);

                StringCollection
                sc = f_1101_14838_14976(dc, val, _si.columnInfo[k].width, _si.columnInfo[k].width)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 14991, 15448) || true) && (addPadding || (DynAbs.Tracing.TraceSender.Expression_False(1101, 14995, 15041) || alignment == TextAlignment.Right) || (DynAbs.Tracing.TraceSender.Expression_False(1101, 14995, 15078) || alignment == TextAlignment.Center))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 14991, 15448);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 15179, 15186);
                        // if length is shorter, do some padding
                        for (int
        col = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 15170, 15433) || true) && (col < f_1101_15194_15202(sc))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 15204, 15209)
        , col++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 15170, 15433))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 15170, 15433);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 15251, 15414) || true) && (f_1101_15255_15273(dc, f_1101_15265_15272(sc, col)) < _si.columnInfo[k].width)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 15251, 15414);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 15326, 15414);

                                sc[col] = f_1101_15336_15413(f_1101_15353_15360(sc, col), _si.columnInfo[k].width, alignment, dc, addPadding);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 15251, 15414);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 264);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 264);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 14991, 15448);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 15464, 15474);

                return sc;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1101, 14673, 15485);

                System.Collections.Specialized.StringCollection
                f_1101_14838_14976(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                displayCells, string
                val, int
                firstLineLen, int
                followingLinesLen)
                {
                    var return_v = StringManipulationHelper.GenerateLines(displayCells, val, firstLineLen, followingLinesLen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 14838, 14976);
                    return return_v;
                }


                int
                f_1101_15194_15202(System.Collections.Specialized.StringCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 15194, 15202);
                    return return_v;
                }


                string
                f_1101_15265_15272(System.Collections.Specialized.StringCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 15265, 15272);
                    return return_v;
                }


                int
                f_1101_15255_15273(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 15255, 15273);
                    return return_v;
                }


                string
                f_1101_15353_15360(System.Collections.Specialized.StringCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 15353, 15360);
                    return return_v;
                }


                string
                f_1101_15336_15413(string
                val, int
                width, int
                alignment, Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                dc, bool
                addPadding)
                {
                    var return_v = GenerateRowField(val, width, alignment, dc, addPadding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 15336, 15413);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1101, 14673, 15485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1101, 14673, 15485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GenerateRow(string[] values, ReadOnlySpan<int> alignment, DisplayCells dc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1101, 15497, 17164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 15611, 15650);

                StringBuilder
                sb = f_1101_15630_15649()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 15666, 15689);

                bool
                addPadding = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 15712, 15717);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 15703, 17116) || true) && (k < f_1101_15723_15744(_si.columnInfo))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 15746, 15749)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 15703, 17116))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 15703, 17116);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 15829, 15943) || true) && (k == f_1101_15838_15859(_si.columnInfo) - 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 15829, 15943);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 15905, 15924);

                            addPadding = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 15829, 15943);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 15963, 16148) || true) && (_si.columnInfo[k].width <= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 15963, 16148);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 16120, 16129);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 15963, 16148);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 16338, 16751) || true) && (k > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 16338, 16751);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 16389, 16455);

                            f_1101_16389_16454(sb, f_1101_16399_16453(ScreenInfo.separatorCharacterCount));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 16338, 16751);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 16338, 16751);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 16595, 16732) || true) && (_startColumn > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 16595, 16732);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 16665, 16709);

                                f_1101_16665_16708(sb, f_1101_16675_16707(_startColumn));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 16595, 16732);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 16338, 16751);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 16771, 16865);

                        f_1101_16771_16864(
                                        sb, f_1101_16781_16863(values[k], _si.columnInfo[k].width, alignment[k], dc, addPadding));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 16883, 17101) || true) && (f_1101_16887_16909(values[k], ESC) != -1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 16883, 17101);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 17049, 17082);

                            f_1101_17049_17081(                    // Reset the console output if the content of this column contains ESC
                                                sb, ResetConsoleVt100Code);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 16883, 17101);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1101, 1, 1414);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1101, 1, 1414);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 17132, 17153);

                return f_1101_17139_17152(sb);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1101, 15497, 17164);

                System.Text.StringBuilder
                f_1101_15630_15649()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 15630, 15649);
                    return return_v;
                }


                int
                f_1101_15723_15744(Microsoft.PowerShell.Commands.Internal.Format.TableWriter.ColumnInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 15723, 15744);
                    return return_v;
                }


                int
                f_1101_15838_15859(Microsoft.PowerShell.Commands.Internal.Format.TableWriter.ColumnInfo[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 15838, 15859);
                    return return_v;
                }


                string
                f_1101_16399_16453(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 16399, 16453);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1101_16389_16454(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 16389, 16454);
                    return return_v;
                }


                string
                f_1101_16675_16707(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 16675, 16707);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1101_16665_16708(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 16665, 16708);
                    return return_v;
                }


                string
                f_1101_16781_16863(string
                val, int
                width, int
                alignment, Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                dc, bool
                addPadding)
                {
                    var return_v = GenerateRowField(val, width, alignment, dc, addPadding);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 16781, 16863);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1101_16771_16864(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 16771, 16864);
                    return return_v;
                }


                int
                f_1101_16887_16909(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 16887, 16909);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1101_17049_17081(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 17049, 17081);
                    return return_v;
                }


                string
                f_1101_17139_17152(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 17139, 17152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1101, 15497, 17164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1101, 15497, 17164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GenerateRowField(string val, int width, int alignment, DisplayCells dc, bool addPadding)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1101, 17176, 23334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 17386, 17445);

                string
                s = f_1101_17397_17444(val)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 17461, 17485);

                string
                currentValue = s
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 17499, 17555);

                int
                currentValueDisplayLength = f_1101_17531_17554(dc, currentValue)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 17571, 22141) || true) && (currentValueDisplayLength < width)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 17571, 22141);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 17789, 17838);

                    int
                    padCount = width - currentValueDisplayLength
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 17856, 19042);

                    switch (alignment)
                    {

                        case TextAlignment.Right:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 17856, 19042);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 17997, 18034);

                                s = f_1101_18001_18029(padCount) + s;
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1101, 18089, 18095);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 17856, 19042);

                        case TextAlignment.Center:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 17856, 19042);
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 18271, 18298);

                                int
                                padLeft = padCount / 2
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 18328, 18362);

                                int
                                padRight = padCount - padLeft
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 18394, 18430);

                                s = f_1101_18398_18425(padLeft) + s;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 18460, 18605) || true) && (addPadding)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 18460, 18605);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 18540, 18574);

                                    s += f_1101_18545_18573(padRight);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 18460, 18605);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1101, 18660, 18666);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 17856, 19042);

                        default:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 17856, 19042);
                            {

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 18755, 18962) || true) && (addPadding)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 18755, 18962);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 18897, 18931);

                                    s += f_1101_18902_18930(padCount);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 18755, 18962);
                                }
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1101, 19017, 19023);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 17856, 19042);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 17571, 22141);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 17571, 22141);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 19076, 22141) || true) && (currentValueDisplayLength > width)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 19076, 22141);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 19280, 19331);

                        int
                        truncationDisplayLength = width - EllipsisSize
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 19351, 22126) || true) && (truncationDisplayLength > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 19351, 22126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 19487, 20818);

                            switch (alignment)
                            {

                                case TextAlignment.Right:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 19487, 20818);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 19708, 19774);

                                        int
                                        tailCount = f_1101_19724_19773(dc, s, truncationDisplayLength)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 19808, 19846);

                                        s = f_1101_19812_19845(s, f_1101_19824_19832(s) - tailCount);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 19880, 19912);

                                        s = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (PSObjectHelper.Ellipsis).ToString(), 1101, 19884, 19907) + s;
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(1101, 19975, 19981);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 19487, 20818);

                                case TextAlignment.Center:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 19487, 20818);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 20164, 20234);

                                        s = f_1101_20168_20233(s, 0, f_1101_20183_20232(dc, s, truncationDisplayLength));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 20268, 20297);

                                        s += PSObjectHelper.Ellipsis;
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(1101, 20360, 20366);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 19487, 20818);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 19487, 20818);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 20593, 20663);

                                        s = f_1101_20597_20662(s, 0, f_1101_20612_20661(dc, s, truncationDisplayLength));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 20697, 20726);

                                        s += PSObjectHelper.Ellipsis;
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(1101, 20789, 20795);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 19487, 20818);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 19351, 22126);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 19351, 22126);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 20986, 21002);

                            int
                            len = width
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 21026, 22107);

                            switch (alignment)
                            {

                                case TextAlignment.Right:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 21026, 22107);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 21244, 21290);

                                        int
                                        tailCount = f_1101_21260_21289(dc, s, len)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 21324, 21373);

                                        s = f_1101_21328_21372(s, f_1101_21340_21348(s) - tailCount, tailCount);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(1101, 21436, 21442);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 21026, 22107);

                                case TextAlignment.Center:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 21026, 22107);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 21622, 21672);

                                        s = f_1101_21626_21671(s, 0, f_1101_21641_21670(dc, s, len));
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(1101, 21735, 21741);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 21026, 22107);

                                default:
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 21026, 22107);
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 21965, 22015);

                                        s = f_1101_21969_22014(s, 0, f_1101_21984_22013(dc, s, len));
                                    }
                                    DynAbs.Tracing.TraceSender.TraceBreak(1101, 22078, 22084);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 21026, 22107);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 19351, 22126);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 19076, 22141);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 17571, 22141);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 22378, 22421);

                int
                finalValueDisplayLength = f_1101_22408_22420(dc, s)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 22435, 22529) || true) && (finalValueDisplayLength == width)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 22435, 22529);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 22505, 22514);

                    return s;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 22435, 22529);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 22545, 23298);

                switch (alignment)
                {

                    case TextAlignment.Right:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 22545, 23298);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 22670, 22682);

                            s = " " + s;
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1101, 22729, 22735);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 22545, 23298);

                    case TextAlignment.Center:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 22545, 23298);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 22830, 22938) || true) && (addPadding)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 22830, 22938);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 22902, 22911);

                                s += " ";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 22830, 22938);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1101, 22985, 22991);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 22545, 23298);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 22545, 23298);
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 23122, 23230) || true) && (addPadding)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1101, 23122, 23230);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 23194, 23203);

                                s += " ";
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 23122, 23230);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1101, 23277, 23283);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1101, 22545, 23298);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 23314, 23323);

                return s;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1101, 17176, 23334);

                string
                f_1101_17397_17444(string
                s)
                {
                    var return_v = StringManipulationHelper.TruncateAtNewLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 17397, 17444);
                    return return_v;
                }


                int
                f_1101_17531_17554(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 17531, 17554);
                    return return_v;
                }


                string
                f_1101_18001_18029(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 18001, 18029);
                    return return_v;
                }


                string
                f_1101_18398_18425(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 18398, 18425);
                    return return_v;
                }


                string
                f_1101_18545_18573(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 18545, 18573);
                    return return_v;
                }


                string
                f_1101_18902_18930(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 18902, 18930);
                    return return_v;
                }


                int
                f_1101_19724_19773(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str, int
                displayCells)
                {
                    var return_v = this_param.GetTailSplitLength(str, displayCells);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 19724, 19773);
                    return return_v;
                }


                int
                f_1101_19824_19832(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 19824, 19832);
                    return return_v;
                }


                string
                f_1101_19812_19845(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 19812, 19845);
                    return return_v;
                }


                int
                f_1101_20183_20232(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str, int
                displayCells)
                {
                    var return_v = this_param.GetHeadSplitLength(str, displayCells);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 20183, 20232);
                    return return_v;
                }


                string
                f_1101_20168_20233(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 20168, 20233);
                    return return_v;
                }


                int
                f_1101_20612_20661(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str, int
                displayCells)
                {
                    var return_v = this_param.GetHeadSplitLength(str, displayCells);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 20612, 20661);
                    return return_v;
                }


                string
                f_1101_20597_20662(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 20597, 20662);
                    return return_v;
                }


                int
                f_1101_21260_21289(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str, int
                displayCells)
                {
                    var return_v = this_param.GetTailSplitLength(str, displayCells);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 21260, 21289);
                    return return_v;
                }


                int
                f_1101_21340_21348(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1101, 21340, 21348);
                    return return_v;
                }


                string
                f_1101_21328_21372(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 21328, 21372);
                    return return_v;
                }


                int
                f_1101_21641_21670(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str, int
                displayCells)
                {
                    var return_v = this_param.GetHeadSplitLength(str, displayCells);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 21641, 21670);
                    return return_v;
                }


                string
                f_1101_21626_21671(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 21626, 21671);
                    return return_v;
                }


                int
                f_1101_21984_22013(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str, int
                displayCells)
                {
                    var return_v = this_param.GetHeadSplitLength(str, displayCells);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 21984, 22013);
                    return return_v;
                }


                string
                f_1101_21969_22014(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 21969, 22014);
                    return return_v;
                }


                int
                f_1101_22408_22420(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1101, 22408, 22420);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1101, 17176, 23334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1101, 17176, 23334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private const int
        EllipsisSize = 1
        ;

        private bool _disabled;

        private bool _hideHeader;

        private int _startColumn;

        public TableWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1101, 377, 23517);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 1229, 1232);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 1374, 1381);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 23406, 23423);
            this._disabled = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 23449, 23468);
            this._hideHeader = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 23493, 23509);
            this._startColumn = 0;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1101, 377, 23517);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1101, 377, 23517);
        }


        static TableWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1101, 377, 23517);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 1262, 1276);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 1308, 1342);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1101, 23364, 23380);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1101, 377, 23517);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1101, 377, 23517);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1101, 377, 23517);
    }
}
