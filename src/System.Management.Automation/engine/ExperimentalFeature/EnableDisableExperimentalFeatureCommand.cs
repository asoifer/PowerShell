// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Configuration;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;

namespace Microsoft.PowerShell.Commands
{
    public class EnableDisableExperimentalFeatureCommandBase : PSCmdlet
    {
        [Parameter(ValueFromPipelineByPropertyName = true, Position = 0, Mandatory = true)]
        [ArgumentCompleter(typeof(ExperimentalFeatureNameCompleter))]
        public string[] Name { get; set; }

        [Parameter]
        public ConfigScope Scope { get; set; }

        protected override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1449, 1273, 1416);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 1337, 1405);

                f_1449_1337_1404(this, f_1449_1350_1403());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1449, 1273, 1416);

                string
                f_1449_1350_1403()
                {
                    var return_v = ExperimentalFeatureStrings.ExperimentalFeaturePending;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1449, 1350, 1403);
                    return return_v;
                }


                int
                f_1449_1337_1404(Microsoft.PowerShell.Commands.EnableDisableExperimentalFeatureCommandBase
                this_param, string
                text)
                {
                    this_param.WriteWarning(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 1337, 1404);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1449, 1273, 1416);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 1273, 1416);
            }
        }

        public EnableDisableExperimentalFeatureCommandBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1449, 562, 1423);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 738, 936);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 1093, 1179);
            this.Scope = ConfigScope.CurrentUser;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1449, 562, 1423);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 562, 1423);
        }


        static EnableDisableExperimentalFeatureCommandBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1449, 562, 1423);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1449, 562, 1423);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 562, 1423);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1449, 562, 1423);
    }
    [Cmdlet(VerbsLifecycle.Enable, "ExperimentalFeature", SupportsShouldProcess = true, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2046964")]
    public class EnableExperimentalFeatureCommand : EnableDisableExperimentalFeatureCommandBase
    {
        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1449, 1881, 2034);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 1945, 2023);

                f_1449_1945_2022(this, f_1449_1996_2000(), f_1449_2002_2007(), enable: true);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1449, 1881, 2034);

                string[]
                f_1449_1996_2000()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1449, 1996, 2000);
                    return return_v;
                }


                System.Management.Automation.Configuration.ConfigScope
                f_1449_2002_2007()
                {
                    var return_v = Scope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1449, 2002, 2007);
                    return return_v;
                }


                int
                f_1449_1945_2022(Microsoft.PowerShell.Commands.EnableExperimentalFeatureCommand
                cmdlet, string[]
                name, System.Management.Automation.Configuration.ConfigScope
                scope, bool
                enable)
                {
                    ExperimentalFeatureConfigHelper.UpdateConfig((System.Management.Automation.PSCmdlet)cmdlet, name, scope, enable: enable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 1945, 2022);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1449, 1881, 2034);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 1881, 2034);
            }
        }

        public EnableExperimentalFeatureCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1449, 1525, 2041);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1449, 1525, 2041);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 1525, 2041);
        }


        static EnableExperimentalFeatureCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1449, 1525, 2041);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1449, 1525, 2041);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 1525, 2041);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1449, 1525, 2041);
    }
    [Cmdlet(VerbsLifecycle.Disable, "ExperimentalFeature", SupportsShouldProcess = true, HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2046963")]
    public class DisableExperimentalFeatureCommand : EnableDisableExperimentalFeatureCommandBase
    {
        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1449, 2501, 2655);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 2565, 2644);

                f_1449_2565_2643(this, f_1449_2616_2620(), f_1449_2622_2627(), enable: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1449, 2501, 2655);

                string[]
                f_1449_2616_2620()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1449, 2616, 2620);
                    return return_v;
                }


                System.Management.Automation.Configuration.ConfigScope
                f_1449_2622_2627()
                {
                    var return_v = Scope;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1449, 2622, 2627);
                    return return_v;
                }


                int
                f_1449_2565_2643(Microsoft.PowerShell.Commands.DisableExperimentalFeatureCommand
                cmdlet, string[]
                name, System.Management.Automation.Configuration.ConfigScope
                scope, bool
                enable)
                {
                    ExperimentalFeatureConfigHelper.UpdateConfig((System.Management.Automation.PSCmdlet)cmdlet, name, scope, enable: enable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 2565, 2643);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1449, 2501, 2655);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 2501, 2655);
            }
        }

        public DisableExperimentalFeatureCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1449, 2143, 2662);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1449, 2143, 2662);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 2143, 2662);
        }


        static DisableExperimentalFeatureCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1449, 2143, 2662);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1449, 2143, 2662);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 2143, 2662);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1449, 2143, 2662);
    }
    internal class ExperimentalFeatureConfigHelper
    {
        internal static void UpdateConfig(PSCmdlet cmdlet, string[] name, ConfigScope scope, bool enable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1449, 2733, 4054);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 2855, 3017);

                IEnumerable<WildcardPattern>
                namePatterns = f_1449_2899_3016(name, WildcardOptions.IgnoreCase | WildcardOptions.CultureInvariant)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 3031, 3129);

                GetExperimentalFeatureCommand
                getExperimentalFeatureCommand = f_1449_3093_3128()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 3143, 3198);

                getExperimentalFeatureCommand.Context = f_1449_3183_3197(cmdlet);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 3212, 3238);

                bool
                foundFeature = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 3252, 3661);
                    foreach (ExperimentalFeature feature in f_1449_3292_3368_I(f_1449_3292_3368(getExperimentalFeatureCommand, namePatterns)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1449, 3252, 3661);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 3402, 3422);

                        foundFeature = true;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 3440, 3547) || true) && (!f_1449_3445_3479(cmdlet, f_1449_3466_3478(feature)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1449, 3440, 3547);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 3521, 3528);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1449, 3440, 3547);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 3567, 3646);

                        f_1449_3567_3645(
                                        PowerShellConfig.Instance, scope, f_1449_3624_3636(feature), enable);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1449, 3252, 3661);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1449, 1, 410);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1449, 1, 410);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 3677, 4043) || true) && (!foundFeature)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1449, 3677, 4043);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 3728, 3854);

                    string
                    errMsg = f_1449_3744_3853(f_1449_3758_3786(), f_1449_3788_3846(), name)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 3872, 4003);

                    f_1449_3872_4002(cmdlet, f_1449_3890_4001(f_1449_3906_3939(errMsg), "ItemNotFoundException", ErrorCategory.ObjectNotFound, name));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 4021, 4028);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1449, 3677, 4043);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1449, 2733, 4054);

                System.Collections.ObjectModel.Collection<System.Management.Automation.WildcardPattern>
                f_1449_2899_3016(string[]
                globPatterns, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = SessionStateUtilities.CreateWildcardsFromStrings((System.Collections.Generic.IEnumerable<string>)globPatterns, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 2899, 3016);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.GetExperimentalFeatureCommand
                f_1449_3093_3128()
                {
                    var return_v = new Microsoft.PowerShell.Commands.GetExperimentalFeatureCommand();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 3093, 3128);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1449_3183_3197(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1449, 3183, 3197);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ExperimentalFeature>
                f_1449_3292_3368(Microsoft.PowerShell.Commands.GetExperimentalFeatureCommand
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.WildcardPattern>
                namePatterns)
                {
                    var return_v = this_param.GetAvailableExperimentalFeatures(namePatterns);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 3292, 3368);
                    return return_v;
                }


                string
                f_1449_3466_3478(System.Management.Automation.ExperimentalFeature
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1449, 3466, 3478);
                    return return_v;
                }


                bool
                f_1449_3445_3479(System.Management.Automation.PSCmdlet
                this_param, string
                target)
                {
                    var return_v = this_param.ShouldProcess(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 3445, 3479);
                    return return_v;
                }


                string
                f_1449_3624_3636(System.Management.Automation.ExperimentalFeature
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1449, 3624, 3636);
                    return return_v;
                }


                int
                f_1449_3567_3645(System.Management.Automation.Configuration.PowerShellConfig
                this_param, System.Management.Automation.Configuration.ConfigScope
                scope, string
                featureName, bool
                setEnabled)
                {
                    this_param.SetExperimentalFeatures(scope, featureName, setEnabled);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 3567, 3645);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.ExperimentalFeature>
                f_1449_3292_3368_I(System.Collections.Generic.IEnumerable<System.Management.Automation.ExperimentalFeature>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 3292, 3368);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1449_3758_3786()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1449, 3758, 3786);
                    return return_v;
                }


                string
                f_1449_3788_3846()
                {
                    var return_v = ExperimentalFeatureStrings.ExperimentalFeatureNameNotFound;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1449, 3788, 3846);
                    return return_v;
                }


                string
                f_1449_3744_3853(System.Globalization.CultureInfo
                provider, string
                format, params string[]
                args)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object?[])args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 3744, 3853);
                    return return_v;
                }


                System.Management.Automation.ItemNotFoundException
                f_1449_3906_3939(string
                message)
                {
                    var return_v = new System.Management.Automation.ItemNotFoundException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 3906, 3939);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1449_3890_4001(System.Management.Automation.ItemNotFoundException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string[]
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 3890, 4001);
                    return return_v;
                }


                int
                f_1449_3872_4002(System.Management.Automation.PSCmdlet
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 3872, 4002);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1449, 2733, 4054);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 2733, 4054);
            }
        }

        public ExperimentalFeatureConfigHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1449, 2670, 4061);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1449, 2670, 4061);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 2670, 4061);
        }


        static ExperimentalFeatureConfigHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1449, 2670, 4061);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1449, 2670, 4061);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 2670, 4061);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1449, 2670, 4061);
    }
    public class ExperimentalFeatureNameCompleter : IArgumentCompleter
    {
        public IEnumerable<CompletionResult> CompleteArgument(string commandName, string parameterName, string wordToComplete, CommandAst commandAst, IDictionary fakeBoundParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1449, 4840, 5894);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 5039, 5193) || true) && (fakeBoundParameters == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1449, 5039, 5193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 5104, 5178);

                    throw f_1449_5110_5177(nameof(fakeBoundParameters));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1449, 5039, 5193);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 5209, 5308);

                var
                commandInfo = f_1449_5227_5307("Get-ExperimentalFeature", typeof(GetExperimentalFeatureCommand))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 5322, 5511);

                var
                ps = f_1449_5331_5510(f_1449_5331_5449(f_1449_5331_5407(RunspaceMode.CurrentRunspace), commandInfo), "Name", wordToComplete + "*")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 5527, 5573);

                HashSet<string>
                names = f_1449_5551_5572()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 5587, 5634);

                var
                results = f_1449_5601_5633(ps)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 5648, 5750);
                    foreach (var result in f_1449_5671_5678_I(results))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1449, 5648, 5750);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 5712, 5735);

                        f_1449_5712_5734(names, f_1449_5722_5733(result));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1449, 5648, 5750);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1449, 1, 103);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1449, 1, 103);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1449, 5766, 5883);

                return f_1449_5773_5882(f_1449_5773_5800(names, name => name), name => new CompletionResult(name, name, CompletionResultType.Text, name));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1449, 4840, 5894);

                System.Management.Automation.PSArgumentNullException
                f_1449_5110_5177(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 5110, 5177);
                    return return_v;
                }


                System.Management.Automation.CmdletInfo
                f_1449_5227_5307(string
                name, System.Type
                implementingType)
                {
                    var return_v = new System.Management.Automation.CmdletInfo(name, implementingType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 5227, 5307);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1449_5331_5407(System.Management.Automation.RunspaceMode
                runspace)
                {
                    var return_v = System.Management.Automation.PowerShell.Create(runspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 5331, 5407);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1449_5331_5449(System.Management.Automation.PowerShell
                this_param, System.Management.Automation.CmdletInfo
                commandInfo)
                {
                    var return_v = this_param.AddCommand((System.Management.Automation.CommandInfo)commandInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 5331, 5449);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1449_5331_5510(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 5331, 5510);
                    return return_v;
                }


                System.Collections.Generic.HashSet<string>
                f_1449_5551_5572()
                {
                    var return_v = new System.Collections.Generic.HashSet<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 5551, 5572);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ExperimentalFeature>
                f_1449_5601_5633(System.Management.Automation.PowerShell
                this_param)
                {
                    var return_v = this_param.Invoke<System.Management.Automation.ExperimentalFeature>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 5601, 5633);
                    return return_v;
                }


                string
                f_1449_5722_5733(System.Management.Automation.ExperimentalFeature
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1449, 5722, 5733);
                    return return_v;
                }


                bool
                f_1449_5712_5734(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 5712, 5734);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<System.Management.Automation.ExperimentalFeature>
                f_1449_5671_5678_I(System.Collections.ObjectModel.Collection<System.Management.Automation.ExperimentalFeature>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 5671, 5678);
                    return return_v;
                }


                System.Linq.IOrderedEnumerable<string>
                f_1449_5773_5800(System.Collections.Generic.HashSet<string>
                source, System.Func<string, string>
                keySelector)
                {
                    var return_v = source.OrderBy<string, string>(keySelector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 5773, 5800);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.CompletionResult>
                f_1449_5773_5882(System.Linq.IOrderedEnumerable<string>
                source, System.Func<string, System.Management.Automation.CompletionResult>
                selector)
                {
                    var return_v = source.Select<string, System.Management.Automation.CompletionResult>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1449, 5773, 5882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1449, 4840, 5894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 4840, 5894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ExperimentalFeatureNameCompleter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1449, 4177, 5901);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1449, 4177, 5901);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 4177, 5901);
        }


        static ExperimentalFeatureNameCompleter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1449, 4177, 5901);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1449, 4177, 5901);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1449, 4177, 5901);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1449, 4177, 5901);
    }
}
