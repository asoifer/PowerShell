// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;

namespace System.Management.Automation.Runspaces
{
    internal sealed class FileSystem_Format_Ps1Xml
    {
        internal static IEnumerable<ExtendedTypeDefinition> GetFormatData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1106, 257, 1710);

                var listYield = new List<ExtendedTypeDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1106, 349, 914);

                var
                FileSystemTypes_GroupingFormat = f_1106_386_913(f_1106_386_882(f_1106_386_849(f_1106_386_812(f_1106_386_572(f_1106_386_482(f_1106_386_443(f_1106_386_408())), f_1106_521_571()), @"
                                                  $_.PSParentPath.Replace(""Microsoft.PowerShell.Core\FileSystem::"", """")
                                              "))))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1106, 930, 1036);

                var
                sharedControls = new CustomControl[] {
                FileSystemTypes_GroupingFormat
                            }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1106, 1052, 1192);

                var
                td1 = f_1106_1062_1191("System.IO.DirectoryInfo", f_1106_1151_1190(sharedControls))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1106, 1206, 1246);

                f_1106_1206_1245(f_1106_1206_1219(td1), "System.IO.FileInfo");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1106, 1260, 1277);

                listYield.Add(td1);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1106, 1293, 1494);

                listYield.Add(f_1106_1306_1493("System.Security.AccessControl.FileSystemSecurity", f_1106_1420_1492(sharedControls)));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1106, 1510, 1699);

                listYield.Add(f_1106_1523_1698("Microsoft.PowerShell.Commands.AlternateStreamData", f_1106_1638_1697()));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1106, 257, 1710);

                return listYield;

                System.Management.Automation.CustomControlBuilder
                f_1106_386_408()
                {
                    var return_v = CustomControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 386, 408);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1106_386_443(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 386, 443);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1106_386_482(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.StartFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 386, 482);
                    return return_v;
                }


                string
                f_1106_521_571()
                {
                    var return_v = FileSystemProviderStrings.DirectoryDisplayGrouping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1106, 521, 571);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1106_386_572(System.Management.Automation.CustomEntryBuilder
                this_param, string
                text)
                {
                    var return_v = this_param.AddText(text);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 386, 572);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1106_386_812(System.Management.Automation.CustomEntryBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockExpressionBinding(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 386, 812);
                    return return_v;
                }


                System.Management.Automation.CustomEntryBuilder
                f_1106_386_849(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndFrame();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 386, 849);
                    return return_v;
                }


                System.Management.Automation.CustomControlBuilder
                f_1106_386_882(System.Management.Automation.CustomEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 386, 882);
                    return return_v;
                }


                System.Management.Automation.CustomControl
                f_1106_386_913(System.Management.Automation.CustomControlBuilder
                this_param)
                {
                    var return_v = this_param.EndControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 386, 913);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1106_1151_1190(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_FileSystemTypes(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 1151, 1190);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1106_1062_1191(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 1062, 1191);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1106_1206_1219(System.Management.Automation.ExtendedTypeDefinition
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1106, 1206, 1219);
                    return return_v;
                }


                int
                f_1106_1206_1245(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 1206, 1245);
                    return 0;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1106_1420_1492(System.Management.Automation.CustomControl[]
                sharedControls)
                {
                    var return_v = ViewsOf_System_Security_AccessControl_FileSystemSecurity(sharedControls);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 1420, 1492);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1106_1306_1493(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 1306, 1493);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                f_1106_1638_1697()
                {
                    var return_v = ViewsOf_Microsoft_PowerShell_Commands_AlternateStreamData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 1638, 1697);
                    return return_v;
                }


                System.Management.Automation.ExtendedTypeDefinition
                f_1106_1523_1698(string
                typeName, System.Collections.Generic.IEnumerable<System.Management.Automation.FormatViewDefinition>
                viewDefinitions)
                {
                    var return_v = new System.Management.Automation.ExtendedTypeDefinition(typeName, viewDefinitions);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 1523, 1698);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1106, 257, 1710);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1106, 257, 1710);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_FileSystemTypes(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1106, 1722, 6634);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1106, 3192, 4042);

                listYield.Add(f_1106_3205_4041("children", f_1106_3259_4040(f_1106_3259_4011(f_1106_3259_3970(f_1106_3259_3912(f_1106_3259_3852(f_1106_3259_3785(f_1106_3259_3718(f_1106_3259_3665(f_1106_3259_3602(f_1106_3259_3525(f_1106_3259_3441(f_1106_3259_3368(f_1106_3259_3280(), "PSParentPath", customControl: sharedControls[0]), Alignment.Left, label: "Mode", width: 7), Alignment.Right, label: "LastWriteTime", width: 26), Alignment.Right, label: "Length", width: 14), Alignment.Left, label: "Name"), wrap: true), "ModeWithoutHardLink"), "LastWriteTimeString"), "LengthString"), "NameString")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1106, 4058, 4905);

                listYield.Add(f_1106_4071_4904("childrenWithHardlink", f_1106_4137_4903(f_1106_4137_4874(f_1106_4137_4833(f_1106_4137_4775(f_1106_4137_4715(f_1106_4137_4648(f_1106_4137_4596(f_1106_4137_4543(f_1106_4137_4480(f_1106_4137_4403(f_1106_4137_4319(f_1106_4137_4246(f_1106_4137_4158(), "PSParentPath", customControl: sharedControls[0]), Alignment.Left, label: "Mode", width: 7), Alignment.Right, label: "LastWriteTime", width: 26), Alignment.Right, label: "Length", width: 14), Alignment.Left, label: "Name"), wrap: true), "Mode"), "LastWriteTimeString"), "LengthString"), "NameString")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1106, 4921, 6226);

                listYield.Add(f_1106_4934_6225("children", f_1106_4988_6224(f_1106_4988_6196(f_1106_4988_6163(f_1106_4988_6110(f_1106_4988_6055(f_1106_4988_6004(f_1106_4988_5943(f_1106_4988_5883(f_1106_4988_5824(f_1106_4988_5773(f_1106_4988_5738(f_1106_4988_5705(f_1106_4988_5647(f_1106_4988_5594(f_1106_4988_5539(f_1106_4988_5488(f_1106_4988_5427(f_1106_4988_5367(f_1106_4988_5308(f_1106_4988_5233(f_1106_4988_5182(f_1106_4988_5096(f_1106_4988_5008(), "PSParentPath", customControl: sharedControls[0]), entrySelectedByType: new[] { "System.IO.FileInfo" }), @"Name"), "LengthString", label: "Length"), @"CreationTime"), @"LastWriteTime"), @"LastAccessTime"), @"Mode"), @"LinkType"), @"Target"), @"VersionInfo"))), @"Name"), @"CreationTime"), @"LastWriteTime"), @"LastAccessTime"), @"Mode"), @"LinkType"), @"Target")))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1106, 6242, 6623);

                listYield.Add(f_1106_6255_6622("children", f_1106_6309_6621(f_1106_6309_6586(f_1106_6309_6464(f_1106_6309_6417(f_1106_6309_6329(), "PSParentPath", customControl: sharedControls[0]), "Name"), "Name", format: "[{0}]", entrySelectedByType: new[] { "System.IO.DirectoryInfo" }))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1106, 1722, 6634);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1106_3259_3280()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 3259, 3280);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_3259_3368(System.Management.Automation.TableControlBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.GroupByProperty(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 3259, 3368);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_3259_3441(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 3259, 3441);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_3259_3525(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 3259, 3525);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_3259_3602(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 3259, 3602);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_3259_3665(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label)
                {
                    var return_v = this_param.AddHeader(alignment, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 3259, 3665);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_3259_3718(System.Management.Automation.TableControlBuilder
                this_param, bool
                wrap)
                {
                    var return_v = this_param.StartRowDefinition(wrap: wrap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 3259, 3718);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_3259_3785(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 3259, 3785);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_3259_3852(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 3259, 3852);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_3259_3912(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 3259, 3912);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_3259_3970(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 3259, 3970);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_3259_4011(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 3259, 4011);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1106_3259_4040(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 3259, 4040);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1106_3205_4041(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 3205, 4041);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_4137_4158()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4137, 4158);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_4137_4246(System.Management.Automation.TableControlBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.GroupByProperty(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4137, 4246);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_4137_4319(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4137, 4319);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_4137_4403(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4137, 4403);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_4137_4480(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, label: label, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4137, 4480);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_4137_4543(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, string
                label)
                {
                    var return_v = this_param.AddHeader(alignment, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4137, 4543);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_4137_4596(System.Management.Automation.TableControlBuilder
                this_param, bool
                wrap)
                {
                    var return_v = this_param.StartRowDefinition(wrap: wrap);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4137, 4596);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_4137_4648(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4137, 4648);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_4137_4715(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4137, 4715);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_4137_4775(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4137, 4775);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_4137_4833(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4137, 4833);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_4137_4874(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4137, 4874);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1106_4137_4903(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4137, 4903);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1106_4071_4904(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4071, 4904);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1106_4988_5008()
                {
                    var return_v = ListControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5008);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1106_4988_5096(System.Management.Automation.ListControlBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.GroupByProperty(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5096);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_5182(System.Management.Automation.ListControlBuilder
                this_param, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.StartEntry(entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5182);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_5233(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5233);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_5308(System.Management.Automation.ListEntryBuilder
                this_param, string
                property, string
                label)
                {
                    var return_v = this_param.AddItemProperty(property, label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5308);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_5367(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5367);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_5427(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5427);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_5488(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5488);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_5539(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5539);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_5594(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5594);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_5647(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5647);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_5705(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5705);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1106_4988_5738(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5738);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_5773(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.StartEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5773);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_5824(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5824);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_5883(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5883);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_5943(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 5943);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_6004(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 6004);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_6055(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 6055);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_6110(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 6110);
                    return return_v;
                }


                System.Management.Automation.ListEntryBuilder
                f_1106_4988_6163(System.Management.Automation.ListEntryBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.AddItemProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 6163);
                    return return_v;
                }


                System.Management.Automation.ListControlBuilder
                f_1106_4988_6196(System.Management.Automation.ListEntryBuilder
                this_param)
                {
                    var return_v = this_param.EndEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 6196);
                    return return_v;
                }


                System.Management.Automation.ListControl
                f_1106_4988_6224(System.Management.Automation.ListControlBuilder
                this_param)
                {
                    var return_v = this_param.EndList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4988, 6224);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1106_4934_6225(string
                name, System.Management.Automation.ListControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 4934, 6225);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1106_6309_6329()
                {
                    var return_v = WideControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6309, 6329);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1106_6309_6417(System.Management.Automation.WideControlBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.GroupByProperty(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6309, 6417);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1106_6309_6464(System.Management.Automation.WideControlBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyEntry(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6309, 6464);
                    return return_v;
                }


                System.Management.Automation.WideControlBuilder
                f_1106_6309_6586(System.Management.Automation.WideControlBuilder
                this_param, string
                propertyName, string
                format, string[]
                entrySelectedByType)
                {
                    var return_v = this_param.AddPropertyEntry(propertyName, format: format, entrySelectedByType: (System.Collections.Generic.IEnumerable<string>)entrySelectedByType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6309, 6586);
                    return return_v;
                }


                System.Management.Automation.WideControl
                f_1106_6309_6621(System.Management.Automation.WideControlBuilder
                this_param)
                {
                    var return_v = this_param.EndWideControl();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6309, 6621);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1106_6255_6622(string
                name, System.Management.Automation.WideControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6255, 6622);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1106, 1722, 6634);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1106, 1722, 6634);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_System_Security_AccessControl_FileSystemSecurity(CustomControl[] sharedControls)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1106, 6646, 7591);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1106, 6808, 7580);

                listYield.Add(f_1106_6821_7579("FileSecurityTable", f_1106_6884_7578(f_1106_6884_7549(f_1106_6884_7508(f_1106_6884_7367(f_1106_6884_7314(f_1106_6884_7166(f_1106_6884_7123(f_1106_6884_7074(f_1106_6884_7040(f_1106_6884_6993(f_1106_6884_6905(), "PSParentPath", customControl: sharedControls[0]), label: "Path")), label: "Access")), @"
                                    split-path $_.Path -leaf
                                "), "Owner"), @"
                                    $_.AccessToString
                                ")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1106, 6646, 7591);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1106_6884_6905()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6884, 6905);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_6884_6993(System.Management.Automation.TableControlBuilder
                this_param, string
                property, System.Management.Automation.CustomControl
                customControl)
                {
                    var return_v = this_param.GroupByProperty(property, customControl: customControl);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6884, 6993);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_6884_7040(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6884, 7040);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_6884_7074(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.AddHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6884, 7074);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_6884_7123(System.Management.Automation.TableControlBuilder
                this_param, string
                label)
                {
                    var return_v = this_param.AddHeader(label: label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6884, 7123);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_6884_7166(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6884, 7166);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_6884_7314(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6884, 7314);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_6884_7367(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6884, 7367);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_6884_7508(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                scriptBlock)
                {
                    var return_v = this_param.AddScriptBlockColumn(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6884, 7508);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_6884_7549(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6884, 7549);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1106_6884_7578(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6884, 7578);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1106_6821_7579(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 6821, 7579);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1106, 6646, 7591);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1106, 6646, 7591);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static IEnumerable<FormatViewDefinition> ViewsOf_Microsoft_PowerShell_Commands_AlternateStreamData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1106, 7603, 8235);

                var listYield = new List<FormatViewDefinition>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1106, 7736, 8224);

                listYield.Add(f_1106_7749_8223("FileSystemStream", f_1106_7811_8222(f_1106_7811_8193(f_1106_7811_8152(f_1106_7811_8098(f_1106_7811_8044(f_1106_7811_8001(f_1106_7811_7941(f_1106_7811_7882(f_1106_7811_7832(), "Filename"), Alignment.Left, width: 20), Alignment.Right, width: 10)), "Stream"), "Length")))));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1106, 7603, 8235);

                return listYield;

                System.Management.Automation.TableControlBuilder
                f_1106_7811_7832()
                {
                    var return_v = TableControl.Create();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 7811, 7832);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_7811_7882(System.Management.Automation.TableControlBuilder
                this_param, string
                property)
                {
                    var return_v = this_param.GroupByProperty(property);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 7811, 7882);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_7811_7941(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 7811, 7941);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_7811_8001(System.Management.Automation.TableControlBuilder
                this_param, System.Management.Automation.Alignment
                alignment, int
                width)
                {
                    var return_v = this_param.AddHeader(alignment, width: width);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 7811, 8001);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_7811_8044(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.StartRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 7811, 8044);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_7811_8098(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 7811, 8098);
                    return return_v;
                }


                System.Management.Automation.TableRowDefinitionBuilder
                f_1106_7811_8152(System.Management.Automation.TableRowDefinitionBuilder
                this_param, string
                propertyName)
                {
                    var return_v = this_param.AddPropertyColumn(propertyName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 7811, 8152);
                    return return_v;
                }


                System.Management.Automation.TableControlBuilder
                f_1106_7811_8193(System.Management.Automation.TableRowDefinitionBuilder
                this_param)
                {
                    var return_v = this_param.EndRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 7811, 8193);
                    return return_v;
                }


                System.Management.Automation.TableControl
                f_1106_7811_8222(System.Management.Automation.TableControlBuilder
                this_param)
                {
                    var return_v = this_param.EndTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 7811, 8222);
                    return return_v;
                }


                System.Management.Automation.FormatViewDefinition
                f_1106_7749_8223(string
                name, System.Management.Automation.TableControl
                control)
                {
                    var return_v = new System.Management.Automation.FormatViewDefinition(name, (System.Management.Automation.PSControl)control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1106, 7749, 8223);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1106, 7603, 8235);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1106, 7603, 8235);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public FileSystem_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1106, 194, 8242);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1106, 194, 8242);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1106, 194, 8242);
        }


        static FileSystem_Format_Ps1Xml()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1106, 194, 8242);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1106, 194, 8242);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1106, 194, 8242);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1106, 194, 8242);
    }
}
