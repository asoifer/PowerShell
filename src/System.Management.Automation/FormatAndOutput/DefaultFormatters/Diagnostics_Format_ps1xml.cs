// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation.Runspaces
{
    internal sealed class Diagnostics_Format_Ps1Xml
    {
        internal static IEnumerable<ExtendedTypeDefinition> GetFormatData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1103, 258, 807);

                var listYield = new List<ExtendedTypeDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1103, 350, 577);

                listYield.Add(f_1103_363_576("Microsoft.PowerShell.Commands.GetCounter.PerformanceCounterSampleSet", f_1103_497_575()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1103, 593, 796);

                listYield.Add(f_1103_606_795("Microsoft.PowerShell.Commands.GetCounter.CounterFileInfo", f_1103_728_794()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1103, 258, 807);

                return listYield;

                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1103_497_575()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_GetCounter_PerformanceCounterSampleSet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 497, 575);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1103_363_576(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 363, 576);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1103_728_794()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_GetCounter_CounterFileInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 728, 794);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1103_606_795(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 606, 795);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1103, 258, 807);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1103, 258, 807);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_GetCounter_PerformanceCounterSampleSet()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1103, 819, 1471);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1103, 971, 1460);

                listYield.Add(f_1103_984_1459("Counter", f_1103_1037_1458(f_1103_1037_1429(f_1103_1037_1388(f_1103_1037_1332(f_1103_1037_1275(f_1103_1037_1222(f_1103_1037_1137(f_1103_1037_1058(), Alignment.Left, label: "Timestamp", width: 26), Alignment.Left, label: "CounterSamples", width: 100), wrap: true), "Timestamp"), "Readings")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1103, 819, 1471);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1103_1037_1058()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1037, 1058);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1103_1037_1137(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1037, 1137);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1103_1037_1222(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1037, 1222);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1103_1037_1275(System.Management.Automation.TableControlBuilder
                this_param, bool
                wrap)
                {
                    var return_v = this_param.StartRowDefinition(wrap: wrap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1037, 1275);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1103_1037_1332(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1037, 1332);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1103_1037_1388(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1037, 1388);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1103_1037_1429(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1037, 1429);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1103_1037_1458(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1037, 1458);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1103_984_1459(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 984, 1459);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1103, 819, 1471);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1103, 819, 1471);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_GetCounter_CounterFileInfo()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1103, 1483, 2202);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1103, 1623, 2191);

                listYield.Add(f_1103_1636_2190("Counter", f_1103_1689_2189(f_1103_1689_2160(f_1103_1689_2119(f_1103_1689_2060(f_1103_1689_2000(f_1103_1689_1940(f_1103_1689_1887(f_1103_1689_1828(f_1103_1689_1769(f_1103_1689_1710(), Alignment.Left, width: 30), Alignment.Left, width: 30), Alignment.Left, width: 30), wrap: true), "OldestRecord"), "NewestRecord"), "SampleCount")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1103, 1483, 2202);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1103_1689_1710()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1689, 1710);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1103_1689_1769(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1689, 1769);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1103_1689_1828(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1689, 1828);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1103_1689_1887(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1689, 1887);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1103_1689_1940(System.Management.Automation.TableControlBuilder
                this_param, bool
                wrap)
                {
                    var return_v = this_param.StartRowDefinition(wrap: wrap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1689, 1940);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1103_1689_2000(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1689, 2000);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1103_1689_2060(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1689, 2060);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1103_1689_2119(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1689, 2119);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1103_1689_2160(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1689, 2160);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1103_1689_2189(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1689, 2189);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1103_1636_2190(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1103, 1636, 2190);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1103, 1483, 2202);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1103, 1483, 2202);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Diagnostics_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1103, 194, 2209);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1103, 194, 2209);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1103, 194, 2209);
        }


        static Diagnostics_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1103, 194, 2209);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1103, 194, 2209);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1103, 194, 2209);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1103, 194, 2209);
    }
}
