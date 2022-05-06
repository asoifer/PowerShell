// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Linq;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Text;

namespace System.Management.Automation
{
    internal class CmdletParameterBinderController : ParameterBinderController
    {
        [TraceSource("ParameterBinderController", "Controls the interaction between the command processor and the parameter binder(s).")]
        private static readonly PSTraceSource s_tracer;

        internal CmdletParameterBinderController(
                    Cmdlet cmdlet,
                    CommandMetadata commandMetadata,
                    ParameterBinderBase parameterBinder)
        : base(
        f_1243_1951_1970_C(f_1243_1951_1970(cmdlet)), f_1243_1989_2003(cmdlet), parameterBinder)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1243, 1747, 3312);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 25903, 25960);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 190144, 190189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 190499, 190509);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 191163, 191198);
                this._warningSet = f_1243_191177_191198();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 191329, 191359);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 191383, 191417);
                this._useDefaultParameterBinding = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 191499, 191548);
                this._parameterSetToBePrioritizedInPipelineBinding = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 191675, 191691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 191843, 191858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 192002, 192081);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 192561, 192589);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 192845, 192868);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 193869, 193898);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 194836, 194858);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 195840, 195867);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 196806, 196829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 197807, 197921);
                this._delayBindScriptBlocks = f_1243_197845_197921();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 198110, 198231);
                this._defaultParameterValues = f_1243_198149_198231(f_1243_198198_198230());
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 2063, 2185) || true) && (cmdlet == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 2063, 2185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 2115, 2170);

                    throw f_1243_2121_2169("cmdlet");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 2063, 2185);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 2201, 2341) || true) && (commandMetadata == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 2201, 2341);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 2262, 2326);

                    throw f_1243_2268_2325("commandMetadata");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 2201, 2341);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 2357, 2379);

                this.Command = cmdlet;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 2393, 2452);

                _commandRuntime = (MshCommandRuntime)f_1243_2430_2451(cmdlet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 2466, 2501);

                _commandMetadata = commandMetadata;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 2656, 3301) || true) && (f_1243_2660_2703(commandMetadata))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 2656, 3301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 2831, 2944);

                    this.UnboundParameters = f_1243_2856_2943(f_1243_2856_2879(this), f_1243_2896_2942(commandMetadata));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 2656, 3301);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 2656, 3301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 3010, 3079);

                    _bindableParameters = f_1243_3032_3078(commandMetadata);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 3173, 3286);

                    this.UnboundParameters = f_1243_3198_3285(f_1243_3239_3284(f_1243_3239_3277(_bindableParameters)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 2656, 3301);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1243, 1747, 3312);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 1747, 3312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 1747, 3312);
            }
        }

        internal void BindCommandLineParameters(Collection<CommandParameterInternal> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 3961, 8371);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 4073, 4132);

                f_1243_4073_4131(s_tracer, "Argument count: {0}", f_1243_4115_4130(arguments));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 4148, 4197);

                f_1243_4148_4196(this, arguments);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 4257, 4351);

                bool
                isPipelineInputExpected = !(f_1243_4290_4314(_commandRuntime) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 4290, 4349) && f_1243_4318_4349(f_1243_4318_4343(_commandRuntime))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 4367, 4394);

                int
                validParameterSetCount
                = default(int);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 4410, 5099) || true) && (!isPipelineInputExpected)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 4410, 5099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 4708, 4768);

                    validParameterSetCount = f_1243_4733_4767(this, false, true);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 4410, 5099);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 4410, 5099);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 5024, 5084);

                    validParameterSetCount = f_1243_5049_5083(this, true, false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 4410, 5099);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 5330, 5501) || true) && (validParameterSetCount == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 5334, 5394) && f_1243_5365_5394_M(!DefaultParameterBindingInUse)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 5330, 5501);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 5428, 5486);

                    f_1243_5428_5485(this, "Mandatory Checking", false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 5330, 5501);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 5714, 6291) || true) && (validParameterSetCount > 1 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 5718, 5771) && isPipelineInputExpected))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 5714, 6291);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 5805, 5886);

                    uint
                    filteredValidParameterSetFlags = f_1243_5843_5885(this)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 5904, 6276) || true) && (filteredValidParameterSetFlags != _currentParameterSetFlag)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 5904, 6276);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 6008, 6066);

                        _currentParameterSetFlag = filteredValidParameterSetFlags;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 6197, 6257);

                        validParameterSetCount = f_1243_6222_6256(this, true, false);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 5904, 6276);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 5714, 6291);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 6307, 7904);
                using (f_1243_6314_6461(ParameterBinderBase.bindingTracer, "MANDATORY PARAMETER CHECK on cmdlet [{0}]", f_1243_6439_6460(_commandMetadata)))
                {
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 6932, 7002);

                        Collection<MergedCompiledCommandParameter>
                        missingMandatoryParameters
                        = default(Collection<MergedCompiledCommandParameter>);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 7123, 7230);

                        bool
                        promptForMandatoryParameters = (f_1243_7160_7190(f_1243_7160_7179(f_1243_7160_7167())) == SessionStateEntryVisibility.Public)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 7252, 7402);

                        f_1243_7252_7401(this, validParameterSetCount, true, promptForMandatoryParameters, isPipelineInputExpected, out missingMandatoryParameters);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 7426, 7580) || true) && (f_1243_7430_7452() is ScriptParameterBinder)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 7426, 7580);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 7527, 7557);

                            f_1243_7527_7556(this);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 7426, 7580);
                        }
                    }
                    catch (ParameterBindingException pbex)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 7617, 7889);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 7696, 7808) || true) && (f_1243_7700_7729_M(!DefaultParameterBindingInUse))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 7696, 7808);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 7779, 7785);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 7696, 7808);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 7832, 7870);

                        f_1243_7832_7869(this, pbex);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 7617, 7889);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1243, 6307, 7904);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 8038, 8144) || true) && (!isPipelineInputExpected)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 8038, 8144);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 8100, 8129);

                    f_1243_8100_8128(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 8038, 8144);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 8293, 8360);

                _prePipelineProcessingParameterSetFlags = _currentParameterSetFlag;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 3961, 8371);

                int
                f_1243_4115_4130(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 4115, 4130);
                    return return_v;
                }


                int
                f_1243_4073_4131(System.Management.Automation.PSTraceSource
                this_param, string
                format, int
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 4073, 4131);
                    return 0;
                }


                int
                f_1243_4148_4196(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                arguments)
                {
                    this_param.BindCommandLineParametersNoValidation(arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 4148, 4196);
                    return 0;
                }


                bool
                f_1243_4290_4314(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsClosed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 4290, 4314);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1243_4318_4343(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.InputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 4318, 4343);
                    return return_v;
                }


                bool
                f_1243_4318_4349(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.Empty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 4318, 4349);
                    return return_v;
                }


                int
                f_1243_4733_4767(System.Management.Automation.CmdletParameterBinderController
                this_param, bool
                prePipelineInput, bool
                setDefault)
                {
                    var return_v = this_param.ValidateParameterSets(prePipelineInput, setDefault);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 4733, 4767);
                    return return_v;
                }


                int
                f_1243_5049_5083(System.Management.Automation.CmdletParameterBinderController
                this_param, bool
                prePipelineInput, bool
                setDefault)
                {
                    var return_v = this_param.ValidateParameterSets(prePipelineInput, setDefault);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 5049, 5083);
                    return return_v;
                }


                bool
                f_1243_5365_5394_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 5365, 5394);
                    return return_v;
                }


                int
                f_1243_5428_5485(System.Management.Automation.CmdletParameterBinderController
                this_param, string
                bindingStage, bool
                isDynamic)
                {
                    this_param.ApplyDefaultParameterBinding(bindingStage, isDynamic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 5428, 5485);
                    return 0;
                }


                uint
                f_1243_5843_5885(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.FilterParameterSetsTakingNoPipelineInput();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 5843, 5885);
                    return return_v;
                }


                int
                f_1243_6222_6256(System.Management.Automation.CmdletParameterBinderController
                this_param, bool
                prePipelineInput, bool
                setDefault)
                {
                    var return_v = this_param.ValidateParameterSets(prePipelineInput, setDefault);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 6222, 6256);
                    return return_v;
                }


                string
                f_1243_6439_6460(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 6439, 6460);
                    return return_v;
                }


                System.IDisposable
                f_1243_6314_6461(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 6314, 6461);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_7160_7167()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 7160, 7167);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1243_7160_7179(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.CommandInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 7160, 7179);
                    return return_v;
                }


                System.Management.Automation.SessionStateEntryVisibility
                f_1243_7160_7190(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Visibility;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 7160, 7190);
                    return return_v;
                }


                bool
                f_1243_7252_7401(System.Management.Automation.CmdletParameterBinderController
                this_param, int
                validParameterSetCount, bool
                processMissingMandatory, bool
                promptForMandatory, bool
                isPipelineInputExpected, out System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                missingMandatoryParameters)
                {
                    var return_v = this_param.HandleUnboundMandatoryParameters(validParameterSetCount, processMissingMandatory, promptForMandatory, isPipelineInputExpected, out missingMandatoryParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 7252, 7401);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderBase
                f_1243_7430_7452()
                {
                    var return_v = DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 7430, 7452);
                    return return_v;
                }


                int
                f_1243_7527_7556(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    this_param.BindUnboundScriptParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 7527, 7556);
                    return 0;
                }


                bool
                f_1243_7700_7729_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 7700, 7729);
                    return return_v;
                }


                int
                f_1243_7832_7869(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.ParameterBindingException
                pbex)
                {
                    this_param.ThrowElaboratedBindingException(pbex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 7832, 7869);
                    return 0;
                }


                int
                f_1243_8100_8128(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    this_param.VerifyParameterSetSelected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 8100, 8128);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 3961, 8371);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 3961, 8371);
            }
        }

        internal void BindCommandLineParametersNoValidation(Collection<CommandParameterInternal> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 8579, 12684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 8703, 8763);

                var
                psCompiledScriptCmdlet = f_1243_8732_8744(this) as PSScriptCmdlet
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 8777, 8929) || true) && (psCompiledScriptCmdlet != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 8777, 8929);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 8845, 8914);

                    f_1243_8845_8913(psCompiledScriptCmdlet, f_1243_8886_8912(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 8777, 8929);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 9026, 9161);
                    foreach (CommandParameterInternal argument in f_1243_9072_9081_I(arguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 9026, 9161);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 9115, 9146);

                        f_1243_9115_9145(f_1243_9115_9131(), argument);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 9026, 9161);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 136);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 136);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 9177, 9227);

                CommandMetadata
                cmdletMetadata = _commandMetadata
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 9296, 9316);

                f_1243_9296_9315(            // Clear the warningSet at the beginning.
                            _warningSet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 9420, 9494);

                _allDefaultParameterValuePairs = f_1243_9453_9493(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 9554, 9591);

                DefaultParameterBindingInUse = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 9673, 9704);

                f_1243_9673_9703(f_1243_9673_9695());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 9787, 9813);

                f_1243_9787_9812(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 9829, 10150);
                using (f_1243_9836_9972(ParameterBinderBase.bindingTracer, "BIND NAMED cmd line args [{0}]", f_1243_9950_9971(_commandMetadata)))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 10052, 10135);

                    UnboundArguments = f_1243_10071_10134(this, _currentParameterSetFlag, f_1243_10112_10133(this));
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1243, 9829, 10150);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 10166, 10217);

                ParameterBindingException
                reportedBindingException
                = default(ParameterBindingException);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 10231, 10281);

                ParameterBindingException
                currentBindingException
                = default(ParameterBindingException);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 10297, 10931);
                using (f_1243_10304_10445(ParameterBinderBase.bindingTracer, "BIND POSITIONAL cmd line args [{0}]", f_1243_10423_10444(_commandMetadata)))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 10566, 10845);

                    UnboundArguments =
                    f_1243_10606_10844(this, f_1243_10657_10673(), _currentParameterSetFlag, f_1243_10751_10789(cmdletMetadata), out currentBindingException);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 10865, 10916);

                    reportedBindingException = currentBindingException;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1243, 10297, 10931);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 11163, 11218);

                f_1243_11163_11217(this, "POSITIONAL BIND", false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 11617, 11652);

                f_1243_11617_11651(this, true, false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 11818, 11882);

                f_1243_11818_11881(this, out currentBindingException);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 12097, 12148);

                f_1243_12097_12147(this, "DYNAMIC BIND", true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 12304, 12410) || true) && (reportedBindingException == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 12304, 12410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 12359, 12410);

                    reportedBindingException = currentBindingException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 12304, 12410);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 12579, 12606);

                f_1243_12579_12605(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 12622, 12673);

                f_1243_12622_12672(this, reportedBindingException);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 8579, 12684);

                System.Management.Automation.Cmdlet
                f_1243_8732_8744(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 8732, 8744);
                    return return_v;
                }


                System.Management.Automation.CommandLineParameters
                f_1243_8886_8912(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.CommandLineParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 8886, 8912);
                    return return_v;
                }


                int
                f_1243_8845_8913(System.Management.Automation.PSScriptCmdlet
                this_param, System.Management.Automation.CommandLineParameters
                commandLineParameters)
                {
                    this_param.PrepareForBinding(commandLineParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 8845, 8913);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_9115_9131()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 9115, 9131);
                    return return_v;
                }


                int
                f_1243_9115_9145(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 9115, 9145);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_9072_9081_I(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 9072, 9081);
                    return return_v;
                }


                int
                f_1243_9296_9315(System.Collections.Generic.HashSet<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 9296, 9315);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                f_1243_9453_9493(System.Management.Automation.CmdletParameterBinderController
                this_param, bool
                needToGetAlias)
                {
                    var return_v = this_param.GetDefaultParameterValuePairs(needToGetAlias);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 9453, 9493);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1243_9673_9695()
                {
                    var return_v = BoundDefaultParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 9673, 9695);
                    return return_v;
                }


                int
                f_1243_9673_9703(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 9673, 9703);
                    return 0;
                }


                int
                f_1243_9787_9812(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    this_param.ReparseUnboundArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 9787, 9812);
                    return 0;
                }


                string
                f_1243_9950_9971(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 9950, 9971);
                    return return_v;
                }


                System.IDisposable
                f_1243_9836_9972(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 9836, 9972);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_10112_10133(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 10112, 10133);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_10071_10134(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                parameterSets, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                arguments)
                {
                    var return_v = this_param.BindParameters(parameterSets, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 10071, 10134);
                    return return_v;
                }


                string
                f_1243_10423_10444(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 10423, 10444);
                    return return_v;
                }


                System.IDisposable
                f_1243_10304_10445(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 10304, 10445);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_10657_10673()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 10657, 10673);
                    return return_v;
                }


                uint
                f_1243_10751_10789(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 10751, 10789);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_10606_10844(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                unboundArguments, uint
                validParameterSets, uint
                defaultParameterSet, out System.Management.Automation.ParameterBindingException
                outgoingBindingException)
                {
                    var return_v = this_param.BindPositionalParameters(unboundArguments, validParameterSets, defaultParameterSet, out outgoingBindingException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 10606, 10844);
                    return return_v;
                }


                int
                f_1243_11163_11217(System.Management.Automation.CmdletParameterBinderController
                this_param, string
                bindingStage, bool
                isDynamic)
                {
                    this_param.ApplyDefaultParameterBinding(bindingStage, isDynamic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 11163, 11217);
                    return 0;
                }


                int
                f_1243_11617_11651(System.Management.Automation.CmdletParameterBinderController
                this_param, bool
                prePipelineInput, bool
                setDefault)
                {
                    var return_v = this_param.ValidateParameterSets(prePipelineInput, setDefault);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 11617, 11651);
                    return return_v;
                }


                int
                f_1243_11818_11881(System.Management.Automation.CmdletParameterBinderController
                this_param, out System.Management.Automation.ParameterBindingException
                outgoingBindingException)
                {
                    this_param.HandleCommandLineDynamicParameters(out outgoingBindingException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 11818, 11881);
                    return 0;
                }


                int
                f_1243_12097_12147(System.Management.Automation.CmdletParameterBinderController
                this_param, string
                bindingStage, bool
                isDynamic)
                {
                    this_param.ApplyDefaultParameterBinding(bindingStage, isDynamic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 12097, 12147);
                    return 0;
                }


                int
                f_1243_12579_12605(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    this_param.HandleRemainingArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 12579, 12605);
                    return 0;
                }


                int
                f_1243_12622_12672(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.ParameterBindingException
                originalBindingException)
                {
                    this_param.VerifyArgumentsProcessed(originalBindingException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 12622, 12672);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 8579, 12684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 8579, 12684);
            }
        }

        private uint FilterParameterSetsTakingNoPipelineInput()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 12941, 15348);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 13021, 13059);

                uint
                parameterSetsTakingPipeInput = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 13073, 13113);

                bool
                findPipeParameterInAllSets = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 13129, 13361);
                    foreach (KeyValuePair<MergedCompiledCommandParameter, DelayedScriptBlockArgument> entry in f_1243_13220_13242_I(_delayBindScriptBlocks))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 13129, 13361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 13276, 13346);

                        parameterSetsTakingPipeInput |= f_1243_13308_13345(f_1243_13308_13327(entry.Key));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 13129, 13361);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 233);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 233);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 13377, 14901);
                    foreach (MergedCompiledCommandParameter parameter in f_1243_13430_13447_I(f_1243_13430_13447()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 13377, 14901);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 13567, 13699) || true) && (f_1243_13571_13629_M(!f_1243_13572_13591(parameter).IsPipelineParameterInSomeParameterSet))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 13567, 13699);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 13671, 13680);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 13567, 13699);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 13719, 13849);

                        var
                        matchingParameterSetMetadata =
                        f_1243_13775_13848(f_1243_13775_13794(parameter), _currentParameterSetFlag)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 13869, 14807);
                            foreach (ParameterSetSpecificMetadata parameterSetMetadata in f_1243_13931_13959_I(matchingParameterSetMetadata))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 13869, 14807);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 14001, 14788) || true) && (f_1243_14005_14043(parameterSetMetadata) || (DynAbs.Tracing.TraceSender.Expression_False(1243, 14005, 14099) || f_1243_14047_14099(parameterSetMetadata)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 14001, 14788);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 14149, 14765) || true) && (f_1243_14153_14190(parameterSetMetadata) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 14153, 14231) && f_1243_14199_14231(parameterSetMetadata)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 14149, 14765);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 14421, 14454);

                                        parameterSetsTakingPipeInput = 0;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 14484, 14518);

                                        findPipeParameterInAllSets = true;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 14548, 14554);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 14149, 14765);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 14149, 14765);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 14668, 14738);

                                        parameterSetsTakingPipeInput |= f_1243_14700_14737(parameterSetMetadata);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 14149, 14765);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 14001, 14788);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 13869, 14807);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 939);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 939);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 14827, 14886) || true) && (findPipeParameterInAllSets)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 14827, 14886);
                            DynAbs.Tracing.TraceSender.TraceBreak(1243, 14880, 14886);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 14827, 14886);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 13377, 14901);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 1525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 1525);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 15150, 15337) || true) && (parameterSetsTakingPipeInput != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 15150, 15337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 15206, 15269);

                    return _currentParameterSetFlag & parameterSetsTakingPipeInput;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 15150, 15337);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 15150, 15337);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 15305, 15337);

                    return _currentParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 15150, 15337);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 12941, 15348);

                System.Management.Automation.CompiledCommandParameter
                f_1243_13308_13327(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 13308, 13327);
                    return return_v;
                }


                uint
                f_1243_13308_13345(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 13308, 13345);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.CmdletParameterBinderController.DelayedScriptBlockArgument>
                f_1243_13220_13242_I(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.CmdletParameterBinderController.DelayedScriptBlockArgument>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 13220, 13242);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_13430_13447()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 13430, 13447);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_13572_13591(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 13572, 13591);
                    return return_v;
                }


                bool
                f_1243_13571_13629_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 13571, 13629);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_13775_13794(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 13775, 13794);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_13775_13848(System.Management.Automation.CompiledCommandParameter
                this_param, uint
                parameterSetFlags)
                {
                    var return_v = this_param.GetMatchingParameterSetData(parameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 13775, 13848);
                    return return_v;
                }


                bool
                f_1243_14005_14043(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 14005, 14043);
                    return return_v;
                }


                bool
                f_1243_14047_14099(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineByPropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 14047, 14099);
                    return return_v;
                }


                uint
                f_1243_14153_14190(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 14153, 14190);
                    return return_v;
                }


                bool
                f_1243_14199_14231(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.IsInAllSets;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 14199, 14231);
                    return return_v;
                }


                uint
                f_1243_14700_14737(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 14700, 14737);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_13931_13959_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 13931, 13959);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_13430_13447_I(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 13430, 13447);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 12941, 15348);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 12941, 15348);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ApplyDefaultParameterBinding(string bindingStage, bool isDynamic)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 15809, 17296);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 15912, 16000) || true) && (!_useDefaultParameterBinding)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 15912, 16000);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 15978, 15985);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 15912, 16000);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 16016, 16303) || true) && (isDynamic)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 16016, 16303);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 16218, 16288);

                    _allDefaultParameterValuePairs = f_1243_16251_16287(this, false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 16016, 16303);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 16319, 16491);

                Dictionary<MergedCompiledCommandParameter, object>
                qualifiedParameterValuePairs = f_1243_16401_16490(this, _currentParameterSetFlag, _allDefaultParameterValuePairs)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 16505, 17262) || true) && (qualifiedParameterValuePairs != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 16505, 17262);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 16579, 16602);

                    bool
                    isSuccess = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 16620, 17142);
                    using (f_1243_16627_16814(ParameterBinderBase.bindingTracer, "BIND DEFAULT <parameter, value> pairs after [{0}] for [{1}]", bindingStage, f_1243_16792_16813(_commandMetadata)))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 16856, 16946);

                        isSuccess = f_1243_16868_16945(this, _currentParameterSetFlag, qualifiedParameterValuePairs);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 16968, 17123) || true) && (isSuccess && (DynAbs.Tracing.TraceSender.Expression_True(1243, 16972, 17014) && f_1243_16985_17014_M(!DefaultParameterBindingInUse)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 16968, 17123);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 17064, 17100);

                            DefaultParameterBindingInUse = true;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 16968, 17123);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1243, 16620, 17142);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 17162, 17247);

                    f_1243_17162_17246(
                                    s_tracer, "BIND DEFAULT after [{0}] result [{1}]", bindingStage, isSuccess);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 16505, 17262);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 17278, 17285);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 15809, 17296);

                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                f_1243_16251_16287(System.Management.Automation.CmdletParameterBinderController
                this_param, bool
                needToGetAlias)
                {
                    var return_v = this_param.GetDefaultParameterValuePairs(needToGetAlias);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 16251, 16287);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                f_1243_16401_16490(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                currentParameterSetFlag, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                availableParameterValuePairs)
                {
                    var return_v = this_param.GetQualifiedParameterValuePairs(currentParameterSetFlag, availableParameterValuePairs);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 16401, 16490);
                    return return_v;
                }


                string
                f_1243_16792_16813(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 16792, 16813);
                    return return_v;
                }


                System.IDisposable
                f_1243_16627_16814(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 16627, 16814);
                    return return_v;
                }


                bool
                f_1243_16868_16945(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                validParameterSetFlag, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                defaultParameterValues)
                {
                    var return_v = this_param.BindDefaultParameters(validParameterSetFlag, defaultParameterValues);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 16868, 16945);
                    return return_v;
                }


                bool
                f_1243_16985_17014_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 16985, 17014);
                    return return_v;
                }


                int
                f_1243_17162_17246(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, bool
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 17162, 17246);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 15809, 17296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 15809, 17296);
            }
        }

        private bool BindDefaultParameters(uint validParameterSetFlag, Dictionary<MergedCompiledCommandParameter, object> defaultParameterValues)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 17765, 21399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 17927, 17944);

                bool
                ret = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 17958, 21361);
                    foreach (var pair in f_1243_17979_18001_I(defaultParameterValues))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 17958, 21361);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 18035, 18087);

                        MergedCompiledCommandParameter
                        parameter = pair.Key
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 18105, 18139);

                        object
                        argumentValue = pair.Value
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 18157, 18205);

                        string
                        parameterName = f_1243_18180_18204(f_1243_18180_18199(parameter))
                        ;

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 18269, 18327);

                            ScriptBlock
                            scriptBlockArg = argumentValue as ScriptBlock
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 18349, 19437) || true) && (scriptBlockArg != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 18349, 19437);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 18832, 18866);

                                PSObject
                                arg = f_1243_18847_18865(this)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 18892, 18950);

                                Collection<PSObject>
                                results = f_1243_18923_18949(scriptBlockArg, arg)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 18976, 19414) || true) && (results == null || (DynAbs.Tracing.TraceSender.Expression_False(1243, 18980, 19017) || f_1243_18999_19012(results) == 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 18976, 19414);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 19075, 19084);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 18976, 19414);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 18976, 19414);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 19142, 19414) || true) && (f_1243_19146_19159(results) == 1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 19142, 19414);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 19222, 19249);

                                        argumentValue = f_1243_19238_19248(results, 0);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 19142, 19414);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 19142, 19414);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 19363, 19387);

                                        argumentValue = results;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 19142, 19414);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 18976, 19414);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 18349, 19437);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 19461, 19747);

                            CommandParameterInternal
                            bindableArgument =
                            f_1243_19530_19746(null, parameterName, "-" + parameterName + ":", null, argumentValue, false)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 19771, 20102);

                            bool
                            bindResult =
                            f_1243_19818_20101(this, validParameterSetFlag, bindableArgument, parameter, ParameterBindingFlags.ShouldCoerceType | ParameterBindingFlags.DelayBindScriptBlock)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 20126, 20232) || true) && (bindResult && (DynAbs.Tracing.TraceSender.Expression_True(1243, 20130, 20148) && !ret))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 20126, 20232);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 20198, 20209);

                                ret = true;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 20126, 20232);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 20256, 20385) || true) && (bindResult)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 20256, 20385);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 20320, 20362);

                                f_1243_20320_20361(f_1243_20320_20342(), parameterName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 20256, 20385);
                            }
                        }
                        catch (ParameterBindingException ex)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 20422, 21346);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 20684, 21294) || true) && (!f_1243_20689_20760(_warningSet, f_1243_20710_20731(_commandMetadata) + Separator + parameterName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 20684, 21294);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 20810, 21114);

                                string
                                message = f_1243_20827_21113(f_1243_20841_20869(), f_1243_20900_20949(), (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 20980, 21020) || ((f_1243_20980_21020(argumentValue) && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 21023, 21029)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 21032, 21056))) ? "null" : f_1243_21032_21056(argumentValue), parameterName, f_1243_21102_21112(ex))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 21140, 21178);

                                f_1243_21140_21177(_commandRuntime, message);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 21204, 21271);

                                f_1243_21204_21270(_warningSet, f_1243_21220_21241(_commandMetadata) + Separator + parameterName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 20684, 21294);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 21318, 21327);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 20422, 21346);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 17958, 21361);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 3404);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 3404);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 21377, 21388);

                return ret;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 17765, 21399);

                System.Management.Automation.CompiledCommandParameter
                f_1243_18180_18199(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 18180, 18199);
                    return return_v;
                }


                string
                f_1243_18180_18204(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 18180, 18204);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1243_18847_18865(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.WrapBindingState();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 18847, 18865);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1243_18923_18949(System.Management.Automation.ScriptBlock
                this_param, params object[]
                args)
                {
                    var return_v = this_param.Invoke(args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 18923, 18949);
                    return return_v;
                }


                int
                f_1243_18999_19012(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 18999, 19012);
                    return return_v;
                }


                int
                f_1243_19146_19159(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 19146, 19159);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1243_19238_19248(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 19238, 19248);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1243_19530_19746(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, object
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 19530, 19746);
                    return return_v;
                }


                bool
                f_1243_19818_20101(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                parameterSets, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(parameterSets, argument, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 19818, 20101);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1243_20320_20342()
                {
                    var return_v = BoundDefaultParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 20320, 20342);
                    return return_v;
                }


                int
                f_1243_20320_20361(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 20320, 20361);
                    return 0;
                }


                string
                f_1243_20710_20731(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 20710, 20731);
                    return return_v;
                }


                bool
                f_1243_20689_20760(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 20689, 20760);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1243_20841_20869()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 20841, 20869);
                    return return_v;
                }


                string
                f_1243_20900_20949()
                {
                    var return_v = ParameterBinderStrings.FailToBindDefaultParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 20900, 20949);
                    return return_v;
                }


                bool
                f_1243_20980_21020(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 20980, 21020);
                    return return_v;
                }


                string?
                f_1243_21032_21056(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 21032, 21056);
                    return return_v;
                }


                string
                f_1243_21102_21112(System.Management.Automation.ParameterBindingException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 21102, 21112);
                    return return_v;
                }


                string
                f_1243_20827_21113(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 20827, 21113);
                    return return_v;
                }


                int
                f_1243_21140_21177(System.Management.Automation.MshCommandRuntime
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 21140, 21177);
                    return 0;
                }


                string
                f_1243_21220_21241(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 21220, 21241);
                    return return_v;
                }


                bool
                f_1243_21204_21270(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 21204, 21270);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                f_1243_17979_18001_I(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 17979, 18001);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 17765, 21399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 17765, 21399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSObject WrapBindingState()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 21575, 22720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 21635, 21727);

                HashSet<string>
                boundParameterNames = f_1243_21673_21726(f_1243_21693_21725())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 21741, 21888);

                HashSet<string>
                boundPositionalParameterNames =
                f_1243_21806_21887(f_1243_21806_21855(f_1243_21806_21833(this)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 21902, 22001);

                HashSet<string>
                boundDefaultParameterNames = f_1243_21947_22000(f_1243_21967_21999())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 22017, 22150);
                    foreach (string paramName in f_1243_22046_22066_I(f_1243_22046_22066(f_1243_22046_22061())))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 22017, 22150);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 22100, 22135);

                        f_1243_22100_22134(boundParameterNames, paramName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 22017, 22150);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 134);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 134);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 22166, 22308);
                    foreach (string paramName in f_1243_22195_22217_I(f_1243_22195_22217()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 22166, 22308);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 22251, 22293);

                        f_1243_22251_22292(boundDefaultParameterNames, paramName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 22166, 22308);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 143);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 143);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 22324, 22357);

                PSObject
                result = f_1243_22342_22356()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 22371, 22453);

                f_1243_22371_22452(f_1243_22371_22388(result), f_1243_22393_22451("BoundParameters", boundParameterNames));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 22467, 22569);

                f_1243_22467_22568(f_1243_22467_22484(result), f_1243_22489_22567("BoundPositionalParameters", boundPositionalParameterNames));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 22583, 22679);

                f_1243_22583_22678(f_1243_22583_22600(result), f_1243_22605_22677("BoundDefaultParameters", boundDefaultParameterNames));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 22695, 22709);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 21575, 22720);

                System.StringComparer
                f_1243_21693_21725()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 21693, 21725);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1243_21673_21726(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 21673, 21726);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderBase
                f_1243_21806_21833(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 21806, 21833);
                    return return_v;
                }


                System.Management.Automation.CommandLineParameters
                f_1243_21806_21855(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.CommandLineParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 21806, 21855);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1243_21806_21887(System.Management.Automation.CommandLineParameters
                this_param)
                {
                    var return_v = this_param.CopyBoundPositionalParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 21806, 21887);
                    return return_v;
                }


                System.StringComparer
                f_1243_21967_21999()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 21967, 21999);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1243_21947_22000(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 21947, 22000);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_22046_22061()
                {
                    var return_v = BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 22046, 22061);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>.KeyCollection
                f_1243_22046_22066(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 22046, 22066);
                    return return_v;
                }


                bool
                f_1243_22100_22134(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 22100, 22134);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>.KeyCollection
                f_1243_22046_22066_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 22046, 22066);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1243_22195_22217()
                {
                    var return_v = BoundDefaultParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 22195, 22217);
                    return return_v;
                }


                bool
                f_1243_22251_22292(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 22251, 22292);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1243_22195_22217_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 22195, 22217);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1243_22342_22356()
                {
                    var return_v = new System.Management.Automation.PSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 22342, 22356);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1243_22371_22388(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 22371, 22388);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1243_22393_22451(string
                name, System.Collections.Generic.HashSet<string>
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 22393, 22451);
                    return return_v;
                }


                int
                f_1243_22371_22452(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 22371, 22452);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1243_22467_22484(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 22467, 22484);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1243_22489_22567(string
                name, System.Collections.Generic.HashSet<string>
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 22489, 22567);
                    return return_v;
                }


                int
                f_1243_22467_22568(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 22467, 22568);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1243_22583_22600(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 22583, 22600);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1243_22605_22677(string
                name, System.Collections.Generic.HashSet<string>
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 22605, 22677);
                    return return_v;
                }


                int
                f_1243_22583_22678(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 22583, 22678);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 21575, 22720);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 21575, 22720);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Dictionary<MergedCompiledCommandParameter, object> GetQualifiedParameterValuePairs(
                    uint currentParameterSetFlag,
                    Dictionary<MergedCompiledCommandParameter, object> availableParameterValuePairs)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 23087, 24716);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 23340, 23441) || true) && (availableParameterValuePairs == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 23340, 23441);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 23414, 23426);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 23340, 23441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 23457, 23574);

                Dictionary<MergedCompiledCommandParameter, object>
                result = f_1243_23517_23573()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 23590, 23633);

                uint
                possibleParameterFlag = uint.MaxValue
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 23647, 24578);
                    foreach (var pair in f_1243_23668_23696_I(availableParameterValuePairs))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 23647, 24578);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 23730, 23778);

                        MergedCompiledCommandParameter
                        param = pair.Key
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 23796, 23968) || true) && ((f_1243_23801_23834(f_1243_23801_23816(param)) & currentParameterSetFlag) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 23800, 23898) && f_1243_23870_23898_M(!f_1243_23871_23886(param).IsInAllSets)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 23796, 23968);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 23940, 23949);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 23796, 23968);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 23988, 24110) || true) && (f_1243_23992_24040(f_1243_23992_24006(), f_1243_24019_24039(f_1243_24019_24034(param))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 23988, 24110);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 24082, 24091);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 23988, 24110);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 24214, 24513) || true) && (f_1243_24218_24251(f_1243_24218_24233(param)) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 24214, 24513);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 24298, 24357);

                            possibleParameterFlag &= f_1243_24323_24356(f_1243_24323_24338(param));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 24379, 24494) || true) && (possibleParameterFlag == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 24379, 24494);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 24459, 24471);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 24379, 24494);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 24214, 24513);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 24533, 24563);

                        f_1243_24533_24562(
                                        result, param, pair.Value);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 23647, 24578);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 932);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 932);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 24594, 24677) || true) && (f_1243_24598_24610(result) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 24594, 24677);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 24648, 24662);

                    return result;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 24594, 24677);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 24693, 24705);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 23087, 24716);

                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                f_1243_23517_23573()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 23517, 23573);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_23801_23816(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 23801, 23816);
                    return return_v;
                }


                uint
                f_1243_23801_23834(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 23801, 23834);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_23871_23886(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 23871, 23886);
                    return return_v;
                }


                bool
                f_1243_23870_23898_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 23870, 23898);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
                f_1243_23992_24006()
                {
                    var return_v = BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 23992, 24006);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_24019_24034(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 24019, 24034);
                    return return_v;
                }


                string
                f_1243_24019_24039(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 24019, 24039);
                    return return_v;
                }


                bool
                f_1243_23992_24040(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 23992, 24040);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_24218_24233(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 24218, 24233);
                    return return_v;
                }


                uint
                f_1243_24218_24251(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 24218, 24251);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_24323_24338(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 24323, 24338);
                    return return_v;
                }


                uint
                f_1243_24323_24356(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 24323, 24356);
                    return return_v;
                }


                int
                f_1243_24533_24562(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 24533, 24562);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                f_1243_23668_23696_I(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 23668, 23696);
                    return return_v;
                }


                int
                f_1243_24598_24610(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 24598, 24610);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 23087, 24716);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 23087, 24716);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<string> GetAliasOfCurrentCmdlet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 24864, 25104);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 24935, 25035);

                var
                results = f_1243_24949_25034(f_1243_24949_25025(f_1243_24949_24978(f_1243_24949_24969(f_1243_24949_24956())), f_1243_25003_25024(_commandMetadata)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 25051, 25093);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 25058, 25075) || ((f_1243_25058_25071(results) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 25078, 25085)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 25088, 25092))) ? results : null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 24864, 25104);

                System.Management.Automation.ExecutionContext
                f_1243_24949_24956()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 24949, 24956);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1243_24949_24969(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 24949, 24969);
                    return return_v;
                }


                System.Management.Automation.SessionStateInternal
                f_1243_24949_24978(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Internal;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 24949, 24978);
                    return return_v;
                }


                string
                f_1243_25003_25024(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 25003, 25024);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1243_24949_25025(System.Management.Automation.SessionStateInternal
                this_param, string
                command)
                {
                    var return_v = this_param.GetAliasesByCommandName(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 24949, 25025);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1243_24949_25034(System.Collections.Generic.IEnumerable<string>
                source)
                {
                    var return_v = source.ToList<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 24949, 25034);
                    return return_v;
                }


                int
                f_1243_25058_25071(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 25058, 25071);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 24864, 25104);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 24864, 25104);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool MatchAnyAlias(string aliasName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 25325, 25891);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 25394, 25478) || true) && (_aliasList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 25394, 25478);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 25450, 25463);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 25394, 25478);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 25494, 25514);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 25528, 25618);

                WildcardPattern
                aliasPattern = f_1243_25559_25617(aliasName, WildcardOptions.IgnoreCase)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 25632, 25850);
                    foreach (string alias in f_1243_25657_25667_I(_aliasList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 25632, 25850);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 25701, 25835) || true) && (f_1243_25705_25732(aliasPattern, alias))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 25701, 25835);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 25774, 25788);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1243, 25810, 25816);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 25701, 25835);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 25632, 25850);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 219);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 219);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 25866, 25880);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 25325, 25891);

                System.Management.Automation.WildcardPattern
                f_1243_25559_25617(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 25559, 25617);
                    return return_v;
                }


                bool
                f_1243_25705_25732(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 25705, 25732);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1243_25657_25667_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 25657, 25667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 25325, 25891);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 25325, 25891);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal IDictionary DefaultParameterValues { get; set; }

        private Dictionary<MergedCompiledCommandParameter, object> GetDefaultParameterValuePairs(bool needToGetAlias)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 26178, 34875);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 26312, 26461) || true) && (f_1243_26316_26338() == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 26312, 26461);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 26380, 26416);

                    _useDefaultParameterBinding = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 26434, 26446);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 26312, 26461);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 26477, 26555);

                var
                availablePairs = f_1243_26498_26554()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 26571, 26771) || true) && (needToGetAlias && (DynAbs.Tracing.TraceSender.Expression_True(1243, 26575, 26625) && f_1243_26593_26621(f_1243_26593_26615()) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 26571, 26771);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 26717, 26756);

                    _aliasList = f_1243_26730_26755(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 26571, 26771);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 26831, 26866);

                _useDefaultParameterBinding = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 26882, 26931);

                string
                currentCmdletName = f_1243_26909_26930(_commandMetadata)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 26947, 27058);

                IDictionary<string, MergedCompiledCommandParameter>
                bindableParameters = f_1243_27020_27057(f_1243_27020_27038())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 27072, 27177);

                IDictionary<string, MergedCompiledCommandParameter>
                bindableAlias = f_1243_27140_27176(f_1243_27140_27158())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 27378, 27449);

                var
                parametersToRemove = f_1243_27403_27448()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 27463, 27518);

                var
                wildcardDefault = f_1243_27485_27517()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 27747, 27785);

                var
                keysToRemove = f_1243_27766_27784()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 27801, 29962);
                    foreach (DictionaryEntry entry in f_1243_27835_27857_I(f_1243_27835_27857()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 27801, 29962);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 27891, 27924);

                        string
                        key = entry.Key as string
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 27942, 28027) || true) && (key == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 27942, 28027);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 27999, 28008);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 27942, 28027);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 28047, 28064);

                        key = f_1243_28053_28063(key);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 28082, 28107);

                        string
                        cmdletName = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 28125, 28153);

                        string
                        parameterName = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 28224, 28948) || true) && (!f_1243_28229_28311(key, ref cmdletName, ref parameterName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 28224, 28948);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 28353, 28629) || true) && (f_1243_28357_28415(key, "Disabled", StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 28357, 28482) && f_1243_28444_28482(entry.Value)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 28353, 28629);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 28532, 28568);

                                _useDefaultParameterBinding = false;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 28594, 28606);

                                return null;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 28353, 28629);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 28732, 28896) || true) && (!f_1243_28737_28795(key, "Disabled", StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 28732, 28896);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 28845, 28873);

                                f_1243_28845_28872(keysToRemove, entry.Key);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 28732, 28896);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 28920, 28929);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 28224, 28948);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 28968, 29101);

                        f_1243_28968_29100(cmdletName != null && (DynAbs.Tracing.TraceSender.Expression_True(1243, 28987, 29030) && parameterName != null), "The cmdletName and parameterName should be set in CheckKeyIsValid");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 29121, 29337) || true) && (f_1243_29125_29172(key))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 29121, 29337);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 29214, 29287);

                            f_1243_29214_29286(wildcardDefault, cmdletName + Separator + parameterName, entry.Value);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 29309, 29318);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 29121, 29337);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 29539, 29716) || true) && (!f_1243_29544_29616(cmdletName, currentCmdletName, StringComparison.OrdinalIgnoreCase) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 29543, 29646) && !f_1243_29621_29646(this, cmdletName)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 29539, 29716);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 29688, 29697);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 29539, 29716);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 29736, 29947);

                        f_1243_29736_29946(this, cmdletName, parameterName, entry.Value, bindableParameters, bindableAlias, availablePairs, parametersToRemove);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 27801, 29962);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 2162);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 2162);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 29978, 33608);
                    foreach (KeyValuePair<string, object> wildcard in f_1243_30028_30043_I(wildcardDefault))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 29978, 33608);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 30077, 30103);

                        string
                        key = wildcard.Key
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 30123, 30220);

                        string
                        cmdletName = f_1243_30143_30219(key, 0, f_1243_30160_30218(key, Separator, StringComparison.OrdinalIgnoreCase))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 30238, 30354);

                        string
                        parameterName = f_1243_30261_30353(key, f_1243_30275_30333(key, Separator, StringComparison.OrdinalIgnoreCase) + f_1243_30336_30352(Separator))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 30374, 30466);

                        WildcardPattern
                        cmdletPattern = f_1243_30406_30465(cmdletName, WildcardOptions.IgnoreCase)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 30665, 30810) || true) && (!f_1243_30670_30710(cmdletPattern, currentCmdletName) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 30669, 30740) && !f_1243_30715_30740(this, cmdletName)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 30665, 30810);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 30782, 30791);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 30665, 30810);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 30830, 31212) || true) && (!f_1243_30835_30892(parameterName))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 30830, 31212);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 30934, 31160);

                            f_1243_30934_31159(this, cmdletName, parameterName, wildcard.Value, bindableParameters, bindableAlias, availablePairs, parametersToRemove);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 31184, 31193);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 30830, 31212);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 31232, 31309);

                        WildcardPattern
                        parameterPattern = f_1243_31267_31308(parameterName)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 31327, 31384);

                        var
                        matches = f_1243_31341_31383()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 31404, 31691);
                            foreach (KeyValuePair<string, MergedCompiledCommandParameter> entry in f_1243_31475_31493_I(bindableParameters))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 31404, 31691);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 31535, 31672) || true) && (f_1243_31539_31574(parameterPattern, entry.Key))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 31535, 31672);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 31624, 31649);

                                    f_1243_31624_31648(matches, entry.Value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 31535, 31672);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 31404, 31691);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 288);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 288);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 31711, 31993);
                            foreach (KeyValuePair<string, MergedCompiledCommandParameter> entry in f_1243_31782_31795_I(bindableAlias))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 31711, 31993);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 31837, 31974) || true) && (f_1243_31841_31876(parameterPattern, entry.Key))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 31837, 31974);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 31926, 31951);

                                    f_1243_31926_31950(matches, entry.Value);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 31837, 31974);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 31711, 31993);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 283);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 283);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 32013, 32654) || true) && (f_1243_32017_32030(matches) > 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 32013, 32654);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 32213, 32602) || true) && (!f_1243_32218_32278(_warningSet, cmdletName + Separator + parameterName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 32213, 32602);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 32328, 32497);

                                f_1243_32328_32496(_commandRuntime, f_1243_32387_32495(f_1243_32401_32429(), f_1243_32431_32479(), parameterName));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 32523, 32579);

                                f_1243_32523_32578(_warningSet, cmdletName + Separator + parameterName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 32213, 32602);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 32626, 32635);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 32013, 32654);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 32674, 33593) || true) && (f_1243_32678_32691(matches) == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 32674, 33593);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 32738, 32936) || true) && (!f_1243_32743_32781(availablePairs, f_1243_32770_32780(matches, 0)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 32738, 32936);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 32831, 32878);

                                f_1243_32831_32877(availablePairs, f_1243_32850_32860(matches, 0), wildcard.Value);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 32904, 32913);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 32738, 32936);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 32960, 33574) || true) && (!f_1243_32965_33014(wildcard.Value, f_1243_32987_33013(availablePairs, f_1243_33002_33012(matches, 0))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 32960, 33574);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 33064, 33488) || true) && (!f_1243_33069_33129(_warningSet, cmdletName + Separator + parameterName))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 33064, 33488);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 33187, 33375);

                                    f_1243_33187_33374(_commandRuntime, f_1243_33250_33373(f_1243_33264_33292(), f_1243_33294_33357(), parameterName));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 33405, 33461);

                                    f_1243_33405_33460(_warningSet, cmdletName + Separator + parameterName);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 33064, 33488);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 33516, 33551);

                                f_1243_33516_33550(
                                                        parametersToRemove, f_1243_33539_33549(matches, 0));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 32960, 33574);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 32674, 33593);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 29978, 33608);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 3631);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 3631);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 33624, 34560) || true) && (f_1243_33628_33646(keysToRemove) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 33624, 34560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 33684, 33722);

                    var
                    keysInError = f_1243_33702_33721()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 33740, 34040);
                        foreach (object badFormatKey in f_1243_33772_33784_I(keysToRemove))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 33740, 34040);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 33826, 33946) || true) && (f_1243_33830_33875(f_1243_33830_33852(), badFormatKey))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 33826, 33946);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 33902, 33946);

                                f_1243_33902_33945(f_1243_33902_33924(), badFormatKey);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 33826, 33946);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 33970, 34021);

                            f_1243_33970_34020(
                                                keysInError, f_1243_33989_34012(badFormatKey) + ", ");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 33740, 34040);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 301);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 301);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 34060, 34106);

                    f_1243_34060_34105(
                                    keysInError, f_1243_34079_34097(keysInError) - 2, 2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 34124, 34166);

                    var
                    multipleKeys = f_1243_34143_34161(keysToRemove) > 1
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 34184, 34404);

                    string
                    formatString = (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 34206, 34218) || ((multipleKeys
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 34266, 34312)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 34360, 34403))) ? f_1243_34266_34312() : f_1243_34360_34403()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 34422, 34545);

                    f_1243_34422_34544(_commandRuntime, f_1243_34473_34543(f_1243_34487_34515(), formatString, keysInError));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 33624, 34560);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 34576, 34721);
                    foreach (MergedCompiledCommandParameter param in f_1243_34625_34643_I(parametersToRemove))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 34576, 34721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 34677, 34706);

                        f_1243_34677_34705(availablePairs, param);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 34576, 34721);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 146);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 146);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 34737, 34836) || true) && (f_1243_34741_34761(availablePairs) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 34737, 34836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 34799, 34821);

                    return availablePairs;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 34737, 34836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 34852, 34864);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 26178, 34875);

                System.Collections.IDictionary
                f_1243_26316_26338()
                {
                    var return_v = DefaultParameterValues;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 26316, 26338);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                f_1243_26498_26554()
                {
                    var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 26498, 26554);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1243_26593_26615()
                {
                    var return_v = DefaultParameterValues;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 26593, 26615);
                    return return_v;
                }


                int
                f_1243_26593_26621(System.Collections.IDictionary
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 26593, 26621);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1243_26730_26755(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.GetAliasOfCurrentCmdlet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 26730, 26755);
                    return return_v;
                }


                string
                f_1243_26909_26930(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 26909, 26930);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_27020_27038()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 27020, 27038);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_27020_27057(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 27020, 27057);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_27140_27158()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 27140, 27158);
                    return return_v;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_27140_27176(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.AliasedParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 27140, 27176);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_27403_27448()
                {
                    var return_v = new System.Collections.Generic.HashSet<System.Management.Automation.MergedCompiledCommandParameter>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 27403, 27448);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1243_27485_27517()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 27485, 27517);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1243_27766_27784()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 27766, 27784);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1243_27835_27857()
                {
                    var return_v = DefaultParameterValues;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 27835, 27857);
                    return return_v;
                }


                string
                f_1243_28053_28063(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 28053, 28063);
                    return return_v;
                }


                bool
                f_1243_28229_28311(string
                key, ref string
                cmdletName, ref string
                parameterName)
                {
                    var return_v = DefaultParameterDictionary.CheckKeyIsValid(key, ref cmdletName, ref parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 28229, 28311);
                    return return_v;
                }


                bool
                f_1243_28357_28415(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 28357, 28415);
                    return return_v;
                }


                bool
                f_1243_28444_28482(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsTrue(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 28444, 28482);
                    return return_v;
                }


                bool
                f_1243_28737_28795(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 28737, 28795);
                    return return_v;
                }


                int
                f_1243_28845_28872(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 28845, 28872);
                    return 0;
                }


                int
                f_1243_28968_29100(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 28968, 29100);
                    return 0;
                }


                bool
                f_1243_29125_29172(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 29125, 29172);
                    return return_v;
                }


                int
                f_1243_29214_29286(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 29214, 29286);
                    return 0;
                }


                bool
                f_1243_29544_29616(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 29544, 29616);
                    return return_v;
                }


                bool
                f_1243_29621_29646(System.Management.Automation.CmdletParameterBinderController
                this_param, string
                aliasName)
                {
                    var return_v = this_param.MatchAnyAlias(aliasName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 29621, 29646);
                    return return_v;
                }


                int
                f_1243_29736_29946(System.Management.Automation.CmdletParameterBinderController
                this_param, string
                cmdletName, string
                paramName, object
                paramValue, System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                bindableParameters, System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                bindableAlias, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                result, System.Collections.Generic.HashSet<System.Management.Automation.MergedCompiledCommandParameter>
                parametersToRemove)
                {
                    this_param.GetDefaultParameterValuePairsHelper(cmdletName, paramName, paramValue, bindableParameters, bindableAlias, result, parametersToRemove);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 29736, 29946);
                    return 0;
                }


                System.Collections.IDictionary
                f_1243_27835_27857_I(System.Collections.IDictionary
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 27835, 27857);
                    return return_v;
                }


                int
                f_1243_30160_30218(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 30160, 30218);
                    return return_v;
                }


                string
                f_1243_30143_30219(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 30143, 30219);
                    return return_v;
                }


                int
                f_1243_30275_30333(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.IndexOf(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 30275, 30333);
                    return return_v;
                }


                int
                f_1243_30336_30352(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 30336, 30352);
                    return return_v;
                }


                string
                f_1243_30261_30353(string
                this_param, int
                startIndex)
                {
                    var return_v = this_param.Substring(startIndex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 30261, 30353);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1243_30406_30465(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 30406, 30465);
                    return return_v;
                }


                bool
                f_1243_30670_30710(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 30670, 30710);
                    return return_v;
                }


                bool
                f_1243_30715_30740(System.Management.Automation.CmdletParameterBinderController
                this_param, string
                aliasName)
                {
                    var return_v = this_param.MatchAnyAlias(aliasName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 30715, 30740);
                    return return_v;
                }


                bool
                f_1243_30835_30892(string
                pattern)
                {
                    var return_v = WildcardPattern.ContainsWildcardCharacters(pattern);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 30835, 30892);
                    return return_v;
                }


                int
                f_1243_30934_31159(System.Management.Automation.CmdletParameterBinderController
                this_param, string
                cmdletName, string
                paramName, object
                paramValue, System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                bindableParameters, System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                bindableAlias, System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                result, System.Collections.Generic.HashSet<System.Management.Automation.MergedCompiledCommandParameter>
                parametersToRemove)
                {
                    this_param.GetDefaultParameterValuePairsHelper(cmdletName, paramName, paramValue, bindableParameters, bindableAlias, result, parametersToRemove);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 30934, 31159);
                    return 0;
                }


                System.Management.Automation.WildcardPattern
                f_1243_31267_31308(string
                name)
                {
                    var return_v = MemberMatch.GetNamePattern(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 31267, 31308);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_31341_31383()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 31341, 31383);
                    return return_v;
                }


                bool
                f_1243_31539_31574(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 31539, 31574);
                    return return_v;
                }


                int
                f_1243_31624_31648(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 31624, 31648);
                    return 0;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_31475_31493_I(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 31475, 31493);
                    return return_v;
                }


                bool
                f_1243_31841_31876(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 31841, 31876);
                    return return_v;
                }


                int
                f_1243_31926_31950(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 31926, 31950);
                    return 0;
                }


                System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_31782_31795_I(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 31782, 31795);
                    return return_v;
                }


                int
                f_1243_32017_32030(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 32017, 32030);
                    return return_v;
                }


                bool
                f_1243_32218_32278(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 32218, 32278);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1243_32401_32429()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 32401, 32429);
                    return return_v;
                }


                string
                f_1243_32431_32479()
                {
                    var return_v = ParameterBinderStrings.MultipleParametersMatched;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 32431, 32479);
                    return return_v;
                }


                string
                f_1243_32387_32495(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 32387, 32495);
                    return return_v;
                }


                int
                f_1243_32328_32496(System.Management.Automation.MshCommandRuntime
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 32328, 32496);
                    return 0;
                }


                bool
                f_1243_32523_32578(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 32523, 32578);
                    return return_v;
                }


                int
                f_1243_32678_32691(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 32678, 32691);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1243_32770_32780(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 32770, 32780);
                    return return_v;
                }


                bool
                f_1243_32743_32781(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 32743, 32781);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1243_32850_32860(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 32850, 32860);
                    return return_v;
                }


                int
                f_1243_32831_32877(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 32831, 32877);
                    return 0;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1243_33002_33012(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 33002, 33012);
                    return return_v;
                }


                object
                f_1243_32987_33013(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 32987, 33013);
                    return return_v;
                }


                bool
                f_1243_32965_33014(object
                this_param, object
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 32965, 33014);
                    return return_v;
                }


                bool
                f_1243_33069_33129(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 33069, 33129);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1243_33264_33292()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 33264, 33292);
                    return return_v;
                }


                string
                f_1243_33294_33357()
                {
                    var return_v = ParameterBinderStrings.DifferentValuesAssignedToSingleParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 33294, 33357);
                    return return_v;
                }


                string
                f_1243_33250_33373(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 33250, 33373);
                    return return_v;
                }


                int
                f_1243_33187_33374(System.Management.Automation.MshCommandRuntime
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 33187, 33374);
                    return 0;
                }


                bool
                f_1243_33405_33460(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 33405, 33460);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1243_33539_33549(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 33539, 33549);
                    return return_v;
                }


                bool
                f_1243_33516_33550(System.Collections.Generic.HashSet<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 33516, 33550);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1243_30028_30043_I(System.Collections.Generic.Dictionary<string, object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 30028, 30043);
                    return return_v;
                }


                int
                f_1243_33628_33646(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 33628, 33646);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_33702_33721()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 33702, 33721);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1243_33830_33852()
                {
                    var return_v = DefaultParameterValues;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 33830, 33852);
                    return return_v;
                }


                bool
                f_1243_33830_33875(System.Collections.IDictionary
                this_param, object
                key)
                {
                    var return_v = this_param.Contains(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 33830, 33875);
                    return return_v;
                }


                System.Collections.IDictionary
                f_1243_33902_33924()
                {
                    var return_v = DefaultParameterValues;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 33902, 33924);
                    return return_v;
                }


                int
                f_1243_33902_33945(System.Collections.IDictionary
                this_param, object
                key)
                {
                    this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 33902, 33945);
                    return 0;
                }


                string?
                f_1243_33989_34012(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 33989, 34012);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_33970_34020(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 33970, 34020);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1243_33772_33784_I(System.Collections.Generic.List<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 33772, 33784);
                    return return_v;
                }


                int
                f_1243_34079_34097(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 34079, 34097);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_34060_34105(System.Text.StringBuilder
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Remove(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 34060, 34105);
                    return return_v;
                }


                int
                f_1243_34143_34161(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 34143, 34161);
                    return return_v;
                }


                string
                f_1243_34266_34312()
                {
                    var return_v = ParameterBinderStrings.MultipleKeysInBadFormat
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 34266, 34312);
                    return return_v;
                }


                string
                f_1243_34360_34403()
                {
                    var return_v = ParameterBinderStrings.SingleKeyInBadFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 34360, 34403);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1243_34487_34515()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 34487, 34515);
                    return return_v;
                }


                string
                f_1243_34473_34543(System.Globalization.CultureInfo
                provider, string
                format, System.Text.StringBuilder
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 34473, 34543);
                    return return_v;
                }


                int
                f_1243_34422_34544(System.Management.Automation.MshCommandRuntime
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 34422, 34544);
                    return 0;
                }


                bool
                f_1243_34677_34705(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 34677, 34705);
                    return return_v;
                }


                System.Collections.Generic.HashSet<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_34625_34643_I(System.Collections.Generic.HashSet<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 34625, 34643);
                    return return_v;
                }


                int
                f_1243_34741_34761(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 34741, 34761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 26178, 34875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 26178, 34875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void GetDefaultParameterValuePairsHelper(
                    string cmdletName, string paramName, object paramValue,
                    IDictionary<string, MergedCompiledCommandParameter> bindableParameters,
                    IDictionary<string, MergedCompiledCommandParameter> bindableAlias,
                    Dictionary<MergedCompiledCommandParameter, object> result,
                    HashSet<MergedCompiledCommandParameter> parametersToRemove)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 35341, 37684);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 36050, 36076);

                bool
                writeWarning = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 36090, 36136);

                MergedCompiledCommandParameter
                matchParameter
                = default(MergedCompiledCommandParameter);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 36150, 36170);

                object
                resultObject
                = default(object);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 36184, 37289) || true) && (f_1243_36188_36249(bindableParameters, paramName, out matchParameter))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 36184, 37289);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 36283, 36469) || true) && (!f_1243_36288_36340(result, matchParameter, out resultObject))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 36283, 36469);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 36382, 36421);

                        f_1243_36382_36420(result, matchParameter, paramValue);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 36443, 36450);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 36283, 36469);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 36489, 36667) || true) && (!f_1243_36494_36525(paramValue, resultObject))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 36489, 36667);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 36567, 36587);

                        writeWarning = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 36609, 36648);

                        f_1243_36609_36647(parametersToRemove, matchParameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 36489, 36667);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 36184, 37289);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 36184, 37289);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 36733, 37274) || true) && (f_1243_36737_36793(bindableAlias, paramName, out matchParameter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 36733, 37274);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 36835, 37037) || true) && (!f_1243_36840_36892(result, matchParameter, out resultObject))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 36835, 37037);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 36942, 36981);

                            f_1243_36942_36980(result, matchParameter, paramValue);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 37007, 37014);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 36835, 37037);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 37061, 37255) || true) && (!f_1243_37066_37097(paramValue, resultObject))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 37061, 37255);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 37147, 37167);

                            writeWarning = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 37193, 37232);

                            f_1243_37193_37231(parametersToRemove, matchParameter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 37061, 37255);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 36733, 37274);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 36184, 37289);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 37305, 37673) || true) && (writeWarning && (DynAbs.Tracing.TraceSender.Expression_True(1243, 37309, 37382) && !f_1243_37326_37382(_warningSet, cmdletName + Separator + paramName)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 37305, 37673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 37416, 37588);

                    f_1243_37416_37587(_commandRuntime, f_1243_37467_37586(f_1243_37481_37509(), f_1243_37511_37574(), paramName));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 37606, 37658);

                    f_1243_37606_37657(_warningSet, cmdletName + Separator + paramName);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 37305, 37673);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 35341, 37684);

                bool
                f_1243_36188_36249(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key, out System.Management.Automation.MergedCompiledCommandParameter
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 36188, 36249);
                    return return_v;
                }


                bool
                f_1243_36288_36340(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 36288, 36340);
                    return return_v;
                }


                int
                f_1243_36382_36420(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 36382, 36420);
                    return 0;
                }


                bool
                f_1243_36494_36525(object
                this_param, object
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 36494, 36525);
                    return return_v;
                }


                bool
                f_1243_36609_36647(System.Collections.Generic.HashSet<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 36609, 36647);
                    return return_v;
                }


                bool
                f_1243_36737_36793(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key, out System.Management.Automation.MergedCompiledCommandParameter
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 36737, 36793);
                    return return_v;
                }


                bool
                f_1243_36840_36892(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                key, out object
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 36840, 36892);
                    return return_v;
                }


                int
                f_1243_36942_36980(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, object>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 36942, 36980);
                    return 0;
                }


                bool
                f_1243_37066_37097(object
                this_param, object
                obj)
                {
                    var return_v = this_param.Equals(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 37066, 37097);
                    return return_v;
                }


                bool
                f_1243_37193_37231(System.Collections.Generic.HashSet<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 37193, 37231);
                    return return_v;
                }


                bool
                f_1243_37326_37382(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 37326, 37382);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1243_37481_37509()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 37481, 37509);
                    return return_v;
                }


                string
                f_1243_37511_37574()
                {
                    var return_v = ParameterBinderStrings.DifferentValuesAssignedToSingleParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 37511, 37574);
                    return return_v;
                }


                string
                f_1243_37467_37586(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 37467, 37586);
                    return return_v;
                }


                int
                f_1243_37416_37587(System.Management.Automation.MshCommandRuntime
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 37416, 37587);
                    return 0;
                }


                bool
                f_1243_37606_37657(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 37606, 37657);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 35341, 37684);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 35341, 37684);
            }
        }

        private void VerifyArgumentsProcessed(ParameterBindingException originalBindingException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 37962, 42361);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 38164, 42350) || true) && (f_1243_38168_38190(f_1243_38168_38184()) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 38164, 42350);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 38228, 38271);

                    ParameterBindingException
                    bindingException
                    = default(ParameterBindingException);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 38289, 38346);

                    CommandParameterInternal
                    parameter = f_1243_38326_38345(f_1243_38326_38342(), 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 38429, 38455);

                    Type
                    specifiedType = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 38473, 38520);

                    object
                    argumentValue = f_1243_38496_38519(parameter)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 38538, 38707) || true) && (argumentValue != null && (DynAbs.Tracing.TraceSender.Expression_True(1243, 38542, 38606) && argumentValue != f_1243_38584_38606()))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 38538, 38707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 38648, 38688);

                        specifiedType = f_1243_38664_38687(argumentValue);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 38538, 38707);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 38727, 42066) || true) && (f_1243_38731_38763(parameter))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 38727, 42066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 38805, 39325);

                        bindingException =
                        f_1243_38849_39324(ErrorCategory.InvalidArgument, f_1243_38969_38994(f_1243_38969_38981(this)), f_1243_39025_39059(this, parameter), f_1243_39090_39113(parameter), null, specifiedType, f_1243_39223_39268(), "NamedParameterNotFound");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 38727, 42066);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 38727, 42066);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 39556, 42047) || true) && (originalBindingException != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 39556, 42047);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 39642, 39686);

                            bindingException = originalBindingException;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 39556, 42047);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 39556, 42047);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 39841, 39885);

                            string
                            argument = StringLiterals.DollarNull
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 39911, 41475) || true) && (f_1243_39915_39938(parameter) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 39911, 41475);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 40072, 40118);

                                    argument = f_1243_40083_40117(f_1243_40083_40106(parameter));
                                }
                                catch (Exception e)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 40179, 41448);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 40263, 41020);

                                    bindingException =
                                    f_1243_40319_41019(e, ErrorCategory.InvalidData, f_1243_40525_40544(this), null, null, null, f_1243_40728_40761(f_1243_40728_40751(parameter)), f_1243_40804_40874(), "ParameterArgumentTransformationErrorMessageOnly", f_1243_41009_41018(e));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 41056, 41417) || true) && (f_1243_41060_41089_M(!DefaultParameterBindingInUse))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 41056, 41417);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 41163, 41186);

                                        throw bindingException;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 41056, 41417);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 41056, 41417);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 41332, 41382);

                                        f_1243_41332_41381(this, bindingException);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 41056, 41417);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 40179, 41448);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 39911, 41475);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 41503, 42024);

                            bindingException =
                            f_1243_41551_42023(ErrorCategory.InvalidArgument, f_1243_41679_41704(f_1243_41679_41691(this)), null, argument, null, specifiedType, f_1243_41908_41958(), "PositionalParameterNotFound");
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 39556, 42047);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 38727, 42066);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 42086, 42335) || true) && (f_1243_42090_42119_M(!DefaultParameterBindingInUse))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 42086, 42335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 42161, 42184);

                        throw bindingException;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 42086, 42335);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 42086, 42335);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 42266, 42316);

                        f_1243_42266_42315(this, bindingException);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 42086, 42335);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 38164, 42350);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 37962, 42361);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_38168_38184()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 38168, 38184);
                    return return_v;
                }


                int
                f_1243_38168_38190(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 38168, 38190);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_38326_38342()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 38326, 38342);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1243_38326_38345(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 38326, 38345);
                    return return_v;
                }


                object
                f_1243_38496_38519(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 38496, 38519);
                    return return_v;
                }


                object
                f_1243_38584_38606()
                {
                    var return_v = UnboundParameter.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 38584, 38606);
                    return return_v;
                }


                System.Type
                f_1243_38664_38687(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 38664, 38687);
                    return return_v;
                }


                bool
                f_1243_38731_38763(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterNameSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 38731, 38763);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_38969_38981(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 38969, 38981);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_38969_38994(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 38969, 38994);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1243_39025_39059(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetParameterErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 39025, 39059);
                    return return_v;
                }


                string
                f_1243_39090_39113(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 39090, 39113);
                    return return_v;
                }


                string
                f_1243_39223_39268()
                {
                    var return_v = ParameterBinderStrings.NamedParameterNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 39223, 39268);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1243_38849_39324(System.Management.Automation.ErrorCategory
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 38849, 39324);
                    return return_v;
                }


                object
                f_1243_39915_39938(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 39915, 39938);
                    return return_v;
                }


                object
                f_1243_40083_40106(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 40083, 40106);
                    return return_v;
                }


                string?
                f_1243_40083_40117(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 40083, 40117);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_40525_40544(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 40525, 40544);
                    return return_v;
                }


                object
                f_1243_40728_40751(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 40728, 40751);
                    return return_v;
                }


                System.Type
                f_1243_40728_40761(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 40728, 40761);
                    return return_v;
                }


                string
                f_1243_40804_40874()
                {
                    var return_v = ParameterBinderStrings.ParameterArgumentTransformationErrorMessageOnly;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 40804, 40874);
                    return return_v;
                }


                string
                f_1243_41009_41018(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 41009, 41018);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingArgumentTransformationException
                f_1243_40319_41019(System.Exception
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
                    var return_v = new System.Management.Automation.ParameterBindingArgumentTransformationException(innerException, errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 40319, 41019);
                    return return_v;
                }


                bool
                f_1243_41060_41089_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 41060, 41089);
                    return return_v;
                }


                int
                f_1243_41332_41381(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.ParameterBindingException
                pbex)
                {
                    this_param.ThrowElaboratedBindingException(pbex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 41332, 41381);
                    return 0;
                }


                System.Management.Automation.Cmdlet
                f_1243_41679_41691(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 41679, 41691);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_41679_41704(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 41679, 41704);
                    return return_v;
                }


                string
                f_1243_41908_41958()
                {
                    var return_v = ParameterBinderStrings.PositionalParameterNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 41908, 41958);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1243_41551_42023(System.Management.Automation.ErrorCategory
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 41551, 42023);
                    return return_v;
                }


                bool
                f_1243_42090_42119_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 42090, 42119);
                    return return_v;
                }


                int
                f_1243_42266_42315(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.ParameterBindingException
                pbex)
                {
                    this_param.ThrowElaboratedBindingException(pbex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 42266, 42315);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 37962, 42361);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 37962, 42361);
            }
        }

        private void VerifyParameterSetSelected()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 42598, 44181);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 42784, 44170) || true) && (f_1243_42788_42829(f_1243_42788_42811(this)) > 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 42784, 44170);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 42867, 44155) || true) && (_currentParameterSetFlag == uint.MaxValue)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 42867, 44155);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 42954, 44136) || true) && ((_currentParameterSetFlag &
                        f_1243_43012_43052(_commandMetadata)) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 42958, 43145) && f_1243_43088_43128(_commandMetadata) != uint.MaxValue))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 42954, 44136);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 43195, 43491);

                            f_1243_43195_43490(ParameterBinderBase.bindingTracer, "{0} valid parameter sets, using the DEFAULT PARAMETER SET: [{0}]", f_1243_43366_43418(f_1243_43366_43407(f_1243_43366_43389(this))), f_1243_43449_43489(_commandMetadata));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 43519, 43616);

                            _currentParameterSetFlag =
                            f_1243_43575_43615(_commandMetadata);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 42954, 44136);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 42954, 44136);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 43714, 43928);

                            f_1243_43714_43927(ParameterBinderBase.bindingTracer, "ERROR: {0} valid parameter sets, but NOT DEFAULT PARAMETER SET.", f_1243_43885_43926(f_1243_43885_43908(this)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 44031, 44113);

                            f_1243_44031_44112(this, _currentParameterSetFlag, f_1243_44093_44111());
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 42954, 44136);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 42867, 44155);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 42784, 44170);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 42598, 44181);

                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_42788_42811(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 42788, 42811);
                    return return_v;
                }


                int
                f_1243_42788_42829(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 42788, 42829);
                    return return_v;
                }


                uint
                f_1243_43012_43052(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 43012, 43052);
                    return return_v;
                }


                uint
                f_1243_43088_43128(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 43088, 43128);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_43366_43389(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 43366, 43389);
                    return return_v;
                }


                int
                f_1243_43366_43407(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 43366, 43407);
                    return return_v;
                }


                string
                f_1243_43366_43418(int
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 43366, 43418);
                    return return_v;
                }


                string
                f_1243_43449_43489(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 43449, 43489);
                    return return_v;
                }


                int
                f_1243_43195_43490(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, string
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 43195, 43490);
                    return 0;
                }


                uint
                f_1243_43575_43615(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 43575, 43615);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_43885_43908(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 43885, 43908);
                    return return_v;
                }


                int
                f_1243_43885_43926(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 43885, 43926);
                    return return_v;
                }


                int
                f_1243_43714_43927(System.Management.Automation.PSTraceSource
                this_param, string
                errorMessageFormat, params object[]
                args)
                {
                    this_param.TraceError(errorMessageFormat, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 43714, 43927);
                    return 0;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_44093_44111()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 44093, 44111);
                    return return_v;
                }


                int
                f_1243_44031_44112(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                parameterSetFlags, System.Management.Automation.MergedCommandParameterMetadata
                bindableParameters)
                {
                    this_param.ThrowAmbiguousParameterSetException(parameterSetFlags, bindableParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 44031, 44112);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 42598, 44181);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 42598, 44181);
            }
        }

        private bool RestoreParameter(CommandParameterInternal argumentToBind, MergedCompiledCommandParameter parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 44675, 47442);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 44812, 47403);

                switch (f_1243_44820_44847(parameter))
                {

                    case ParameterBinderAssociation.DeclaredFormalParameters:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 44812, 47403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 44960, 45078);

                        f_1243_44960_45077(f_1243_44960_44982(), f_1243_44997_45025(argumentToBind), f_1243_45027_45055(argumentToBind), f_1243_45057_45076(parameter));
                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 45100, 45106);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 44812, 47403);

                    case ParameterBinderAssociation.CommonParameters:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 44812, 47403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 45197, 45315);

                        f_1243_45197_45314(f_1243_45197_45219(), f_1243_45234_45262(argumentToBind), f_1243_45264_45292(argumentToBind), f_1243_45294_45313(parameter));
                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 45337, 45343);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 44812, 47403);

                    case ParameterBinderAssociation.ShouldProcessParameters:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 44812, 47403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 45441, 45662);

                        f_1243_45441_45661(f_1243_45486_45524(_commandMetadata), "The metadata for the ShouldProcessParameters should only be available if the command supports ShouldProcess");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 45686, 45811);

                        f_1243_45686_45810(f_1243_45686_45715(), f_1243_45730_45758(argumentToBind), f_1243_45760_45788(argumentToBind), f_1243_45790_45809(parameter));
                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 45833, 45839);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 44812, 47403);

                    case ParameterBinderAssociation.PagingParameters:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 44812, 47403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 45930, 46130);

                        f_1243_45930_46129(f_1243_45975_46006(_commandMetadata), "The metadata for the PagingParameters should only be available if the command supports paging");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 46154, 46272);

                        f_1243_46154_46271(f_1243_46154_46176(), f_1243_46191_46219(argumentToBind), f_1243_46221_46249(argumentToBind), f_1243_46251_46270(parameter));
                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 46294, 46300);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 44812, 47403);

                    case ParameterBinderAssociation.TransactionParameters:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 44812, 47403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 46396, 46613);

                        f_1243_46396_46612(f_1243_46441_46478(_commandMetadata), "The metadata for the TransactionParameters should only be available if the command supports Transactions");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 46637, 46760);

                        f_1243_46637_46759(f_1243_46637_46664(), f_1243_46679_46707(argumentToBind), f_1243_46709_46737(argumentToBind), f_1243_46739_46758(parameter));
                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 46782, 46788);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 44812, 47403);

                    case ParameterBinderAssociation.DynamicParameters:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 44812, 47403);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 46880, 47107);

                        f_1243_46880_47106(f_1243_46925_46969(_commandMetadata), "The metadata for the dynamic parameters should only be available if the command supports IDynamicParameters");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 47131, 47358) || true) && (_dynamicParameterBinder != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 47131, 47358);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 47216, 47335);

                            f_1243_47216_47334(_dynamicParameterBinder, f_1243_47254_47282(argumentToBind), f_1243_47284_47312(argumentToBind), f_1243_47314_47333(parameter));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 47131, 47358);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 47382, 47388);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 44812, 47403);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 47419, 47431);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 44675, 47442);

                System.Management.Automation.ParameterBinderAssociation
                f_1243_44820_44847(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.BinderAssociation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 44820, 44847);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderBase
                f_1243_44960_44982()
                {
                    var return_v = DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 44960, 44982);
                    return return_v;
                }


                string
                f_1243_44997_45025(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 44997, 45025);
                    return return_v;
                }


                object
                f_1243_45027_45055(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 45027, 45055);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_45057_45076(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 45057, 45076);
                    return return_v;
                }


                int
                f_1243_44960_45077(System.Management.Automation.ParameterBinderBase
                this_param, string
                name, object
                value, System.Management.Automation.CompiledCommandParameter
                parameterMetadata)
                {
                    this_param.BindParameter(name, value, parameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 44960, 45077);
                    return 0;
                }


                System.Management.Automation.ReflectionParameterBinder
                f_1243_45197_45219()
                {
                    var return_v = CommonParametersBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 45197, 45219);
                    return return_v;
                }


                string
                f_1243_45234_45262(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 45234, 45262);
                    return return_v;
                }


                object
                f_1243_45264_45292(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 45264, 45292);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_45294_45313(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 45294, 45313);
                    return return_v;
                }


                int
                f_1243_45197_45314(System.Management.Automation.ReflectionParameterBinder
                this_param, string
                name, object
                value, System.Management.Automation.CompiledCommandParameter
                parameterMetadata)
                {
                    this_param.BindParameter(name, value, parameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 45197, 45314);
                    return 0;
                }


                bool
                f_1243_45486_45524(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.SupportsShouldProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 45486, 45524);
                    return return_v;
                }


                int
                f_1243_45441_45661(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 45441, 45661);
                    return 0;
                }


                System.Management.Automation.ReflectionParameterBinder
                f_1243_45686_45715()
                {
                    var return_v = ShouldProcessParametersBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 45686, 45715);
                    return return_v;
                }


                string
                f_1243_45730_45758(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 45730, 45758);
                    return return_v;
                }


                object
                f_1243_45760_45788(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 45760, 45788);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_45790_45809(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 45790, 45809);
                    return return_v;
                }


                int
                f_1243_45686_45810(System.Management.Automation.ReflectionParameterBinder
                this_param, string
                name, object
                value, System.Management.Automation.CompiledCommandParameter
                parameterMetadata)
                {
                    this_param.BindParameter(name, value, parameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 45686, 45810);
                    return 0;
                }


                bool
                f_1243_45975_46006(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.SupportsPaging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 45975, 46006);
                    return return_v;
                }


                int
                f_1243_45930_46129(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 45930, 46129);
                    return 0;
                }


                System.Management.Automation.ReflectionParameterBinder
                f_1243_46154_46176()
                {
                    var return_v = PagingParametersBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 46154, 46176);
                    return return_v;
                }


                string
                f_1243_46191_46219(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 46191, 46219);
                    return return_v;
                }


                object
                f_1243_46221_46249(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 46221, 46249);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_46251_46270(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 46251, 46270);
                    return return_v;
                }


                int
                f_1243_46154_46271(System.Management.Automation.ReflectionParameterBinder
                this_param, string
                name, object
                value, System.Management.Automation.CompiledCommandParameter
                parameterMetadata)
                {
                    this_param.BindParameter(name, value, parameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 46154, 46271);
                    return 0;
                }


                bool
                f_1243_46441_46478(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.SupportsTransactions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 46441, 46478);
                    return return_v;
                }


                int
                f_1243_46396_46612(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 46396, 46612);
                    return 0;
                }


                System.Management.Automation.ReflectionParameterBinder
                f_1243_46637_46664()
                {
                    var return_v = TransactionParametersBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 46637, 46664);
                    return return_v;
                }


                string
                f_1243_46679_46707(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 46679, 46707);
                    return return_v;
                }


                object
                f_1243_46709_46737(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 46709, 46737);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_46739_46758(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 46739, 46758);
                    return return_v;
                }


                int
                f_1243_46637_46759(System.Management.Automation.ReflectionParameterBinder
                this_param, string
                name, object
                value, System.Management.Automation.CompiledCommandParameter
                parameterMetadata)
                {
                    this_param.BindParameter(name, value, parameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 46637, 46759);
                    return 0;
                }


                bool
                f_1243_46925_46969(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.ImplementsDynamicParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 46925, 46969);
                    return return_v;
                }


                int
                f_1243_46880_47106(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 46880, 47106);
                    return 0;
                }


                string
                f_1243_47254_47282(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 47254, 47282);
                    return return_v;
                }


                object
                f_1243_47284_47312(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 47284, 47312);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_47314_47333(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 47314, 47333);
                    return return_v;
                }


                int
                f_1243_47216_47334(System.Management.Automation.ParameterBinderBase
                this_param, string
                name, object
                value, System.Management.Automation.CompiledCommandParameter
                parameterMetadata)
                {
                    this_param.BindParameter(name, value, parameterMetadata);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 47216, 47334);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 44675, 47442);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 44675, 47442);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Collection<CommandParameterInternal> BindParameters(uint parameterSets, Collection<CommandParameterInternal> arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 48508, 53422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 48660, 48749);

                Collection<CommandParameterInternal>
                result = f_1243_48706_48748()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 48765, 53381);
                    foreach (CommandParameterInternal argument in f_1243_48811_48820_I(arguments))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 48765, 53381);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 48854, 49003) || true) && (f_1243_48858_48890_M(!argument.ParameterNameSpecified))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 48854, 49003);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 48932, 48953);

                            f_1243_48932_48952(result, argument);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 48975, 48984);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 48854, 49003);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 49222, 49516);

                        MergedCompiledCommandParameter
                        parameter =
                        f_1243_49286_49515(f_1243_49286_49304(), f_1243_49352_49374(argument), false, true, f_1243_49439_49514(f_1243_49458_49487(f_1243_49458_49477(this)), f_1243_49489_49513(argument)))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 49660, 53366) || true) && (parameter != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 49660, 53366);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 49870, 50787) || true) && (f_1243_49874_49927(f_1243_49874_49889(), f_1243_49902_49926(f_1243_49902_49921(parameter))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 49870, 50787);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 49977, 50569);

                                ParameterBindingException
                                bindingException =
                                f_1243_50051_50568(ErrorCategory.InvalidArgument, f_1243_50179_50198(this), f_1243_50233_50266(this, argument), f_1243_50301_50323(argument), null, null, f_1243_50436_50480(), nameof(ParameterBinderStrings.ParameterAlreadyBound))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 50741, 50764);

                                throw bindingException;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 49870, 50787);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 50811, 52124) || true) && ((f_1243_50816_50853(f_1243_50816_50835(parameter)) & parameterSets) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 50815, 50936) && f_1243_50904_50936_M(!f_1243_50905_50924(parameter).IsInAllSets)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 50811, 52124);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 50986, 51066);

                                string
                                parameterSetName = f_1243_51012_51065(f_1243_51012_51030(), parameterSets)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 51094, 51695);

                                ParameterBindingException
                                bindingException =
                                f_1243_51168_51694(ErrorCategory.InvalidArgument, f_1243_51296_51321(f_1243_51296_51308(this)), null, f_1243_51395_51417(argument), null, null, f_1243_51530_51579(), "ParameterNotInParameterSet", parameterSetName)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 51796, 52101) || true) && (f_1243_51800_51829_M(!DefaultParameterBindingInUse))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 51796, 52101);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 51887, 51910);

                                    throw bindingException;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 51796, 52101);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 51796, 52101);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 52024, 52074);

                                    f_1243_52024_52073(this, bindingException);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 51796, 52101);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 50811, 52124);
                            }

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 52200, 52364);

                                f_1243_52200_52363(this, parameterSets, argument, parameter, ParameterBindingFlags.ShouldCoerceType | ParameterBindingFlags.DelayBindScriptBlock);
                            }
                            catch (ParameterBindingException pbex)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 52409, 52709);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 52496, 52620) || true) && (f_1243_52500_52529_M(!DefaultParameterBindingInUse))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 52496, 52620);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 52587, 52593);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 52496, 52620);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 52648, 52686);

                                f_1243_52648_52685(this, pbex);
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 52409, 52709);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 49660, 53366);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 49660, 53366);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 52751, 53366) || true) && (f_1243_52755_52841(f_1243_52755_52777(argument), Parser.VERBATIM_PARAMETERNAME, StringComparison.Ordinal))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 52751, 53366);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 53148, 53244);

                                f_1243_53148_53243(f_1243_53148_53192(f_1243_53148_53170()), f_1243_53220_53242(argument));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 52751, 53366);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 52751, 53366);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 53326, 53347);

                                f_1243_53326_53346(result, argument);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 52751, 53366);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 49660, 53366);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 48765, 53381);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 4617);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 4617);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 53397, 53411);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 48508, 53422);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_48706_48748()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 48706, 48748);
                    return return_v;
                }


                bool
                f_1243_48858_48890_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 48858, 48890);
                    return return_v;
                }


                int
                f_1243_48932_48952(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 48932, 48952);
                    return 0;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_49286_49304()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 49286, 49304);
                    return return_v;
                }


                string
                f_1243_49352_49374(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 49352, 49374);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_49458_49477(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 49458, 49477);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1243_49458_49487(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 49458, 49487);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1243_49489_49513(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterExtent;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 49489, 49513);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_49439_49514(System.Management.Automation.CommandInfo
                commandInfo, System.Management.Automation.Language.IScriptExtent
                scriptPosition)
                {
                    var return_v = new System.Management.Automation.InvocationInfo(commandInfo, scriptPosition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 49439, 49514);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1243_49286_49515(System.Management.Automation.MergedCommandParameterMetadata
                this_param, string
                name, bool
                throwOnParameterNotFound, bool
                tryExactMatching, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = this_param.GetMatchingParameter(name, throwOnParameterNotFound, tryExactMatching, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 49286, 49515);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_49874_49889()
                {
                    var return_v = BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 49874, 49889);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_49902_49921(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 49902, 49921);
                    return return_v;
                }


                string
                f_1243_49902_49926(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 49902, 49926);
                    return return_v;
                }


                bool
                f_1243_49874_49927(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 49874, 49927);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_50179_50198(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 50179, 50198);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1243_50233_50266(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetParameterErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 50233, 50266);
                    return return_v;
                }


                string
                f_1243_50301_50323(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 50301, 50323);
                    return return_v;
                }


                string
                f_1243_50436_50480()
                {
                    var return_v = ParameterBinderStrings.ParameterAlreadyBound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 50436, 50480);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1243_50051_50568(System.Management.Automation.ErrorCategory
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 50051, 50568);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_50816_50835(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 50816, 50835);
                    return return_v;
                }


                uint
                f_1243_50816_50853(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 50816, 50853);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_50905_50924(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 50905, 50924);
                    return return_v;
                }


                bool
                f_1243_50904_50936_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 50904, 50936);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_51012_51030()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 51012, 51030);
                    return return_v;
                }


                string
                f_1243_51012_51065(System.Management.Automation.MergedCommandParameterMetadata
                this_param, uint
                parameterSet)
                {
                    var return_v = this_param.GetParameterSetName(parameterSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 51012, 51065);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_51296_51308(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 51296, 51308);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_51296_51321(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 51296, 51321);
                    return return_v;
                }


                string
                f_1243_51395_51417(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 51395, 51417);
                    return return_v;
                }


                string
                f_1243_51530_51579()
                {
                    var return_v = ParameterBinderStrings.ParameterNotInParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 51530, 51579);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1243_51168_51694(System.Management.Automation.ErrorCategory
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 51168, 51694);
                    return return_v;
                }


                bool
                f_1243_51800_51829_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 51800, 51829);
                    return return_v;
                }


                int
                f_1243_52024_52073(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.ParameterBindingException
                pbex)
                {
                    this_param.ThrowElaboratedBindingException(pbex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 52024, 52073);
                    return 0;
                }


                bool
                f_1243_52200_52363(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                parameterSets, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(parameterSets, argument, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 52200, 52363);
                    return return_v;
                }


                bool
                f_1243_52500_52529_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 52500, 52529);
                    return return_v;
                }


                int
                f_1243_52648_52685(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.ParameterBindingException
                pbex)
                {
                    this_param.ThrowElaboratedBindingException(pbex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 52648, 52685);
                    return 0;
                }


                string
                f_1243_52755_52777(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 52755, 52777);
                    return return_v;
                }


                bool
                f_1243_52755_52841(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 52755, 52841);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderBase
                f_1243_53148_53170()
                {
                    var return_v = DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 53148, 53170);
                    return return_v;
                }


                System.Management.Automation.CommandLineParameters
                f_1243_53148_53192(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.CommandLineParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 53148, 53192);
                    return return_v;
                }


                object
                f_1243_53220_53242(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 53220, 53242);
                    return return_v;
                }


                int
                f_1243_53148_53243(System.Management.Automation.CommandLineParameters
                this_param, object
                obj)
                {
                    this_param.SetImplicitUsingParameters(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 53148, 53243);
                    return 0;
                }


                int
                f_1243_53326_53346(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 53326, 53346);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_48811_48820_I(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 48811, 48820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 48508, 53422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 48508, 53422);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool IsParameterScriptBlockBindable(MergedCompiledCommandParameter parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1243, 54008, 55822);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 54125, 54145);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 54161, 54207);

                Type
                parameterType = f_1243_54182_54206(f_1243_54182_54201(parameter))
                ;
                {
                    try
                    {
                        do // false loop

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 54223, 55692);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 54272, 54410) || true) && (parameterType == typeof(object))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 54272, 54410);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 54349, 54363);

                                result = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1243, 54385, 54391);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 54272, 54410);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 54430, 54573) || true) && (parameterType == typeof(ScriptBlock))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 54430, 54573);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 54512, 54526);

                                result = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1243, 54548, 54554);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 54430, 54573);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 54593, 54747) || true) && (f_1243_54597_54644(parameterType, typeof(ScriptBlock)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 54593, 54747);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 54686, 54700);

                                result = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1243, 54722, 54728);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 54593, 54747);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 54767, 54878);

                            ParameterCollectionTypeInformation
                            parameterCollectionTypeInfo = f_1243_54832_54877(f_1243_54832_54851(parameter))
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 54896, 55662) || true) && (f_1243_54900_54951(parameterCollectionTypeInfo) != ParameterCollectionType.NotCollection)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 54896, 55662);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 55034, 55214) || true) && (f_1243_55038_55077(parameterCollectionTypeInfo) == typeof(object))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 55034, 55214);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 55145, 55159);

                                    result = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1243, 55185, 55191);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 55034, 55214);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 55238, 55423) || true) && (f_1243_55242_55281(parameterCollectionTypeInfo) == typeof(ScriptBlock))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 55238, 55423);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 55354, 55368);

                                    result = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1243, 55394, 55400);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 55238, 55423);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 55447, 55643) || true) && (f_1243_55451_55524(f_1243_55451_55490(parameterCollectionTypeInfo), typeof(ScriptBlock)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 55447, 55643);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 55574, 55588);

                                    result = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1243, 55614, 55620);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 55447, 55643);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 54896, 55662);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 54223, 55692);
                        }
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 54223, 55692) || true) && (false)
                        );
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 54223, 55692);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 54223, 55692);
                    }
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 55708, 55783);

                f_1243_55708_55782(
                            s_tracer, "IsParameterScriptBlockBindable: result = {0}", result);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 55797, 55811);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1243, 54008, 55822);

                System.Management.Automation.CompiledCommandParameter
                f_1243_54182_54201(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 54182, 54201);
                    return return_v;
                }


                System.Type
                f_1243_54182_54206(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 54182, 54206);
                    return return_v;
                }


                bool
                f_1243_54597_54644(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsSubclassOf(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 54597, 54644);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_54832_54851(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 54832, 54851);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionTypeInformation
                f_1243_54832_54877(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.CollectionTypeInformation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 54832, 54877);
                    return return_v;
                }


                System.Management.Automation.ParameterCollectionType
                f_1243_54900_54951(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ParameterCollectionType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 54900, 54951);
                    return return_v;
                }


                System.Type
                f_1243_55038_55077(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 55038, 55077);
                    return return_v;
                }


                System.Type
                f_1243_55242_55281(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 55242, 55281);
                    return return_v;
                }


                System.Type
                f_1243_55451_55490(System.Management.Automation.ParameterCollectionTypeInformation
                this_param)
                {
                    var return_v = this_param.ElementType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 55451, 55490);
                    return return_v;
                }


                bool
                f_1243_55451_55524(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsSubclassOf(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 55451, 55524);
                    return return_v;
                }


                int
                f_1243_55708_55782(System.Management.Automation.PSTraceSource
                this_param, string
                format, bool
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 55708, 55782);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 54008, 55822);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 54008, 55822);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override Collection<CommandParameterInternal> BindParameters(Collection<CommandParameterInternal> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 56038, 56241);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 56181, 56230);

                return f_1243_56188_56229(this, uint.MaxValue, parameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 56038, 56241);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_56188_56229(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                parameterSets, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                arguments)
                {
                    var return_v = this_param.BindParameters(parameterSets, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 56188, 56229);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 56038, 56241);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 56038, 56241);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override bool BindParameter(
                    uint parameterSets,
                    CommandParameterInternal argument,
                    MergedCompiledCommandParameter parameter,
                    ParameterBindingFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 57781, 63261);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 58550, 58582);

                bool
                continueWithBinding = true
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 58598, 61993) || true) && ((flags & ParameterBindingFlags.DelayBindScriptBlock) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 58602, 58748) && f_1243_58680_58748(f_1243_58680_58699(parameter), parameterSets)) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 58602, 58795) && f_1243_58769_58795(argument)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 58598, 61993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 58829, 58875);

                    object
                    argumentValue = f_1243_58852_58874(argument)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 58893, 61978) || true) && ((argumentValue is ScriptBlock || (DynAbs.Tracing.TraceSender.Expression_False(1243, 58898, 58973) || argumentValue is DelayedScriptBlockArgument)) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 58897, 59041) && !f_1243_59000_59041(parameter)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 58893, 61978);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 59400, 60209) || true) && (f_1243_59404_59428(_commandRuntime) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 59404, 59463) && f_1243_59432_59463(f_1243_59432_59457(_commandRuntime))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 59400, 60209);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 59513, 60135);

                            ParameterBindingException
                            bindingException =
                            f_1243_59587_60134(ErrorCategory.MetadataError, f_1243_59721_59746(f_1243_59721_59733(this)), f_1243_59785_59809(this, argument), f_1243_59848_59872(f_1243_59848_59867(parameter)), f_1243_59911_59935(f_1243_59911_59930(parameter)), null, f_1243_60017_60066(), "ScriptBlockArgumentNoInput")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 60163, 60186);

                            throw bindingException;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 59400, 60209);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 60233, 60415);

                        f_1243_60233_60414(
                                            ParameterBinderBase.bindingTracer, "Adding ScriptBlock to delay-bind list for parameter '{0}'", f_1243_60389_60413(f_1243_60389_60408(parameter)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 60524, 60753);

                        DelayedScriptBlockArgument
                        delayedArg = argumentValue as DelayedScriptBlockArgument ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Management.Automation.CmdletParameterBinderController.DelayedScriptBlockArgument>(1243, 60564, 60752) ?? new DelayedScriptBlockArgument { _argument = DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => argument, 1243, 60672, 60752), _parameterBinder = this })
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 60775, 60948) || true) && (!f_1243_60780_60825(_delayBindScriptBlocks, parameter))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 60775, 60948);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 60875, 60925);

                            f_1243_60875_60924(_delayBindScriptBlocks, parameter, delayedArg);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 60775, 60948);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 61166, 61351) || true) && (f_1243_61170_61207(f_1243_61170_61189(parameter)) != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 61166, 61351);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 61262, 61328);

                            _currentParameterSetFlag &= f_1243_61290_61327(f_1243_61290_61309(parameter));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 61166, 61351);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 61375, 61411);

                        f_1243_61375_61410(f_1243_61375_61392(), parameter);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 61435, 61489);

                        f_1243_61435_61450()[f_1243_61451_61475(f_1243_61451_61470(parameter))] = parameter;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 61511, 61563);

                        f_1243_61511_61525()[f_1243_61526_61550(f_1243_61526_61545(parameter))] = argument;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 61587, 61907) || true) && (f_1243_61591_61613().RecordBoundParameters && (DynAbs.Tracing.TraceSender.Expression_True(1243, 61591, 61747) && !f_1243_61665_61747(f_1243_61665_61709(f_1243_61665_61687()), f_1243_61722_61746(f_1243_61722_61741(parameter)))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 61587, 61907);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 61797, 61884);

                            f_1243_61797_61883(f_1243_61797_61841(f_1243_61797_61819()), f_1243_61846_61870(f_1243_61846_61865(parameter)), delayedArg);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 61587, 61907);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 61931, 61959);

                        continueWithBinding = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 58893, 61978);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 58598, 61993);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 62009, 62029);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 62043, 63220) || true) && (continueWithBinding)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 62043, 63220);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 62144, 62195);

                        result = f_1243_62153_62194(this, argument, parameter, flags);
                    }
                    catch (Exception e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 62232, 63205);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 62292, 62312);

                        bool
                        rethrow = true
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 62334, 63072) || true) && ((flags & ParameterBindingFlags.ShouldCoerceType) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 62334, 63072);
                            try
                            {
                                while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 62711, 63049) || true) && (e != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 62711, 63049);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 62785, 62969) || true) && (e is PSInvalidCastException)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 62785, 62969);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 62882, 62898);

                                        rethrow = false;
                                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 62932, 62938);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 62785, 62969);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 63001, 63022);

                                    e = f_1243_63005_63021(e);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 62711, 63049);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 62711, 63049);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 62711, 63049);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 62334, 63072);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 63096, 63186) || true) && (rethrow)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 63096, 63186);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 63157, 63163);

                            throw;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 63096, 63186);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 62232, 63205);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 62043, 63220);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 63236, 63250);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 57781, 63261);

                System.Management.Automation.CompiledCommandParameter
                f_1243_58680_58699(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 58680, 58699);
                    return return_v;
                }


                bool
                f_1243_58680_58748(System.Management.Automation.CompiledCommandParameter
                this_param, uint
                validParameterSetFlags)
                {
                    var return_v = this_param.DoesParameterSetTakePipelineInput(validParameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 58680, 58748);
                    return return_v;
                }


                bool
                f_1243_58769_58795(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 58769, 58795);
                    return return_v;
                }


                object
                f_1243_58852_58874(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 58852, 58874);
                    return return_v;
                }


                bool
                f_1243_59000_59041(System.Management.Automation.MergedCompiledCommandParameter
                parameter)
                {
                    var return_v = IsParameterScriptBlockBindable(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 59000, 59041);
                    return return_v;
                }


                bool
                f_1243_59404_59428(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.IsClosed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 59404, 59428);
                    return return_v;
                }


                System.Management.Automation.Internal.Pipe
                f_1243_59432_59457(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.InputPipe;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 59432, 59457);
                    return return_v;
                }


                bool
                f_1243_59432_59463(System.Management.Automation.Internal.Pipe
                this_param)
                {
                    var return_v = this_param.Empty;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 59432, 59463);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_59721_59733(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 59721, 59733);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_59721_59746(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 59721, 59746);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1243_59785_59809(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 59785, 59809);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_59848_59867(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 59848, 59867);
                    return return_v;
                }


                string
                f_1243_59848_59872(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 59848, 59872);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_59911_59930(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 59911, 59930);
                    return return_v;
                }


                System.Type
                f_1243_59911_59935(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 59911, 59935);
                    return return_v;
                }


                string
                f_1243_60017_60066()
                {
                    var return_v = ParameterBinderStrings.ScriptBlockArgumentNoInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 60017, 60066);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1243_59587_60134(System.Management.Automation.ErrorCategory
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 59587, 60134);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_60389_60408(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 60389, 60408);
                    return return_v;
                }


                string
                f_1243_60389_60413(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 60389, 60413);
                    return return_v;
                }


                int
                f_1243_60233_60414(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 60233, 60414);
                    return 0;
                }


                bool
                f_1243_60780_60825(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.CmdletParameterBinderController.DelayedScriptBlockArgument>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 60780, 60825);
                    return return_v;
                }


                int
                f_1243_60875_60924(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.CmdletParameterBinderController.DelayedScriptBlockArgument>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                key, System.Management.Automation.CmdletParameterBinderController.DelayedScriptBlockArgument
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 60875, 60924);
                    return 0;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_61170_61189(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61170, 61189);
                    return return_v;
                }


                uint
                f_1243_61170_61207(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61170, 61207);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_61290_61309(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61290, 61309);
                    return return_v;
                }


                uint
                f_1243_61290_61327(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61290, 61327);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_61375_61392()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61375, 61392);
                    return return_v;
                }


                bool
                f_1243_61375_61410(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 61375, 61410);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_61435_61450()
                {
                    var return_v = BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61435, 61450);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_61451_61470(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61451, 61470);
                    return return_v;
                }


                string
                f_1243_61451_61475(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61451, 61475);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
                f_1243_61511_61525()
                {
                    var return_v = BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61511, 61525);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_61526_61545(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61526, 61545);
                    return return_v;
                }


                string
                f_1243_61526_61550(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61526, 61550);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderBase
                f_1243_61591_61613()
                {
                    var return_v = DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61591, 61613);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderBase
                f_1243_61665_61687()
                {
                    var return_v = DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61665, 61687);
                    return return_v;
                }


                System.Management.Automation.CommandLineParameters
                f_1243_61665_61709(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.CommandLineParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61665, 61709);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_61722_61741(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61722, 61741);
                    return return_v;
                }


                string
                f_1243_61722_61746(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61722, 61746);
                    return return_v;
                }


                bool
                f_1243_61665_61747(System.Management.Automation.CommandLineParameters
                this_param, string
                name)
                {
                    var return_v = this_param.ContainsKey(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 61665, 61747);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderBase
                f_1243_61797_61819()
                {
                    var return_v = DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61797, 61819);
                    return return_v;
                }


                System.Management.Automation.CommandLineParameters
                f_1243_61797_61841(System.Management.Automation.ParameterBinderBase
                this_param)
                {
                    var return_v = this_param.CommandLineParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61797, 61841);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_61846_61865(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61846, 61865);
                    return return_v;
                }


                string
                f_1243_61846_61870(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 61846, 61870);
                    return return_v;
                }


                int
                f_1243_61797_61883(System.Management.Automation.CommandLineParameters
                this_param, string
                name, System.Management.Automation.CmdletParameterBinderController.DelayedScriptBlockArgument
                value)
                {
                    this_param.Add(name, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 61797, 61883);
                    return 0;
                }


                bool
                f_1243_62153_62194(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(argument, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 62153, 62194);
                    return return_v;
                }


                System.Exception
                f_1243_63005_63021(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 63005, 63021);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 57781, 63261);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 57781, 63261);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool BindParameter(
                    CommandParameterInternal argument,
                    MergedCompiledCommandParameter parameter,
                    ParameterBindingFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 64049, 69237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 64246, 64266);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 64282, 67364);

                switch (f_1243_64290_64317(parameter))
                {

                    case ParameterBinderAssociation.DeclaredFormalParameters:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 64282, 67364);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 64430, 64627);

                        result =
                        f_1243_64464_64626(f_1243_64464_64486(), argument, f_1243_64570_64589(parameter), flags);
                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 64649, 64655);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 64282, 67364);

                    case ParameterBinderAssociation.CommonParameters:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 64282, 67364);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 64746, 64943);

                        result =
                        f_1243_64780_64942(f_1243_64780_64802(), argument, f_1243_64886_64905(parameter), flags);
                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 64965, 64971);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 64282, 67364);

                    case ParameterBinderAssociation.ShouldProcessParameters:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 64282, 67364);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 65069, 65290);

                        f_1243_65069_65289(f_1243_65114_65152(_commandMetadata), "The metadata for the ShouldProcessParameters should only be available if the command supports ShouldProcess");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 65314, 65518);

                        result =
                        f_1243_65348_65517(f_1243_65348_65377(), argument, f_1243_65461_65480(parameter), flags);
                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 65540, 65546);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 64282, 67364);

                    case ParameterBinderAssociation.PagingParameters:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 64282, 67364);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 65637, 65837);

                        f_1243_65637_65836(f_1243_65682_65713(_commandMetadata), "The metadata for the PagingParameters should only be available if the command supports paging");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 65861, 66058);

                        result =
                        f_1243_65895_66057(f_1243_65895_65917(), argument, f_1243_66001_66020(parameter), flags);
                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 66080, 66086);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 64282, 67364);

                    case ParameterBinderAssociation.TransactionParameters:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 64282, 67364);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 66182, 66400);

                        f_1243_66182_66399(f_1243_66227_66264(_commandMetadata), "The metadata for the TransactionsParameters should only be available if the command supports transactions");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 66424, 66626);

                        result =
                        f_1243_66458_66625(f_1243_66458_66485(), argument, f_1243_66569_66588(parameter), flags);
                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 66648, 66654);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 64282, 67364);

                    case ParameterBinderAssociation.DynamicParameters:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 64282, 67364);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 66746, 66973);

                        f_1243_66746_66972(f_1243_66791_66835(_commandMetadata), "The metadata for the dynamic parameters should only be available if the command supports IDynamicParameters");

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 66997, 67319) || true) && (_dynamicParameterBinder != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 66997, 67319);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 67082, 67296);

                            result =
                            f_1243_67120_67295(_dynamicParameterBinder, argument, f_1243_67235_67254(parameter), flags);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 66997, 67319);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 67343, 67349);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 64282, 67364);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 67380, 69196) || true) && (result && (DynAbs.Tracing.TraceSender.Expression_True(1243, 67384, 67447) && ((flags & ParameterBindingFlags.IsDefaultValue) == 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 67380, 69196);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 67548, 67721) || true) && (f_1243_67552_67589(f_1243_67552_67571(parameter)) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 67548, 67721);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 67636, 67702);

                        _currentParameterSetFlag &= f_1243_67664_67701(f_1243_67664_67683(parameter));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 67548, 67721);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 67741, 67777);

                    f_1243_67741_67776(f_1243_67741_67758(), parameter);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 67797, 67973) || true) && (!f_1243_67802_67855(f_1243_67802_67817(), f_1243_67830_67854(f_1243_67830_67849(parameter))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 67797, 67973);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 67897, 67954);

                        f_1243_67897_67953(f_1243_67897_67912(), f_1243_67917_67941(f_1243_67917_67936(parameter)), parameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 67797, 67973);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 67993, 68166) || true) && (!f_1243_67998_68050(f_1243_67998_68012(), f_1243_68025_68049(f_1243_68025_68044(parameter))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 67993, 68166);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 68092, 68147);

                        f_1243_68092_68146(f_1243_68092_68106(), f_1243_68111_68135(f_1243_68111_68130(parameter)), argument);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 67993, 68166);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 68186, 69181) || true) && (f_1243_68190_68227(f_1243_68190_68209(parameter)) != null && (DynAbs.Tracing.TraceSender.Expression_True(1243, 68190, 68311) && (flags & ParameterBindingFlags.IsDefaultValue) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 68190, 68399) && !f_1243_68337_68399(f_1243_68337_68364(), f_1243_68374_68398(f_1243_68374_68393(parameter)))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 68186, 69181);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 68441, 68740);

                        string
                        obsoleteWarning = f_1243_68466_68739(f_1243_68506_68534(), f_1243_68561_68615(), f_1243_68642_68666(f_1243_68642_68661(parameter)), f_1243_68693_68738(f_1243_68693_68730(f_1243_68693_68712(parameter))))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 68762, 68860);

                        var
                        warningRecord = f_1243_68782_68859(ParameterBinderBase.FQIDParameterObsolete, obsoleteWarning)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 68884, 68942);

                        f_1243_68884_68941(f_1243_68884_68911(), f_1243_68916_68940(f_1243_68916_68935(parameter)));

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 68966, 69090) || true) && (f_1243_68970_68998() == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 68966, 69090);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 69033, 69090);

                            ObsoleteParameterWarningList = f_1243_69064_69089();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 68966, 69090);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 69114, 69162);

                        f_1243_69114_69161(f_1243_69114_69142(), warningRecord);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 68186, 69181);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 67380, 69196);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 69212, 69226);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 64049, 69237);

                System.Management.Automation.ParameterBinderAssociation
                f_1243_64290_64317(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.BinderAssociation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 64290, 64317);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderBase
                f_1243_64464_64486()
                {
                    var return_v = DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 64464, 64486);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_64570_64589(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 64570, 64589);
                    return return_v;
                }


                bool
                f_1243_64464_64626(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter, System.Management.Automation.CompiledCommandParameter
                parameterMetadata, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(parameter, parameterMetadata, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 64464, 64626);
                    return return_v;
                }


                System.Management.Automation.ReflectionParameterBinder
                f_1243_64780_64802()
                {
                    var return_v = CommonParametersBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 64780, 64802);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_64886_64905(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 64886, 64905);
                    return return_v;
                }


                bool
                f_1243_64780_64942(System.Management.Automation.ReflectionParameterBinder
                this_param, System.Management.Automation.CommandParameterInternal
                parameter, System.Management.Automation.CompiledCommandParameter
                parameterMetadata, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(parameter, parameterMetadata, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 64780, 64942);
                    return return_v;
                }


                bool
                f_1243_65114_65152(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.SupportsShouldProcess;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 65114, 65152);
                    return return_v;
                }


                int
                f_1243_65069_65289(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 65069, 65289);
                    return 0;
                }


                System.Management.Automation.ReflectionParameterBinder
                f_1243_65348_65377()
                {
                    var return_v = ShouldProcessParametersBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 65348, 65377);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_65461_65480(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 65461, 65480);
                    return return_v;
                }


                bool
                f_1243_65348_65517(System.Management.Automation.ReflectionParameterBinder
                this_param, System.Management.Automation.CommandParameterInternal
                parameter, System.Management.Automation.CompiledCommandParameter
                parameterMetadata, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(parameter, parameterMetadata, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 65348, 65517);
                    return return_v;
                }


                bool
                f_1243_65682_65713(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.SupportsPaging;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 65682, 65713);
                    return return_v;
                }


                int
                f_1243_65637_65836(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 65637, 65836);
                    return 0;
                }


                System.Management.Automation.ReflectionParameterBinder
                f_1243_65895_65917()
                {
                    var return_v = PagingParametersBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 65895, 65917);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_66001_66020(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 66001, 66020);
                    return return_v;
                }


                bool
                f_1243_65895_66057(System.Management.Automation.ReflectionParameterBinder
                this_param, System.Management.Automation.CommandParameterInternal
                parameter, System.Management.Automation.CompiledCommandParameter
                parameterMetadata, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(parameter, parameterMetadata, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 65895, 66057);
                    return return_v;
                }


                bool
                f_1243_66227_66264(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.SupportsTransactions;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 66227, 66264);
                    return return_v;
                }


                int
                f_1243_66182_66399(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 66182, 66399);
                    return 0;
                }


                System.Management.Automation.ReflectionParameterBinder
                f_1243_66458_66485()
                {
                    var return_v = TransactionParametersBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 66458, 66485);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_66569_66588(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 66569, 66588);
                    return return_v;
                }


                bool
                f_1243_66458_66625(System.Management.Automation.ReflectionParameterBinder
                this_param, System.Management.Automation.CommandParameterInternal
                parameter, System.Management.Automation.CompiledCommandParameter
                parameterMetadata, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(parameter, parameterMetadata, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 66458, 66625);
                    return return_v;
                }


                bool
                f_1243_66791_66835(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.ImplementsDynamicParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 66791, 66835);
                    return return_v;
                }


                int
                f_1243_66746_66972(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 66746, 66972);
                    return 0;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_67235_67254(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 67235, 67254);
                    return return_v;
                }


                bool
                f_1243_67120_67295(System.Management.Automation.ParameterBinderBase
                this_param, System.Management.Automation.CommandParameterInternal
                parameter, System.Management.Automation.CompiledCommandParameter
                parameterMetadata, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(parameter, parameterMetadata, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 67120, 67295);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_67552_67571(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 67552, 67571);
                    return return_v;
                }


                uint
                f_1243_67552_67589(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 67552, 67589);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_67664_67683(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 67664, 67683);
                    return return_v;
                }


                uint
                f_1243_67664_67701(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 67664, 67701);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_67741_67758()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 67741, 67758);
                    return return_v;
                }


                bool
                f_1243_67741_67776(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 67741, 67776);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_67802_67817()
                {
                    var return_v = BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 67802, 67817);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_67830_67849(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 67830, 67849);
                    return return_v;
                }


                string
                f_1243_67830_67854(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 67830, 67854);
                    return return_v;
                }


                bool
                f_1243_67802_67855(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 67802, 67855);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_67897_67912()
                {
                    var return_v = BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 67897, 67912);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_67917_67936(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 67917, 67936);
                    return return_v;
                }


                string
                f_1243_67917_67941(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 67917, 67941);
                    return return_v;
                }


                int
                f_1243_67897_67953(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key, System.Management.Automation.MergedCompiledCommandParameter
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 67897, 67953);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
                f_1243_67998_68012()
                {
                    var return_v = BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 67998, 68012);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_68025_68044(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68025, 68044);
                    return return_v;
                }


                string
                f_1243_68025_68049(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68025, 68049);
                    return return_v;
                }


                bool
                f_1243_67998_68050(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 67998, 68050);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
                f_1243_68092_68106()
                {
                    var return_v = BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68092, 68106);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_68111_68130(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68111, 68130);
                    return return_v;
                }


                string
                f_1243_68111_68135(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68111, 68135);
                    return return_v;
                }


                int
                f_1243_68092_68146(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
                this_param, string
                key, System.Management.Automation.CommandParameterInternal
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 68092, 68146);
                    return 0;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_68190_68209(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68190, 68209);
                    return return_v;
                }


                System.ObsoleteAttribute
                f_1243_68190_68227(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ObsoleteAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68190, 68227);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1243_68337_68364()
                {
                    var return_v = BoundObsoleteParameterNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68337, 68364);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_68374_68393(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68374, 68393);
                    return return_v;
                }


                string
                f_1243_68374_68398(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68374, 68398);
                    return return_v;
                }


                bool
                f_1243_68337_68399(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 68337, 68399);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1243_68506_68534()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68506, 68534);
                    return return_v;
                }


                string
                f_1243_68561_68615()
                {
                    var return_v = ParameterBinderStrings.UseOfDeprecatedParameterWarning;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68561, 68615);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_68642_68661(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68642, 68661);
                    return return_v;
                }


                string
                f_1243_68642_68666(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68642, 68666);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_68693_68712(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68693, 68712);
                    return return_v;
                }


                System.ObsoleteAttribute
                f_1243_68693_68730(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ObsoleteAttribute;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68693, 68730);
                    return return_v;
                }


                string
                f_1243_68693_68738(System.ObsoleteAttribute
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68693, 68738);
                    return return_v;
                }


                string
                f_1243_68466_68739(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 68466, 68739);
                    return return_v;
                }


                System.Management.Automation.WarningRecord
                f_1243_68782_68859(string
                fullyQualifiedWarningId, string
                message)
                {
                    var return_v = new System.Management.Automation.WarningRecord(fullyQualifiedWarningId, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 68782, 68859);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1243_68884_68911()
                {
                    var return_v = BoundObsoleteParameterNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68884, 68911);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_68916_68935(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68916, 68935);
                    return return_v;
                }


                string
                f_1243_68916_68940(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68916, 68940);
                    return return_v;
                }


                bool
                f_1243_68884_68941(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 68884, 68941);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                f_1243_68970_68998()
                {
                    var return_v = ObsoleteParameterWarningList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 68970, 68998);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                f_1243_69064_69089()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.WarningRecord>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 69064, 69089);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                f_1243_69114_69142()
                {
                    var return_v = ObsoleteParameterWarningList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 69114, 69142);
                    return return_v;
                }


                int
                f_1243_69114_69161(System.Collections.Generic.List<System.Management.Automation.WarningRecord>
                this_param, System.Management.Automation.WarningRecord
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 69114, 69161);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 64049, 69237);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 64049, 69237);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void HandleRemainingArguments()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 69561, 75474);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 69625, 75463) || true) && (f_1243_69629_69651(f_1243_69629_69645()) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 69625, 75463);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 69869, 69924);

                    MergedCompiledCommandParameter
                    varargsParameter = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 69944, 71797);
                        foreach (MergedCompiledCommandParameter parameter in f_1243_69997_70014_I(f_1243_69997_70014()))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 69944, 71797);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 70056, 70170);

                            ParameterSetSpecificMetadata
                            parameterSetData = f_1243_70104_70169(f_1243_70104_70123(parameter), _currentParameterSetFlag)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 70194, 70304) || true) && (parameterSetData == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 70194, 70304);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 70272, 70281);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 70194, 70304);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 70413, 71778) || true) && (f_1243_70417_70461(parameterSetData))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 70413, 71778);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 70511, 71698) || true) && (varargsParameter != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 70511, 71698);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 70597, 71225);

                                    ParameterBindingException
                                    bindingException =
                                    f_1243_70675_71224(ErrorCategory.MetadataError, f_1243_70817_70842(f_1243_70817_70829(this)), null, f_1243_70932_70956(f_1243_70932_70951(parameter)), f_1243_70999_71023(f_1243_70999_71018(parameter)), null, f_1243_71113_71157(), "AmbiguousParameterSet")
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 71338, 71671) || true) && (f_1243_71342_71371_M(!DefaultParameterBindingInUse))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 71338, 71671);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 71437, 71460);

                                        throw bindingException;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 71338, 71671);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 71338, 71671);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 71590, 71640);

                                        f_1243_71590_71639(this, bindingException);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 71338, 71671);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 70511, 71698);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 71726, 71755);

                                varargsParameter = parameter;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 70413, 71778);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 69944, 71797);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 1854);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 1854);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 71817, 75448) || true) && (varargsParameter != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 71817, 75448);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 71887, 75429);
                        using (f_1243_71894_72079(ParameterBinderBase.bindingTracer, "BIND REMAININGARGUMENTS cmd line args to param: [{0}]", f_1243_72047_72078(f_1243_72047_72073(varargsParameter))))
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 72240, 72302);

                            List<object>
                            valueFromRemainingArguments = f_1243_72283_72301()
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 72330, 73273);
                                foreach (CommandParameterInternal argument in f_1243_72376_72392_I(f_1243_72376_72392()))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 72330, 73273);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 72450, 72767) || true) && (f_1243_72454_72485(argument))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 72450, 72767);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 72551, 72646);

                                        f_1243_72551_72645(!f_1243_72571_72615(f_1243_72592_72614(argument)), "Don't add a null argument");
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 72680, 72736);

                                        f_1243_72680_72735(valueFromRemainingArguments, f_1243_72712_72734(argument));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 72450, 72767);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 72799, 73246) || true) && (f_1243_72803_72829(argument))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 72799, 73246);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 72895, 72941);

                                        object
                                        argumentValue = f_1243_72918_72940(argument)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 72975, 73215) || true) && (argumentValue != f_1243_72996_73016() && (DynAbs.Tracing.TraceSender.Expression_True(1243, 72979, 73059) && argumentValue != f_1243_73037_73059()))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 72975, 73215);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 73133, 73180);

                                            f_1243_73133_73179(valueFromRemainingArguments, argumentValue);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 72975, 73215);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 72799, 73246);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 72330, 73273);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 944);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 944);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 73537, 73624);

                            var
                            argumentAst = (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 73555, 73582) || ((f_1243_73555_73577(f_1243_73555_73571()) == 1 && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 73585, 73616)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 73619, 73623))) ? f_1243_73585_73616(f_1243_73585_73604(f_1243_73585_73601(), 0)) : null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 73650, 73921);

                            var
                            cpi = f_1243_73660_73920(null, f_1243_73765_73796(f_1243_73765_73791(varargsParameter)), "-" + f_1243_73804_73835(f_1243_73804_73830(varargsParameter)) + ":", argumentAst, valueFromRemainingArguments, false)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 74423, 74709) || true) && (f_1243_74427_74460(valueFromRemainingArguments) == 1 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 74427, 74538) && f_1243_74469_74538(f_1243_74507_74537(valueFromRemainingArguments, 0))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 74423, 74709);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 74596, 74682);

                                f_1243_74596_74681(cpi, f_1243_74617_74648(f_1243_74617_74636(f_1243_74617_74633(), 0)), f_1243_74650_74680(valueFromRemainingArguments, 0));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 74423, 74709);
                            }

                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 74797, 74874);

                                f_1243_74797_74873(this, cpi, varargsParameter, ParameterBindingFlags.ShouldCoerceType);
                            }
                            catch (ParameterBindingException pbex)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 74927, 75353);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 75022, 75326) || true) && (f_1243_75026_75055_M(!DefaultParameterBindingInUse))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 75022, 75326);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 75121, 75127);

                                    throw;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 75022, 75326);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 75022, 75326);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 75257, 75295);

                                    f_1243_75257_75294(this, pbex);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 75022, 75326);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 74927, 75353);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 75381, 75406);

                            f_1243_75381_75405(f_1243_75381_75397());
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1243, 71887, 75429);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 71817, 75448);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 69625, 75463);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 69561, 75474);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_69629_69645()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 69629, 69645);
                    return return_v;
                }


                int
                f_1243_69629_69651(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 69629, 69651);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_69997_70014()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 69997, 70014);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_70104_70123(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 70104, 70123);
                    return return_v;
                }


                System.Management.Automation.ParameterSetSpecificMetadata
                f_1243_70104_70169(System.Management.Automation.CompiledCommandParameter
                this_param, uint
                parameterSetFlag)
                {
                    var return_v = this_param.GetParameterSetData(parameterSetFlag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 70104, 70169);
                    return return_v;
                }


                bool
                f_1243_70417_70461(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromRemainingArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 70417, 70461);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_70817_70829(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 70817, 70829);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_70817_70842(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 70817, 70842);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_70932_70951(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 70932, 70951);
                    return return_v;
                }


                string
                f_1243_70932_70956(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 70932, 70956);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_70999_71018(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 70999, 71018);
                    return return_v;
                }


                System.Type
                f_1243_70999_71023(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 70999, 71023);
                    return return_v;
                }


                string
                f_1243_71113_71157()
                {
                    var return_v = ParameterBinderStrings.AmbiguousParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 71113, 71157);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1243_70675_71224(System.Management.Automation.ErrorCategory
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 70675, 71224);
                    return return_v;
                }


                bool
                f_1243_71342_71371_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 71342, 71371);
                    return return_v;
                }


                int
                f_1243_71590_71639(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.ParameterBindingException
                pbex)
                {
                    this_param.ThrowElaboratedBindingException(pbex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 71590, 71639);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_69997_70014_I(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 69997, 70014);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_72047_72073(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 72047, 72073);
                    return return_v;
                }


                string
                f_1243_72047_72078(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 72047, 72078);
                    return return_v;
                }


                System.IDisposable
                f_1243_71894_72079(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 71894, 72079);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1243_72283_72301()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 72283, 72301);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_72376_72392()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 72376, 72392);
                    return return_v;
                }


                bool
                f_1243_72454_72485(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterNameSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 72454, 72485);
                    return return_v;
                }


                string
                f_1243_72592_72614(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 72592, 72614);
                    return return_v;
                }


                bool
                f_1243_72571_72615(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 72571, 72615);
                    return return_v;
                }


                int
                f_1243_72551_72645(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 72551, 72645);
                    return 0;
                }


                string
                f_1243_72712_72734(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 72712, 72734);
                    return return_v;
                }


                int
                f_1243_72680_72735(System.Collections.Generic.List<object>
                this_param, string
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 72680, 72735);
                    return 0;
                }


                bool
                f_1243_72803_72829(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentSpecified;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 72803, 72829);
                    return return_v;
                }


                object
                f_1243_72918_72940(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 72918, 72940);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1243_72996_73016()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 72996, 73016);
                    return return_v;
                }


                object
                f_1243_73037_73059()
                {
                    var return_v = UnboundParameter.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 73037, 73059);
                    return return_v;
                }


                int
                f_1243_73133_73179(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 73133, 73179);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_72376_72392_I(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 72376, 72392);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_73555_73571()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 73555, 73571);
                    return return_v;
                }


                int
                f_1243_73555_73577(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 73555, 73577);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_73585_73601()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 73585, 73601);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1243_73585_73604(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 73585, 73604);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1243_73585_73616(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 73585, 73616);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_73765_73791(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 73765, 73791);
                    return return_v;
                }


                string
                f_1243_73765_73796(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 73765, 73796);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_73804_73830(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 73804, 73830);
                    return return_v;
                }


                string
                f_1243_73804_73835(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 73804, 73835);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1243_73660_73920(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, System.Collections.Generic.List<object>
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, (object)value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 73660, 73920);
                    return return_v;
                }


                int
                f_1243_74427_74460(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 74427, 74460);
                    return return_v;
                }


                object
                f_1243_74507_74537(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 74507, 74537);
                    return return_v;
                }


                bool
                f_1243_74469_74538(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsObjectEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 74469, 74538);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_74617_74633()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 74617, 74633);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1243_74617_74636(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 74617, 74636);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1243_74617_74648(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 74617, 74648);
                    return return_v;
                }


                object
                f_1243_74650_74680(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 74650, 74680);
                    return return_v;
                }


                int
                f_1243_74596_74681(System.Management.Automation.CommandParameterInternal
                this_param, System.Management.Automation.Language.Ast
                ast, object
                value)
                {
                    this_param.SetArgumentValue(ast, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 74596, 74681);
                    return 0;
                }


                bool
                f_1243_74797_74873(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(argument, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 74797, 74873);
                    return return_v;
                }


                bool
                f_1243_75026_75055_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 75026, 75055);
                    return return_v;
                }


                int
                f_1243_75257_75294(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.ParameterBindingException
                pbex)
                {
                    this_param.ThrowElaboratedBindingException(pbex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 75257, 75294);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_75381_75397()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 75381, 75397);
                    return return_v;
                }


                int
                f_1243_75381_75405(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 75381, 75405);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 69561, 75474);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 69561, 75474);
            }
        }

        private void HandleCommandLineDynamicParameters(out ParameterBindingException outgoingBindingException)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 76198, 83552);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 76326, 76358);

                outgoingBindingException = null;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 76374, 83541) || true) && (f_1243_76378_76422(_commandMetadata))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 76374, 83541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 76456, 83526);
                    using (f_1243_76463_76574(ParameterBinderBase.bindingTracer, "BIND cmd line args to DYNAMIC parameters."))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 76616, 76690);

                        f_1243_76616_76689(s_tracer, "The Cmdlet supports the dynamic parameter interface");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 76714, 76793);

                        IDynamicParameters
                        dynamicParameterCmdlet = f_1243_76758_76770(this) as IDynamicParameters
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 76817, 83507) || true) && (dynamicParameterCmdlet != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 76817, 83507);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 76901, 81938) || true) && (_dynamicParameterBinder == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 76901, 81938);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 76994, 77060);

                                f_1243_76994_77059(s_tracer, "Getting the bindable object from the Cmdlet");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 77171, 77205);

                                object
                                dynamicParamBindableObject
                                = default(object);

                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 77305, 77380);

                                    dynamicParamBindableObject = f_1243_77334_77379(dynamicParameterCmdlet);
                                }
                                catch (Exception e) // Catch-all OK, this is a third-party callout
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 77441, 78678);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 77572, 77620) || true) && (e is ProviderInvocationException)
                                    )
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 77572, 77620);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 77612, 77618);

                                        throw;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 77572, 77620);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 77656, 78362);

                                    ParameterBindingException
                                    bindingException =
                                    f_1243_77738_78361(e, ErrorCategory.InvalidArgument, f_1243_77926_77951(f_1243_77926_77938(this)), null, null, null, null, f_1243_78182_78234(), "GetDynamicParametersException", f_1243_78351_78360(e))
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 78624, 78647);

                                    throw bindingException;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 77441, 78678);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 78710, 81911) || true) && (dynamicParamBindableObject != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 78710, 81911);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 78814, 79006);

                                    f_1243_78814_79005(ParameterBinderBase.bindingTracer, "DYNAMIC parameter object: [{0}]", f_1243_78968_79004(dynamicParamBindableObject));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 79042, 79129);

                                    f_1243_79042_79128(
                                                                    s_tracer, "Creating a new parameter binder for the dynamic parameter object");
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 79165, 79216);

                                    InternalParameterMetadata
                                    dynamicParameterMetadata
                                    = default(InternalParameterMetadata);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 79252, 79375);

                                    RuntimeDefinedParameterDictionary
                                    runtimeParamDictionary = dynamicParamBindableObject as RuntimeDefinedParameterDictionary
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 79409, 80971) || true) && (runtimeParamDictionary != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 79409, 80971);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 79619, 79753);

                                        dynamicParameterMetadata =
                                        f_1243_79687_79752(runtimeParamDictionary, true, true);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 79793, 80096);

                                        _dynamicParameterBinder =
                                        f_1243_79860_80095(runtimeParamDictionary, f_1243_80009_80021(this), f_1243_80068_80094(this));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 79409, 80971);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 79409, 80971);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 80339, 80490);

                                        dynamicParameterMetadata =
                                        f_1243_80407_80489(f_1243_80437_80473(dynamicParamBindableObject), f_1243_80475_80482(), true);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 80633, 80936);

                                        _dynamicParameterBinder =
                                        f_1243_80700_80935(dynamicParamBindableObject, f_1243_80849_80861(this), f_1243_80908_80934(this));
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 79409, 80971);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 81104, 81356);

                                    var
                                    dynamicParams =
                                    f_1243_81161_81355(f_1243_81161_81179(), dynamicParameterMetadata, ParameterBinderAssociation.DynamicParameters)
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 81390, 81563);
                                        foreach (var param in f_1243_81412_81425_I(dynamicParams))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 81390, 81563);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 81499, 81528);

                                            f_1243_81499_81527(f_1243_81499_81516(), param);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 81390, 81563);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 174);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 174);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 81694, 81880);

                                    _commandMetadata.DefaultParameterSetFlag =
                                    f_1243_81774_81879(f_1243_81774_81797(this), f_1243_81838_81878(_commandMetadata));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 78710, 81911);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 76901, 81938);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 81966, 82202) || true) && (_dynamicParameterBinder == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 81966, 82202);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 82059, 82138);

                                f_1243_82059_82137(s_tracer, "No dynamic parameter object was returned from the Cmdlet");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 82168, 82175);

                                return;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 81966, 82202);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 82230, 83484) || true) && (f_1243_82234_82256(f_1243_82234_82250()) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 82230, 83484);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 82318, 82847);
                                using (f_1243_82325_82448(ParameterBinderBase.bindingTracer, "BIND NAMED args to DYNAMIC parameters"))
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 82676, 82702);

                                    f_1243_82676_82701(this);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 82738, 82816);

                                    UnboundArguments = f_1243_82757_82815(this, _currentParameterSetFlag, f_1243_82798_82814());
                                    DynAbs.Tracing.TraceSender.TraceExitUsing(1243, 82318, 82847);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 82879, 83457);
                                using (f_1243_82886_83014(ParameterBinderBase.bindingTracer, "BIND POSITIONAL args to DYNAMIC parameters"))
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 83080, 83426);

                                    UnboundArguments =
                                    f_1243_83136_83425(this, f_1243_83199_83215(), _currentParameterSetFlag, f_1243_83317_83357(_commandMetadata), out outgoingBindingException);
                                    DynAbs.Tracing.TraceSender.TraceExitUsing(1243, 82879, 83457);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 82230, 83484);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 76817, 83507);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1243, 76456, 83526);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 76374, 83541);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 76198, 83552);

                bool
                f_1243_76378_76422(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.ImplementsDynamicParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 76378, 76422);
                    return return_v;
                }


                System.IDisposable
                f_1243_76463_76574(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 76463, 76574);
                    return return_v;
                }


                int
                f_1243_76616_76689(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 76616, 76689);
                    return 0;
                }


                System.Management.Automation.Cmdlet
                f_1243_76758_76770(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 76758, 76770);
                    return return_v;
                }


                int
                f_1243_76994_77059(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 76994, 77059);
                    return 0;
                }


                object
                f_1243_77334_77379(System.Management.Automation.IDynamicParameters
                this_param)
                {
                    var return_v = this_param.GetDynamicParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 77334, 77379);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_77926_77938(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 77926, 77938);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_77926_77951(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 77926, 77951);
                    return return_v;
                }


                string
                f_1243_78182_78234()
                {
                    var return_v = ParameterBinderStrings.GetDynamicParametersException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 78182, 78234);
                    return return_v;
                }


                string
                f_1243_78351_78360(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 78351, 78360);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1243_77738_78361(System.Exception
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 77738, 78361);
                    return return_v;
                }


                System.Type
                f_1243_78968_79004(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 78968, 79004);
                    return return_v;
                }


                int
                f_1243_78814_79005(System.Management.Automation.PSTraceSource
                this_param, string
                format, System.Type
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 78814, 79005);
                    return 0;
                }


                int
                f_1243_79042_79128(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 79042, 79128);
                    return 0;
                }


                System.Management.Automation.InternalParameterMetadata
                f_1243_79687_79752(System.Management.Automation.RuntimeDefinedParameterDictionary
                runtimeDefinedParameters, bool
                processingDynamicParameters, bool
                checkNames)
                {
                    var return_v = InternalParameterMetadata.Get(runtimeDefinedParameters, processingDynamicParameters, checkNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 79687, 79752);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_80009_80021(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 80009, 80021);
                    return return_v;
                }


                System.Management.Automation.CommandLineParameters
                f_1243_80068_80094(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.CommandLineParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 80068, 80094);
                    return return_v;
                }


                System.Management.Automation.RuntimeDefinedParameterBinder
                f_1243_79860_80095(System.Management.Automation.RuntimeDefinedParameterDictionary
                target, System.Management.Automation.Cmdlet
                command, System.Management.Automation.CommandLineParameters
                commandLineParameters)
                {
                    var return_v = new System.Management.Automation.RuntimeDefinedParameterBinder(target, (System.Management.Automation.Internal.InternalCommand)command, commandLineParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 79860, 80095);
                    return return_v;
                }


                System.Type
                f_1243_80437_80473(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 80437, 80473);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1243_80475_80482()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 80475, 80482);
                    return return_v;
                }


                System.Management.Automation.InternalParameterMetadata
                f_1243_80407_80489(System.Type
                type, System.Management.Automation.ExecutionContext
                context, bool
                processingDynamicParameters)
                {
                    var return_v = InternalParameterMetadata.Get(type, context, processingDynamicParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 80407, 80489);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_80849_80861(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 80849, 80861);
                    return return_v;
                }


                System.Management.Automation.CommandLineParameters
                f_1243_80908_80934(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.CommandLineParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 80908, 80934);
                    return return_v;
                }


                System.Management.Automation.ReflectionParameterBinder
                f_1243_80700_80935(object
                target, System.Management.Automation.Cmdlet
                command, System.Management.Automation.CommandLineParameters
                commandLineParameters)
                {
                    var return_v = new System.Management.Automation.ReflectionParameterBinder(target, command, commandLineParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 80700, 80935);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_81161_81179()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 81161, 81179);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_81161_81355(System.Management.Automation.MergedCommandParameterMetadata
                this_param, System.Management.Automation.InternalParameterMetadata
                parameterMetadata, System.Management.Automation.ParameterBinderAssociation
                binderAssociation)
                {
                    var return_v = this_param.AddMetadataForBinder(parameterMetadata, binderAssociation);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 81161, 81355);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_81499_81516()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 81499, 81516);
                    return return_v;
                }


                int
                f_1243_81499_81527(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 81499, 81527);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_81412_81425_I(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 81412, 81425);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_81774_81797(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 81774, 81797);
                    return return_v;
                }


                string
                f_1243_81838_81878(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 81838, 81878);
                    return return_v;
                }


                uint
                f_1243_81774_81879(System.Management.Automation.MergedCommandParameterMetadata
                this_param, string
                defaultParameterSetName)
                {
                    var return_v = this_param.GenerateParameterSetMappingFromMetadata(defaultParameterSetName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 81774, 81879);
                    return return_v;
                }


                int
                f_1243_82059_82137(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 82059, 82137);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_82234_82250()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 82234, 82250);
                    return return_v;
                }


                int
                f_1243_82234_82256(System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 82234, 82256);
                    return return_v;
                }


                System.IDisposable
                f_1243_82325_82448(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 82325, 82448);
                    return return_v;
                }


                int
                f_1243_82676_82701(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    this_param.ReparseUnboundArguments();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 82676, 82701);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_82798_82814()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 82798, 82814);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_82757_82815(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                parameterSets, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                arguments)
                {
                    var return_v = this_param.BindParameters(parameterSets, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 82757, 82815);
                    return return_v;
                }


                System.IDisposable
                f_1243_82886_83014(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 82886, 83014);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_83199_83215()
                {
                    var return_v = UnboundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 83199, 83215);
                    return return_v;
                }


                uint
                f_1243_83317_83357(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 83317, 83357);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                f_1243_83136_83425(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.CommandParameterInternal>
                unboundArguments, uint
                validParameterSets, uint
                defaultParameterSet, out System.Management.Automation.ParameterBindingException
                outgoingBindingException)
                {
                    var return_v = this_param.BindPositionalParameters(unboundArguments, validParameterSets, defaultParameterSet, out outgoingBindingException);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 83136, 83425);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 76198, 83552);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 76198, 83552);
            }
        }

        [SuppressMessage("Microsoft.Maintainability", "CA1505:AvoidUnmaintainableCode", Justification = "Consider Simplifying it.")]
        private Collection<MergedCompiledCommandParameter> GetMissingMandatoryParameters(
                    int validParameterSetCount,
                    bool isPipelineInputExpected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 84797, 124533);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 85121, 85222);

                Collection<MergedCompiledCommandParameter>
                result = f_1243_85173_85221()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 85238, 85306);

                uint
                defaultParameterSet = f_1243_85265_85305(_commandMetadata)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 85320, 85350);

                uint
                commandMandatorySets = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 85366, 85476);

                Dictionary<uint, ParameterSetPromptingData>
                promptingData = f_1243_85426_85475()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 85492, 85532);

                bool
                missingAMandatoryParameter = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 85546, 85594);

                bool
                missingAMandatoryParameterInAllSet = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 85679, 87776);
                    foreach (MergedCompiledCommandParameter parameter in f_1243_85732_85749_I(f_1243_85732_85749()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 85679, 87776);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 85869, 85993) || true) && (f_1243_85873_85923_M(!f_1243_85874_85893(parameter).IsMandatoryInSomeParameterSet))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 85869, 85993);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 85965, 85974);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 85869, 85993);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 86013, 86122);

                        var
                        matchingParameterSetMetadata = f_1243_86048_86121(f_1243_86048_86067(parameter), _currentParameterSetFlag)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 86142, 86174);

                        uint
                        parameterMandatorySets = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 86192, 86226);

                        bool
                        thisParameterMissing = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 86246, 87286);
                            foreach (ParameterSetSpecificMetadata parameterSetMetadata in f_1243_86308_86336_I(matchingParameterSetMetadata))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 86246, 87286);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 86378, 86537);

                                uint
                                newMandatoryParameterSetFlag = f_1243_86414_86536(this, promptingData, parameter, parameterSetMetadata, defaultParameterSet, isPipelineInputExpected)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 86561, 87267) || true) && (newMandatoryParameterSetFlag != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 86561, 87267);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 86648, 86682);

                                    missingAMandatoryParameter = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 86708, 86736);

                                    thisParameterMissing = true;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 86764, 87244) || true) && (newMandatoryParameterSetFlag != uint.MaxValue)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 86764, 87244);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 86871, 86955);

                                        parameterMandatorySets |= (_currentParameterSetFlag & newMandatoryParameterSetFlag);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 86985, 87061);

                                        commandMandatorySets |= (_currentParameterSetFlag & parameterMandatorySets);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 86764, 87244);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 86764, 87244);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 87175, 87217);

                                        missingAMandatoryParameterInAllSet = true;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 86764, 87244);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 86561, 87267);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 86246, 87286);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 1041);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 1041);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 87362, 87761) || true) && (!isPipelineInputExpected)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 87362, 87761);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 87511, 87665) || true) && (thisParameterMissing)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 87511, 87665);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 87585, 87607);

                                f_1243_87585_87606(result, parameter);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 87633, 87642);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 87511, 87665);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 87362, 87761);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 85679, 87776);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 2098);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 2098);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 87792, 124492) || true) && (missingAMandatoryParameter && (DynAbs.Tracing.TraceSender.Expression_True(1243, 87796, 87849) && isPipelineInputExpected))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 87792, 124492);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 87883, 88021) || true) && (commandMandatorySets == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 87883, 88021);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 87954, 88002);

                        commandMandatorySets = _currentParameterSetFlag;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 87883, 88021);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 88041, 88495) || true) && (missingAMandatoryParameterInAllSet)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 88041, 88495);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 88121, 88200);

                        uint
                        availableParameterSetFlags = f_1243_88155_88199(f_1243_88155_88178(this))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 88222, 88373) || true) && (availableParameterSetFlags == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 88222, 88373);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 88307, 88350);

                            availableParameterSetFlags = uint.MaxValue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 88222, 88373);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 88397, 88476);

                        commandMandatorySets = (_currentParameterSetFlag & availableParameterSetFlags);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 88041, 88495);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 88767, 93208) || true) && (validParameterSetCount > 1 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 88771, 88846) && defaultParameterSet != 0) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 88771, 88920) && (defaultParameterSet & commandMandatorySets) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 88771, 88998) && (defaultParameterSet & _currentParameterSetFlag) != 0))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 88767, 93208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 89137, 89172);

                        uint
                        setThatTakesPipelineInput = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 89194, 89901);
                            foreach (ParameterSetPromptingData promptingSetData in f_1243_89249_89269_I(f_1243_89249_89269(promptingData)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 89194, 89901);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 89319, 89878) || true) && ((f_1243_89324_89353(promptingSetData) & _currentParameterSetFlag) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 89323, 89477) && (f_1243_89420_89449(promptingSetData) & defaultParameterSet) == 0) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 89323, 89536) && f_1243_89510_89536_M(!promptingSetData.IsAllSet)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 89319, 89878);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 89594, 89851) || true) && (f_1243_89598_89652(f_1243_89598_89646(promptingSetData)) > 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 89594, 89851);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 89722, 89780);

                                        setThatTakesPipelineInput = f_1243_89750_89779(promptingSetData);
                                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 89814, 89820);

                                        break;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 89594, 89851);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 89319, 89878);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 89194, 89901);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 708);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 708);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 89925, 93189) || true) && (setThatTakesPipelineInput == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 89925, 93189);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 92727, 92801);

                            commandMandatorySets = _currentParameterSetFlag & (~commandMandatorySets);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 92827, 92875);

                            _currentParameterSetFlag = commandMandatorySets;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 92903, 93166) || true) && (_currentParameterSetFlag == defaultParameterSet)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 92903, 93166);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 92985, 93038);

                                f_1243_92985_93037(f_1243_92985_92992(), f_1243_93013_93036());
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 92903, 93166);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 92903, 93166);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 93098, 93166);

                                _parameterSetToBePrioritizedInPipelineBinding = defaultParameterSet;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 92903, 93166);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 89925, 93189);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 88767, 93208);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 93443, 93520);

                    int
                    commandMandatorySetsCount = f_1243_93475_93519(commandMandatorySets)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 93538, 124477) || true) && (commandMandatorySetsCount == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 93538, 124477);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 93614, 93696);

                        f_1243_93614_93695(this, _currentParameterSetFlag, f_1243_93676_93694());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 93538, 124477);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 93538, 124477);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 93738, 124477) || true) && (commandMandatorySetsCount == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 93738, 124477);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 93890, 94490);
                                foreach (ParameterSetPromptingData promptingSetData in f_1243_93945_93965_I(f_1243_93945_93965(promptingData)))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 93890, 94490);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 94015, 94467) || true) && ((f_1243_94020_94049(promptingSetData) & commandMandatorySets) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(1243, 94019, 94136) || f_1243_94111_94136(promptingSetData)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 94015, 94467);
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 94194, 94440);
                                            foreach (MergedCompiledCommandParameter mandatoryParameter in f_1243_94256_94312_I(f_1243_94256_94312(f_1243_94256_94307(promptingSetData))))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 94194, 94440);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 94378, 94409);

                                                f_1243_94378_94408(result, mandatoryParameter);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 94194, 94440);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 247);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 247);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 94015, 94467);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 93890, 94490);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 601);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 601);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 93738, 124477);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 93738, 124477);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 94532, 124477) || true) && (_parameterSetToBePrioritizedInPipelineBinding == 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 94532, 124477);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 94907, 94937);

                                bool
                                latchOnToDefault = false
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 94959, 100274) || true) && (defaultParameterSet != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 94963, 95040) && (commandMandatorySets & defaultParameterSet) != 0))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 94959, 100274);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 95309, 95351);

                                    bool
                                    anotherSetTakesPipelineInput = false
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 95377, 96011);
                                        foreach (ParameterSetPromptingData paramPromptingData in f_1243_95434_95454_I(f_1243_95434_95454(promptingData)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 95377, 96011);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 95512, 95984) || true) && (f_1243_95516_95544_M(!paramPromptingData.IsAllSet) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 95516, 95613) && f_1243_95581_95613_M(!paramPromptingData.IsDefaultSet)) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 95516, 95710) && f_1243_95650_95706(f_1243_95650_95700(paramPromptingData)) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 95516, 95811) && f_1243_95747_95806(f_1243_95747_95800(paramPromptingData)) == 0))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 95512, 95984);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 95877, 95913);

                                                anotherSetTakesPipelineInput = true;
                                                DynAbs.Tracing.TraceSender.TraceBreak(1243, 95947, 95953);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 95512, 95984);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 95377, 96011);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 635);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 635);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 96130, 96186);

                                    bool
                                    anotherSetTakesPipelineInputByPropertyName = false
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 96212, 96773);
                                        foreach (ParameterSetPromptingData paramPromptingData in f_1243_96269_96289_I(f_1243_96269_96289(promptingData)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 96212, 96773);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 96347, 96746) || true) && (f_1243_96351_96379_M(!paramPromptingData.IsAllSet) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 96351, 96448) && f_1243_96416_96448_M(!paramPromptingData.IsDefaultSet)) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 96351, 96559) && f_1243_96485_96555(f_1243_96485_96549(paramPromptingData)) > 0))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 96347, 96746);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 96625, 96675);

                                                anotherSetTakesPipelineInputByPropertyName = true;
                                                DynAbs.Tracing.TraceSender.TraceBreak(1243, 96709, 96715);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 96347, 96746);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 96212, 96773);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 562);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 562);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 96915, 96965);

                                    ParameterSetPromptingData
                                    defaultSetPromptingData
                                    = default(ParameterSetPromptingData);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 96991, 97884) || true) && (f_1243_96995_97070(promptingData, defaultParameterSet, out defaultSetPromptingData))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 96991, 97884);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 97128, 97230);

                                        bool
                                        defaultSetTakesPipelineInput = f_1243_97164_97225(f_1243_97164_97219(defaultSetPromptingData)) > 0
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 97260, 97390);

                                        bool
                                        defaultSetTakesPipelineInputByPropertyName = f_1243_97310_97385(f_1243_97310_97379(defaultSetPromptingData)) > 0
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 97422, 97857) || true) && (defaultSetTakesPipelineInputByPropertyName && (DynAbs.Tracing.TraceSender.Expression_True(1243, 97426, 97515) && !anotherSetTakesPipelineInputByPropertyName))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 97422, 97857);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 97581, 97605);

                                            latchOnToDefault = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 97422, 97857);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 97422, 97857);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 97671, 97857) || true) && (defaultSetTakesPipelineInput && (DynAbs.Tracing.TraceSender.Expression_True(1243, 97675, 97736) && !anotherSetTakesPipelineInput))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 97671, 97857);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 97802, 97826);

                                                latchOnToDefault = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 97671, 97857);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 97422, 97857);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 96991, 97884);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 97912, 98312) || true) && (!latchOnToDefault)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 97912, 98312);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 98131, 98285) || true) && (!anotherSetTakesPipelineInput)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 98131, 98285);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 98230, 98254);

                                            latchOnToDefault = true;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 98131, 98285);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 97912, 98312);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 98340, 99033) || true) && (!latchOnToDefault)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 98340, 99033);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 98563, 98609);

                                        ParameterSetPromptingData
                                        allSetPromptingData
                                        = default(ParameterSetPromptingData);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 98639, 99006) || true) && (f_1243_98643_98708(promptingData, uint.MaxValue, out allSetPromptingData))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 98639, 99006);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 98774, 98975) || true) && (f_1243_98778_98838(f_1243_98778_98832(allSetPromptingData)) > 0)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 98774, 98975);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 98916, 98940);

                                                latchOnToDefault = true;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 98774, 98975);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 98639, 99006);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 98340, 99033);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 99061, 100251) || true) && (latchOnToDefault)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 99061, 100251);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 99209, 99252);

                                        commandMandatorySets = defaultParameterSet;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 99282, 99329);

                                        _currentParameterSetFlag = defaultParameterSet;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 99359, 99412);

                                        f_1243_99359_99411(f_1243_99359_99366(), f_1243_99387_99410());
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 99544, 100224);
                                            foreach (ParameterSetPromptingData promptingSetData in f_1243_99599_99619_I(f_1243_99599_99619(promptingData)))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 99544, 100224);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 99685, 100193) || true) && ((f_1243_99690_99719(promptingSetData) & commandMandatorySets) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(1243, 99689, 99814) || f_1243_99789_99814(promptingSetData)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 99685, 100193);
                                                    try
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 99888, 100158);
                                                        foreach (MergedCompiledCommandParameter mandatoryParameter in f_1243_99950_100006_I(f_1243_99950_100006(f_1243_99950_100001(promptingSetData))))
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 99888, 100158);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 100088, 100119);

                                                            f_1243_100088_100118(result, mandatoryParameter);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 99888, 100158);
                                                        }
                                                    }
                                                    catch (System.Exception)
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 271);
                                                        throw;
                                                    }
                                                    finally
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 271);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 99685, 100193);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 99544, 100224);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 681);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 681);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 99061, 100251);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 94959, 100274);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 100298, 124458) || true) && (!latchOnToDefault)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 100298, 124458);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 112582, 112624);

                                    uint
                                    setThatTakesPipelineInputByValue = 0
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 112650, 112699);

                                    uint
                                    setThatTakesPipelineInputByPropertyName = 0
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 112810, 112861);

                                    bool
                                    foundSetThatTakesPipelineInputByValue = false
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 112887, 112947);

                                    bool
                                    foundMultipleSetsThatTakesPipelineInputByValue = false
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 112973, 114065);
                                        foreach (ParameterSetPromptingData promptingSetData in f_1243_113028_113048_I(f_1243_113028_113048(promptingData)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 112973, 114065);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 113106, 114038) || true) && ((f_1243_113111_113140(promptingSetData) & commandMandatorySets) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 113110, 113232) && f_1243_113206_113232_M(!promptingSetData.IsAllSet)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 113106, 114038);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 113298, 114007) || true) && (f_1243_113302_113363(f_1243_113302_113357(promptingSetData)) > 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 113298, 114007);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 113441, 113784) || true) && (foundSetThatTakesPipelineInputByValue)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 113441, 113784);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 113564, 113618);

                                                        foundMultipleSetsThatTakesPipelineInputByValue = true;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 113660, 113697);

                                                        setThatTakesPipelineInputByValue = 0;
                                                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 113739, 113745);

                                                        break;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 113441, 113784);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 113824, 113889);

                                                    setThatTakesPipelineInputByValue = f_1243_113859_113888(promptingSetData);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 113927, 113972);

                                                    foundSetThatTakesPipelineInputByValue = true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 113298, 114007);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 113106, 114038);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 112973, 114065);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 1093);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 1093);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 114184, 114242);

                                    bool
                                    foundSetThatTakesPipelineInputByPropertyName = false
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 114268, 114335);

                                    bool
                                    foundMultipleSetsThatTakesPipelineInputByPropertyName = false
                                    ;
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 114361, 115499);
                                        foreach (ParameterSetPromptingData promptingSetData in f_1243_114416_114436_I(f_1243_114416_114436(promptingData)))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 114361, 115499);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 114494, 115472) || true) && ((f_1243_114499_114528(promptingSetData) & commandMandatorySets) != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 114498, 114624) && f_1243_114598_114624_M(!promptingSetData.IsAllSet)))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 114494, 115472);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 114690, 115441) || true) && (f_1243_114694_114762(f_1243_114694_114756(promptingSetData)) > 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 114690, 115441);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 114840, 115204) || true) && (foundSetThatTakesPipelineInputByPropertyName)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 114840, 115204);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 114970, 115031);

                                                        foundMultipleSetsThatTakesPipelineInputByPropertyName = true;
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 115073, 115117);

                                                        setThatTakesPipelineInputByPropertyName = 0;
                                                        DynAbs.Tracing.TraceSender.TraceBreak(1243, 115159, 115165);

                                                        break;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 114840, 115204);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 115244, 115316);

                                                    setThatTakesPipelineInputByPropertyName = f_1243_115286_115315(promptingSetData);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 115354, 115406);

                                                    foundSetThatTakesPipelineInputByPropertyName = true;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 114690, 115441);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 114494, 115472);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 114361, 115499);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 1139);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 1139);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 115630, 115671);

                                    uint
                                    uniqueSetThatTakesPipelineInput = 0
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 115697, 116049) || true) && ((foundSetThatTakesPipelineInputByValue & foundSetThatTakesPipelineInputByPropertyName) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 115701, 115897) && (setThatTakesPipelineInputByValue == setThatTakesPipelineInputByPropertyName)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 115697, 116049);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 115955, 116022);

                                        uniqueSetThatTakesPipelineInput = setThatTakesPipelineInputByValue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 115697, 116049);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 116077, 116432) || true) && (foundSetThatTakesPipelineInputByValue ^ foundSetThatTakesPipelineInputByPropertyName)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 116077, 116432);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 116223, 116405);

                                        uniqueSetThatTakesPipelineInput = (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 116257, 116294) || ((foundSetThatTakesPipelineInputByValue && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 116330, 116362)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 116365, 116404))) ? setThatTakesPipelineInputByValue : setThatTakesPipelineInputByPropertyName;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 116077, 116432);
                                    }

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 116460, 124435) || true) && (uniqueSetThatTakesPipelineInput != 0)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 116460, 124435);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 116636, 116691);

                                        commandMandatorySets = uniqueSetThatTakesPipelineInput;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 116721, 116760);

                                        uint
                                        otherMandatorySetsToBeIgnored = 0
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 116790, 116864);

                                        bool
                                        chosenMandatorySetContainsNonpipelineableMandatoryParameters = false
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 116996, 118246);
                                            foreach (ParameterSetPromptingData promptingSetData in f_1243_117051_117071_I(f_1243_117051_117071(promptingData)))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 116996, 118246);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 117137, 118215) || true) && ((f_1243_117142_117171(promptingSetData) & commandMandatorySets) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(1243, 117141, 117266) || f_1243_117241_117266(promptingSetData)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 117137, 118215);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 117340, 117661) || true) && (f_1243_117344_117370_M(!promptingSetData.IsAllSet))
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 117340, 117661);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 117452, 117622);

                                                        chosenMandatorySetContainsNonpipelineableMandatoryParameters =
                                                        f_1243_117560_117617(f_1243_117560_117611(promptingSetData)) > 0;
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 117340, 117661);
                                                    }
                                                    try
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 117701, 117971);
                                                        foreach (MergedCompiledCommandParameter mandatoryParameter in f_1243_117763_117819_I(f_1243_117763_117819(f_1243_117763_117814(promptingSetData))))
                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 117701, 117971);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 117901, 117932);

                                                            f_1243_117901_117931(result, mandatoryParameter);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 117701, 117971);
                                                        }
                                                    }
                                                    catch (System.Exception)
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 271);
                                                        throw;
                                                    }
                                                    finally
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 271);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 117137, 118215);
                                                }

                                                else

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 117137, 118215);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 118117, 118180);

                                                    otherMandatorySetsToBeIgnored |= f_1243_118150_118179(promptingSetData);
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 117137, 118215);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 116996, 118246);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 1251);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 1251);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 118364, 118641);

                                        f_1243_118364_118640(this, uniqueSetThatTakesPipelineInput, otherMandatorySetsToBeIgnored, chosenMandatorySetContainsNonpipelineableMandatoryParameters);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 116460, 124435);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 116460, 124435);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 118910, 118946);

                                        bool
                                        foundMissingParameters = false
                                        ;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 118976, 119034);

                                        uint
                                        setsThatContainNonpipelineableMandatoryParameter = 0
                                        ;
                                        try
                                        {
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 119064, 119978);
                                            foreach (ParameterSetPromptingData promptingSetData in f_1243_119119_119139_I(f_1243_119119_119139(promptingData)))
                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 119064, 119978);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 119205, 119947) || true) && ((f_1243_119210_119239(promptingSetData) & commandMandatorySets) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(1243, 119209, 119335) || f_1243_119310_119335(promptingSetData)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 119205, 119947);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 119409, 119912) || true) && (f_1243_119413_119470(f_1243_119413_119464(promptingSetData)) > 0)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 119409, 119912);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 119556, 119586);

                                                        foundMissingParameters = true;

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 119628, 119873) || true) && (f_1243_119632_119658_M(!promptingSetData.IsAllSet))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 119628, 119873);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 119748, 119830);

                                                            setsThatContainNonpipelineableMandatoryParameter |= f_1243_119800_119829(promptingSetData);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 119628, 119873);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 119409, 119912);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 119205, 119947);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 119064, 119978);
                                            }
                                        }
                                        catch (System.Exception)
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 915);
                                            throw;
                                        }
                                        finally
                                        {
                                            DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 915);
                                        }
                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 120010, 124408) || true) && (foundMissingParameters)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 120010, 124408);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 120213, 124377) || true) && (setThatTakesPipelineInputByValue != 0)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 120213, 124377);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 120414, 120470);

                                                commandMandatorySets = setThatTakesPipelineInputByValue;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 120508, 120547);

                                                uint
                                                otherMandatorySetsToBeIgnored = 0
                                                ;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 120585, 120659);

                                                bool
                                                chosenMandatorySetContainsNonpipelineableMandatoryParameters = false
                                                ;
                                                try
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 120807, 122209);
                                                    foreach (ParameterSetPromptingData promptingSetData in f_1243_120862_120882_I(f_1243_120862_120882(promptingData)))
                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 120807, 122209);

                                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 120964, 122170) || true) && ((f_1243_120969_120998(promptingSetData) & commandMandatorySets) != 0 || (DynAbs.Tracing.TraceSender.Expression_False(1243, 120968, 121101) || f_1243_121076_121101(promptingSetData)))
                                                        )

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 120964, 122170);

                                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 121191, 121544) || true) && (f_1243_121195_121221_M(!promptingSetData.IsAllSet))
                                                            )

                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 121191, 121544);
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 121319, 121497);

                                                                chosenMandatorySetContainsNonpipelineableMandatoryParameters =
                                                                f_1243_121435_121492(f_1243_121435_121486(promptingSetData)) > 0;
                                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 121191, 121544);
                                                            }
                                                            try
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 121592, 121886);
                                                                foreach (MergedCompiledCommandParameter mandatoryParameter in f_1243_121654_121710_I(f_1243_121654_121710(f_1243_121654_121705(promptingSetData))))
                                                                {
                                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 121592, 121886);
                                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 121808, 121839);

                                                                    f_1243_121808_121838(result, mandatoryParameter);
                                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 121592, 121886);
                                                                }
                                                            }
                                                            catch (System.Exception)
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 295);
                                                                throw;
                                                            }
                                                            finally
                                                            {
                                                                DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 295);
                                                            }
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 120964, 122170);
                                                        }

                                                        else

                                                        {
                                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 120964, 122170);
                                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 122064, 122127);

                                                            otherMandatorySetsToBeIgnored |= f_1243_122097_122126(promptingSetData);
                                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 120964, 122170);
                                                        }
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 120807, 122209);
                                                    }
                                                }
                                                catch (System.Exception)
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 1403);
                                                    throw;
                                                }
                                                finally
                                                {
                                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 1403);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 122343, 122637);

                                                f_1243_122343_122636(this, setThatTakesPipelineInputByValue, otherMandatorySetsToBeIgnored, chosenMandatorySetContainsNonpipelineableMandatoryParameters);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 120213, 124377);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 120213, 124377);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 122783, 123139) || true) && ((!foundMultipleSetsThatTakesPipelineInputByValue) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 122787, 122936) && (!foundMultipleSetsThatTakesPipelineInputByPropertyName)))
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 122783, 123139);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 123018, 123100);

                                                    f_1243_123018_123099(this, _currentParameterSetFlag, f_1243_123080_123098());
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 122783, 123139);
                                                }

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 123503, 124342) || true) && (setsThatContainNonpipelineableMandatoryParameter != 0)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 123503, 124342);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 123642, 123726);

                                                    f_1243_123642_123725(this, setsThatContainNonpipelineableMandatoryParameter);

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 123768, 124016) || true) && (_currentParameterSetFlag == 0)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 123768, 124016);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 123891, 123973);

                                                        f_1243_123891_123972(this, _currentParameterSetFlag, f_1243_123953_123971());
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 123768, 124016);
                                                    }

                                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 124060, 124303) || true) && (f_1243_124064_124112(_currentParameterSetFlag) == 1)
                                                    )

                                                    {
                                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 124060, 124303);
                                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 124207, 124260);

                                                        f_1243_124207_124259(f_1243_124207_124214(), f_1243_124235_124258());
                                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 124060, 124303);
                                                    }
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 123503, 124342);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 120213, 124377);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 120010, 124408);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 116460, 124435);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 100298, 124458);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 94532, 124477);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 93738, 124477);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 93538, 124477);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 87792, 124492);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 124508, 124522);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 84797, 124533);

                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_85173_85221()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 85173, 85221);
                    return return_v;
                }


                uint
                f_1243_85265_85305(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 85265, 85305);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                f_1243_85426_85475()
                {
                    var return_v = new System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 85426, 85475);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_85732_85749()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 85732, 85749);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_85874_85893(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 85874, 85893);
                    return return_v;
                }


                bool
                f_1243_85873_85923_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 85873, 85923);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_86048_86067(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 86048, 86067);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_86048_86121(System.Management.Automation.CompiledCommandParameter
                this_param, uint
                parameterSetFlags)
                {
                    var return_v = this_param.GetMatchingParameterSetData(parameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 86048, 86121);
                    return return_v;
                }


                uint
                f_1243_86414_86536(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                promptingData, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterSetSpecificMetadata
                parameterSetMetadata, uint
                defaultParameterSet, bool
                pipelineInputExpected)
                {
                    var return_v = this_param.NewParameterSetPromptingData(promptingData, parameter, parameterSetMetadata, defaultParameterSet, pipelineInputExpected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 86414, 86536);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_86308_86336_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 86308, 86336);
                    return return_v;
                }


                int
                f_1243_87585_87606(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 87585, 87606);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_85732_85749_I(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 85732, 85749);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_88155_88178(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 88155, 88178);
                    return return_v;
                }


                uint
                f_1243_88155_88199(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.AllParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 88155, 88199);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_89249_89269(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 89249, 89269);
                    return return_v;
                }


                uint
                f_1243_89324_89353(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 89324, 89353);
                    return return_v;
                }


                uint
                f_1243_89420_89449(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 89420, 89449);
                    return return_v;
                }


                bool
                f_1243_89510_89536_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 89510, 89536);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_89598_89646(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.PipelineableMandatoryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 89598, 89646);
                    return return_v;
                }


                int
                f_1243_89598_89652(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 89598, 89652);
                    return return_v;
                }


                uint
                f_1243_89750_89779(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 89750, 89779);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_89249_89269_I(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 89249, 89269);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_92985_92992()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 92985, 92992);
                    return return_v;
                }


                string
                f_1243_93013_93036()
                {
                    var return_v = CurrentParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 93013, 93036);
                    return return_v;
                }


                int
                f_1243_92985_93037(System.Management.Automation.Cmdlet
                this_param, string
                parameterSetName)
                {
                    this_param.SetParameterSetName(parameterSetName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 92985, 93037);
                    return 0;
                }


                int
                f_1243_93475_93519(uint
                parameterSetFlags)
                {
                    var return_v = ValidParameterSetCount(parameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 93475, 93519);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_93676_93694()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 93676, 93694);
                    return return_v;
                }


                int
                f_1243_93614_93695(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                parameterSetFlags, System.Management.Automation.MergedCommandParameterMetadata
                bindableParameters)
                {
                    this_param.ThrowAmbiguousParameterSetException(parameterSetFlags, bindableParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 93614, 93695);
                    return 0;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_93945_93965(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 93945, 93965);
                    return return_v;
                }


                uint
                f_1243_94020_94049(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 94020, 94049);
                    return return_v;
                }


                bool
                f_1243_94111_94136(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.IsAllSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 94111, 94136);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_94256_94307(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.NonpipelineableMandatoryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 94256, 94307);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
                f_1243_94256_94312(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 94256, 94312);
                    return return_v;
                }


                int
                f_1243_94378_94408(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 94378, 94408);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
                f_1243_94256_94312_I(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 94256, 94312);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_93945_93965_I(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 93945, 93965);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_95434_95454(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 95434, 95454);
                    return return_v;
                }


                bool
                f_1243_95516_95544_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 95516, 95544);
                    return return_v;
                }


                bool
                f_1243_95581_95613_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 95581, 95613);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_95650_95700(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.PipelineableMandatoryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 95650, 95700);
                    return return_v;
                }


                int
                f_1243_95650_95706(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 95650, 95706);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_95747_95800(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.NonpipelineableMandatoryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 95747, 95800);
                    return return_v;
                }


                int
                f_1243_95747_95806(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 95747, 95806);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_95434_95454_I(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 95434, 95454);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_96269_96289(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 96269, 96289);
                    return return_v;
                }


                bool
                f_1243_96351_96379_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 96351, 96379);
                    return return_v;
                }


                bool
                f_1243_96416_96448_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 96416, 96448);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_96485_96549(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.PipelineableMandatoryByPropertyNameParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 96485, 96549);
                    return return_v;
                }


                int
                f_1243_96485_96555(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 96485, 96555);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_96269_96289_I(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 96269, 96289);
                    return return_v;
                }


                bool
                f_1243_96995_97070(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                this_param, uint
                key, out System.Management.Automation.ParameterSetPromptingData
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 96995, 97070);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_97164_97219(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.PipelineableMandatoryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 97164, 97219);
                    return return_v;
                }


                int
                f_1243_97164_97225(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 97164, 97225);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_97310_97379(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.PipelineableMandatoryByPropertyNameParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 97310, 97379);
                    return return_v;
                }


                int
                f_1243_97310_97385(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 97310, 97385);
                    return return_v;
                }


                bool
                f_1243_98643_98708(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                this_param, uint
                key, out System.Management.Automation.ParameterSetPromptingData
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 98643, 98708);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_98778_98832(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.NonpipelineableMandatoryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 98778, 98832);
                    return return_v;
                }


                int
                f_1243_98778_98838(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 98778, 98838);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_99359_99366()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 99359, 99366);
                    return return_v;
                }


                string
                f_1243_99387_99410()
                {
                    var return_v = CurrentParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 99387, 99410);
                    return return_v;
                }


                int
                f_1243_99359_99411(System.Management.Automation.Cmdlet
                this_param, string
                parameterSetName)
                {
                    this_param.SetParameterSetName(parameterSetName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 99359, 99411);
                    return 0;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_99599_99619(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 99599, 99619);
                    return return_v;
                }


                uint
                f_1243_99690_99719(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 99690, 99719);
                    return return_v;
                }


                bool
                f_1243_99789_99814(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.IsAllSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 99789, 99814);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_99950_100001(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.NonpipelineableMandatoryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 99950, 100001);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
                f_1243_99950_100006(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 99950, 100006);
                    return return_v;
                }


                int
                f_1243_100088_100118(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 100088, 100118);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
                f_1243_99950_100006_I(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 99950, 100006);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_99599_99619_I(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 99599, 99619);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_113028_113048(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 113028, 113048);
                    return return_v;
                }


                uint
                f_1243_113111_113140(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 113111, 113140);
                    return return_v;
                }


                bool
                f_1243_113206_113232_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 113206, 113232);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_113302_113357(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.PipelineableMandatoryByValueParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 113302, 113357);
                    return return_v;
                }


                int
                f_1243_113302_113363(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 113302, 113363);
                    return return_v;
                }


                uint
                f_1243_113859_113888(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 113859, 113888);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_113028_113048_I(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 113028, 113048);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_114416_114436(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 114416, 114436);
                    return return_v;
                }


                uint
                f_1243_114499_114528(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 114499, 114528);
                    return return_v;
                }


                bool
                f_1243_114598_114624_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 114598, 114624);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_114694_114756(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.PipelineableMandatoryByPropertyNameParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 114694, 114756);
                    return return_v;
                }


                int
                f_1243_114694_114762(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 114694, 114762);
                    return return_v;
                }


                uint
                f_1243_115286_115315(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 115286, 115315);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_114416_114436_I(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 114416, 114436);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_117051_117071(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 117051, 117071);
                    return return_v;
                }


                uint
                f_1243_117142_117171(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 117142, 117171);
                    return return_v;
                }


                bool
                f_1243_117241_117266(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.IsAllSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 117241, 117266);
                    return return_v;
                }


                bool
                f_1243_117344_117370_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 117344, 117370);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_117560_117611(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.NonpipelineableMandatoryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 117560, 117611);
                    return return_v;
                }


                int
                f_1243_117560_117617(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 117560, 117617);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_117763_117814(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.NonpipelineableMandatoryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 117763, 117814);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
                f_1243_117763_117819(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 117763, 117819);
                    return return_v;
                }


                int
                f_1243_117901_117931(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 117901, 117931);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
                f_1243_117763_117819_I(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 117763, 117819);
                    return return_v;
                }


                uint
                f_1243_118150_118179(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 118150, 118179);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_117051_117071_I(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 117051, 117071);
                    return return_v;
                }


                int
                f_1243_118364_118640(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                chosenMandatorySet, uint
                otherMandatorySetsToBeIgnored, bool
                chosenSetContainsNonpipelineableMandatoryParameters)
                {
                    this_param.PreservePotentialParameterSets(chosenMandatorySet, otherMandatorySetsToBeIgnored, chosenSetContainsNonpipelineableMandatoryParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 118364, 118640);
                    return 0;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_119119_119139(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 119119, 119139);
                    return return_v;
                }


                uint
                f_1243_119210_119239(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 119210, 119239);
                    return return_v;
                }


                bool
                f_1243_119310_119335(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.IsAllSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 119310, 119335);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_119413_119464(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.NonpipelineableMandatoryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 119413, 119464);
                    return return_v;
                }


                int
                f_1243_119413_119470(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 119413, 119470);
                    return return_v;
                }


                bool
                f_1243_119632_119658_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 119632, 119658);
                    return return_v;
                }


                uint
                f_1243_119800_119829(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 119800, 119829);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_119119_119139_I(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 119119, 119139);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_120862_120882(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 120862, 120882);
                    return return_v;
                }


                uint
                f_1243_120969_120998(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 120969, 120998);
                    return return_v;
                }


                bool
                f_1243_121076_121101(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.IsAllSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 121076, 121101);
                    return return_v;
                }


                bool
                f_1243_121195_121221_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 121195, 121221);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_121435_121486(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.NonpipelineableMandatoryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 121435, 121486);
                    return return_v;
                }


                int
                f_1243_121435_121492(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 121435, 121492);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_121654_121705(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.NonpipelineableMandatoryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 121654, 121705);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
                f_1243_121654_121710(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                this_param)
                {
                    var return_v = this_param.Keys;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 121654, 121710);
                    return return_v;
                }


                int
                f_1243_121808_121838(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 121808, 121838);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
                f_1243_121654_121710_I(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>.KeyCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 121654, 121710);
                    return return_v;
                }


                uint
                f_1243_122097_122126(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.ParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 122097, 122126);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                f_1243_120862_120882_I(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 120862, 120882);
                    return return_v;
                }


                int
                f_1243_122343_122636(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                chosenMandatorySet, uint
                otherMandatorySetsToBeIgnored, bool
                chosenSetContainsNonpipelineableMandatoryParameters)
                {
                    this_param.PreservePotentialParameterSets(chosenMandatorySet, otherMandatorySetsToBeIgnored, chosenSetContainsNonpipelineableMandatoryParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 122343, 122636);
                    return 0;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_123080_123098()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 123080, 123098);
                    return return_v;
                }


                int
                f_1243_123018_123099(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                parameterSetFlags, System.Management.Automation.MergedCommandParameterMetadata
                bindableParameters)
                {
                    this_param.ThrowAmbiguousParameterSetException(parameterSetFlags, bindableParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 123018, 123099);
                    return 0;
                }


                int
                f_1243_123642_123725(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                otherMandatorySetsToBeIgnored)
                {
                    this_param.IgnoreOtherMandatoryParameterSets(otherMandatorySetsToBeIgnored);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 123642, 123725);
                    return 0;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_123953_123971()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 123953, 123971);
                    return return_v;
                }


                int
                f_1243_123891_123972(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                parameterSetFlags, System.Management.Automation.MergedCommandParameterMetadata
                bindableParameters)
                {
                    this_param.ThrowAmbiguousParameterSetException(parameterSetFlags, bindableParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 123891, 123972);
                    return 0;
                }


                int
                f_1243_124064_124112(uint
                parameterSetFlags)
                {
                    var return_v = ValidParameterSetCount(parameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 124064, 124112);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_124207_124214()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 124207, 124214);
                    return return_v;
                }


                string
                f_1243_124235_124258()
                {
                    var return_v = CurrentParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 124235, 124258);
                    return return_v;
                }


                int
                f_1243_124207_124259(System.Management.Automation.Cmdlet
                this_param, string
                parameterSetName)
                {
                    this_param.SetParameterSetName(parameterSetName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 124207, 124259);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 84797, 124533);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 84797, 124533);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void PreservePotentialParameterSets(uint chosenMandatorySet, uint otherMandatorySetsToBeIgnored, bool chosenSetContainsNonpipelineableMandatoryParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 125042, 126209);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 125409, 126198) || true) && (chosenSetContainsNonpipelineableMandatoryParameters)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 125409, 126198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 125498, 125544);

                    _currentParameterSetFlag = chosenMandatorySet;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 125562, 125615);

                    f_1243_125562_125614(f_1243_125562_125569(), f_1243_125590_125613());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 125409, 126198);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 125409, 126198);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 125849, 125914);

                    f_1243_125849_125913(this, otherMandatorySetsToBeIgnored);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 125932, 125985);

                    f_1243_125932_125984(f_1243_125932_125939(), f_1243_125960_125983());

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 126005, 126183) || true) && (_currentParameterSetFlag != chosenMandatorySet)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 126005, 126183);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 126097, 126164);

                        _parameterSetToBePrioritizedInPipelineBinding = chosenMandatorySet;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 126005, 126183);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 125409, 126198);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 125042, 126209);

                System.Management.Automation.Cmdlet
                f_1243_125562_125569()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 125562, 125569);
                    return return_v;
                }


                string
                f_1243_125590_125613()
                {
                    var return_v = CurrentParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 125590, 125613);
                    return return_v;
                }


                int
                f_1243_125562_125614(System.Management.Automation.Cmdlet
                this_param, string
                parameterSetName)
                {
                    this_param.SetParameterSetName(parameterSetName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 125562, 125614);
                    return 0;
                }


                int
                f_1243_125849_125913(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                otherMandatorySetsToBeIgnored)
                {
                    this_param.IgnoreOtherMandatoryParameterSets(otherMandatorySetsToBeIgnored);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 125849, 125913);
                    return 0;
                }


                System.Management.Automation.Cmdlet
                f_1243_125932_125939()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 125932, 125939);
                    return return_v;
                }


                string
                f_1243_125960_125983()
                {
                    var return_v = CurrentParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 125960, 125983);
                    return return_v;
                }


                int
                f_1243_125932_125984(System.Management.Automation.Cmdlet
                this_param, string
                parameterSetName)
                {
                    this_param.SetParameterSetName(parameterSetName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 125932, 125984);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 125042, 126209);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 125042, 126209);
            }
        }

        private void IgnoreOtherMandatoryParameterSets(uint otherMandatorySetsToBeIgnored)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 126727, 127602);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 126834, 126898) || true) && (otherMandatorySetsToBeIgnored == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 126834, 126898);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 126891, 126898);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 126834, 126898);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 126914, 127591) || true) && (_currentParameterSetFlag == uint.MaxValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 126914, 127591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 127158, 127233);

                    uint
                    availableParameterSets = f_1243_127188_127232(f_1243_127188_127211(this))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 127251, 127346);

                    f_1243_127251_127345(availableParameterSets != 0, "At least one parameter set must be declared");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 127364, 127449);

                    _currentParameterSetFlag = availableParameterSets & (~otherMandatorySetsToBeIgnored);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 126914, 127591);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 126914, 127591);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 127515, 127576);

                    _currentParameterSetFlag &= (~otherMandatorySetsToBeIgnored);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 126914, 127591);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 126727, 127602);

                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_127188_127211(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 127188, 127211);
                    return return_v;
                }


                uint
                f_1243_127188_127232(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.AllParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 127188, 127232);
                    return return_v;
                }


                int
                f_1243_127251_127345(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 127251, 127345);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 126727, 127602);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 126727, 127602);
            }
        }

        private uint NewParameterSetPromptingData(
                    Dictionary<uint, ParameterSetPromptingData> promptingData,
                    MergedCompiledCommandParameter parameter,
                    ParameterSetSpecificMetadata parameterSetMetadata,
                    uint defaultParameterSet,
                    bool pipelineInputExpected)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 127614, 130167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 127952, 127984);

                uint
                parameterMandatorySets = 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 127998, 128060);

                uint
                parameterSetFlag = f_1243_128022_128059(parameterSetMetadata)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 128074, 128181) || true) && (parameterSetFlag == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 128074, 128181);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 128133, 128166);

                    parameterSetFlag = uint.MaxValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 128074, 128181);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 128197, 128295);

                bool
                isDefaultSet = (defaultParameterSet != 0) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 128217, 128294) && ((defaultParameterSet & parameterSetFlag) != 0))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 128311, 128336);

                bool
                isMandatory = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 128350, 128515) || true) && (f_1243_128354_128386(parameterSetMetadata))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 128350, 128515);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 128420, 128463);

                    parameterMandatorySets |= parameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 128481, 128500);

                    isMandatory = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 128350, 128515);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 128531, 128559);

                bool
                isPipelineable = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 128573, 128828) || true) && (pipelineInputExpected)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 128573, 128828);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 128632, 128813) || true) && (f_1243_128636_128674(parameterSetMetadata) || (DynAbs.Tracing.TraceSender.Expression_False(1243, 128636, 128730) || f_1243_128678_128730(parameterSetMetadata)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 128632, 128813);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 128772, 128794);

                        isPipelineable = true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 128632, 128813);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 128573, 128828);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 128844, 130110) || true) && (isMandatory)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 128844, 130110);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 128893, 128939);

                    ParameterSetPromptingData
                    promptingDataForSet
                    = default(ParameterSetPromptingData);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 128957, 129254) || true) && (!f_1243_128962_129030(promptingData, parameterSetFlag, out promptingDataForSet))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 128957, 129254);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 129072, 129156);

                        promptingDataForSet = f_1243_129094_129155(parameterSetFlag, isDefaultSet);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 129178, 129235);

                        f_1243_129178_129234(promptingData, parameterSetFlag, promptingDataForSet);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 128957, 129254);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 129274, 130095) || true) && (isPipelineable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 129274, 130095);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 129334, 129420);

                        f_1243_129334_129385(promptingDataForSet)[parameter] = parameterSetMetadata;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 129444, 129652) || true) && (f_1243_129448_129486(parameterSetMetadata))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 129444, 129652);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 129536, 129629);

                            f_1243_129536_129594(promptingDataForSet)[parameter] = parameterSetMetadata;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 129444, 129652);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 129676, 129905) || true) && (f_1243_129680_129732(parameterSetMetadata))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 129676, 129905);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 129782, 129882);

                            f_1243_129782_129847(promptingDataForSet)[parameter] = parameterSetMetadata;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 129676, 129905);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 129274, 130095);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 129274, 130095);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 129987, 130076);

                        f_1243_129987_130041(promptingDataForSet)[parameter] = parameterSetMetadata;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 129274, 130095);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 128844, 130110);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 130126, 130156);

                return parameterMandatorySets;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 127614, 130167);

                uint
                f_1243_128022_128059(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 128022, 128059);
                    return return_v;
                }


                bool
                f_1243_128354_128386(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.IsMandatory;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 128354, 128386);
                    return return_v;
                }


                bool
                f_1243_128636_128674(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 128636, 128674);
                    return return_v;
                }


                bool
                f_1243_128678_128730(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineByPropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 128678, 128730);
                    return return_v;
                }


                bool
                f_1243_128962_129030(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                this_param, uint
                key, out System.Management.Automation.ParameterSetPromptingData
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 128962, 129030);
                    return return_v;
                }


                System.Management.Automation.ParameterSetPromptingData
                f_1243_129094_129155(uint
                parameterSet, bool
                isDefaultSet)
                {
                    var return_v = new System.Management.Automation.ParameterSetPromptingData(parameterSet, isDefaultSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 129094, 129155);
                    return return_v;
                }


                int
                f_1243_129178_129234(System.Collections.Generic.Dictionary<uint, System.Management.Automation.ParameterSetPromptingData>
                this_param, uint
                key, System.Management.Automation.ParameterSetPromptingData
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 129178, 129234);
                    return 0;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_129334_129385(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.PipelineableMandatoryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 129334, 129385);
                    return return_v;
                }


                bool
                f_1243_129448_129486(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 129448, 129486);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_129536_129594(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.PipelineableMandatoryByValueParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 129536, 129594);
                    return return_v;
                }


                bool
                f_1243_129680_129732(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineByPropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 129680, 129732);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_129782_129847(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.PipelineableMandatoryByPropertyNameParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 129782, 129847);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_129987_130041(System.Management.Automation.ParameterSetPromptingData
                this_param)
                {
                    var return_v = this_param.NonpipelineableMandatoryParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 129987, 130041);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 127614, 130167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 127614, 130167);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int ValidateParameterSets(bool prePipelineInput, bool setDefault)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 131200, 136810);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 131362, 131440);

                int
                validParameterSetCount = f_1243_131391_131439(_currentParameterSetFlag)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 131456, 136753) || true) && (validParameterSetCount == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 131460, 131532) && _currentParameterSetFlag != uint.MaxValue))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 131456, 136753);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 131566, 131648);

                    f_1243_131566_131647(this, _currentParameterSetFlag, f_1243_131628_131646());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 131456, 136753);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 131456, 136753);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 131682, 136753) || true) && (validParameterSetCount > 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 131682, 136753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 131746, 131818);

                        uint
                        defaultParameterSetFlag = f_1243_131777_131817(_commandMetadata)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 131836, 131893);

                        bool
                        hasDefaultSetDefined = defaultParameterSetFlag != 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 131913, 131979);

                        bool
                        validSetIsAllSet = _currentParameterSetFlag == uint.MaxValue
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 131997, 132074);

                        bool
                        validSetIsDefault = _currentParameterSetFlag == defaultParameterSetFlag
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 132232, 134554) || true) && (validSetIsAllSet && (DynAbs.Tracing.TraceSender.Expression_True(1243, 132236, 132277) && !hasDefaultSetDefined))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 132232, 134554);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 132478, 132505);

                            validParameterSetCount = 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 132232, 134554);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 132232, 134554);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 132815, 134554) || true) && (!prePipelineInput && (DynAbs.Tracing.TraceSender.Expression_True(1243, 132819, 132878) && validSetIsDefault) || (DynAbs.Tracing.TraceSender.Expression_False(1243, 132819, 132986) || (hasDefaultSetDefined && (DynAbs.Tracing.TraceSender.Expression_True(1243, 132904, 132985) && (_currentParameterSetFlag & defaultParameterSetFlag) != 0))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 132815, 134554);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 133188, 133285);

                                string
                                currentParameterSetName = f_1243_133221_133284(f_1243_133221_133239(), defaultParameterSetFlag)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 133307, 133360);

                                f_1243_133307_133359(f_1243_133307_133314(), currentParameterSetName);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 133382, 133590) || true) && (setDefault)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 133382, 133590);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 133446, 133514);

                                    _currentParameterSetFlag = f_1243_133473_133513(_commandMetadata);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 133540, 133567);

                                    validParameterSetCount = 1;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 133382, 133590);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 132815, 134554);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 132815, 134554);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 133764, 134554) || true) && (prePipelineInput && (DynAbs.Tracing.TraceSender.Expression_True(1243, 133768, 133887) && f_1243_133809_133887(this, _currentParameterSetFlag)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 133764, 134554);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 133764, 134554);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 133764, 134554);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 134160, 134249);

                                    int
                                    resolvedParameterSetCount = f_1243_134192_134248(this)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 134271, 134460) || true) && (resolvedParameterSetCount != 1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 134271, 134460);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 134355, 134437);

                                        f_1243_134355_134436(this, _currentParameterSetFlag, f_1243_134417_134435());
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 134271, 134460);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 134484, 134535);

                                    validParameterSetCount = resolvedParameterSetCount;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 133764, 134554);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 132815, 134554);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 132232, 134554);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 131682, 136753);
                    }

                    else // validParameterSetCount == 1

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 131682, 136753);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 134824, 136665) || true) && (_currentParameterSetFlag == uint.MaxValue)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 134824, 136665);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 135138, 135313);

                            validParameterSetCount =
                            (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 135188, 135235) || (((f_1243_135189_135230(f_1243_135189_135212(this)) > 0) && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 135267, 135308)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 135311, 135312))) ? f_1243_135267_135308(f_1243_135267_135290(this)) : 1;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 135337, 136646) || true) && (prePipelineInput && (DynAbs.Tracing.TraceSender.Expression_True(1243, 135341, 135464) && f_1243_135386_135464(this, _currentParameterSetFlag)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 135337, 136646);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 135337, 136646);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 135337, 136646);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 135692, 136646) || true) && (f_1243_135696_135736(_commandMetadata) != 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 135692, 136646);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 135791, 136015) || true) && (setDefault)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 135791, 136015);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 135863, 135931);

                                        _currentParameterSetFlag = f_1243_135890_135930(_commandMetadata);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 135961, 135988);

                                        validParameterSetCount = 1;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 135791, 136015);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 135692, 136646);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 135692, 136646);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 136148, 136646) || true) && (validParameterSetCount > 1)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 136148, 136646);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 136228, 136317);

                                        int
                                        resolvedParameterSetCount = f_1243_136260_136316(this)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 136343, 136544) || true) && (resolvedParameterSetCount != 1)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 136343, 136544);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 136435, 136517);

                                            f_1243_136435_136516(this, _currentParameterSetFlag, f_1243_136497_136515());
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 136343, 136544);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 136572, 136623);

                                        validParameterSetCount = resolvedParameterSetCount;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 136148, 136646);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 135692, 136646);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 135337, 136646);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 134824, 136665);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 136685, 136738);

                        f_1243_136685_136737(f_1243_136685_136692(), f_1243_136713_136736());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 131682, 136753);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 131456, 136753);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 136769, 136799);

                return validParameterSetCount;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 131200, 136810);

                int
                f_1243_131391_131439(uint
                parameterSetFlags)
                {
                    var return_v = ValidParameterSetCount(parameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 131391, 131439);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_131628_131646()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 131628, 131646);
                    return return_v;
                }


                int
                f_1243_131566_131647(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                parameterSetFlags, System.Management.Automation.MergedCommandParameterMetadata
                bindableParameters)
                {
                    this_param.ThrowAmbiguousParameterSetException(parameterSetFlags, bindableParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 131566, 131647);
                    return 0;
                }


                uint
                f_1243_131777_131817(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 131777, 131817);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_133221_133239()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 133221, 133239);
                    return return_v;
                }


                string
                f_1243_133221_133284(System.Management.Automation.MergedCommandParameterMetadata
                this_param, uint
                parameterSet)
                {
                    var return_v = this_param.GetParameterSetName(parameterSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 133221, 133284);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_133307_133314()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 133307, 133314);
                    return return_v;
                }


                int
                f_1243_133307_133359(System.Management.Automation.Cmdlet
                this_param, string
                parameterSetName)
                {
                    this_param.SetParameterSetName(parameterSetName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 133307, 133359);
                    return 0;
                }


                uint
                f_1243_133473_133513(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 133473, 133513);
                    return return_v;
                }


                bool
                f_1243_133809_133887(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                validParameterSetFlags)
                {
                    var return_v = this_param.AtLeastOneUnboundValidParameterSetTakesPipelineInput(validParameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 133809, 133887);
                    return return_v;
                }


                int
                f_1243_134192_134248(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.ResolveParameterSetAmbiguityBasedOnMandatoryParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 134192, 134248);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_134417_134435()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 134417, 134435);
                    return return_v;
                }


                int
                f_1243_134355_134436(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                parameterSetFlags, System.Management.Automation.MergedCommandParameterMetadata
                bindableParameters)
                {
                    this_param.ThrowAmbiguousParameterSetException(parameterSetFlags, bindableParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 134355, 134436);
                    return 0;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_135189_135212(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 135189, 135212);
                    return return_v;
                }


                int
                f_1243_135189_135230(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 135189, 135230);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_135267_135290(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 135267, 135290);
                    return return_v;
                }


                int
                f_1243_135267_135308(System.Management.Automation.MergedCommandParameterMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 135267, 135308);
                    return return_v;
                }


                bool
                f_1243_135386_135464(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                validParameterSetFlags)
                {
                    var return_v = this_param.AtLeastOneUnboundValidParameterSetTakesPipelineInput(validParameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 135386, 135464);
                    return return_v;
                }


                uint
                f_1243_135696_135736(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 135696, 135736);
                    return return_v;
                }


                uint
                f_1243_135890_135930(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 135890, 135930);
                    return return_v;
                }


                int
                f_1243_136260_136316(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.ResolveParameterSetAmbiguityBasedOnMandatoryParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 136260, 136316);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_136497_136515()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 136497, 136515);
                    return return_v;
                }


                int
                f_1243_136435_136516(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                parameterSetFlags, System.Management.Automation.MergedCommandParameterMetadata
                bindableParameters)
                {
                    this_param.ThrowAmbiguousParameterSetException(parameterSetFlags, bindableParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 136435, 136516);
                    return 0;
                }


                System.Management.Automation.Cmdlet
                f_1243_136685_136692()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 136685, 136692);
                    return return_v;
                }


                string
                f_1243_136713_136736()
                {
                    var return_v = CurrentParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 136713, 136736);
                    return return_v;
                }


                int
                f_1243_136685_136737(System.Management.Automation.Cmdlet
                this_param, string
                parameterSetName)
                {
                    this_param.SetParameterSetName(parameterSetName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 136685, 136737);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 131200, 136810);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 131200, 136810);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int ResolveParameterSetAmbiguityBasedOnMandatoryParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 136822, 137098);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 136915, 137087);

                return f_1243_136922_137086(f_1243_136977_136997(this), f_1243_136999_137021(this), f_1243_137023_137046(this), ref _currentParameterSetFlag, f_1243_137078_137085());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 136822, 137098);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_136977_136997(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 136977, 136997);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_136999_137021(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 136999, 137021);
                    return return_v;
                }


                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_137023_137046(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 137023, 137046);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_137078_137085()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 137078, 137085);
                    return return_v;
                }


                int
                f_1243_136922_137086(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                boundParameters, System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                unboundParameters, System.Management.Automation.MergedCommandParameterMetadata
                bindableParameters, ref uint
                _currentParameterSetFlag, System.Management.Automation.Cmdlet
                command)
                {
                    var return_v = ResolveParameterSetAmbiguityBasedOnMandatoryParameters(boundParameters, (System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>)unboundParameters, bindableParameters, ref _currentParameterSetFlag, command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 136922, 137086);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 136822, 137098);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 136822, 137098);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static int ResolveParameterSetAmbiguityBasedOnMandatoryParameters(
                    Dictionary<string, MergedCompiledCommandParameter> boundParameters,
                    ICollection<MergedCompiledCommandParameter> unboundParameters,
                    MergedCommandParameterMetadata bindableParameters,
                    ref uint _currentParameterSetFlag,
                    Cmdlet command
                    )
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1243, 137110, 139597);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 137522, 137609);

                uint
                remainingParameterSetsWithNoMandatoryUnboundParameters = _currentParameterSetFlag
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 137625, 137832);

                IEnumerable<ParameterSetSpecificMetadata>
                allParameterSetMetadatas = f_1243_137694_137831(f_1243_137694_137760(f_1243_137694_137716(boundParameters), unboundParameters), p => p.Parameter.ParameterSetData.Values)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 137846, 137876);

                uint
                allParameterSetFlags = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 137890, 138087);
                    foreach (ParameterSetSpecificMetadata parameterSetMetadata in f_1243_137952_137976_I(allParameterSetMetadatas))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 137890, 138087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 138010, 138072);

                        allParameterSetFlags |= f_1243_138034_138071(parameterSetMetadata);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 137890, 138087);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 138103, 138182);

                remainingParameterSetsWithNoMandatoryUnboundParameters &= allParameterSetFlags;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 138198, 138419);

                f_1243_138198_138418(f_1243_138235_138313(remainingParameterSetsWithNoMandatoryUnboundParameters) > 1, "This method should only be called when there is an ambiguity wrt parameter sets");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 138435, 138663);

                IEnumerable<ParameterSetSpecificMetadata>
                parameterSetMetadatasForUnboundMandatoryParameters = f_1243_138530_138662(f_1243_138530_138618(unboundParameters
                , p => p.Parameter.ParameterSetData.Values), p => p.IsMandatory)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 138677, 138937);
                    foreach (ParameterSetSpecificMetadata parameterSetMetadata in f_1243_138739_138789_I(parameterSetMetadatasForUnboundMandatoryParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 138677, 138937);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 138823, 138922);

                        remainingParameterSetsWithNoMandatoryUnboundParameters &= (f_1243_138882_138920_M(~parameterSetMetadata.ParameterSetFlag));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 138677, 138937);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 261);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 261);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 138953, 139061);

                int
                finalParameterSetCount = f_1243_138982_139060(remainingParameterSetsWithNoMandatoryUnboundParameters)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 139075, 139560) || true) && (finalParameterSetCount == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 139075, 139560);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 139140, 139222);

                    _currentParameterSetFlag = remainingParameterSetsWithNoMandatoryUnboundParameters;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 139242, 139495) || true) && (command != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 139242, 139495);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 139303, 139401);

                        string
                        currentParameterSetName = f_1243_139336_139400(bindableParameters, _currentParameterSetFlag)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 139423, 139476);

                        f_1243_139423_139475(command, currentParameterSetName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 139242, 139495);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 139515, 139545);

                    return finalParameterSetCount;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 139075, 139560);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 139576, 139586);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1243, 137110, 139597);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>.ValueCollection
                f_1243_137694_137716(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Values
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 137694, 137716);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_137694_137760(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>.ValueCollection
                first, System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                second)
                {
                    var return_v = first.Concat<System.Management.Automation.MergedCompiledCommandParameter>((System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>)second);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 137694, 137760);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_137694_137831(System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>
                source, System.Func<System.Management.Automation.MergedCompiledCommandParameter, System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>>
                selector)
                {
                    var return_v = source.SelectMany<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 137694, 137831);
                    return return_v;
                }


                uint
                f_1243_138034_138071(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 138034, 138071);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_137952_137976_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 137952, 137976);
                    return return_v;
                }


                int
                f_1243_138235_138313(uint
                parameterSetFlags)
                {
                    var return_v = ValidParameterSetCount(parameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 138235, 138313);
                    return return_v;
                }


                int
                f_1243_138198_138418(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 138198, 138418);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_138530_138618(System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
                source, System.Func<System.Management.Automation.MergedCompiledCommandParameter, System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>>
                selector)
                {
                    var return_v = source.SelectMany<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.ParameterSetSpecificMetadata>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 138530, 138618);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_138530_138662(System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                source, System.Func<System.Management.Automation.ParameterSetSpecificMetadata, bool>
                predicate)
                {
                    var return_v = source.Where<System.Management.Automation.ParameterSetSpecificMetadata>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 138530, 138662);
                    return return_v;
                }


                uint
                f_1243_138882_138920_M(uint
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 138882, 138920);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_138739_138789_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 138739, 138789);
                    return return_v;
                }


                int
                f_1243_138982_139060(uint
                parameterSetFlags)
                {
                    var return_v = ValidParameterSetCount(parameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 138982, 139060);
                    return return_v;
                }


                string
                f_1243_139336_139400(System.Management.Automation.MergedCommandParameterMetadata
                this_param, uint
                parameterSet)
                {
                    var return_v = this_param.GetParameterSetName(parameterSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 139336, 139400);
                    return return_v;
                }


                int
                f_1243_139423_139475(System.Management.Automation.Cmdlet
                this_param, string
                parameterSetName)
                {
                    this_param.SetParameterSetName(parameterSetName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 139423, 139475);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 137110, 139597);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 137110, 139597);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ThrowAmbiguousParameterSetException(uint parameterSetFlags, MergedCommandParameterMetadata bindableParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 139609, 141196);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 139757, 140171);

                ParameterBindingException
                bindingException =
                f_1243_139819_140170(ErrorCategory.InvalidArgument, f_1243_139923_139948(f_1243_139923_139935(this)), null, null, null, null, f_1243_140079_140123(), "AmbiguousParameterSet")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 140241, 140270);

                uint
                currentParameterSet = 1
                ;
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 140286, 140948) || true) && (parameterSetFlags != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 140286, 140948);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 140349, 140406);

                        uint
                        currentParameterSetActive = parameterSetFlags & 0x1
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 140426, 140845) || true) && (currentParameterSetActive == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 140426, 140845);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 140502, 140588);

                            string
                            parameterSetName = f_1243_140528_140587(bindableParameters, currentParameterSet)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 140610, 140826) || true) && (!f_1243_140615_140653(parameterSetName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 140610, 140826);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 140703, 140803);

                                f_1243_140703_140802(ParameterBinderBase.bindingTracer, "Remaining valid parameter set: {0}", parameterSetName);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 140610, 140826);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 140426, 140845);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 140865, 140889);

                        parameterSetFlags >>= 1;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 140907, 140933);

                        currentParameterSet <<= 1;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 140286, 140948);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 140286, 140948);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 140286, 140948);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 140964, 141185) || true) && (f_1243_140968_140997_M(!DefaultParameterBindingInUse))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 140964, 141185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 141031, 141054);

                    throw bindingException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 140964, 141185);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 140964, 141185);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 141120, 141170);

                    f_1243_141120_141169(this, bindingException);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 140964, 141185);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 139609, 141196);

                System.Management.Automation.Cmdlet
                f_1243_139923_139935(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 139923, 139935);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_139923_139948(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 139923, 139948);
                    return return_v;
                }


                string
                f_1243_140079_140123()
                {
                    var return_v = ParameterBinderStrings.AmbiguousParameterSet;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 140079, 140123);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1243_139819_140170(System.Management.Automation.ErrorCategory
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 139819, 140170);
                    return return_v;
                }


                string
                f_1243_140528_140587(System.Management.Automation.MergedCommandParameterMetadata
                this_param, uint
                parameterSet)
                {
                    var return_v = this_param.GetParameterSetName(parameterSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 140528, 140587);
                    return return_v;
                }


                bool
                f_1243_140615_140653(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 140615, 140653);
                    return return_v;
                }


                int
                f_1243_140703_140802(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 140703, 140802);
                    return 0;
                }


                bool
                f_1243_140968_140997_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 140968, 140997);
                    return return_v;
                }


                int
                f_1243_141120_141169(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.ParameterBindingException
                pbex)
                {
                    this_param.ThrowElaboratedBindingException(pbex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 141120, 141169);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 139609, 141196);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 139609, 141196);
            }
        }

        private bool AtLeastOneUnboundValidParameterSetTakesPipelineInput(uint validParameterSetFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 141785, 142441);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 141904, 141924);

                bool
                result = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 142097, 142400);
                    foreach (MergedCompiledCommandParameter parameter in f_1243_142150_142167_I(f_1243_142150_142167()))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 142097, 142400);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 142201, 142385) || true) && (f_1243_142205_142282(f_1243_142205_142224(parameter), validParameterSetFlags))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 142201, 142385);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 142324, 142338);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1243, 142360, 142366);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 142201, 142385);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 142097, 142400);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 304);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 304);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 142416, 142430);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 141785, 142441);

                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_142150_142167()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 142150, 142167);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_142205_142224(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 142205, 142224);
                    return return_v;
                }


                bool
                f_1243_142205_142282(System.Management.Automation.CompiledCommandParameter
                this_param, uint
                validParameterSetFlags)
                {
                    var return_v = this_param.DoesParameterSetTakePipelineInput(validParameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 142205, 142282);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_142150_142167_I(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 142150, 142167);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 141785, 142441);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 141785, 142441);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HandleUnboundMandatoryParameters(out Collection<MergedCompiledCommandParameter> missingMandatoryParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 142896, 143282);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 143042, 143271);

                return f_1243_143049_143270(this, f_1243_143100_143148(_currentParameterSetFlag), false, false, false, out missingMandatoryParameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 142896, 143282);

                int
                f_1243_143100_143148(uint
                parameterSetFlags)
                {
                    var return_v = ValidParameterSetCount(parameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 143100, 143148);
                    return return_v;
                }


                bool
                f_1243_143049_143270(System.Management.Automation.CmdletParameterBinderController
                this_param, int
                validParameterSetCount, bool
                processMissingMandatory, bool
                promptForMandatory, bool
                isPipelineInputExpected, out System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                missingMandatoryParameters)
                {
                    var return_v = this_param.HandleUnboundMandatoryParameters(validParameterSetCount, processMissingMandatory, promptForMandatory, isPipelineInputExpected, out missingMandatoryParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 143049, 143270);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 142896, 143282);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 142896, 143282);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool HandleUnboundMandatoryParameters(
                    int validParameterSetCount,
                    bool processMissingMandatory,
                    bool promptForMandatory,
                    bool isPipelineInputExpected,
                    out Collection<MergedCompiledCommandParameter> missingMandatoryParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 144996, 148907);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 145321, 145340);

                bool
                result = true
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 145356, 145464);

                missingMandatoryParameters = f_1243_145385_145463(this, validParameterSetCount, isPipelineInputExpected);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 145480, 148866) || true) && (f_1243_145484_145516(missingMandatoryParameters) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 145480, 148866);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 145554, 148851) || true) && (processMissingMandatory)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 145554, 148851);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 145779, 146988) || true) && ((f_1243_145784_145811(f_1243_145784_145791()) == null) || (DynAbs.Tracing.TraceSender.Expression_False(1243, 145783, 145845) || (!promptForMandatory)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 145779, 146988);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 145895, 146058);

                            f_1243_145895_146057(f_1243_145944_145971(f_1243_145944_145951()) != null, "The EngineHostInterface should never be null");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 146086, 146235);

                            f_1243_146086_146234(
                                                    ParameterBinderBase.bindingTracer, "ERROR: host does not support prompting for missing mandatory parameters");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 146263, 146343);

                            string
                            missingParameters = f_1243_146290_146342(missingMandatoryParameters)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 146371, 146914);

                            ParameterBindingException
                            bindingException =
                            f_1243_146445_146913(ErrorCategory.InvalidArgument, f_1243_146573_146598(f_1243_146573_146585(this)), null, missingParameters, null, null, f_1243_146802_146850(), "MissingMandatoryParameter")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 146942, 146965);

                            throw bindingException;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 145779, 146988);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 147123, 147230);

                        Collection<FieldDescription>
                        fieldDescriptionList = f_1243_147175_147229(this, missingMandatoryParameters)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 147254, 147466);

                        Dictionary<string, PSObject>
                        parameters =
                        f_1243_147321_147465(this, fieldDescriptionList, missingMandatoryParameters)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 147490, 148735);
                        using (f_1243_147497_147609(ParameterBinderBase.bindingTracer, "BIND PROMPTED mandatory parameter args"))
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 147734, 148670);
                                foreach (KeyValuePair<string, PSObject> entry in f_1243_147783_147793_I(parameters))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 147734, 148670);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 147851, 148149);

                                    var
                                    argument =
                                    f_1243_147899_148148(null, entry.Key, "-" + entry.Key + ":", null, entry.Value, false)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 148275, 148430);

                                    result =
                                    f_1243_148317_148429(this, argument, ParameterBindingFlags.ShouldCoerceType | ParameterBindingFlags.ThrowOnParameterNotFound);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 148462, 148643);

                                    f_1243_148462_148642(result, "Any error in binding the parameter with type coercion should result in an exception");
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 147734, 148670);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 937);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 937);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 148698, 148712);

                            result = true;
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1243, 147490, 148735);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 145554, 148851);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 145554, 148851);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 148817, 148832);

                        result = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 145554, 148851);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 145480, 148866);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 148882, 148896);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 144996, 148907);

                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_145385_145463(System.Management.Automation.CmdletParameterBinderController
                this_param, int
                validParameterSetCount, bool
                isPipelineInputExpected)
                {
                    var return_v = this_param.GetMissingMandatoryParameters(validParameterSetCount, isPipelineInputExpected);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 145385, 145463);
                    return return_v;
                }


                int
                f_1243_145484_145516(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 145484, 145516);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1243_145784_145791()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 145784, 145791);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1243_145784_145811(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 145784, 145811);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1243_145944_145951()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 145944, 145951);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1243_145944_145971(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 145944, 145971);
                    return return_v;
                }


                int
                f_1243_145895_146057(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 145895, 146057);
                    return 0;
                }


                int
                f_1243_146086_146234(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 146086, 146234);
                    return 0;
                }


                string
                f_1243_146290_146342(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                missingMandatoryParameters)
                {
                    var return_v = BuildMissingParamsString(missingMandatoryParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 146290, 146342);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_146573_146585(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 146573, 146585);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_146573_146598(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 146573, 146598);
                    return return_v;
                }


                string
                f_1243_146802_146850()
                {
                    var return_v = ParameterBinderStrings.MissingMandatoryParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 146802, 146850);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1243_146445_146913(System.Management.Automation.ErrorCategory
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 146445, 146913);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
                f_1243_147175_147229(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                missingMandatoryParameters)
                {
                    var return_v = this_param.CreatePromptDataStructures(missingMandatoryParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 147175, 147229);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSObject>
                f_1243_147321_147465(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
                fieldDescriptionList, System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                missingMandatoryParameters)
                {
                    var return_v = this_param.PromptForMissingMandatoryParameters(fieldDescriptionList, missingMandatoryParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 147321, 147465);
                    return return_v;
                }


                System.IDisposable
                f_1243_147497_147609(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 147497, 147609);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1243_147899_148148(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, System.Management.Automation.PSObject
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, (object)value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 147899, 148148);
                    return return_v;
                }


                bool
                f_1243_148317_148429(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(argument, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 148317, 148429);
                    return return_v;
                }


                int
                f_1243_148462_148642(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 148462, 148642);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSObject>
                f_1243_147783_147793_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 147783, 147793);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 144996, 148907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 144996, 148907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Dictionary<string, PSObject> PromptForMissingMandatoryParameters(
                    Collection<FieldDescription> fieldDescriptionList,
                    Collection<MergedCompiledCommandParameter> missingMandatoryParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 148919, 152061);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 149165, 149212);

                Dictionary<string, PSObject>
                parameters = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 149228, 149251);

                Exception
                error = null
                ;

                // Prompt
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 149326, 149453);

                    f_1243_149326_149452(ParameterBinderBase.bindingTracer, "PROMPTING for missing mandatory parameters using the host");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 149471, 149521);

                    string
                    msg = f_1243_149484_149520()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 149539, 149586);

                    InvocationInfo
                    invoInfo = f_1243_149565_149585(f_1243_149565_149572())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 149604, 149771);

                    string
                    caption = f_1243_149621_149770(f_1243_149639_149675(), f_1243_149698_149721(f_1243_149698_149716(invoInfo)), f_1243_149744_149769(invoInfo))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 149791, 149878);

                    parameters = f_1243_149804_149877(f_1243_149804_149834(f_1243_149804_149831(f_1243_149804_149811())), caption, msg, fieldDescriptionList);
                }
                catch (NotImplementedException notImplemented)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 149907, 150024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 149986, 150009);

                    error = notImplemented;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 149907, 150024);
                }
                catch (HostException hostException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 150038, 150143);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 150106, 150128);

                    error = hostException;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 150038, 150143);
                }
                catch (PSInvalidOperationException invalidOperation)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 150157, 150282);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 150242, 150267);

                    error = invalidOperation;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 150157, 150282);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 150298, 151139) || true) && (error != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 150298, 151139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 150349, 150490);

                    f_1243_150349_150489(ParameterBinderBase.bindingTracer, "ERROR: host does not support prompting for missing mandatory parameters");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 150510, 150590);

                    string
                    missingParameters = f_1243_150537_150589(missingMandatoryParameters)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 150610, 151081);

                    ParameterBindingException
                    bindingException =
                    f_1243_150676_151080(ErrorCategory.InvalidArgument, f_1243_150788_150813(f_1243_150788_150800(this)), null, missingParameters, null, null, f_1243_150977_151025(), "MissingMandatoryParameter")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 151101, 151124);

                    throw bindingException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 150298, 151139);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 151155, 152016) || true) && ((parameters == null) || (DynAbs.Tracing.TraceSender.Expression_False(1243, 151159, 151206) || (f_1243_151184_151200(parameters) == 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 151155, 152016);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 151240, 151367);

                    f_1243_151240_151366(ParameterBinderBase.bindingTracer, "ERROR: still missing mandatory parameters after PROMPTING");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 151387, 151467);

                    string
                    missingParameters = f_1243_151414_151466(missingMandatoryParameters)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 151487, 151958);

                    ParameterBindingException
                    bindingException =
                    f_1243_151553_151957(ErrorCategory.InvalidArgument, f_1243_151665_151690(f_1243_151665_151677(this)), null, missingParameters, null, null, f_1243_151854_151902(), "MissingMandatoryParameter")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 151978, 152001);

                    throw bindingException;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 151155, 152016);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 152032, 152050);

                return parameters;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 148919, 152061);

                int
                f_1243_149326_149452(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 149326, 149452);
                    return 0;
                }


                string
                f_1243_149484_149520()
                {
                    var return_v = ParameterBinderStrings.PromptMessage;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 149484, 149520);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_149565_149572()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 149565, 149572);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_149565_149585(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 149565, 149585);
                    return return_v;
                }


                string
                f_1243_149639_149675()
                {
                    var return_v = ParameterBinderStrings.PromptCaption;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 149639, 149675);
                    return return_v;
                }


                System.Management.Automation.CommandInfo
                f_1243_149698_149716(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.MyCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 149698, 149716);
                    return return_v;
                }


                string
                f_1243_149698_149721(System.Management.Automation.CommandInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 149698, 149721);
                    return return_v;
                }


                int
                f_1243_149744_149769(System.Management.Automation.InvocationInfo
                this_param)
                {
                    var return_v = this_param.PipelinePosition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 149744, 149769);
                    return return_v;
                }


                string
                f_1243_149621_149770(string
                formatSpec, string
                o1, int
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 149621, 149770);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1243_149804_149811()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 149804, 149811);
                    return return_v;
                }


                System.Management.Automation.Internal.Host.InternalHost
                f_1243_149804_149831(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.EngineHostInterface;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 149804, 149831);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1243_149804_149834(System.Management.Automation.Internal.Host.InternalHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 149804, 149834);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.PSObject>
                f_1243_149804_149877(System.Management.Automation.Host.PSHostUserInterface
                this_param, string
                caption, string
                message, System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
                descriptions)
                {
                    var return_v = this_param.Prompt(caption, message, descriptions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 149804, 149877);
                    return return_v;
                }


                int
                f_1243_150349_150489(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 150349, 150489);
                    return 0;
                }


                string
                f_1243_150537_150589(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                missingMandatoryParameters)
                {
                    var return_v = BuildMissingParamsString(missingMandatoryParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 150537, 150589);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_150788_150800(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 150788, 150800);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_150788_150813(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 150788, 150813);
                    return return_v;
                }


                string
                f_1243_150977_151025()
                {
                    var return_v = ParameterBinderStrings.MissingMandatoryParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 150977, 151025);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1243_150676_151080(System.Management.Automation.ErrorCategory
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 150676, 151080);
                    return return_v;
                }


                int
                f_1243_151184_151200(System.Collections.Generic.Dictionary<string, System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 151184, 151200);
                    return return_v;
                }


                int
                f_1243_151240_151366(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 151240, 151366);
                    return 0;
                }


                string
                f_1243_151414_151466(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                missingMandatoryParameters)
                {
                    var return_v = BuildMissingParamsString(missingMandatoryParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 151414, 151466);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_151665_151677(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 151665, 151677);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_151665_151690(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 151665, 151690);
                    return return_v;
                }


                string
                f_1243_151854_151902()
                {
                    var return_v = ParameterBinderStrings.MissingMandatoryParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 151854, 151902);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1243_151553_151957(System.Management.Automation.ErrorCategory
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 151553, 151957);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 148919, 152061);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 148919, 152061);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string BuildMissingParamsString(Collection<MergedCompiledCommandParameter> missingMandatoryParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1243, 152073, 152586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 152216, 152270);

                StringBuilder
                missingParameters = f_1243_152250_152269()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 152286, 152523);
                    foreach (MergedCompiledCommandParameter missingParameter in f_1243_152346_152372_I(missingMandatoryParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 152286, 152523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 152406, 152508);

                        f_1243_152406_152507(missingParameters, f_1243_152437_152465(), " {0}", f_1243_152475_152506(f_1243_152475_152501(missingParameter)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 152286, 152523);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 238);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 238);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 152539, 152575);

                return f_1243_152546_152574(missingParameters);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1243, 152073, 152586);

                System.Text.StringBuilder
                f_1243_152250_152269()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 152250, 152269);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1243_152437_152465()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 152437, 152465);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_152475_152501(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 152475, 152501);
                    return return_v;
                }


                string
                f_1243_152475_152506(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 152475, 152506);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_152406_152507(System.Text.StringBuilder
                this_param, System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = this_param.AppendFormat((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 152406, 152507);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_152346_152372_I(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 152346, 152372);
                    return return_v;
                }


                string
                f_1243_152546_152574(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 152546, 152574);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 152073, 152586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 152073, 152586);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Collection<FieldDescription> CreatePromptDataStructures(
                    Collection<MergedCompiledCommandParameter> missingMandatoryParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 152598, 154573);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 152771, 152819);

                StringBuilder
                usedHotKeys = f_1243_152799_152818()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 152833, 152920);

                Collection<FieldDescription>
                fieldDescriptionList = f_1243_152885_152919()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 153005, 154518);
                    foreach (MergedCompiledCommandParameter parameter in f_1243_153058_153084_I(missingMandatoryParameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 153005, 154518);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 153118, 153257);

                        ParameterSetSpecificMetadata
                        parameterSetMetadata =
                        f_1243_153191_153256(f_1243_153191_153210(parameter), _currentParameterSetFlag)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 153277, 153349);

                        FieldDescription
                        fDesc = f_1243_153302_153348(f_1243_153323_153347(f_1243_153323_153342(parameter)))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 153369, 153392);

                        string
                        helpInfo = null
                        ;

                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 153456, 153512);

                            helpInfo = f_1243_153467_153511(parameterSetMetadata, f_1243_153503_153510());
                        }
                        catch (InvalidOperationException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 153549, 153620);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 153549, 153620);
                        }
                        catch (ArgumentException)
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 153638, 153701);
                            DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 153638, 153701);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 153721, 153846) || true) && (!f_1243_153726_153756(helpInfo))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 153721, 153846);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 153798, 153827);

                            fDesc.HelpMessage = helpInfo;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 153721, 153846);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 153866, 153915);

                        f_1243_153866_153914(
                                        fDesc, f_1243_153889_153913(f_1243_153889_153908(parameter)));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 153933, 153997);

                        fDesc.Label = f_1243_153947_153996(f_1243_153958_153982(f_1243_153958_153977(parameter)), usedHotKeys);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 154017, 154193);
                            foreach (ValidateArgumentsAttribute vaAttr in f_1243_154063_154103_I(f_1243_154063_154103(f_1243_154063_154082(parameter))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 154017, 154193);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 154145, 154174);

                                f_1243_154145_154173(f_1243_154145_154161(fDesc), vaAttr);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 154017, 154193);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 177);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 177);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 154213, 154406);
                            foreach (ArgumentTransformationAttribute arAttr in f_1243_154264_154316_I(f_1243_154264_154316(f_1243_154264_154283(parameter))))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 154213, 154406);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 154358, 154387);

                                f_1243_154358_154386(f_1243_154358_154374(fDesc), arAttr);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 154213, 154406);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 194);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 194);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 154426, 154451);

                        fDesc.IsMandatory = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 154471, 154503);

                        f_1243_154471_154502(
                                        fieldDescriptionList, fDesc);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 153005, 154518);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 1514);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 1514);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 154534, 154562);

                return fieldDescriptionList;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 152598, 154573);

                System.Text.StringBuilder
                f_1243_152799_152818()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 152799, 152818);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
                f_1243_152885_152919()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 152885, 152919);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_153191_153210(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 153191, 153210);
                    return return_v;
                }


                System.Management.Automation.ParameterSetSpecificMetadata
                f_1243_153191_153256(System.Management.Automation.CompiledCommandParameter
                this_param, uint
                parameterSetFlag)
                {
                    var return_v = this_param.GetParameterSetData(parameterSetFlag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 153191, 153256);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_153323_153342(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 153323, 153342);
                    return return_v;
                }


                string
                f_1243_153323_153347(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 153323, 153347);
                    return return_v;
                }


                System.Management.Automation.Host.FieldDescription
                f_1243_153302_153348(string
                name)
                {
                    var return_v = new System.Management.Automation.Host.FieldDescription(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 153302, 153348);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_153503_153510()
                {
                    var return_v = Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 153503, 153510);
                    return return_v;
                }


                string
                f_1243_153467_153511(System.Management.Automation.ParameterSetSpecificMetadata
                this_param, System.Management.Automation.Cmdlet
                cmdlet)
                {
                    var return_v = this_param.GetHelpMessage(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 153467, 153511);
                    return return_v;
                }


                bool
                f_1243_153726_153756(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 153726, 153756);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_153889_153908(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 153889, 153908);
                    return return_v;
                }


                System.Type
                f_1243_153889_153913(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 153889, 153913);
                    return return_v;
                }


                int
                f_1243_153866_153914(System.Management.Automation.Host.FieldDescription
                this_param, System.Type
                parameterType)
                {
                    this_param.SetParameterType(parameterType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 153866, 153914);
                    return 0;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_153958_153977(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 153958, 153977);
                    return return_v;
                }


                string
                f_1243_153958_153982(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 153958, 153982);
                    return return_v;
                }


                string
                f_1243_153947_153996(string
                parameterName, System.Text.StringBuilder
                usedHotKeys)
                {
                    var return_v = BuildLabel(parameterName, usedHotKeys);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 153947, 153996);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_154063_154082(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 154063, 154082);
                    return return_v;
                }


                System.Management.Automation.ValidateArgumentsAttribute[]
                f_1243_154063_154103(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ValidationAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 154063, 154103);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1243_154145_154161(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 154145, 154161);
                    return return_v;
                }


                int
                f_1243_154145_154173(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ValidateArgumentsAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 154145, 154173);
                    return 0;
                }


                System.Management.Automation.ValidateArgumentsAttribute[]
                f_1243_154063_154103_I(System.Management.Automation.ValidateArgumentsAttribute[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 154063, 154103);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_154264_154283(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 154264, 154283);
                    return return_v;
                }


                System.Management.Automation.ArgumentTransformationAttribute[]
                f_1243_154264_154316(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ArgumentTransformationAttributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 154264, 154316);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Attribute>
                f_1243_154358_154374(System.Management.Automation.Host.FieldDescription
                this_param)
                {
                    var return_v = this_param.Attributes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 154358, 154374);
                    return return_v;
                }


                int
                f_1243_154358_154386(System.Collections.ObjectModel.Collection<System.Attribute>
                this_param, System.Management.Automation.ArgumentTransformationAttribute
                item)
                {
                    this_param.Add((System.Attribute)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 154358, 154386);
                    return 0;
                }


                System.Management.Automation.ArgumentTransformationAttribute[]
                f_1243_154264_154316_I(System.Management.Automation.ArgumentTransformationAttribute[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 154264, 154316);
                    return return_v;
                }


                int
                f_1243_154471_154502(System.Collections.ObjectModel.Collection<System.Management.Automation.Host.FieldDescription>
                this_param, System.Management.Automation.Host.FieldDescription
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 154471, 154502);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_153058_153084_I(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 153058, 153084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 152598, 154573);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 152598, 154573);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string BuildLabel(string parameterName, StringBuilder usedHotKeys)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1243, 155391, 157505);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 155497, 155582);

                f_1243_155497_155581(!f_1243_155517_155552(parameterName), "parameterName is not set");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 155596, 155626);

                const char
                hotKeyPrefix = '&'
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 155640, 155659);

                bool
                built = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 155673, 155728);

                StringBuilder
                label = f_1243_155695_155727(parameterName)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 155742, 155789);

                string
                usedHotKeysStr = f_1243_155766_155788(usedHotKeys)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 155814, 155819);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 155805, 156233) || true) && (i < f_1243_155825_155845(parameterName))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 155847, 155850)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 155805, 156233))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 155805, 156233);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 155919, 156218) || true) && (f_1243_155923_155953(f_1243_155936_155952(parameterName, i)) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 155923, 156005) && (f_1243_155958_155998(usedHotKeysStr, f_1243_155981_155997(parameterName, i)) == -1)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 155919, 156218);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156047, 156077);

                            f_1243_156047_156076(label, i, hotKeyPrefix);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156099, 156136);

                            f_1243_156099_156135(usedHotKeys, f_1243_156118_156134(parameterName, i));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156158, 156171);

                            built = true;
                            DynAbs.Tracing.TraceSender.TraceBreak(1243, 156193, 156199);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 155919, 156218);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 429);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 429);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156249, 156772) || true) && (!built)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 156249, 156772);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156337, 156342);
                        // try Lower case
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156328, 156757) || true) && (i < f_1243_156348_156368(parameterName))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156370, 156373)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 156328, 156757))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 156328, 156757);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156415, 156738) || true) && (f_1243_156419_156449(f_1243_156432_156448(parameterName, i)) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 156419, 156501) && (f_1243_156454_156494(usedHotKeysStr, f_1243_156477_156493(parameterName, i)) == -1)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 156415, 156738);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156551, 156581);

                                f_1243_156551_156580(label, i, hotKeyPrefix);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156607, 156644);

                                f_1243_156607_156643(usedHotKeys, f_1243_156626_156642(parameterName, i));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156670, 156683);

                                built = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1243, 156709, 156715);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 156415, 156738);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 430);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 430);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 156249, 156772);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156788, 157314) || true) && (!built)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 156788, 157314);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156877, 156882);
                        // try non-letters
                        for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156868, 157299) || true) && (i < f_1243_156888_156908(parameterName))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156910, 156913)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 156868, 157299))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 156868, 157299);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 156955, 157280) || true) && (!f_1243_156960_156991(f_1243_156974_156990(parameterName, i)) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 156959, 157043) && (f_1243_156996_157036(usedHotKeysStr, f_1243_157019_157035(parameterName, i)) == -1)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 156955, 157280);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 157093, 157123);

                                f_1243_157093_157122(label, i, hotKeyPrefix);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 157149, 157186);

                                f_1243_157149_157185(usedHotKeys, f_1243_157168_157184(parameterName, i));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 157212, 157225);

                                built = true;
                                DynAbs.Tracing.TraceSender.TraceBreak(1243, 157251, 157257);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 156955, 157280);
                            }
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 432);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 432);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 156788, 157314);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 157330, 157454) || true) && (!built)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 157330, 157454);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 157409, 157439);

                    f_1243_157409_157438(                // use first char
                                    label, 0, hotKeyPrefix);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 157330, 157454);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 157470, 157494);

                return f_1243_157477_157493(label);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1243, 155391, 157505);

                bool
                f_1243_155517_155552(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 155517, 155552);
                    return return_v;
                }


                int
                f_1243_155497_155581(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 155497, 155581);
                    return 0;
                }


                System.Text.StringBuilder
                f_1243_155695_155727(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 155695, 155727);
                    return return_v;
                }


                string
                f_1243_155766_155788(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 155766, 155788);
                    return return_v;
                }


                int
                f_1243_155825_155845(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 155825, 155845);
                    return return_v;
                }


                char
                f_1243_155936_155952(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 155936, 155952);
                    return return_v;
                }


                bool
                f_1243_155923_155953(char
                c)
                {
                    var return_v = char.IsUpper(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 155923, 155953);
                    return return_v;
                }


                char
                f_1243_155981_155997(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 155981, 155997);
                    return return_v;
                }


                int
                f_1243_155958_155998(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 155958, 155998);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_156047_156076(System.Text.StringBuilder
                this_param, int
                index, char
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 156047, 156076);
                    return return_v;
                }


                char
                f_1243_156118_156134(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 156118, 156134);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_156099_156135(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 156099, 156135);
                    return return_v;
                }


                int
                f_1243_156348_156368(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 156348, 156368);
                    return return_v;
                }


                char
                f_1243_156432_156448(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 156432, 156448);
                    return return_v;
                }


                bool
                f_1243_156419_156449(char
                c)
                {
                    var return_v = char.IsLower(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 156419, 156449);
                    return return_v;
                }


                char
                f_1243_156477_156493(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 156477, 156493);
                    return return_v;
                }


                int
                f_1243_156454_156494(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 156454, 156494);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_156551_156580(System.Text.StringBuilder
                this_param, int
                index, char
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 156551, 156580);
                    return return_v;
                }


                char
                f_1243_156626_156642(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 156626, 156642);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_156607_156643(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 156607, 156643);
                    return return_v;
                }


                int
                f_1243_156888_156908(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 156888, 156908);
                    return return_v;
                }


                char
                f_1243_156974_156990(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 156974, 156990);
                    return return_v;
                }


                bool
                f_1243_156960_156991(char
                c)
                {
                    var return_v = char.IsLetter(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 156960, 156991);
                    return return_v;
                }


                char
                f_1243_157019_157035(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 157019, 157035);
                    return return_v;
                }


                int
                f_1243_156996_157036(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 156996, 157036);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_157093_157122(System.Text.StringBuilder
                this_param, int
                index, char
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 157093, 157122);
                    return return_v;
                }


                char
                f_1243_157168_157184(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 157168, 157184);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_157149_157185(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 157149, 157185);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_157409_157438(System.Text.StringBuilder
                this_param, int
                index, char
                value)
                {
                    var return_v = this_param.Insert(index, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 157409, 157438);
                    return return_v;
                }


                string
                f_1243_157477_157493(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 157477, 157493);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 155391, 157505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 155391, 157505);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal string CurrentParameterSetName
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 157700, 157993);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 157736, 157834);

                    string
                    currentParameterSetName = f_1243_157769_157833(f_1243_157769_157787(), _currentParameterSetFlag)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 157852, 157929);

                    f_1243_157852_157928(s_tracer, "CurrentParameterSetName = {0}", currentParameterSetName);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 157947, 157978);

                    return currentParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 157700, 157993);

                    System.Management.Automation.MergedCommandParameterMetadata
                    f_1243_157769_157787()
                    {
                        var return_v = BindableParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 157769, 157787);
                        return return_v;
                    }


                    string
                    f_1243_157769_157833(System.Management.Automation.MergedCommandParameterMetadata
                    this_param, uint
                    parameterSet)
                    {
                        var return_v = this_param.GetParameterSetName(parameterSet);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 157769, 157833);
                        return return_v;
                    }


                    int
                    f_1243_157852_157928(System.Management.Automation.PSTraceSource
                    this_param, string
                    format, string
                    arg1)
                    {
                        this_param.WriteLine(format, (object)arg1);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 157852, 157928);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 157636, 158004);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 157636, 158004);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal bool BindPipelineParameters(PSObject inputToOperateOn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 158470, 161619);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 158558, 158570);

                bool
                result
                = default(bool);

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 158622, 160150);
                    using (f_1243_158629_158784(ParameterBinderBase.bindingTracer, "BIND PIPELINE object to parameters: [{0}]", f_1243_158762_158783(_commandMetadata)))
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 158971, 159000);

                        bool
                        thereWasSomethingToBind
                        = default(bool);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 159022, 159129);

                        bool
                        invokeScriptResult = f_1243_159048_159128(this, inputToOperateOn, out thereWasSomethingToBind)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 159153, 159249);

                        bool
                        continueBindingAfterScriptBlockProcessing = !thereWasSomethingToBind || (DynAbs.Tracing.TraceSender.Expression_False(1243, 159202, 159248) || invokeScriptResult)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 159273, 159315);

                        bool
                        bindPipelineParametersResult = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 159339, 159769) || true) && (continueBindingAfterScriptBlockProcessing)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 159339, 159769);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 159667, 159746);

                            bindPipelineParametersResult = f_1243_159698_159745(this, inputToOperateOn);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 159339, 159769);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 160042, 160131);

                        result = (thereWasSomethingToBind && (DynAbs.Tracing.TraceSender.Expression_True(1243, 160052, 160097) && invokeScriptResult)) || (DynAbs.Tracing.TraceSender.Expression_False(1243, 160051, 160130) || bindPipelineParametersResult);
                        DynAbs.Tracing.TraceSender.TraceExitUsing(1243, 158622, 160150);
                    }
                }
                catch (ParameterBindingException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 160179, 160637);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 160457, 160529);

                    f_1243_160457_160528(                // Reset the default values
                                                         // This prevents the last pipeline object from being bound during EndProcessing
                                                         // if it failed some post binding verification step.
                                    this, f_1243_160492_160527());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 160616, 160622);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 160179, 160637);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 160769, 160798);

                    f_1243_160769_160797(this);
                }
                catch (ParameterBindingException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 160827, 161218);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 161105, 161177);

                    f_1243_161105_161176(                // Reset the default values
                                                         // This prevents the last pipeline object from being bound during EndProcessing
                                                         // if it failed some post binding verification step.
                                    this, f_1243_161140_161175());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 161197, 161203);

                    throw;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 160827, 161218);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 161234, 161578) || true) && (!result)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 161234, 161578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 161491, 161563);

                    f_1243_161491_161562(                // Reset the default values
                                                         // This prevents the last pipeline object from being bound during EndProcessing
                                                         // if it failed some post binding verification step.
                                    this, f_1243_161526_161561());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 161234, 161578);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 161594, 161608);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 158470, 161619);

                string
                f_1243_158762_158783(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 158762, 158783);
                    return return_v;
                }


                System.IDisposable
                f_1243_158629_158784(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    var return_v = this_param.TraceScope(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 158629, 158784);
                    return return_v;
                }


                bool
                f_1243_159048_159128(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.PSObject
                inputToOperateOn, out bool
                thereWasSomethingToBind)
                {
                    var return_v = this_param.InvokeAndBindDelayBindScriptBlock(inputToOperateOn, out thereWasSomethingToBind);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 159048, 159128);
                    return return_v;
                }


                bool
                f_1243_159698_159745(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.PSObject
                inputToOperateOn)
                {
                    var return_v = this_param.BindPipelineParametersPrivate(inputToOperateOn);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 159698, 159745);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_160492_160527()
                {
                    var return_v = ParametersBoundThroughPipelineInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 160492, 160527);
                    return return_v;
                }


                int
                f_1243_160457_160528(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                parameters)
                {
                    this_param.RestoreDefaultParameterValues((System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>)parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 160457, 160528);
                    return 0;
                }


                int
                f_1243_160769_160797(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    this_param.VerifyParameterSetSelected();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 160769, 160797);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_161140_161175()
                {
                    var return_v = ParametersBoundThroughPipelineInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 161140, 161175);
                    return return_v;
                }


                int
                f_1243_161105_161176(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                parameters)
                {
                    this_param.RestoreDefaultParameterValues((System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>)parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 161105, 161176);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_161526_161561()
                {
                    var return_v = ParametersBoundThroughPipelineInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 161526, 161561);
                    return return_v;
                }


                int
                f_1243_161491_161562(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                parameters)
                {
                    this_param.RestoreDefaultParameterValues((System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>)parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 161491, 161562);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 158470, 161619);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 158470, 161619);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool BindPipelineParametersPrivate(PSObject inputToOperateOn)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 163516, 168246);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 163610, 164388) || true) && (f_1243_163614_163657(ParameterBinderBase.bindingTracer))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 163610, 164388);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 163691, 163735);

                    ConsolidatedString
                    dontuseInternalTypeNames
                    = default(ConsolidatedString);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 163753, 164259);

                    f_1243_163753_164258(ParameterBinderBase.bindingTracer, "PIPELINE object TYPE = [{0}]", (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 163872, 163940) || ((inputToOperateOn == null || (DynAbs.Tracing.TraceSender.Expression_False(1243, 163872, 163940) || inputToOperateOn == f_1243_163920_163940()) && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 163968, 163974)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 164002, 164257))) ? "null"
                    : (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 164002, 164116) || (((f_1243_164003_164072((dontuseInternalTypeNames = f_1243_164031_164065(inputToOperateOn))) > 0 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 164003, 164115) && f_1243_164080_164107(dontuseInternalTypeNames, 0) != null))
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 164150, 164177)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 164211, 164257))) ? f_1243_164150_164177(dontuseInternalTypeNames, 0) : f_1243_164211_164257(f_1243_164211_164248(f_1243_164211_164238(inputToOperateOn))));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 164279, 164373);

                    f_1243_164279_164372(
                                    ParameterBinderBase.bindingTracer, "RESTORING pipeline parameter's original values");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 163610, 164388);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 164404, 164424);

                bool
                result = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 164483, 164555);

                f_1243_164483_164554(
                            // Reset the default values

                            this, f_1243_164518_164553());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 164652, 164696);

                f_1243_164652_164695(f_1243_164652_164687());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 164766, 164833);

                _currentParameterSetFlag = _prePipelineProcessingParameterSetFlags;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 164847, 164898);

                uint
                validParameterSets = _currentParameterSetFlag
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 164912, 165010);

                bool
                needToPrioritizeOneSpecificParameterSet = _parameterSetToBePrioritizedInPipelineBinding != 0
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 165024, 165084);

                int
                steps = (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 165036, 165075) || ((needToPrioritizeOneSpecificParameterSet && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 165078, 165079)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 165082, 165083))) ? 2 : 1
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 165100, 165657) || true) && (needToPrioritizeOneSpecificParameterSet)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 165100, 165657);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 165380, 165557);

                    f_1243_165380_165556((_currentParameterSetFlag & _parameterSetToBePrioritizedInPipelineBinding) != 0, "_parameterSetToBePrioritizedInPipelineBinding should be valid if it's set");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 165575, 165642);

                    validParameterSets = _parameterSetToBePrioritizedInPipelineBinding;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 165100, 165657);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 165682, 165687);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 165673, 167870) || true) && (i < steps)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 165700, 165703)
        , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 165673, 167870))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 165673, 167870);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 165759, 165822);
                            for (CurrentlyBinding
            currentlyBinding = CurrentlyBinding.ValueFromPipelineNoCoercion
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 165737, 167285) || true) && (currentlyBinding <= CurrentlyBinding.ValueFromPipelineByPropertyNameWithCoercion)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 165906, 165924)
            , ++currentlyBinding, DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 165737, 167285))

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 165737, 167285);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 166121, 166373);

                                bool
                                parameterBoundForCurrentlyBindingState =
                                f_1243_166192_166372(this, inputToOperateOn, currentlyBinding, validParameterSets)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 166397, 167266) || true) && (parameterBoundForCurrentlyBindingState)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 166397, 167266);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 166952, 167201) || true) && (!needToPrioritizeOneSpecificParameterSet || (DynAbs.Tracing.TraceSender.Expression_False(1243, 166956, 167006) || i == 1))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 166952, 167201);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 167064, 167098);

                                        f_1243_167064_167097(this, true, true);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 167128, 167174);

                                        validParameterSets = _currentParameterSetFlag;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 166952, 167201);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 167229, 167243);

                                    result = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 166397, 167266);
                                }
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 1549);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 1549);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 167415, 167855) || true) && (needToPrioritizeOneSpecificParameterSet && (DynAbs.Tracing.TraceSender.Expression_True(1243, 167419, 167468) && i == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 167415, 167855);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 167632, 167717) || true) && (_currentParameterSetFlag == _parameterSetToBePrioritizedInPipelineBinding)
                            )
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 167632, 167717);
                                DynAbs.Tracing.TraceSender.TraceBreak(1243, 167711, 167717);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 167632, 167717);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 167739, 167836);

                            validParameterSets = _currentParameterSetFlag & (~_parameterSetToBePrioritizedInPipelineBinding);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 167415, 167855);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 2198);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 2198);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 168019, 168054);

                f_1243_168019_168053(this, false, true);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 168070, 168205) || true) && (f_1243_168074_168103_M(!DefaultParameterBindingInUse))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 168070, 168205);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 168137, 168190);

                    f_1243_168137_168189(this, "PIPELINE BIND", false);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 168070, 168205);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 168221, 168235);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 163516, 168246);

                bool
                f_1243_163614_163657(System.Management.Automation.PSTraceSource
                this_param)
                {
                    var return_v = this_param.IsEnabled;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 163614, 163657);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1243_163920_163940()
                {
                    var return_v = AutomationNull.Value
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 163920, 163940);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1243_164031_164065(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 164031, 164065);
                    return return_v;
                }


                int
                f_1243_164003_164072(System.Management.Automation.Runspaces.ConsolidatedString
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 164003, 164072);
                    return return_v;
                }


                string
                f_1243_164080_164107(System.Management.Automation.Runspaces.ConsolidatedString
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 164080, 164107);
                    return return_v;
                }


                string
                f_1243_164150_164177(System.Management.Automation.Runspaces.ConsolidatedString
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 164150, 164177);
                    return return_v;
                }


                object
                f_1243_164211_164238(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 164211, 164238);
                    return return_v;
                }


                System.Type
                f_1243_164211_164248(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 164211, 164248);
                    return return_v;
                }


                string
                f_1243_164211_164257(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 164211, 164257);
                    return return_v;
                }


                int
                f_1243_163753_164258(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 163753, 164258);
                    return 0;
                }


                int
                f_1243_164279_164372(System.Management.Automation.PSTraceSource
                this_param, string
                format)
                {
                    this_param.WriteLine(format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 164279, 164372);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_164518_164553()
                {
                    var return_v = ParametersBoundThroughPipelineInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 164518, 164553);
                    return return_v;
                }


                int
                f_1243_164483_164554(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                parameters)
                {
                    this_param.RestoreDefaultParameterValues((System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>)parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 164483, 164554);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_164652_164687()
                {
                    var return_v = ParametersBoundThroughPipelineInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 164652, 164687);
                    return return_v;
                }


                int
                f_1243_164652_164695(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 164652, 164695);
                    return 0;
                }


                int
                f_1243_165380_165556(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 165380, 165556);
                    return 0;
                }


                bool
                f_1243_166192_166372(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.PSObject
                inputToOperateOn, System.Management.Automation.CmdletParameterBinderController.CurrentlyBinding
                currentlyBinding, uint
                validParameterSets)
                {
                    var return_v = this_param.BindUnboundParametersForBindingState(inputToOperateOn, currentlyBinding, validParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 166192, 166372);
                    return return_v;
                }


                int
                f_1243_167064_167097(System.Management.Automation.CmdletParameterBinderController
                this_param, bool
                prePipelineInput, bool
                setDefault)
                {
                    var return_v = this_param.ValidateParameterSets(prePipelineInput, setDefault);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 167064, 167097);
                    return return_v;
                }


                int
                f_1243_168019_168053(System.Management.Automation.CmdletParameterBinderController
                this_param, bool
                prePipelineInput, bool
                setDefault)
                {
                    var return_v = this_param.ValidateParameterSets(prePipelineInput, setDefault);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 168019, 168053);
                    return return_v;
                }


                bool
                f_1243_168074_168103_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 168074, 168103);
                    return return_v;
                }


                int
                f_1243_168137_168189(System.Management.Automation.CmdletParameterBinderController
                this_param, string
                bindingStage, bool
                isDynamic)
                {
                    this_param.ApplyDefaultParameterBinding(bindingStage, isDynamic);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 168137, 168189);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 163516, 168246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 163516, 168246);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool BindUnboundParametersForBindingState(
                    PSObject inputToOperateOn,
                    CurrentlyBinding currentlyBinding,
                    uint validParameterSets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 168258, 169995);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 168459, 168491);

                bool
                aParameterWasBound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 168632, 168704);

                uint
                defaultParameterSetFlag = f_1243_168663_168703(_commandMetadata)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 168720, 169396) || true) && (defaultParameterSetFlag != 0 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 168724, 168807) && (validParameterSets & defaultParameterSetFlag) != 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 168720, 169396);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 168998, 169228);

                    aParameterWasBound =
                    f_1243_169040_169227(this, inputToOperateOn, currentlyBinding, defaultParameterSetFlag);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 169248, 169381) || true) && (!aParameterWasBound)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 169248, 169381);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 169313, 169362);

                        validParameterSets &= ~(defaultParameterSetFlag);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 169248, 169381);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 168720, 169396);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 169412, 169861) || true) && (!aParameterWasBound)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 169412, 169861);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 169621, 169846);

                    aParameterWasBound =
                    f_1243_169663_169845(this, inputToOperateOn, currentlyBinding, validParameterSets);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 169412, 169861);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 169877, 169944);

                f_1243_169877_169943(
                            s_tracer, "aParameterWasBound = {0}", aParameterWasBound);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 169958, 169984);

                return aParameterWasBound;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 168258, 169995);

                uint
                f_1243_168663_168703(System.Management.Automation.CommandMetadata
                this_param)
                {
                    var return_v = this_param.DefaultParameterSetFlag;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 168663, 168703);
                    return return_v;
                }


                bool
                f_1243_169040_169227(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.PSObject
                inputToOperateOn, System.Management.Automation.CmdletParameterBinderController.CurrentlyBinding
                currentlyBinding, uint
                validParameterSets)
                {
                    var return_v = this_param.BindUnboundParametersForBindingStateInParameterSet(inputToOperateOn, currentlyBinding, validParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 169040, 169227);
                    return return_v;
                }


                bool
                f_1243_169663_169845(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.PSObject
                inputToOperateOn, System.Management.Automation.CmdletParameterBinderController.CurrentlyBinding
                currentlyBinding, uint
                validParameterSets)
                {
                    var return_v = this_param.BindUnboundParametersForBindingStateInParameterSet(inputToOperateOn, currentlyBinding, validParameterSets);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 169663, 169845);
                    return return_v;
                }


                int
                f_1243_169877_169943(System.Management.Automation.PSTraceSource
                this_param, string
                format, bool
                arg1)
                {
                    this_param.WriteLine(format, arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 169877, 169943);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 168258, 169995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 168258, 169995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool BindUnboundParametersForBindingStateInParameterSet(
                    PSObject inputToOperateOn,
                    CurrentlyBinding currentlyBinding,
                    uint validParameterSets)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 170007, 174743);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 170222, 170254);

                bool
                aParameterWasBound = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 171460, 171491);

                    // For all unbound parameters in the parameter set, see if we can bind
                    // from the input object directly from pipeline without type coercion.
                    //
                    // We loop the unbound parameters in reversed order, so that we can move
                    // items from the unboundParameters collection to the boundParameters
                    // collection as we process, without the need to make a copy of the
                    // unboundParameters collection.
                    //
                    // We used to make a copy of UnboundParameters and loop from the head of the
                    // list. Now we are processing the unbound parameters from the end of the list.
                    // This change should NOT be a breaking change. The 'validParameterSets' in
                    // this method never changes, so no matter we start from the head or the end of
                    // the list, every unbound parameter in the list that takes pipeline input and
                    // satisfy the 'validParameterSets' will be bound. If parameters from more than
                    // one sets got bound, then "parameter set cannot be resolved" error will be thrown,
                    // which is expected.

                    for (int
        i = f_1243_171464_171487(f_1243_171464_171481()) - 1
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 171451, 174690) || true) && (i >= 0)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 171501, 171504)
        , i--, DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 171451, 174690))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 171451, 174690);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 171538, 171575);

                        var
                        parameter = f_1243_171554_171574(f_1243_171554_171571(), i)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 171681, 171775) || true) && (f_1243_171685_171743_M(!f_1243_171686_171705(parameter).IsPipelineParameterInSomeParameterSet))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 171681, 171775);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 171766, 171775);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 171681, 171775);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 171889, 172085) || true) && ((validParameterSets & f_1243_171915_171952(f_1243_171915_171934(parameter))) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 171893, 172015) && f_1243_171983_172015_M(!f_1243_171984_172003(parameter).IsInAllSets)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 171889, 172085);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 172057, 172066);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 171889, 172085);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 172164, 172255);

                        var
                        parameterSetData = f_1243_172187_172254(f_1243_172187_172206(parameter), validParameterSets)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 172275, 172299);

                        bool
                        bindResult = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 172319, 174675);
                            foreach (ParameterSetSpecificMetadata parameterSetMetadata in f_1243_172381_172397_I(parameterSetData))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 172319, 174675);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 172573, 174487) || true) && (currentlyBinding == CurrentlyBinding.ValueFromPipelineNoCoercion && (DynAbs.Tracing.TraceSender.Expression_True(1243, 172577, 172708) && f_1243_172670_172708(parameterSetMetadata)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 172573, 174487);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 172758, 172850);

                                    bindResult = f_1243_172771_172849(this, inputToOperateOn, parameter, ParameterBindingFlags.None);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 172573, 174487);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 172573, 174487);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 173039, 174487) || true) && (currentlyBinding == CurrentlyBinding.ValueFromPipelineByPropertyNameNoCoercion && (DynAbs.Tracing.TraceSender.Expression_True(1243, 173043, 173202) && f_1243_173150_173202(parameterSetMetadata)) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 173043, 173255) && inputToOperateOn != null))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 173039, 174487);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 173305, 173411);

                                        bindResult = f_1243_173318_173410(this, inputToOperateOn, parameter, ParameterBindingFlags.None);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 173039, 174487);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 173039, 174487);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 173594, 174487) || true) && (currentlyBinding == CurrentlyBinding.ValueFromPipelineWithCoercion && (DynAbs.Tracing.TraceSender.Expression_True(1243, 173598, 173731) && f_1243_173693_173731(parameterSetMetadata)))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 173594, 174487);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 173781, 173885);

                                            bindResult = f_1243_173794_173884(this, inputToOperateOn, parameter, ParameterBindingFlags.ShouldCoerceType);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 173594, 174487);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 173594, 174487);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 174078, 174487) || true) && (currentlyBinding == CurrentlyBinding.ValueFromPipelineByPropertyNameWithCoercion && (DynAbs.Tracing.TraceSender.Expression_True(1243, 174082, 174243) && f_1243_174191_174243(parameterSetMetadata)) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 174082, 174296) && inputToOperateOn != null))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 174078, 174487);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 174346, 174464);

                                                bindResult = f_1243_174359_174463(this, inputToOperateOn, parameter, ParameterBindingFlags.ShouldCoerceType);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 174078, 174487);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 173594, 174487);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 173039, 174487);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 172573, 174487);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 174511, 174656) || true) && (bindResult)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 174511, 174656);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 174575, 174601);

                                    aParameterWasBound = true;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1243, 174627, 174633);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 174511, 174656);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 172319, 174675);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 2357);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 2357);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 3240);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 3240);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 174706, 174732);

                return aParameterWasBound;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 170007, 174743);

                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_171464_171481()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 171464, 171481);
                    return return_v;
                }


                int
                f_1243_171464_171487(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 171464, 171487);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_171554_171571()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 171554, 171571);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1243_171554_171574(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 171554, 171574);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_171686_171705(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 171686, 171705);
                    return return_v;
                }


                bool
                f_1243_171685_171743_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 171685, 171743);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_171915_171934(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 171915, 171934);
                    return return_v;
                }


                uint
                f_1243_171915_171952(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.ParameterSetFlags;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 171915, 171952);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_171984_172003(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 171984, 172003);
                    return return_v;
                }


                bool
                f_1243_171983_172015_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 171983, 172015);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_172187_172206(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 172187, 172206);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_172187_172254(System.Management.Automation.CompiledCommandParameter
                this_param, uint
                parameterSetFlags)
                {
                    var return_v = this_param.GetMatchingParameterSetData(parameterSetFlags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 172187, 172254);
                    return return_v;
                }


                bool
                f_1243_172670_172708(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 172670, 172708);
                    return return_v;
                }


                bool
                f_1243_172771_172849(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.PSObject
                inputToOperateOn, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindValueFromPipeline(inputToOperateOn, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 172771, 172849);
                    return return_v;
                }


                bool
                f_1243_173150_173202(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineByPropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 173150, 173202);
                    return return_v;
                }


                bool
                f_1243_173318_173410(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.PSObject
                inputToOperateOn, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindValueFromPipelineByPropertyName(inputToOperateOn, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 173318, 173410);
                    return return_v;
                }


                bool
                f_1243_173693_173731(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipeline;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 173693, 173731);
                    return return_v;
                }


                bool
                f_1243_173794_173884(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.PSObject
                inputToOperateOn, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindValueFromPipeline(inputToOperateOn, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 173794, 173884);
                    return return_v;
                }


                bool
                f_1243_174191_174243(System.Management.Automation.ParameterSetSpecificMetadata
                this_param)
                {
                    var return_v = this_param.ValueFromPipelineByPropertyName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 174191, 174243);
                    return return_v;
                }


                bool
                f_1243_174359_174463(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.PSObject
                inputToOperateOn, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindValueFromPipelineByPropertyName(inputToOperateOn, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 174359, 174463);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                f_1243_172381_172397_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ParameterSetSpecificMetadata>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 172381, 172397);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 170007, 174743);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 170007, 174743);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool BindValueFromPipeline(
                    PSObject inputToOperateOn,
                    MergedCompiledCommandParameter parameter,
                    ParameterBindingFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 174755, 177222);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 174952, 174976);

                bool
                bindResult = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 175092, 175428);

                f_1243_175092_175427(
                            // Attempt binding the value from the pipeline
                            // without type coercion

                            ParameterBinderBase.bindingTracer, (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 175154, 175209) || ((((flags & ParameterBindingFlags.ShouldCoerceType) != 0) && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 175233, 175297)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 175321, 175383))) ? "Parameter [{0}] PIPELINE INPUT ValueFromPipeline WITH COERCION" : "Parameter [{0}] PIPELINE INPUT ValueFromPipeline NO COERCION", f_1243_175402_175426(f_1243_175402_175421(parameter)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 175444, 175503);

                ParameterBindingException
                parameterBindingException = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 175553, 175624);

                    bindResult = f_1243_175566_175623(this, inputToOperateOn, parameter, flags);
                }
                catch (ParameterBindingArgumentTransformationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 175653, 176363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 175743, 175778);

                    PSInvalidCastException
                    invalidCast
                    = default(PSInvalidCastException);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 175796, 176131) || true) && (f_1243_175800_175816(e) is ArgumentTransformationMetadataException)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 175796, 176131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 175901, 175973);

                        invalidCast = f_1243_175915_175946(f_1243_175915_175931(e)) as PSInvalidCastException;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 175796, 176131);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 175796, 176131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 176055, 176112);

                        invalidCast = f_1243_176069_176085(e) as PSInvalidCastException;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 175796, 176131);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 176151, 176265) || true) && (invalidCast == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 176151, 176265);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 176216, 176246);

                        parameterBindingException = e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 176151, 176265);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 176329, 176348);

                    bindResult = false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 175653, 176363);
                }
                catch (ParameterBindingValidationException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 176377, 176500);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 176455, 176485);

                    parameterBindingException = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 176377, 176500);
                }
                catch (ParameterBindingParameterDefaultValueException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 176514, 176648);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 176603, 176633);

                    parameterBindingException = e;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 176514, 176648);
                }
                catch (ParameterBindingException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 176662, 176808);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 176774, 176793);

                    bindResult = false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 176662, 176808);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 176824, 177177) || true) && (parameterBindingException != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 176824, 177177);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 176895, 177162) || true) && (f_1243_176899_176928_M(!DefaultParameterBindingInUse))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 176895, 177162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 176970, 177002);

                        throw parameterBindingException;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 176895, 177162);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 176895, 177162);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 177084, 177143);

                        f_1243_177084_177142(this, parameterBindingException);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 176895, 177162);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 176824, 177177);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 177193, 177211);

                return bindResult;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 174755, 177222);

                System.Management.Automation.CompiledCommandParameter
                f_1243_175402_175421(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 175402, 175421);
                    return return_v;
                }


                string
                f_1243_175402_175426(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 175402, 175426);
                    return return_v;
                }


                int
                f_1243_175092_175427(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 175092, 175427);
                    return 0;
                }


                bool
                f_1243_175566_175623(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.PSObject
                parameterValue, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindPipelineParameter((object)parameterValue, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 175566, 175623);
                    return return_v;
                }


                System.Exception
                f_1243_175800_175816(System.Management.Automation.ParameterBindingArgumentTransformationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 175800, 175816);
                    return return_v;
                }


                System.Exception
                f_1243_175915_175931(System.Management.Automation.ParameterBindingArgumentTransformationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 175915, 175931);
                    return return_v;
                }


                System.Exception
                f_1243_175915_175946(System.Exception
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 175915, 175946);
                    return return_v;
                }


                System.Exception
                f_1243_176069_176085(System.Management.Automation.ParameterBindingArgumentTransformationException
                this_param)
                {
                    var return_v = this_param.InnerException;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 176069, 176085);
                    return return_v;
                }


                bool
                f_1243_176899_176928_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 176899, 176928);
                    return return_v;
                }


                int
                f_1243_177084_177142(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.ParameterBindingException
                pbex)
                {
                    this_param.ThrowElaboratedBindingException(pbex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 177084, 177142);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 174755, 177222);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 174755, 177222);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool BindValueFromPipelineByPropertyName(
                    PSObject inputToOperateOn,
                    MergedCompiledCommandParameter parameter,
                    ParameterBindingFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 177234, 179950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 177445, 177469);

                bool
                bindResult = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 177485, 177849);

                f_1243_177485_177848(
                            ParameterBinderBase.bindingTracer, (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 177547, 177602) || ((((flags & ParameterBindingFlags.ShouldCoerceType) != 0) && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 177626, 177704)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 177728, 177804))) ? "Parameter [{0}] PIPELINE INPUT ValueFromPipelineByPropertyName WITH COERCION" : "Parameter [{0}] PIPELINE INPUT ValueFromPipelineByPropertyName NO COERCION", f_1243_177823_177847(f_1243_177823_177842(parameter)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 177865, 177941);

                PSMemberInfo
                member = f_1243_177887_177940(f_1243_177887_177914(inputToOperateOn), f_1243_177915_177939(f_1243_177915_177934(parameter)))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 177957, 178427) || true) && (member == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 177957, 178427);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 178134, 178412);
                        foreach (string alias in f_1243_178159_178186_I(f_1243_178159_178186(f_1243_178159_178178(parameter))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 178134, 178412);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 178228, 178272);

                            member = f_1243_178237_178271(f_1243_178237_178264(inputToOperateOn), alias);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 178296, 178393) || true) && (member != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 178296, 178393);
                                DynAbs.Tracing.TraceSender.TraceBreak(1243, 178364, 178370);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 178296, 178393);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 178134, 178412);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 279);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 279);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 177957, 178427);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 178443, 179905) || true) && (member != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 178443, 179905);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 178495, 178554);

                    ParameterBindingException
                    parameterBindingException = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 178616, 178796);

                        bindResult =
                        f_1243_178654_178795(this, f_1243_178706_178718(member), parameter, flags);
                    }
                    catch (ParameterBindingArgumentTransformationException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 178833, 178980);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 178931, 178961);

                        parameterBindingException = e;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 178833, 178980);
                    }
                    catch (ParameterBindingValidationException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 178998, 179133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 179084, 179114);

                        parameterBindingException = e;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 178998, 179133);
                    }
                    catch (ParameterBindingParameterDefaultValueException e)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 179151, 179297);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 179248, 179278);

                        parameterBindingException = e;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 179151, 179297);
                    }
                    catch (ParameterBindingException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 179315, 179477);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 179439, 179458);

                        bindResult = false;
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 179315, 179477);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 179497, 179890) || true) && (parameterBindingException != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 179497, 179890);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 179576, 179871) || true) && (f_1243_179580_179609_M(!DefaultParameterBindingInUse))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 179576, 179871);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 179659, 179691);

                            throw parameterBindingException;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 179576, 179871);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 179576, 179871);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 179789, 179848);

                            f_1243_179789_179847(this, parameterBindingException);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 179576, 179871);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 179497, 179890);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 178443, 179905);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 179921, 179939);

                return bindResult;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 177234, 179950);

                System.Management.Automation.CompiledCommandParameter
                f_1243_177823_177842(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 177823, 177842);
                    return return_v;
                }


                string
                f_1243_177823_177847(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 177823, 177847);
                    return return_v;
                }


                int
                f_1243_177485_177848(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1)
                {
                    this_param.WriteLine(format, (object)arg1);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 177485, 177848);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1243_177887_177914(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 177887, 177914);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_177915_177934(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 177915, 177934);
                    return return_v;
                }


                string
                f_1243_177915_177939(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 177915, 177939);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1243_177887_177940(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 177887, 177940);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_178159_178178(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 178159, 178178);
                    return return_v;
                }


                string[]
                f_1243_178159_178186(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Aliases;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 178159, 178186);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1243_178237_178264(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 178237, 178264);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1243_178237_178271(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 178237, 178271);
                    return return_v;
                }


                string[]
                f_1243_178159_178186_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 178159, 178186);
                    return return_v;
                }


                object
                f_1243_178706_178718(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 178706, 178718);
                    return return_v;
                }


                bool
                f_1243_178654_178795(System.Management.Automation.CmdletParameterBinderController
                this_param, object
                parameterValue, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindPipelineParameter(parameterValue, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 178654, 178795);
                    return return_v;
                }


                bool
                f_1243_179580_179609_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 179580, 179609);
                    return return_v;
                }


                int
                f_1243_179789_179847(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.ParameterBindingException
                pbex)
                {
                    this_param.ThrowElaboratedBindingException(pbex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 179789, 179847);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 177234, 179950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 177234, 179950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        /// <summary>
        /// Used for defining the state of the binding state machine.
        /// </summary>
        private enum CurrentlyBinding
        {
            ValueFromPipelineNoCoercion = 0,
            ValueFromPipelineByPropertyNameNoCoercion = 1,
            ValueFromPipelineWithCoercion = 2,
            ValueFromPipelineByPropertyNameWithCoercion = 3
        }

        private bool InvokeAndBindDelayBindScriptBlock(PSObject inputToOperateOn, out bool thereWasSomethingToBind)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 181299, 186172);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 181431, 181463);

                thereWasSomethingToBind = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 181477, 181496);

                bool
                result = true
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 182093, 186131);
                    foreach (KeyValuePair<MergedCompiledCommandParameter, DelayedScriptBlockArgument> delayedScriptBlock in f_1243_182197_182219_I(_delayBindScriptBlocks))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 182093, 186131);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 182253, 182284);

                        thereWasSomethingToBind = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 182304, 182375);

                        CommandParameterInternal
                        argument = delayedScriptBlock.Value._argument
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 182393, 182459);

                        MergedCompiledCommandParameter
                        parameter = delayedScriptBlock.Key
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 182479, 182538);

                        ScriptBlock
                        script = f_1243_182500_182522(argument) as ScriptBlock
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 182558, 182733);

                        f_1243_182558_182732(script != null, "An argument should only be put in the delayBindScriptBlocks collection if it is a ScriptBlock");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 182753, 182788);

                        Collection<PSObject>
                        output = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 182808, 182831);

                        Exception
                        error = null
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 182849, 183725);
                        using (f_1243_182856_182957(ParameterBinderBase.bindingTracer, "Invoking delay-bind ScriptBlock"))
                        {

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 182999, 183706) || true) && (delayedScriptBlock.Value._parameterBinder == this)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 182999, 183706);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 183162, 183246);

                                    output = f_1243_183171_183245(script, inputToOperateOn, inputToOperateOn, f_1243_183223_183244());
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 183276, 183329);

                                    delayedScriptBlock.Value._evaluatedArgument = output;
                                }
                                catch (RuntimeException runtimeException)
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 183382, 183532);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 183480, 183505);

                                    error = runtimeException;
                                    DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 183382, 183532);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 182999, 183706);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 182999, 183706);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 183630, 183683);

                                output = delayedScriptBlock.Value._evaluatedArgument;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 182999, 183706);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1243, 182849, 183725);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 183745, 184504) || true) && (error != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 183745, 184504);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 183804, 184438);

                            ParameterBindingException
                            bindingException =
                            f_1243_183874_184437(error, ErrorCategory.InvalidArgument, f_1243_184030_184055(f_1243_184030_184042(this)), f_1243_184086_184110(this, argument), f_1243_184141_184165(f_1243_184141_184160(parameter)), null, null, f_1243_184266_184324(), "ScriptBlockArgumentInvocationFailed", f_1243_184423_184436(error))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 184462, 184485);

                            throw bindingException;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 183745, 184504);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 184524, 185244) || true) && (output == null || (DynAbs.Tracing.TraceSender.Expression_False(1243, 184528, 184563) || f_1243_184546_184558(output) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 184524, 185244);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 184605, 185178);

                            ParameterBindingException
                            bindingException =
                            f_1243_184675_185177(null, ErrorCategory.InvalidArgument, f_1243_184830_184855(f_1243_184830_184842(this)), f_1243_184886_184910(this, argument), f_1243_184941_184965(f_1243_184941_184960(parameter)), null, null, f_1243_185066_185116(), "ScriptBlockArgumentNoOutput")
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 185202, 185225);

                            throw bindingException;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 184524, 185244);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 185421, 185446);

                        object
                        newValue = output
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 185464, 185567) || true) && (f_1243_185468_185480(output) == 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 185464, 185567);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 185527, 185548);

                            newValue = f_1243_185538_185547(output, 0);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 185464, 185567);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 185681, 185938);

                        var
                        newArgument = f_1243_185699_185937(f_1243_185774_185795(argument), f_1243_185797_185819(argument), "-" + f_1243_185827_185849(argument) + ":", f_1243_185878_185898(argument), newValue, false)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 185958, 186116) || true) && (!f_1243_185963_186040(this, newArgument, parameter, ParameterBindingFlags.ShouldCoerceType))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 185958, 186116);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 186082, 186097);

                            result = false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 185958, 186116);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 182093, 186131);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 4039);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 4039);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 186147, 186161);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 181299, 186172);

                object
                f_1243_182500_182522(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 182500, 182522);
                    return return_v;
                }


                int
                f_1243_182558_182732(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 182558, 182732);
                    return 0;
                }


                System.IDisposable
                f_1243_182856_182957(System.Management.Automation.PSTraceSource
                this_param, string
                msg)
                {
                    var return_v = this_param.TraceScope(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 182856, 182957);
                    return return_v;
                }


                object[]
                f_1243_183223_183244()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 183223, 183244);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                f_1243_183171_183245(System.Management.Automation.ScriptBlock
                this_param, System.Management.Automation.PSObject
                dollarUnder, System.Management.Automation.PSObject
                input, object[]
                args)
                {
                    var return_v = this_param.DoInvoke((object)dollarUnder, (object)input, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 183171, 183245);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_184030_184042(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 184030, 184042);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_184030_184055(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 184030, 184055);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1243_184086_184110(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 184086, 184110);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_184141_184160(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 184141, 184160);
                    return return_v;
                }


                string
                f_1243_184141_184165(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 184141, 184165);
                    return return_v;
                }


                string
                f_1243_184266_184324()
                {
                    var return_v = ParameterBinderStrings.ScriptBlockArgumentInvocationFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 184266, 184324);
                    return return_v;
                }


                string
                f_1243_184423_184436(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 184423, 184436);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1243_183874_184437(System.Exception
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 183874, 184437);
                    return return_v;
                }


                int
                f_1243_184546_184558(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 184546, 184558);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_184830_184842(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 184830, 184842);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_184830_184855(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 184830, 184855);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1243_184886_184910(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 184886, 184910);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_184941_184960(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 184941, 184960);
                    return return_v;
                }


                string
                f_1243_184941_184965(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 184941, 184965);
                    return return_v;
                }


                string
                f_1243_185066_185116()
                {
                    var return_v = ParameterBinderStrings.ScriptBlockArgumentNoOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 185066, 185116);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1243_184675_185177(System.Exception
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 184675, 185177);
                    return return_v;
                }


                int
                f_1243_185468_185480(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 185468, 185480);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1243_185538_185547(System.Collections.ObjectModel.Collection<System.Management.Automation.PSObject>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 185538, 185547);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1243_185774_185795(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 185774, 185795);
                    return return_v;
                }


                string
                f_1243_185797_185819(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 185797, 185819);
                    return return_v;
                }


                string
                f_1243_185827_185849(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ParameterName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 185827, 185849);
                    return return_v;
                }


                System.Management.Automation.Language.Ast
                f_1243_185878_185898(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentAst;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 185878, 185898);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1243_185699_185937(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, object
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 185699, 185937);
                    return return_v;
                }


                bool
                f_1243_185963_186040(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(argument, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 185963, 186040);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.CmdletParameterBinderController.DelayedScriptBlockArgument>
                f_1243_182197_182219_I(System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.CmdletParameterBinderController.DelayedScriptBlockArgument>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 182197, 182219);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 181299, 186172);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 181299, 186172);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int ValidParameterSetCount(uint parameterSetFlags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1243, 186576, 187079);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 186666, 186681);

                int
                result = 0
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 186697, 187038) || true) && (parameterSetFlags == uint.MaxValue)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 186697, 187038);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 186769, 186780);

                    result = 1;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 186697, 187038);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 186697, 187038);
                    try
                    {
                        while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 186846, 187023) || true) && (parameterSetFlags != 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 186846, 187023);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 186917, 186958);

                            result += (int)(parameterSetFlags & 0x1);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 186980, 187004);

                            parameterSetFlags >>= 1;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 186846, 187023);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 186846, 187023);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 186846, 187023);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 186697, 187038);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 187054, 187068);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1243, 186576, 187079);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 186576, 187079);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 186576, 187079);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal object GetDefaultParameterValue(string name)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 187826, 189971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 187904, 188122);

                MergedCompiledCommandParameter
                matchingParameter =
                f_1243_187972_188121(f_1243_187972_187990(), name, false, true, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 188138, 188159);

                object
                result = null
                ;

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 188211, 189213);

                    switch (f_1243_188219_188254(matchingParameter))
                    {

                        case ParameterBinderAssociation.DeclaredFormalParameters:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 188211, 189213);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 188379, 188442);

                            result = f_1243_188388_188441(f_1243_188388_188410(), name);
                            DynAbs.Tracing.TraceSender.TraceBreak(1243, 188468, 188474);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 188211, 189213);

                        case ParameterBinderAssociation.CommonParameters:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 188211, 189213);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 188573, 188636);

                            result = f_1243_188582_188635(f_1243_188582_188604(), name);
                            DynAbs.Tracing.TraceSender.TraceBreak(1243, 188662, 188668);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 188211, 189213);

                        case ParameterBinderAssociation.ShouldProcessParameters:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 188211, 189213);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 188774, 188844);

                            result = f_1243_188783_188843(f_1243_188783_188812(), name);
                            DynAbs.Tracing.TraceSender.TraceBreak(1243, 188870, 188876);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 188211, 189213);

                        case ParameterBinderAssociation.DynamicParameters:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 188211, 189213);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 188976, 189160) || true) && (_dynamicParameterBinder != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 188976, 189160);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 189069, 189133);

                                result = f_1243_189078_189132(_dynamicParameterBinder, name);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 188976, 189160);
                            }
                            DynAbs.Tracing.TraceSender.TraceBreak(1243, 189188, 189194);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 188211, 189213);
                    }
                }
                catch (GetValueException getValueException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 189242, 189930);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 189318, 189876);

                    ParameterBindingParameterDefaultValueException
                    bindingError =
                    f_1243_189401_189875(getValueException, ErrorCategory.ReadError, f_1243_189572_189597(f_1243_189572_189584(this)), null, name, null, null, "ParameterBinderStrings", "GetDefaultValueFailed", f_1243_189849_189874(getValueException))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 189896, 189915);

                    throw bindingError;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 189242, 189930);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 189946, 189960);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 187826, 189971);

                System.Management.Automation.MergedCommandParameterMetadata
                f_1243_187972_187990()
                {
                    var return_v = BindableParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 187972, 187990);
                    return return_v;
                }


                System.Management.Automation.MergedCompiledCommandParameter
                f_1243_187972_188121(System.Management.Automation.MergedCommandParameterMetadata
                this_param, string
                name, bool
                throwOnParameterNotFound, bool
                tryExactMatching, System.Management.Automation.InvocationInfo
                invocationInfo)
                {
                    var return_v = this_param.GetMatchingParameter(name, throwOnParameterNotFound, tryExactMatching, invocationInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 187972, 188121);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderAssociation
                f_1243_188219_188254(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.BinderAssociation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 188219, 188254);
                    return return_v;
                }


                System.Management.Automation.ParameterBinderBase
                f_1243_188388_188410()
                {
                    var return_v = DefaultParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 188388, 188410);
                    return return_v;
                }


                object
                f_1243_188388_188441(System.Management.Automation.ParameterBinderBase
                this_param, string
                name)
                {
                    var return_v = this_param.GetDefaultParameterValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 188388, 188441);
                    return return_v;
                }


                System.Management.Automation.ReflectionParameterBinder
                f_1243_188582_188604()
                {
                    var return_v = CommonParametersBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 188582, 188604);
                    return return_v;
                }


                object
                f_1243_188582_188635(System.Management.Automation.ReflectionParameterBinder
                this_param, string
                name)
                {
                    var return_v = this_param.GetDefaultParameterValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 188582, 188635);
                    return return_v;
                }


                System.Management.Automation.ReflectionParameterBinder
                f_1243_188783_188812()
                {
                    var return_v = ShouldProcessParametersBinder;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 188783, 188812);
                    return return_v;
                }


                object
                f_1243_188783_188843(System.Management.Automation.ReflectionParameterBinder
                this_param, string
                name)
                {
                    var return_v = this_param.GetDefaultParameterValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 188783, 188843);
                    return return_v;
                }


                object
                f_1243_189078_189132(System.Management.Automation.ParameterBinderBase
                this_param, string
                name)
                {
                    var return_v = this_param.GetDefaultParameterValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 189078, 189132);
                    return return_v;
                }


                System.Management.Automation.Cmdlet
                f_1243_189572_189584(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.Command;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 189572, 189584);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_189572_189597(System.Management.Automation.Cmdlet
                this_param)
                {
                    var return_v = this_param.MyInvocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 189572, 189597);
                    return return_v;
                }


                string
                f_1243_189849_189874(System.Management.Automation.GetValueException
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 189849, 189874);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingParameterDefaultValueException
                f_1243_189401_189875(System.Management.Automation.GetValueException
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
                    var return_v = new System.Management.Automation.ParameterBindingParameterDefaultValueException((System.Exception)innerException, errorCategory, invocationInfo, errorPosition, parameterName, parameterType, typeSpecified, resourceString, errorId, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 189401, 189875);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 187826, 189971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 187826, 189971);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Cmdlet Command { get; private set; }

        private const string
        Separator = ":::"
        ;

        private List<string> _aliasList;

        private readonly HashSet<string> _warningSet;

        private Dictionary<MergedCompiledCommandParameter, object> _allDefaultParameterValuePairs;

        private bool _useDefaultParameterBinding;

        private uint _parameterSetToBePrioritizedInPipelineBinding;

        private readonly CommandMetadata _commandMetadata;

        private readonly MshCommandRuntime _commandRuntime;

        internal List<WarningRecord> ObsoleteParameterWarningList { get; private set; }

        private HashSet<string> BoundObsoleteParameterNames
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 192313, 192514);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 192349, 192499);

                    return _boundObsoleteParameterNames ?? (DynAbs.Tracing.TraceSender.Expression_Null<System.Collections.Generic.HashSet<string>>(1243, 192356, 192498) ?? (_boundObsoleteParameterNames = f_1243_192444_192497(f_1243_192464_192496())));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 192313, 192514);

                    System.StringComparer
                    f_1243_192464_192496()
                    {
                        var return_v = StringComparer.OrdinalIgnoreCase;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 192464, 192496);
                        return return_v;
                    }


                    System.Collections.Generic.HashSet<string>
                    f_1243_192444_192497(System.StringComparer
                    comparer)
                    {
                        var return_v = new System.Collections.Generic.HashSet<string>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 192444, 192497);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 192237, 192525);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 192237, 192525);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private HashSet<string> _boundObsoleteParameterNames;

        private ParameterBinderBase _dynamicParameterBinder;

        internal ReflectionParameterBinder ShouldProcessParametersBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 193085, 193812);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 193121, 193740) || true) && (_shouldProcessParameterBinder == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 193121, 193740);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 193293, 193388);

                        ShouldProcessParameters
                        shouldProcessParameters = f_1243_193343_193387(_commandRuntime)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 193479, 193721);

                        _shouldProcessParameterBinder =
                        f_1243_193536_193720(shouldProcessParameters, f_1243_193650_193662(this), f_1243_193693_193719(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 193121, 193740);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 193760, 193797);

                    return _shouldProcessParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 193085, 193812);

                    System.Management.Automation.Internal.ShouldProcessParameters
                    f_1243_193343_193387(System.Management.Automation.MshCommandRuntime
                    commandRuntime)
                    {
                        var return_v = new System.Management.Automation.Internal.ShouldProcessParameters(commandRuntime);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 193343, 193387);
                        return return_v;
                    }


                    System.Management.Automation.Cmdlet
                    f_1243_193650_193662(System.Management.Automation.CmdletParameterBinderController
                    this_param)
                    {
                        var return_v = this_param.Command;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 193650, 193662);
                        return return_v;
                    }


                    System.Management.Automation.CommandLineParameters
                    f_1243_193693_193719(System.Management.Automation.CmdletParameterBinderController
                    this_param)
                    {
                        var return_v = this_param.CommandLineParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 193693, 193719);
                        return return_v;
                    }


                    System.Management.Automation.ReflectionParameterBinder
                    f_1243_193536_193720(System.Management.Automation.Internal.ShouldProcessParameters
                    target, System.Management.Automation.Cmdlet
                    command, System.Management.Automation.CommandLineParameters
                    commandLineParameters)
                    {
                        var return_v = new System.Management.Automation.ReflectionParameterBinder((object)target, command, commandLineParameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 193536, 193720);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 192996, 193823);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 192996, 193823);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ReflectionParameterBinder _shouldProcessParameterBinder;

        internal ReflectionParameterBinder PagingParametersBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 194101, 194779);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 194137, 194714) || true) && (_pagingParameterBinder == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 194137, 194714);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 194302, 194376);

                        PagingParameters
                        pagingParameters = f_1243_194338_194375(_commandRuntime)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 194467, 194695);

                        _pagingParameterBinder =
                        f_1243_194517_194694(pagingParameters, f_1243_194624_194636(this), f_1243_194667_194693(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 194137, 194714);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 194734, 194764);

                    return _pagingParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 194101, 194779);

                    System.Management.Automation.PagingParameters
                    f_1243_194338_194375(System.Management.Automation.MshCommandRuntime
                    commandRuntime)
                    {
                        var return_v = new System.Management.Automation.PagingParameters(commandRuntime);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 194338, 194375);
                        return return_v;
                    }


                    System.Management.Automation.Cmdlet
                    f_1243_194624_194636(System.Management.Automation.CmdletParameterBinderController
                    this_param)
                    {
                        var return_v = this_param.Command;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 194624, 194636);
                        return return_v;
                    }


                    System.Management.Automation.CommandLineParameters
                    f_1243_194667_194693(System.Management.Automation.CmdletParameterBinderController
                    this_param)
                    {
                        var return_v = this_param.CommandLineParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 194667, 194693);
                        return return_v;
                    }


                    System.Management.Automation.ReflectionParameterBinder
                    f_1243_194517_194694(System.Management.Automation.PagingParameters
                    target, System.Management.Automation.Cmdlet
                    command, System.Management.Automation.CommandLineParameters
                    commandLineParameters)
                    {
                        var return_v = new System.Management.Automation.ReflectionParameterBinder((object)target, command, commandLineParameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 194517, 194694);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 194019, 194790);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 194019, 194790);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ReflectionParameterBinder _pagingParameterBinder;

        internal ReflectionParameterBinder TransactionParametersBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 195072, 195783);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 195108, 195713) || true) && (_transactionParameterBinder == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 195108, 195713);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 195276, 195365);

                        TransactionParameters
                        transactionParameters = f_1243_195322_195364(_commandRuntime)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 195456, 195694);

                        _transactionParameterBinder =
                        f_1243_195511_195693(transactionParameters, f_1243_195623_195635(this), f_1243_195666_195692(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 195108, 195713);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 195733, 195768);

                    return _transactionParameterBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 195072, 195783);

                    System.Management.Automation.Internal.TransactionParameters
                    f_1243_195322_195364(System.Management.Automation.MshCommandRuntime
                    commandRuntime)
                    {
                        var return_v = new System.Management.Automation.Internal.TransactionParameters(commandRuntime);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 195322, 195364);
                        return return_v;
                    }


                    System.Management.Automation.Cmdlet
                    f_1243_195623_195635(System.Management.Automation.CmdletParameterBinderController
                    this_param)
                    {
                        var return_v = this_param.Command;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 195623, 195635);
                        return return_v;
                    }


                    System.Management.Automation.CommandLineParameters
                    f_1243_195666_195692(System.Management.Automation.CmdletParameterBinderController
                    this_param)
                    {
                        var return_v = this_param.CommandLineParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 195666, 195692);
                        return return_v;
                    }


                    System.Management.Automation.ReflectionParameterBinder
                    f_1243_195511_195693(System.Management.Automation.Internal.TransactionParameters
                    target, System.Management.Automation.Cmdlet
                    command, System.Management.Automation.CommandLineParameters
                    commandLineParameters)
                    {
                        var return_v = new System.Management.Automation.ReflectionParameterBinder((object)target, command, commandLineParameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 195511, 195693);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 194985, 195794);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 194985, 195794);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ReflectionParameterBinder _transactionParameterBinder;

        internal ReflectionParameterBinder CommonParametersBinder
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 196069, 196749);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 196105, 196683) || true) && (_commonParametersBinder == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 196105, 196683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 196270, 196344);

                        CommonParameters
                        commonParameters = f_1243_196306_196343(_commandRuntime)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 196435, 196664);

                        _commonParametersBinder =
                        f_1243_196486_196663(commonParameters, f_1243_196593_196605(this), f_1243_196636_196662(this));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 196105, 196683);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 196703, 196734);

                    return _commonParametersBinder;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 196069, 196749);

                    System.Management.Automation.Internal.CommonParameters
                    f_1243_196306_196343(System.Management.Automation.MshCommandRuntime
                    commandRuntime)
                    {
                        var return_v = new System.Management.Automation.Internal.CommonParameters(commandRuntime);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 196306, 196343);
                        return return_v;
                    }


                    System.Management.Automation.Cmdlet
                    f_1243_196593_196605(System.Management.Automation.CmdletParameterBinderController
                    this_param)
                    {
                        var return_v = this_param.Command;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 196593, 196605);
                        return return_v;
                    }


                    System.Management.Automation.CommandLineParameters
                    f_1243_196636_196662(System.Management.Automation.CmdletParameterBinderController
                    this_param)
                    {
                        var return_v = this_param.CommandLineParameters;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 196636, 196662);
                        return return_v;
                    }


                    System.Management.Automation.ReflectionParameterBinder
                    f_1243_196486_196663(System.Management.Automation.Internal.CommonParameters
                    target, System.Management.Automation.Cmdlet
                    command, System.Management.Automation.CommandLineParameters
                    commandLineParameters)
                    {
                        var return_v = new System.Management.Automation.ReflectionParameterBinder((object)target, command, commandLineParameters);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 196486, 196663);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 195987, 196760);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 195987, 196760);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private ReflectionParameterBinder _commonParametersBinder;
        private class DelayedScriptBlockArgument
        {
            internal CmdletParameterBinderController _parameterBinder;

            internal CommandParameterInternal _argument;

            internal Collection<PSObject> _evaluatedArgument;

            public override string ToString()
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 197247, 197370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 197313, 197355);

                    return f_1243_197320_197354(f_1243_197320_197343(_argument));
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 197247, 197370);

                    object
                    f_1243_197320_197343(System.Management.Automation.CommandParameterInternal
                    this_param)
                    {
                        var return_v = this_param.ArgumentValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 197320, 197343);
                        return return_v;
                    }


                    string?
                    f_1243_197320_197354(object
                    this_param)
                    {
                        var return_v = this_param.ToString();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 197320, 197354);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 197247, 197370);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 197247, 197370);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            public DelayedScriptBlockArgument()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1243, 196842, 197381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 197093, 197109);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 197158, 197167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 197212, 197230);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1243, 196842, 197381);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 196842, 197381);
            }


            static DelayedScriptBlockArgument()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1243, 196842, 197381);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1243, 196842, 197381);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 196842, 197381);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1243, 196842, 197381);
        }

        private readonly Dictionary<MergedCompiledCommandParameter, DelayedScriptBlockArgument> _delayBindScriptBlocks;

        private readonly Dictionary<string, CommandParameterInternal> _defaultParameterValues;

        private bool BindPipelineParameter(
                    object parameterValue,
                    MergedCompiledCommandParameter parameter,
                    ParameterBindingFlags flags)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 199157, 200579);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 199350, 199370);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 199386, 200538) || true) && (parameterValue != f_1243_199408_199428())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 199386, 200538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 199462, 199615);

                    f_1243_199462_199614(s_tracer, "Adding PipelineParameter name={0}; value={1}", f_1243_199563_199587(f_1243_199563_199582(parameter)), parameterValue ?? (DynAbs.Tracing.TraceSender.Expression_Null<object>(1243, 199589, 199613) ?? "null"));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 199680, 199714);

                    f_1243_199680_199713(this, parameter);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 199777, 200057);

                    CommandParameterInternal
                    param = f_1243_199810_200056(null, f_1243_199907_199931(f_1243_199907_199926(parameter)), "-" + f_1243_199939_199963(f_1243_199939_199958(parameter)) + ":", null, parameterValue, false)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 200077, 200137);

                    flags = flags & ~ParameterBindingFlags.DelayBindScriptBlock;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 200155, 200229);

                    result = f_1243_200164_200228(this, _currentParameterSetFlag, param, parameter, flags);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 200249, 200523) || true) && (result)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 200249, 200523);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 200453, 200504);

                        f_1243_200453_200503(f_1243_200453_200488(), parameter);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 200249, 200523);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 199386, 200538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 200554, 200568);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 199157, 200579);

                System.Management.Automation.PSObject
                f_1243_199408_199428()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 199408, 199428);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_199563_199582(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 199563, 199582);
                    return return_v;
                }


                string
                f_1243_199563_199587(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 199563, 199587);
                    return return_v;
                }


                int
                f_1243_199462_199614(System.Management.Automation.PSTraceSource
                this_param, string
                format, string
                arg1, object
                arg2)
                {
                    this_param.WriteLine(format, (object)arg1, arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 199462, 199614);
                    return 0;
                }


                int
                f_1243_199680_199713(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                parameter)
                {
                    this_param.BackupDefaultParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 199680, 199713);
                    return 0;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_199907_199926(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 199907, 199926);
                    return return_v;
                }


                string
                f_1243_199907_199931(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 199907, 199931);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_199939_199958(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 199939, 199958);
                    return return_v;
                }


                string
                f_1243_199939_199963(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 199939, 199963);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1243_199810_200056(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, object
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 199810, 200056);
                    return return_v;
                }


                bool
                f_1243_200164_200228(System.Management.Automation.CmdletParameterBinderController
                this_param, uint
                parameterSets, System.Management.Automation.CommandParameterInternal
                argument, System.Management.Automation.MergedCompiledCommandParameter
                parameter, System.Management.Automation.ParameterBindingFlags
                flags)
                {
                    var return_v = this_param.BindParameter(parameterSets, argument, parameter, flags);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 200164, 200228);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_200453_200488()
                {
                    var return_v = ParametersBoundThroughPipelineInput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 200453, 200488);
                    return return_v;
                }


                int
                f_1243_200453_200503(System.Collections.ObjectModel.Collection<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 200453, 200503);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 199157, 200579);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 199157, 200579);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void SaveDefaultScriptParameterValue(string name, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 200591, 200959);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 200698, 200948);

                f_1243_200698_200947(_defaultParameterValues, name, f_1243_200749_200946(null, name, "-" + name + ":", null, value, false));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 200591, 200959);

                System.Management.Automation.CommandParameterInternal
                f_1243_200749_200946(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, object
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 200749, 200946);
                    return return_v;
                }


                int
                f_1243_200698_200947(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
                this_param, string
                key, System.Management.Automation.CommandParameterInternal
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 200698, 200947);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 200591, 200959);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 200591, 200959);
            }
        }

        private void BackupDefaultParameter(MergedCompiledCommandParameter parameter)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 201455, 202147);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 201557, 202136) || true) && (!f_1243_201562_201623(_defaultParameterValues, f_1243_201598_201622(f_1243_201598_201617(parameter))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 201557, 202136);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 201657, 201739);

                    object
                    defaultParameterValue = f_1243_201688_201738(this, f_1243_201713_201737(f_1243_201713_201732(parameter)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 201757, 202121);

                    f_1243_201757_202120(_defaultParameterValues, f_1243_201807_201831(f_1243_201807_201826(parameter)), f_1243_201854_202119(null, f_1243_201955_201979(f_1243_201955_201974(parameter)), "-" + f_1243_201987_202011(f_1243_201987_202006(parameter)) + ":", null, defaultParameterValue, false));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 201557, 202136);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 201455, 202147);

                System.Management.Automation.CompiledCommandParameter
                f_1243_201598_201617(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 201598, 201617);
                    return return_v;
                }


                string
                f_1243_201598_201622(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 201598, 201622);
                    return return_v;
                }


                bool
                f_1243_201562_201623(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 201562, 201623);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_201713_201732(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 201713, 201732);
                    return return_v;
                }


                string
                f_1243_201713_201737(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 201713, 201737);
                    return return_v;
                }


                object
                f_1243_201688_201738(System.Management.Automation.CmdletParameterBinderController
                this_param, string
                name)
                {
                    var return_v = this_param.GetDefaultParameterValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 201688, 201738);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_201807_201826(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 201807, 201826);
                    return return_v;
                }


                string
                f_1243_201807_201831(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 201807, 201831);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_201955_201974(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 201955, 201974);
                    return return_v;
                }


                string
                f_1243_201955_201979(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 201955, 201979);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_201987_202006(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 201987, 202006);
                    return return_v;
                }


                string
                f_1243_201987_202011(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 201987, 202011);
                    return return_v;
                }


                System.Management.Automation.CommandParameterInternal
                f_1243_201854_202119(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, object
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 201854, 202119);
                    return return_v;
                }


                int
                f_1243_201757_202120(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
                this_param, string
                key, System.Management.Automation.CommandParameterInternal
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 201757, 202120);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 201455, 202147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 201455, 202147);
            }
        }

        private void RestoreDefaultParameterValues(IEnumerable<MergedCompiledCommandParameter> parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 202597, 206747);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 202720, 202850) || true) && (parameters == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 202720, 202850);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 202776, 202835);

                    throw f_1243_202782_202834("parameters");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 202720, 202850);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 203044, 206736);
                    foreach (MergedCompiledCommandParameter parameter in f_1243_203097_203107_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 203044, 206736);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 203141, 203232) || true) && (parameter == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 203141, 203232);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 203204, 203213);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 203141, 203232);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 203252, 203299);

                        CommandParameterInternal
                        argumentToBind = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 203465, 206721) || true) && (f_1243_203469_203550(_defaultParameterValues, f_1243_203505_203529(f_1243_203505_203524(parameter)), out argumentToBind))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 203465, 206721);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 203920, 203943);

                            Exception
                            error = null
                            ;
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 204145, 204207);

                                bool
                                bindResult = f_1243_204163_204206(this, argumentToBind, parameter)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 204235, 204389);

                                f_1243_204235_204388(bindResult, "Restoring the default value should not require type coercion");
                            }
                            catch (SetValueException setValueException)
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCatch(1243, 204434, 204575);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 204526, 204552);

                                error = setValueException;
                                DynAbs.Tracing.TraceSender.TraceExitCatch(1243, 204434, 204575);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 204599, 205548) || true) && (error != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 204599, 205548);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 204666, 204774);

                                Type
                                specifiedType = (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 204687, 204725) || (((f_1243_204688_204716(argumentToBind) == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 204728, 204732)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 204735, 204773))) ? null : f_1243_204735_204773(f_1243_204735_204763(argumentToBind))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 204800, 205476);

                                ParameterBindingException
                                bindingException =
                                f_1243_204874_205475(error, ErrorCategory.WriteError, f_1243_205037_205056(this), f_1243_205091_205121(this, argumentToBind), f_1243_205156_205180(f_1243_205156_205175(parameter)), f_1243_205215_205239(f_1243_205215_205234(parameter)), specifiedType, f_1243_205322_205367(), "ParameterBindingFailed", f_1243_205461_205474(error))
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 205502, 205525);

                                throw bindingException;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 204599, 205548);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 205789, 205838);

                            f_1243_205789_205837(f_1243_205789_205804(), f_1243_205812_205836(f_1243_205812_205831(parameter)));

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 205862, 206010) || true) && (!f_1243_205867_205904(f_1243_205867_205884(), parameter))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 205862, 206010);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 205954, 205987);

                                f_1243_205954_205986(f_1243_205954_205971(), parameter);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 205862, 206010);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 206034, 206082);

                            f_1243_206034_206081(f_1243_206034_206048(), f_1243_206056_206080(f_1243_206056_206075(parameter)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 203465, 206721);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 203465, 206721);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 206370, 206558) || true) && (!f_1243_206375_206428(f_1243_206375_206390(), f_1243_206403_206427(f_1243_206403_206422(parameter))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 206370, 206558);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 206478, 206535);

                                f_1243_206478_206534(f_1243_206478_206493(), f_1243_206498_206522(f_1243_206498_206517(parameter)), parameter);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 206370, 206558);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 206666, 206702);

                            f_1243_206666_206701(f_1243_206666_206683(), parameter);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 203465, 206721);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 203044, 206736);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 3693);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 3693);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 202597, 206747);

                System.Management.Automation.PSArgumentNullException
                f_1243_202782_202834(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 202782, 202834);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_203505_203524(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 203505, 203524);
                    return return_v;
                }


                string
                f_1243_203505_203529(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 203505, 203529);
                    return return_v;
                }


                bool
                f_1243_203469_203550(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
                this_param, string
                key, out System.Management.Automation.CommandParameterInternal
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 203469, 203550);
                    return return_v;
                }


                bool
                f_1243_204163_204206(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.CommandParameterInternal
                argumentToBind, System.Management.Automation.MergedCompiledCommandParameter
                parameter)
                {
                    var return_v = this_param.RestoreParameter(argumentToBind, parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 204163, 204206);
                    return return_v;
                }


                int
                f_1243_204235_204388(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 204235, 204388);
                    return 0;
                }


                object
                f_1243_204688_204716(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 204688, 204716);
                    return return_v;
                }


                object
                f_1243_204735_204763(System.Management.Automation.CommandParameterInternal
                this_param)
                {
                    var return_v = this_param.ArgumentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 204735, 204763);
                    return return_v;
                }


                System.Type
                f_1243_204735_204773(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 204735, 204773);
                    return return_v;
                }


                System.Management.Automation.InvocationInfo
                f_1243_205037_205056(System.Management.Automation.CmdletParameterBinderController
                this_param)
                {
                    var return_v = this_param.InvocationInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 205037, 205056);
                    return return_v;
                }


                System.Management.Automation.Language.IScriptExtent
                f_1243_205091_205121(System.Management.Automation.CmdletParameterBinderController
                this_param, System.Management.Automation.CommandParameterInternal
                cpi)
                {
                    var return_v = this_param.GetErrorExtent(cpi);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 205091, 205121);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_205156_205175(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 205156, 205175);
                    return return_v;
                }


                string
                f_1243_205156_205180(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 205156, 205180);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_205215_205234(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 205215, 205234);
                    return return_v;
                }


                System.Type
                f_1243_205215_205239(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 205215, 205239);
                    return return_v;
                }


                string
                f_1243_205322_205367()
                {
                    var return_v = ParameterBinderStrings.ParameterBindingFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 205322, 205367);
                    return return_v;
                }


                string
                f_1243_205461_205474(System.Exception
                this_param)
                {
                    var return_v = this_param.Message;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 205461, 205474);
                    return return_v;
                }


                System.Management.Automation.ParameterBindingException
                f_1243_204874_205475(System.Exception
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
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 204874, 205475);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_205789_205804()
                {
                    var return_v = BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 205789, 205804);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_205812_205831(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 205812, 205831);
                    return return_v;
                }


                string
                f_1243_205812_205836(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 205812, 205836);
                    return return_v;
                }


                bool
                f_1243_205789_205837(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 205789, 205837);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_205867_205884()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 205867, 205884);
                    return return_v;
                }


                bool
                f_1243_205867_205904(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 205867, 205904);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_205954_205971()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 205954, 205971);
                    return return_v;
                }


                int
                f_1243_205954_205986(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 205954, 205986);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
                f_1243_206034_206048()
                {
                    var return_v = BoundArguments;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 206034, 206048);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_206056_206075(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 206056, 206075);
                    return return_v;
                }


                string
                f_1243_206056_206080(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 206056, 206080);
                    return return_v;
                }


                bool
                f_1243_206034_206081(System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
                this_param, string
                key)
                {
                    var return_v = this_param.Remove(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 206034, 206081);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_206375_206390()
                {
                    var return_v = BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 206375, 206390);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_206403_206422(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 206403, 206422);
                    return return_v;
                }


                string
                f_1243_206403_206427(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 206403, 206427);
                    return return_v;
                }


                bool
                f_1243_206375_206428(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 206375, 206428);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_206478_206493()
                {
                    var return_v = BoundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 206478, 206493);
                    return return_v;
                }


                System.Management.Automation.CompiledCommandParameter
                f_1243_206498_206517(System.Management.Automation.MergedCompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Parameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 206498, 206517);
                    return return_v;
                }


                string
                f_1243_206498_206522(System.Management.Automation.CompiledCommandParameter
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 206498, 206522);
                    return return_v;
                }


                int
                f_1243_206478_206534(System.Collections.Generic.Dictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
                this_param, string
                key, System.Management.Automation.MergedCompiledCommandParameter
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 206478, 206534);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_206666_206683()
                {
                    var return_v = UnboundParameters;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 206666, 206683);
                    return return_v;
                }


                bool
                f_1243_206666_206701(System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
                this_param, System.Management.Automation.MergedCompiledCommandParameter
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 206666, 206701);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>
                f_1243_203097_203107_I(System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 203097, 203107);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 202597, 206747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 202597, 206747);
            }
        }

        static CmdletParameterBinderController()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1243, 723, 206754);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 1017, 1167);
            s_tracer = f_1243_1028_1167("ParameterBinderController", "Controls the interaction between the command processor and the parameter binder(s).");
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 190397, 190414);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1243, 723, 206754);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 723, 206754);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1243, 723, 206754);

        static System.Management.Automation.PSTraceSource
        f_1243_1028_1167(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 1028, 1167);
            return return_v;
        }


        static System.Management.Automation.InvocationInfo
        f_1243_1951_1970(System.Management.Automation.Cmdlet
        this_param)
        {
            var return_v = this_param.MyInvocation;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 1951, 1970);
            return return_v;
        }


        static System.Management.Automation.ExecutionContext
        f_1243_1989_2003(System.Management.Automation.Cmdlet
        this_param)
        {
            var return_v = this_param.Context;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 1989, 2003);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1243_2121_2169(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 2121, 2169);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1243_2268_2325(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 2268, 2325);
            return return_v;
        }


        System.Management.Automation.ICommandRuntime
        f_1243_2430_2451(System.Management.Automation.Cmdlet
        this_param)
        {
            var return_v = this_param.CommandRuntime;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 2430, 2451);
            return return_v;
        }


        bool
        f_1243_2660_2703(System.Management.Automation.CommandMetadata
        this_param)
        {
            var return_v = this_param.ImplementsDynamicParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 2660, 2703);
            return return_v;
        }


        System.Management.Automation.MergedCommandParameterMetadata
        f_1243_2856_2879(System.Management.Automation.CmdletParameterBinderController
        this_param)
        {
            var return_v = this_param.BindableParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 2856, 2879);
            return return_v;
        }


        System.Management.Automation.MergedCommandParameterMetadata
        f_1243_2896_2942(System.Management.Automation.CommandMetadata
        this_param)
        {
            var return_v = this_param.StaticCommandParameterMetadata;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 2896, 2942);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
        f_1243_2856_2943(System.Management.Automation.MergedCommandParameterMetadata
        this_param, System.Management.Automation.MergedCommandParameterMetadata
        metadata)
        {
            var return_v = this_param.ReplaceMetadata(metadata);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 2856, 2943);
            return return_v;
        }


        System.Management.Automation.MergedCommandParameterMetadata
        f_1243_3032_3078(System.Management.Automation.CommandMetadata
        this_param)
        {
            var return_v = this_param.StaticCommandParameterMetadata;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 3032, 3078);
            return return_v;
        }


        System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
        f_1243_3239_3277(System.Management.Automation.MergedCommandParameterMetadata
        this_param)
        {
            var return_v = this_param.BindableParameters;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 3239, 3277);
            return return_v;
        }


        System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
        f_1243_3239_3284(System.Collections.Generic.IDictionary<string, System.Management.Automation.MergedCompiledCommandParameter>
        this_param)
        {
            var return_v = this_param.Values;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 3239, 3284);
            return return_v;
        }


        System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>
        f_1243_3198_3285(System.Collections.Generic.ICollection<System.Management.Automation.MergedCompiledCommandParameter>
        collection)
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.MergedCompiledCommandParameter>((System.Collections.Generic.IEnumerable<System.Management.Automation.MergedCompiledCommandParameter>)collection);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 3198, 3285);
            return return_v;
        }


        static System.Management.Automation.InvocationInfo
        f_1243_1951_1970_C(System.Management.Automation.InvocationInfo
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1243, 1747, 3312);
            return return_v;
        }


        System.Collections.Generic.HashSet<string>
        f_1243_191177_191198()
        {
            var return_v = new System.Collections.Generic.HashSet<string>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 191177, 191198);
            return return_v;
        }


        System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.CmdletParameterBinderController.DelayedScriptBlockArgument>
        f_1243_197845_197921()
        {
            var return_v = new System.Collections.Generic.Dictionary<System.Management.Automation.MergedCompiledCommandParameter, System.Management.Automation.CmdletParameterBinderController.DelayedScriptBlockArgument>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 197845, 197921);
            return return_v;
        }


        System.StringComparer
        f_1243_198198_198230()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 198198, 198230);
            return return_v;
        }


        System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>
        f_1243_198149_198231(System.StringComparer
        comparer)
        {
            var return_v = new System.Collections.Generic.Dictionary<string, System.Management.Automation.CommandParameterInternal>((System.Collections.Generic.IEqualityComparer<string>)comparer);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 198149, 198231);
            return return_v;
        }

    }
    [SuppressMessage("Microsoft.Usage", "CA2237:MarkISerializableTypesWithSerializable", Justification = "DefaultParameterDictionary will only be used for $PSDefaultParameterValues.")]
    public sealed class DefaultParameterDictionary : Hashtable
    {
        private bool _isChanged;

        public bool ChangeSinceLastCheck()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 207395, 207545);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 207454, 207476);

                bool
                ret = _isChanged
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 207490, 207509);

                _isChanged = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 207523, 207534);

                return ret;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 207395, 207545);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 207395, 207545);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 207395, 207545);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DefaultParameterDictionary()
        : base(f_1243_207725_207757_C(f_1243_207725_207757()))
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1243, 207669, 207812);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 207174, 207184);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 207783, 207801);

                _isChanged = true;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1243, 207669, 207812);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 207669, 207812);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 207669, 207812);
            }
        }

        public DefaultParameterDictionary(IDictionary dictionary)
                    : this()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1243, 208096, 210705);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 208200, 208330) || true) && (dictionary == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 208200, 208330);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 208256, 208315);

                    throw f_1243_208262_208314("dictionary");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 208200, 208330);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 208559, 208600);

                var
                keysInBadFormat = f_1243_208581_208599()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 208616, 209993);
                    foreach (DictionaryEntry entry in f_1243_208650_208660_I(dictionary))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 208616, 209993);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 208694, 208729);

                        var
                        entryKey = entry.Key as string
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 208747, 209978) || true) && (entryKey != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 208747, 209978);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 208809, 208838);

                            string
                            key = f_1243_208822_208837(entryKey)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 208860, 208885);

                            string
                            cmdletName = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 208907, 208935);

                            string
                            parameterName = null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 208957, 208983);

                            bool
                            isSpecialKey = false
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 209089, 209493) || true) && (!f_1243_209094_209149(key, ref cmdletName, ref parameterName))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 209089, 209493);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 209199, 209273);

                                isSpecialKey = f_1243_209214_209272(key, "Disabled", StringComparison.OrdinalIgnoreCase);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 209299, 209470) || true) && (!isSpecialKey)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 209299, 209470);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 209374, 209404);

                                    f_1243_209374_209403(keysInBadFormat, entryKey);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 209434, 209443);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 209299, 209470);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 209089, 209493);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 209517, 209668);

                            f_1243_209517_209667(isSpecialKey || (DynAbs.Tracing.TraceSender.Expression_False(1243, 209536, 209597) || (cmdletName != null && (DynAbs.Tracing.TraceSender.Expression_True(1243, 209553, 209596) && parameterName != null))), "The cmdletName and parameterName should be set in CheckKeyIsValid");

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 209690, 209846) || true) && (f_1243_209694_209715(keysInBadFormat) == 0 && (DynAbs.Tracing.TraceSender.Expression_True(1243, 209694, 209746) && !DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ContainsKey(key), 1243, 209725, 209746)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 209690, 209846);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 209796, 209823);

                                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Add(key, entry.Value), 1243, 209796, 209822);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 209690, 209846);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 208747, 209978);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 208747, 209978);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 209928, 209959);

                            f_1243_209928_209958(keysInBadFormat, entry.Key);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 208747, 209978);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 208616, 209993);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 1378);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 1378);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 210009, 210047);

                var
                keysInError = f_1243_210027_210046()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 210061, 210208);
                    foreach (object badFormatKey in f_1243_210093_210108_I(keysInBadFormat))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 210061, 210208);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 210142, 210193);

                        f_1243_210142_210192(keysInError, f_1243_210161_210184(badFormatKey) + ", ");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 210061, 210208);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 148);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 148);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 210224, 210694) || true) && (f_1243_210228_210246(keysInError) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 210224, 210694);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 210284, 210330);

                    f_1243_210284_210329(keysInError, f_1243_210303_210321(keysInError) - 2, 2);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 210348, 210583);

                    string
                    resourceString = (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 210372, 210397) || ((f_1243_210372_210393(keysInBadFormat) > 1
                    && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 210445, 210491)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 210539, 210582))) ? f_1243_210445_210491() : f_1243_210539_210582()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 210601, 210679);

                    throw f_1243_210607_210678(resourceString, keysInError);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 210224, 210694);
                }
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1243, 208096, 210705);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 208096, 210705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 208096, 210705);
            }
        }

        public override bool Contains(object key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 210830, 210936);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 210896, 210925);

                return f_1243_210903_210924(this, key);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 210830, 210936);

                bool
                f_1243_210903_210924(System.Management.Automation.DefaultParameterDictionary
                this_param, object
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 210903, 210924);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 210830, 210936);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 210830, 210936);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override bool ContainsKey(object key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 211030, 211424);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 211099, 211215) || true) && (key == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 211099, 211215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 211148, 211200);

                    throw f_1243_211154_211199("key");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 211099, 211215);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 211231, 211258);

                var
                strKey = key as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 211272, 211309) || true) && (strKey == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 211272, 211309);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 211294, 211307);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 211272, 211309);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 211325, 211361);

                string
                keyAfterTrim = f_1243_211347_211360(strKey)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 211375, 211413);

                return DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ContainsKey(keyAfterTrim), 1243, 211382, 211412);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 211030, 211424);

                System.Management.Automation.PSArgumentNullException
                f_1243_211154_211199(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 211154, 211199);
                    return return_v;
                }


                string
                f_1243_211347_211360(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 211347, 211360);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 211030, 211424);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 211030, 211424);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public override void Add(object key, object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 211656, 211785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 211731, 211774);

                f_1243_211731_211773(this, key, value, isSelfIndexing: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 211656, 211785);

                int
                f_1243_211731_211773(System.Management.Automation.DefaultParameterDictionary
                this_param, object
                key, object
                value, bool
                isSelfIndexing)
                {
                    this_param.AddImpl(key, value, isSelfIndexing: isSelfIndexing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 211731, 211773);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 211656, 211785);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 211656, 211785);
            }
        }

        private void AddImpl(object key, object value, bool isSelfIndexing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 211888, 213370);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 211980, 212096) || true) && (key == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 211980, 212096);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 212029, 212081);

                    throw f_1243_212035_212080("key");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 211980, 212096);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 212112, 212139);

                var
                strKey = key as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 212153, 212344) || true) && (strKey == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 212153, 212344);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 212205, 212329);

                    throw f_1243_212211_212328("key", f_1243_212253_212298(), key, f_1243_212305_212327(f_1243_212305_212318(key)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 212153, 212344);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 212360, 212396);

                string
                keyAfterTrim = f_1243_212382_212395(strKey)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 212410, 212435);

                string
                cmdletName = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 212449, 212477);

                string
                parameterName = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 212493, 212864) || true) && (DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ContainsKey(keyAfterTrim), 1243, 212497, 212527))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 212493, 212864);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 212561, 212736) || true) && (isSelfIndexing)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 212561, 212736);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 212621, 212639);

                        _isChanged = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 212661, 212688);

                        base[keyAfterTrim] = value;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 212710, 212717);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 212561, 212736);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 212756, 212849);

                    throw f_1243_212762_212848("key", f_1243_212804_212842(), key);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 212493, 212864);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 212880, 213281) || true) && (!f_1243_212885_212949(keyAfterTrim, ref cmdletName, ref parameterName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 212880, 213281);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 213034, 213266) || true) && (!f_1243_213039_213106(keyAfterTrim, "Disabled", StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 213034, 213266);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 213148, 213247);

                        throw f_1243_213154_213246(f_1243_213197_213240(), key);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 213034, 213266);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 212880, 213281);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 213297, 213315);

                _isChanged = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 213329, 213359);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Add(keyAfterTrim, value), 1243, 213329, 213358);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 211888, 213370);

                System.Management.Automation.PSArgumentNullException
                f_1243_212035_212080(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 212035, 212080);
                    return return_v;
                }


                string
                f_1243_212253_212298()
                {
                    var return_v = ParameterBinderStrings.StringValueKeyExpected;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 212253, 212298);
                    return return_v;
                }


                System.Type
                f_1243_212305_212318(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 212305, 212318);
                    return return_v;
                }


                string
                f_1243_212305_212327(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 212305, 212327);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1243_212211_212328(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 212211, 212328);
                    return return_v;
                }


                string
                f_1243_212382_212395(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 212382, 212395);
                    return return_v;
                }


                string
                f_1243_212804_212842()
                {
                    var return_v = ParameterBinderStrings.KeyAlreadyAdded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 212804, 212842);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1243_212762_212848(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 212762, 212848);
                    return return_v;
                }


                bool
                f_1243_212885_212949(string
                key, ref string
                cmdletName, ref string
                parameterName)
                {
                    var return_v = CheckKeyIsValid(key, ref cmdletName, ref parameterName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 212885, 212949);
                    return return_v;
                }


                bool
                f_1243_213039_213106(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 213039, 213106);
                    return return_v;
                }


                string
                f_1243_213197_213240()
                {
                    var return_v = ParameterBinderStrings.SingleKeyInBadFormat;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 213197, 213240);
                    return return_v;
                }


                System.Management.Automation.PSInvalidOperationException
                f_1243_213154_213246(string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 213154, 213246);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 211888, 213370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 211888, 213370);
            }
        }

        /// <summary>
        /// Override the indexing to check for key's format and make it versionable.
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public override object this[object key]
        {

            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 213652, 213977);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 213688, 213761) || true) && (key == null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 213688, 213761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 213707, 213759);

                        throw f_1243_213713_213758("key");
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 213688, 213761);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 213781, 213808);

                    var
                    strKey = key as string
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 213826, 213862) || true) && (strKey == null)
                    )
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 213826, 213862);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 213848, 213860);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 213826, 213862);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 213882, 213918);

                    string
                    keyAfterTrim = f_1243_213904_213917(strKey)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 213936, 213962);

                    // LAFHIS
                    //return f_1243_213943_213961(base, keyAfterTrim);
                    var temp = base[keyAfterTrim];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 213943, 213961);
                    return temp;

                    DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 213652, 213977);

                    System.Management.Automation.PSArgumentNullException
                    f_1243_213713_213758(string
                    paramName)
                    {
                        var return_v = PSTraceSource.NewArgumentNullException(paramName);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 213713, 213758);
                        return return_v;
                    }


                    string
                    f_1243_213904_213917(string
                    this_param)
                    {
                        var return_v = this_param.Trim();
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 213904, 213917);
                        return return_v;
                    }


                    //object
                    //f_1243_213943_213961(System.Collections.Hashtable
                    //this_param, object
                    //i0)
                    //{
                    //    var return_v = this_param[i0];
                    //    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 213943, 213961);
                    //    return return_v;
                    //}

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 213652, 213977);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 213652, 213977);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }

            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 213993, 214086);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 214029, 214071);

                    f_1243_214029_214070(this, key, value, isSelfIndexing: true);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 213993, 214086);

                    int
                    f_1243_214029_214070(System.Management.Automation.DefaultParameterDictionary
                    this_param, object
                    key, object
                    value, bool
                    isSelfIndexing)
                    {
                        this_param.AddImpl(key, value, isSelfIndexing: isSelfIndexing);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 214029, 214070);
                        return 0;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 213993, 214086);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 213993, 214086);
                }
            }
        }

        public override void Remove(object key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 214257, 214747);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 214321, 214437) || true) && (key == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 214321, 214437);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 214370, 214422);

                    throw f_1243_214376_214421("key");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 214321, 214437);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 214453, 214480);

                var
                strKey = key as string
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 214494, 214525) || true) && (strKey == null)
                )
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 214494, 214525);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 214516, 214523);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 214494, 214525);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 214541, 214577);

                string
                keyAfterTrim = f_1243_214563_214576(strKey)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 214591, 214736) || true) && (DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ContainsKey(keyAfterTrim), 1243, 214595, 214625))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 214591, 214736);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 214659, 214685);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Remove(keyAfterTrim), 1243, 214659, 214684);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 214703, 214721);

                    _isChanged = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 214591, 214736);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 214257, 214747);

                System.Management.Automation.PSArgumentNullException
                f_1243_214376_214421(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 214376, 214421);
                    return return_v;
                }


                string
                f_1243_214563_214576(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 214563, 214576);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 214257, 214747);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 214257, 214747);
            }
        }

        public override void Clear()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1243, 214862, 214971);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 214915, 214928);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Clear(), 1243, 214915, 214927);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 214942, 214960);

                _isChanged = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1243, 214862, 214971);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 214862, 214971);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 214862, 214971);
            }
        }

        internal static bool CheckKeyIsValid(string key, ref string cmdletName, ref string parameterName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1243, 215379, 216697);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 215501, 215586) || true) && (key == string.Empty)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 215501, 215586);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 215558, 215571);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 215501, 215586);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 215711, 215767);

                int
                index = f_1243_215723_215766(0, key, ref cmdletName, true)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 215781, 215858) || true) && (index == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 215781, 215858);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 215830, 215843);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 215781, 215858);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 215992, 216027);

                index = f_1243_216000_216026(index, key);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 216041, 216139) || true) && (index == -1 || (DynAbs.Tracing.TraceSender.Expression_False(1243, 216045, 216077) || f_1243_216060_216070(key, index) != ':'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 216041, 216139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 216111, 216124);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 216041, 216139);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 216261, 216300);

                index = f_1243_216269_216299(index + 1, key);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 216314, 216391) || true) && (index == -1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 216314, 216391);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 216363, 216376);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 216314, 216391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 216484, 216544);

                index = f_1243_216492_216543(index, key, ref parameterName, false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 216558, 216658) || true) && (index == -1 || (DynAbs.Tracing.TraceSender.Expression_False(1243, 216562, 216596) || index != f_1243_216586_216596(key)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 216558, 216658);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 216630, 216643);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 216558, 216658);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 216674, 216686);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1243, 215379, 216697);

                int
                f_1243_215723_215766(int
                index, string
                key, ref string
                name, bool
                getCmdletName)
                {
                    var return_v = GetValueToken(index, key, ref name, getCmdletName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 215723, 215766);
                    return return_v;
                }


                int
                f_1243_216000_216026(int
                index, string
                key)
                {
                    var return_v = SkipWhiteSpace(index, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 216000, 216026);
                    return return_v;
                }


                char
                f_1243_216060_216070(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 216060, 216070);
                    return return_v;
                }


                int
                f_1243_216269_216299(int
                index, string
                key)
                {
                    var return_v = SkipWhiteSpace(index, key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 216269, 216299);
                    return return_v;
                }


                int
                f_1243_216492_216543(int
                index, string
                key, ref string
                name, bool
                getCmdletName)
                {
                    var return_v = GetValueToken(index, key, ref name, getCmdletName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 216492, 216543);
                    return return_v;
                }


                int
                f_1243_216586_216596(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 216586, 216596);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 215379, 216697);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 215379, 216697);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int GetValueToken(int index, string key, ref string name, bool getCmdletName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1243, 217750, 219582);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 217867, 217889);

                char
                quoteChar = '\0'
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 217903, 218061) || true) && (f_1243_217907_217933(f_1243_217907_217917(key, index)) || (DynAbs.Tracing.TraceSender.Expression_False(1243, 217907, 217963) || f_1243_217937_217963(f_1243_217937_217947(key, index))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 217903, 218061);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 217997, 218020);

                    quoteChar = f_1243_218009_218019(key, index);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 218038, 218046);

                    index++;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 217903, 218061);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 218077, 218133);

                StringBuilder
                builder = f_1243_218101_218132(string.Empty)
                ;
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 218147, 219281) || true) && (index < f_1243_218162_218172(key))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 218174, 218181)
   , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 218147, 219281))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 218147, 219281);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 218215, 218787) || true) && (quoteChar != '\0')
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 218215, 218787);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 218278, 218686) || true) && ((f_1243_218283_218308(quoteChar) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 218283, 218338) && f_1243_218312_218338(f_1243_218312_218322(key, index)))) || (DynAbs.Tracing.TraceSender.Expression_False(1243, 218282, 218425) || (f_1243_218369_218394(quoteChar) && (DynAbs.Tracing.TraceSender.Expression_True(1243, 218369, 218424) && f_1243_218398_218424(f_1243_218398_218408(key, index))))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 218278, 218686);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 218475, 218508);

                                name = f_1243_218482_218507(f_1243_218482_218500(builder));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 218622, 218663);

                                return (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 218629, 218645) || ((f_1243_218629_218640(name) == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 218648, 218650)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 218653, 218662))) ? -1 : index + 1;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 218278, 218686);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 218710, 218737);

                            f_1243_218710_218736(
                                                builder, f_1243_218725_218735(key, index));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 218759, 218768);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 218215, 218787);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 218807, 219266) || true) && (getCmdletName)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 218807, 219266);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 218866, 219022) || true) && (f_1243_218870_218880(key, index) != ':')
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 218866, 219022);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 218937, 218964);

                                f_1243_218937_218963(builder, f_1243_218952_218962(key, index));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 218990, 218999);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 218866, 219022);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 219046, 219079);

                            name = f_1243_219053_219078(f_1243_219053_219071(builder));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 219101, 219138);

                            return (DynAbs.Tracing.TraceSender.Conditional_F1(1243, 219108, 219124) || ((f_1243_219108_219119(name) == 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1243, 219127, 219129)) || DynAbs.Tracing.TraceSender.Conditional_F3(1243, 219132, 219137))) ? -1 : index;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 218807, 219266);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 218807, 219266);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 219220, 219247);

                            f_1243_219220_219246(builder, f_1243_219235_219245(key, index));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 218807, 219266);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 1135);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 1135);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 219297, 219545) || true) && (!getCmdletName && (DynAbs.Tracing.TraceSender.Expression_True(1243, 219301, 219336) && quoteChar == '\0'))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 219297, 219545);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 219370, 219403);

                    name = f_1243_219377_219402(f_1243_219377_219395(builder));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 219421, 219499);

                    f_1243_219421_219498(f_1243_219440_219451(name) > 0, "name should not be empty at this point");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 219517, 219530);

                    return index;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 219297, 219545);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 219561, 219571);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1243, 217750, 219582);

                char
                f_1243_217907_217917(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 217907, 217917);
                    return return_v;
                }


                bool
                f_1243_217907_217933(char
                c)
                {
                    var return_v = c.IsSingleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 217907, 217933);
                    return return_v;
                }


                char
                f_1243_217937_217947(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 217937, 217947);
                    return return_v;
                }


                bool
                f_1243_217937_217963(char
                c)
                {
                    var return_v = c.IsDoubleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 217937, 217963);
                    return return_v;
                }


                char
                f_1243_218009_218019(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 218009, 218019);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_218101_218132(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 218101, 218132);
                    return return_v;
                }


                int
                f_1243_218162_218172(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 218162, 218172);
                    return return_v;
                }


                bool
                f_1243_218283_218308(char
                c)
                {
                    var return_v = c.IsSingleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 218283, 218308);
                    return return_v;
                }


                char
                f_1243_218312_218322(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 218312, 218322);
                    return return_v;
                }


                bool
                f_1243_218312_218338(char
                c)
                {
                    var return_v = c.IsSingleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 218312, 218338);
                    return return_v;
                }


                bool
                f_1243_218369_218394(char
                c)
                {
                    var return_v = c.IsDoubleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 218369, 218394);
                    return return_v;
                }


                char
                f_1243_218398_218408(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 218398, 218408);
                    return return_v;
                }


                bool
                f_1243_218398_218424(char
                c)
                {
                    var return_v = c.IsDoubleQuote();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 218398, 218424);
                    return return_v;
                }


                string
                f_1243_218482_218500(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 218482, 218500);
                    return return_v;
                }


                string
                f_1243_218482_218507(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 218482, 218507);
                    return return_v;
                }


                int
                f_1243_218629_218640(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 218629, 218640);
                    return return_v;
                }


                char
                f_1243_218725_218735(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 218725, 218735);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_218710_218736(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 218710, 218736);
                    return return_v;
                }


                char
                f_1243_218870_218880(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 218870, 218880);
                    return return_v;
                }


                char
                f_1243_218952_218962(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 218952, 218962);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_218937_218963(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 218937, 218963);
                    return return_v;
                }


                string
                f_1243_219053_219071(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 219053, 219071);
                    return return_v;
                }


                string
                f_1243_219053_219078(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 219053, 219078);
                    return return_v;
                }


                int
                f_1243_219108_219119(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 219108, 219119);
                    return return_v;
                }


                char
                f_1243_219235_219245(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 219235, 219245);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1243_219220_219246(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 219220, 219246);
                    return return_v;
                }


                string
                f_1243_219377_219395(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 219377, 219395);
                    return return_v;
                }


                string
                f_1243_219377_219402(string
                this_param)
                {
                    var return_v = this_param.Trim();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 219377, 219402);
                    return return_v;
                }


                int
                f_1243_219440_219451(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 219440, 219451);
                    return return_v;
                }


                int
                f_1243_219421_219498(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 219421, 219498);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 217750, 219582);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 217750, 219582);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static int SkipWhiteSpace(int index, string key)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1243, 219997, 220334);
                try
                {
                    for (; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 220078, 220297) || true) && (index < f_1243_220093_220103(key))
   ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 220105, 220112)
   , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 220078, 220297))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 220078, 220297);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 220146, 220251) || true) && (f_1243_220150_220175(f_1243_220150_220160(key, index)) || (DynAbs.Tracing.TraceSender.Expression_False(1243, 220150, 220197) || f_1243_220179_220189(key, index) == '\r') || (DynAbs.Tracing.TraceSender.Expression_False(1243, 220150, 220219) || f_1243_220201_220211(key, index) == '\n'))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1243, 220146, 220251);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 220242, 220251);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1243, 220146, 220251);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 220269, 220282);

                        return index;
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1243, 1, 220);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1243, 1, 220);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1243, 220313, 220323);

                return -1;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1243, 219997, 220334);

                int
                f_1243_220093_220103(string
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 220093, 220103);
                    return return_v;
                }


                char
                f_1243_220150_220160(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 220150, 220160);
                    return return_v;
                }


                bool
                f_1243_220150_220175(char
                c)
                {
                    var return_v = c.IsWhitespace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 220150, 220175);
                    return return_v;
                }


                char
                f_1243_220179_220189(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 220179, 220189);
                    return return_v;
                }


                char
                f_1243_220201_220211(string
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 220201, 220211);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1243, 219997, 220334);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 219997, 220334);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static DefaultParameterDictionary()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1243, 206900, 220377);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1243, 206900, 220377);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1243, 206900, 220377);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1243, 206900, 220377);

        static System.StringComparer
        f_1243_207725_207757()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 207725, 207757);
            return return_v;
        }


        static System.Collections.IEqualityComparer
        f_1243_207725_207757_C(System.Collections.IEqualityComparer
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceBaseCall(1243, 207669, 207812);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1243_208262_208314(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 208262, 208314);
            return return_v;
        }


        System.Collections.Generic.List<object>
        f_1243_208581_208599()
        {
            var return_v = new System.Collections.Generic.List<object>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 208581, 208599);
            return return_v;
        }


        string
        f_1243_208822_208837(string
        this_param)
        {
            var return_v = this_param.Trim();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 208822, 208837);
            return return_v;
        }


        bool
        f_1243_209094_209149(string
        key, ref string
        cmdletName, ref string
        parameterName)
        {
            var return_v = CheckKeyIsValid(key, ref cmdletName, ref parameterName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 209094, 209149);
            return return_v;
        }


        bool
        f_1243_209214_209272(string
        this_param, string
        value, System.StringComparison
        comparisonType)
        {
            var return_v = this_param.Equals(value, comparisonType);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 209214, 209272);
            return return_v;
        }


        int
        f_1243_209374_209403(System.Collections.Generic.List<object>
        this_param, string
        item)
        {
            this_param.Add((object)item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 209374, 209403);
            return 0;
        }


        int
        f_1243_209517_209667(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 209517, 209667);
            return 0;
        }


        int
        f_1243_209694_209715(System.Collections.Generic.List<object>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 209694, 209715);
            return return_v;
        }


        int
        f_1243_209928_209958(System.Collections.Generic.List<object>
        this_param, object
        item)
        {
            this_param.Add(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 209928, 209958);
            return 0;
        }


        System.Collections.IDictionary
        f_1243_208650_208660_I(System.Collections.IDictionary
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 208650, 208660);
            return return_v;
        }


        System.Text.StringBuilder
        f_1243_210027_210046()
        {
            var return_v = new System.Text.StringBuilder();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 210027, 210046);
            return return_v;
        }


        string?
        f_1243_210161_210184(object
        this_param)
        {
            var return_v = this_param.ToString();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 210161, 210184);
            return return_v;
        }


        System.Text.StringBuilder
        f_1243_210142_210192(System.Text.StringBuilder
        this_param, string
        value)
        {
            var return_v = this_param.Append(value);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 210142, 210192);
            return return_v;
        }


        System.Collections.Generic.List<object>
        f_1243_210093_210108_I(System.Collections.Generic.List<object>
        i)
        {
            var return_v = i;
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 210093, 210108);
            return return_v;
        }


        int
        f_1243_210228_210246(System.Text.StringBuilder
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 210228, 210246);
            return return_v;
        }


        int
        f_1243_210303_210321(System.Text.StringBuilder
        this_param)
        {
            var return_v = this_param.Length;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 210303, 210321);
            return return_v;
        }


        System.Text.StringBuilder
        f_1243_210284_210329(System.Text.StringBuilder
        this_param, int
        startIndex, int
        length)
        {
            var return_v = this_param.Remove(startIndex, length);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 210284, 210329);
            return return_v;
        }


        int
        f_1243_210372_210393(System.Collections.Generic.List<object>
        this_param)
        {
            var return_v = this_param.Count;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 210372, 210393);
            return return_v;
        }


        string
        f_1243_210445_210491()
        {
            var return_v = ParameterBinderStrings.MultipleKeysInBadFormat
            ;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 210445, 210491);
            return return_v;
        }


        string
        f_1243_210539_210582()
        {
            var return_v = ParameterBinderStrings.SingleKeyInBadFormat;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1243, 210539, 210582);
            return return_v;
        }


        System.Management.Automation.PSInvalidOperationException
        f_1243_210607_210678(string
        resourceString, params object[]
        args)
        {
            var return_v = PSTraceSource.NewInvalidOperationException(resourceString, args);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1243, 210607, 210678);
            return return_v;
        }

    }
}

