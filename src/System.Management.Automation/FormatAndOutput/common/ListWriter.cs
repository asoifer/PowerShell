// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Specialized;
using System.Diagnostics;
using System.Management.Automation.Internal;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal class ListWriter
    {
        private string[] _propertyLabels;

        private int _propertyLabelsDisplayLength;

        private int _columnWidth;

        internal void Initialize(string[] propertyNames, int screenColumnWidth, DisplayCells dc)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1098, 1256, 4302);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 1369, 1402);

                _columnWidth = screenColumnWidth;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 1416, 1606) || true) && (propertyNames == null || (DynAbs.Tracing.TraceSender.Expression_False(1098, 1420, 1470) || f_1098_1445_1465(propertyNames) == 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 1416, 1606);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 1549, 1566);

                    _disabled = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 1584, 1591);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 1416, 1606);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 1622, 1640);

                _disabled = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 1656, 1717);

                f_1098_1656_1716(propertyNames != null, "propertyNames is null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 1731, 1803);

                f_1098_1731_1802(f_1098_1744_1764(propertyNames) > 0, "propertyNames has zero length");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 1860, 2104) || true) && ((screenColumnWidth - f_1098_1885_1901(Separator) - MinFieldWidth - MinLabelWidth) < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 1860, 2104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 2047, 2064);

                    _disabled = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 2082, 2089);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 1860, 2104);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 2176, 2259);

                int
                maxAllowableLabelLength = screenColumnWidth - f_1098_2226_2242(Separator) - MinFieldWidth
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 2358, 2391);

                _propertyLabelsDisplayLength = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 2477, 2643);

                Span<int>
                propertyNameCellCounts = (DynAbs.Tracing.TraceSender.Conditional_F1(1098, 2512, 2571) || ((f_1098_2512_2532(propertyNames) <= OutCommandInner.StackAllocThreshold && DynAbs.Tracing.TraceSender.Conditional_F2(1098, 2574, 2610)) || DynAbs.Tracing.TraceSender.Conditional_F3(1098, 2613, 2642))) ? stackalloc int[f_1098_2589_2609(propertyNames)] : new int[f_1098_2621_2641(propertyNames)]
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 2666, 2671);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 2657, 3050) || true) && (k < f_1098_2677_2697(propertyNames))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 2699, 2702)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 2657, 3050))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 2657, 3050);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 2736, 2803);

                        f_1098_2736_2802(propertyNames[k] != null, "propertyNames[k] is null");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 2821, 2877);

                        propertyNameCellCounts[k] = f_1098_2849_2876(dc, propertyNames[k]);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 2895, 3035) || true) && (propertyNameCellCounts[k] > _propertyLabelsDisplayLength)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 2895, 3035);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 2978, 3035);

                            _propertyLabelsDisplayLength = propertyNameCellCounts[k];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 2895, 3035);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1098, 1, 394);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1098, 1, 394);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 3066, 3265) || true) && (_propertyLabelsDisplayLength > maxAllowableLabelLength)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 3066, 3265);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 3195, 3250);

                    _propertyLabelsDisplayLength = maxAllowableLabelLength;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 3066, 3265);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 3281, 3332);

                _propertyLabels = new string[f_1098_3310_3330(propertyNames)];
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 3357, 3362);

                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 3348, 4226) || true) && (k < f_1098_3368_3388(propertyNames))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 3390, 3393)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 3348, 4226))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 3348, 4226);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 3427, 4159) || true) && (propertyNameCellCounts[k] < _propertyLabelsDisplayLength)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 3427, 4159);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 3587, 3704);

                            _propertyLabels[k] = propertyNames[k] + f_1098_3627_3703(_propertyLabelsDisplayLength - propertyNameCellCounts[k]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 3427, 4159);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 3427, 4159);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 3746, 4159) || true) && (propertyNameCellCounts[k] > _propertyLabelsDisplayLength)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 3746, 4159);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 3898, 4020);

                                _propertyLabels[k] = f_1098_3919_4019(propertyNames[k], 0, f_1098_3949_4018(dc, propertyNames[k], _propertyLabelsDisplayLength));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 3746, 4159);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 3746, 4159);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 4102, 4140);

                                _propertyLabels[k] = propertyNames[k];
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 3746, 4159);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 3427, 4159);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 4179, 4211);

                        _propertyLabels[k] += Separator;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1098, 1, 879);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1098, 1, 879);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 4242, 4291);

                _propertyLabelsDisplayLength += f_1098_4274_4290(Separator);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1098, 1256, 4302);

                int
                f_1098_1445_1465(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 1445, 1465);
                    return return_v;
                }


                int
                f_1098_1656_1716(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 1656, 1716);
                    return 0;
                }


                int
                f_1098_1744_1764(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 1744, 1764);
                    return return_v;
                }


                int
                f_1098_1731_1802(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 1731, 1802);
                    return 0;
                }


                int
                f_1098_1885_1901(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 1885, 1901);
                    return return_v;
                }


                int
                f_1098_2226_2242(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 2226, 2242);
                    return return_v;
                }


                int
                f_1098_2512_2532(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 2512, 2532);
                    return return_v;
                }


                int
                f_1098_2589_2609(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 2589, 2609);
                    return return_v;
                }


                int
                f_1098_2621_2641(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 2621, 2641);
                    return return_v;
                }


                int
                f_1098_2677_2697(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 2677, 2697);
                    return return_v;
                }


                int
                f_1098_2736_2802(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 2736, 2802);
                    return 0;
                }


                int
                f_1098_2849_2876(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 2849, 2876);
                    return return_v;
                }


                int
                f_1098_3310_3330(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 3310, 3330);
                    return return_v;
                }


                int
                f_1098_3368_3388(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 3368, 3388);
                    return return_v;
                }


                string
                f_1098_3627_3703(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 3627, 3703);
                    return return_v;
                }


                int
                f_1098_3949_4018(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str, int
                displayCells)
                {
                    var return_v = this_param.GetHeadSplitLength(str, displayCells);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 3949, 4018);
                    return return_v;
                }


                string
                f_1098_3919_4019(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 3919, 4019);
                    return return_v;
                }


                int
                f_1098_4274_4290(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 4274, 4290);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1098, 1256, 4302);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1098, 1256, 4302);
            }
        }

        internal void WriteProperties(string[] values, LineOutput lo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1098, 4589, 6249);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 4675, 4714) || true) && (_disabled)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 4675, 4714);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 4707, 4714);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 4675, 4714);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 4730, 4760);

                string[]
                valuesToPrint = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 4774, 6024) || true) && (values == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 4774, 6024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 4900, 4951);

                    valuesToPrint = new string[f_1098_4927_4949(_propertyLabels)];
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 4978, 4983);
                        for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 4969, 5071) || true) && (k < f_1098_4989_5011(_propertyLabels))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5013, 5016)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 4969, 5071))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 4969, 5071);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5039, 5071);

                            valuesToPrint[k] = string.Empty;
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1098, 1, 103);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1098, 1, 103);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 4774, 6024);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 4774, 6024);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5105, 6024) || true) && (f_1098_5109_5122(values) < f_1098_5125_5147(_propertyLabels))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 5105, 6024);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5237, 5288);

                        valuesToPrint = new string[f_1098_5264_5286(_propertyLabels)];
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5315, 5320);
                            for (int
            k = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5306, 5575) || true) && (k < f_1098_5326_5348(_propertyLabels))
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5350, 5353)
            , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 5306, 5575))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 5306, 5575);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5395, 5556) || true) && (k < f_1098_5403_5416(values))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 5395, 5556);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5443, 5472);

                                    valuesToPrint[k] = values[k];
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 5395, 5556);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 5395, 5556);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5524, 5556);

                                    valuesToPrint[k] = string.Empty;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 5395, 5556);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1098, 1, 270);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1098, 1, 270);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 5105, 6024);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 5105, 6024);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5609, 6024) || true) && (f_1098_5613_5626(values) > f_1098_5629_5651(_propertyLabels))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 5609, 6024);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5718, 5769);

                            valuesToPrint = new string[f_1098_5745_5767(_propertyLabels)];
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5796, 5801);
                                for (int
                k = 0
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5787, 5886) || true) && (k < f_1098_5807_5829(_propertyLabels))
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5831, 5834)
                , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 5787, 5886))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 5787, 5886);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5857, 5886);

                                    valuesToPrint[k] = values[k];
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1098, 1, 100);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1098, 1, 100);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 5609, 6024);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 5609, 6024);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 5986, 6009);

                            valuesToPrint = values;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 5609, 6024);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 5105, 6024);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 4774, 6024);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 6040, 6087);

                f_1098_6040_6086(lo != null, "LineOutput is null");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 6112, 6117);

                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 6103, 6238) || true) && (k < f_1098_6123_6145(_propertyLabels))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 6147, 6150)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 6103, 6238))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 6103, 6238);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 6184, 6223);

                        f_1098_6184_6222(this, k, valuesToPrint[k], lo);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1098, 1, 136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1098, 1, 136);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1098, 4589, 6249);

                int
                f_1098_4927_4949(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 4927, 4949);
                    return return_v;
                }


                int
                f_1098_4989_5011(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 4989, 5011);
                    return return_v;
                }


                int
                f_1098_5109_5122(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 5109, 5122);
                    return return_v;
                }


                int
                f_1098_5125_5147(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 5125, 5147);
                    return return_v;
                }


                int
                f_1098_5264_5286(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 5264, 5286);
                    return return_v;
                }


                int
                f_1098_5326_5348(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 5326, 5348);
                    return return_v;
                }


                int
                f_1098_5403_5416(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 5403, 5416);
                    return return_v;
                }


                int
                f_1098_5613_5626(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 5613, 5626);
                    return return_v;
                }


                int
                f_1098_5629_5651(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 5629, 5651);
                    return return_v;
                }


                int
                f_1098_5745_5767(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 5745, 5767);
                    return return_v;
                }


                int
                f_1098_5807_5829(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 5807, 5829);
                    return return_v;
                }


                int
                f_1098_6040_6086(bool
                condition, string
                message)
                {
                    Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 6040, 6086);
                    return 0;
                }


                int
                f_1098_6123_6145(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 6123, 6145);
                    return return_v;
                }


                int
                f_1098_6184_6222(Microsoft.PowerShell.Commands.Internal.Format.ListWriter
                this_param, int
                k, string
                propertyValue, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                lo)
                {
                    this_param.WriteProperty(k, propertyValue, lo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 6184, 6222);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1098, 4589, 6249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1098, 4589, 6249);
            }
        }

        private void WriteProperty(int k, string propertyValue, LineOutput lo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1098, 6670, 7608);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 6765, 6838) || true) && (propertyValue == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 6765, 6838);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 6809, 6838);

                    propertyValue = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 6765, 6838);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 6907, 6975);

                string[]
                lines = f_1098_6924_6974(propertyValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 7051, 7073);

                string
                padding = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 7098, 7103);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 7089, 7597) || true) && (i < f_1098_7109_7121(lines))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 7123, 7126)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 7089, 7597))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 7089, 7597);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 7160, 7188);

                        string
                        prependString = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 7208, 7511) || true) && (i == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 7208, 7511);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 7241, 7276);

                            prependString = _propertyLabels[k];
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 7208, 7511);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 7208, 7511);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 7339, 7444) || true) && (padding == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 7339, 7444);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 7385, 7444);

                                padding = f_1098_7395_7443(_propertyLabelsDisplayLength);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 7339, 7444);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 7468, 7492);

                            prependString = padding;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 7208, 7511);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 7531, 7582);

                        f_1098_7531_7581(this, prependString, lines[i], lo);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1098, 1, 509);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1098, 1, 509);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1098, 6670, 7608);

                string[]
                f_1098_6924_6974(string
                s)
                {
                    var return_v = StringManipulationHelper.SplitLines(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 6924, 6974);
                    return return_v;
                }


                int
                f_1098_7109_7121(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 7109, 7121);
                    return return_v;
                }


                string
                f_1098_7395_7443(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 7395, 7443);
                    return return_v;
                }


                int
                f_1098_7531_7581(Microsoft.PowerShell.Commands.Internal.Format.ListWriter
                this_param, string
                prependString, string
                line, Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                lo)
                {
                    this_param.WriteSingleLineHelper(prependString, line, lo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 7531, 7581);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1098, 6670, 7608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1098, 6670, 7608);
            }
        }

        private void WriteSingleLineHelper(string prependString, string line, LineOutput lo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1098, 7985, 8996);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 8094, 8149) || true) && (line == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 8094, 8149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 8129, 8149);

                    line = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 8094, 8149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 8251, 8316);

                int
                fieldCellCount = _columnWidth - _propertyLabelsDisplayLength
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 8364, 8480);

                StringCollection
                sc = f_1098_8386_8479(f_1098_8425_8440(lo), line, fieldCellCount, fieldCellCount)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 8556, 8622);

                string
                padding = f_1098_8573_8621(_propertyLabelsDisplayLength)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 8693, 8698);

                    // display the string collection
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 8684, 8985) || true) && (k < f_1098_8704_8712(sc))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 8714, 8717)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 8684, 8985))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 8684, 8985);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 8751, 8970) || true) && (k == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 8751, 8970);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 8803, 8839);

                            f_1098_8803_8838(lo, prependString + f_1098_8832_8837(sc, k));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 8751, 8970);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1098, 8751, 8970);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 8921, 8951);

                            f_1098_8921_8950(lo, padding + f_1098_8944_8949(sc, k));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1098, 8751, 8970);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1098, 1, 302);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1098, 1, 302);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1098, 7985, 8996);

                Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                f_1098_8425_8440(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.DisplayCells;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 8425, 8440);
                    return return_v;
                }


                System.Collections.Specialized.StringCollection
                f_1098_8386_8479(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                displayCells, string
                val, int
                firstLineLen, int
                followingLinesLen)
                {
                    var return_v = StringManipulationHelper.GenerateLines(displayCells, val, firstLineLen, followingLinesLen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 8386, 8479);
                    return return_v;
                }


                string
                f_1098_8573_8621(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 8573, 8621);
                    return return_v;
                }


                int
                f_1098_8704_8712(System.Collections.Specialized.StringCollection
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 8704, 8712);
                    return return_v;
                }


                string
                f_1098_8832_8837(System.Collections.Specialized.StringCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 8832, 8837);
                    return return_v;
                }


                int
                f_1098_8803_8838(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, string
                s)
                {
                    this_param.WriteLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 8803, 8838);
                    return 0;
                }


                string
                f_1098_8944_8949(System.Collections.Specialized.StringCollection
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1098, 8944, 8949);
                    return return_v;
                }


                int
                f_1098_8921_8950(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, string
                s)
                {
                    this_param.WriteLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1098, 8921, 8950);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1098, 7985, 8996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1098, 7985, 8996);
            }
        }

        private bool _disabled;

        private const string
        Separator = " : "
        ;

        private const int
        MinLabelWidth = 1
        ;

        private const int
        MinFieldWidth = 1
        ;

        public ListWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1098, 433, 9538);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 614, 629);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 787, 819);
            this._propertyLabelsDisplayLength = 0;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 932, 948);
            this._columnWidth = 0;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 9158, 9175);
            this._disabled = false;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1098, 433, 9538);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1098, 433, 9538);
        }


        static ListWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1098, 433, 9538);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 9209, 9226);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 9361, 9378);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1098, 9513, 9530);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1098, 433, 9538);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1098, 433, 9538);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1098, 433, 9538);
    }
}
