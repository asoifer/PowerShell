// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation.Runspaces
{
    internal sealed class Registry_Format_Ps1Xml
    {
        internal static IEnumerable<ExtendedTypeDefinition> GetFormatData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1111, 255, 1388);

                var listYield = new List<ExtendedTypeDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1111, 347, 765);

                var
                Registry_GroupingFormat = f_1111_377_764(f_1111_377_733(f_1111_377_700(f_1111_377_663(f_1111_377_525(f_1111_377_473(f_1111_377_434(f_1111_377_399())), "    Hive: "), @"$_.PSParentPath.Replace(""Microsoft.PowerShell.Core\Registry::"", """")"))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1111, 781, 880);

                var
                sharedControls = new CustomControl[] {
                Registry_GroupingFormat
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1111, 896, 1197);

                var
                td1 = f_1111_906_1196("Microsoft.PowerShell.Commands.Internal.TransactedRegistryKey", f_1111_1032_1195(sharedControls))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1111, 1211, 1260);

                f_1111_1211_1259(f_1111_1211_1224(td1), "Microsoft.Win32.RegistryKey");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1111, 1274, 1346);

                f_1111_1274_1345(f_1111_1274_1287(td1), "System.Management.Automation.TreatAs.RegistryValue");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1111, 1360, 1377);

                listYield.Add(td1);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1111, 255, 1388);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1111_377_399()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 377, 399);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1111_377_434(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 377, 434);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1111_377_473(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.StartFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 377, 473);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1111_377_525(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 377, 525);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1111_377_663(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 377, 663);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1111_377_700(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 377, 700);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1111_377_733(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 377, 733);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1111_377_764(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 377, 764);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1111_1032_1195(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_Internal_TransactedRegistryKey_Microsoft_Win32_RegistryKey_System_Management_Automation_TreatAs_RegistryValue(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 1032, 1195);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1111_906_1196(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 906, 1196);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1111_1211_1224(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1111, 1211, 1224);
                    return return_v;
                }


                int
                f_1111_1211_1259(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 1211, 1259);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1111_1274_1287(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1111, 1274, 1287);
                    return return_v;
                }


                int
                f_1111_1274_1345(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 1274, 1345);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1111, 255, 1388);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1111, 255, 1388);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_Internal_TransactedRegistryKey_Microsoft_Win32_RegistryKey_System_Management_Automation_TreatAs_RegistryValue(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1111, 1400, 2734);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1111, 1653, 2723);

                listYield.Add(f_1111_1666_2722("children", f_1111_1720_2721(f_1111_1720_2692(f_1111_1720_2651(f_1111_1720_2050(f_1111_1720_1991(f_1111_1720_1938(f_1111_1720_1887(f_1111_1720_1829(f_1111_1720_1741(), "PSParentPath", customControl: sharedControls[0]), label: "Name", width: 30), label: "Property"), wrap: true), "PSChildName"), @"
                                  $result = (Get-ItemProperty -LiteralPath $_.PSPath |
                                      Select * -Exclude PSPath,PSParentPath,PSChildName,PSDrive,PsProvider |
                                      Format-List | Out-String | Sort).Trim()
                                  $result = $result.Substring(0, [Math]::Min($result.Length, 5000) )
                                  if($result.Length -eq 5000) { $result += ""`u{2026}"" }

                                  $result
                                ")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1111, 1400, 2734);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1111_1720_1741()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 1720, 1741);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1111_1720_1829(System.Management.Automation.TableControlBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.GroupByProperty(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 1720, 1829);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1111_1720_1887(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 1720, 1887);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1111_1720_1938(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 1720, 1938);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1111_1720_1991(System.Management.Automation.TableControlBuilder
                this_param, bool
                wrap)
                {
                    var return_v = this_param.StartRowDefinition(wrap: wrap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 1720, 1991);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1111_1720_2050(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 1720, 2050);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1111_1720_2651(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 1720, 2651);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1111_1720_2692(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 1720, 2692);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1111_1720_2721(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 1720, 2721);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1111_1666_2722(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1111, 1666, 2722);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1111, 1400, 2734);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1111, 1400, 2734);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Registry_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1111, 194, 2741);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1111, 194, 2741);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1111, 194, 2741);
        }


        static Registry_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1111, 194, 2741);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1111, 194, 2741);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1111, 194, 2741);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1111, 194, 2741);
    }
}
