// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.Globalization;
using System.Management.Automation.Internal;
using System.Text;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class ComplexWriter
    {
        internal void Initialize(LineOutput lineOutput, int numberOfTextColumns)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 835, 1009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 932, 949);

                _lo = lineOutput;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 963, 998);

                _textColumns = numberOfTextColumns;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 835, 1009);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 835, 1009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 835, 1009);
            }
        }

        internal void WriteString(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 1136, 1298);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 1196, 1224);

                f_1085_1196_1223(_indentationManager);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 1240, 1255);

                f_1085_1240_1254(this, s);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 1271, 1287);

                f_1085_1271_1286(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 1136, 1298);

                int
                f_1085_1196_1223(Microsoft.PowerShell.Commands.Internal.Format.IndentationManager
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 1196, 1223);
                    return 0;
                }


                int
                f_1085_1240_1254(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param, string
                s)
                {
                    this_param.AddToBuffer(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 1240, 1254);
                    return 0;
                }


                int
                f_1085_1271_1286(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param)
                {
                    this_param.WriteToScreen();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 1271, 1286);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 1136, 1298);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 1136, 1298);
            }
        }

        internal void WriteObject(List<FormatValue> formatValueList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 1522, 2093);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 1659, 1687);

                f_1085_1659_1686(            // we always start with no indentation
                            _indentationManager);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 1703, 1966);
                    foreach (FormatEntry fe in f_1085_1730_1745_I(formatValueList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 1703, 1966);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 1917, 1951);

                        f_1085_1917_1950(this, fe, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 1703, 1966);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1085, 1, 264);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1085, 1, 264);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 2066, 2082);

                f_1085_2066_2081(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 1522, 2093);

                int
                f_1085_1659_1686(Microsoft.PowerShell.Commands.Internal.Format.IndentationManager
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 1659, 1686);
                    return 0;
                }


                int
                f_1085_1917_1950(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                fe, int
                currentDepth)
                {
                    this_param.GenerateFormatEntryDisplay(fe, currentDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 1917, 1950);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                f_1085_1730_1745_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 1730, 1745);
                    return return_v;
                }


                int
                f_1085_2066_2081(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param)
                {
                    this_param.WriteToScreen();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 2066, 2081);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 1522, 2093);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 1522, 2093);
            }
        }

        private void GenerateFormatEntryDisplay(FormatEntry fe, int currentDepth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 2324, 4094);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 2422, 4083);
                    foreach (object obj in f_1085_2445_2463_I(fe.formatValueList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 2422, 4083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 2497, 2538);

                        FormatEntry
                        feChild = obj as FormatEntry
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 2556, 3491) || true) && (feChild != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 2556, 3491);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 2617, 3439) || true) && (currentDepth < maxRecursionDepth)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 2617, 3439);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 2703, 3416) || true) && (feChild.frameInfo != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 2703, 3416);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 2928, 3135);
                                    using (f_1085_2935_2984(_indentationManager, feChild.frameInfo))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 3050, 3104);

                                        f_1085_3050_3103(this, feChild, currentDepth + 1);
                                        DynAbs.Tracing.TraceSender.TraceExitUsing(1085, 2928, 3135);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 2703, 3416);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 2703, 3416);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 3335, 3389);

                                    f_1085_3335_3388(this, feChild, currentDepth + 1);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 2703, 3416);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 2617, 3439);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 3463, 3472);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 2556, 3491);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 3511, 3648) || true) && (obj is FormatNewLine)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 3511, 3648);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 3577, 3598);

                            f_1085_3577_3597(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 3620, 3629);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 3511, 3648);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 3668, 3713);

                        FormatTextField
                        ftf = obj as FormatTextField
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 3731, 3865) || true) && (ftf != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 3731, 3865);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 3788, 3815);

                            f_1085_3788_3814(this, ftf.text);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 3837, 3846);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 3731, 3865);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 3885, 3938);

                        FormatPropertyField
                        fpf = obj as FormatPropertyField
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 3956, 4068) || true) && (fpf != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 3956, 4068);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 4013, 4049);

                            f_1085_4013_4048(this, fpf.propertyValue);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 3956, 4068);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 2422, 4083);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1085, 1, 1662);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1085, 1, 1662);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 2324, 4094);

                System.IDisposable
                f_1085_2935_2984(Microsoft.PowerShell.Commands.Internal.Format.IndentationManager
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FrameInfo
                frameInfo)
                {
                    var return_v = this_param.StackFrame(frameInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 2935, 2984);
                    return return_v;
                }


                int
                f_1085_3050_3103(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                fe, int
                currentDepth)
                {
                    this_param.GenerateFormatEntryDisplay(fe, currentDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 3050, 3103);
                    return 0;
                }


                int
                f_1085_3335_3388(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                fe, int
                currentDepth)
                {
                    this_param.GenerateFormatEntryDisplay(fe, currentDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 3335, 3388);
                    return 0;
                }


                int
                f_1085_3577_3597(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param)
                {
                    this_param.WriteToScreen();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 3577, 3597);
                    return 0;
                }


                int
                f_1085_3788_3814(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param, string
                s)
                {
                    this_param.AddToBuffer(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 3788, 3814);
                    return 0;
                }


                int
                f_1085_4013_4048(Microsoft.PowerShell.Commands.Internal.Format.ComplexWriter
                this_param, string
                s)
                {
                    this_param.AddToBuffer(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 4013, 4048);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                f_1085_2445_2463_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 2445, 2463);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 2324, 4094);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 2324, 4094);
            }
        }

        private void AddToBuffer(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 4292, 4386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 4351, 4375);

                f_1085_4351_4374(_stringBuffer, s);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 4292, 4386);

                System.Text.StringBuilder
                f_1085_4351_4374(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 4351, 4374);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 4292, 4386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 4292, 4386);
            }
        }

        private void WriteToScreen()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 4489, 7481);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 4542, 4600);

                int
                leftIndentation = f_1085_4564_4599(_indentationManager)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 4614, 4674);

                int
                rightIndentation = f_1085_4637_4673(_indentationManager)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 4688, 4756);

                int
                firstLineIndentation = f_1085_4715_4755(_indentationManager)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 4857, 4925);

                int
                usefulWidth = _textColumns - rightIndentation - leftIndentation
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 4939, 5170) || true) && (usefulWidth <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 4939, 5170);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 5119, 5155);

                    _stringBuffer = f_1085_5135_5154();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 4939, 5170);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 5267, 5372);

                int
                indentationAbsoluteValue = (DynAbs.Tracing.TraceSender.Conditional_F1(1085, 5298, 5324) || (((firstLineIndentation > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(1085, 5327, 5347)) || DynAbs.Tracing.TraceSender.Conditional_F3(1085, 5350, 5371))) ? firstLineIndentation : -firstLineIndentation
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 5386, 5557) || true) && (indentationAbsoluteValue >= usefulWidth)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 5386, 5557);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 5517, 5542);

                    firstLineIndentation = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 5386, 5557);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 5635, 5706);

                int
                firstLineWidth = _textColumns - rightIndentation - leftIndentation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 5720, 5761);

                int
                followingLinesWidth = firstLineWidth
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 5777, 6104) || true) && (firstLineIndentation >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 5777, 6104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 5894, 5933);

                    firstLineWidth -= firstLineIndentation;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 5777, 6104);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 5777, 6104);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 6045, 6089);

                    followingLinesWidth += firstLineIndentation;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 5777, 6104);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 6232, 6415);

                StringCollection
                sc = f_1085_6254_6414(f_1085_6293_6309(_lo), f_1085_6311_6335(_stringBuffer), firstLineWidth, followingLinesWidth)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 6463, 6502);

                int
                firstLinePadding = leftIndentation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 6516, 6560);

                int
                followingLinesPadding = leftIndentation
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 6574, 6905) || true) && (firstLineIndentation >= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 6574, 6905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 6691, 6732);

                    firstLinePadding += firstLineIndentation;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 6574, 6905);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 6574, 6905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 6844, 6890);

                    followingLinesPadding -= firstLineIndentation;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 6574, 6905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 6971, 6993);

                bool
                firstLine = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 7007, 7418);
                    foreach (string s in f_1085_7028_7030_I(sc))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 7007, 7418);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 7064, 7403) || true) && (firstLine)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 7064, 7403);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 7119, 7137);

                            firstLine = false;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 7159, 7228);

                            f_1085_7159_7227(_lo, f_1085_7173_7226(s, firstLinePadding));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 7064, 7403);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 7064, 7403);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 7310, 7384);

                            f_1085_7310_7383(_lo, f_1085_7324_7382(s, followingLinesPadding));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 7064, 7403);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 7007, 7418);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1085, 1, 412);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1085, 1, 412);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 7434, 7470);

                _stringBuffer = f_1085_7450_7469();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 4489, 7481);

                int
                f_1085_4564_4599(Microsoft.PowerShell.Commands.Internal.Format.IndentationManager
                this_param)
                {
                    var return_v = this_param.LeftIndentation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 4564, 4599);
                    return return_v;
                }


                int
                f_1085_4637_4673(Microsoft.PowerShell.Commands.Internal.Format.IndentationManager
                this_param)
                {
                    var return_v = this_param.RightIndentation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 4637, 4673);
                    return return_v;
                }


                int
                f_1085_4715_4755(Microsoft.PowerShell.Commands.Internal.Format.IndentationManager
                this_param)
                {
                    var return_v = this_param.FirstLineIndentation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 4715, 4755);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1085_5135_5154()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 5135, 5154);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                f_1085_6293_6309(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param)
                {
                    var return_v = this_param.DisplayCells;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 6293, 6309);
                    return return_v;
                }


                string
                f_1085_6311_6335(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 6311, 6335);
                    return return_v;
                }


                System.Collections.Specialized.StringCollection
                f_1085_6254_6414(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                displayCells, string
                val, int
                firstLineLen, int
                followingLinesLen)
                {
                    var return_v = StringManipulationHelper.GenerateLines(displayCells, val, firstLineLen, followingLinesLen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 6254, 6414);
                    return return_v;
                }


                string
                f_1085_7173_7226(string
                val, int
                count)
                {
                    var return_v = StringManipulationHelper.PadLeft(val, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 7173, 7226);
                    return return_v;
                }


                int
                f_1085_7159_7227(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, string
                s)
                {
                    this_param.WriteLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 7159, 7227);
                    return 0;
                }


                string
                f_1085_7324_7382(string
                val, int
                count)
                {
                    var return_v = StringManipulationHelper.PadLeft(val, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 7324, 7382);
                    return return_v;
                }


                int
                f_1085_7310_7383(Microsoft.PowerShell.Commands.Internal.Format.LineOutput
                this_param, string
                s)
                {
                    this_param.WriteLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 7310, 7383);
                    return 0;
                }


                System.Collections.Specialized.StringCollection
                f_1085_7028_7030_I(System.Collections.Specialized.StringCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 7028, 7030);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1085_7450_7469()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 7450, 7469);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 4489, 7481);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 4489, 7481);
            }
        }

        private IndentationManager _indentationManager;

        private StringBuilder _stringBuffer;

        private LineOutput _lo;

        private int _textColumns;

        private const int
        maxRecursionDepth = 50
        ;

        public ComplexWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1085, 487, 8187);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 7645, 7691);
            this._indentationManager = f_1085_7667_7691();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 7835, 7870);
            this._stringBuffer = f_1085_7851_7870();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 7985, 7988);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 8114, 8126);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1085, 487, 8187);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 487, 8187);
        }


        static ComplexWriter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1085, 487, 8187);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 8157, 8179);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1085, 487, 8187);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 487, 8187);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1085, 487, 8187);

        Microsoft.PowerShell.Commands.Internal.Format.IndentationManager
        f_1085_7667_7691()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.IndentationManager();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 7667, 7691);
            return return_v;
        }


        System.Text.StringBuilder
        f_1085_7851_7870()
        {
            var return_v = new System.Text.StringBuilder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 7851, 7870);
            return return_v;
        }

    }
    internal sealed class IndentationManager
    {
        private sealed class IndentationStackFrame : IDisposable
        {
            internal IndentationStackFrame(IndentationManager mgr)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1085, 8333, 8446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 8675, 8679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 8420, 8431);

                    _mgr = mgr;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1085, 8333, 8446);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 8333, 8446);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 8333, 8446);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 8462, 8632);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 8516, 8617) || true) && (_mgr != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 8516, 8617);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 8574, 8598);

                        f_1085_8574_8597(_mgr);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 8516, 8617);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 8462, 8632);

                    int
                    f_1085_8574_8597(Microsoft.PowerShell.Commands.Internal.Format.IndentationManager
                    this_param)
                    {
                        this_param.RemoveStackFrame();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 8574, 8597);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 8462, 8632);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 8462, 8632);
                }
            }

            private IndentationManager _mgr;

            static IndentationStackFrame()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1085, 8252, 8691);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1085, 8252, 8691);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 8252, 8691);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1085, 8252, 8691);
        }

        internal void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 8703, 8784);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 8749, 8773);

                f_1085_8749_8772(_frameInfoStack);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 8703, 8784);

                int
                f_1085_8749_8772(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FrameInfo>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 8749, 8772);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 8703, 8784);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 8703, 8784);
            }
        }

        internal IDisposable StackFrame(FrameInfo frameInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 8796, 9019);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 8873, 8935);

                IndentationStackFrame
                frame = f_1085_8903_8934(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 8949, 8981);

                f_1085_8949_8980(_frameInfoStack, frameInfo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 8995, 9008);

                return frame;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 8796, 9019);

                Microsoft.PowerShell.Commands.Internal.Format.IndentationManager.IndentationStackFrame
                f_1085_8903_8934(Microsoft.PowerShell.Commands.Internal.Format.IndentationManager
                mgr)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.IndentationManager.IndentationStackFrame(mgr);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 8903, 8934);
                    return return_v;
                }


                int
                f_1085_8949_8980(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FrameInfo>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FrameInfo
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 8949, 8980);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 8796, 9019);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 8796, 9019);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void RemoveStackFrame()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 9031, 9120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 9087, 9109);

                f_1085_9087_9108(_frameInfoStack);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 9031, 9120);

                Microsoft.PowerShell.Commands.Internal.Format.FrameInfo
                f_1085_9087_9108(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FrameInfo>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 9087, 9108);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 9031, 9120);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 9031, 9120);
            }
        }

        internal int RightIndentation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 9186, 9270);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 9222, 9255);

                    return f_1085_9229_9254(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 9186, 9270);

                    int
                    f_1085_9229_9254(Microsoft.PowerShell.Commands.Internal.Format.IndentationManager
                    this_param)
                    {
                        var return_v = this_param.ComputeRightIndentation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 9229, 9254);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 9132, 9281);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 9132, 9281);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int LeftIndentation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 9346, 9429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 9382, 9414);

                    return f_1085_9389_9413(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 9346, 9429);

                    int
                    f_1085_9389_9413(Microsoft.PowerShell.Commands.Internal.Format.IndentationManager
                    this_param)
                    {
                        var return_v = this_param.ComputeLeftIndentation();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 9389, 9413);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 9293, 9440);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 9293, 9440);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int FirstLineIndentation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 9510, 9681);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 9546, 9608) || true) && (f_1085_9550_9571(_frameInfoStack) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 9546, 9608);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 9599, 9608);

                        return 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 9546, 9608);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 9626, 9666);

                    return f_1085_9633_9655(_frameInfoStack).firstLine;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 9510, 9681);

                    int
                    f_1085_9550_9571(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FrameInfo>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 9550, 9571);
                        return return_v;
                    }


                    Microsoft.PowerShell.Commands.Internal.Format.FrameInfo
                    f_1085_9633_9655(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FrameInfo>
                    this_param)
                    {
                        var return_v = this_param.Peek();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 9633, 9655);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 9452, 9692);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 9452, 9692);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int ComputeRightIndentation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 9704, 9946);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 9766, 9778);

                int
                val = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 9792, 9908);
                    foreach (FrameInfo fi in f_1085_9817_9832_I(_frameInfoStack))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 9792, 9908);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 9866, 9893);

                        val += fi.rightIndentation;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 9792, 9908);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1085, 1, 117);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1085, 1, 117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 9924, 9935);

                return val;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 9704, 9946);

                System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FrameInfo>
                f_1085_9817_9832_I(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FrameInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 9817, 9832);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 9704, 9946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 9704, 9946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int ComputeLeftIndentation()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 9958, 10198);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 10019, 10031);

                int
                val = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 10045, 10160);
                    foreach (FrameInfo fi in f_1085_10070_10085_I(_frameInfoStack))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 10045, 10160);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 10119, 10145);

                        val += fi.leftIndentation;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 10045, 10160);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1085, 1, 116);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1085, 1, 116);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 10176, 10187);

                return val;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 9958, 10198);

                System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FrameInfo>
                f_1085_10070_10085_I(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FrameInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 10070, 10085);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 9958, 10198);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 9958, 10198);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Stack<FrameInfo> _frameInfoStack;

        public IndentationManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1085, 8195, 10283);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 10235, 10275);
            this._frameInfoStack = f_1085_10253_10275();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1085, 8195, 10283);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 8195, 10283);
        }


        static IndentationManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1085, 8195, 10283);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1085, 8195, 10283);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 8195, 10283);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1085, 8195, 10283);

        System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FrameInfo>
        f_1085_10253_10275()
        {
            var return_v = new System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.FrameInfo>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 10253, 10275);
            return return_v;
        }

    }

    internal struct GetWordsResult
    {

        internal string Word;

        internal string Delim;
        static GetWordsResult()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1085, 10359, 10466);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1085, 10359, 10466);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 10359, 10466);
        }
    }
    internal sealed class StringManipulationHelper
    {
        private static readonly char s_softHyphen;

        private static readonly char s_hardHyphen;

        private static readonly char s_nonBreakingSpace;

        private static Collection<string> s_cultureCollection;

        static StringManipulationHelper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1085, 10927, 11355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 10668, 10691);
                s_softHyphen = '\u00AD';
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 10731, 10754);
                s_hardHyphen = '\u2011';
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 10794, 10823);
                s_nonBreakingSpace = '\u00A0';
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 10868, 10914);
                s_cultureCollection = f_1085_10890_10914();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 25458, 25493);
                s_newLineChar = new char[] { '\n' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 25535, 25579);
                s_lineBreakChars = new char[] { '\n', '\r' };
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 10985, 11015);

                f_1085_10985_11014(s_cultureCollection, "en");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 11047, 11077);

                f_1085_11047_11076(s_cultureCollection, "fr");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 11108, 11138);

                f_1085_11108_11137(s_cultureCollection, "de");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 11169, 11199);

                f_1085_11169_11198(s_cultureCollection, "it");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 11231, 11261);

                f_1085_11231_11260(s_cultureCollection, "pt");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 11296, 11326);

                f_1085_11296_11325(s_cultureCollection, "es");
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1085, 10927, 11355);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 10927, 11355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 10927, 11355);
            }
        }

        private static IEnumerable<GetWordsResult> GetWords(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1085, 11699, 13052);

                var listYield = new List<GetWordsResult>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 11785, 11824);

                StringBuilder
                sb = f_1085_11804_11823()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 11838, 11883);

                GetWordsResult
                result = f_1085_11862_11882()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 11908, 11913);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 11899, 12919) || true) && (i < f_1085_11919_11927(s))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 11929, 11932)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 11899, 12919))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 11899, 12919);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 12102, 12904) || true) && (f_1085_12106_12110(s, i) == ' ' || (DynAbs.Tracing.TraceSender.Expression_False(1085, 12106, 12133) || f_1085_12121_12125(s, i) == '\t') || (DynAbs.Tracing.TraceSender.Expression_False(1085, 12106, 12157) || f_1085_12137_12141(s, i) == s_softHyphen))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 12102, 12904);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 12199, 12227);

                            result.Word = f_1085_12213_12226(sb);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 12249, 12260);

                            f_1085_12249_12259(sb);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 12282, 12317);

                            result.Delim = f_1085_12297_12316(f_1085_12308_12312(s, i), 1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 12341, 12361);

                            listYield.Add(result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 12102, 12904);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 12102, 12904);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 12536, 12904) || true) && (f_1085_12540_12544(s, i) == s_hardHyphen || (DynAbs.Tracing.TraceSender.Expression_False(1085, 12540, 12590) || f_1085_12564_12568(s, i) == s_nonBreakingSpace))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 12536, 12904);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 12632, 12660);

                                result.Word = f_1085_12646_12659(sb);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 12682, 12693);

                                f_1085_12682_12692(sb);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 12715, 12743);

                                result.Delim = string.Empty;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 12767, 12787);

                                listYield.Add(result);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 12536, 12904);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 12536, 12904);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 12869, 12885);

                                f_1085_12869_12884(sb, f_1085_12879_12883(s, i));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 12536, 12904);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 12102, 12904);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1085, 1, 1021);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1085, 1, 1021);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 12935, 12963);

                result.Word = f_1085_12949_12962(sb);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 12977, 13005);

                result.Delim = string.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 13021, 13041);

                listYield.Add(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1085, 11699, 13052);

                return listYield;

                System.Text.StringBuilder
                f_1085_11804_11823()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 11804, 11823);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.GetWordsResult
                f_1085_11862_11882()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.GetWordsResult();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 11862, 11882);
                    return return_v;
                }


                int
                f_1085_11919_11927(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 11919, 11927);
                    return return_v;
                }


                char
                f_1085_12106_12110(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 12106, 12110);
                    return return_v;
                }


                char
                f_1085_12121_12125(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 12121, 12125);
                    return return_v;
                }


                char
                f_1085_12137_12141(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 12137, 12141);
                    return return_v;
                }


                string
                f_1085_12213_12226(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 12213, 12226);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1085_12249_12259(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 12249, 12259);
                    return return_v;
                }


                char
                f_1085_12308_12312(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 12308, 12312);
                    return return_v;
                }


                string
                f_1085_12297_12316(char
                c, int
                count)
                {
                    var return_v = new string(c, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 12297, 12316);
                    return return_v;
                }


                char
                f_1085_12540_12544(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 12540, 12544);
                    return return_v;
                }


                char
                f_1085_12564_12568(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 12564, 12568);
                    return return_v;
                }


                string
                f_1085_12646_12659(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 12646, 12659);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1085_12682_12692(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 12682, 12692);
                    return return_v;
                }


                char
                f_1085_12879_12883(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 12879, 12883);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1085_12869_12884(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 12869, 12884);
                    return return_v;
                }


                string
                f_1085_12949_12962(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 12949, 12962);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 11699, 13052);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 11699, 13052);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static StringCollection GenerateLines(DisplayCells displayCells, string val, int firstLineLen, int followingLinesLen)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1085, 13064, 13599);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 13215, 13588) || true) && (f_1085_13219_13300(s_cultureCollection, f_1085_13248_13299(f_1085_13248_13274())))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 13215, 13588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 13334, 13419);

                    return f_1085_13341_13418(displayCells, val, firstLineLen, followingLinesLen);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 13215, 13588);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 13215, 13588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 13485, 13573);

                    return f_1085_13492_13572(displayCells, val, firstLineLen, followingLinesLen);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 13215, 13588);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1085, 13064, 13599);

                System.Globalization.CultureInfo
                f_1085_13248_13274()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 13248, 13274);
                    return return_v;
                }


                string
                f_1085_13248_13299(System.Globalization.CultureInfo
                this_param)
                {
                    var return_v = this_param.TwoLetterISOLanguageName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 13248, 13299);
                    return return_v;
                }


                bool
                f_1085_13219_13300(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 13219, 13300);
                    return return_v;
                }


                System.Collections.Specialized.StringCollection
                f_1085_13341_13418(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                displayCells, string
                val, int
                firstLineLen, int
                followingLinesLen)
                {
                    var return_v = GenerateLinesWithWordWrap(displayCells, val, firstLineLen, followingLinesLen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 13341, 13418);
                    return return_v;
                }


                System.Collections.Specialized.StringCollection
                f_1085_13492_13572(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                displayCells, string
                val, int
                firstLineLen, int
                followingLinesLen)
                {
                    var return_v = GenerateLinesWithoutWordWrap(displayCells, val, firstLineLen, followingLinesLen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 13492, 13572);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 13064, 13599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 13064, 13599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static StringCollection GenerateLinesWithoutWordWrap(DisplayCells displayCells, string val, int firstLineLen, int followingLinesLen)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1085, 13611, 17196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 13776, 13825);

                StringCollection
                retVal = f_1085_13802_13824()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 13841, 14030) || true) && (f_1085_13845_13870(val))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 13841, 14030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 13967, 13983);

                    f_1085_13967_13982(                // if null or empty, just add and we are done
                                    retVal, val);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 14001, 14015);

                    return retVal;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 13841, 14030);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 14120, 14153);

                string[]
                lines = f_1085_14137_14152(val)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 14178, 14183);

                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 14169, 17155) || true) && (k < f_1085_14189_14201(lines))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 14203, 14206)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 14169, 17155))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 14169, 17155);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 14240, 14488) || true) && (lines[k] == null || (DynAbs.Tracing.TraceSender.Expression_False(1085, 14244, 14309) || f_1085_14264_14293(displayCells, lines[k]) <= firstLineLen))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 14240, 14488);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 14417, 14438);

                            f_1085_14417_14437(                    // we do not need to split further, just add
                                                retVal, lines[k]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 14460, 14469);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 14240, 14488);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 14814, 14917);

                        SplitLinesAccumulator
                        accumulator = f_1085_14850_14916(retVal, firstLineLen, followingLinesLen)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 14937, 14952);

                        int
                        offset = 0
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 15013, 17140) || true) && (true)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 15013, 17140);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 15169, 15215);

                                int
                                currentDisplayLen = f_1085_15193_15214(accumulator)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 15407, 15469);

                                int
                                currentCellsToFit = f_1085_15431_15468(displayCells, lines[k], offset)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 15551, 15607);

                                int
                                excessCells = currentCellsToFit - currentDisplayLen
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 15631, 17121) || true) && (excessCells > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 15631, 17121);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 15860, 15951);

                                    int
                                    charactersToAdd = f_1085_15882_15950(displayCells, lines[k], offset, currentDisplayLen)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 15979, 16711) || true) && (charactersToAdd <= 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 15979, 16711);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 16351, 16371);

                                        charactersToAdd = 1;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 16401, 16426);

                                        f_1085_16401_16425(accumulator, "?");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 15979, 16711);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 15979, 16711);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 16619, 16684);

                                        f_1085_16619_16683(                            // of the given length, add it to the accumulator
                                                                    accumulator, f_1085_16639_16682(lines[k], offset, charactersToAdd));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 15979, 16711);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 16816, 16842);

                                    offset += charactersToAdd;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 15631, 17121);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 15631, 17121);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 17018, 17066);

                                    f_1085_17018_17065(                        // we reached the last (partial) line, we add it all
                                                            accumulator, f_1085_17038_17064(lines[k], offset));
                                    DynAbs.Tracing.TraceSender.TraceBreak(1085, 17092, 17098);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 15631, 17121);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 15013, 17140);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1085, 15013, 17140);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1085, 15013, 17140);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1085, 1, 2987);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1085, 1, 2987);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 17171, 17185);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1085, 13611, 17196);

                System.Collections.Specialized.StringCollection
                f_1085_13802_13824()
                {
                    var return_v = new System.Collections.Specialized.StringCollection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 13802, 13824);
                    return return_v;
                }


                bool
                f_1085_13845_13870(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 13845, 13870);
                    return return_v;
                }


                int
                f_1085_13967_13982(System.Collections.Specialized.StringCollection
                this_param, string
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 13967, 13982);
                    return return_v;
                }


                string[]
                f_1085_14137_14152(string
                s)
                {
                    var return_v = SplitLines(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 14137, 14152);
                    return return_v;
                }


                int
                f_1085_14189_14201(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 14189, 14201);
                    return return_v;
                }


                int
                f_1085_14264_14293(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 14264, 14293);
                    return return_v;
                }


                int
                f_1085_14417_14437(System.Collections.Specialized.StringCollection
                this_param, string
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 14417, 14437);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.StringManipulationHelper.SplitLinesAccumulator
                f_1085_14850_14916(System.Collections.Specialized.StringCollection
                retVal, int
                firstLineLen, int
                followingLinesLen)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.StringManipulationHelper.SplitLinesAccumulator(retVal, firstLineLen, followingLinesLen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 14850, 14916);
                    return return_v;
                }


                int
                f_1085_15193_15214(Microsoft.PowerShell.Commands.Internal.Format.StringManipulationHelper.SplitLinesAccumulator
                this_param)
                {
                    var return_v = this_param.ActiveLen;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 15193, 15214);
                    return return_v;
                }


                int
                f_1085_15431_15468(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str, int
                offset)
                {
                    var return_v = this_param.Length(str, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 15431, 15468);
                    return return_v;
                }


                int
                f_1085_15882_15950(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str, int
                offset, int
                displayCells)
                {
                    var return_v = this_param.GetHeadSplitLength(str, offset, displayCells);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 15882, 15950);
                    return return_v;
                }


                int
                f_1085_16401_16425(Microsoft.PowerShell.Commands.Internal.Format.StringManipulationHelper.SplitLinesAccumulator
                this_param, string
                s)
                {
                    this_param.AddLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 16401, 16425);
                    return 0;
                }


                string
                f_1085_16639_16682(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 16639, 16682);
                    return return_v;
                }


                int
                f_1085_16619_16683(Microsoft.PowerShell.Commands.Internal.Format.StringManipulationHelper.SplitLinesAccumulator
                this_param, string
                s)
                {
                    this_param.AddLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 16619, 16683);
                    return 0;
                }


                string
                f_1085_17038_17064(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 17038, 17064);
                    return return_v;
                }


                int
                f_1085_17018_17065(Microsoft.PowerShell.Commands.Internal.Format.StringManipulationHelper.SplitLinesAccumulator
                this_param, string
                s)
                {
                    this_param.AddLine(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 17018, 17065);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 13611, 17196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 13611, 17196);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private sealed class SplitLinesAccumulator
        {
            internal SplitLinesAccumulator(StringCollection retVal, int firstLineLen, int followingLinesLen)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1085, 17275, 17540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 18079, 18086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 18114, 18129);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 18156, 18169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 18196, 18214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 17404, 17421);

                    _retVal = retVal;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 17439, 17468);

                    _firstLineLen = firstLineLen;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 17486, 17525);

                    _followingLinesLen = followingLinesLen;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1085, 17275, 17540);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 17275, 17540);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 17275, 17540);
                }
            }

            internal void AddLine(string s)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 17556, 17774);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 17620, 17724) || true) && (!_addedFirstLine)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 17620, 17724);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 17682, 17705);

                        _addedFirstLine = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 17620, 17724);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 17744, 17759);

                    f_1085_17744_17758(
                                    _retVal, s);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 17556, 17774);

                    int
                    f_1085_17744_17758(System.Collections.Specialized.StringCollection
                    this_param, string
                    value)
                    {
                        var return_v = this_param.Add(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 17744, 17758);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 17556, 17774);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 17556, 17774);
                }
            }

            internal int ActiveLen
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1085, 17845, 18023);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 17889, 17961) || true) && (_addedFirstLine)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 17889, 17961);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 17935, 17961);

                            return _followingLinesLen;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 17889, 17961);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 17983, 18004);

                        return _firstLineLen;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1085, 17845, 18023);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 17790, 18038);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 17790, 18038);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
            }

            private StringCollection _retVal;

            private bool _addedFirstLine;

            private int _firstLineLen;

            private int _followingLinesLen;

            static SplitLinesAccumulator()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1085, 17208, 18226);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1085, 17208, 18226);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 17208, 18226);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1085, 17208, 18226);
        }

        private static StringCollection GenerateLinesWithWordWrap(DisplayCells displayCells, string val, int firstLineLen, int followingLinesLen)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1085, 18238, 23493);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 18400, 18449);

                StringCollection
                retVal = f_1085_18426_18448()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 18465, 18654) || true) && (f_1085_18469_18494(val))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 18465, 18654);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 18591, 18607);

                    f_1085_18591_18606(                // if null or empty, just add and we are done
                                    retVal, val);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 18625, 18639);

                    return retVal;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 18465, 18654);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 18744, 18777);

                string[]
                lines = f_1085_18761_18776(val)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 18802, 18807);

                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 18793, 23452) || true) && (k < f_1085_18813_18825(lines))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 18827, 18830)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 18793, 23452))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 18793, 23452);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 18864, 19112) || true) && (lines[k] == null || (DynAbs.Tracing.TraceSender.Expression_False(1085, 18868, 18933) || f_1085_18888_18917(displayCells, lines[k]) <= firstLineLen))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 18864, 19112);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 19041, 19062);

                            f_1085_19041_19061(                    // we do not need to split further, just add
                                                retVal, lines[k]);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 19084, 19093);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 18864, 19112);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 19132, 19162);

                        int
                        spacesLeft = firstLineLen
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 19180, 19209);

                        int
                        lineWidth = firstLineLen
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 19227, 19249);

                        bool
                        firstLine = true
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 19267, 19314);

                        StringBuilder
                        singleLine = f_1085_19294_19313()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 19334, 23383);
                            foreach (GetWordsResult word in f_1085_19366_19384_I(f_1085_19366_19384(lines[k])))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 19334, 23383);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 19426, 19455);

                                string
                                wordToAdd = word.Word
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 19522, 20208) || true) && (word.Delim == f_1085_19540_19563(s_softHyphen))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 19522, 20208);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 19613, 19717);

                                    int
                                    wordWidthWithHyphen = f_1085_19639_19669(displayCells, wordToAdd) + f_1085_19672_19716(displayCells, f_1085_19692_19715(s_softHyphen))
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 19802, 19941) || true) && (wordWidthWithHyphen == spacesLeft)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 19802, 19941);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 19897, 19914);

                                        wordToAdd += "-";
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 19802, 19941);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 19522, 20208);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 19522, 20208);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 20039, 20185) || true) && (!f_1085_20044_20076(word.Delim))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 20039, 20185);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 20134, 20158);

                                        wordToAdd += word.Delim;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 20039, 20185);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 19522, 20208);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 20232, 20279);

                                int
                                wordWidth = f_1085_20248_20278(displayCells, wordToAdd)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 20345, 20800) || true) && (lineWidth == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 20345, 20800);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 20413, 20589) || true) && (firstLine)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 20413, 20589);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 20484, 20502);

                                        firstLine = false;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 20532, 20562);

                                        lineWidth = followingLinesLen;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 20413, 20589);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 20617, 20726) || true) && (lineWidth == 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 20617, 20726);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1085, 20693, 20699);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 20617, 20726);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 20754, 20777);

                                    spacesLeft = lineWidth;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 20345, 20800);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 20881, 23364) || true) && (wordWidth > lineWidth)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 20881, 23364);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 20956, 22502);
                                        foreach (char c in f_1085_20975_20984_I(wordToAdd))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 20956, 22502);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 21042, 21061);

                                            char
                                            charToAdd = c
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 21091, 21130);

                                            int
                                            charWidth = f_1085_21107_21129(displayCells, c)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 21452, 21638) || true) && (charWidth > lineWidth)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 21452, 21638);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 21543, 21559);

                                                charToAdd = '?';
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 21593, 21607);

                                                charWidth = 1;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 21452, 21638);
                                            }

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 21670, 22475) || true) && (charWidth > spacesLeft)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 21670, 22475);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 21762, 21796);

                                                f_1085_21762_21795(retVal, f_1085_21773_21794(singleLine));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 21830, 21849);

                                                f_1085_21830_21848(singleLine);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 21883, 21912);

                                                f_1085_21883_21911(singleLine, charToAdd);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 21948, 22156) || true) && (firstLine)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 21948, 22156);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 22035, 22053);

                                                    firstLine = false;
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 22091, 22121);

                                                    lineWidth = followingLinesLen;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 21948, 22156);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 22192, 22227);

                                                spacesLeft = lineWidth - charWidth;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 21670, 22475);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 21670, 22475);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 22357, 22386);

                                                f_1085_22357_22385(singleLine, charToAdd);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 22420, 22444);

                                                spacesLeft -= charWidth;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 21670, 22475);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 20956, 22502);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1085, 1, 1547);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1085, 1, 1547);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 20881, 23364);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 20881, 23364);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 22600, 23341) || true) && (wordWidth > spacesLeft)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 22600, 23341);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 22684, 22718);

                                        f_1085_22684_22717(retVal, f_1085_22695_22716(singleLine));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 22748, 22767);

                                        f_1085_22748_22766(singleLine);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 22797, 22826);

                                        f_1085_22797_22825(singleLine, wordToAdd);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 22858, 23050) || true) && (firstLine)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 22858, 23050);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 22937, 22955);

                                            firstLine = false;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 22989, 23019);

                                            lineWidth = followingLinesLen;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 22858, 23050);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 23082, 23117);

                                        spacesLeft = lineWidth - wordWidth;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 22600, 23341);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 22600, 23341);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 23231, 23260);

                                        f_1085_23231_23259(singleLine, wordToAdd);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 23290, 23314);

                                        spacesLeft -= wordWidth;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 22600, 23341);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 20881, 23364);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 19334, 23383);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1085, 1, 4050);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1085, 1, 4050);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 23403, 23437);

                        f_1085_23403_23436(
                                        retVal, f_1085_23414_23435(singleLine));
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1085, 1, 4660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1085, 1, 4660);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 23468, 23482);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1085, 18238, 23493);

                System.Collections.Specialized.StringCollection
                f_1085_18426_18448()
                {
                    var return_v = new System.Collections.Specialized.StringCollection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 18426, 18448);
                    return return_v;
                }


                bool
                f_1085_18469_18494(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 18469, 18494);
                    return return_v;
                }


                int
                f_1085_18591_18606(System.Collections.Specialized.StringCollection
                this_param, string
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 18591, 18606);
                    return return_v;
                }


                string[]
                f_1085_18761_18776(string
                s)
                {
                    var return_v = SplitLines(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 18761, 18776);
                    return return_v;
                }


                int
                f_1085_18813_18825(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1085, 18813, 18825);
                    return return_v;
                }


                int
                f_1085_18888_18917(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 18888, 18917);
                    return return_v;
                }


                int
                f_1085_19041_19061(System.Collections.Specialized.StringCollection
                this_param, string
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 19041, 19061);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1085_19294_19313()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 19294, 19313);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.Internal.Format.GetWordsResult>
                f_1085_19366_19384(string
                s)
                {
                    var return_v = GetWords(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 19366, 19384);
                    return return_v;
                }


                string
                f_1085_19540_19563(char
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 19540, 19563);
                    return return_v;
                }


                int
                f_1085_19639_19669(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 19639, 19669);
                    return return_v;
                }


                string
                f_1085_19692_19715(char
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 19692, 19715);
                    return return_v;
                }


                int
                f_1085_19672_19716(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 19672, 19716);
                    return return_v;
                }


                bool
                f_1085_20044_20076(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 20044, 20076);
                    return return_v;
                }


                int
                f_1085_20248_20278(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, string
                str)
                {
                    var return_v = this_param.Length(str);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 20248, 20278);
                    return return_v;
                }


                int
                f_1085_21107_21129(Microsoft.PowerShell.Commands.Internal.Format.DisplayCells
                this_param, char
                character)
                {
                    var return_v = this_param.Length(character);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 21107, 21129);
                    return return_v;
                }


                string
                f_1085_21773_21794(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 21773, 21794);
                    return return_v;
                }


                int
                f_1085_21762_21795(System.Collections.Specialized.StringCollection
                this_param, string
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 21762, 21795);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1085_21830_21848(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 21830, 21848);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1085_21883_21911(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 21883, 21911);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1085_22357_22385(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 22357, 22385);
                    return return_v;
                }


                string
                f_1085_20975_20984_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 20975, 20984);
                    return return_v;
                }


                string
                f_1085_22695_22716(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 22695, 22716);
                    return return_v;
                }


                int
                f_1085_22684_22717(System.Collections.Specialized.StringCollection
                this_param, string
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 22684, 22717);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1085_22748_22766(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 22748, 22766);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1085_22797_22825(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 22797, 22825);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1085_23231_23259(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 23231, 23259);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.Internal.Format.GetWordsResult>
                f_1085_19366_19384_I(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.Internal.Format.GetWordsResult>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 19366, 19384);
                    return return_v;
                }


                string
                f_1085_23414_23435(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 23414, 23435);
                    return return_v;
                }


                int
                f_1085_23403_23436(System.Collections.Specialized.StringCollection
                this_param, string
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 23403, 23436);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 18238, 23493);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 18238, 23493);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string[] SplitLines(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1085, 23774, 24175);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 23844, 23917) || true) && (f_1085_23848_23871(s))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 23844, 23917);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 23890, 23917);

                    return new string[1] { s };
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 23844, 23917);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 23933, 23972);

                StringBuilder
                sb = f_1085_23952_23971()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 23988, 24106);
                    foreach (char c in f_1085_24007_24008_I(s))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 23988, 24106);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 24042, 24091) || true) && (c != '\r')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 24042, 24091);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 24078, 24091);

                            f_1085_24078_24090(sb, c);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 24042, 24091);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 23988, 24106);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1085, 1, 119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1085, 1, 119);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 24122, 24164);

                return f_1085_24129_24163(f_1085_24129_24142(sb), s_newLineChar);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1085, 23774, 24175);

                bool
                f_1085_23848_23871(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 23848, 23871);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1085_23952_23971()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 23952, 23971);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1085_24078_24090(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 24078, 24090);
                    return return_v;
                }


                string
                f_1085_24007_24008_I(string
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 24007, 24008);
                    return return_v;
                }


                string
                f_1085_24129_24142(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 24129, 24142);
                    return return_v;
                }


                string[]
                f_1085_24129_24163(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 24129, 24163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 23774, 24175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 23774, 24175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string TruncateAtNewLine(string s)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1085, 24864, 25275);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 24939, 25035) || true) && (f_1085_24943_24966(s))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 24939, 25035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 25000, 25020);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 24939, 25035);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 25051, 25098);

                int
                lineBreak = f_1085_25067_25097(s, s_lineBreakChars)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 25114, 25189) || true) && (lineBreak < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1085, 25114, 25189);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 25165, 25174);

                    return s;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1085, 25114, 25189);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 25205, 25264);

                return f_1085_25212_25237(s, 0, lineBreak) + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (PSObjectHelper.Ellipsis).ToString(), 1085, 25240, 25263);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1085, 24864, 25275);

                bool
                f_1085_24943_24966(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 24943, 24966);
                    return return_v;
                }


                int
                f_1085_25067_25097(string
                this_param, char[]
                anyOf)
                {
                    var return_v = this_param.IndexOfAny(anyOf);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 25067, 25097);
                    return return_v;
                }


                string
                f_1085_25212_25237(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 25212, 25237);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 24864, 25275);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 24864, 25275);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string PadLeft(string val, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1085, 25287, 25415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1085, 25365, 25404);

                return f_1085_25372_25397(count) + val;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1085, 25287, 25415);

                string
                f_1085_25372_25397(int
                countOfSpaces)
                {
                    var return_v = StringUtil.Padding(countOfSpaces);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 25372, 25397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1085, 25287, 25415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 25287, 25415);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly char[] s_newLineChar;

        private static readonly char[] s_lineBreakChars;

        public StringManipulationHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1085, 10576, 25587);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1085, 10576, 25587);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1085, 10576, 25587);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1085, 10576, 25587);

        static System.Collections.ObjectModel.Collection<string>
        f_1085_10890_10914()
        {
            var return_v = new System.Collections.ObjectModel.Collection<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 10890, 10914);
            return return_v;
        }


        static int
        f_1085_10985_11014(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 10985, 11014);
            return 0;
        }


        static int
        f_1085_11047_11076(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 11047, 11076);
            return 0;
        }


        static int
        f_1085_11108_11137(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 11108, 11137);
            return 0;
        }


        static int
        f_1085_11169_11198(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 11169, 11198);
            return 0;
        }


        static int
        f_1085_11231_11260(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 11231, 11260);
            return 0;
        }


        static int
        f_1085_11296_11325(System.Collections.ObjectModel.Collection<string>
        this_param, string
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1085, 11296, 11325);
            return 0;
        }

    }
}

