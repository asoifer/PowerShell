// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Text;
using System.Management.Automation.Internal;

namespace System.Management.Automation.Language
{

    /// <summary>
    /// Represents a single point in a script.  The script may come from a file or interactive input.
    /// </summary>
    public interface IScriptPosition
    {

        string File { get; }

        int LineNumber { get; }

        int ColumnNumber { get; }

        int Offset { get; }

        string Line { get; }

        string GetFullScript();
    }

    /// <summary>
    /// Represents the a span of text in a script.
    /// </summary>
    public interface IScriptExtent
    {

        string File { get; }

        IScriptPosition StartScriptPosition { get; }

        IScriptPosition EndScriptPosition { get; }

        int StartLineNumber { get; }

        int StartColumnNumber { get; }

        int EndLineNumber { get; }

        int EndColumnNumber { get; }

        string Text { get; }

        int StartOffset { get; }

        int EndOffset { get; }
    }
    internal static class PositionUtilities
    {
        public static IScriptPosition EmptyPosition { get; }

        public static IScriptExtent EmptyExtent { get; }

        internal static string VerboseMessage(IScriptExtent position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1551, 4108, 9951);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 4194, 4313) || true) && (f_1551_4198_4244(f_1551_4198_4227(), position))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 4194, 4313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 4278, 4298);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 4194, 4313);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 4329, 4361);

                string
                fileName = f_1551_4347_4360(position)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 4375, 4499) || true) && (f_1551_4379_4409(fileName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 4375, 4499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 4443, 4484);

                    fileName = f_1551_4454_4483();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 4375, 4499);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 4515, 4579);

                string
                sourceLine = f_1551_4535_4578(f_1551_4535_4568(f_1551_4535_4563(position)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 4595, 4625);

                string
                message = string.Empty
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 4639, 9702) || true) && (!f_1551_4644_4676(sourceLine))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 4639, 9702);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 4710, 4765);

                    int
                    spacesBeforeError = f_1551_4734_4760(position) - 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 4783, 5094);

                    int
                    errorLength = (DynAbs.Tracing.TraceSender.Conditional_F1(1551, 4801, 4906) || (((f_1551_4802_4826(position) == f_1551_4830_4852(position) && (DynAbs.Tracing.TraceSender.Expression_True(1551, 4802, 4905) && f_1551_4856_4880(position) <= f_1551_4884_4901(sourceLine) + 1))
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1551, 4948, 5001)) || DynAbs.Tracing.TraceSender.Conditional_F3(1551, 5043, 5093))) ? f_1551_4948_4972(position) - f_1551_4975_5001(position) : f_1551_5043_5060(sourceLine) - f_1551_5063_5089(position) + 1
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 5198, 5945) || true) && (f_1551_5202_5226(sourceLine, '\t') != -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 5198, 5945);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 5274, 5330);

                        var
                        copyLine = f_1551_5289_5329(f_1551_5307_5324(sourceLine) * 2)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 5354, 5437);

                        var
                        beforeError = f_1551_5372_5436(f_1551_5372_5414(sourceLine, 0, spacesBeforeError), "\t", "    ")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 5459, 5546);

                        var
                        error = f_1551_5471_5545(f_1551_5471_5523(sourceLine, spacesBeforeError, errorLength), "\t", "    ")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 5570, 5599);

                        f_1551_5570_5598(
                                            copyLine, beforeError);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 5621, 5644);

                        f_1551_5621_5643(copyLine, error);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 5666, 5759);

                        f_1551_5666_5758(copyLine, f_1551_5682_5757(f_1551_5682_5735(sourceLine, spacesBeforeError + errorLength), "\t", "    "));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 5783, 5822);

                        spacesBeforeError = f_1551_5803_5821(beforeError);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 5844, 5871);

                        errorLength = f_1551_5858_5870(error);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 5893, 5926);

                        sourceLine = f_1551_5906_5925(copyLine);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 5198, 5945);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 6321, 6350);

                    const int
                    maxLineLength = 69
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 6368, 6397);

                    bool
                    needsPrefixDots = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 6415, 6444);

                    bool
                    needsSuffixDots = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 6464, 6499);

                    int
                    lineLength = f_1551_6481_6498(sourceLine)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 6517, 6571);

                    var
                    sb = f_1551_6526_6570(f_1551_6544_6561(sourceLine) * 2 + 4)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 6589, 8992) || true) && (lineLength > maxLineLength)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 6589, 8992);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 6815, 6851);

                        int
                        totalPrefix = spacesBeforeError
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 6873, 6912);

                        int
                        prefix = f_1551_6886_6911(totalPrefix, 12)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 6936, 6999);

                        int
                        totalSuffix = lineLength - errorLength - spacesBeforeError
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 7021, 7059);

                        int
                        suffix = f_1551_7034_7058(totalSuffix, 8)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 7083, 7135);

                        int
                        candidateLength = prefix + errorLength + suffix
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 7157, 8573) || true) && (candidateLength >= maxLineLength)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 7157, 8573);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 7456, 7619) || true) && (prefix + errorLength >= maxLineLength)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 7456, 7619);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 7555, 7592);

                                errorLength = maxLineLength - prefix;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 7456, 7619);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 7647, 7670);

                            needsSuffixDots = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 7157, 8573);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 7157, 8573);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 7925, 7968);

                            int
                            prefixAvailable = totalPrefix - prefix
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 7994, 8249) || true) && (prefixAvailable > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 7994, 8249);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 8075, 8144);

                                prefix += f_1551_8085_8143(prefixAvailable, maxLineLength - candidateLength);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 8174, 8222);

                                candidateLength = prefix + errorLength + suffix;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 7994, 8249);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 8277, 8481) || true) && (candidateLength < maxLineLength && (DynAbs.Tracing.TraceSender.Expression_True(1551, 8281, 8331) && totalSuffix > 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 8277, 8481);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 8389, 8454);

                                suffix += f_1551_8399_8453(totalSuffix, maxLineLength - candidateLength);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 8277, 8481);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 8509, 8550);

                            needsSuffixDots = (suffix < totalSuffix);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 7157, 8573);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 8597, 8638);

                        needsPrefixDots = (prefix < totalPrefix);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 8662, 8719);

                        var
                        startIndex = f_1551_8679_8718(spacesBeforeError - prefix, 0)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 8741, 8802);

                        sourceLine = f_1551_8754_8801(sourceLine, startIndex, maxLineLength);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 8824, 8880);

                        spacesBeforeError = f_1551_8844_8879(spacesBeforeError, prefix);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 8902, 8973);

                        errorLength = f_1551_8916_8972(errorLength, maxLineLength - spacesBeforeError);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 6589, 8992);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 9012, 9143) || true) && (needsPrefixDots)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 9012, 9143);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 9073, 9094);

                        f_1551_9073_9093(sb, "\u2026 ");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 9012, 9143);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 9163, 9185);

                    f_1551_9163_9184(
                                    sb, sourceLine);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 9205, 9336) || true) && (needsSuffixDots)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 9205, 9336);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 9266, 9287);

                        f_1551_9266_9286(sb, " \u2026");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 9205, 9336);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 9356, 9387);

                    f_1551_9356_9386(
                                    sb, f_1551_9366_9385());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 9405, 9421);

                    f_1551_9405_9420(sb, "+ ");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 9439, 9501);

                    f_1551_9439_9500(sb, ' ', spacesBeforeError + ((DynAbs.Tracing.TraceSender.Conditional_F1(1551, 9475, 9490) || ((needsPrefixDots && DynAbs.Tracing.TraceSender.Conditional_F2(1551, 9493, 9494)) || DynAbs.Tracing.TraceSender.Conditional_F3(1551, 9497, 9498))) ? 2 : 0));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 9593, 9643);

                    f_1551_9593_9642(                // errorLength of 0 happens at EOF - always write out 1.
                                    sb, '~', (DynAbs.Tracing.TraceSender.Conditional_F1(1551, 9608, 9623) || ((errorLength > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1551, 9626, 9637)) || DynAbs.Tracing.TraceSender.Conditional_F3(1551, 9640, 9641))) ? errorLength : 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 9663, 9687);

                    message = f_1551_9673_9686(sb);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 4639, 9702);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 9718, 9940);

                return f_1551_9725_9939(f_1551_9761_9797(), fileName, f_1551_9843_9867(position), f_1551_9886_9912(position), message);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1551, 4108, 9951);

                System.Management.Automation.Language.IScriptExtent
                f_1551_4198_4227()
                {
                    var return_v = PositionUtilities.EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 4198, 4227);
                    return return_v;
                }


                bool
                f_1551_4198_4244(System.Management.Automation.Language.IScriptExtent
                this_param, System.Management.Automation.Language.IScriptExtent
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 4198, 4244);
                    return return_v;
                }


                string
                f_1551_4347_4360(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 4347, 4360);
                    return return_v;
                }


                bool
                f_1551_4379_4409(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 4379, 4409);
                    return return_v;
                }


                string
                f_1551_4454_4483()
                {
                    var return_v = ParserStrings.TextForWordLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 4454, 4483);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1551_4535_4563(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 4535, 4563);
                    return return_v;
                }


                string
                f_1551_4535_4568(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 4535, 4568);
                    return return_v;
                }


                string
                f_1551_4535_4578(string
                this_param)
                {
                    var return_v = this_param.TrimEnd();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 4535, 4578);
                    return return_v;
                }


                bool
                f_1551_4644_4676(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 4644, 4676);
                    return return_v;
                }


                int
                f_1551_4734_4760(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 4734, 4760);
                    return return_v;
                }


                int
                f_1551_4802_4826(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 4802, 4826);
                    return return_v;
                }


                int
                f_1551_4830_4852(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 4830, 4852);
                    return return_v;
                }


                int
                f_1551_4856_4880(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 4856, 4880);
                    return return_v;
                }


                int
                f_1551_4884_4901(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 4884, 4901);
                    return return_v;
                }


                int
                f_1551_4948_4972(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 4948, 4972);
                    return return_v;
                }


                int
                f_1551_4975_5001(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 4975, 5001);
                    return return_v;
                }


                int
                f_1551_5043_5060(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 5043, 5060);
                    return return_v;
                }


                int
                f_1551_5063_5089(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 5063, 5089);
                    return return_v;
                }


                int
                f_1551_5202_5226(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 5202, 5226);
                    return return_v;
                }


                int
                f_1551_5307_5324(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 5307, 5324);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_5289_5329(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 5289, 5329);
                    return return_v;
                }


                string
                f_1551_5372_5414(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 5372, 5414);
                    return return_v;
                }


                string
                f_1551_5372_5436(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 5372, 5436);
                    return return_v;
                }


                string
                f_1551_5471_5523(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 5471, 5523);
                    return return_v;
                }


                string
                f_1551_5471_5545(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 5471, 5545);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_5570_5598(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 5570, 5598);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_5621_5643(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 5621, 5643);
                    return return_v;
                }


                string
                f_1551_5682_5735(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 5682, 5735);
                    return return_v;
                }


                string
                f_1551_5682_5757(string
                this_param, string
                oldValue, string
                newValue)
                {
                    var return_v = this_param.Replace(oldValue, newValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 5682, 5757);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_5666_5758(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 5666, 5758);
                    return return_v;
                }


                int
                f_1551_5803_5821(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 5803, 5821);
                    return return_v;
                }


                int
                f_1551_5858_5870(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 5858, 5870);
                    return return_v;
                }


                string
                f_1551_5906_5925(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 5906, 5925);
                    return return_v;
                }


                int
                f_1551_6481_6498(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 6481, 6498);
                    return return_v;
                }


                int
                f_1551_6544_6561(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 6544, 6561);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_6526_6570(int
                capacity)
                {
                    var return_v = new System.Text.StringBuilder(capacity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 6526, 6570);
                    return return_v;
                }


                int
                f_1551_6886_6911(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 6886, 6911);
                    return return_v;
                }


                int
                f_1551_7034_7058(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 7034, 7058);
                    return return_v;
                }


                int
                f_1551_8085_8143(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 8085, 8143);
                    return return_v;
                }


                int
                f_1551_8399_8453(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 8399, 8453);
                    return return_v;
                }


                int
                f_1551_8679_8718(int
                val1, int
                val2)
                {
                    var return_v = Math.Max(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 8679, 8718);
                    return return_v;
                }


                string
                f_1551_8754_8801(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 8754, 8801);
                    return return_v;
                }


                int
                f_1551_8844_8879(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 8844, 8879);
                    return return_v;
                }


                int
                f_1551_8916_8972(int
                val1, int
                val2)
                {
                    var return_v = Math.Min(val1, val2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 8916, 8972);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_9073_9093(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 9073, 9093);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_9163_9184(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 9163, 9184);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_9266_9286(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 9266, 9286);
                    return return_v;
                }


                string
                f_1551_9366_9385()
                {
                    var return_v = Environment.NewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 9366, 9385);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_9356_9386(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 9356, 9386);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_9405_9420(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 9405, 9420);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_9439_9500(System.Text.StringBuilder
                this_param, char
                value, int
                repeatCount)
                {
                    var return_v = this_param.Append(value, repeatCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 9439, 9500);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_9593_9642(System.Text.StringBuilder
                this_param, char
                value, int
                repeatCount)
                {
                    var return_v = this_param.Append(value, repeatCount);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 9593, 9642);
                    return return_v;
                }


                string
                f_1551_9673_9686(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 9673, 9686);
                    return return_v;
                }


                string
                f_1551_9761_9797()
                {
                    var return_v = ParserStrings.TextForPositionMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 9761, 9797);
                    return return_v;
                }


                int
                f_1551_9843_9867(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 9843, 9867);
                    return return_v;
                }


                int
                f_1551_9886_9912(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 9886, 9912);
                    return return_v;
                }


                string
                f_1551_9725_9939(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 9725, 9939);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 4108, 9951);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 4108, 9951);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string BriefMessage(IScriptPosition position)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1551, 10104, 10626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 10190, 10247);

                StringBuilder
                message = f_1551_10214_10246(f_1551_10232_10245(position))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 10261, 10495) || true) && (f_1551_10265_10286(position) > f_1551_10289_10303(message))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 10261, 10495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 10337, 10362);

                    f_1551_10337_10361(message, " <<<< ");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 10261, 10495);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 10261, 10495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 10428, 10480);

                    f_1551_10428_10479(message, f_1551_10443_10464(position) - 1, " >>>> ");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 10261, 10495);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 10511, 10615);

                return f_1551_10518_10614(f_1551_10536_10572(), f_1551_10574_10593(position), f_1551_10595_10613(message));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1551, 10104, 10626);

                string
                f_1551_10232_10245(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 10232, 10245);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_10214_10246(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 10214, 10246);
                    return return_v;
                }


                int
                f_1551_10265_10286(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.ColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 10265, 10286);
                    return return_v;
                }


                int
                f_1551_10289_10303(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 10289, 10303);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_10337_10361(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 10337, 10361);
                    return return_v;
                }


                int
                f_1551_10443_10464(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.ColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 10443, 10464);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1551_10428_10479(System.Text.StringBuilder
                this_param, int
                index, string
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 10428, 10479);
                    return return_v;
                }


                string
                f_1551_10536_10572()
                {
                    var return_v = ParserStrings.TraceScriptLineMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 10536, 10572);
                    return return_v;
                }


                int
                f_1551_10574_10593(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.LineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 10574, 10593);
                    return return_v;
                }


                string
                f_1551_10595_10613(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 10595, 10613);
                    return return_v;
                }


                string
                f_1551_10518_10614(string
                formatSpec, int
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 10518, 10614);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 10104, 10626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 10104, 10626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IScriptExtent NewScriptExtent(IScriptExtent start, IScriptExtent end)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1551, 10638, 11572);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 10748, 10826) || true) && (start == end)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 10748, 10826);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 10798, 10811);

                    return start;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 10748, 10826);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 10842, 10926) || true) && (start == f_1551_10855_10866())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 10842, 10926);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 10900, 10911);

                    return end;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 10842, 10926);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 10942, 11026) || true) && (end == f_1551_10953_10964())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 10942, 11026);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 10998, 11011);

                    return start;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 10942, 11026);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 11042, 11107);

                InternalScriptExtent
                startExtent = start as InternalScriptExtent
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 11121, 11182);

                InternalScriptExtent
                endExtent = end as InternalScriptExtent
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 11196, 11314);

                f_1551_11196_11313(startExtent != null && (DynAbs.Tracing.TraceSender.Expression_True(1551, 11215, 11255) && endExtent != null), "This function only handles internal and empty extents");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 11328, 11439);

                f_1551_11328_11438(f_1551_11347_11373(startExtent) == f_1551_11377_11401(endExtent), "Extents must be from same source");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 11455, 11561);

                return f_1551_11462_11560(f_1551_11487_11513(startExtent), f_1551_11515_11538(startExtent), f_1551_11540_11559(endExtent));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1551, 10638, 11572);

                System.Management.Automation.Language.IScriptExtent
                f_1551_10855_10866()
                {
                    var return_v = EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 10855, 10866);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1551_10953_10964()
                {
                    var return_v = EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 10953, 10964);
                    return return_v;
                }


                int
                f_1551_11196_11313(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 11196, 11313);
                    return 0;
                }


                System.Management.Automation.Language.PositionHelper
                f_1551_11347_11373(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.PositionHelper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 11347, 11373);
                    return return_v;
                }


                System.Management.Automation.Language.PositionHelper
                f_1551_11377_11401(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.PositionHelper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 11377, 11401);
                    return return_v;
                }


                int
                f_1551_11328_11438(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 11328, 11438);
                    return 0;
                }


                System.Management.Automation.Language.PositionHelper
                f_1551_11487_11513(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.PositionHelper;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 11487, 11513);
                    return return_v;
                }


                int
                f_1551_11515_11538(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 11515, 11538);
                    return return_v;
                }


                int
                f_1551_11540_11559(System.Management.Automation.Language.InternalScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 11540, 11559);
                    return return_v;
                }


                System.Management.Automation.Language.InternalScriptExtent
                f_1551_11462_11560(System.Management.Automation.Language.PositionHelper
                _positionHelper, int
                startOffset, int
                endOffset)
                {
                    var return_v = new System.Management.Automation.Language.InternalScriptExtent(_positionHelper, startOffset, endOffset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 11462, 11560);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 10638, 11572);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 10638, 11572);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsBefore(this IScriptExtent extentToTest, IScriptExtent startExtent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1551, 11584, 12054);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 11698, 11819) || true) && (f_1551_11702_11728(extentToTest) < f_1551_11731_11758(startExtent))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 11698, 11819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 11792, 11804);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 11698, 11819);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 11835, 12014) || true) && (f_1551_11839_11865(extentToTest) == f_1551_11869_11896(startExtent))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 11835, 12014);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 11930, 11999);

                    return f_1551_11937_11965(extentToTest) <= f_1551_11969_11998(startExtent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 11835, 12014);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 12030, 12043);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1551, 11584, 12054);

                int
                f_1551_11702_11728(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 11702, 11728);
                    return return_v;
                }


                int
                f_1551_11731_11758(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 11731, 11758);
                    return return_v;
                }


                int
                f_1551_11839_11865(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 11839, 11865);
                    return return_v;
                }


                int
                f_1551_11869_11896(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 11869, 11896);
                    return return_v;
                }


                int
                f_1551_11937_11965(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 11937, 11965);
                    return return_v;
                }


                int
                f_1551_11969_11998(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 11969, 11998);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 11584, 12054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 11584, 12054);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsAfter(this IScriptExtent extentToTest, IScriptExtent endExtent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1551, 12066, 12527);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 12177, 12296) || true) && (f_1551_12181_12209(extentToTest) > f_1551_12212_12235(endExtent))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 12177, 12296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 12269, 12281);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 12177, 12296);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 12312, 12487) || true) && (f_1551_12316_12344(extentToTest) == f_1551_12348_12371(endExtent))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 12312, 12487);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 12405, 12472);

                    return f_1551_12412_12442(extentToTest) >= f_1551_12446_12471(endExtent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 12312, 12487);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 12503, 12516);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1551, 12066, 12527);

                int
                f_1551_12181_12209(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 12181, 12209);
                    return return_v;
                }


                int
                f_1551_12212_12235(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 12212, 12235);
                    return return_v;
                }


                int
                f_1551_12316_12344(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 12316, 12344);
                    return return_v;
                }


                int
                f_1551_12348_12371(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 12348, 12371);
                    return return_v;
                }


                int
                f_1551_12412_12442(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 12412, 12442);
                    return return_v;
                }


                int
                f_1551_12446_12471(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 12446, 12471);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 12066, 12527);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 12066, 12527);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsWithin(this IScriptExtent extentToTest, IScriptExtent extent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1551, 12539, 12955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 12648, 12944);

                return f_1551_12655_12683(extentToTest) >= f_1551_12687_12709(extent) && (DynAbs.Tracing.TraceSender.Expression_True(1551, 12655, 12783) && f_1551_12733_12759(extentToTest) <= f_1551_12763_12783(extent)) && (DynAbs.Tracing.TraceSender.Expression_True(1551, 12655, 12865) && f_1551_12807_12837(extentToTest) >= f_1551_12841_12865(extent)) && (DynAbs.Tracing.TraceSender.Expression_True(1551, 12655, 12943) && f_1551_12889_12917(extentToTest) <= f_1551_12921_12943(extent));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1551, 12539, 12955);

                int
                f_1551_12655_12683(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 12655, 12683);
                    return return_v;
                }


                int
                f_1551_12687_12709(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 12687, 12709);
                    return return_v;
                }


                int
                f_1551_12733_12759(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 12733, 12759);
                    return return_v;
                }


                int
                f_1551_12763_12783(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 12763, 12783);
                    return return_v;
                }


                int
                f_1551_12807_12837(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 12807, 12837);
                    return return_v;
                }


                int
                f_1551_12841_12865(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 12841, 12865);
                    return return_v;
                }


                int
                f_1551_12889_12917(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 12889, 12917);
                    return return_v;
                }


                int
                f_1551_12921_12943(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 12921, 12943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 12539, 12955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 12539, 12955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool IsAfter(this IScriptExtent extent, int line, int column)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1551, 12967, 13237);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13069, 13133) || true) && (line < f_1551_13080_13102(extent))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 13069, 13133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13121, 13133);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 13069, 13133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13149, 13226);

                return (line == f_1551_13165_13187(extent) && (DynAbs.Tracing.TraceSender.Expression_True(1551, 13157, 13224) && column < f_1551_13200_13224(extent)));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1551, 12967, 13237);

                int
                f_1551_13080_13102(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 13080, 13102);
                    return return_v;
                }


                int
                f_1551_13165_13187(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 13165, 13187);
                    return return_v;
                }


                int
                f_1551_13200_13224(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 13200, 13224);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 12967, 13237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 12967, 13237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ContainsLineAndColumn(this IScriptExtent extent, int line, int column)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1551, 13249, 14059);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13365, 13754) || true) && (f_1551_13369_13391(extent) == line)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 13365, 13754);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13433, 13462) || true) && (column == 0)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 13433, 13462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13450, 13462);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 13433, 13462);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13480, 13706) || true) && (column >= f_1551_13494_13518(extent))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 13480, 13706);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13560, 13624) || true) && (f_1551_13564_13584(extent) != f_1551_13588_13610(extent))
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 13560, 13624);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13612, 13624);

                            return true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 13560, 13624);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13646, 13687);

                        return (column < f_1551_13663_13685(extent));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 13480, 13706);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13726, 13739);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 13365, 13754);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13770, 13835) || true) && (f_1551_13774_13796(extent) > line)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 13770, 13835);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13822, 13835);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 13770, 13835);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13851, 13914) || true) && (line > f_1551_13862_13882(extent))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 13851, 13914);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13901, 13914);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 13851, 13914);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13930, 14020) || true) && (f_1551_13934_13954(extent) == line)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 13930, 14020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 13981, 14020);

                    return column < f_1551_13997_14019(extent);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 13930, 14020);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 14036, 14048);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1551, 13249, 14059);

                int
                f_1551_13369_13391(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 13369, 13391);
                    return return_v;
                }


                int
                f_1551_13494_13518(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 13494, 13518);
                    return return_v;
                }


                int
                f_1551_13564_13584(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 13564, 13584);
                    return return_v;
                }


                int
                f_1551_13588_13610(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 13588, 13610);
                    return return_v;
                }


                int
                f_1551_13663_13685(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 13663, 13685);
                    return return_v;
                }


                int
                f_1551_13774_13796(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 13774, 13796);
                    return return_v;
                }


                int
                f_1551_13862_13882(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 13862, 13882);
                    return return_v;
                }


                int
                f_1551_13934_13954(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 13934, 13954);
                    return return_v;
                }


                int
                f_1551_13997_14019(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 13997, 14019);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 13249, 14059);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 13249, 14059);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PositionUtilities()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1551, 3410, 14066);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 3594, 3675);
            EmptyPosition = f_1551_3649_3674();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 3811, 3886);
            EmptyExtent = f_1551_3862_3885();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1551, 3410, 14066);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 3410, 14066);
        }


        static System.Management.Automation.Language.EmptyScriptPosition
        f_1551_3649_3674()
        {
            var return_v = new System.Management.Automation.Language.EmptyScriptPosition();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 3649, 3674);
            return return_v;
        }


        static System.Management.Automation.Language.EmptyScriptExtent
        f_1551_3862_3885()
        {
            var return_v = new System.Management.Automation.Language.EmptyScriptExtent();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 3862, 3885);
            return return_v;
        }

    }
    internal class PositionHelper
    {
        private int[] _lineStartMap;

        internal PositionHelper(string filename, string scriptText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1551, 14229, 14378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 14203, 14216);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 14390, 14425);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 14542, 14569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 14313, 14329);

                File = filename;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 14343, 14367);

                ScriptText = scriptText;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1551, 14229, 14378);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 14229, 14378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 14229, 14378);
            }
        }

        internal string ScriptText { get; }

        internal int[] LineStartMap
        {
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 14489, 14519);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 14495, 14517);

                    _lineStartMap = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 14489, 14519);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 14437, 14530);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 14437, 14530);
                }
            }
        }

        public string File { get; }

        internal int LineFromOffset(int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 14581, 14838);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 14645, 14703);

                int
                line = f_1551_14656_14702(_lineStartMap, offset)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 14717, 14795) || true) && (line < 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 14717, 14795);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 14763, 14780);

                    line = ~line - 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 14717, 14795);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 14811, 14827);

                return line + 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 14581, 14838);

                int
                f_1551_14656_14702(int[]
                array, int
                value)
                {
                    var return_v = Array.BinarySearch<int>(array, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 14656, 14702);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 14581, 14838);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 14581, 14838);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal int ColumnFromOffset(int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 14850, 14989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 14916, 14978);

                return offset - _lineStartMap[f_1551_14946_14968(this, offset) - 1] + 1;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 14850, 14989);

                int
                f_1551_14946_14968(System.Management.Automation.Language.PositionHelper
                this_param, int
                offset)
                {
                    var return_v = this_param.LineFromOffset(offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 14946, 14968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 14850, 14989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 14850, 14989);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string Text(int line)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 15001, 15350);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 15056, 15092);

                int
                start = _lineStartMap[line - 1]
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 15106, 15288) || true) && (line < f_1551_15117_15137(_lineStartMap))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 15106, 15288);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 15171, 15212);

                    int
                    length = _lineStartMap[line] - start
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 15230, 15273);

                    return f_1551_15237_15272(f_1551_15237_15247(), start, length);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 15106, 15288);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 15304, 15339);

                return f_1551_15311_15338(f_1551_15311_15321(), start);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 15001, 15350);

                int
                f_1551_15117_15137(int[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 15117, 15137);
                    return return_v;
                }


                string
                f_1551_15237_15247()
                {
                    var return_v = ScriptText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 15237, 15247);
                    return return_v;
                }


                string
                f_1551_15237_15272(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 15237, 15272);
                    return return_v;
                }


                string
                f_1551_15311_15321()
                {
                    var return_v = ScriptText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 15311, 15321);
                    return return_v;
                }


                string
                f_1551_15311_15338(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 15311, 15338);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 15001, 15350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 15001, 15350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PositionHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1551, 14143, 15357);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1551, 14143, 15357);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 14143, 15357);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1551, 14143, 15357);
    }
    internal sealed class InternalScriptPosition : IScriptPosition
    {
        private readonly PositionHelper _positionHelper;

        internal InternalScriptPosition(PositionHelper _positionHelper, int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1551, 15504, 15684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 15476, 15491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 16038, 16064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 15604, 15643);

                this._positionHelper = _positionHelper;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 15657, 15673);

                Offset = offset;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1551, 15504, 15684);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 15504, 15684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 15504, 15684);
            }
        }

        public string File
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 15717, 15753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 15723, 15751);

                    return f_1551_15730_15750(_positionHelper);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 15717, 15753);

                    string
                    f_1551_15730_15750(System.Management.Automation.Language.PositionHelper
                    this_param)
                    {
                        var return_v = this_param.File;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 15730, 15750);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 15696, 15755);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 15696, 15755);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int LineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 15791, 15845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 15797, 15843);

                    return f_1551_15804_15842(_positionHelper, f_1551_15835_15841());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 15791, 15845);

                    int
                    f_1551_15835_15841()
                    {
                        var return_v = Offset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 15835, 15841);
                        return return_v;
                    }


                    int
                    f_1551_15804_15842(System.Management.Automation.Language.PositionHelper
                    this_param, int
                    offset)
                    {
                        var return_v = this_param.LineFromOffset(offset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 15804, 15842);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 15767, 15847);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 15767, 15847);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int ColumnNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 15885, 15941);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 15891, 15939);

                    return f_1551_15898_15938(_positionHelper, f_1551_15931_15937());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 15885, 15941);

                    int
                    f_1551_15931_15937()
                    {
                        var return_v = Offset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 15931, 15937);
                        return return_v;
                    }


                    int
                    f_1551_15898_15938(System.Management.Automation.Language.PositionHelper
                    this_param, int
                    offset)
                    {
                        var return_v = this_param.ColumnFromOffset(offset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 15898, 15938);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 15859, 15943);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 15859, 15943);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Line
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 15976, 16024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 15982, 16022);

                    return f_1551_15989_16021(_positionHelper, f_1551_16010_16020());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 15976, 16024);

                    int
                    f_1551_16010_16020()
                    {
                        var return_v = LineNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 16010, 16020);
                        return return_v;
                    }


                    string
                    f_1551_15989_16021(System.Management.Automation.Language.PositionHelper
                    this_param, int
                    line)
                    {
                        var return_v = this_param.Text(line);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 15989, 16021);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 15955, 16026);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 15955, 16026);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Offset { get; }

        internal InternalScriptPosition CloneWithNewOffset(int offset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 16076, 16233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 16163, 16222);

                return f_1551_16170_16221(_positionHelper, offset);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 16076, 16233);

                System.Management.Automation.Language.InternalScriptPosition
                f_1551_16170_16221(System.Management.Automation.Language.PositionHelper
                _positionHelper, int
                offset)
                {
                    var return_v = new System.Management.Automation.Language.InternalScriptPosition(_positionHelper, offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 16170, 16221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 16076, 16233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 16076, 16233);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public string GetFullScript()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 16245, 16344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 16299, 16333);

                return f_1551_16306_16332(_positionHelper);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 16245, 16344);

                string
                f_1551_16306_16332(System.Management.Automation.Language.PositionHelper
                this_param)
                {
                    var return_v = this_param.ScriptText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 16306, 16332);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 16245, 16344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 16245, 16344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static InternalScriptPosition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1551, 15365, 16351);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1551, 15365, 16351);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 15365, 16351);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1551, 15365, 16351);
    }
    internal sealed class InternalScriptExtent : IScriptExtent
    {
        internal InternalScriptExtent(PositionHelper _positionHelper, int startOffset, int endOffset)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1551, 16434, 16677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 18149, 18196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 18208, 18239);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 18251, 18280);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 16552, 16590);

                this.PositionHelper = _positionHelper;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 16604, 16630);

                StartOffset = startOffset;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 16644, 16666);

                EndOffset = endOffset;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1551, 16434, 16677);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 16434, 16677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 16434, 16677);
            }
        }

        public string File
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 16732, 16767);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 16738, 16765);

                    return f_1551_16745_16764(f_1551_16745_16759());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 16732, 16767);

                    System.Management.Automation.Language.PositionHelper
                    f_1551_16745_16759()
                    {
                        var return_v = PositionHelper;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 16745, 16759);
                        return return_v;
                    }


                    string
                    f_1551_16745_16764(System.Management.Automation.Language.PositionHelper
                    this_param)
                    {
                        var return_v = this_param.File;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 16745, 16764);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 16689, 16778);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 16689, 16778);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IScriptPosition StartScriptPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 16857, 16928);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 16863, 16926);

                    return f_1551_16870_16925(f_1551_16897_16911(), f_1551_16913_16924());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 16857, 16928);

                    System.Management.Automation.Language.PositionHelper
                    f_1551_16897_16911()
                    {
                        var return_v = PositionHelper;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 16897, 16911);
                        return return_v;
                    }


                    int
                    f_1551_16913_16924()
                    {
                        var return_v = StartOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 16913, 16924);
                        return return_v;
                    }


                    System.Management.Automation.Language.InternalScriptPosition
                    f_1551_16870_16925(System.Management.Automation.Language.PositionHelper
                    _positionHelper, int
                    offset)
                    {
                        var return_v = new System.Management.Automation.Language.InternalScriptPosition(_positionHelper, offset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 16870, 16925);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 16790, 16939);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 16790, 16939);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IScriptPosition EndScriptPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 17016, 17085);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 17022, 17083);

                    return f_1551_17029_17082(f_1551_17056_17070(), f_1551_17072_17081());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 17016, 17085);

                    System.Management.Automation.Language.PositionHelper
                    f_1551_17056_17070()
                    {
                        var return_v = PositionHelper;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17056, 17070);
                        return return_v;
                    }


                    int
                    f_1551_17072_17081()
                    {
                        var return_v = EndOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17072, 17081);
                        return return_v;
                    }


                    System.Management.Automation.Language.InternalScriptPosition
                    f_1551_17029_17082(System.Management.Automation.Language.PositionHelper
                    _positionHelper, int
                    offset)
                    {
                        var return_v = new System.Management.Automation.Language.InternalScriptPosition(_positionHelper, offset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 17029, 17082);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 16951, 17096);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 16951, 17096);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int StartLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 17159, 17217);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 17165, 17215);

                    return f_1551_17172_17214(f_1551_17172_17186(), f_1551_17202_17213());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 17159, 17217);

                    System.Management.Automation.Language.PositionHelper
                    f_1551_17172_17186()
                    {
                        var return_v = PositionHelper;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17172, 17186);
                        return return_v;
                    }


                    int
                    f_1551_17202_17213()
                    {
                        var return_v = StartOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17202, 17213);
                        return return_v;
                    }


                    int
                    f_1551_17172_17214(System.Management.Automation.Language.PositionHelper
                    this_param, int
                    offset)
                    {
                        var return_v = this_param.LineFromOffset(offset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 17172, 17214);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 17108, 17228);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 17108, 17228);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int StartColumnNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 17293, 17353);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 17299, 17351);

                    return f_1551_17306_17350(f_1551_17306_17320(), f_1551_17338_17349());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 17293, 17353);

                    System.Management.Automation.Language.PositionHelper
                    f_1551_17306_17320()
                    {
                        var return_v = PositionHelper;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17306, 17320);
                        return return_v;
                    }


                    int
                    f_1551_17338_17349()
                    {
                        var return_v = StartOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17338, 17349);
                        return return_v;
                    }


                    int
                    f_1551_17306_17350(System.Management.Automation.Language.PositionHelper
                    this_param, int
                    offset)
                    {
                        var return_v = this_param.ColumnFromOffset(offset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 17306, 17350);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 17240, 17364);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 17240, 17364);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int EndLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 17425, 17481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 17431, 17479);

                    return f_1551_17438_17478(f_1551_17438_17452(), f_1551_17468_17477());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 17425, 17481);

                    System.Management.Automation.Language.PositionHelper
                    f_1551_17438_17452()
                    {
                        var return_v = PositionHelper;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17438, 17452);
                        return return_v;
                    }


                    int
                    f_1551_17468_17477()
                    {
                        var return_v = EndOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17468, 17477);
                        return return_v;
                    }


                    int
                    f_1551_17438_17478(System.Management.Automation.Language.PositionHelper
                    this_param, int
                    offset)
                    {
                        var return_v = this_param.LineFromOffset(offset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 17438, 17478);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 17376, 17492);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 17376, 17492);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int EndColumnNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 17555, 17613);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 17561, 17611);

                    return f_1551_17568_17610(f_1551_17568_17582(), f_1551_17600_17609());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 17555, 17613);

                    System.Management.Automation.Language.PositionHelper
                    f_1551_17568_17582()
                    {
                        var return_v = PositionHelper;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17568, 17582);
                        return return_v;
                    }


                    int
                    f_1551_17600_17609()
                    {
                        var return_v = EndOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17600, 17609);
                        return return_v;
                    }


                    int
                    f_1551_17568_17610(System.Management.Automation.Language.PositionHelper
                    this_param, int
                    offset)
                    {
                        var return_v = this_param.ColumnFromOffset(offset);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 17568, 17610);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 17504, 17624);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 17504, 17624);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Text
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 17679, 18033);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 17786, 17917) || true) && (f_1551_17790_17801() > f_1551_17804_17836(f_1551_17804_17829(f_1551_17804_17818())))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 17786, 17917);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 17878, 17898);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 17786, 17917);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 17937, 18018);

                    return f_1551_17944_18017(f_1551_17944_17969(f_1551_17944_17958()), f_1551_17980_17991(), f_1551_17993_18002() - f_1551_18005_18016());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 17679, 18033);

                    int
                    f_1551_17790_17801()
                    {
                        var return_v = StartOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17790, 17801);
                        return return_v;
                    }


                    System.Management.Automation.Language.PositionHelper
                    f_1551_17804_17818()
                    {
                        var return_v = PositionHelper;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17804, 17818);
                        return return_v;
                    }


                    string
                    f_1551_17804_17829(System.Management.Automation.Language.PositionHelper
                    this_param)
                    {
                        var return_v = this_param.ScriptText;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17804, 17829);
                        return return_v;
                    }


                    int
                    f_1551_17804_17836(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17804, 17836);
                        return return_v;
                    }


                    System.Management.Automation.Language.PositionHelper
                    f_1551_17944_17958()
                    {
                        var return_v = PositionHelper;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17944, 17958);
                        return return_v;
                    }


                    string
                    f_1551_17944_17969(System.Management.Automation.Language.PositionHelper
                    this_param)
                    {
                        var return_v = this_param.ScriptText;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17944, 17969);
                        return return_v;
                    }


                    int
                    f_1551_17980_17991()
                    {
                        var return_v = StartOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17980, 17991);
                        return return_v;
                    }


                    int
                    f_1551_17993_18002()
                    {
                        var return_v = EndOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 17993, 18002);
                        return return_v;
                    }


                    int
                    f_1551_18005_18016()
                    {
                        var return_v = StartOffset;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 18005, 18016);
                        return return_v;
                    }


                    string
                    f_1551_17944_18017(string
                    this_param, int
                    startIndex, int
                    length)
                    {
                        var return_v = this_param.Substring(startIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 17944, 18017);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 17636, 18044);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 17636, 18044);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 18056, 18137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 18114, 18126);

                return f_1551_18121_18125();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 18056, 18137);

                string
                f_1551_18121_18125()
                {
                    var return_v = Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 18121, 18125);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 18056, 18137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 18056, 18137);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PositionHelper PositionHelper { get; }

        public int StartOffset { get; }

        public int EndOffset { get; }

        static InternalScriptExtent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1551, 16359, 18287);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1551, 16359, 18287);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 16359, 18287);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1551, 16359, 18287);
    }
    internal sealed class EmptyScriptPosition : IScriptPosition
    {
        public string File
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 18461, 18481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 18467, 18479);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 18461, 18481);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 18440, 18483);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 18440, 18483);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int LineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 18519, 18536);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 18525, 18534);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 18519, 18536);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 18495, 18538);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 18495, 18538);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int ColumnNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 18576, 18593);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 18582, 18591);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 18576, 18593);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 18550, 18595);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 18550, 18595);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int Offset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 18627, 18644);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 18633, 18642);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 18627, 18644);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 18607, 18646);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 18607, 18646);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Line
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 18679, 18707);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 18685, 18705);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 18679, 18707);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 18658, 18709);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 18658, 18709);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string GetFullScript()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 18721, 18767);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 18753, 18765);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 18721, 18767);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 18721, 18767);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 18721, 18767);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmptyScriptPosition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1551, 18364, 18774);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1551, 18364, 18774);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 18364, 18774);
        }


        static EmptyScriptPosition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1551, 18364, 18774);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1551, 18364, 18774);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 18364, 18774);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1551, 18364, 18774);
    }
    internal sealed class EmptyScriptExtent : IScriptExtent
    {
        public string File
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 18875, 18895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 18881, 18893);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 18875, 18895);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 18854, 18897);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 18854, 18897);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IScriptPosition StartScriptPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 18954, 19001);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 18960, 18999);

                    return f_1551_18967_18998();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 18954, 19001);

                    System.Management.Automation.Language.IScriptPosition
                    f_1551_18967_18998()
                    {
                        var return_v = PositionUtilities.EmptyPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 18967, 18998);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 18909, 19003);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 18909, 19003);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IScriptPosition EndScriptPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 19058, 19105);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 19064, 19103);

                    return f_1551_19071_19102();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 19058, 19105);

                    System.Management.Automation.Language.IScriptPosition
                    f_1551_19071_19102()
                    {
                        var return_v = PositionUtilities.EmptyPosition;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 19071, 19102);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 19015, 19107);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 19015, 19107);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int StartLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 19148, 19165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 19154, 19163);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 19148, 19165);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 19119, 19167);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 19119, 19167);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int StartColumnNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 19210, 19227);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 19216, 19225);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 19210, 19227);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 19179, 19229);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 19179, 19229);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int EndLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 19268, 19285);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 19274, 19283);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 19268, 19285);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 19241, 19287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 19241, 19287);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int EndColumnNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 19328, 19345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 19334, 19343);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 19328, 19345);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 19299, 19347);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 19299, 19347);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int StartOffset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 19384, 19401);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 19390, 19399);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 19384, 19401);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 19359, 19403);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 19359, 19403);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int EndOffset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 19438, 19455);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 19444, 19453);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 19438, 19455);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 19415, 19457);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 19415, 19457);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Text
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 19490, 19518);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 19496, 19516);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 19490, 19518);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 19469, 19520);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 19469, 19520);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public override bool Equals(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 19532, 20308);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 19596, 19647);

                IScriptExtent
                otherPosition = obj as IScriptExtent
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 19661, 19748) || true) && (otherPosition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 19661, 19748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 19720, 19733);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 19661, 19748);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 19764, 20297) || true) && ((f_1551_19769_19809(f_1551_19790_19808(otherPosition))) && (DynAbs.Tracing.TraceSender.Expression_True(1551, 19768, 19881) && (f_1551_19832_19861(otherPosition) == f_1551_19865_19880())) && (DynAbs.Tracing.TraceSender.Expression_True(1551, 19768, 19956) && (f_1551_19903_19934(otherPosition) == f_1551_19938_19955())) && (DynAbs.Tracing.TraceSender.Expression_True(1551, 19768, 20023) && (f_1551_19978_20005(otherPosition) == f_1551_20009_20022())) && (DynAbs.Tracing.TraceSender.Expression_True(1551, 19768, 20094) && (f_1551_20045_20074(otherPosition) == f_1551_20078_20093())) && (DynAbs.Tracing.TraceSender.Expression_True(1551, 19768, 20157) && (f_1551_20116_20156(f_1551_20137_20155(otherPosition)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 19764, 20297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 20191, 20203);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 19764, 20297);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 19764, 20297);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 20269, 20282);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 19764, 20297);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 19532, 20308);

                string
                f_1551_19790_19808(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.File;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 19790, 19808);
                    return return_v;
                }


                bool
                f_1551_19769_19809(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 19769, 19809);
                    return return_v;
                }


                int
                f_1551_19832_19861(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 19832, 19861);
                    return return_v;
                }


                int
                f_1551_19865_19880()
                {
                    var return_v = StartLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 19865, 19880);
                    return return_v;
                }


                int
                f_1551_19903_19934(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 19903, 19934);
                    return return_v;
                }


                int
                f_1551_19938_19955()
                {
                    var return_v = StartColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 19938, 19955);
                    return return_v;
                }


                int
                f_1551_19978_20005(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 19978, 20005);
                    return return_v;
                }


                int
                f_1551_20009_20022()
                {
                    var return_v = EndLineNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 20009, 20022);
                    return return_v;
                }


                int
                f_1551_20045_20074(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 20045, 20074);
                    return return_v;
                }


                int
                f_1551_20078_20093()
                {
                    var return_v = EndColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 20078, 20093);
                    return return_v;
                }


                string
                f_1551_20137_20155(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 20137, 20155);
                    return return_v;
                }


                bool
                f_1551_20116_20156(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 20116, 20156);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 19532, 20308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 19532, 20308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override int GetHashCode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 20320, 20415);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 20378, 20404);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GetHashCode(), 1551, 20385, 20403);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 20320, 20415);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 20320, 20415);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 20320, 20415);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public EmptyScriptExtent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1551, 18782, 20422);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1551, 18782, 20422);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 18782, 20422);
        }


        static EmptyScriptExtent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1551, 18782, 20422);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1551, 18782, 20422);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 18782, 20422);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1551, 18782, 20422);
    }
    public sealed class ScriptPosition : IScriptPosition
    {
        private readonly string _fullScript;

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        public ScriptPosition(string scriptName, int scriptLineNumber, int offsetInLine, string line)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1551, 21329, 21848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 20701, 20712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 23110, 23137);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 23281, 23311);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 23459, 23491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 23801, 23828);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 21540, 21558);

                File = scriptName;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 21572, 21602);

                LineNumber = scriptLineNumber;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 21616, 21644);

                ColumnNumber = offsetInLine;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 21660, 21837) || true) && (f_1551_21664_21690(line))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 21660, 21837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 21724, 21744);

                    Line = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 21660, 21837);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 21660, 21837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 21810, 21822);

                    Line = line;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 21660, 21837);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1551, 21329, 21848);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 21329, 21848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 21329, 21848);
            }
        }

        [SuppressMessage("Microsoft.Naming", "CA1702:CompoundWordsShouldBeCasedCorrectly")]
        public ScriptPosition(
                    string scriptName,
                    int scriptLineNumber,
                    int offsetInLine,
                    string line,
                    string fullScript) : this(f_1551_22852_22862_C(scriptName), scriptLineNumber, offsetInLine, line)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1551, 22560, 22962);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 22926, 22951);

                _fullScript = fullScript;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1551, 22560, 22962);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 22560, 22962);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 22560, 22962);
            }
        }

        public string File { get; }

        public int LineNumber { get; }

        public int ColumnNumber { get; }

        public int Offset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 23645, 23662);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 23651, 23660);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 23645, 23662);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 23625, 23664);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 23625, 23664);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Line { get; }

        public string GetFullScript()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 23955, 24008);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 23987, 24006);

                return _fullScript;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 23955, 24008);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 23955, 24008);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 23955, 24008);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ScriptPosition()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1551, 20608, 24015);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1551, 20608, 24015);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 20608, 24015);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1551, 20608, 24015);

        bool
        f_1551_21664_21690(string
        value)
        {
            var return_v = string.IsNullOrEmpty(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 21664, 21690);
            return return_v;
        }


        static string
        f_1551_22852_22862_C(string
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1551, 22560, 22962);
            return return_v;
        }

    }
    public sealed class ScriptExtent : IScriptExtent
    {
        private ScriptPosition _startPosition;

        private ScriptPosition _endPosition;

        private ScriptExtent()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1551, 24309, 24353);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 24236, 24250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 24284, 24296);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1551, 24309, 24353);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 24309, 24353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 24309, 24353);
            }
        }

        public ScriptExtent(ScriptPosition startPosition, ScriptPosition endPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1551, 24459, 24644);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 24236, 24250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 24284, 24296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 24561, 24592);

                _startPosition = startPosition;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 24606, 24633);

                _endPosition = endPosition;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1551, 24459, 24644);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 24459, 24644);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 24459, 24644);
            }
        }

        public string File
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 24813, 24848);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 24819, 24846);

                    return f_1551_24826_24845(_startPosition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 24813, 24848);

                    string
                    f_1551_24826_24845(System.Management.Automation.Language.ScriptPosition
                    this_param)
                    {
                        var return_v = this_param.File;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 24826, 24845);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 24792, 24850);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 24792, 24850);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IScriptPosition StartScriptPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 25004, 25034);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 25010, 25032);

                    return _startPosition;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 25004, 25034);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 24959, 25036);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 24959, 25036);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public IScriptPosition EndScriptPosition
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 25250, 25278);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 25256, 25276);

                    return _endPosition;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 25250, 25278);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 25207, 25280);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 25207, 25280);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int StartLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 25468, 25509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 25474, 25507);

                    return f_1551_25481_25506(_startPosition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 25468, 25509);

                    int
                    f_1551_25481_25506(System.Management.Automation.Language.ScriptPosition
                    this_param)
                    {
                        var return_v = this_param.LineNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 25481, 25506);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 25439, 25511);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 25439, 25511);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int StartColumnNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 25705, 25748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 25711, 25746);

                    return f_1551_25718_25745(_startPosition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 25705, 25748);

                    int
                    f_1551_25718_25745(System.Management.Automation.Language.ScriptPosition
                    this_param)
                    {
                        var return_v = this_param.ColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 25718, 25745);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 25674, 25750);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 25674, 25750);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int EndLineNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 25930, 25969);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 25936, 25967);

                    return f_1551_25943_25966(_endPosition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 25930, 25969);

                    int
                    f_1551_25943_25966(System.Management.Automation.Language.ScriptPosition
                    this_param)
                    {
                        var return_v = this_param.LineNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 25943, 25966);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 25903, 25971);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 25903, 25971);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int EndColumnNumber
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 26157, 26198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 26163, 26196);

                    return f_1551_26170_26195(_endPosition);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 26157, 26198);

                    int
                    f_1551_26170_26195(System.Management.Automation.Language.ScriptPosition
                    this_param)
                    {
                        var return_v = this_param.ColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 26170, 26195);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 26128, 26200);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 26128, 26200);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int StartOffset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 26333, 26350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 26339, 26348);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 26333, 26350);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 26308, 26352);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 26308, 26352);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public int EndOffset
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 26481, 26498);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 26487, 26496);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 26481, 26498);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 26458, 26500);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 26458, 26500);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public string Text
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 26657, 27483);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 26693, 27468) || true) && (f_1551_26697_26712() > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 26693, 27468);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 26758, 27056) || true) && (f_1551_26762_26777() == f_1551_26781_26794())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 26758, 27056);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 26844, 27033);

                            return f_1551_26851_27032(f_1551_26851_26870(_startPosition), f_1551_26881_26908(_startPosition) - 1, f_1551_26976_27001(_endPosition) - f_1551_27004_27031(_startPosition));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 26758, 27056);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 27080, 27347);

                        return f_1551_27087_27346(f_1551_27101_27129(), "{0}...{1}", f_1551_27186_27244(f_1551_27186_27205(_startPosition), f_1551_27216_27243(_startPosition)), f_1551_27288_27345(f_1551_27288_27305(_endPosition), 0, f_1551_27319_27344(_endPosition)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 26693, 27468);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1551, 26693, 27468);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 27429, 27449);

                        return string.Empty;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1551, 26693, 27468);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 26657, 27483);

                    int
                    f_1551_26697_26712()
                    {
                        var return_v = EndColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 26697, 26712);
                        return return_v;
                    }


                    int
                    f_1551_26762_26777()
                    {
                        var return_v = StartLineNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 26762, 26777);
                        return return_v;
                    }


                    int
                    f_1551_26781_26794()
                    {
                        var return_v = EndLineNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 26781, 26794);
                        return return_v;
                    }


                    string
                    f_1551_26851_26870(System.Management.Automation.Language.ScriptPosition
                    this_param)
                    {
                        var return_v = this_param.Line;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 26851, 26870);
                        return return_v;
                    }


                    int
                    f_1551_26881_26908(System.Management.Automation.Language.ScriptPosition
                    this_param)
                    {
                        var return_v = this_param.ColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 26881, 26908);
                        return return_v;
                    }


                    int
                    f_1551_26976_27001(System.Management.Automation.Language.ScriptPosition
                    this_param)
                    {
                        var return_v = this_param.ColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 26976, 27001);
                        return return_v;
                    }


                    int
                    f_1551_27004_27031(System.Management.Automation.Language.ScriptPosition
                    this_param)
                    {
                        var return_v = this_param.ColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 27004, 27031);
                        return return_v;
                    }


                    string
                    f_1551_26851_27032(string
                    this_param, int
                    startIndex, int
                    length)
                    {
                        var return_v = this_param.Substring(startIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 26851, 27032);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1551_27101_27129()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 27101, 27129);
                        return return_v;
                    }


                    string
                    f_1551_27186_27205(System.Management.Automation.Language.ScriptPosition
                    this_param)
                    {
                        var return_v = this_param.Line;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 27186, 27205);
                        return return_v;
                    }


                    int
                    f_1551_27216_27243(System.Management.Automation.Language.ScriptPosition
                    this_param)
                    {
                        var return_v = this_param.ColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 27216, 27243);
                        return return_v;
                    }


                    string
                    f_1551_27186_27244(string
                    this_param, int
                    startIndex)
                    {
                        var return_v = this_param.Substring(startIndex);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 27186, 27244);
                        return return_v;
                    }


                    string
                    f_1551_27288_27305(System.Management.Automation.Language.ScriptPosition
                    this_param)
                    {
                        var return_v = this_param.Line;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 27288, 27305);
                        return return_v;
                    }


                    int
                    f_1551_27319_27344(System.Management.Automation.Language.ScriptPosition
                    this_param)
                    {
                        var return_v = this_param.ColumnNumber;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1551, 27319, 27344);
                        return return_v;
                    }


                    string
                    f_1551_27288_27345(string
                    this_param, int
                    startIndex, int
                    length)
                    {
                        var return_v = this_param.Substring(startIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 27288, 27345);
                        return return_v;
                    }


                    string
                    f_1551_27087_27346(System.Globalization.CultureInfo
                    provider, string
                    format, string
                    arg0, string
                    arg1)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 27087, 27346);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 26614, 27494);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 26614, 27494);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal void ToPSObjectForRemoting(PSObject dest)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 27506, 28091);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 27581, 27652);

                f_1551_27581_27651(dest, "ScriptExtent_File", () => File);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 27666, 27759);

                f_1551_27666_27758(dest, "ScriptExtent_StartLineNumber", () => StartLineNumber);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 27773, 27870);

                f_1551_27773_27869(dest, "ScriptExtent_StartColumnNumber", () => StartColumnNumber);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 27884, 27973);

                f_1551_27884_27972(dest, "ScriptExtent_EndLineNumber", () => EndLineNumber);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 27987, 28080);

                f_1551_27987_28079(dest, "ScriptExtent_EndColumnNumber", () => EndColumnNumber);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 27506, 28091);

                int
                f_1551_27581_27651(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<string>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 27581, 27651);
                    return 0;
                }


                int
                f_1551_27666_27758(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<int>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 27666, 27758);
                    return 0;
                }


                int
                f_1551_27773_27869(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<int>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 27773, 27869);
                    return 0;
                }


                int
                f_1551_27884_27972(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<int>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 27884, 27972);
                    return 0;
                }


                int
                f_1551_27987_28079(System.Management.Automation.PSObject
                pso, string
                propertyName, System.Management.Automation.RemotingEncoder.ValueGetterDelegate<int>
                valueGetter)
                {
                    RemotingEncoder.AddNoteProperty(pso, propertyName, valueGetter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 27987, 28079);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 27506, 28091);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 27506, 28091);
            }
        }

        private void PopulateFromSerializedInfo(PSObject serializedScriptExtent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1551, 28103, 29139);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 28200, 28300);

                string
                file = f_1551_28214_28299(serializedScriptExtent, "ScriptExtent_File")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 28314, 28430);

                int
                startLineNumber = f_1551_28336_28429(serializedScriptExtent, "ScriptExtent_StartLineNumber")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 28444, 28564);

                int
                startColumnNumber = f_1551_28468_28563(serializedScriptExtent, "ScriptExtent_StartColumnNumber")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 28578, 28690);

                int
                endLineNumber = f_1551_28598_28689(serializedScriptExtent, "ScriptExtent_EndLineNumber")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 28704, 28820);

                int
                endColumnNumber = f_1551_28726_28819(serializedScriptExtent, "ScriptExtent_EndColumnNumber")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 28836, 28934);

                ScriptPosition
                startPosition = f_1551_28867_28933(file, startLineNumber, startColumnNumber, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 28948, 29040);

                ScriptPosition
                endPosition = f_1551_28977_29039(file, endLineNumber, endColumnNumber, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 29056, 29087);

                _startPosition = startPosition;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 29101, 29128);

                _endPosition = endPosition;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1551, 28103, 29139);

                string
                f_1551_28214_28299(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<string>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 28214, 28299);
                    return return_v;
                }


                int
                f_1551_28336_28429(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<int>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 28336, 28429);
                    return return_v;
                }


                int
                f_1551_28468_28563(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<int>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 28468, 28563);
                    return return_v;
                }


                int
                f_1551_28598_28689(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<int>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 28598, 28689);
                    return return_v;
                }


                int
                f_1551_28726_28819(System.Management.Automation.PSObject
                psObject, string
                propertyName)
                {
                    var return_v = RemotingDecoder.GetPropertyValue<int>(psObject, propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 28726, 28819);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptPosition
                f_1551_28867_28933(string
                scriptName, int
                scriptLineNumber, int
                offsetInLine, string
                line)
                {
                    var return_v = new System.Management.Automation.Language.ScriptPosition(scriptName, scriptLineNumber, offsetInLine, line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 28867, 28933);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptPosition
                f_1551_28977_29039(string
                scriptName, int
                scriptLineNumber, int
                offsetInLine, string
                line)
                {
                    var return_v = new System.Management.Automation.Language.ScriptPosition(scriptName, scriptLineNumber, offsetInLine, line);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 28977, 29039);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 28103, 29139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 28103, 29139);
            }
        }

        internal static ScriptExtent FromPSObjectForRemoting(PSObject serializedScriptExtent)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1551, 29151, 29413);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 29261, 29302);

                ScriptExtent
                extent = f_1551_29283_29301()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 29316, 29374);

                f_1551_29316_29373(extent, serializedScriptExtent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1551, 29388, 29402);

                return extent;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1551, 29151, 29413);

                System.Management.Automation.Language.ScriptExtent
                f_1551_29283_29301()
                {
                    var return_v = new System.Management.Automation.Language.ScriptExtent();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 29283, 29301);
                    return return_v;
                }


                int
                f_1551_29316_29373(System.Management.Automation.Language.ScriptExtent
                this_param, System.Management.Automation.PSObject
                serializedScriptExtent)
                {
                    this_param.PopulateFromSerializedInfo(serializedScriptExtent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1551, 29316, 29373);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1551, 29151, 29413);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 29151, 29413);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ScriptExtent()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1551, 24148, 29420);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1551, 24148, 29420);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1551, 24148, 29420);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1551, 24148, 29420);
    }
}
