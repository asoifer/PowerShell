// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Management.Automation;
using System.Management.Automation.Host;
using System.Management.Automation.Internal;

using Microsoft.PowerShell.Commands.Internal.Format;

namespace Microsoft.PowerShell.Commands
{
    [CmdletAttribute("Out", "Null", SupportsShouldProcess = false,
            HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096792", RemotingCapability = RemotingCapability.None)]
    public class OutNullCommand : PSCmdlet
    {
        [Parameter(ValueFromPipeline = true)]
        public PSObject InputObject { set; get; }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1115, 1016, 1158);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1115, 1016, 1158);
                // explicitely overridden:
                // do not do any processing
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1115, 1016, 1158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1115, 1016, 1158);
            }
        }

        public OutNullCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1115, 466, 1165);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 820, 932);
            this.InputObject = f_1115_911_931();
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1115, 466, 1165);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1115, 466, 1165);
        }


        static OutNullCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1115, 466, 1165);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1115, 466, 1165);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1115, 466, 1165);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1115, 466, 1165);

        System.Management.Automation.PSObject
        f_1115_911_931()
        {
            var return_v = AutomationNull.Value;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 911, 931);
            return return_v;
        }

    }
    [Cmdlet(VerbsData.Out, "Default", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096486", RemotingCapability = RemotingCapability.None)]
    public class OutDefaultCommand : FrontEndCommandBase
    {
        [Parameter()]
        public SwitchParameter Transcript { get; set; }

        public OutDefaultCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1115, 2184, 2293);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 5846, 5867);
                this._outVarResults = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 5898, 5926);
                this._transcribeOnlyCookie = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 2235, 2282);

                this.implementation = f_1115_2257_2281();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1115, 2184, 2293);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1115, 2184, 2293);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1115, 2184, 2293);
            }
        }

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1115, 2404, 3421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 2470, 2513);

                PSHostUserInterface
                console = f_1115_2500_2512(f_1115_2500_2509(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 2527, 2631);

                ConsoleLineOutput
                lineOutput = f_1115_2558_2630(console, false, f_1115_2596_2629(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 2647, 2713);

                ((OutputManagerInner)this.implementation).LineOutput = lineOutput;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 2729, 2794);

                MshCommandRuntime
                mrt = f_1115_2753_2772(this) as MshCommandRuntime
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 2810, 2920) || true) && (mrt != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1115, 2810, 2920);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 2859, 2905);

                    mrt.MergeUnclaimedPreviousErrorResults = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1115, 2810, 2920);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 2936, 3051) || true) && (f_1115_2940_2950())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1115, 2936, 3051);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 2984, 3036);

                    _transcribeOnlyCookie = f_1115_3008_3035(f_1115_3008_3015(f_1115_3008_3012()));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1115, 2936, 3051);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 3215, 3238);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(), 1115, 3215, 3237);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 3254, 3410) || true) && (f_1115_3258_3315(f_1115_3258_3304(f_1115_3258_3289(f_1115_3258_3265()))) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1115, 3254, 3410);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 3357, 3395);

                    _outVarResults = f_1115_3374_3394();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1115, 3254, 3410);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1115, 2404, 3421);

                System.Management.Automation.Host.PSHost
                f_1115_2500_2509(Microsoft.PowerShell.Commands.OutDefaultCommand
                this_param)
                {
                    var return_v = this_param.Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 2500, 2509);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1115_2500_2512(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 2500, 2512);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1115_2596_2629(Microsoft.PowerShell.Commands.OutDefaultCommand
                command)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext((System.Management.Automation.PSCmdlet)command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 2596, 2629);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                f_1115_2558_2630(System.Management.Automation.Host.PSHostUserInterface
                hostConsole, bool
                paging, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput(hostConsole, paging, errorContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 2558, 2630);
                    return return_v;
                }


                System.Management.Automation.ICommandRuntime
                f_1115_2753_2772(Microsoft.PowerShell.Commands.OutDefaultCommand
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 2753, 2772);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1115_2940_2950()
                {
                    var return_v = Transcript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 2940, 2950);
                    return return_v;
                }


                System.Management.Automation.Host.PSHost
                f_1115_3008_3012()
                {
                    var return_v = Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 3008, 3012);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1115_3008_3015(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 3008, 3015);
                    return return_v;
                }


                System.IDisposable
                f_1115_3008_3035(System.Management.Automation.Host.PSHostUserInterface
                this_param)
                {
                    var return_v = this_param.SetTranscribeOnly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 3008, 3035);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1115_3258_3265()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 3258, 3265);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1115_3258_3289(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 3258, 3289);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1115_3258_3304(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 3258, 3304);
                    return return_v;
                }


                System.Collections.IList
                f_1115_3258_3315(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutVarList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 3258, 3315);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSObject>
                f_1115_3374_3394()
                {
                    var return_v = new System.Collections.Generic.List<System.Management.Automation.PSObject>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 3374, 3394);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1115, 2404, 3421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1115, 2404, 3421);
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1115, 3521, 4505);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 3585, 3673) || true) && (f_1115_3589_3599())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1115, 3585, 3673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 3633, 3658);

                    f_1115_3633_3657(this, f_1115_3645_3656());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1115, 3585, 3673);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 3837, 4457) || true) && (_outVarResults != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1115, 3837, 4457);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 3897, 3949);

                    object
                    inputObjectBase = f_1115_3922_3948(f_1115_3936_3947())
                    ;

                    if (
                    (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 4054, 4442) || true) && ((inputObjectBase != null) && (DynAbs.Tracing.TraceSender.Expression_True(1115, 4080, 4165) && (!(inputObjectBase is ErrorRecord))) && (DynAbs.Tracing.TraceSender.Expression_True(1115, 4080, 4349) && (!f_1115_4192_4348(f_1115_4192_4226(f_1115_4192_4217(inputObjectBase)), "Microsoft.PowerShell.Commands.Internal.Format", StringComparison.OrdinalIgnoreCase))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1115, 4054, 4442);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 4391, 4423);

                        f_1115_4391_4422(_outVarResults, f_1115_4410_4421());
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1115, 4054, 4442);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1115, 3837, 4457);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 4473, 4494);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.ProcessRecord(), 1115, 4473, 4493);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1115, 3521, 4505);

                System.Management.Automation.SwitchParameter
                f_1115_3589_3599()
                {
                    var return_v = Transcript;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 3589, 3599);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1115_3645_3656()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 3645, 3656);
                    return return_v;
                }


                int
                f_1115_3633_3657(Microsoft.PowerShell.Commands.OutDefaultCommand
                this_param, System.Management.Automation.PSObject
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 3633, 3657);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1115_3936_3947()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 3936, 3947);
                    return return_v;
                }


                object
                f_1115_3922_3948(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObject.Base((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 3922, 3948);
                    return return_v;
                }


                System.Type
                f_1115_4192_4217(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 4192, 4217);
                    return return_v;
                }


                string
                f_1115_4192_4226(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 4192, 4226);
                    return return_v;
                }


                bool
                f_1115_4192_4348(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 4192, 4348);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1115_4410_4421()
                {
                    var return_v = InputObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 4410, 4421);
                    return return_v;
                }


                int
                f_1115_4391_4422(System.Collections.Generic.List<System.Management.Automation.PSObject>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 4391, 4422);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1115, 3521, 4505);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1115, 3521, 4505);
            }
        }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1115, 4643, 5303);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 4855, 5255) || true) && ((_outVarResults != null) && (DynAbs.Tracing.TraceSender.Expression_True(1115, 4859, 4913) && (f_1115_4888_4908(_outVarResults) > 0)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1115, 4855, 5255);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 4947, 5013);

                    f_1115_4947_5012(f_1115_4947_5004(f_1115_4947_4993(f_1115_4947_4978(f_1115_4947_4954()))));
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 5031, 5198);
                        foreach (object item in f_1115_5055_5069_I(_outVarResults))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1115, 5031, 5198);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 5111, 5179);

                            f_1115_5111_5178(f_1115_5111_5168(f_1115_5111_5157(f_1115_5111_5142(f_1115_5111_5118()))), item);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1115, 5031, 5198);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1115, 1, 168);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1115, 1, 168);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 5218, 5240);

                    _outVarResults = null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1115, 4855, 5255);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 5271, 5292);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.EndProcessing(), 1115, 5271, 5291);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1115, 4643, 5303);

                int
                f_1115_4888_4908(System.Collections.Generic.List<System.Management.Automation.PSObject>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 4888, 4908);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1115_4947_4954()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 4947, 4954);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1115_4947_4978(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 4947, 4978);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1115_4947_4993(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 4947, 4993);
                    return return_v;
                }


                System.Collections.IList
                f_1115_4947_5004(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutVarList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 4947, 5004);
                    return return_v;
                }


                int
                f_1115_4947_5012(System.Collections.IList
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 4947, 5012);
                    return 0;
                }


                System.Management.Automation.ExecutionContext
                f_1115_5111_5118()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 5111, 5118);
                    return return_v;
                }


                System.Management.Automation.CommandProcessorBase
                f_1115_5111_5142(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentCommandProcessor;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 5111, 5142);
                    return return_v;
                }


                System.Management.Automation.MshCommandRuntime
                f_1115_5111_5157(System.Management.Automation.CommandProcessorBase
                this_param)
                {
                    var return_v = this_param.CommandRuntime;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 5111, 5157);
                    return return_v;
                }


                System.Collections.IList
                f_1115_5111_5168(System.Management.Automation.MshCommandRuntime
                this_param)
                {
                    var return_v = this_param.OutVarList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 5111, 5168);
                    return return_v;
                }


                int
                f_1115_5111_5178(System.Collections.IList
                this_param, object
                value)
                {
                    var return_v = this_param.Add(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 5111, 5178);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSObject>
                f_1115_5055_5069_I(System.Collections.Generic.List<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 5055, 5069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1115, 4643, 5303);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1115, 4643, 5303);
            }
        }

        protected override void InternalDispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1115, 5414, 5811);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 5516, 5539);

                    DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.InternalDispose(), 1115, 5516, 5538);
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinally(1115, 5568, 5800);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 5608, 5785) || true) && (_transcribeOnlyCookie != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1115, 5608, 5785);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 5683, 5715);

                        f_1115_5683_5714(_transcribeOnlyCookie);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 5737, 5766);

                        _transcribeOnlyCookie = null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1115, 5608, 5785);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitFinally(1115, 5568, 5800);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1115, 5414, 5811);

                int
                f_1115_5683_5714(System.IDisposable
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 5683, 5714);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1115, 5414, 5811);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1115, 5414, 5811);
            }
        }

        private List<PSObject> _outVarResults;

        private IDisposable _transcribeOnlyCookie;

        static OutDefaultCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1115, 1423, 5934);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1115, 1423, 5934);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1115, 1423, 5934);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1115, 1423, 5934);

        Microsoft.PowerShell.Commands.Internal.Format.OutputManagerInner
        f_1115_2257_2281()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.OutputManagerInner();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 2257, 2281);
            return return_v;
        }

    }
    [Cmdlet(VerbsData.Out, "Host", HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096863", RemotingCapability = RemotingCapability.None)]
    public class OutHostCommand : FrontEndCommandBase
    {
        private bool _paging;

        public OutHostCommand()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1115, 6534, 6640);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 6401, 6408);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 6582, 6629);

                this.implementation = f_1115_6604_6628();
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1115, 6534, 6640);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1115, 6534, 6640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1115, 6534, 6640);
            }
        }

        [Parameter]
        public SwitchParameter Paging
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1115, 6901, 6924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 6907, 6922);

                    return _paging;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1115, 6901, 6924);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1115, 6826, 6975);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1115, 6826, 6975);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1115, 6940, 6964);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 6946, 6962);

                    _paging = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1115, 6940, 6964);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1115, 6826, 6975);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1115, 6826, 6975);
                }
            }
        }

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1115, 7086, 7445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 7152, 7195);

                PSHostUserInterface
                console = f_1115_7182_7194(f_1115_7182_7191(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 7209, 7315);

                ConsoleLineOutput
                lineOutput = f_1115_7240_7314(console, _paging, f_1115_7280_7313(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 7331, 7397);

                ((OutputManagerInner)this.implementation).LineOutput = lineOutput;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1115, 7411, 7434);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(), 1115, 7411, 7433);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1115, 7086, 7445);

                System.Management.Automation.Host.PSHost
                f_1115_7182_7191(Microsoft.PowerShell.Commands.OutHostCommand
                this_param)
                {
                    var return_v = this_param.Host;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 7182, 7191);
                    return return_v;
                }


                System.Management.Automation.Host.PSHostUserInterface
                f_1115_7182_7194(System.Management.Automation.Host.PSHost
                this_param)
                {
                    var return_v = this_param.UI;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1115, 7182, 7194);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1115_7280_7313(Microsoft.PowerShell.Commands.OutHostCommand
                command)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext((System.Management.Automation.PSCmdlet)command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 7280, 7313);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput
                f_1115_7240_7314(System.Management.Automation.Host.PSHostUserInterface
                hostConsole, bool
                paging, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ConsoleLineOutput(hostConsole, paging, errorContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 7240, 7314);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1115, 7086, 7445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1115, 7086, 7445);
            }
        }

        static OutHostCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1115, 6031, 7452);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1115, 6031, 7452);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1115, 6031, 7452);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1115, 6031, 7452);

        Microsoft.PowerShell.Commands.Internal.Format.OutputManagerInner
        f_1115_6604_6628()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.OutputManagerInner();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1115, 6604, 6628);
            return return_v;
        }

    }
}
