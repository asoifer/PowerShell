// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class TerminatingErrorContext
    {
        internal TerminatingErrorContext(PSCmdlet command)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1080, 531, 744);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 925, 933);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 606, 700) || true) && (command == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1080, 606, 700);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 644, 700);

                    throw f_1080_650_699("command");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1080, 606, 700);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 714, 733);

                _command = command;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1080, 531, 744);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 531, 744);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 531, 744);
            }
        }

        internal void ThrowTerminatingError(ErrorRecord errorRecord)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 756, 896);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 841, 885);

                f_1080_841_884(_command, errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 756, 896);

                int
                f_1080_841_884(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 841, 884);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 756, 896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 756, 896);
            }
        }

        private PSCmdlet _command;

        static TerminatingErrorContext()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1080, 469, 941);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1080, 469, 941);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 469, 941);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1080, 469, 941);

        System.Management.Automation.PSArgumentNullException
        f_1080_650_699(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 650, 699);
            return return_v;
        }

    }
    internal sealed class CommandWrapper : IDisposable
    {
        internal void Initialize(ExecutionContext execContext, string nameOfCommand, Type typeOfCommand)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 1588, 1829);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 1709, 1732);

                _context = execContext;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 1746, 1775);

                _commandName = nameOfCommand;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 1789, 1818);

                _commandType = typeOfCommand;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 1588, 1829);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 1588, 1829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 1588, 1829);
            }
        }

        internal void AddNamedParameter(string parameterName, object parameterValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 2159, 2520);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 2260, 2509);

                f_1080_2260_2508(_commandParameterList, f_1080_2304_2507(null, parameterName, null, null, parameterValue, false));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 2159, 2520);

                System.Management.Automation.CommandParameterInternal
                f_1080_2304_2507(System.Management.Automation.Language.Ast
                parameterAst, string
                parameterName, string
                parameterText, System.Management.Automation.Language.Ast
                argumentAst, object
                value, bool
                spaceAfterParameter)
                {
                    var return_v = CommandParameterInternal.CreateParameterWithArgument(parameterAst, parameterName, parameterText, argumentAst, value, spaceAfterParameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 2304, 2507);
                    return return_v;
                }


                int
                f_1080_2260_2508(System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                this_param, System.Management.Automation.CommandParameterInternal
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 2260, 2508);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 2159, 2520);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 2159, 2520);
            }
        }

        internal Array Process(object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 2758, 3066);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 2815, 3020) || true) && (_pp == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1080, 2815, 3020);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 2977, 3005);

                    f_1080_2977_3004(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1080, 2815, 3020);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 3036, 3055);

                return f_1080_3043_3054(_pp, o);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 2758, 3066);

                int
                f_1080_2977_3004(Microsoft.PowerShell.Commands.Internal.Format.CommandWrapper
                this_param)
                {
                    this_param.DelayedInternalInitialize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 2977, 3004);
                    return 0;
                }


                System.Array
                f_1080_3043_3054(System.Management.Automation.Internal.PipelineProcessor
                this_param, object
                input)
                {
                    var return_v = this_param.Step(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 3043, 3054);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 2758, 3066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 2758, 3066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal Array ShutDown()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 3240, 3687);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 3290, 3524) || true) && (_pp == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1080, 3290, 3524);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 3480, 3509);

                    return f_1080_3487_3508();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1080, 3290, 3524);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 3540, 3571);

                PipelineProcessor
                ppTemp = _pp
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 3587, 3598);

                _pp = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 3612, 3676);

                return f_1080_3619_3675(ppTemp, f_1080_3654_3674());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 3240, 3687);

                object[]
                f_1080_3487_3508()
                {
                    var return_v = Array.Empty<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 3487, 3508);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1080_3654_3674()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1080, 3654, 3674);
                    return return_v;
                }


                System.Array
                f_1080_3619_3675(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.PSObject
                input)
                {
                    var return_v = this_param.SynchronousExecuteEnumerate((object)input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 3619, 3675);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 3240, 3687);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 3240, 3687);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DelayedInternalInitialize()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 3699, 4167);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 3764, 3794);

                _pp = f_1080_3770_3793();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 3810, 3899);

                CmdletInfo
                cmdletInfo = f_1080_3834_3898(_commandName, _commandType, null, null, _context)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 3915, 3980);

                CommandProcessor
                cp = f_1080_3937_3979(cmdletInfo, _context)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 3996, 4128);
                    foreach (CommandParameterInternal par in f_1080_4037_4058_I(_commandParameterList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1080, 3996, 4128);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 4092, 4113);

                        f_1080_4092_4112(cp, par);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1080, 3996, 4128);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1080, 1, 133);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1080, 1, 133);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 4144, 4156);

                f_1080_4144_4155(
                            _pp, cp);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 3699, 4167);

                System.Management.Automation.Internal.PipelineProcessor
                f_1080_3770_3793()
                {
                    var return_v = new System.Management.Automation.Internal.PipelineProcessor();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 3770, 3793);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1080_3834_3898(string
                name, System.Type
                implementingType, string
                helpFile, System.Management.Automation.PSSnapInInfo
                PSSnapin, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(name, implementingType, helpFile, PSSnapin, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 3834, 3898);
                    return return_v;
                }


                System.Management.Automation.CommandProcessor
                f_1080_3937_3979(System.Management.Automation.CmdletInfo
                cmdletInfo, System.Management.Automation.ExecutionContext
                context)
                {
                    var return_v = new System.Management.Automation.CommandProcessor(cmdletInfo, context);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 3937, 3979);
                    return return_v;
                }


                int
                f_1080_4092_4112(System.Management.Automation.CommandProcessor
                this_param, System.Management.Automation.CommandParameterInternal
                parameter)
                {
                    this_param.AddParameter(parameter);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 4092, 4112);
                    return 0;
                }


                System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                f_1080_4037_4058_I(System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 4037, 4058);
                    return return_v;
                }


                int
                f_1080_4144_4155(System.Management.Automation.Internal.PipelineProcessor
                this_param, System.Management.Automation.CommandProcessor
                commandProcessor)
                {
                    var return_v = this_param.Add((System.Management.Automation.CommandProcessorBase)commandProcessor);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 4144, 4155);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 3699, 4167);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 3699, 4167);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 4276, 4429);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 4322, 4363) || true) && (_pp == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1080, 4322, 4363);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 4356, 4363);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1080, 4322, 4363);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 4379, 4393);

                f_1080_4379_4392(
                            _pp);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 4407, 4418);

                _pp = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 4276, 4429);

                int
                f_1080_4379_4392(System.Management.Automation.Internal.PipelineProcessor
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 4379, 4392);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 4276, 4429);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 4276, 4429);
            }
        }

        private PipelineProcessor _pp;

        private string _commandName;

        private Type _commandType;

        private List<CommandParameterInternal> _commandParameterList;

        private ExecutionContext _context;

        public CommandWrapper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1080, 1173, 4731);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 4467, 4477);
            this._pp = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 4505, 4524);
            this._commandName = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 4548, 4560);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 4610, 4670);
            this._commandParameterList = f_1080_4634_4670();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 4708, 4723);
            this._context = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1080, 1173, 4731);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 1173, 4731);
        }


        static CommandWrapper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1080, 1173, 4731);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1080, 1173, 4731);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 1173, 4731);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1080, 1173, 4731);

        System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>
        f_1080_4634_4670()
        {
            var return_v = new System.Collections.Generic.List<System.Management.Automation.CommandParameterInternal>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 4634, 4670);
            return return_v;
        }

    }
    public abstract class FrontEndCommandBase : PSCmdlet, IDisposable
    {
        [Parameter(ValueFromPipeline = true)]
        public PSObject InputObject { set; get; }

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 5456, 6101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 5522, 5601);

                f_1080_5522_5600(this.implementation != null, "this.implementation is null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 5615, 5725);

                this.implementation.OuterCmdletCall = new ImplementationCommandBase.OuterCmdletCallback(this.OuterCmdletCall);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 5739, 5849);

                this.implementation.InputObjectCall = new ImplementationCommandBase.InputObjectCallback(this.InputObjectCall);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 5863, 5973);

                this.implementation.WriteObjectCall = new ImplementationCommandBase.WriteObjectCallback(this.WriteObjectCall);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 5989, 6041);

                f_1080_5989_6040(
                            this.implementation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 6057, 6090);

                f_1080_6057_6089(
                            implementation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 5456, 6101);

                int
                f_1080_5522_5600(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 5522, 5600);
                    return 0;
                }


                int
                f_1080_5989_6040(Microsoft.PowerShell.Commands.Internal.Format.ImplementationCommandBase
                this_param)
                {
                    this_param.CreateTerminatingErrorContext();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 5989, 6040);
                    return 0;
                }


                int
                f_1080_6057_6089(Microsoft.PowerShell.Commands.Internal.Format.ImplementationCommandBase
                this_param)
                {
                    this_param.BeginProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 6057, 6089);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 5456, 6101);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 5456, 6101);
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 6198, 6304);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 6262, 6293);

                f_1080_6262_6292(implementation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 6198, 6304);

                int
                f_1080_6262_6292(Microsoft.PowerShell.Commands.Internal.Format.ImplementationCommandBase
                this_param)
                {
                    this_param.ProcessRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 6262, 6292);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 6198, 6304);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 6198, 6304);
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 6401, 6507);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 6465, 6496);

                f_1080_6465_6495(implementation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 6401, 6507);

                int
                f_1080_6465_6495(Microsoft.PowerShell.Commands.Internal.Format.ImplementationCommandBase
                this_param)
                {
                    this_param.EndProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 6465, 6495);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 6401, 6507);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 6401, 6507);
            }
        }

        protected override void StopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 6604, 6712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 6669, 6701);

                f_1080_6669_6700(implementation);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 6604, 6712);

                int
                f_1080_6669_6700(Microsoft.PowerShell.Commands.Internal.Format.ImplementationCommandBase
                this_param)
                {
                    this_param.StopProcessing();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 6669, 6700);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 6604, 6712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 6604, 6712);
            }
        }

        protected virtual PSCmdlet OuterCmdletCall()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 6910, 7002);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 6979, 6991);

                return this;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 6910, 7002);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 6910, 7002);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 6910, 7002);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual PSObject InputObjectCall()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 7208, 7368);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 7333, 7357);

                return f_1080_7340_7356(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 7208, 7368);

                System.Management.Automation.PSObject
                f_1080_7340_7356(Microsoft.PowerShell.Commands.Internal.Format.FrontEndCommandBase
                this_param)
                {
                    var return_v = this_param.InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1080, 7340, 7356);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 7208, 7368);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 7208, 7368);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected virtual void WriteObjectCall(object value)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 7553, 7701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 7666, 7690);

                f_1080_7666_7689(            // just call Monad API
                            this, value);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 7553, 7701);

                int
                f_1080_7666_7689(Microsoft.PowerShell.Commands.Internal.Format.FrontEndCommandBase
                this_param, object
                sendToPipeline)
                {
                    this_param.WriteObject(sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 7666, 7689);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 7553, 7701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 7553, 7701);
            }
        }

        internal ImplementationCommandBase implementation;

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 8158, 8271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 8204, 8218);

                f_1080_8204_8217(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 8234, 8260);

                f_1080_8234_8259(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 8158, 8271);

                int
                f_1080_8204_8217(Microsoft.PowerShell.Commands.Internal.Format.FrontEndCommandBase
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 8204, 8217);
                    return 0;
                }


                int
                f_1080_8234_8259(Microsoft.PowerShell.Commands.Internal.Format.FrontEndCommandBase
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 8234, 8259);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 8158, 8271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 8158, 8271);
            }
        }

        protected virtual void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 8421, 8583);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 8492, 8572) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1080, 8492, 8572);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 8539, 8557);

                    f_1080_8539_8556(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1080, 8492, 8572);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 8421, 8583);

                int
                f_1080_8539_8556(Microsoft.PowerShell.Commands.Internal.Format.FrontEndCommandBase
                this_param)
                {
                    this_param.InternalDispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 8539, 8556);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 8421, 8583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 8421, 8583);
            }
        }

        protected virtual void InternalDispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 8724, 8944);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 8789, 8846) || true) && (this.implementation == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1080, 8789, 8846);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 8839, 8846);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1080, 8789, 8846);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 8862, 8892);

                f_1080_8862_8891(
                            this.implementation);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 8906, 8933);

                this.implementation = null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 8724, 8944);

                int
                f_1080_8862_8891(Microsoft.PowerShell.Commands.Internal.Format.ImplementationCommandBase
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 8862, 8891);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 8724, 8944);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 8724, 8944);
            }
        }

        public FrontEndCommandBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1080, 4910, 8971);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 5145, 5257);
            this.InputObject = f_1080_5236_5256();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 7890, 7911);
            this.implementation = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1080, 4910, 8971);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 4910, 8971);
        }


        static FrontEndCommandBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1080, 4910, 8971);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1080, 4910, 8971);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 4910, 8971);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1080, 4910, 8971);

        System.Management.Automation.PSObject
        f_1080_5236_5256()
        {
            var return_v = AutomationNull.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1080, 5236, 5256);
            return return_v;
        }

    }
    internal class ImplementationCommandBase : IDisposable
    {
        internal virtual void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 9356, 9417);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 9356, 9417);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 9356, 9417);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 9356, 9417);
            }
        }

        internal virtual void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 9534, 9593);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 9534, 9593);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 9534, 9593);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 9534, 9593);
            }
        }

        internal virtual void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 9710, 9769);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 9710, 9769);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 9710, 9769);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 9710, 9769);
            }
        }

        internal virtual void StopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 9887, 9947);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 9887, 9947);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 9887, 9947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 9887, 9947);
            }
        }

        internal virtual PSObject ReadObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 10063, 10324);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 10175, 10269);

                f_1080_10175_10268(this.InputObjectCall != null, "this.InputObjectCall is null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 10283, 10313);

                return f_1080_10290_10312(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 10063, 10324);

                int
                f_1080_10175_10268(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 10175, 10268);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1080_10290_10312(Microsoft.PowerShell.Commands.Internal.Format.ImplementationCommandBase
                this_param)
                {
                    var return_v = this_param.InputObjectCall();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 10290, 10312);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 10063, 10324);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 10063, 10324);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal virtual void WriteObject(object o)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 10499, 10759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 10616, 10710);

                f_1080_10616_10709(this.WriteObjectCall != null, "this.WriteObjectCall is null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 10724, 10748);

                f_1080_10724_10747(this, o);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 10499, 10759);

                int
                f_1080_10616_10709(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 10616, 10709);
                    return 0;
                }


                int
                f_1080_10724_10747(Microsoft.PowerShell.Commands.Internal.Format.ImplementationCommandBase
                this_param, object
                o)
                {
                    this_param.WriteObjectCall(o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 10724, 10747);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 10499, 10759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 10499, 10759);
            }
        }

        internal virtual PSCmdlet OuterCmdlet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 10964, 11226);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 11077, 11171);

                f_1080_11077_11170(this.OuterCmdletCall != null, "this.OuterCmdletCall is null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 11185, 11215);

                return f_1080_11192_11214(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 10964, 11226);

                int
                f_1080_11077_11170(bool
                condition, string
                message)
                {
                    System.Diagnostics.Debug.Assert(condition, message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 11077, 11170);
                    return 0;
                }


                System.Management.Automation.PSCmdlet
                f_1080_11192_11214(Microsoft.PowerShell.Commands.Internal.Format.ImplementationCommandBase
                this_param)
                {
                    var return_v = this_param.OuterCmdletCall();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 11192, 11214);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 10964, 11226);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 10964, 11226);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected TerminatingErrorContext TerminatingErrorContext { get; private set; }

        internal void CreateTerminatingErrorContext()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 11329, 11484);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 11399, 11473);

                TerminatingErrorContext = f_1080_11425_11472(f_1080_11453_11471(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 11329, 11484);

                System.Management.Automation.PSCmdlet
                f_1080_11453_11471(Microsoft.PowerShell.Commands.Internal.Format.ImplementationCommandBase
                this_param)
                {
                    var return_v = this_param.OuterCmdlet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 11453, 11471);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1080_11425_11472(System.Management.Automation.PSCmdlet
                command)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext(command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 11425, 11472);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 11329, 11484);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 11329, 11484);
            }
        }

        /// <summary>
        /// Delegate definition to get to the outer command-let.
        /// </summary>
        internal delegate PSCmdlet OuterCmdletCallback();

        internal OuterCmdletCallback OuterCmdletCall;

        // callback to the methods to get an object and write an object
        /// <summary>
        /// Delegate definition to get to the current pipeline input object.
        /// </summary>
        internal delegate PSObject InputObjectCallback();

        /// <summary>
        /// Delegate definition to write object.
        /// </summary>
        internal delegate void WriteObjectCallback(object o);

        internal InputObjectCallback InputObjectCall;

        internal WriteObjectCallback WriteObjectCall;

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 12769, 12882);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 12815, 12829);

                f_1080_12815_12828(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 12845, 12871);

                f_1080_12845_12870(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 12769, 12882);

                int
                f_1080_12815_12828(Microsoft.PowerShell.Commands.Internal.Format.ImplementationCommandBase
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 12815, 12828);
                    return 0;
                }


                int
                f_1080_12845_12870(Microsoft.PowerShell.Commands.Internal.Format.ImplementationCommandBase
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 12845, 12870);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 12769, 12882);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 12769, 12882);
            }
        }

        private void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 12894, 13046);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 12955, 13035) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1080, 12955, 13035);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 13002, 13020);

                    f_1080_13002_13019(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1080, 12955, 13035);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 12894, 13046);

                int
                f_1080_13002_13019(Microsoft.PowerShell.Commands.Internal.Format.ImplementationCommandBase
                this_param)
                {
                    this_param.InternalDispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1080, 13002, 13019);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 12894, 13046);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 12894, 13046);
            }
        }

        protected virtual void InternalDispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1080, 13187, 13249);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1080, 13187, 13249);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1080, 13187, 13249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 13187, 13249);
            }
        }

        public ImplementationCommandBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1080, 9178, 13278);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 11238, 11317);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 11801, 11816);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 12364, 12379);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1080, 12507, 12522);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1080, 9178, 13278);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 9178, 13278);
        }


        static ImplementationCommandBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1080, 9178, 13278);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1080, 9178, 13278);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1080, 9178, 13278);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1080, 9178, 13278);
    }
}

