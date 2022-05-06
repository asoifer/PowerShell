// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.ObjectModel;
using System.Globalization;
using System.IO;
using System.Management.Automation.Language;
using System.Xml;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal class MinishellParameterBinderController : NativeCommandParameterBinderController
    {
        internal MinishellParameterBinderController(
                    NativeCommand command)
        : base(f_1289_1091_1098_C(command))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1289, 990, 1231);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 2056, 2120);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 2274, 2339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 2463, 2513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 1124, 1164);

                InputFormat = NativeCommandIOFormat.Xml;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 1178, 1220);

                OutputFormat = NativeCommandIOFormat.Text;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1289, 990, 1231);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1289, 990, 1231);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1289, 990, 1231);
            }
        }

        internal override
                Collection<CommandParameterInternal>
                BindParameters(Collection<CommandParameterInternal> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1289, 1657, 1903);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 1818, 1866);

                f_1289_1818_1865(false, "this method should be used");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 1880, 1892);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1289, 1657, 1903);

                int
                f_1289_1818_1865(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 1818, 1865);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1289, 1657, 1903);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1289, 1657, 1903);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal NativeCommandIOFormat InputFormat { get; private set; }

        internal NativeCommandIOFormat OutputFormat { get; private set; }

        internal bool NonInteractive { get; private set; }

        internal Collection<CommandParameterInternal> BindParameters(Collection<CommandParameterInternal> parameters, bool outputRedirected, string hostName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1289, 3133, 13713);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 3307, 3336);

                MinishellParameters
                seen = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 3350, 3376);

                string
                inputFormat = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 3390, 3417);

                string
                outputFormat = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 3440, 3445);
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 3431, 11422) || true) && (i < f_1289_3451_3467(parameters))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 3469, 3472)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 3431, 11422))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 3431, 11422);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 3506, 3536);

                        var
                        parameter = f_1289_3522_3535(parameters, i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 3556, 11407) || true) && (f_1289_3560_3592(parameter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 3556, 11407);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 3634, 3678);

                            var
                            parameterName = f_1289_3654_3677(parameter)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 3702, 10316) || true) && (f_1289_3706_3784(CommandParameter, parameterName, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 3702, 10316);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 3834, 3911);

                                f_1289_3834_3910(this, ref seen, MinishellParameters.Command, CommandParameter);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 4015, 4505) || true) && (i + 1 >= f_1289_4028_4044(parameters))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 4015, 4505);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 4102, 4478);

                                    throw f_1289_4108_4477(this, null, ErrorCategory.InvalidArgument, CommandParameter, typeof(ScriptBlock), null, f_1289_4347_4382(), "NoValueForCommandParameter");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 4015, 4505);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 4533, 4540);

                                i += 1;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 4644, 4684);

                                var
                                scriptBlockArgument = f_1289_4670_4683(parameters, i)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 4710, 4779);

                                var
                                argumentValue = f_1289_4730_4778(f_1289_4744_4777(scriptBlockArgument))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 4805, 5376) || true) && (f_1289_4809_4847_M(!scriptBlockArgument.ArgumentSpecified) || (DynAbs.Tracing.TraceSender.Expression_False(1289, 4809, 4882) || !(argumentValue is ScriptBlock)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 4805, 5376);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 4940, 5349);

                                    throw f_1289_4946_5348(this, null, ErrorCategory.InvalidArgument, CommandParameter, typeof(ScriptBlock), f_1289_5115_5138(argumentValue), f_1289_5204_5246(), "IncorrectValueForCommandParameter");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 4805, 5376);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 5505, 5646);

                                parameters[i - 1] = f_1289_5525_5645(EncodedCommandParameter, "-" + EncodedCommandParameter, f_1289_5622_5644(parameter));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 5672, 5766);

                                string
                                encodedScript = f_1289_5695_5765(f_1289_5740_5764(argumentValue))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 5792, 5896);

                                parameters[i] = f_1289_5808_5895(encodedScript, f_1289_5863_5894(scriptBlockArgument));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 3702, 10316);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 3702, 10316);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 5946, 10316) || true) && (f_1289_5950_6032(InputFormatParameter, parameterName, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 5946, 10316);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 6082, 6167);

                                    f_1289_6082_6166(this, ref seen, MinishellParameters.InputFormat, InputFormatParameter);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 6264, 6761) || true) && (i + 1 >= f_1289_6277_6293(parameters))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 6264, 6761);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 6351, 6734);

                                        throw f_1289_6357_6733(this, null, ErrorCategory.InvalidArgument, InputFormatParameter, typeof(string), null, f_1289_6595_6634(), "NoValueForInputFormatParameter");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 6264, 6761);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 6869, 6876);

                                    i += 1;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 6902, 6937);

                                    var
                                    inputFormatArg = f_1289_6923_6936(parameters, i)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 6963, 7057);

                                    inputFormat = f_1289_6977_7056(this, InputFormatParameter, f_1289_7027_7055(inputFormatArg));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 7083, 7218);

                                    parameters[i - 1] = f_1289_7103_7217(InputFormatParameter, "-" + InputFormatParameter, f_1289_7194_7216(parameter));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 7244, 7341);

                                    parameters[i] = f_1289_7260_7340(inputFormat, f_1289_7313_7339(inputFormatArg));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 5946, 10316);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 5946, 10316);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 7391, 10316) || true) && (f_1289_7395_7478(OutputFormatParameter, parameterName, StringComparison.OrdinalIgnoreCase))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 7391, 10316);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 7528, 7615);

                                        f_1289_7528_7614(this, ref seen, MinishellParameters.OutputFormat, OutputFormatParameter);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 7712, 8211) || true) && (i + 1 >= f_1289_7725_7741(parameters))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 7712, 8211);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 7799, 8184);

                                            throw f_1289_7805_8183(this, null, ErrorCategory.InvalidArgument, OutputFormatParameter, typeof(string), null, f_1289_8044_8084(), "NoValueForInputFormatParameter");
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 7712, 8211);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 8319, 8326);

                                        i += 1;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 8352, 8388);

                                        var
                                        outputFormatArg = f_1289_8374_8387(parameters, i)
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 8414, 8511);

                                        outputFormat = f_1289_8429_8510(this, OutputFormatParameter, f_1289_8480_8509(outputFormatArg));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 8537, 8674);

                                        parameters[i - 1] = f_1289_8557_8673(OutputFormatParameter, "-" + OutputFormatParameter, f_1289_8650_8672(parameter));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 8700, 8799);

                                        parameters[i] = f_1289_8716_8798(outputFormat, f_1289_8770_8797(outputFormatArg));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 7391, 10316);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 7391, 10316);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 8849, 10316) || true) && (f_1289_8853_8928(ArgsParameter, parameterName, StringComparison.OrdinalIgnoreCase))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 8849, 10316);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 8978, 9054);

                                            f_1289_8978_9053(this, ref seen, MinishellParameters.Arguments, ArgsParameter);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 9154, 9568) || true) && (i + 1 >= f_1289_9167_9183(parameters))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 9154, 9568);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 9241, 9541);

                                                throw f_1289_9247_9540(this, null, ErrorCategory.InvalidArgument, ArgsParameter, typeof(string), null, f_1289_9414_9447(), "NoValuesSpecifiedForArgs");
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 9154, 9568);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 9666, 9673);

                                            i += 1;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 9699, 9727);

                                            var
                                            argsArg = f_1289_9713_9726(parameters, i)
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 9753, 9826);

                                            var
                                            encodedArgs = f_1289_9771_9825(f_1289_9803_9824(argsArg))
                                            ;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 9852, 9987);

                                            parameters[i - 1] = f_1289_9872_9986(EncodedArgsParameter, "-" + EncodedArgsParameter, f_1289_9963_9985(parameter));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 10224, 10293);

                                            parameters[i] = f_1289_10240_10292(encodedArgs);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 8849, 10316);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 7391, 10316);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 5946, 10316);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 3702, 10316);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 3556, 11407);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 3556, 11407);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 10505, 10545);

                            var
                            scriptBlockArgument = f_1289_10531_10544(parameters, i)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 10567, 10636);

                            var
                            argumentValue = f_1289_10587_10635(f_1289_10601_10634(scriptBlockArgument))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 10658, 11388) || true) && (argumentValue is ScriptBlock)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 10658, 11388);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 10740, 10817);

                                f_1289_10740_10816(this, ref seen, MinishellParameters.Command, CommandParameter);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 10944, 11038);

                                string
                                encodedScript = f_1289_10967_11037(f_1289_11012_11036(argumentValue))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 11064, 11365);

                                parameters[i] = f_1289_11080_11364(f_1289_11163_11184(parameter), EncodedCommandParameter, "-" + EncodedCommandParameter, f_1289_11271_11292(parameter), encodedScript, spaceAfterParameter: true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 10658, 11388);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 3556, 11407);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1289, 1, 7992);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1289, 1, 7992);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 11514, 11892) || true) && (inputFormat == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 11514, 11892);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 11633, 11740);

                    f_1289_11633_11739(                // For minishell default input format is xml
                                    parameters, f_1289_11648_11738(InputFormatParameter, "-" + InputFormatParameter));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 11758, 11830);

                    f_1289_11758_11829(parameters, f_1289_11773_11828(XmlFormatValue));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 11848, 11877);

                    inputFormat = XmlFormatValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 11514, 11892);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 11908, 12336) || true) && (outputFormat == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 11908, 12336);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 12039, 12106);

                    outputFormat = (DynAbs.Tracing.TraceSender.Conditional_F1(1289, 12054, 12070) || ((outputRedirected && DynAbs.Tracing.TraceSender.Conditional_F2(1289, 12073, 12087)) || DynAbs.Tracing.TraceSender.Conditional_F3(1289, 12090, 12105))) ? XmlFormatValue : TextFormatValue;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 12124, 12233);

                    f_1289_12124_12232(parameters, f_1289_12139_12231(OutputFormatParameter, "-" + OutputFormatParameter));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 12251, 12321);

                    f_1289_12251_12320(parameters, f_1289_12266_12319(outputFormat));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 11908, 12336);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 12415, 12595);

                InputFormat = (DynAbs.Tracing.TraceSender.Conditional_F1(1289, 12429, 12503) || ((f_1289_12429_12503(XmlFormatValue, inputFormat, StringComparison.OrdinalIgnoreCase) && DynAbs.Tracing.TraceSender.Conditional_F2(1289, 12523, 12548)) || DynAbs.Tracing.TraceSender.Conditional_F3(1289, 12568, 12594))) ? NativeCommandIOFormat.Xml
                : NativeCommandIOFormat.Text;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 12609, 12791);

                OutputFormat = (DynAbs.Tracing.TraceSender.Conditional_F1(1289, 12624, 12699) || ((f_1289_12624_12699(XmlFormatValue, outputFormat, StringComparison.OrdinalIgnoreCase) && DynAbs.Tracing.TraceSender.Conditional_F2(1289, 12719, 12744)) || DynAbs.Tracing.TraceSender.Conditional_F3(1289, 12764, 12790))) ? NativeCommandIOFormat.Xml
                : NativeCommandIOFormat.Text;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 13113, 13426) || true) && (f_1289_13117_13147(hostName) || (DynAbs.Tracing.TraceSender.Expression_False(1289, 13117, 13218) || !f_1289_13152_13218(hostName, "ConsoleHost", StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 13113, 13426);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 13252, 13274);

                    NonInteractive = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 13292, 13411);

                    f_1289_13292_13410(parameters, 0, f_1289_13313_13409(NonInteractiveParameter, "-" + NonInteractiveParameter));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 13113, 13426);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 13442, 13524);

                f_1289_13442_13523(
                            ((NativeCommandParameterBinder)f_1289_13473_13495()), parameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 13540, 13655);

                f_1289_13540_13654(f_1289_13559_13588(s_emptyReturnCollection) == 0, "This list shouldn't be used for anything as it's shared.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 13671, 13702);

                return s_emptyReturnCollection;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1289, 3133, 13713);

                int
                f_1289_3451_3467(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 3451, 3467);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_3522_3535(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 3522, 3535);
                    return return_v;
                }


                bool
                f_1289_3560_3592(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterNameSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 3560, 3592);
                    return return_v;
                }


                string
                f_1289_3654_3677(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 3654, 3677);
                    return return_v;
                }


                bool
                f_1289_3706_3784(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 3706, 3784);
                    return return_v;
                }


                int
                f_1289_3834_3910(System.Management.Automation.MinishellParameterBinderController
                this_param, ref System.Management.Automation.MinishellParameterBinderController.MinishellParameters
                seen, System.Management.Automation.MinishellParameterBinderController.MinishellParameters
                parameter, string
                parameterName)
                {
                    this_param.HandleSeenParameter(ref seen, parameter, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 3834, 3910);
                    return 0;
                }


                int
                f_1289_4028_4044(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 4028, 4044);
                    return return_v;
                }


                string
                f_1289_4347_4382()
                {
                    var return_v = NativeCP.NoValueForCommandParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 4347, 4382);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1289_4108_4477(System.Management.Automation.MinishellParameterBinderController
                this_param, System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = this_param.NewParameterBindingException(innerException, errorCategory, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 4108, 4477);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_4670_4683(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 4670, 4683);
                    return return_v;
                }


                object
                f_1289_4744_4777(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 4744, 4777);
                    return return_v;
                }


                object
                f_1289_4730_4778(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 4730, 4778);
                    return return_v;
                }


                bool
                f_1289_4809_4847_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 4809, 4847);
                    return return_v;
                }


                System.Type
                f_1289_5115_5138(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 5115, 5138);
                    return return_v;
                }


                string
                f_1289_5204_5246()
                {
                    var return_v = NativeCP.IncorrectValueForCommandParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 5204, 5246);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1289_4946_5348(System.Management.Automation.MinishellParameterBinderController
                this_param, System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = this_param.NewParameterBindingException(innerException, errorCategory, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 4946, 5348);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1289_5622_5644(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 5622, 5644);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_5525_5645(string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = CommandParameterInternal.CreateParameter(parameterName, parameterText, ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 5525, 5645);
                    return return_v;
                }


                string?
                f_1289_5740_5764(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 5740, 5764);
                    return return_v;
                }


                string
                f_1289_5695_5765(string
                input)
                {
                    var return_v = StringToBase64Converter.StringToBase64String(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 5695, 5765);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1289_5863_5894(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 5863, 5894);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_5808_5895(string
                value, System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = CommandParameterInternal.CreateArgument((object)value, ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 5808, 5895);
                    return return_v;
                }


                bool
                f_1289_5950_6032(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 5950, 6032);
                    return return_v;
                }


                int
                f_1289_6082_6166(System.Management.Automation.MinishellParameterBinderController
                this_param, ref System.Management.Automation.MinishellParameterBinderController.MinishellParameters
                seen, System.Management.Automation.MinishellParameterBinderController.MinishellParameters
                parameter, string
                parameterName)
                {
                    this_param.HandleSeenParameter(ref seen, parameter, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 6082, 6166);
                    return 0;
                }


                int
                f_1289_6277_6293(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 6277, 6293);
                    return return_v;
                }


                string
                f_1289_6595_6634()
                {
                    var return_v = NativeCP.NoValueForInputFormatParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 6595, 6634);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1289_6357_6733(System.Management.Automation.MinishellParameterBinderController
                this_param, System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = this_param.NewParameterBindingException(innerException, errorCategory, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 6357, 6733);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_6923_6936(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 6923, 6936);
                    return return_v;
                }


                object
                f_1289_7027_7055(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 7027, 7055);
                    return return_v;
                }


                string
                f_1289_6977_7056(System.Management.Automation.MinishellParameterBinderController
                this_param, string
                parameterName, object
                value)
                {
                    var return_v = this_param.ProcessFormatParameterValue(parameterName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 6977, 7056);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1289_7194_7216(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 7194, 7216);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_7103_7217(string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = CommandParameterInternal.CreateParameter(parameterName, parameterText, ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 7103, 7217);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1289_7313_7339(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 7313, 7339);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_7260_7340(string
                value, System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = CommandParameterInternal.CreateArgument((object)value, ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 7260, 7340);
                    return return_v;
                }


                bool
                f_1289_7395_7478(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 7395, 7478);
                    return return_v;
                }


                int
                f_1289_7528_7614(System.Management.Automation.MinishellParameterBinderController
                this_param, ref System.Management.Automation.MinishellParameterBinderController.MinishellParameters
                seen, System.Management.Automation.MinishellParameterBinderController.MinishellParameters
                parameter, string
                parameterName)
                {
                    this_param.HandleSeenParameter(ref seen, parameter, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 7528, 7614);
                    return 0;
                }


                int
                f_1289_7725_7741(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 7725, 7741);
                    return return_v;
                }


                string
                f_1289_8044_8084()
                {
                    var return_v = NativeCP.NoValueForOutputFormatParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 8044, 8084);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1289_7805_8183(System.Management.Automation.MinishellParameterBinderController
                this_param, System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = this_param.NewParameterBindingException(innerException, errorCategory, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 7805, 8183);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_8374_8387(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 8374, 8387);
                    return return_v;
                }


                object
                f_1289_8480_8509(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 8480, 8509);
                    return return_v;
                }


                string
                f_1289_8429_8510(System.Management.Automation.MinishellParameterBinderController
                this_param, string
                parameterName, object
                value)
                {
                    var return_v = this_param.ProcessFormatParameterValue(parameterName, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 8429, 8510);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1289_8650_8672(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 8650, 8672);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_8557_8673(string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = CommandParameterInternal.CreateParameter(parameterName, parameterText, ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 8557, 8673);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1289_8770_8797(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 8770, 8797);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_8716_8798(string
                value, System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = CommandParameterInternal.CreateArgument((object)value, ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 8716, 8798);
                    return return_v;
                }


                bool
                f_1289_8853_8928(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 8853, 8928);
                    return return_v;
                }


                int
                f_1289_8978_9053(System.Management.Automation.MinishellParameterBinderController
                this_param, ref System.Management.Automation.MinishellParameterBinderController.MinishellParameters
                seen, System.Management.Automation.MinishellParameterBinderController.MinishellParameters
                parameter, string
                parameterName)
                {
                    this_param.HandleSeenParameter(ref seen, parameter, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 8978, 9053);
                    return 0;
                }


                int
                f_1289_9167_9183(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 9167, 9183);
                    return return_v;
                }


                string
                f_1289_9414_9447()
                {
                    var return_v = NativeCP.NoValuesSpecifiedForArgs;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 9414, 9447);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1289_9247_9540(System.Management.Automation.MinishellParameterBinderController
                this_param, System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = this_param.NewParameterBindingException(innerException, errorCategory, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 9247, 9540);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_9713_9726(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 9713, 9726);
                    return return_v;
                }


                object
                f_1289_9803_9824(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 9803, 9824);
                    return return_v;
                }


                string
                f_1289_9771_9825(object
                value)
                {
                    var return_v = ConvertArgsValueToEncodedString(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 9771, 9825);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1289_9963_9985(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 9963, 9985);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_9872_9986(string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                ast)
                {
                    var return_v = CommandParameterInternal.CreateParameter(parameterName, parameterText, ast);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 9872, 9986);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_10240_10292(string
                value)
                {
                    var return_v = CommandParameterInternal.CreateArgument((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 10240, 10292);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_10531_10544(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 10531, 10544);
                    return return_v;
                }


                object
                f_1289_10601_10634(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 10601, 10634);
                    return return_v;
                }


                object
                f_1289_10587_10635(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 10587, 10635);
                    return return_v;
                }


                int
                f_1289_10740_10816(System.Management.Automation.MinishellParameterBinderController
                this_param, ref System.Management.Automation.MinishellParameterBinderController.MinishellParameters
                seen, System.Management.Automation.MinishellParameterBinderController.MinishellParameters
                parameter, string
                parameterName)
                {
                    this_param.HandleSeenParameter(ref seen, parameter, parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 10740, 10816);
                    return 0;
                }


                string?
                f_1289_11012_11036(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 11012, 11036);
                    return return_v;
                }


                string
                f_1289_10967_11037(string
                input)
                {
                    var return_v = StringToBase64Converter.StringToBase64String(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 10967, 11037);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1289_11163_11184(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 11163, 11184);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1289_11271_11292(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 11271, 11292);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_11080_11364(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, string
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, (object)value, spaceAfterParameter: spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 11080, 11364);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_11648_11738(string
                parameterName, string
                parameterText)
                {
                    var return_v = CommandParameterInternal.CreateParameter(parameterName, parameterText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 11648, 11738);
                    return return_v;
                }


                int
                f_1289_11633_11739(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 11633, 11739);
                    return 0;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_11773_11828(string
                value)
                {
                    var return_v = CommandParameterInternal.CreateArgument((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 11773, 11828);
                    return return_v;
                }


                int
                f_1289_11758_11829(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 11758, 11829);
                    return 0;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_12139_12231(string
                parameterName, string
                parameterText)
                {
                    var return_v = CommandParameterInternal.CreateParameter(parameterName, parameterText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 12139, 12231);
                    return return_v;
                }


                int
                f_1289_12124_12232(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 12124, 12232);
                    return 0;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_12266_12319(string
                value)
                {
                    var return_v = CommandParameterInternal.CreateArgument((object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 12266, 12319);
                    return return_v;
                }


                int
                f_1289_12251_12320(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 12251, 12320);
                    return 0;
                }


                bool
                f_1289_12429_12503(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 12429, 12503);
                    return return_v;
                }


                bool
                f_1289_12624_12699(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 12624, 12699);
                    return return_v;
                }


                bool
                f_1289_13117_13147(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 13117, 13147);
                    return return_v;
                }


                bool
                f_1289_13152_13218(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 13152, 13218);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1289_13313_13409(string
                parameterName, string
                parameterText)
                {
                    var return_v = CommandParameterInternal.CreateParameter(parameterName, parameterText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 13313, 13409);
                    return return_v;
                }


                int
                f_1289_13292_13410(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, int
                index, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 13292, 13410);
                    return 0;
                }


                System.Management.Automation.ParameterBinderBase
                f_1289_13473_13495()
                {
                    var return_v = DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 13473, 13495);
                    return return_v;
                }


                int
                f_1289_13442_13523(System.Management.Automation.NativeCommandParameterBinder
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                parameters)
                {
                    this_param.BindParameters(parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 13442, 13523);
                    return 0;
                }


                int
                f_1289_13559_13588(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 13559, 13588);
                    return return_v;
                }


                int
                f_1289_13540_13654(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 13540, 13654);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1289, 3133, 13713);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1289, 3133, 13713);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly Collection<CommandParameterInternal> s_emptyReturnCollection;

        internal const string
        CommandParameter = "command"
        ;

        internal const string
        EncodedCommandParameter = "encodedCommand"
        ;

        internal const string
        ArgsParameter = "args"
        ;

        internal const string
        EncodedArgsParameter = "encodedarguments"
        ;

        internal const string
        InputFormatParameter = "inputFormat"
        ;

        internal const string
        OutputFormatParameter = "outputFormat"
        ;

        internal const string
        XmlFormatValue = "xml"
        ;

        internal const string
        TextFormatValue = "text"
        ;

        internal const string
        NonInteractiveParameter = "noninteractive"
        ;

        [Flags]
        private enum MinishellParameters
        {
            Command = 0x01,
            Arguments = 0x02,
            InputFormat = 0x04,
            OutputFormat = 0x08
        };

        private void HandleSeenParameter(ref MinishellParameters seen, MinishellParameters parameter, string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1289, 14801, 15519);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 14941, 15508) || true) && ((seen & parameter) == parameter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 14941, 15508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 15010, 15403);

                    throw f_1289_15016_15402(this, null, ErrorCategory.InvalidArgument, "-" + parameterName, null, null, f_1289_15219_15253(), "ParameterSpecifiedAlready", parameterName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 14941, 15508);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 14941, 15508);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 15469, 15493);

                    seen = seen | parameter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 14941, 15508);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1289, 14801, 15519);

                string
                f_1289_15219_15253()
                {
                    var return_v = NativeCP.ParameterSpecifiedAlready;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 15219, 15253);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1289_15016_15402(System.Management.Automation.MinishellParameterBinderController
                this_param, System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = this_param.NewParameterBindingException(innerException, errorCategory, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 15016, 15402);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1289, 14801, 15519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1289, 14801, 15519);
            }
        }

        private string
                ProcessFormatParameterValue(string parameterName, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1289, 15930, 17337);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 16042, 16057);

                string
                fpValue
                = default(string);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 16107, 16207);

                    fpValue = (string)f_1289_16125_16206(value, typeof(string), f_1289_16177_16205());
                }
                catch (PSInvalidCastException ex)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1289, 16236, 16695);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 16302, 16680);

                    throw f_1289_16308_16679(this, ex, ErrorCategory.InvalidArgument, parameterName, typeof(string), f_1289_16455_16470(value), f_1289_16524_16570(), "StringValueExpectedForFormatParameter", parameterName);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1289, 16236, 16695);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 16711, 16856) || true) && (f_1289_16715_16785(XmlFormatValue, fpValue, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 16711, 16856);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 16819, 16841);

                    return XmlFormatValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 16711, 16856);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 16872, 17019) || true) && (f_1289_16876_16947(TextFormatValue, fpValue, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 16872, 17019);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 16981, 17004);

                    return TextFormatValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 16872, 17019);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 17035, 17326);

                throw f_1289_17041_17325(this, null, ErrorCategory.InvalidArgument, parameterName, typeof(string), f_1289_17155_17170(value), f_1289_17189_17230(), "IncorrectValueForFormatParameter", fpValue, parameterName);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1289, 15930, 17337);

                System.Globalization.CultureInfo
                f_1289_16177_16205()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 16177, 16205);
                    return return_v;
                }


                object
                f_1289_16125_16206(object
                valueToConvert, System.Type
                resultType, System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = LanguagePrimitives.ConvertTo(valueToConvert, resultType, (System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 16125, 16206);
                    return return_v;
                }


                System.Type
                f_1289_16455_16470(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 16455, 16470);
                    return return_v;
                }


                string
                f_1289_16524_16570()
                {
                    var return_v = NativeCP.StringValueExpectedForFormatParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 16524, 16570);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1289_16308_16679(System.Management.Automation.MinishellParameterBinderController
                this_param, System.Management.Automation.PSInvalidCastException
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = this_param.NewParameterBindingException((System.Exception)innerException, errorCategory, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 16308, 16679);
                    return return_v;
                }


                bool
                f_1289_16715_16785(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 16715, 16785);
                    return return_v;
                }


                bool
                f_1289_16876_16947(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 16876, 16947);
                    return return_v;
                }


                System.Type
                f_1289_17155_17170(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 17155, 17170);
                    return return_v;
                }


                string
                f_1289_17189_17230()
                {
                    var return_v = NativeCP.IncorrectValueForFormatParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 17189, 17230);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1289_17041_17325(System.Management.Automation.MinishellParameterBinderController
                this_param, System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = this_param.NewParameterBindingException(innerException, errorCategory, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 17041, 17325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1289, 15930, 17337);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1289, 15930, 17337);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string ConvertArgsValueToEncodedString(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1289, 17467, 18287);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 17559, 17611);

                ArrayList
                list = f_1289_17576_17610(value)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 17662, 17758);

                StringWriter
                stringWriter = f_1289_17690_17757(f_1289_17707_17756())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 17875, 17928);

                XmlWriter
                xmlWriter = f_1289_17897_17927(stringWriter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 17942, 17992);

                Serializer
                serializer = f_1289_17966_17991(xmlWriter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 18006, 18033);

                f_1289_18006_18032(serializer, list);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 18047, 18065);

                f_1289_18047_18064(serializer);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 18079, 18097);

                f_1289_18079_18096(xmlWriter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 18111, 18151);

                string
                result = f_1289_18127_18150(stringWriter)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 18216, 18276);

                return f_1289_18223_18275(result);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1289, 17467, 18287);

                System.Collections.ArrayList
                f_1289_17576_17610(object
                value)
                {
                    var return_v = ConvertArgsValueToArrayList(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 17576, 17610);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1289_17707_17756()
                {
                    var return_v = System.Globalization.CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 17707, 17756);
                    return return_v;
                }


                System.IO.StringWriter
                f_1289_17690_17757(System.Globalization.CultureInfo
                formatProvider)
                {
                    var return_v = new System.IO.StringWriter((System.IFormatProvider)formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 17690, 17757);
                    return return_v;
                }


                System.Xml.XmlWriter
                f_1289_17897_17927(System.IO.StringWriter
                output)
                {
                    var return_v = XmlWriter.Create((System.IO.TextWriter)output);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 17897, 17927);
                    return return_v;
                }


                System.Management.Automation.Serializer
                f_1289_17966_17991(System.Xml.XmlWriter
                writer)
                {
                    var return_v = new System.Management.Automation.Serializer(writer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 17966, 17991);
                    return return_v;
                }


                int
                f_1289_18006_18032(System.Management.Automation.Serializer
                this_param, System.Collections.ArrayList
                source)
                {
                    this_param.Serialize((object)source);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 18006, 18032);
                    return 0;
                }


                int
                f_1289_18047_18064(System.Management.Automation.Serializer
                this_param)
                {
                    this_param.Done();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 18047, 18064);
                    return 0;
                }


                int
                f_1289_18079_18096(System.Xml.XmlWriter
                this_param)
                {
                    this_param.Flush();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 18079, 18096);
                    return 0;
                }


                string
                f_1289_18127_18150(System.IO.StringWriter
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 18127, 18150);
                    return return_v;
                }


                string
                f_1289_18223_18275(string
                input)
                {
                    var return_v = StringToBase64Converter.StringToBase64String(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 18223, 18275);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1289, 17467, 18287);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1289, 17467, 18287);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static ArrayList ConvertArgsValueToArrayList(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1289, 18451, 18966);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 18542, 18578);

                ArrayList
                results = f_1289_18562_18577()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 18592, 18651);

                IEnumerator
                list = f_1289_18611_18650(value)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 18665, 18924) || true) && (list == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 18665, 18924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 18715, 18734);

                    f_1289_18715_18733(results, value);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 18665, 18924);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 18665, 18924);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 18800, 18909) || true) && (f_1289_18807_18822(list))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1289, 18800, 18909);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 18864, 18890);

                            f_1289_18864_18889(results, f_1289_18876_18888(list));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 18800, 18909);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1289, 18800, 18909);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1289, 18800, 18909);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1289, 18665, 18924);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 18940, 18955);

                return results;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1289, 18451, 18966);

                System.Collections.ArrayList
                f_1289_18562_18577()
                {
                    var return_v = new System.Collections.ArrayList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 18562, 18577);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1289_18611_18650(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerator(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 18611, 18650);
                    return return_v;
                }


                int
                f_1289_18715_18733(System.Collections.ArrayList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 18715, 18733);
                    return return_v;
                }


                bool
                f_1289_18807_18822(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.MoveNext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 18807, 18822);
                    return return_v;
                }


                object
                f_1289_18876_18888(System.Collections.IEnumerator
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 18876, 18888);
                    return return_v;
                }


                int
                f_1289_18864_18889(System.Collections.ArrayList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 18864, 18889);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1289, 18451, 18966);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1289, 18451, 18966);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ParameterBindingException NewParameterBindingException(
                    Exception innerException,
                    ErrorCategory errorCategory,
                    string parameterName,
                    Type parameterType,
                    Type typeSpecified,
                    string resourceString,
                    string errorId,
                    params object[] args)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1289, 18978, 19701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 19348, 19690);

                return f_1289_19355_19689(innerException, errorCategory, f_1289_19468_19487(this), null, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1289, 18978, 19701);

                System.Management.Automation.InvocationInfo
                f_1289_19468_19487(System.Management.Automation.MinishellParameterBinderController
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1289, 19468, 19487);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1289_19355_19689(System.Exception
                innerException, System.Management.Automation.ErrorCategory
                errorCategory, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                parameterName, System.Type
                parameterType, System.Type
                typeSpecified, string
                resourceString, string
                errorId, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(innerException, errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 19355, 19689);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1289, 18978, 19701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1289, 18978, 19701);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static MinishellParameterBinderController()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1289, 568, 19708);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 13786, 13854);
            s_emptyReturnCollection = f_1289_13812_13854();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 13889, 13917);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 13950, 13992);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 14025, 14047);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 14080, 14121);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 14154, 14190);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 14223, 14261);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 14294, 14316);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 14349, 14373);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1289, 14406, 14448);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1289, 568, 19708);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1289, 568, 19708);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1289, 568, 19708);

        static System.Management.Automation.NativeCommand
        f_1289_1091_1098_C(System.Management.Automation.NativeCommand
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1289, 990, 1231);
            return return_v;
        }


        static System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
        f_1289_13812_13854()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1289, 13812, 13854);
            return return_v;
        }

    }
}
