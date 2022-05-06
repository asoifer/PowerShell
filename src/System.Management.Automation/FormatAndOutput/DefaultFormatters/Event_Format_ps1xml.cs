// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation.Runspaces
{
    internal sealed class Event_Format_Ps1Xml
    {
        internal static IEnumerable<ExtendedTypeDefinition> GetFormatData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1105, 252, 972);

                var listYield = new List<ExtendedTypeDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1105, 344, 533);

                listYield.Add(f_1105_357_532("System.Diagnostics.Eventing.Reader.EventLogRecord", f_1105_472_531()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1105, 549, 752);

                listYield.Add(f_1105_562_751("System.Diagnostics.Eventing.Reader.EventLogConfiguration", f_1105_684_750()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1105, 768, 961);

                listYield.Add(f_1105_781_960("System.Diagnostics.Eventing.Reader.ProviderMetadata", f_1105_898_959()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1105, 252, 972);

                return listYield;

                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1105_472_531()
                {
                    var return_v = ViewsOf_System_Diagnostics_Eventing_Reader_EventLogRecord();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 472, 531);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1105_357_532(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 357, 532);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1105_684_750()
                {
                    var return_v = ViewsOf_System_Diagnostics_Eventing_Reader_EventLogConfiguration();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 684, 750);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1105_562_751(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 562, 751);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1105_898_959()
                {
                    var return_v = ViewsOf_System_Diagnostics_Eventing_Reader_ProviderMetadata();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 898, 959);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1105_781_960(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 781, 960);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1105, 252, 972);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1105, 252, 972);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Diagnostics_Eventing_Reader_EventLogRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1105, 984, 1814);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1105, 1117, 1803);

                listYield.Add(f_1105_1130_1802("Default", f_1105_1183_1801(f_1105_1183_1772(f_1105_1183_1731(f_1105_1183_1676(f_1105_1183_1612(f_1105_1183_1562(f_1105_1183_1503(f_1105_1183_1460(f_1105_1183_1426(f_1105_1183_1383(f_1105_1183_1324(f_1105_1183_1281(f_1105_1183_1204(), "ProviderName", label: "ProviderName"), width: 26), Alignment.Right, width: 8), width: 16))), "TimeCreated"), "Id"), "LevelDisplayName"), "Message")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1105, 984, 1814);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1105_1183_1204()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1183, 1204);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1105_1183_1281(System.Management.Automation.TableControlBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.GroupByProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1183, 1281);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1105_1183_1324(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1183, 1324);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1105_1183_1383(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1183, 1383);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1105_1183_1426(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1183, 1426);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1105_1183_1460(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1183, 1460);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1105_1183_1503(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1183, 1503);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1105_1183_1562(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1183, 1562);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1105_1183_1612(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1183, 1612);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1105_1183_1676(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1183, 1676);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1105_1183_1731(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1183, 1731);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1105_1183_1772(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1183, 1772);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1105_1183_1801(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1183, 1801);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1105_1130_1802(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1130, 1802);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1105, 984, 1814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1105, 984, 1814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Diagnostics_Eventing_Reader_EventLogConfiguration()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1105, 1826, 2679);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1105, 1966, 2668);

                listYield.Add(f_1105_1979_2667("Default", f_1105_2032_2666(f_1105_2032_2637(f_1105_2032_2596(f_1105_2032_2541(f_1105_2032_2482(f_1105_2032_2416(f_1105_2032_2361(f_1105_2032_2318(f_1105_2032_2284(f_1105_2032_2202(f_1105_2032_2113(f_1105_2032_2053(), label: "LogMode", width: 9), Alignment.Right, label: "MaximumSizeInBytes", width: 18), Alignment.Right, label: "RecordCount", width: 11))), "LogMode"), "MaximumSizeInBytes"), "RecordCount"), "LogName")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1105, 1826, 2679);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1105_2032_2053()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2032, 2053);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1105_2032_2113(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2032, 2113);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1105_2032_2202(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2032, 2202);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1105_2032_2284(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2032, 2284);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1105_2032_2318(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2032, 2318);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1105_2032_2361(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2032, 2361);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1105_2032_2416(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2032, 2416);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1105_2032_2482(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2032, 2482);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1105_2032_2541(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2032, 2541);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1105_2032_2596(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2032, 2596);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1105_2032_2637(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2032, 2637);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1105_2032_2666(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2032, 2666);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1105_1979_2667(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 1979, 2667);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1105, 1826, 2679);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1105, 1826, 2679);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Diagnostics_Eventing_Reader_ProviderMetadata()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1105, 2691, 3233);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1105, 2826, 3222);

                listYield.Add(f_1105_2839_3221("Default", f_1105_2892_3220(f_1105_2892_3192(f_1105_2892_3159(f_1105_2892_3107(f_1105_2892_3053(f_1105_2892_2998(f_1105_2892_2947(f_1105_2892_2912()), @"Name"), @"LogLinks"), @"Opcodes"), @"Tasks")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1105, 2691, 3233);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1105_2892_2912()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2892, 2912);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1105_2892_2947(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2892, 2947);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1105_2892_2998(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2892, 2998);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1105_2892_3053(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2892, 3053);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1105_2892_3107(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2892, 3107);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1105_2892_3159(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2892, 3159);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1105_2892_3192(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2892, 3192);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1105_2892_3220(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2892, 3220);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1105_2839_3221(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1105, 2839, 3221);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1105, 2691, 3233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1105, 2691, 3233);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Event_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1105, 194, 3240);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1105, 194, 3240);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1105, 194, 3240);
        }


        static Event_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1105, 194, 3240);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1105, 194, 3240);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1105, 194, 3240);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1105, 194, 3240);
    }
}
