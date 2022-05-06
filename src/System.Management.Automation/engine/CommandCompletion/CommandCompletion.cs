// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Text.RegularExpressions;

namespace System.Management.Automation
{
    public class CommandCompletion
    {
        public CommandCompletion(Collection<CompletionResult> matches, int currentMatchIndex, int replacementIndex, int replacementLength)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1441, 819, 1187);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 1350, 1392);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 1528, 1569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 1708, 1750);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 1855, 2015);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 974, 1007);

                this.CompletionMatches = matches;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 1021, 1064);

                this.CurrentMatchIndex = currentMatchIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 1078, 1119);

                this.ReplacementIndex = replacementIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 1133, 1176);

                this.ReplacementLength = replacementLength;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1441, 819, 1187);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 819, 1187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 819, 1187);
            }
        }

        public int CurrentMatchIndex { get; set; }

        public int ReplacementIndex { get; set; }

        public int ReplacementLength { get; set; }

        [SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public Collection<CompletionResult> CompletionMatches { get; set; }

        internal static readonly IList<CompletionResult> EmptyCompletionResult;

        private static readonly CommandCompletion s_emptyCommandCompletion;

        public static Tuple<Ast, Token[], IScriptPosition> MapStringInputToParsedInput(string input, int cursorIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 2576, 3243);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 2710, 2845) || true) && (cursorIndex > f_1441_2728_2740(input))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 2710, 2845);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 2774, 2830);

                    throw f_1441_2780_2829("cursorIndex");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 2710, 2845);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 2861, 2876);

                Token[]
                tokens
                = default(Token[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 2890, 2910);

                ParseError[]
                errors
                = default(ParseError[]);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 2924, 2983);

                var
                ast = f_1441_2934_2982(input, out tokens, out errors)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 2999, 3138);

                IScriptPosition
                cursorPosition =
                f_1441_3049_3137(((InternalScriptPosition)f_1441_3074_3104(f_1441_3074_3084(ast))), cursorIndex)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 3152, 3232);

                return f_1441_3159_3231(ast, tokens, cursorPosition);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 2576, 3243);

                int
                f_1441_2728_2740(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 2728, 2740);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1441_2780_2829(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 2780, 2829);
                    return return_v;
                }


                System.Management.Automation.Language.ScriptBlockAst
                f_1441_2934_2982(string
                input, out System.Management.Automation.Language.Token[]
                tokens, out System.Management.Automation.Language.ParseError[]
                errors)
                {
                    var return_v = Parser.ParseInput(input, out tokens, out errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 2934, 2982);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1441_3074_3084(System.Management.Automation.Language.ScriptBlockAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 3074, 3084);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1441_3074_3104(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 3074, 3104);
                    return return_v;
                }


                System.Management.Automation.Language.InternalScriptPosition
                f_1441_3049_3137(System.Management.Automation.Language.InternalScriptPosition
                this_param, int
                offset)
                {
                    var return_v = this_param.CloneWithNewOffset(offset);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 3049, 3137);
                    return return_v;
                }


                System.Tuple<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[], System.Management.Automation.Language.IScriptPosition>
                f_1441_3159_3231(System.Management.Automation.Language.ScriptBlockAst
                item1, System.Management.Automation.Language.Token[]
                item2, System.Management.Automation.Language.IScriptPosition
                item3)
                {
                    var return_v = Tuple.Create<Ast, Token[], IScriptPosition>((System.Management.Automation.Language.Ast)item1, item2, item3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 3159, 3231);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 2576, 3243);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 2576, 3243);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CommandCompletion CompleteInput(string input, int cursorIndex, Hashtable options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 3586, 4002);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 3706, 3804) || true) && (input == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 3706, 3804);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 3757, 3789);

                    return s_emptyCommandCompletion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 3706, 3804);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 3820, 3886);

                var
                parsedInput = f_1441_3838_3885(input, cursorIndex)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 3900, 3991);

                return f_1441_3907_3990(f_1441_3925_3942(parsedInput), f_1441_3944_3961(parsedInput), f_1441_3963_3980(parsedInput), options);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 3586, 4002);

                System.Tuple<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[], System.Management.Automation.Language.IScriptPosition>
                f_1441_3838_3885(string
                input, int
                cursorIndex)
                {
                    var return_v = MapStringInputToParsedInput(input, cursorIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 3838, 3885);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1441_3925_3942(System.Tuple<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[], System.Management.Automation.Language.IScriptPosition>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 3925, 3942);
                    return return_v;
                }


                System.Management.Automation.Language.Token[]
                f_1441_3944_3961(System.Tuple<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[], System.Management.Automation.Language.IScriptPosition>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 3944, 3961);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptPosition
                f_1441_3963_3980(System.Tuple<System.Management.Automation.Language.Ast, System.Management.Automation.Language.Token[], System.Management.Automation.Language.IScriptPosition>
                this_param)
                {
                    var return_v = this_param.Item3;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 3963, 3980);
                    return return_v;
                }


                System.Management.Automation.CommandCompletion
                f_1441_3907_3990(System.Management.Automation.Language.Ast
                ast, System.Management.Automation.Language.Token[]
                tokens, System.Management.Automation.Language.IScriptPosition
                positionOfCursor, System.Collections.Hashtable
                options)
                {
                    var return_v = CompleteInputImpl(ast, tokens, positionOfCursor, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 3907, 3990);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 3586, 4002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 3586, 4002);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public static CommandCompletion CompleteInput(Ast ast, Token[] tokens, IScriptPosition positionOfCursor, Hashtable options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 4385, 5037);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 4533, 4649) || true) && (ast == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 4533, 4649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 4582, 4634);

                    throw f_1441_4588_4633("ast");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 4533, 4649);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 4665, 4787) || true) && (tokens == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 4665, 4787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 4717, 4772);

                    throw f_1441_4723_4771("tokens");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 4665, 4787);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 4803, 4945) || true) && (positionOfCursor == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 4803, 4945);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 4865, 4930);

                    throw f_1441_4871_4929("positionOfCursor");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 4803, 4945);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 4961, 5026);

                return f_1441_4968_5025(ast, tokens, positionOfCursor, options);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 4385, 5037);

                System.Management.Automation.PSArgumentNullException
                f_1441_4588_4633(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 4588, 4633);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1441_4723_4771(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 4723, 4771);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1441_4871_4929(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 4871, 4929);
                    return return_v;
                }


                System.Management.Automation.CommandCompletion
                f_1441_4968_5025(System.Management.Automation.Language.Ast
                ast, System.Management.Automation.Language.Token[]
                tokens, System.Management.Automation.Language.IScriptPosition
                positionOfCursor, System.Collections.Hashtable
                options)
                {
                    var return_v = CompleteInputImpl(ast, tokens, positionOfCursor, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 4968, 5025);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 4385, 5037);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 4385, 5037);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "powershell")]
        public static CommandCompletion CompleteInput(string input, int cursorIndex, Hashtable options, PowerShell powershell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 5761, 9246);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 6023, 6121) || true) && (input == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 6023, 6121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 6074, 6106);

                    return s_emptyCommandCompletion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 6023, 6121);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 6137, 6272) || true) && (cursorIndex > f_1441_6155_6167(input))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 6137, 6272);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 6201, 6257);

                    throw f_1441_6207_6256("cursorIndex");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 6137, 6272);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 6288, 6418) || true) && (powershell == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 6288, 6418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 6344, 6403);

                    throw f_1441_6350_6402("powershell");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 6288, 6418);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 6524, 6607);

                var
                debugger = (DynAbs.Tracing.TraceSender.Conditional_F1(1441, 6539, 6568) || (((f_1441_6540_6559(powershell) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1441, 6571, 6599)) || DynAbs.Tracing.TraceSender.Conditional_F3(1441, 6602, 6606))) ? f_1441_6571_6599(f_1441_6571_6590(powershell)) : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 6621, 6787) || true) && ((debugger != null) && (DynAbs.Tracing.TraceSender.Expression_True(1441, 6625, 6668) && f_1441_6647_6668(debugger)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 6621, 6787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 6702, 6772);

                    return f_1441_6709_6771(input, cursorIndex, options, debugger);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 6621, 6787);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 6803, 6862);

                var
                remoteRunspace = f_1441_6824_6843(powershell) as RemoteRunspace
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 6876, 9138) || true) && (remoteRunspace != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 6876, 9138);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 7103, 7294) || true) && (f_1441_7107_7126(powershell) || (DynAbs.Tracing.TraceSender.Expression_False(1441, 7107, 7201) || (f_1441_7131_7166(remoteRunspace) != RunspaceAvailability.Available)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 7103, 7294);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 7243, 7275);

                        return s_emptyCommandCompletion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 7103, 7294);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 7859, 9123) || true) && (f_1441_7863_7882_M(!powershell.IsChild))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 7859, 9123);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 7924, 7972);

                        f_1441_7924_7971(remoteRunspace);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 7994, 9104) || true) && (f_1441_7998_8075(f_1441_7998_8030(remoteRunspace), Runspaces.RunspaceCapability.Default))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 7994, 9104);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 8585, 8606);

                            int
                            replacementIndex
                            = default(int);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 8632, 8654);

                            int
                            replacementLength
                            = default(int);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 8682, 8710);

                            f_1441_8682_8709(f_1441_8682_8701(powershell));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 8736, 8858);

                            var
                            results = f_1441_8750_8857(powershell, input, cursorIndex, true, out replacementIndex, out replacementLength)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 8884, 9081);

                            return f_1441_8891_9080(f_1441_8943_9009(results ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.List<System.Management.Automation.CompletionResult>>(1441, 8976, 9008) ?? EmptyCompletionResult)), -1, replacementIndex, replacementLength);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 7994, 9104);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 7859, 9123);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 6876, 9138);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 9154, 9235);

                return f_1441_9161_9234(input, cursorIndex, options, powershell);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 5761, 9246);

                int
                f_1441_6155_6167(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 6155, 6167);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1441_6207_6256(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 6207, 6256);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1441_6350_6402(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 6350, 6402);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1441_6540_6559(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 6540, 6559);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1441_6571_6590(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 6571, 6590);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1441_6571_6599(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 6571, 6599);
                    return return_v;
                }


                bool
                f_1441_6647_6668(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.InBreakpoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 6647, 6668);
                    return return_v;
                }


                System.Management.Automation.CommandCompletion
                f_1441_6709_6771(string
                input, int
                cursorIndex, System.Collections.Hashtable
                options, System.Management.Automation.Debugger
                debugger)
                {
                    var return_v = CompleteInputInDebugger(input, cursorIndex, options, debugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 6709, 6771);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1441_6824_6843(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 6824, 6843);
                    return return_v;
                }


                bool
                f_1441_7107_7126(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 7107, 7126);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1441_7131_7166(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 7131, 7166);
                    return return_v;
                }


                bool
                f_1441_7863_7882_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 7863, 7882);
                    return return_v;
                }


                int
                f_1441_7924_7971(System.Management.Automation.RemoteRunspace
                remoteRunspace)
                {
                    CheckScriptCallOnRemoteRunspace(remoteRunspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 7924, 7971);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspaceCapability
                f_1441_7998_8030(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.GetCapabilities();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 7998, 8030);
                    return return_v;
                }


                bool
                f_1441_7998_8075(System.Management.Automation.Runspaces.RunspaceCapability
                this_param, System.Management.Automation.Runspaces.RunspaceCapability
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 7998, 8075);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1441_8682_8701(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 8682, 8701);
                    return return_v;
                }


                int
                f_1441_8682_8709(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 8682, 8709);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1441_8750_8857(System.Management.Automation.PowerShell
                powershell, string
                input, int
                cursorIndex, bool
                remoteToWin7, out int
                replacementIndex, out int
                replacementLength)
                {
                    var return_v = InvokeLegacyTabExpansion(powershell, input, cursorIndex, remoteToWin7, out replacementIndex, out replacementLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 8750, 8857);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>
                f_1441_8943_9009(System.Collections.Generic.IList<System.Management.Automation.CompletionResult>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 8943, 9009);
                    return return_v;
                }


                System.Management.Automation.CommandCompletion
                f_1441_8891_9080(System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>
                matches, int
                currentMatchIndex, int
                replacementIndex, int
                replacementLength)
                {
                    var return_v = new System.Management.Automation.CommandCompletion(matches, currentMatchIndex, replacementIndex, replacementLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 8891, 9080);
                    return return_v;
                }


                System.Management.Automation.CommandCompletion
                f_1441_9161_9234(string
                input, int
                cursorIndex, System.Collections.Hashtable
                options, System.Management.Automation.PowerShell
                powershell)
                {
                    var return_v = CallScriptWithStringParameterSet(input, cursorIndex, options, powershell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 9161, 9234);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 5761, 9246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 5761, 9246);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        [SuppressMessage("Microsoft.Naming", "CA1704:IdentifiersShouldBeSpelledCorrectly", MessageId = "powershell")]
        public static CommandCompletion CompleteInput(Ast ast, Token[] tokens, IScriptPosition cursorPosition, Hashtable options, PowerShell powershell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 9867, 13647);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 10155, 10271) || true) && (ast == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 10155, 10271);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 10204, 10256);

                    throw f_1441_10210_10255("ast");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 10155, 10271);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 10287, 10409) || true) && (tokens == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 10287, 10409);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 10339, 10394);

                    throw f_1441_10345_10393("tokens");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 10287, 10409);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 10425, 10563) || true) && (cursorPosition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 10425, 10563);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 10485, 10548);

                    throw f_1441_10491_10547("cursorPosition");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 10425, 10563);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 10579, 10709) || true) && (powershell == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 10579, 10709);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 10635, 10694);

                    throw f_1441_10641_10693("powershell");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 10579, 10709);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 10815, 10898);

                var
                debugger = (DynAbs.Tracing.TraceSender.Conditional_F1(1441, 10830, 10859) || (((f_1441_10831_10850(powershell) != null) && DynAbs.Tracing.TraceSender.Conditional_F2(1441, 10862, 10890)) || DynAbs.Tracing.TraceSender.Conditional_F3(1441, 10893, 10897))) ? f_1441_10862_10890(f_1441_10862_10881(powershell)) : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 10912, 11087) || true) && ((debugger != null) && (DynAbs.Tracing.TraceSender.Expression_True(1441, 10916, 10959) && f_1441_10938_10959(debugger)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 10912, 11087);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 10993, 11072);

                    return f_1441_11000_11071(ast, tokens, cursorPosition, options, debugger);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 10912, 11087);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 11103, 11162);

                var
                remoteRunspace = f_1441_11124_11143(powershell) as RemoteRunspace
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 11176, 13533) || true) && (remoteRunspace != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 11176, 13533);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 11403, 11594) || true) && (f_1441_11407_11426(powershell) || (DynAbs.Tracing.TraceSender.Expression_False(1441, 11407, 11501) || (f_1441_11431_11466(remoteRunspace) != RunspaceAvailability.Available)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 11403, 11594);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 11543, 11575);

                        return s_emptyCommandCompletion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 11403, 11594);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 11614, 13518) || true) && (f_1441_11618_11637_M(!powershell.IsChild))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 11614, 13518);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 11679, 11727);

                        f_1441_11679_11726(remoteRunspace);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 11749, 13499) || true) && (f_1441_11753_11830(f_1441_11753_11785(remoteRunspace), Runspaces.RunspaceCapability.Default))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 11749, 13499);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 12229, 12250);

                            int
                            replacementIndex
                            = default(int);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 12276, 12298);

                            int
                            replacementLength
                            = default(int);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 12438, 12466);

                            f_1441_12438_12465(f_1441_12438_12457(powershell));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 12492, 12554);

                            var
                            inputAndCursor = f_1441_12513_12553(cursorPosition)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 12580, 12726);

                            var
                            results = f_1441_12594_12725(powershell, f_1441_12631_12651(inputAndCursor), f_1441_12653_12673(inputAndCursor), true, out replacementIndex, out replacementLength)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 12752, 12972);

                            return f_1441_12759_12971(f_1441_12811_12877(results ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.List<System.Management.Automation.CompletionResult>>(1441, 12844, 12876) ?? EmptyCompletionResult)), -1, replacementIndex + f_1441_12931_12951(inputAndCursor), replacementLength);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 11749, 13499);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 11749, 13499);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 13246, 13277);

                            string
                            input = f_1441_13261_13276(f_1441_13261_13271(ast))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 13303, 13369);

                            int
                            cursorIndex = f_1441_13321_13368(((InternalScriptPosition)cursorPosition))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 13395, 13476);

                            return f_1441_13402_13475(input, cursorIndex, options, powershell);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 11749, 13499);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 11614, 13518);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 11176, 13533);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 13549, 13636);

                return f_1441_13556_13635(ast, tokens, cursorPosition, options, powershell);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 9867, 13647);

                System.Management.Automation.PSArgumentNullException
                f_1441_10210_10255(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 10210, 10255);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1441_10345_10393(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 10345, 10393);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1441_10491_10547(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 10491, 10547);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1441_10641_10693(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 10641, 10693);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1441_10831_10850(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 10831, 10850);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1441_10862_10881(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 10862, 10881);
                    return return_v;
                }


                System.Management.Automation.Debugger
                f_1441_10862_10890(System.Management.Automation.Runspaces.Runspace
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 10862, 10890);
                    return return_v;
                }


                bool
                f_1441_10938_10959(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.InBreakpoint;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 10938, 10959);
                    return return_v;
                }


                System.Management.Automation.CommandCompletion
                f_1441_11000_11071(System.Management.Automation.Language.Ast
                ast, System.Management.Automation.Language.Token[]
                tokens, System.Management.Automation.Language.IScriptPosition
                cursorPosition, System.Collections.Hashtable
                options, System.Management.Automation.Debugger
                debugger)
                {
                    var return_v = CompleteInputInDebugger(ast, tokens, cursorPosition, options, debugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 11000, 11071);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1441_11124_11143(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 11124, 11143);
                    return return_v;
                }


                bool
                f_1441_11407_11426(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.IsNested;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 11407, 11426);
                    return return_v;
                }


                System.Management.Automation.Runspaces.RunspaceAvailability
                f_1441_11431_11466(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspaceAvailability;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 11431, 11466);
                    return return_v;
                }


                bool
                f_1441_11618_11637_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 11618, 11637);
                    return return_v;
                }


                int
                f_1441_11679_11726(System.Management.Automation.RemoteRunspace
                remoteRunspace)
                {
                    CheckScriptCallOnRemoteRunspace(remoteRunspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 11679, 11726);
                    return 0;
                }


                System.Management.Automation.Runspaces.RunspaceCapability
                f_1441_11753_11785(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.GetCapabilities();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 11753, 11785);
                    return return_v;
                }


                bool
                f_1441_11753_11830(System.Management.Automation.Runspaces.RunspaceCapability
                this_param, System.Management.Automation.Runspaces.RunspaceCapability
                obj)
                {
                    var return_v = this_param.Equals((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 11753, 11830);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1441_12438_12457(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 12438, 12457);
                    return return_v;
                }


                int
                f_1441_12438_12465(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 12438, 12465);
                    return 0;
                }


                System.Tuple<string, int, int>
                f_1441_12513_12553(System.Management.Automation.Language.IScriptPosition
                cursorPosition)
                {
                    var return_v = GetInputAndCursorFromAst(cursorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 12513, 12553);
                    return return_v;
                }


                string
                f_1441_12631_12651(System.Tuple<string, int, int>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 12631, 12651);
                    return return_v;
                }


                int
                f_1441_12653_12673(System.Tuple<string, int, int>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 12653, 12673);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1441_12594_12725(System.Management.Automation.PowerShell
                powershell, string
                input, int
                cursorIndex, bool
                remoteToWin7, out int
                replacementIndex, out int
                replacementLength)
                {
                    var return_v = InvokeLegacyTabExpansion(powershell, input, cursorIndex, remoteToWin7, out replacementIndex, out replacementLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 12594, 12725);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>
                f_1441_12811_12877(System.Collections.Generic.IList<System.Management.Automation.CompletionResult>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 12811, 12877);
                    return return_v;
                }


                int
                f_1441_12931_12951(System.Tuple<string, int, int>
                this_param)
                {
                    var return_v = this_param.Item3;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 12931, 12951);
                    return return_v;
                }


                System.Management.Automation.CommandCompletion
                f_1441_12759_12971(System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>
                matches, int
                currentMatchIndex, int
                replacementIndex, int
                replacementLength)
                {
                    var return_v = new System.Management.Automation.CommandCompletion(matches, currentMatchIndex, replacementIndex, replacementLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 12759, 12971);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1441_13261_13271(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 13261, 13271);
                    return return_v;
                }


                string
                f_1441_13261_13276(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 13261, 13276);
                    return return_v;
                }


                int
                f_1441_13321_13368(System.Management.Automation.Language.InternalScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 13321, 13368);
                    return return_v;
                }


                System.Management.Automation.CommandCompletion
                f_1441_13402_13475(string
                input, int
                cursorIndex, System.Collections.Hashtable
                options, System.Management.Automation.PowerShell
                powershell)
                {
                    var return_v = CallScriptWithStringParameterSet(input, cursorIndex, options, powershell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 13402, 13475);
                    return return_v;
                }


                System.Management.Automation.CommandCompletion
                f_1441_13556_13635(System.Management.Automation.Language.Ast
                ast, System.Management.Automation.Language.Token[]
                tokens, System.Management.Automation.Language.IScriptPosition
                cursorPosition, System.Collections.Hashtable
                options, System.Management.Automation.PowerShell
                powershell)
                {
                    var return_v = CallScriptWithAstParameterSet(ast, tokens, cursorPosition, options, powershell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 13556, 13635);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 9867, 13647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 9867, 13647);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public CompletionResult GetNextResult(bool forward)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1441, 14085, 14733);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 14161, 14192);

                CompletionResult
                result = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 14206, 14242);

                var
                count = f_1441_14218_14241(f_1441_14218_14235())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 14256, 14692) || true) && (count > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 14256, 14692);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 14303, 14341);

                    CurrentMatchIndex += DynAbs.Tracing.TraceSender.TraceInitialMemberAccessWrapper(() => (DynAbs.Tracing.TraceSender.Conditional_F1(1441, 14324, 14331) || ((forward && DynAbs.Tracing.TraceSender.Conditional_F2(1441, 14334, 14335)) || DynAbs.Tracing.TraceSender.Conditional_F3(1441, 14338, 14340))) ? 1 : -1, 1441, 14303, 14320);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 14359, 14611) || true) && (f_1441_14363_14380() >= count)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 14359, 14611);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 14431, 14453);

                        CurrentMatchIndex = 0;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 14359, 14611);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 14359, 14611);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 14495, 14611) || true) && (f_1441_14499_14516() < 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 14495, 14611);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 14562, 14592);

                            CurrentMatchIndex = count - 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 14495, 14611);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 14359, 14611);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 14631, 14677);

                    result = f_1441_14640_14676(f_1441_14640_14657(), f_1441_14658_14675());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 14256, 14692);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 14708, 14722);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1441, 14085, 14733);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>
                f_1441_14218_14235()
                {
                    var return_v = CompletionMatches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 14218, 14235);
                    return return_v;
                }


                int
                f_1441_14218_14241(System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 14218, 14241);
                    return return_v;
                }


                int
                f_1441_14363_14380()
                {
                    var return_v = CurrentMatchIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 14363, 14380);
                    return return_v;
                }


                int
                f_1441_14499_14516()
                {
                    var return_v = CurrentMatchIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 14499, 14516);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>
                f_1441_14640_14657()
                {
                    var return_v = CompletionMatches;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 14640, 14657);
                    return return_v;
                }


                int
                f_1441_14658_14675()
                {
                    var return_v = CurrentMatchIndex;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 14658, 14675);
                    return return_v;
                }


                System.Management.Automation.CompletionResult
                f_1441_14640_14676(System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 14640, 14676);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 14085, 14733);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 14085, 14733);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CommandCompletion CompleteInputInDebugger(string input, int cursorIndex, Hashtable options, Debugger debugger)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 15387, 16235);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 15538, 15636) || true) && (input == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 15538, 15636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 15589, 15621);

                    return s_emptyCommandCompletion;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 15538, 15636);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 15652, 15787) || true) && (cursorIndex > f_1441_15670_15682(input))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 15652, 15787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 15716, 15772);

                    throw f_1441_15722_15771("cursorIndex");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 15652, 15787);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 15803, 15929) || true) && (debugger == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 15803, 15929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 15857, 15914);

                    throw f_1441_15863_15913("debugger");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 15803, 15929);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 15945, 15988);

                Command
                cmd = f_1441_15959_15987("TabExpansion2")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 16002, 16043);

                f_1441_16002_16042(f_1441_16002_16016(cmd), "InputScript", input);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 16057, 16105);

                f_1441_16057_16104(f_1441_16057_16071(cmd), "CursorColumn", cursorIndex);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 16119, 16158);

                f_1441_16119_16157(f_1441_16119_16133(cmd), "Options", options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 16174, 16224);

                return f_1441_16181_16223(cmd, debugger);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 15387, 16235);

                int
                f_1441_15670_15682(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 15670, 15682);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1441_15722_15771(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 15722, 15771);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1441_15863_15913(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 15863, 15913);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1441_15959_15987(string
                command)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 15959, 15987);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1441_16002_16016(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 16002, 16016);
                    return return_v;
                }


                int
                f_1441_16002_16042(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, string
                name, string
                value)
                {
                    this_param.Add(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 16002, 16042);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1441_16057_16071(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 16057, 16071);
                    return return_v;
                }


                int
                f_1441_16057_16104(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, string
                name, int
                value)
                {
                    this_param.Add(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 16057, 16104);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1441_16119_16133(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 16119, 16133);
                    return return_v;
                }


                int
                f_1441_16119_16157(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, string
                name, System.Collections.Hashtable
                value)
                {
                    this_param.Add(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 16119, 16157);
                    return 0;
                }


                System.Management.Automation.CommandCompletion
                f_1441_16181_16223(System.Management.Automation.Runspaces.Command
                cmd, System.Management.Automation.Debugger
                debugger)
                {
                    var return_v = ProcessCompleteInputCommand(cmd, debugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 16181, 16223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 15387, 16235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 15387, 16235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static CommandCompletion CompleteInputInDebugger(Ast ast, Token[] tokens, IScriptPosition cursorPosition, Hashtable options, Debugger debugger)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 16732, 18197);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 16909, 17025) || true) && (ast == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 16909, 17025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 16958, 17010);

                    throw f_1441_16964_17009("ast");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 16909, 17025);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 17041, 17163) || true) && (tokens == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 17041, 17163);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 17093, 17148);

                    throw f_1441_17099_17147("tokens");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 17041, 17163);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 17179, 17317) || true) && (cursorPosition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 17179, 17317);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 17239, 17302);

                    throw f_1441_17245_17301("cursorPosition");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 17179, 17317);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 17333, 17459) || true) && (debugger == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 17333, 17459);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 17387, 17444);

                    throw f_1441_17393_17443("debugger");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 17333, 17459);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 17536, 17843) || true) && ((debugger is RemoteDebugger) || (DynAbs.Tracing.TraceSender.Expression_False(1441, 17540, 17589) || f_1441_17572_17589(debugger)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 17536, 17843);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 17623, 17654);

                    string
                    input = f_1441_17638_17653(f_1441_17638_17648(ast))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 17672, 17738);

                    int
                    cursorIndex = f_1441_17690_17737(((InternalScriptPosition)cursorPosition))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 17758, 17828);

                    return f_1441_17765_17827(input, cursorIndex, options, debugger);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 17536, 17843);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 17859, 17902);

                Command
                cmd = f_1441_17873_17901("TabExpansion2")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 17916, 17947);

                f_1441_17916_17946(f_1441_17916_17930(cmd), "Ast", ast);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 17961, 17998);

                f_1441_17961_17997(f_1441_17961_17975(cmd), "Tokens", tokens);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 18012, 18067);

                f_1441_18012_18066(f_1441_18012_18026(cmd), "PositionOfCursor", cursorPosition);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 18081, 18120);

                f_1441_18081_18119(f_1441_18081_18095(cmd), "Options", options);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 18136, 18186);

                return f_1441_18143_18185(cmd, debugger);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 16732, 18197);

                System.Management.Automation.PSArgumentNullException
                f_1441_16964_17009(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 16964, 17009);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1441_17099_17147(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 17099, 17147);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1441_17245_17301(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 17245, 17301);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1441_17393_17443(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 17393, 17443);
                    return return_v;
                }


                bool
                f_1441_17572_17589(System.Management.Automation.Debugger
                this_param)
                {
                    var return_v = this_param.IsPushed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 17572, 17589);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1441_17638_17648(System.Management.Automation.Language.Ast
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 17638, 17648);
                    return return_v;
                }


                string
                f_1441_17638_17653(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 17638, 17653);
                    return return_v;
                }


                int
                f_1441_17690_17737(System.Management.Automation.Language.InternalScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 17690, 17737);
                    return return_v;
                }


                System.Management.Automation.CommandCompletion
                f_1441_17765_17827(string
                input, int
                cursorIndex, System.Collections.Hashtable
                options, System.Management.Automation.Debugger
                debugger)
                {
                    var return_v = CompleteInputInDebugger(input, cursorIndex, options, debugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 17765, 17827);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Command
                f_1441_17873_17901(string
                command)
                {
                    var return_v = new System.Management.Automation.Runspaces.Command(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 17873, 17901);
                    return return_v;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1441_17916_17930(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 17916, 17930);
                    return return_v;
                }


                int
                f_1441_17916_17946(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, string
                name, System.Management.Automation.Language.Ast
                value)
                {
                    this_param.Add(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 17916, 17946);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1441_17961_17975(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 17961, 17975);
                    return return_v;
                }


                int
                f_1441_17961_17997(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, string
                name, System.Management.Automation.Language.Token[]
                value)
                {
                    this_param.Add(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 17961, 17997);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1441_18012_18026(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 18012, 18026);
                    return return_v;
                }


                int
                f_1441_18012_18066(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, string
                name, System.Management.Automation.Language.IScriptPosition
                value)
                {
                    this_param.Add(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 18012, 18066);
                    return 0;
                }


                System.Management.Automation.Runspaces.CommandParameterCollection
                f_1441_18081_18095(System.Management.Automation.Runspaces.Command
                this_param)
                {
                    var return_v = this_param.Parameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 18081, 18095);
                    return return_v;
                }


                int
                f_1441_18081_18119(System.Management.Automation.Runspaces.CommandParameterCollection
                this_param, string
                name, System.Collections.Hashtable
                value)
                {
                    this_param.Add(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 18081, 18119);
                    return 0;
                }


                System.Management.Automation.CommandCompletion
                f_1441_18143_18185(System.Management.Automation.Runspaces.Command
                cmd, System.Management.Automation.Debugger
                debugger)
                {
                    var return_v = ProcessCompleteInputCommand(cmd, debugger);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 18143, 18185);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 16732, 18197);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 16732, 18197);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandCompletion ProcessCompleteInputCommand(
                    Command cmd,
                    Debugger debugger)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 18209, 18876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 18353, 18392);

                PSCommand
                command = f_1441_18373_18391(cmd)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 18406, 18475);

                PSDataCollection<PSObject>
                output = f_1441_18442_18474()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 18491, 18532);

                f_1441_18491_18531(
                            debugger, command, output);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 18548, 18817) || true) && (f_1441_18552_18564(output) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 18548, 18817);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 18603, 18669);

                    var
                    commandCompletion = f_1441_18627_18647(f_1441_18627_18636(output, 0)) as CommandCompletion
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 18687, 18802) || true) && (commandCompletion != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 18687, 18802);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 18758, 18783);

                        return commandCompletion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 18687, 18802);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 18548, 18817);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 18833, 18865);

                return s_emptyCommandCompletion;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 18209, 18876);

                System.Management.Automation.PSCommand
                f_1441_18373_18391(System.Management.Automation.Runspaces.Command
                command)
                {
                    var return_v = new System.Management.Automation.PSCommand(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 18373, 18391);
                    return return_v;
                }


                System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                f_1441_18442_18474()
                {
                    var return_v = new System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 18442, 18474);
                    return return_v;
                }


                System.Management.Automation.DebuggerCommandResults
                f_1441_18491_18531(System.Management.Automation.Debugger
                this_param, System.Management.Automation.PSCommand
                command, System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                output)
                {
                    var return_v = this_param.ProcessCommand(command, output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 18491, 18531);
                    return return_v;
                }


                int
                f_1441_18552_18564(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 18552, 18564);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1441_18627_18636(System.Management.Automation.PSDataCollection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 18627, 18636);
                    return return_v;
                }


                object
                f_1441_18627_18647(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 18627, 18647);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 18209, 18876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 18209, 18876);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void CheckScriptCallOnRemoteRunspace(RemoteRunspace remoteRunspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 18945, 19775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 19052, 19136);

                var
                remoteRunspaceInternal = f_1441_19081_19135(f_1441_19081_19108(remoteRunspace))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 19150, 19764) || true) && (remoteRunspaceInternal != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 19150, 19764);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 19218, 19302);

                    var
                    transportManager = f_1441_19241_19301(f_1441_19241_19284(remoteRunspaceInternal))
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 19320, 19749) || true) && (transportManager != null && (DynAbs.Tracing.TraceSender.Expression_True(1441, 19324, 19386) && f_1441_19352_19378(transportManager) == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 19320, 19749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 19622, 19730);

                        throw f_1441_19628_19729(f_1441_19671_19728());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 19320, 19749);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 19150, 19764);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 18945, 19775);

                System.Management.Automation.Runspaces.RunspacePool
                f_1441_19081_19108(System.Management.Automation.RemoteRunspace
                this_param)
                {
                    var return_v = this_param.RunspacePool;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 19081, 19108);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                f_1441_19081_19135(System.Management.Automation.Runspaces.RunspacePool
                this_param)
                {
                    var return_v = this_param.RemoteRunspacePoolInternal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 19081, 19135);
                    return return_v;
                }


                System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
                f_1441_19241_19284(System.Management.Automation.Runspaces.Internal.RemoteRunspacePoolInternal
                this_param)
                {
                    var return_v = this_param.DataStructureHandler;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 19241, 19284);
                    return return_v;
                }


                System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
                f_1441_19241_19301(System.Management.Automation.Internal.ClientRunspacePoolDataStructureHandler
                this_param)
                {
                    var return_v = this_param.TransportManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 19241, 19301);
                    return return_v;
                }


                System.Management.Automation.Runspaces.TypeTable
                f_1441_19352_19378(System.Management.Automation.Remoting.Client.BaseClientSessionTransportManager
                this_param)
                {
                    var return_v = this_param.TypeTable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 19352, 19378);
                    return return_v;
                }


                string
                f_1441_19671_19728()
                {
                    var return_v = TabCompletionStrings.CannotDeserializeTabCompletionResult;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 19671, 19728);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1441_19628_19729(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 19628, 19729);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 18945, 19775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 18945, 19775);
            }
        }

        private static CommandCompletion CallScriptWithStringParameterSet(string input, int cursorIndex, Hashtable options, PowerShell powershell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 19787, 20981);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 19986, 20014);

                    f_1441_19986_20013(f_1441_19986_20005(powershell));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 20032, 20202);

                    f_1441_20032_20201(f_1441_20032_20158(f_1441_20032_20111(f_1441_20032_20070(powershell, "TabExpansion2"), input), cursorIndex), options);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 20220, 20254);

                    var
                    results = f_1441_20234_20253(powershell)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 20272, 20384) || true) && (results == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 20272, 20384);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 20333, 20365);

                        return s_emptyCommandCompletion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 20272, 20384);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 20404, 20749) || true) && (f_1441_20408_20421(results) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 20404, 20749);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 20468, 20507);

                        var
                        result = f_1441_20481_20506(f_1441_20495_20505(results, 0))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 20529, 20581);

                        var
                        commandCompletion = result as CommandCompletion
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 20603, 20730) || true) && (commandCompletion != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 20603, 20730);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 20682, 20707);

                            return commandCompletion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 20603, 20730);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 20404, 20749);
                    }
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1441, 20778, 20825);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1441, 20778, 20825);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1441, 20839, 20922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 20879, 20907);

                    f_1441_20879_20906(f_1441_20879_20898(powershell));
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1441, 20839, 20922);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 20938, 20970);

                return s_emptyCommandCompletion;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 19787, 20981);

                System.Management.Automation.PSCommand
                f_1441_19986_20005(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 19986, 20005);
                    return return_v;
                }


                int
                f_1441_19986_20013(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 19986, 20013);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1441_20032_20070(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 20032, 20070);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1441_20032_20111(System.Management.Automation.PowerShell
                this_param, string
                value)
                {
                    var return_v = this_param.AddArgument((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 20032, 20111);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1441_20032_20158(System.Management.Automation.PowerShell
                this_param, int
                value)
                {
                    var return_v = this_param.AddArgument((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 20032, 20158);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1441_20032_20201(System.Management.Automation.PowerShell
                this_param, System.Collections.Hashtable
                value)
                {
                    var return_v = this_param.AddArgument((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 20032, 20201);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1441_20234_20253(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 20234, 20253);
                    return return_v;
                }


                int
                f_1441_20408_20421(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 20408, 20421);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1441_20495_20505(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 20495, 20505);
                    return return_v;
                }


                object
                f_1441_20481_20506(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObject.Base((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 20481, 20506);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1441_20879_20898(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 20879, 20898);
                    return return_v;
                }


                int
                f_1441_20879_20906(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 20879, 20906);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 19787, 20981);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 19787, 20981);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandCompletion CallScriptWithAstParameterSet(Ast ast, Token[] tokens, IScriptPosition cursorPosition, Hashtable options, PowerShell powershell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 20993, 22253);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 21215, 21243);

                    f_1441_21215_21242(f_1441_21215_21234(powershell));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 21261, 21474);

                    f_1441_21261_21473(f_1441_21261_21430(f_1441_21261_21380(f_1441_21261_21338(f_1441_21261_21299(powershell, "TabExpansion2"), ast), tokens), cursorPosition), options);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 21492, 21526);

                    var
                    results = f_1441_21506_21525(powershell)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 21544, 21656) || true) && (results == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 21544, 21656);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 21605, 21637);

                        return s_emptyCommandCompletion;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 21544, 21656);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 21676, 22021) || true) && (f_1441_21680_21693(results) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 21676, 22021);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 21740, 21779);

                        var
                        result = f_1441_21753_21778(f_1441_21767_21777(results, 0))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 21801, 21853);

                        var
                        commandCompletion = result as CommandCompletion
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 21875, 22002) || true) && (commandCompletion != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 21875, 22002);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 21954, 21979);

                            return commandCompletion;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 21875, 22002);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 21676, 22021);
                    }
                }
                catch (Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1441, 22050, 22097);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1441, 22050, 22097);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1441, 22111, 22194);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 22151, 22179);

                    f_1441_22151_22178(f_1441_22151_22170(powershell));
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1441, 22111, 22194);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 22210, 22242);

                return s_emptyCommandCompletion;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 20993, 22253);

                System.Management.Automation.PSCommand
                f_1441_21215_21234(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 21215, 21234);
                    return return_v;
                }


                int
                f_1441_21215_21242(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 21215, 21242);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1441_21261_21299(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 21261, 21299);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1441_21261_21338(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.Language.Ast
                value)
                {
                    var return_v = this_param.AddArgument((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 21261, 21338);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1441_21261_21380(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.Language.Token[]
                value)
                {
                    var return_v = this_param.AddArgument((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 21261, 21380);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1441_21261_21430(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.Language.IScriptPosition
                value)
                {
                    var return_v = this_param.AddArgument((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 21261, 21430);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1441_21261_21473(System.Management.Automation.PowerShell
                this_param, System.Collections.Hashtable
                value)
                {
                    var return_v = this_param.AddArgument((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 21261, 21473);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1441_21506_21525(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 21506, 21525);
                    return return_v;
                }


                int
                f_1441_21680_21693(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 21680, 21693);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1441_21767_21777(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 21767, 21777);
                    return return_v;
                }


                object
                f_1441_21753_21778(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObject.Base((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 21753, 21778);
                    return return_v;
                }


                System.Management.Automation.PSCommand
                f_1441_22151_22170(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Commands;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 22151, 22170);
                    return return_v;
                }


                int
                f_1441_22151_22178(System.Management.Automation.PSCommand
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 22151, 22178);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 20993, 22253);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 20993, 22253);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static CommandCompletion CompleteInputImpl(Ast ast, Token[] tokens, IScriptPosition positionOfCursor, Hashtable options)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 22366, 27475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 22755, 27464);
                using (var
                powershell = f_1441_22779_22826(RunspaceMode.CurrentRunspace)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 22860, 22917);

                    var
                    context = f_1441_22874_22916()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 22937, 23030);

                    bool
                    cleanupModuleAnalysisAppDomain = f_1441_22975_23029(context)
                    ;

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 23296, 23322);

                        int
                        replacementIndex = -1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 23344, 23371);

                        int
                        replacementLength = -1
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 23393, 23431);

                        List<CompletionResult>
                        results = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 23455, 23874) || true) && (f_1441_23459_23501(powershell))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 23455, 23874);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 23551, 23615);

                            var
                            inputAndCursor = f_1441_23572_23614(positionOfCursor)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 23641, 23784);

                            results = f_1441_23651_23783(powershell, f_1441_23688_23708(inputAndCursor), f_1441_23710_23730(inputAndCursor), false, out replacementIndex, out replacementLength);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 23810, 23851);

                            replacementIndex += f_1441_23830_23850(inputAndCursor);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 23455, 23874);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 23898, 26473) || true) && (results == null || (DynAbs.Tracing.TraceSender.Expression_False(1441, 23902, 23939) || f_1441_23921_23934(results) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 23898, 26473);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 25859, 25947);

                            var
                            completionAnalysis = f_1441_25884_25946(ast, tokens, positionOfCursor, options)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 25973, 26070);

                            results = f_1441_25983_26069(completionAnalysis, powershell, out replacementIndex, out replacementLength);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 23898, 26473);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 26497, 26554);

                        var
                        completionResults = results ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.List<System.Management.Automation.CompletionResult>>(1441, 26521, 26553) ?? EmptyCompletionResult)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 26956, 27180);

                        return f_1441_26963_27179(f_1441_27011_27062(completionResults), -1, replacementIndex, replacementLength);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1441, 27217, 27449);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 27265, 27430) || true) && (cleanupModuleAnalysisAppDomain)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 27265, 27430);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 27349, 27407);

                            f_1441_27349_27406(context);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 27265, 27430);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1441, 27217, 27449);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1441, 22755, 27464);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 22366, 27475);

                System.Management.Automation.PowerShell
                f_1441_22779_22826(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 22779, 22826);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1441_22874_22916()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 22874, 22916);
                    return return_v;
                }


                bool
                f_1441_22975_23029(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TakeResponsibilityForModuleAnalysisAppDomain();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 22975, 23029);
                    return return_v;
                }


                bool
                f_1441_23459_23501(System.Management.Automation.PowerShell
                powershell)
                {
                    var return_v = NeedToInvokeLegacyTabExpansion(powershell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 23459, 23501);
                    return return_v;
                }


                System.Tuple<string, int, int>
                f_1441_23572_23614(System.Management.Automation.Language.IScriptPosition
                cursorPosition)
                {
                    var return_v = GetInputAndCursorFromAst(cursorPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 23572, 23614);
                    return return_v;
                }


                string
                f_1441_23688_23708(System.Tuple<string, int, int>
                this_param)
                {
                    var return_v = this_param.Item1;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 23688, 23708);
                    return return_v;
                }


                int
                f_1441_23710_23730(System.Tuple<string, int, int>
                this_param)
                {
                    var return_v = this_param.Item2;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 23710, 23730);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1441_23651_23783(System.Management.Automation.PowerShell
                powershell, string
                input, int
                cursorIndex, bool
                remoteToWin7, out int
                replacementIndex, out int
                replacementLength)
                {
                    var return_v = InvokeLegacyTabExpansion(powershell, input, cursorIndex, remoteToWin7, out replacementIndex, out replacementLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 23651, 23783);
                    return return_v;
                }


                int
                f_1441_23830_23850(System.Tuple<string, int, int>
                this_param)
                {
                    var return_v = this_param.Item3;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 23830, 23850);
                    return return_v;
                }


                int
                f_1441_23921_23934(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 23921, 23934);
                    return return_v;
                }


                System.Management.Automation.CompletionAnalysis
                f_1441_25884_25946(System.Management.Automation.Language.Ast
                ast, System.Management.Automation.Language.Token[]
                tokens, System.Management.Automation.Language.IScriptPosition
                cursorPosition, System.Collections.Hashtable
                options)
                {
                    var return_v = new System.Management.Automation.CompletionAnalysis(ast, tokens, cursorPosition, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 25884, 25946);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1441_25983_26069(System.Management.Automation.CompletionAnalysis
                this_param, System.Management.Automation.PowerShell
                powerShell, out int
                replacementIndex, out int
                replacementLength)
                {
                    var return_v = this_param.GetResults(powerShell, out replacementIndex, out replacementLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 25983, 26069);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>
                f_1441_27011_27062(System.Collections.Generic.IList<System.Management.Automation.CompletionResult>
                list)
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>(list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 27011, 27062);
                    return return_v;
                }


                System.Management.Automation.CommandCompletion
                f_1441_26963_27179(System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>
                matches, int
                currentMatchIndex, int
                replacementIndex, int
                replacementLength)
                {
                    var return_v = new System.Management.Automation.CommandCompletion(matches, currentMatchIndex, replacementIndex, replacementLength);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 26963, 27179);
                    return return_v;
                }


                int
                f_1441_27349_27406(System.Management.Automation.ExecutionContext
                this_param)
                {
                    this_param.ReleaseResponsibilityForModuleAnalysisAppDomain();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 27349, 27406);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 22366, 27475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 22366, 27475);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Tuple<string, int, int> GetInputAndCursorFromAst(IScriptPosition cursorPosition)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 27487, 27851);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 27607, 27638);

                var
                line = f_1441_27618_27637(cursorPosition)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 27652, 27697);

                var
                cursor = f_1441_27665_27692(cursorPosition) - 1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 27711, 27759);

                var
                adjustment = f_1441_27728_27749(cursorPosition) - cursor
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 27773, 27840);

                return f_1441_27780_27839(f_1441_27793_27818(line, 0, cursor), cursor, adjustment);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 27487, 27851);

                string
                f_1441_27618_27637(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Line;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 27618, 27637);
                    return return_v;
                }


                int
                f_1441_27665_27692(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.ColumnNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 27665, 27692);
                    return return_v;
                }


                int
                f_1441_27728_27749(System.Management.Automation.Language.IScriptPosition
                this_param)
                {
                    var return_v = this_param.Offset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 27728, 27749);
                    return return_v;
                }


                string
                f_1441_27793_27818(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 27793, 27818);
                    return return_v;
                }


                System.Tuple<string, int, int>
                f_1441_27780_27839(string
                item1, int
                item2, int
                item3)
                {
                    var return_v = Tuple.Create(item1, item2, item3);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 27780, 27839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 27487, 27851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 27487, 27851);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool NeedToInvokeLegacyTabExpansion(PowerShell powershell)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 27863, 28475);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 27961, 28015);

                var
                executionContext = f_1441_27984_28014(powershell)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 28124, 28207);

                var
                functionInfo = f_1441_28143_28206(f_1441_28143_28178(executionContext), "TabExpansion")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 28221, 28276) || true) && (functionInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 28221, 28276);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 28264, 28276);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 28221, 28276);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 28292, 28369);

                var
                aliasInfo = f_1441_28308_28368(f_1441_28308_28343(executionContext), "TabExpansion")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 28383, 28435) || true) && (aliasInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 28383, 28435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 28423, 28435);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 28383, 28435);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 28451, 28464);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 27863, 28475);

                System.Management.Automation.ExecutionContext
                f_1441_27984_28014(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.GetContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 27984, 28014);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1441_28143_28178(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 28143, 28178);
                    return return_v;
                }


                System.Management.Automation.FunctionInfo
                f_1441_28143_28206(System.Management.Automation.SessionStateInternal
                this_param, string
                name)
                {
                    var return_v = this_param.GetFunction(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 28143, 28206);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1441_28308_28343(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 28308, 28343);
                    return return_v;
                }


                System.Management.Automation.AliasInfo
                f_1441_28308_28368(System.Management.Automation.SessionStateInternal
                this_param, string
                aliasName)
                {
                    var return_v = this_param.GetAlias(aliasName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 28308, 28368);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 27863, 28475);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 27863, 28475);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static List<CompletionResult> InvokeLegacyTabExpansion(PowerShell powershell, string input, int cursorIndex, bool remoteToWin7, out int replacementIndex, out int replacementLength)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 28487, 31029);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 28700, 28738);

                List<CompletionResult>
                results = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 28754, 28844);

                var
                legacyInput = (DynAbs.Tracing.TraceSender.Conditional_F1(1441, 28772, 28801) || (((cursorIndex != f_1441_28788_28800(input)) && DynAbs.Tracing.TraceSender.Conditional_F2(1441, 28804, 28835)) || DynAbs.Tracing.TraceSender.Conditional_F3(1441, 28838, 28843))) ? f_1441_28804_28835(input, 0, cursorIndex) : input
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 28858, 28869);

                char
                quote
                = default(char);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 28883, 28972);

                var
                lastword = f_1441_28898_28971(legacyInput, out replacementIndex, out quote)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 28986, 29044);

                replacementLength = f_1441_29006_29024(legacyInput) - replacementIndex;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 29058, 29113);

                var
                helper = f_1441_29071_29112(powershell)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 29129, 29214);

                f_1441_29129_29213(f_1441_29129_29191(f_1441_29129_29166(
                            powershell, "TabExpansion"), legacyInput), lastword);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 29230, 29256);

                Exception
                exceptionThrown
                = default(Exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 29270, 29340);

                var
                oldResults = f_1441_29287_29339(helper, out exceptionThrown)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 29354, 30358) || true) && (oldResults != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 29354, 30358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 29410, 29449);

                    results = f_1441_29420_29448();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 29467, 30343);
                        foreach (var oldResult in f_1441_29493_29503_I(oldResults))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 29467, 30343);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 29545, 29613);

                            var
                            completionResult = f_1441_29568_29592(oldResult) as CompletionResult
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 29635, 30270) || true) && (completionResult == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 29635, 30270);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 29713, 29753);

                                var
                                oldResultStr = f_1441_29732_29752(oldResult)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 29867, 30165) || true) && (quote != '\0')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 29867, 30165);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 29942, 30138) || true) && (f_1441_29946_29965(oldResultStr) > 2 && (DynAbs.Tracing.TraceSender.Expression_True(1441, 29946, 29997) && f_1441_29973_29988(oldResultStr, 0) != quote))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 29942, 30138);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 30063, 30107);

                                        oldResultStr = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (quote).ToString(), 1441, 30078, 30083) + oldResultStr + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (quote).ToString(), 1441, 30101, 30106);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 29942, 30138);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 29867, 30165);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 30193, 30247);

                                completionResult = f_1441_30212_30246(oldResultStr);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 29635, 30270);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 30294, 30324);

                            f_1441_30294_30323(
                                                results, completionResult);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 29467, 30343);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1441, 1, 877);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1441, 1, 877);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 29354, 30358);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 30374, 30987) || true) && (remoteToWin7 && (DynAbs.Tracing.TraceSender.Expression_True(1441, 30378, 30433) && (results == null || (DynAbs.Tracing.TraceSender.Expression_False(1441, 30395, 30432) || f_1441_30414_30427(results) == 0))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 30374, 30987);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 30467, 30533);

                    string
                    quoteStr = (DynAbs.Tracing.TraceSender.Conditional_F1(1441, 30485, 30498) || ((quote == '\0' && DynAbs.Tracing.TraceSender.Conditional_F2(1441, 30501, 30513)) || DynAbs.Tracing.TraceSender.Conditional_F3(1441, 30516, 30532))) ? string.Empty : f_1441_30516_30532(quote)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 30551, 30664);

                    results = f_1441_30561_30663(helper, lastword, replacementIndex == 0, quoteStr);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 30682, 30807);

                    var
                    cmdletResults = f_1441_30702_30806(helper, lastword, quoteStr, replacementIndex == 0)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 30827, 30972) || true) && (cmdletResults != null && (DynAbs.Tracing.TraceSender.Expression_True(1441, 30831, 30879) && f_1441_30856_30875(cmdletResults) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 30827, 30972);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 30921, 30953);

                        f_1441_30921_30952(results, cmdletResults);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 30827, 30972);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 30374, 30987);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 31003, 31018);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 28487, 31029);

                int
                f_1441_28788_28800(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 28788, 28800);
                    return return_v;
                }


                string
                f_1441_28804_28835(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 28804, 28835);
                    return return_v;
                }


                string
                f_1441_28898_28971(string
                sentence, out int
                replacementIndexOut, out char
                closingQuote)
                {
                    var return_v = LastWordFinder.FindLastWord(sentence, out replacementIndexOut, out closingQuote);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 28898, 28971);
                    return return_v;
                }


                int
                f_1441_29006_29024(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 29006, 29024);
                    return return_v;
                }


                System.Management.Automation.PowerShellExecutionHelper
                f_1441_29071_29112(System.Management.Automation.PowerShell
                powershell)
                {
                    var return_v = new System.Management.Automation.PowerShellExecutionHelper(powershell);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 29071, 29112);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1441_29129_29166(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 29129, 29166);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1441_29129_29191(System.Management.Automation.PowerShell
                this_param, string
                value)
                {
                    var return_v = this_param.AddArgument((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 29129, 29191);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1441_29129_29213(System.Management.Automation.PowerShell
                this_param, string
                value)
                {
                    var return_v = this_param.AddArgument((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 29129, 29213);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1441_29287_29339(System.Management.Automation.PowerShellExecutionHelper
                this_param, out System.Exception
                exceptionThrown)
                {
                    var return_v = this_param.ExecuteCurrentPowerShell(out exceptionThrown);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 29287, 29339);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1441_29420_29448()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 29420, 29448);
                    return return_v;
                }


                object
                f_1441_29568_29592(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObject.Base((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 29568, 29592);
                    return return_v;
                }


                string
                f_1441_29732_29752(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 29732, 29752);
                    return return_v;
                }


                int
                f_1441_29946_29965(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 29946, 29965);
                    return return_v;
                }


                char
                f_1441_29973_29988(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 29973, 29988);
                    return return_v;
                }


                System.Management.Automation.CompletionResult
                f_1441_30212_30246(string
                completionText)
                {
                    var return_v = new System.Management.Automation.CompletionResult(completionText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 30212, 30246);
                    return return_v;
                }


                int
                f_1441_30294_30323(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Management.Automation.CompletionResult
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 30294, 30323);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1441_29493_29503_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 29493, 29503);
                    return return_v;
                }


                int
                f_1441_30414_30427(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 30414, 30427);
                    return return_v;
                }


                string
                f_1441_30516_30532(char
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 30516, 30532);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1441_30561_30663(System.Management.Automation.PowerShellExecutionHelper
                helper, string
                lastWord, bool
                completingAtStartOfLine, string
                quote)
                {
                    var return_v = PSv2CompletionCompleter.PSv2GenerateMatchSetOfFiles(helper, lastWord, completingAtStartOfLine, quote);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 30561, 30663);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                f_1441_30702_30806(System.Management.Automation.PowerShellExecutionHelper
                helper, string
                lastWord, string
                quote, bool
                completingAtStartOfLine)
                {
                    var return_v = PSv2CompletionCompleter.PSv2GenerateMatchSetOfCmdlets(helper, lastWord, quote, completingAtStartOfLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 30702, 30806);
                    return return_v;
                }


                int
                f_1441_30856_30875(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 30856, 30875);
                    return return_v;
                }


                int
                f_1441_30921_30952(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                this_param, System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 30921, 30952);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 28487, 31029);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 28487, 31029);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private static class PSv2CompletionCompleter
        {
            private static readonly Regex s_cmdletTabRegex;

            private static readonly char[] s_charsRequiringQuotedString;

            private static bool PSv2IsCommandLikeCmdlet(string lastWord, out bool isSnapinSpecified)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 32242, 33010);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 32363, 32389);

                    isSnapinSpecified = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 32409, 32475);

                    string[]
                    cmdletParts = f_1441_32432_32474(lastWord, Utils.Separators.Backslash)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 32493, 32623) || true) && (f_1441_32497_32515(cmdletParts) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 32493, 32623);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 32562, 32604);

                        return f_1441_32569_32603(s_cmdletTabRegex, lastWord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 32493, 32623);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 32643, 32962) || true) && (f_1441_32647_32665(cmdletParts) == 2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 32643, 32962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 32712, 32779);

                        isSnapinSpecified = f_1441_32732_32778(cmdletParts[0]);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 32801, 32943) || true) && (isSnapinSpecified)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 32801, 32943);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 32872, 32920);

                            return f_1441_32879_32919(s_cmdletTabRegex, cmdletParts[1]);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 32801, 32943);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 32643, 32962);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 32982, 32995);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 32242, 33010);

                    string[]
                    f_1441_32432_32474(string
                    this_param, params char[]
                    separator)
                    {
                        var return_v = this_param.Split(separator);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 32432, 32474);
                        return return_v;
                    }


                    int
                    f_1441_32497_32515(string[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 32497, 32515);
                        return return_v;
                    }


                    bool
                    f_1441_32569_32603(System.Text.RegularExpressions.Regex
                    this_param, string
                    input)
                    {
                        var return_v = this_param.IsMatch(input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 32569, 32603);
                        return return_v;
                    }


                    int
                    f_1441_32647_32665(string[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 32647, 32665);
                        return return_v;
                    }


                    bool
                    f_1441_32732_32778(string
                    psSnapinId)
                    {
                        var return_v = PSSnapInInfo.IsPSSnapinIdValid(psSnapinId);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 32732, 32778);
                        return return_v;
                    }


                    bool
                    f_1441_32879_32919(System.Text.RegularExpressions.Regex
                    this_param, string
                    input)
                    {
                        var return_v = this_param.IsMatch(input);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 32879, 32919);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 32242, 33010);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 32242, 33010);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private struct CommandAndName
            {

                internal readonly PSObject Command;

                internal readonly PSSnapinQualifiedName CommandName;

                internal CommandAndName(PSObject command, PSSnapinQualifiedName commandName)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(1441, 33213, 33425);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 33330, 33353);

                        this.Command = command;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 33375, 33406);

                        this.CommandName = commandName;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(1441, 33213, 33425);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 33213, 33425);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 33213, 33425);
                    }
                }
                static CommandAndName()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1441, 33026, 33440);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1441, 33026, 33440);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 33026, 33440);
                }
            }

            internal static List<CompletionResult> PSv2GenerateMatchSetOfCmdlets(PowerShellExecutionHelper helper, string lastWord, string quote, bool completingAtStartOfLine)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 33853, 35985);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 34049, 34092);

                    var
                    results = f_1441_34063_34091()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 34110, 34133);

                    bool
                    isSnapinSpecified
                    = default(bool);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 34153, 34252) || true) && (!f_1441_34158_34214(lastWord, out isSnapinSpecified))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 34153, 34252);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 34237, 34252);

                        return results;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 34153, 34252);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 34272, 34507);

                    f_1441_34272_34506(f_1441_34272_34451(f_1441_34272_34403(f_1441_34272_34344(f_1441_34272_34296(helper), "Get-Command"), "Name", lastWord + "*"), "Sort-Object"), "Property", "Name");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 34527, 34553);

                    Exception
                    exceptionThrown
                    = default(Exception);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 34571, 34656);

                    Collection<PSObject>
                    commands = f_1441_34603_34655(helper, out exceptionThrown)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 34676, 35935) || true) && (commands != null && (DynAbs.Tracing.TraceSender.Expression_True(1441, 34680, 34718) && f_1441_34700_34714(commands) > 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 34676, 35935);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 34819, 34881);

                        CommandAndName[]
                        cmdlets = new CommandAndName[f_1441_34865_34879(commands)]
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 35082, 35087);
                            // if the command causes cmdlets from multiple mshsnapin is returned,
                            // append the mshsnapin name to disambiguate the cmdlets.
                            for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 35073, 35416) || true) && (i < f_1441_35093_35107(commands))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 35109, 35112)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 35073, 35416))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 35073, 35416);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 35162, 35193);

                                PSObject
                                command = f_1441_35181_35192(commands, i)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 35219, 35275);

                                string
                                cmdletFullName = f_1441_35243_35274(command)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 35301, 35393);

                                cmdlets[i] = f_1441_35314_35392(command, f_1441_35342_35391(cmdletFullName));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1441, 1, 344);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1441, 1, 344);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 35440, 35916) || true) && (isSnapinSpecified)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 35440, 35916);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 35511, 35709);
                                foreach (CommandAndName cmdlet in f_1441_35545_35552_I(cmdlets))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 35511, 35709);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 35610, 35682);

                                    f_1441_35610_35681(cmdlet, true, completingAtStartOfLine, quote, results);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 35511, 35709);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1441, 1, 199);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1441, 1, 199);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 35440, 35916);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 35440, 35916);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 35807, 35893);

                            f_1441_35807_35892(cmdlets, completingAtStartOfLine, quote, results);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 35440, 35916);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 34676, 35935);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 35955, 35970);

                    return results;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 33853, 35985);

                    System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                    f_1441_34063_34091()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 34063, 34091);
                        return return_v;
                    }


                    bool
                    f_1441_34158_34214(string
                    lastWord, out bool
                    isSnapinSpecified)
                    {
                        var return_v = PSv2IsCommandLikeCmdlet(lastWord, out isSnapinSpecified);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 34158, 34214);
                        return return_v;
                    }


                    System.Management.Automation.PowerShell
                    f_1441_34272_34296(System.Management.Automation.PowerShellExecutionHelper
                    this_param)
                    {
                        var return_v = this_param.CurrentPowerShell
                        ;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 34272, 34296);
                        return return_v;
                    }


                    System.Management.Automation.PowerShell
                    f_1441_34272_34344(System.Management.Automation.PowerShell
                    this_param, string
                    cmdlet)
                    {
                        var return_v = this_param.AddCommand(cmdlet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 34272, 34344);
                        return return_v;
                    }


                    System.Management.Automation.PowerShell
                    f_1441_34272_34403(System.Management.Automation.PowerShell
                    this_param, string
                    parameterName, string
                    value)
                    {
                        var return_v = this_param.AddParameter(parameterName, (object)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 34272, 34403);
                        return return_v;
                    }


                    System.Management.Automation.PowerShell
                    f_1441_34272_34451(System.Management.Automation.PowerShell
                    this_param, string
                    cmdlet)
                    {
                        var return_v = this_param.AddCommand(cmdlet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 34272, 34451);
                        return return_v;
                    }


                    System.Management.Automation.PowerShell
                    f_1441_34272_34506(System.Management.Automation.PowerShell
                    this_param, string
                    parameterName, string
                    value)
                    {
                        var return_v = this_param.AddParameter(parameterName, (object)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 34272, 34506);
                        return return_v;
                    }


                    System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                    f_1441_34603_34655(System.Management.Automation.PowerShellExecutionHelper
                    this_param, out System.Exception
                    exceptionThrown)
                    {
                        var return_v = this_param.ExecuteCurrentPowerShell(out exceptionThrown);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 34603, 34655);
                        return return_v;
                    }


                    int
                    f_1441_34700_34714(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 34700, 34714);
                        return return_v;
                    }


                    int
                    f_1441_34865_34879(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 34865, 34879);
                        return return_v;
                    }


                    int
                    f_1441_35093_35107(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 35093, 35107);
                        return return_v;
                    }


                    System.Management.Automation.PSObject
                    f_1441_35181_35192(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 35181, 35192);
                        return return_v;
                    }


                    string
                    f_1441_35243_35274(System.Management.Automation.PSObject
                    psObject)
                    {
                        var return_v = CmdletInfo.GetFullName(psObject);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 35243, 35274);
                        return return_v;
                    }


                    System.Management.Automation.PSSnapinQualifiedName
                    f_1441_35342_35391(string
                    name)
                    {
                        var return_v = PSSnapinQualifiedName.GetInstance(name);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 35342, 35391);
                        return return_v;
                    }


                    System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.CommandAndName
                    f_1441_35314_35392(System.Management.Automation.PSObject
                    command, System.Management.Automation.PSSnapinQualifiedName
                    commandName)
                    {
                        var return_v = new System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.CommandAndName(command, commandName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 35314, 35392);
                        return return_v;
                    }


                    int
                    f_1441_35610_35681(System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.CommandAndName
                    commandAndName, bool
                    useFullName, bool
                    completingAtStartOfLine, string
                    quote, System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                    results)
                    {
                        AddCommandResult(commandAndName, useFullName, completingAtStartOfLine, quote, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 35610, 35681);
                        return 0;
                    }


                    System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.CommandAndName[]
                    f_1441_35545_35552_I(System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.CommandAndName[]
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 35545, 35552);
                        return return_v;
                    }


                    int
                    f_1441_35807_35892(System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.CommandAndName[]
                    cmdlets, bool
                    completingAtStartOfLine, string
                    quote, System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                    results)
                    {
                        PrependSnapInNameForSameCmdletNames(cmdlets, completingAtStartOfLine, quote, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 35807, 35892);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 33853, 35985);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 33853, 35985);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static void AddCommandResult(CommandAndName commandAndName, bool useFullName, bool completingAtStartOfLine, string quote, List<CompletionResult> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 36001, 37345);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 36195, 36288);

                    f_1441_36195_36287(results != null, "Caller needs to make sure the result list is not null");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 36308, 36411);

                    string
                    name = (DynAbs.Tracing.TraceSender.Conditional_F1(1441, 36322, 36333) || ((useFullName && DynAbs.Tracing.TraceSender.Conditional_F2(1441, 36336, 36371)) || DynAbs.Tracing.TraceSender.Conditional_F3(1441, 36374, 36410))) ? f_1441_36336_36371(commandAndName.CommandName) : f_1441_36374_36410(commandAndName.CommandName)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 36429, 36511);

                    string
                    quotedFileName = f_1441_36453_36510(name, quote, completingAtStartOfLine)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 36531, 36619);

                    var
                    commandType = f_1441_36549_36618(commandAndName.Command, "CommandType")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 36637, 36728) || true) && (commandType == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 36637, 36728);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 36702, 36709);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 36637, 36728);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 36748, 36763);

                    string
                    toolTip
                    = default(string);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 36781, 36858);

                    string
                    displayName = f_1441_36802_36857(commandAndName.Command, "Name")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 36878, 37208) || true) && (f_1441_36882_36899(commandType) == CommandTypes.Cmdlet || (DynAbs.Tracing.TraceSender.Expression_False(1441, 36882, 36971) || f_1441_36926_36943(commandType) == CommandTypes.Application))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 36878, 37208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 37013, 37085);

                        toolTip = f_1441_37023_37084(commandAndName.Command, "Definition");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 36878, 37208);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 36878, 37208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 37167, 37189);

                        toolTip = displayName;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 36878, 37208);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 37228, 37330);

                    f_1441_37228_37329(
                                    results, f_1441_37240_37328(quotedFileName, displayName, CompletionResultType.Command, toolTip));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 36001, 37345);

                    int
                    f_1441_36195_36287(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 36195, 36287);
                        return 0;
                    }


                    string
                    f_1441_36336_36371(System.Management.Automation.PSSnapinQualifiedName
                    this_param)
                    {
                        var return_v = this_param.FullName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 36336, 36371);
                        return return_v;
                    }


                    string
                    f_1441_36374_36410(System.Management.Automation.PSSnapinQualifiedName
                    this_param)
                    {
                        var return_v = this_param.ShortName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 36374, 36410);
                        return return_v;
                    }


                    string
                    f_1441_36453_36510(string
                    completionText, string
                    quote, bool
                    completingAtStartOfLine)
                    {
                        var return_v = AddQuoteIfNecessary(completionText, quote, completingAtStartOfLine);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 36453, 36510);
                        return return_v;
                    }


                    System.Management.Automation.CommandTypes?
                    f_1441_36549_36618(System.Management.Automation.PSObject
                    psObject, string
                    propertyName)
                    {
                        var return_v = SafeGetProperty<CommandTypes?>(psObject, propertyName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 36549, 36618);
                        return return_v;
                    }


                    string
                    f_1441_36802_36857(System.Management.Automation.PSObject
                    psObject, string
                    propertyName)
                    {
                        var return_v = SafeGetProperty<string>(psObject, propertyName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 36802, 36857);
                        return return_v;
                    }


                    System.Management.Automation.CommandTypes
                    f_1441_36882_36899(System.Management.Automation.CommandTypes?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 36882, 36899);
                        return return_v;
                    }


                    System.Management.Automation.CommandTypes
                    f_1441_36926_36943(System.Management.Automation.CommandTypes?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 36926, 36943);
                        return return_v;
                    }


                    string
                    f_1441_37023_37084(System.Management.Automation.PSObject
                    psObject, string
                    propertyName)
                    {
                        var return_v = SafeGetProperty<string>(psObject, propertyName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 37023, 37084);
                        return return_v;
                    }


                    System.Management.Automation.CompletionResult
                    f_1441_37240_37328(string
                    completionText, string
                    listItemText, System.Management.Automation.CompletionResultType
                    resultType, string
                    toolTip)
                    {
                        var return_v = new System.Management.Automation.CompletionResult(completionText, listItemText, resultType, toolTip);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 37240, 37328);
                        return return_v;
                    }


                    int
                    f_1441_37228_37329(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                    this_param, System.Management.Automation.CompletionResult
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 37228, 37329);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 36001, 37345);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 36001, 37345);
                }
            }

            private static void PrependSnapInNameForSameCmdletNames(CommandAndName[] cmdlets, bool completingAtStartOfLine, string quote, List<CompletionResult> results)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 37361, 39028);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 37551, 37709);

                    f_1441_37551_37708(cmdlets != null && (DynAbs.Tracing.TraceSender.Expression_True(1441, 37570, 37607) && f_1441_37589_37603(cmdlets) > 0), "HasMultiplePSSnapIns must be called with a non-empty collection of PSObject");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 37729, 37739);

                    int
                    i = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 37757, 37786);

                    bool
                    previousMatched = false
                    ;
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 37804, 39013) || true) && (true)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 37804, 39013);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 37857, 37900);

                            CommandAndName
                            commandAndName = cmdlets[i]
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 37924, 37946);

                            int
                            lookAhead = i + 1
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 37968, 38195) || true) && (lookAhead >= f_1441_37985_37999(cmdlets))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 37968, 38195);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 38049, 38140);

                                f_1441_38049_38139(commandAndName, previousMatched, completingAtStartOfLine, quote, results);
                                DynAbs.Tracing.TraceSender.TraceBreak(1441, 38166, 38172);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 37968, 38195);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 38219, 38274);

                            CommandAndName
                            nextCommandAndName = cmdlets[lookAhead]
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 38298, 38966) || true) && (f_1441_38302_38520(f_1441_38347_38383(commandAndName.CommandName), f_1441_38414_38454(nextCommandAndName.CommandName), StringComparison.OrdinalIgnoreCase) == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 38298, 38966);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 38575, 38655);

                                f_1441_38575_38654(commandAndName, true, completingAtStartOfLine, quote, results);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 38681, 38704);

                                previousMatched = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 38298, 38966);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 38298, 38966);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 38802, 38893);

                                f_1441_38802_38892(commandAndName, previousMatched, completingAtStartOfLine, quote, results);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 38919, 38943);

                                previousMatched = false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 38298, 38966);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 38990, 38994);

                            i++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 37804, 39013);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1441, 37804, 39013);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1441, 37804, 39013);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 37361, 39028);

                    int
                    f_1441_37589_37603(System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.CommandAndName[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 37589, 37603);
                        return return_v;
                    }


                    int
                    f_1441_37551_37708(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 37551, 37708);
                        return 0;
                    }


                    int
                    f_1441_37985_37999(System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.CommandAndName[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 37985, 37999);
                        return return_v;
                    }


                    int
                    f_1441_38049_38139(System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.CommandAndName
                    commandAndName, bool
                    useFullName, bool
                    completingAtStartOfLine, string
                    quote, System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                    results)
                    {
                        AddCommandResult(commandAndName, useFullName, completingAtStartOfLine, quote, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 38049, 38139);
                        return 0;
                    }


                    string
                    f_1441_38347_38383(System.Management.Automation.PSSnapinQualifiedName
                    this_param)
                    {
                        var return_v = this_param.ShortName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 38347, 38383);
                        return return_v;
                    }


                    string
                    f_1441_38414_38454(System.Management.Automation.PSSnapinQualifiedName
                    this_param)
                    {
                        var return_v = this_param.ShortName;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 38414, 38454);
                        return return_v;
                    }


                    int
                    f_1441_38302_38520(string
                    strA, string
                    strB, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Compare(strA, strB, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 38302, 38520);
                        return return_v;
                    }


                    int
                    f_1441_38575_38654(System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.CommandAndName
                    commandAndName, bool
                    useFullName, bool
                    completingAtStartOfLine, string
                    quote, System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                    results)
                    {
                        AddCommandResult(commandAndName, useFullName, completingAtStartOfLine, quote, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 38575, 38654);
                        return 0;
                    }


                    int
                    f_1441_38802_38892(System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.CommandAndName
                    commandAndName, bool
                    useFullName, bool
                    completingAtStartOfLine, string
                    quote, System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                    results)
                    {
                        AddCommandResult(commandAndName, useFullName, completingAtStartOfLine, quote, results);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 38802, 38892);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 37361, 39028);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 37361, 39028);
                }
            }

            internal static List<CompletionResult> PSv2GenerateMatchSetOfFiles(PowerShellExecutionHelper helper, string lastWord, bool completingAtStartOfLine, string quote)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 39130, 43338);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 39324, 39367);

                    var
                    results = f_1441_39338_39366()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 40124, 40160);

                    lastWord = lastWord ?? (DynAbs.Tracing.TraceSender.Expression_Null<string>(1441, 40135, 40159) ?? string.Empty);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 40178, 40232);

                    bool
                    isLastWordEmpty = f_1441_40201_40231(lastWord)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 40250, 40315);

                    bool
                    lastCharIsStar = !isLastWordEmpty && (DynAbs.Tracing.TraceSender.Expression_True(1441, 40272, 40314) && f_1441_40292_40314(lastWord, '*'))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 40333, 40411);

                    bool
                    containsGlobChars = f_1441_40358_40410(lastWord)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 40431, 40464);

                    string
                    wildWord = lastWord + "*"
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 40482, 40563);

                    bool
                    shouldFullyQualifyPaths = f_1441_40513_40562(helper, lastWord)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 40843, 41024);

                    bool
                    isProviderDirectPath = f_1441_40871_40923(lastWord, @"\\", StringComparison.Ordinal) || (DynAbs.Tracing.TraceSender.Expression_False(1441, 40871, 41023) || f_1441_40972_41023(lastWord, "//", StringComparison.Ordinal))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 41044, 41085);

                    List<PathItemAndConvertedPath>
                    s1 = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 41103, 41144);

                    List<PathItemAndConvertedPath>
                    s2 = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 41164, 41418) || true) && (containsGlobChars && (DynAbs.Tracing.TraceSender.Expression_True(1441, 41168, 41205) && !isLastWordEmpty))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 41164, 41418);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 41247, 41399);

                        s1 = f_1441_41252_41398(helper, lastWord, shouldFullyQualifyPaths);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 41164, 41418);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 41438, 41670) || true) && (!lastCharIsStar)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 41438, 41670);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 41499, 41651);

                        s2 = f_1441_41504_41650(helper, wildWord, shouldFullyQualifyPaths);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 41438, 41670);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 41690, 41771);

                    IEnumerable<PathItemAndConvertedPath>
                    combinedMatches = f_1441_41746_41770(s1, s2)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 41791, 43288) || true) && (combinedMatches != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 41791, 43288);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 41860, 43269);
                            foreach (var combinedMatch in f_1441_41890_41905_I(combinedMatches))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 41860, 43269);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 41955, 42025);

                                string
                                combinedMatchPath = f_1441_41982_42024(combinedMatch.Path)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 42051, 42139);

                                string
                                combinedMatchConvertedPath = f_1441_42087_42138(combinedMatch.ConvertedPath)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 42165, 42259);

                                string
                                completionText = (DynAbs.Tracing.TraceSender.Conditional_F1(1441, 42189, 42209) || ((isProviderDirectPath && DynAbs.Tracing.TraceSender.Conditional_F2(1441, 42212, 42238)) || DynAbs.Tracing.TraceSender.Conditional_F3(1441, 42241, 42258))) ? combinedMatchConvertedPath : combinedMatchPath
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 42287, 42372);

                                completionText = f_1441_42304_42371(completionText, quote, completingAtStartOfLine);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 42400, 42480);

                                bool?
                                isContainer = f_1441_42420_42479(combinedMatch.Item, "PSIsContainer")
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 42506, 42584);

                                string
                                childName = f_1441_42525_42583(combinedMatch.Item, "PSChildName")
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 42610, 42695);

                                string
                                toolTip = f_1441_42627_42694(combinedMatch.ConvertedPath)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 42723, 43246) || true) && (isContainer != null && (DynAbs.Tracing.TraceSender.Expression_True(1441, 42727, 42767) && childName != null) && (DynAbs.Tracing.TraceSender.Expression_True(1441, 42727, 42786) && toolTip != null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 42723, 43246);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 42844, 43107);

                                    CompletionResultType
                                    resultType = (DynAbs.Tracing.TraceSender.Conditional_F1(1441, 42878, 42895) || ((f_1441_42878_42895(isContainer) && DynAbs.Tracing.TraceSender.Conditional_F2(1441, 42965, 43003)) || DynAbs.Tracing.TraceSender.Conditional_F3(1441, 43073, 43106))) ? CompletionResultType.ProviderContainer
                                    : CompletionResultType.ProviderItem
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 43137, 43219);

                                    f_1441_43137_43218(results, f_1441_43149_43217(completionText, childName, resultType, toolTip));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 42723, 43246);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 41860, 43269);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1441, 1, 1410);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1441, 1, 1410);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 41791, 43288);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 43308, 43323);

                    return results;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 39130, 43338);

                    System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                    f_1441_39338_39366()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.CompletionResult>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 39338, 39366);
                        return return_v;
                    }


                    bool
                    f_1441_40201_40231(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 40201, 40231);
                        return return_v;
                    }


                    bool
                    f_1441_40292_40314(string
                    this_param, char
                    value)
                    {
                        var return_v = this_param.EndsWith(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 40292, 40314);
                        return return_v;
                    }


                    bool
                    f_1441_40358_40410(string
                    pattern)
                    {
                        var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 40358, 40410);
                        return return_v;
                    }


                    bool
                    f_1441_40513_40562(System.Management.Automation.PowerShellExecutionHelper
                    helper, string
                    lastWord)
                    {
                        var return_v = PSv2ShouldFullyQualifyPathsPath(helper, lastWord);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 40513, 40562);
                        return return_v;
                    }


                    bool
                    f_1441_40871_40923(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.StartsWith(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 40871, 40923);
                        return return_v;
                    }


                    bool
                    f_1441_40972_41023(string
                    this_param, string
                    value, System.StringComparison
                    comparisonType)
                    {
                        var return_v = this_param.StartsWith(value, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 40972, 41023);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    f_1441_41252_41398(System.Management.Automation.PowerShellExecutionHelper
                    helper, string
                    path, bool
                    shouldFullyQualifyPaths)
                    {
                        var return_v = PSv2FindMatches(helper, path, shouldFullyQualifyPaths);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 41252, 41398);
                        return return_v;
                    }


                    System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    f_1441_41504_41650(System.Management.Automation.PowerShellExecutionHelper
                    helper, string
                    path, bool
                    shouldFullyQualifyPaths)
                    {
                        var return_v = PSv2FindMatches(helper, path, shouldFullyQualifyPaths);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 41504, 41650);
                        return return_v;
                    }


                    System.Collections.Generic.IEnumerable<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    f_1441_41746_41770(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    s1, System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    s2)
                    {
                        var return_v = CombineMatchSets(s1, s2);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 41746, 41770);
                        return return_v;
                    }


                    string
                    f_1441_41982_42024(string
                    pattern)
                    {
                        var return_v = WildcardPattern.Escape(pattern);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 41982, 42024);
                        return return_v;
                    }


                    string
                    f_1441_42087_42138(string
                    pattern)
                    {
                        var return_v = WildcardPattern.Escape(pattern);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 42087, 42138);
                        return return_v;
                    }


                    string
                    f_1441_42304_42371(string
                    completionText, string
                    quote, bool
                    completingAtStartOfLine)
                    {
                        var return_v = AddQuoteIfNecessary(completionText, quote, completingAtStartOfLine);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 42304, 42371);
                        return return_v;
                    }


                    bool?
                    f_1441_42420_42479(System.Management.Automation.PSObject
                    psObject, string
                    propertyName)
                    {
                        var return_v = SafeGetProperty<bool?>(psObject, propertyName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 42420, 42479);
                        return return_v;
                    }


                    string
                    f_1441_42525_42583(System.Management.Automation.PSObject
                    psObject, string
                    propertyName)
                    {
                        var return_v = SafeGetProperty<string>(psObject, propertyName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 42525, 42583);
                        return return_v;
                    }


                    string
                    f_1441_42627_42694(string
                    obj)
                    {
                        var return_v = PowerShellExecutionHelper.SafeToString((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 42627, 42694);
                        return return_v;
                    }


                    bool
                    f_1441_42878_42895(bool?
                    this_param)
                    {
                        var return_v = this_param.Value
                        ;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 42878, 42895);
                        return return_v;
                    }


                    System.Management.Automation.CompletionResult
                    f_1441_43149_43217(string
                    completionText, string
                    listItemText, System.Management.Automation.CompletionResultType
                    resultType, string
                    toolTip)
                    {
                        var return_v = new System.Management.Automation.CompletionResult(completionText, listItemText, resultType, toolTip);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 43149, 43217);
                        return return_v;
                    }


                    int
                    f_1441_43137_43218(System.Collections.Generic.List<System.Management.Automation.CompletionResult>
                    this_param, System.Management.Automation.CompletionResult
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 43137, 43218);
                        return 0;
                    }


                    System.Collections.Generic.IEnumerable<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    f_1441_41890_41905_I(System.Collections.Generic.IEnumerable<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 41890, 41905);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 39130, 43338);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 39130, 43338);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static string AddQuoteIfNecessary(string completionText, string quote, bool completingAtStartOfLine)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 43354, 44232);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 43495, 44175) || true) && (f_1441_43499_43554(completionText, s_charsRequiringQuotedString) != -1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 43495, 44175);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 43602, 43668);

                        bool
                        needAmpersand = f_1441_43623_43635(quote) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1441, 43623, 43667) && completingAtStartOfLine)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 43690, 43742);

                        string
                        quoteInUse = (DynAbs.Tracing.TraceSender.Conditional_F1(1441, 43710, 43727) || ((f_1441_43710_43722(quote) == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1441, 43730, 43733)) || DynAbs.Tracing.TraceSender.Conditional_F3(1441, 43736, 43741))) ? "'" : quote
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 43764, 43852);

                        completionText = (DynAbs.Tracing.TraceSender.Conditional_F1(1441, 43781, 43798) || ((quoteInUse == "'" && DynAbs.Tracing.TraceSender.Conditional_F2(1441, 43801, 43834)) || DynAbs.Tracing.TraceSender.Conditional_F3(1441, 43837, 43851))) ? f_1441_43801_43834(completionText, "'", "''") : completionText;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 43874, 43932);

                        completionText = quoteInUse + completionText + quoteInUse;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 43954, 44026);

                        completionText = (DynAbs.Tracing.TraceSender.Conditional_F1(1441, 43971, 43984) || ((needAmpersand && DynAbs.Tracing.TraceSender.Conditional_F2(1441, 43987, 44008)) || DynAbs.Tracing.TraceSender.Conditional_F3(1441, 44011, 44025))) ? "& " + completionText : completionText;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 43495, 44175);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 43495, 44175);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 44108, 44156);

                        completionText = quote + completionText + quote;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 43495, 44175);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 44195, 44217);

                    return completionText;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 43354, 44232);

                    int
                    f_1441_43499_43554(string
                    this_param, char[]
                    anyOf)
                    {
                        var return_v = this_param.IndexOfAny(anyOf);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 43499, 43554);
                        return return_v;
                    }


                    int
                    f_1441_43623_43635(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 43623, 43635);
                        return return_v;
                    }


                    int
                    f_1441_43710_43722(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 43710, 43722);
                        return return_v;
                    }


                    string
                    f_1441_43801_43834(string
                    this_param, string
                    oldValue, string
                    newValue)
                    {
                        var return_v = this_param.Replace(oldValue, newValue);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 43801, 43834);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 43354, 44232);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 43354, 44232);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static IEnumerable<PathItemAndConvertedPath> CombineMatchSets(List<PathItemAndConvertedPath> s1, List<PathItemAndConvertedPath> s2)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 44248, 46451);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 44420, 44598) || true) && (s1 == null || (DynAbs.Tracing.TraceSender.Expression_False(1441, 44424, 44450) || f_1441_44438_44446(s1) < 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 44420, 44598);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 44569, 44579);

                        return s2;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 44420, 44598);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 44618, 44768) || true) && (s2 == null || (DynAbs.Tracing.TraceSender.Expression_False(1441, 44622, 44648) || f_1441_44636_44644(s2) < 1))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 44618, 44768);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 44739, 44749);

                        return s1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 44618, 44768);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 44834, 44907);

                    f_1441_44834_44906(s1 != null && (DynAbs.Tracing.TraceSender.Expression_True(1441, 44853, 44879) && f_1441_44867_44875(s1) > 0), "s1 should have results");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 44925, 45007);

                    f_1441_44925_45006(s2 != null && (DynAbs.Tracing.TraceSender.Expression_True(1441, 44944, 44970) && f_1441_44958_44966(s2) > 0), "if s1 has results, s2 must also");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 45025, 45104);

                    f_1441_45025_45103(f_1441_45044_45052(s1) <= f_1441_45056_45064(s2), "s2 should always be larger than s1");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 45124, 45174);

                    var
                    result = f_1441_45137_45173()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 45522, 45542);

                    f_1441_45522_45541(
                                    // we need to remove from s2 those items in s1.  Since the results from FindMatches will be sorted,
                                    // just copy out the unique elements from s2 and s1.  We know that every element of S1 will be in S2,
                                    // so the result set will be S1 + (S2 - S1), which is the same size as S2.
                                    result, s1);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 45569, 45574);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 45576, 45581);
                        for (int
        i = 0
        ,
        j = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 45560, 45921) || true) && (i < f_1441_45587_45595(s2))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 45597, 45600)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 45560, 45921))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 45560, 45921);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 45642, 45860) || true) && (j < f_1441_45650_45658(s1) && (DynAbs.Tracing.TraceSender.Expression_True(1441, 45646, 45748) && f_1441_45662_45743(s2[i].Path, s1[j].Path, StringComparison.CurrentCultureIgnoreCase) == 0))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 45642, 45860);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 45798, 45802);

                                ++j;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 45828, 45837);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 45642, 45860);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 45884, 45902);

                            f_1441_45884_45901(
                                                result, f_1441_45895_45900(s2, i));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1441, 1, 362);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1441, 1, 362);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 45952, 46065);

                    f_1441_45952_46064(f_1441_45971_45983(result) == f_1441_45987_45995(s2), "result should be the same size as s2, see the size comment above");
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 46092, 46097);
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 46083, 46396) || true) && (i < f_1441_46103_46111(s1))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 46113, 46116)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 46083, 46396))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 46083, 46396);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 46158, 46187);

                            string
                            path = result[i].Path
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 46209, 46265);

                            int
                            j = f_1441_46217_46264(result, item => item.Path == path)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 46287, 46377);

                            f_1441_46287_46376(j == i, "elements of s1 should only come at the start of the results");
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1441, 1, 314);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1441, 1, 314);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 46422, 46436);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 44248, 46451);

                    int
                    f_1441_44438_44446(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 44438, 44446);
                        return return_v;
                    }


                    int
                    f_1441_44636_44644(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 44636, 44644);
                        return return_v;
                    }


                    int
                    f_1441_44867_44875(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 44867, 44875);
                        return return_v;
                    }


                    int
                    f_1441_44834_44906(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 44834, 44906);
                        return 0;
                    }


                    int
                    f_1441_44958_44966(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 44958, 44966);
                        return return_v;
                    }


                    int
                    f_1441_44925_45006(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 44925, 45006);
                        return 0;
                    }


                    int
                    f_1441_45044_45052(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 45044, 45052);
                        return return_v;
                    }


                    int
                    f_1441_45056_45064(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 45056, 45064);
                        return return_v;
                    }


                    int
                    f_1441_45025_45103(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 45025, 45103);
                        return 0;
                    }


                    System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    f_1441_45137_45173()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 45137, 45173);
                        return return_v;
                    }


                    int
                    f_1441_45522_45541(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param, System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    collection)
                    {
                        this_param.AddRange((System.Collections.Generic.IEnumerable<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>)collection);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 45522, 45541);
                        return 0;
                    }


                    int
                    f_1441_45587_45595(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 45587, 45595);
                        return return_v;
                    }


                    int
                    f_1441_45650_45658(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 45650, 45658);
                        return return_v;
                    }


                    int
                    f_1441_45662_45743(string
                    strA, string
                    strB, System.StringComparison
                    comparisonType)
                    {
                        var return_v = string.Compare(strA, strB, comparisonType);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 45662, 45743);
                        return return_v;
                    }


                    System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath
                    f_1441_45895_45900(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 45895, 45900);
                        return return_v;
                    }


                    int
                    f_1441_45884_45901(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param, System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 45884, 45901);
                        return 0;
                    }


                    int
                    f_1441_45971_45983(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 45971, 45983);
                        return return_v;
                    }


                    int
                    f_1441_45987_45995(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 45987, 45995);
                        return return_v;
                    }


                    int
                    f_1441_45952_46064(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 45952, 46064);
                        return 0;
                    }


                    int
                    f_1441_46103_46111(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 46103, 46111);
                        return return_v;
                    }


                    int
                    f_1441_46217_46264(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param, System.Predicate<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    match)
                    {
                        var return_v = this_param.FindLastIndex(match);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 46217, 46264);
                        return return_v;
                    }


                    int
                    f_1441_46287_46376(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 46287, 46376);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 44248, 46451);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 44248, 46451);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static T SafeGetProperty<T>(PSObject psObject, string propertyName)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 46467, 47303);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 46575, 46674) || true) && (psObject == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 46575, 46674);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 46637, 46655);

                        return default(T);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 46575, 46674);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 46694, 46754);

                    PSPropertyInfo
                    property = f_1441_46720_46753(f_1441_46720_46739(psObject), propertyName)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 46772, 46871) || true) && (property == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 46772, 46871);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 46834, 46852);

                        return default(T);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 46772, 46871);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 46891, 46929);

                    object
                    propertyValue = f_1441_46914_46928(property)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 46947, 47051) || true) && (propertyValue == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 46947, 47051);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 47014, 47032);

                        return default(T);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 46947, 47051);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 47071, 47085);

                    T
                    returnValue
                    = default(T);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 47103, 47250) || true) && (f_1441_47107_47170(propertyValue, out returnValue))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 47103, 47250);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 47212, 47231);

                        return returnValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 47103, 47250);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 47270, 47288);

                    return default(T);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 46467, 47303);

                    System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    f_1441_46720_46739(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.Properties;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 46720, 46739);
                        return return_v;
                    }


                    System.Management.Automation.PSPropertyInfo
                    f_1441_46720_46753(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                    this_param, string
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 46720, 46753);
                        return return_v;
                    }


                    object
                    f_1441_46914_46928(System.Management.Automation.PSPropertyInfo
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 46914, 46928);
                        return return_v;
                    }


                    bool
                    f_1441_47107_47170(object
                    valueToConvert, out T
                    result)
                    {
                        var return_v = LanguagePrimitives.TryConvertTo(valueToConvert, out result);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 47107, 47170);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 46467, 47303);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 46467, 47303);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private static bool PSv2ShouldFullyQualifyPathsPath(PowerShellExecutionHelper helper, string lastWord)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 47319, 48119);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 47588, 47788) || true) && (f_1441_47592_47616(lastWord, '~') || (DynAbs.Tracing.TraceSender.Expression_False(1441, 47592, 47666) || f_1441_47641_47666(lastWord, '\\')) || (DynAbs.Tracing.TraceSender.Expression_False(1441, 47592, 47715) || f_1441_47691_47715(lastWord, '/')))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 47588, 47788);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 47757, 47769);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 47588, 47788);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 47808, 47988);

                    f_1441_47808_47987(f_1441_47808_47932(f_1441_47808_47879(f_1441_47808_47832(helper), "Split-Path"), "Path", lastWord), "IsAbsolute", true);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 48008, 48068);

                    bool
                    isAbsolute = f_1441_48026_48067(helper)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 48086, 48104);

                    return isAbsolute;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 47319, 48119);

                    bool
                    f_1441_47592_47616(string
                    this_param, char
                    value)
                    {
                        var return_v = this_param.StartsWith(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 47592, 47616);
                        return return_v;
                    }


                    bool
                    f_1441_47641_47666(string
                    this_param, char
                    value)
                    {
                        var return_v = this_param.StartsWith(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 47641, 47666);
                        return return_v;
                    }


                    bool
                    f_1441_47691_47715(string
                    this_param, char
                    value)
                    {
                        var return_v = this_param.StartsWith(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 47691, 47715);
                        return return_v;
                    }


                    System.Management.Automation.PowerShell
                    f_1441_47808_47832(System.Management.Automation.PowerShellExecutionHelper
                    this_param)
                    {
                        var return_v = this_param.CurrentPowerShell
                        ;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 47808, 47832);
                        return return_v;
                    }


                    System.Management.Automation.PowerShell
                    f_1441_47808_47879(System.Management.Automation.PowerShell
                    this_param, string
                    cmdlet)
                    {
                        var return_v = this_param.AddCommand(cmdlet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 47808, 47879);
                        return return_v;
                    }


                    System.Management.Automation.PowerShell
                    f_1441_47808_47932(System.Management.Automation.PowerShell
                    this_param, string
                    parameterName, string
                    value)
                    {
                        var return_v = this_param.AddParameter(parameterName, (object)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 47808, 47932);
                        return return_v;
                    }


                    System.Management.Automation.PowerShell
                    f_1441_47808_47987(System.Management.Automation.PowerShell
                    this_param, string
                    parameterName, bool
                    value)
                    {
                        var return_v = this_param.AddParameter(parameterName, (object)value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 47808, 47987);
                        return return_v;
                    }


                    bool
                    f_1441_48026_48067(System.Management.Automation.PowerShellExecutionHelper
                    this_param)
                    {
                        var return_v = this_param.ExecuteCommandAndGetResultAsBool();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 48026, 48067);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 47319, 48119);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 47319, 48119);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private struct PathItemAndConvertedPath
            {

                internal readonly string Path;

                internal readonly PSObject Item;

                internal readonly string ConvertedPath;

                internal PathItemAndConvertedPath(string path, PSObject item, string convertedPath)
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterConstructor(1441, 48364, 48620);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 48488, 48505);

                        this.Path = path;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 48527, 48544);

                        this.Item = item;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 48566, 48601);

                        this.ConvertedPath = convertedPath;
                        DynAbs.Tracing.TraceSender.TraceExitConstructor(1441, 48364, 48620);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 48364, 48620);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 48364, 48620);
                    }
                }
                static PathItemAndConvertedPath()
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1441, 48135, 48635);
                    DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1441, 48135, 48635);

                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 48135, 48635);
                }
            }

            private static List<PathItemAndConvertedPath> PSv2FindMatches(PowerShellExecutionHelper helper, string path, bool shouldFullyQualifyPaths)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 48651, 51891);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 48822, 48898);

                    f_1441_48822_48897(!f_1441_48842_48868(path), "path should have a value");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 48916, 48966);

                    var
                    result = f_1441_48929_48965()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 48986, 49012);

                    Exception
                    exceptionThrown
                    = default(Exception);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 49030, 49079);

                    PowerShell
                    powershell = f_1441_49054_49078(helper)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 49225, 50112) || true) && (!shouldFullyQualifyPaths)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 49225, 50112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 49295, 49658);

                        f_1441_49295_49657(powershell, f_1441_49316_49656(f_1441_49356_49384(), "& {{ trap {{ continue }} ; resolve-path {0} -Relative -WarningAction SilentlyContinue | ForEach-Object {{,($_,(get-item $_ -WarningAction SilentlyContinue),(convert-path $_ -WarningAction SilentlyContinue))}} }}", path));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 49225, 50112);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 49225, 50112);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 49740, 50093);

                        f_1441_49740_50092(powershell, f_1441_49761_50091(f_1441_49801_49829(), "& {{ trap {{ continue }} ; resolve-path {0} -WarningAction SilentlyContinue | ForEach-Object {{,($_,(get-item $_ -WarningAction SilentlyContinue),(convert-path $_ -WarningAction SilentlyContinue))}} }}", path));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 49225, 50112);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 50132, 50214);

                    Collection<PSObject>
                    paths = f_1441_50161_50213(helper, out exceptionThrown)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 50232, 50342) || true) && (paths == null || (DynAbs.Tracing.TraceSender.Expression_False(1441, 50236, 50269) || f_1441_50253_50264(paths) == 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 50232, 50342);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 50311, 50323);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 50232, 50342);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 50362, 51300);
                        foreach (PSObject t in f_1441_50385_50390_I(paths))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 50362, 51300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 50432, 50471);

                            var
                            pathsArray = f_1441_50449_50461(t) as IList
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 50493, 51281) || true) && (pathsArray != null && (DynAbs.Tracing.TraceSender.Expression_True(1441, 50497, 50540) && f_1441_50519_50535(pathsArray) == 3))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 50493, 51281);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 50590, 50624);

                                object
                                objectPath = f_1441_50610_50623(pathsArray, 0)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 50650, 50692);

                                PSObject
                                item = f_1441_50666_50679(pathsArray, 1) as PSObject
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 50718, 50755);

                                object
                                convertedPath = f_1441_50741_50754(pathsArray, 1)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 50783, 50940) || true) && (objectPath == null || (DynAbs.Tracing.TraceSender.Expression_False(1441, 50787, 50821) || item == null) || (DynAbs.Tracing.TraceSender.Expression_False(1441, 50787, 50846) || convertedPath == null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 50783, 50940);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 50904, 50913);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 50783, 50940);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 50968, 51258);

                                f_1441_50968_51257(
                                                        result, f_1441_50979_51256(f_1441_51054_51104(objectPath), item, f_1441_51202_51255(convertedPath)));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 50493, 51281);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 50362, 51300);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1441, 1, 939);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1441, 1, 939);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 51320, 51414) || true) && (f_1441_51324_51336(result) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 51320, 51414);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 51383, 51395);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 51320, 51414);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 51434, 51842);

                    f_1441_51434_51841(
                                    result, delegate (PathItemAndConvertedPath x, PathItemAndConvertedPath y)
                                                    {
                                                        Diagnostics.Assert(x.Path != null && y.Path != null, "SafeToString always returns a non-null string");
                                                        return string.Compare(x.Path, y.Path, StringComparison.CurrentCultureIgnoreCase);
                                                    });
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 51862, 51876);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 48651, 51891);

                    bool
                    f_1441_48842_48868(string
                    value)
                    {
                        var return_v = string.IsNullOrEmpty(value);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 48842, 48868);
                        return return_v;
                    }


                    int
                    f_1441_48822_48897(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 48822, 48897);
                        return 0;
                    }


                    System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    f_1441_48929_48965()
                    {
                        var return_v = new System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 48929, 48965);
                        return return_v;
                    }


                    System.Management.Automation.PowerShell
                    f_1441_49054_49078(System.Management.Automation.PowerShellExecutionHelper
                    this_param)
                    {
                        var return_v = this_param.CurrentPowerShell;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 49054, 49078);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1441_49356_49384()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 49356, 49384);
                        return return_v;
                    }


                    string
                    f_1441_49316_49656(System.Globalization.CultureInfo
                    provider, string
                    format, string
                    arg0)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 49316, 49656);
                        return return_v;
                    }


                    System.Management.Automation.PowerShell
                    f_1441_49295_49657(System.Management.Automation.PowerShell
                    this_param, string
                    script)
                    {
                        var return_v = this_param.AddScript(script);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 49295, 49657);
                        return return_v;
                    }


                    System.Globalization.CultureInfo
                    f_1441_49801_49829()
                    {
                        var return_v = CultureInfo.InvariantCulture;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 49801, 49829);
                        return return_v;
                    }


                    string
                    f_1441_49761_50091(System.Globalization.CultureInfo
                    provider, string
                    format, string
                    arg0)
                    {
                        var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 49761, 50091);
                        return return_v;
                    }


                    System.Management.Automation.PowerShell
                    f_1441_49740_50092(System.Management.Automation.PowerShell
                    this_param, string
                    script)
                    {
                        var return_v = this_param.AddScript(script);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 49740, 50092);
                        return return_v;
                    }


                    System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                    f_1441_50161_50213(System.Management.Automation.PowerShellExecutionHelper
                    this_param, out System.Exception
                    exceptionThrown)
                    {
                        var return_v = this_param.ExecuteCurrentPowerShell(out exceptionThrown);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 50161, 50213);
                        return return_v;
                    }


                    int
                    f_1441_50253_50264(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 50253, 50264);
                        return return_v;
                    }


                    object
                    f_1441_50449_50461(System.Management.Automation.PSObject
                    this_param)
                    {
                        var return_v = this_param.BaseObject;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 50449, 50461);
                        return return_v;
                    }


                    int
                    f_1441_50519_50535(System.Collections.IList
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 50519, 50535);
                        return return_v;
                    }


                    object
                    f_1441_50610_50623(System.Collections.IList
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 50610, 50623);
                        return return_v;
                    }


                    object
                    f_1441_50666_50679(System.Collections.IList
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 50666, 50679);
                        return return_v;
                    }


                    object
                    f_1441_50741_50754(System.Collections.IList
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 50741, 50754);
                        return return_v;
                    }


                    string
                    f_1441_51054_51104(object
                    obj)
                    {
                        var return_v = PowerShellExecutionHelper.SafeToString(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 51054, 51104);
                        return return_v;
                    }


                    string
                    f_1441_51202_51255(object
                    obj)
                    {
                        var return_v = PowerShellExecutionHelper.SafeToString(obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 51202, 51255);
                        return return_v;
                    }


                    System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath
                    f_1441_50979_51256(string
                    path, System.Management.Automation.PSObject
                    item, string
                    convertedPath)
                    {
                        var return_v = new System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath(path, item, convertedPath);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 50979, 51256);
                        return return_v;
                    }


                    int
                    f_1441_50968_51257(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param, System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath
                    item)
                    {
                        this_param.Add(item);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 50968, 51257);
                        return 0;
                    }


                    System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                    f_1441_50385_50390_I(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 50385, 50390);
                        return return_v;
                    }


                    int
                    f_1441_51324_51336(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param)
                    {
                        var return_v = this_param.Count;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 51324, 51336);
                        return return_v;
                    }


                    int
                    f_1441_51434_51841(System.Collections.Generic.List<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    this_param, System.Comparison<System.Management.Automation.CommandCompletion.PSv2CompletionCompleter.PathItemAndConvertedPath>
                    comparison)
                    {
                        this_param.Sort(comparison);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 51434, 51841);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 48651, 51891);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 48651, 51891);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            static PSv2CompletionCompleter()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1441, 31648, 51948);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 31747, 31800);
                s_cmdletTabRegex = f_1441_31766_31800(@"^[\w\*\?]+-[\w\*\?]*");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 31846, 31911);
                s_charsRequiringQuotedString = f_1441_31877_31911("`&@'#{}()$,;|<> \t");
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1441, 31648, 51948);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 31648, 51948);
            }


            static System.Text.RegularExpressions.Regex
            f_1441_31766_31800(string
            pattern)
            {
                var return_v = new System.Text.RegularExpressions.Regex(pattern);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 31766, 31800);
                return return_v;
            }


            static char[]
            f_1441_31877_31911(string
            this_param)
            {
                var return_v = this_param.ToCharArray();
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 31877, 31911);
                return return_v;
            }

        }
        private class LastWordFinder
        {
            internal static string FindLastWord(string sentence, out int replacementIndexOut, out char closingQuote)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 52301, 52547);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 52438, 52532);

                    return f_1441_52445_52531((f_1441_52446_52474(sentence)), out replacementIndexOut, out closingQuote);
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 52301, 52547);

                    System.Management.Automation.CommandCompletion.LastWordFinder
                    f_1441_52446_52474(string
                    sentence)
                    {
                        var return_v = new System.Management.Automation.CommandCompletion.LastWordFinder(sentence);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 52446, 52474);
                        return return_v;
                    }


                    string
                    f_1441_52445_52531(System.Management.Automation.CommandCompletion.LastWordFinder
                    this_param, out int
                    replacementIndexOut, out char
                    closingQuote)
                    {
                        var return_v = this_param.FindLastWord(out replacementIndexOut, out closingQuote);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 52445, 52531);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 52301, 52547);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 52301, 52547);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private LastWordFinder(string sentence)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1441, 52563, 52797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 59194, 59203);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 59233, 59244);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 59271, 59287);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 59314, 59331);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 59358, 59372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 59400, 59417);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 52635, 52657);

                    _replacementIndex = 0;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 52675, 52743);

                    f_1441_52675_52742(sentence != null, "need to provide an instance");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 52761, 52782);

                    _sentence = sentence;
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1441, 52563, 52797);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 52563, 52797);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 52563, 52797);
                }
            }

            private string FindLastWord(out int replacementIndexOut, out char closingQuote)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1441, 53956, 57073);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 54068, 54095);

                    bool
                    inSingleQuote = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 54113, 54140);

                    bool
                    inDoubleQuote = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 54160, 54181);

                    ReplacementIndex = 0;
                    try
                    {
                        for (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 54206, 54224)
        , _sentenceIndex = 0; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 54201, 56803) || true) && (_sentenceIndex < f_1441_54243_54259(_sentence))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 54261, 54277)
        , ++_sentenceIndex, DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 54201, 56803))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 54201, 56803);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 54319, 54443);

                            f_1441_54319_54442(!(inSingleQuote && (DynAbs.Tracing.TraceSender.Expression_True(1441, 54340, 54370) && inDoubleQuote)), "Can't be in both single and double quotes");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 54467, 54502);

                            char
                            c = f_1441_54476_54501(_sentence, _sentenceIndex)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 54797, 56784) || true) && (c == '\'')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 54797, 56784);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 54860, 54913);

                                f_1441_54860_54912(this, ref inSingleQuote, ref inDoubleQuote, c);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 54797, 56784);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 54797, 56784);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 54963, 56784) || true) && (c == '"')
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 54963, 56784);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 55025, 55078);

                                    f_1441_55025_55077(this, ref inDoubleQuote, ref inSingleQuote, c);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 54963, 56784);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 54963, 56784);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 55128, 56784) || true) && (c == '`')
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 55128, 56784);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 55190, 55201);

                                        f_1441_55190_55200(this, c);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 55227, 55386) || true) && (++_sentenceIndex < f_1441_55250_55266(_sentence))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 55227, 55386);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 55324, 55359);

                                            f_1441_55324_55358(this, f_1441_55332_55357(_sentence, _sentenceIndex));
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 55227, 55386);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 55128, 56784);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 55128, 56784);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 55436, 56784) || true) && (f_1441_55440_55455(c))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 55436, 56784);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 55505, 56584) || true) && (_sequenceDueToEnd)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 55505, 56584);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 55668, 55694);

                                                _sequenceDueToEnd = false;

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 55724, 55860) || true) && (inSingleQuote)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 55724, 55860);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 55807, 55829);

                                                    inSingleQuote = false;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 55724, 55860);
                                                }

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 55892, 56028) || true) && (inDoubleQuote)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 55892, 56028);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 55975, 55997);

                                                    inDoubleQuote = false;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 55892, 56028);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 56060, 56098);

                                                ReplacementIndex = _sentenceIndex + 1;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 55505, 56584);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 55505, 56584);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 56156, 56584) || true) && (inSingleQuote || (DynAbs.Tracing.TraceSender.Expression_False(1441, 56160, 56190) || inDoubleQuote))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 56156, 56584);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 56324, 56335);

                                                    f_1441_56324_56334(this, c);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 56156, 56584);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 56156, 56584);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 56519, 56557);

                                                    ReplacementIndex = _sentenceIndex + 1;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 56156, 56584);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 55505, 56584);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 55436, 56784);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 55436, 56784);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 56750, 56761);

                                            f_1441_56750_56760(this, c);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 55436, 56784);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 55128, 56784);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 54963, 56784);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 54797, 56784);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1441, 1, 2603);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1441, 1, 2603);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 56823, 56884);

                    string
                    result = f_1441_56839_56883(_wordBuffer, 0, _wordBufferIndex)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 56904, 56969);

                    closingQuote = (DynAbs.Tracing.TraceSender.Conditional_F1(1441, 56919, 56932) || ((inSingleQuote && DynAbs.Tracing.TraceSender.Conditional_F2(1441, 56935, 56939)) || DynAbs.Tracing.TraceSender.Conditional_F3(1441, 56942, 56968))) ? '\'' : (DynAbs.Tracing.TraceSender.Conditional_F1(1441, 56942, 56955) || ((inDoubleQuote && DynAbs.Tracing.TraceSender.Conditional_F2(1441, 56958, 56961)) || DynAbs.Tracing.TraceSender.Conditional_F3(1441, 56964, 56968))) ? '"' : '\0';
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 56987, 57026);

                    replacementIndexOut = f_1441_57009_57025();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 57044, 57058);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1441, 53956, 57073);

                    int
                    f_1441_54243_54259(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 54243, 54259);
                        return return_v;
                    }


                    int
                    f_1441_54319_54442(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 54319, 54442);
                        return 0;
                    }


                    char
                    f_1441_54476_54501(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 54476, 54501);
                        return return_v;
                    }


                    int
                    f_1441_54860_54912(System.Management.Automation.CommandCompletion.LastWordFinder
                    this_param, ref bool
                    inQuote, ref bool
                    inOppositeQuote, char
                    c)
                    {
                        this_param.HandleQuote(ref inQuote, ref inOppositeQuote, c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 54860, 54912);
                        return 0;
                    }


                    int
                    f_1441_55025_55077(System.Management.Automation.CommandCompletion.LastWordFinder
                    this_param, ref bool
                    inQuote, ref bool
                    inOppositeQuote, char
                    c)
                    {
                        this_param.HandleQuote(ref inQuote, ref inOppositeQuote, c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 55025, 55077);
                        return 0;
                    }


                    int
                    f_1441_55190_55200(System.Management.Automation.CommandCompletion.LastWordFinder
                    this_param, char
                    c)
                    {
                        this_param.Consume(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 55190, 55200);
                        return 0;
                    }


                    int
                    f_1441_55250_55266(string
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 55250, 55266);
                        return return_v;
                    }


                    char
                    f_1441_55332_55357(string
                    this_param, int
                    i0)
                    {
                        var return_v = this_param[i0];
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 55332, 55357);
                        return return_v;
                    }


                    int
                    f_1441_55324_55358(System.Management.Automation.CommandCompletion.LastWordFinder
                    this_param, char
                    c)
                    {
                        this_param.Consume(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 55324, 55358);
                        return 0;
                    }


                    bool
                    f_1441_55440_55455(char
                    c)
                    {
                        var return_v = IsWhitespace(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 55440, 55455);
                        return return_v;
                    }


                    int
                    f_1441_56324_56334(System.Management.Automation.CommandCompletion.LastWordFinder
                    this_param, char
                    c)
                    {
                        this_param.Consume(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 56324, 56334);
                        return 0;
                    }


                    int
                    f_1441_56750_56760(System.Management.Automation.CommandCompletion.LastWordFinder
                    this_param, char
                    c)
                    {
                        this_param.Consume(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 56750, 56760);
                        return 0;
                    }


                    string
                    f_1441_56839_56883(char[]
                    value, int
                    startIndex, int
                    length)
                    {
                        var return_v = new string(value, startIndex, length);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 56839, 56883);
                        return return_v;
                    }


                    int
                    f_1441_57009_57025()
                    {
                        var return_v = ReplacementIndex;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 57009, 57025);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 53956, 57073);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 53956, 57073);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private void HandleQuote(ref bool inQuote, ref bool inOppositeQuote, char c)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1441, 57089, 58043);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 57198, 57382) || true) && (inOppositeQuote)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 57198, 57382);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 57323, 57334);

                        f_1441_57323_57333(this, c);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 57356, 57363);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 57198, 57382);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 57402, 58028) || true) && (inQuote)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 57402, 58028);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 57455, 57703) || true) && (_sequenceDueToEnd)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 57455, 57703);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 57642, 57680);

                            ReplacementIndex = _sentenceIndex + 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 57455, 57703);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 57727, 57766);

                        _sequenceDueToEnd = !_sequenceDueToEnd;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 57402, 58028);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1441, 57402, 58028);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 57938, 57953);

                        inQuote = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 57975, 58009);

                        ReplacementIndex = _sentenceIndex;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1441, 57402, 58028);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1441, 57089, 58043);

                    int
                    f_1441_57323_57333(System.Management.Automation.CommandCompletion.LastWordFinder
                    this_param, char
                    c)
                    {
                        this_param.Consume(c);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 57323, 57333);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 57089, 58043);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 57089, 58043);
                }
            }

            private void Consume(char c)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1441, 58059, 58375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 58120, 58193);

                    f_1441_58120_58192(_wordBuffer != null, "wordBuffer is not initialized");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 58211, 58304);

                    f_1441_58211_58303(_wordBufferIndex < f_1441_58249_58267(_wordBuffer), "wordBufferIndex is out of range");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 58324, 58360);

                    _wordBuffer[_wordBufferIndex++] = c;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1441, 58059, 58375);

                    int
                    f_1441_58120_58192(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 58120, 58192);
                        return 0;
                    }


                    int
                    f_1441_58249_58267(char[]
                    this_param)
                    {
                        var return_v = this_param.Length;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 58249, 58267);
                        return return_v;
                    }


                    int
                    f_1441_58211_58303(bool
                    condition, string
                    whyThisShouldNeverHappen)
                    {
                        Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 58211, 58303);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 58059, 58375);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 58059, 58375);
                }
            }

            private int ReplacementIndex
            {
                get
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1441, 58452, 58485);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 58458, 58483);

                        return _replacementIndex;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1441, 58452, 58485);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 58391, 59013);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 58391, 59013);
                    }
                    throw new System.Exception("Slicer error: unreachable code");
                }
                set
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterMethod(1441, 58505, 58998);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 58549, 58634);

                        f_1441_58549_58633(value >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(1441, 58568, 58610) && value < f_1441_58590_58606(_sentence) + 1), "value out of range");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 58847, 58888);

                        _wordBuffer = new char[f_1441_58870_58886(_sentence)];
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 58910, 58931);

                        _wordBufferIndex = 0;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 58953, 58979);

                        _replacementIndex = value;
                        DynAbs.Tracing.TraceSender.TraceExitMethod(1441, 58505, 58998);

                        int
                        f_1441_58590_58606(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 58590, 58606);
                            return return_v;
                        }


                        int
                        f_1441_58549_58633(bool
                        condition, string
                        whyThisShouldNeverHappen)
                        {
                            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                            DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 58549, 58633);
                            return 0;
                        }


                        int
                        f_1441_58870_58886(string
                        this_param)
                        {
                            var return_v = this_param.Length;
                            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1441, 58870, 58886);
                            return return_v;
                        }

                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 58391, 59013);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 58391, 59013);
                    }
                }
            }

            private static bool IsWhitespace(char c)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1441, 59029, 59154);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 59102, 59139);

                    return (c == ' ') || (DynAbs.Tracing.TraceSender.Expression_False(1441, 59109, 59138) || (c == '\x0009'));
                    DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1441, 59029, 59154);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1441, 59029, 59154);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 59029, 59154);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            private readonly string _sentence;

            private char[] _wordBuffer;

            private int _wordBufferIndex;

            private int _replacementIndex;

            private int _sentenceIndex;

            private bool _sequenceDueToEnd;

            static LastWordFinder()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1441, 52248, 59429);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1441, 52248, 59429);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 52248, 59429);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1441, 52248, 59429);

            int
            f_1441_52675_52742(bool
            condition, string
            whyThisShouldNeverHappen)
            {
                Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 52675, 52742);
                return 0;
            }

        }

        static CommandCompletion()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1441, 659, 59474);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 2076, 2131);
            EmptyCompletionResult = f_1441_2100_2131();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1441, 2184, 2315);
            s_emptyCommandCompletion = f_1441_2211_2315(f_1441_2247_2302(EmptyCompletionResult), -1, -1, -1);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1441, 659, 59474);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1441, 659, 59474);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1441, 659, 59474);

        static System.Management.Automation.CompletionResult[]
        f_1441_2100_2131()
        {
            var return_v = Array.Empty<CompletionResult>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 2100, 2131);
            return return_v;
        }


        static System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>
        f_1441_2247_2302(System.Collections.Generic.IList<System.Management.Automation.CompletionResult>
        list)
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>(list);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 2247, 2302);
            return return_v;
        }


        static System.Management.Automation.CommandCompletion
        f_1441_2211_2315(System.Collections.ObjectModel.Collection<System.Management.Automation.CompletionResult>
        matches, int
        currentMatchIndex, int
        replacementIndex, int
        replacementLength)
        {
            var return_v = new System.Management.Automation.CommandCompletion(matches, currentMatchIndex, replacementIndex, replacementLength);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1441, 2211, 2315);
            return return_v;
        }

    }
}
