// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Language;
using System.Management.Automation.Runspaces;
using System.Threading;

using Microsoft.Management.Infrastructure;

using Dbg = System.Management.Automation.Diagnostics;

//
// Now define the set of commands for manipulating modules.
//

namespace Microsoft.PowerShell.Commands
{
    [Cmdlet(VerbsCommon.Get, "Module", DefaultParameterSetName = ParameterSet_Loaded,
            HelpUri = "https://go.microsoft.com/fwlink/?LinkID=2096696")]
    [OutputType(typeof(PSModuleInfo))]
    public sealed class GetModuleCommand : ModuleCmdletBase, IDisposable
    {
        private const string
        ParameterSet_Loaded = "Loaded"
        ;

        private const string
        ParameterSet_AvailableLocally = "Available"
        ;

        private const string
        ParameterSet_AvailableInPsrpSession = "PsSession"
        ;

        private const string
        ParameterSet_AvailableInCimSession = "CimSession"
        ;

        [Parameter(ParameterSetName = ParameterSet_Loaded, ValueFromPipeline = true, Position = 0)]
        [Parameter(ParameterSetName = ParameterSet_AvailableLocally, ValueFromPipeline = true, Position = 0)]
        [Parameter(ParameterSetName = ParameterSet_AvailableInPsrpSession, ValueFromPipeline = true, Position = 0)]
        [Parameter(ParameterSetName = ParameterSet_AvailableInCimSession, ValueFromPipeline = true, Position = 0)]
        [ValidateNotNullOrEmpty]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
                    Justification = "Cmdlets use arrays for parameters.")]
        public string[] Name { get; set; }

        [Parameter(ParameterSetName = ParameterSet_Loaded, ValueFromPipelineByPropertyName = true)]
        [Parameter(ParameterSetName = ParameterSet_AvailableLocally, ValueFromPipelineByPropertyName = true)]
        [Parameter(ParameterSetName = ParameterSet_AvailableInPsrpSession, ValueFromPipelineByPropertyName = true)]
        [Parameter(ParameterSetName = ParameterSet_AvailableInCimSession, ValueFromPipelineByPropertyName = true)]
        [SuppressMessage("Microsoft.Performance", "CA1819:PropertiesShouldNotReturnArrays",
                    Justification = "Cmdlets use arrays for parameters.")]
        public ModuleSpecification[] FullyQualifiedName { get; set; }

        [Parameter(ParameterSetName = ParameterSet_Loaded)]
        [Parameter(ParameterSetName = ParameterSet_AvailableLocally)]
        public SwitchParameter All { get; set; }

        [Parameter(ParameterSetName = ParameterSet_AvailableLocally, Mandatory = true)]
        [Parameter(ParameterSetName = ParameterSet_AvailableInPsrpSession)]
        [Parameter(ParameterSetName = ParameterSet_AvailableInCimSession)]
        public SwitchParameter ListAvailable { get; set; }

        [Parameter(ParameterSetName = ParameterSet_AvailableLocally)]
        [Parameter(ParameterSetName = ParameterSet_AvailableInPsrpSession)]
        [ArgumentCompleter(typeof(PSEditionArgumentCompleter))]
        public string PSEdition { get; set; }

        [Parameter(ParameterSetName = ParameterSet_AvailableLocally)]
        [Parameter(ParameterSetName = ParameterSet_AvailableInPsrpSession)]
        [Parameter(ParameterSetName = ParameterSet_AvailableInCimSession)]
        public SwitchParameter SkipEditionCheck
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 4745, 4798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 4751, 4796);

                    return (SwitchParameter)f_1529_4775_4795();
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 4745, 4798);

                    bool
                    f_1529_4775_4795()
                    {
                        var return_v = BaseSkipEditionCheck;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 4775, 4795);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 4457, 4862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 4457, 4862);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 4814, 4851);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 4820, 4849);

                    BaseSkipEditionCheck = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 4814, 4851);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 4457, 4862);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 4457, 4862);
                }
            }
        }

        [Parameter(ParameterSetName = ParameterSet_AvailableLocally)]
        [Parameter(ParameterSetName = ParameterSet_AvailableInPsrpSession)]
        [Parameter(ParameterSetName = ParameterSet_AvailableInCimSession)]
        public SwitchParameter Refresh { get; set; }

        [Parameter(ParameterSetName = ParameterSet_AvailableInPsrpSession, Mandatory = true)]
        [ValidateNotNull]
        public PSSession PSSession { get; set; }

        [Parameter(ParameterSetName = ParameterSet_AvailableInCimSession, Mandatory = true)]
        [ValidateNotNull]
        public CimSession CimSession { get; set; }

        [Parameter(ParameterSetName = ParameterSet_AvailableInCimSession, Mandatory = false)]
        [ValidateNotNull]
        public Uri CimResourceUri { get; set; }

        [Parameter(ParameterSetName = ParameterSet_AvailableInCimSession, Mandatory = false)]
        [ValidateNotNullOrEmpty]
        public string CimNamespace { get; set; }

        private IEnumerable<PSModuleInfo> GetAvailableViaPsrpSessionCore(string[] moduleNames, Runspace remoteRunspace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 6724, 8214);

                var listYield = new List<PSModuleInfo>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 6860, 6942);

                f_1529_6860_6941(remoteRunspace != null, "Caller should verify remoteRunspace != null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 6958, 8203);
                using (var
                powerShell = f_1529_6982_7030()
                )
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 7064, 7101);

                    powerShell.Runspace = remoteRunspace;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 7119, 7155);

                    f_1529_7119_7154(powerShell, "Get-Module");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 7173, 7220);

                    f_1529_7173_7219(powerShell, "ListAvailable", true);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 7240, 7363) || true) && (f_1529_7244_7251().IsPresent)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 7240, 7363);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 7303, 7344);

                        f_1529_7303_7343(powerShell, "Refresh", true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 7240, 7363);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 7383, 7512) || true) && (moduleNames != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 7383, 7512);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 7448, 7493);

                        f_1529_7448_7492(powerShell, "Name", moduleNames);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 7383, 7512);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 7532, 7732);

                    string
                    errorMessageTemplate = f_1529_7562_7731(f_1529_7598_7626(), f_1529_7649_7695(), "Get-Module")
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 7750, 8188);
                        foreach (PSObject outputObject in f_1529_7831_7997_I(f_1529_7831_7997(powerShell, f_1529_7882_7904(this), this, errorMessageTemplate)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 7750, 8188);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 8039, 8123);

                            PSModuleInfo
                            moduleInfo = f_1529_8065_8122(outputObject)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 8145, 8169);

                            listYield.Add(moduleInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 7750, 8188);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1529, 1, 439);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1529, 1, 439);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1529, 6958, 8203);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 6724, 8214);

                return listYield;

                int
                f_1529_6860_6941(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 6860, 6941);
                    return 0;
                }


                System.Management.Automation.PowerShell
                f_1529_6982_7030()
                {
                    var return_v = System.Management.Automation.PowerShell.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 6982, 7030);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1529_7119_7154(System.Management.Automation.PowerShell
                this_param, string
                cmdlet)
                {
                    var return_v = this_param.AddCommand(cmdlet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 7119, 7154);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1529_7173_7219(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 7173, 7219);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1529_7244_7251()
                {
                    var return_v = Refresh;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 7244, 7251);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1529_7303_7343(System.Management.Automation.PowerShell
                this_param, string
                parameterName, bool
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 7303, 7343);
                    return return_v;
                }


                System.Management.Automation.PowerShell
                f_1529_7448_7492(System.Management.Automation.PowerShell
                this_param, string
                parameterName, string[]
                value)
                {
                    var return_v = this_param.AddParameter(parameterName, (object)value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 7448, 7492);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1529_7598_7626()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 7598, 7626);
                    return return_v;
                }


                string
                f_1529_7649_7695()
                {
                    var return_v = Modules.RemoteDiscoveryRemotePsrpCommandFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 7649, 7695);
                    return return_v;
                }


                string
                f_1529_7562_7731(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 7562, 7731);
                    return return_v;
                }


                System.Threading.CancellationToken
                f_1529_7882_7904(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    var return_v = this_param.CancellationToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 7882, 7904);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1529_7831_7997(System.Management.Automation.PowerShell
                powerShell, System.Threading.CancellationToken
                cancellationToken, Microsoft.PowerShell.Commands.GetModuleCommand
                cmdlet, string
                errorMessageTemplate)
                {
                    var return_v = RemoteDiscoveryHelper.InvokePowerShell(powerShell, cancellationToken, (System.Management.Automation.PSCmdlet)cmdlet, errorMessageTemplate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 7831, 7997);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1529_8065_8122(System.Management.Automation.PSObject
                deserializedModuleInfo)
                {
                    var return_v = RemoteDiscoveryHelper.RehydratePSModuleInfo(deserializedModuleInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 8065, 8122);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                f_1529_7831_7997_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSObject>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 7831, 7997);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 6724, 8214);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 6724, 8214);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSModuleInfo GetModuleInfoForRemoteModuleWithoutManifest(RemoteDiscoveryHelper.CimModule cimModule)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 8226, 8427);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 8358, 8416);

                return f_1529_8365_8415(f_1529_8382_8402(cimModule), null, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 8226, 8427);

                string
                f_1529_8382_8402(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 8382, 8402);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1529_8365_8415(string
                path, System.Management.Automation.ExecutionContext
                context, System.Management.Automation.SessionState
                sessionState)
                {
                    var return_v = new System.Management.Automation.PSModuleInfo(path, context, sessionState);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 8365, 8415);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 8226, 8427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 8226, 8427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSModuleInfo ConvertCimModuleInfoToPSModuleInfo(RemoteDiscoveryHelper.CimModule cimModule,
                                                                        string computerName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 8439, 11427);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 8684, 8713);

                    bool
                    containedErrors = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 8733, 8890) || true) && (f_1529_8737_8759(cimModule) == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 8733, 8890);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 8809, 8871);

                        return f_1529_8816_8870(this, cimModule);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 8733, 8890);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 8910, 9209);

                    string
                    temporaryModuleManifestPath = f_1529_8947_9208(f_1529_8982_9146(f_1529_9018_9038(cimModule), null, computerName, f_1529_9117_9145(f_1529_9117_9129(this))), f_1529_9169_9207(f_1529_9186_9206(cimModule)))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 9229, 9255);

                    Hashtable
                    mainData = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 9273, 9785) || true) && (!containedErrors)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 9273, 9785);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 9335, 9589);

                        mainData = f_1529_9346_9588(f_1529_9434_9456(cimModule), temporaryModuleManifestPath, this, ref containedErrors);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 9611, 9766) || true) && (mainData == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 9611, 9766);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 9681, 9743);

                            return f_1529_9688_9742(this, cimModule);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 9611, 9766);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 9273, 9785);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 9805, 9945) || true) && (!containedErrors)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 9805, 9945);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 9867, 9926);

                        mainData = f_1529_9878_9925(mainData);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 9805, 9945);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 9965, 10000);

                    Hashtable
                    localizedData = mainData
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 10083, 10114);

                    PSModuleInfo
                    moduleInfo = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 10132, 10901) || true) && (!containedErrors)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 10132, 10901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 10194, 10259);

                        ImportModuleOptions
                        throwAwayOptions = f_1529_10233_10258()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 10281, 10882);

                        moduleInfo = f_1529_10294_10881(this, temporaryModuleManifestPath, null, mainData, localizedData, 0, f_1529_10623_10646(this), f_1529_10673_10696(this), f_1529_10723_10747(this), f_1529_10774_10787(this), ref throwAwayOptions, ref containedErrors);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 10132, 10901);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 10921, 11093) || true) && ((moduleInfo == null) || (DynAbs.Tracing.TraceSender.Expression_False(1529, 10925, 10964) || containedErrors))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 10921, 11093);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 11006, 11074);

                        moduleInfo = f_1529_11019_11073(this, cimModule);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 10921, 11093);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 11113, 11131);

                    return moduleInfo;
                }
                catch (Exception e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1529, 11160, 11416);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 11212, 11324);

                    ErrorRecord
                    errorRecord = f_1529_11238_11323(e, f_1529_11302_11322(cimModule))
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 11342, 11371);

                    f_1529_11342_11370(this, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 11389, 11401);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1529, 11160, 11416);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 8439, 11427);

                System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                f_1529_8737_8759(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.MainManifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 8737, 8759);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1529_8816_8870(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Management.Automation.RemoteDiscoveryHelper.CimModule
                cimModule)
                {
                    var return_v = this_param.GetModuleInfoForRemoteModuleWithoutManifest(cimModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 8816, 8870);
                    return return_v;
                }


                string
                f_1529_9018_9038(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 9018, 9038);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1529_9117_9129(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 9117, 9129);
                    return return_v;
                }


                System.Management.Automation.Runspaces.Runspace
                f_1529_9117_9145(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentRunspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 9117, 9145);
                    return return_v;
                }


                string
                f_1529_8982_9146(string
                remoteModuleName, System.Version
                remoteModuleVersion, string
                computerName, System.Management.Automation.Runspaces.Runspace
                localRunspace)
                {
                    var return_v = RemoteDiscoveryHelper.GetModulePath(remoteModuleName, remoteModuleVersion, computerName, localRunspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 8982, 9146);
                    return return_v;
                }


                string
                f_1529_9186_9206(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 9186, 9206);
                    return return_v;
                }


                string?
                f_1529_9169_9207(string
                path)
                {
                    var return_v = Path.GetFileName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 9169, 9207);
                    return return_v;
                }


                string
                f_1529_8947_9208(string
                path1, string
                path2)
                {
                    var return_v = Path.Combine(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 8947, 9208);
                    return return_v;
                }


                System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                f_1529_9434_9456(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.MainManifest;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 9434, 9456);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1529_9346_9588(System.Management.Automation.RemoteDiscoveryHelper.CimModuleFile
                cimModuleFile, string
                temporaryModuleManifestPath, Microsoft.PowerShell.Commands.GetModuleCommand
                cmdlet, ref bool
                containedErrors)
                {
                    var return_v = RemoteDiscoveryHelper.ConvertCimModuleFileToManifestHashtable(cimModuleFile, temporaryModuleManifestPath, (Microsoft.PowerShell.Commands.ModuleCmdletBase)cmdlet, ref containedErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 9346, 9588);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1529_9688_9742(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Management.Automation.RemoteDiscoveryHelper.CimModule
                cimModule)
                {
                    var return_v = this_param.GetModuleInfoForRemoteModuleWithoutManifest(cimModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 9688, 9742);
                    return return_v;
                }


                System.Collections.Hashtable
                f_1529_9878_9925(System.Collections.Hashtable
                originalManifest)
                {
                    var return_v = RemoteDiscoveryHelper.RewriteManifest(originalManifest);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 9878, 9925);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                f_1529_10233_10258()
                {
                    var return_v = new Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 10233, 10258);
                    return return_v;
                }


                System.Version
                f_1529_10623_10646(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    var return_v = this_param.BaseMinimumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 10623, 10646);
                    return return_v;
                }


                System.Version
                f_1529_10673_10696(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    var return_v = this_param.BaseMaximumVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 10673, 10696);
                    return return_v;
                }


                System.Version
                f_1529_10723_10747(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    var return_v = this_param.BaseRequiredVersion;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 10723, 10747);
                    return return_v;
                }


                System.Guid?
                f_1529_10774_10787(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    var return_v = this_param.BaseGuid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 10774, 10787);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1529_10294_10881(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, string
                moduleManifestPath, System.Management.Automation.ExternalScriptInfo
                manifestScriptInfo, System.Collections.Hashtable
                data, System.Collections.Hashtable
                localizedData, int
                manifestProcessingFlags, System.Version
                minimumVersion, System.Version
                maximumVersion, System.Version
                requiredVersion, System.Guid?
                requiredModuleGuid, ref Microsoft.PowerShell.Commands.ModuleCmdletBase.ImportModuleOptions
                options, ref bool
                containedErrors)
                {
                    var return_v = this_param.LoadModuleManifest(moduleManifestPath, manifestScriptInfo, data, localizedData, (Microsoft.PowerShell.Commands.ModuleCmdletBase.ManifestProcessingFlags)manifestProcessingFlags, minimumVersion, maximumVersion, requiredVersion, requiredModuleGuid, ref options, ref containedErrors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 10294, 10881);
                    return return_v;
                }


                System.Management.Automation.PSModuleInfo
                f_1529_11019_11073(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Management.Automation.RemoteDiscoveryHelper.CimModule
                cimModule)
                {
                    var return_v = this_param.GetModuleInfoForRemoteModuleWithoutManifest(cimModule);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 11019, 11073);
                    return return_v;
                }


                string
                f_1529_11302_11322(System.Management.Automation.RemoteDiscoveryHelper.CimModule
                this_param)
                {
                    var return_v = this_param.ModuleName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 11302, 11322);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1529_11238_11323(System.Exception
                innerException, string
                moduleName)
                {
                    var return_v = RemoteDiscoveryHelper.GetErrorRecordForProcessingOfCimModule(innerException, moduleName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 11238, 11323);
                    return return_v;
                }


                int
                f_1529_11342_11370(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.WriteError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 11342, 11370);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 8439, 11427);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 8439, 11427);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private IEnumerable<PSModuleInfo> GetAvailableViaCimSessionCore(IEnumerable<string> moduleNames,
                                                                                CimSession cimSession, Uri resourceUri,
                                                                                string cimNamespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 11439, 12393);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 11767, 12092);

                IEnumerable<RemoteDiscoveryHelper.CimModule>
                remoteModules = f_1529_11828_12091(cimSession, resourceUri, cimNamespace, moduleNames, true, this, f_1529_12068_12090(this))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 12108, 12341);

                IEnumerable<PSModuleInfo>
                remoteModuleInfos = f_1529_12154_12340(f_1529_12154_12282(remoteModules
                , cimModule => this.ConvertCimModuleInfoToPSModuleInfo(cimModule, cimSession.ComputerName)), moduleInfo => moduleInfo != null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 12357, 12382);

                return remoteModuleInfos;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 11439, 12393);

                System.Threading.CancellationToken
                f_1529_12068_12090(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    var return_v = this_param.CancellationToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 12068, 12090);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                f_1529_11828_12091(Microsoft.Management.Infrastructure.CimSession
                cimSession, System.Uri
                resourceUri, string
                cimNamespace, System.Collections.Generic.IEnumerable<string>
                moduleNamePatterns, bool
                onlyManifests, Microsoft.PowerShell.Commands.GetModuleCommand
                cmdlet, System.Threading.CancellationToken
                cancellationToken)
                {
                    var return_v = RemoteDiscoveryHelper.GetCimModules(cimSession, resourceUri, cimNamespace, moduleNamePatterns, onlyManifests, (System.Management.Automation.Cmdlet)cmdlet, cancellationToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 11828, 12091);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_12154_12282(System.Collections.Generic.IEnumerable<System.Management.Automation.RemoteDiscoveryHelper.CimModule>
                source, System.Func<System.Management.Automation.RemoteDiscoveryHelper.CimModule, System.Management.Automation.PSModuleInfo>
                selector)
                {
                    var return_v = source.Select<System.Management.Automation.RemoteDiscoveryHelper.CimModule, System.Management.Automation.PSModuleInfo>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 12154, 12282);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_12154_12340(System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                source, System.Func<System.Management.Automation.PSModuleInfo, bool>
                predicate)
                {
                    var return_v = source.Where<System.Management.Automation.PSModuleInfo>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 12154, 12340);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 11439, 12393);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 11439, 12393);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private readonly CancellationTokenSource _cancellationTokenSource;

        private CancellationToken CancellationToken
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 12662, 12708);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 12668, 12706);

                    return f_1529_12675_12705(_cancellationTokenSource);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 12662, 12708);

                    System.Threading.CancellationToken
                    f_1529_12675_12705(System.Threading.CancellationTokenSource
                    this_param)
                    {
                        var return_v = this_param.Token;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 12675, 12705);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 12594, 12719);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 12594, 12719);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        protected override void StopProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 13048, 13158);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 13113, 13147);

                f_1529_13113_13146(_cancellationTokenSource);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 13048, 13158);

                int
                f_1529_13113_13146(System.Threading.CancellationTokenSource
                this_param)
                {
                    this_param.Cancel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 13113, 13146);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 13048, 13158);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 13048, 13158);
            }
        }

        public void Dispose()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 13339, 13455);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 13385, 13404);

                f_1529_13385_13403(this, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 13418, 13444);

                f_1529_13418_13443(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 13339, 13455);

                int
                f_1529_13385_13403(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, bool
                disposing)
                {
                    this_param.Dispose(disposing);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 13385, 13403);
                    return 0;
                }


                int
                f_1529_13418_13443(Microsoft.PowerShell.Commands.GetModuleCommand
                obj)
                {
                    GC.SuppressFinalize((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 13418, 13443);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 13339, 13455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 13339, 13455);
            }
        }

        private void Dispose(bool disposing)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 13575, 13862);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 13636, 13705) || true) && (_disposed)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 13636, 13705);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 13683, 13690);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 13636, 13705);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 13721, 13818) || true) && (disposing)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 13721, 13818);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 13768, 13803);

                    f_1529_13768_13802(_cancellationTokenSource);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 13721, 13818);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 13834, 13851);

                _disposed = true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 13575, 13862);

                int
                f_1529_13768_13802(System.Threading.CancellationTokenSource
                this_param)
                {
                    this_param.Dispose();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 13768, 13802);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 13575, 13862);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 13575, 13862);
            }
        }

        private bool _disposed;

        private void AssertListAvailableMode()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 13931, 14559);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 13994, 14548) || true) && (f_1529_13998_14027_M(!this.ListAvailable.IsPresent))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 13994, 14548);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 14061, 14135);

                    string
                    errorMessage = f_1529_14083_14134()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 14153, 14227);

                    ArgumentException
                    argumentException = f_1529_14191_14226(errorMessage)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 14245, 14475);

                    ErrorRecord
                    errorRecord = f_1529_14271_14474(argumentException, "RemoteDiscoveryWorksOnlyInListAvailableMode", ErrorCategory.InvalidArgument, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 14493, 14533);

                    f_1529_14493_14532(this, errorRecord);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 13994, 14548);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 13931, 14559);

                bool
                f_1529_13998_14027_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 13998, 14027);
                    return return_v;
                }


                string
                f_1529_14083_14134()
                {
                    var return_v = Modules.RemoteDiscoveryWorksOnlyInListAvailableMode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 14083, 14134);
                    return return_v;
                }


                System.ArgumentException
                f_1529_14191_14226(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 14191, 14226);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1529_14271_14474(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 14271, 14474);
                    return return_v;
                }


                int
                f_1529_14493_14532(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 14493, 14532);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 13931, 14559);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 13931, 14559);
            }
        }

        protected override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 14666, 19390);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 14881, 15333) || true) && ((f_1529_14886_14890() != null) && (DynAbs.Tracing.TraceSender.Expression_True(1529, 14885, 14931) && (f_1529_14904_14922() != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 14881, 15333);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 14965, 15086);

                    string
                    errMsg = f_1529_14981_15085(f_1529_14999_15054(), "Name", "FullyQualifiedName")
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 15104, 15271);

                    ErrorRecord
                    error = f_1529_15124_15270(f_1529_15140_15177(errMsg), "NameAndFullyQualifiedNameCannotBeSpecifiedTogether", ErrorCategory.InvalidOperation, null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 15289, 15318);

                    f_1529_15289_15317(this, error);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 14881, 15333);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 15460, 15924) || true) && (f_1529_15464_15480() && (DynAbs.Tracing.TraceSender.Expression_True(1529, 15464, 15498) && f_1529_15484_15498_M(!ListAvailable)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 15460, 15924);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 15532, 15860);

                    ErrorRecord
                    error = f_1529_15552_15859(f_1529_15590_15677(f_1529_15620_15676()), nameof(Modules.SkipEditionCheckNotSupportedWithoutListAvailable), ErrorCategory.InvalidOperation, targetObject: null)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 15880, 15909);

                    f_1529_15880_15908(this, error);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 15460, 15924);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 15940, 15974);

                var
                strNames = f_1529_15955_15973()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 15988, 16077) || true) && (f_1529_15992_15996() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 15988, 16077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 16038, 16062);

                    f_1529_16038_16061(strNames, f_1529_16056_16060());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 15988, 16077);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 16093, 16193);

                var
                moduleSpecTable = f_1529_16115_16192(f_1529_16159_16191())
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 16207, 16801) || true) && (f_1529_16211_16229() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 16207, 16801);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 16280, 16296);
                        for (int
        modSpecIndex = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 16271, 16551) || true) && (modSpecIndex < f_1529_16313_16338(f_1529_16313_16331()))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 16340, 16354)
        , modSpecIndex++, DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 16271, 16551))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 16271, 16551);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 16396, 16532);

                            f_1529_16396_16414()[modSpecIndex] = f_1529_16431_16531(f_1529_16431_16449()[modSpecIndex], f_1529_16483_16490(), f_1529_16492_16530(f_1529_16492_16525(f_1529_16492_16509(f_1529_16492_16504()))));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1529, 1, 281);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1529, 1, 281);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 16571, 16704);

                    moduleSpecTable = f_1529_16589_16703(f_1529_16589_16607(), moduleSpecification => moduleSpecification.Name, f_1529_16670_16702());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 16722, 16786);

                    f_1529_16722_16785(strNames, f_1529_16740_16784(f_1529_16740_16758(), spec => spec.Name));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 16207, 16801);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 16817, 16881);

                string[]
                names = (DynAbs.Tracing.TraceSender.Conditional_F1(1529, 16834, 16852) || ((f_1529_16834_16848(strNames) > 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1529, 16855, 16873)) || DynAbs.Tracing.TraceSender.Conditional_F3(1529, 16876, 16880))) ? f_1529_16855_16873(strNames) : null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 16897, 19379) || true) && (f_1529_16901_16981(f_1529_16901_16917(), ParameterSet_Loaded, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 16897, 19379);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 17015, 17284);

                    f_1529_17015_17283(this, names, f_1529_17103_17170(), "ModuleDiscoveryForLoadedModulesWorksOnlyForUnQualifiedNames");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 17302, 17353);

                    f_1529_17302_17352(this, names, moduleSpecTable, f_1529_17343_17351(this));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 16897, 19379);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 16897, 19379);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 17387, 19379) || true) && (f_1529_17391_17481(f_1529_17391_17407(), ParameterSet_AvailableLocally, StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 17387, 19379);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 17515, 18096) || true) && (f_1529_17519_17532().IsPresent)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 17515, 18096);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 17584, 17645);

                            f_1529_17584_17644(this, names, moduleSpecTable, f_1529_17635_17643(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 17515, 18096);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 17515, 18096);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 17727, 18004);

                            f_1529_17727_18003(this, names, f_1529_17819_17886(), "ModuleDiscoveryForLoadedModulesWorksOnlyForUnQualifiedNames");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 18026, 18077);

                            f_1529_18026_18076(this, names, moduleSpecTable, f_1529_18067_18075(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 17515, 18096);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 17387, 19379);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 17387, 19379);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 18130, 19379) || true) && (f_1529_18134_18230(f_1529_18134_18150(), ParameterSet_AvailableInPsrpSession, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 18130, 19379);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 18264, 18290);

                            f_1529_18264_18289(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 18308, 18545);

                            f_1529_18308_18544(this, names, f_1529_18396_18447(), "RemoteDiscoveryWorksOnlyForUnQualifiedNames");
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 18565, 18632);

                            f_1529_18565_18631(this, names, moduleSpecTable, f_1529_18616_18630(this));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 18130, 19379);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 18130, 19379);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 18666, 19379) || true) && (f_1529_18670_18765(f_1529_18670_18686(), ParameterSet_AvailableInCimSession, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 18666, 19379);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 18799, 18825);

                                f_1529_18799_18824(this);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 18843, 19080);

                                f_1529_18843_19079(this, names, f_1529_18931_18982(), "RemoteDiscoveryWorksOnlyForUnQualifiedNames");
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 19100, 19250);

                                f_1529_19100_19249(this, names, moduleSpecTable, f_1529_19150_19165(this), f_1529_19210_19229(this), f_1529_19231_19248(this));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 18666, 19379);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 18666, 19379);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 19316, 19364);

                                f_1529_19316_19363(false, "Unrecognized parameter set");
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 18666, 19379);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 18130, 19379);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 17387, 19379);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 16897, 19379);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 14666, 19390);

                string[]
                f_1529_14886_14890()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 14886, 14890);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1529_14904_14922()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 14904, 14922);
                    return return_v;
                }


                string
                f_1529_14999_15054()
                {
                    var return_v = SessionStateStrings.GetContent_TailAndHeadCannotCoexist;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 14999, 15054);
                    return return_v;
                }


                string
                f_1529_14981_15085(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 14981, 15085);
                    return return_v;
                }


                System.InvalidOperationException
                f_1529_15140_15177(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 15140, 15177);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1529_15124_15270(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 15124, 15270);
                    return return_v;
                }


                int
                f_1529_15289_15317(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 15289, 15317);
                    return 0;
                }


                System.Management.Automation.SwitchParameter
                f_1529_15464_15480()
                {
                    var return_v = SkipEditionCheck;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 15464, 15480);
                    return return_v;
                }


                bool
                f_1529_15484_15498_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 15484, 15498);
                    return return_v;
                }


                string
                f_1529_15620_15676()
                {
                    var return_v = Modules.SkipEditionCheckNotSupportedWithoutListAvailable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 15620, 15676);
                    return return_v;
                }


                System.InvalidOperationException
                f_1529_15590_15677(string
                message)
                {
                    var return_v = new System.InvalidOperationException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 15590, 15677);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1529_15552_15859(System.InvalidOperationException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject: targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 15552, 15859);
                    return return_v;
                }


                int
                f_1529_15880_15908(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 15880, 15908);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1529_15955_15973()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 15955, 15973);
                    return return_v;
                }


                string[]
                f_1529_15992_15996()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 15992, 15996);
                    return return_v;
                }


                string[]
                f_1529_16056_16060()
                {
                    var return_v = Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16056, 16060);
                    return return_v;
                }


                int
                f_1529_16038_16061(System.Collections.Generic.List<string>
                this_param, string[]
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 16038, 16061);
                    return 0;
                }


                System.StringComparer
                f_1529_16159_16191()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16159, 16191);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1529_16115_16192(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 16115, 16192);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1529_16211_16229()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16211, 16229);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1529_16313_16331()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16313, 16331);
                    return return_v;
                }


                int
                f_1529_16313_16338(Microsoft.PowerShell.Commands.ModuleSpecification[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16313, 16338);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1529_16396_16414()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16396, 16414);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1529_16431_16449()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16431, 16449);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1529_16483_16490()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16483, 16490);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1529_16492_16504()
                {
                    var return_v = SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16492, 16504);
                    return return_v;
                }


                System.Management.Automation.PathIntrinsics
                f_1529_16492_16509(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16492, 16509);
                    return return_v;
                }


                System.Management.Automation.PathInfo
                f_1529_16492_16525(System.Management.Automation.PathIntrinsics
                this_param)
                {
                    var return_v = this_param.CurrentLocation;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16492, 16525);
                    return return_v;
                }


                string
                f_1529_16492_16530(System.Management.Automation.PathInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16492, 16530);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification
                f_1529_16431_16531(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param, System.Management.Automation.ExecutionContext
                context, string
                basePath)
                {
                    var return_v = this_param.WithNormalizedName(context, basePath);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 16431, 16531);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1529_16589_16607()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16589, 16607);
                    return return_v;
                }


                System.StringComparer
                f_1529_16670_16702()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16670, 16702);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1529_16589_16703(Microsoft.PowerShell.Commands.ModuleSpecification[]
                source, System.Func<Microsoft.PowerShell.Commands.ModuleSpecification, string>
                keySelector, System.StringComparer
                comparer)
                {
                    var return_v = source.ToDictionary<Microsoft.PowerShell.Commands.ModuleSpecification, string>(keySelector, (System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 16589, 16703);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.ModuleSpecification[]
                f_1529_16740_16758()
                {
                    var return_v = FullyQualifiedName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16740, 16758);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1529_16740_16784(Microsoft.PowerShell.Commands.ModuleSpecification[]
                source, System.Func<Microsoft.PowerShell.Commands.ModuleSpecification, string>
                selector)
                {
                    var return_v = source.Select<Microsoft.PowerShell.Commands.ModuleSpecification, string>(selector);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 16740, 16784);
                    return return_v;
                }


                int
                f_1529_16722_16785(System.Collections.Generic.List<string>
                this_param, System.Collections.Generic.IEnumerable<string>
                collection)
                {
                    this_param.AddRange(collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 16722, 16785);
                    return 0;
                }


                int
                f_1529_16834_16848(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16834, 16848);
                    return return_v;
                }


                string[]
                f_1529_16855_16873(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 16855, 16873);
                    return return_v;
                }


                string
                f_1529_16901_16917()
                {
                    var return_v = ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 16901, 16917);
                    return return_v;
                }


                bool
                f_1529_16901_16981(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 16901, 16981);
                    return return_v;
                }


                string
                f_1529_17103_17170()
                {
                    var return_v = Modules.ModuleDiscoveryForLoadedModulesWorksOnlyForUnQualifiedNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 17103, 17170);
                    return return_v;
                }


                int
                f_1529_17015_17283(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, string[]
                names, string
                stringFormat, string
                resourceId)
                {
                    this_param.AssertNameDoesNotResolveToAPath(names, stringFormat, resourceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 17015, 17283);
                    return 0;
                }


                System.Management.Automation.SwitchParameter
                f_1529_17343_17351(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    var return_v = this_param.All;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 17343, 17351);
                    return return_v;
                }


                int
                f_1529_17302_17352(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, string[]
                names, System.Collections.Generic.Dictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                moduleSpecTable, System.Management.Automation.SwitchParameter
                all)
                {
                    this_param.GetLoadedModules(names, (System.Collections.Generic.IDictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>)moduleSpecTable, (bool)all);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 17302, 17352);
                    return 0;
                }


                string
                f_1529_17391_17407()
                {
                    var return_v = ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 17391, 17407);
                    return return_v;
                }


                bool
                f_1529_17391_17481(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 17391, 17481);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1529_17519_17532()
                {
                    var return_v = ListAvailable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 17519, 17532);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1529_17635_17643(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    var return_v = this_param.All;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 17635, 17643);
                    return return_v;
                }


                int
                f_1529_17584_17644(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, string[]
                names, System.Collections.Generic.Dictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                moduleSpecTable, System.Management.Automation.SwitchParameter
                all)
                {
                    this_param.GetAvailableLocallyModules(names, (System.Collections.Generic.IDictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>)moduleSpecTable, (bool)all);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 17584, 17644);
                    return 0;
                }


                string
                f_1529_17819_17886()
                {
                    var return_v = Modules.ModuleDiscoveryForLoadedModulesWorksOnlyForUnQualifiedNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 17819, 17886);
                    return return_v;
                }


                int
                f_1529_17727_18003(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, string[]
                names, string
                stringFormat, string
                resourceId)
                {
                    this_param.AssertNameDoesNotResolveToAPath(names, stringFormat, resourceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 17727, 18003);
                    return 0;
                }


                System.Management.Automation.SwitchParameter
                f_1529_18067_18075(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    var return_v = this_param.All;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 18067, 18075);
                    return return_v;
                }


                int
                f_1529_18026_18076(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, string[]
                names, System.Collections.Generic.Dictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                moduleSpecTable, System.Management.Automation.SwitchParameter
                all)
                {
                    this_param.GetLoadedModules(names, (System.Collections.Generic.IDictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>)moduleSpecTable, (bool)all);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 18026, 18076);
                    return 0;
                }


                string
                f_1529_18134_18150()
                {
                    var return_v = ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 18134, 18150);
                    return return_v;
                }


                bool
                f_1529_18134_18230(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 18134, 18230);
                    return return_v;
                }


                int
                f_1529_18264_18289(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    this_param.AssertListAvailableMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 18264, 18289);
                    return 0;
                }


                string
                f_1529_18396_18447()
                {
                    var return_v = Modules.RemoteDiscoveryWorksOnlyForUnQualifiedNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 18396, 18447);
                    return return_v;
                }


                int
                f_1529_18308_18544(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, string[]
                names, string
                stringFormat, string
                resourceId)
                {
                    this_param.AssertNameDoesNotResolveToAPath(names, stringFormat, resourceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 18308, 18544);
                    return 0;
                }


                System.Management.Automation.Runspaces.PSSession
                f_1529_18616_18630(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    var return_v = this_param.PSSession;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 18616, 18630);
                    return return_v;
                }


                int
                f_1529_18565_18631(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, string[]
                names, System.Collections.Generic.Dictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                moduleSpecTable, System.Management.Automation.Runspaces.PSSession
                session)
                {
                    this_param.GetAvailableViaPsrpSession(names, (System.Collections.Generic.IDictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>)moduleSpecTable, session);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 18565, 18631);
                    return 0;
                }


                string
                f_1529_18670_18686()
                {
                    var return_v = ParameterSetName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 18670, 18686);
                    return return_v;
                }


                bool
                f_1529_18670_18765(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 18670, 18765);
                    return return_v;
                }


                int
                f_1529_18799_18824(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    this_param.AssertListAvailableMode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 18799, 18824);
                    return 0;
                }


                string
                f_1529_18931_18982()
                {
                    var return_v = Modules.RemoteDiscoveryWorksOnlyForUnQualifiedNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 18931, 18982);
                    return return_v;
                }


                int
                f_1529_18843_19079(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, string[]
                names, string
                stringFormat, string
                resourceId)
                {
                    this_param.AssertNameDoesNotResolveToAPath(names, stringFormat, resourceId);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 18843, 19079);
                    return 0;
                }


                Microsoft.Management.Infrastructure.CimSession
                f_1529_19150_19165(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    var return_v = this_param.CimSession;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 19150, 19165);
                    return return_v;
                }


                System.Uri
                f_1529_19210_19229(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    var return_v = this_param.CimResourceUri;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 19210, 19229);
                    return return_v;
                }


                string
                f_1529_19231_19248(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param)
                {
                    var return_v = this_param.CimNamespace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 19231, 19248);
                    return return_v;
                }


                int
                f_1529_19100_19249(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, string[]
                names, System.Collections.Generic.Dictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                moduleSpecTable, Microsoft.Management.Infrastructure.CimSession
                cimSession, System.Uri
                resourceUri, string
                cimNamespace)
                {
                    this_param.GetAvailableViaCimSession((System.Collections.Generic.IEnumerable<string>)names, (System.Collections.Generic.IDictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>)moduleSpecTable, cimSession, resourceUri, cimNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 19100, 19249);
                    return 0;
                }


                int
                f_1529_19316_19363(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 19316, 19363);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 14666, 19390);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 14666, 19390);
            }
        }

        private void AssertNameDoesNotResolveToAPath(string[] names, string stringFormat, string resourceId)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 19402, 20326);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 19527, 20315) || true) && (names != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 19527, 20315);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 19578, 20300);
                        foreach (var n in f_1529_19596_19601_I(names))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 19578, 20300);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 19643, 20281) || true) && (f_1529_19647_19693(n, StringLiterals.DefaultPathSeparator) != -1 || (DynAbs.Tracing.TraceSender.Expression_False(1529, 19647, 19757) || f_1529_19703_19751(n, StringLiterals.AlternatePathSeparator) != -1))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 19643, 20281);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 19807, 19864);

                                string
                                errorMessage = f_1529_19829_19863(stringFormat, n)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 19890, 19950);

                                var
                                argumentException = f_1529_19914_19949(errorMessage)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 19976, 20192);

                                var
                                errorRecord = f_1529_19994_20191(argumentException, resourceId, ErrorCategory.InvalidArgument, n)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 20218, 20258);

                                f_1529_20218_20257(this, errorRecord);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 19643, 20281);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 19578, 20300);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1529, 1, 723);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1529, 1, 723);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 19527, 20315);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 19402, 20326);

                int
                f_1529_19647_19693(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 19647, 19693);
                    return return_v;
                }


                int
                f_1529_19703_19751(string
                this_param, char
                value)
                {
                    var return_v = this_param.IndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 19703, 19751);
                    return return_v;
                }


                string
                f_1529_19829_19863(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 19829, 19863);
                    return return_v;
                }


                System.ArgumentException
                f_1529_19914_19949(string
                message)
                {
                    var return_v = new System.ArgumentException(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 19914, 19949);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1529_19994_20191(System.ArgumentException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, string
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, (object)targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 19994, 20191);
                    return return_v;
                }


                int
                f_1529_20218_20257(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 20218, 20257);
                    return 0;
                }


                string[]
                f_1529_19596_19601_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 19596, 19601);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 19402, 20326);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 19402, 20326);
            }
        }

        private void GetAvailableViaCimSession(IEnumerable<string> names, IDictionary<string, ModuleSpecification> moduleSpecTable,
                                                       CimSession cimSession, Uri resourceUri, string cimNamespace)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 20338, 21127);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 20595, 20713);

                IEnumerable<PSModuleInfo>
                remoteModules = f_1529_20637_20712(this, names, cimSession, resourceUri, cimNamespace)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 20729, 21116);
                    foreach (PSModuleInfo remoteModule in f_1529_20767_20838_I(f_1529_20767_20838(this, remoteModules, moduleSpecTable)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 20729, 21116);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 20872, 21052);

                        f_1529_20872_21051(remoteModule, cimSession, resourceUri, cimNamespace);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 21070, 21101);

                        f_1529_21070_21100(this, remoteModule);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 20729, 21116);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1529, 1, 388);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1529, 1, 388);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 20338, 21127);

                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_20637_20712(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Collections.Generic.IEnumerable<string>
                moduleNames, Microsoft.Management.Infrastructure.CimSession
                cimSession, System.Uri
                resourceUri, string
                cimNamespace)
                {
                    var return_v = this_param.GetAvailableViaCimSessionCore(moduleNames, cimSession, resourceUri, cimNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 20637, 20712);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_20767_20838(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                modules, System.Collections.Generic.IDictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                moduleSpecificationTable)
                {
                    var return_v = this_param.FilterModulesForEditionAndSpecification(modules, moduleSpecificationTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 20767, 20838);
                    return return_v;
                }


                int
                f_1529_20872_21051(System.Management.Automation.PSModuleInfo
                moduleInfo, Microsoft.Management.Infrastructure.CimSession
                cimSession, System.Uri
                resourceUri, string
                cimNamespace)
                {
                    RemoteDiscoveryHelper.AssociatePSModuleInfoWithSession(moduleInfo, cimSession, resourceUri, cimNamespace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 20872, 21051);
                    return 0;
                }


                int
                f_1529_21070_21100(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 21070, 21100);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_20767_20838_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 20767, 20838);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 20338, 21127);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 20338, 21127);
            }
        }

        private void GetAvailableViaPsrpSession(string[] names, IDictionary<string, ModuleSpecification> moduleSpecTable, PSSession session)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 21139, 21706);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 21296, 21394);

                IEnumerable<PSModuleInfo>
                remoteModules = f_1529_21338_21393(this, names, f_1529_21376_21392(session))
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 21410, 21695);
                    foreach (PSModuleInfo remoteModule in f_1529_21448_21519_I(f_1529_21448_21519(this, remoteModules, moduleSpecTable)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 21410, 21695);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 21553, 21631);

                        f_1529_21553_21630(remoteModule, session);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 21649, 21680);

                        f_1529_21649_21679(this, remoteModule);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 21410, 21695);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1529, 1, 286);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1529, 1, 286);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 21139, 21706);

                System.Management.Automation.Runspaces.Runspace
                f_1529_21376_21392(System.Management.Automation.Runspaces.PSSession
                this_param)
                {
                    var return_v = this_param.Runspace;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 21376, 21392);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_21338_21393(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, string[]
                moduleNames, System.Management.Automation.Runspaces.Runspace
                remoteRunspace)
                {
                    var return_v = this_param.GetAvailableViaPsrpSessionCore(moduleNames, remoteRunspace);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 21338, 21393);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_21448_21519(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                modules, System.Collections.Generic.IDictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                moduleSpecificationTable)
                {
                    var return_v = this_param.FilterModulesForEditionAndSpecification(modules, moduleSpecificationTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 21448, 21519);
                    return return_v;
                }


                int
                f_1529_21553_21630(System.Management.Automation.PSModuleInfo
                moduleInfo, System.Management.Automation.Runspaces.PSSession
                psSession)
                {
                    RemoteDiscoveryHelper.AssociatePSModuleInfoWithSession(moduleInfo, psSession);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 21553, 21630);
                    return 0;
                }


                int
                f_1529_21649_21679(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 21649, 21679);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_21448_21519_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 21448, 21519);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 21139, 21706);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 21139, 21706);
            }
        }

        private void GetAvailableLocallyModules(string[] names, IDictionary<string, ModuleSpecification> moduleSpecTable, bool all)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 21718, 22249);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 21866, 21933);

                IEnumerable<PSModuleInfo>
                modules = f_1529_21902_21932(this, names, all, f_1529_21924_21931())
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 21947, 22238);
                    foreach (PSModuleInfo module in f_1529_21979_22044_I(f_1529_21979_22044(this, modules, moduleSpecTable)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 21947, 22238);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 22078, 22114);

                        var
                        psModule = f_1529_22093_22113(module)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 22132, 22183);

                        f_1529_22132_22182(f_1529_22132_22150(psModule), 0, "ModuleInfoGrouping");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 22201, 22223);

                        f_1529_22201_22222(this, psModule);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 21947, 22238);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1529, 1, 292);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1529, 1, 292);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 21718, 22249);

                System.Management.Automation.SwitchParameter
                f_1529_21924_21931()
                {
                    var return_v = Refresh;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 21924, 21931);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1529_21902_21932(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, string[]
                names, bool
                all, System.Management.Automation.SwitchParameter
                refresh)
                {
                    var return_v = this_param.GetModule(names, all, (bool)refresh);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 21902, 21932);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_21979_22044(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                modules, System.Collections.Generic.IDictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                moduleSpecificationTable)
                {
                    var return_v = this_param.FilterModulesForEditionAndSpecification(modules, moduleSpecificationTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 21979, 22044);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1529_22093_22113(System.Management.Automation.PSModuleInfo
                obj)
                {
                    var return_v = new System.Management.Automation.PSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 22093, 22113);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1529_22132_22150(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 22132, 22150);
                    return return_v;
                }


                int
                f_1529_22132_22182(System.Collections.ObjectModel.Collection<string>
                this_param, int
                index, string
                item)
                {
                    this_param.Insert(index, item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 22132, 22182);
                    return 0;
                }


                int
                f_1529_22201_22222(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Management.Automation.PSObject
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 22201, 22222);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_21979_22044_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 21979, 22044);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 21718, 22249);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 21718, 22249);
            }
        }

        private void GetLoadedModules(string[] names, IDictionary<string, ModuleSpecification> moduleSpecTable, bool all)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 22261, 22667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 22399, 22459);

                var
                modulesToWrite = f_1529_22420_22458(f_1529_22420_22435(f_1529_22420_22427()), names, all)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 22475, 22656);
                    foreach (PSModuleInfo moduleInfo in f_1529_22511_22583_I(f_1529_22511_22583(this, modulesToWrite, moduleSpecTable)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 22475, 22656);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 22617, 22641);

                        f_1529_22617_22640(this, moduleInfo);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 22475, 22656);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1529, 1, 182);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1529, 1, 182);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 22261, 22667);

                System.Management.Automation.ExecutionContext
                f_1529_22420_22427()
                {
                    var return_v = Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 22420, 22427);
                    return return_v;
                }


                System.Management.Automation.ModuleIntrinsics
                f_1529_22420_22435(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.Modules;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 22420, 22435);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                f_1529_22420_22458(System.Management.Automation.ModuleIntrinsics
                this_param, string[]
                patterns, bool
                all)
                {
                    var return_v = this_param.GetModules(patterns, all);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 22420, 22458);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_22511_22583(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Collections.Generic.List<System.Management.Automation.PSModuleInfo>
                modules, System.Collections.Generic.IDictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                moduleSpecificationTable)
                {
                    var return_v = this_param.FilterModulesForEditionAndSpecification((System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>)modules, moduleSpecificationTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 22511, 22583);
                    return return_v;
                }


                int
                f_1529_22617_22640(Microsoft.PowerShell.Commands.GetModuleCommand
                this_param, System.Management.Automation.PSModuleInfo
                sendToPipeline)
                {
                    this_param.WriteObject((object)sendToPipeline);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 22617, 22640);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_22511_22583_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 22511, 22583);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 22261, 22667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 22261, 22667);
            }
        }

        private IEnumerable<PSModuleInfo> FilterModulesForEditionAndSpecification(
                    IEnumerable<PSModuleInfo> modules,
                    IDictionary<string, ModuleSpecification> moduleSpecificationTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 23268, 24235);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 23581, 23748) || true) && (f_1529_23585_23602_M(!SkipEditionCheck) && (DynAbs.Tracing.TraceSender.Expression_True(1529, 23585, 23619) && f_1529_23606_23619()) && (DynAbs.Tracing.TraceSender.Expression_True(1529, 23585, 23627) && f_1529_23623_23627_M(!All)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 23581, 23748);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 23661, 23733);

                    modules = f_1529_23671_23732(modules, module => module.IsConsideredEditionCompatible);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 23581, 23748);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 23772, 23974) || true) && (!f_1529_23777_23808(f_1529_23798_23807()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 23772, 23974);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 23842, 23959);

                    modules = f_1529_23852_23958(modules, module => module.CompatiblePSEditions.Contains(PSEdition, StringComparer.OrdinalIgnoreCase));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 23772, 23974);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 23990, 24193) || true) && (moduleSpecificationTable != null && (DynAbs.Tracing.TraceSender.Expression_True(1529, 23994, 24064) && f_1529_24030_24060(moduleSpecificationTable) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 23990, 24193);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 24098, 24178);

                    modules = f_1529_24108_24177(modules, moduleSpecificationTable);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 23990, 24193);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 24209, 24224);

                return modules;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 23268, 24235);

                bool
                f_1529_23585_23602_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 23585, 23602);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1529_23606_23619()
                {
                    var return_v = ListAvailable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 23606, 23619);
                    return return_v;
                }


                bool
                f_1529_23623_23627_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 23623, 23627);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_23671_23732(System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                source, System.Func<System.Management.Automation.PSModuleInfo, bool>
                predicate)
                {
                    var return_v = source.Where<System.Management.Automation.PSModuleInfo>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 23671, 23732);
                    return return_v;
                }


                string
                f_1529_23798_23807()
                {
                    var return_v = PSEdition;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 23798, 23807);
                    return return_v;
                }


                bool
                f_1529_23777_23808(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 23777, 23808);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_23852_23958(System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                source, System.Func<System.Management.Automation.PSModuleInfo, bool>
                predicate)
                {
                    var return_v = source.Where<System.Management.Automation.PSModuleInfo>(predicate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 23852, 23958);
                    return return_v;
                }


                int
                f_1529_24030_24060(System.Collections.Generic.IDictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 24030, 24060);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_24108_24177(System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                modules, System.Collections.Generic.IDictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                moduleSpecificationTable)
                {
                    var return_v = FilterModulesForSpecificationMatch(modules, moduleSpecificationTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 24108, 24177);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 23268, 24235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 23268, 24235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<PSModuleInfo> FilterModulesForSpecificationMatch(
                    IEnumerable<PSModuleInfo> modules,
                    IDictionary<string, ModuleSpecification> moduleSpecificationTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1529, 24817, 26058);

                var listYield = new List<PSModuleInfo>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 25046, 25164);

                f_1529_25046_25163(moduleSpecificationTable != null, $"Caller to verify that {nameof(moduleSpecificationTable)} is not null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 25178, 25300);

                f_1529_25178_25299(f_1529_25189_25219(moduleSpecificationTable) != 0, $"Caller to verify that {nameof(moduleSpecificationTable)} is not empty");
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 25316, 26047);
                    foreach (PSModuleInfo module in f_1529_25348_25355_I(modules))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 25316, 26047);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 25389, 25503);

                        IEnumerable<ModuleSpecification>
                        candidateModuleSpecs = f_1529_25445_25502(moduleSpecificationTable, module)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 25727, 26032);
                            foreach (ModuleSpecification moduleSpec in f_1529_25770_25790_I(candidateModuleSpecs))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 25727, 26032);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 25832, 26013) || true) && (f_1529_25836_25920(module, moduleSpec, skipNameCheck: true))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 25832, 26013);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 25970, 25990);

                                    listYield.Add(module);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 25832, 26013);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 25727, 26032);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1529, 1, 306);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1529, 1, 306);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 25316, 26047);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1529, 1, 732);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1529, 1, 732);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1529, 24817, 26058);

                return listYield;

                int
                f_1529_25046_25163(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 25046, 25163);
                    return 0;
                }


                int
                f_1529_25189_25219(System.Collections.Generic.IDictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 25189, 25219);
                    return return_v;
                }


                int
                f_1529_25178_25299(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Dbg.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 25178, 25299);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1529_25445_25502(System.Collections.Generic.IDictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                moduleSpecTable, System.Management.Automation.PSModuleInfo
                module)
                {
                    var return_v = GetCandidateModuleSpecs(moduleSpecTable, module);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 25445, 25502);
                    return return_v;
                }


                bool
                f_1529_25836_25920(System.Management.Automation.PSModuleInfo
                moduleInfo, Microsoft.PowerShell.Commands.ModuleSpecification
                moduleSpec, bool
                skipNameCheck)
                {
                    var return_v = ModuleIntrinsics.IsModuleMatchingModuleSpec(moduleInfo, moduleSpec, skipNameCheck: skipNameCheck);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 25836, 25920);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1529_25770_25790_I(System.Collections.Generic.IEnumerable<Microsoft.PowerShell.Commands.ModuleSpecification>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 25770, 25790);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                f_1529_25348_25355_I(System.Collections.Generic.IEnumerable<System.Management.Automation.PSModuleInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 25348, 25355);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 24817, 26058);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 24817, 26058);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<ModuleSpecification> GetCandidateModuleSpecs(
                    IDictionary<string, ModuleSpecification> moduleSpecTable,
                    PSModuleInfo module)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1529, 26619, 27344);

                var listYield = new List<ModuleSpecification>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 26821, 26915);

                const WildcardOptions
                options = WildcardOptions.IgnoreCase | WildcardOptions.CultureInvariant
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 26929, 27333);
                    foreach (ModuleSpecification moduleSpec in f_1529_26972_26994_I(f_1529_26972_26994(moduleSpecTable)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 26929, 27333);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 27028, 27104);

                        WildcardPattern
                        namePattern = f_1529_27058_27103(f_1529_27078_27093(moduleSpec), options)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 27122, 27318) || true) && (f_1529_27126_27158(namePattern, f_1529_27146_27157(module)) || (DynAbs.Tracing.TraceSender.Expression_False(1529, 27126, 27192) || f_1529_27162_27177(moduleSpec) == f_1529_27181_27192(module)) || (DynAbs.Tracing.TraceSender.Expression_False(1529, 27126, 27233) || f_1529_27196_27233(f_1529_27196_27207(module), f_1529_27217_27232(moduleSpec))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 27122, 27318);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 27275, 27299);

                            listYield.Add(moduleSpec);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 27122, 27318);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 26929, 27333);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1529, 1, 405);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1529, 1, 405);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1529, 26619, 27344);

                return listYield;

                System.Collections.Generic.ICollection<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1529_26972_26994(System.Collections.Generic.IDictionary<string, Microsoft.PowerShell.Commands.ModuleSpecification>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 26972, 26994);
                    return return_v;
                }


                string
                f_1529_27078_27093(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 27078, 27093);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1529_27058_27103(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 27058, 27103);
                    return return_v;
                }


                string
                f_1529_27146_27157(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 27146, 27157);
                    return return_v;
                }


                bool
                f_1529_27126_27158(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 27126, 27158);
                    return return_v;
                }


                string
                f_1529_27162_27177(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 27162, 27177);
                    return return_v;
                }


                string
                f_1529_27181_27192(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 27181, 27192);
                    return return_v;
                }


                string
                f_1529_27196_27207(System.Management.Automation.PSModuleInfo
                this_param)
                {
                    var return_v = this_param.Path;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 27196, 27207);
                    return return_v;
                }


                string
                f_1529_27217_27232(Microsoft.PowerShell.Commands.ModuleSpecification
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1529, 27217, 27232);
                    return return_v;
                }


                bool
                f_1529_27196_27233(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 27196, 27233);
                    return return_v;
                }


                System.Collections.Generic.ICollection<Microsoft.PowerShell.Commands.ModuleSpecification>
                f_1529_26972_26994_I(System.Collections.Generic.ICollection<Microsoft.PowerShell.Commands.ModuleSpecification>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 26972, 26994);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 26619, 27344);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 26619, 27344);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public GetModuleCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1529, 817, 27351);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 1552, 2226);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 2352, 3019);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 4016, 4266);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 5474, 5636);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 5828, 5991);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 6150, 6311);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 6467, 6636);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 12525, 12581);
            this._cancellationTokenSource = f_1529_12552_12581();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 13887, 13896);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1529, 817, 27351);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 817, 27351);
        }


        static GetModuleCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1529, 817, 27351);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 1158, 1188);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 1220, 1263);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 1295, 1344);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 1376, 1425);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1529, 817, 27351);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 817, 27351);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1529, 817, 27351);

        System.Threading.CancellationTokenSource
        f_1529_12552_12581()
        {
            var return_v = new System.Threading.CancellationTokenSource();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 12552, 12581);
            return return_v;
        }

    }
    public class PSEditionArgumentCompleter : IArgumentCompleter
    {
        public IEnumerable<CompletionResult> CompleteArgument(string commandName, string parameterName, string wordToComplete, CommandAst commandAst, IDictionary fakeBoundParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1529, 27619, 28283);

                var listYield = new List<CompletionResult>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 27818, 27966);

                var
                wordToCompletePattern = f_1529_27846_27965((DynAbs.Tracing.TraceSender.Conditional_F1(1529, 27866, 27907) || ((f_1529_27866_27907(wordToComplete) && DynAbs.Tracing.TraceSender.Conditional_F2(1529, 27910, 27913)) || DynAbs.Tracing.TraceSender.Conditional_F3(1529, 27916, 27936))) ? "*" : wordToComplete + "*", WildcardOptions.IgnoreCase)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 27982, 28272);
                    foreach (var edition in f_1529_28006_28032_I(Utils.AllowedEditionValues))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 27982, 28272);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 28066, 28257) || true) && (f_1529_28070_28108(wordToCompletePattern, edition))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1529, 28066, 28257);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1529, 28150, 28238);

                            listYield.Add(f_1529_28163_28237(edition, edition, CompletionResultType.Text, edition));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 28066, 28257);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1529, 27982, 28272);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1529, 1, 291);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1529, 1, 291);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1529, 27619, 28283);

                return listYield;

                bool
                f_1529_27866_27907(string
                value)
                {
                    var return_v = string.IsNullOrWhiteSpace(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 27866, 27907);
                    return return_v;
                }


                System.Management.Automation.WildcardPattern
                f_1529_27846_27965(string
                pattern, System.Management.Automation.WildcardOptions
                options)
                {
                    var return_v = WildcardPattern.Get(pattern, options);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 27846, 27965);
                    return return_v;
                }


                bool
                f_1529_28070_28108(System.Management.Automation.WildcardPattern
                this_param, string
                input)
                {
                    var return_v = this_param.IsMatch(input);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 28070, 28108);
                    return return_v;
                }


                System.Management.Automation.CompletionResult
                f_1529_28163_28237(string
                completionText, string
                listItemText, System.Management.Automation.CompletionResultType
                resultType, string
                toolTip)
                {
                    var return_v = new System.Management.Automation.CompletionResult(completionText, listItemText, resultType, toolTip);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 28163, 28237);
                    return return_v;
                }


                string[]
                f_1529_28006_28032_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1529, 28006, 28032);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1529, 27619, 28283);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 27619, 28283);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PSEditionArgumentCompleter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1529, 27464, 28290);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1529, 27464, 28290);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 27464, 28290);
        }


        static PSEditionArgumentCompleter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1529, 27464, 28290);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1529, 27464, 28290);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1529, 27464, 28290);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1529, 27464, 28290);
    }
}
