// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation.Runspaces
{
    internal sealed class DotNetTypes_Format_Ps1Xml
    {
        internal static IEnumerable<ExtendedTypeDefinition> GetFormatData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 258, 15656);

                var listYield = new List<ExtendedTypeDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 350, 515);

                listYield.Add(f_1104_363_514("System.CodeDom.Compiler.CompilerError", f_1104_466_513()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 531, 674);

                listYield.Add(f_1104_544_673("System.Reflection.Assembly", f_1104_636_672()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 690, 841);

                listYield.Add(f_1104_703_840("System.Reflection.AssemblyName", f_1104_799_839()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 857, 1012);

                listYield.Add(f_1104_870_1011("System.Globalization.CultureInfo", f_1104_968_1010()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 1028, 1187);

                listYield.Add(f_1104_1041_1186("System.Diagnostics.FileVersionInfo", f_1104_1141_1185()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 1203, 1358);

                listYield.Add(f_1104_1216_1357("System.Diagnostics.EventLogEntry", f_1104_1314_1356()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 1374, 1519);

                listYield.Add(f_1104_1387_1518("System.Diagnostics.EventLog", f_1104_1480_1517()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 1535, 1654);

                listYield.Add(f_1104_1548_1653("System.Version", f_1104_1628_1652()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 1670, 1813);

                listYield.Add(f_1104_1683_1812("System.Version#IncludeLabel", f_1104_1776_1811()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 1829, 1991);

                listYield.Add(f_1104_1842_1990("System.Management.Automation.SemanticVersion", f_1104_1952_1989()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 2007, 2172);

                listYield.Add(f_1104_2020_2171("System.Drawing.Printing.PrintDocument", f_1104_2123_2170()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 2188, 2347);

                listYield.Add(f_1104_2201_2346("System.Collections.DictionaryEntry", f_1104_2301_2345()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 2363, 2518);

                listYield.Add(f_1104_2376_2517("System.Diagnostics.ProcessModule", f_1104_2474_2516()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 2534, 2677);

                listYield.Add(f_1104_2547_2676("System.Diagnostics.Process", f_1104_2639_2675()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 2693, 2868);

                listYield.Add(f_1104_2706_2867("System.Diagnostics.Process#IncludeUserName", f_1104_2814_2866()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 2884, 3053);

                listYield.Add(f_1104_2897_3052("System.DirectoryServices.DirectoryEntry", f_1104_3002_3051()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 3069, 3242);

                listYield.Add(f_1104_3082_3241("System.Management.Automation.PSSnapInInfo", f_1104_3189_3240()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 3258, 3427);

                listYield.Add(f_1104_3271_3426("System.ServiceProcess.ServiceController", f_1104_3376_3425()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 3443, 3564);

                listYield.Add(f_1104_3456_3563("System.TimeSpan", f_1104_3537_3562()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 3580, 3703);

                listYield.Add(f_1104_3593_3702("System.AppDomain", f_1104_3675_3701()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 3719, 3840);

                listYield.Add(f_1104_3732_3839("System.DateTime", f_1104_3813_3838()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 3856, 4035);

                listYield.Add(f_1104_3869_4034("System.Security.AccessControl.ObjectSecurity", f_1104_3979_4033()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 4051, 4208);

                listYield.Add(f_1104_4064_4207("System.Management.ManagementClass", f_1104_4163_4206()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 4224, 4403);

                listYield.Add(f_1104_4237_4402("Microsoft.Management.Infrastructure.CimClass", f_1104_4347_4401()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 4419, 4532);

                listYield.Add(f_1104_4432_4531("System.Guid", f_1104_4509_4530()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 4548, 4764);

                listYield.Add(f_1104_4561_4763(@"System.Management.ManagementObject#root\cimv2\Win32_PingStatus", f_1104_4690_4762()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 4780, 5021);

                listYield.Add(f_1104_4793_5020("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_PingStatus", f_1104_4934_5019()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 5037, 5251);

                listYield.Add(f_1104_5050_5250(@"System.Management.ManagementObject#root\default\SystemRestore", f_1104_5178_5249()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 5267, 5506);

                listYield.Add(f_1104_5280_5505("Microsoft.Management.Infrastructure.CimInstance#root/default/SystemRestore", f_1104_5420_5504()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 5522, 5756);

                listYield.Add(f_1104_5535_5755(@"System.Management.ManagementObject#root\cimv2\Win32_QuickFixEngineering", f_1104_5673_5754()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 5772, 6031);

                listYield.Add(f_1104_5785_6030("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_QuickFixEngineering", f_1104_5935_6029()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 6047, 6282);

                listYield.Add(f_1104_6060_6281("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_Process", f_1104_6198_6280()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 6298, 6547);

                listYield.Add(f_1104_6311_6546("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_ComputerSystem", f_1104_6456_6545()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 6563, 6802);

                listYield.Add(f_1104_6576_6801("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/WIN32_PROCESSOR", f_1104_6716_6800()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 6818, 7069);

                listYield.Add(f_1104_6831_7068("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/WIN32_DCOMApplication", f_1104_6977_7067()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 7085, 7320);

                listYield.Add(f_1104_7098_7319("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/WIN32_DESKTOP", f_1104_7236_7318()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 7336, 7585);

                listYield.Add(f_1104_7349_7584("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/WIN32_DESKTOPMONITOR", f_1104_7494_7583()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 7601, 7860);

                listYield.Add(f_1104_7614_7859("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_DeviceMemoryAddress", f_1104_7764_7858()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 7876, 8115);

                listYield.Add(f_1104_7889_8114("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_DiskDrive", f_1104_8029_8113()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 8131, 8370);

                listYield.Add(f_1104_8144_8369("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_DiskQuota", f_1104_8284_8368()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 8386, 8629);

                listYield.Add(f_1104_8399_8628("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_Environment", f_1104_8541_8627()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 8645, 8884);

                listYield.Add(f_1104_8658_8883("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_Directory", f_1104_8798_8882()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 8900, 9131);

                listYield.Add(f_1104_8913_9130("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_Group", f_1104_9049_9129()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 9147, 9394);

                listYield.Add(f_1104_9160_9393("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_IDEController", f_1104_9304_9392()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 9410, 9653);

                listYield.Add(f_1104_9423_9652("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_IRQResource", f_1104_9565_9651()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 9669, 9914);

                listYield.Add(f_1104_9682_9913("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_ScheduledJob", f_1104_9825_9912()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 9930, 10179);

                listYield.Add(f_1104_9943_10178("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_LoadOrderGroup", f_1104_10088_10177()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 10195, 10438);

                listYield.Add(f_1104_10208_10437("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_LogicalDisk", f_1104_10350_10436()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 10454, 10699);

                listYield.Add(f_1104_10467_10698("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_LogonSession", f_1104_10610_10697()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 10715, 10974);

                listYield.Add(f_1104_10728_10973("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_PhysicalMemoryArray", f_1104_10878_10972()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 10990, 11237);

                listYield.Add(f_1104_11003_11236("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_OnBoardDevice", f_1104_11147_11235()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 11253, 11504);

                listYield.Add(f_1104_11266_11503("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_OperatingSystem", f_1104_11412_11502()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 11520, 11767);

                listYield.Add(f_1104_11533_11766("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_DiskPartition", f_1104_11677_11765()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 11783, 12030);

                listYield.Add(f_1104_11796_12029("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_PortConnector", f_1104_11940_12028()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 12046, 12291);

                listYield.Add(f_1104_12059_12290("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_QuotaSetting", f_1104_12202_12289()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 12307, 12556);

                listYield.Add(f_1104_12320_12555("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_SCSIController", f_1104_12465_12554()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 12572, 12807);

                listYield.Add(f_1104_12585_12806("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_Service", f_1104_12723_12805()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 12823, 13066);

                listYield.Add(f_1104_12836_13065("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_UserAccount", f_1104_12978_13064()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 13082, 13333);

                listYield.Add(f_1104_13095_13332("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_NetworkProtocol", f_1104_13241_13331()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 13349, 13598);

                listYield.Add(f_1104_13362_13597("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_NetworkAdapter", f_1104_13507_13596()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 13614, 13889);

                listYield.Add(f_1104_13627_13888("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_NetworkAdapterConfiguration", f_1104_13785_13887()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 13905, 14142);

                listYield.Add(f_1104_13918_14141("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_NTDomain", f_1104_14057_14140()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 14158, 14393);

                listYield.Add(f_1104_14171_14392("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_Printer", f_1104_14309_14391()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 14409, 14646);

                listYield.Add(f_1104_14422_14645("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_PrintJob", f_1104_14561_14644()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 14662, 14897);

                listYield.Add(f_1104_14675_14896("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_Product", f_1104_14813_14895()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 14913, 15060);

                listYield.Add(f_1104_14926_15059("System.Net.NetworkCredential", f_1104_15020_15058()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 15076, 15241);

                listYield.Add(f_1104_15089_15240("System.Management.Automation.PSMethod", f_1104_15192_15239()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 15257, 15484);

                listYield.Add(f_1104_15270_15483("Microsoft.Management.Infrastructure.CimInstance#__PartialCIMInstance", f_1104_15404_15482()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 15500, 15645);

                listYield.Add(f_1104_15513_15644("System.Threading.Tasks.Task", f_1104_15606_15643()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 258, 15656);

                return listYield;

                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_466_513()
                {
                    var return_v = ViewsOf_System_CodeDom_Compiler_CompilerError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 466, 513);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_363_514(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 363, 514);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_636_672()
                {
                    var return_v = ViewsOf_System_Reflection_Assembly();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 636, 672);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_544_673(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 544, 673);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_799_839()
                {
                    var return_v = ViewsOf_System_Reflection_AssemblyName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 799, 839);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_703_840(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 703, 840);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_968_1010()
                {
                    var return_v = ViewsOf_System_Globalization_CultureInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 968, 1010);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_870_1011(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 870, 1011);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_1141_1185()
                {
                    var return_v = ViewsOf_System_Diagnostics_FileVersionInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 1141, 1185);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_1041_1186(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 1041, 1186);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_1314_1356()
                {
                    var return_v = ViewsOf_System_Diagnostics_EventLogEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 1314, 1356);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_1216_1357(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 1216, 1357);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_1480_1517()
                {
                    var return_v = ViewsOf_System_Diagnostics_EventLog();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 1480, 1517);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_1387_1518(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 1387, 1518);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_1628_1652()
                {
                    var return_v = ViewsOf_System_Version();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 1628, 1652);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_1548_1653(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 1548, 1653);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_1776_1811()
                {
                    var return_v = ViewsOf_System_Version_With_Label();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 1776, 1811);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_1683_1812(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 1683, 1812);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_1952_1989()
                {
                    var return_v = ViewsOf_Semantic_Version_With_Label();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 1952, 1989);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_1842_1990(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 1842, 1990);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_2123_2170()
                {
                    var return_v = ViewsOf_System_Drawing_Printing_PrintDocument();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 2123, 2170);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_2020_2171(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 2020, 2171);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_2301_2345()
                {
                    var return_v = ViewsOf_System_Collections_DictionaryEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 2301, 2345);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_2201_2346(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 2201, 2346);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_2474_2516()
                {
                    var return_v = ViewsOf_System_Diagnostics_ProcessModule();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 2474, 2516);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_2376_2517(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 2376, 2517);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_2639_2675()
                {
                    var return_v = ViewsOf_System_Diagnostics_Process();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 2639, 2675);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_2547_2676(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 2547, 2676);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_2814_2866()
                {
                    var return_v = ViewsOf_System_Diagnostics_Process_IncludeUserName();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 2814, 2866);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_2706_2867(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 2706, 2867);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_3002_3051()
                {
                    var return_v = ViewsOf_System_DirectoryServices_DirectoryEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 3002, 3051);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_2897_3052(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 2897, 3052);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_3189_3240()
                {
                    var return_v = ViewsOf_System_Management_Automation_PSSnapInInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 3189, 3240);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_3082_3241(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 3082, 3241);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_3376_3425()
                {
                    var return_v = ViewsOf_System_ServiceProcess_ServiceController();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 3376, 3425);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_3271_3426(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 3271, 3426);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_3537_3562()
                {
                    var return_v = ViewsOf_System_TimeSpan();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 3537, 3562);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_3456_3563(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 3456, 3563);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_3675_3701()
                {
                    var return_v = ViewsOf_System_AppDomain();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 3675, 3701);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_3593_3702(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 3593, 3702);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_3813_3838()
                {
                    var return_v = ViewsOf_System_DateTime();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 3813, 3838);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_3732_3839(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 3732, 3839);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_3979_4033()
                {
                    var return_v = ViewsOf_System_Security_AccessControl_ObjectSecurity();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 3979, 4033);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_3869_4034(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 3869, 4034);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_4163_4206()
                {
                    var return_v = ViewsOf_System_Management_ManagementClass();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 4163, 4206);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_4064_4207(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 4064, 4207);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_4347_4401()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimClass();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 4347, 4401);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_4237_4402(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 4237, 4402);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_4509_4530()
                {
                    var return_v = ViewsOf_System_Guid();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 4509, 4530);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_4432_4531(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 4432, 4531);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_4690_4762()
                {
                    var return_v = ViewsOf_System_Management_ManagementObject_root_cimv2_Win32_PingStatus();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 4690, 4762);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_4561_4763(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 4561, 4763);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_4934_5019()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_PingStatus();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 4934, 5019);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_4793_5020(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 4793, 5020);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_5178_5249()
                {
                    var return_v = ViewsOf_System_Management_ManagementObject_root_default_SystemRestore();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 5178, 5249);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_5050_5250(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 5050, 5250);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_5420_5504()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_default_SystemRestore();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 5420, 5504);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_5280_5505(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 5280, 5505);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_5673_5754()
                {
                    var return_v = ViewsOf_System_Management_ManagementObject_root_cimv2_Win32_QuickFixEngineering();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 5673, 5754);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_5535_5755(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 5535, 5755);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_5935_6029()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_QuickFixEngineering();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 5935, 6029);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_5785_6030(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 5785, 6030);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_6198_6280()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_Process();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 6198, 6280);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_6060_6281(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 6060, 6281);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_6456_6545()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_ComputerSystem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 6456, 6545);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_6311_6546(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 6311, 6546);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_6716_6800()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_WIN32_PROCESSOR();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 6716, 6800);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_6576_6801(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 6576, 6801);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_6977_7067()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_WIN32_DCOMApplication();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 6977, 7067);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_6831_7068(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 6831, 7068);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_7236_7318()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_WIN32_DESKTOP();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 7236, 7318);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_7098_7319(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 7098, 7319);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_7494_7583()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_WIN32_DESKTOPMONITOR();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 7494, 7583);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_7349_7584(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 7349, 7584);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_7764_7858()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_DeviceMemoryAddress();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 7764, 7858);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_7614_7859(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 7614, 7859);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_8029_8113()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_DiskDrive();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 8029, 8113);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_7889_8114(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 7889, 8114);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_8284_8368()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_DiskQuota();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 8284, 8368);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_8144_8369(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 8144, 8369);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_8541_8627()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_Environment();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 8541, 8627);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_8399_8628(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 8399, 8628);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_8798_8882()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_Directory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 8798, 8882);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_8658_8883(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 8658, 8883);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_9049_9129()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_Group();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 9049, 9129);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_8913_9130(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 8913, 9130);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_9304_9392()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_IDEController();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 9304, 9392);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_9160_9393(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 9160, 9393);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_9565_9651()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_IRQResource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 9565, 9651);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_9423_9652(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 9423, 9652);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_9825_9912()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_ScheduledJob();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 9825, 9912);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_9682_9913(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 9682, 9913);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_10088_10177()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_LoadOrderGroup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 10088, 10177);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_9943_10178(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 9943, 10178);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_10350_10436()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_LogicalDisk();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 10350, 10436);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_10208_10437(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 10208, 10437);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_10610_10697()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_LogonSession();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 10610, 10697);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_10467_10698(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 10467, 10698);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_10878_10972()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_PhysicalMemoryArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 10878, 10972);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_10728_10973(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 10728, 10973);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_11147_11235()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_OnBoardDevice();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 11147, 11235);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_11003_11236(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 11003, 11236);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_11412_11502()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_OperatingSystem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 11412, 11502);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_11266_11503(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 11266, 11503);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_11677_11765()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_DiskPartition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 11677, 11765);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_11533_11766(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 11533, 11766);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_11940_12028()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_PortConnector();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 11940, 12028);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_11796_12029(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 11796, 12029);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_12202_12289()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_QuotaSetting();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 12202, 12289);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_12059_12290(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 12059, 12290);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_12465_12554()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_SCSIController();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 12465, 12554);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_12320_12555(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 12320, 12555);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_12723_12805()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_Service();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 12723, 12805);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_12585_12806(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 12585, 12806);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_12978_13064()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_UserAccount();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 12978, 13064);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_12836_13065(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 12836, 13065);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_13241_13331()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_NetworkProtocol();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 13241, 13331);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_13095_13332(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 13095, 13332);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_13507_13596()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_NetworkAdapter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 13507, 13596);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_13362_13597(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 13362, 13597);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_13785_13887()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_NetworkAdapterConfiguration();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 13785, 13887);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_13627_13888(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 13627, 13888);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_14057_14140()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_NTDomain();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 14057, 14140);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_13918_14141(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 13918, 14141);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_14309_14391()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_Printer();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 14309, 14391);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_14171_14392(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 14171, 14392);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_14561_14644()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_PrintJob();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 14561, 14644);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_14422_14645(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 14422, 14645);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_14813_14895()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_Product();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 14813, 14895);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_14675_14896(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 14675, 14896);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_15020_15058()
                {
                    var return_v = ViewsOf_System_Net_NetworkCredential();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15020, 15058);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_14926_15059(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 14926, 15059);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_15192_15239()
                {
                    var return_v = ViewsOf_System_Management_Automation_PSMethod();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15192, 15239);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_15089_15240(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15089, 15240);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_15404_15482()
                {
                    var return_v = ViewsOf_Microsoft_Management_Infrastructure_CimInstance___PartialCIMInstance();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15404, 15482);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_15270_15483(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15270, 15483);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1104_15606_15643()
                {
                    var return_v = ViewsOf_System_Threading_Tasks_Task();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15606, 15643);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1104_15513_15644(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15513, 15644);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 258, 15656);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 258, 15656);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_CodeDom_Compiler_CompilerError()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 15668, 16289);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 15789, 16278);

                listYield.Add(f_1104_15802_16277("System.CodeDom.Compiler.CompilerError", f_1104_15885_16276(f_1104_15885_16248(f_1104_15885_16215(f_1104_15885_16158(f_1104_15885_16100(f_1104_15885_16047(f_1104_15885_15996(f_1104_15885_15940(f_1104_15885_15905()), @"ErrorText"), @"Line"), @"Column"), @"ErrorNumber"), @"LineSource")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 15668, 16289);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1104_15885_15905()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15885, 15905);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_15885_15940(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15885, 15940);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_15885_15996(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15885, 15996);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_15885_16047(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15885, 16047);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_15885_16100(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15885, 16100);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_15885_16158(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15885, 16158);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_15885_16215(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15885, 16215);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_15885_16248(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15885, 16248);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1104_15885_16276(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15885, 16276);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_15802_16277(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 15802, 16277);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 15668, 16289);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 15668, 16289);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Reflection_Assembly()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 16301, 17991);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 16411, 16973);

                listYield.Add(f_1104_16424_16972("System.Reflection.Assembly", f_1104_16496_16971(f_1104_16496_16942(f_1104_16496_16901(f_1104_16496_16845(f_1104_16496_16778(f_1104_16496_16711(f_1104_16496_16668(f_1104_16496_16634(f_1104_16496_16573(f_1104_16496_16517(), label: "GAC", width: 6), label: "Version", width: 14))), "GlobalAssemblyCache"), "ImageRuntimeVersion"), "Location")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 16989, 17980);

                listYield.Add(f_1104_17002_17979("System.Reflection.Assembly", f_1104_17074_17978(f_1104_17074_17950(f_1104_17074_17917(f_1104_17074_17856(f_1104_17074_17787(f_1104_17074_17727(f_1104_17074_17666(f_1104_17074_17611(f_1104_17074_17545(f_1104_17074_17482(f_1104_17074_17424(f_1104_17074_17358(f_1104_17074_17303(f_1104_17074_17241(f_1104_17074_17184(f_1104_17074_17129(f_1104_17074_17094()), @"CodeBase"), @"EntryPoint"), @"EscapedCodeBase"), @"FullName"), @"GlobalAssemblyCache"), @"HostContext"), @"ImageFileMachine"), @"ImageRuntimeVersion"), @"Location"), @"ManifestModule"), @"MetadataToken"), @"PortableExecutableKind"), @"ReflectionOnly")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 16301, 17991);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_16496_16517()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 16496, 16517);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_16496_16573(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 16496, 16573);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_16496_16634(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 16496, 16634);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_16496_16668(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 16496, 16668);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_16496_16711(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 16496, 16711);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_16496_16778(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 16496, 16778);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_16496_16845(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 16496, 16845);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_16496_16901(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 16496, 16901);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_16496_16942(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 16496, 16942);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_16496_16971(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 16496, 16971);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_16424_16972(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 16424, 16972);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_17074_17094()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17094);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_17074_17129(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17129);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_17074_17184(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17184);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_17074_17241(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17241);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_17074_17303(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17303);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_17074_17358(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17358);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_17074_17424(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17424);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_17074_17482(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17482);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_17074_17545(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17545);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_17074_17611(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17611);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_17074_17666(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17666);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_17074_17727(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17727);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_17074_17787(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17787);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_17074_17856(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17856);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_17074_17917(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17917);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_17074_17950(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17950);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1104_17074_17978(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17074, 17978);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_17002_17979(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 17002, 17979);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 16301, 17991);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 16301, 17991);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Reflection_AssemblyName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 18003, 18537);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 18117, 18526);

                listYield.Add(f_1104_18130_18525("System.Reflection.AssemblyName", f_1104_18206_18524(f_1104_18206_18495(f_1104_18206_18454(f_1104_18206_18402(f_1104_18206_18347(f_1104_18206_18304(f_1104_18206_18270(f_1104_18206_18227(), width: 14))), "Version"), "Name")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 18003, 18537);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_18206_18227()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18206, 18227);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_18206_18270(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18206, 18270);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_18206_18304(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18206, 18304);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_18206_18347(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18206, 18347);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_18206_18402(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18206, 18402);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_18206_18454(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18206, 18454);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_18206_18495(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18206, 18495);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_18206_18524(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18206, 18524);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_18130_18525(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18130, 18525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 18003, 18537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 18003, 18537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Globalization_CultureInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 18549, 19186);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 18665, 19175);

                listYield.Add(f_1104_18678_19174("System.Globalization.CultureInfo", f_1104_18756_19173(f_1104_18756_19144(f_1104_18756_19103(f_1104_18756_19044(f_1104_18756_18992(f_1104_18756_18940(f_1104_18756_18897(f_1104_18756_18863(f_1104_18756_18820(f_1104_18756_18777(), width: 16), width: 16))), "LCID"), "Name"), "DisplayName")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 18549, 19186);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_18756_18777()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18756, 18777);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_18756_18820(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18756, 18820);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_18756_18863(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18756, 18863);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_18756_18897(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18756, 18897);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_18756_18940(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18756, 18940);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_18756_18992(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18756, 18992);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_18756_19044(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18756, 19044);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_18756_19103(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18756, 19103);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_18756_19144(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18756, 19144);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_18756_19173(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18756, 19173);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_18678_19174(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 18678, 19174);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 18549, 19186);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 18549, 19186);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Diagnostics_FileVersionInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 19198, 21262);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 19316, 19842);

                listYield.Add(f_1104_19329_19841("System.Diagnostics.FileVersionInfo", f_1104_19409_19840(f_1104_19409_19811(f_1104_19409_19770(f_1104_19409_19714(f_1104_19409_19655(f_1104_19409_19593(f_1104_19409_19550(f_1104_19409_19516(f_1104_19409_19473(f_1104_19409_19430(), width: 16), width: 16))), "ProductVersion"), "FileVersion"), "FileName")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 19858, 21251);

                listYield.Add(f_1104_19871_21250("System.Diagnostics.FileVersionInfo", f_1104_19951_21249(f_1104_19951_21221(f_1104_19951_21188(f_1104_19951_21124(f_1104_19951_21063(f_1104_19951_21004(f_1104_19951_20945(f_1104_19951_20883(f_1104_19951_20822(f_1104_19951_20767(f_1104_19951_20706(f_1104_19951_20645(f_1104_19951_20586(f_1104_19951_20530(f_1104_19951_20476(f_1104_19951_20415(f_1104_19951_20357(f_1104_19951_20302(f_1104_19951_20244(f_1104_19951_20189(f_1104_19951_20131(f_1104_19951_20069(f_1104_19951_20006(f_1104_19951_19971()), @"OriginalFileName"), @"FileDescription"), @"ProductName"), @"Comments"), @"CompanyName"), @"FileName"), @"FileVersion"), @"ProductVersion"), @"IsDebug"), @"IsPatched"), @"IsPreRelease"), @"IsPrivateBuild"), @"IsSpecialBuild"), @"Language"), @"LegalCopyright"), @"LegalTrademarks"), @"PrivateBuild"), @"SpecialBuild"), @"FileVersionRaw"), @"ProductVersionRaw")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 19198, 21262);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_19409_19430()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19409, 19430);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_19409_19473(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19409, 19473);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_19409_19516(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19409, 19516);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_19409_19550(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19409, 19550);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_19409_19593(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19409, 19593);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_19409_19655(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19409, 19655);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_19409_19714(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19409, 19714);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_19409_19770(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19409, 19770);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_19409_19811(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19409, 19811);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_19409_19840(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19409, 19840);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_19329_19841(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19329, 19841);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_19951_19971()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 19971);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20006(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20006);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20069(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20069);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20131(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20131);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20189(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20189);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20244(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20244);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20302(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20302);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20357(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20357);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20415(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20415);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20476(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20476);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20530(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20530);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20586(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20586);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20645(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20645);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20706(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20706);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20767(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20767);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20822(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20822);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20883(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20883);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_20945(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 20945);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_21004(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 21004);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_21063(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 21063);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_21124(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 21124);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_19951_21188(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 21188);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_19951_21221(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 21221);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1104_19951_21249(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19951, 21249);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_19871_21250(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 19871, 21250);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 19198, 21262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 19198, 21262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Diagnostics_EventLogEntry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 21274, 23250);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 21390, 22388);

                listYield.Add(f_1104_21403_22387("System.Diagnostics.EventLogEntry", f_1104_21481_22386(f_1104_21481_22357(f_1104_21481_22316(f_1104_21481_22261(f_1104_21481_22203(f_1104_21481_22149(f_1104_21481_22086(f_1104_21481_21985(f_1104_21481_21932(f_1104_21481_21889(f_1104_21481_21839(f_1104_21481_21758(f_1104_21481_21698(f_1104_21481_21635(f_1104_21481_21577(f_1104_21481_21502(), Alignment.Right, label: "Index", width: 8), label: "Time", width: 13), label: "EntryType", width: 11), label: "Source", width: 20), Alignment.Right, label: "InstanceID", width: 12), label: "Message")), "Index"), "TimeGenerated", format: "{0:MMM} {0:dd} {0:HH}:{0:mm}"), "$_.EntryType"), "Source"), "InstanceID"), "Message")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 22404, 23239);

                listYield.Add(f_1104_22417_23238("System.Diagnostics.EventLogEntry", f_1104_22495_23237(f_1104_22495_23209(f_1104_22495_23176(f_1104_22495_23121(f_1104_22495_23063(f_1104_22495_23003(f_1104_22495_22950(f_1104_22495_22885(f_1104_22495_22824(f_1104_22495_22769(f_1104_22495_22715(f_1104_22495_22658(f_1104_22495_22602(f_1104_22495_22550(f_1104_22495_22515()), @"Index"), @"EntryType"), @"InstanceID"), @"Message"), @"Category"), @"CategoryNumber"), @"ReplacementStrings"), @"Source"), @"TimeGenerated"), @"TimeWritten"), @"UserName")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 21274, 23250);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_21481_21502()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 21502);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_21481_21577(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 21577);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_21481_21635(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 21635);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_21481_21698(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 21698);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_21481_21758(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 21758);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_21481_21839(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 21839);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_21481_21889(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 21889);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_21481_21932(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 21932);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_21481_21985(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 21985);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_21481_22086(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName, string
                format)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName, format: format);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 22086);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_21481_22149(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 22149);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_21481_22203(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 22203);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_21481_22261(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 22261);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_21481_22316(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 22316);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_21481_22357(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 22357);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_21481_22386(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21481, 22386);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_21403_22387(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 21403, 22387);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_22495_22515()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 22515);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_22495_22550(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 22550);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_22495_22602(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 22602);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_22495_22658(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 22658);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_22495_22715(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 22715);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_22495_22769(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 22769);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_22495_22824(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 22824);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_22495_22885(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 22885);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_22495_22950(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 22950);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_22495_23003(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 23003);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_22495_23063(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 23063);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_22495_23121(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 23121);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_22495_23176(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 23176);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_22495_23209(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 23209);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1104_22495_23237(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22495, 23237);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_22417_23238(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 22417, 23238);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 21274, 23250);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 21274, 23250);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Diagnostics_EventLog()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 23262, 24825);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 23373, 24287);

                listYield.Add(f_1104_23386_24286("System.Diagnostics.EventLog", f_1104_23459_24285(f_1104_23459_24256(f_1104_23459_24215(f_1104_23459_24164(f_1104_23459_24082(f_1104_23459_24020(f_1104_23459_23952(f_1104_23459_23867(f_1104_23459_23824(f_1104_23459_23778(f_1104_23459_23700(f_1104_23459_23632(f_1104_23459_23556(f_1104_23459_23480(), Alignment.Right, label: "Max(K)", width: 8), Alignment.Right, label: "Retain", width: 6), label: "OverflowAction", width: 18), Alignment.Right, label: "Entries", width: 10), label: "Log")), "$_.MaximumKilobytes.ToString('N0')"), "MinimumRetentionDays"), "OverflowAction"), "$_.Entries.Count.ToString('N0')"), "Log")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 24303, 24814);

                listYield.Add(f_1104_24316_24813("System.Diagnostics.EventLog", f_1104_24389_24812(f_1104_24389_24784(f_1104_24389_24751(f_1104_24389_24690(f_1104_24389_24623(f_1104_24389_24560(f_1104_24389_24494(f_1104_24389_24444(f_1104_24389_24409()), @"Log"), @"EnableRaisingEvents"), @"MaximumKilobytes"), @"MinimumRetentionDays"), @"OverflowAction")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 23262, 24825);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_23459_23480()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23459, 23480);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_23459_23556(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23459, 23556);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_23459_23632(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23459, 23632);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_23459_23700(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23459, 23700);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_23459_23778(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23459, 23778);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_23459_23824(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23459, 23824);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_23459_23867(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23459, 23867);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_23459_23952(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23459, 23952);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_23459_24020(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23459, 24020);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_23459_24082(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23459, 24082);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_23459_24164(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23459, 24164);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_23459_24215(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23459, 24215);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_23459_24256(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23459, 24256);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_23459_24285(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23459, 24285);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_23386_24286(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 23386, 24286);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_24389_24409()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 24389, 24409);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_24389_24444(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 24389, 24444);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_24389_24494(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 24389, 24494);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_24389_24560(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 24389, 24560);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_24389_24623(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 24389, 24623);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_24389_24690(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 24389, 24690);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_24389_24751(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 24389, 24751);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_24389_24784(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 24389, 24784);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1104_24389_24812(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 24389, 24812);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_24316_24813(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 24316, 24813);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 23262, 24825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 23262, 24825);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Version()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 24837, 25538);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 24935, 25527);

                listYield.Add(f_1104_24948_25526("System.Version", f_1104_25008_25525(f_1104_25008_25496(f_1104_25008_25455(f_1104_25008_25399(f_1104_25008_25346(f_1104_25008_25293(f_1104_25008_25240(f_1104_25008_25197(f_1104_25008_25155(f_1104_25008_25113(f_1104_25008_25071(f_1104_25008_25029(), width: 6), width: 6), width: 6), width: 8)), "Major"), "Minor"), "Build"), "Revision")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 24837, 25538);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_25008_25029()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25008, 25029);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_25008_25071(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25008, 25071);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_25008_25113(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25008, 25113);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_25008_25155(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25008, 25155);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_25008_25197(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25008, 25197);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_25008_25240(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25008, 25240);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_25008_25293(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25008, 25293);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_25008_25346(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25008, 25346);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_25008_25399(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25008, 25399);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_25008_25455(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25008, 25455);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_25008_25496(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25008, 25496);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_25008_25525(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25008, 25525);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_24948_25526(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 24948, 25526);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 24837, 25538);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 24837, 25538);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Version_With_Label()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 25550, 26485);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 25659, 26474);

                listYield.Add(f_1104_25672_26473("System.Version", f_1104_25732_26472(f_1104_25732_26443(f_1104_25732_26402(f_1104_25732_26336(f_1104_25732_26265(f_1104_25732_26209(f_1104_25732_26156(f_1104_25732_26103(f_1104_25732_26050(f_1104_25732_26007(f_1104_25732_25964(f_1104_25732_25921(f_1104_25732_25879(f_1104_25732_25837(f_1104_25732_25795(f_1104_25732_25753(), width: 6), width: 6), width: 6), width: 8), width: 26), width: 27)), "Major"), "Minor"), "Build"), "Revision"), "PSSemVerPreReleaseLabel"), "PSSemVerBuildLabel")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 25550, 26485);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_25732_25753()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 25753);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_25732_25795(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 25795);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_25732_25837(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 25837);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_25732_25879(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 25879);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_25732_25921(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 25921);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_25732_25964(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 25964);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_25732_26007(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 26007);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_25732_26050(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 26050);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_25732_26103(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 26103);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_25732_26156(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 26156);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_25732_26209(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 26209);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_25732_26265(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 26265);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_25732_26336(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 26336);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_25732_26402(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 26402);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_25732_26443(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 26443);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_25732_26472(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25732, 26472);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_25672_26473(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 25672, 26473);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 25550, 26485);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 25550, 26485);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Semantic_Version_With_Label()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 26497, 27350);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 26608, 27339);

                listYield.Add(f_1104_26621_27338("System.Management.Automation.SemanticVersion", f_1104_26711_27337(f_1104_26711_27308(f_1104_26711_27267(f_1104_26711_27209(f_1104_26711_27146(f_1104_26711_27093(f_1104_26711_27040(f_1104_26711_26987(f_1104_26711_26944(f_1104_26711_26901(f_1104_26711_26858(f_1104_26711_26816(f_1104_26711_26774(f_1104_26711_26732(), width: 6), width: 6), width: 6), width: 15), width: 11)), "Major"), "Minor"), "Patch"), "PreReleaseLabel"), "BuildLabel")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 26497, 27350);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_26711_26732()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26711, 26732);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_26711_26774(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26711, 26774);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_26711_26816(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26711, 26816);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_26711_26858(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26711, 26858);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_26711_26901(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26711, 26901);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_26711_26944(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26711, 26944);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_26711_26987(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26711, 26987);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_26711_27040(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26711, 27040);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_26711_27093(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26711, 27093);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_26711_27146(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26711, 27146);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_26711_27209(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26711, 27209);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_26711_27267(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26711, 27267);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_26711_27308(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26711, 27308);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_26711_27337(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26711, 27337);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_26621_27338(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 26621, 27338);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 26497, 27350);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 26497, 27350);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Drawing_Printing_PrintDocument()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 27362, 28005);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 27483, 27994);

                listYield.Add(f_1104_27496_27993("System.Drawing.Printing.PrintDocument", f_1104_27579_27992(f_1104_27579_27963(f_1104_27579_27922(f_1104_27579_27870(f_1104_27579_27816(f_1104_27579_27763(f_1104_27579_27720(f_1104_27579_27686(f_1104_27579_27643(f_1104_27579_27600(), width: 10), width: 10))), "Color"), "Duplex"), "Name")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 27362, 28005);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_27579_27600()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 27579, 27600);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_27579_27643(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 27579, 27643);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_27579_27686(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 27579, 27686);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_27579_27720(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 27579, 27720);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_27579_27763(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 27579, 27763);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_27579_27816(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 27579, 27816);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_27579_27870(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 27579, 27870);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_27579_27922(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 27579, 27922);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_27579_27963(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 27579, 27963);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_27579_27992(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 27579, 27992);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_27496_27993(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 27496, 27993);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 27362, 28005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 27362, 28005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Collections_DictionaryEntry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 28017, 28863);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 28135, 28522);

                listYield.Add(f_1104_28148_28521("Dictionary", f_1104_28204_28520(f_1104_28204_28491(f_1104_28204_28450(f_1104_28204_28397(f_1104_28204_28345(f_1104_28204_28302(f_1104_28204_28268(f_1104_28204_28225(), width: 30))), "Name"), "Value")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 28538, 28852);

                listYield.Add(f_1104_28551_28851("System.Collections.DictionaryEntry", f_1104_28631_28850(f_1104_28631_28822(f_1104_28631_28789(f_1104_28631_28737(f_1104_28631_28686(f_1104_28631_28651()), @"Name"), @"Value")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 28017, 28863);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_28204_28225()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28204, 28225);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_28204_28268(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28204, 28268);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_28204_28302(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28204, 28302);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_28204_28345(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28204, 28345);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_28204_28397(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28204, 28397);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_28204_28450(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28204, 28450);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_28204_28491(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28204, 28491);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_28204_28520(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28204, 28520);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_28148_28521(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28148, 28521);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_28631_28651()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28631, 28651);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_28631_28686(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28631, 28686);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_28631_28737(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28631, 28737);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_28631_28789(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28631, 28789);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_28631_28822(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28631, 28822);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1104_28631_28850(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28631, 28850);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_28551_28851(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 28551, 28851);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 28017, 28863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 28017, 28863);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Diagnostics_ProcessModule()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 28875, 29537);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 28991, 29526);

                listYield.Add(f_1104_29004_29525("ProcessModule", f_1104_29063_29524(f_1104_29063_29495(f_1104_29063_29454(f_1104_29063_29398(f_1104_29063_29340(f_1104_29063_29282(f_1104_29063_29239(f_1104_29063_29205(f_1104_29063_29162(f_1104_29063_29084(), Alignment.Right, label: "Size(K)", width: 10), width: 50))), "$_.Size"), "ModuleName"), "FileName")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 28875, 29537);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_29063_29084()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29063, 29084);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_29063_29162(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29063, 29162);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_29063_29205(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29063, 29205);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_29063_29239(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29063, 29239);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_29063_29282(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29063, 29282);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_29063_29340(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29063, 29340);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_29063_29398(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29063, 29398);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_29063_29454(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29063, 29454);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_29063_29495(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29063, 29495);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_29063_29524(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29063, 29524);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_29004_29525(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29004, 29525);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 28875, 29537);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 28875, 29537);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Diagnostics_Process()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 29549, 32297);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 29659, 30798);

                listYield.Add(f_1104_29672_30797("process", f_1104_29725_30796(f_1104_29725_30767(f_1104_29725_30726(f_1104_29725_30667(f_1104_29725_30617(f_1104_29725_30567(f_1104_29725_30487(f_1104_29725_30402(f_1104_29725_30317(f_1104_29725_30245(f_1104_29725_30202(f_1104_29725_30168(f_1104_29725_30109(f_1104_29725_30050(f_1104_29725_29973(f_1104_29725_29897(f_1104_29725_29822(f_1104_29725_29746(), Alignment.Right, label: "NPM(K)", width: 7), Alignment.Right, label: "PM(M)", width: 8), Alignment.Right, label: "WS(M)", width: 10), Alignment.Right, label: "CPU(s)", width: 10), Alignment.Right, width: 7), Alignment.Right, width: 3))), "[long]($_.NPM / 1024)"), "\"{0:N2}\" -f [float]($_.PM / 1MB)"), "\"{0:N2}\" -f [float]($_.WS / 1MB)"), "\"{0:N2}\" -f [float]($_.CPU)"), "Id"), "SI"), "ProcessName")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 30812, 31426);

                listYield.Add(f_1104_30825_31425("Priority", f_1104_30879_31424(f_1104_30879_31395(f_1104_30879_31354(f_1104_30879_31294(f_1104_30879_31244(f_1104_30879_31185(f_1104_30879_31142(f_1104_30879_31082(f_1104_30879_31022(f_1104_30879_30979(f_1104_30879_30900(), "PriorityClass", label: "PriorityClass"), width: 20), Alignment.Right, width: 10), Alignment.Right, width: 12)), "ProcessName"), "Id"), "WorkingSet64")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 31440, 32093);

                listYield.Add(f_1104_31453_32092("StartTime", f_1104_31508_32091(f_1104_31508_32062(f_1104_31508_32021(f_1104_31508_31961(f_1104_31508_31911(f_1104_31508_31852(f_1104_31508_31809(f_1104_31508_31749(f_1104_31508_31689(f_1104_31508_31646(f_1104_31508_31529(), "$_.StartTime.ToShortDateString()", label: "StartTime.ToShortDateString()"), width: 20), Alignment.Right, width: 10), Alignment.Right, width: 12)), "ProcessName"), "Id"), "WorkingSet64")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 32109, 32286);

                listYield.Add(f_1104_32122_32285("process", f_1104_32175_32284(f_1104_32175_32249(f_1104_32175_32195(), "ProcessName"))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 29549, 32297);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_29725_29746()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 29746);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_29725_29822(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 29822);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_29725_29897(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 29897);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_29725_29973(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 29973);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_29725_30050(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 30050);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_29725_30109(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 30109);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_29725_30168(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 30168);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_29725_30202(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 30202);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_29725_30245(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 30245);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_29725_30317(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 30317);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_29725_30402(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 30402);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_29725_30487(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 30487);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_29725_30567(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 30567);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_29725_30617(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 30617);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_29725_30667(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 30667);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_29725_30726(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 30726);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_29725_30767(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 30767);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_29725_30796(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29725, 30796);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_29672_30797(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 29672, 30797);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_30879_30900()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 30879, 30900);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_30879_30979(System.Management.Automation.TableControlBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.GroupByProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 30879, 30979);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_30879_31022(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 30879, 31022);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_30879_31082(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 30879, 31082);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_30879_31142(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 30879, 31142);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_30879_31185(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 30879, 31185);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_30879_31244(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 30879, 31244);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_30879_31294(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 30879, 31294);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_30879_31354(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 30879, 31354);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_30879_31395(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 30879, 31395);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_30879_31424(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 30879, 31424);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_30825_31425(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 30825, 31425);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_31508_31529()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 31508, 31529);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_31508_31646(System.Management.Automation.TableControlBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.GroupByScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 31508, 31646);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_31508_31689(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 31508, 31689);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_31508_31749(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 31508, 31749);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_31508_31809(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 31508, 31809);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_31508_31852(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 31508, 31852);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_31508_31911(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 31508, 31911);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_31508_31961(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 31508, 31961);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_31508_32021(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 31508, 32021);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_31508_32062(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 31508, 32062);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_31508_32091(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 31508, 32091);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_31453_32092(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 31453, 32092);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1104_32175_32195()
                {
                    var return_v = WideControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32175, 32195);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1104_32175_32249(System.Management.Automation.WideControlBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyEntry(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32175, 32249);
                    return return_v;
                }


                System.Management.Automation.WideControl
                f_1104_32175_32284(System.Management.Automation.WideControlBuilder
                this_param)
                {
                    var return_v = this_param.EndWideControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32175, 32284);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_32122_32285(string
                name, System.Management.Automation.WideControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32122, 32285);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 29549, 32297);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 29549, 32297);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Diagnostics_Process_IncludeUserName()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 32309, 33278);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 32435, 33267);

                listYield.Add(f_1104_32448_33266("ProcessWithUserName", f_1104_32513_33265(f_1104_32513_33236(f_1104_32513_33195(f_1104_32513_33136(f_1104_32513_33080(f_1104_32513_33030(f_1104_32513_32950(f_1104_32513_32865(f_1104_32513_32822(f_1104_32513_32788(f_1104_32513_32745(f_1104_32513_32686(f_1104_32513_32610(f_1104_32513_32534(), Alignment.Right, label: "WS(M)", width: 10), Alignment.Right, label: "CPU(s)", width: 8), Alignment.Right, width: 7), width: 30))), "\"{0:N2}\" -f [float]($_.WS / 1MB)"), "\"{0:N2}\" -f [float]($_.CPU)"), "Id"), "UserName"), "ProcessName")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 32309, 33278);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_32513_32534()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32513, 32534);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_32513_32610(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32513, 32610);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_32513_32686(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32513, 32686);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_32513_32745(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32513, 32745);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_32513_32788(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32513, 32788);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_32513_32822(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32513, 32822);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_32513_32865(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32513, 32865);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_32513_32950(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32513, 32950);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_32513_33030(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32513, 33030);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_32513_33080(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32513, 33080);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_32513_33136(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32513, 33136);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_32513_33195(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32513, 33195);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_32513_33236(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32513, 33236);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_32513_33265(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32513, 33265);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_32448_33266(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 32448, 33266);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 32309, 33278);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 32309, 33278);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_DirectoryServices_DirectoryEntry()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 33290, 33773);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 33413, 33762);

                listYield.Add(f_1104_33426_33761("DirectoryEntry", f_1104_33486_33760(f_1104_33486_33732(f_1104_33486_33699(f_1104_33486_33633(f_1104_33486_33541(f_1104_33486_33506()), @"distinguishedName", label: "distinguishedName"), @"path", label: "Path")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 33290, 33773);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1104_33486_33506()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33486, 33506);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_33486_33541(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33486, 33541);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_33486_33633(System.Management.Automation.ListEntryBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.AddItemProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33486, 33633);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_33486_33699(System.Management.Automation.ListEntryBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.AddItemProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33486, 33699);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_33486_33732(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33486, 33732);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1104_33486_33760(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33486, 33760);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_33426_33761(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33426, 33761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 33290, 33773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 33290, 33773);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_PSSnapInInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 33785, 34955);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 33910, 34321);

                listYield.Add(f_1104_33923_34320("PSSnapInInfo", f_1104_33981_34319(f_1104_33981_34291(f_1104_33981_34258(f_1104_33981_34178(f_1104_33981_34102(f_1104_33981_34036(f_1104_33981_34001()), @"Name", label: "Name"), @"PSVersion", label: "PSVersion"), @"Description", label: "Description")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 34335, 34944);

                listYield.Add(f_1104_34348_34943("PSSnapInInfo", f_1104_34406_34942(f_1104_34406_34913(f_1104_34406_34872(f_1104_34406_34813(f_1104_34406_34756(f_1104_34406_34704(f_1104_34406_34661(f_1104_34406_34580(f_1104_34406_34501(f_1104_34406_34427(), Alignment.Left, label: "Name", width: 30), Alignment.Left, label: "PSVersion", width: 20), Alignment.Left, label: "Description", width: 30)), "Name"), "PSVersion"), "Description")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 33785, 34955);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1104_33981_34001()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33981, 34001);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_33981_34036(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33981, 34036);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_33981_34102(System.Management.Automation.ListEntryBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.AddItemProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33981, 34102);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_33981_34178(System.Management.Automation.ListEntryBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.AddItemProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33981, 34178);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_33981_34258(System.Management.Automation.ListEntryBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.AddItemProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33981, 34258);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_33981_34291(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33981, 34291);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1104_33981_34319(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33981, 34319);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_33923_34320(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 33923, 34320);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_34406_34427()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 34406, 34427);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_34406_34501(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 34406, 34501);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_34406_34580(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 34406, 34580);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_34406_34661(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 34406, 34661);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_34406_34704(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 34406, 34704);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_34406_34756(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 34406, 34756);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_34406_34813(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 34406, 34813);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_34406_34872(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 34406, 34872);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_34406_34913(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 34406, 34913);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_34406_34942(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 34406, 34942);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_34348_34943(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 34348, 34943);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 33785, 34955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 33785, 34955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_ServiceProcess_ServiceController()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 34967, 36355);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 35090, 35585);

                listYield.Add(f_1104_35103_35584("service", f_1104_35156_35583(f_1104_35156_35554(f_1104_35156_35513(f_1104_35156_35454(f_1104_35156_35402(f_1104_35156_35348(f_1104_35156_35305(f_1104_35156_35262(f_1104_35156_35219(f_1104_35156_35177(), width: 8), width: 18), width: 38)), "Status"), "Name"), "DisplayName")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 35601, 36344);

                listYield.Add(f_1104_35614_36343("System.ServiceProcess.ServiceController", f_1104_35699_36342(f_1104_35699_36314(f_1104_35699_36281(f_1104_35699_36223(f_1104_35699_36169(f_1104_35699_36111(f_1104_35699_36045(f_1104_35699_35980(f_1104_35699_35916(f_1104_35699_35863(f_1104_35699_35805(f_1104_35699_35754(f_1104_35699_35719()), @"Name"), @"DisplayName"), @"Status"), @"DependentServices"), @"ServicesDependedOn"), @"CanPauseAndContinue"), @"CanShutdown"), @"CanStop"), @"ServiceType")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 34967, 36355);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_35156_35177()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35156, 35177);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_35156_35219(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35156, 35219);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_35156_35262(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35156, 35262);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_35156_35305(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35156, 35305);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_35156_35348(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35156, 35348);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_35156_35402(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35156, 35402);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_35156_35454(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35156, 35454);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_35156_35513(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35156, 35513);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_35156_35554(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35156, 35554);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_35156_35583(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35156, 35583);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_35103_35584(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35103, 35584);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_35699_35719()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35699, 35719);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_35699_35754(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35699, 35754);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_35699_35805(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35699, 35805);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_35699_35863(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35699, 35863);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_35699_35916(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35699, 35916);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_35699_35980(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35699, 35980);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_35699_36045(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35699, 36045);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_35699_36111(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35699, 36111);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_35699_36169(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35699, 36169);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_35699_36223(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35699, 36223);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_35699_36281(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35699, 36281);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_35699_36314(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35699, 36314);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1104_35699_36342(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35699, 36342);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_35614_36343(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 35614, 36343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 34967, 36355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 34967, 36355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_TimeSpan()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 36367, 37992);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 36466, 37275);

                listYield.Add(f_1104_36479_37274("System.TimeSpan", f_1104_36540_37273(f_1104_36540_37245(f_1104_36540_37212(f_1104_36540_37148(f_1104_36540_37089(f_1104_36540_37030(f_1104_36540_36973(f_1104_36540_36917(f_1104_36540_36865(f_1104_36540_36806(f_1104_36540_36752(f_1104_36540_36698(f_1104_36540_36646(f_1104_36540_36595(f_1104_36540_36560()), @"Days"), @"Hours"), @"Minutes"), @"Seconds"), @"Milliseconds"), @"Ticks"), @"TotalDays"), @"TotalHours"), @"TotalMinutes"), @"TotalSeconds"), @"TotalMilliseconds")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 37289, 37774);

                listYield.Add(f_1104_37302_37773("System.TimeSpan", f_1104_37363_37772(f_1104_37363_37743(f_1104_37363_37702(f_1104_37363_37642(f_1104_37363_37587(f_1104_37363_37532(f_1104_37363_37479(f_1104_37363_37427(f_1104_37363_37384()), "Days"), "Hours"), "Minutes"), "Seconds"), "Milliseconds")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 37790, 37981);

                listYield.Add(f_1104_37803_37980("System.TimeSpan", f_1104_37864_37979(f_1104_37864_37944(f_1104_37864_37884(), "TotalMilliseconds"))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 36367, 37992);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1104_36540_36560()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 36560);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_36540_36595(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 36595);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_36540_36646(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 36646);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_36540_36698(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 36698);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_36540_36752(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 36752);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_36540_36806(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 36806);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_36540_36865(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 36865);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_36540_36917(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 36917);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_36540_36973(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 36973);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_36540_37030(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 37030);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_36540_37089(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 37089);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_36540_37148(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 37148);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_36540_37212(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 37212);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_36540_37245(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 37245);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1104_36540_37273(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36540, 37273);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_36479_37274(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 36479, 37274);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_37363_37384()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 37363, 37384);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_37363_37427(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 37363, 37427);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_37363_37479(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 37363, 37479);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_37363_37532(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 37363, 37532);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_37363_37587(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 37363, 37587);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_37363_37642(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 37363, 37642);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_37363_37702(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 37363, 37702);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_37363_37743(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 37363, 37743);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_37363_37772(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 37363, 37772);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_37302_37773(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 37302, 37773);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1104_37864_37884()
                {
                    var return_v = WideControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 37864, 37884);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1104_37864_37944(System.Management.Automation.WideControlBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyEntry(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 37864, 37944);
                    return return_v;
                }


                System.Management.Automation.WideControl
                f_1104_37864_37979(System.Management.Automation.WideControlBuilder
                this_param)
                {
                    var return_v = this_param.EndWideControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 37864, 37979);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_37803_37980(string
                name, System.Management.Automation.WideControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 37803, 37980);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 36367, 37992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 36367, 37992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_AppDomain()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 38004, 38798);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 38104, 38787);

                listYield.Add(f_1104_38117_38786("System.AppDomain", f_1104_38179_38785(f_1104_38179_38757(f_1104_38179_38724(f_1104_38179_38662(f_1104_38179_38599(f_1104_38179_38534(f_1104_38179_38471(f_1104_38179_38411(f_1104_38179_38342(f_1104_38179_38293(f_1104_38179_38234(f_1104_38179_38199()), @"FriendlyName"), @"Id"), @"ApplicationDescription"), @"BaseDirectory"), @"DynamicDirectory"), @"RelativeSearchPath"), @"SetupInformation"), @"ShadowCopyFiles")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 38004, 38798);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1104_38179_38199()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38179, 38199);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_38179_38234(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38179, 38234);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_38179_38293(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38179, 38293);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_38179_38342(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38179, 38342);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_38179_38411(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38179, 38411);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_38179_38471(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38179, 38471);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_38179_38534(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38179, 38534);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_38179_38599(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38179, 38599);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_38179_38662(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38179, 38662);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_38179_38724(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38179, 38724);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_38179_38757(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38179, 38757);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1104_38179_38785(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38179, 38785);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_38117_38786(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38117, 38786);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 38004, 38798);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 38004, 38798);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_DateTime()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 38810, 39178);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 38909, 39167);

                listYield.Add(f_1104_38922_39166("DateTime", f_1104_38976_39165(f_1104_38976_39134(f_1104_38976_39101(f_1104_38976_39033(f_1104_38976_38998()), @"DateTime")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 38810, 39178);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1104_38976_38998()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38976, 38998);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1104_38976_39033(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38976, 39033);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1104_38976_39101(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38976, 39101);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1104_38976_39134(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38976, 39134);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1104_38976_39165(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38976, 39165);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_38922_39166(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 38922, 39166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 38810, 39178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 38810, 39178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Security_AccessControl_ObjectSecurity()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 39190, 40449);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 39318, 39841);

                listYield.Add(f_1104_39331_39840("System.Security.AccessControl.ObjectSecurity", f_1104_39421_39839(f_1104_39421_39810(f_1104_39421_39769(f_1104_39421_39707(f_1104_39421_39654(f_1104_39421_39602(f_1104_39421_39559(f_1104_39421_39510(f_1104_39421_39476(f_1104_39421_39442())), label: "Access")), "Path"), "Owner"), "AccessToString")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 39857, 40438);

                listYield.Add(f_1104_39870_40437("System.Security.AccessControl.ObjectSecurity", f_1104_39960_40436(f_1104_39960_40408(f_1104_39960_40375(f_1104_39960_40324(f_1104_39960_40248(f_1104_39960_40170(f_1104_39960_40118(f_1104_39960_40066(f_1104_39960_40015(f_1104_39960_39980()), @"Path"), @"Owner"), @"Group"), @"AccessToString", label: "Access"), @"AuditToString", label: "Audit"), @"Sddl")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 39190, 40449);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_39421_39442()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39421, 39442);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_39421_39476(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39421, 39476);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_39421_39510(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39421, 39510);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_39421_39559(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39421, 39559);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_39421_39602(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39421, 39602);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_39421_39654(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39421, 39654);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_39421_39707(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39421, 39707);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_39421_39769(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39421, 39769);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_39421_39810(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39421, 39810);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_39421_39839(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39421, 39839);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_39331_39840(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39331, 39840);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_39960_39980()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39960, 39980);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_39960_40015(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39960, 40015);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_39960_40066(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39960, 40066);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_39960_40118(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39960, 40118);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_39960_40170(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39960, 40170);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_39960_40248(System.Management.Automation.ListEntryBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.AddItemProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39960, 40248);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_39960_40324(System.Management.Automation.ListEntryBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.AddItemProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39960, 40324);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_39960_40375(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39960, 40375);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_39960_40408(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39960, 40408);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1104_39960_40436(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39960, 40436);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_39870_40437(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 39870, 40437);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 39190, 40449);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 39190, 40449);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_ManagementClass()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 40461, 41175);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 40578, 41164);

                listYield.Add(f_1104_40591_41163("System.Management.ManagementClass", f_1104_40670_41162(f_1104_40670_41133(f_1104_40670_41092(f_1104_40670_41034(f_1104_40670_40979(f_1104_40670_40927(f_1104_40670_40884(f_1104_40670_40850(f_1104_40670_40807(f_1104_40670_40764(f_1104_40670_40691(), "__Namespace", label: "NameSpace"), width: 35), width: 20))), "Name"), "Methods"), "Properties")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 40461, 41175);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_40670_40691()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 40670, 40691);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_40670_40764(System.Management.Automation.TableControlBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.GroupByProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 40670, 40764);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_40670_40807(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 40670, 40807);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_40670_40850(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 40670, 40850);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_40670_40884(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 40670, 40884);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_40670_40927(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 40670, 40927);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_40670_40979(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 40670, 40979);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_40670_41034(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 40670, 41034);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_40670_41092(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 40670, 41092);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_40670_41133(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 40670, 41133);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_40670_41162(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 40670, 41162);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_40591_41163(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 40591, 41163);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 40461, 41175);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 40461, 41175);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimClass()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 41187, 41994);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 41315, 41983);

                listYield.Add(f_1104_41328_41982("Microsoft.Management.Infrastructure.CimClass", f_1104_41418_41981(f_1104_41418_41952(f_1104_41418_41911(f_1104_41418_41845(f_1104_41418_41782(f_1104_41418_41722(f_1104_41418_41679(f_1104_41418_41645(f_1104_41418_41602(f_1104_41418_41536(f_1104_41418_41439(), "$_.CimSystemProperties.Namespace", label: "NameSpace"), label: "CimClassName", width: 35), width: 20))), "CimClassName"), "CimClassMethods"), "CimClassProperties")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 41187, 41994);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_41418_41439()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 41418, 41439);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_41418_41536(System.Management.Automation.TableControlBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.GroupByScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 41418, 41536);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_41418_41602(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 41418, 41602);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_41418_41645(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 41418, 41645);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_41418_41679(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 41418, 41679);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_41418_41722(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 41418, 41722);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_41418_41782(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 41418, 41782);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_41418_41845(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 41418, 41845);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_41418_41911(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 41418, 41911);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_41418_41952(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 41418, 41952);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_41418_41981(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 41418, 41981);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_41328_41982(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 41328, 41982);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 41187, 41994);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 41187, 41994);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Guid()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 42006, 42370);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 42101, 42359);

                listYield.Add(f_1104_42114_42358("System.Guid", f_1104_42171_42357(f_1104_42171_42328(f_1104_42171_42287(f_1104_42171_42235(f_1104_42171_42192()), "Guid")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 42006, 42370);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_42171_42192()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42171, 42192);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_42171_42235(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42171, 42235);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_42171_42287(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42171, 42287);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_42171_42328(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42171, 42328);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_42171_42357(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42171, 42357);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_42114_42358(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42114, 42358);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 42006, 42370);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 42006, 42370);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_ManagementObject_root_cimv2_Win32_PingStatus()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 42382, 43518);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 42528, 43507);

                listYield.Add(f_1104_42541_43506(@"System.Management.ManagementObject#root\cimv2\Win32_PingStatus", f_1104_42650_43505(f_1104_42650_43476(f_1104_42650_43435(f_1104_42650_43375(f_1104_42650_43317(f_1104_42650_43258(f_1104_42650_43199(f_1104_42650_43144(f_1104_42650_43088(f_1104_42650_43045(f_1104_42650_42984(f_1104_42650_42926(f_1104_42650_42861(f_1104_42650_42796(f_1104_42650_42731(f_1104_42650_42671(), label: "Source", width: 13), label: "Destination", width: 15), label: "IPV4Address", width: 16), label: "IPV6Address", width: 40), label: "Bytes", width: 8), label: "Time(ms)", width: 9)), "__Server"), "Address"), "IPV4Address"), "IPV6Address"), "BufferSize"), "ResponseTime")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 42382, 43518);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_42650_42671()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 42671);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_42650_42731(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 42731);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_42650_42796(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 42796);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_42650_42861(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 42861);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_42650_42926(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 42926);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_42650_42984(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 42984);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_42650_43045(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 43045);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_42650_43088(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 43088);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_42650_43144(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 43144);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_42650_43199(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 43199);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_42650_43258(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 43258);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_42650_43317(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 43317);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_42650_43375(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 43375);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_42650_43435(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 43435);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_42650_43476(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 43476);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_42650_43505(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42650, 43505);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_42541_43506(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 42541, 43506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 42382, 43518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 42382, 43518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_PingStatus()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 43530, 44946);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 43689, 44935);

                listYield.Add(f_1104_43702_44934("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_PingStatus", f_1104_43823_44933(f_1104_43823_44904(f_1104_43823_44863(f_1104_43823_44803(f_1104_43823_44745(f_1104_43823_44686(f_1104_43823_44627(f_1104_43823_44572(f_1104_43823_44261(f_1104_43823_44218(f_1104_43823_44157(f_1104_43823_44099(f_1104_43823_44034(f_1104_43823_43969(f_1104_43823_43904(f_1104_43823_43844(), label: "Source", width: 13), label: "Destination", width: 15), label: "IPV4Address", width: 16), label: "IPV6Address", width: 40), label: "Bytes", width: 8), label: "Time(ms)", width: 9)), @"
                            $sourceName = $_.PSComputerName;
                            if($sourceName -eq ""."")
                            {$sourceName = $env:COMPUTERNAME;}

                            return $sourceName;
                        "), "Address"), "IPV4Address"), "IPV6Address"), "BufferSize"), "ResponseTime")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 43530, 44946);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_43823_43844()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 43844);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_43823_43904(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 43904);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_43823_43969(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 43969);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_43823_44034(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 44034);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_43823_44099(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 44099);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_43823_44157(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 44157);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_43823_44218(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 44218);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_43823_44261(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 44261);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_43823_44572(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 44572);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_43823_44627(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 44627);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_43823_44686(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 44686);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_43823_44745(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 44745);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_43823_44803(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 44803);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_43823_44863(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 44863);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_43823_44904(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 44904);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_43823_44933(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43823, 44933);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_43702_44934(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 43702, 44934);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 43530, 44946);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 43530, 44946);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_ManagementObject_root_default_SystemRestore()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 44958, 47312);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 45103, 47301);

                listYield.Add(f_1104_45116_47300(@"System.Management.ManagementObject#root\default\SystemRestore", f_1104_45224_47299(f_1104_45224_47270(f_1104_45224_47229(f_1104_45224_46481(f_1104_45224_45877(f_1104_45224_45815(f_1104_45224_45756(f_1104_45224_45620(f_1104_45224_45577(f_1104_45224_45507(f_1104_45224_45444(f_1104_45224_45376(f_1104_45224_45311(f_1104_45224_45245(), label: "CreationTime", width: 22), label: "Description", width: 30), label: "SequenceNumber", width: 17), label: "EventType", width: 17), label: "RestorePointType", width: 22)), @"
                    return $_.ConvertToDateTime($_.CreationTime)
                "), "Description"), "SequenceNumber"), @"
                    $eventType = $_.EventType;
                    if($_.EventType -eq 100)
                    {$eventType = ""BEGIN_SYSTEM_CHANGE"";}

                    if($_.EventType -eq 101)
                    {$eventType = ""END_SYSTEM_CHANGE"";}

                    if($_.EventType -eq 102)
                    {$eventType = ""BEGIN_NESTED_SYSTEM_CHANGE"";}

                    if($_.EventType -eq 103)
                    {$eventType = ""END_NESTED_SYSTEM_CHANGE"";}

                    return $eventType;
                "), @"
                $RestorePointType = $_.RestorePointType;
                if($_.RestorePointType -eq 0)
                { $RestorePointType = ""APPLICATION_INSTALL"";}

                if($_.RestorePointType -eq 1)
                { $RestorePointType = ""APPLICATION_UNINSTALL"";}

                if($_.RestorePointType -eq 10)
                { $RestorePointType = ""DEVICE_DRIVER_INSTALL"";}

                if($_.RestorePointType -eq 12)
                { $RestorePointType = ""MODIFY_SETTINGS"";}

                if($_.RestorePointType -eq 13)
                { $RestorePointType = ""CANCELLED_OPERATION"";}

                    return $RestorePointType;
                ")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 44958, 47312);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_45224_45245()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45224, 45245);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_45224_45311(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45224, 45311);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_45224_45376(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45224, 45376);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_45224_45444(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45224, 45444);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_45224_45507(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45224, 45507);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_45224_45577(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45224, 45577);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_45224_45620(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45224, 45620);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_45224_45756(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45224, 45756);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_45224_45815(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45224, 45815);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_45224_45877(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45224, 45877);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_45224_46481(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45224, 46481);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_45224_47229(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45224, 47229);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_45224_47270(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45224, 47270);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_45224_47299(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45224, 47299);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_45116_47300(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 45116, 47300);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 44958, 47312);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 44958, 47312);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_default_SystemRestore()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 47324, 49753);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 47482, 49742);

                listYield.Add(f_1104_47495_49741("Microsoft.Management.Infrastructure.CimInstance#root/default/SystemRestore", f_1104_47615_49740(f_1104_47615_49711(f_1104_47615_49670(f_1104_47615_48876(f_1104_47615_48270(f_1104_47615_48208(f_1104_47615_48149(f_1104_47615_48011(f_1104_47615_47968(f_1104_47615_47898(f_1104_47615_47835(f_1104_47615_47767(f_1104_47615_47702(f_1104_47615_47636(), label: "CreationTime", width: 22), label: "Description", width: 30), label: "SequenceNumber", width: 17), label: "EventType", width: 17), label: "RestorePointType", width: 22)), @"
                    return $_.ConvertToDateTime($_.CreationTime)
                  "), "Description"), "SequenceNumber"), @"
                    $eventType = $_.EventType;
                    if($_.EventType -eq 100)
                    {$eventType = ""BEGIN_SYSTEM_CHANGE"";}

                    if($_.EventType -eq 101)
                    {$eventType = ""END_SYSTEM_CHANGE"";}

                    if($_.EventType -eq 102)
                    {$eventType = ""BEGIN_NESTED_SYSTEM_CHANGE"";}

                    if($_.EventType -eq 103)
                    {$eventType = ""END_NESTED_SYSTEM_CHANGE"";}

                    return $eventType;
                  "), @"
                    $RestorePointType = $_.RestorePointType;
                    if($_.RestorePointType -eq 0)
                    { $RestorePointType = ""APPLICATION_INSTALL"";}

                    if($_.RestorePointType -eq 1)
                    { $RestorePointType = ""APPLICATION_UNINSTALL"";}

                    if($_.RestorePointType -eq 10)
                    { $RestorePointType = ""DEVICE_DRIVER_INSTALL"";}

                    if($_.RestorePointType -eq 12)
                    { $RestorePointType = ""MODIFY_SETTINGS"";}

                    if($_.RestorePointType -eq 13)
                    { $RestorePointType = ""CANCELLED_OPERATION"";}

                    return $RestorePointType;
                  ")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 47324, 49753);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_47615_47636()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47615, 47636);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_47615_47702(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47615, 47702);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_47615_47767(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47615, 47767);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_47615_47835(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47615, 47835);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_47615_47898(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47615, 47898);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_47615_47968(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47615, 47968);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_47615_48011(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47615, 48011);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_47615_48149(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47615, 48149);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_47615_48208(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47615, 48208);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_47615_48270(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47615, 48270);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_47615_48876(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47615, 48876);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_47615_49670(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47615, 49670);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_47615_49711(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47615, 49711);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_47615_49740(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47615, 49740);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_47495_49741(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 47495, 49741);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 47324, 49753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 47324, 49753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_ManagementObject_root_cimv2_Win32_QuickFixEngineering()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 49765, 50804);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 49920, 50793);

                listYield.Add(f_1104_49933_50792(@"System.Management.ManagementObject#root\cimv2\Win32_QuickFixEngineering", f_1104_50051_50791(f_1104_50051_50762(f_1104_50051_50721(f_1104_50051_50662(f_1104_50051_50603(f_1104_50051_50547(f_1104_50051_50488(f_1104_50051_50432(f_1104_50051_50389(f_1104_50051_50324(f_1104_50051_50259(f_1104_50051_50197(f_1104_50051_50132(f_1104_50051_50072(), label: "Source", width: 13), label: "Description", width: 16), label: "HotFixID", width: 13), label: "InstalledBy", width: 20), label: "InstalledOn", width: 26)), "__SERVER"), "Description"), "HotFixID"), "InstalledBy"), "InstalledOn")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 49765, 50804);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_50051_50072()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50051, 50072);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_50051_50132(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50051, 50132);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_50051_50197(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50051, 50197);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_50051_50259(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50051, 50259);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_50051_50324(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50051, 50324);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_50051_50389(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50051, 50389);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_50051_50432(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50051, 50432);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_50051_50488(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50051, 50488);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_50051_50547(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50051, 50547);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_50051_50603(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50051, 50603);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_50051_50662(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50051, 50662);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_50051_50721(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50051, 50721);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_50051_50762(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50051, 50762);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_50051_50791(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50051, 50791);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_49933_50792(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 49933, 50792);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 49765, 50804);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 49765, 50804);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_QuickFixEngineering()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 50816, 51884);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 50984, 51873);

                listYield.Add(f_1104_50997_51872("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_QuickFixEngineering", f_1104_51127_51871(f_1104_51127_51842(f_1104_51127_51801(f_1104_51127_51742(f_1104_51127_51683(f_1104_51127_51627(f_1104_51127_51568(f_1104_51127_51508(f_1104_51127_51465(f_1104_51127_51400(f_1104_51127_51335(f_1104_51127_51273(f_1104_51127_51208(f_1104_51127_51148(), label: "Source", width: 13), label: "Description", width: 16), label: "HotFixID", width: 13), label: "InstalledBy", width: 20), label: "InstalledOn", width: 26)), "ComputerName"), "Description"), "HotFixID"), "InstalledBy"), "InstalledOn")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 50816, 51884);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_51127_51148()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 51127, 51148);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_51127_51208(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 51127, 51208);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_51127_51273(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 51127, 51273);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_51127_51335(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 51127, 51335);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_51127_51400(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 51127, 51400);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_51127_51465(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 51127, 51465);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_51127_51508(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 51127, 51508);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_51127_51568(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 51127, 51568);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_51127_51627(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 51127, 51627);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_51127_51683(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 51127, 51683);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_51127_51742(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 51127, 51742);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_51127_51801(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 51127, 51801);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_51127_51842(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 51127, 51842);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_51127_51871(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 51127, 51871);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_50997_51872(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 50997, 51872);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 50816, 51884);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 50816, 51884);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_Process()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 51896, 52894);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 52052, 52883);

                listYield.Add(f_1104_52065_52882("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_Process", f_1104_52183_52881(f_1104_52183_52852(f_1104_52183_52811(f_1104_52183_52752(f_1104_52183_52690(f_1104_52183_52631(f_1104_52183_52579(f_1104_52183_52522(f_1104_52183_52479(f_1104_52183_52425(f_1104_52183_52368(f_1104_52183_52314(f_1104_52183_52256(f_1104_52183_52204(), label: "ProcessId"), label: "Name", width: 16), label: "HandleCount"), label: "WorkingSetSize"), label: "VirtualSize")), "ProcessId"), "Name"), "HandleCount"), "WorkingSetSize"), "VirtualSize")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 51896, 52894);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_52183_52204()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52183, 52204);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_52183_52256(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52183, 52256);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_52183_52314(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52183, 52314);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_52183_52368(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52183, 52368);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_52183_52425(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52183, 52425);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_52183_52479(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52183, 52479);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_52183_52522(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52183, 52522);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_52183_52579(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52183, 52579);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_52183_52631(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52183, 52631);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_52183_52690(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52183, 52690);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_52183_52752(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52183, 52752);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_52183_52811(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52183, 52811);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_52183_52852(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52183, 52852);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_52183_52881(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52183, 52881);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_52065_52882(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 52065, 52882);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 51896, 52894);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 51896, 52894);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_ComputerSystem()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 52906, 54035);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 53069, 54024);

                listYield.Add(f_1104_53082_54023("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_ComputerSystem", f_1104_53207_54022(f_1104_53207_53993(f_1104_53207_53952(f_1104_53207_53892(f_1104_53207_53839(f_1104_53207_53772(f_1104_53207_53718(f_1104_53207_53654(f_1104_53207_53602(f_1104_53207_53559(f_1104_53207_53504(f_1104_53207_53456(f_1104_53207_53394(f_1104_53207_53345(f_1104_53207_53286(f_1104_53207_53228(), label: "Name", width: 16), label: "PrimaryOwnerName"), label: "Domain"), label: "TotalPhysicalMemory"), label: "Model"), label: "Manufacturer")), "Name"), "PrimaryOwnerName"), "Domain"), "TotalPhysicalMemory"), "Model"), "Manufacturer")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 52906, 54035);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_53207_53228()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53228);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_53207_53286(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53286);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_53207_53345(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53345);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_53207_53394(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53394);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_53207_53456(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53456);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_53207_53504(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53504);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_53207_53559(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53559);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_53207_53602(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53602);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_53207_53654(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53654);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_53207_53718(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53718);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_53207_53772(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53772);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_53207_53839(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53839);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_53207_53892(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53892);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_53207_53952(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53952);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_53207_53993(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 53993);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_53207_54022(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53207, 54022);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_53082_54023(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 53082, 54023);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 52906, 54035);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 52906, 54035);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_WIN32_PROCESSOR()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 54047, 55164);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 54205, 55153);

                listYield.Add(f_1104_54218_55152("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/WIN32_PROCESSOR", f_1104_54338_55151(f_1104_54338_55122(f_1104_54338_55081(f_1104_54338_55021(f_1104_54338_54956(f_1104_54338_54895(f_1104_54338_54840(f_1104_54338_54788(f_1104_54338_54732(f_1104_54338_54689(f_1104_54338_54634(f_1104_54338_54574(f_1104_54338_54518(f_1104_54338_54468(f_1104_54338_54410(f_1104_54338_54359(), label: "DeviceID"), label: "Name", width: 16), label: "Caption"), label: "MaxClockSpeed"), label: "SocketDesignation"), label: "Manufacturer")), "DeviceID"), "Name"), "Caption"), "MaxClockSpeed"), "SocketDesignation"), "Manufacturer")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 54047, 55164);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_54338_54359()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 54359);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_54338_54410(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 54410);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_54338_54468(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 54468);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_54338_54518(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 54518);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_54338_54574(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 54574);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_54338_54634(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 54634);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_54338_54689(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 54689);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_54338_54732(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 54732);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_54338_54788(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 54788);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_54338_54840(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 54840);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_54338_54895(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 54895);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_54338_54956(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 54956);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_54338_55021(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 55021);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_54338_55081(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 55081);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_54338_55122(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 55122);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_54338_55151(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54338, 55151);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_54218_55152(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 54218, 55152);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 54047, 55164);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 54047, 55164);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_WIN32_DCOMApplication()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 55176, 55950);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 55340, 55939);

                listYield.Add(f_1104_55353_55938("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/WIN32_DCOMApplication", f_1104_55479_55937(f_1104_55479_55908(f_1104_55479_55867(f_1104_55479_55808(f_1104_55479_55756(f_1104_55479_55703(f_1104_55479_55660(f_1104_55479_55606(f_1104_55479_55548(f_1104_55479_55500(), label: "AppID"), label: "Name", width: 16), label: "InstallDate")), "AppID"), "Name"), "InstallDate")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 55176, 55950);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_55479_55500()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 55479, 55500);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_55479_55548(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 55479, 55548);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_55479_55606(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 55479, 55606);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_55479_55660(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 55479, 55660);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_55479_55703(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 55479, 55703);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_55479_55756(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 55479, 55756);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_55479_55808(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 55479, 55808);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_55479_55867(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 55479, 55867);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_55479_55908(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 55479, 55908);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_55479_55937(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 55479, 55937);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_55353_55938(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 55353, 55938);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 55176, 55950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 55176, 55950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_WIN32_DESKTOP()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 55962, 56992);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 56118, 56981);

                listYield.Add(f_1104_56131_56980("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/WIN32_DESKTOP", f_1104_56249_56979(f_1104_56249_56950(f_1104_56249_56909(f_1104_56249_56843(f_1104_56249_56778(f_1104_56249_56713(f_1104_56249_56661(f_1104_56249_56604(f_1104_56249_56561(f_1104_56249_56500(f_1104_56249_56440(f_1104_56249_56380(f_1104_56249_56322(f_1104_56249_56270(), label: "SettingID"), label: "Name", width: 16), label: "ScreenSaverActive"), label: "ScreenSaverSecure"), label: "ScreenSaverTimeout")), "SettingID"), "Name"), "ScreenSaverActive"), "ScreenSaverSecure"), "ScreenSaverTimeout")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 55962, 56992);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_56249_56270()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56249, 56270);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_56249_56322(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56249, 56322);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_56249_56380(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56249, 56380);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_56249_56440(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56249, 56440);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_56249_56500(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56249, 56500);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_56249_56561(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56249, 56561);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_56249_56604(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56249, 56604);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_56249_56661(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56249, 56661);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_56249_56713(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56249, 56713);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_56249_56778(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56249, 56778);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_56249_56843(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56249, 56843);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_56249_56909(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56249, 56909);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_56249_56950(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56249, 56950);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_56249_56979(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56249, 56979);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_56131_56980(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 56131, 56980);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 55962, 56992);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 55962, 56992);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_WIN32_DESKTOPMONITOR()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 57004, 58139);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 57167, 58128);

                listYield.Add(f_1104_57180_58127("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/WIN32_DESKTOPMONITOR", f_1104_57305_58126(f_1104_57305_58097(f_1104_57305_58056(f_1104_57305_57997(f_1104_57305_57937(f_1104_57305_57870(f_1104_57305_57811(f_1104_57305_57759(f_1104_57305_57703(f_1104_57305_57660(f_1104_57305_57606(f_1104_57305_57551(f_1104_57305_57489(f_1104_57305_57435(f_1104_57305_57377(f_1104_57305_57326(), label: "DeviceID"), label: "Name", width: 16), label: "DisplayType"), label: "MonitorManufacturer"), label: "ScreenHeight"), label: "ScreenWidth")), "DeviceID"), "Name"), "DisplayType"), "MonitorManufacturer"), "ScreenHeight"), "ScreenWidth")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 57004, 58139);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_57305_57326()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 57326);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_57305_57377(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 57377);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_57305_57435(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 57435);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_57305_57489(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 57489);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_57305_57551(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 57551);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_57305_57606(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 57606);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_57305_57660(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 57660);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_57305_57703(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 57703);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_57305_57759(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 57759);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_57305_57811(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 57811);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_57305_57870(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 57870);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_57305_57937(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 57937);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_57305_57997(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 57997);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_57305_58056(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 58056);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_57305_58097(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 58097);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_57305_58126(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57305, 58126);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_57180_58127(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 57180, 58127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 57004, 58139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 57004, 58139);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_DeviceMemoryAddress()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 58151, 58933);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 58319, 58922);

                listYield.Add(f_1104_58332_58921("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_DeviceMemoryAddress", f_1104_58462_58920(f_1104_58462_58891(f_1104_58462_58850(f_1104_58462_58796(f_1104_58462_58738(f_1104_58462_58686(f_1104_58462_58643(f_1104_58462_58594(f_1104_58462_58541(f_1104_58462_58483(), label: "Name", width: 16), label: "MemoryType"), label: "Status")), "Name"), "MemoryType"), "Status")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 58151, 58933);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_58462_58483()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 58462, 58483);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_58462_58541(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 58462, 58541);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_58462_58594(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 58462, 58594);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_58462_58643(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 58462, 58643);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_58462_58686(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 58462, 58686);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_58462_58738(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 58462, 58738);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_58462_58796(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 58462, 58796);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_58462_58850(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 58462, 58850);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_58462_58891(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 58462, 58891);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_58462_58920(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 58462, 58920);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_58332_58921(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 58332, 58921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 58151, 58933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 58151, 58933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_DiskDrive()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 58945, 59906);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 59103, 59895);

                listYield.Add(f_1104_59116_59894("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_DiskDrive", f_1104_59236_59893(f_1104_59236_59864(f_1104_59236_59823(f_1104_59236_59770(f_1104_59236_59718(f_1104_59236_59660(f_1104_59236_59605(f_1104_59236_59549(f_1104_59236_59506(f_1104_59236_59458(f_1104_59236_59411(f_1104_59236_59358(f_1104_59236_59308(f_1104_59236_59257(), label: "DeviceID"), label: "Caption"), label: "Partitions"), label: "Size"), label: "Model")), "DeviceID"), "Caption"), "Partitions"), "Size"), "Model")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 58945, 59906);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_59236_59257()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59236, 59257);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_59236_59308(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59236, 59308);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_59236_59358(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59236, 59358);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_59236_59411(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59236, 59411);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_59236_59458(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59236, 59458);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_59236_59506(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59236, 59506);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_59236_59549(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59236, 59549);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_59236_59605(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59236, 59605);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_59236_59660(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59236, 59660);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_59236_59718(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59236, 59718);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_59236_59770(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59236, 59770);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_59236_59823(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59236, 59823);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_59236_59864(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59236, 59864);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_59236_59893(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59236, 59893);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_59116_59894(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 59116, 59894);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 58945, 59906);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 58945, 59906);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_DiskQuota()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 59918, 60786);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 60076, 60775);

                listYield.Add(f_1104_60089_60774("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_DiskQuota", f_1104_60209_60773(f_1104_60209_60744(f_1104_60209_60703(f_1104_60209_60651(f_1104_60209_60592(f_1104_60209_60539(f_1104_60209_60478(f_1104_60209_60435(f_1104_60209_60388(f_1104_60209_60334(f_1104_60209_60286(f_1104_60209_60230(), label: "DiskSpaceUsed"), label: "Limit"), label: "QuotaVolume"), label: "User")), "DiskSpaceUsed"), "Limit"), "QuotaVolume"), "User")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 59918, 60786);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_60209_60230()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 60209, 60230);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_60209_60286(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 60209, 60286);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_60209_60334(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 60209, 60334);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_60209_60388(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 60209, 60388);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_60209_60435(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 60209, 60435);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_60209_60478(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 60209, 60478);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_60209_60539(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 60209, 60539);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_60209_60592(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 60209, 60592);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_60209_60651(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 60209, 60651);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_60209_60703(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 60209, 60703);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_60209_60744(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 60209, 60744);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_60209_60773(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 60209, 60773);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_60089_60774(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 60089, 60774);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 59918, 60786);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 59918, 60786);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_Environment()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 60798, 61574);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 60958, 61563);

                listYield.Add(f_1104_60971_61562("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_Environment", f_1104_61093_61561(f_1104_61093_61532(f_1104_61093_61491(f_1104_61093_61430(f_1104_61093_61374(f_1104_61093_61322(f_1104_61093_61279(f_1104_61093_61223(f_1104_61093_61172(f_1104_61093_61114(), label: "Name", width: 16), label: "UserName"), label: "VariableValue")), "Name"), "UserName"), "VariableValue")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 60798, 61574);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_61093_61114()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61093, 61114);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_61093_61172(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61093, 61172);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_61093_61223(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61093, 61223);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_61093_61279(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61093, 61279);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_61093_61322(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61093, 61322);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_61093_61374(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61093, 61374);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_61093_61430(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61093, 61430);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_61093_61491(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61093, 61491);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_61093_61532(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61093, 61532);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_61093_61561(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61093, 61561);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_60971_61562(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 60971, 61562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 60798, 61574);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 60798, 61574);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_Directory()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 61586, 62566);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 61744, 62555);

                listYield.Add(f_1104_61757_62554("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_Directory", f_1104_61877_62553(f_1104_61877_62524(f_1104_61877_62483(f_1104_61877_62423(f_1104_61877_62366(f_1104_61877_62311(f_1104_61877_62257(f_1104_61877_62205(f_1104_61877_62162(f_1104_61877_62107(f_1104_61877_62055(f_1104_61877_62005(f_1104_61877_61956(f_1104_61877_61898(), label: "Name", width: 16), label: "Hidden"), label: "Archive"), label: "Writeable"), label: "LastModified")), "Name"), "Hidden"), "Archive"), "Writeable"), "LastModified")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 61586, 62566);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_61877_61898()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61877, 61898);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_61877_61956(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61877, 61956);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_61877_62005(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61877, 62005);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_61877_62055(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61877, 62055);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_61877_62107(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61877, 62107);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_61877_62162(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61877, 62162);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_61877_62205(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61877, 62205);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_61877_62257(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61877, 62257);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_61877_62311(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61877, 62311);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_61877_62366(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61877, 62366);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_61877_62423(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61877, 62423);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_61877_62483(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61877, 62483);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_61877_62524(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61877, 62524);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_61877_62553(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61877, 62553);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_61757_62554(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 61757, 62554);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 61586, 62566);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 61586, 62566);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_Group()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 62578, 63423);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 62732, 63412);

                listYield.Add(f_1104_62745_63411("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_Group", f_1104_62861_63410(f_1104_62861_63381(f_1104_62861_63340(f_1104_62861_63286(f_1104_62861_63231(f_1104_62861_63179(f_1104_62861_63128(f_1104_62861_63085(f_1104_62861_63036(f_1104_62861_62986(f_1104_62861_62928(f_1104_62861_62882(), label: "SID"), label: "Name", width: 16), label: "Caption"), label: "Domain")), "SID"), "Name"), "Caption"), "Domain")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 62578, 63423);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_62861_62882()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 62861, 62882);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_62861_62928(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 62861, 62928);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_62861_62986(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 62861, 62986);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_62861_63036(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 62861, 63036);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_62861_63085(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 62861, 63085);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_62861_63128(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 62861, 63128);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_62861_63179(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 62861, 63179);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_62861_63231(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 62861, 63231);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_62861_63286(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 62861, 63286);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_62861_63340(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 62861, 63340);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_62861_63381(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 62861, 63381);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_62861_63410(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 62861, 63410);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_62745_63411(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 62745, 63411);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 62578, 63423);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 62578, 63423);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_IDEController()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 63435, 64445);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 63597, 64434);

                listYield.Add(f_1104_63610_64433("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_IDEController", f_1104_63734_64432(f_1104_63734_64403(f_1104_63734_64362(f_1104_63734_64302(f_1104_63734_64237(f_1104_63734_64179(f_1104_63734_64125(f_1104_63734_64073(f_1104_63734_64030(f_1104_63734_63975(f_1104_63734_63915(f_1104_63734_63862(f_1104_63734_63813(f_1104_63734_63755(), label: "Name", width: 16), label: "Status"), label: "StatusInfo"), label: "ProtocolSupported"), label: "Manufacturer")), "Name"), "Status"), "StatusInfo"), "ProtocolSupported"), "Manufacturer")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 63435, 64445);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_63734_63755()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63734, 63755);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_63734_63813(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63734, 63813);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_63734_63862(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63734, 63862);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_63734_63915(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63734, 63915);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_63734_63975(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63734, 63975);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_63734_64030(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63734, 64030);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_63734_64073(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63734, 64073);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_63734_64125(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63734, 64125);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_63734_64179(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63734, 64179);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_63734_64237(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63734, 64237);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_63734_64302(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63734, 64302);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_63734_64362(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63734, 64362);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_63734_64403(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63734, 64403);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_63734_64432(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63734, 64432);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_63610_64433(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 63610, 64433);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 63435, 64445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 63435, 64445);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_IRQResource()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 64457, 65453);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 64617, 65442);

                listYield.Add(f_1104_64630_65441("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_IRQResource", f_1104_64752_65440(f_1104_64752_65411(f_1104_64752_65370(f_1104_64752_65311(f_1104_64752_65251(f_1104_64752_65195(f_1104_64752_65138(f_1104_64752_65086(f_1104_64752_65043(f_1104_64752_64989(f_1104_64752_64934(f_1104_64752_64883(f_1104_64752_64831(f_1104_64752_64773(), label: "Name", width: 16), label: "IRQNumber"), label: "Hardware"), label: "TriggerLevel"), label: "TriggerType")), "Name"), "IRQNumber"), "Hardware"), "TriggerLevel"), "TriggerType")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 64457, 65453);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_64752_64773()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64752, 64773);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_64752_64831(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64752, 64831);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_64752_64883(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64752, 64883);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_64752_64934(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64752, 64934);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_64752_64989(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64752, 64989);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_64752_65043(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64752, 65043);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_64752_65086(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64752, 65086);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_64752_65138(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64752, 65138);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_64752_65195(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64752, 65195);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_64752_65251(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64752, 65251);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_64752_65311(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64752, 65311);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_64752_65370(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64752, 65370);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_64752_65411(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64752, 65411);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_64752_65440(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64752, 65440);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_64630_65441(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 64630, 65441);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 64457, 65453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 64457, 65453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_ScheduledJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 65465, 66433);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 65626, 66422);

                listYield.Add(f_1104_65639_66421("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_ScheduledJob", f_1104_65762_66420(f_1104_65762_66391(f_1104_65762_66350(f_1104_65762_66295(f_1104_65762_66239(f_1104_65762_66186(f_1104_65762_66134(f_1104_65762_66081(f_1104_65762_66038(f_1104_65762_65988(f_1104_65762_65937(f_1104_65762_65889(f_1104_65762_65831(f_1104_65762_65783(), label: "JobId"), label: "Name", width: 16), label: "Owner"), label: "Priority"), label: "Command")), "JobId"), "Name"), "Owner"), "Priority"), "Command")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 65465, 66433);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_65762_65783()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65762, 65783);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_65762_65831(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65762, 65831);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_65762_65889(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65762, 65889);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_65762_65937(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65762, 65937);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_65762_65988(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65762, 65988);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_65762_66038(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65762, 66038);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_65762_66081(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65762, 66081);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_65762_66134(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65762, 66134);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_65762_66186(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65762, 66186);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_65762_66239(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65762, 66239);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_65762_66295(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65762, 66295);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_65762_66350(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65762, 66350);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_65762_66391(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65762, 66391);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_65762_66420(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65762, 66420);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_65639_66421(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 65639, 66421);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 65465, 66433);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 65465, 66433);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_LoadOrderGroup()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 66445, 67114);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 66608, 67103);

                listYield.Add(f_1104_66621_67102("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_LoadOrderGroup", f_1104_66746_67101(f_1104_66746_67072(f_1104_66746_67031(f_1104_66746_66973(f_1104_66746_66921(f_1104_66746_66878(f_1104_66746_66825(f_1104_66746_66767(), label: "Name", width: 16), label: "GroupOrder")), "Name"), "GroupOrder")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 66445, 67114);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_66746_66767()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 66746, 66767);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_66746_66825(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 66746, 66825);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_66746_66878(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 66746, 66878);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_66746_66921(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 66746, 66921);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_66746_66973(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 66746, 66973);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_66746_67031(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 66746, 67031);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_66746_67072(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 66746, 67072);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_66746_67101(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 66746, 67101);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_66621_67102(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 66621, 67102);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 66445, 67114);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 66445, 67114);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_LogicalDisk()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 67126, 68240);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 67286, 68229);

                listYield.Add(f_1104_67299_68228("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_LogicalDisk", f_1104_67421_68227(f_1104_67421_68198(f_1104_67421_68157(f_1104_67421_68100(f_1104_67421_68048(f_1104_67421_67990(f_1104_67421_67930(f_1104_67421_67873(f_1104_67421_67817(f_1104_67421_67774(f_1104_67421_67722(f_1104_67421_67675(f_1104_67421_67611(f_1104_67421_67545(f_1104_67421_67493(f_1104_67421_67442(), label: "DeviceID"), label: "DriveType"), label: "ProviderName", width: 16), label: "VolumeName", width: 16), label: "Size"), label: "FreeSpace")), "DeviceID"), "DriveType"), "ProviderName"), "VolumeName"), "Size"), "FreeSpace")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 67126, 68240);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_67421_67442()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 67442);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_67421_67493(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 67493);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_67421_67545(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 67545);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_67421_67611(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 67611);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_67421_67675(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 67675);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_67421_67722(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 67722);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_67421_67774(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 67774);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_67421_67817(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 67817);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_67421_67873(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 67873);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_67421_67930(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 67930);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_67421_67990(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 67990);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_67421_68048(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 68048);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_67421_68100(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 68100);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_67421_68157(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 68157);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_67421_68198(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 68198);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_67421_68227(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67421, 68227);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_67299_68228(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 67299, 68228);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 67126, 68240);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 67126, 68240);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_LogonSession()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 68252, 69365);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 68413, 69354);

                listYield.Add(f_1104_68426_69353("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_LogonSession", f_1104_68549_69352(f_1104_68549_69323(f_1104_68549_69282(f_1104_68549_69213(f_1104_68549_69159(f_1104_68549_69102(f_1104_68549_69045(f_1104_68549_68993(f_1104_68549_68938(f_1104_68549_68895(f_1104_68549_68831(f_1104_68549_68782(f_1104_68549_68730(f_1104_68549_68678(f_1104_68549_68620(f_1104_68549_68570(), label: "LogonId"), label: "Name", width: 16), label: "LogonType"), label: "StartTime"), label: "Status"), label: "AuthenticationPackage")), "LogonId"), "Name"), "LogonType"), "StartTime"), "Status"), "AuthenticationPackage")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 68252, 69365);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_68549_68570()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 68570);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_68549_68620(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 68620);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_68549_68678(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 68678);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_68549_68730(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 68730);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_68549_68782(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 68782);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_68549_68831(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 68831);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_68549_68895(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 68895);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_68549_68938(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 68938);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_68549_68993(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 68993);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_68549_69045(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 69045);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_68549_69102(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 69102);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_68549_69159(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 69159);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_68549_69213(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 69213);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_68549_69282(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 69282);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_68549_69323(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 69323);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_68549_69352(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68549, 69352);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_68426_69353(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 68426, 69353);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 68252, 69365);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 68252, 69365);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_PhysicalMemoryArray()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 69377, 70276);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 69545, 70265);

                listYield.Add(f_1104_69558_70264("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_PhysicalMemoryArray", f_1104_69688_70263(f_1104_69688_70234(f_1104_69688_70193(f_1104_69688_70140(f_1104_69688_70081(f_1104_69688_70020(f_1104_69688_69968(f_1104_69688_69925(f_1104_69688_69877(f_1104_69688_69823(f_1104_69688_69767(f_1104_69688_69709(), label: "Name", width: 16), label: "MemoryDevices"), label: "MaxCapacity"), label: "Model")), "Name"), "MemoryDevices"), "MaxCapacity"), "Model")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 69377, 70276);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_69688_69709()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 69688, 69709);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_69688_69767(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 69688, 69767);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_69688_69823(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 69688, 69823);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_69688_69877(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 69688, 69877);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_69688_69925(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 69688, 69925);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_69688_69968(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 69688, 69968);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_69688_70020(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 69688, 70020);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_69688_70081(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 69688, 70081);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_69688_70140(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 69688, 70140);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_69688_70193(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 69688, 70193);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_69688_70234(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 69688, 70234);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_69688_70263(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 69688, 70263);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_69558_70264(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 69558, 70264);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 69377, 70276);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 69377, 70276);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_OnBoardDevice()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 70288, 71178);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 70450, 71167);

                listYield.Add(f_1104_70463_71166("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_OnBoardDevice", f_1104_70587_71165(f_1104_70587_71136(f_1104_70587_71095(f_1104_70587_71036(f_1104_70587_70981(f_1104_70587_70921(f_1104_70587_70863(f_1104_70587_70820(f_1104_70587_70766(f_1104_70587_70716(f_1104_70587_70661(f_1104_70587_70608(), label: "DeviceType"), label: "SerialNumber"), label: "Enabled"), label: "Description")), "DeviceType"), "SerialNumber"), "Enabled"), "Description")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 70288, 71178);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_70587_70608()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 70587, 70608);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_70587_70661(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 70587, 70661);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_70587_70716(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 70587, 70716);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_70587_70766(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 70587, 70766);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_70587_70820(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 70587, 70820);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_70587_70863(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 70587, 70863);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_70587_70921(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 70587, 70921);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_70587_70981(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 70587, 70981);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_70587_71036(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 70587, 71036);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_70587_71095(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 70587, 71095);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_70587_71136(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 70587, 71136);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_70587_71165(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 70587, 71165);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_70463_71166(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 70463, 71166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 70288, 71178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 70288, 71178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_OperatingSystem()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 71190, 72328);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 71354, 72317);

                listYield.Add(f_1104_71367_72316("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_OperatingSystem", f_1104_71493_72315(f_1104_71493_72286(f_1104_71493_72245(f_1104_71493_72190(f_1104_71493_72130(f_1104_71493_72068(f_1104_71493_72009(f_1104_71493_71949(f_1104_71493_71886(f_1104_71493_71843(f_1104_71493_71793(f_1104_71493_71738(f_1104_71493_71681(f_1104_71493_71627(f_1104_71493_71572(f_1104_71493_71514(), label: "SystemDirectory"), label: "Organization"), label: "BuildNumber"), label: "RegisteredUser"), label: "SerialNumber"), label: "Version")), "SystemDirectory"), "Organization"), "BuildNumber"), "RegisteredUser"), "SerialNumber"), "Version")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 71190, 72328);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_71493_71514()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 71514);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_71493_71572(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 71572);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_71493_71627(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 71627);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_71493_71681(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 71681);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_71493_71738(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 71738);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_71493_71793(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 71793);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_71493_71843(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 71843);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_71493_71886(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 71886);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_71493_71949(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 71949);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_71493_72009(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 72009);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_71493_72068(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 72068);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_71493_72130(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 72130);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_71493_72190(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 72190);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_71493_72245(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 72245);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_71493_72286(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 72286);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_71493_72315(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71493, 72315);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_71367_72316(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 71367, 72316);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 71190, 72328);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 71190, 72328);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_DiskPartition()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 72340, 73455);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 72502, 73444);

                listYield.Add(f_1104_72515_73443("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_DiskPartition", f_1104_72639_73442(f_1104_72639_73413(f_1104_72639_73372(f_1104_72639_73319(f_1104_72639_73267(f_1104_72639_73203(f_1104_72639_73142(f_1104_72639_73080(f_1104_72639_73028(f_1104_72639_72985(f_1104_72639_72937(f_1104_72639_72890(f_1104_72639_72831(f_1104_72639_72775(f_1104_72639_72718(f_1104_72639_72660(), label: "Name", width: 16), label: "NumberOfBlocks"), label: "BootPartition"), label: "PrimaryPartition"), label: "Size"), label: "Index")), "Name"), "NumberOfBlocks"), "BootPartition"), "PrimaryPartition"), "Size"), "Index")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 72340, 73455);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_72639_72660()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 72660);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_72639_72718(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 72718);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_72639_72775(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 72775);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_72639_72831(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 72831);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_72639_72890(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 72890);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_72639_72937(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 72937);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_72639_72985(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 72985);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_72639_73028(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 73028);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_72639_73080(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 73080);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_72639_73142(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 73142);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_72639_73203(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 73203);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_72639_73267(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 73267);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_72639_73319(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 73319);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_72639_73372(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 73372);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_72639_73413(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 73413);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_72639_73442(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72639, 73442);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_72515_73443(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 72515, 73443);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 72340, 73455);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 72340, 73455);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_PortConnector()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 73467, 74494);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 73629, 74483);

                listYield.Add(f_1104_73642_74482("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_PortConnector", f_1104_73766_74481(f_1104_73766_74452(f_1104_73766_74411(f_1104_73766_74336(f_1104_73766_74276(f_1104_73766_74215(f_1104_73766_74159(f_1104_73766_74108(f_1104_73766_74065(f_1104_73766_73995(f_1104_73766_73940(f_1104_73766_73884(f_1104_73766_73833(f_1104_73766_73787(), label: "Tag"), label: "PortType"), label: "ConnectorType"), label: "SerialNumber"), label: "ExternalReferenceDesignator")), "Tag"), "PortType"), "ConnectorType"), "SerialNumber"), "ExternalReferenceDesignator")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 73467, 74494);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_73766_73787()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73766, 73787);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_73766_73833(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73766, 73833);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_73766_73884(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73766, 73884);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_73766_73940(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73766, 73940);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_73766_73995(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73766, 73995);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_73766_74065(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73766, 74065);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_73766_74108(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73766, 74108);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_73766_74159(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73766, 74159);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_73766_74215(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73766, 74215);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_73766_74276(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73766, 74276);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_73766_74336(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73766, 74336);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_73766_74411(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73766, 74411);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_73766_74452(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73766, 74452);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_73766_74481(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73766, 74481);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_73642_74482(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 73642, 74482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 73467, 74494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 73467, 74494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_QuotaSetting()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 74506, 75620);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 74667, 75609);

                listYield.Add(f_1104_74680_75608("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_QuotaSetting", f_1104_74803_75607(f_1104_74803_75578(f_1104_74803_75537(f_1104_74803_75470(f_1104_74803_75410(f_1104_74803_75352(f_1104_74803_75299(f_1104_74803_75244(f_1104_74803_75187(f_1104_74803_75144(f_1104_74803_75082(f_1104_74803_75027(f_1104_74803_74974(f_1104_74803_74926(f_1104_74803_74876(f_1104_74803_74824(), label: "SettingID"), label: "Caption"), label: "State"), label: "VolumePath"), label: "DefaultLimit"), label: "DefaultWarningLimit")), "SettingID"), "Caption"), "State"), "VolumePath"), "DefaultLimit"), "DefaultWarningLimit")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 74506, 75620);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_74803_74824()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 74824);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_74803_74876(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 74876);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_74803_74926(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 74926);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_74803_74974(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 74974);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_74803_75027(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 75027);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_74803_75082(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 75082);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_74803_75144(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 75144);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_74803_75187(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 75187);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_74803_75244(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 75244);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_74803_75299(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 75299);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_74803_75352(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 75352);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_74803_75410(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 75410);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_74803_75470(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 75470);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_74803_75537(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 75537);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_74803_75578(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 75578);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_74803_75607(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74803, 75607);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_74680_75608(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 74680, 75608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 74506, 75620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 74506, 75620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_SCSIController()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 75632, 76766);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 75795, 76755);

                listYield.Add(f_1104_75808_76754("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_SCSIController", f_1104_75933_76753(f_1104_75933_76724(f_1104_75933_76683(f_1104_75933_76623(f_1104_75933_76558(f_1104_75933_76500(f_1104_75933_76446(f_1104_75933_76388(f_1104_75933_76336(f_1104_75933_76293(f_1104_75933_76238(f_1104_75933_76178(f_1104_75933_76125(f_1104_75933_76076(f_1104_75933_76012(f_1104_75933_75954(), label: "Name", width: 16), label: "DriverName", width: 16), label: "Status"), label: "StatusInfo"), label: "ProtocolSupported"), label: "Manufacturer")), "Name"), "DriverName"), "Status"), "StatusInfo"), "ProtocolSupported"), "Manufacturer")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 75632, 76766);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_75933_75954()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 75954);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_75933_76012(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76012);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_75933_76076(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76076);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_75933_76125(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76125);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_75933_76178(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76178);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_75933_76238(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76238);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_75933_76293(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76293);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_75933_76336(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76336);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_75933_76388(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76388);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_75933_76446(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76446);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_75933_76500(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76500);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_75933_76558(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76558);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_75933_76623(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76623);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_75933_76683(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76683);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_75933_76724(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76724);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_75933_76753(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75933, 76753);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_75808_76754(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 75808, 76754);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 75632, 76766);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 75632, 76766);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_Service()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 76778, 77851);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 76934, 77840);

                listYield.Add(f_1104_76947_77839("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_Service", f_1104_77065_77838(f_1104_77065_77809(f_1104_77065_77768(f_1104_77065_77712(f_1104_77065_77658(f_1104_77065_77605(f_1104_77065_77548(f_1104_77065_77496(f_1104_77065_77439(f_1104_77065_77396(f_1104_77065_77345(f_1104_77065_77296(f_1104_77065_77248(f_1104_77065_77196(f_1104_77065_77138(f_1104_77065_77086(), label: "ProcessId"), label: "Name", width: 16), label: "StartMode"), label: "State"), label: "Status"), label: "ExitCode")), "ProcessId"), "Name"), "StartMode"), "State"), "Status"), "ExitCode")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 76778, 77851);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_77065_77086()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77086);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_77065_77138(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77138);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_77065_77196(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77196);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_77065_77248(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77248);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_77065_77296(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77296);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_77065_77345(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77345);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_77065_77396(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77396);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_77065_77439(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77439);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_77065_77496(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77496);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_77065_77548(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77548);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_77065_77605(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77605);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_77065_77658(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77658);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_77065_77712(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77712);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_77065_77768(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77768);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_77065_77809(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77809);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_77065_77838(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 77065, 77838);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_76947_77839(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 76947, 77839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 76778, 77851);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 76778, 77851);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_UserAccount()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 77863, 78833);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 78023, 78822);

                listYield.Add(f_1104_78036_78821("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_UserAccount", f_1104_78158_78820(f_1104_78158_78791(f_1104_78158_78750(f_1104_78158_78696(f_1104_78158_78645(f_1104_78158_78586(f_1104_78158_78531(f_1104_78158_78479(f_1104_78158_78436(f_1104_78158_78387(f_1104_78158_78341(f_1104_78158_78287(f_1104_78158_78237(f_1104_78158_78179(), label: "Name", width: 16), label: "Caption"), label: "AccountType"), label: "SID"), label: "Domain")), "Name"), "Caption"), "AccountType"), "SID"), "Domain")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 77863, 78833);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_78158_78179()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78158, 78179);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_78158_78237(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78158, 78237);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_78158_78287(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78158, 78287);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_78158_78341(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78158, 78341);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_78158_78387(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78158, 78387);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_78158_78436(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78158, 78436);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_78158_78479(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78158, 78479);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_78158_78531(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78158, 78531);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_78158_78586(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78158, 78586);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_78158_78645(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78158, 78645);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_78158_78696(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78158, 78696);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_78158_78750(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78158, 78750);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_78158_78791(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78158, 78791);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_78158_78820(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78158, 78820);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_78036_78821(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 78036, 78821);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 77863, 78833);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 77863, 78833);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_NetworkProtocol()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 78845, 79613);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 79009, 79602);

                listYield.Add(f_1104_79022_79601("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_NetworkProtocol", f_1104_79148_79600(f_1104_79148_79571(f_1104_79148_79530(f_1104_79148_79476(f_1104_79148_79421(f_1104_79148_79369(f_1104_79148_79326(f_1104_79148_79277(f_1104_79148_79227(f_1104_79148_79169(), label: "Name", width: 16), label: "Caption"), label: "Status")), "Name"), "Caption"), "Status")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 78845, 79613);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_79148_79169()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79148, 79169);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_79148_79227(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79148, 79227);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_79148_79277(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79148, 79277);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_79148_79326(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79148, 79326);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_79148_79369(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79148, 79369);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_79148_79421(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79148, 79421);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_79148_79476(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79148, 79476);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_79148_79530(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79148, 79530);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_79148_79571(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79148, 79571);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_79148_79600(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79148, 79600);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_79022_79601(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79022, 79601);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 78845, 79613);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 78845, 79613);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_NetworkAdapter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 79625, 80516);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 79788, 80505);

                listYield.Add(f_1104_79801_80504("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_NetworkAdapter", f_1104_79926_80503(f_1104_79926_80474(f_1104_79926_80433(f_1104_79926_80374(f_1104_79926_80315(f_1104_79926_80263(f_1104_79926_80207(f_1104_79926_80164(f_1104_79926_80110(f_1104_79926_80056(f_1104_79926_79998(f_1104_79926_79947(), label: "DeviceID"), label: "Name", width: 16), label: "AdapterType"), label: "ServiceName")), "DeviceID"), "Name"), "AdapterType"), "ServiceName")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 79625, 80516);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_79926_79947()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79926, 79947);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_79926_79998(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79926, 79998);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_79926_80056(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79926, 80056);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_79926_80110(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79926, 80110);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_79926_80164(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79926, 80164);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_79926_80207(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79926, 80207);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_79926_80263(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79926, 80263);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_79926_80315(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79926, 80315);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_79926_80374(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79926, 80374);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_79926_80433(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79926, 80433);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_79926_80474(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79926, 80474);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_79926_80503(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79926, 80503);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_79801_80504(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 79801, 80504);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 79625, 80516);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 79625, 80516);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_NetworkAdapterConfiguration()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 80528, 81453);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 80704, 81442);

                listYield.Add(f_1104_80717_81441("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_NetworkAdapterConfiguration", f_1104_80855_81440(f_1104_80855_81411(f_1104_80855_81370(f_1104_80855_81311(f_1104_80855_81258(f_1104_80855_81199(f_1104_80855_81140(f_1104_80855_81097(f_1104_80855_81043(f_1104_80855_80995(f_1104_80855_80941(f_1104_80855_80876(), label: "ServiceName", width: 16), label: "DHCPEnabled"), label: "Index"), label: "Description")), "ServiceName"), "DHCPEnabled"), "Index"), "Description")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 80528, 81453);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_80855_80876()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 80855, 80876);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_80855_80941(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 80855, 80941);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_80855_80995(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 80855, 80995);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_80855_81043(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 80855, 81043);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_80855_81097(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 80855, 81097);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_80855_81140(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 80855, 81140);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_80855_81199(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 80855, 81199);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_80855_81258(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 80855, 81258);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_80855_81311(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 80855, 81311);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_80855_81370(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 80855, 81370);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_80855_81411(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 80855, 81411);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_80855_81440(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 80855, 81440);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_80717_81441(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 80717, 81441);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 80528, 81453);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 80528, 81453);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_NTDomain()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 81465, 82271);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 81622, 82260);

                listYield.Add(f_1104_81635_82259("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_NTDomain", f_1104_81754_82258(f_1104_81754_82229(f_1104_81754_82188(f_1104_81754_82120(f_1104_81754_82059(f_1104_81754_82001(f_1104_81754_81958(f_1104_81754_81895(f_1104_81754_81839(f_1104_81754_81775(), label: "DomainName", width: 16), label: "DnsForestName"), label: "DomainControllerName")), "DomainName"), "DnsForestName"), "DomainControllerName")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 81465, 82271);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_81754_81775()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 81754, 81775);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_81754_81839(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 81754, 81839);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_81754_81895(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 81754, 81895);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_81754_81958(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 81754, 81958);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_81754_82001(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 81754, 82001);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_81754_82059(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 81754, 82059);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_81754_82120(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 81754, 82120);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_81754_82188(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 81754, 82188);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_81754_82229(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 81754, 82229);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_81754_82258(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 81754, 82258);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_81635_82259(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 81635, 82259);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 81465, 82271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 81465, 82271);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_Printer()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 82283, 83386);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 82439, 83375);

                listYield.Add(f_1104_82452_83374("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_Printer", f_1104_82570_83373(f_1104_82570_83344(f_1104_82570_83303(f_1104_82570_83247(f_1104_82570_83186(f_1104_82570_83126(f_1104_82570_83068(f_1104_82570_83011(f_1104_82570_82959(f_1104_82570_82916(f_1104_82570_82865(f_1104_82570_82809(f_1104_82570_82754(f_1104_82570_82701(f_1104_82570_82649(f_1104_82570_82591(), label: "Name", width: 16), label: "ShareName"), label: "SystemName"), label: "PrinterState"), label: "PrinterStatus"), label: "Location")), "Name"), "ShareName"), "SystemName"), "PrinterState"), "PrinterStatus"), "Location")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 82283, 83386);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_82570_82591()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 82591);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_82570_82649(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 82649);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_82570_82701(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 82701);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_82570_82754(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 82754);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_82570_82809(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 82809);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_82570_82865(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 82865);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_82570_82916(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 82916);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_82570_82959(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 82959);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_82570_83011(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 83011);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_82570_83068(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 83068);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_82570_83126(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 83126);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_82570_83186(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 83186);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_82570_83247(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 83247);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_82570_83303(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 83303);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_82570_83344(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 83344);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_82570_83373(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82570, 83373);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_82452_83374(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 82452, 83374);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 82283, 83386);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 82283, 83386);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_PrintJob()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 83398, 84568);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 83555, 84557);

                listYield.Add(f_1104_83568_84556("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_PrintJob", f_1104_83687_84555(f_1104_83687_84526(f_1104_83687_84485(f_1104_83687_84429(f_1104_83687_84377(f_1104_83687_84321(f_1104_83687_84268(f_1104_83687_84211(f_1104_83687_84159(f_1104_83687_84106(f_1104_83687_84063(f_1104_83687_84012(f_1104_83687_83965(f_1104_83687_83914(f_1104_83687_83866(f_1104_83687_83814(f_1104_83687_83756(f_1104_83687_83708(), label: "JobId"), label: "Name", width: 16), label: "JobStatus"), label: "Owner"), label: "Priority"), label: "Size"), label: "Document")), "JobId"), "Name"), "JobStatus"), "Owner"), "Priority"), "Size"), "Document")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 83398, 84568);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_83687_83708()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 83708);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_83687_83756(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 83756);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_83687_83814(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 83814);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_83687_83866(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 83866);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_83687_83914(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 83914);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_83687_83965(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 83965);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_83687_84012(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 84012);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_83687_84063(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 84063);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_83687_84106(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 84106);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_83687_84159(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 84159);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_83687_84211(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 84211);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_83687_84268(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 84268);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_83687_84321(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 84321);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_83687_84377(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 84377);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_83687_84429(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 84429);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_83687_84485(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 84485);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_83687_84526(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 84526);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_83687_84555(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83687, 84555);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_83568_84556(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 83568, 84556);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 83398, 84568);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 83398, 84568);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance_root_cimv2_Win32_Product()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 84580, 85562);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 84736, 85551);

                listYield.Add(f_1104_84749_85550("Microsoft.Management.Infrastructure.CimInstance#root/cimv2/Win32_Product", f_1104_84867_85549(f_1104_84867_85520(f_1104_84867_85479(f_1104_84867_85414(f_1104_84867_85359(f_1104_84867_85305(f_1104_84867_85250(f_1104_84867_85198(f_1104_84867_85155(f_1104_84867_85095(f_1104_84867_85045(f_1104_84867_84996(f_1104_84867_84946(f_1104_84867_84888(), label: "Name", width: 16), label: "Caption"), label: "Vendor"), label: "Version"), label: "IdentifyingNumber")), "Name"), "Caption"), "Vendor"), "Version"), "IdentifyingNumber")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 84580, 85562);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_84867_84888()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84867, 84888);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_84867_84946(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84867, 84946);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_84867_84996(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84867, 84996);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_84867_85045(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84867, 85045);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_84867_85095(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84867, 85095);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_84867_85155(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84867, 85155);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_84867_85198(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84867, 85198);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_84867_85250(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84867, 85250);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_84867_85305(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84867, 85305);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_84867_85359(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84867, 85359);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_84867_85414(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84867, 85414);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_84867_85479(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84867, 85479);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_84867_85520(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84867, 85520);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_84867_85549(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84867, 85549);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_84749_85550(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 84749, 85550);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 84580, 85562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 84580, 85562);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Net_NetworkCredential()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 85574, 86152);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 85686, 86141);

                listYield.Add(f_1104_85699_86140("System.Net.NetworkCredential", f_1104_85773_86139(f_1104_85773_86110(f_1104_85773_86069(f_1104_85773_86015(f_1104_85773_85959(f_1104_85773_85916(f_1104_85773_85856(f_1104_85773_85794(), label: "UserName", width: 50), label: "Domain", width: 50)), "UserName"), "Domain")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 85574, 86152);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_85773_85794()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 85773, 85794);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_85773_85856(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 85773, 85856);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_85773_85916(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 85773, 85916);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_85773_85959(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 85773, 85959);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_85773_86015(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 85773, 86015);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_85773_86069(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 85773, 86069);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_85773_86110(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 85773, 86110);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_85773_86139(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 85773, 86139);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_85699_86140(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 85699, 86140);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 85574, 86152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 85574, 86152);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_PSMethod()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 86164, 86759);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 86285, 86748);

                listYield.Add(f_1104_86298_86747("System.Management.Automation.PSMethod", f_1104_86381_86746(f_1104_86381_86717(f_1104_86381_86676(f_1104_86381_86517(f_1104_86381_86464(f_1104_86381_86402(), label: "OverloadDefinitions"), wrap: true), @"
                                    $_.OverloadDefinitions | Out-String
                                ")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 86164, 86759);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_86381_86402()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 86381, 86402);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_86381_86464(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 86381, 86464);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_86381_86517(System.Management.Automation.TableControlBuilder
                this_param, bool
                wrap)
                {
                    var return_v = this_param.StartRowDefinition(wrap: wrap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 86381, 86517);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_86381_86676(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 86381, 86676);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_86381_86717(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 86381, 86717);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_86381_86746(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 86381, 86746);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_86298_86747(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 86298, 86747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 86164, 86759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 86164, 86759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Management_Infrastructure_CimInstance___PartialCIMInstance()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 86771, 87571);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 86923, 87560);

                listYield.Add(f_1104_86936_87559("Microsoft.Management.Infrastructure.CimInstance#__PartialCIMInstance", f_1104_87050_87558(f_1104_87050_87527(f_1104_87050_87494(f_1104_87050_87457(f_1104_87050_87146(f_1104_87050_87107(f_1104_87050_87072())), @"
                                            $str = $_ | Microsoft.PowerShell.Utility\Format-List -Property * | Microsoft.PowerShell.Utility\Out-String
                                            $str
                                        "))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 86771, 87571);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1104_87050_87072()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 87050, 87072);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1104_87050_87107(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 87050, 87107);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1104_87050_87146(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.StartFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 87050, 87146);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1104_87050_87457(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 87050, 87457);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1104_87050_87494(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 87050, 87494);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1104_87050_87527(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 87050, 87527);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1104_87050_87558(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 87050, 87558);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_86936_87559(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 86936, 87559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 86771, 87571);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 86771, 87571);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Threading_Tasks_Task()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1104, 87583, 89816);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 87910, 88519);

                listYield.Add(f_1104_87923_88518("System.Threading.Tasks.Task", f_1104_88014_88517(f_1104_88014_88484(f_1104_88014_88439(f_1104_88014_88381(f_1104_88014_88318(f_1104_88014_88264(f_1104_88014_88217(f_1104_88014_88164(f_1104_88014_88106(f_1104_88014_88057(), label: "Id"), label: "IsCompleted"), label: "Status")), "Id"), "IsCompleted"), "Status")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1104, 88535, 89805);

                listYield.Add(f_1104_88548_89804("System.Threading.Tasks.Task", f_1104_88639_89803(f_1104_88639_89771(f_1104_88639_89734(f_1104_88639_89677(f_1104_88639_89356(f_1104_88639_89296(f_1104_88639_89222(f_1104_88639_89160(f_1104_88639_89099(f_1104_88639_89046(f_1104_88639_88986(f_1104_88639_88920(f_1104_88639_88847(f_1104_88639_88781(f_1104_88639_88720(f_1104_88639_88681()), @"AsyncState"), @"AsyncWaitHandle"), @"CompletedSynchronously"), @"CreationOptions"), @"Exception"), @"Id"), @"IsCanceled"), @"IsCompleted"), @"IsCompletedSuccessfully"), @"IsFaulted"), @"
                                    if ($_.IsCompleted) {
                                        $_.Result
                                    }
                                ", label: "Result"), @"Status")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1104, 87583, 89816);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1104_88014_88057()
                {
                    var return_v = TableControl
                                        .Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88014, 88057);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_88014_88106(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88014, 88106);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_88014_88164(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88014, 88164);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_88014_88217(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88014, 88217);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_88014_88264(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88014, 88264);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_88014_88318(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88014, 88318);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_88014_88381(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88014, 88381);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1104_88014_88439(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88014, 88439);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1104_88014_88484(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88014, 88484);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1104_88014_88517(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88014, 88517);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_87923_88518(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 87923, 88518);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_88639_88681()
                {
                    var return_v = ListControl
                                        .Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 88681);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_88639_88720(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 88720);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_88639_88781(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 88781);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_88639_88847(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 88847);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_88639_88920(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 88920);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_88639_88986(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 88986);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_88639_89046(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 89046);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_88639_89099(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 89099);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_88639_89160(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 89160);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_88639_89222(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 89222);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_88639_89296(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 89296);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_88639_89356(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 89356);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_88639_89677(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 89677);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1104_88639_89734(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 89734);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1104_88639_89771(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 89771);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1104_88639_89803(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88639, 89803);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1104_88548_89804(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1104, 88548, 89804);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1104, 87583, 89816);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 87583, 89816);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public DotNetTypes_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1104, 194, 89823);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1104, 194, 89823);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 194, 89823);
        }


        static DotNetTypes_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1104, 194, 89823);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1104, 194, 89823);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1104, 194, 89823);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1104, 194, 89823);
    }
}
