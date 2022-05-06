// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.
#pragma warning disable 1634, 1691

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Internal.Host;
using System.Management.Automation.Remoting;
using System.Management.Automation.Runspaces;
using System.Threading;

using Dbg = System.Management.Automation.Diagnostics;

namespace System.Management.Automation
{
    internal class MshCommandRuntime : ICommandRuntime2
    {
        internal ExecutionContext Context { get; set; }

        private SessionState _state;

        internal InternalHost CBhost;

        public PSHost Host { get; }

        private Pipe _inputPipe;

        private Pipe _outputPipe;

        private Pipe _errorOutputPipe;

        internal bool IsClosed { get; set; }

        internal bool IsPipelineInputExpected
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 2172, 2508);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 2331, 2461) || true) && (f_1291_2335_2343() && (DynAbs.Tracing.TraceSender.Expression_True(1291, 2335, 2387) && (_inputPipe == null || (DynAbs.Tracing.TraceSender.Expression_False(1291, 2348, 2386) || f_1291_2370_2386(_inputPipe)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 2331, 2461);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 2429, 2442);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 2331, 2461);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 2481, 2493);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 2172, 2508);

                    bool
                    f_1291_2335_2343()
                    {
                        var return_v = IsClosed;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 2335, 2343);
                        return return_v;
                    }


                    bool
                    f_1291_2370_2386(System.Management.Automation.Internal.Pipe
                    this_param)
                    {
                        var return_v = this_param.Empty;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 2370, 2386);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 2110, 2519);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 2110, 2519);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal string OutVariable { get; set; }

        internal IList OutVarList
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 3203, 3230);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 3209, 3228);

                    return _outVarList;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 3203, 3230);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 3175, 3261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 3175, 3261);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 3231, 3259);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 3237, 3257);

                    _outVarList = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 3231, 3259);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 3175, 3261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 3175, 3261);
                }
            }
        }

        private IList _outVarList;

        internal PipelineProcessor PipelineProcessor { get; set; }

        private CommandInfo _commandInfo;

        private InternalCommand _thisCommand;

        internal MshCommandRuntime(ExecutionContext context, CommandInfo commandInfo, InternalCommand thisCommand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1291, 3518, 3961);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 1273, 1320);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 1353, 1366);
                this._state = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 1399, 1405);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 1511, 1538);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 1589, 1599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 1623, 1634);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 1658, 1674);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 1943, 1979);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 3122, 3163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 3287, 3305);
                this._outVarList = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 3318, 3376);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 3408, 3420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 3455, 3467);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 4343, 4356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 12463, 12472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 38535, 38593);
                this.LogPipelineExecutionDetail = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 40044, 40090);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 40119, 40147);
                this._pipelineVarReference = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 96812, 96863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 98062, 98133);
                this.MergeUnclaimedPreviousErrorResults = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 99540, 99585);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 99695, 99740);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 99848, 99891);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 100007, 100056);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 106554, 106567);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 106896, 106939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 109434, 109449);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 109782, 109827);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 110435, 110454);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 110799, 110848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 113456, 113484);
                this.UseSecurityContextRun = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 128252, 128286);
                this._isConfirmPreferenceCached = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 128319, 128384);
                this._confirmPreference = InitialSessionState.DefaultConfirmPreference;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129857, 129886);
                this._isDebugPreferenceSet = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129922, 129983);
                this._debugPreference = InitialSessionState.DefaultDebugPreference;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 130007, 130039);
                this._isDebugPreferenceCached = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 131946, 131980);
                this._isVerbosePreferenceCached = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 132016, 132081);
                this._verbosePreference = InitialSessionState.DefaultVerbosePreference;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 133713, 133776);
                this.IsWarningActionSet = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 133801, 133835);
                this._isWarningPreferenceCached = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 133871, 133936);
                this._warningPreference = InitialSessionState.DefaultWarningPreference;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 135665, 135685);
                this._verboseFlag = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 136178, 136239);
                this.IsVerboseFlagSet = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 136264, 136284);
                this._confirmFlag = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 136832, 136893);
                this.IsConfirmFlagSet = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 136918, 136945);
                this._useTransactionFlag = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 137526, 137592);
                this.UseTransactionFlagSet = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 137846, 137864);
                this._debugFlag = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 138462, 138521);
                this.IsDebugFlagSet = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 138546, 138603);
                this._whatIfFlag = InitialSessionState.DefaultWhatIfPreference;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 138627, 138652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 139597, 139648);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 139685, 139748);
                this._errorAction = InitialSessionState.DefaultErrorActionPreference;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 139772, 139810);
                this._isErrorActionPreferenceCached = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 141255, 141316);
                this.IsErrorActionSet = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 142508, 142575);
                this._progressPreference = InitialSessionState.DefaultProgressPreference;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 142599, 142631);
                this._isProgressPreferenceSet = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 142655, 142690);
                this._isProgressPreferenceCached = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 143912, 143985);
                this._informationPreference = InitialSessionState.DefaultInformationPreference;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 143998, 144065);
                this.IsInformationActionSet = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 144090, 144128);
                this._isInformationPreferenceCached = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 144141, 144197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 144651, 144703);
                this.lastShouldProcessContinueStatus = ContinueStatus.Yes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 144738, 144782);
                this.lastErrorContinueStatus = ContinueStatus.Yes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 144817, 144861);
                this.lastDebugContinueStatus = ContinueStatus.Yes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 144896, 144942);
                this.lastVerboseContinueStatus = ContinueStatus.Yes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 144977, 145023);
                this.lastWarningContinueStatus = ContinueStatus.Yes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 145058, 145105);
                this.lastProgressContinueStatus = ContinueStatus.Yes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 145140, 145190);
                this.lastInformationContinueStatus = ContinueStatus.Yes;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 3649, 3667);

                Context = context;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 3681, 3716);

                Host = f_1291_3688_3715(context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 3730, 3786);

                this.CBhost = (InternalHost)f_1291_3758_3785(context);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 3800, 3827);

                _commandInfo = commandInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 3841, 3868);

                _thisCommand = thisCommand;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 3882, 3950);

                LogPipelineExecutionDetail = f_1291_3911_3949(this);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1291, 3518, 3961);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 3518, 3961);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 3518, 3961);
            }
        }

        public override string ToString()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 4091, 4308);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 4149, 4223) || true) && (_commandInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 4149, 4223);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 4192, 4223);

                    return f_1291_4199_4222(_commandInfo);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 4149, 4223);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 4237, 4264);

                return "<NullCommandInfo>";
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 4091, 4308);

                string
                f_1291_4199_4222(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 4199, 4222);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 4091, 4308);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 4091, 4308);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private InvocationInfo _myInvocation;

        internal InvocationInfo MyInvocation
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 4608, 4684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 4614, 4682);

                    return _myInvocation ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.InvocationInfo>(1291, 4621, 4681) ?? (_myInvocation = f_1291_4655_4680(_thisCommand)));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 4608, 4684);

                    System.Management.Automation.InvocationInfo
                    f_1291_4655_4680(System.Management.Automation.Internal.InternalCommand
                    this_param)
                    {
                        var return_v = this_param.MyInvocation;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 4655, 4680);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 4547, 4695);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 4547, 4695);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsStopping
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 4892, 4975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 4898, 4973);

                    return (f_1291_4906_4928(this) != null && (DynAbs.Tracing.TraceSender.Expression_True(1291, 4906, 4971) && f_1291_4940_4971(f_1291_4940_4962(this))));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 4892, 4975);

                    System.Management.Automation.Internal.PipelineProcessor
                    f_1291_4906_4928(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.PipelineProcessor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 4906, 4928);
                        return return_v;
                    }


                    System.Management.Automation.Internal.PipelineProcessor
                    f_1291_4940_4962(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.PipelineProcessor;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 4940, 4962);
                        return return_v;
                    }


                    bool
                    f_1291_4940_4971(System.Management.Automation.Internal.PipelineProcessor
                    this_param)
                    {
                        var return_v = this_param.Stopping;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 4940, 4971);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 4843, 4986);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 4843, 4986);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void WriteObject(object sendToPipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 6314, 7451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 6628, 6646);

                f_1291_6628_6645(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 6735, 6765);

                f_1291_6735_6764(this, sendToPipeline);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 6314, 7451);

                int
                f_1291_6628_6645(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 6628, 6645);
                    return 0;
                }


                int
                f_1291_6735_6764(System.Management.Automation.MshCommandRuntime
                this_param, object
                sendToPipeline)
                {
                    this_param.DoWriteObject(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 6735, 6764);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 6314, 7451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 6314, 7451);
            }
        }

        private void DoWriteObject(object sendToPipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 7991, 8164);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 8065, 8096);

                f_1291_8065_8095(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 8110, 8153);

                f_1291_8110_8152(this, sendToPipeline);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 7991, 8164);

                int
                f_1291_8065_8095(System.Management.Automation.MshCommandRuntime
                this_param, bool
                needsToWriteToPipeline)
                {
                    this_param.ThrowIfWriteNotPermitted(needsToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 8065, 8095);
                    return 0;
                }


                int
                f_1291_8110_8152(System.Management.Automation.MshCommandRuntime
                this_param, object
                sendToPipeline)
                {
                    this_param._WriteObjectSkipAllowCheck(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 8110, 8152);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 7991, 8164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 7991, 8164);
            }
        }

        public void WriteObject(object sendToPipeline, bool enumerateCollection)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 9632, 10948);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 9729, 9855) || true) && (!enumerateCollection)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 9729, 9855);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 9787, 9815);

                    f_1291_9787_9814(this, sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 9833, 9840);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 9729, 9855);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 10115, 10133);

                f_1291_10115_10132(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 10222, 10262);

                f_1291_10222_10261(this, sendToPipeline);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 9632, 10948);

                int
                f_1291_9787_9814(System.Management.Automation.MshCommandRuntime
                this_param, object
                sendToPipeline)
                {
                    this_param.WriteObject(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 9787, 9814);
                    return 0;
                }


                int
                f_1291_10115_10132(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 10115, 10132);
                    return 0;
                }


                int
                f_1291_10222_10261(System.Management.Automation.MshCommandRuntime
                this_param, object
                sendToPipeline)
                {
                    this_param.DoWriteEnumeratedObject(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 10222, 10261);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 9632, 10948);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 9632, 10948);
            }
        }

        private void DoWriteEnumeratedObject(object sendToPipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 11757, 11998);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 11887, 11918);

                f_1291_11887_11917(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 11932, 11987);

                f_1291_11932_11986(this, sendToPipeline);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 11757, 11998);

                int
                f_1291_11887_11917(System.Management.Automation.MshCommandRuntime
                this_param, bool
                needsToWriteToPipeline)
                {
                    this_param.ThrowIfWriteNotPermitted(needsToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 11887, 11917);
                    return 0;
                }


                int
                f_1291_11932_11986(System.Management.Automation.MshCommandRuntime
                this_param, object
                sendToPipeline)
                {
                    this_param._EnumerateAndWriteObjectSkipAllowCheck(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 11932, 11986);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 11757, 11998);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 11757, 11998);
            }
        }

        private static Int64 s_lastUsedSourceId /* = 0 */;

        private Int64 _sourceId /* = 0 */;

        public void WriteProgress(ProgressRecord progressRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 14061, 14195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 14142, 14184);

                f_1291_14142_14183(this, progressRecord, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 14061, 14195);

                int
                f_1291_14142_14183(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ProgressRecord
                progressRecord, bool
                overrideInquire)
                {
                    this_param.WriteProgress(progressRecord, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 14142, 14183);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 14061, 14195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 14061, 14195);
            }
        }

        internal void WriteProgress(ProgressRecord progressRecord, bool overrideInquire)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 14207, 15492);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 14387, 14405);

                f_1291_14387_14404(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 15036, 15068);

                f_1291_15036_15067(this, false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 15277, 15402) || true) && (0 == _sourceId)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 15277, 15402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 15329, 15387);

                    _sourceId = f_1291_15341_15386(ref s_lastUsedSourceId);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 15277, 15402);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 15418, 15481);

                f_1291_15418_15480(
                            this, _sourceId, progressRecord, overrideInquire);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 14207, 15492);

                int
                f_1291_14387_14404(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 14387, 14404);
                    return 0;
                }


                int
                f_1291_15036_15067(System.Management.Automation.MshCommandRuntime
                this_param, bool
                needsToWriteToPipeline)
                {
                    this_param.ThrowIfWriteNotPermitted(needsToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 15036, 15067);
                    return 0;
                }


                long
                f_1291_15341_15386(ref long
                location)
                {
                    var return_v = Interlocked.Increment(ref location);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 15341, 15386);
                    return return_v;
                }


                int
                f_1291_15418_15480(System.Management.Automation.MshCommandRuntime
                this_param, long
                sourceId, System.Management.Automation.ProgressRecord
                progressRecord, bool
                overrideInquire)
                {
                    this_param.WriteProgress(sourceId, progressRecord, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 15418, 15480);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 14207, 15492);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 14207, 15492);
            }
        }

        public void WriteProgress(
                    Int64 sourceId,
                    ProgressRecord progressRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 16616, 16798);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 16740, 16787);

                f_1291_16740_16786(this, sourceId, progressRecord, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 16616, 16798);

                int
                f_1291_16740_16786(System.Management.Automation.MshCommandRuntime
                this_param, long
                sourceId, System.Management.Automation.ProgressRecord
                progressRecord, bool
                overrideInquire)
                {
                    this_param.WriteProgress(sourceId, progressRecord, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 16740, 16786);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 16616, 16798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 16616, 16798);
            }
        }

        internal void WriteProgress(
                        Int64 sourceId,
                        ProgressRecord progressRecord,
                        bool overrideInquire)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 16810, 18361);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 16983, 17121) || true) && (progressRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 16983, 17121);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 17043, 17106);

                    throw f_1291_17049_17105("progressRecord");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 16983, 17121);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 17137, 17358) || true) && (f_1291_17141_17145() == null || (DynAbs.Tracing.TraceSender.Expression_False(1291, 17141, 17172) || f_1291_17157_17164(f_1291_17157_17161()) == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 17137, 17358);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 17206, 17274);

                    f_1291_17206_17273(false, "No host in CommandBase.WriteProgress()");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 17292, 17343);

                    throw f_1291_17298_17342();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 17137, 17358);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 17374, 17442);

                InternalHostUserInterface
                ui = f_1291_17405_17412(f_1291_17405_17409()) as InternalHostUserInterface
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 17458, 17507);

                ActionPreference
                preference = f_1291_17488_17506()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 17521, 17670) || true) && (overrideInquire && (DynAbs.Tracing.TraceSender.Expression_True(1291, 17525, 17582) && preference == ActionPreference.Inquire))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 17521, 17670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 17616, 17655);

                    preference = ActionPreference.Continue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 17521, 17670);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 17686, 18091) || true) && (f_1291_17690_17771(this, preference, lastProgressContinueStatus))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 17686, 18091);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 17862, 18013) || true) && (preference == ActionPreference.Break)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 17862, 18013);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 17944, 17994);

                        //f_1291_17944_17993_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(CBhost, 1291, 17944, 17993) ? f_1291_17951_17993_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(.Runspace, 1291, 17951, 17993) ? DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(.Debugger, 1291, 17961, 17993)?.Break(progressRecord), 1291, 17971, 17993)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 17862, 18013);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 18033, 18076);

                    f_1291_18033_18075(
                                    ui, sourceId, progressRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 17686, 18091);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 18107, 18350);

                lastProgressContinueStatus = f_1291_18136_18349(this, null, null, preference, lastProgressContinueStatus, "ProgressPreference", f_1291_18325_18348(progressRecord));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 16810, 18361);

                System.Management.Automation.PSArgumentNullException
                f_1291_17049_17105(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 17049, 17105);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1291_17141_17145()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 17141, 17145);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1291_17157_17161()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 17157, 17161);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1291_17157_17164(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 17157, 17164);
                    return return_v;
                }


                int
                f_1291_17206_17273(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 17206, 17273);
                    return 0;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1291_17298_17342()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 17298, 17342);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1291_17405_17409()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 17405, 17409);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1291_17405_17412(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 17405, 17412);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1291_17488_17506()
                {
                    var return_v = ProgressPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 17488, 17506);
                    return return_v;
                }


                bool
                f_1291_17690_17771(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ActionPreference
                preference, System.Management.Automation.MshCommandRuntime.ContinueStatus
                lastContinueStatus)
                {
                    var return_v = this_param.WriteHelper_ShouldWrite(preference, lastContinueStatus);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 17690, 17771);
                    return return_v;
                }

                int
                f_1291_18033_18075(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, long
                sourceId, System.Management.Automation.ProgressRecord
                record)
                {
                    this_param.WriteProgress(sourceId, record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 18033, 18075);
                    return 0;
                }


                string
                f_1291_18325_18348(System.Management.Automation.ProgressRecord
                this_param)
                {
                    var return_v = this_param.Activity;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 18325, 18348);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime.ContinueStatus
                f_1291_18136_18349(System.Management.Automation.MshCommandRuntime
                this_param, string
                inquireCaption, string
                inquireMessage, System.Management.Automation.ActionPreference
                preference, System.Management.Automation.MshCommandRuntime.ContinueStatus
                lastContinueStatus, string
                preferenceVariableName, string
                message)
                {
                    var return_v = this_param.WriteHelper(inquireCaption, inquireMessage, preference, lastContinueStatus, preferenceVariableName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 18136, 18349);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 16810, 18361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 16810, 18361);
            }
        }

        public void WriteDebug(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 20256, 20361);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 20316, 20350);

                f_1291_20316_20349(this, f_1291_20327_20348(text));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 20256, 20361);

                System.Management.Automation.DebugRecord
                f_1291_20327_20348(string
                message)
                {
                    var return_v = new System.Management.Automation.DebugRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 20327, 20348);
                    return return_v;
                }


                int
                f_1291_20316_20349(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.DebugRecord
                record)
                {
                    this_param.WriteDebug(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 20316, 20349);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 20256, 20361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 20256, 20361);
            }
        }

        internal void WriteDebug(DebugRecord record, bool overrideInquire = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 20460, 22860);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 20559, 20605);

                ActionPreference
                preference = f_1291_20589_20604()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 20619, 20738) || true) && (overrideInquire && (DynAbs.Tracing.TraceSender.Expression_True(1291, 20623, 20680) && preference == ActionPreference.Inquire))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 20619, 20738);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 20699, 20738);

                    preference = ActionPreference.Continue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 20619, 20738);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 20754, 22608) || true) && (f_1291_20758_20818(this, preference, lastDebugContinueStatus))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 20754, 22608);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 20852, 20985) || true) && (f_1291_20856_20877(record) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 20852, 20985);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 20927, 20966);

                        f_1291_20927_20965(record, f_1291_20952_20964());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 20852, 20985);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 21062, 21205) || true) && (preference == ActionPreference.Break)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 21062, 21205);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 21144, 21186);

                        //f_1291_21144_21185_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(CBhost, 1291, 21144, 21185) ? 
                        //    f_1291_21151_21185_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(.Runspace, 1291, 21151, 21185) ? 
                        //    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(.Debugger, 1291, 21161, 21185)?.Break(record), 1291, 21171, 21185)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 21062, 21205);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 21225, 22593) || true) && (f_1291_21229_21244() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 21225, 22593);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 21294, 21638) || true) && (CBhost != null && (DynAbs.Tracing.TraceSender.Expression_True(1291, 21298, 21341) && f_1291_21316_21333(CBhost) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1291, 21298, 21394) && f_1291_21370_21394(f_1291_21370_21385())))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 21294, 21638);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 21567, 21615);

                            f_1291_21567_21614(f_1291_21567_21584(CBhost), record);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 21294, 21638);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 21751, 21800);

                        PSObject
                        debugWrap = f_1291_21772_21799(record)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 21822, 21868);

                        debugWrap.WriteStream = WriteStreamType.Debug;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 21892, 21923);

                        f_1291_21892_21922(f_1291_21892_21907(), debugWrap);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 21225, 22593);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 21225, 22593);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 22113, 22363) || true) && (f_1291_22117_22121() == null || (DynAbs.Tracing.TraceSender.Expression_False(1291, 22117, 22148) || f_1291_22133_22140(f_1291_22133_22137()) == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 22113, 22363);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 22198, 22263);

                            f_1291_22198_22262(false, "No host in CommandBase.WriteDebug()");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 22289, 22340);

                            throw f_1291_22295_22339();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 22113, 22363);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 22387, 22509);

                        f_1291_22387_22508(f_1291_22387_22404(CBhost), f_1291_22422_22507(f_1291_22440_22490(), f_1291_22492_22506(record)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 22531, 22574);

                        f_1291_22531_22573(f_1291_22531_22548(CBhost), record);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 21225, 22593);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 20754, 22608);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 22624, 22849);

                lastDebugContinueStatus = f_1291_22650_22848(this, null, null, preference, lastDebugContinueStatus, "DebugPreference", f_1291_22833_22847(record));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 20460, 22860);

                System.Management.Automation.ActionPreference
                f_1291_20589_20604()
                {
                    var return_v = DebugPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 20589, 20604);
                    return return_v;
                }


                bool
                f_1291_20758_20818(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ActionPreference
                preference, System.Management.Automation.MshCommandRuntime.ContinueStatus
                lastContinueStatus)
                {
                    var return_v = this_param.WriteHelper_ShouldWrite(preference, lastContinueStatus);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 20758, 20818);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1291_20856_20877(System.Management.Automation.DebugRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 20856, 20877);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1291_20952_20964()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 20952, 20964);
                    return return_v;
                }


                int
                f_1291_20927_20965(System.Management.Automation.DebugRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 20927, 20965);
                    return 0;
                }

                System.Management.Automation.Internal.Pipe
                f_1291_21229_21244()
                {
                    var return_v = DebugOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 21229, 21244);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_21316_21333(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 21316, 21333);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_21370_21385()
                {
                    var return_v = DebugOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 21370, 21385);
                    return return_v;
                }


                bool
                f_1291_21370_21394(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.NullPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 21370, 21394);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_21567_21584(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 21567, 21584);
                    return return_v;
                }


                int
                f_1291_21567_21614(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.DebugRecord
                record)
                {
                    this_param.WriteDebugInfoBuffers(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 21567, 21614);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1291_21772_21799(System.Management.Automation.DebugRecord
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 21772, 21799);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_21892_21907()
                {
                    var return_v = DebugOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 21892, 21907);
                    return return_v;
                }


                int
                f_1291_21892_21922(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.PSObject
                obj)
                {
                    this_param.Add((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 21892, 21922);
                    return 0;
                }


                System.Management.Automation.Host.PSHost
                f_1291_22117_22121()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 22117, 22121);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1291_22133_22137()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 22133, 22137);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1291_22133_22140(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 22133, 22140);
                    return return_v;
                }


                int
                f_1291_22198_22262(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 22198, 22262);
                    return 0;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1291_22295_22339()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 22295, 22339);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_22387_22404(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 22387, 22404);
                    return return_v;
                }


                string
                f_1291_22440_22490()
                {
                    var return_v = InternalHostUserInterfaceStrings.DebugFormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 22440, 22490);
                    return return_v;
                }


                string
                f_1291_22492_22506(System.Management.Automation.DebugRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 22492, 22506);
                    return return_v;
                }


                string
                f_1291_22422_22507(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 22422, 22507);
                    return return_v;
                }


                int
                f_1291_22387_22508(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                resultText)
                {
                    this_param.TranscribeResult(resultText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 22387, 22508);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_22531_22548(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 22531, 22548);
                    return return_v;
                }


                int
                f_1291_22531_22573(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.DebugRecord
                record)
                {
                    this_param.WriteDebugRecord(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 22531, 22573);
                    return 0;
                }


                string
                f_1291_22833_22847(System.Management.Automation.DebugRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 22833, 22847);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime.ContinueStatus
                f_1291_22650_22848(System.Management.Automation.MshCommandRuntime
                this_param, string
                inquireCaption, string
                inquireMessage, System.Management.Automation.ActionPreference
                preference, System.Management.Automation.MshCommandRuntime.ContinueStatus
                lastContinueStatus, string
                preferenceVariableName, string
                message)
                {
                    var return_v = this_param.WriteHelper(inquireCaption, inquireMessage, preference, lastContinueStatus, preferenceVariableName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 22650, 22848);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 20460, 22860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 20460, 22860);
            }
        }

        public void WriteVerbose(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 24388, 24499);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 24450, 24488);

                f_1291_24450_24487(this, f_1291_24463_24486(text));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 24388, 24499);

                System.Management.Automation.VerboseRecord
                f_1291_24463_24486(string
                message)
                {
                    var return_v = new System.Management.Automation.VerboseRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 24463, 24486);
                    return return_v;
                }


                int
                f_1291_24450_24487(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.VerboseRecord
                record)
                {
                    this_param.WriteVerbose(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 24450, 24487);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 24388, 24499);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 24388, 24499);
            }
        }

        internal void WriteVerbose(VerboseRecord record, bool overrideInquire = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 24600, 27038);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 24703, 24751);

                ActionPreference
                preference = f_1291_24733_24750()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 24765, 24884) || true) && (overrideInquire && (DynAbs.Tracing.TraceSender.Expression_True(1291, 24769, 24826) && preference == ActionPreference.Inquire))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 24765, 24884);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 24845, 24884);

                    preference = ActionPreference.Continue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 24765, 24884);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 24900, 26780) || true) && (f_1291_24904_24966(this, preference, lastVerboseContinueStatus))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 24900, 26780);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 25000, 25133) || true) && (f_1291_25004_25025(record) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 25000, 25133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 25075, 25114);

                        f_1291_25075_25113(record, f_1291_25100_25112());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 25000, 25133);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 25210, 25353) || true) && (preference == ActionPreference.Break)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 25210, 25353);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 25292, 25334);

                        //f_1291_25292_25333_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(CBhost, 1291, 25292, 25333) ? f_1291_25299_25333_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(.Runspace, 1291, 25299, 25333) ? DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(.Debugger, 1291, 25309, 25333)?.Break(record), 1291, 25319, 25333)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 25210, 25353);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 25373, 26765) || true) && (f_1291_25377_25394() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 25373, 26765);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 25444, 25792) || true) && (CBhost != null && (DynAbs.Tracing.TraceSender.Expression_True(1291, 25448, 25491) && f_1291_25466_25483(CBhost) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1291, 25448, 25546) && f_1291_25520_25546(f_1291_25520_25537())))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 25444, 25792);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 25719, 25769);

                            f_1291_25719_25768(f_1291_25719_25736(CBhost), record);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 25444, 25792);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 25907, 25958);

                        PSObject
                        verboseWrap = f_1291_25930_25957(record)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 25980, 26030);

                        verboseWrap.WriteStream = WriteStreamType.Verbose;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 26054, 26089);

                        f_1291_26054_26088(f_1291_26054_26071(), verboseWrap);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 25373, 26765);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 25373, 26765);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 26279, 26531) || true) && (f_1291_26283_26287() == null || (DynAbs.Tracing.TraceSender.Expression_False(1291, 26283, 26314) || f_1291_26299_26306(f_1291_26299_26303()) == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 26279, 26531);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 26364, 26431);

                            f_1291_26364_26430(false, "No host in CommandBase.WriteVerbose()");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 26457, 26508);

                            throw f_1291_26463_26507();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 26279, 26531);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 26555, 26679);

                        f_1291_26555_26678(f_1291_26555_26572(CBhost), f_1291_26590_26677(f_1291_26608_26660(), f_1291_26662_26676(record)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 26701, 26746);

                        f_1291_26701_26745(f_1291_26701_26718(CBhost), record);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 25373, 26765);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 24900, 26780);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 26796, 27027);

                lastVerboseContinueStatus = f_1291_26824_27026(this, null, null, preference, lastVerboseContinueStatus, "VerbosePreference", f_1291_27011_27025(record));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 24600, 27038);

                System.Management.Automation.ActionPreference
                f_1291_24733_24750()
                {
                    var return_v = VerbosePreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 24733, 24750);
                    return return_v;
                }


                bool
                f_1291_24904_24966(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ActionPreference
                preference, System.Management.Automation.MshCommandRuntime.ContinueStatus
                lastContinueStatus)
                {
                    var return_v = this_param.WriteHelper_ShouldWrite(preference, lastContinueStatus);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 24904, 24966);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1291_25004_25025(System.Management.Automation.VerboseRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 25004, 25025);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1291_25100_25112()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 25100, 25112);
                    return return_v;
                }


                int
                f_1291_25075_25113(System.Management.Automation.VerboseRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 25075, 25113);
                    return 0;
                }

                System.Management.Automation.Internal.Pipe
                f_1291_25377_25394()
                {
                    var return_v = VerboseOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 25377, 25394);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_25466_25483(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 25466, 25483);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_25520_25537()
                {
                    var return_v = VerboseOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 25520, 25537);
                    return return_v;
                }


                bool
                f_1291_25520_25546(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.NullPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 25520, 25546);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_25719_25736(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 25719, 25736);
                    return return_v;
                }


                int
                f_1291_25719_25768(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.VerboseRecord
                record)
                {
                    this_param.WriteVerboseInfoBuffers(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 25719, 25768);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1291_25930_25957(System.Management.Automation.VerboseRecord
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 25930, 25957);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_26054_26071()
                {
                    var return_v = VerboseOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 26054, 26071);
                    return return_v;
                }


                int
                f_1291_26054_26088(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.PSObject
                obj)
                {
                    this_param.Add((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 26054, 26088);
                    return 0;
                }


                System.Management.Automation.Host.PSHost
                f_1291_26283_26287()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 26283, 26287);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1291_26299_26303()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 26299, 26303);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1291_26299_26306(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 26299, 26306);
                    return return_v;
                }


                int
                f_1291_26364_26430(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 26364, 26430);
                    return 0;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1291_26463_26507()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 26463, 26507);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_26555_26572(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 26555, 26572);
                    return return_v;
                }


                string
                f_1291_26608_26660()
                {
                    var return_v = InternalHostUserInterfaceStrings.VerboseFormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 26608, 26660);
                    return return_v;
                }


                string
                f_1291_26662_26676(System.Management.Automation.VerboseRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 26662, 26676);
                    return return_v;
                }


                string
                f_1291_26590_26677(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 26590, 26677);
                    return return_v;
                }


                int
                f_1291_26555_26678(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                resultText)
                {
                    this_param.TranscribeResult(resultText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 26555, 26678);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_26701_26718(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 26701, 26718);
                    return return_v;
                }


                int
                f_1291_26701_26745(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.VerboseRecord
                record)
                {
                    this_param.WriteVerboseRecord(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 26701, 26745);
                    return 0;
                }


                string
                f_1291_27011_27025(System.Management.Automation.VerboseRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 27011, 27025);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime.ContinueStatus
                f_1291_26824_27026(System.Management.Automation.MshCommandRuntime
                this_param, string
                inquireCaption, string
                inquireMessage, System.Management.Automation.ActionPreference
                preference, System.Management.Automation.MshCommandRuntime.ContinueStatus
                lastContinueStatus, string
                preferenceVariableName, string
                message)
                {
                    var return_v = this_param.WriteHelper(inquireCaption, inquireMessage, preference, lastContinueStatus, preferenceVariableName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 26824, 27026);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 24600, 27038);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 24600, 27038);
            }
        }

        public void WriteWarning(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 28545, 28656);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 28607, 28645);

                f_1291_28607_28644(this, f_1291_28620_28643(text));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 28545, 28656);

                System.Management.Automation.WarningRecord
                f_1291_28620_28643(string
                message)
                {
                    var return_v = new System.Management.Automation.WarningRecord(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 28620, 28643);
                    return return_v;
                }


                int
                f_1291_28607_28644(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.WarningRecord
                record)
                {
                    this_param.WriteWarning(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 28607, 28644);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 28545, 28656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 28545, 28656);
            }
        }

        internal void WriteWarning(WarningRecord record, bool overrideInquire = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 28757, 31266);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 28860, 28908);

                ActionPreference
                preference = f_1291_28890_28907()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 28922, 29041) || true) && (overrideInquire && (DynAbs.Tracing.TraceSender.Expression_True(1291, 28926, 28983) && preference == ActionPreference.Inquire))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 28922, 29041);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 29002, 29041);

                    preference = ActionPreference.Continue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 28922, 29041);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 29057, 30963) || true) && (f_1291_29061_29123(this, preference, lastWarningContinueStatus))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 29057, 30963);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 29157, 29290) || true) && (f_1291_29161_29182(record) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 29157, 29290);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 29232, 29271);

                        f_1291_29232_29270(record, f_1291_29257_29269());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 29157, 29290);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 29367, 29510) || true) && (preference == ActionPreference.Break)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 29367, 29510);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 29449, 29491);

                        //f_1291_29449_29490_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(CBhost, 1291, 29449, 29490) ? f_1291_29456_29490_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(.Runspace, 1291, 29456, 29490) ? DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(.Debugger, 1291, 29466, 29490)?.Break(record), 1291, 29476, 29490)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 29367, 29510);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 29530, 30948) || true) && (f_1291_29534_29551() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 29530, 30948);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 29601, 29949) || true) && (CBhost != null && (DynAbs.Tracing.TraceSender.Expression_True(1291, 29605, 29648) && f_1291_29623_29640(CBhost) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1291, 29605, 29703) && f_1291_29677_29703(f_1291_29677_29694())))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 29601, 29949);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 29876, 29926);

                            f_1291_29876_29925(f_1291_29876_29893(CBhost), record);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 29601, 29949);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 30064, 30115);

                        PSObject
                        warningWrap = f_1291_30087_30114(record)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 30137, 30187);

                        warningWrap.WriteStream = WriteStreamType.Warning;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 30211, 30272);

                        f_1291_30211_30271(f_1291_30211_30228(), warningWrap);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 29530, 30948);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 29530, 30948);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 30462, 30714) || true) && (f_1291_30466_30470() == null || (DynAbs.Tracing.TraceSender.Expression_False(1291, 30466, 30497) || f_1291_30482_30489(f_1291_30482_30486()) == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 30462, 30714);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 30547, 30614);

                            f_1291_30547_30613(false, "No host in CommandBase.WriteWarning()");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 30640, 30691);

                            throw f_1291_30646_30690();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 30462, 30714);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 30738, 30862);

                        f_1291_30738_30861(f_1291_30738_30755(CBhost), f_1291_30773_30860(f_1291_30791_30843(), f_1291_30845_30859(record)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 30884, 30929);

                        f_1291_30884_30928(f_1291_30884_30901(CBhost), record);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 29530, 30948);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 29057, 30963);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 30979, 31008);

                f_1291_30979_31007(this, record);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 31024, 31255);

                lastWarningContinueStatus = f_1291_31052_31254(this, null, null, preference, lastWarningContinueStatus, "WarningPreference", f_1291_31239_31253(record));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 28757, 31266);

                System.Management.Automation.ActionPreference
                f_1291_28890_28907()
                {
                    var return_v = WarningPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 28890, 28907);
                    return return_v;
                }


                bool
                f_1291_29061_29123(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ActionPreference
                preference, System.Management.Automation.MshCommandRuntime.ContinueStatus
                lastContinueStatus)
                {
                    var return_v = this_param.WriteHelper_ShouldWrite(preference, lastContinueStatus);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 29061, 29123);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1291_29161_29182(System.Management.Automation.WarningRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 29161, 29182);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1291_29257_29269()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 29257, 29269);
                    return return_v;
                }


                int
                f_1291_29232_29270(System.Management.Automation.WarningRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 29232, 29270);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_29534_29551()
                {
                    var return_v = WarningOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 29534, 29551);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_29623_29640(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 29623, 29640);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_29677_29694()
                {
                    var return_v = WarningOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 29677, 29694);
                    return return_v;
                }


                bool
                f_1291_29677_29703(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.NullPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 29677, 29703);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_29876_29893(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 29876, 29893);
                    return return_v;
                }


                int
                f_1291_29876_29925(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.WarningRecord
                record)
                {
                    this_param.WriteWarningInfoBuffers(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 29876, 29925);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1291_30087_30114(System.Management.Automation.WarningRecord
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 30087, 30114);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_30211_30228()
                {
                    var return_v = WarningOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 30211, 30228);
                    return return_v;
                }


                int
                f_1291_30211_30271(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.PSObject
                obj)
                {
                    this_param.AddWithoutAppendingOutVarList((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 30211, 30271);
                    return 0;
                }


                System.Management.Automation.Host.PSHost
                f_1291_30466_30470()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 30466, 30470);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1291_30482_30486()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 30482, 30486);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1291_30482_30489(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 30482, 30489);
                    return return_v;
                }


                int
                f_1291_30547_30613(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 30547, 30613);
                    return 0;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1291_30646_30690()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 30646, 30690);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_30738_30755(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 30738, 30755);
                    return return_v;
                }


                string
                f_1291_30791_30843()
                {
                    var return_v = InternalHostUserInterfaceStrings.WarningFormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 30791, 30843);
                    return return_v;
                }


                string
                f_1291_30845_30859(System.Management.Automation.WarningRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 30845, 30859);
                    return return_v;
                }


                string
                f_1291_30773_30860(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 30773, 30860);
                    return return_v;
                }


                int
                f_1291_30738_30861(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                resultText)
                {
                    this_param.TranscribeResult(resultText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 30738, 30861);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_30884_30901(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 30884, 30901);
                    return return_v;
                }


                int
                f_1291_30884_30928(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.WarningRecord
                record)
                {
                    this_param.WriteWarningRecord(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 30884, 30928);
                    return 0;
                }


                int
                f_1291_30979_31007(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.WarningRecord
                obj)
                {
                    this_param.AppendWarningVarList((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 30979, 31007);
                    return 0;
                }


                string
                f_1291_31239_31253(System.Management.Automation.WarningRecord
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 31239, 31253);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime.ContinueStatus
                f_1291_31052_31254(System.Management.Automation.MshCommandRuntime
                this_param, string
                inquireCaption, string
                inquireMessage, System.Management.Automation.ActionPreference
                preference, System.Management.Automation.MshCommandRuntime.ContinueStatus
                lastContinueStatus, string
                preferenceVariableName, string
                message)
                {
                    var return_v = this_param.WriteHelper(inquireCaption, inquireMessage, preference, lastContinueStatus, preferenceVariableName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 31052, 31254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 28757, 31266);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 28757, 31266);
            }
        }

        public void WriteInformation(InformationRecord informationRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 31373, 31517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 31463, 31506);

                f_1291_31463_31505(this, informationRecord, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 31373, 31517);

                int
                f_1291_31463_31505(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.InformationRecord
                record, bool
                overrideInquire)
                {
                    this_param.WriteInformation(record, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 31463, 31505);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 31373, 31517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 31373, 31517);
            }
        }

        internal void WriteInformation(InformationRecord record, bool overrideInquire = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 31624, 37541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 31735, 31787);

                ActionPreference
                preference = f_1291_31765_31786()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 31801, 31920) || true) && (overrideInquire && (DynAbs.Tracing.TraceSender.Expression_True(1291, 31805, 31862) && preference == ActionPreference.Inquire))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 31801, 31920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 31881, 31920);

                    preference = ActionPreference.Continue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 31801, 31920);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 31989, 32120) || true) && (preference == ActionPreference.Break)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 31989, 32120);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 32063, 32105);

                    //f_1291_32063_32104_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(CBhost, 1291, 32063, 32104) ? f_1291_32070_32104_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(.Runspace, 1291, 32070, 32104) ? DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(.Debugger, 1291, 32080, 32104)?.Break(record), 1291, 32090, 32104)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 31989, 32120);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 32136, 37219) || true) && (preference != ActionPreference.Ignore)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 32136, 37219);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 32211, 36718) || true) && (f_1291_32215_32236() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 32211, 36718);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 32286, 32642) || true) && (CBhost != null && (DynAbs.Tracing.TraceSender.Expression_True(1291, 32290, 32333) && f_1291_32308_32325(CBhost) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1291, 32290, 32392) && f_1291_32362_32392(f_1291_32362_32383())))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 32286, 32642);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 32565, 32619);

                            f_1291_32565_32618(f_1291_32565_32582(CBhost), record);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 32286, 32642);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 32761, 32816);

                        PSObject
                        informationWrap = f_1291_32788_32815(record)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 32838, 32896);

                        informationWrap.WriteStream = WriteStreamType.Information;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 32920, 32963);

                        f_1291_32920_32962(f_1291_32920_32941(), informationWrap);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 32211, 36718);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 32211, 36718);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 33153, 33355) || true) && (f_1291_33157_33161() == null || (DynAbs.Tracing.TraceSender.Expression_False(1291, 33157, 33188) || f_1291_33173_33180(f_1291_33173_33177()) == null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 33153, 33355);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 33238, 33332);

                            throw f_1291_33244_33331("No host in CommandBase.WriteInformation()");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 33153, 33355);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 33379, 33428);

                        f_1291_33379_33427(f_1291_33379_33396(CBhost), record);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 33452, 36699) || true) && ((f_1291_33457_33487(f_1291_33457_33468(record), "PSHOST") && (DynAbs.Tracing.TraceSender.Expression_True(1291, 33457, 33527) && (!f_1291_33493_33526(f_1291_33493_33504(record), "FORWARDED"))))
                        || (DynAbs.Tracing.TraceSender.Expression_False(1291, 33456, 33598) || (preference == ActionPreference.Continue)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 33452, 36699);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 33648, 33729);

                            HostInformationMessage
                            hostOutput = f_1291_33684_33702(record) as HostInformationMessage
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 33755, 36676) || true) && (hostOutput != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 33755, 36676);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 33835, 33871);

                                string
                                message = f_1291_33852_33870(hostOutput)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 33901, 33938);

                                ConsoleColor?
                                foregroundColor = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 33968, 34005);

                                ConsoleColor?
                                backgroundColor = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 34035, 34058);

                                bool
                                noNewLine = false
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 34090, 34277) || true) && (f_1291_34094_34129(f_1291_34094_34120(hostOutput)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 34090, 34277);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 34195, 34246);

                                    foregroundColor = f_1291_34213_34245(f_1291_34213_34239(hostOutput));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 34090, 34277);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 34309, 34496) || true) && (f_1291_34313_34348(f_1291_34313_34339(hostOutput)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 34309, 34496);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 34414, 34465);

                                    backgroundColor = f_1291_34432_34464(f_1291_34432_34458(hostOutput));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 34309, 34496);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 34528, 34697) || true) && (f_1291_34532_34561(f_1291_34532_34552(hostOutput)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 34528, 34697);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 34627, 34666);

                                    noNewLine = f_1291_34639_34665(f_1291_34639_34659(hostOutput));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 34528, 34697);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 34729, 36488) || true) && (f_1291_34733_34757(foregroundColor) || (DynAbs.Tracing.TraceSender.Expression_False(1291, 34733, 34785) || f_1291_34761_34785(backgroundColor)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 34729, 36488);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 35138, 35312) || true) && (f_1291_35142_35167_M(!foregroundColor.HasValue))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 35138, 35312);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 35241, 35277);

                                        foregroundColor = ConsoleColor.Gray;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 35138, 35312);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 35348, 35523) || true) && (f_1291_35352_35377_M(!backgroundColor.HasValue))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 35348, 35523);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 35451, 35488);

                                        backgroundColor = ConsoleColor.Black;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 35348, 35523);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 35559, 35989) || true) && (noNewLine)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 35559, 35989);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 35646, 35725);

                                        f_1291_35646_35724(f_1291_35646_35663(CBhost), f_1291_35670_35691(foregroundColor), f_1291_35693_35714(backgroundColor), message);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 35559, 35989);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 35559, 35989);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 35871, 35954);

                                        f_1291_35871_35953(f_1291_35871_35888(CBhost), f_1291_35899_35920(foregroundColor), f_1291_35922_35943(backgroundColor), message);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 35559, 35989);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 34729, 36488);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 34729, 36488);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 36119, 36457) || true) && (noNewLine)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 36119, 36457);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 36206, 36239);

                                        f_1291_36206_36238(f_1291_36206_36223(CBhost), message);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 36119, 36457);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 36119, 36457);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 36385, 36422);

                                        f_1291_36385_36421(f_1291_36385_36402(CBhost), message);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 36119, 36457);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 34729, 36488);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 33755, 36676);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 33755, 36676);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 36602, 36649);

                                f_1291_36602_36648(f_1291_36602_36619(CBhost), f_1291_36630_36647(record));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 33755, 36676);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 33452, 36699);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 32211, 36718);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 37002, 37204) || true) && (f_1291_37006_37036(f_1291_37006_37017(record), "PSHOST") || (DynAbs.Tracing.TraceSender.Expression_False(1291, 37006, 37089) || (preference != ActionPreference.SilentlyContinue)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 37002, 37204);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 37131, 37185);

                        f_1291_37131_37184(f_1291_37131_37148(CBhost), f_1291_37166_37183(record));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 37002, 37204);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 32136, 37219);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 37235, 37268);

                f_1291_37235_37267(this, record);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 37284, 37530);

                lastInformationContinueStatus = f_1291_37316_37529(this, null, null, preference, lastInformationContinueStatus, "InformationPreference", f_1291_37511_37528(record));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 31624, 37541);

                System.Management.Automation.ActionPreference
                f_1291_31765_31786()
                {
                    var return_v = InformationPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 31765, 31786);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_32215_32236()
                {
                    var return_v = InformationOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 32215, 32236);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_32308_32325(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 32308, 32325);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_32362_32383()
                {
                    var return_v = InformationOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 32362, 32383);
                    return return_v;
                }


                bool
                f_1291_32362_32392(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.NullPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 32362, 32392);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_32565_32582(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 32565, 32582);
                    return return_v;
                }


                int
                f_1291_32565_32618(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.InformationRecord
                record)
                {
                    this_param.WriteInformationInfoBuffers(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 32565, 32618);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1291_32788_32815(System.Management.Automation.InformationRecord
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 32788, 32815);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_32920_32941()
                {
                    var return_v = InformationOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 32920, 32941);
                    return return_v;
                }


                int
                f_1291_32920_32962(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.PSObject
                obj)
                {
                    this_param.Add((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 32920, 32962);
                    return 0;
                }


                System.Management.Automation.Host.PSHost
                f_1291_33157_33161()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 33157, 33161);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1291_33173_33177()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 33173, 33177);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1291_33173_33180(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 33173, 33180);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1291_33244_33331(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 33244, 33331);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_33379_33396(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 33379, 33396);
                    return return_v;
                }


                int
                f_1291_33379_33427(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.Management.Automation.InformationRecord
                record)
                {
                    this_param.WriteInformationRecord(record);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 33379, 33427);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1291_33457_33468(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.Tags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 33457, 33468);
                    return return_v;
                }


                bool
                f_1291_33457_33487(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 33457, 33487);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1291_33493_33504(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.Tags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 33493, 33504);
                    return return_v;
                }


                bool
                f_1291_33493_33526(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 33493, 33526);
                    return return_v;
                }


                object
                f_1291_33684_33702(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.MessageData;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 33684, 33702);
                    return return_v;
                }


                string
                f_1291_33852_33870(System.Management.Automation.HostInformationMessage
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 33852, 33870);
                    return return_v;
                }


                System.ConsoleColor?
                f_1291_34094_34120(System.Management.Automation.HostInformationMessage
                this_param)
                {
                    var return_v = this_param.ForegroundColor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 34094, 34120);
                    return return_v;
                }


                bool
                f_1291_34094_34129(System.ConsoleColor?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 34094, 34129);
                    return return_v;
                }


                System.ConsoleColor?
                f_1291_34213_34239(System.Management.Automation.HostInformationMessage
                this_param)
                {
                    var return_v = this_param.ForegroundColor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 34213, 34239);
                    return return_v;
                }


                System.ConsoleColor
                f_1291_34213_34245(System.ConsoleColor?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 34213, 34245);
                    return return_v;
                }


                System.ConsoleColor?
                f_1291_34313_34339(System.Management.Automation.HostInformationMessage
                this_param)
                {
                    var return_v = this_param.BackgroundColor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 34313, 34339);
                    return return_v;
                }


                bool
                f_1291_34313_34348(System.ConsoleColor?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 34313, 34348);
                    return return_v;
                }


                System.ConsoleColor?
                f_1291_34432_34458(System.Management.Automation.HostInformationMessage
                this_param)
                {
                    var return_v = this_param.BackgroundColor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 34432, 34458);
                    return return_v;
                }


                System.ConsoleColor
                f_1291_34432_34464(System.ConsoleColor?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 34432, 34464);
                    return return_v;
                }


                bool?
                f_1291_34532_34552(System.Management.Automation.HostInformationMessage
                this_param)
                {
                    var return_v = this_param.NoNewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 34532, 34552);
                    return return_v;
                }


                bool
                f_1291_34532_34561(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 34532, 34561);
                    return return_v;
                }


                bool?
                f_1291_34639_34659(System.Management.Automation.HostInformationMessage
                this_param)
                {
                    var return_v = this_param.NoNewLine;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 34639, 34659);
                    return return_v;
                }


                bool
                f_1291_34639_34665(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 34639, 34665);
                    return return_v;
                }


                bool
                f_1291_34733_34757(System.ConsoleColor?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 34733, 34757);
                    return return_v;
                }


                bool
                f_1291_34761_34785(System.ConsoleColor?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 34761, 34785);
                    return return_v;
                }


                bool
                f_1291_35142_35167_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 35142, 35167);
                    return return_v;
                }


                bool
                f_1291_35352_35377_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 35352, 35377);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_35646_35663(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 35646, 35663);
                    return return_v;
                }


                System.ConsoleColor
                f_1291_35670_35691(System.ConsoleColor?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 35670, 35691);
                    return return_v;
                }


                System.ConsoleColor
                f_1291_35693_35714(System.ConsoleColor?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 35693, 35714);
                    return return_v;
                }


                int
                f_1291_35646_35724(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.ConsoleColor
                foregroundColor, System.ConsoleColor
                backgroundColor, string
                value)
                {
                    this_param.Write(foregroundColor, backgroundColor, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 35646, 35724);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_35871_35888(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 35871, 35888);
                    return return_v;
                }


                System.ConsoleColor
                f_1291_35899_35920(System.ConsoleColor?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 35899, 35920);
                    return return_v;
                }


                System.ConsoleColor
                f_1291_35922_35943(System.ConsoleColor?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 35922, 35943);
                    return return_v;
                }


                int
                f_1291_35871_35953(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, System.ConsoleColor
                foregroundColor, System.ConsoleColor
                backgroundColor, string
                value)
                {
                    this_param.WriteLine(foregroundColor, backgroundColor, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 35871, 35953);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_36206_36223(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 36206, 36223);
                    return return_v;
                }


                int
                f_1291_36206_36238(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                value)
                {
                    this_param.Write(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 36206, 36238);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_36385_36402(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 36385, 36402);
                    return return_v;
                }


                int
                f_1291_36385_36421(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 36385, 36421);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_36602_36619(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 36602, 36619);
                    return return_v;
                }


                string
                f_1291_36630_36647(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 36630, 36647);
                    return return_v;
                }


                int
                f_1291_36602_36648(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 36602, 36648);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1291_37006_37017(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.Tags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 37006, 37017);
                    return return_v;
                }


                bool
                f_1291_37006_37036(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 37006, 37036);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_37131_37148(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 37131, 37148);
                    return return_v;
                }


                string
                f_1291_37166_37183(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 37166, 37183);
                    return return_v;
                }


                int
                f_1291_37131_37184(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                resultText)
                {
                    this_param.TranscribeResult(resultText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 37131, 37184);
                    return 0;
                }


                int
                f_1291_37235_37267(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.InformationRecord
                obj)
                {
                    this_param.AppendInformationVarList((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 37235, 37267);
                    return 0;
                }


                string
                f_1291_37511_37528(System.Management.Automation.InformationRecord
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 37511, 37528);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime.ContinueStatus
                f_1291_37316_37529(System.Management.Automation.MshCommandRuntime
                this_param, string
                inquireCaption, string
                inquireMessage, System.Management.Automation.ActionPreference
                preference, System.Management.Automation.MshCommandRuntime.ContinueStatus
                lastContinueStatus, string
                preferenceVariableName, string
                message)
                {
                    var return_v = this_param.WriteHelper(inquireCaption, inquireMessage, preference, lastContinueStatus, preferenceVariableName, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 37316, 37529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 31624, 37541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 31624, 37541);
            }
        }

        public void WriteCommandDetail(string text)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 38371, 38523);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 38439, 38512);

                f_1291_38439_38511(f_1291_38439_38461(this), f_1291_38479_38504(_thisCommand), text);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 38371, 38523);

                System.Management.Automation.Internal.PipelineProcessor
                f_1291_38439_38461(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 38439, 38461);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1291_38479_38504(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 38479, 38504);
                    return return_v;
                }


                int
                f_1291_38439_38511(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo, string
                text)
                {
                    this_param.LogExecutionInfo(invocationInfo, text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 38439, 38511);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 38371, 38523);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 38371, 38523);
            }
        }

        internal bool LogPipelineExecutionDetail { get; }

        private bool InitShouldLogPipelineExecutionDetail()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 38605, 39757);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 38681, 38732);

                CmdletInfo
                cmdletInfo = _commandInfo as CmdletInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 38748, 39397) || true) && (cmdletInfo != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 38748, 39397);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 38804, 38959) || true) && (f_1291_38808_38886("Add-Type", f_1291_38834_38849(cmdletInfo), StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 38804, 38959);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 38928, 38940);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 38804, 38959);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 38979, 39155) || true) && (f_1291_38983_39000(cmdletInfo) == null && (DynAbs.Tracing.TraceSender.Expression_True(1291, 38983, 39039) && f_1291_39012_39031(cmdletInfo) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 38979, 39155);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 39081, 39136);

                        return f_1291_39088_39135(f_1291_39088_39107(cmdletInfo));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 38979, 39155);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 39175, 39349) || true) && (f_1291_39179_39198(cmdletInfo) == null && (DynAbs.Tracing.TraceSender.Expression_True(1291, 39179, 39235) && f_1291_39210_39227(cmdletInfo) != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 39175, 39349);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 39277, 39330);

                        return f_1291_39284_39329(f_1291_39284_39301(cmdletInfo));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 39175, 39349);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 39369, 39382);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 38748, 39397);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 39487, 39544);

                FunctionInfo
                functionInfo = _commandInfo as FunctionInfo
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 39558, 39717) || true) && (functionInfo != null && (DynAbs.Tracing.TraceSender.Expression_True(1291, 39562, 39613) && f_1291_39586_39605(functionInfo) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 39558, 39717);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 39647, 39702);

                    return f_1291_39654_39701(f_1291_39654_39673(functionInfo));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 39558, 39717);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 39733, 39746);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 38605, 39757);

                string
                f_1291_38834_38849(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 38834, 38849);
                    return return_v;
                }


                bool
                f_1291_38808_38886(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 38808, 38886);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1291_38983_39000(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 38983, 39000);
                    return return_v;
                }


                System.Management.Automation.PSSnapInInfo
                f_1291_39012_39031(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.PSSnapIn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 39012, 39031);
                    return return_v;
                }


                System.Management.Automation.PSSnapInInfo
                f_1291_39088_39107(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.PSSnapIn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 39088, 39107);
                    return return_v;
                }


                bool
                f_1291_39088_39135(System.Management.Automation.PSSnapInInfo
                this_param)
                {
                    var return_v = this_param.LogPipelineExecutionDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 39088, 39135);
                    return return_v;
                }


                System.Management.Automation.PSSnapInInfo
                f_1291_39179_39198(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.PSSnapIn;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 39179, 39198);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1291_39210_39227(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 39210, 39227);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1291_39284_39301(System.Management.Automation.CmdletInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 39284, 39301);
                    return return_v;
                }


                bool
                f_1291_39284_39329(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.LogPipelineExecutionDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 39284, 39329);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1291_39586_39605(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 39586, 39605);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1291_39654_39673(System.Management.Automation.FunctionInfo
                this_param)
                {
                    var return_v = this_param.Module;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 39654, 39673);
                    return return_v;
                }


                bool
                f_1291_39654_39701(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.LogPipelineExecutionDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 39654, 39701);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 38605, 39757);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 38605, 39757);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string PipelineVariable { get; set; }

        private PSVariable _pipelineVarReference;

        internal void SetupOutVariable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 40160, 41546);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 40217, 40315) || true) && (f_1291_40221_40259(f_1291_40242_40258(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 40217, 40315);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 40293, 40300);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 40217, 40315);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 40331, 40364);

                f_1291_40331_40363(this);

                if (
                (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 40547, 41535) || true) && ((!f_1291_40571_40609(f_1291_40592_40608(this))) && (DynAbs.Tracing.TraceSender.Expression_True(1291, 40569, 40668) && (!(f_1291_40634_40666(f_1291_40634_40650(this), '+')))) && (DynAbs.Tracing.TraceSender.Expression_True(1291, 40569, 40784) && f_1291_40689_40784("Out-Default", f_1291_40718_40747(f_1291_40718_40742(_thisCommand)), StringComparison.OrdinalIgnoreCase)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 40547, 41535);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 40818, 40913) || true) && (_state == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 40818, 40913);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 40859, 40913);

                        _state = f_1291_40868_40912(f_1291_40885_40911(f_1291_40885_40892()));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 40818, 40913);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 40933, 40955);

                    IList
                    oldValue = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 40973, 41053);

                    oldValue = f_1291_40984_41043(f_1291_40998_41042(f_1291_40998_41015(_state), f_1291_41025_41041(this))) as IList;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 41073, 41115);

                    _outVarList = oldValue ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.IList>(1291, 41087, 41114) ?? f_1291_41099_41114());

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 41135, 41305) || true) && (!(_thisCommand is PSScriptCmdlet))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 41135, 41305);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 41214, 41286);

                        f_1291_41214_41285(f_1291_41214_41229(this), VariableStreamKind.Output, _outVarList);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 41135, 41305);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 41325, 41378);

                    f_1291_41325_41377(f_1291_41325_41342(_state), f_1291_41347_41363(this), _outVarList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 40547, 41535);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 40547, 41535);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 41444, 41520);

                    f_1291_41444_41519(this, VariableStreamKind.Output, f_1291_41485_41501(this), ref _outVarList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 40547, 41535);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 40160, 41546);

                string
                f_1291_40242_40258(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 40242, 40258);
                    return return_v;
                }


                bool
                f_1291_40221_40259(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 40221, 40259);
                    return return_v;
                }


                int
                f_1291_40331_40363(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.EnsureVariableParameterAllowed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 40331, 40363);
                    return 0;
                }


                string
                f_1291_40592_40608(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 40592, 40608);
                    return return_v;
                }


                bool
                f_1291_40571_40609(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 40571, 40609);
                    return return_v;
                }


                string
                f_1291_40634_40650(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 40634, 40650);
                    return return_v;
                }


                bool
                f_1291_40634_40666(string
                this_param, char
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 40634, 40666);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1291_40718_40742(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 40718, 40742);
                    return return_v;
                }


                string
                f_1291_40718_40747(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 40718, 40747);
                    return return_v;
                }


                bool
                f_1291_40689_40784(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 40689, 40784);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1291_40885_40892()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 40885, 40892);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1291_40885_40911(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 40885, 40911);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1291_40868_40912(System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.SessionState(sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 40868, 40912);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1291_40998_41015(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 40998, 41015);
                    return return_v;
                }


                string
                f_1291_41025_41041(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 41025, 41041);
                    return return_v;
                }


                object
                f_1291_40998_41042(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name)
                {
                    var return_v = this_param.GetValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 40998, 41042);
                    return return_v;
                }


                object
                f_1291_40984_41043(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 40984, 41043);
                    return return_v;
                }


                System.Collections.ArrayList
                f_1291_41099_41114()
                {
                    var return_v = new System.Collections.ArrayList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 41099, 41114);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_41214_41229(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 41214, 41229);
                    return return_v;
                }


                int
                f_1291_41214_41285(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.VariableStreamKind
                kind, System.Collections.IList
                list)
                {
                    this_param.AddVariableList(kind, list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 41214, 41285);
                    return 0;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1291_41325_41342(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 41325, 41342);
                    return return_v;
                }


                string
                f_1291_41347_41363(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 41347, 41363);
                    return return_v;
                }


                int
                f_1291_41325_41377(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name, System.Collections.IList
                value)
                {
                    this_param.Set(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 41325, 41377);
                    return 0;
                }


                string
                f_1291_41485_41501(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 41485, 41501);
                    return return_v;
                }


                int
                f_1291_41444_41519(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.Internal.VariableStreamKind
                streamKind, string
                variableName, ref System.Collections.IList
                varList)
                {
                    this_param.SetupVariable(streamKind, variableName, ref varList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 41444, 41519);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 40160, 41546);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 40160, 41546);
            }
        }

        internal void SetupPipelineVariable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 41558, 42557);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 41759, 41862) || true) && (f_1291_41763_41806(f_1291_41784_41805(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 41759, 41862);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 41840, 41847);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 41759, 41862);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 41878, 41911);

                f_1291_41878_41910(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 41927, 42018) || true) && (_state == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 41927, 42018);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 41964, 42018);

                    _state = f_1291_41973_42017(f_1291_41990_42016(f_1291_41990_41997()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 41927, 42018);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 42079, 42141);

                _pipelineVarReference = f_1291_42103_42140(f_1291_42118_42139(this));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 42155, 42200);

                f_1291_42155_42199(f_1291_42155_42172(_state), _pipelineVarReference);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 42316, 42385);

                _pipelineVarReference = f_1291_42340_42384(f_1291_42340_42357(_state), f_1291_42362_42383(this));

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 42401, 42546) || true) && (!(_thisCommand is PSScriptCmdlet))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 42401, 42546);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 42472, 42531);

                    f_1291_42472_42530(f_1291_42472_42487(this), _pipelineVarReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 42401, 42546);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 41558, 42557);

                string
                f_1291_41784_41805(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 41784, 41805);
                    return return_v;
                }


                bool
                f_1291_41763_41806(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 41763, 41806);
                    return return_v;
                }


                int
                f_1291_41878_41910(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.EnsureVariableParameterAllowed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 41878, 41910);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1291_41990_41997()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 41990, 41997);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1291_41990_42016(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 41990, 42016);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1291_41973_42017(System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.SessionState(sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 41973, 42017);
                    return return_v;
                }


                string
                f_1291_42118_42139(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 42118, 42139);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1291_42103_42140(string
                name)
                {
                    var return_v = new System.Management.Automation.PSVariable(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 42103, 42140);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1291_42155_42172(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 42155, 42172);
                    return return_v;
                }


                int
                f_1291_42155_42199(System.Management.Automation.PSVariableIntrinsics
                this_param, System.Management.Automation.PSVariable
                variable)
                {
                    this_param.Set(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 42155, 42199);
                    return 0;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1291_42340_42357(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 42340, 42357);
                    return return_v;
                }


                string
                f_1291_42362_42383(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 42362, 42383);
                    return return_v;
                }


                System.Management.Automation.PSVariable
                f_1291_42340_42384(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name)
                {
                    var return_v = this_param.Get(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 42340, 42384);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_42472_42487(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 42472, 42487);
                    return return_v;
                }


                int
                f_1291_42472_42530(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.PSVariable
                pipelineVariable)
                {
                    this_param.SetPipelineVariable(pipelineVariable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 42472, 42530);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 41558, 42557);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 41558, 42557);
            }
        }

        internal int OutBuffer
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 42872, 42913);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 42878, 42911);

                    return f_1291_42885_42910(f_1291_42885_42895());
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 42872, 42913);

                    System.Management.Automation.Internal.Pipe
                    f_1291_42885_42895()
                    {
                        var return_v = OutputPipe;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 42885, 42895);
                        return return_v;
                    }


                    int
                    f_1291_42885_42910(System.Management.Automation.Internal.Pipe
                    this_param)
                    {
                        var return_v = this_param.OutBufferCount;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 42885, 42910);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 42825, 42982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 42825, 42982);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 42929, 42971);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 42935, 42969);

                    f_1291_42935_42945().OutBufferCount = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 42929, 42971);

                    System.Management.Automation.Internal.Pipe
                    f_1291_42935_42945()
                    {
                        var return_v = OutputPipe;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 42935, 42945);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 42825, 42982);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 42825, 42982);
                }
            }
        }

        public bool ShouldProcess(string target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 47340, 47722);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 47405, 47563);

                string
                verboseDescription = f_1291_47433_47562(f_1291_47451_47490(), f_1291_47509_47536(f_1291_47509_47531(f_1291_47509_47521())), target)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 47577, 47617);

                ShouldProcessReason
                shouldProcessReason
                = default(ShouldProcessReason);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 47631, 47711);

                return f_1291_47638_47710(this, verboseDescription, null, null, out shouldProcessReason);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 47340, 47722);

                string
                f_1291_47451_47490()
                {
                    var return_v = CommandBaseStrings.ShouldProcessMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 47451, 47490);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1291_47509_47521()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 47509, 47521);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1291_47509_47531(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 47509, 47531);
                    return return_v;
                }


                string
                f_1291_47509_47536(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 47509, 47536);
                    return return_v;
                }


                string
                f_1291_47433_47562(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 47433, 47562);
                    return return_v;
                }


                bool
                f_1291_47638_47710(System.Management.Automation.MshCommandRuntime
                this_param, string
                verboseDescription, string
                verboseWarning, string
                caption, out System.Management.Automation.ShouldProcessReason
                shouldProcessReason)
                {
                    var return_v = this_param.DoShouldProcess(verboseDescription, verboseWarning, caption, out shouldProcessReason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 47638, 47710);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 47340, 47722);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 47340, 47722);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldProcess(string target, string action)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 52246, 52645);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 52326, 52486);

                string
                verboseDescription = f_1291_52354_52485(f_1291_52372_52411(), action, target, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 52500, 52540);

                ShouldProcessReason
                shouldProcessReason
                = default(ShouldProcessReason);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 52554, 52634);

                return f_1291_52561_52633(this, verboseDescription, null, null, out shouldProcessReason);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 52246, 52645);

                string
                f_1291_52372_52411()
                {
                    var return_v = CommandBaseStrings.ShouldProcessMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 52372, 52411);
                    return return_v;
                }


                string
                f_1291_52354_52485(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 52354, 52485);
                    return return_v;
                }


                bool
                f_1291_52561_52633(System.Management.Automation.MshCommandRuntime
                this_param, string
                verboseDescription, string
                verboseWarning, string
                caption, out System.Management.Automation.ShouldProcessReason
                shouldProcessReason)
                {
                    var return_v = this_param.DoShouldProcess(verboseDescription, verboseWarning, caption, out shouldProcessReason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 52561, 52633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 52246, 52645);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 52246, 52645);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldProcess(
                    string verboseDescription,
                    string verboseWarning,
                    string caption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 57830, 58213);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 57986, 58026);

                ShouldProcessReason
                shouldProcessReason
                = default(ShouldProcessReason);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 58040, 58202);

                return f_1291_58047_58201(this, verboseDescription, verboseWarning, caption, out shouldProcessReason);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 57830, 58213);

                bool
                f_1291_58047_58201(System.Management.Automation.MshCommandRuntime
                this_param, string
                verboseDescription, string
                verboseWarning, string
                caption, out System.Management.Automation.ShouldProcessReason
                shouldProcessReason)
                {
                    var return_v = this_param.DoShouldProcess(verboseDescription, verboseWarning, caption, out shouldProcessReason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 58047, 58201);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 57830, 58213);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 57830, 58213);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldProcess(
                    string verboseDescription,
                    string verboseWarning,
                    string caption,
                    out ShouldProcessReason shouldProcessReason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 63808, 64195);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 64022, 64184);

                return f_1291_64029_64183(this, verboseDescription, verboseWarning, caption, out shouldProcessReason);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 63808, 64195);

                bool
                f_1291_64029_64183(System.Management.Automation.MshCommandRuntime
                this_param, string
                verboseDescription, string
                verboseWarning, string
                caption, out System.Management.Automation.ShouldProcessReason
                shouldProcessReason)
                {
                    var return_v = this_param.DoShouldProcess(verboseDescription, verboseWarning, caption, out shouldProcessReason);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 64029, 64183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 63808, 64195);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 63808, 64195);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool CanShouldProcessAutoConfirm()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 64207, 64935);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 64330, 64393);

                CommandMetadata
                commandMetadata = f_1291_64364_64392(_commandInfo)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 64407, 64559) || true) && (commandMetadata == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 64407, 64559);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 64468, 64514);

                    f_1291_64468_64513(false, "Expected CommandMetadata");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 64532, 64544);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 64407, 64559);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 64575, 64641);

                ConfirmImpact
                cmdletConfirmImpact = f_1291_64611_64640(commandMetadata)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 64702, 64746);

                ConfirmImpact
                threshold = f_1291_64728_64745()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 64760, 64895) || true) && ((threshold == ConfirmImpact.None) || (DynAbs.Tracing.TraceSender.Expression_False(1291, 64764, 64834) || (threshold > cmdletConfirmImpact)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 64760, 64895);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 64868, 64880);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 64760, 64895);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 64911, 64924);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 64207, 64935);

                System.Management.Automation.CommandMetadata
                f_1291_64364_64392(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.CommandMetadata;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 64364, 64392);
                    return return_v;
                }


                int
                f_1291_64468_64513(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 64468, 64513);
                    return 0;
                }


                System.Management.Automation.ConfirmImpact
                f_1291_64611_64640(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.ConfirmImpact;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 64611, 64640);
                    return return_v;
                }


                System.Management.Automation.ConfirmImpact
                f_1291_64728_64745()
                {
                    var return_v = ConfirmPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 64728, 64745);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 64207, 64935);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 64207, 64935);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool DoShouldProcess(
                    string verboseDescription,
                    string verboseWarning,
                    string caption,
                    out ShouldProcessReason shouldProcessReason)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 66733, 71334);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 66950, 66968);

                f_1291_66950_66967(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 66984, 67031);

                shouldProcessReason = ShouldProcessReason.None;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 67047, 67279);

                switch (lastShouldProcessContinueStatus)
                {

                    case ContinueStatus.NoToAll:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 67047, 67279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 67170, 67183);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 67047, 67279);

                    case ContinueStatus.YesToAll:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 67047, 67279);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 67252, 67264);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 67047, 67279);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 67295, 68594) || true) && (f_1291_67299_67305())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 67295, 68594);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 68152, 68184);

                    f_1291_68152_68183(this, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 68204, 68253);

                    shouldProcessReason = ShouldProcessReason.WhatIf;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 68271, 68425);

                    string
                    whatIfMessage =
                    f_1291_68315_68424(f_1291_68333_68378(), verboseDescription)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 68445, 68495);

                    f_1291_68445_68494(f_1291_68445_68462(CBhost), whatIfMessage);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 68513, 68548);

                    f_1291_68513_68547(f_1291_68513_68522(CBhost), whatIfMessage);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 68566, 68579);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 67295, 68594);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 68610, 69760) || true) && (f_1291_68614_68648(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 68610, 69760);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 68682, 69713) || true) && (f_1291_68686_68698(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 68682, 69713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 69605, 69637);

                        f_1291_69605_69636(this, false);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 69661, 69694);

                        f_1291_69661_69693(this, verboseDescription);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 68682, 69713);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 69733, 69745);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 68610, 69760);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 69776, 69960) || true) && (f_1291_69780_69816(verboseWarning))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 69776, 69960);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 69835, 69960);

                    verboseWarning = f_1291_69852_69959(f_1291_69870_69917(), verboseDescription);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 69776, 69960);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 70737, 70769);

                f_1291_70737_70768(this, false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 70785, 71087);

                lastShouldProcessContinueStatus = f_1291_70819_71086(this, verboseWarning, caption, true, true, false, false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 71103, 71295);

                switch (lastShouldProcessContinueStatus)
                {

                    case ContinueStatus.No:
                    case ContinueStatus.NoToAll:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 71103, 71295);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 71267, 71280);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 71103, 71295);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 71311, 71323);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 66733, 71334);

                int
                f_1291_66950_66967(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 66950, 66967);
                    return 0;
                }


                System.Management.Automation.SwitchParameter
                f_1291_67299_67305()
                {
                    var return_v = WhatIf;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 67299, 67305);
                    return return_v;
                }


                int
                f_1291_68152_68183(System.Management.Automation.MshCommandRuntime
                this_param, bool
                needsToWriteToPipeline)
                {
                    this_param.ThrowIfWriteNotPermitted(needsToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 68152, 68183);
                    return 0;
                }


                string
                f_1291_68333_68378()
                {
                    var return_v = CommandBaseStrings.ShouldProcessWhatIfMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 68333, 68378);
                    return return_v;
                }


                string
                f_1291_68315_68424(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 68315, 68424);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_68445_68462(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 68445, 68462);
                    return return_v;
                }


                int
                f_1291_68445_68494(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                resultText)
                {
                    this_param.TranscribeResult(resultText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 68445, 68494);
                    return 0;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1291_68513_68522(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 68513, 68522);
                    return return_v;
                }


                int
                f_1291_68513_68547(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                value)
                {
                    this_param.WriteLine(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 68513, 68547);
                    return 0;
                }


                bool
                f_1291_68614_68648(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.CanShouldProcessAutoConfirm();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 68614, 68648);
                    return return_v;
                }


                bool
                f_1291_68686_68698(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 68686, 68698);
                    return return_v;
                }


                int
                f_1291_69605_69636(System.Management.Automation.MshCommandRuntime
                this_param, bool
                needsToWriteToPipeline)
                {
                    this_param.ThrowIfWriteNotPermitted(needsToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 69605, 69636);
                    return 0;
                }


                int
                f_1291_69661_69693(System.Management.Automation.MshCommandRuntime
                this_param, string
                text)
                {
                    this_param.WriteVerbose(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 69661, 69693);
                    return 0;
                }


                bool
                f_1291_69780_69816(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 69780, 69816);
                    return return_v;
                }


                string
                f_1291_69870_69917()
                {
                    var return_v = CommandBaseStrings.ShouldProcessWarningFallback;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 69870, 69917);
                    return return_v;
                }


                string
                f_1291_69852_69959(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 69852, 69959);
                    return return_v;
                }


                int
                f_1291_70737_70768(System.Management.Automation.MshCommandRuntime
                this_param, bool
                needsToWriteToPipeline)
                {
                    this_param.ThrowIfWriteNotPermitted(needsToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 70737, 70768);
                    return 0;
                }


                System.Management.Automation.MshCommandRuntime.ContinueStatus
                f_1291_70819_71086(System.Management.Automation.MshCommandRuntime
                this_param, string
                inquireMessage, string
                inquireCaption, bool
                allowYesToAll, bool
                allowNoToAll, bool
                replaceNoWithHalt, bool
                hasSecurityImpact)
                {
                    var return_v = this_param.InquireHelper(inquireMessage, inquireCaption, allowYesToAll, allowNoToAll, replaceNoWithHalt, hasSecurityImpact);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 70819, 71086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 66733, 71334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 66733, 71334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal enum ShouldProcessPossibleOptimization
        {
            AutoYes_CanSkipShouldProcessCall,
            AutoYes_CanCallShouldProcessAsynchronously,

            AutoNo_CanCallShouldProcessAsynchronously,

            NoOptimizationPossible,
        }

        internal ShouldProcessPossibleOptimization CalculatePossibleShouldProcessOptimization()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 71628, 72398);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 71740, 71887) || true) && (f_1291_71744_71755(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 71740, 71887);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 71789, 71872);

                    return ShouldProcessPossibleOptimization.AutoNo_CanCallShouldProcessAsynchronously;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 71740, 71887);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 71903, 72307) || true) && (f_1291_71907_71941(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 71903, 72307);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 71975, 72292) || true) && (f_1291_71979_71991(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 71975, 72292);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 72033, 72117);

                        return ShouldProcessPossibleOptimization.AutoYes_CanCallShouldProcessAsynchronously;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 71975, 72292);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 71975, 72292);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 72199, 72273);

                        return ShouldProcessPossibleOptimization.AutoYes_CanSkipShouldProcessCall;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 71975, 72292);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 71903, 72307);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 72323, 72387);

                return ShouldProcessPossibleOptimization.NoOptimizationPossible;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 71628, 72398);

                System.Management.Automation.SwitchParameter
                f_1291_71744_71755(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.WhatIf;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 71744, 71755);
                    return return_v;
                }


                bool
                f_1291_71907_71941(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.CanShouldProcessAutoConfirm();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 71907, 71941);
                    return return_v;
                }


                bool
                f_1291_71979_71991(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.Verbose;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 71979, 71991);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 71628, 72398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 71628, 72398);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldContinue(string query, string caption)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 78469, 78770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 78550, 78572);

                bool
                yesToAll = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 78586, 78607);

                bool
                noToAll = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 78621, 78652);

                bool
                hasSecurityImpact = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 78666, 78759);

                return f_1291_78673_78758(this, query, caption, hasSecurityImpact, false, ref yesToAll, ref noToAll);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 78469, 78770);

                bool
                f_1291_78673_78758(System.Management.Automation.MshCommandRuntime
                this_param, string
                query, string
                caption, bool
                hasSecurityImpact, bool
                supportsToAllOptions, ref bool
                yesToAll, ref bool
                noToAll)
                {
                    var return_v = this_param.DoShouldContinue(query, caption, hasSecurityImpact, supportsToAllOptions, ref yesToAll, ref noToAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 78673, 78758);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 78469, 78770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 78469, 78770);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldContinue(
                    string query, string caption, bool hasSecurityImpact, ref bool yesToAll, ref bool noToAll)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 81205, 81464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 81361, 81453);

                return f_1291_81368_81452(this, query, caption, hasSecurityImpact, true, ref yesToAll, ref noToAll);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 81205, 81464);

                bool
                f_1291_81368_81452(System.Management.Automation.MshCommandRuntime
                this_param, string
                query, string
                caption, bool
                hasSecurityImpact, bool
                supportsToAllOptions, ref bool
                yesToAll, ref bool
                noToAll)
                {
                    var return_v = this_param.DoShouldContinue(query, caption, hasSecurityImpact, supportsToAllOptions, ref yesToAll, ref noToAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 81368, 81452);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 81205, 81464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 81205, 81464);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool ShouldContinue(
                    string query, string caption, ref bool yesToAll, ref bool noToAll)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 88082, 88305);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 88214, 88294);

                return f_1291_88221_88293(this, query, caption, false, true, ref yesToAll, ref noToAll);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 88082, 88305);

                bool
                f_1291_88221_88293(System.Management.Automation.MshCommandRuntime
                this_param, string
                query, string
                caption, bool
                hasSecurityImpact, bool
                supportsToAllOptions, ref bool
                yesToAll, ref bool
                noToAll)
                {
                    var return_v = this_param.DoShouldContinue(query, caption, hasSecurityImpact, supportsToAllOptions, ref yesToAll, ref noToAll);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 88221, 88293);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 88082, 88305);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 88082, 88305);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool DoShouldContinue(
                    string query,
                    string caption,
                    bool hasSecurityImpact,
                    bool supportsToAllOptions,
                    ref bool yesToAll,
                    ref bool noToAll)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 88317, 90152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 88568, 88586);

                f_1291_88568_88585(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 89217, 89249);

                f_1291_89217_89248(this, false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 89265, 89370) || true) && (noToAll)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 89265, 89370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 89295, 89308);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 89265, 89370);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 89265, 89370);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 89327, 89370) || true) && (yesToAll)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 89327, 89370);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 89358, 89370);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 89327, 89370);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 89265, 89370);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 89386, 89733);

                ContinueStatus
                continueStatus = f_1291_89418_89732(this, query, caption, supportsToAllOptions, supportsToAllOptions, false, hasSecurityImpact)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 89749, 90113);

                switch (continueStatus)
                {

                    case ContinueStatus.No:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 89749, 90113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 89850, 89863);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 89749, 90113);

                    case ContinueStatus.NoToAll:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 89749, 90113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 89933, 89948);

                        noToAll = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 89970, 89983);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 89749, 90113);

                    case ContinueStatus.YesToAll:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 89749, 90113);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 90054, 90070);

                        yesToAll = true;
                        DynAbs.Tracing.TraceSender.TraceBreak(1291, 90092, 90098);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 89749, 90113);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 90129, 90141);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 88317, 90152);

                int
                f_1291_88568_88585(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 88568, 88585);
                    return 0;
                }


                int
                f_1291_89217_89248(System.Management.Automation.MshCommandRuntime
                this_param, bool
                needsToWriteToPipeline)
                {
                    this_param.ThrowIfWriteNotPermitted(needsToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 89217, 89248);
                    return 0;
                }


                System.Management.Automation.MshCommandRuntime.ContinueStatus
                f_1291_89418_89732(System.Management.Automation.MshCommandRuntime
                this_param, string
                inquireMessage, string
                inquireCaption, bool
                allowYesToAll, bool
                allowNoToAll, bool
                replaceNoWithHalt, bool
                hasSecurityImpact)
                {
                    var return_v = this_param.InquireHelper(inquireMessage, inquireCaption, allowYesToAll, allowNoToAll, replaceNoWithHalt, hasSecurityImpact);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 89418, 89732);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 88317, 90152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 88317, 90152);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public bool TransactionAvailable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 90375, 90519);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 90434, 90508);

                return f_1291_90441_90462() && (DynAbs.Tracing.TraceSender.Expression_True(1291, 90441, 90507) && f_1291_90466_90507(f_1291_90466_90492(f_1291_90466_90473())));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 90375, 90519);

                bool
                f_1291_90441_90462()
                {
                    var return_v = UseTransactionFlagSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 90441, 90462);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1291_90466_90473()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 90466, 90473);
                    return return_v;
                }


                System.Management.Automation.Internal.PSTransactionManager
                f_1291_90466_90492(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TransactionManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 90466, 90492);
                    return return_v;
                }


                bool
                f_1291_90466_90507(System.Management.Automation.Internal.PSTransactionManager
                this_param)
                {
                    var return_v = this_param.HasTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 90466, 90507);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 90375, 90519);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 90375, 90519);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSTransactionContext CurrentPSTransaction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 90814, 91549);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 90850, 91454) || true) && (!f_1291_90855_90877(this))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 90850, 91454);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 90919, 90939);

                        string
                        error = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 90963, 91165) || true) && (f_1291_90967_90989_M(!UseTransactionFlagSet))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 90963, 91165);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 91016, 91063);

                            error = f_1291_91024_91062();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 90963, 91165);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 90963, 91165);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 91115, 91165);

                            error = f_1291_91123_91164();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 90963, 91165);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 91392, 91435);

                        throw f_1291_91398_91434(error);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 90850, 91454);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 91474, 91534);

                    return f_1291_91481_91533(f_1291_91506_91532(f_1291_91506_91513()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 90814, 91549);

                    bool
                    f_1291_90855_90877(System.Management.Automation.MshCommandRuntime
                    this_param)
                    {
                        var return_v = this_param.TransactionAvailable();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 90855, 90877);
                        return return_v;
                    }


                    bool
                    f_1291_90967_90989_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 90967, 90989);
                        return return_v;
                    }


                    string
                    f_1291_91024_91062()
                    {
                        var return_v = TransactionStrings.CmdletRequiresUseTx;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 91024, 91062);
                        return return_v;
                    }


                    string
                    f_1291_91123_91164()
                    {
                        var return_v = TransactionStrings.NoTransactionAvailable;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 91123, 91164);
                        return return_v;
                    }


                    System.InvalidOperationException
                    f_1291_91398_91434(string
                    message)
                    {
                        var return_v = new System.InvalidOperationException(message);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 91398, 91434);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1291_91506_91513()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 91506, 91513);
                        return return_v;
                    }


                    System.Management.Automation.Internal.PSTransactionManager
                    f_1291_91506_91532(System.Management.Automation.ExecutionContext
                    this_param)
                    {
                        var return_v = this_param.TransactionManager;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 91506, 91532);
                        return return_v;
                    }


                    System.Management.Automation.PSTransactionContext
                    f_1291_91481_91533(System.Management.Automation.Internal.PSTransactionManager
                    transactionManager)
                    {
                        var return_v = new System.Management.Automation.PSTransactionContext(transactionManager);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 91481, 91533);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 90741, 91560);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 90741, 91560);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        public void ThrowTerminatingError(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 93635, 95433);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 93718, 93736);

                f_1291_93718_93735(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 93750, 93882) || true) && (errorRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 93750, 93882);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 93807, 93867);

                    throw f_1291_93813_93866("errorRecord");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 93750, 93882);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 93898, 93942);

                f_1291_93898_93941(
                            errorRecord, f_1291_93928_93940());

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 93958, 94402) || true) && (f_1291_93962_93986(errorRecord) != null
                && (DynAbs.Tracing.TraceSender.Expression_True(1291, 93962, 94063) && f_1291_94015_94055(f_1291_94015_94039(errorRecord)) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 93958, 94402);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 94097, 94166);

                    Exception
                    textLookupError = f_1291_94125_94165(f_1291_94125_94149(errorRecord))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 94184, 94232);

                    f_1291_94184_94208(errorRecord).TextLookupError = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 94250, 94387);

                    f_1291_94250_94386(f_1291_94301_94308(), textLookupError, Severity.Warning);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 93958, 94402);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 94501, 94952) || true) && (f_1291_94505_94526(errorRecord) != null
                && (DynAbs.Tracing.TraceSender.Expression_True(1291, 94505, 94609) && f_1291_94555_94609(f_1291_94576_94608(f_1291_94576_94597(errorRecord)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 94501, 94952);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 94687, 94715);

                        throw f_1291_94693_94714(errorRecord);
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1291, 94752, 94937);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1291, 94752, 94937);
                        // no need to worry about severe exceptions since
                        // it wasn't really thrown originally
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 94501, 94952);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 94968, 95058);

                CmdletInvocationException
                e =
                f_1291_95015_95057(errorRecord)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 95190, 95327) || true) && (f_1291_95194_95205() == ActionPreference.Break)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 95190, 95327);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 95265, 95312);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1291_95265_95281(f_1291_95265_95272()), 1291, 95265, 95311).Break(f_1291_95289_95305(e) ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Exception>(1291, 95289, 95310) ?? e)), 1291, 95282, 95311);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 95190, 95327);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 95397, 95422);

                throw f_1291_95403_95421(this, e);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 93635, 95433);

                int
                f_1291_93718_93735(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 93718, 93735);
                    return 0;
                }


                System.Management.Automation.PSArgumentNullException
                f_1291_93813_93866(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 93813, 93866);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1291_93928_93940()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 93928, 93940);
                    return return_v;
                }


                int
                f_1291_93898_93941(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 93898, 93941);
                    return 0;
                }


                System.Management.Automation.ErrorDetails
                f_1291_93962_93986(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 93962, 93986);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1291_94015_94039(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 94015, 94039);
                    return return_v;
                }


                System.Exception
                f_1291_94015_94055(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.TextLookupError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 94015, 94055);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1291_94125_94149(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 94125, 94149);
                    return return_v;
                }


                System.Exception
                f_1291_94125_94165(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.TextLookupError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 94125, 94165);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1291_94184_94208(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 94184, 94208);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1291_94301_94308()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 94301, 94308);
                    return return_v;
                }


                int
                f_1291_94250_94386(System.Management.Automation.ExecutionContext
                executionContext, System.Exception
                exception, System.Management.Automation.Severity
                severity)
                {
                    MshLog.LogCommandHealthEvent(executionContext, exception, severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 94250, 94386);
                    return 0;
                }


                System.Exception
                f_1291_94505_94526(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 94505, 94526);
                    return return_v;
                }


                System.Exception
                f_1291_94576_94597(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 94576, 94597);
                    return return_v;
                }


                string
                f_1291_94576_94608(System.Exception
                this_param)
                {
                    var return_v = this_param.StackTrace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 94576, 94608);
                    return return_v;
                }


                bool
                f_1291_94555_94609(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 94555, 94609);
                    return return_v;
                }


                System.Exception
                f_1291_94693_94714(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 94693, 94714);
                    return return_v;
                }


                System.Management.Automation.CmdletInvocationException
                f_1291_95015_95057(System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    var return_v = new System.Management.Automation.CmdletInvocationException(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 95015, 95057);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1291_95194_95205()
                {
                    var return_v = ErrorAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 95194, 95205);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1291_95265_95272()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 95265, 95272);
                    return return_v;
                }


                System.Management.Automation.ScriptDebugger
                f_1291_95265_95281(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Debugger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 95265, 95281);
                    return return_v;
                }


                System.Exception
                f_1291_95289_95305(System.Management.Automation.CmdletInvocationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 95289, 95305);
                    return return_v;
                }


                System.Exception
                f_1291_95403_95421(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.CmdletInvocationException
                e)
                {
                    var return_v = this_param.ManageException((System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 95403, 95421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 93635, 95433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 93635, 95433);
            }
        }


        /// <summary>
        /// Data streams available for merging.
        /// </summary>
        internal enum MergeDataStream
        {
            /// <summary>
            /// No data stream available for merging.
            /// </summary>
            None = 0,

            /// <summary>
            /// All data streams.
            /// </summary>
            All = 1,

            /// <summary>
            /// Success output.
            /// </summary>
            Output = 2,

            /// <summary>
            /// Error output.
            /// </summary>
            Error = 3,

            /// <summary>
            /// Warning output.
            /// </summary>
            Warning = 4,

            /// <summary>
            /// Verbose output.
            /// </summary>
            Verbose = 5,

            /// <summary>
            /// Debug output.
            /// </summary>
            Debug = 6,

            /// <summary>
            /// Host output.
            /// </summary>
            Host = 7,

            /// <summary>
            /// Information output.
            /// </summary>
            Information = 8
        }

        internal MergeDataStream ErrorMergeTo { get; set; }

        internal void SetMergeFromRuntime(MshCommandRuntime fromRuntime)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 97077, 97872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 97166, 97211);

                this.ErrorMergeTo = f_1291_97186_97210(fromRuntime);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 97227, 97372) || true) && (f_1291_97231_97260(fromRuntime) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 97227, 97372);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 97302, 97357);

                    this.WarningOutputPipe = f_1291_97327_97356(fromRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 97227, 97372);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 97388, 97533) || true) && (f_1291_97392_97421(fromRuntime) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 97388, 97533);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 97463, 97518);

                    this.VerboseOutputPipe = f_1291_97488_97517(fromRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 97388, 97533);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 97549, 97688) || true) && (f_1291_97553_97580(fromRuntime) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 97549, 97688);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 97622, 97673);

                    this.DebugOutputPipe = f_1291_97645_97672(fromRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 97549, 97688);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 97704, 97861) || true) && (f_1291_97708_97741(fromRuntime) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 97704, 97861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 97783, 97846);

                    this.InformationOutputPipe = f_1291_97812_97845(fromRuntime);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 97704, 97861);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 97077, 97872);

                System.Management.Automation.MshCommandRuntime.MergeDataStream
                f_1291_97186_97210(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorMergeTo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 97186, 97210);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_97231_97260(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.WarningOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 97231, 97260);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_97327_97356(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.WarningOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 97327, 97356);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_97392_97421(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.VerboseOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 97392, 97421);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_97488_97517(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.VerboseOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 97488, 97517);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_97553_97580(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.DebugOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 97553, 97580);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_97645_97672(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.DebugOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 97645, 97672);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_97708_97741(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.InformationOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 97708, 97741);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_97812_97845(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.InformationOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 97812, 97845);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 97077, 97872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 97077, 97872);
            }
        }

        internal bool MergeUnclaimedPreviousErrorResults { get; set; }

        internal Pipe InputPipe
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 98338, 98393);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 98344, 98391);

                    return _inputPipe ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Internal.Pipe>(1291, 98351, 98390) ?? (_inputPipe = f_1291_98379_98389()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 98338, 98393);

                    System.Management.Automation.Internal.Pipe
                    f_1291_98379_98389()
                    {
                        var return_v = new System.Management.Automation.Internal.Pipe();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 98379, 98389);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 98290, 98447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 98290, 98447);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 98409, 98436);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 98415, 98434);

                    _inputPipe = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 98409, 98436);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 98290, 98447);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 98290, 98447);
                }
            }
        }

        internal Pipe OutputPipe
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 98598, 98655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 98604, 98653);

                    return _outputPipe ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Internal.Pipe>(1291, 98611, 98652) ?? (_outputPipe = f_1291_98641_98651()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 98598, 98655);

                    System.Management.Automation.Internal.Pipe
                    f_1291_98641_98651()
                    {
                        var return_v = new System.Management.Automation.Internal.Pipe();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 98641, 98651);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 98549, 98710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 98549, 98710);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 98671, 98699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 98677, 98697);

                    _outputPipe = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 98671, 98699);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 98549, 98710);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 98549, 98710);
                }
            }
        }

        internal object[] GetResultsAsArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 98722, 98904);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 98784, 98850) || true) && (_outputPipe == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 98784, 98850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 98826, 98850);

                    return StaticEmptyArray;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 98784, 98850);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 98864, 98893);

                return f_1291_98871_98892(_outputPipe);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 98722, 98904);

                object[]
                f_1291_98871_98892(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 98871, 98892);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 98722, 98904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 98722, 98904);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static object[] StaticEmptyArray;

        internal Pipe ErrorOutputPipe
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 99303, 99370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 99309, 99368);

                    return _errorOutputPipe ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.Internal.Pipe>(1291, 99316, 99367) ?? (_errorOutputPipe = f_1291_99356_99366()));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 99303, 99370);

                    System.Management.Automation.Internal.Pipe
                    f_1291_99356_99366()
                    {
                        var return_v = new System.Management.Automation.Internal.Pipe();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 99356, 99366);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 99249, 99430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 99249, 99430);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 99386, 99419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 99392, 99417);

                    _errorOutputPipe = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 99386, 99419);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 99249, 99430);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 99249, 99430);
                }
            }
        }

        internal Pipe WarningOutputPipe { get; set; }

        internal Pipe VerboseOutputPipe { get; set; }

        internal Pipe DebugOutputPipe { get; set; }

        internal Pipe InformationOutputPipe { get; set; }

        internal void ThrowIfStopping()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 100318, 100455);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 100374, 100444) || true) && (f_1291_100378_100388())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 100374, 100444);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 100407, 100444);

                    throw f_1291_100413_100443();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 100374, 100444);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 100318, 100455);

                bool
                f_1291_100378_100388()
                {
                    var return_v = IsStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 100378, 100388);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1291_100413_100443()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 100413, 100443);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 100318, 100455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 100318, 100455);
            }
        }

        internal void ThrowIfWriteNotPermitted(bool needsToWriteToPipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 100784, 101689);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 100876, 101678) || true) && (f_1291_100880_100902(this) == null
                || (DynAbs.Tracing.TraceSender.Expression_False(1291, 100880, 100987) || _thisCommand != f_1291_100947_100969(this)._permittedToWrite
                ) || (DynAbs.Tracing.TraceSender.Expression_False(1291, 100880, 101085) || needsToWriteToPipeline && (DynAbs.Tracing.TraceSender.Expression_True(1291, 101008, 101085) && !f_1291_101035_101057(this)._permittedToWriteToPipeline
                )) || (DynAbs.Tracing.TraceSender.Expression_False(1291, 100880, 101176) || f_1291_101106_101126() != f_1291_101130_101152(this)._permittedToWriteThread
                ))
                               )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 100876, 101678);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 101439, 101663) || true) && (DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(f_1291_101443_101465(this), 1291, 101443, 101484)?._permittedToWrite != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 101439, 101663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 101534, 101644);

                        throw f_1291_101540_101643(f_1291_101609_101642());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 101439, 101663);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 100876, 101678);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 100784, 101689);

                System.Management.Automation.Internal.PipelineProcessor
                f_1291_100880_100902(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 100880, 100902);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1291_100947_100969(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 100947, 100969);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1291_101035_101057(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 101035, 101057);
                    return return_v;
                }


                System.Threading.Thread
                f_1291_101106_101126()
                {
                    var return_v = Thread.CurrentThread;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 101106, 101126);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1291_101130_101152(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 101130, 101152);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1291_101443_101465(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 101443, 101465);
                    return return_v;
                }


                string
                f_1291_101609_101642()
                {
                    var return_v = PipelineStrings.WriteNotPermitted;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 101609, 101642);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1291_101540_101643(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 101540, 101643);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 100784, 101689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 100784, 101689);
            }
        }

        internal IDisposable AllowThisCommandToWrite(bool permittedToWriteToPipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 102007, 102184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 102109, 102173);

                return f_1291_102116_102172(_thisCommand, permittedToWriteToPipeline);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 102007, 102184);

                System.Management.Automation.MshCommandRuntime.AllowWrite
                f_1291_102116_102172(System.Management.Automation.Internal.InternalCommand
                permittedToWrite, bool
                permittedToWriteToPipeline)
                {
                    var return_v = new System.Management.Automation.MshCommandRuntime.AllowWrite(permittedToWrite, permittedToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 102116, 102172);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 102007, 102184);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 102007, 102184);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
        private class AllowWrite : IDisposable
        {
            internal AllowWrite(InternalCommand permittedToWrite, bool permittedToWriteToPipeline)
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterConstructor(1291, 102390, 103499);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 104322, 104332);
                    this._pp = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 104371, 104398);
                    this._wasPermittedToWrite = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 104426, 104464);
                    this._wasPermittedToWriteToPipeline = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 104494, 104527);
                    this._wasPermittedToWriteThread = null;
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 102509, 102625) || true) && (permittedToWrite == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 102509, 102625);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 102560, 102625);

                        throw f_1291_102566_102624("permittedToWrite");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 102509, 102625);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 102643, 102720);

                    MshCommandRuntime
                    mcr = permittedToWrite.commandRuntime as MshCommandRuntime
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 102738, 102856) || true) && (mcr == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 102738, 102856);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 102776, 102856);

                        throw f_1291_102782_102855("permittedToWrite.CommandRuntime");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 102738, 102856);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 102874, 102902);

                    _pp = f_1291_102880_102901(mcr);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 102920, 103056) || true) && (_pp == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 102920, 103056);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 102958, 103056);

                        throw f_1291_102964_103055("permittedToWrite.CommandRuntime.PipelineProcessor");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 102920, 103056);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 103074, 103119);

                    _wasPermittedToWrite = _pp._permittedToWrite;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 103137, 103202);

                    _wasPermittedToWriteToPipeline = _pp._permittedToWriteToPipeline;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 103220, 103277);

                    _wasPermittedToWriteThread = _pp._permittedToWriteThread;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 103295, 103336);

                    _pp._permittedToWrite = permittedToWrite;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 103354, 103415);

                    _pp._permittedToWriteToPipeline = permittedToWriteToPipeline;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 103433, 103484);

                    _pp._permittedToWriteThread = f_1291_103463_103483();
                    DynAbs.Tracing.TraceSender.TraceExitConstructor(1291, 102390, 103499);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 102390, 103499);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 102390, 103499);
                }
            }

            public void Dispose()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 103814, 104130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 103868, 103913);

                    _pp._permittedToWrite = _wasPermittedToWrite;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 103931, 103996);

                    _pp._permittedToWriteToPipeline = _wasPermittedToWriteToPipeline;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 104014, 104071);

                    _pp._permittedToWriteThread = _wasPermittedToWriteThread;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 104089, 104115);

                    f_1291_104089_104114(this);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 103814, 104130);

                    int
                    f_1291_104089_104114(System.Management.Automation.MshCommandRuntime.AllowWrite
                    obj)
                    {
                        GC.SuppressFinalize((object)obj);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 104089, 104114);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 103814, 104130);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 103814, 104130);
                }
            }

            private PipelineProcessor _pp;

            private InternalCommand _wasPermittedToWrite;

            private bool _wasPermittedToWriteToPipeline;

            private Thread _wasPermittedToWriteThread;

            static AllowWrite()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1291, 102196, 104539);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1291, 102196, 104539);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 102196, 104539);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1291, 102196, 104539);

            System.Management.Automation.PSArgumentNullException
            f_1291_102566_102624(string
            paramName)
            {
                var return_v = PSTraceSource.NewArgumentNullException(paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 102566, 102624);
                return return_v;
            }


            System.Management.Automation.PSArgumentNullException
            f_1291_102782_102855(string
            paramName)
            {
                var return_v = PSTraceSource.NewArgumentNullException(paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 102782, 102855);
                return return_v;
            }


            System.Management.Automation.Internal.PipelineProcessor
            f_1291_102880_102901(System.Management.Automation.MshCommandRuntime
            this_param)
            {
                var return_v = this_param.PipelineProcessor;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 102880, 102901);
                return return_v;
            }


            System.Management.Automation.PSArgumentNullException
            f_1291_102964_103055(string
            paramName)
            {
                var return_v = PSTraceSource.NewArgumentNullException(paramName);
                DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 102964, 103055);
                return return_v;
            }


            System.Threading.Thread
            f_1291_103463_103483()
            {
                var return_v = Thread.CurrentThread;
                DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 103463, 103483);
                return return_v;
            }

        }

        public Exception ManageException(Exception e)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 104946, 106455);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 105016, 105098) || true) && (e == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 105016, 105098);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 105048, 105098);

                    throw f_1291_105054_105097("e");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 105016, 105098);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 105114, 105241) || true) && (f_1291_105118_105135() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 105114, 105241);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 105177, 105226);

                    f_1291_105177_105225(f_1291_105177_105194(), e, _thisCommand);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 105114, 105241);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 105710, 106325) || true) && (!(e is HaltCommandException) && (DynAbs.Tracing.TraceSender.Expression_True(1291, 105714, 105778) && !(e is PipelineStoppedException)) && (DynAbs.Tracing.TraceSender.Expression_True(1291, 105714, 105815) && !(e is ExitNestedPromptException)) && (DynAbs.Tracing.TraceSender.Expression_True(1291, 105714, 105856) && !(e is StopUpstreamCommandsException)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 105710, 106325);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 105934, 105960);

                        f_1291_105934_105959(this, e);
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1291, 105997, 106118);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1291, 105997, 106118);
                        // Catch all OK, the error variables might be corrupted.
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 106187, 106310);

                    f_1291_106187_106309(f_1291_106238_106245(), e, Severity.Warning);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 105710, 106325);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 106406, 106444);

                return f_1291_106413_106443();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 104946, 106455);

                System.Management.Automation.PSArgumentNullException
                f_1291_105054_105097(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 105054, 105097);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1291_105118_105135()
                {
                    var return_v = PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 105118, 105135);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1291_105177_105194()
                {
                    var return_v = PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 105177, 105194);
                    return return_v;
                }


                bool
                f_1291_105177_105225(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Exception
                e, System.Management.Automation.Internal.InternalCommand
                command)
                {
                    var return_v = this_param.RecordFailure(e, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 105177, 105225);
                    return return_v;
                }


                int
                f_1291_105934_105959(System.Management.Automation.MshCommandRuntime
                this_param, System.Exception
                obj)
                {
                    this_param.AppendErrorToVariables((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 105934, 105959);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1291_106238_106245()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 106238, 106245);
                    return return_v;
                }


                int
                f_1291_106187_106309(System.Management.Automation.ExecutionContext
                executionContext, System.Exception
                exception, System.Management.Automation.Severity
                severity)
                {
                    MshLog.LogCommandHealthEvent(executionContext, exception, severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 106187, 106309);
                    return 0;
                }


                System.Management.Automation.PipelineStoppedException
                f_1291_106413_106443()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 106413, 106443);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 104946, 106455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 104946, 106455);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IList _errorVarList;

        internal string ErrorVariable { get; set; }

        internal void SetupErrorVariable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 106951, 107100);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 107010, 107089);

                f_1291_107010_107088(this, VariableStreamKind.Error, f_1291_107050_107068(this), ref _errorVarList);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 106951, 107100);

                string
                f_1291_107050_107068(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 107050, 107068);
                    return return_v;
                }


                int
                f_1291_107010_107088(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.Internal.VariableStreamKind
                streamKind, string
                variableName, ref System.Collections.IList
                varList)
                {
                    this_param.SetupVariable(streamKind, variableName, ref varList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 107010, 107088);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 106951, 107100);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 106951, 107100);
            }
        }

        private void EnsureVariableParameterAllowed()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 107112, 107681);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 107182, 107670) || true) && ((f_1291_107187_107207(f_1291_107187_107194()) == PSLanguageMode.NoLanguage) || (DynAbs.Tracing.TraceSender.Expression_False(1291, 107186, 107317) || (f_1291_107259_107279(f_1291_107259_107266()) == PSLanguageMode.RestrictedLanguage)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 107182, 107670);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 107351, 107655);

                    throw f_1291_107357_107654(null, typeof(RuntimeException), null, "VariableReferenceNotSupportedInDataSection", f_1291_107524_107580(), f_1291_107603_107653());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 107182, 107670);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 107112, 107681);

                System.Management.Automation.ExecutionContext
                f_1291_107187_107194()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 107187, 107194);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1291_107187_107207(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 107187, 107207);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1291_107259_107266()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 107259, 107266);
                    return return_v;
                }


                System.Management.Automation.PSLanguageMode
                f_1291_107259_107279(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.LanguageMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 107259, 107279);
                    return return_v;
                }


                string
                f_1291_107524_107580()
                {
                    var return_v = ParserStrings.VariableReferenceNotSupportedInDataSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 107524, 107580);
                    return return_v;
                }


                string
                f_1291_107603_107653()
                {
                    var return_v = ParserStrings.DefaultAllowedVariablesInDataSection;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 107603, 107653);
                    return return_v;
                }


                System.Management.Automation.RuntimeException
                f_1291_107357_107654(object
                targetObject, System.Type
                exceptionType, System.Management.Automation.Language.IScriptExtent
                errorPosition, string
                resourceIdAndErrorId, string
                resourceString, params object[]
                args)
                {
                    var return_v = InterpreterError.NewInterpreterException(targetObject, exceptionType, errorPosition, resourceIdAndErrorId, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 107357, 107654);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 107112, 107681);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 107112, 107681);
            }
        }

        internal void AppendErrorToVariables(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 108079, 108325);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 108152, 108193) || true) && (obj == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 108152, 108193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 108186, 108193);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 108152, 108193);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 108209, 108232);

                f_1291_108209_108231(this, obj);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 108248, 108314);

                f_1291_108248_108313(f_1291_108248_108263(this), VariableStreamKind.Error, obj);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 108079, 108325);

                int
                f_1291_108209_108231(System.Management.Automation.MshCommandRuntime
                this_param, object
                obj)
                {
                    this_param.AppendDollarError(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 108209, 108231);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_108248_108263(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 108248, 108263);
                    return return_v;
                }


                int
                f_1291_108248_108313(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.VariableStreamKind
                kind, object
                obj)
                {
                    this_param.AppendVariableList(kind, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 108248, 108313);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 108079, 108325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 108079, 108325);
            }
        }

        private void AppendDollarError(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 109016, 109333);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 109083, 109275) || true) && (obj is Exception)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 109083, 109275);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 109137, 109237) || true) && (f_1291_109141_109163(this) == null || (DynAbs.Tracing.TraceSender.Expression_False(1291, 109141, 109207) || f_1291_109175_109207_M(!f_1291_109176_109198(this).TopLevel)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 109137, 109237);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 109230, 109237);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 109137, 109237);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 109083, 109275);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 109291, 109322);

                f_1291_109291_109321(f_1291_109291_109298(), obj);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 109016, 109333);

                System.Management.Automation.Internal.PipelineProcessor
                f_1291_109141_109163(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 109141, 109163);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1291_109176_109198(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 109176, 109198);
                    return return_v;
                }


                bool
                f_1291_109175_109207_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 109175, 109207);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1291_109291_109298()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 109291, 109298);
                    return return_v;
                }


                int
                f_1291_109291_109321(System.Management.Automation.ExecutionContext
                this_param, object
                obj)
                {
                    this_param.AppendDollarError(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 109291, 109321);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 109016, 109333);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 109016, 109333);
            }
        }

        private IList _warningVarList;

        internal string WarningVariable { get; set; }

        internal void SetupWarningVariable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 109839, 109996);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 109900, 109985);

                f_1291_109900_109984(this, VariableStreamKind.Warning, f_1291_109942_109962(this), ref _warningVarList);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 109839, 109996);

                string
                f_1291_109942_109962(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.WarningVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 109942, 109962);
                    return return_v;
                }


                int
                f_1291_109900_109984(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.Internal.VariableStreamKind
                streamKind, string
                variableName, ref System.Collections.IList
                varList)
                {
                    this_param.SetupVariable(streamKind, variableName, ref varList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 109900, 109984);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 109839, 109996);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 109839, 109996);
            }
        }

        internal void AppendWarningVarList(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 110178, 110328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 110249, 110317);

                f_1291_110249_110316(f_1291_110249_110264(this), VariableStreamKind.Warning, obj);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 110178, 110328);

                System.Management.Automation.Internal.Pipe
                f_1291_110249_110264(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 110249, 110264);
                    return return_v;
                }


                int
                f_1291_110249_110316(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.VariableStreamKind
                kind, object
                obj)
                {
                    this_param.AppendVariableList(kind, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 110249, 110316);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 110178, 110328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 110178, 110328);
            }
        }

        private IList _informationVarList;

        internal string InformationVariable { get; set; }

        internal void SetupInformationVariable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 110860, 111033);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 110925, 111022);

                f_1291_110925_111021(this, VariableStreamKind.Information, f_1291_110971_110995(this), ref _informationVarList);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 110860, 111033);

                string
                f_1291_110971_110995(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.InformationVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 110971, 110995);
                    return return_v;
                }


                int
                f_1291_110925_111021(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.Internal.VariableStreamKind
                streamKind, string
                variableName, ref System.Collections.IList
                varList)
                {
                    this_param.SetupVariable(streamKind, variableName, ref varList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 110925, 111021);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 110860, 111033);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 110860, 111033);
            }
        }

        internal void SetupVariable(VariableStreamKind streamKind, string variableName, ref IList varList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 111045, 113010);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 111168, 111262) || true) && (f_1291_111172_111206(variableName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 111168, 111262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 111240, 111247);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 111168, 111262);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 111278, 111311);

                f_1291_111278_111310(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 111327, 111418) || true) && (_state == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 111327, 111418);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 111364, 111418);

                    _state = f_1291_111373_111417(f_1291_111390_111416(f_1291_111390_111397()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 111327, 111418);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 111434, 112783) || true) && (f_1291_111438_111466(variableName, '+'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 111434, 112783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 111500, 111541);

                    variableName = f_1291_111515_111540(variableName, 1);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 111559, 111633);

                    object
                    oldValue = f_1291_111577_111632(f_1291_111591_111631(f_1291_111591_111608(_state), variableName))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 111651, 111679);

                    varList = oldValue as IList;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 111697, 112676) || true) && (varList == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 111697, 112676);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 111758, 111784);

                        varList = f_1291_111768_111783();

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 111808, 112417) || true) && (oldValue != null && (DynAbs.Tracing.TraceSender.Expression_True(1291, 111812, 111864) && f_1291_111832_111852() != oldValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 111808, 112417);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 111914, 111982);

                            IEnumerable
                            enumerable = f_1291_111939_111981(oldValue)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 112008, 112394) || true) && (enumerable != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 112008, 112394);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 112088, 112231);
                                    foreach (object o in f_1291_112109_112119_I(enumerable))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 112088, 112231);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 112185, 112200);

                                        f_1291_112185_112199(varList, o);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 112088, 112231);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1291, 1, 144);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1291, 1, 144);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 112008, 112394);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 112008, 112394);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 112345, 112367);

                                f_1291_112345_112366(varList, oldValue);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 112008, 112394);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 111808, 112417);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 111697, 112676);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 111697, 112676);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 112459, 112676) || true) && (f_1291_112463_112482(varList))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 112459, 112676);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 112524, 112563);

                            ArrayList
                            varListNew = f_1291_112547_112562()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 112585, 112614);

                            f_1291_112585_112613(varListNew, varList);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 112636, 112657);

                            varList = varListNew;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 112459, 112676);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 111697, 112676);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 111434, 112783);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 111434, 112783);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 112742, 112768);

                    varList = f_1291_112752_112767();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 111434, 112783);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 112799, 112938) || true) && (!(_thisCommand is PSScriptCmdlet))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 112799, 112938);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 112870, 112923);

                    f_1291_112870_112922(f_1291_112870_112885(this), streamKind, varList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 112799, 112938);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 112954, 112999);

                f_1291_112954_112998(f_1291_112954_112971(_state), variableName, varList);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 111045, 113010);

                bool
                f_1291_111172_111206(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 111172, 111206);
                    return return_v;
                }


                int
                f_1291_111278_111310(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.EnsureVariableParameterAllowed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 111278, 111310);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1291_111390_111397()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 111390, 111397);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1291_111390_111416(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineSessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 111390, 111416);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1291_111373_111417(System.Management.Automation.SessionStateInternal
                sessionState)
                {
                    var return_v = new System.Management.Automation.SessionState(sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 111373, 111417);
                    return return_v;
                }


                bool
                f_1291_111438_111466(string
                this_param, char
                value)
                {
                    var return_v = this_param.StartsWith(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 111438, 111466);
                    return return_v;
                }


                string
                f_1291_111515_111540(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 111515, 111540);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1291_111591_111608(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 111591, 111608);
                    return return_v;
                }


                object
                f_1291_111591_111631(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name)
                {
                    var return_v = this_param.GetValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 111591, 111631);
                    return return_v;
                }


                object
                f_1291_111577_111632(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 111577, 111632);
                    return return_v;
                }


                System.Collections.ArrayList
                f_1291_111768_111783()
                {
                    var return_v = new System.Collections.ArrayList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 111768, 111783);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1291_111832_111852()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 111832, 111852);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1291_111939_111981(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 111939, 111981);
                    return return_v;
                }


                int
                f_1291_112185_112199(System.Collections.IList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 112185, 112199);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1291_112109_112119_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 112109, 112119);
                    return return_v;
                }


                int
                f_1291_112345_112366(System.Collections.IList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 112345, 112366);
                    return return_v;
                }


                bool
                f_1291_112463_112482(System.Collections.IList
                this_param)
                {
                    var return_v = this_param.IsFixedSize;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 112463, 112482);
                    return return_v;
                }


                System.Collections.ArrayList
                f_1291_112547_112562()
                {
                    var return_v = new System.Collections.ArrayList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 112547, 112562);
                    return return_v;
                }


                int
                f_1291_112585_112613(System.Collections.ArrayList
                this_param, System.Collections.IList
                c)
                {
                    this_param.AddRange((System.Collections.ICollection)c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 112585, 112613);
                    return 0;
                }


                System.Collections.ArrayList
                f_1291_112752_112767()
                {
                    var return_v = new System.Collections.ArrayList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 112752, 112767);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_112870_112885(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 112870, 112885);
                    return return_v;
                }


                int
                f_1291_112870_112922(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.VariableStreamKind
                kind, System.Collections.IList
                list)
                {
                    this_param.AddVariableList(kind, list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 112870, 112922);
                    return 0;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1291_112954_112971(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 112954, 112971);
                    return return_v;
                }


                int
                f_1291_112954_112998(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name, System.Collections.IList
                value)
                {
                    this_param.Set(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 112954, 112998);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 111045, 113010);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 111045, 113010);
            }
        }

        internal void AppendInformationVarList(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 113204, 113362);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 113279, 113351);

                f_1291_113279_113350(f_1291_113279_113294(this), VariableStreamKind.Information, obj);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 113204, 113362);

                System.Management.Automation.Internal.Pipe
                f_1291_113279_113294(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 113279, 113294);
                    return return_v;
                }


                int
                f_1291_113279_113350(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.VariableStreamKind
                kind, object
                obj)
                {
                    this_param.AppendVariableList(kind, obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 113279, 113350);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 113204, 113362);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 113204, 113362);
            }
        }

        internal bool UseSecurityContextRun;

        internal void _WriteObjectSkipAllowCheck(object sendToPipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 114134, 114472);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 114222, 114240);

                f_1291_114222_114239(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 114256, 114324) || true) && (f_1291_114260_114280() == sendToPipeline)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 114256, 114324);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 114317, 114324);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 114256, 114324);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 114340, 114409);

                sendToPipeline = f_1291_114357_114408(sendToPipeline);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 114425, 114461);

                f_1291_114425_114460(f_1291_114425_114440(this), sendToPipeline);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 114134, 114472);

                int
                f_1291_114222_114239(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 114222, 114239);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1291_114260_114280()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 114260, 114280);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1291_114357_114408(object
                obj)
                {
                    var return_v = LanguagePrimitives.AsPSObjectOrNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 114357, 114408);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_114425_114440(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 114425, 114440);
                    return return_v;
                }


                int
                f_1291_114425_114460(System.Management.Automation.Internal.Pipe
                this_param, object
                obj)
                {
                    this_param.Add(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 114425, 114460);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 114134, 114472);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 114134, 114472);
            }
        }

        internal void _EnumerateAndWriteObjectSkipAllowCheck(object sendToPipeline)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 115150, 116089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 115250, 115324);

                IEnumerable
                enumerable = f_1291_115275_115323(sendToPipeline)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 115338, 115477) || true) && (enumerable == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 115338, 115477);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 115394, 115437);

                    f_1291_115394_115436(this, sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 115455, 115462);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 115338, 115477);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 115493, 115511);

                f_1291_115493_115510(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 115527, 115569);

                ArrayList
                convertedList = f_1291_115553_115568()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 115583, 115911);
                    foreach (object toConvert in f_1291_115612_115622_I(enumerable))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 115583, 115911);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 115656, 115763) || true) && (f_1291_115660_115680() == toConvert)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 115656, 115763);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 115735, 115744);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 115656, 115763);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 115783, 115849);

                        object
                        converted = f_1291_115802_115848(toConvert)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 115867, 115896);

                        f_1291_115867_115895(convertedList, converted);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 115583, 115911);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1291, 1, 329);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1291, 1, 329);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 116038, 116078);

                f_1291_116038_116077(f_1291_116038_116053(this), convertedList);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 115150, 116089);

                System.Collections.IEnumerable
                f_1291_115275_115323(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 115275, 115323);
                    return return_v;
                }


                int
                f_1291_115394_115436(System.Management.Automation.MshCommandRuntime
                this_param, object
                sendToPipeline)
                {
                    this_param._WriteObjectSkipAllowCheck(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 115394, 115436);
                    return 0;
                }


                int
                f_1291_115493_115510(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 115493, 115510);
                    return 0;
                }


                System.Collections.ArrayList
                f_1291_115553_115568()
                {
                    var return_v = new System.Collections.ArrayList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 115553, 115568);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1291_115660_115680()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 115660, 115680);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1291_115802_115848(object
                obj)
                {
                    var return_v = LanguagePrimitives.AsPSObjectOrNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 115802, 115848);
                    return return_v;
                }


                int
                f_1291_115867_115895(System.Collections.ArrayList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 115867, 115895);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1291_115612_115622_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 115612, 115622);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_116038_116053(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 116038, 116053);
                    return return_v;
                }


                int
                f_1291_116038_116077(System.Management.Automation.Internal.Pipe
                this_param, System.Collections.ArrayList
                objects)
                {
                    this_param.AddItems((object)objects);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 116038, 116077);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 115150, 116089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 115150, 116089);
            }
        }

        public void WriteError(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 117988, 118102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 118060, 118091);

                f_1291_118060_118090(this, errorRecord, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 117988, 118102);

                int
                f_1291_118060_118090(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ErrorRecord
                errorRecord, bool
                overrideInquire)
                {
                    this_param.WriteError(errorRecord, overrideInquire);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 118060, 118090);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 117988, 118102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 117988, 118102);
            }
        }

        internal void WriteError(ErrorRecord errorRecord, bool overrideInquire)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 118114, 119872);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 118452, 118470);

                f_1291_118452_118469(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 118486, 118528);

                ActionPreference
                preference = f_1291_118516_118527()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 118542, 118691) || true) && (overrideInquire && (DynAbs.Tracing.TraceSender.Expression_True(1291, 118546, 118603) && preference == ActionPreference.Inquire))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 118542, 118691);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 118637, 118676);

                    preference = ActionPreference.Continue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 118542, 118691);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 118760, 118896) || true) && (preference == ActionPreference.Break)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 118760, 118896);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 118834, 118881);

                    //f_1291_118834_118880_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(CBhost, 1291, 118834, 118880) ? f_1291_118841_118880_M(DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(.Runspace, 1291, 118841, 118880) ? DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => DynAbs.Tracing.TraceSender.TraceConditionalAccessExpression(.Debugger, 1291, 118851, 118880)?.Break(errorRecord), 1291, 118861, 118880)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 118760, 118896);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 118985, 119072);

                f_1291_118985_119071(this, f_1291_118998_119070(errorRecord, preference));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 118114, 119872);

                int
                f_1291_118452_118469(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 118452, 118469);
                    return 0;
                }


                System.Management.Automation.ActionPreference
                f_1291_118516_118527()
                {
                    var return_v = ErrorAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 118516, 118527);
                    return return_v;
                }

                System.Collections.Generic.KeyValuePair<System.Management.Automation.ErrorRecord, System.Management.Automation.ActionPreference>
                f_1291_118998_119070(System.Management.Automation.ErrorRecord
                key, System.Management.Automation.ActionPreference
                value)
                {
                    var return_v = new System.Collections.Generic.KeyValuePair<System.Management.Automation.ErrorRecord, System.Management.Automation.ActionPreference>(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 118998, 119070);
                    return return_v;
                }


                int
                f_1291_118985_119071(System.Management.Automation.MshCommandRuntime
                this_param, System.Collections.Generic.KeyValuePair<System.Management.Automation.ErrorRecord, System.Management.Automation.ActionPreference>
                obj)
                {
                    this_param.DoWriteError((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 118985, 119071);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 118114, 119872);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 118114, 119872);
            }
        }

        private void DoWriteError(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 120821, 122250);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 120883, 120983);

                KeyValuePair<ErrorRecord, ActionPreference>
                pair = (KeyValuePair<ErrorRecord, ActionPreference>)obj
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 120997, 121032);

                ErrorRecord
                errorRecord = pair.Key
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 121046, 121087);

                ActionPreference
                preference = pair.Value
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 121101, 121233) || true) && (errorRecord == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 121101, 121233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 121158, 121218);

                    throw f_1291_121164_121217("errorRecord");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 121101, 121233);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 121351, 121727) || true) && (f_1291_121355_121369())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 121351, 121727);

                    if (
                    (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 121403, 121712) || true) && ((f_1291_121429_121474(f_1291_121429_121455(f_1291_121429_121436())) != RollbackSeverity.TerminatingError) && (DynAbs.Tracing.TraceSender.Expression_True(1291, 121428, 121609) && (f_1291_121537_121582(f_1291_121537_121563(f_1291_121537_121544())) != RollbackSeverity.Never)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 121403, 121712);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 121651, 121693);

                        f_1291_121651_121692(f_1291_121651_121677(f_1291_121651_121658()), true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 121403, 121712);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 121351, 121727);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 121891, 122079) || true) && (f_1291_121895_121933(errorRecord))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 121891, 122079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 121952, 121999);

                    errorRecord.PreserveInvocationInfoOnce = false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 121891, 122079);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 121891, 122079);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 122035, 122079);

                    f_1291_122035_122078(errorRecord, f_1291_122065_122077());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 121891, 122079);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 122141, 122172);

                f_1291_122141_122171(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 122188, 122239);

                f_1291_122188_122238(this, errorRecord, preference);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 120821, 122250);

                System.Management.Automation.PSArgumentNullException
                f_1291_121164_121217(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 121164, 121217);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1291_121355_121369()
                {
                    var return_v = UseTransaction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 121355, 121369);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1291_121429_121436()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 121429, 121436);
                    return return_v;
                }


                System.Management.Automation.Internal.PSTransactionManager
                f_1291_121429_121455(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TransactionManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 121429, 121455);
                    return return_v;
                }


                System.Management.Automation.RollbackSeverity
                f_1291_121429_121474(System.Management.Automation.Internal.PSTransactionManager
                this_param)
                {
                    var return_v = this_param.RollbackPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 121429, 121474);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1291_121537_121544()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 121537, 121544);
                    return return_v;
                }


                System.Management.Automation.Internal.PSTransactionManager
                f_1291_121537_121563(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TransactionManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 121537, 121563);
                    return return_v;
                }


                System.Management.Automation.RollbackSeverity
                f_1291_121537_121582(System.Management.Automation.Internal.PSTransactionManager
                this_param)
                {
                    var return_v = this_param.RollbackPreference;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 121537, 121582);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1291_121651_121658()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 121651, 121658);
                    return return_v;
                }


                System.Management.Automation.Internal.PSTransactionManager
                f_1291_121651_121677(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.TransactionManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 121651, 121677);
                    return return_v;
                }


                int
                f_1291_121651_121692(System.Management.Automation.Internal.PSTransactionManager
                this_param, bool
                suppressErrors)
                {
                    this_param.Rollback(suppressErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 121651, 121692);
                    return 0;
                }


                bool
                f_1291_121895_121933(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.PreserveInvocationInfoOnce;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 121895, 121933);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1291_122065_122077()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 122065, 122077);
                    return return_v;
                }


                int
                f_1291_122035_122078(System.Management.Automation.ErrorRecord
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    this_param.SetInvocationInfo(invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 122035, 122078);
                    return 0;
                }


                int
                f_1291_122141_122171(System.Management.Automation.MshCommandRuntime
                this_param, bool
                needsToWriteToPipeline)
                {
                    this_param.ThrowIfWriteNotPermitted(needsToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 122141, 122171);
                    return 0;
                }


                int
                f_1291_122188_122238(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ErrorRecord
                errorRecord, System.Management.Automation.ActionPreference
                actionPreference)
                {
                    this_param._WriteErrorSkipAllowCheck(errorRecord, (System.Management.Automation.ActionPreference?)actionPreference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 122188, 122238);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 120821, 122250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 120821, 122250);
            }
        }

        internal void _WriteErrorSkipAllowCheck(ErrorRecord errorRecord, ActionPreference? actionPreference = null, bool isNativeError = false)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 123162, 127943);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 123322, 123340);

                f_1291_123322_123339(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 123356, 123800) || true) && (f_1291_123360_123384(errorRecord) != null
                && (DynAbs.Tracing.TraceSender.Expression_True(1291, 123360, 123461) && f_1291_123413_123453(f_1291_123413_123437(errorRecord)) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 123356, 123800);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 123495, 123564);

                    Exception
                    textLookupError = f_1291_123523_123563(f_1291_123523_123547(errorRecord))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 123582, 123630);

                    f_1291_123582_123606(errorRecord).TextLookupError = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 123648, 123785);

                    f_1291_123648_123784(f_1291_123699_123706(), textLookupError, Severity.Warning);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 123356, 123800);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 123816, 123862);

                f_1291_123816_123838(this).ExecutionFailed = true;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 123876, 124036) || true) && (f_1291_123880_123906())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 123876, 124036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 123940, 124021);

                    f_1291_123940_124020(f_1291_123940_123962(this), f_1291_123981_124006(_thisCommand), errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 123876, 124036);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 124052, 124094);

                ActionPreference
                preference = f_1291_124082_124093()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 124108, 124222) || true) && (f_1291_124112_124137(actionPreference))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 124108, 124222);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 124171, 124207);

                    preference = f_1291_124184_124206(actionPreference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 124108, 124222);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 124297, 124435) || true) && (ActionPreference.Ignore == preference)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 124297, 124435);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 124372, 124379);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 124297, 124435);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 124554, 124746) || true) && (ActionPreference.SilentlyContinue == preference)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 124554, 124746);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 124639, 124675);

                    f_1291_124639_124674(this, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 124693, 124700);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 124554, 124746);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 124762, 124904) || true) && (ContinueStatus.YesToAll == lastErrorContinueStatus)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 124762, 124904);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 124850, 124889);

                    preference = ActionPreference.Continue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 124762, 124904);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 124920, 126083);

                switch (preference)
                {

                    case ActionPreference.Stop:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 124920, 126083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 125021, 125431);

                        ActionPreferenceStopException
                        e =
                        f_1291_125080_125430(f_1291_125144_125156(), errorRecord, f_1291_125229_125429(f_1291_125247_125285(), "ErrorActionPreference", f_1291_125406_125428(errorRecord)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 125453, 125478);

                        throw f_1291_125459_125477(this, e);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 124920, 126083);

                    case ActionPreference.Inquire:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 124920, 126083);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 125670, 126040);

                        lastErrorContinueStatus = f_1291_125696_126039(this, f_1291_125736_125781(errorRecord), null, true, false, true, false);
                        DynAbs.Tracing.TraceSender.TraceBreak(1291, 126062, 126068);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 124920, 126083);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 126215, 126251);

                f_1291_126215_126250(this, errorRecord);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 126473, 126527);

                PSObject
                errorWrap = f_1291_126494_126526(errorRecord)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 126790, 126903) || true) && (!isNativeError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 126790, 126903);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 126842, 126888);

                    errorWrap.WriteStream = WriteStreamType.Error;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 126790, 126903);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 127166, 127932) || true) && (f_1291_127170_127182() != MergeDataStream.None)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 127166, 127932);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 127240, 127339);

                    f_1291_127240_127338(f_1291_127251_127263() == MergeDataStream.Output, "Only merging to success output is supported.");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 127357, 127414);

                    f_1291_127357_127413(f_1291_127357_127372(this), errorWrap);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 127166, 127932);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 127166, 127932);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 127644, 127835) || true) && (f_1291_127648_127686(f_1291_127648_127671(f_1291_127648_127668(f_1291_127648_127655()))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 127644, 127835);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 127728, 127816);

                        f_1291_127728_127815(f_1291_127728_127751(f_1291_127728_127748(f_1291_127728_127735())), f_1291_127768_127775(), f_1291_127777_127803(errorRecord), errorWrap);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 127644, 127835);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 127855, 127917);

                    f_1291_127855_127916(f_1291_127855_127875(this), errorWrap);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 127166, 127932);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 123162, 127943);

                int
                f_1291_123322_123339(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 123322, 123339);
                    return 0;
                }


                System.Management.Automation.ErrorDetails
                f_1291_123360_123384(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 123360, 123384);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1291_123413_123437(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 123413, 123437);
                    return return_v;
                }


                System.Exception
                f_1291_123413_123453(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.TextLookupError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 123413, 123453);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1291_123523_123547(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 123523, 123547);
                    return return_v;
                }


                System.Exception
                f_1291_123523_123563(System.Management.Automation.ErrorDetails
                this_param)
                {
                    var return_v = this_param.TextLookupError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 123523, 123563);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1291_123582_123606(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ErrorDetails;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 123582, 123606);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1291_123699_123706()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 123699, 123706);
                    return return_v;
                }


                int
                f_1291_123648_123784(System.Management.Automation.ExecutionContext
                executionContext, System.Exception
                exception, System.Management.Automation.Severity
                severity)
                {
                    MshLog.LogCommandHealthEvent(executionContext, exception, severity);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 123648, 123784);
                    return 0;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1291_123816_123838(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 123816, 123838);
                    return return_v;
                }


                bool
                f_1291_123880_123906()
                {
                    var return_v = LogPipelineExecutionDetail;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 123880, 123906);
                    return return_v;
                }


                System.Management.Automation.Internal.PipelineProcessor
                f_1291_123940_123962(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 123940, 123962);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1291_123981_124006(System.Management.Automation.Internal.InternalCommand
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 123981, 124006);
                    return return_v;
                }


                int
                f_1291_123940_124020(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.LogExecutionError(invocationInfo, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 123940, 124020);
                    return 0;
                }


                System.Management.Automation.ActionPreference
                f_1291_124082_124093()
                {
                    var return_v = ErrorAction;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 124082, 124093);
                    return return_v;
                }


                bool
                f_1291_124112_124137(System.Management.Automation.ActionPreference?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 124112, 124137);
                    return return_v;
                }


                System.Management.Automation.ActionPreference
                f_1291_124184_124206(System.Management.Automation.ActionPreference?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 124184, 124206);
                    return return_v;
                }


                int
                f_1291_124639_124674(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ErrorRecord
                obj)
                {
                    this_param.AppendErrorToVariables((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 124639, 124674);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1291_125144_125156()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 125144, 125156);
                    return return_v;
                }


                string
                f_1291_125247_125285()
                {
                    var return_v = CommandBaseStrings.ErrorPreferenceStop;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 125247, 125285);
                    return return_v;
                }


                string
                f_1291_125406_125428(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 125406, 125428);
                    return return_v;
                }


                string
                f_1291_125229_125429(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 125229, 125429);
                    return return_v;
                }


                System.Management.Automation.ActionPreferenceStopException
                f_1291_125080_125430(System.Management.Automation.InvocationInfo
                invocationInfo, System.Management.Automation.ErrorRecord
                errorRecord, string
                message)
                {
                    var return_v = new System.Management.Automation.ActionPreferenceStopException(invocationInfo, errorRecord, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 125080, 125430);
                    return return_v;
                }


                System.Exception
                f_1291_125459_125477(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ActionPreferenceStopException
                e)
                {
                    var return_v = this_param.ManageException((System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 125459, 125477);
                    return return_v;
                }


                string
                f_1291_125736_125781(System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    var return_v = RuntimeException.RetrieveMessage(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 125736, 125781);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime.ContinueStatus
                f_1291_125696_126039(System.Management.Automation.MshCommandRuntime
                this_param, string
                inquireMessage, string
                inquireCaption, bool
                allowYesToAll, bool
                allowNoToAll, bool
                replaceNoWithHalt, bool
                hasSecurityImpact)
                {
                    var return_v = this_param.InquireHelper(inquireMessage, inquireCaption, allowYesToAll, allowNoToAll, replaceNoWithHalt, hasSecurityImpact);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 125696, 126039);
                    return return_v;
                }


                int
                f_1291_126215_126250(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ErrorRecord
                obj)
                {
                    this_param.AppendErrorToVariables((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 126215, 126250);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1291_126494_126526(System.Management.Automation.ErrorRecord
                obj)
                {
                    var return_v = PSObject.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 126494, 126526);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime.MergeDataStream
                f_1291_127170_127182()
                {
                    var return_v = ErrorMergeTo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 127170, 127182);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime.MergeDataStream
                f_1291_127251_127263()
                {
                    var return_v = ErrorMergeTo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 127251, 127263);
                    return return_v;
                }


                int
                f_1291_127240_127338(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 127240, 127338);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_127357_127372(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 127357, 127372);
                    return return_v;
                }


                int
                f_1291_127357_127413(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.PSObject
                obj)
                {
                    this_param.AddWithoutAppendingOutVarList((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 127357, 127413);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1291_127648_127655()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 127648, 127655);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1291_127648_127668(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 127648, 127668);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1291_127648_127671(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 127648, 127671);
                    return return_v;
                }


                bool
                f_1291_127648_127686(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.IsTranscribing;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 127648, 127686);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1291_127728_127735()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 127728, 127735);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1291_127728_127748(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.InternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 127728, 127748);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1291_127728_127751(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 127728, 127751);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1291_127768_127775()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 127768, 127775);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1291_127777_127803(System.Management.Automation.ErrorRecord
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 127777, 127803);
                    return return_v;
                }


                int
                f_1291_127728_127815(System.Management.Automation.Host.PSHostUserInterface
                this_param, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.InvocationInfo
                invocation, System.Management.Automation.PSObject
                errorWrap)
                {
                    this_param.TranscribeError(context, invocation, errorWrap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 127728, 127815);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_127855_127875(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.ErrorOutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 127855, 127875);
                    return return_v;
                }


                int
                f_1291_127855_127916(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.PSObject
                obj)
                {
                    this_param.AddWithoutAppendingOutVarList((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 127855, 127916);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 123162, 127943);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 123162, 127943);
            }
        }

        private bool _isConfirmPreferenceCached;

        private ConfirmImpact _confirmPreference;

        internal ConfirmImpact ConfirmPreference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 128904, 129821);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129017, 129076) || true) && (f_1291_129021_129028())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 129017, 129076);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129051, 129076);

                        return ConfirmImpact.Low;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 129017, 129076);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129094, 129310) || true) && (f_1291_129098_129103())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 129094, 129310);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129145, 129244) || true) && (f_1291_129149_129165())
                        ) // -Debug -Confirm:$false

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 129145, 129244);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129218, 129244);

                            return ConfirmImpact.None;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 129145, 129244);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129266, 129291);

                        return ConfirmImpact.Low;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 129094, 129310);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129330, 129418) || true) && (f_1291_129334_129350())
                    ) // -Confirm:$false

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 129330, 129418);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129392, 129418);

                        return ConfirmImpact.None;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 129330, 129418);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129438, 129760) || true) && (!_isConfirmPreferenceCached)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 129438, 129760);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129511, 129536);

                        bool
                        defaultUsed = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129558, 129685);

                        _confirmPreference = f_1291_129579_129684(f_1291_129579_129586(), SpecialVariables.ConfirmPreferenceVarPath, _confirmPreference, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129707, 129741);

                        _isConfirmPreferenceCached = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 129438, 129760);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 129780, 129806);

                    return _confirmPreference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 128904, 129821);

                    System.Management.Automation.SwitchParameter
                    f_1291_129021_129028()
                    {
                        var return_v = Confirm;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 129021, 129028);
                        return return_v;
                    }


                    bool
                    f_1291_129098_129103()
                    {
                        var return_v = Debug;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 129098, 129103);
                        return return_v;
                    }


                    bool
                    f_1291_129149_129165()
                    {
                        var return_v = IsConfirmFlagSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 129149, 129165);
                        return return_v;
                    }


                    bool
                    f_1291_129334_129350()
                    {
                        var return_v = IsConfirmFlagSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 129334, 129350);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1291_129579_129586()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 129579, 129586);
                        return return_v;
                    }


                    System.Management.Automation.ConfirmImpact
                    f_1291_129579_129684(System.Management.Automation.ExecutionContext
                    this_param, System.Management.Automation.VariablePath
                    preferenceVariablePath, System.Management.Automation.ConfirmImpact
                    defaultPref, out bool
                    defaultUsed)
                    {
                        var return_v = this_param.GetEnumPreference<System.Management.Automation.ConfirmImpact>(preferenceVariablePath, defaultPref, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 129579, 129684);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 128839, 129832);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 128839, 129832);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _isDebugPreferenceSet;

        private ActionPreference _debugPreference;

        private bool _isDebugPreferenceCached;

        internal ActionPreference DebugPreference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 130381, 131545);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 130417, 130527) || true) && (_isDebugPreferenceSet)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 130417, 130527);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 130484, 130508);

                        return _debugPreference;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 130417, 130527);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 130547, 130703) || true) && (f_1291_130551_130565())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 130547, 130703);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 130607, 130684);

                        return (DynAbs.Tracing.TraceSender.Conditional_F1(1291, 130614, 130619) || ((f_1291_130614_130619() && DynAbs.Tracing.TraceSender.Conditional_F2(1291, 130622, 130647)) || DynAbs.Tracing.TraceSender.Conditional_F3(1291, 130650, 130683))) ? ActionPreference.Continue : ActionPreference.SilentlyContinue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 130547, 130703);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 130723, 131486) || true) && (!_isDebugPreferenceCached)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 130723, 131486);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 130794, 130819);

                        bool
                        defaultUsed = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 130843, 130964);

                        _debugPreference = f_1291_130862_130963(f_1291_130862_130869(), SpecialVariables.DebugPreferenceVarPath, _debugPreference, out defaultUsed);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 131207, 131411) || true) && ((f_1291_131212_131234(f_1291_131212_131231(CBhost)) == null) && (DynAbs.Tracing.TraceSender.Expression_True(1291, 131211, 131293) && (_debugPreference == ActionPreference.Inquire)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 131207, 131411);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 131343, 131388);

                            _debugPreference = ActionPreference.Continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 131207, 131411);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 131435, 131467);

                        _isDebugPreferenceCached = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 130723, 131486);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 131506, 131530);

                    return _debugPreference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 130381, 131545);

                    bool
                    f_1291_130551_130565()
                    {
                        var return_v = IsDebugFlagSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 130551, 130565);
                        return return_v;
                    }


                    bool
                    f_1291_130614_130619()
                    {
                        var return_v = Debug;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 130614, 130619);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1291_130862_130869()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 130862, 130869);
                        return return_v;
                    }


                    System.Management.Automation.ActionPreference
                    f_1291_130862_130963(System.Management.Automation.ExecutionContext
                    this_param, System.Management.Automation.VariablePath
                    preferenceVariablePath, System.Management.Automation.ActionPreference
                    defaultPref, out bool
                    defaultUsed)
                    {
                        var return_v = this_param.GetEnumPreference<System.Management.Automation.ActionPreference>(preferenceVariablePath, defaultPref, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 130862, 130963);
                        return return_v;
                    }


                    System.Management.Automation.Host.PSHost
                    f_1291_131212_131231(System.Management.Automation.Internal.Host.InternalHost
                    this_param)
                    {
                        var return_v = this_param.ExternalHost;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 131212, 131231);
                        return return_v;
                    }


                    System.Management.Automation.Host.PSHostUserInterface
                    f_1291_131212_131234(System.Management.Automation.Host.PSHost
                    this_param)
                    {
                        var return_v = this_param.UI;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 131212, 131234);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 130315, 131921);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 130315, 131921);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 131561, 131910);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 131597, 131803) || true) && (value == ActionPreference.Suspend)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 131597, 131803);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 131676, 131784);

                        throw f_1291_131682_131783(f_1291_131721_131775(), value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 131597, 131803);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 131823, 131848);

                    _debugPreference = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 131866, 131895);

                    _isDebugPreferenceSet = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 131561, 131910);

                    string
                    f_1291_131721_131775()
                    {
                        var return_v = ErrorPackage.ActionPreferenceReservedForFutureUseError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 131721, 131775);
                        return return_v;
                    }


                    System.Management.Automation.PSNotSupportedException
                    f_1291_131682_131783(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 131682, 131783);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 130315, 131921);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 130315, 131921);
                }
            }
        }

        private bool _isVerbosePreferenceCached;

        private ActionPreference _verbosePreference;

        internal ActionPreference VerbosePreference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 132416, 133690);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 132452, 132697) || true) && (f_1291_132456_132472())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 132452, 132697);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 132514, 132678) || true) && (f_1291_132518_132525())
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 132514, 132678);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 132552, 132585);

                            return ActionPreference.Continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 132514, 132678);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 132514, 132678);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 132637, 132678);

                            return ActionPreference.SilentlyContinue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 132514, 132678);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 132452, 132697);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 132717, 133267) || true) && (f_1291_132721_132726())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 132717, 133267);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 132978, 133248) || true) && (f_1291_132982_133004(f_1291_132982_133001(CBhost)) == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 132978, 133248);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 133062, 133095);

                            return ActionPreference.Continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 132978, 133248);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 132978, 133248);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 133193, 133225);

                            return ActionPreference.Inquire;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 132978, 133248);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 132717, 133267);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 133287, 133629) || true) && (!_isVerbosePreferenceCached)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 133287, 133629);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 133360, 133385);

                        bool
                        defaultUsed = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 133407, 133610);

                        _verbosePreference = f_1291_133428_133609(f_1291_133428_133435(), SpecialVariables.VerbosePreferenceVarPath, _verbosePreference, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 133287, 133629);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 133649, 133675);

                    return _verbosePreference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 132416, 133690);

                    bool
                    f_1291_132456_132472()
                    {
                        var return_v = IsVerboseFlagSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 132456, 132472);
                        return return_v;
                    }


                    bool
                    f_1291_132518_132525()
                    {
                        var return_v = Verbose;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 132518, 132525);
                        return return_v;
                    }


                    bool
                    f_1291_132721_132726()
                    {
                        var return_v = Debug;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 132721, 132726);
                        return return_v;
                    }


                    System.Management.Automation.Host.PSHost
                    f_1291_132982_133001(System.Management.Automation.Internal.Host.InternalHost
                    this_param)
                    {
                        var return_v = this_param.ExternalHost;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 132982, 133001);
                        return return_v;
                    }


                    System.Management.Automation.Host.PSHostUserInterface
                    f_1291_132982_133004(System.Management.Automation.Host.PSHost
                    this_param)
                    {
                        var return_v = this_param.UI;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 132982, 133004);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1291_133428_133435()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 133428, 133435);
                        return return_v;
                    }


                    System.Management.Automation.ActionPreference
                    f_1291_133428_133609(System.Management.Automation.ExecutionContext
                    this_param, System.Management.Automation.VariablePath
                    preferenceVariablePath, System.Management.Automation.ActionPreference
                    defaultPref, out bool
                    defaultUsed)
                    {
                        var return_v = this_param.GetEnumPreference<System.Management.Automation.ActionPreference>(preferenceVariablePath, defaultPref, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 133428, 133609);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 132348, 133701);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 132348, 133701);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool IsWarningActionSet { get; private set; }

        private bool _isWarningPreferenceCached;

        private ActionPreference _warningPreference;

        internal ActionPreference WarningPreference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 134271, 135034);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 134387, 134458) || true) && (f_1291_134391_134409())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 134387, 134458);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 134432, 134458);

                        return _warningPreference;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 134387, 134458);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 134478, 134542) || true) && (f_1291_134482_134487())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 134478, 134542);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 134510, 134542);

                        return ActionPreference.Inquire;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 134478, 134542);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 134560, 134627) || true) && (f_1291_134564_134571())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 134560, 134627);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 134594, 134627);

                        return ActionPreference.Continue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 134560, 134627);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 134707, 134973) || true) && (!_isWarningPreferenceCached)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 134707, 134973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 134780, 134805);

                        bool
                        defaultUsed = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 134827, 134954);

                        _warningPreference = f_1291_134848_134953(f_1291_134848_134855(), SpecialVariables.WarningPreferenceVarPath, _warningPreference, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 134707, 134973);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 134993, 135019);

                    return _warningPreference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 134271, 135034);

                    bool
                    f_1291_134391_134409()
                    {
                        var return_v = IsWarningActionSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 134391, 134409);
                        return return_v;
                    }


                    bool
                    f_1291_134482_134487()
                    {
                        var return_v = Debug;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 134482, 134487);
                        return return_v;
                    }


                    bool
                    f_1291_134564_134571()
                    {
                        var return_v = Verbose;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 134564, 134571);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1291_134848_134855()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 134848, 134855);
                        return return_v;
                    }


                    System.Management.Automation.ActionPreference
                    f_1291_134848_134953(System.Management.Automation.ExecutionContext
                    this_param, System.Management.Automation.VariablePath
                    preferenceVariablePath, System.Management.Automation.ActionPreference
                    defaultPref, out bool
                    defaultUsed)
                    {
                        var return_v = this_param.GetEnumPreference<System.Management.Automation.ActionPreference>(preferenceVariablePath, defaultPref, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 134848, 134953);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 134203, 135409);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 134203, 135409);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 135050, 135398);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 135086, 135292) || true) && (value == ActionPreference.Suspend)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 135086, 135292);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 135165, 135273);

                        throw f_1291_135171_135272(f_1291_135210_135264(), value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 135086, 135292);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 135312, 135339);

                    _warningPreference = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 135357, 135383);

                    IsWarningActionSet = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 135050, 135398);

                    string
                    f_1291_135210_135264()
                    {
                        var return_v = ErrorPackage.ActionPreferenceReservedForFutureUseError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 135210, 135264);
                        return return_v;
                    }


                    System.Management.Automation.PSNotSupportedException
                    f_1291_135171_135272(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 135171, 135272);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 134203, 135409);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 134203, 135409);
                }
            }
        }

        private bool _verboseFlag;

        internal bool Verbose
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 135997, 136025);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 136003, 136023);

                    return _verboseFlag;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 135997, 136025);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 135951, 136166);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 135951, 136166);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 136041, 136155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 136077, 136098);

                    _verboseFlag = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 136116, 136140);

                    IsVerboseFlagSet = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 136041, 136155);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 135951, 136166);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 135951, 136166);
                }
            }
        }

        internal bool IsVerboseFlagSet { get; private set; }

        private bool _confirmFlag;

        internal SwitchParameter Confirm
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 136608, 136679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 136644, 136664);

                    return _confirmFlag;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 136608, 136679);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 136551, 136820);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 136551, 136820);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 136695, 136809);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 136731, 136752);

                    _confirmFlag = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 136770, 136794);

                    IsConfirmFlagSet = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 136695, 136809);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 136551, 136820);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 136551, 136820);
                }
            }
        }

        internal bool IsConfirmFlagSet { get; private set; }

        private bool _useTransactionFlag;

        internal SwitchParameter UseTransaction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 137283, 137361);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 137319, 137346);

                    return _useTransactionFlag;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 137283, 137361);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 137219, 137514);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 137219, 137514);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 137377, 137503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 137413, 137441);

                    _useTransactionFlag = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 137459, 137488);

                    UseTransactionFlagSet = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 137377, 137503);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 137219, 137514);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 137219, 137514);
                }
            }
        }

        internal bool UseTransactionFlagSet { get; private set; }

        private bool _debugFlag;

        internal bool Debug
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 138287, 138313);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 138293, 138311);

                    return _debugFlag;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 138287, 138313);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 138243, 138450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 138243, 138450);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 138329, 138439);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 138365, 138384);

                    _debugFlag = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 138402, 138424);

                    IsDebugFlagSet = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 138329, 138439);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 138243, 138450);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 138243, 138450);
                }
            }
        }

        internal bool IsDebugFlagSet { get; private set; }

        private bool _whatIfFlag;

        private bool _isWhatIfPreferenceCached /* = false */;

        internal SwitchParameter WhatIf
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 139028, 139446);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 139064, 139392) || true) && (f_1291_139068_139084_M(!IsWhatIfFlagSet) && (DynAbs.Tracing.TraceSender.Expression_True(1291, 139068, 139114) && !_isWhatIfPreferenceCached))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 139064, 139392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 139156, 139181);

                        bool
                        defaultUsed = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 139203, 139318);

                        _whatIfFlag = f_1291_139217_139317(f_1291_139217_139224(), SpecialVariables.WhatIfPreferenceVarPath, _whatIfFlag, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 139340, 139373);

                        _isWhatIfPreferenceCached = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 139064, 139392);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 139412, 139431);

                    return _whatIfFlag;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 139028, 139446);

                    bool
                    f_1291_139068_139084_M(bool
                    i)
                    {
                        var return_v = i;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 139068, 139084);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1291_139217_139224()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 139217, 139224);
                        return return_v;
                    }


                    bool
                    f_1291_139217_139317(System.Management.Automation.ExecutionContext
                    this_param, System.Management.Automation.VariablePath
                    preferenceVariablePath, bool
                    defaultPref, out bool
                    defaultUsed)
                    {
                        var return_v = this_param.GetBooleanPreference(preferenceVariablePath, defaultPref, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 139217, 139317);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 138972, 139585);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 138972, 139585);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 139462, 139574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 139498, 139518);

                    _whatIfFlag = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 139536, 139559);

                    IsWhatIfFlagSet = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 139462, 139574);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 138972, 139585);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 138972, 139585);
                }
            }
        }

        internal bool IsWhatIfFlagSet { get; private set; }

        private ActionPreference _errorAction;

        private bool _isErrorActionPreferenceCached;

        internal ActionPreference ErrorAction
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 140302, 140876);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 140416, 140479) || true) && (f_1291_140420_140436())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 140416, 140479);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 140459, 140479);

                        return _errorAction;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 140416, 140479);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 140499, 140821) || true) && (!_isErrorActionPreferenceCached)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 140499, 140821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 140576, 140601);

                        bool
                        defaultUsed = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 140623, 140742);

                        _errorAction = f_1291_140638_140741(f_1291_140638_140645(), SpecialVariables.ErrorActionPreferenceVarPath, _errorAction, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 140764, 140802);

                        _isErrorActionPreferenceCached = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 140499, 140821);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 140841, 140861);

                    return _errorAction;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 140302, 140876);

                    bool
                    f_1291_140420_140436()
                    {
                        var return_v = IsErrorActionSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 140420, 140436);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1291_140638_140645()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 140638, 140645);
                        return return_v;
                    }


                    System.Management.Automation.ActionPreference
                    f_1291_140638_140741(System.Management.Automation.ExecutionContext
                    this_param, System.Management.Automation.VariablePath
                    preferenceVariablePath, System.Management.Automation.ActionPreference
                    defaultPref, out bool
                    defaultUsed)
                    {
                        var return_v = this_param.GetEnumPreference<System.Management.Automation.ActionPreference>(preferenceVariablePath, defaultPref, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 140638, 140741);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 140240, 141243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 140240, 141243);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 140892, 141232);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 140928, 141134) || true) && (value == ActionPreference.Suspend)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 140928, 141134);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 141007, 141115);

                        throw f_1291_141013_141114(f_1291_141052_141106(), value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 140928, 141134);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 141154, 141175);

                    _errorAction = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 141193, 141217);

                    IsErrorActionSet = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 140892, 141232);

                    string
                    f_1291_141052_141106()
                    {
                        var return_v = ErrorPackage.ActionPreferenceReservedForFutureUseError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 141052, 141106);
                        return return_v;
                    }


                    System.Management.Automation.PSNotSupportedException
                    f_1291_141013_141114(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 141013, 141114);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 140240, 141243);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 140240, 141243);
                }
            }
        }

        internal bool IsErrorActionSet { get; private set; }

        internal ActionPreference ProgressPreference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 141566, 142089);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 141602, 141680) || true) && (_isProgressPreferenceSet)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 141602, 141680);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 141653, 141680);

                        return _progressPreference;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 141602, 141680);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 141700, 142027) || true) && (!_isProgressPreferenceCached)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 141700, 142027);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 141774, 141799);

                        bool
                        defaultUsed = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 141821, 141951);

                        _progressPreference = f_1291_141843_141950(f_1291_141843_141850(), SpecialVariables.ProgressPreferenceVarPath, _progressPreference, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 141973, 142008);

                        _isProgressPreferenceCached = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 141700, 142027);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 142047, 142074);

                    return _progressPreference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 141566, 142089);

                    System.Management.Automation.ExecutionContext
                    f_1291_141843_141850()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 141843, 141850);
                        return return_v;
                    }


                    System.Management.Automation.ActionPreference
                    f_1291_141843_141950(System.Management.Automation.ExecutionContext
                    this_param, System.Management.Automation.VariablePath
                    preferenceVariablePath, System.Management.Automation.ActionPreference
                    defaultPref, out bool
                    defaultUsed)
                    {
                        var return_v = this_param.GetEnumPreference<System.Management.Automation.ActionPreference>(preferenceVariablePath, defaultPref, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 141843, 141950);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 141497, 142471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 141497, 142471);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 142105, 142460);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 142141, 142347) || true) && (value == ActionPreference.Suspend)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 142141, 142347);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 142220, 142328);

                        throw f_1291_142226_142327(f_1291_142265_142319(), value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 142141, 142347);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 142367, 142395);

                    _progressPreference = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 142413, 142445);

                    _isProgressPreferenceSet = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 142105, 142460);

                    string
                    f_1291_142265_142319()
                    {
                        var return_v = ErrorPackage.ActionPreferenceReservedForFutureUseError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 142265, 142319);
                        return return_v;
                    }


                    System.Management.Automation.PSNotSupportedException
                    f_1291_142226_142327(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 142226, 142327);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 141497, 142471);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 141497, 142471);
                }
            }
        }

        private ActionPreference _progressPreference;

        private bool _isProgressPreferenceSet;

        private bool _isProgressPreferenceCached;

        internal ActionPreference InformationPreference
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 142950, 143492);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 142986, 143065) || true) && (f_1291_142990_143012())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 142986, 143065);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 143035, 143065);

                        return _informationPreference;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 142986, 143065);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 143085, 143427) || true) && (!_isInformationPreferenceCached)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 143085, 143427);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 143162, 143187);

                        bool
                        defaultUsed = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 143209, 143348);

                        _informationPreference = f_1291_143234_143347(f_1291_143234_143241(), SpecialVariables.InformationPreferenceVarPath, _informationPreference, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 143370, 143408);

                        _isInformationPreferenceCached = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 143085, 143427);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 143447, 143477);

                    return _informationPreference;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 142950, 143492);

                    bool
                    f_1291_142990_143012()
                    {
                        var return_v = IsInformationActionSet;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 142990, 143012);
                        return return_v;
                    }


                    System.Management.Automation.ExecutionContext
                    f_1291_143234_143241()
                    {
                        var return_v = Context;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 143234, 143241);
                        return return_v;
                    }


                    System.Management.Automation.ActionPreference
                    f_1291_143234_143347(System.Management.Automation.ExecutionContext
                    this_param, System.Management.Automation.VariablePath
                    preferenceVariablePath, System.Management.Automation.ActionPreference
                    defaultPref, out bool
                    defaultUsed)
                    {
                        var return_v = this_param.GetEnumPreference<System.Management.Automation.ActionPreference>(preferenceVariablePath, defaultPref, out defaultUsed);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 143234, 143347);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 142878, 143875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 142878, 143875);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 143508, 143864);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 143544, 143750) || true) && (value == ActionPreference.Suspend)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 143544, 143750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 143623, 143731);

                        throw f_1291_143629_143730(f_1291_143668_143722(), value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 143544, 143750);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 143770, 143801);

                    _informationPreference = value;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 143819, 143849);

                    IsInformationActionSet = true;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 143508, 143864);

                    string
                    f_1291_143668_143722()
                    {
                        var return_v = ErrorPackage.ActionPreferenceReservedForFutureUseError;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 143668, 143722);
                        return return_v;
                    }


                    System.Management.Automation.PSNotSupportedException
                    f_1291_143629_143730(string
                    resourceString, params object[]
                    args)
                    {
                        var return_v = PSTraceSource.NewNotSupportedException(resourceString, args);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 143629, 143730);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 142878, 143875);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 142878, 143875);
                }
            }
        }

        private ActionPreference _informationPreference;

        internal bool IsInformationActionSet { get; private set; }

        private bool _isInformationPreferenceCached;

        internal PagingParameters PagingParameters { get; set; }




        /// <summary>
        /// ContinueStatus indicates the last reply from the user
        /// whether or not the command should process an object.
        /// </summary>
        internal enum ContinueStatus
        {
            Yes,
            No,
            YesToAll,
            NoToAll
        };

        internal ContinueStatus lastShouldProcessContinueStatus;

        internal ContinueStatus lastErrorContinueStatus;

        internal ContinueStatus lastDebugContinueStatus;

        internal ContinueStatus lastVerboseContinueStatus;

        internal ContinueStatus lastWarningContinueStatus;

        internal ContinueStatus lastProgressContinueStatus;

        internal ContinueStatus lastInformationContinueStatus;

        internal bool WriteHelper_ShouldWrite(
                    ActionPreference preference,
                    ContinueStatus lastContinueStatus)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 145627, 147484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 145780, 145798);

                f_1291_145780_145797(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 146575, 146607);

                f_1291_146575_146606(this, false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 146623, 146906);

                switch (lastContinueStatus)
                {

                    case ContinueStatus.NoToAll:  // previously answered NoToAll
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 146623, 146906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 146765, 146778);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 146623, 146906);

                    case ContinueStatus.YesToAll: // previously answered YesToAll
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 146623, 146906);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 146879, 146891);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 146623, 146906);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 146922, 147473);

                switch (preference)
                {

                    case ActionPreference.Ignore:
                    case ActionPreference.SilentlyContinue:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 146922, 147473);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 147082, 147095);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 146922, 147473);

                    case ActionPreference.Continue:
                    case ActionPreference.Stop:
                    case ActionPreference.Inquire:
                    case ActionPreference.Break:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 146922, 147473);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 147307, 147319);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 146922, 147473);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 146922, 147473);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 147369, 147424);

                        f_1291_147369_147423(false, "Bad preference value" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (preference).ToString(), 1291, 147412, 147422));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 147446, 147458);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 146922, 147473);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 145627, 147484);

                int
                f_1291_145780_145797(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    this_param.ThrowIfStopping();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 145780, 145797);
                    return 0;
                }


                int
                f_1291_146575_146606(System.Management.Automation.MshCommandRuntime
                this_param, bool
                needsToWriteToPipeline)
                {
                    this_param.ThrowIfWriteNotPermitted(needsToWriteToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 146575, 146606);
                    return 0;
                }


                int
                f_1291_147369_147423(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 147369, 147423);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 145627, 147484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 145627, 147484);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ContinueStatus WriteHelper(
                    string inquireCaption,
                    string inquireMessage,
                    ActionPreference preference,
                    ContinueStatus lastContinueStatus,
                    string preferenceVariableName,
                    string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 148777, 150908);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 149073, 149392);

                switch (lastContinueStatus)
                {

                    case ContinueStatus.NoToAll:  // previously answered NoToAll
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 149073, 149392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 149215, 149245);

                        return ContinueStatus.NoToAll;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 149073, 149392);

                    case ContinueStatus.YesToAll: // previously answered YesToAll
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 149073, 149392);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 149346, 149377);

                        return ContinueStatus.YesToAll;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 149073, 149392);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 149408, 150607);

                switch (preference)
                {

                    case ActionPreference.Ignore: // YesToAll
                    case ActionPreference.SilentlyContinue:
                    case ActionPreference.Continue:
                    case ActionPreference.Break:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 149408, 150607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 149675, 149701);

                        return ContinueStatus.Yes;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 149408, 150607);

                    case ActionPreference.Stop:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 149408, 150607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 149770, 150028);

                        ActionPreferenceStopException
                        e =
                        f_1291_149829_150027(f_1291_149893_149905(), f_1291_149936_150026(f_1291_149954_149992(), preferenceVariableName, message))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 150050, 150075);

                        throw f_1291_150056_150074(this, e);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 149408, 150607);

                    case ActionPreference.Inquire:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 149408, 150607);
                        DynAbs.Tracing.TraceSender.TraceBreak(1291, 150147, 150153);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 149408, 150607);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 149408, 150607);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 150203, 150258);

                        f_1291_150203_150257(false, "Bad preference value" + DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => (preference).ToString(), 1291, 150246, 150256));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 150280, 150542);

                        ActionPreferenceStopException
                        apse =
                        f_1291_150342_150541(f_1291_150406_150418(), f_1291_150449_150540(f_1291_150467_150503(), preferenceVariableName, preference))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 150564, 150592);

                        throw f_1291_150570_150591(this, apse);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 149408, 150607);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 150623, 150897);

                return f_1291_150630_150896(this, inquireMessage, inquireCaption, true, false, true, false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 148777, 150908);

                System.Management.Automation.InvocationInfo
                f_1291_149893_149905()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 149893, 149905);
                    return return_v;
                }


                string
                f_1291_149954_149992()
                {
                    var return_v = CommandBaseStrings.ErrorPreferenceStop;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 149954, 149992);
                    return return_v;
                }


                string
                f_1291_149936_150026(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 149936, 150026);
                    return return_v;
                }


                System.Management.Automation.ActionPreferenceStopException
                f_1291_149829_150027(System.Management.Automation.InvocationInfo
                invocationInfo, string
                message)
                {
                    var return_v = new System.Management.Automation.ActionPreferenceStopException(invocationInfo, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 149829, 150027);
                    return return_v;
                }


                System.Exception
                f_1291_150056_150074(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ActionPreferenceStopException
                e)
                {
                    var return_v = this_param.ManageException((System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 150056, 150074);
                    return return_v;
                }


                int
                f_1291_150203_150257(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 150203, 150257);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1291_150406_150418()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 150406, 150418);
                    return return_v;
                }


                string
                f_1291_150467_150503()
                {
                    var return_v = CommandBaseStrings.PreferenceInvalid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 150467, 150503);
                    return return_v;
                }


                string
                f_1291_150449_150540(string
                formatSpec, string
                o1, System.Management.Automation.ActionPreference
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 150449, 150540);
                    return return_v;
                }


                System.Management.Automation.ActionPreferenceStopException
                f_1291_150342_150541(System.Management.Automation.InvocationInfo
                invocationInfo, string
                message)
                {
                    var return_v = new System.Management.Automation.ActionPreferenceStopException(invocationInfo, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 150342, 150541);
                    return return_v;
                }


                System.Exception
                f_1291_150570_150591(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ActionPreferenceStopException
                e)
                {
                    var return_v = this_param.ManageException((System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 150570, 150591);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime.ContinueStatus
                f_1291_150630_150896(System.Management.Automation.MshCommandRuntime
                this_param, string
                inquireMessage, string
                inquireCaption, bool
                allowYesToAll, bool
                allowNoToAll, bool
                replaceNoWithHalt, bool
                hasSecurityImpact)
                {
                    var return_v = this_param.InquireHelper(inquireMessage, inquireCaption, allowYesToAll, allowNoToAll, replaceNoWithHalt, hasSecurityImpact);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 150630, 150896);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 148777, 150908);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 148777, 150908);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal ContinueStatus InquireHelper(
                    string inquireMessage,
                    string inquireCaption,
                    bool allowYesToAll,
                    bool allowNoToAll,
                    bool replaceNoWithHalt,
                    bool hasSecurityImpact
                    )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 152194, 158626);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 152482, 152575);

                Collection<ChoiceDescription>
                choices =
                f_1291_152539_152574()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 152589, 152611);

                int
                currentOption = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 152627, 152910);

                int
                continueOneOption = Int32.MaxValue
                ,
                continueAllOption = Int32.MaxValue
                ,
                haltOption = Int32.MaxValue
                ,
                skipOneOption = Int32.MaxValue
                ,
                skipAllOption = Int32.MaxValue
                ,
                pauseOption = Int32.MaxValue
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 152926, 152988);

                string
                continueOneLabel = f_1291_152952_152987()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 153002, 153072);

                string
                continueOneHelpMsg = f_1291_153030_153071()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 153086, 153159);

                f_1291_153086_153158(choices, f_1291_153098_153157(continueOneLabel, continueOneHelpMsg));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 153173, 153209);

                continueOneOption = currentOption++;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 153225, 153586) || true) && (allowYesToAll)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 153225, 153586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 153276, 153338);

                    string
                    continueAllLabel = f_1291_153302_153337()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 153356, 153426);

                    string
                    continueAllHelpMsg = f_1291_153384_153425()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 153444, 153517);

                    f_1291_153444_153516(choices, f_1291_153456_153515(continueAllLabel, continueAllHelpMsg));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 153535, 153571);

                    continueAllOption = currentOption++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 153225, 153586);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 153602, 154251) || true) && (replaceNoWithHalt)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 153602, 154251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 153657, 153705);

                    string
                    haltLabel = f_1291_153676_153704()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 153723, 153779);

                    string
                    haltHelpMsg = f_1291_153744_153778()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 153797, 153856);

                    f_1291_153797_153855(choices, f_1291_153809_153854(haltLabel, haltHelpMsg));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 153874, 153903);

                    haltOption = currentOption++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 153602, 154251);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 153602, 154251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 153969, 154023);

                    string
                    skipOneLabel = f_1291_153991_154022()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 154041, 154103);

                    string
                    skipOneHelpMsg = f_1291_154065_154102()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 154121, 154186);

                    f_1291_154121_154185(choices, f_1291_154133_154184(skipOneLabel, skipOneHelpMsg));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 154204, 154236);

                    skipOneOption = currentOption++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 153602, 154251);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 154267, 154599) || true) && (allowNoToAll)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 154267, 154599);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 154317, 154371);

                    string
                    skipAllLabel = f_1291_154339_154370()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 154389, 154451);

                    string
                    skipAllHelpMsg = f_1291_154413_154450()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 154469, 154534);

                    f_1291_154469_154533(choices, f_1291_154481_154532(skipAllLabel, skipAllHelpMsg));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 154552, 154584);

                    skipAllOption = currentOption++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 154267, 154599);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 154885, 155242) || true) && (f_1291_154889_154913(this))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 154885, 155242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 154947, 154997);

                    string
                    pauseLabel = f_1291_154967_154996()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 155015, 155100);

                    string
                    pauseHelpMsg = f_1291_155037_155099(f_1291_155055_155090(), "exit")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 155118, 155179);

                    f_1291_155118_155178(choices, f_1291_155130_155177(pauseLabel, pauseHelpMsg));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 155197, 155227);

                    pauseOption = currentOption++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 154885, 155242);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 155258, 155411) || true) && (f_1291_155262_155298(inquireMessage))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 155258, 155411);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 155332, 155396);

                    inquireMessage = f_1291_155349_155395();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 155258, 155411);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 155427, 155574) || true) && (f_1291_155431_155467(inquireCaption))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 155427, 155574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 155501, 155559);

                    inquireCaption = f_1291_155518_155558();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 155427, 155574);
                }
                {
                    try
                    {
                        do

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 155590, 158615);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 155681, 155732);

                            f_1291_155681_155731(f_1291_155681_155698(CBhost), inquireCaption);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 155750, 155801);

                            f_1291_155750_155800(f_1291_155750_155767(CBhost), inquireMessage);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 155821, 155879);

                            Text.StringBuilder
                            textChoices = f_1291_155854_155878()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 155897, 156183);
                                foreach (ChoiceDescription choice in f_1291_155934_155941_I(choices))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 155897, 156183);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 155983, 156107) || true) && (f_1291_155987_156005(textChoices) > 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 155983, 156107);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 156059, 156084);

                                        f_1291_156059_156083(textChoices, "  ");
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 155983, 156107);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 156131, 156164);

                                    f_1291_156131_156163(
                                                        textChoices, f_1291_156150_156162(choice));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 155897, 156183);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1291, 1, 287);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1291, 1, 287);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 156203, 156262);

                            f_1291_156203_156261(f_1291_156203_156220(CBhost), f_1291_156238_156260(textChoices));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 156282, 156304);

                            int
                            defaultOption = 0
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 156322, 156434) || true) && (hasSecurityImpact)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 156322, 156434);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 156385, 156415);

                                defaultOption = skipOneOption;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 156322, 156434);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 156454, 156578);

                            int
                            response = f_1291_156469_156577(f_1291_156469_156483(this.CBhost), inquireCaption, inquireMessage, choices, defaultOption)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 156598, 156638);

                            string
                            chosen = f_1291_156614_156637(f_1291_156614_156631(choices, response))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 156656, 156693);

                            int
                            labelIndex = f_1291_156673_156692(chosen, '&')
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 156711, 156834) || true) && (labelIndex > -1)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 156711, 156834);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 156772, 156815);

                                chosen = f_1291_156781_156814(f_1291_156781_156803(chosen, labelIndex + 1));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 156711, 156834);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 156854, 156897);

                            f_1291_156854_156896(f_1291_156854_156871(CBhost), chosen);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 156917, 158586) || true) && (continueOneOption == response)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 156917, 158586);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 156973, 156999);

                                return ContinueStatus.Yes;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 156917, 158586);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 156917, 158586);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 157022, 158586) || true) && (continueAllOption == response)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 157022, 158586);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 157078, 157109);

                                    return ContinueStatus.YesToAll;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 157022, 158586);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 157022, 158586);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 157132, 158586) || true) && (haltOption == response)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 157132, 158586);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 157200, 157398);

                                        ActionPreferenceStopException
                                        e =
                                        f_1291_157259_157397(f_1291_157323_157335(), f_1291_157366_157396())
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 157420, 157445);

                                        throw f_1291_157426_157444(this, e);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 157132, 158586);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 157132, 158586);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 157487, 158586) || true) && (skipOneOption == response)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 157487, 158586);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 157539, 157564);

                                            return ContinueStatus.No;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 157487, 158586);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 157487, 158586);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 157587, 158586) || true) && (skipAllOption == response)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 157587, 158586);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 157639, 157669);

                                                return ContinueStatus.NoToAll;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 157587, 158586);
                                            }

                                            else
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 157587, 158586);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 157692, 158586) || true) && (pauseOption == response)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 157692, 158586);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 157842, 157881);

                                                    f_1291_157842_157880(                    // This call returns when the user exits the nested prompt.
                                                                        CBhost, _thisCommand);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 157692, 158586);
                                                }

                                                else
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 157692, 158586);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 157961, 158586) || true) && (-1 == response)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 157961, 158586);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 158021, 158220);

                                                        ActionPreferenceStopException
                                                        e =
                                                        f_1291_158080_158219(f_1291_158144_158156(), f_1291_158187_158218())
                                                        ;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 158242, 158267);

                                                        throw f_1291_158248_158266(this, e);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 157961, 158586);
                                                    }

                                                    else

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 157961, 158586);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 158349, 158398);

                                                        f_1291_158349_158397(false, "all cases should be checked");
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 158420, 158520);

                                                        InvalidOperationException
                                                        e =
                                                        f_1291_158475_158519()
                                                        ;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 158542, 158567);

                                                        throw f_1291_158548_158566(this, e);
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 157961, 158586);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 157692, 158586);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 157587, 158586);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 157487, 158586);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 157132, 158586);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 157022, 158586);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 156917, 158586);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 155590, 158615);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 155590, 158615) || true) && (true)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1291, 155590, 158615);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1291, 155590, 158615);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 152194, 158626);

                System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                f_1291_152539_152574()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 152539, 152574);
                    return return_v;
                }


                string
                f_1291_152952_152987()
                {
                    var return_v = CommandBaseStrings.ContinueOneLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 152952, 152987);
                    return return_v;
                }


                string
                f_1291_153030_153071()
                {
                    var return_v = CommandBaseStrings.ContinueOneHelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 153030, 153071);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1291_153098_153157(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 153098, 153157);
                    return return_v;
                }


                int
                f_1291_153086_153158(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 153086, 153158);
                    return 0;
                }


                string
                f_1291_153302_153337()
                {
                    var return_v = CommandBaseStrings.ContinueAllLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 153302, 153337);
                    return return_v;
                }


                string
                f_1291_153384_153425()
                {
                    var return_v = CommandBaseStrings.ContinueAllHelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 153384, 153425);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1291_153456_153515(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 153456, 153515);
                    return return_v;
                }


                int
                f_1291_153444_153516(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 153444, 153516);
                    return 0;
                }


                string
                f_1291_153676_153704()
                {
                    var return_v = CommandBaseStrings.HaltLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 153676, 153704);
                    return return_v;
                }


                string
                f_1291_153744_153778()
                {
                    var return_v = CommandBaseStrings.HaltHelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 153744, 153778);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1291_153809_153854(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 153809, 153854);
                    return return_v;
                }


                int
                f_1291_153797_153855(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 153797, 153855);
                    return 0;
                }


                string
                f_1291_153991_154022()
                {
                    var return_v = CommandBaseStrings.SkipOneLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 153991, 154022);
                    return return_v;
                }


                string
                f_1291_154065_154102()
                {
                    var return_v = CommandBaseStrings.SkipOneHelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 154065, 154102);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1291_154133_154184(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 154133, 154184);
                    return return_v;
                }


                int
                f_1291_154121_154185(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 154121, 154185);
                    return 0;
                }


                string
                f_1291_154339_154370()
                {
                    var return_v = CommandBaseStrings.SkipAllLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 154339, 154370);
                    return return_v;
                }


                string
                f_1291_154413_154450()
                {
                    var return_v = CommandBaseStrings.SkipAllHelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 154413, 154450);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1291_154481_154532(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 154481, 154532);
                    return return_v;
                }


                int
                f_1291_154469_154533(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 154469, 154533);
                    return 0;
                }


                bool
                f_1291_154889_154913(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsSuspendPromptAllowed();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 154889, 154913);
                    return return_v;
                }


                string
                f_1291_154967_154996()
                {
                    var return_v = CommandBaseStrings.PauseLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 154967, 154996);
                    return return_v;
                }


                string
                f_1291_155055_155090()
                {
                    var return_v = CommandBaseStrings.PauseHelpMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 155055, 155090);
                    return return_v;
                }


                string
                f_1291_155037_155099(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 155037, 155099);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1291_155130_155177(string
                label, string
                helpMessage)
                {
                    var return_v = new System.Management.Automation.Host.ChoiceDescription(label, helpMessage);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 155130, 155177);
                    return return_v;
                }


                int
                f_1291_155118_155178(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, System.Management.Automation.Host.ChoiceDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 155118, 155178);
                    return 0;
                }


                bool
                f_1291_155262_155298(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 155262, 155298);
                    return return_v;
                }


                string
                f_1291_155349_155395()
                {
                    var return_v = CommandBaseStrings.ShouldContinuePromptCaption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 155349, 155395);
                    return return_v;
                }


                bool
                f_1291_155431_155467(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 155431, 155467);
                    return return_v;
                }


                string
                f_1291_155518_155558()
                {
                    var return_v = CommandBaseStrings.InquireCaptionDefault;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 155518, 155558);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_155681_155698(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 155681, 155698);
                    return return_v;
                }


                int
                f_1291_155681_155731(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                resultText)
                {
                    this_param.TranscribeResult(resultText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 155681, 155731);
                    return 0;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_155750_155767(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 155750, 155767);
                    return return_v;
                }


                int
                f_1291_155750_155800(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                resultText)
                {
                    this_param.TranscribeResult(resultText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 155750, 155800);
                    return 0;
                }


                System.Text.StringBuilder
                f_1291_155854_155878()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 155854, 155878);
                    return return_v;
                }


                int
                f_1291_155987_156005(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 155987, 156005);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1291_156059_156083(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 156059, 156083);
                    return return_v;
                }


                string
                f_1291_156150_156162(System.Management.Automation.Host.ChoiceDescription
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 156150, 156162);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1291_156131_156163(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 156131, 156163);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                f_1291_155934_155941_I(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 155934, 155941);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_156203_156220(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 156203, 156220);
                    return return_v;
                }


                string
                f_1291_156238_156260(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 156238, 156260);
                    return return_v;
                }


                int
                f_1291_156203_156261(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                resultText)
                {
                    this_param.TranscribeResult(resultText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 156203, 156261);
                    return 0;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1291_156469_156483(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 156469, 156483);
                    return return_v;
                }


                int
                f_1291_156469_156577(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                caption, string
                message, System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                choices, int
                defaultChoice)
                {
                    var return_v = this_param.PromptForChoice(caption, message, choices, defaultChoice);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 156469, 156577);
                    return return_v;
                }


                System.Management.Automation.Host.ChoiceDescription
                f_1291_156614_156631(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.ChoiceDescription>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 156614, 156631);
                    return return_v;
                }


                string
                f_1291_156614_156637(System.Management.Automation.Host.ChoiceDescription
                this_param)
                {
                    var return_v = this_param.Label;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 156614, 156637);
                    return return_v;
                }


                int
                f_1291_156673_156692(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 156673, 156692);
                    return return_v;
                }


                char
                f_1291_156781_156803(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 156781, 156803);
                    return return_v;
                }


                string
                f_1291_156781_156814(char
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 156781, 156814);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHostUserInterface
                f_1291_156854_156871(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.InternalUI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 156854, 156871);
                    return return_v;
                }


                int
                f_1291_156854_156896(System.Management.Automation.Internal.Host.InternalHostUserInterface
                this_param, string
                resultText)
                {
                    this_param.TranscribeResult(resultText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 156854, 156896);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1291_157323_157335()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 157323, 157335);
                    return return_v;
                }


                string
                f_1291_157366_157396()
                {
                    var return_v = CommandBaseStrings.InquireHalt;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 157366, 157396);
                    return return_v;
                }


                System.Management.Automation.ActionPreferenceStopException
                f_1291_157259_157397(System.Management.Automation.InvocationInfo
                invocationInfo, string
                message)
                {
                    var return_v = new System.Management.Automation.ActionPreferenceStopException(invocationInfo, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 157259, 157397);
                    return return_v;
                }


                System.Exception
                f_1291_157426_157444(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ActionPreferenceStopException
                e)
                {
                    var return_v = this_param.ManageException((System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 157426, 157444);
                    return return_v;
                }


                int
                f_1291_157842_157880(System.Management.Automation.Internal.Host.InternalHost
                this_param, System.Management.Automation.Internal.InternalCommand
                callingCommand)
                {
                    this_param.EnterNestedPrompt(callingCommand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 157842, 157880);
                    return 0;
                }


                System.Management.Automation.InvocationInfo
                f_1291_158144_158156()
                {
                    var return_v = MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 158144, 158156);
                    return return_v;
                }


                string
                f_1291_158187_158218()
                {
                    var return_v = CommandBaseStrings.InquireCtrlC;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 158187, 158218);
                    return return_v;
                }


                System.Management.Automation.ActionPreferenceStopException
                f_1291_158080_158219(System.Management.Automation.InvocationInfo
                invocationInfo, string
                message)
                {
                    var return_v = new System.Management.Automation.ActionPreferenceStopException(invocationInfo, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 158080, 158219);
                    return return_v;
                }


                System.Exception
                f_1291_158248_158266(System.Management.Automation.MshCommandRuntime
                this_param, System.Management.Automation.ActionPreferenceStopException
                e)
                {
                    var return_v = this_param.ManageException((System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 158248, 158266);
                    return return_v;
                }


                int
                f_1291_158349_158397(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 158349, 158397);
                    return 0;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1291_158475_158519()
                {
                    var return_v = PSTraceSource.NewInvalidOperationException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 158475, 158519);
                    return return_v;
                }


                System.Exception
                f_1291_158548_158566(System.Management.Automation.MshCommandRuntime
                this_param, System.InvalidOperationException
                e)
                {
                    var return_v = this_param.ManageException((System.Exception)e);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 158548, 158566);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 152194, 158626);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 152194, 158626);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool IsSuspendPromptAllowed()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 158770, 159163);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 158832, 158896);

                f_1291_158832_158895(this.CBhost != null, "Expected this.CBhost != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 158910, 159000);

                f_1291_158910_158999(f_1291_158921_158945(this.CBhost) != null, "Expected this.CBhost.ExternalHost != null");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 159014, 159124) || true) && (f_1291_159018_159042(this.CBhost) is ServerRemoteHost)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 159014, 159124);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 159096, 159109);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 159014, 159124);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 159140, 159152);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 158770, 159163);

                int
                f_1291_158832_158895(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 158832, 158895);
                    return 0;
                }


                System.Management.Automation.Host.PSHost
                f_1291_158921_158945(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.ExternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 158921, 158945);
                    return return_v;
                }


                int
                f_1291_158910_158999(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 158910, 158999);
                    return 0;
                }


                System.Management.Automation.Host.PSHost
                f_1291_159018_159042(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.ExternalHost;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 159018, 159042);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 158770, 159163);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 158770, 159163);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void SetVariableListsInPipe()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 159242, 160237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 159305, 159396);

                f_1291_159305_159395(_thisCommand is PSScriptCmdlet, "this is only done for script cmdlets");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 159412, 159556) || true) && (_outVarList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 159412, 159556);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 159469, 159541);

                    f_1291_159469_159540(f_1291_159469_159484(this), VariableStreamKind.Output, _outVarList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 159412, 159556);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 159572, 159719) || true) && (_errorVarList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 159572, 159719);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 159631, 159704);

                    f_1291_159631_159703(f_1291_159631_159646(this), VariableStreamKind.Error, _errorVarList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 159572, 159719);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 159735, 159888) || true) && (_warningVarList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 159735, 159888);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 159796, 159873);

                    f_1291_159796_159872(f_1291_159796_159811(this), VariableStreamKind.Warning, _warningVarList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 159735, 159888);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 159904, 160069) || true) && (_informationVarList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 159904, 160069);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 159969, 160054);

                    f_1291_159969_160053(f_1291_159969_159984(this), VariableStreamKind.Information, _informationVarList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 159904, 160069);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 160085, 160226) || true) && (f_1291_160089_160110(this) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 160085, 160226);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 160152, 160211);

                    f_1291_160152_160210(f_1291_160152_160167(this), _pipelineVarReference);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 160085, 160226);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 159242, 160237);

                int
                f_1291_159305_159395(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 159305, 159395);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_159469_159484(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 159469, 159484);
                    return return_v;
                }


                int
                f_1291_159469_159540(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.VariableStreamKind
                kind, System.Collections.IList
                list)
                {
                    this_param.AddVariableList(kind, list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 159469, 159540);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_159631_159646(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 159631, 159646);
                    return return_v;
                }


                int
                f_1291_159631_159703(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.VariableStreamKind
                kind, System.Collections.IList
                list)
                {
                    this_param.AddVariableList(kind, list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 159631, 159703);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_159796_159811(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 159796, 159811);
                    return return_v;
                }


                int
                f_1291_159796_159872(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.VariableStreamKind
                kind, System.Collections.IList
                list)
                {
                    this_param.AddVariableList(kind, list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 159796, 159872);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_159969_159984(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 159969, 159984);
                    return return_v;
                }


                int
                f_1291_159969_160053(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.VariableStreamKind
                kind, System.Collections.IList
                list)
                {
                    this_param.AddVariableList(kind, list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 159969, 160053);
                    return 0;
                }


                string
                f_1291_160089_160110(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 160089, 160110);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_160152_160167(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 160152, 160167);
                    return return_v;
                }


                int
                f_1291_160152_160210(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.PSVariable
                pipelineVariable)
                {
                    this_param.SetPipelineVariable(pipelineVariable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 160152, 160210);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 159242, 160237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 159242, 160237);
            }
        }

        internal void RemoveVariableListsInPipe()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1291, 160249, 161553);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 160424, 160571) || true) && (_outVarList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 160424, 160571);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 160481, 160556);

                    f_1291_160481_160555(f_1291_160481_160496(this), VariableStreamKind.Output, _outVarList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 160424, 160571);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 160587, 160737) || true) && (_errorVarList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 160587, 160737);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 160646, 160722);

                    f_1291_160646_160721(f_1291_160646_160661(this), VariableStreamKind.Error, _errorVarList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 160587, 160737);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 160753, 160909) || true) && (_warningVarList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 160753, 160909);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 160814, 160894);

                    f_1291_160814_160893(f_1291_160814_160829(this), VariableStreamKind.Warning, _warningVarList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 160753, 160909);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 160925, 161093) || true) && (_informationVarList != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 160925, 161093);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 160990, 161078);

                    f_1291_160990_161077(f_1291_160990_161005(this), VariableStreamKind.Information, _informationVarList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 160925, 161093);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 161109, 161542) || true) && (f_1291_161113_161134(this) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1291, 161109, 161542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 161176, 161217);

                    f_1291_161176_161216(f_1291_161176_161191(this));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 161478, 161527);

                    //f_1291_161485_161526(.PSVariable, f_1291_161504_161525(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1291, 161109, 161542);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1291, 160249, 161553);

                System.Management.Automation.Internal.Pipe
                f_1291_160481_160496(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 160481, 160496);
                    return return_v;
                }


                int
                f_1291_160481_160555(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.VariableStreamKind
                kind, System.Collections.IList
                list)
                {
                    this_param.RemoveVariableList(kind, list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 160481, 160555);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_160646_160661(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 160646, 160661);
                    return return_v;
                }


                int
                f_1291_160646_160721(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.VariableStreamKind
                kind, System.Collections.IList
                list)
                {
                    this_param.RemoveVariableList(kind, list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 160646, 160721);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_160814_160829(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 160814, 160829);
                    return return_v;
                }


                int
                f_1291_160814_160893(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.VariableStreamKind
                kind, System.Collections.IList
                list)
                {
                    this_param.RemoveVariableList(kind, list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 160814, 160893);
                    return 0;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_160990_161005(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 160990, 161005);
                    return return_v;
                }


                int
                f_1291_160990_161077(System.Management.Automation.Internal.Pipe
                this_param, System.Management.Automation.Internal.VariableStreamKind
                kind, System.Collections.IList
                list)
                {
                    this_param.RemoveVariableList(kind, list);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 160990, 161077);
                    return 0;
                }


                string
                f_1291_161113_161134(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 161113, 161134);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1291_161176_161191(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 161176, 161191);
                    return return_v;
                }


                int
                f_1291_161176_161216(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    this_param.RemovePipelineVariable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 161176, 161216);
                    return 0;
                }


                string
                f_1291_161504_161525(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.PipelineVariable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 161504, 161525);
                    return return_v;
                }


                void f_1291_161485_161526(System.Management.Automation.PSVariableIntrinsics this_param, string name)
                {
                    this_param?.Remove(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 161485, 161526);
                    //return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1291, 160249, 161553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 160249, 161553);
            }
        }

        static MshCommandRuntime()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1291, 1048, 161560);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 12410, 12428);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1291, 99107, 99147);
            StaticEmptyArray = f_1291_99126_99147();
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1291, 1048, 161560);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1291, 1048, 161560);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1291, 1048, 161560);

        System.Management.Automation.Internal.Host.InternalHost
        f_1291_3688_3715(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.EngineHostInterface;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 3688, 3715);
            return return_v;
        }


        System.Management.Automation.Internal.Host.InternalHost
        f_1291_3758_3785(System.Management.Automation.ExecutionContext
        this_param)
        {
            var return_v = this_param.EngineHostInterface;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1291, 3758, 3785);
            return return_v;
        }


        bool
        f_1291_3911_3949(System.Management.Automation.MshCommandRuntime
        this_param)
        {
            var return_v = this_param.InitShouldLogPipelineExecutionDetail();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 3911, 3949);
            return return_v;
        }


        static object[]
        f_1291_99126_99147()
        {
            var return_v = Array.Empty<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1291, 99126, 99147);
            return return_v;
        }

    }
}
