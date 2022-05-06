// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.IO;
using System.Management.Automation;
using System.Runtime.InteropServices;
using System.Threading;

using Microsoft.ApplicationInsights;
using Microsoft.ApplicationInsights.Extensibility;

namespace Microsoft.PowerShell.Telemetry
{
    /// <summary>
    /// The category of telemetry.
    /// </summary>
    internal enum TelemetryType
    {
        /// <summary>
        /// Telemetry of the application type (cmdlet, script, etc).
        /// </summary>
        ApplicationType,

        /// <summary>
        /// Send telemetry when we load a module, only module names in the s_knownModules list
        /// will be reported, otherwise it will be "anonymous".
        /// </summary>
        ModuleLoad,

        /// <summary>
        /// Send telemetry when we load a module using Windows compatibility feature, only module names in the s_knownModules list
        /// will be reported, otherwise it will be "anonymous".
        /// </summary>
        WinCompatModuleLoad,

        /// <summary>
        /// Send telemetry for experimental module feature activation.
        /// All experimental engine features will be have telemetry.
        /// </summary>
        ExperimentalEngineFeatureActivation,

        /// <summary>
        /// Send telemetry for experimental module feature activation.
        /// Experimental module features will send telemetry based on the module it is in.
        /// If we send telemetry for the module, we will also do so for any experimental feature
        /// in that module.
        /// </summary>
        ExperimentalModuleFeatureActivation,

        /// <summary>
        /// Send telemetry for each PowerShell.Create API.
        /// </summary>
        PowerShellCreate,

        /// <summary>
        /// Remote session creation.
        /// </summary>
        RemoteSessionOpen,
    }
    public static class ApplicationInsightsTelemetry
    {
        private const string
        _telemetryOptoutEnvVar = "POWERSHELL_TELEMETRY_OPTOUT"
        ;

        private const string
        _psCoreTelemetryKey = "d26a5ef4-d608-452c-a6b8-a4a55935f70d"
        ;

        private const string
        _anonymous = "anonymous"
        ;

        private const string
        _telemetryFailure = "TELEMETRY_FAILURE"
        ;

        private static TelemetryClient s_telemetryClient { get; set; }

        private static string s_uniqueUserIdentifier { get; set; }

        private static string s_sessionId { get; set; }

        private static int s_startupEventSent;

        private static HashSet<string> s_knownModules;

        public static bool CanSendTelemetry { get; private set; }

