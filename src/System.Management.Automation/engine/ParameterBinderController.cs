// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Management.Automation.Language;
using System.Text;

namespace System.Management.Automation
{
    [DebuggerDisplay("InvocationInfo = {InvocationInfo}")]
    internal abstract class ParameterBinderController
    {
        internal ParameterBinderController(InvocationInfo invocationInfo, ExecutionContext context, ParameterBinderBase parameterBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1305, 1350, 1941);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 2122, 2164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 2279, 2352);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 2477, 2524);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 2883, 2941);
                this._bindableParameters = f_1305_2905_2941();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 3064, 3142);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 3343, 3520);
                this.BoundParameters = f_1305_3431_3519(f_1305_3486_3518());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 3810, 3876);
                this.DefaultParameterBindingInUse = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 4057, 4145);
                this.BoundDefaultParameters = f_1305_4120_4144();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 4343, 4466);
                this.UnboundArguments = f_1305_4423_4465();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 4700, 4864);
                this.BoundArguments = f_1305_4781_4863(f_1305_4830_4862());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 48616, 48764);
                this.ParametersBoundThroughPipelineInput = f_1305_48715_48763();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 52427, 52467);
                this._currentParameterSetFlag = uint.MaxValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 52492, 52547);
                this._prePipelineProcessingParameterSetFlags = uint.MaxValue;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 1503, 1594);

                f_1305_1503_1593(invocationInfo != null, "Caller to verify invocationInfo is not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 1608, 1701);

                f_1305_1608_1700(parameterBinder != null, "Caller to verify parameterBinder is not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 1715, 1790);

                f_1305_1715_1789(context != null, "call to verify context is not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 1806, 1852);

                this.DefaultParameterBinder = parameterBinder;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 1866, 1884);

                Context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 1898, 1930);

                InvocationInfo = invocationInfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1305, 1350, 1941);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 1350, 1941);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 1350, 1941);
            }
        }

        internal ExecutionContext Context { get; }

        internal ParameterBinderBase DefaultParameterBinder { get; private set; }

        internal InvocationInfo InvocationInfo { get; }

        internal MergedCommandParameterMetadata BindableParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1305, 2784, 2819);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 2790, 2817);

                    return _bindableParameters;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1305, 2784, 2819);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 2701, 2830);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 2701, 2830);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected MergedCommandParameterMetadata _bindableParameters;

        protected List<MergedCompiledCommandParameter> UnboundParameters { get; set; }

        protected Dictionary<string, MergedCompiledCommandParameter> BoundParameters { get; }

        internal CommandLineParameters CommandLineParameters
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1305, 3609, 3674);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 3615, 3672);

                    return f_1305_3622_3671(f_1305_3622_3649(this));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1305, 3609, 3674);

                    System.Management.Automation.ParameterBinderBase
                    f_1305_3622_3649(System.Management.Automation.ParameterBinderController
                    this_param)
                    {
                        var return_v = this_param.DefaultParameterBinder;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 3622, 3649);
                        return return_v;
                    }


                    System.Management.Automation.CommandLineParameters
                    f_1305_3622_3671(System.Management.Automation.ParameterBinderBase
                    this_param)
                    {
                        var return_v = this_param.CommandLineParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 3622, 3671);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 3532, 3685);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 3532, 3685);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected bool DefaultParameterBindingInUse { get; set; }

        protected Collection<string> BoundDefaultParameters { get; }

        protected Collection<CommandParameterInternal> UnboundArguments { get; set; }

        internal void ClearUnboundArguments()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1305, 4478, 4576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 4540, 4565);

                f_1305_4540_4564(f_1305_4540_4556());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1305, 4478, 4576);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1305_4540_4556()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 4540, 4556);
                    return return_v;
                }


                int
                f_1305_4540_4564(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 4540, 4564);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 4478, 4576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 4478, 4576);
            }
        }

        protected Dictionary<string, CommandParameterInternal> BoundArguments { get; }

        internal void ReparseUnboundArguments()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1305, 5354, 11433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 5418, 5507);

                Collection<CommandParameterInternal>
                result = f_1305_5464_5506()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 5532, 5541);

                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 5523, 11380) || true) && (index < f_1305_5551_5573(f_1305_5551_5567()))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 5575, 5582)
        , ++index, DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 5523, 11380))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 5523, 11380);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 5616, 5676);

                        CommandParameterInternal
                        argument = f_1305_5652_5675(f_1305_5652_5668(), index)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 5872, 6051) || true) && (f_1305_5876_5908_M(!argument.ParameterNameSpecified) || (DynAbs.Tracing.TraceSender.Expression_False(1305, 5876, 5938) || f_1305_5912_5938(argument)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 5872, 6051);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 5980, 6001);

                            f_1305_5980_6000(result, argument);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 6023, 6032);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 5872, 6051);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 6071, 6238);

                        f_1305_6071_6237(f_1305_6090_6121(argument) && (DynAbs.Tracing.TraceSender.Expression_True(1305, 6090, 6152) && f_1305_6125_6152_M(!argument.ArgumentSpecified)), "At this point, we only process parameters with no arguments");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 6325, 6371);

                        string
                        parameterName = f_1305_6348_6370(argument)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 6389, 6708);

                        MergedCompiledCommandParameter
                        matchingParameter =
                        f_1305_6461_6707(_bindableParameters, parameterName, false, true, f_1305_6631_6706(f_1305_6650_6679(f_1305_6650_6669(this)), f_1305_6681_6705(argument)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 6728, 6995) || true) && (matchingParameter == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 6728, 6995);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 6924, 6945);

                            f_1305_6924_6944(                    // Since we couldn't find a match, just add the argument as it was
                                                                 // and continue
                                                result, argument);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 6967, 6976);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 6728, 6995);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 7289, 7479) || true) && (f_1305_7293_7366(parameterName, argument, f_1305_7338_7365(matchingParameter)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 7289, 7479);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 7408, 7429);

                            f_1305_7408_7428(result, argument);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 7451, 7460);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 7289, 7479);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 7620, 11365) || true) && (f_1305_7624_7646(f_1305_7624_7640()) - 1 > index)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 7620, 11365);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 7700, 7768);

                            CommandParameterInternal
                            nextArgument = f_1305_7740_7767(f_1305_7740_7756(), index + 1)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 7963, 10127) || true) && (f_1305_7967_8002(nextArgument))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 7963, 10127);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 8241, 8621);

                                MergedCompiledCommandParameter
                                nextMatchingParameter =
                                f_1305_8325_8620(_bindableParameters, f_1305_8400_8426(nextArgument), false, true, f_1305_8540_8619(f_1305_8559_8588(f_1305_8559_8578(this)), f_1305_8590_8618(nextArgument)))
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 8649, 9796) || true) && ((nextMatchingParameter != null) || (DynAbs.Tracing.TraceSender.Expression_False(1305, 8653, 8730) || f_1305_8688_8730(nextArgument)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 8649, 9796);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 9103, 9721);

                                    ParameterBindingException
                                    exception =
                                    f_1305_9174_9720(ErrorCategory.InvalidArgument, f_1305_9310_9329(this), f_1305_9368_9401(this, argument), f_1305_9440_9472(f_1305_9440_9467(matchingParameter)), f_1305_9511_9543(f_1305_9511_9538(matchingParameter)), null, f_1305_9625_9663(), "MissingArgument")
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 9753, 9769);

                                    throw exception;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 8649, 9796);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 9824, 9832);

                                ++index;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 9858, 9916);

                                argument.ParameterName = f_1305_9883_9915(f_1305_9883_9910(matchingParameter));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 9942, 10022);

                                f_1305_9942_10021(argument, f_1305_9968_9992(nextArgument), f_1305_9994_10020(nextArgument));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 10048, 10069);

                                f_1305_10048_10068(result, argument);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 10095, 10104);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 7963, 10127);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 10311, 10319);

                            ++index;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 10341, 10399);

                            argument.ParameterName = f_1305_10366_10398(f_1305_10366_10393(matchingParameter));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 10421, 10501);

                            f_1305_10421_10500(argument, f_1305_10447_10471(nextArgument), f_1305_10473_10499(nextArgument));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 10523, 10544);

                            f_1305_10523_10543(result, argument);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 7620, 11365);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 7620, 11365);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 10760, 11306);

                            ParameterBindingException
                            exception =
                            f_1305_10823_11305(ErrorCategory.InvalidArgument, f_1305_10943_10962(this), f_1305_10993_11026(this, argument), f_1305_11057_11089(f_1305_11057_11084(matchingParameter)), f_1305_11120_11152(f_1305_11120_11147(matchingParameter)), null, f_1305_11218_11256(), "MissingArgument")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 11330, 11346);

                            throw exception;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 7620, 11365);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 5858);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 5858);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 11396, 11422);

                UnboundArguments = result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1305, 5354, 11433);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1305_5464_5506()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 5464, 5506);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1305_5551_5567()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 5551, 5567);
                    return return_v;
                }


                int
                f_1305_5551_5573(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 5551, 5573);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1305_5652_5668()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 5652, 5668);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1305_5652_5675(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 5652, 5675);
                    return return_v;
                }


                bool
                f_1305_5876_5908_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 5876, 5908);
                    return return_v;
                }


                bool
                f_1305_5912_5938(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 5912, 5938);
                    return return_v;
                }


                int
                f_1305_5980_6000(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 5980, 6000);
                    return 0;
                }


                bool
                f_1305_6090_6121(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterNameSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 6090, 6121);
                    return return_v;
                }


                bool
                f_1305_6125_6152_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 6125, 6152);
                    return return_v;
                }


                int
                f_1305_6071_6237(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 6071, 6237);
                    return 0;
                }


                string
                f_1305_6348_6370(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 6348, 6370);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1305_6650_6669(System.Management.Automation.ParameterBinderController
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 6650, 6669);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1305_6650_6679(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 6650, 6679);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1305_6681_6705(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 6681, 6705);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1305_6631_6706(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 6631, 6706);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1305_6461_6707(System.Management.Automation.MergedCommandParameterMetadata
                this_param, string
                name, bool
                throwOnParameterNotFound, bool
                tryExactMatching, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = this_param.GetMatchingParameter(name, throwOnParameterNotFound, tryExactMatching, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 6461, 6707);
                    return return_v;
                }


                int
                f_1305_6924_6944(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 6924, 6944);
                    return 0;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_7338_7365(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 7338, 7365);
                    return return_v;
                }


                bool
                f_1305_7293_7366(string
                argumentName, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.CompiledCommandParameter
                matchingParameter)
                {
                    var return_v = IsSwitchAndSetValue(argumentName, argument, matchingParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 7293, 7366);
                    return return_v;
                }


                int
                f_1305_7408_7428(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 7408, 7428);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1305_7624_7640()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 7624, 7640);
                    return return_v;
                }


                int
                f_1305_7624_7646(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 7624, 7646);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1305_7740_7756()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 7740, 7756);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1305_7740_7767(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 7740, 7767);
                    return return_v;
                }


                bool
                f_1305_7967_8002(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterNameSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 7967, 8002);
                    return return_v;
                }


                string
                f_1305_8400_8426(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 8400, 8426);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1305_8559_8578(System.Management.Automation.ParameterBinderController
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 8559, 8578);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1305_8559_8588(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 8559, 8588);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1305_8590_8618(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 8590, 8618);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1305_8540_8619(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 8540, 8619);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1305_8325_8620(System.Management.Automation.MergedCommandParameterMetadata
                this_param, string
                name, bool
                throwOnParameterNotFound, bool
                tryExactMatching, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = this_param.GetMatchingParameter(name, throwOnParameterNotFound, tryExactMatching, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 8325, 8620);
                    return return_v;
                }


                bool
                f_1305_8688_8730(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterAndArgumentSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 8688, 8730);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1305_9310_9329(System.Management.Automation.ParameterBinderController
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 9310, 9329);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1305_9368_9401(System.Management.Automation.ParameterBinderController
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetParameterErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 9368, 9401);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_9440_9467(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 9440, 9467);
                    return return_v;
                }


                string
                f_1305_9440_9472(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 9440, 9472);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_9511_9538(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 9511, 9538);
                    return return_v;
                }


                System.Type
                f_1305_9511_9543(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 9511, 9543);
                    return return_v;
                }


                string
                f_1305_9625_9663()
                {
                    var return_v = ParameterBinderStrings.MissingArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 9625, 9663);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1305_9174_9720(System.Management.Automation.ErrorCategory
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
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 9174, 9720);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_9883_9910(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 9883, 9910);
                    return return_v;
                }


                string
                f_1305_9883_9915(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 9883, 9915);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1305_9968_9992(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 9968, 9992);
                    return return_v;
                }


                string
                f_1305_9994_10020(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 9994, 10020);
                    return return_v;
                }


                int
                f_1305_9942_10021(System.Management.Automation.CommandParameterInternal
                this_param, System.Management.Automation.Language.Ast
                ast, string
                value)
                {
                    this_param.SetArgumentValue(ast, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 9942, 10021);
                    return 0;
                }


                int
                f_1305_10048_10068(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 10048, 10068);
                    return 0;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_10366_10393(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 10366, 10393);
                    return return_v;
                }


                string
                f_1305_10366_10398(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 10366, 10398);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1305_10447_10471(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 10447, 10471);
                    return return_v;
                }


                object
                f_1305_10473_10499(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 10473, 10499);
                    return return_v;
                }


                int
                f_1305_10421_10500(System.Management.Automation.CommandParameterInternal
                this_param, System.Management.Automation.Language.Ast
                ast, object
                value)
                {
                    this_param.SetArgumentValue(ast, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 10421, 10500);
                    return 0;
                }


                int
                f_1305_10523_10543(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 10523, 10543);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1305_10943_10962(System.Management.Automation.ParameterBinderController
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 10943, 10962);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1305_10993_11026(System.Management.Automation.ParameterBinderController
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetParameterErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 10993, 11026);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_11057_11084(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 11057, 11084);
                    return return_v;
                }


                string
                f_1305_11057_11089(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 11057, 11089);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_11120_11147(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 11120, 11147);
                    return return_v;
                }


                System.Type
                f_1305_11120_11152(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 11120, 11152);
                    return return_v;
                }


                string
                f_1305_11218_11256()
                {
                    var return_v = ParameterBinderStrings.MissingArgument;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 11218, 11256);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1305_10823_11305(System.Management.Automation.ErrorCategory
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
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 10823, 11305);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 5354, 11433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 5354, 11433);
            }
        }

        private static bool IsSwitchAndSetValue(
                    string argumentName,
                    CommandParameterInternal argument,
                    CompiledCommandParameter matchingParameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1305, 11445, 11973);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 11649, 11669);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 11685, 11932) || true) && (f_1305_11689_11711(matchingParameter) == typeof(SwitchParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 11685, 11932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 11772, 11810);

                    argument.ParameterName = argumentName;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 11828, 11885);

                    f_1305_11828_11884(argument, null, SwitchParameter.Present);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 11903, 11917);

                    result = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 11685, 11932);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 11948, 11962);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1305, 11445, 11973);

                System.Type
                f_1305_11689_11711(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 11689, 11711);
                    return return_v;
                }


                int
                f_1305_11828_11884(System.Management.Automation.CommandParameterInternal
                this_param, System.Management.Automation.Language.Ast
                ast, System.Management.Automation.SwitchParameter
                value)
                {
                    this_param.SetArgumentValue(ast, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 11828, 11884);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 11445, 11973);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 11445, 11973);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ArgumentLooksLikeParameter(string arg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1305, 12376, 12641);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 12460, 12480);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 12496, 12600) || true) && (!f_1305_12501_12526(arg))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 12496, 12600);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 12560, 12585);

                    result = f_1305_12569_12584(f_1305_12569_12575(arg, 0));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 12496, 12600);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 12616, 12630);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1305, 12376, 12641);

                bool
                f_1305_12501_12526(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 12501, 12526);
                    return return_v;
                }


                char
                f_1305_12569_12575(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 12569, 12575);
                    return return_v;
                }


                bool
                f_1305_12569_12584(char
                c)
                {
                    var return_v = c.IsDash();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 12569, 12584);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 12376, 12641);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 12376, 12641);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void AddArgumentsToCommandProcessor(CommandProcessorBase commandProcessor, object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1305, 13237, 16714);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 13372, 16703) || true) && ((arguments != null) && (DynAbs.Tracing.TraceSender.Expression_True(1305, 13376, 13421) && (f_1305_13400_13416(arguments) > 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 13372, 16703);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 13455, 13545);

                    PSBoundParametersDictionary
                    boundParameters = arguments[0] as PSBoundParametersDictionary
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 13563, 16688) || true) && ((boundParameters != null) && (DynAbs.Tracing.TraceSender.Expression_True(1305, 13567, 13619) && (f_1305_13597_13613(arguments) == 1)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 13563, 16688);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 13754, 14218);
                            foreach (KeyValuePair<string, object> boundParameter in f_1305_13810_13825_I(boundParameters))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 13754, 14218);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 13875, 14132);

                                CommandParameterInternal
                                param = f_1305_13908_14131(null, boundParameter.Key, boundParameter.Key, null, boundParameter.Value, false)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 14158, 14195);

                                f_1305_14158_14194(commandProcessor, param);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 13754, 14218);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 465);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 465);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 13563, 16688);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 13563, 16688);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 14376, 14388);
                            // Otherwise, we need to parse them ourselves
                            for (int
        argIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 14367, 16669) || true) && (argIndex < f_1305_14401_14417(arguments))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 14419, 14429)
        , ++argIndex, DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 14367, 16669))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 14367, 16669);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 14479, 14510);

                                CommandParameterInternal
                                param
                                = default(CommandParameterInternal);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 14536, 14585);

                                string
                                paramText = arguments[argIndex] as string
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 14611, 16581) || true) && (f_1305_14615_14652(paramText))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 14611, 16581);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 15016, 15056);

                                    var
                                    colonIndex = f_1305_15033_15055(paramText, ':')
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 15086, 16371) || true) && (colonIndex != -1 && (DynAbs.Tracing.TraceSender.Expression_True(1305, 15090, 15144) && colonIndex != f_1305_15124_15140(paramText) - 1))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 15086, 16371);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 15210, 15528);

                                        param = f_1305_15218_15527(null, f_1305_15331_15369(paramText, 1, colonIndex - 1), paramText, null, f_1305_15440_15482(f_1305_15440_15475(paramText, colonIndex + 1)), false);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 15086, 16371);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 15086, 16371);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 15594, 16371) || true) && (argIndex == f_1305_15610_15626(arguments) - 1 || (DynAbs.Tracing.TraceSender.Expression_False(1305, 15598, 15672) || f_1305_15634_15665(paramText, f_1305_15644_15660(paramText) - 1) != ':'))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 15594, 16371);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 15738, 15860);

                                            param = f_1305_15746_15859(f_1305_15825_15847(paramText, 1), paramText);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 15594, 16371);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 15594, 16371);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 15990, 16295);

                                            param = f_1305_15998_16294(null, f_1305_16111_16155(paramText, 1, f_1305_16134_16150(paramText) - 2), paramText, null, arguments[argIndex + 1], false);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 16329, 16340);

                                            argIndex++;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 15594, 16371);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 15086, 16371);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 14611, 16581);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 14611, 16581);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 16485, 16554);

                                    param = f_1305_16493_16553(arguments[argIndex]);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 14611, 16581);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 16609, 16646);

                                f_1305_16609_16645(
                                                        commandProcessor, param);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 2303);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 2303);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 13563, 16688);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 13372, 16703);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1305, 13237, 16714);

                int
                f_1305_13400_13416(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 13400, 13416);
                    return return_v;
                }


                int
                f_1305_13597_13613(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 13597, 13613);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1305_13908_14131(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, object
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 13908, 14131);
                    return return_v;
                }


                int
                f_1305_14158_14194(System.Management.Automation.CommandProcessorBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter)
                {
                    this_param.AddParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 14158, 14194);
                    return 0;
                }


                System.Management.Automation.PSBoundParametersDictionary
                f_1305_13810_13825_I(System.Management.Automation.PSBoundParametersDictionary
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 13810, 13825);
                    return return_v;
                }


                int
                f_1305_14401_14417(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 14401, 14417);
                    return return_v;
                }


                bool
                f_1305_14615_14652(string
                arg)
                {
                    var return_v = ArgumentLooksLikeParameter(arg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 14615, 14652);
                    return return_v;
                }


                int
                f_1305_15033_15055(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 15033, 15055);
                    return return_v;
                }


                int
                f_1305_15124_15140(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 15124, 15140);
                    return return_v;
                }


                string
                f_1305_15331_15369(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 15331, 15369);
                    return return_v;
                }


                string
                f_1305_15440_15475(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 15440, 15475);
                    return return_v;
                }


                string
                f_1305_15440_15482(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 15440, 15482);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1305_15218_15527(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, string
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, (object)value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 15218, 15527);
                    return return_v;
                }


                int
                f_1305_15610_15626(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 15610, 15626);
                    return return_v;
                }


                int
                f_1305_15644_15660(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 15644, 15660);
                    return return_v;
                }


                char
                f_1305_15634_15665(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 15634, 15665);
                    return return_v;
                }


                string
                f_1305_15825_15847(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 15825, 15847);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1305_15746_15859(string
                parameterName, string
                parameterText)
                {
                    var return_v = CommandParameterInternal.CreateParameter(parameterName, parameterText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 15746, 15859);
                    return return_v;
                }


                int
                f_1305_16134_16150(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 16134, 16150);
                    return return_v;
                }


                string
                f_1305_16111_16155(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 16111, 16155);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1305_15998_16294(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, object
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 15998, 16294);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1305_16493_16553(object
                value)
                {
                    var return_v = CommandParameterInternal.CreateArgument(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 16493, 16553);
                    return return_v;
                }


                int
                f_1305_16609_16645(System.Management.Automation.CommandProcessorBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter)
                {
                    this_param.AddParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 16609, 16645);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 13237, 16714);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 13237, 16714);
            }
        }

        internal virtual bool BindParameter(
                    CommandParameterInternal argument,
                    ParameterBindingFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1305, 17816, 19552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 17967, 17987);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 18003, 18366);

                MergedCompiledCommandParameter
                matchingParameter =
                f_1305_18071_18365(f_1305_18071_18089(), f_1305_18133_18155(argument), (flags & ParameterBindingFlags.ThrowOnParameterNotFound) != 0, true, f_1305_18289_18364(f_1305_18308_18337(f_1305_18308_18327(this)), f_1305_18339_18363(argument)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 18382, 19511) || true) && (matchingParameter != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 18382, 19511);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 18584, 19313) || true) && (f_1305_18588_18649(f_1305_18588_18603(), f_1305_18616_18648(f_1305_18616_18643(matchingParameter))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 18584, 19313);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 18691, 19247);

                        ParameterBindingException
                        bindingException =
                        f_1305_18761_19246(ErrorCategory.InvalidArgument, f_1305_18881_18900(this), f_1305_18931_18964(this, argument), f_1305_18995_19017(argument), null, null, f_1305_19118_19162(), nameof(ParameterBinderStrings.ParameterAlreadyBound))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 19271, 19294);

                        throw bindingException;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 18584, 19313);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 19333, 19393);

                    flags = flags & ~ParameterBindingFlags.DelayBindScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 19411, 19496);

                    result = f_1305_19420_19495(this, _currentParameterSetFlag, argument, matchingParameter, flags);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 18382, 19511);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 19527, 19541);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1305, 17816, 19552);

                System.Management.Automation.MergedCommandParameterMetadata
                f_1305_18071_18089()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 18071, 18089);
                    return return_v;
                }


                string
                f_1305_18133_18155(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 18133, 18155);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1305_18308_18327(System.Management.Automation.ParameterBinderController
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 18308, 18327);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1305_18308_18337(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 18308, 18337);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1305_18339_18363(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 18339, 18363);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1305_18289_18364(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 18289, 18364);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1305_18071_18365(System.Management.Automation.MergedCommandParameterMetadata
                this_param, string
                name, bool
                throwOnParameterNotFound, bool
                tryExactMatching, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = this_param.GetMatchingParameter(name, throwOnParameterNotFound, tryExactMatching, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 18071, 18365);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1305_18588_18603()
                {
                    var return_v = BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 18588, 18603);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_18616_18643(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 18616, 18643);
                    return return_v;
                }


                string
                f_1305_18616_18648(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 18616, 18648);
                    return return_v;
                }


                bool
                f_1305_18588_18649(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 18588, 18649);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1305_18881_18900(System.Management.Automation.ParameterBinderController
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 18881, 18900);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1305_18931_18964(System.Management.Automation.ParameterBinderController
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetParameterErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 18931, 18964);
                    return return_v;
                }


                string
                f_1305_18995_19017(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 18995, 19017);
                    return return_v;
                }


                string
                f_1305_19118_19162()
                {
                    var return_v = ParameterBinderStrings.ParameterAlreadyBound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 19118, 19162);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1305_18761_19246(System.Management.Automation.ErrorCategory
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
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 18761, 19246);
                    return return_v;
                }


                bool
                f_1305_19420_19495(System.Management.Automation.ParameterBinderController
                this_param, uint
                parameterSets, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(parameterSets, argument, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 19420, 19495);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 17816, 19552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 17816, 19552);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract Collection<CommandParameterInternal> BindParameters(Collection<CommandParameterInternal> parameters);

        internal virtual bool BindParameter(
                    uint parameterSets,
                    CommandParameterInternal argument,
                    MergedCompiledCommandParameter parameter,
                    ParameterBindingFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1305, 21407, 22583);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 21646, 21666);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 21682, 22299);

                switch (f_1305_21690_21717(parameter))
                {

                    case ParameterBinderAssociation.DeclaredFormalParameters:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 21682, 22299);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 21830, 22032);

                        result =
                        f_1305_21864_22031(f_1305_21864_21891(this), argument, f_1305_21975_21994(parameter), flags);
                        DynAbs.Tracing.TraceSender.TraceBreak(1305, 22054, 22060);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 21682, 22299);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 21682, 22299);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 22110, 22256);

                        f_1305_22110_22255(false, "Only the formal parameters are available for this type of command");
                        DynAbs.Tracing.TraceSender.TraceBreak(1305, 22278, 22284);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 21682, 22299);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 22315, 22542) || true) && (result && (DynAbs.Tracing.TraceSender.Expression_True(1305, 22319, 22382) && ((flags & ParameterBindingFlags.IsDefaultValue) == 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 22315, 22542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 22416, 22452);

                    f_1305_22416_22451(f_1305_22416_22433(), parameter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 22470, 22527);

                    f_1305_22470_22526(f_1305_22470_22485(), f_1305_22490_22514(f_1305_22490_22509(parameter)), parameter);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 22315, 22542);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 22558, 22572);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1305, 21407, 22583);

                System.Management.Automation.ParameterBinderAssociation
                f_1305_21690_21717(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.BinderAssociation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 21690, 21717);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderBase
                f_1305_21864_21891(System.Management.Automation.ParameterBinderController
                this_param)
                {
                    var return_v = this_param.DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 21864, 21891);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_21975_21994(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 21975, 21994);
                    return return_v;
                }


                bool
                f_1305_21864_22031(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter, System.Management.Automation.CompiledCommandParameter
                parameterMetadata, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(parameter, parameterMetadata, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 21864, 22031);
                    return return_v;
                }


                int
                f_1305_22110_22255(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 22110, 22255);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1305_22416_22433()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 22416, 22433);
                    return return_v;
                }


                bool
                f_1305_22416_22451(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 22416, 22451);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1305_22470_22485()
                {
                    var return_v = BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 22470, 22485);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_22490_22509(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 22490, 22509);
                    return return_v;
                }


                string
                f_1305_22490_22514(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 22490, 22514);
                    return return_v;
                }


                int
                f_1305_22470_22526(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key, System.Management.Automation.MergedCompiledCommandParameter
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 22470, 22526);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 21407, 22583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 21407, 22583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<CommandParameterInternal> BindPositionalParameters(
                    Collection<CommandParameterInternal> unboundArguments,
                    uint validParameterSets,
                    uint defaultParameterSet,
                    out ParameterBindingException outgoingBindingException
                    )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1305, 24319, 32558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 24643, 24732);

                Collection<CommandParameterInternal>
                result = f_1305_24689_24731()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 24746, 24778);

                outgoingBindingException = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 24794, 32517) || true) && (f_1305_24798_24820(unboundArguments) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 24794, 32517);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 25000, 25113);

                    List<CommandParameterInternal>
                    unboundArgumentsCollection = f_1305_25060_25112(unboundArguments)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 25257, 25381);

                    SortedDictionary<int, Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter>>
                    positionalParameterDictionary
                    = default(SortedDictionary<int, Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter>>);

                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 25445, 25583);

                        positionalParameterDictionary =
                        f_1305_25502_25582(f_1305_25538_25555(), _currentParameterSetFlag);
                    }
                    catch (InvalidOperationException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1305, 25620, 26655);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 25810, 26316);

                        ParameterBindingException
                        bindingException =
                        f_1305_25880_26315(ErrorCategory.InvalidArgument, f_1305_26000_26019(this), null, null, null, null, f_1305_26190_26247(), "AmbiguousPositionalParameterNoName")
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 26613, 26636);

                        throw bindingException;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1305, 25620, 26655);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 26675, 32502) || true) && (f_1305_26679_26714(positionalParameterDictionary) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 26675, 32502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 26760, 26790);

                        int
                        unboundArgumentsIndex = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 26814, 31898);
                            foreach (Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter> nextPositionalParameters in f_1305_26922_26958_I(f_1305_26922_26958(positionalParameterDictionary)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 26814, 31898);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 27198, 27331) || true) && (f_1305_27202_27232(nextPositionalParameters) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 27198, 27331);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 27295, 27304);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 27198, 27331);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 27359, 27572);

                                CommandParameterInternal
                                argument = f_1305_27395_27571(unboundArgumentsCollection, result, ref unboundArgumentsIndex)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 27600, 27711) || true) && (argument == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 27600, 27711);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1305, 27678, 27684);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 27600, 27711);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 28025, 28057);

                                bool
                                aParameterWasBound = false
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 28083, 28779) || true) && (defaultParameterSet != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1305, 28087, 28162) && (validParameterSets & defaultParameterSet) != 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 28083, 28779);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 28351, 28752);

                                    aParameterWasBound =
                                    f_1305_28405_28751(this, defaultParameterSet, nextPositionalParameters, argument, ParameterBindingFlags.DelayBindScriptBlock, out outgoingBindingException);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 28083, 28779);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 28807, 29439) || true) && (!aParameterWasBound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 28807, 29439);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 29012, 29412);

                                    aParameterWasBound =
                                    f_1305_29066_29411(this, validParameterSets, nextPositionalParameters, argument, ParameterBindingFlags.DelayBindScriptBlock, out outgoingBindingException);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 28807, 29439);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 29467, 30441) || true) && (!aParameterWasBound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 29467, 30441);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 29633, 30414) || true) && (defaultParameterSet != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1305, 29637, 29712) && (validParameterSets & defaultParameterSet) != 0))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 29633, 30414);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 29917, 30383);

                                        aParameterWasBound =
                                        f_1305_29975_30382(this, defaultParameterSet, nextPositionalParameters, argument, ParameterBindingFlags.ShouldCoerceType | ParameterBindingFlags.DelayBindScriptBlock, out outgoingBindingException);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 29633, 30414);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 29467, 30441);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 30469, 31139) || true) && (!aParameterWasBound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 30469, 31139);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 30671, 31112);

                                    aParameterWasBound =
                                    f_1305_30725_31111(this, validParameterSets, nextPositionalParameters, argument, ParameterBindingFlags.ShouldCoerceType | ParameterBindingFlags.DelayBindScriptBlock, out outgoingBindingException);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 30469, 31139);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 31167, 31875) || true) && (!aParameterWasBound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 31167, 31875);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 31337, 31358);

                                    f_1305_31337_31357(                            // Add the unprocessed argument to the results and continue
                                                                result, argument);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 31167, 31875);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 31167, 31875);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 31543, 31848) || true) && (validParameterSets != _currentParameterSetFlag)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 31543, 31848);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 31659, 31705);

                                        validParameterSets = _currentParameterSetFlag;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 31739, 31817);

                                        f_1305_31739_31816(positionalParameterDictionary, validParameterSets);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 31543, 31848);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 31167, 31875);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 26814, 31898);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 5085);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 5085);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 32051, 32080);

                            // Now for any arguments that were not processed, add them to
                            // the result

                            for (int
        index = unboundArgumentsIndex
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 32042, 32250) || true) && (index < f_1305_32090_32122(unboundArgumentsCollection))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 32124, 32131)
        , ++index, DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 32042, 32250))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 32042, 32250);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 32181, 32227);

                                f_1305_32181_32226(result, f_1305_32192_32225(unboundArgumentsCollection, index));
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 209);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 209);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 26675, 32502);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 26675, 32502);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 32457, 32483);

                        result = unboundArguments;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 26675, 32502);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 24794, 32517);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 32533, 32547);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1305, 24319, 32558);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1305_24689_24731()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 24689, 24731);
                    return return_v;
                }


                int
                f_1305_24798_24820(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 24798, 24820);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                f_1305_25060_25112(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                collection)
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>((System.Collections.Generic.IEnumerable<System.Management.Automation.CommandParameterInternal>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 25060, 25112);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1305_25538_25555()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 25538, 25555);
                    return return_v;
                }


                System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>
                f_1305_25502_25582(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                unboundParameters, uint
                validParameterSetFlag)
                {
                    var return_v = EvaluateUnboundPositionalParameters((System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>)unboundParameters, validParameterSetFlag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 25502, 25582);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1305_26000_26019(System.Management.Automation.ParameterBinderController
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 26000, 26019);
                    return return_v;
                }


                string
                f_1305_26190_26247()
                {
                    var return_v = ParameterBinderStrings.AmbiguousPositionalParameterNoName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 26190, 26247);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1305_25880_26315(System.Management.Automation.ErrorCategory
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
                    var return_v = new System.Management.Automation.ParameterBindingException(errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 25880, 26315);
                    return return_v;
                }


                int
                f_1305_26679_26714(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 26679, 26714);
                    return return_v;
                }


                System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>.ValueCollection
                f_1305_26922_26958(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 26922, 26958);
                    return return_v;
                }


                int
                f_1305_27202_27232(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 27202, 27232);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1305_27395_27571(System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                unboundArgumentsCollection, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                nonPositionalArguments, ref int
                unboundArgumentsIndex)
                {
                    var return_v = GetNextPositionalArgument(unboundArgumentsCollection, nonPositionalArguments, ref unboundArgumentsIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 27395, 27571);
                    return return_v;
                }


                bool
                f_1305_28405_28751(System.Management.Automation.ParameterBinderController
                this_param, uint
                validParameterSets, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                nextPositionalParameters, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.ParameterBindingFlags
                flags, out System.Management.Automation.ParameterBindingException
                bindingException)
                {
                    var return_v = this_param.BindPositionalParametersInSet(validParameterSets, nextPositionalParameters, argument, flags, out bindingException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 28405, 28751);
                    return return_v;
                }


                bool
                f_1305_29066_29411(System.Management.Automation.ParameterBinderController
                this_param, uint
                validParameterSets, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                nextPositionalParameters, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.ParameterBindingFlags
                flags, out System.Management.Automation.ParameterBindingException
                bindingException)
                {
                    var return_v = this_param.BindPositionalParametersInSet(validParameterSets, nextPositionalParameters, argument, flags, out bindingException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 29066, 29411);
                    return return_v;
                }


                bool
                f_1305_29975_30382(System.Management.Automation.ParameterBinderController
                this_param, uint
                validParameterSets, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                nextPositionalParameters, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.ParameterBindingFlags
                flags, out System.Management.Automation.ParameterBindingException
                bindingException)
                {
                    var return_v = this_param.BindPositionalParametersInSet(validParameterSets, nextPositionalParameters, argument, flags, out bindingException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 29975, 30382);
                    return return_v;
                }


                bool
                f_1305_30725_31111(System.Management.Automation.ParameterBinderController
                this_param, uint
                validParameterSets, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                nextPositionalParameters, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.ParameterBindingFlags
                flags, out System.Management.Automation.ParameterBindingException
                bindingException)
                {
                    var return_v = this_param.BindPositionalParametersInSet(validParameterSets, nextPositionalParameters, argument, flags, out bindingException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 30725, 31111);
                    return return_v;
                }


                int
                f_1305_31337_31357(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 31337, 31357);
                    return 0;
                }


                int
                f_1305_31739_31816(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>
                positionalParameterDictionary, uint
                validParameterSets)
                {
                    UpdatePositionalDictionary(positionalParameterDictionary, validParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 31739, 31816);
                    return 0;
                }


                System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>.ValueCollection
                f_1305_26922_26958_I(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 26922, 26958);
                    return return_v;
                }


                int
                f_1305_32090_32122(System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 32090, 32122);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1305_32192_32225(System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 32192, 32225);
                    return return_v;
                }


                int
                f_1305_32181_32226(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 32181, 32226);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 24319, 32558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 24319, 32558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void UpdatePositionalDictionary(
                    SortedDictionary<int, Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter>> positionalParameterDictionary,
                    uint validParameterSets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1305, 33055, 34864);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 33304, 34853);
                    foreach (Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter> parameterCollection in f_1305_33407_33443_I(f_1305_33407_33443(positionalParameterDictionary)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 33304, 34853);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 33477, 33585);

                        Collection<MergedCompiledCommandParameter>
                        paramToRemove = f_1305_33536_33584()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 33605, 34560);
                            foreach (PositionalCommandParameter positionalParameter in f_1305_33664_33690_I(f_1305_33664_33690(parameterCollection)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 33605, 34560);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 33732, 33829);

                                Collection<ParameterSetSpecificMetadata>
                                parameterSetData = f_1305_33792_33828(positionalParameter)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 33862, 33896);

                                    for (int
                index = f_1305_33870_33892(parameterSetData) - 1
                ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 33853, 34364) || true) && (index >= 0)
                ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 33910, 33917)
                , --index, DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 33853, 34364))

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 33853, 34364);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 33967, 34341) || true) && ((f_1305_33972_34012(f_1305_33972_33995(parameterSetData, index)) & validParameterSets) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1305, 33971, 34108) && f_1305_34072_34108_M(!f_1305_34073_34096(parameterSetData, index).IsInAllSets)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 33967, 34341);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 34281, 34314);

                                            f_1305_34281_34313(                            // The parameter is not in the valid parameter sets so remove it from the collection.
                                                                        parameterSetData, index);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 33967, 34341);
                                        }
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 512);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 512);
                                }
                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 34388, 34541) || true) && (f_1305_34392_34414(parameterSetData) == 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 34388, 34541);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 34469, 34518);

                                    f_1305_34469_34517(paramToRemove, f_1305_34487_34516(positionalParameter));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 34388, 34541);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 33605, 34560);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 956);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 956);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 34669, 34838);
                            foreach (MergedCompiledCommandParameter removeParam in f_1305_34724_34737_I(paramToRemove))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 34669, 34838);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 34779, 34819);

                                f_1305_34779_34818(parameterCollection, removeParam);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 34669, 34838);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 170);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 170);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 33304, 34853);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 1550);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 1550);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1305, 33055, 34864);

                System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>.ValueCollection
                f_1305_33407_33443(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 33407, 33443);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1305_33536_33584()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 33536, 33584);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>.ValueCollection
                f_1305_33664_33690(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 33664, 33690);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1305_33792_33828(System.Management.Automation.PositionalCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 33792, 33828);
                    return return_v;
                }


                int
                f_1305_33870_33892(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 33870, 33892);
                    return return_v;
                }


                System.Management.Automation.ParameterSetSpecificMetadata
                f_1305_33972_33995(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 33972, 33995);
                    return return_v;
                }


                uint
                f_1305_33972_34012(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 33972, 34012);
                    return return_v;
                }


                System.Management.Automation.ParameterSetSpecificMetadata
                f_1305_34073_34096(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 34073, 34096);
                    return return_v;
                }


                bool
                f_1305_34072_34108_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 34072, 34108);
                    return return_v;
                }


                int
                f_1305_34281_34313(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 34281, 34313);
                    return 0;
                }


                int
                f_1305_34392_34414(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 34392, 34414);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1305_34487_34516(System.Management.Automation.PositionalCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 34487, 34516);
                    return return_v;
                }


                int
                f_1305_34469_34517(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 34469, 34517);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>.ValueCollection
                f_1305_33664_33690_I(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 33664, 33690);
                    return return_v;
                }


                bool
                f_1305_34779_34818(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 34779, 34818);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1305_34724_34737_I(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 34724, 34737);
                    return return_v;
                }


                System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>.ValueCollection
                f_1305_33407_33443_I(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 33407, 33443);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 33055, 34864);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 33055, 34864);
            }
        }

        private bool BindPositionalParametersInSet(
                    uint validParameterSets,
                    Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter> nextPositionalParameters,
                    CommandParameterInternal argument,
                    ParameterBindingFlags flags,
                    out ParameterBindingException bindingException
                    )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1305, 34876, 38798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 35257, 35277);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 35291, 35315);

                bindingException = null;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 35331, 38757);
                    foreach (PositionalCommandParameter parameter in f_1305_35380_35411_I(f_1305_35380_35411(nextPositionalParameters)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 35331, 38757);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 35445, 38742);
                            foreach (ParameterSetSpecificMetadata parameterSetData in f_1305_35503_35529_I(f_1305_35503_35529(parameter)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 35445, 38742);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 35671, 35876) || true) && ((validParameterSets & f_1305_35697_35730(parameterSetData)) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1305, 35675, 35794) && f_1305_35765_35794_M(!parameterSetData.IsInAllSets)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 35671, 35876);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 35844, 35853);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 35671, 35876);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 35900, 35924);

                                bool
                                bindResult = false
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 35946, 36004);

                                string
                                parameterName = f_1305_35969_36003(f_1305_35969_35998(f_1305_35969_35988(parameter)))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 36028, 36095);

                                ParameterBindingException
                                parameterBindingExceptionToThrown = null
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 36169, 36512);

                                    CommandParameterInternal
                                    bindableArgument =
                                    f_1305_36242_36511(null, parameterName, "-" + parameterName + ":", f_1305_36426_36446(argument), f_1305_36448_36470(argument), false)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 36540, 36795);

                                    bindResult =
                                    f_1305_36582_36794(this, validParameterSets, bindableArgument, f_1305_36734_36753(parameter), flags);
                                }
                                catch (ParameterBindingArgumentTransformationException pbex)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1305, 36840, 37013);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 36949, 36990);

                                    parameterBindingExceptionToThrown = pbex;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1305, 36840, 37013);
                                }
                                catch (ParameterBindingValidationException pbex)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1305, 37035, 37550);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 37132, 37527) || true) && (f_1305_37136_37157(pbex))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 37132, 37527);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 37272, 37291);

                                        bindResult = false;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 37321, 37345);

                                        bindingException = pbex;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 37132, 37527);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 37132, 37527);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 37459, 37500);

                                        parameterBindingExceptionToThrown = pbex;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 37132, 37527);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1305, 37035, 37550);
                                }
                                catch (ParameterBindingParameterDefaultValueException pbex)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1305, 37572, 37744);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 37680, 37721);

                                    parameterBindingExceptionToThrown = pbex;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1305, 37572, 37744);
                                }
                                catch (ParameterBindingException e)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1305, 37766, 37993);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 37904, 37923);

                                    bindResult = false;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 37949, 37970);

                                    bindingException = e;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1305, 37766, 37993);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 38017, 38474) || true) && (parameterBindingExceptionToThrown != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 38017, 38474);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 38112, 38451) || true) && (f_1305_38116_38145_M(!DefaultParameterBindingInUse))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 38112, 38451);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 38203, 38243);

                                        throw parameterBindingExceptionToThrown;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 38112, 38451);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 38112, 38451);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 38357, 38424);

                                        f_1305_38357_38423(this, parameterBindingExceptionToThrown);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 38112, 38451);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 38017, 38474);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 38498, 38723) || true) && (bindResult)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 38498, 38723);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 38562, 38576);

                                    result = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 38602, 38668);

                                    f_1305_38602_38667(f_1305_38602_38628(this), parameterName);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1305, 38694, 38700);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 38498, 38723);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 35445, 38742);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 3298);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 3298);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 35331, 38757);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 3427);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 3427);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 38773, 38787);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1305, 34876, 38798);

                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>.ValueCollection
                f_1305_35380_35411(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 35380, 35411);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1305_35503_35529(System.Management.Automation.PositionalCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 35503, 35529);
                    return return_v;
                }


                uint
                f_1305_35697_35730(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 35697, 35730);
                    return return_v;
                }


                bool
                f_1305_35765_35794_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 35765, 35794);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1305_35969_35988(System.Management.Automation.PositionalCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 35969, 35988);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_35969_35998(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 35969, 35998);
                    return return_v;
                }


                string
                f_1305_35969_36003(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 35969, 36003);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1305_36426_36446(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 36426, 36446);
                    return return_v;
                }


                object
                f_1305_36448_36470(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 36448, 36470);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1305_36242_36511(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, object
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 36242, 36511);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1305_36734_36753(System.Management.Automation.PositionalCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 36734, 36753);
                    return return_v;
                }


                bool
                f_1305_36582_36794(System.Management.Automation.ParameterBinderController
                this_param, uint
                parameterSets, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(parameterSets, argument, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 36582, 36794);
                    return return_v;
                }


                bool
                f_1305_37136_37157(System.Management.Automation.ParameterBindingValidationException
                this_param)
                {
                    var return_v = this_param.SwallowException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 37136, 37157);
                    return return_v;
                }


                bool
                f_1305_38116_38145_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 38116, 38145);
                    return return_v;
                }


                int
                f_1305_38357_38423(System.Management.Automation.ParameterBinderController
                this_param, System.Management.Automation.ParameterBindingException
                pbex)
                {
                    this_param.ThrowElaboratedBindingException(pbex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 38357, 38423);
                    return 0;
                }


                System.Management.Automation.CommandLineParameters
                f_1305_38602_38628(System.Management.Automation.ParameterBinderController
                this_param)
                {
                    var return_v = this_param.CommandLineParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 38602, 38628);
                    return return_v;
                }


                int
                f_1305_38602_38667(System.Management.Automation.CommandLineParameters
                this_param, string
                name)
                {
                    this_param.MarkAsBoundPositionally(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 38602, 38667);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1305_35503_35529_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 35503, 35529);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>.ValueCollection
                f_1305_35380_35411_I(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 35380, 35411);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 34876, 38798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 34876, 38798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void ThrowElaboratedBindingException(ParameterBindingException pbex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1305, 39021, 40376);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 39124, 39242) || true) && (pbex == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 39124, 39242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 39174, 39227);

                    throw f_1305_39180_39226("pbex");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 39124, 39242);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 39258, 39368);

                f_1305_39258_39367(f_1305_39277_39293(pbex) != null, "ErrorRecord should not be null in a ParameterBindingException");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 39423, 39452);

                string
                oldMsg = f_1305_39439_39451(pbex)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 39518, 39576);

                StringBuilder
                defaultParamsGetBound = f_1305_39556_39575()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 39590, 39775);
                    foreach (string paramName in f_1305_39619_39641_I(f_1305_39619_39641()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 39590, 39775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 39675, 39760);

                        f_1305_39675_39759(defaultParamsGetBound, f_1305_39710_39738(), " -{0}", paramName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 39590, 39775);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 186);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 39791, 39875);

                string
                resourceString = f_1305_39815_39874()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 39889, 40053) || true) && (f_1305_39893_39921(f_1305_39893_39915()) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 39889, 40053);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 39959, 40038);

                    resourceString = f_1305_39976_40037();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 39889, 40053);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 40069, 40323);

                ParameterBindingException
                newBindingException =
                f_1305_40134_40322(f_1305_40186_40205(pbex), pbex, resourceString, oldMsg, defaultParamsGetBound)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 40339, 40365);

                throw newBindingException;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1305, 39021, 40376);

                System.Management.Automation.PSArgumentNullException
                f_1305_39180_39226(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 39180, 39226);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1305_39277_39293(System.Management.Automation.ParameterBindingException
                this_param)
                {
                    var return_v = this_param.ErrorRecord;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 39277, 39293);
                    return return_v;
                }


                int
                f_1305_39258_39367(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 39258, 39367);
                    return 0;
                }


                string
                f_1305_39439_39451(System.Management.Automation.ParameterBindingException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 39439, 39451);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1305_39556_39575()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 39556, 39575);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1305_39619_39641()
                {
                    var return_v = BoundDefaultParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 39619, 39641);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1305_39710_39738()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 39710, 39738);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1305_39675_39759(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 39675, 39759);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1305_39619_39641_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 39619, 39641);
                    return return_v;
                }


                string
                f_1305_39815_39874()
                {
                    var return_v = ParameterBinderStrings.DefaultBindingErrorElaborationSingle;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 39815, 39874);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1305_39893_39915()
                {
                    var return_v = BoundDefaultParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 39893, 39915);
                    return return_v;
                }


                int
                f_1305_39893_39921(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 39893, 39921);
                    return return_v;
                }


                string
                f_1305_39976_40037()
                {
                    var return_v = ParameterBinderStrings.DefaultBindingErrorElaborationMultiple;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 39976, 40037);
                    return return_v;
                }


                System.Exception
                f_1305_40186_40205(System.Management.Automation.ParameterBindingException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 40186, 40205);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1305_40134_40322(System.Exception
                innerException, System.Management.Automation.ParameterBindingException
                pbex, string
                resourceString, params object[]
                args)
                {
                    var return_v = new System.Management.Automation.ParameterBindingException(innerException, pbex, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 40134, 40322);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 39021, 40376);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 39021, 40376);
            }
        }

        private static CommandParameterInternal GetNextPositionalArgument(
                    List<CommandParameterInternal> unboundArgumentsCollection,
                    Collection<CommandParameterInternal> nonPositionalArguments,
                    ref int unboundArgumentsIndex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1305, 40388, 42125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 40954, 40993);

                CommandParameterInternal
                result = null
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 41007, 42084) || true) && (unboundArgumentsIndex < f_1305_41038_41070(unboundArgumentsCollection))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 41007, 42084);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 41104, 41192);

                        CommandParameterInternal
                        argument = f_1305_41140_41191(unboundArgumentsCollection, unboundArgumentsIndex++)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 41212, 41355) || true) && (f_1305_41216_41248_M(!argument.ParameterNameSpecified))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 41212, 41355);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 41290, 41308);

                            result = argument;
                            DynAbs.Tracing.TraceSender.TraceBreak(1305, 41330, 41336);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 41212, 41355);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 41375, 41412);

                        f_1305_41375_41411(
                                        nonPositionalArguments, argument);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 41522, 42069) || true) && (f_1305_41526_41558(unboundArgumentsCollection) - 1 >= unboundArgumentsIndex)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 41522, 42069);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 41629, 41690);

                            argument = f_1305_41640_41689(unboundArgumentsCollection, unboundArgumentsIndex);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 41714, 42050) || true) && (f_1305_41718_41750_M(!argument.ParameterNameSpecified))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 41714, 42050);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 41940, 41977);

                                f_1305_41940_41976(                        // Since the next argument doesn't appear to be a parameter name
                                                                           // consume it as well.

                                                        nonPositionalArguments, argument);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 42003, 42027);

                                unboundArgumentsIndex++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 41714, 42050);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 41522, 42069);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 41007, 42084);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 41007, 42084);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 41007, 42084);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 42100, 42114);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1305, 40388, 42125);

                int
                f_1305_41038_41070(System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 41038, 41070);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1305_41140_41191(System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 41140, 41191);
                    return return_v;
                }


                bool
                f_1305_41216_41248_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 41216, 41248);
                    return return_v;
                }


                int
                f_1305_41375_41411(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 41375, 41411);
                    return 0;
                }


                int
                f_1305_41526_41558(System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 41526, 41558);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1305_41640_41689(System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 41640, 41689);
                    return return_v;
                }


                bool
                f_1305_41718_41750_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 41718, 41750);
                    return return_v;
                }


                int
                f_1305_41940_41976(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 41940, 41976);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 40388, 42125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 40388, 42125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static SortedDictionary<int, Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter>> EvaluateUnboundPositionalParameters(
                    ICollection<MergedCompiledCommandParameter> unboundParameters, uint validParameterSetFlag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1305, 42473, 44753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 42748, 42968);

                SortedDictionary<int, Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter>>
                result =
                f_1305_42868_42967()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 42984, 44712) || true) && (f_1305_42988_43011(unboundParameters) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 42984, 44712);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 43253, 44697);
                        foreach (MergedCompiledCommandParameter parameter in f_1305_43306_43323_I(unboundParameters))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 43253, 44697);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 43365, 43493);

                            bool
                            isInParameterSet = (f_1305_43390_43427(f_1305_43390_43409(parameter)) & validParameterSetFlag) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(1305, 43389, 43492) || f_1305_43461_43492(f_1305_43461_43480(parameter)))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 43517, 44678) || true) && (isInParameterSet)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 43517, 44678);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 43587, 43691);

                                var
                                parameterSetDataCollection = f_1305_43620_43690(f_1305_43620_43639(parameter), validParameterSetFlag)
                                ;
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 43717, 44655);
                                    foreach (ParameterSetSpecificMetadata parameterSetData in f_1305_43775_43801_I(parameterSetDataCollection))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 43717, 44655);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 43935, 44089) || true) && (f_1305_43939_43983(parameterSetData))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 43935, 44089);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 44049, 44058);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 43935, 44089);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 44195, 44250);

                                        int
                                        positionInParameterSet = f_1305_44224_44249(parameterSetData)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 44282, 44520) || true) && (positionInParameterSet == int.MinValue)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 44282, 44520);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 44480, 44489);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 44282, 44520);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 44552, 44628);

                                        f_1305_44552_44627(result, positionInParameterSet, parameter, parameterSetData);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 43717, 44655);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 939);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 939);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 43517, 44678);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 43253, 44697);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 1445);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 1445);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 42984, 44712);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 44728, 44742);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1305, 42473, 44753);

                System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>
                f_1305_42868_42967()
                {
                    var return_v = new System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 42868, 42967);
                    return return_v;
                }


                int
                f_1305_42988_43011(System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 42988, 43011);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_43390_43409(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 43390, 43409);
                    return return_v;
                }


                uint
                f_1305_43390_43427(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 43390, 43427);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_43461_43480(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 43461, 43480);
                    return return_v;
                }


                bool
                f_1305_43461_43492(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.IsInAllSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 43461, 43492);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_43620_43639(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 43620, 43639);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1305_43620_43690(System.Management.Automation.CompiledCommandParameter
                this_param, uint
                parameterSetFlags)
                {
                    var return_v = this_param.GetMatchingParameterSetData(parameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 43620, 43690);
                    return return_v;
                }


                bool
                f_1305_43939_43983(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromRemainingArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 43939, 43983);
                    return return_v;
                }


                int
                f_1305_44224_44249(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.Position;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 44224, 44249);
                    return return_v;
                }


                int
                f_1305_44552_44627(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>
                result, int
                positionInParameterSet, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterSetSpecificMetadata
                parameterSetData)
                {
                    AddNewPosition(result, positionInParameterSet, parameter, parameterSetData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 44552, 44627);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1305_43775_43801_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 43775, 43801);
                    return return_v;
                }


                System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1305_43306_43323_I(System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 43306, 43323);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 42473, 44753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 42473, 44753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddNewPosition(
                    SortedDictionary<int, Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter>> result,
                    int positionInParameterSet,
                    MergedCompiledCommandParameter parameter,
                    ParameterSetSpecificMetadata parameterSetData)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1305, 44765, 47176);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 45096, 45195);

                Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter>
                positionalCommandParameters
                = default(Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter>);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 45209, 47165) || true) && (f_1305_45213_45288(result, positionInParameterSet, out positionalCommandParameters))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 45209, 47165);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 45434, 46050) || true) && (f_1305_45438_45545(positionalCommandParameters, parameter, f_1305_45511_45544(parameterSetData)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 45434, 46050);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 45980, 46031);

                        throw f_1305_45986_46030();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 45434, 46050);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 46070, 46124);

                    PositionalCommandParameter
                    positionalCommandParameter
                    = default(PositionalCommandParameter);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 46142, 46454) || true) && (!f_1305_46147_46229(positionalCommandParameters, parameter, out positionalCommandParameter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 46142, 46454);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 46271, 46342);

                        positionalCommandParameter = f_1305_46300_46341(parameter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 46364, 46435);

                        f_1305_46364_46434(positionalCommandParameters, parameter, positionalCommandParameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 46142, 46454);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 46474, 46540);

                    f_1305_46474_46539(f_1305_46474_46517(positionalCommandParameter), parameterSetData);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 45209, 47165);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 45209, 47165);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 46606, 46799);

                    Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter>
                    newPositionDictionary =
                    f_1305_46722_46798()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 46819, 46913);

                    PositionalCommandParameter
                    newPositionalParameter = f_1305_46871_46912(parameter)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 46931, 46993);

                    f_1305_46931_46992(f_1305_46931_46970(newPositionalParameter), parameterSetData);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 47011, 47072);

                    f_1305_47011_47071(newPositionDictionary, parameter, newPositionalParameter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 47092, 47150);

                    f_1305_47092_47149(
                                    result, positionInParameterSet, newPositionDictionary);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 45209, 47165);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1305, 44765, 47176);

                bool
                f_1305_45213_45288(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>
                this_param, int
                key, out System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 45213, 45288);
                    return return_v;
                }


                uint
                f_1305_45511_45544(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 45511, 45544);
                    return return_v;
                }


                bool
                f_1305_45438_45545(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                positionalCommandParameters, System.Management.Automation.MergedCompiledCommandParameter
                parameter, uint
                parameterSet)
                {
                    var return_v = ContainsPositionalParameterInSet(positionalCommandParameters, parameter, parameterSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 45438, 45545);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1305_45986_46030()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 45986, 46030);
                    return return_v;
                }


                bool
                f_1305_46147_46229(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                key, out System.Management.Automation.PositionalCommandParameter
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 46147, 46229);
                    return return_v;
                }


                System.Management.Automation.PositionalCommandParameter
                f_1305_46300_46341(System.Management.Automation.MergedCompiledCommandParameter
                parameter)
                {
                    var return_v = new System.Management.Automation.PositionalCommandParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 46300, 46341);
                    return return_v;
                }


                int
                f_1305_46364_46434(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                key, System.Management.Automation.PositionalCommandParameter
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 46364, 46434);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1305_46474_46517(System.Management.Automation.PositionalCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 46474, 46517);
                    return return_v;
                }


                int
                f_1305_46474_46539(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                this_param, System.Management.Automation.ParameterSetSpecificMetadata
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 46474, 46539);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                f_1305_46722_46798()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 46722, 46798);
                    return return_v;
                }


                System.Management.Automation.PositionalCommandParameter
                f_1305_46871_46912(System.Management.Automation.MergedCompiledCommandParameter
                parameter)
                {
                    var return_v = new System.Management.Automation.PositionalCommandParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 46871, 46912);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1305_46931_46970(System.Management.Automation.PositionalCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 46931, 46970);
                    return return_v;
                }


                int
                f_1305_46931_46992(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                this_param, System.Management.Automation.ParameterSetSpecificMetadata
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 46931, 46992);
                    return 0;
                }


                int
                f_1305_47011_47071(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                key, System.Management.Automation.PositionalCommandParameter
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 47011, 47071);
                    return 0;
                }


                int
                f_1305_47092_47149(System.Collections.Generic.SortedDictionary<int, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>>
                this_param, int
                key, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 47092, 47149);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 44765, 47176);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 44765, 47176);
            }
        }

        private static bool ContainsPositionalParameterInSet(
                    Dictionary<MergedCompiledCommandParameter, PositionalCommandParameter> positionalCommandParameters,
                    MergedCompiledCommandParameter parameter,
                    uint parameterSet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1305, 47188, 48378);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 47466, 47486);

                bool
                result = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 47502, 48337);
                    foreach (KeyValuePair<MergedCompiledCommandParameter, PositionalCommandParameter> pair in f_1305_47592_47619_I(positionalCommandParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 47502, 48337);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 47708, 47803) || true) && (pair.Key == parameter)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 47708, 47803);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 47775, 47784);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 47708, 47803);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 47823, 48225);
                            foreach (ParameterSetSpecificMetadata parameterSetData in f_1305_47881_47908_I(f_1305_47881_47908(pair.Value)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 47823, 48225);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 47950, 48206) || true) && ((f_1305_47955_47988(parameterSetData) & parameterSet) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(1305, 47954, 48087) || f_1305_48038_48071(parameterSetData) == parameterSet))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 47950, 48206);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 48137, 48151);

                                    result = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1305, 48177, 48183);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 47950, 48206);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 47823, 48225);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 403);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 403);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 48245, 48322) || true) && (result)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 48245, 48322);
                            DynAbs.Tracing.TraceSender.TraceBreak(1305, 48297, 48303);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 48245, 48322);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 47502, 48337);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 836);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 48353, 48367);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1305, 47188, 48378);

                System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1305_47881_47908(System.Management.Automation.PositionalCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 47881, 47908);
                    return return_v;
                }


                uint
                f_1305_47955_47988(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 47955, 47988);
                    return return_v;
                }


                uint
                f_1305_48038_48071(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 48038, 48071);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1305_47881_47908_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ParameterSetSpecificMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 47881, 47908);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                f_1305_47592_47619_I(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.PositionalCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 47592, 47619);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 47188, 48378);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 47188, 48378);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Collection<MergedCompiledCommandParameter> ParametersBoundThroughPipelineInput { get; }

        internal void BindUnboundScriptParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1305, 49157, 49409);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 49225, 49398);
                    foreach (MergedCompiledCommandParameter parameter in f_1305_49278_49295_I(f_1305_49278_49295()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 49225, 49398);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 49329, 49383);

                        f_1305_49329_49382(this, parameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 49225, 49398);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1305, 1, 174);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1305, 1, 174);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1305, 49157, 49409);

                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1305_49278_49295()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 49278, 49295);
                    return return_v;
                }


                int
                f_1305_49329_49382(System.Management.Automation.ParameterBinderController
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                parameter)
                {
                    this_param.BindUnboundScriptParameterWithDefaultValue(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 49329, 49382);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1305_49278_49295_I(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 49278, 49295);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 49157, 49409);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 49157, 49409);
            }
        }

        protected virtual void SaveDefaultScriptParameterValue(string name, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1305, 49629, 49861);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1305, 49629, 49861);
                // By default, parameter binders don't need to remember the value, the exception being the cmdlet parameter binder.
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 49629, 49861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 49629, 49861);
            }
        }

        internal void BindUnboundScriptParameterWithDefaultValue(MergedCompiledCommandParameter parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1305, 50060, 52401);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 50183, 50262);

                ScriptParameterBinder
                spb = (ScriptParameterBinder)f_1305_50234_50261(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 50276, 50308);

                ScriptBlock
                script = f_1305_50297_50307(spb)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 50322, 50370);

                RuntimeDefinedParameter
                runtimeDefinedParameter
                = default(RuntimeDefinedParameter);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 50384, 52390) || true) && (f_1305_50388_50486(f_1305_50388_50419(script), f_1305_50432_50456(f_1305_50432_50451(parameter)), out runtimeDefinedParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 50384, 52390);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 50520, 50573);

                    bool
                    oldRecordParameters = spb.RecordBoundParameters
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 50635, 50669);

                        spb.RecordBoundParameters = false;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 50936, 50998);

                        System.Collections.IDictionary
                        implicitUsingParameters = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 51020, 51249) || true) && (f_1305_51024_51068(f_1305_51024_51046()) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 51020, 51249);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 51126, 51226);

                            implicitUsingParameters = f_1305_51152_51225(f_1305_51152_51196(f_1305_51152_51174()));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 51020, 51249);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 51273, 51374);

                        object
                        result = f_1305_51289_51373(spb, runtimeDefinedParameter, implicitUsingParameters)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 51396, 51462);

                        f_1305_51396_51461(this, f_1305_51428_51452(f_1305_51428_51447(parameter)), result);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 51484, 51771);

                        CommandParameterInternal
                        argument = f_1305_51520_51770(null, f_1305_51621_51645(f_1305_51621_51640(parameter)), "-" + f_1305_51653_51677(f_1305_51653_51672(parameter)) + ":", null, result, false)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 51793, 51860);

                        ParameterBindingFlags
                        flags = ParameterBindingFlags.IsDefaultValue
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 51988, 52142) || true) && (f_1305_51992_52021(runtimeDefinedParameter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 51988, 52142);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 52071, 52119);

                            flags |= ParameterBindingFlags.ShouldCoerceType;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 51988, 52142);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 52166, 52223);

                        f_1305_52166_52222(this, uint.MaxValue, argument, parameter, flags);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1305, 52260, 52375);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 52308, 52356);

                        spb.RecordBoundParameters = oldRecordParameters;
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1305, 52260, 52375);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 50384, 52390);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1305, 50060, 52401);

                System.Management.Automation.ParameterBinderBase
                f_1305_50234_50261(System.Management.Automation.ParameterBinderController
                this_param)
                {
                    var return_v = this_param.DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 50234, 50261);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1305_50297_50307(System.Management.Automation.ScriptParameterBinder
                this_param)
                {
                    var return_v = this_param.Script;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 50297, 50307);
                    return return_v;
                }


                System.Management.Automation.RuntimeDefinedParameterDictionary
                f_1305_50388_50419(System.Management.Automation.ScriptBlock
                this_param)
                {
                    var return_v = this_param.RuntimeDefinedParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 50388, 50419);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_50432_50451(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 50432, 50451);
                    return return_v;
                }


                string
                f_1305_50432_50456(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 50432, 50456);
                    return return_v;
                }


                bool
                f_1305_50388_50486(System.Management.Automation.RuntimeDefinedParameterDictionary
                this_param, string
                key, out System.Management.Automation.RuntimeDefinedParameter
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 50388, 50486);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderBase
                f_1305_51024_51046()
                {
                    var return_v = DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 51024, 51046);
                    return return_v;
                }


                System.Management.Automation.CommandLineParameters
                f_1305_51024_51068(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.CommandLineParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 51024, 51068);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderBase
                f_1305_51152_51174()
                {
                    var return_v = DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 51152, 51174);
                    return return_v;
                }


                System.Management.Automation.CommandLineParameters
                f_1305_51152_51196(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.CommandLineParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 51152, 51196);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1305_51152_51225(System.Management.Automation.CommandLineParameters
                this_param)
                {
                    var return_v = this_param.GetImplicitUsingParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 51152, 51225);
                    return return_v;
                }


                object
                f_1305_51289_51373(System.Management.Automation.ScriptParameterBinder
                this_param, System.Management.Automation.RuntimeDefinedParameter
                parameter, System.Collections.IDictionary
                implicitUsingParameters)
                {
                    var return_v = this_param.GetDefaultScriptParameterValue(parameter, implicitUsingParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 51289, 51373);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_51428_51447(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 51428, 51447);
                    return return_v;
                }


                string
                f_1305_51428_51452(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 51428, 51452);
                    return return_v;
                }


                int
                f_1305_51396_51461(System.Management.Automation.ParameterBinderController
                this_param, string
                name, object
                value)
                {
                    this_param.SaveDefaultScriptParameterValue(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 51396, 51461);
                    return 0;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_51621_51640(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 51621, 51640);
                    return return_v;
                }


                string
                f_1305_51621_51645(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 51621, 51645);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1305_51653_51672(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 51653, 51672);
                    return return_v;
                }


                string
                f_1305_51653_51677(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 51653, 51677);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1305_51520_51770(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, object
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 51520, 51770);
                    return return_v;
                }


                bool
                f_1305_51992_52021(System.Management.Automation.RuntimeDefinedParameter
                this_param)
                {
                    var return_v = this_param.IsSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 51992, 52021);
                    return return_v;
                }


                bool
                f_1305_52166_52222(System.Management.Automation.ParameterBinderController
                this_param, uint
                parameterSets, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(parameterSets, argument, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 52166, 52222);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 50060, 52401);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 50060, 52401);
            }
        }

        internal uint _currentParameterSetFlag;

        internal uint _prePipelineProcessingParameterSetFlags;

        protected IScriptExtent GetErrorExtent(CommandParameterInternal cpi)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1305, 52560, 53064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 52653, 52682);

                var
                result = f_1305_52666_52681(cpi)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 52696, 52797) || true) && (result == f_1305_52710_52739())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 52696, 52797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 52758, 52797);

                    result = f_1305_52767_52796(f_1305_52767_52781());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 52696, 52797);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 53039, 53053);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1305, 52560, 53064);

                System.Management.Automation.Language.IScriptExtent
                f_1305_52666_52681(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ErrorExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 52666, 52681);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1305_52710_52739()
                {
                    var return_v = PositionUtilities.EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 52710, 52739);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1305_52767_52781()
                {
                    var return_v = InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 52767, 52781);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1305_52767_52796(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.ScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 52767, 52796);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 52560, 53064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 52560, 53064);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected IScriptExtent GetParameterErrorExtent(CommandParameterInternal cpi)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1305, 53076, 53593);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 53178, 53211);

                var
                result = f_1305_53191_53210(cpi)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 53225, 53326) || true) && (result == f_1305_53239_53268())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1305, 53225, 53326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 53287, 53326);

                    result = f_1305_53296_53325(f_1305_53296_53310());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1305, 53225, 53326);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1305, 53568, 53582);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1305, 53076, 53593);

                System.Management.Automation.Language.IScriptExtent
                f_1305_53191_53210(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 53191, 53210);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1305_53239_53268()
                {
                    var return_v = PositionUtilities.EmptyExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 53239, 53268);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1305_53296_53310()
                {
                    var return_v = InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 53296, 53310);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1305_53296_53325(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.ScriptPosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 53296, 53325);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1305, 53076, 53593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 53076, 53593);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ParameterBinderController()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1305, 634, 53639);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1305, 634, 53639);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1305, 634, 53639);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1305, 634, 53639);

        int
        f_1305_1503_1593(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 1503, 1593);
            return 0;
        }


        int
        f_1305_1608_1700(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 1608, 1700);
            return 0;
        }


        int
        f_1305_1715_1789(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 1715, 1789);
            return 0;
        }


        System.Management.Automation.MergedCommandParameterMetadata
        f_1305_2905_2941()
        {
            var return_v = new System.Management.Automation.MergedCommandParameterMetadata();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 2905, 2941);
            return return_v;
        }


        System.StringComparer
        f_1305_3486_3518()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 3486, 3518);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
        f_1305_3431_3519(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 3431, 3519);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<string>
        f_1305_4120_4144()
        {
            var return_v = new System.Collections.ObjectModel.Collection<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 4120, 4144);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
        f_1305_4423_4465()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 4423, 4465);
            return return_v;
        }


        System.StringComparer
        f_1305_4830_4862()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1305, 4830, 4862);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
        f_1305_4781_4863(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 4781, 4863);
            return return_v;
        }


        System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
        f_1305_48715_48763()
        {
            var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1305, 48715, 48763);
            return return_v;
        }

    }
}

