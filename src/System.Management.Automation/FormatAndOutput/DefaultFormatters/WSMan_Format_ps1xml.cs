// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation.Runspaces
{
    internal sealed class WSMan_Format_Ps1Xml
    {
        internal static IEnumerable<ExtendedTypeDefinition> GetFormatData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1112, 252, 1737);

                var listYield = new List<ExtendedTypeDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1112, 344, 639);

                listYield.Add(f_1112_357_638("System.Xml.XmlElement#http://schemas.dmtf.org/wbem/wsman/identity/1/wsmanidentity.xsd#IdentifyResponse", f_1112_525_637()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1112, 655, 836);

                listYield.Add(f_1112_668_835("Microsoft.WSMan.Management.WSManConfigElement", f_1112_779_834()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1112, 852, 1051);

                listYield.Add(f_1112_865_1050("Microsoft.WSMan.Management.WSManConfigContainerElement", f_1112_985_1049()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1112, 1067, 1256);

                listYield.Add(f_1112_1080_1255("Microsoft.WSMan.Management.WSManConfigLeafElement", f_1112_1195_1254()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1112, 1272, 1483);

                listYield.Add(f_1112_1285_1482("Microsoft.WSMan.Management.WSManConfigLeafElement#InitParams", f_1112_1411_1481()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1112, 1499, 1726);

                listYield.Add(f_1112_1512_1725("Microsoft.WSMan.Management.WSManConfigContainerElement#ComputerLevel", f_1112_1646_1724()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1112, 252, 1737);

                return listYield;

                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1112_525_637()
                {
                    var return_v = ViewsOf_System_Xml_XmlElement_http___schemas_dmtf_org_wbem_wsman_identity_1_wsmanidentity_xsd_IdentifyResponse();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 525, 637);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1112_357_638(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 357, 638);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1112_779_834()
                {
                    var return_v = ViewsOf_Microsoft_WSMan_Management_WSManConfigElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 779, 834);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1112_668_835(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 668, 835);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1112_985_1049()
                {
                    var return_v = ViewsOf_Microsoft_WSMan_Management_WSManConfigContainerElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 985, 1049);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1112_865_1050(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 865, 1050);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1112_1195_1254()
                {
                    var return_v = ViewsOf_Microsoft_WSMan_Management_WSManConfigLeafElement();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 1195, 1254);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1112_1080_1255(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 1080, 1255);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1112_1411_1481()
                {
                    var return_v = ViewsOf_Microsoft_WSMan_Management_WSManConfigLeafElement_InitParams();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 1411, 1481);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1112_1285_1482(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 1285, 1482);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1112_1646_1724()
                {
                    var return_v = ViewsOf_Microsoft_WSMan_Management_WSManConfigContainerElement_ComputerLevel();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 1646, 1724);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1112_1512_1725(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 1512, 1725);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1112, 252, 1737);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1112, 252, 1737);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Xml_XmlElement_http___schemas_dmtf_org_wbem_wsman_identity_1_wsmanidentity_xsd_IdentifyResponse()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1112, 1749, 2460);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1112, 1935, 2449);

                listYield.Add(f_1112_1948_2448("System.Xml.XmlElement#http://schemas.dmtf.org/wbem/wsman/identity/1/wsmanidentity.xsd#IdentifyResponse", f_1112_2096_2447(f_1112_2096_2419(f_1112_2096_2386(f_1112_2096_2325(f_1112_2096_2265(f_1112_2096_2203(f_1112_2096_2151(f_1112_2096_2116()), @"wsmid"), @"ProtocolVersion"), @"ProductVendor"), @"ProductVersion")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1112, 1749, 2460);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1112_2096_2116()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2096, 2116);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1112_2096_2151(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2096, 2151);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1112_2096_2203(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2096, 2203);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1112_2096_2265(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2096, 2265);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1112_2096_2325(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2096, 2325);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1112_2096_2386(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2096, 2386);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1112_2096_2419(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2096, 2419);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1112_2096_2447(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2096, 2447);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1112_1948_2448(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 1948, 2448);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1112, 1749, 2460);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1112, 1749, 2460);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_WSMan_Management_WSManConfigElement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1112, 2472, 3161);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1112, 2601, 3150);

                listYield.Add(f_1112_2614_3149("Microsoft.WSMan.Management.WSManConfigElement", f_1112_2705_3148(f_1112_2705_3119(f_1112_2705_3078(f_1112_2705_3026(f_1112_2705_2961(f_1112_2705_2918(f_1112_2705_2860(f_1112_2705_2802(f_1112_2705_2726(), "PSParentPath", label: "WSManConfig"), label: "Type", width: 15), label: "Name", width: 30)), "TypeNameOfElement"), "Name")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1112, 2472, 3161);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1112_2705_2726()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2705, 2726);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_2705_2802(System.Management.Automation.TableControlBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.GroupByProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2705, 2802);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_2705_2860(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2705, 2860);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_2705_2918(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2705, 2918);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_2705_2961(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2705, 2961);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_2705_3026(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2705, 3026);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_2705_3078(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2705, 3078);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_2705_3119(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2705, 3119);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1112_2705_3148(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2705, 3148);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1112_2614_3149(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 2614, 3149);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1112, 2472, 3161);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1112, 2472, 3161);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_WSMan_Management_WSManConfigContainerElement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1112, 3173, 3979);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1112, 3311, 3968);

                listYield.Add(f_1112_3324_3967("Microsoft.WSMan.Management.WSManConfigContainerElement", f_1112_3424_3966(f_1112_3424_3937(f_1112_3424_3896(f_1112_3424_3844(f_1112_3424_3792(f_1112_3424_3727(f_1112_3424_3684(f_1112_3424_3637(f_1112_3424_3579(f_1112_3424_3521(f_1112_3424_3445(), "PSParentPath", label: "WSManConfig"), label: "Type", width: 15), label: "Keys", width: 35), label: "Name")), "TypeNameOfElement"), "Keys"), "Name")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1112, 3173, 3979);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1112_3424_3445()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 3424, 3445);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_3424_3521(System.Management.Automation.TableControlBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.GroupByProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 3424, 3521);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_3424_3579(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 3424, 3579);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_3424_3637(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 3424, 3637);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_3424_3684(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 3424, 3684);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_3424_3727(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 3424, 3727);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_3424_3792(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 3424, 3792);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_3424_3844(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 3424, 3844);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_3424_3896(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 3424, 3896);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_3424_3937(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 3424, 3937);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1112_3424_3966(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 3424, 3966);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1112_3324_3967(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 3324, 3967);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1112, 3173, 3979);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1112, 3173, 3979);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_WSMan_Management_WSManConfigLeafElement()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1112, 3991, 4917);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1112, 4124, 4906);

                listYield.Add(f_1112_4137_4905("Microsoft.WSMan.Management.WSManConfigLeafElement", f_1112_4232_4904(f_1112_4232_4875(f_1112_4232_4834(f_1112_4232_4781(f_1112_4232_4720(f_1112_4232_4668(f_1112_4232_4603(f_1112_4232_4560(f_1112_4232_4512(f_1112_4232_4445(f_1112_4232_4387(f_1112_4232_4329(f_1112_4232_4253(), "PSParentPath", label: "WSManConfig"), label: "Type", width: 15), label: "Name", width: 30), label: "SourceOfValue", width: 15), label: "Value")), "TypeNameOfElement"), "Name"), "SourceOfValue"), "Value")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1112, 3991, 4917);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1112_4232_4253()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 4232, 4253);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_4232_4329(System.Management.Automation.TableControlBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.GroupByProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 4232, 4329);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_4232_4387(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 4232, 4387);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_4232_4445(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 4232, 4445);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_4232_4512(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 4232, 4512);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_4232_4560(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 4232, 4560);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_4232_4603(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 4232, 4603);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_4232_4668(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 4232, 4668);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_4232_4720(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 4232, 4720);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_4232_4781(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 4232, 4781);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_4232_4834(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 4232, 4834);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_4232_4875(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 4232, 4875);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1112_4232_4904(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 4232, 4904);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1112_4137_4905(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 4137, 4905);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1112, 3991, 4917);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1112, 3991, 4917);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_WSMan_Management_WSManConfigLeafElement_InitParams()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1112, 4929, 5647);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1112, 5073, 5636);

                listYield.Add(f_1112_5086_5635("Microsoft.WSMan.Management.WSManConfigLeafElement#InitParams", f_1112_5192_5634(f_1112_5192_5605(f_1112_5192_5564(f_1112_5192_5511(f_1112_5192_5459(f_1112_5192_5416(f_1112_5192_5352(f_1112_5192_5289(f_1112_5192_5213(), "PSParentPath", label: "WSManConfig"), label: "ParamName", width: 30), label: "ParamValue", width: 20)), "Name"), "Value")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1112, 4929, 5647);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1112_5192_5213()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5192, 5213);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_5192_5289(System.Management.Automation.TableControlBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.GroupByProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5192, 5289);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_5192_5352(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5192, 5352);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_5192_5416(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5192, 5416);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_5192_5459(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5192, 5459);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_5192_5511(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5192, 5511);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_5192_5564(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5192, 5564);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_5192_5605(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5192, 5605);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1112_5192_5634(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5192, 5634);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1112_5086_5635(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5086, 5635);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1112, 4929, 5647);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1112, 4929, 5647);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_WSMan_Management_WSManConfigContainerElement_ComputerLevel()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1112, 5659, 6402);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1112, 5811, 6391);

                listYield.Add(f_1112_5824_6390("Microsoft.WSMan.Management.WSManConfigContainerElement#ComputerLevel", f_1112_5938_6389(f_1112_5938_6360(f_1112_5938_6319(f_1112_5938_6254(f_1112_5938_6202(f_1112_5938_6159(f_1112_5938_6101(f_1112_5938_6035(f_1112_5938_5959(), "PSParentPath", label: "WSManConfig"), label: "ComputerName", width: 45), label: "Type", width: 20)), "Name"), "TypeNameOfElement")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1112, 5659, 6402);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1112_5938_5959()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5938, 5959);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_5938_6035(System.Management.Automation.TableControlBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.GroupByProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5938, 6035);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_5938_6101(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5938, 6101);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_5938_6159(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5938, 6159);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_5938_6202(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5938, 6202);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_5938_6254(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5938, 6254);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1112_5938_6319(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5938, 6319);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1112_5938_6360(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5938, 6360);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1112_5938_6389(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5938, 6389);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1112_5824_6390(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1112, 5824, 6390);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1112, 5659, 6402);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1112, 5659, 6402);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public WSMan_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1112, 194, 6409);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1112, 194, 6409);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1112, 194, 6409);
        }


        static WSMan_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1112, 194, 6409);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1112, 194, 6409);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1112, 194, 6409);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1112, 194, 6409);
    }
}
