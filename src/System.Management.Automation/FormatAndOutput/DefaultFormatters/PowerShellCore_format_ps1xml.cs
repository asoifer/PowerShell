// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation.Runspaces
{
    internal sealed class PowerShellCore_Format_Ps1Xml
    {
        internal static IEnumerable<ExtendedTypeDefinition> GetFormatData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 261, 13217);

                var listYield = new List<ExtendedTypeDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 353, 908);

                var
                AvailableModules_GroupingFormat = f_1109_391_907(f_1109_391_876(f_1109_391_843(f_1109_391_806(f_1109_391_577(f_1109_391_487(f_1109_391_448(f_1109_391_413())), f_1109_526_576()), @"Split-Path -Parent $_.Path | ForEach-Object { if([Version]::TryParse((Split-Path $_ -Leaf), [ref]$null)) { Split-Path -Parent $_} else {$_} } | Split-Path -Parent"))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 924, 1031);

                var
                sharedControls = new CustomControl[] {
                AvailableModules_GroupingFormat
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 1047, 1174);

                listYield.Add(f_1109_1060_1173("System.RuntimeType", f_1109_1144_1172()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 1190, 1373);

                listYield.Add(f_1109_1203_1372("Microsoft.PowerShell.Commands.MemberDefinition", f_1109_1315_1371()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 1389, 1558);

                listYield.Add(f_1109_1402_1557("Microsoft.PowerShell.Commands.GroupInfo", f_1109_1507_1556()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 1574, 1761);

                listYield.Add(f_1109_1587_1760("Microsoft.PowerShell.Commands.GroupInfoNoElement", f_1109_1701_1759()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 1777, 1950);

                listYield.Add(f_1109_1790_1949("Microsoft.PowerShell.Commands.HistoryInfo", f_1109_1897_1948()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 1966, 2135);

                listYield.Add(f_1109_1979_2134("Microsoft.PowerShell.Commands.MatchInfo", f_1109_2084_2133()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 2151, 2320);

                listYield.Add(f_1109_2164_2319("System.Management.Automation.PSVariable", f_1109_2269_2318()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 2336, 2501);

                listYield.Add(f_1109_2349_2500("System.Management.Automation.PathInfo", f_1109_2452_2499()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 2517, 2688);

                listYield.Add(f_1109_2530_2687("System.Management.Automation.CommandInfo", f_1109_2636_2686()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 2704, 3124);

                var
                td10 = f_1109_2715_3123("System.Management.Automation.AliasInfo", f_1109_2819_3122())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 3138, 3205);

                f_1109_3138_3204(f_1109_3138_3152(td10), "System.Management.Automation.ApplicationInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 3219, 3281);

                f_1109_3219_3280(f_1109_3219_3233(td10), "System.Management.Automation.CmdletInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 3295, 3365);

                f_1109_3295_3364(f_1109_3295_3309(td10), "System.Management.Automation.ExternalScriptInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 3379, 3441);

                f_1109_3379_3440(f_1109_3379_3393(td10), "System.Management.Automation.FilterInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 3455, 3519);

                f_1109_3455_3518(f_1109_3455_3469(td10), "System.Management.Automation.FunctionInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 3533, 3595);

                f_1109_3533_3594(f_1109_3533_3547(td10), "System.Management.Automation.ScriptInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 3609, 3627);

                listYield.Add(td10);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 3643, 3828);

                listYield.Add(f_1109_3656_3827("System.Management.Automation.Runspaces.TypeData", f_1109_3769_3826()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 3844, 4027);

                listYield.Add(f_1109_3857_4026("Microsoft.PowerShell.Commands.ControlPanelItem", f_1109_3969_4025()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 4043, 4222);

                listYield.Add(f_1109_4056_4221("System.Management.Automation.ApplicationInfo", f_1109_4166_4220()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 4238, 4407);

                listYield.Add(f_1109_4251_4406("System.Management.Automation.ScriptInfo", f_1109_4356_4405()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 4423, 4608);

                listYield.Add(f_1109_4436_4607("System.Management.Automation.ExternalScriptInfo", f_1109_4549_4606()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 4624, 4797);

                listYield.Add(f_1109_4637_4796("System.Management.Automation.FunctionInfo", f_1109_4744_4795()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 4813, 4982);

                listYield.Add(f_1109_4826_4981("System.Management.Automation.FilterInfo", f_1109_4931_4980()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 4998, 5165);

                listYield.Add(f_1109_5011_5164("System.Management.Automation.AliasInfo", f_1109_5115_5163()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 5181, 5376);

                listYield.Add(f_1109_5194_5375("Microsoft.PowerShell.Commands.ListCommand+MemberInfo", f_1109_5312_5374()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 5392, 5656);

                var
                td20 = f_1109_5403_5655("Microsoft.PowerShell.Commands.ActiveDirectoryProvider+ADPSDriveInfo", f_1109_5536_5654())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 5670, 5733);

                f_1109_5670_5732(f_1109_5670_5684(td20), "System.Management.Automation.PSDriveInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 5747, 5765);

                listYield.Add(td20);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 5781, 5954);

                listYield.Add(f_1109_5794_5953("System.Management.Automation.ProviderInfo", f_1109_5901_5952()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 5970, 6139);

                listYield.Add(f_1109_5983_6138("System.Management.Automation.CmdletInfo", f_1109_6088_6137()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 6155, 6364);

                var
                td23 = f_1109_6166_6363("System.Management.Automation.FilterInfo", f_1109_6271_6362())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 6378, 6442);

                f_1109_6378_6441(f_1109_6378_6392(td23), "System.Management.Automation.FunctionInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 6456, 6474);

                listYield.Add(td23);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 6490, 6661);

                listYield.Add(f_1109_6503_6660("System.Management.Automation.PSDriveInfo", f_1109_6609_6659()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 6677, 6852);

                listYield.Add(f_1109_6690_6851("System.Management.Automation.ShellVariable", f_1109_6798_6850()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 6868, 7039);

                listYield.Add(f_1109_6881_7038("System.Management.Automation.ScriptBlock", f_1109_6987_7037()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 7055, 7246);

                var
                extendedError = f_1109_7075_7245("System.Management.Automation.ErrorRecord#PSExtendedError", f_1109_7197_7244())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 7260, 7324);

                f_1109_7260_7323(f_1109_7260_7283(extendedError), "System.Exception#PSExtendedError");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 7338, 7365);

                listYield.Add(extendedError);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 7381, 7567);

                var
                errorRecord_Exception = f_1109_7409_7566("System.Management.Automation.ErrorRecord", f_1109_7515_7565())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 7581, 7616);

                listYield.Add(errorRecord_Exception);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 7632, 7807);

                listYield.Add(f_1109_7645_7806("System.Management.Automation.WarningRecord", f_1109_7753_7805()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 7823, 8024);

                listYield.Add(f_1109_7836_8023("Deserialized.System.Management.Automation.WarningRecord", f_1109_7957_8022()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 8040, 8223);

                listYield.Add(f_1109_8053_8222("System.Management.Automation.InformationRecord", f_1109_8165_8221()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 8239, 8434);

                listYield.Add(f_1109_8252_8433("System.Management.Automation.CommandParameterSetInfo", f_1109_8370_8432()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 8450, 8635);

                listYield.Add(f_1109_8463_8634("System.Management.Automation.Runspaces.Runspace", f_1109_8576_8633()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 8651, 8838);

                listYield.Add(f_1109_8664_8837("System.Management.Automation.Runspaces.PSSession", f_1109_8778_8836()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 8854, 9009);

                listYield.Add(f_1109_8867_9008("System.Management.Automation.Job", f_1109_8965_9007()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 9025, 9232);

                listYield.Add(f_1109_9038_9231("Deserialized.Microsoft.PowerShell.Commands.TextMeasureInfo", f_1109_9162_9230()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 9248, 9461);

                listYield.Add(f_1109_9261_9460("Deserialized.Microsoft.PowerShell.Commands.GenericMeasureInfo", f_1109_9388_9459()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 9477, 9654);

                listYield.Add(f_1109_9490_9653("System.Management.Automation.CallStackFrame", f_1109_9599_9652()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 9670, 9820);

                var
                td40 = f_1109_9681_9819("System.Management.Automation.CommandBreakpoint", f_1109_9793_9818())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 9834, 9900);

                f_1109_9834_9899(f_1109_9834_9848(td40), "System.Management.Automation.LineBreakpoint");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 9914, 9984);

                f_1109_9914_9983(f_1109_9914_9928(td40), "System.Management.Automation.VariableBreakpoint");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 9998, 10016);

                listYield.Add(td40);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 10032, 10289);

                listYield.Add(f_1109_10045_10288("Microsoft.PowerShell.Commands.PSSessionConfigurationCommands#PSSessionConfiguration", f_1109_10194_10287()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 10305, 10492);

                listYield.Add(f_1109_10318_10491("Microsoft.PowerShell.Commands.ComputerChangeInfo", f_1109_10432_10490()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 10508, 10707);

                listYield.Add(f_1109_10521_10706("Microsoft.PowerShell.Commands.RenameComputerChangeInfo", f_1109_10641_10705()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 10723, 10864);

                listYield.Add(f_1109_10736_10863("ModuleInfoGrouping", f_1109_10820_10862(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 10880, 11053);

                listYield.Add(f_1109_10893_11052("System.Management.Automation.PSModuleInfo", f_1109_11000_11051()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 11069, 11256);

                listYield.Add(f_1109_11082_11255("System.Management.Automation.ExperimentalFeature", f_1109_11196_11254()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 11272, 11473);

                var
                td46 = f_1109_11283_11472("Microsoft.PowerShell.Commands.BasicHtmlWebResponseObject", f_1109_11405_11471())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 11487, 11505);

                listYield.Add(td46);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 11521, 11706);

                listYield.Add(f_1109_11534_11705("Microsoft.PowerShell.Commands.WebResponseObject", f_1109_11647_11704()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 11722, 11896);

                listYield.Add(f_1109_11735_11895("Microsoft.PowerShell.Commands.FileHashInfo", f_1109_11843_11894()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 11912, 12093);

                listYield.Add(f_1109_11925_12092("Microsoft.PowerShell.Commands.PSRunspaceDebug", f_1109_12036_12091()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 12109, 12310);

                listYield.Add(f_1109_12122_12309("Microsoft.PowerShell.MarkdownRender.PSMarkdownOptionInfo", f_1109_12244_12308()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 12326, 12541);

                listYield.Add(f_1109_12339_12540("Microsoft.PowerShell.Commands.TestConnectionCommand+PingStatus", f_1109_12467_12539()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 12557, 12778);

                listYield.Add(f_1109_12570_12777("Microsoft.PowerShell.Commands.TestConnectionCommand+PingMtuStatus", f_1109_12701_12776()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 12794, 13011);

                listYield.Add(f_1109_12807_13010("Microsoft.PowerShell.Commands.TestConnectionCommand+TraceStatus", f_1109_12936_13009()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 13027, 13206);

                listYield.Add(f_1109_13040_13205("Microsoft.PowerShell.Commands.ByteCollection", f_1109_13150_13204()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 261, 13217);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1109_391_413()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 391, 413);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_391_448(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 391, 448);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_391_487(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.StartFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 391, 487);
                    return return_v;
                }


                string
                f_1109_526_576()
                {
                    var return_v = FileSystemProviderStrings.DirectoryDisplayGrouping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1109, 526, 576);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_391_577(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 391, 577);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_391_806(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 391, 806);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_391_843(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 391, 843);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1109_391_876(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 391, 876);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1109_391_907(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 391, 907);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_1144_1172()
                {
                    var return_v = ViewsOf_System_RuntimeType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 1144, 1172);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_1060_1173(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 1060, 1173);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_1315_1371()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_MemberDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 1315, 1371);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_1203_1372(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 1203, 1372);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_1507_1556()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_GroupInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 1507, 1556);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_1402_1557(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 1402, 1557);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_1701_1759()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_GroupInfoNoElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 1701, 1759);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_1587_1760(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 1587, 1760);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_1897_1948()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_HistoryInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 1897, 1948);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_1790_1949(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 1790, 1949);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_2084_2133()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_MatchInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 2084, 2133);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_1979_2134(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 1979, 2134);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_2269_2318()
                {
                    var return_v = ViewsOf_System_Management_Automation_PSVariable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 2269, 2318);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_2164_2319(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 2164, 2319);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_2452_2499()
                {
                    var return_v = ViewsOf_System_Management_Automation_PathInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 2452, 2499);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_2349_2500(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 2349, 2500);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_2636_2686()
                {
                    var return_v = ViewsOf_System_Management_Automation_CommandInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 2636, 2686);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_2530_2687(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 2530, 2687);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_2819_3122()
                {
                    var return_v = ViewsOf_System_Management_Automation_AliasInfo_System_Management_Automation_ApplicationInfo_System_Management_Automation_CmdletInfo_System_Management_Automation_ExternalScriptInfo_System_Management_Automation_FilterInfo_System_Management_Automation_FunctionInfo_System_Management_Automation_ScriptInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 2819, 3122);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_2715_3123(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 2715, 3123);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1109_3138_3152(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1109, 3138, 3152);
                    return return_v;
                }


                int
                f_1109_3138_3204(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 3138, 3204);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1109_3219_3233(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1109, 3219, 3233);
                    return return_v;
                }


                int
                f_1109_3219_3280(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 3219, 3280);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1109_3295_3309(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1109, 3295, 3309);
                    return return_v;
                }


                int
                f_1109_3295_3364(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 3295, 3364);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1109_3379_3393(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1109, 3379, 3393);
                    return return_v;
                }


                int
                f_1109_3379_3440(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 3379, 3440);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1109_3455_3469(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1109, 3455, 3469);
                    return return_v;
                }


                int
                f_1109_3455_3518(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 3455, 3518);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1109_3533_3547(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1109, 3533, 3547);
                    return return_v;
                }


                int
                f_1109_3533_3594(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 3533, 3594);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_3769_3826()
                {
                    var return_v = ViewsOf_System_Management_Automation_Runspaces_TypeData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 3769, 3826);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_3656_3827(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 3656, 3827);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_3969_4025()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_ControlPanelItem();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 3969, 4025);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_3857_4026(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 3857, 4026);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_4166_4220()
                {
                    var return_v = ViewsOf_System_Management_Automation_ApplicationInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 4166, 4220);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_4056_4221(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 4056, 4221);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_4356_4405()
                {
                    var return_v = ViewsOf_System_Management_Automation_ScriptInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 4356, 4405);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_4251_4406(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 4251, 4406);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_4549_4606()
                {
                    var return_v = ViewsOf_System_Management_Automation_ExternalScriptInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 4549, 4606);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_4436_4607(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 4436, 4607);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_4744_4795()
                {
                    var return_v = ViewsOf_System_Management_Automation_FunctionInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 4744, 4795);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_4637_4796(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 4637, 4796);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_4931_4980()
                {
                    var return_v = ViewsOf_System_Management_Automation_FilterInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 4931, 4980);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_4826_4981(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 4826, 4981);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_5115_5163()
                {
                    var return_v = ViewsOf_System_Management_Automation_AliasInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 5115, 5163);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_5011_5164(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 5011, 5164);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_5312_5374()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_ListCommand_MemberInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 5312, 5374);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_5194_5375(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 5194, 5375);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_5536_5654()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_ActiveDirectoryProvider_ADPSDriveInfo_System_Management_Automation_PSDriveInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 5536, 5654);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_5403_5655(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 5403, 5655);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1109_5670_5684(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1109, 5670, 5684);
                    return return_v;
                }


                int
                f_1109_5670_5732(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 5670, 5732);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_5901_5952()
                {
                    var return_v = ViewsOf_System_Management_Automation_ProviderInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 5901, 5952);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_5794_5953(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 5794, 5953);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_6088_6137()
                {
                    var return_v = ViewsOf_System_Management_Automation_CmdletInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 6088, 6137);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_5983_6138(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 5983, 6138);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_6271_6362()
                {
                    var return_v = ViewsOf_System_Management_Automation_FilterInfo_System_Management_Automation_FunctionInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 6271, 6362);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_6166_6363(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 6166, 6363);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1109_6378_6392(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1109, 6378, 6392);
                    return return_v;
                }


                int
                f_1109_6378_6441(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 6378, 6441);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_6609_6659()
                {
                    var return_v = ViewsOf_System_Management_Automation_PSDriveInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 6609, 6659);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_6503_6660(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 6503, 6660);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_6798_6850()
                {
                    var return_v = ViewsOf_System_Management_Automation_ShellVariable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 6798, 6850);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_6690_6851(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 6690, 6851);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_6987_7037()
                {
                    var return_v = ViewsOf_System_Management_Automation_ScriptBlock();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 6987, 7037);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_6881_7038(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 6881, 7038);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_7197_7244()
                {
                    var return_v = ViewsOf_System_Management_Automation_GetError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 7197, 7244);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_7075_7245(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 7075, 7245);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1109_7260_7283(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1109, 7260, 7283);
                    return return_v;
                }


                int
                f_1109_7260_7323(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 7260, 7323);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_7515_7565()
                {
                    var return_v = ViewsOf_System_Management_Automation_ErrorRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 7515, 7565);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_7409_7566(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 7409, 7566);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_7753_7805()
                {
                    var return_v = ViewsOf_System_Management_Automation_WarningRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 7753, 7805);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_7645_7806(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 7645, 7806);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_7957_8022()
                {
                    var return_v = ViewsOf_Deserialized_System_Management_Automation_WarningRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 7957, 8022);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_7836_8023(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 7836, 8023);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_8165_8221()
                {
                    var return_v = ViewsOf_System_Management_Automation_InformationRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 8165, 8221);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_8053_8222(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 8053, 8222);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_8370_8432()
                {
                    var return_v = ViewsOf_System_Management_Automation_CommandParameterSetInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 8370, 8432);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_8252_8433(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 8252, 8433);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_8576_8633()
                {
                    var return_v = ViewsOf_System_Management_Automation_Runspaces_Runspace();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 8576, 8633);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_8463_8634(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 8463, 8634);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_8778_8836()
                {
                    var return_v = ViewsOf_System_Management_Automation_Runspaces_PSSession();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 8778, 8836);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_8664_8837(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 8664, 8837);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_8965_9007()
                {
                    var return_v = ViewsOf_System_Management_Automation_Job();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 8965, 9007);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_8867_9008(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 8867, 9008);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_9162_9230()
                {
                    var return_v = ViewsOf_Deserialized_Microsoft_PowerShell_Commands_TextMeasureInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 9162, 9230);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_9038_9231(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 9038, 9231);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_9388_9459()
                {
                    var return_v = ViewsOf_Deserialized_Microsoft_PowerShell_Commands_GenericMeasureInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 9388, 9459);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_9261_9460(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 9261, 9460);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_9599_9652()
                {
                    var return_v = ViewsOf_System_Management_Automation_CallStackFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 9599, 9652);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_9490_9653(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 9490, 9653);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_9793_9818()
                {
                    var return_v = ViewsOf_BreakpointTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 9793, 9818);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_9681_9819(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 9681, 9819);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1109_9834_9848(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1109, 9834, 9848);
                    return return_v;
                }


                int
                f_1109_9834_9899(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 9834, 9899);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1109_9914_9928(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1109, 9914, 9928);
                    return return_v;
                }


                int
                f_1109_9914_9983(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 9914, 9983);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_10194_10287()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_PSSessionConfigurationCommands_PSSessionConfiguration();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 10194, 10287);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_10045_10288(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 10045, 10288);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_10432_10490()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_ComputerChangeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 10432, 10490);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_10318_10491(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 10318, 10491);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_10641_10705()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_RenameComputerChangeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 10641, 10705);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_10521_10706(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 10521, 10706);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_10820_10862(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_ModuleInfoGrouping(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 10820, 10862);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_10736_10863(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 10736, 10863);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_11000_11051()
                {
                    var return_v = ViewsOf_System_Management_Automation_PSModuleInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 11000, 11051);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_10893_11052(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 10893, 11052);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_11196_11254()
                {
                    var return_v = ViewsOf_System_Management_Automation_ExperimentalFeature();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 11196, 11254);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_11082_11255(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 11082, 11255);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_11405_11471()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_BasicHtmlWebResponseObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 11405, 11471);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_11283_11472(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 11283, 11472);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_11647_11704()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_WebResponseObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 11647, 11704);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_11534_11705(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 11534, 11705);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_11843_11894()
                {
                    var return_v = ViewsOf_Microsoft_Powershell_Utility_FileHashInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 11843, 11894);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_11735_11895(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 11735, 11895);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_12036_12091()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_PSRunspaceDebug();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 12036, 12091);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_11925_12092(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 11925, 12092);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_12244_12308()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_MarkdownRender_MarkdownOptionInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 12244, 12308);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_12122_12309(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 12122, 12309);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_12467_12539()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_TestConnectionCommand_PingStatus();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 12467, 12539);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_12339_12540(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 12339, 12540);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_12701_12776()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_TestConnectionCommand_PingMtuStatus();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 12701, 12776);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_12570_12777(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 12570, 12777);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_12936_13009()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_TestConnectionCommand_TraceStatus();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 12936, 13009);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_12807_13010(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 12807, 13010);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1109_13150_13204()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_ByteCollection();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13150, 13204);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1109_13040_13205(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13040, 13205);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 261, 13217);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 261, 13217);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_RuntimeType()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 13229, 13980);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 13331, 13969);

                listYield.Add(f_1109_13344_13968("System.RuntimeType", f_1109_13408_13967(f_1109_13408_13938(f_1109_13408_13897(f_1109_13408_13841(f_1109_13408_13789(f_1109_13408_13727(f_1109_13408_13671(f_1109_13408_13628(f_1109_13408_13594(f_1109_13408_13551(f_1109_13408_13490(f_1109_13408_13429(), label: "IsPublic", width: 8), label: "IsSerial", width: 8), width: 40))), "IsPublic"), "IsSerializable"), "Name"), "BaseType")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 13229, 13980);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_13408_13429()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13408, 13429);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_13408_13490(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13408, 13490);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_13408_13551(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13408, 13551);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_13408_13594(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13408, 13594);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_13408_13628(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13408, 13628);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_13408_13671(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13408, 13671);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_13408_13727(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13408, 13727);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_13408_13789(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13408, 13789);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_13408_13841(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13408, 13841);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_13408_13897(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13408, 13897);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_13408_13938(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13408, 13938);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_13408_13967(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13408, 13967);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_13344_13968(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 13344, 13968);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 13229, 13980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 13229, 13980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_MemberDefinition()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 13992, 14759);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 14122, 14748);

                listYield.Add(f_1109_14135_14747("Microsoft.PowerShell.Commands.MemberDefinition", f_1109_14227_14746(f_1109_14227_14717(f_1109_14227_14676(f_1109_14227_14618(f_1109_14227_14560(f_1109_14227_14508(f_1109_14227_14465(f_1109_14227_14412(f_1109_14227_14359(f_1109_14227_14312(f_1109_14227_14262(autoSize: true), "TypeName"), label: "Name"), label: "MemberType"), label: "Definition")), "Name"), "MemberType"), "Definition")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 13992, 14759);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_14227_14262(bool
                autoSize)
                {
                    var return_v = TableControl.Create(autoSize: autoSize);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14227, 14262);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_14227_14312(System.Management.Automation.TableControlBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.GroupByProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14227, 14312);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_14227_14359(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14227, 14359);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_14227_14412(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14227, 14412);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_14227_14465(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14227, 14465);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_14227_14508(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14227, 14508);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_14227_14560(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14227, 14560);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_14227_14618(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14227, 14618);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_14227_14676(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14227, 14676);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_14227_14717(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14227, 14717);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_14227_14746(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14227, 14746);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_14135_14747(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14135, 14747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 13992, 14759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 13992, 14759);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_GroupInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 14771, 15889);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 14894, 15438);

                listYield.Add(f_1109_14907_15437("Microsoft.PowerShell.Commands.GroupInfo", f_1109_14992_15436(f_1109_14992_15407(f_1109_14992_15366(f_1109_14992_15313(f_1109_14992_15261(f_1109_14992_15208(f_1109_14992_15165(f_1109_14992_15131(f_1109_14992_15088(f_1109_14992_15013(), Alignment.Right, label: "Count", width: 5), width: 25))), "Count"), "Name"), "Group")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 15454, 15878);

                listYield.Add(f_1109_15467_15877("Microsoft.PowerShell.Commands.GroupInfo", f_1109_15552_15876(f_1109_15552_15848(f_1109_15552_15815(f_1109_15552_15762(f_1109_15552_15710(f_1109_15552_15658(f_1109_15552_15607(f_1109_15552_15572()), @"Name"), @"Count"), @"Group"), @"Values")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 14771, 15889);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_14992_15013()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14992, 15013);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_14992_15088(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14992, 15088);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_14992_15131(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14992, 15131);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_14992_15165(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14992, 15165);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_14992_15208(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14992, 15208);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_14992_15261(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14992, 15261);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_14992_15313(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14992, 15313);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_14992_15366(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14992, 15366);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_14992_15407(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14992, 15407);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_14992_15436(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14992, 15436);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_14907_15437(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 14907, 15437);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_15552_15572()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 15552, 15572);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_15552_15607(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 15552, 15607);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_15552_15658(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 15552, 15658);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_15552_15710(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 15552, 15710);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_15552_15762(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 15552, 15762);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_15552_15815(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 15552, 15815);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_15552_15848(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 15552, 15848);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_15552_15876(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 15552, 15876);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_15467_15877(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 15467, 15877);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 14771, 15889);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 14771, 15889);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_GroupInfoNoElement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 15901, 16907);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 16033, 16499);

                listYield.Add(f_1109_16046_16498("Microsoft.PowerShell.Commands.GroupInfoNoElement", f_1109_16140_16497(f_1109_16140_16468(f_1109_16140_16427(f_1109_16140_16375(f_1109_16140_16322(f_1109_16140_16279(f_1109_16140_16236(f_1109_16140_16161(), Alignment.Right, label: "Count", width: 5), width: 25)), "Count"), "Name")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 16515, 16896);

                listYield.Add(f_1109_16528_16895("Microsoft.PowerShell.Commands.GroupInfoNoElement", f_1109_16622_16894(f_1109_16622_16866(f_1109_16622_16833(f_1109_16622_16780(f_1109_16622_16728(f_1109_16622_16677(f_1109_16622_16642()), @"Name"), @"Count"), @"Values")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 15901, 16907);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_16140_16161()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16140, 16161);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_16140_16236(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16140, 16236);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_16140_16279(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16140, 16279);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_16140_16322(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16140, 16322);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_16140_16375(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16140, 16375);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_16140_16427(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16140, 16427);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_16140_16468(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16140, 16468);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_16140_16497(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16140, 16497);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_16046_16498(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16046, 16498);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_16622_16642()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16622, 16642);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_16622_16677(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16622, 16677);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_16622_16728(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16622, 16728);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_16622_16780(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16622, 16780);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_16622_16833(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16622, 16833);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_16622_16866(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16622, 16866);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_16622_16894(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16622, 16894);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_16528_16895(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 16528, 16895);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 15901, 16907);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 15901, 16907);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_HistoryInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 16919, 18606);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 17044, 18402);

                listYield.Add(f_1109_17057_18401("history", f_1109_17110_18400(f_1109_17110_18371(f_1109_17110_18330(f_1109_17110_18271(f_1109_17110_17396(f_1109_17110_17346(f_1109_17110_17303(f_1109_17110_17269(f_1109_17110_17190(f_1109_17110_17131(), Alignment.Right, width: 4), Alignment.Right, label: "Duration", width: 12))), "Id"), @"
                                if ($_.Duration.TotalHours -ge 10) {
                                    return ""{0}:{1:mm}:{1:ss}.{1:fff}"" -f [int]$_.Duration.TotalHours, $_.Duration
                                }
                                elseif ($_.Duration.TotalHours -ge 1) {
                                    $formatString = ""h\:mm\:ss\.fff""
                                }
                                elseif ($_.Duration.TotalMinutes -ge 1) {
                                    $formatString = ""m\:ss\.fff""
                                }
                                else {
                                    $formatString = ""s\.fff""
                                }

                                $_.Duration.ToString($formatString)
                              "), "CommandLine")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 18418, 18595);

                listYield.Add(f_1109_18431_18594("history", f_1109_18484_18593(f_1109_18484_18558(f_1109_18484_18504(), "CommandLine"))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 16919, 18606);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_17110_17131()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 17110, 17131);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_17110_17190(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 17110, 17190);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_17110_17269(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 17110, 17269);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_17110_17303(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 17110, 17303);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_17110_17346(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 17110, 17346);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_17110_17396(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 17110, 17396);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_17110_18271(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 17110, 18271);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_17110_18330(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 17110, 18330);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_17110_18371(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 17110, 18371);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_17110_18400(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 17110, 18400);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_17057_18401(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 17057, 18401);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1109_18484_18504()
                {
                    var return_v = WideControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 18484, 18504);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1109_18484_18558(System.Management.Automation.WideControlBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyEntry(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 18484, 18558);
                    return return_v;
                }


                System.Management.Automation.WideControl
                f_1109_18484_18593(System.Management.Automation.WideControlBuilder
                this_param)
                {
                    var return_v = this_param.EndWideControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 18484, 18593);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_18431_18594(string
                name, System.Management.Automation.WideControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 18431, 18594);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 16919, 18606);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 16919, 18606);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_MatchInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 18618, 19050);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 18741, 19039);

                listYield.Add(f_1109_18754_19038("MatchInfo", f_1109_18809_19037(f_1109_18809_19006(f_1109_18809_18973(f_1109_18809_18866(f_1109_18809_18831()), @"$_.ToEmphasizedString(((get-location).path))")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 18618, 19050);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1109_18809_18831()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 18809, 18831);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_18809_18866(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 18809, 18866);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_18809_18973(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 18809, 18973);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1109_18809_19006(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 18809, 19006);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1109_18809_19037(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 18809, 19037);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_18754_19038(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 18754, 19038);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 18618, 19050);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 18618, 19050);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_PSVariable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 19062, 19581);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 19185, 19570);

                listYield.Add(f_1109_19198_19569("Variable", f_1109_19252_19568(f_1109_19252_19539(f_1109_19252_19498(f_1109_19252_19445(f_1109_19252_19393(f_1109_19252_19350(f_1109_19252_19316(f_1109_19252_19273(), width: 30))), "Name"), "Value")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 19062, 19581);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_19252_19273()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19252, 19273);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_19252_19316(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19252, 19316);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_19252_19350(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19252, 19350);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_19252_19393(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19252, 19393);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_19252_19445(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19252, 19445);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_19252_19498(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19252, 19498);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_19252_19539(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19252, 19539);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_19252_19568(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19252, 19568);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_19198_19569(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19198, 19569);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 19062, 19581);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 19062, 19581);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_PathInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 19593, 20014);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 19714, 20003);

                listYield.Add(f_1109_19727_20002("PathInfo", f_1109_19781_20001(f_1109_19781_19972(f_1109_19781_19931(f_1109_19781_19879(f_1109_19781_19836(f_1109_19781_19802())), "Path")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 19593, 20014);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_19781_19802()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19781, 19802);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_19781_19836(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19781, 19836);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_19781_19879(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19781, 19879);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_19781_19931(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19781, 19931);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_19781_19972(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19781, 19972);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_19781_20001(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19781, 20001);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_19727_20002(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 19727, 20002);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 19593, 20014);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 19593, 20014);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_CommandInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 20026, 20555);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 20150, 20544);

                listYield.Add(f_1109_20163_20543("CommandInfo", f_1109_20220_20542(f_1109_20220_20513(f_1109_20220_20472(f_1109_20220_20420(f_1109_20220_20361(f_1109_20220_20318(f_1109_20220_20284(f_1109_20220_20241(), width: 15))), "CommandType"), "Name")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 20026, 20555);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_20220_20241()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 20220, 20241);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_20220_20284(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 20220, 20284);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_20220_20318(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 20220, 20318);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_20220_20361(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 20220, 20361);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_20220_20420(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 20220, 20420);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_20220_20472(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 20220, 20472);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_20220_20513(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 20220, 20513);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_20220_20542(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 20220, 20542);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_20163_20543(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 20163, 20543);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 20026, 20555);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 20026, 20555);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_AliasInfo_System_Management_Automation_ApplicationInfo_System_Management_Automation_CmdletInfo_System_Management_Automation_ExternalScriptInfo_System_Management_Automation_FilterInfo_System_Management_Automation_FunctionInfo_System_Management_Automation_ScriptInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 20567, 21984);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 20944, 21973);

                listYield.Add(f_1109_20957_21972("CommandInfo", f_1109_21014_21971(f_1109_21014_21942(f_1109_21014_21901(f_1109_21014_21847(f_1109_21014_21792(f_1109_21014_21370(f_1109_21014_21311(f_1109_21014_21268(f_1109_21014_21219(f_1109_21014_21158(f_1109_21014_21100(f_1109_21014_21035(), label: "CommandType", width: 15), label: "Name", width: 50), label: "Version", width: 10), label: "Source")), "CommandType"), @"
                                if ($_.CommandType -eq ""Alias"")
                                {
                                  $_.DisplayName
                                }
                                else
                                {
                                  $_.Name
                                }
                              "), "Version"), "Source")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 20567, 21984);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_21014_21035()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 21014, 21035);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_21014_21100(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 21014, 21100);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_21014_21158(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 21014, 21158);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_21014_21219(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 21014, 21219);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_21014_21268(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 21014, 21268);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_21014_21311(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 21014, 21311);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_21014_21370(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 21014, 21370);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_21014_21792(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 21014, 21792);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_21014_21847(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 21014, 21847);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_21014_21901(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 21014, 21901);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_21014_21942(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 21014, 21942);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_21014_21971(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 21014, 21971);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_20957_21972(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 20957, 21972);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 20567, 21984);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 20567, 21984);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_Runspaces_TypeData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 21996, 22553);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 22127, 22542);

                listYield.Add(f_1109_22140_22541("TypeData", f_1109_22194_22540(f_1109_22194_22511(f_1109_22194_22470(f_1109_22194_22415(f_1109_22194_22359(f_1109_22194_22316(f_1109_22194_22266(f_1109_22194_22215(), label: "TypeName"), label: "Members")), "TypeName"), "Members")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 21996, 22553);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_22194_22215()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22194, 22215);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_22194_22266(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22194, 22266);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_22194_22316(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22194, 22316);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_22194_22359(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22194, 22359);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_22194_22415(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22194, 22415);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_22194_22470(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22194, 22470);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_22194_22511(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22194, 22511);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_22194_22540(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22194, 22540);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_22140_22541(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22140, 22541);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 21996, 22553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 21996, 22553);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_ControlPanelItem()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 22565, 23353);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 22695, 23342);

                listYield.Add(f_1109_22708_23341("ControlPanelItem", f_1109_22770_23340(f_1109_22770_23311(f_1109_22770_23270(f_1109_22770_23211(f_1109_22770_23155(f_1109_22770_23094(f_1109_22770_23042(f_1109_22770_22999(f_1109_22770_22945(f_1109_22770_22894(f_1109_22770_22838(f_1109_22770_22791(), label: "Name"), label: "CanonicalName"), label: "Category"), label: "Description")), "Name"), "CanonicalName"), "Category"), "Description")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 22565, 23353);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_22770_22791()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22770, 22791);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_22770_22838(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22770, 22838);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_22770_22894(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22770, 22894);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_22770_22945(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22770, 22945);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_22770_22999(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22770, 22999);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_22770_23042(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22770, 23042);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_22770_23094(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22770, 23094);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_22770_23155(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22770, 23155);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_22770_23211(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22770, 23211);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_22770_23270(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22770, 23270);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_22770_23311(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22770, 23311);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_22770_23340(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22770, 23340);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_22708_23341(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 22708, 23341);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 22565, 23353);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 22565, 23353);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ApplicationInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 23365, 24560);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 23493, 23977);

                listYield.Add(f_1109_23506_23976("ApplicationInfo", f_1109_23567_23975(f_1109_23567_23946(f_1109_23567_23905(f_1109_23567_23853(f_1109_23567_23801(f_1109_23567_23742(f_1109_23567_23699(f_1109_23567_23665(f_1109_23567_23631(f_1109_23567_23588(), width: 15)))), "CommandType"), "Name"), "Path")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 23993, 24549);

                listYield.Add(f_1109_24006_24548("System.Management.Automation.ApplicationInfo", f_1109_24096_24547(f_1109_24096_24519(f_1109_24096_24486(f_1109_24096_24424(f_1109_24096_24373(f_1109_24096_24317(f_1109_24096_24260(f_1109_24096_24202(f_1109_24096_24151(f_1109_24096_24116()), @"Name"), @"CommandType"), @"Definition"), @"Extension"), @"Path"), @"FileVersionInfo")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 23365, 24560);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_23567_23588()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 23567, 23588);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_23567_23631(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 23567, 23631);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_23567_23665(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 23567, 23665);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_23567_23699(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 23567, 23699);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_23567_23742(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 23567, 23742);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_23567_23801(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 23567, 23801);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_23567_23853(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 23567, 23853);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_23567_23905(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 23567, 23905);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_23567_23946(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 23567, 23946);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_23567_23975(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 23567, 23975);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_23506_23976(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 23506, 23976);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_24096_24116()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24096, 24116);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_24096_24151(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24096, 24151);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_24096_24202(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24096, 24202);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_24096_24260(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24096, 24260);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_24096_24317(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24096, 24317);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_24096_24373(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24096, 24373);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_24096_24424(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24096, 24424);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_24096_24486(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24096, 24486);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_24096_24519(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24096, 24519);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_24096_24547(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24096, 24547);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_24006_24548(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24006, 24548);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 23365, 24560);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 23365, 24560);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ScriptInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 24572, 25640);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 24695, 25180);

                listYield.Add(f_1109_24708_25179("ScriptInfo", f_1109_24764_25178(f_1109_24764_25149(f_1109_24764_25108(f_1109_24764_25050(f_1109_24764_24998(f_1109_24764_24939(f_1109_24764_24896(f_1109_24764_24862(f_1109_24764_24828(f_1109_24764_24785(), width: 15)))), "CommandType"), "Name"), "Definition")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 25196, 25629);

                listYield.Add(f_1109_25209_25628("System.Management.Automation.ScriptInfo", f_1109_25294_25627(f_1109_25294_25599(f_1109_25294_25566(f_1109_25294_25515(f_1109_25294_25458(f_1109_25294_25400(f_1109_25294_25349(f_1109_25294_25314()), @"Name"), @"CommandType"), @"Definition"), @"Path")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 24572, 25640);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_24764_24785()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24764, 24785);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_24764_24828(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24764, 24828);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_24764_24862(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24764, 24862);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_24764_24896(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24764, 24896);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_24764_24939(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24764, 24939);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_24764_24998(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24764, 24998);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_24764_25050(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24764, 25050);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_24764_25108(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24764, 25108);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_24764_25149(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24764, 25149);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_24764_25178(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24764, 25178);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_24708_25179(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 24708, 25179);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_25294_25314()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25294, 25314);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_25294_25349(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25294, 25349);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_25294_25400(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25294, 25400);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_25294_25458(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25294, 25458);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_25294_25515(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25294, 25515);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_25294_25566(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25294, 25566);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_25294_25599(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25294, 25599);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_25294_25627(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25294, 25627);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_25209_25628(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25209, 25628);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 24572, 25640);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 24572, 25640);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ExternalScriptInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 25652, 26281);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 25783, 26270);

                listYield.Add(f_1109_25796_26269("ExternalScriptInfo", f_1109_25860_26268(f_1109_25860_26239(f_1109_25860_26198(f_1109_25860_26146(f_1109_25860_26094(f_1109_25860_26035(f_1109_25860_25992(f_1109_25860_25958(f_1109_25860_25924(f_1109_25860_25881(), width: 15)))), "CommandType"), "Name"), "Path")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 25652, 26281);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_25860_25881()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25860, 25881);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_25860_25924(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25860, 25924);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_25860_25958(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25860, 25958);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_25860_25992(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25860, 25992);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_25860_26035(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25860, 26035);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_25860_26094(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25860, 26094);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_25860_26146(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25860, 26146);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_25860_26198(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25860, 26198);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_25860_26239(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25860, 26239);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_25860_26268(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25860, 26268);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_25796_26269(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 25796, 26269);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 25652, 26281);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 25652, 26281);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_FunctionInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 26293, 26914);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 26418, 26903);

                listYield.Add(f_1109_26431_26902("FunctionInfo", f_1109_26489_26901(f_1109_26489_26872(f_1109_26489_26831(f_1109_26489_26775(f_1109_26489_26723(f_1109_26489_26664(f_1109_26489_26621(f_1109_26489_26587(f_1109_26489_26553(f_1109_26489_26510(), width: 15)))), "CommandType"), "Name"), "Function")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 26293, 26914);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_26489_26510()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 26489, 26510);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_26489_26553(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 26489, 26553);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_26489_26587(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 26489, 26587);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_26489_26621(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 26489, 26621);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_26489_26664(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 26489, 26664);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_26489_26723(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 26489, 26723);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_26489_26775(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 26489, 26775);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_26489_26831(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 26489, 26831);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_26489_26872(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 26489, 26872);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_26489_26901(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 26489, 26901);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_26431_26902(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 26431, 26902);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 26293, 26914);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 26293, 26914);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_FilterInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 26926, 27541);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 27049, 27530);

                listYield.Add(f_1109_27062_27529("FilterInfo", f_1109_27118_27528(f_1109_27118_27499(f_1109_27118_27458(f_1109_27118_27404(f_1109_27118_27352(f_1109_27118_27293(f_1109_27118_27250(f_1109_27118_27216(f_1109_27118_27182(f_1109_27118_27139(), width: 15)))), "CommandType"), "Name"), "Filter")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 26926, 27541);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_27118_27139()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27118, 27139);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_27118_27182(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27118, 27182);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_27118_27216(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27118, 27216);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_27118_27250(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27118, 27250);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_27118_27293(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27118, 27293);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_27118_27352(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27118, 27352);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_27118_27404(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27118, 27404);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_27118_27458(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27118, 27458);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_27118_27499(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27118, 27499);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_27118_27528(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27118, 27528);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_27062_27529(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27062, 27529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 26926, 27541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 26926, 27541);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_AliasInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 27553, 28615);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 27675, 28074);

                listYield.Add(f_1109_27688_28073("AliasInfo", f_1109_27743_28072(f_1109_27743_28043(f_1109_27743_28002(f_1109_27743_27943(f_1109_27743_27884(f_1109_27743_27841(f_1109_27743_27807(f_1109_27743_27764(), width: 15))), "CommandType"), "DisplayName")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 28090, 28604);

                listYield.Add(f_1109_28103_28603("System.Management.Automation.AliasInfo", f_1109_28187_28602(f_1109_28187_28574(f_1109_28187_28541(f_1109_28187_28479(f_1109_28187_28415(f_1109_28187_28358(f_1109_28187_28300(f_1109_28187_28242(f_1109_28187_28207()), @"DisplayName"), @"CommandType"), @"Definition"), @"ReferencedCommand"), @"ResolvedCommand")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 27553, 28615);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_27743_27764()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27743, 27764);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_27743_27807(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27743, 27807);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_27743_27841(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27743, 27841);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_27743_27884(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27743, 27884);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_27743_27943(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27743, 27943);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_27743_28002(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27743, 28002);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_27743_28043(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27743, 28043);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_27743_28072(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27743, 28072);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_27688_28073(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 27688, 28073);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_28187_28207()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28187, 28207);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_28187_28242(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28187, 28242);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_28187_28300(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28187, 28300);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_28187_28358(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28187, 28358);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_28187_28415(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28187, 28415);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_28187_28479(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28187, 28479);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_28187_28541(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28187, 28541);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_28187_28574(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28187, 28574);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_28187_28602(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28187, 28602);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_28103_28603(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28103, 28603);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 27553, 28615);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 27553, 28615);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_ListCommand_MemberInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 28627, 29695);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 28763, 29273);

                listYield.Add(f_1109_28776_29272("memberinfo", f_1109_28832_29271(f_1109_28832_29242(f_1109_28832_29201(f_1109_28832_29143(f_1109_28832_29091(f_1109_28832_29032(f_1109_28832_28989(f_1109_28832_28955(f_1109_28832_28912(f_1109_28832_28853(), label: "Class", width: 11), width: 25))), "MemberClass"), "Name"), "MemberData")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 29289, 29684);

                listYield.Add(f_1109_29302_29683("Microsoft.PowerShell.Commands.ListCommand+MemberInfo", f_1109_29400_29682(f_1109_29400_29654(f_1109_29400_29621(f_1109_29400_29564(f_1109_29400_29506(f_1109_29400_29455(f_1109_29400_29420()), @"Name"), @"MemberClass"), @"MemberData")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 28627, 29695);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_28832_28853()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28832, 28853);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_28832_28912(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28832, 28912);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_28832_28955(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28832, 28955);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_28832_28989(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28832, 28989);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_28832_29032(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28832, 29032);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_28832_29091(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28832, 29091);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_28832_29143(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28832, 29143);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_28832_29201(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28832, 29201);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_28832_29242(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28832, 29242);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_28832_29271(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28832, 29271);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_28776_29272(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 28776, 29272);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_29400_29420()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29400, 29420);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_29400_29455(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29400, 29455);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_29400_29506(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29400, 29506);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_29400_29564(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29400, 29564);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_29400_29621(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29400, 29621);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_29400_29654(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29400, 29654);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_29400_29682(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29400, 29682);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_29302_29683(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29302, 29683);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 28627, 29695);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 28627, 29695);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_ActiveDirectoryProvider_ADPSDriveInfo_System_Management_Automation_PSDriveInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 29707, 31042);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 29899, 31031);

                listYield.Add(f_1109_29912_31030("drive", f_1109_29963_31029(f_1109_29963_31000(f_1109_29963_30959(f_1109_29963_30868(f_1109_29963_30753(f_1109_29963_30686(f_1109_29963_30544(f_1109_29963_30402(f_1109_29963_30350(f_1109_29963_30307(f_1109_29963_30273(f_1109_29963_30215(f_1109_29963_30153(f_1109_29963_30090(f_1109_29963_30027(f_1109_29963_29984(), width: 10), label: "Used (GB)", width: 13), label: "Free (GB)", width: 13), label: "Provider", width: 13), label: "Root", width: 35))), "Name"), @"if($_.Used -or $_.Free) { ""{0:###0.00}"" -f ($_.Used / 1GB) }", alignment: Alignment.Right), @"if($_.Used -or $_.Free) { ""{0:###0.00}"" -f ($_.Free / 1GB) }", alignment: Alignment.Right), "$_.Provider.Name"), "if($null -ne $_.DisplayRoot) { $_.DisplayRoot } else { $_.Root }"), "CurrentLocation", alignment: Alignment.Right)))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 29707, 31042);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_29963_29984()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 29984);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_29963_30027(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 30027);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_29963_30090(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 30090);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_29963_30153(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 30153);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_29963_30215(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 30215);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_29963_30273(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 30273);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_29963_30307(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 30307);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_29963_30350(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 30350);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_29963_30402(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 30402);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_29963_30544(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock, System.Management.Automation.Alignment
                alignment)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock, alignment: alignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 30544);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_29963_30686(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock, System.Management.Automation.Alignment
                alignment)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock, alignment: alignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 30686);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_29963_30753(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 30753);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_29963_30868(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 30868);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_29963_30959(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName, System.Management.Automation.Alignment
                alignment)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName, alignment: alignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 30959);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_29963_31000(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 31000);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_29963_31029(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29963, 31029);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_29912_31030(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 29912, 31030);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 29707, 31042);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 29707, 31042);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ProviderInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 31054, 32316);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 31179, 31659);

                listYield.Add(f_1109_31192_31658("provider", f_1109_31246_31657(f_1109_31246_31628(f_1109_31246_31587(f_1109_31246_31533(f_1109_31246_31473(f_1109_31246_31421(f_1109_31246_31378(f_1109_31246_31344(f_1109_31246_31310(f_1109_31246_31267(), width: 20)))), "Name"), "Capabilities"), "Drives")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 31675, 32305);

                listYield.Add(f_1109_31688_32304("provider", f_1109_31742_32303(f_1109_31742_32275(f_1109_31742_32242(f_1109_31742_32183(f_1109_31742_32120(f_1109_31742_32061(f_1109_31742_32003(f_1109_31742_31952(f_1109_31742_31901(f_1109_31742_31848(f_1109_31742_31797(f_1109_31742_31762()), @"Name"), @"Drives"), @"Path"), @"Home"), @"Description"), @"Capabilities"), @"ImplementingType"), @"AssemblyInfo")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 31054, 32316);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_31246_31267()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31246, 31267);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_31246_31310(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31246, 31310);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_31246_31344(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31246, 31344);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_31246_31378(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31246, 31378);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_31246_31421(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31246, 31421);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_31246_31473(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31246, 31473);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_31246_31533(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31246, 31533);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_31246_31587(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31246, 31587);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_31246_31628(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31246, 31628);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_31246_31657(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31246, 31657);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_31192_31658(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31192, 31658);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_31742_31762()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31742, 31762);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_31742_31797(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31742, 31797);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_31742_31848(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31742, 31848);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_31742_31901(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31742, 31901);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_31742_31952(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31742, 31952);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_31742_32003(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31742, 32003);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_31742_32061(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31742, 32061);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_31742_32120(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31742, 32120);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_31742_32183(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31742, 32183);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_31742_32242(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31742, 32242);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_31742_32275(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31742, 32275);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_31742_32303(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31742, 32303);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_31688_32304(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 31688, 32304);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 31054, 32316);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 31054, 32316);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_CmdletInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 32328, 33284);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 32451, 33273);

                listYield.Add(f_1109_32464_33272("System.Management.Automation.CmdletInfo", f_1109_32549_33271(f_1109_32549_33243(f_1109_32549_33210(f_1109_32549_33159(f_1109_32549_33108(f_1109_32549_33045(f_1109_32549_32985(f_1109_32549_32930(f_1109_32549_32880(f_1109_32549_32821(f_1109_32549_32770(f_1109_32549_32713(f_1109_32549_32655(f_1109_32549_32604(f_1109_32549_32569()), @"Name"), @"CommandType"), @"Definition"), @"Path"), @"AssemblyInfo"), @"DLL"), @"HelpFile"), @"ParameterSets"), @"ImplementingType"), @"Verb"), @"Noun")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 32328, 33284);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1109_32549_32569()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 32569);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_32549_32604(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 32604);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_32549_32655(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 32655);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_32549_32713(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 32713);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_32549_32770(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 32770);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_32549_32821(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 32821);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_32549_32880(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 32880);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_32549_32930(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 32930);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_32549_32985(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 32985);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_32549_33045(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 33045);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_32549_33108(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 33108);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_32549_33159(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 33159);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_32549_33210(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 33210);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_32549_33243(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 33243);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_32549_33271(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32549, 33271);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_32464_33272(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 32464, 33272);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 32328, 33284);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 32328, 33284);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_FilterInfo_System_Management_Automation_FunctionInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 33296, 33855);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 33461, 33844);

                listYield.Add(f_1109_33474_33843("System.Management.Automation.CommandInfo", f_1109_33560_33842(f_1109_33560_33814(f_1109_33560_33781(f_1109_33560_33724(f_1109_33560_33666(f_1109_33560_33615(f_1109_33560_33580()), @"Name"), @"CommandType"), @"Definition")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 33296, 33855);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1109_33560_33580()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 33560, 33580);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_33560_33615(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 33560, 33615);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_33560_33666(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 33560, 33666);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_33560_33724(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 33560, 33724);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_33560_33781(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 33560, 33781);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_33560_33814(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 33560, 33814);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_33560_33842(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 33560, 33842);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_33474_33843(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 33474, 33843);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 33296, 33855);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 33296, 33855);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_PSDriveInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 33867, 34496);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 33991, 34485);

                listYield.Add(f_1109_34004_34484("System.Management.Automation.PSDriveInfo", f_1109_34090_34483(f_1109_34090_34455(f_1109_34090_34422(f_1109_34090_34360(f_1109_34090_34309(f_1109_34090_34254(f_1109_34090_34196(f_1109_34090_34145(f_1109_34090_34110()), @"Name"), @"Description"), @"Provider"), @"Root"), @"CurrentLocation")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 33867, 34496);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1109_34090_34110()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34090, 34110);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_34090_34145(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34090, 34145);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_34090_34196(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34090, 34196);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_34090_34254(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34090, 34254);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_34090_34309(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34090, 34309);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_34090_34360(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34090, 34360);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_34090_34422(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34090, 34422);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_34090_34455(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34090, 34455);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_34090_34483(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34090, 34483);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_34004_34484(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34004, 34484);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 33867, 34496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 33867, 34496);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ShellVariable()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 34508, 34938);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 34634, 34927);

                listYield.Add(f_1109_34647_34926("ShellVariable", f_1109_34706_34925(f_1109_34706_34897(f_1109_34706_34864(f_1109_34706_34812(f_1109_34706_34761(f_1109_34706_34726()), @"Name"), @"Value")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 34508, 34938);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1109_34706_34726()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34706, 34726);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_34706_34761(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34706, 34761);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_34706_34812(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34706, 34812);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_34706_34864(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34706, 34864);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_34706_34897(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34706, 34897);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_34706_34925(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34706, 34925);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_34647_34926(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 34647, 34926);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 34508, 34938);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 34508, 34938);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ScriptBlock()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 34950, 35358);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 35074, 35347);

                listYield.Add(f_1109_35087_35346("ScriptBlock", f_1109_35144_35345(f_1109_35144_35314(f_1109_35144_35281(f_1109_35144_35216(f_1109_35144_35181(outOfBand: true)), @"$_")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 34950, 35358);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1109_35144_35181(bool
                outOfBand)
                {
                    var return_v = CustomControl.Create(outOfBand: outOfBand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 35144, 35181);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_35144_35216(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 35144, 35216);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_35144_35281(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 35144, 35281);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1109_35144_35314(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 35144, 35314);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1109_35144_35345(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 35144, 35345);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_35087_35346(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 35087, 35346);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 34950, 35358);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 34950, 35358);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_GetError()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 35605, 49137);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 35726, 49126);

                listYield.Add(f_1109_35739_49125("GetErrorInstance", f_1109_35801_49124(f_1109_35801_49093(f_1109_35801_49060(f_1109_35801_35933(f_1109_35801_35898(f_1109_35801_35823(), "PSErrorIndex", label: "ErrorIndex")), @"
                            Set-StrictMode -Off

                            $maxDepth = 10
                            $ellipsis = ""`u{2026}""
                            $resetColor = ''
                            if ($Host.UI.SupportsVirtualTerminal -and !(Test-Path env:__SuppressAnsiEscapeSequences)) {
                                $resetColor = [System.Management.Automation.VTUtility]::GetEscapeSequence(
                                    [System.Management.Automation.VTUtility+VT]::Reset
                                )
                            }

                            function Get-VT100Color([ConsoleColor] $color) {
                                if (!$Host.UI.SupportsVirtualTerminal -or (Test-Path env:__SuppressAnsiEscapeSequences)) {
                                    return ''
                                }

                                return [System.Management.Automation.VTUtility]::GetEscapeSequence($color)
                            }

                            function Show-ErrorRecord($obj, [int]$indent = 0, [int]$depth = 1) {
                                $newline = [Environment]::Newline
                                $output = [System.Text.StringBuilder]::new()
                                $prefix = ' ' * $indent
                                $accentColor = ''

                                if ($null -ne $Host.PrivateData) {
                                    $accentColor = Get-VT100Color ($Host.PrivateData.FormatAccentColor ?? $Host.PrivateData.ErrorForegroundColor)
                                }

                                $expandTypes = @(
                                    'Microsoft.Rest.HttpRequestMessageWrapper'
                                    'Microsoft.Rest.HttpResponseMessageWrapper'
                                    'System.Management.Automation.InvocationInfo'
                                )

                                # if object is an Exception, add an ExceptionType property
                                if ($obj -is [Exception]) {
                                    $obj | Add-Member -NotePropertyName Type -NotePropertyValue $obj.GetType().FullName -ErrorAction Ignore
                                }

                                # first find the longest property so we can indent properly
                                $propLength = 0
                                foreach ($prop in $obj.PSObject.Properties) {
                                    if ($prop.Value -ne $null -and $prop.Value -ne [string]::Empty -and $prop.Name.Length -gt $propLength) {
                                        $propLength = $prop.Name.Length
                                    }
                                }

                                $addedProperty = $false
                                foreach ($prop in $obj.PSObject.Properties) {

                                    # don't show empty properties or our added property for $error[index]
                                    if ($prop.Value -ne $null -and $prop.Value -ne [string]::Empty -and $prop.Value.count -gt 0 -and $prop.Name -ne 'PSErrorIndex') {
                                        $addedProperty = $true
                                        $null = $output.Append($prefix)
                                        $null = $output.Append($accentColor)
                                        $null = $output.Append($prop.Name)
                                        $propNameIndent = ' ' * ($propLength - $prop.Name.Length)
                                        $null = $output.Append($propNameIndent)
                                        $null = $output.Append(' : ')
                                        $null = $output.Append($resetColor)

                                        $newIndent = $indent + 4

                                        # only show nested objects that are Exceptions, ErrorRecords, or types defined in $expandTypes and types not in $ignoreTypes
                                        if ($prop.Value -is [Exception] -or $prop.Value -is [System.Management.Automation.ErrorRecord] -or
                                            $expandTypes -contains $prop.TypeNameOfValue -or ($prop.TypeNames -ne $null -and $expandTypes -contains $prop.TypeNames[0])) {

                                            if ($depth -ge $maxDepth) {
                                                $null = $output.Append($ellipsis)
                                            }
                                            else {
                                                $null = $output.Append($newline)
                                                $null = $output.Append((Show-ErrorRecord $prop.Value $newIndent ($depth + 1)))
                                            }
                                        }
                                        # `TargetSite` has many members that are not useful visually, so we have a reduced view of the relevant members
                                        elseif ($prop.Name -eq 'TargetSite' -and $prop.Value.GetType().Name -eq 'RuntimeMethodInfo') {
                                            if ($depth -ge $maxDepth) {
                                                $null = $output.Append($ellipsis)
                                            }
                                            else {
                                                $targetSite = [PSCustomObject]@{
                                                    Name = $prop.Value.Name
                                                    DeclaringType = $prop.Value.DeclaringType
                                                    MemberType = $prop.Value.MemberType
                                                    Module = $prop.Value.Module
                                                }

                                                $null = $output.Append($newline)
                                                $null = $output.Append((Show-ErrorRecord $targetSite $newIndent ($depth + 1)))
                                            }
                                        }
                                        # `StackTrace` is handled specifically because the lines are typically long but necessary so they are left justified without additional indentation
                                        elseif ($prop.Name -eq 'StackTrace') {
                                            # for a stacktrace which is usually quite wide with info, we left justify it
                                            $null = $output.Append($newline)
                                            $null = $output.Append($prop.Value)
                                        }
                                        # Dictionary and Hashtable we want to show as Key/Value pairs, we don't do the extra whitespace alignment here
                                        elseif ($prop.Value.GetType().Name.StartsWith('Dictionary') -or $prop.Value.GetType().Name -eq 'Hashtable') {
                                            $isFirstElement = $true
                                            foreach ($key in $prop.Value.Keys) {
                                                if ($isFirstElement) {
                                                    $null = $output.Append($newline)
                                                }

                                                if ($key -eq 'Authorization') {
                                                    $null = $output.Append(""${prefix}    ${accentColor}${key} : ${resetColor}${ellipsis}${newline}"")
                                                }
                                                else {
                                                    $null = $output.Append(""${prefix}    ${accentColor}${key} : ${resetColor}$($prop.Value[$key])${newline}"")
                                                }

                                                $isFirstElement = $false
                                            }
                                        }
                                        # if the object implements IEnumerable and not a string, we try to show each object
                                        # We ignore the `Data` property as it can contain lots of type information by the interpreter that isn't useful here
                                        elseif (!($prop.Value -is [System.String]) -and $prop.Value.GetType().GetInterface('IEnumerable') -ne $null -and $prop.Name -ne 'Data') {

                                            if ($depth -ge $maxDepth) {
                                                $null = $output.Append($ellipsis)
                                            }
                                            else {
                                                $isFirstElement = $true
                                                foreach ($value in $prop.Value) {
                                                    $null = $output.Append($newline)
                                                    if (!$isFirstElement) {
                                                        $null = $output.Append($newline)
                                                    }
                                                    $null = $output.Append((Show-ErrorRecord $value $newIndent ($depth + 1)))
                                                    $isFirstElement = $false
                                                }
                                            }
                                        }
                                        # Anything else, we convert to string.
                                        # ToString() can throw so we use LanguagePrimitives.TryConvertTo() to hide a convert error
                                        else {
                                            $value = $null
                                            if ([System.Management.Automation.LanguagePrimitives]::TryConvertTo($prop.Value, [string], [ref]$value) -and $value -ne $null)
                                            {
                                                $isFirstLine = $true
                                                if ($value.Contains($newline)) {
                                                    # the 3 is to account for ' : '
                                                    $valueIndent = ' ' * ($propLength + 3)
                                                    # need to trim any extra whitespace already in the text
                                                    foreach ($line in $value.Split($newline)) {
                                                        if (!$isFirstLine) {
                                                            $null = $output.Append(""${newline}${prefix}${valueIndent}"")
                                                        }
                                                        $null = $output.Append($line.Trim())
                                                        $isFirstLine = $false
                                                    }
                                                }
                                                else {
                                                    $null = $output.Append($value)
                                                }
                                            }
                                        }

                                        $null = $output.Append($newline)
                                    }
                                }

                                # if we had added nested properties, we need to remove the last newline
                                if ($addedProperty) {
                                    $null = $output.Remove($output.Length - $newline.Length, $newline.Length)
                                }

                                $output.ToString()
                            }

                            # Add back original typename and remove PSExtendedError
                            if ($_.PSObject.TypeNames.Contains('System.Management.Automation.ErrorRecord#PSExtendedError')) {
                                $_.PSObject.TypeNames.Add('System.Management.Automation.ErrorRecord')
                                $null = $_.PSObject.TypeNames.Remove('System.Management.Automation.ErrorRecord#PSExtendedError')
                            }
                            elseif ($_.PSObject.TypeNames.Contains('System.Exception#PSExtendedError')) {
                                $_.PSObject.TypeNames.Add('System.Exception')
                                $null = $_.PSObject.TypeNames.Remove('System.Exception#PSExtendedError')
                            }

                            Show-ErrorRecord $_
                        ")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 35605, 49137);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1109_35801_35823()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 35801, 35823);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1109_35801_35898(System.Management.Automation.CustomControlBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.GroupByProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 35801, 35898);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_35801_35933(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 35801, 35933);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_35801_49060(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 35801, 49060);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1109_35801_49093(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 35801, 49093);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1109_35801_49124(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 35801, 49124);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_35739_49125(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 35739, 49125);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 35605, 49137);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 35605, 49137);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ErrorRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 49149, 72092);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 49273, 72081);

                listYield.Add(f_1109_49286_72080("ErrorInstance", f_1109_49345_72079(f_1109_49345_72048(f_1109_49345_72015(f_1109_49345_52542(f_1109_49345_49417(f_1109_49345_49382(outOfBand: true)), @"
                                    if (@('NativeCommandErrorMessage','NativeCommandError') -notcontains $_.FullyQualifiedErrorId -and @('CategoryView','ConciseView') -notcontains $ErrorView)
                                    {
                                        $myinv = $_.InvocationInfo
                                        if ($myinv -and $myinv.MyCommand)
                                        {
                                            switch -regex ( $myinv.MyCommand.CommandType )
                                            {
                                                ([System.Management.Automation.CommandTypes]::ExternalScript)
                                                {
                                                    if ($myinv.MyCommand.Path)
                                                    {
                                                        $myinv.MyCommand.Path + ' : '
                                                    }

                                                    break
                                                }

                                                ([System.Management.Automation.CommandTypes]::Script)
                                                {
                                                    if ($myinv.MyCommand.ScriptBlock)
                                                    {
                                                        $myinv.MyCommand.ScriptBlock.ToString() + ' : '
                                                    }

                                                    break
                                                }
                                                default
                                                {
                                                    if ($myinv.InvocationName -match '^[&\.]?$')
                                                    {
                                                        if ($myinv.MyCommand.Name)
                                                        {
                                                            $myinv.MyCommand.Name + ' : '
                                                        }
                                                    }
                                                    else
                                                    {
                                                        $myinv.InvocationName + ' : '
                                                    }

                                                    break
                                                }
                                            }
                                        }
                                        elseif ($myinv -and $myinv.InvocationName)
                                        {
                                            $myinv.InvocationName + ' : '
                                        }
                                    }
                                "), @"
                                    Set-StrictMode -Off
                                    $newline = [Environment]::Newline

                                    function Get-ConciseViewPositionMessage {

                                        $resetColor = ''
                                        if ($Host.UI.SupportsVirtualTerminal -and !(Test-Path env:__SuppressAnsiEscapeSequences)) {
                                            $resetColor = [System.Management.Automation.VTUtility]::GetEscapeSequence(
                                                [System.Management.Automation.VTUtility+VT]::Reset
                                            )
                                        }

                                        function Get-VT100Color([ConsoleColor] $color) {
                                            if (!$Host.UI.SupportsVirtualTerminal -or (Test-Path env:__SuppressAnsiEscapeSequences)) {
                                                return ''
                                            }

                                            return [System.Management.Automation.VTUtility]::GetEscapeSequence($color)
                                        }

                                        # return length of string sans VT100 codes
                                        function Get-RawStringLength($string) {
                                            $vtCodes = ""`e[0m"", ""`e[2;30m"", ""`e[2;31m"", ""`e[2;32m"", ""`e[2;33m"", ""`e[2;34m"",
                                                ""`e[2;35m"", ""`e[2;36m"", ""`e[2;37m"", ""`e[1;30m"", ""`e[1;31m"", ""`e[1;32m"",
                                                ""`e[1;33m"", ""`e[1;34m"", ""`e[1;35m"", ""`e[1;36m"", ""`e[1;37m""

                                            $newString = $string
                                            foreach ($vtCode in $vtCodes) {
                                                $newString = $newString.Replace($vtCode, '')
                                            }

                                            return $newString.Length
                                        }

                                        # returns a string cut to last whitespace
                                        function Get-TruncatedString($string, [int]$length) {

                                            if ($string.Length -le $length) {
                                                return $string
                                            }

                                            return ($string.Substring(0,$length) -split '\s',-2)[0]
                                        }

                                        $errorColor = ''
                                        $accentColor = ''

                                        if ($null -ne $Host.PrivateData) {
                                            $errorColor = Get-VT100Color $Host.PrivateData.ErrorForegroundColor
                                            $accentColor = Get-VT100Color ($Host.PrivateData.ErrorAccentColor ?? $errorColor)
                                        }

                                        $posmsg = ''
                                        $headerWhitespace = ''
                                        $offsetWhitespace = ''
                                        $message = ''
                                        $prefix = ''

                                        if ($myinv -and $myinv.ScriptName -or $myinv.ScriptLineNumber -gt 1 -or $err.CategoryInfo.Category -eq 'ParserError') {
                                            $useTargetObject = $false

                                            # Handle case where there is a TargetObject and we can show the error at the target rather than the script source
                                            if ($_.TargetObject.Line -and $_.TargetObject.LineText) {
                                                $posmsg = ""${resetcolor}$($_.TargetObject.File)${newline}""
                                                $useTargetObject = $true
                                            }
                                            elseif ($myinv.ScriptName) {
                                                if ($env:TERM_PROGRAM -eq 'vscode') {
                                                    # If we are running in vscode, we know the file:line:col links are clickable so we use this format
                                                    $posmsg = ""${resetcolor}$($myinv.ScriptName):$($myinv.ScriptLineNumber):$($myinv.OffsetInLine)${newline}""
                                                }
                                                else {
                                                    $posmsg = ""${resetcolor}$($myinv.ScriptName):$($myinv.ScriptLineNumber)${newline}""
                                                }
                                            }
                                            else {
                                                $posmsg = ""${newline}""
                                            }

                                            if ($useTargetObject) {
                                                $scriptLineNumber = $_.TargetObject.Line
                                                $scriptLineNumberLength = $_.TargetObject.Line.ToString().Length
                                            }
                                            else {
                                                $scriptLineNumber = $myinv.ScriptLineNumber
                                                $scriptLineNumberLength = $myinv.ScriptLineNumber.ToString().Length
                                            }

                                            if ($scriptLineNumberLength -gt 4) {
                                                $headerWhitespace = ' ' * ($scriptLineNumberLength - 4)
                                            }

                                            $lineWhitespace = ''
                                            if ($scriptLineNumberLength -lt 4) {
                                                $lineWhitespace = ' ' * (4 - $scriptLineNumberLength)
                                            }

                                            $verticalBar = '|'
                                            $posmsg += ""${accentColor}${headerWhitespace}Line ${verticalBar}${newline}""

                                            $highlightLine = ''
                                            if ($useTargetObject) {
                                                $line = $_.TargetObject.LineText.Trim()
                                                $offsetLength = 0
                                                $offsetInLine = 0
                                            }
                                            else {
                                                $positionMessage = $myinv.PositionMessage.Split($newline)
                                                $line = $positionMessage[1].Substring(1) # skip the '+' at the start
                                                $highlightLine = $positionMessage[$positionMessage.Count - 1].Substring(1)
                                                $offsetLength = $highlightLine.Trim().Length
                                                $offsetInLine = $highlightLine.IndexOf('~')
                                            }

                                            if (-not $line.EndsWith($newline)) {
                                                $line += $newline
                                            }

                                            # don't color the whole line
                                            if ($offsetLength -lt $line.Length - 1) {
                                                $line = $line.Insert($offsetInLine + $offsetLength, $resetColor).Insert($offsetInLine, $accentColor)
                                            }

                                            $posmsg += ""${accentColor}${lineWhitespace}${ScriptLineNumber} ${verticalBar} ${resetcolor}${line}""
                                            $offsetWhitespace = ' ' * $offsetInLine
                                            $prefix = ""${accentColor}${headerWhitespace}     ${verticalBar} ${errorColor}""
                                            if ($highlightLine -ne '') {
                                                $posMsg += ""${prefix}${highlightLine}${newline}""
                                            }
                                            $message = ""${prefix}""
                                        }

                                        if (! $err.ErrorDetails -or ! $err.ErrorDetails.Message) {
                                            if ($err.CategoryInfo.Category -eq 'ParserError' -and $err.Exception.Message.Contains(""~$newline"")) {
                                                # need to parse out the relevant part of the pre-rendered positionmessage
                                                $message += $err.Exception.Message.split(""~$newline"")[1].split(""${newline}${newline}"")[0]
                                            }
                                            elseif ($err.Exception) {
                                                $message += $err.Exception.Message
                                            }
                                            elseif ($err.Message) {
                                                $message += $err.Message
                                            }
                                            else {
                                                $message += $err.ToString()
                                            }
                                        }
                                        else {
                                            $message += $err.ErrorDetails.Message
                                        }

                                        # if rendering line information, break up the message if it's wider than the console
                                        if ($myinv -and $myinv.ScriptName -or $err.CategoryInfo.Category -eq 'ParserError') {
                                            $prefixLength = Get-RawStringLength -string $prefix
                                            $prefixVtLength = $prefix.Length - $prefixLength

                                            # replace newlines in message so it lines up correct
                                            $message = $message.Replace($newline, ' ').Replace(""`t"", ' ')

                                            $windowWidth = 120
                                            if ($Host.UI.RawUI -ne $null) {
                                                $windowWidth = $Host.UI.RawUI.WindowSize.Width
                                            }

                                            if ($windowWidth -gt 0 -and ($message.Length - $prefixVTLength) -gt $windowWidth) {
                                                $sb = [Text.StringBuilder]::new()
                                                $substring = Get-TruncatedString -string $message -length ($windowWidth + $prefixVTLength)
                                                $null = $sb.Append($substring)
                                                $remainingMessage = $message.Substring($substring.Length).Trim()
                                                $null = $sb.Append($newline)
                                                while (($remainingMessage.Length + $prefixLength) -gt $windowWidth) {
                                                    $subMessage = $prefix + $remainingMessage
                                                    $substring = Get-TruncatedString -string $subMessage -length ($windowWidth + $prefixVtLength)

                                                    if ($substring.Length - $prefix.Length -gt 0)
                                                    {
                                                        $null = $sb.Append($substring)
                                                        $null = $sb.Append($newline)
                                                        $remainingMessage = $remainingMessage.Substring($substring.Length - $prefix.Length).Trim()
                                                    }
                                                    else
                                                    {
                                                        break
                                                    }
                                                }
                                                $null = $sb.Append($prefix + $remainingMessage.Trim())
                                                $message = $sb.ToString()
                                            }

                                            $message += $newline
                                        }

                                        $posmsg += ""${errorColor}"" + $message

                                        $reason = 'Error'
                                        if ($err.Exception -and $err.Exception.WasThrownFromThrowStatement) {
                                            $reason = 'Exception'
                                        }
                                        # MyCommand can be the script block, so we don't want to show that so check if it's an actual command
                                        elseif ($myinv.MyCommand -and (Get-Command -Name $myinv.MyCommand -ErrorAction Ignore))
                                        {
                                            $reason = $myinv.MyCommand
                                        }
                                        # If it's a scriptblock, better to show the command in the scriptblock that had the error
                                        elseif ($_.CategoryInfo.Activity) {
                                            $reason = $_.CategoryInfo.Activity
                                        }
                                        elseif ($myinv.MyCommand) {
                                            $reason = $myinv.MyCommand
                                        }
                                        elseif ($myinv.InvocationName) {
                                            $reason = $myinv.InvocationName
                                        }
                                        elseif ($err.CategoryInfo.Category) {
                                            $reason = $err.CategoryInfo.Category
                                        }
                                        elseif ($err.CategoryInfo.Reason) {
                                            $reason = $err.CategoryInfo.Reason
                                        }

                                        $errorMsg = 'Error'

                                        ""${errorColor}${reason}: ${posmsg}${resetcolor}""
                                    }

                                    $myinv = $_.InvocationInfo
                                    $err = $_
                                    if (!$myinv -and $_.ErrorRecord -and $_.ErrorRecord.InvocationInfo) {
                                        $err = $_.ErrorRecord
                                        $myinv = $err.InvocationInfo
                                    }

                                    if ($err.FullyQualifiedErrorId -eq 'NativeCommandErrorMessage' -or $err.FullyQualifiedErrorId -eq 'NativeCommandError') {
                                        $err.Exception.Message
                                    }
                                    else
                                    {
                                        $myinv = $err.InvocationInfo
                                        if ($ErrorView -eq 'ConciseView') {
                                            $posmsg = Get-ConciseViewPositionMessage
                                        }
                                        elseif ($myinv -and ($myinv.MyCommand -or ($err.CategoryInfo.Category -ne 'ParserError'))) {
                                            $posmsg = $myinv.PositionMessage
                                        } else {
                                            $posmsg = ''
                                        }

                                        if ($posmsg -ne '')
                                        {
                                            $posmsg = $newline + $posmsg
                                        }

                                        if ($err.PSMessageDetails) {
                                            $posmsg = ' : ' +  $err.PSMessageDetails + $posmsg
                                        }

                                        if ($ErrorView -eq 'ConciseView') {
                                            return $posmsg
                                        }

                                        $indent = 4

                                        $errorCategoryMsg = $err.ErrorCategory_Message

                                        if ($null -ne $errorCategoryMsg)
                                        {
                                            $indentString = '+ CategoryInfo          : ' + $err.ErrorCategory_Message
                                        }
                                        else
                                        {
                                            $indentString = '+ CategoryInfo          : ' + $err.CategoryInfo
                                        }

                                        $posmsg += $newline + $indentString

                                        $indentString = ""+ FullyQualifiedErrorId : "" + $err.FullyQualifiedErrorId
                                        $posmsg += $newline + $indentString

                                        $originInfo = $err.OriginInfo

                                        if (($null -ne $originInfo) -and ($null -ne $originInfo.PSComputerName))
                                        {
                                            $indentString = ""+ PSComputerName        : "" + $originInfo.PSComputerName
                                            $posmsg += $newline + $indentString
                                        }

                                        if ($ErrorView -eq 'CategoryView') {
                                            $err.CategoryInfo.GetMessage()
                                        }
                                        elseif (! $err.ErrorDetails -or ! $err.ErrorDetails.Message) {
                                            $err.Exception.Message + $posmsg + $newline
                                        } else {
                                            $err.ErrorDetails.Message + $posmsg
                                        }
                                    }
                                ")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 49149, 72092);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1109_49345_49382(bool
                outOfBand)
                {
                    var return_v = CustomControl.Create(outOfBand: outOfBand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 49345, 49382);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_49345_49417(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 49345, 49417);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_49345_52542(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 49345, 52542);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_49345_72015(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 49345, 72015);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1109_49345_72048(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 49345, 72048);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1109_49345_72079(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 49345, 72079);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_49286_72080(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 49286, 72080);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 49149, 72092);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 49149, 72092);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_WarningRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 72104, 72518);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 72230, 72507);

                listYield.Add(f_1109_72243_72506("WarningRecord", f_1109_72302_72505(f_1109_72302_72474(f_1109_72302_72441(f_1109_72302_72374(f_1109_72302_72339(outOfBand: true)), @"Message")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 72104, 72518);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1109_72302_72339(bool
                outOfBand)
                {
                    var return_v = CustomControl.Create(outOfBand: outOfBand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 72302, 72339);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_72302_72374(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 72302, 72374);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_72302_72441(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 72302, 72441);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1109_72302_72474(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 72302, 72474);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1109_72302_72505(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 72302, 72505);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_72243_72506(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 72243, 72506);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 72104, 72518);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 72104, 72518);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Deserialized_System_Management_Automation_WarningRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 72530, 72989);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 72669, 72978);

                listYield.Add(f_1109_72682_72977("DeserializedWarningRecord", f_1109_72753_72976(f_1109_72753_72945(f_1109_72753_72912(f_1109_72753_72825(f_1109_72753_72790(outOfBand: true)), @"InformationalRecord_Message")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 72530, 72989);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1109_72753_72790(bool
                outOfBand)
                {
                    var return_v = CustomControl.Create(outOfBand: outOfBand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 72753, 72790);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_72753_72825(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 72753, 72825);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_72753_72912(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 72753, 72912);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1109_72753_72945(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 72753, 72945);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1109_72753_72976(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 72753, 72976);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_72682_72977(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 72682, 72977);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 72530, 72989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 72530, 72989);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_InformationRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 73001, 73432);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 73131, 73421);

                listYield.Add(f_1109_73144_73420("InformationRecord", f_1109_73207_73419(f_1109_73207_73388(f_1109_73207_73355(f_1109_73207_73279(f_1109_73207_73244(outOfBand: true)), @"$_.ToString()")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 73001, 73432);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1109_73207_73244(bool
                outOfBand)
                {
                    var return_v = CustomControl.Create(outOfBand: outOfBand);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73207, 73244);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73207_73279(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73207, 73279);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73207_73355(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73207, 73355);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1109_73207_73388(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73207, 73388);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1109_73207_73419(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73207, 73419);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_73144_73420(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73144, 73420);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 73001, 73432);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 73001, 73432);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_CommandParameterSetInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 73444, 77145);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 73580, 73863);

                var
                FmtParameterAttributes = f_1109_73609_73862(f_1109_73609_73831(f_1109_73609_73798(f_1109_73609_73761(f_1109_73609_73718(f_1109_73609_73666(f_1109_73609_73631()), leftIndent: 2)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 73879, 76411);

                var
                FmtParameterInfo = f_1109_73902_76410(f_1109_73902_76379(f_1109_73902_76346(f_1109_73902_76309(f_1109_73902_76268(f_1109_73902_76124(f_1109_73902_76077(f_1109_73902_76019(f_1109_73902_75972(f_1109_73902_75897(f_1109_73902_75841(f_1109_73902_75794(f_1109_73902_75699(f_1109_73902_75623(f_1109_73902_75576(f_1109_73902_75477(f_1109_73902_75397(f_1109_73902_75350(f_1109_73902_75265(f_1109_73902_75199(f_1109_73902_75152(f_1109_73902_75073(f_1109_73902_75013(f_1109_73902_74966(f_1109_73902_74889(f_1109_73902_74831(f_1109_73902_74784(f_1109_73902_74705(f_1109_73902_74645(f_1109_73902_74598(f_1109_73902_74522(f_1109_73902_74465(f_1109_73902_74418(f_1109_73902_74337(f_1109_73902_74275(f_1109_73902_74219(f_1109_73902_74176(f_1109_73902_74108(f_1109_73902_74050(f_1109_73902_73998(f_1109_73902_73959(f_1109_73902_73924())), leftIndent: 2), "Parameter Name: "), @"Name")), leftIndent: 2), "ParameterType = "), @"ParameterType")), "Position = "), @"Position")), "IsMandatory = "), @"IsMandatory")), "IsDynamic = "), @"IsDynamic")), "HelpMessage = "), @"HelpMessage")), "ValueFromPipeline = "), @"ValueFromPipeline")), "ValueFromPipelineByPropertyName = "), @"ValueFromPipelineByPropertyName")), "ValueFromRemainingArguments = "), @"ValueFromRemainingArguments")), "Aliases = "), @"Aliases")), "Attributes =")), @"Attributes", enumerateCollection: true, customControl: FmtParameterAttributes)))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 76427, 77134);

                listYield.Add(f_1109_76440_77133("CommandParameterSetInfo", f_1109_76509_77132(f_1109_76509_77101(f_1109_76509_77068(f_1109_76509_77029(f_1109_76509_76899(f_1109_76509_76860(f_1109_76509_76791(f_1109_76509_76727(f_1109_76509_76688(f_1109_76509_76624(f_1109_76509_76566(f_1109_76509_76531()), "Parameter Set Name: "), @"Name")), "Is default parameter set: "), @"IsDefault")), @"Parameters", enumerateCollection: true, customControl: FmtParameterInfo))))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 73444, 77145);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1109_73609_73631()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73609, 73631);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73609_73666(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73609, 73666);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73609_73718(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73609, 73718);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73609_73761(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73609, 73761);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73609_73798(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73609, 73798);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1109_73609_73831(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73609, 73831);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1109_73609_73862(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73609, 73862);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1109_73902_73924()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 73924);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_73959(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 73959);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_73998(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 73998);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74050(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74050);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74108(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74108);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74176(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74176);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74219(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74219);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74275(System.Management.Automation.CustomEntryBuilder
                this_param, int
                leftIndent)
                {
                    var return_v = this_param.StartFrame(leftIndent: (uint)leftIndent);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74275);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74337(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74337);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74418(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74418);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74465(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74465);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74522(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74522);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74598(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74598);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74645(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74645);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74705(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74705);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74784(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74784);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74831(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74831);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74889(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74889);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_74966(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 74966);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75013(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75013);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75073(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75073);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75152(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75152);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75199(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75199);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75265(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75265);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75350(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75350);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75397(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75397);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75477(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75477);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75576(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75576);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75623(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75623);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75699(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75699);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75794(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75794);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75841(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75841);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75897(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75897);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_75972(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 75972);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_76019(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 76019);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_76077(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 76077);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_76124(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 76124);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_76268(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 76268);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_76309(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 76309);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_73902_76346(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 76346);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1109_73902_76379(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 76379);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1109_73902_76410(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 73902, 76410);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1109_76509_76531()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 76509, 76531);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_76509_76566(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 76509, 76566);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_76509_76624(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 76509, 76624);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_76509_76688(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 76509, 76688);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_76509_76727(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 76509, 76727);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_76509_76791(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 76509, 76791);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_76509_76860(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 76509, 76860);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_76509_76899(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 76509, 76899);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_76509_77029(System.Management.Automation.CustomEntryBuilder
                this_param, string
                property, bool
                enumerateCollection, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.AddPropertyExpressionBinding(property, enumerateCollection: enumerateCollection, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 76509, 77029);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1109_76509_77068(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.AddNewline();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 76509, 77068);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1109_76509_77101(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 76509, 77101);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1109_76509_77132(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 76509, 77132);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_76440_77133(string
                name, System.Management.Automation.CustomControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 76440, 77133);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 73444, 77145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 73444, 77145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_Runspaces_Runspace()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 77157, 79149);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 77288, 79138);

                listYield.Add(f_1109_77301_79137("Runspace", f_1109_77355_79136(f_1109_77355_79107(f_1109_77355_79066(f_1109_77355_78703(f_1109_77355_78626(f_1109_77355_78315(f_1109_77355_77980(f_1109_77355_77928(f_1109_77355_77878(f_1109_77355_77835(f_1109_77355_77753(f_1109_77355_77678(f_1109_77355_77604(f_1109_77355_77522(f_1109_77355_77448(f_1109_77355_77376(), Alignment.Right, label: "Id", width: 3), Alignment.Left, label: "Name", width: 15), Alignment.Left, label: "ComputerName", width: 15), Alignment.Left, label: "Type", width: 13), Alignment.Left, label: "State", width: 13), Alignment.Left, label: "Availability", width: 15)), "Id"), "Name"), @"
                    if ($null -ne $_.ConnectionInfo)
                    {
                      $_.ConnectionInfo.ComputerName
                    }
                    else
                    {
                      ""localhost""
                    }
                  "), @"
                    if ($null -ne $_.ConnectionInfo)
                    {
                      ""Remote""
                    }
                    else
                    {
                      ""Local""
                    }
                  "), "$_.RunspaceStateInfo.State"), @"
                    if (($null -ne $_.Debugger) -and ($_.Debugger.InBreakpoint))
                    {
                        ""InBreakpoint""
                    }
                    else
                    {
                        $_.RunspaceAvailability
                    }
                  ")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 77157, 79149);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_77355_77376()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 77376);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_77355_77448(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 77448);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_77355_77522(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 77522);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_77355_77604(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 77604);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_77355_77678(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 77678);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_77355_77753(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 77753);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_77355_77835(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 77835);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_77355_77878(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 77878);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_77355_77928(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 77928);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_77355_77980(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 77980);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_77355_78315(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 78315);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_77355_78626(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 78626);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_77355_78703(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 78703);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_77355_79066(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 79066);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_77355_79107(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 79107);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_77355_79136(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77355, 79136);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_77301_79137(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 77301, 79137);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 77157, 79149);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 77157, 79149);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_Runspaces_PSSession()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 79161, 80598);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 79293, 80587);

                listYield.Add(f_1109_79306_80586("PSSession", f_1109_79361_80585(f_1109_79361_80556(f_1109_79361_80515(f_1109_79361_80455(f_1109_79361_80390(f_1109_79361_80337(f_1109_79361_80277(f_1109_79361_80217(f_1109_79361_80160(f_1109_79361_80108(f_1109_79361_80058(f_1109_79361_80015(f_1109_79361_79932(f_1109_79361_79845(f_1109_79361_79770(f_1109_79361_79688(f_1109_79361_79606(f_1109_79361_79528(f_1109_79361_79454(f_1109_79361_79382(), Alignment.Right, label: "Id", width: 3), Alignment.Left, label: "Name", width: 15), Alignment.Left, label: "Transport", width: 9), Alignment.Left, label: "ComputerName", width: 15), Alignment.Left, label: "ComputerType", width: 15), Alignment.Left, label: "State", width: 13), Alignment.Left, label: "ConfigurationName", width: 20), Alignment.Right, label: "Availability", width: 13)), "Id"), "Name"), "Transport"), "ComputerName"), "ComputerType"), "State"), "ConfigurationName"), "Availability")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 79161, 80598);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_79361_79382()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 79382);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_79361_79454(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 79454);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_79361_79528(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 79528);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_79361_79606(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 79606);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_79361_79688(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 79688);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_79361_79770(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 79770);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_79361_79845(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 79845);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_79361_79932(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 79932);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_79361_80015(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 80015);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_79361_80058(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 80058);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_79361_80108(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 80108);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_79361_80160(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 80160);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_79361_80217(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 80217);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_79361_80277(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 80277);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_79361_80337(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 80337);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_79361_80390(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 80390);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_79361_80455(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 80455);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_79361_80515(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 80515);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_79361_80556(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 80556);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_79361_80585(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79361, 80585);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_79306_80586(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 79306, 80586);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 79161, 80598);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 79161, 80598);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_Job()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 80610, 81860);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 80726, 81849);

                listYield.Add(f_1109_80739_81848("Job", f_1109_80788_81847(f_1109_80788_81818(f_1109_80788_81777(f_1109_80788_81722(f_1109_80788_81666(f_1109_80788_81607(f_1109_80788_81554(f_1109_80788_81493(f_1109_80788_81441(f_1109_80788_81391(f_1109_80788_81348(f_1109_80788_81271(f_1109_80788_81193(f_1109_80788_81112(f_1109_80788_81037(f_1109_80788_80954(f_1109_80788_80880(f_1109_80788_80809(), Alignment.Left, label: "Id", width: 6), Alignment.Left, label: "Name", width: 15), Alignment.Left, label: "PSJobTypeName", width: 15), Alignment.Left, label: "State", width: 13), Alignment.Left, label: "HasMoreData", width: 15), Alignment.Left, label: "Location", width: 20), Alignment.Left, label: "Command", width: 25)), "Id"), "Name"), "PSJobTypeName"), "State"), "HasMoreData"), "Location"), "Command")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 80610, 81860);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_80788_80809()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 80809);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_80788_80880(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 80880);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_80788_80954(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 80954);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_80788_81037(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81037);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_80788_81112(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81112);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_80788_81193(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81193);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_80788_81271(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81271);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_80788_81348(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81348);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_80788_81391(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81391);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_80788_81441(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81441);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_80788_81493(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81493);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_80788_81554(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81554);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_80788_81607(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81607);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_80788_81666(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81666);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_80788_81722(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81722);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_80788_81777(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81777);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_80788_81818(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81818);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_80788_81847(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80788, 81847);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_80739_81848(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 80739, 81848);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 80610, 81860);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 80610, 81860);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Deserialized_Microsoft_PowerShell_Commands_TextMeasureInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 81872, 82685);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 82014, 82674);

                listYield.Add(f_1109_82027_82673("Microsoft.PowerShell.Commands.TextMeasureInfo", f_1109_82118_82672(f_1109_82118_82643(f_1109_82118_82602(f_1109_82118_82546(f_1109_82118_82488(f_1109_82118_82435(f_1109_82118_82382(f_1109_82118_82339(f_1109_82118_82288(f_1109_82118_82235(f_1109_82118_82187(f_1109_82118_82139(), label: "Lines"), label: "Words"), label: "Characters"), label: "Property")), "Lines"), "Words"), "Characters"), "Property")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 81872, 82685);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_82118_82139()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82118, 82139);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_82118_82187(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82118, 82187);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_82118_82235(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82118, 82235);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_82118_82288(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82118, 82288);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_82118_82339(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82118, 82339);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_82118_82382(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82118, 82382);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_82118_82435(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82118, 82435);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_82118_82488(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82118, 82488);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_82118_82546(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82118, 82546);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_82118_82602(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82118, 82602);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_82118_82643(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82118, 82643);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_82118_82672(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82118, 82672);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_82027_82673(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82027, 82673);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 81872, 82685);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 81872, 82685);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Deserialized_Microsoft_PowerShell_Commands_GenericMeasureInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 82697, 83397);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 82842, 83386);

                listYield.Add(f_1109_82855_83385("Microsoft.PowerShell.Commands.GenericMeasureInfo", f_1109_82949_83384(f_1109_82949_83356(f_1109_82949_83323(f_1109_82949_83268(f_1109_82949_83214(f_1109_82949_83160(f_1109_82949_83110(f_1109_82949_83056(f_1109_82949_83004(f_1109_82949_82969()), @"Count"), @"Average"), @"Sum"), @"Maximum"), @"Minimum"), @"Property")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 82697, 83397);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1109_82949_82969()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82949, 82969);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_82949_83004(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82949, 83004);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_82949_83056(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82949, 83056);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_82949_83110(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82949, 83110);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_82949_83160(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82949, 83160);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_82949_83214(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82949, 83214);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_82949_83268(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82949, 83268);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_82949_83323(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82949, 83323);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_82949_83356(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82949, 83356);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_82949_83384(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82949, 83384);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_82855_83385(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 82855, 83385);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 82697, 83397);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 82697, 83397);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_CallStackFrame()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 83409, 84077);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 83536, 84066);

                listYield.Add(f_1109_83549_84065("CallStackFrame", f_1109_83609_84064(f_1109_83609_84035(f_1109_83609_83994(f_1109_83609_83938(f_1109_83609_83881(f_1109_83609_83826(f_1109_83609_83783(f_1109_83609_83732(f_1109_83609_83680(f_1109_83609_83630(), label: "Command"), label: "Arguments"), label: "Location")), "Command"), "Arguments"), "Location")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 83409, 84077);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_83609_83630()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 83609, 83630);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_83609_83680(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 83609, 83680);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_83609_83732(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 83609, 83732);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_83609_83783(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 83609, 83783);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_83609_83826(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 83609, 83826);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_83609_83881(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 83609, 83881);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_83609_83938(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 83609, 83938);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_83609_83994(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 83609, 83994);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_83609_84035(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 83609, 84035);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_83609_84064(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 83609, 84064);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_83549_84065(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 83549, 84065);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 83409, 84077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 83409, 84077);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_BreakpointTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 84089, 86988);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 84188, 85115);

                listYield.Add(f_1109_84201_85114("Breakpoint", f_1109_84257_85113(f_1109_84257_85084(f_1109_84257_85043(f_1109_84257_84989(f_1109_84257_84933(f_1109_84257_84878(f_1109_84257_84826(f_1109_84257_84716(f_1109_84257_84666(f_1109_84257_84623(f_1109_84257_84574(f_1109_84257_84523(f_1109_84257_84473(f_1109_84257_84399(f_1109_84257_84350(f_1109_84257_84278(), Alignment.Right, label: "ID", width: 4), label: "Script"), Alignment.Right, label: "Line", width: 4), label: "Command"), label: "Variable"), label: "Action")), "ID"), "if ($_.Script) { [System.IO.Path]::GetFileName($_.Script) }"), "Line"), "Command"), "Variable"), "Action")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 85131, 86977);

                listYield.Add(f_1109_85144_86976("Breakpoint", f_1109_85200_86975(f_1109_85200_86947(f_1109_85200_86914(f_1109_85200_86861(f_1109_85200_86806(f_1109_85200_86752(f_1109_85200_86699(f_1109_85200_86650(f_1109_85200_86615(f_1109_85200_86582(f_1109_85200_86529(f_1109_85200_86474(f_1109_85200_86420(f_1109_85200_86366(f_1109_85200_86317(f_1109_85200_86203(f_1109_85200_86170(f_1109_85200_86117(f_1109_85200_86062(f_1109_85200_86008(f_1109_85200_85951(f_1109_85200_85896(f_1109_85200_85847(f_1109_85200_85732(f_1109_85200_85699(f_1109_85200_85646(f_1109_85200_85591(f_1109_85200_85537(f_1109_85200_85484(f_1109_85200_85433(f_1109_85200_85380(f_1109_85200_85331(f_1109_85200_85220(), entrySelectedByType: new[] { "System.Management.Automation.LineBreakpoint" }), @"ID"), @"Script"), @"Line"), @"Column"), @"Enabled"), @"HitCount"), @"Action")), entrySelectedByType: new[] { "System.Management.Automation.VariableBreakpoint" }), @"ID"), @"Variable"), @"AccessMode"), @"Enabled"), @"HitCount"), @"Action")), entrySelectedByType: new[] { "System.Management.Automation.CommandBreakpoint" }), @"ID"), @"Command"), @"Enabled"), @"HitCount"), @"Action"))), @"ID"), @"Script"), @"Enabled"), @"HitCount"), @"Action")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 84089, 86988);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_84257_84278()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 84278);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_84257_84350(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 84350);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_84257_84399(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 84399);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_84257_84473(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 84473);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_84257_84523(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 84523);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_84257_84574(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 84574);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_84257_84623(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 84623);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_84257_84666(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 84666);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_84257_84716(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 84716);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_84257_84826(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 84826);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_84257_84878(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 84878);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_84257_84933(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 84933);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_84257_84989(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 84989);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_84257_85043(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 85043);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_84257_85084(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 85084);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_84257_85113(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84257, 85113);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_84201_85114(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 84201, 85114);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_85200_85220()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 85220);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_85331(System.Management.Automation.ListControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 85331);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_85380(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 85380);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_85433(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 85433);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_85484(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 85484);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_85537(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 85537);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_85591(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 85591);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_85646(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 85646);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_85699(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 85699);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_85200_85732(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 85732);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_85847(System.Management.Automation.ListControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 85847);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_85896(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 85896);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_85951(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 85951);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86008(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86008);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86062(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86062);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86117(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86117);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86170(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86170);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_85200_86203(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86203);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86317(System.Management.Automation.ListControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86317);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86366(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86366);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86420(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86420);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86474(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86474);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86529(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86529);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86582(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86582);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_85200_86615(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86615);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86650(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86650);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86699(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86699);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86752(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86752);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86806(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86806);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86861(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86861);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_85200_86914(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86914);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_85200_86947(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86947);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_85200_86975(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85200, 86975);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_85144_86976(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 85144, 86976);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 84089, 86988);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 84089, 86988);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_PSSessionConfigurationCommands_PSSessionConfiguration()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 87000, 87657);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 87167, 87646);

                listYield.Add(f_1109_87180_87645("PSSessionConfiguration", f_1109_87248_87644(f_1109_87248_87616(f_1109_87248_87583(f_1109_87248_87526(f_1109_87248_87470(f_1109_87248_87410(f_1109_87248_87354(f_1109_87248_87303(f_1109_87248_87268()), @"Name"), @"PSVersion"), @"StartupScript"), @"RunAsUser"), @"Permission")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 87000, 87657);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1109_87248_87268()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87248, 87268);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_87248_87303(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87248, 87303);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_87248_87354(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87248, 87354);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_87248_87410(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87248, 87410);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_87248_87470(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87248, 87470);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_87248_87526(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87248, 87526);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_87248_87583(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87248, 87583);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_87248_87616(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87248, 87616);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_87248_87644(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87248, 87644);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_87180_87645(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87180, 87645);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 87000, 87657);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 87000, 87657);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_ComputerChangeInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 87669, 88323);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 87801, 88312);

                listYield.Add(f_1109_87814_88311("Microsoft.PowerShell.Commands.ComputerChangeInfo", f_1109_87908_88310(f_1109_87908_88281(f_1109_87908_88240(f_1109_87908_88180(f_1109_87908_88120(f_1109_87908_88077(f_1109_87908_88011(f_1109_87908_87929(), Alignment.Left, label: "HasSucceeded", width: 12), label: "ComputerName", width: 25)), "HasSucceeded"), "ComputerName")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 87669, 88323);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_87908_87929()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87908, 87929);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_87908_88011(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87908, 88011);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_87908_88077(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87908, 88077);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_87908_88120(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87908, 88120);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_87908_88180(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87908, 88180);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_87908_88240(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87908, 88240);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_87908_88281(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87908, 88281);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_87908_88310(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87908, 88310);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_87814_88311(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 87814, 88311);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 87669, 88323);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 87669, 88323);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_RenameComputerChangeInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 88335, 89139);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 88473, 89128);

                listYield.Add(f_1109_88486_89127("Microsoft.PowerShell.Commands.RenameComputerChangeInfo", f_1109_88586_89126(f_1109_88586_89097(f_1109_88586_89056(f_1109_88586_88993(f_1109_88586_88930(f_1109_88586_88870(f_1109_88586_88827(f_1109_88586_88758(f_1109_88586_88689(f_1109_88586_88607(), Alignment.Left, label: "HasSucceeded", width: 12), label: "OldComputerName", width: 25), label: "NewComputerName", width: 25)), "HasSucceeded"), "OldComputerName"), "NewComputerName")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 88335, 89139);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_88586_88607()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 88586, 88607);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_88586_88689(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 88586, 88689);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_88586_88758(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 88586, 88758);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_88586_88827(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 88586, 88827);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_88586_88870(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 88586, 88870);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_88586_88930(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 88586, 88930);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_88586_88993(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 88586, 88993);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_88586_89056(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 88586, 89056);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_88586_89097(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 88586, 89097);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_88586_89126(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 88586, 89126);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_88486_89127(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 88486, 89127);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 88335, 89139);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 88335, 89139);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_ModuleInfoGrouping(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 89151, 91267);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 89283, 91256);

                listYield.Add(f_1109_89296_91255("Module", f_1109_89348_91254(f_1109_89348_91225(f_1109_89348_91184(f_1109_89348_91109(f_1109_89348_90488(f_1109_89348_90436(f_1109_89348_90176(f_1109_89348_90121(f_1109_89348_90063(f_1109_89348_90020(f_1109_89348_89945(f_1109_89348_89867(f_1109_89348_89808(f_1109_89348_89728(f_1109_89348_89669(f_1109_89348_89610(f_1109_89348_89369(), "Split-Path -Parent $_.Path | ForEach-Object { if([Version]::TryParse((Split-Path $_ -Leaf), [ref]$null)) { Split-Path -Parent $_} else {$_} } | Split-Path -Parent", customControl: sharedControls[0]), Alignment.Left, width: 10), Alignment.Left, width: 10), Alignment.Left, label: "PreRelease", width: 10), Alignment.Left, width: 35), Alignment.Left, width: 9, label: "PSEdition"), Alignment.Left, label: "ExportedCommands")), "ModuleType"), "Version"), @"
                            if ($_.PrivateData -and $_.PrivateData.PSData)
                            {
                                    $_.PrivateData.PSData.PreRelease
                            }"), "Name"), @"
                            $result = [System.Collections.ArrayList]::new()
                            $editions = $_.CompatiblePSEditions
                            if (-not $editions)
                            {
                                $editions = @('Desktop')
                            }

                            foreach ($edition in $editions)
                            {
                                $result += $edition.Substring(0,4)
                            }

                            ($result | Sort-Object) -join ','"), "$_.ExportedCommands.Keys")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 89151, 91267);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_89348_89369()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 89369);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_89348_89610(System.Management.Automation.TableControlBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.GroupByScriptBlock(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 89610);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_89348_89669(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 89669);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_89348_89728(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 89728);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_89348_89808(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 89808);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_89348_89867(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 89867);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_89348_89945(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width, string
                label)
                {
                    var return_v = this_param.AddHeader(alignment, width: width, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 89945);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_89348_90020(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label)
                {
                    var return_v = this_param.AddHeader(alignment, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 90020);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_89348_90063(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 90063);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_89348_90121(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 90121);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_89348_90176(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 90176);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_89348_90436(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 90436);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_89348_90488(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 90488);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_89348_91109(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 91109);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_89348_91184(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 91184);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_89348_91225(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 91225);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_89348_91254(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89348, 91254);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_89296_91255(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 89296, 91255);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 89151, 91267);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 89151, 91267);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_PSModuleInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 91279, 93905);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 91404, 92437);

                listYield.Add(f_1109_91417_92436("Module", f_1109_91469_92435(f_1109_91469_92406(f_1109_91469_92365(f_1109_91469_92290(f_1109_91469_92238(f_1109_91469_91978(f_1109_91469_91923(f_1109_91469_91865(f_1109_91469_91822(f_1109_91469_91747(f_1109_91469_91688(f_1109_91469_91608(f_1109_91469_91549(f_1109_91469_91490(), Alignment.Left, width: 10), Alignment.Left, width: 10), Alignment.Left, label: "PreRelease", width: 10), Alignment.Left, width: 35), Alignment.Left, label: "ExportedCommands")), "ModuleType"), "Version"), @"
                            if ($_.PrivateData -and $_.PrivateData.PSData)
                            {
                                    $_.PrivateData.PSData.PreRelease
                            }"), "Name"), "$_.ExportedCommands.Keys")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 92453, 92622);

                listYield.Add(f_1109_92466_92621("Module", f_1109_92518_92620(f_1109_92518_92585(f_1109_92518_92538(), "Name"))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 92638, 93894);

                listYield.Add(f_1109_92651_93893("Module", f_1109_92703_93892(f_1109_92703_93864(f_1109_92703_93831(f_1109_92703_93732(f_1109_92703_93629(f_1109_92703_93530(f_1109_92703_93427(f_1109_92703_93367(f_1109_92703_93029(f_1109_92703_92975(f_1109_92703_92918(f_1109_92703_92860(f_1109_92703_92809(f_1109_92703_92758(f_1109_92703_92723()), @"Name"), @"Path"), @"Description"), @"ModuleType"), @"Version"), @"
                            if ($_.PrivateData -and $_.PrivateData.PSData)
                            {
                                    $_.PrivateData.PSData.PreRelease
                            }", label: "PreRelease"), @"NestedModules"), @"$_.ExportedFunctions.Keys", label: "ExportedFunctions"), @"$_.ExportedCmdlets.Keys", label: "ExportedCmdlets"), @"$_.ExportedVariables.Keys", label: "ExportedVariables"), @"$_.ExportedAliases.Keys", label: "ExportedAliases")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 91279, 93905);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_91469_91490()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91469, 91490);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_91469_91549(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91469, 91549);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_91469_91608(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91469, 91608);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_91469_91688(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91469, 91688);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_91469_91747(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91469, 91747);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_91469_91822(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label)
                {
                    var return_v = this_param.AddHeader(alignment, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91469, 91822);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_91469_91865(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91469, 91865);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_91469_91923(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91469, 91923);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_91469_91978(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91469, 91978);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_91469_92238(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91469, 92238);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_91469_92290(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91469, 92290);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_91469_92365(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91469, 92365);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_91469_92406(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91469, 92406);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_91469_92435(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91469, 92435);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_91417_92436(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 91417, 92436);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1109_92518_92538()
                {
                    var return_v = WideControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92518, 92538);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1109_92518_92585(System.Management.Automation.WideControlBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyEntry(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92518, 92585);
                    return return_v;
                }


                System.Management.Automation.WideControl
                f_1109_92518_92620(System.Management.Automation.WideControlBuilder
                this_param)
                {
                    var return_v = this_param.EndWideControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92518, 92620);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_92466_92621(string
                name, System.Management.Automation.WideControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92466, 92621);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_92703_92723()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 92723);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_92703_92758(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 92758);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_92703_92809(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 92809);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_92703_92860(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 92860);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_92703_92918(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 92918);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_92703_92975(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 92975);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_92703_93029(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 93029);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_92703_93367(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 93367);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_92703_93427(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 93427);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_92703_93530(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 93530);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_92703_93629(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 93629);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_92703_93732(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 93732);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_92703_93831(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 93831);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_92703_93864(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 93864);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_92703_93892(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92703, 93892);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_92651_93893(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 92651, 93893);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 91279, 93905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 91279, 93905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_ExperimentalFeature()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 93917, 95143);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 94049, 94708);

                listYield.Add(f_1109_94062_94707("ExperimentalFeature", f_1109_94127_94706(f_1109_94127_94677(f_1109_94127_94636(f_1109_94127_94577(f_1109_94127_94523(f_1109_94127_94468(f_1109_94127_94416(f_1109_94127_94373(f_1109_94127_94325(f_1109_94127_94266(f_1109_94127_94207(f_1109_94127_94148(), Alignment.Left, width: 35), Alignment.Right, width: 7), Alignment.Left, width: 35), Alignment.Left)), "Name"), "Enabled"), "Source"), "Description")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 94724, 95132);

                listYield.Add(f_1109_94737_95131("ExperimentalFeature", f_1109_94802_95130(f_1109_94802_95102(f_1109_94802_95069(f_1109_94802_95012(f_1109_94802_94960(f_1109_94802_94907(f_1109_94802_94857(f_1109_94802_94822()), "Name"), "Enabled"), "Source"), "Description")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 93917, 95143);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_94127_94148()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94127, 94148);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_94127_94207(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94127, 94207);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_94127_94266(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94127, 94266);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_94127_94325(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94127, 94325);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_94127_94373(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment)
                {
                    var return_v = this_param.AddHeader(alignment);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94127, 94373);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_94127_94416(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94127, 94416);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_94127_94468(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94127, 94468);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_94127_94523(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94127, 94523);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_94127_94577(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94127, 94577);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_94127_94636(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94127, 94636);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_94127_94677(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94127, 94677);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_94127_94706(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94127, 94706);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_94062_94707(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94062, 94707);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_94802_94822()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94802, 94822);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_94802_94857(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94802, 94857);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_94802_94907(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94802, 94907);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_94802_94960(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94802, 94960);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_94802_95012(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94802, 95012);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_94802_95069(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94802, 95069);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_94802_95102(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94802, 95102);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_94802_95130(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94802, 95130);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_94737_95131(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 94737, 95131);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 93917, 95143);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 93917, 95143);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_BasicHtmlWebResponseObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 95155, 96793);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 95295, 96782);

                listYield.Add(f_1109_95308_96781("Microsoft.PowerShell.Commands.BasicHtmlWebResponseObject", f_1109_95410_96780(f_1109_95410_96752(f_1109_95410_96719(f_1109_95410_96660(f_1109_95410_96597(f_1109_95410_96545(f_1109_95410_96487(f_1109_95410_96434(f_1109_95410_96380(f_1109_95410_95980(f_1109_95410_95586(f_1109_95410_95522(f_1109_95410_95465(f_1109_95410_95430()), @"StatusCode"), @"StatusDescription"), @"
                                  $result = $_.Content
                                  $result = $result.Substring(0, [Math]::Min($result.Length, 200) )
                                  if($result.Length -eq 200) { $result += ""`u{2026}"" }

                                  $result
                                ", label: "Content"), @"
                                  $result = $_.RawContent
                                  $result = $result.Substring(0, [Math]::Min($result.Length, 200) )
                                  if($result.Length -eq 200) { $result += ""`u{2026}"" }

                                  $result
                                ", label: "RawContent"), @"Headers"), @"Images"), @"InputFields"), @"Links"), @"RawContentLength"), @"RelationLink")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 95155, 96793);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1109_95410_95430()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95410, 95430);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_95410_95465(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95410, 95465);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_95410_95522(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95410, 95522);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_95410_95586(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95410, 95586);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_95410_95980(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95410, 95980);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_95410_96380(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95410, 96380);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_95410_96434(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95410, 96434);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_95410_96487(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95410, 96487);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_95410_96545(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95410, 96545);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_95410_96597(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95410, 96597);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_95410_96660(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95410, 96660);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_95410_96719(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95410, 96719);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_95410_96752(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95410, 96752);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_95410_96780(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95410, 96780);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_95308_96781(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 95308, 96781);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 95155, 96793);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 95155, 96793);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_WebResponseObject()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 96805, 97922);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 96936, 97911);

                listYield.Add(f_1109_96949_97910("Microsoft.PowerShell.Commands.WebResponseObject", f_1109_97042_97909(f_1109_97042_97881(f_1109_97042_97848(f_1109_97042_97789(f_1109_97042_97726(f_1109_97042_97672(f_1109_97042_97272(f_1109_97042_97218(f_1109_97042_97154(f_1109_97042_97097(f_1109_97042_97062()), @"StatusCode"), @"StatusDescription"), @"Content"), @"
                                  $result = $_.RawContent
                                  $result = $result.Substring(0, [Math]::Min($result.Length, 200) )
                                  if($result.Length -eq 200) { $result += ""`u{2026}"" }

                                  $result
                                ", label: "RawContent"), @"Headers"), @"RawContentLength"), @"RelationLink")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 96805, 97922);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1109_97042_97062()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 97042, 97062);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_97042_97097(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 97042, 97097);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_97042_97154(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 97042, 97154);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_97042_97218(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 97042, 97218);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_97042_97272(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 97042, 97272);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_97042_97672(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 97042, 97672);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_97042_97726(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 97042, 97726);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_97042_97789(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 97042, 97789);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_97042_97848(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 97042, 97848);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_97042_97881(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 97042, 97881);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_97042_97909(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 97042, 97909);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_96949_97910(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 96949, 97910);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 96805, 97922);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 96805, 97922);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_Powershell_Utility_FileHashInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 97934, 98620);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 98059, 98609);

                listYield.Add(f_1109_98072_98608("Microsoft.PowerShell.Commands.FileHashInfo", f_1109_98160_98607(f_1109_98160_98578(f_1109_98160_98537(f_1109_98160_98485(f_1109_98160_98433(f_1109_98160_98376(f_1109_98160_98333(f_1109_98160_98299(f_1109_98160_98240(f_1109_98160_98181(), Alignment.Left, width: 15), Alignment.Left, width: 70))), "Algorithm"), "Hash"), "Path")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 97934, 98620);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_98160_98181()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98160, 98181);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_98160_98240(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98160, 98240);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_98160_98299(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98160, 98299);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_98160_98333(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98160, 98333);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_98160_98376(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98160, 98376);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_98160_98433(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98160, 98433);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_98160_98485(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98160, 98485);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_98160_98537(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98160, 98537);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_98160_98578(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98160, 98578);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_98160_98607(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98160, 98607);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_98072_98608(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98072, 98608);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 97934, 98620);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 97934, 98620);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_PSRunspaceDebug()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 98632, 99513);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 98761, 99502);

                listYield.Add(f_1109_98774_99501("PSRunspaceDebug>", f_1109_98836_99500(f_1109_98836_99471(f_1109_98836_99430(f_1109_98836_99374(f_1109_98836_99319(f_1109_98836_99259(f_1109_98836_99201(f_1109_98836_99158(f_1109_98836_99080(f_1109_98836_99003(f_1109_98836_98929(f_1109_98836_98857(), Alignment.Right, label: "Id", width: 3), Alignment.Left, label: "Name", width: 20), Alignment.Left, label: "Enabled", width: 10), Alignment.Left, label: "BreakAll", width: 10)), "RunspaceId"), "RunspaceName"), "Enabled"), "BreakAll")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 98632, 99513);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_98836_98857()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98836, 98857);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_98836_98929(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98836, 98929);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_98836_99003(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98836, 99003);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_98836_99080(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98836, 99080);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_98836_99158(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98836, 99158);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_98836_99201(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98836, 99201);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_98836_99259(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98836, 99259);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_98836_99319(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98836, 99319);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_98836_99374(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98836, 99374);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_98836_99430(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98836, 99430);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_98836_99471(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98836, 99471);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_98836_99500(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98836, 99500);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_98774_99501(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 98774, 99501);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 98632, 99513);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 98632, 99513);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_MarkdownRender_MarkdownOptionInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 99525, 100995);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 99663, 100984);

                listYield.Add(f_1109_99676_100983("Microsoft.PowerShell.MarkdownRender.PSMarkdownOptionInfo", f_1109_99778_100982(f_1109_99778_100954(f_1109_99778_100921(f_1109_99778_100807(f_1109_99778_100699(f_1109_99778_100605(f_1109_99778_100513(f_1109_99778_100421(f_1109_99778_100323(f_1109_99778_100225(f_1109_99778_100127(f_1109_99778_100029(f_1109_99778_99931(f_1109_99778_99833(f_1109_99778_99798()), @"$_.AsEscapeSequence('Header1')", label: "Header1"), @"$_.AsEscapeSequence('Header2')", label: "Header2"), @"$_.AsEscapeSequence('Header3')", label: "Header3"), @"$_.AsEscapeSequence('Header4')", label: "Header4"), @"$_.AsEscapeSequence('Header5')", label: "Header5"), @"$_.AsEscapeSequence('Header6')", label: "Header6"), @"$_.AsEscapeSequence('Code')", label: "Code"), @"$_.AsEscapeSequence('Link')", label: "Link"), @"$_.AsEscapeSequence('Image')", label: "Image"), @"$_.AsEscapeSequence('EmphasisBold')", label: "EmphasisBold"), @"$_.AsEscapeSequence('EmphasisItalics')", label: "EmphasisItalics")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 99525, 100995);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1109_99778_99798()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 99798);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_99778_99833(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 99833);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_99778_99931(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 99931);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_99778_100029(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 100029);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_99778_100127(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 100127);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_99778_100225(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 100225);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_99778_100323(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 100323);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_99778_100421(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 100421);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_99778_100513(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 100513);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_99778_100605(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 100605);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_99778_100699(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 100699);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_99778_100807(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 100807);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1109_99778_100921(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 100921);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1109_99778_100954(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 100954);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1109_99778_100982(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99778, 100982);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_99676_100983(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 99676, 100983);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 99525, 100995);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 99525, 100995);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_TestConnectionCommand_PingStatus()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 101007, 102821);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 101153, 102810);

                listYield.Add(f_1109_101166_102809("Microsoft.PowerShell.Commands.TestConnectionCommand+PingStatus", f_1109_101292_102808(f_1109_101292_102779(f_1109_101292_102726(f_1109_101292_102685(f_1109_101292_102631(f_1109_101292_102310(f_1109_101292_101992(f_1109_101292_101930(f_1109_101292_101876(f_1109_101292_101824(f_1109_101292_101781(f_1109_101292_101705(f_1109_101292_101621(f_1109_101292_101540(f_1109_101292_101463(f_1109_101292_101387(f_1109_101292_101313(), Alignment.Right, label: "Ping", width: 4), Alignment.Left, label: "Source", width: 16), Alignment.Left, label: "Address", width: 25), Alignment.Right, label: "Latency(ms)", width: 7), Alignment.Right, label: "BufferSize(B)", width: 10), Alignment.Left, label: "Status", width: 16)), "Ping"), "Source"), "DisplayAddress"), @"
                            if ($_.Status -eq 'TimedOut') {
                                '*'
                            }
                            else {
                                $_.Latency
                            }
                        "), @"
                            if ($_.Status -eq 'TimedOut') {
                                '*'
                            }
                            else {
                                $_.BufferSize
                            }
                        "), "Status")), "Destination"))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 101007, 102821);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_101292_101313()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 101313);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_101292_101387(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 101387);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_101292_101463(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 101463);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_101292_101540(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 101540);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_101292_101621(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 101621);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_101292_101705(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 101705);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_101292_101781(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 101781);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_101292_101824(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 101824);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_101292_101876(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 101876);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_101292_101930(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 101930);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_101292_101992(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 101992);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_101292_102310(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 102310);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_101292_102631(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 102631);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_101292_102685(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 102685);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_101292_102726(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 102726);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_101292_102779(System.Management.Automation.TableControlBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.GroupByProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 102779);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_101292_102808(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101292, 102808);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_101166_102809(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 101166, 102809);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 101007, 102821);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 101007, 102821);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_TestConnectionCommand_PingMtuStatus()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 102833, 104257);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 102982, 104246);

                listYield.Add(f_1109_102995_104245("Microsoft.PowerShell.Commands.TestConnectionCommand+PingMtuStatus", f_1109_103124_104244(f_1109_103124_104215(f_1109_103124_104162(f_1109_103124_104121(f_1109_103124_104066(f_1109_103124_104012(f_1109_103124_103694(f_1109_103124_103632(f_1109_103124_103578(f_1109_103124_103535(f_1109_103124_103455(f_1109_103124_103379(f_1109_103124_103298(f_1109_103124_103221(f_1109_103124_103145(), Alignment.Left, label: "Source", width: 16), Alignment.Left, label: "Address", width: 25), Alignment.Right, label: "Latency(ms)", width: 7), Alignment.Left, label: "Status", width: 16), Alignment.Right, label: "MtuSize(B)", width: 7)), "Source"), "DisplayAddress"), @"
                            if ($_.Status -eq 'TimedOut') {
                                '*'
                            }
                            else {
                                $_.Latency
                            }
                        "), "Status"), "MtuSize")), "Destination"))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 102833, 104257);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_103124_103145()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 103145);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_103124_103221(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 103221);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_103124_103298(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 103298);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_103124_103379(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 103379);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_103124_103455(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 103455);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_103124_103535(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 103535);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_103124_103578(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 103578);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_103124_103632(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 103632);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_103124_103694(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 103694);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_103124_104012(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 104012);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_103124_104066(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 104066);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_103124_104121(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 104121);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_103124_104162(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 104162);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_103124_104215(System.Management.Automation.TableControlBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.GroupByProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 104215);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_103124_104244(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 103124, 104244);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_102995_104245(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 102995, 104245);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 102833, 104257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 102833, 104257);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_TestConnectionCommand_TraceStatus()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 104269, 106188);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 104416, 106177);

                listYield.Add(f_1109_104429_106176("Microsoft.PowerShell.Commands.TestConnectionCommand+TraceStatus", f_1109_104556_106175(f_1109_104556_106146(f_1109_104556_106098(f_1109_104556_106057(f_1109_104556_105996(f_1109_104556_105942(f_1109_104556_105888(f_1109_104556_105570(f_1109_104556_105518(f_1109_104556_105212(f_1109_104556_105161(f_1109_104556_105118(f_1109_104556_105035(f_1109_104556_104959(f_1109_104556_104883(f_1109_104556_104802(f_1109_104556_104728(f_1109_104556_104650(f_1109_104556_104577(), Alignment.Right, label: "Hop", width: 3), Alignment.Left, label: "Hostname", width: 25), Alignment.Right, label: "Ping", width: 4), Alignment.Right, label: "Latency(ms)", width: 7), Alignment.Left, label: "Status", width: 16), Alignment.Left, label: "Source", width: 12), Alignment.Left, label: "TargetAddress", width: 15)), "Hop"), @"
                            if ($_.Hostname) {
                                $_.HostName
                            }
                            else {
                                '*'
                            }
                        "), "Ping"), @"
                            if ($_.Status -eq 'TimedOut') {
                                '*'
                            }
                            else {
                                $_.Latency
                            }
                        "), "Status"), "Source"), "TargetAddress")), "Target"))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 104269, 106188);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_104556_104577()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 104577);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_104556_104650(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 104650);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_104556_104728(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 104728);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_104556_104802(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 104802);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_104556_104883(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 104883);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_104556_104959(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 104959);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_104556_105035(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 105035);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_104556_105118(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 105118);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_104556_105161(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 105161);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_104556_105212(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 105212);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_104556_105518(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 105518);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_104556_105570(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 105570);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_104556_105888(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 105888);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_104556_105942(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 105942);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_104556_105996(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 105996);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_104556_106057(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 106057);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_104556_106098(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 106098);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_104556_106146(System.Management.Automation.TableControlBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.GroupByProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 106146);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_104556_106175(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104556, 106175);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_104429_106176(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 104429, 106176);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 104269, 106188);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 104269, 106188);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_ByteCollection()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1109, 106200, 107085);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1109, 106328, 107074);

                listYield.Add(f_1109_106341_107073("Microsoft.PowerShell.Commands.ByteCollection", f_1109_106449_107072(f_1109_106449_107043(f_1109_106449_106996(f_1109_106449_106955(f_1109_106449_106902(f_1109_106449_106846(f_1109_106449_106789(f_1109_106449_106746(f_1109_106449_106671(f_1109_106449_106547(f_1109_106449_106470(), Alignment.Right, label: "Offset", width: 16), Alignment.Left, label: "Bytes\n00 01 02 03 04 05 06 07 08 09 0A 0B 0C 0D 0E 0F", width: 47), Alignment.Left, label: "Ascii", width: 16)), "HexOffset"), "HexBytes"), "Ascii")), "Label"))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1109, 106200, 107085);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1109_106449_106470()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 106449, 106470);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_106449_106547(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 106449, 106547);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_106449_106671(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 106449, 106671);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_106449_106746(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 106449, 106746);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_106449_106789(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 106449, 106789);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_106449_106846(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 106449, 106846);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_106449_106902(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 106449, 106902);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1109_106449_106955(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 106449, 106955);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_106449_106996(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 106449, 106996);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1109_106449_107043(System.Management.Automation.TableControlBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.GroupByProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 106449, 107043);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1109_106449_107072(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 106449, 107072);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1109_106341_107073(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1109, 106341, 107073);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1109, 106200, 107085);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 106200, 107085);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShellCore_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1109, 194, 107092);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1109, 194, 107092);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 194, 107092);
        }


        static PowerShellCore_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1109, 194, 107092);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1109, 194, 107092);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1109, 194, 107092);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1109, 194, 107092);
    }
}
