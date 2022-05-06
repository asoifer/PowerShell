// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Management.Automation.Internal;
using System.Text;

using Microsoft.PowerShell.Commands;

namespace System.Management.Automation
{
    using Language;
    internal class NativeCommandParameterBinder : ParameterBinderBase
    {
        internal NativeCommandParameterBinder(
                    NativeCommand command) : base(f_1299_1000_1020_C(f_1299_1000_1020(command)), f_1299_1022_1037(command), command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1299, 918, 1108);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 5549, 5581);
                this._arguments = f_1299_5562_5581();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 16312, 16326);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 1072, 1097);

                _nativeCommand = command;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1299, 918, 1108);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1299, 918, 1108);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1299, 918, 1108);
            }
        }

        internal override void BindParameter(string name, object value, CompiledCommandParameter parameterMetadata)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1299, 1871, 2110);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 2003, 2049);

                f_1299_2003_2048(false, "Unreachable code");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 2065, 2099);

                throw f_1299_2071_2098();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1299, 1871, 2110);

                int
                f_1299_2003_2048(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 2003, 2048);
                    return 0;
                }


                System.NotSupportedException
                f_1299_2071_2098()
                {
                    var return_v = new System.NotSupportedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 2071, 2098);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1299, 1871, 2110);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1299, 1871, 2110);
            }
        }

        internal override object GetDefaultParameterValue(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1299, 2122, 2232);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 2209, 2221);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1299, 2122, 2232);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1299, 2122, 2232);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1299, 2122, 2232);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void BindParameters(Collection<CommandParameterInternal> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1299, 2244, 5210);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 2346, 2385);

                bool
                sawVerbatimArgumentMarker = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 2399, 2417);

                bool
                first = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 2431, 5199);
                    foreach (CommandParameterInternal parameter in f_1299_2478_2488_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 2431, 5199);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 2522, 2616) || true) && (!first)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 2522, 2616);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 2574, 2597);

                            f_1299_2574_2596(_arguments, ' ');
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 2522, 2616);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 2636, 2650);

                        first = false;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 2670, 3102) || true) && (f_1299_2674_2706(parameter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 2670, 3102);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 2748, 2848);

                            f_1299_2748_2847(f_1299_2767_2803(f_1299_2767_2790(parameter), ' ') == -1, "Parameters cannot have whitespace");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 2870, 2930);

                            f_1299_2870_2929(this, f_1299_2886_2909(parameter), usedQuotes: false);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 2954, 3083) || true) && (f_1299_2958_2987(parameter))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 2954, 3083);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 3037, 3060);

                                f_1299_3037_3059(_arguments, ' ');
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 2954, 3083);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 2670, 3102);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 3122, 5184) || true) && (f_1299_3126_3153(parameter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 3122, 5184);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 3417, 3459);

                            object
                            argValue = f_1299_3435_3458(parameter)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 3481, 3702) || true) && (f_1299_3485_3561("--%", argValue as string, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 3481, 3702);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 3611, 3644);

                                sawVerbatimArgumentMarker = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 3670, 3679);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 3481, 3702);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 3726, 5165) || true) && (argValue != f_1299_3742_3762() && (DynAbs.Tracing.TraceSender.Expression_True(1299, 3730, 3800) && argValue != f_1299_3778_3800()))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 3726, 5165);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 4217, 4241);

                                bool
                                usedQuotes = false
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 4267, 4306);

                                ArrayLiteralAst
                                arrayLiteralAst = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 4332, 4986);

                                switch (f_1299_4340_4362_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(parameter, 1299, 4340, 4362)?.ArgumentAst))
                                {

                                    case StringConstantExpressionAst sce:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 4332, 4986);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 4491, 4558);

                                        usedQuotes = f_1299_4504_4526(sce) != StringConstantType.BareWord;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1299, 4592, 4598);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 4332, 4986);

                                    case ExpandableStringExpressionAst ese:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 4332, 4986);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 4701, 4768);

                                        usedQuotes = f_1299_4714_4736(ese) != StringConstantType.BareWord;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1299, 4802, 4808);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 4332, 4986);

                                    case ArrayLiteralAst ala:
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 4332, 4986);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 4897, 4919);

                                        arrayLiteralAst = ala;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1299, 4953, 4959);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 4332, 4986);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 5014, 5142);

                                f_1299_5014_5141(this, f_1299_5038_5045(), argValue, arrayLiteralAst, sawVerbatimArgumentMarker, usedQuotes);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 3726, 5165);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 3122, 5184);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 2431, 5199);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1299, 1, 2769);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1299, 1, 2769);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1299, 2244, 5210);

                System.Text.StringBuilder
                f_1299_2574_2596(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 2574, 2596);
                    return return_v;
                }


                bool
                f_1299_2674_2706(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterNameSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 2674, 2706);
                    return return_v;
                }


                string
                f_1299_2767_2790(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 2767, 2790);
                    return return_v;
                }


                int
                f_1299_2767_2803(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 2767, 2803);
                    return return_v;
                }


                int
                f_1299_2748_2847(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 2748, 2847);
                    return 0;
                }


                string
                f_1299_2886_2909(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 2886, 2909);
                    return return_v;
                }


                int
                f_1299_2870_2929(System.Management.Automation.NativeCommandParameterBinder
                this_param, string
                arg, bool
                usedQuotes)
                {
                    this_param.PossiblyGlobArg(arg, usedQuotes: usedQuotes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 2870, 2929);
                    return 0;
                }


                bool
                f_1299_2958_2987(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.SpaceAfterParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 2958, 2987);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1299_3037_3059(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 3037, 3059);
                    return return_v;
                }


                bool
                f_1299_3126_3153(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 3126, 3153);
                    return return_v;
                }


                object
                f_1299_3435_3458(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 3435, 3458);
                    return return_v;
                }


                bool
                f_1299_3485_3561(string
                a, object
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, (string)b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 3485, 3561);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1299_3742_3762()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 3742, 3762);
                    return return_v;
                }


                object
                f_1299_3778_3800()
                {
                    var return_v = UnboundParameter.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 3778, 3800);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1299_4340_4362_M(System.Management.Automation.Language.Ast
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 4340, 4362);
                    return return_v;
                }


                System.Management.Automation.Language.StringConstantType
                f_1299_4504_4526(System.Management.Automation.Language.StringConstantExpressionAst
                this_param)
                {
                    var return_v = this_param.StringConstantType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 4504, 4526);
                    return return_v;
                }


                System.Management.Automation.Language.StringConstantType
                f_1299_4714_4736(System.Management.Automation.Language.ExpandableStringExpressionAst
                this_param)
                {
                    var return_v = this_param.StringConstantType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 4714, 4736);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1299_5038_5045()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 5038, 5045);
                    return return_v;
                }


                int
                f_1299_5014_5141(System.Management.Automation.NativeCommandParameterBinder
                this_param, System.Management.Automation.ExecutionContext
                context, object
                obj, System.Management.Automation.Language.ArrayLiteralAst
                argArrayAst, bool
                sawVerbatimArgumentMarker, bool
                usedQuotes)
                {
                    this_param.appendOneNativeArgument(context, obj, argArrayAst, sawVerbatimArgumentMarker, usedQuotes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 5014, 5141);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1299_2478_2488_I(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 2478, 2488);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1299, 2244, 5210);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1299, 2244, 5210);
            }
        }

        internal string Arguments
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1299, 5415, 5495);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 5451, 5480);

                    return f_1299_5458_5479(_arguments);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1299, 5415, 5495);

                    string
                    f_1299_5458_5479(System.Text.StringBuilder
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 5458, 5479);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1299, 5365, 5506);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1299, 5365, 5506);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private readonly StringBuilder _arguments;

        private void appendOneNativeArgument(ExecutionContext context, object obj, ArrayLiteralAst argArrayAst, bool sawVerbatimArgumentMarker, bool usedQuotes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1299, 6381, 9921);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 6558, 6615);

                IEnumerator
                list = f_1299_6577_6614(obj)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 6631, 6847);

                f_1299_6631_6846(argArrayAst == null
                || (DynAbs.Tracing.TraceSender.Expression_False(1299, 6650, 6761) || obj is object[] && (DynAbs.Tracing.TraceSender.Expression_True(1299, 6690, 6761) && f_1299_6709_6731(((object[])obj)) == f_1299_6735_6761(f_1299_6735_6755(argArrayAst)))), "array argument and ArrayLiteralAst differ in number of elements");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 6863, 6887);

                int
                currentElement = -1
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 6901, 6933);

                string
                separator = string.Empty
                ;
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 6947, 9910);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 6982, 6993);

                            string
                            arg
                            = default(string);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 7011, 7660) || true) && (list == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 7011, 7660);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 7069, 7113);

                                arg = f_1299_7075_7112(context, obj);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 7011, 7660);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 7011, 7660);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 7195, 7318) || true) && (!f_1299_7200_7239(context, null, list))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 7195, 7318);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1299, 7289, 7295);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 7195, 7318);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 7342, 7412);

                                arg = f_1299_7348_7411(context, f_1299_7381_7410(null, list));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 7436, 7456);

                                currentElement += 1;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 7478, 7641) || true) && (currentElement != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 7478, 7641);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 7551, 7618);

                                    separator = f_1299_7563_7617(argArrayAst, currentElement);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 7478, 7641);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 7011, 7660);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 7680, 9873) || true) && (!f_1299_7685_7710(arg))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 7680, 9873);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 7752, 7781);

                                f_1299_7752_7780(_arguments, separator);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 7805, 9854) || true) && (sawVerbatimArgumentMarker)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 7805, 9854);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 7884, 7934);

                                    arg = f_1299_7890_7933(arg);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 7960, 7983);

                                    f_1299_7960_7982(_arguments, arg);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 7805, 9854);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 7805, 9854);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 9003, 9831) || true) && (f_1299_9007_9022(arg))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 9003, 9831);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 9080, 9103);

                                        f_1299_9080_9102(_arguments, '"');
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 9370, 9393);

                                        f_1299_9370_9392(                            // need to escape all trailing backslashes so the native command receives it correctly
                                                                                     // according to http://www.daviddeley.com/autohotkey/parameters/parameters.htm#WINCRULESDOC
                                                                    _arguments, arg);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 9432, 9450);
                                            for (int
                i = f_1299_9436_9446(arg) - 1
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 9423, 9602) || true) && (i >= 0 && (DynAbs.Tracing.TraceSender.Expression_True(1299, 9452, 9476) && f_1299_9462_9468(arg, i) == '\\'))
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 9478, 9481)
                , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 9423, 9602))

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 9423, 9602);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 9547, 9571);

                                                f_1299_9547_9570(_arguments, '\\');
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1299, 1, 180);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1299, 1, 180);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 9634, 9657);

                                        f_1299_9634_9656(
                                                                    _arguments, '"');
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 9003, 9831);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 9003, 9831);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 9771, 9804);

                                        f_1299_9771_9803(this, arg, usedQuotes);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 9003, 9831);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 7805, 9854);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 7680, 9873);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 6947, 9910);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 6947, 9910) || true) && (list != null)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1299, 6947, 9910);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1299, 6947, 9910);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1299, 6381, 9921);

                System.Collections.IEnumerator
                f_1299_6577_6614(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 6577, 6614);
                    return return_v;
                }


                int
                f_1299_6709_6731(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 6709, 6731);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1299_6735_6755(System.Management.Automation.Language.ArrayLiteralAst
                this_param)
                {
                    var return_v = this_param.Elements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 6735, 6755);
                    return return_v;
                }


                int
                f_1299_6735_6761(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 6735, 6761);
                    return return_v;
                }


                int
                f_1299_6631_6846(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 6631, 6846);
                    return 0;
                }


                string
                f_1299_7075_7112(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 7075, 7112);
                    return return_v;
                }


                bool
                f_1299_7200_7239(System.Management.Automation.ExecutionContext
                context, System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.MoveNext(context, errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 7200, 7239);
                    return return_v;
                }


                object
                f_1299_7381_7410(System.Management.Automation.Language.IScriptExtent
                errorPosition, System.Collections.IEnumerator
                enumerator)
                {
                    var return_v = ParserOps.Current(errorPosition, enumerator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 7381, 7410);
                    return return_v;
                }


                string
                f_1299_7348_7411(System.Management.Automation.ExecutionContext
                context, object
                obj)
                {
                    var return_v = PSObject.ToStringParser(context, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 7348, 7411);
                    return return_v;
                }


                string
                f_1299_7563_7617(System.Management.Automation.Language.ArrayLiteralAst
                arrayLiteralAst, int
                index)
                {
                    var return_v = GetEnumerableArgSeparator(arrayLiteralAst, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 7563, 7617);
                    return return_v;
                }


                bool
                f_1299_7685_7710(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 7685, 7710);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1299_7752_7780(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 7752, 7780);
                    return return_v;
                }


                string
                f_1299_7890_7933(string
                name)
                {
                    var return_v = Environment.ExpandEnvironmentVariables(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 7890, 7933);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1299_7960_7982(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 7960, 7982);
                    return return_v;
                }


                bool
                f_1299_9007_9022(string
                stringToCheck)
                {
                    var return_v = NeedQuotes(stringToCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 9007, 9022);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1299_9080_9102(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 9080, 9102);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1299_9370_9392(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 9370, 9392);
                    return return_v;
                }


                int
                f_1299_9436_9446(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 9436, 9446);
                    return return_v;
                }


                char
                f_1299_9462_9468(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 9462, 9468);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1299_9547_9570(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 9547, 9570);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1299_9634_9656(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 9634, 9656);
                    return return_v;
                }


                int
                f_1299_9771_9803(System.Management.Automation.NativeCommandParameterBinder
                this_param, string
                arg, bool
                usedQuotes)
                {
                    this_param.PossiblyGlobArg(arg, usedQuotes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 9771, 9803);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1299, 6381, 9921);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1299, 6381, 9921);
            }
        }

        private void PossiblyGlobArg(string arg, bool usedQuotes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1299, 10327, 14329);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 10409, 10433);

                var
                argExpanded = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 14230, 14318) || true) && (!argExpanded)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 14230, 14318);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 14280, 14303);

                    f_1299_14280_14302(_arguments, arg);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 14230, 14318);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1299, 10327, 14329);

                System.Text.StringBuilder
                f_1299_14280_14302(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 14280, 14302);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1299, 10327, 14329);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1299, 10327, 14329);
            }
        }

        internal static bool NeedQuotes(string stringToCheck)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1299, 14555, 15230);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 14633, 14685);

                bool
                needQuotes = false
                ,
                followingBackslash = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 14699, 14718);

                int
                quoteCount = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 14741, 14746);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 14732, 15185) || true) && (i < f_1299_14752_14772(stringToCheck))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 14774, 14777)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 14732, 15185))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 14732, 15185);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 14811, 15104) || true) && (f_1299_14815_14831(stringToCheck, i) == '"' && (DynAbs.Tracing.TraceSender.Expression_True(1299, 14815, 14861) && !followingBackslash))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 14811, 15104);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 14903, 14919);

                            quoteCount += 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 14811, 15104);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 14811, 15104);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 14961, 15104) || true) && (f_1299_14965_15000(f_1299_14983_14999(stringToCheck, i)) && (DynAbs.Tracing.TraceSender.Expression_True(1299, 14965, 15025) && (quoteCount % 2 == 0)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 14961, 15104);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15067, 15085);

                                needQuotes = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 14961, 15104);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 14811, 15104);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15124, 15170);

                        followingBackslash = f_1299_15145_15161(stringToCheck, i) == '\\';
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1299, 1, 454);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1299, 1, 454);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15201, 15219);

                return needQuotes;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1299, 14555, 15230);

                int
                f_1299_14752_14772(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 14752, 14772);
                    return return_v;
                }


                char
                f_1299_14815_14831(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 14815, 14831);
                    return return_v;
                }


                char
                f_1299_14983_14999(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 14983, 14999);
                    return return_v;
                }


                bool
                f_1299_14965_15000(char
                c)
                {
                    var return_v = char.IsWhiteSpace(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 14965, 15000);
                    return return_v;
                }


                char
                f_1299_15145_15161(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 15145, 15161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1299, 14555, 15230);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1299, 14555, 15230);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetEnumerableArgSeparator(ArrayLiteralAst arrayLiteralAst, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1299, 15242, 16187);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15358, 15398) || true) && (arrayLiteralAst == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 15358, 15398);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15387, 15398);

                    return " ";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 15358, 15398);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15548, 15591);

                var
                next = f_1299_15559_15590(f_1299_15559_15583(arrayLiteralAst), index)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15605, 15652);

                var
                prev = f_1299_15616_15651(f_1299_15616_15640(arrayLiteralAst), index - 1)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15668, 15709);

                var
                arrayExtent = f_1299_15686_15708(arrayLiteralAst)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15723, 15761);

                var
                afterPrev = f_1299_15739_15760(f_1299_15739_15750(prev))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15775, 15820);

                var
                beforeNext = f_1299_15792_15815(f_1299_15792_15803(next)) - 1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15836, 15876) || true) && (afterPrev == beforeNext)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 15836, 15876);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15865, 15876);

                    return ",";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 15836, 15876);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15892, 15925);

                var
                arrayText = f_1299_15908_15924(arrayExtent)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15939, 15976);

                afterPrev -= f_1299_15952_15975(arrayExtent);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 15990, 16028);

                beforeNext -= f_1299_16004_16027(arrayExtent);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 16044, 16089) || true) && (f_1299_16048_16068(arrayText, afterPrev) == ',')
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 16044, 16089);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 16077, 16089);

                    return ", ";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 16044, 16089);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 16103, 16149) || true) && (f_1299_16107_16128(arrayText, beforeNext) == ',')
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1299, 16103, 16149);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 16137, 16149);

                    return " ,";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1299, 16103, 16149);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1299, 16163, 16176);

                return " , ";
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1299, 15242, 16187);

                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1299_15559_15583(System.Management.Automation.Language.ArrayLiteralAst
                this_param)
                {
                    var return_v = this_param.Elements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 15559, 15583);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1299_15559_15590(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 15559, 15590);
                    return return_v;
                }


                System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                f_1299_15616_15640(System.Management.Automation.Language.ArrayLiteralAst
                this_param)
                {
                    var return_v = this_param.Elements;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 15616, 15640);
                    return return_v;
                }


                System.Management.Automation.Language.ExpressionAst
                f_1299_15616_15651(System.Collections.ObjectModel.ReadOnlyCollection<System.Management.Automation.Language.ExpressionAst>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 15616, 15651);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1299_15686_15708(System.Management.Automation.Language.ArrayLiteralAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 15686, 15708);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1299_15739_15750(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 15739, 15750);
                    return return_v;
                }


                int
                f_1299_15739_15760(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.EndOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 15739, 15760);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1299_15792_15803(System.Management.Automation.Language.ExpressionAst
                this_param)
                {
                    var return_v = this_param.Extent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 15792, 15803);
                    return return_v;
                }


                int
                f_1299_15792_15815(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 15792, 15815);
                    return return_v;
                }


                string
                f_1299_15908_15924(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.Text;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 15908, 15924);
                    return return_v;
                }


                int
                f_1299_15952_15975(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 15952, 15975);
                    return return_v;
                }


                int
                f_1299_16004_16027(System.Management.Automation.Language.IScriptExtent
                this_param)
                {
                    var return_v = this_param.StartOffset;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 16004, 16027);
                    return return_v;
                }


                char
                f_1299_16048_16068(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 16048, 16068);
                    return return_v;
                }


                char
                f_1299_16107_16128(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 16107, 16128);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1299, 15242, 16187);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1299, 15242, 16187);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NativeCommand _nativeCommand;

        static NativeCommandParameterBinder()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1299, 472, 16370);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1299, 472, 16370);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1299, 472, 16370);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1299, 472, 16370);

        static System.Management.Automation.InvocationInfo
        f_1299_1000_1020(System.Management.Automation.NativeCommand
        this_param)
        {
            var return_v = this_param.MyInvocation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 1000, 1020);
            return return_v;
        }


        static System.Management.Automation.ExecutionContext
        f_1299_1022_1037(System.Management.Automation.NativeCommand
        this_param)
        {
            var return_v = this_param.Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1299, 1022, 1037);
            return return_v;
        }


        static System.Management.Automation.InvocationInfo
        f_1299_1000_1020_C(System.Management.Automation.InvocationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1299, 918, 1108);
            return return_v;
        }


        System.Text.StringBuilder
        f_1299_5562_5581()
        {
            var return_v = new System.Text.StringBuilder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1299, 5562, 5581);
            return return_v;
        }

    }
}
