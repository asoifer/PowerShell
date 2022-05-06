// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation.Runspaces
{
    internal sealed class PowerShellTrace_Format_Ps1Xml
    {
        internal static IEnumerable<ExtendedTypeDefinition> GetFormatData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1110, 262, 540);

                var listYield = new List<ExtendedTypeDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1110, 354, 529);

                listYield.Add(f_1110_367_528("System.Management.Automation.PSTraceSource", f_1110_475_527()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1110, 262, 540);

                return listYield;

                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1110_475_527()
                {
                    var return_v = ViewsOf_System_Management_Automation_PSTraceSource();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 475, 527);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1110_367_528(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 367, 528);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1110, 262, 540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1110, 262, 540);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_PSTraceSource()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1110, 552, 1875);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1110, 678, 1300);

                listYield.Add(f_1110_691_1299("System.Management.Automation.PSTraceSource", f_1110_779_1298(f_1110_779_1269(f_1110_779_1228(f_1110_779_1169(f_1110_779_1112(f_1110_779_1060(f_1110_779_1005(f_1110_779_962(f_1110_779_928(f_1110_779_885(f_1110_779_842(f_1110_779_800(), width: 8), width: 20), width: 20))), "Options"), "Name"), "Listeners"), "Description")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1110, 1316, 1864);

                listYield.Add(f_1110_1329_1863("System.Management.Automation.PSTraceSource", f_1110_1417_1862(f_1110_1417_1834(f_1110_1417_1801(f_1110_1417_1748(f_1110_1417_1691(f_1110_1417_1635(f_1110_1417_1581(f_1110_1417_1523(f_1110_1417_1472(f_1110_1417_1437()), @"Name"), @"Description"), @"Options"), @"Listeners"), @"Attributes"), @"Switch")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1110, 552, 1875);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1110_779_800()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 779, 800);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1110_779_842(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 779, 842);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1110_779_885(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 779, 885);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1110_779_928(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 779, 928);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1110_779_962(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 779, 962);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1110_779_1005(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 779, 1005);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1110_779_1060(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 779, 1060);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1110_779_1112(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 779, 1112);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1110_779_1169(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 779, 1169);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1110_779_1228(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 779, 1228);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1110_779_1269(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 779, 1269);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1110_779_1298(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 779, 1298);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1110_691_1299(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 691, 1299);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1110_1417_1437()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 1417, 1437);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1110_1417_1472(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 1417, 1472);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1110_1417_1523(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 1417, 1523);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1110_1417_1581(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 1417, 1581);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1110_1417_1635(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 1417, 1635);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1110_1417_1691(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 1417, 1691);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1110_1417_1748(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 1417, 1748);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1110_1417_1801(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 1417, 1801);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1110_1417_1834(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 1417, 1834);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1110_1417_1862(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 1417, 1862);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1110_1329_1863(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1110, 1329, 1863);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1110, 552, 1875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1110, 552, 1875);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public PowerShellTrace_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1110, 194, 1882);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1110, 194, 1882);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1110, 194, 1882);
        }


        static PowerShellTrace_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1110, 194, 1882);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1110, 194, 1882);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1110, 194, 1882);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1110, 194, 1882);
    }
}
