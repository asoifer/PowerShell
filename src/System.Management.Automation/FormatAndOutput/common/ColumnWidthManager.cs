// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class ColumnWidthManager
    {
        internal ColumnWidthManager(int tableWidth, int minimumColumnWidth, int separatorWidth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1084, 731, 981);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 7559, 7570);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 7593, 7612);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 7635, 7650);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 843, 868);

                _tableWidth = tableWidth;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 882, 923);

                _minimumColumnWidth = minimumColumnWidth;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 937, 970);

                _separatorWidth = separatorWidth;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1084, 731, 981);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1084, 731, 981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1084, 731, 981);
            }
        }

        internal void CalculateColumnWidths(Span<int> columnWidths)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1084, 1500, 1864);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 1584, 1743) || true) && (f_1084_1588_1620(this, columnWidths))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 1584, 1743);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 1721, 1728);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 1584, 1743);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 1829, 1853);

                f_1084_1829_1852(this, columnWidths);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1084, 1500, 1864);

                bool
                f_1084_1588_1620(Microsoft.PowerShell.Commands.Internal.Format.ColumnWidthManager
                this_param, System.Span<int>
                columnWidths)
                {
                    var return_v = this_param.AssignColumnWidths(columnWidths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1084, 1588, 1620);
                    return return_v;
                }


                int
                f_1084_1829_1852(Microsoft.PowerShell.Commands.Internal.Format.ColumnWidthManager
                this_param, System.Span<int>
                columnWidths)
                {
                    this_param.TrimToFit(columnWidths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1084, 1829, 1852);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1084, 1500, 1864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1084, 1500, 1864);
            }
        }

        private bool AssignColumnWidths(Span<int> columnWidths)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1084, 2208, 4769);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 2407, 2432);

                bool
                allSpecified = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 2446, 2473);

                int
                maxInitialWidthSum = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 2498, 2503);

                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 2489, 2774) || true) && (k < columnWidths.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 2530, 2533)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 2489, 2774))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 2489, 2774);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 2567, 2701) || true) && (columnWidths[k] <= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 2567, 2701);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 2633, 2654);

                            allSpecified = false;
                            DynAbs.Tracing.TraceSender.TraceBreak(1084, 2676, 2682);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 2567, 2701);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 2721, 2759);

                        maxInitialWidthSum += columnWidths[k];
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1084, 1, 286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1084, 1, 286);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 2790, 3273) || true) && (allSpecified)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 2790, 3273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 2915, 2981);

                    maxInitialWidthSum += _separatorWidth * (columnWidths.Length - 1);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 2999, 3171) || true) && (maxInitialWidthSum <= _tableWidth)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 2999, 3171);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 3140, 3152);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 2999, 3171);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 3245, 3258);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 2790, 3273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 3455, 3506);

                bool[]
                fixedColumn = new bool[columnWidths.Length]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 3529, 3534);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 3520, 3753) || true) && (k < columnWidths.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 3561, 3564)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 3520, 3753))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 3520, 3753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 3598, 3635);

                        fixedColumn[k] = columnWidths[k] > 0;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 3653, 3738) || true) && (columnWidths[k] == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 3653, 3738);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 3700, 3738);

                            columnWidths[k] = _minimumColumnWidth;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 3653, 3738);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1084, 1, 234);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1084, 1, 234);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 3799, 3855);

                int
                currentTableWidth = f_1084_3823_3854(this, columnWidths)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 3869, 3922);

                int
                availableWidth = _tableWidth - currentTableWidth
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 3938, 4245) || true) && (availableWidth < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 3938, 4245);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 4082, 4095);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 3938, 4245);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 3938, 4245);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 4129, 4245) || true) && (availableWidth == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 4129, 4245);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 4218, 4230);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 4129, 4245);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 3938, 4245);
                }
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 4328, 4720) || true) && (availableWidth > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 4328, 4720);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 4396, 4401);
                            for (int
            k = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 4387, 4705) || true) && (k < columnWidths.Length)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 4428, 4431)
            , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 4387, 4705))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 4387, 4705);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 4473, 4527) || true) && (fixedColumn[k])
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 4473, 4527);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 4518, 4527);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 4473, 4527);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 4551, 4569);

                                f_1084_4551_4568_M(columnWidths[k]++);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 4591, 4608);

                                availableWidth--;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 4630, 4686) || true) && (availableWidth == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 4630, 4686);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1084, 4680, 4686);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 4630, 4686);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1084, 1, 319);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1084, 1, 319);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 4328, 4720);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1084, 4328, 4720);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1084, 4328, 4720);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 4736, 4748);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1084, 2208, 4769);

                int
                f_1084_3823_3854(Microsoft.PowerShell.Commands.Internal.Format.ColumnWidthManager
                this_param, System.Span<int>
                columnWidths)
                {
                    var return_v = this_param.CurrentTableWidth(columnWidths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1084, 3823, 3854);
                    return return_v;
                }


                int
                f_1084_4551_4568_M(int
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1084, 4551, 4568);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1084, 2208, 4769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1084, 2208, 4769);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void TrimToFit(Span<int> columnWidths)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1084, 4979, 6270);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 5050, 6259) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 5050, 6259);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 5095, 5151);

                        int
                        currentTableWidth = f_1084_5119_5150(this, columnWidths)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 5169, 5221);

                        int
                        widthInExcess = currentTableWidth - _tableWidth
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 5239, 5360) || true) && (widthInExcess <= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 5239, 5360);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 5303, 5310);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 5239, 5360);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 5452, 5511);

                        int
                        lastVisibleColumn = f_1084_5476_5510(columnWidths)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 5531, 5586) || true) && (lastVisibleColumn < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 5531, 5586);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 5579, 5586);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 5531, 5586);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 5721, 5801);

                        int
                        newLastVisibleColumnWidth = columnWidths[lastVisibleColumn] - widthInExcess
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 5821, 6244) || true) && (newLastVisibleColumnWidth < _minimumColumnWidth)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 5821, 6244);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 5966, 6003);

                            columnWidths[lastVisibleColumn] = -1;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 6025, 6034);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 5821, 6244);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 5821, 6244);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 6165, 6225);

                            columnWidths[lastVisibleColumn] = newLastVisibleColumnWidth;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 5821, 6244);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 5050, 6259);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1084, 5050, 6259);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1084, 5050, 6259);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1084, 4979, 6270);

                int
                f_1084_5119_5150(Microsoft.PowerShell.Commands.Internal.Format.ColumnWidthManager
                this_param, System.Span<int>
                columnWidths)
                {
                    var return_v = this_param.CurrentTableWidth(columnWidths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1084, 5119, 5150);
                    return return_v;
                }


                int
                f_1084_5476_5510(System.Span<int>
                columnWidths)
                {
                    var return_v = GetLastVisibleColumn(columnWidths);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1084, 5476, 5510);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1084, 4979, 6270);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1084, 4979, 6270);
            }
        }

        private int CurrentTableWidth(Span<int> columnWidths)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1084, 6504, 6965);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 6582, 6594);

                int
                sum = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 6608, 6631);

                int
                visibleColumns = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 6656, 6661);

                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 6647, 6886) || true) && (k < columnWidths.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 6688, 6691)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 6647, 6886))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 6647, 6886);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 6725, 6871) || true) && (columnWidths[k] > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 6725, 6871);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 6790, 6813);

                            sum += columnWidths[k];
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 6835, 6852);

                            visibleColumns++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 6725, 6871);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1084, 1, 240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1084, 1, 240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 6902, 6954);

                return sum + _separatorWidth * (visibleColumns - 1);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1084, 6504, 6965);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1084, 6504, 6965);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1084, 6504, 6965);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetLastVisibleColumn(Span<int> columnWidths)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1084, 7237, 7535);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 7334, 7339);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 7325, 7477) || true) && (k < columnWidths.Length)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 7366, 7369)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 7325, 7477))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 7325, 7477);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 7403, 7462) || true) && (columnWidths[k] < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1084, 7403, 7462);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 7449, 7462);

                            return k - 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1084, 7403, 7462);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1084, 1, 153);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1084, 1, 153);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1084, 7493, 7524);

                return columnWidths.Length - 1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1084, 7237, 7535);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1084, 7237, 7535);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1084, 7237, 7535);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int _tableWidth;

        private int _minimumColumnWidth;

        private int _separatorWidth;

        static ColumnWidthManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1084, 308, 7658);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1084, 308, 7658);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1084, 308, 7658);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1084, 308, 7658);
    }
}
