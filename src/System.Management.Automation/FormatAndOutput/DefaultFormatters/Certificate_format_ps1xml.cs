// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation.Runspaces
{
    internal sealed class Certificate_Format_Ps1Xml
    {
        internal static IEnumerable<ExtendedTypeDefinition> GetFormatData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1102, 258, 1947);

                var listYield = new List<ExtendedTypeDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 350, 759);

                var
                SignatureTypes_GroupingFormat = f_1102_386_758(f_1102_386_727(f_1102_386_694(f_1102_386_657(f_1102_386_572(f_1102_386_482(f_1102_386_443(f_1102_386_408())), f_1102_521_571()), @"split-path $_.Path"))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 775, 880);

                var
                sharedControls = new CustomControl[] {
                SignatureTypes_GroupingFormat
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 896, 1111);

                listYield.Add(f_1102_909_1110("System.Security.Cryptography.X509Certificates.X509Certificate2", f_1102_1037_1109()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 1127, 1286);

                var
                td2 = f_1102_1137_1285("Microsoft.PowerShell.Commands.X509StoreLocation", f_1102_1250_1284())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 1300, 1384);

                f_1102_1300_1383(f_1102_1300_1313(td2), "System.Security.Cryptography.X509Certificates.X509Certificate2");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 1398, 1475);

                f_1102_1398_1474(f_1102_1398_1411(td2), "System.Security.Cryptography.X509Certificates.X509Store");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 1489, 1506);

                listYield.Add(td2);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 1522, 1703);

                listYield.Add(f_1102_1535_1702("System.Management.Automation.Signature", f_1102_1639_1701(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 1719, 1936);

                listYield.Add(f_1102_1732_1935("System.Security.Cryptography.X509Certificates.X509CertificateEx", f_1102_1861_1934()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1102, 258, 1947);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1102_386_408()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 386, 408);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1102_386_443(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 386, 443);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1102_386_482(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.StartFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 386, 482);
                    return return_v;
                }


                string
                f_1102_521_571()
                {
                    var return_v = FileSystemProviderStrings.DirectoryDisplayGrouping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1102, 521, 571);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1102_386_572(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 386, 572);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1102_386_657(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 386, 657);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1102_386_694(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 386, 694);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1102_386_727(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 386, 727);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1102_386_758(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 386, 758);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1102_1037_1109()
                {
                    var return_v = ViewsOf_System_Security_Cryptography_X509Certificates_X509Certificate2();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 1037, 1109);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1102_909_1110(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 909, 1110);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1102_1250_1284()
                {
                    var return_v = ViewsOf_CertificateProviderTypes();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 1250, 1284);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1102_1137_1285(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 1137, 1285);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1102_1300_1313(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1102, 1300, 1313);
                    return return_v;
                }


                int
                f_1102_1300_1383(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 1300, 1383);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1102_1398_1411(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1102, 1398, 1411);
                    return return_v;
                }


                int
                f_1102_1398_1474(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 1398, 1474);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1102_1639_1701(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_System_Management_Automation_Signature(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 1639, 1701);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1102_1535_1702(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 1535, 1702);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1102_1861_1934()
                {
                    var return_v = ViewsOf_System_Security_Cryptography_X509Certificates_X509CertificateEx();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 1861, 1934);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1102_1732_1935(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 1732, 1935);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1102, 258, 1947);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1102, 258, 1947);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Security_Cryptography_X509Certificates_X509Certificate2()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1102, 1959, 2729);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 2105, 2718);

                listYield.Add(f_1102_2118_2717("ThumbprintTable", f_1102_2179_2716(f_1102_2179_2687(f_1102_2179_2646(f_1102_2179_2559(f_1102_2179_2504(f_1102_2179_2446(f_1102_2179_2403(f_1102_2179_2340(f_1102_2179_2297(f_1102_2179_2254(f_1102_2179_2200(), "PSParentPath"), width: 41), width: 20), label: "EnhancedKeyUsageList")), "Thumbprint"), "Subject"), "$_.EnhancedKeyUsageList.FriendlyName")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1102, 1959, 2729);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1102_2179_2200()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2179, 2200);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_2179_2254(System.Management.Automation.TableControlBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.GroupByProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2179, 2254);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_2179_2297(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2179, 2297);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_2179_2340(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2179, 2340);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_2179_2403(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2179, 2403);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1102_2179_2446(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2179, 2446);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1102_2179_2504(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2179, 2504);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1102_2179_2559(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2179, 2559);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1102_2179_2646(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2179, 2646);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_2179_2687(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2179, 2687);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1102_2179_2716(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2179, 2716);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1102_2118_2717(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2118, 2717);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1102, 1959, 2729);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1102, 1959, 2729);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_CertificateProviderTypes()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1102, 2741, 4899);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 2849, 3963);

                listYield.Add(f_1102_2862_3962("ThumbprintList", f_1102_2922_3961(f_1102_2922_3933(f_1102_2922_3900(f_1102_2922_3843(f_1102_2922_3788(f_1102_2922_3732(f_1102_2922_3673(f_1102_2922_3616(f_1102_2922_3531(f_1102_2922_3444(f_1102_2922_3409(f_1102_2922_3376(f_1102_2922_3325(f_1102_2922_3202(f_1102_2922_3169(f_1102_2922_3112(f_1102_2922_3057(f_1102_2922_2942(), entrySelectedByType: new[] { "Microsoft.PowerShell.Commands.X509StoreLocation" }), @"Location"), @"StoreNames")), entrySelectedByType: new[] { "System.Security.Cryptography.X509Certificates.X509Store" }), @"Name"))), @"$_.SubjectName.Name", label: "Subject"), @"$_.IssuerName.Name", label: "Issuer"), @"Thumbprint"), @"FriendlyName"), @"NotBefore"), @"NotAfter"), @"Extensions")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 3979, 4216);

                listYield.Add(f_1102_3992_4215("ThumbprintWide", f_1102_4052_4214(f_1102_4052_4179(f_1102_4052_4126(f_1102_4052_4072(), "PSParentPath"), "Thumbprint"))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 4232, 4888);

                listYield.Add(f_1102_4245_4887("PathOnly", f_1102_4299_4886(f_1102_4299_4858(f_1102_4299_4825(f_1102_4299_4772(f_1102_4299_4649(f_1102_4299_4616(f_1102_4299_4559(f_1102_4299_4444(f_1102_4299_4411(f_1102_4299_4354(f_1102_4299_4319()), @"PSPathPath")), entrySelectedByType: new[] { "Microsoft.PowerShell.Commands.X509StoreLocation" }), @"PSPathPath")), entrySelectedByType: new[] { "System.Security.Cryptography.X509Certificates.X509Store" }), @"PSPath")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1102, 2741, 4899);

                return listYield;

                System.Management.Automation.ListControlBuilder
                f_1102_2922_2942()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 2942);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_2922_3057(System.Management.Automation.ListControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3057);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_2922_3112(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3112);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_2922_3169(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3169);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1102_2922_3202(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3202);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_2922_3325(System.Management.Automation.ListControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3325);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_2922_3376(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3376);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1102_2922_3409(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3409);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_2922_3444(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3444);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_2922_3531(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3531);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_2922_3616(System.Management.Automation.ListEntryBuilder
                this_param, string
                scriptBlock, string
                label)
                {
                    var return_v = this_param.AddItemScriptBlock(scriptBlock, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3616);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_2922_3673(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3673);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_2922_3732(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3732);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_2922_3788(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3788);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_2922_3843(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3843);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_2922_3900(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3900);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1102_2922_3933(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3933);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1102_2922_3961(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2922, 3961);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1102_2862_3962(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 2862, 3962);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1102_4052_4072()
                {
                    var return_v = WideControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4052, 4072);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1102_4052_4126(System.Management.Automation.WideControlBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.GroupByProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4052, 4126);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1102_4052_4179(System.Management.Automation.WideControlBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyEntry(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4052, 4179);
                    return return_v;
                }


                System.Management.Automation.WideControl
                f_1102_4052_4214(System.Management.Automation.WideControlBuilder
                this_param)
                {
                    var return_v = this_param.EndWideControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4052, 4214);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1102_3992_4215(string
                name, System.Management.Automation.WideControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 3992, 4215);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1102_4299_4319()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4299, 4319);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_4299_4354(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4299, 4354);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_4299_4411(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4299, 4411);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1102_4299_4444(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4299, 4444);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_4299_4559(System.Management.Automation.ListControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4299, 4559);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_4299_4616(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4299, 4616);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1102_4299_4649(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4299, 4649);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_4299_4772(System.Management.Automation.ListControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4299, 4772);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1102_4299_4825(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4299, 4825);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1102_4299_4858(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4299, 4858);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1102_4299_4886(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4299, 4886);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1102_4245_4887(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 4245, 4887);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1102, 2741, 4899);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1102, 2741, 4899);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Management_Automation_Signature(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1102, 4911, 6178);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 5063, 5830);

                listYield.Add(f_1102_5076_5829("PSThumbprintTable", f_1102_5139_5828(f_1102_5139_5799(f_1102_5139_5758(f_1102_5139_5683(f_1102_5139_5622(f_1102_5139_5568(f_1102_5139_5486(f_1102_5139_5443(f_1102_5139_5396(f_1102_5139_5362(f_1102_5139_5328(f_1102_5139_5257(f_1102_5139_5160(), "split-path $_.Path", customControl: sharedControls[0]), label: "SignerCertificate", width: 41))), label: "Path")), "$_.SignerCertificate.Thumbprint"), "Status"), "StatusMessage"), "split-path $_.Path -leaf")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 5846, 6167);

                listYield.Add(f_1102_5859_6166("PSThumbprintWide", f_1102_5921_6165(f_1102_5921_6130(f_1102_5921_6038(f_1102_5921_5941(), "split-path $_.Path", customControl: sharedControls[0]), @"""$(split-path $_.Path -leaf): $($_.Status)"""))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1102, 4911, 6178);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1102_5139_5160()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5139, 5160);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_5139_5257(System.Management.Automation.TableControlBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.GroupByScriptBlock(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5139, 5257);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_5139_5328(System.Management.Automation.TableControlBuilder
                this_param, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5139, 5328);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_5139_5362(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5139, 5362);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_5139_5396(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5139, 5396);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_5139_5443(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5139, 5443);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1102_5139_5486(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5139, 5486);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1102_5139_5568(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5139, 5568);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1102_5139_5622(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5139, 5622);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1102_5139_5683(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5139, 5683);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1102_5139_5758(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5139, 5758);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_5139_5799(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5139, 5799);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1102_5139_5828(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5139, 5828);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1102_5076_5829(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5076, 5829);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1102_5921_5941()
                {
                    var return_v = WideControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5921, 5941);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1102_5921_6038(System.Management.Automation.WideControlBuilder
                this_param, string
                scriptBlock, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.GroupByScriptBlock(scriptBlock, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5921, 6038);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1102_5921_6130(System.Management.Automation.WideControlBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockEntry(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5921, 6130);
                    return return_v;
                }


                System.Management.Automation.WideControl
                f_1102_5921_6165(System.Management.Automation.WideControlBuilder
                this_param)
                {
                    var return_v = this_param.EndWideControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5921, 6165);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1102_5859_6166(string
                name, System.Management.Automation.WideControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 5859, 6166);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1102, 4911, 6178);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1102, 4911, 6178);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Security_Cryptography_X509Certificates_X509CertificateEx()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1102, 6190, 6850);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1102, 6337, 6839);

                listYield.Add(f_1102_6350_6838("System.Security.Cryptography.X509Certificates.X509CertificateEx", f_1102_6459_6837(f_1102_6459_6808(f_1102_6459_6767(f_1102_6459_6712(f_1102_6459_6654(f_1102_6459_6611(f_1102_6459_6577(f_1102_6459_6534(f_1102_6459_6480(), "PSParentPath"), width: 41))), "Thumbprint"), "Subject")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1102, 6190, 6850);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1102_6459_6480()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 6459, 6480);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_6459_6534(System.Management.Automation.TableControlBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.GroupByProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 6459, 6534);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_6459_6577(System.Management.Automation.TableControlBuilder
                this_param, int
                width)
                {
                    var return_v = this_param.AddHeader(width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 6459, 6577);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_6459_6611(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 6459, 6611);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1102_6459_6654(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 6459, 6654);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1102_6459_6712(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 6459, 6712);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1102_6459_6767(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 6459, 6767);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1102_6459_6808(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 6459, 6808);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1102_6459_6837(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 6459, 6837);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1102_6350_6838(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1102, 6350, 6838);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1102, 6190, 6850);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1102, 6190, 6850);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public Certificate_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1102, 194, 6857);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1102, 194, 6857);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1102, 194, 6857);
        }


        static Certificate_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1102, 194, 6857);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1102, 194, 6857);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1102, 194, 6857);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1102, 194, 6857);
    }
}