        static ApplicationInsightsTelemetry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1044, 4280, 24386);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 2309, 2363);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 2547, 2607);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 2738, 2762);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 2837, 2876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 2968, 3030);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 3107, 3165);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 3212, 3259);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 3377, 3399);
                s_startupEventSent = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 3653, 3667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 3767, 3824);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 4422, 4522);

                CanSendTelemetry = !f_1044_4442_4521(name: _telemetryOptoutEnvVar, defaultValue: false);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 4536, 24375) || true) && (f_1044_4540_4556())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 4536, 24375);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 4590, 4668);

                    TelemetryConfiguration
                    configuration = f_1044_4629_4667()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 4686, 4741);

                    configuration.InstrumentationKey = _psCoreTelemetryKey;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 4835, 4888);

                    f_1044_4835_4865(configuration).DeveloperMode = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 4908, 4963);

                    s_telemetryClient = f_1044_4928_4962(configuration);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 4981, 5021);

                    s_sessionId = Guid.NewGuid().ToString();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 5152, 24282);

                    s_knownModules = new HashSet<string>(f_1044_5189_5221())
                    {
                        DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => "AADRM",1044,5169,24281),                        "activedirectory",                        "adcsadministration",                        "adcsdeployment",                        "addsadministration",                        "addsdeployment",                        "adfs",                        "adrms",                        "adrmsadmin",                        "agpm",                        "appbackgroundtask",                        "applocker",                        "appv",                        "appvclient",                        "appvsequencer",                        "appvserver",                        "appx",                        "assignedaccess",                        "Az",                        "Az.Accounts",                        "Az.Advisor",                        "Az.Aks",                        "Az.AlertsManagement",                        "Az.AnalysisServices",                        "Az.ApiManagement",                        "Az.ApplicationInsights",                        "Az.Attestation",                        "Az.Automation",                        "Az.Batch",                        "Az.Billing",                        "Az.Blueprint",                        "Az.Cdn",                        "Az.CognitiveServices",                        "Az.Compute",                        "Az.ContainerInstance",                        "Az.ContainerRegistry",                        "Az.DataBox",                        "Az.DataFactory",                        "Az.DataLakeAnalytics",                        "Az.DataLakeStore",                        "Az.DataMigration",                        "Az.DataShare",                        "Az.DeploymentManager",                        "Az.DeviceProvisioningServices",                        "Az.DevSpaces",                        "Az.DevTestLabs",                        "Az.Dns",                        "Az.EventGrid",                        "Az.EventHub",                        "Az.FrontDoor",                        "Az.GuestConfiguration",                        "Az.HDInsight",                        "Az.HealthcareApis",                        "Az.IotCentral",                        "Az.IotHub",                        "Az.KeyVault",                        "Az.Kusto",                        "Az.LogicApp",                        "Az.MachineLearning",                        "Az.ManagedServiceIdentity",                        "Az.ManagedServices",                        "Az.ManagementPartner",                        "Az.Maps",                        "Az.MarketplaceOrdering",                        "Az.Media",                        "Az.MixedReality",                        "Az.Monitor",                        "Az.NetAppFiles",                        "Az.Network",                        "Az.NotificationHubs",                        "Az.OperationalInsights",                        "Az.Peering",                        "Az.PolicyInsights",                        "Az.PowerBIEmbedded",                        "Az.PrivateDns",                        "Az.RecoveryServices",                        "Az.RedisCache",                        "Az.Relay",                        "Az.Reservations",                        "Az.ResourceGraph",                        "Az.Resources",                        "Az.Search",                        "Az.Security",                        "Az.ServiceBus",                        "Az.ServiceFabric",                        "Az.SignalR",                        "Az.Sql",                        "Az.Storage",                        "Az.StorageSync",                        "Az.StorageTable",                        "Az.StreamAnalytics",                        "Az.Subscription",                        "Az.TrafficManager",                        "Az.Websites",                        "Azs.Azurebridge.Admin",                        "Azs.Backup.Admin",                        "Azs.Commerce.Admin",                        "Azs.Compute.Admin",                        "Azs.Fabric.Admin",                        "Azs.Gallery.Admin",                        "Azs.Infrastructureinsights.Admin",                        "Azs.Keyvault.Admin",                        "Azs.Network.Admin",                        "Azs.Storage.Admin",                        "Azs.Subscriptions",                        "Azs.Subscriptions.Admin",                        "Azs.Update.Admin",                        "AzStorageTable",                        "Azure",                        "Azure.AnalysisServices",                        "Azure.Storage",                        "AzureAD",                        "AzureInformationProtection",                        "AzureRM.Aks",                        "AzureRM.AnalysisServices",                        "AzureRM.ApiManagement",                        "AzureRM.ApplicationInsights",                        "AzureRM.Automation",                        "AzureRM.Backup",                        "AzureRM.Batch",                        "AzureRM.Billing",                        "AzureRM.Cdn",                        "AzureRM.CognitiveServices",                        "AzureRm.Compute",                        "AzureRM.Compute.ManagedService",                        "AzureRM.Consumption",                        "AzureRM.ContainerInstance",                        "AzureRM.ContainerRegistry",                        "AzureRM.DataFactories",                        "AzureRM.DataFactoryV2",                        "AzureRM.DataLakeAnalytics",                        "AzureRM.DataLakeStore",                        "AzureRM.DataMigration",                        "AzureRM.DeploymentManager",                        "AzureRM.DeviceProvisioningServices",                        "AzureRM.DevSpaces",                        "AzureRM.DevTestLabs",                        "AzureRm.Dns",                        "AzureRM.EventGrid",                        "AzureRM.EventHub",                        "AzureRM.FrontDoor",                        "AzureRM.HDInsight",                        "AzureRm.Insights",                        "AzureRM.IotCentral",                        "AzureRM.IotHub",                        "AzureRm.Keyvault",                        "AzureRM.LocationBasedServices",                        "AzureRM.LogicApp",                        "AzureRM.MachineLearning",                        "AzureRM.MachineLearningCompute",                        "AzureRM.ManagedServiceIdentity",                        "AzureRM.ManagementPartner",                        "AzureRM.Maps",                        "AzureRM.MarketplaceOrdering",                        "AzureRM.Media",                        "AzureRM.Network",                        "AzureRM.NotificationHubs",                        "AzureRM.OperationalInsights",                        "AzureRM.PolicyInsights",                        "AzureRM.PowerBIEmbedded",                        "AzureRM.Profile",                        "AzureRM.RecoveryServices",                        "AzureRM.RecoveryServices.Backup",                        "AzureRM.RecoveryServices.SiteRecovery",                        "AzureRM.RedisCache",                        "AzureRM.Relay",                        "AzureRM.Reservations",                        "AzureRM.ResourceGraph",                        "AzureRM.Resources",                        "AzureRM.Scheduler",                        "AzureRM.Search",                        "AzureRM.Security",                        "AzureRM.ServerManagement",                        "AzureRM.ServiceBus",                        "AzureRM.ServiceFabric",                        "AzureRM.SignalR",                        "AzureRM.SiteRecovery",                        "AzureRM.Sql",                        "AzureRm.Storage",                        "AzureRM.StorageSync",                        "AzureRM.StreamAnalytics",                        "AzureRM.Subscription",                        "AzureRM.Subscription.Preview",                        "AzureRM.Tags",                        "AzureRM.TrafficManager",                        "AzureRm.UsageAggregates",                        "AzureRm.Websites",                        "AzureRmStorageTable",                        "bestpractices",                        "bitlocker",                        "bitstransfer",                        "booteventcollector",                        "branchcache",                        "CimCmdlets",                        "clusterawareupdating",                        "configci",                        "ConfigurationManager",                        "DataProtectionManager",                        "dcbqos",                        "deduplication",                        "defender",                        "devicehealthattestation",                        "dfsn",                        "dfsr",                        "dhcpserver",                        "directaccessclient",                        "directaccessclientcomponent",                        "directaccessclientcomponents",                        "dism",                        "dnsclient",                        "dnsserver",                        "ElasticDatabaseJobs",                        "EventTracingManagement",                        "failoverclusters",                        "fileserverresourcemanager",                        "FIMAutomation",                        "GPRegistryPolicy",                        "grouppolicy",                        "hardwarecertification",                        "hcs",                        "hgsattestation",                        "hgsclient",                        "hgsdiagnostics",                        "hgskeyprotection",                        "hgsserver",                        "hnvdiagnostics",                        "hostcomputeservice",                        "hpc",                        "HPC.ACM",                        "HPC.ACM.API.PS",                        "HPCPack2016",                        "hyper-v",                        "IISAdministration",                        "international",                        "ipamserver",                        "iscsi",                        "iscsitarget",                        "ISE",                        "kds",                        "Microsoft.MBAM",                        "Microsoft.MEDV",                        "MgmtSvcAdmin",                        "MgmtSvcConfig",                        "MgmtSvcMySql",                        "MgmtSvcSqlServer",                        "Microsoft.AzureStack.ReadinessChecker",                        "Microsoft.Crm.PowerShell",                        "Microsoft.DiagnosticDataViewer",                        "Microsoft.DirectoryServices.MetadirectoryServices.Config",                        "Microsoft.Dynamics.Nav.Apps.Management",                        "Microsoft.Dynamics.Nav.Apps.Tools",                        "Microsoft.Dynamics.Nav.Ide",                        "Microsoft.Dynamics.Nav.Management",                        "Microsoft.Dynamics.Nav.Model.Tools",                        "Microsoft.Dynamics.Nav.Model.Tools.Crm",                        "Microsoft.EnterpriseManagement.Warehouse.Cmdlets",                        "Microsoft.Medv.Administration.Commands.WorkspacePackager",                        "Microsoft.PowerApps.Checker.PowerShell",                        "Microsoft.PowerShell.Archive",                        "Microsoft.PowerShell.Core",                        "Microsoft.PowerShell.Diagnostics",                        "Microsoft.PowerShell.Host",                        "Microsoft.PowerShell.LocalAccounts",                        "Microsoft.PowerShell.Management",                        "Microsoft.PowerShell.ODataUtils",                        "Microsoft.PowerShell.Operation.Validation",                        "Microsoft.PowerShell.Security",                        "Microsoft.PowerShell.Utility",                        "Microsoft.SharePoint.Powershell",                        "Microsoft.SystemCenter.ServiceManagementAutomation",                        "Microsoft.Windows.ServerManager.Migration",                        "Microsoft.WSMan.Management",                        "Microsoft.Xrm.OnlineManagementAPI",                        "Microsoft.Xrm.Tooling.CrmConnector.PowerShell",                        "Microsoft.Xrm.Tooling.PackageDeployment",                        "Microsoft.Xrm.Tooling.PackageDeployment.Powershell",                        "Microsoft.Xrm.Tooling.Testing",                        "MicrosoftPowerBIMgmt",                        "MicrosoftPowerBIMgmt.Data",                        "MicrosoftPowerBIMgmt.Profile",                        "MicrosoftPowerBIMgmt.Reports",                        "MicrosoftPowerBIMgmt.Workspaces",                        "MicrosoftStaffHub",                        "MicrosoftTeams",                        "MIMPAM",                        "mlSqlPs",                        "MMAgent",                        "MPIO",                        "MsDtc",                        "MSMQ",                        "MSOnline",                        "MSOnlineBackup",                        "WmsCmdlets",                        "WmsCmdlets3",                        "NanoServerImageGenerator",                        "NAVWebClientManagement",                        "NetAdapter",                        "NetConnection",                        "NetEventPacketCapture",                        "Netlbfo",                        "Netldpagent",                        "NetNat",                        "Netqos",                        "NetSecurity",                        "NetSwitchtTeam",                        "Nettcpip",                        "Netwnv",                        "NetworkConnectivity",                        "NetworkConnectivityStatus",                        "NetworkController",                        "NetworkControllerDiagnostics",                        "NetworkloadBalancingClusters",                        "NetworkSwitchManager",                        "NetworkTransition",                        "NFS",                        "NPS",                        "OfficeWebapps",                        "OperationsManager",                        "PackageManagement",                        "PartnerCenter",                        "pcsvdevice",                        "pef",                        "Pester",                        "pkiclient",                        "platformidentifier",                        "pnpdevice",                        "PowerShellEditorServices",                        "PowerShellGet",                        "powershellwebaccess",                        "printmanagement",                        "ProcessMitigations",                        "provisioning",                        "PSDesiredStateConfiguration",                        "PSDiagnostics",                        "PSReadLine",                        "PSScheduledJob",                        "PSScriptAnalyzer",                        "PSWorkflow",                        "PSWorkflowUtility",                        "RemoteAccess",                        "RemoteDesktop",                        "RemoteDesktopServices",                        "ScheduledTasks",                        "Secureboot",                        "ServerCore",                        "ServerManager",                        "ServerManagerTasks",                        "ServerMigrationcmdlets",                        "ServiceFabric",                        "Microsoft.Online.SharePoint.PowerShell",                        "shieldedvmdatafile",                        "shieldedvmprovisioning",                        "shieldedvmtemplate",                        "SkypeOnlineConnector",                        "SkypeForBusinessHybridHealth",                        "smbshare",                        "smbwitness",                        "smisconfig",                        "softwareinventorylogging",                        "SPFAdmin",                        "Microsoft.SharePoint.MigrationTool.PowerShell",                        "sqlps",                        "SqlServer",                        "StartLayout",                        "StartScreen",                        "Storage",                        "StorageDsc",                        "storageqos",                        "Storagereplica",                        "Storagespaces",                        "Syncshare",                        "System.Center.Service.Manager",                        "TLS",                        "TroubleshootingPack",                        "TrustedPlatformModule",                        "UEV",                        "UpdateServices",                        "UserAccessLogging",                        "vamt",                        "VirtualMachineManager",                        "vpnclient",                        "WasPSExt",                        "WDAC",                        "WDS",                        "WebAdministration",                        "WebAdministrationDsc",                        "WebApplicationProxy",                        "WebSites",                        "Whea",                        "WhiteboardAdmin",                        "WindowsDefender",                        "WindowsDefenderDsc",                        "WindowsDeveloperLicense",                        "WindowsDiagnosticData",                        "WindowsErrorReporting",                        "WindowServerRackup",                        "WindowsSearch",                        "WindowsServerBackup",                        "WindowsUpdate",                        "wsscmdlets",                        "wsssetup",                        "wsus",                        "xActiveDirectory",                        "xBitLocker",                        "xDefender",                        "xDhcpServer",                        "xDismFeature",                        "xDnsServer",                        "xHyper-V",                        "xHyper-VBackup",                        "xPSDesiredStateConfiguration",                        "xSmbShare",                        "xSqlPs",                        "xStorage",                        "xWebAdministration",                        "xWindowsUpdate"                    };
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 24302, 24360);

                    s_uniqueUserIdentifier = f_1044_24327_24348().ToString();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 4536, 24375);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1044, 4280, 24386);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1044, 4280, 24386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1044, 4280, 24386);
            }
        }

        private static bool GetEnvironmentVariableAsBool(string name, bool defaultValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1044, 24808, 25473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 24913, 24964);

                var
                str = f_1044_24923_24963(name)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 24978, 25076) || true) && (f_1044_24982_25007(str))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 24978, 25076);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 25041, 25061);

                    return defaultValue;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 24978, 25076);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 25092, 25462);

                switch (f_1044_25100_25122(str))
                {

                    case "true":
                    case "1":
                    case "yes":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 25092, 25462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 25246, 25258);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 25092, 25462);

                    case "false":
                    case "0":
                    case "no":
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 25092, 25462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 25366, 25379);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 25092, 25462);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 25092, 25462);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 25427, 25447);

                        return defaultValue;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 25092, 25462);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1044, 24808, 25473);

                string?
                f_1044_24923_24963(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 24923, 24963);
                    return return_v;
                }


                bool
                f_1044_24982_25007(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 24982, 25007);
                    return return_v;
                }


                string
                f_1044_25100_25122(string
                this_param)
                {
                    var return_v = this_param.ToLowerInvariant();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 25100, 25122);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1044, 24808, 25473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1044, 24808, 25473);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void SendTelemetryMetric(TelemetryType metricId, string data)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1044, 25744, 27674);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 25846, 25923) || true) && (f_1044_25850_25867_M(!CanSendTelemetry))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 25846, 25923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 25901, 25908);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 25846, 25923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 25939, 25976);

                f_1044_25939_25975("hosted");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 25992, 26032);

                string
                metricName = f_1044_26012_26031(metricId)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 26082, 27438);

                    switch (metricId)
                    {

                        case TelemetryType.ApplicationType:
                        case TelemetryType.PowerShellCreate:
                        case TelemetryType.RemoteSessionOpen:
                        case TelemetryType.ExperimentalEngineFeatureActivation:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 26082, 27438);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 26395, 26538);

                            f_1044_26395_26537(f_1044_26395_26465(f_1044_26395_26412(), metricName, "uuid", "SessionId", "Detail"), metricValue: 1.0, f_1044_26495_26517(), f_1044_26519_26530(), data);
                            DynAbs.Tracing.TraceSender.TraceBreak(1044, 26564, 26570);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 26082, 27438);

                        case TelemetryType.ExperimentalModuleFeatureActivation:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 26082, 27438);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 26673, 26739);

                            string
                            experimentalFeatureName = f_1044_26706_26738(data)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 26765, 26927);

                            f_1044_26765_26926(f_1044_26765_26835(f_1044_26765_26782(), metricName, "uuid", "SessionId", "Detail"), metricValue: 1.0, f_1044_26865_26887(), f_1044_26889_26900(), experimentalFeatureName);
                            DynAbs.Tracing.TraceSender.TraceBreak(1044, 26953, 26959);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 26082, 27438);

                        case TelemetryType.ModuleLoad:
                        case TelemetryType.WinCompatModuleLoad:
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 26082, 27438);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 27098, 27138);

                            string
                            moduleName = f_1044_27118_27137(data)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 27238, 27387);

                            f_1044_27238_27386(f_1044_27238_27308(f_1044_27238_27255(), metricName, "uuid", "SessionId", "Detail"), metricValue: 1.0, f_1044_27338_27360(), f_1044_27362_27373(), moduleName);
                            DynAbs.Tracing.TraceSender.TraceBreak(1044, 27413, 27419);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 26082, 27438);
                    }
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1044, 27467, 27663);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1044, 27467, 27663);
                    // do nothing, telemetry can't be sent
                    // don't send the panic telemetry as if we have failed above, it will likely fail here.
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1044, 25744, 27674);

                bool
                f_1044_25850_25867_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 25850, 25867);
                    return return_v;
                }


                int
                f_1044_25939_25975(string
                mode)
                {
                    SendPSCoreStartupTelemetry(mode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 25939, 25975);
                    return 0;
                }


                string
                f_1044_26012_26031(Microsoft.PowerShell.Telemetry.TelemetryType
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 26012, 26031);
                    return return_v;
                }


                Microsoft.ApplicationInsights.TelemetryClient
                f_1044_26395_26412()
                {
                    var return_v = s_telemetryClient;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 26395, 26412);
                    return return_v;
                }


                Microsoft.ApplicationInsights.Metric
                f_1044_26395_26465(Microsoft.ApplicationInsights.TelemetryClient
                this_param, string
                metricId, string
                dimension1Name, string
                dimension2Name, string
                dimension3Name)
                {
                    var return_v = this_param.GetMetric(metricId, dimension1Name, dimension2Name, dimension3Name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 26395, 26465);
                    return return_v;
                }


                string
                f_1044_26495_26517()
                {
                    var return_v = s_uniqueUserIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 26495, 26517);
                    return return_v;
                }


                string
                f_1044_26519_26530()
                {
                    var return_v = s_sessionId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 26519, 26530);
                    return return_v;
                }


                bool
                f_1044_26395_26537(Microsoft.ApplicationInsights.Metric
                this_param, double
                metricValue, string
                dimension1Value, string
                dimension2Value, string
                dimension3Value)
                {
                    var return_v = this_param.TrackValue(metricValue: metricValue, dimension1Value, dimension2Value, dimension3Value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 26395, 26537);
                    return return_v;
                }


                string
                f_1044_26706_26738(string
                featureNameToValidate)
                {
                    var return_v = GetExperimentalFeatureName(featureNameToValidate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 26706, 26738);
                    return return_v;
                }


                Microsoft.ApplicationInsights.TelemetryClient
                f_1044_26765_26782()
                {
                    var return_v = s_telemetryClient;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 26765, 26782);
                    return return_v;
                }


                Microsoft.ApplicationInsights.Metric
                f_1044_26765_26835(Microsoft.ApplicationInsights.TelemetryClient
                this_param, string
                metricId, string
                dimension1Name, string
                dimension2Name, string
                dimension3Name)
                {
                    var return_v = this_param.GetMetric(metricId, dimension1Name, dimension2Name, dimension3Name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 26765, 26835);
                    return return_v;
                }


                string
                f_1044_26865_26887()
                {
                    var return_v = s_uniqueUserIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 26865, 26887);
                    return return_v;
                }


                string
                f_1044_26889_26900()
                {
                    var return_v = s_sessionId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 26889, 26900);
                    return return_v;
                }


                bool
                f_1044_26765_26926(Microsoft.ApplicationInsights.Metric
                this_param, double
                metricValue, string
                dimension1Value, string
                dimension2Value, string
                dimension3Value)
                {
                    var return_v = this_param.TrackValue(metricValue: metricValue, dimension1Value, dimension2Value, dimension3Value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 26765, 26926);
                    return return_v;
                }


                string
                f_1044_27118_27137(string
                moduleNameToValidate)
                {
                    var return_v = GetModuleName(moduleNameToValidate);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 27118, 27137);
                    return return_v;
                }


                Microsoft.ApplicationInsights.TelemetryClient
                f_1044_27238_27255()
                {
                    var return_v = s_telemetryClient;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 27238, 27255);
                    return return_v;
                }


                Microsoft.ApplicationInsights.Metric
                f_1044_27238_27308(Microsoft.ApplicationInsights.TelemetryClient
                this_param, string
                metricId, string
                dimension1Name, string
                dimension2Name, string
                dimension3Name)
                {
                    var return_v = this_param.GetMetric(metricId, dimension1Name, dimension2Name, dimension3Name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 27238, 27308);
                    return return_v;
                }


                string
                f_1044_27338_27360()
                {
                    var return_v = s_uniqueUserIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 27338, 27360);
                    return return_v;
                }


                string
                f_1044_27362_27373()
                {
                    var return_v = s_sessionId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 27362, 27373);
                    return return_v;
                }


                bool
                f_1044_27238_27386(Microsoft.ApplicationInsights.Metric
                this_param, double
                metricValue, string
                dimension1Value, string
                dimension2Value, string
                dimension3Value)
                {
                    var return_v = this_param.TrackValue(metricValue: metricValue, dimension1Value, dimension2Value, dimension3Value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 27238, 27386);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1044, 25744, 27674);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1044, 25744, 27674);
            }
        }

        private static string GetExperimentalFeatureName(string featureNameToValidate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1044, 27828, 28451);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 28134, 28192);

                int
                lastDotIndex = f_1044_28153_28191(featureNameToValidate, '.')
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 28206, 28275);

                string
                moduleName = f_1044_28226_28274(featureNameToValidate, 0, lastDotIndex)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 28289, 28406) || true) && (f_1044_28293_28328(s_knownModules, moduleName))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 28289, 28406);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 28362, 28391);

                    return featureNameToValidate;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 28289, 28406);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 28422, 28440);

                return _anonymous;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1044, 27828, 28451);

                int
                f_1044_28153_28191(string
                this_param, char
                value)
                {
                    var return_v = this_param.LastIndexOf(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 28153, 28191);
                    return return_v;
                }


                string
                f_1044_28226_28274(string
                this_param, int
                startIndex, int
                length)
                {
                    var return_v = this_param.Substring(startIndex, length);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 28226, 28274);
                    return return_v;
                }


                bool
                f_1044_28293_28328(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 28293, 28328);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1044, 27828, 28451);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1044, 27828, 28451);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetModuleName(string moduleNameToValidate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1044, 28576, 28836);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 28665, 28791) || true) && (f_1044_28669_28714(s_knownModules, moduleNameToValidate))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 28665, 28791);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 28748, 28776);

                    return moduleNameToValidate;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 28665, 28791);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 28807, 28825);

                return _anonymous;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1044, 28576, 28836);

                bool
                f_1044_28669_28714(System.Collections.Generic.HashSet<string>
                this_param, string
                item)
                {
                    var return_v = this_param.Contains(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 28669, 28714);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1044, 28576, 28836);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1044, 28576, 28836);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void SendPSCoreStartupTelemetry(string mode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1044, 29083, 30550);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 29227, 29349) || true) && (f_1044_29231_29288(ref s_startupEventSent, 1, 0) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 29227, 29349);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 29327, 29334);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 29227, 29349);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 29365, 29442) || true) && (f_1044_29369_29386_M(!CanSendTelemetry))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 29365, 29442);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 29420, 29427);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 29365, 29442);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 29458, 29508);

                var
                properties = f_1044_29475_29507()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 29762, 29846);

                var
                channel = f_1044_29776_29845("POWERSHELL_DISTRIBUTION_CHANNEL")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 29862, 29903);

                f_1044_29862_29902(
                            properties, "SessionId", f_1044_29890_29901());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 29917, 29964);

                f_1044_29917_29963(properties, "UUID", f_1044_29940_29962());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 29978, 30035);

                f_1044_29978_30034(properties, "GitCommitID", f_1044_30008_30033());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 30049, 30115);

                f_1044_30049_30114(properties, "OSDescription", f_1044_30081_30113());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 30129, 30210);

                f_1044_30129_30209(properties, "OSChannel", (DynAbs.Tracing.TraceSender.Conditional_F1(1044, 30157, 30186) || ((f_1044_30157_30186(channel) && DynAbs.Tracing.TraceSender.Conditional_F2(1044, 30189, 30198)) || DynAbs.Tracing.TraceSender.Conditional_F3(1044, 30201, 30208))) ? "unknown" : channel);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 30224, 30299);

                f_1044_30224_30298(properties, "StartMode", (DynAbs.Tracing.TraceSender.Conditional_F1(1044, 30252, 30278) || ((f_1044_30252_30278(mode) && DynAbs.Tracing.TraceSender.Conditional_F2(1044, 30281, 30290)) || DynAbs.Tracing.TraceSender.Conditional_F3(1044, 30293, 30297))) ? "unknown" : mode);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 30349, 30418);

                    f_1044_30349_30417(f_1044_30349_30366(), "ConsoleHostStartup", properties, null);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1044, 30447, 30539);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1044, 30447, 30539);
                    // do nothing, telemetry cannot be sent
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1044, 29083, 30550);

                int
                f_1044_29231_29288(ref int
                location1, int
                value, int
                comparand)
                {
                    var return_v = Interlocked.CompareExchange(ref location1, value, comparand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 29231, 29288);
                    return return_v;
                }


                bool
                f_1044_29369_29386_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 29369, 29386);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, string>
                f_1044_29475_29507()
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 29475, 29507);
                    return return_v;
                }


                string?
                f_1044_29776_29845(string
                variable)
                {
                    var return_v = Environment.GetEnvironmentVariable(variable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 29776, 29845);
                    return return_v;
                }


                string
                f_1044_29890_29901()
                {
                    var return_v = s_sessionId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 29890, 29901);
                    return return_v;
                }


                int
                f_1044_29862_29902(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key, string
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 29862, 29902);
                    return 0;
                }


                string
                f_1044_29940_29962()
                {
                    var return_v = s_uniqueUserIdentifier;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 29940, 29962);
                    return return_v;
                }


                int
                f_1044_29917_29963(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key, string
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 29917, 29963);
                    return 0;
                }


                string
                f_1044_30008_30033()
                {
                    var return_v = PSVersionInfo.GitCommitId;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 30008, 30033);
                    return return_v;
                }


                int
                f_1044_29978_30034(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key, string
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 29978, 30034);
                    return 0;
                }


                string
                f_1044_30081_30113()
                {
                    var return_v = RuntimeInformation.OSDescription;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 30081, 30113);
                    return return_v;
                }


                int
                f_1044_30049_30114(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key, string
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 30049, 30114);
                    return 0;
                }


                bool
                f_1044_30157_30186(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 30157, 30186);
                    return return_v;
                }


                int
                f_1044_30129_30209(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key, string
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 30129, 30209);
                    return 0;
                }


                bool
                f_1044_30252_30278(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 30252, 30278);
                    return return_v;
                }


                int
                f_1044_30224_30298(System.Collections.Generic.Dictionary<string, string>
                this_param, string
                key, string
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 30224, 30298);
                    return 0;
                }


                Microsoft.ApplicationInsights.TelemetryClient
                f_1044_30349_30366()
                {
                    var return_v = s_telemetryClient;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 30349, 30366);
                    return return_v;
                }


                int
                f_1044_30349_30417(Microsoft.ApplicationInsights.TelemetryClient
                this_param, string
                eventName, System.Collections.Generic.Dictionary<string, string>
                properties, System.Collections.Generic.IDictionary<string, double>
                metrics)
                {
                    this_param.TrackEvent(eventName, (System.Collections.Generic.IDictionary<string, string>)properties, metrics);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 30349, 30417);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1044, 29083, 30550);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1044, 29083, 30550);
            }
        }

        private static bool TryGetIdentifier(string telemetryFilePath, out Guid id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1044, 30946, 32242);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 31046, 32172) || true) && (f_1044_31050_31080(telemetryFilePath))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 31046, 32172);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 31175, 31199);

                    const int
                    GuidSize = 16
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 31217, 31252);

                    byte[]
                    buffer = new byte[GuidSize]
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 31314, 31966);
                        using (FileStream
                        fs = f_1044_31337_31402(telemetryFilePath, FileMode.Open, FileAccess.Read)
                        )
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 31532, 31569);

                            int
                            n = f_1044_31540_31568(fs, buffer, 0, GuidSize)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 31595, 31943) || true) && (n == GuidSize)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 31595, 31943);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 31735, 31757);

                                id = f_1044_31740_31756(buffer);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 31787, 31916) || true) && (id != Guid.Empty)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 31787, 31916);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 31873, 31885);

                                    return true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 31787, 31916);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 31595, 31943);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitUsing(1044, 31314, 31966);
                        }
                    }
                    catch
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1044, 32003, 32157);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1044, 32003, 32157);
                        // something went wrong, the file may not exist or not have enough bytes, so return false
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 31046, 32172);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 32188, 32204);

                id = Guid.Empty;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 32218, 32231);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1044, 30946, 32242);

                bool
                f_1044_31050_31080(string
                path)
                {
                    var return_v = File.Exists(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 31050, 31080);
                    return return_v;
                }


                System.IO.FileStream
                f_1044_31337_31402(string
                path, System.IO.FileMode
                mode, System.IO.FileAccess
                access)
                {
                    var return_v = new System.IO.FileStream(path, mode, access);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 31337, 31402);
                    return return_v;
                }


                int
                f_1044_31540_31568(System.IO.FileStream
                this_param, byte[]
                array, int
                offset, int
                count)
                {
                    var return_v = this_param.Read(array, offset, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 31540, 31568);
                    return return_v;
                }


                System.Guid
                f_1044_31740_31756(byte[]
                b)
                {
                    var return_v = new System.Guid(b);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 31740, 31756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1044, 30946, 32242);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1044, 30946, 32242);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TryCreateUniqueIdentifierAndFile(string telemetryFilePath, out Guid id)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1044, 32689, 34513);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 32925, 32941);

                id = Guid.Empty;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 32955, 33063) || true) && (f_1044_32959_33002(telemetryFilePath, out id))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 32955, 33063);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 33036, 33048);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 32955, 33063);
                }

                // The directory may not exist, so attempt to create it
                // CreateDirectory will simply return the directory if exists
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 33259, 33327);

                    f_1044_33259_33326(f_1044_33285_33325(telemetryFilePath));
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1044, 33356, 33935);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 33763, 33788);

                    CanSendTelemetry = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 33806, 33889);

                    f_1044_33806_33888(f_1044_33806_33862(f_1044_33806_33823(), _telemetryFailure, "Detail"), 1, "cachedir");
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 33907, 33920);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1044, 33356, 33935);
                }

                // Create and save the new identifier, and if there's a problem, disable telemetry
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 34083, 34103);

                    id = Guid.NewGuid();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 34121, 34177);

                    f_1044_34121_34176(telemetryFilePath, id.ToByteArray());
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 34195, 34207);

                    return true;
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1044, 34236, 34473);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 34375, 34458);

                    f_1044_34375_34457(f_1044_34375_34431(f_1044_34375_34392(), _telemetryFailure, "Detail"), 1, "saveuuid");
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1044, 34236, 34473);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 34489, 34502);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1044, 32689, 34513);

                bool
                f_1044_32959_33002(string
                telemetryFilePath, out System.Guid
                id)
                {
                    var return_v = TryGetIdentifier(telemetryFilePath, out id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 32959, 33002);
                    return return_v;
                }


                string?
                f_1044_33285_33325(string
                path)
                {
                    var return_v = Path.GetDirectoryName(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 33285, 33325);
                    return return_v;
                }


                System.IO.DirectoryInfo
                f_1044_33259_33326(string
                path)
                {
                    var return_v = Directory.CreateDirectory(path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 33259, 33326);
                    return return_v;
                }


                Microsoft.ApplicationInsights.TelemetryClient
                f_1044_33806_33823()
                {
                    var return_v = s_telemetryClient;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 33806, 33823);
                    return return_v;
                }


                Microsoft.ApplicationInsights.Metric
                f_1044_33806_33862(Microsoft.ApplicationInsights.TelemetryClient
                this_param, string
                metricId, string
                dimension1Name)
                {
                    var return_v = this_param.GetMetric(metricId, dimension1Name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 33806, 33862);
                    return return_v;
                }


                bool
                f_1044_33806_33888(Microsoft.ApplicationInsights.Metric
                this_param, int
                metricValue, string
                dimension1Value)
                {
                    var return_v = this_param.TrackValue((double)metricValue, dimension1Value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 33806, 33888);
                    return return_v;
                }


                int
                f_1044_34121_34176(string
                path, byte[]
                bytes)
                {
                    File.WriteAllBytes(path, bytes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 34121, 34176);
                    return 0;
                }


                Microsoft.ApplicationInsights.TelemetryClient
                f_1044_34375_34392()
                {
                    var return_v =                 // another bit of telemetry to notify us about a problem with saving the unique id.
                                    s_telemetryClient;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 34375, 34392);
                    return return_v;
                }


                Microsoft.ApplicationInsights.Metric
                f_1044_34375_34431(Microsoft.ApplicationInsights.TelemetryClient
                this_param, string
                metricId, string
                dimension1Name)
                {
                    var return_v = this_param.GetMetric(metricId, dimension1Name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 34375, 34431);
                    return return_v;
                }


                bool
                f_1044_34375_34457(Microsoft.ApplicationInsights.Metric
                this_param, int
                metricValue, string
                dimension1Value)
                {
                    var return_v = this_param.TrackValue((double)metricValue, dimension1Value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 34375, 34457);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1044, 32689, 34513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1044, 32689, 34513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static Guid GetUniqueIdentifier()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1044, 34812, 36608);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 35034, 35055);

                Guid
                id = Guid.Empty
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 35069, 35140);

                string
                uuidPath = f_1044_35087_35139(Platform.CacheDirectory, "telemetry.uuid")
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 35154, 35251) || true) && (f_1044_35158_35192(uuidPath, out id))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 35154, 35251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 35226, 35236);

                    return id;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 35154, 35251);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 35549, 36441);
                using (var
                m = f_1044_35564_35601(true, "CreateUniqueUserId")
                )
                {
                    // TryCreateUniqueIdentifierAndFile shouldn't throw, but the mutex might
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 35769, 35781);

                        f_1044_35769_35780(m);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 35803, 35940) || true) && (f_1044_35807_35857(uuidPath, out id))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1044, 35803, 35940);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 35907, 35917);

                            return id;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1044, 35803, 35940);
                        }
                    }
                    catch (Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1044, 35977, 36324);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 36225, 36305);

                        f_1044_36225_36304(f_1044_36225_36281(f_1044_36225_36242(), _telemetryFailure, "Detail"), 1, "mutex");
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1044, 35977, 36324);
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterFinally(1044, 36342, 36426);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 36390, 36407);

                        f_1044_36390_36406(m);
                        DynAbs.Tracing.TraceSender.TraceExitFinally(1044, 36342, 36426);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1044, 35549, 36441);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 36548, 36573);

                CanSendTelemetry = false;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1044, 36587, 36597);

                return id;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1044, 34812, 36608);

                string
                f_1044_35087_35139(string
                path1, string
                path2)
                {
                    var return_v = Path.Join(path1, path2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 35087, 35139);
                    return return_v;
                }


                bool
                f_1044_35158_35192(string
                telemetryFilePath, out System.Guid
                id)
                {
                    var return_v = TryGetIdentifier(telemetryFilePath, out id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 35158, 35192);
                    return return_v;
                }


                System.Threading.Mutex
                f_1044_35564_35601(bool
                initiallyOwned, string
                name)
                {
                    var return_v = new System.Threading.Mutex(initiallyOwned, name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 35564, 35601);
                    return return_v;
                }


                bool
                f_1044_35769_35780(System.Threading.Mutex
                this_param)
                {
                    var return_v = this_param.WaitOne();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 35769, 35780);
                    return return_v;
                }


                bool
                f_1044_35807_35857(string
                telemetryFilePath, out System.Guid
                id)
                {
                    var return_v = TryCreateUniqueIdentifierAndFile(telemetryFilePath, out id);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 35807, 35857);
                    return return_v;
                }


                Microsoft.ApplicationInsights.TelemetryClient
                f_1044_36225_36242()
                {
                    var return_v =                     // Any problem in generating a uuid will result in no telemetry being sent.
                                                       // Try to send the failure in telemetry, but it will have no unique id.
                                        s_telemetryClient;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 36225, 36242);
                    return return_v;
                }


                Microsoft.ApplicationInsights.Metric
                f_1044_36225_36281(Microsoft.ApplicationInsights.TelemetryClient
                this_param, string
                metricId, string
                dimension1Name)
                {
                    var return_v = this_param.GetMetric(metricId, dimension1Name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 36225, 36281);
                    return return_v;
                }


                bool
                f_1044_36225_36304(Microsoft.ApplicationInsights.Metric
                this_param, int
                metricValue, string
                dimension1Value)
                {
                    var return_v = this_param.TrackValue((double)metricValue, dimension1Value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 36225, 36304);
                    return return_v;
                }


                int
                f_1044_36390_36406(System.Threading.Mutex
                this_param)
                {
                    this_param.ReleaseMutex();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 36390, 36406);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1044, 34812, 36608);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1044, 34812, 36608);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static bool
        f_1044_4442_4521(string
        name, bool
        defaultValue)
        {
            var return_v = GetEnvironmentVariableAsBool(name: name, defaultValue: defaultValue);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 4442, 4521);
            return return_v;
        }


        static bool
        f_1044_4540_4556()
        {
            var return_v = CanSendTelemetry;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 4540, 4556);
            return return_v;
        }


        static Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration
        f_1044_4629_4667()
        {
            var return_v = TelemetryConfiguration.CreateDefault();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 4629, 4667);
            return return_v;
        }


        static Microsoft.ApplicationInsights.Channel.ITelemetryChannel
        f_1044_4835_4865(Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration
        this_param)
        {
            var return_v = this_param.TelemetryChannel;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 4835, 4865);
            return return_v;
        }


        static Microsoft.ApplicationInsights.TelemetryClient
        f_1044_4928_4962(Microsoft.ApplicationInsights.Extensibility.TelemetryConfiguration
        configuration)
        {
            var return_v = new Microsoft.ApplicationInsights.TelemetryClient(configuration);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 4928, 4962);
            return return_v;
        }


        static System.StringComparer
        f_1044_5189_5221()
        {
            var return_v = StringComparer.OrdinalIgnoreCase;
            DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1044, 5189, 5221);
            return return_v;
        }


        static System.Guid
        f_1044_24327_24348()
        {
            var return_v = GetUniqueIdentifier();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1044, 24327, 24348);
            return return_v;
        }

    }
}
