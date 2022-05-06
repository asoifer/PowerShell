// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Management.Automation.Internal;
using System.Xml;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed partial class TypeInfoDataBaseLoader : XmlLoaderBase
    {
        private ControlBase LoadTableControl(XmlNode controlNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1132, 523, 6452);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 605, 6441);
                using (f_1132_612_640(this, controlNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 674, 726);

                    TableControlBody
                    tableBody = f_1132_703_725()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 744, 774);

                    bool
                    headersNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 817, 850);

                    bool
                    rowEntriesNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 887, 921);

                    bool
                    hideHeadersNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 961, 992);

                    bool
                    autosizeNodeFound = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 1034, 3989);
                        foreach (XmlNode n in f_1132_1056_1078_I(f_1132_1056_1078(controlNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 1034, 3989);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 1120, 3970) || true) && (f_1132_1124_1170(this, n, XmlTags.HideTableHeadersNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 1120, 3970);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 1220, 1415) || true) && (hideHeadersNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 1220, 1415);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 1302, 1331);

                                    f_1132_1302_1330(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 1361, 1373);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 1220, 1415);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 1443, 1471);

                                hideHeadersNodeFound = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 1497, 1670) || true) && (!f_1132_1502_1558(this, n, out tableBody.header.hideHeader))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 1497, 1670);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 1616, 1628);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 1497, 1670);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 1120, 3970);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 1120, 3970);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 1720, 3970) || true) && (f_1132_1724_1762(this, n, XmlTags.AutoSizeNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 1720, 3970);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 1812, 2004) || true) && (autosizeNodeFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 1812, 2004);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 1891, 1920);

                                        f_1132_1891_1919(this, n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 1950, 1962);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 1812, 2004);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 2032, 2057);

                                    autosizeNodeFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 2083, 2096);

                                    bool
                                    tempVal
                                    = default(bool);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 2122, 2275) || true) && (!f_1132_2127_2163(this, n, out tempVal))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 2122, 2275);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 2221, 2233);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 2122, 2275);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 2303, 2332);

                                    tableBody.autosize = tempVal;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 1720, 3970);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 1720, 3970);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 2382, 3970) || true) && (f_1132_2386_2428(this, n, XmlTags.TableHeadersNode))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 2382, 3970);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 2478, 2669) || true) && (headersNodeFound)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 2478, 2669);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 2556, 2585);

                                            f_1132_2556_2584(this, n);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 2615, 2627);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 2478, 2669);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 2697, 2721);

                                        headersNodeFound = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 2813, 2846);

                                        f_1132_2813_2845(this, tableBody, n);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 2872, 3126) || true) && (tableBody.header.columnHeaderDefinitionList == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 2872, 3126);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 3072, 3084);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 2872, 3126);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 2382, 3970);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 2382, 3970);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 3176, 3970) || true) && (f_1132_3180_3225(this, n, XmlTags.TableRowEntriesNode))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 3176, 3970);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 3275, 3469) || true) && (rowEntriesNodeFound)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 3275, 3469);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 3356, 3385);

                                                f_1132_3356_3384(this, n);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 3415, 3427);

                                                return null;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 3275, 3469);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 3497, 3524);

                                            rowEntriesNodeFound = true;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 3609, 3645);

                                            f_1132_3609_3644(this, tableBody, n);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 3671, 3822) || true) && (tableBody.defaultDefinition == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 3671, 3822);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 3768, 3780);

                                                return null;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 3671, 3822);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 3176, 3970);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 3176, 3970);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 3920, 3947);

                                            f_1132_3920_3946(this, n);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 3176, 3970);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 2382, 3970);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 1720, 3970);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 1120, 3970);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 1034, 3989);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1132, 1, 2956);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1132, 1, 2956);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 4009, 4195) || true) && (!rowEntriesNodeFound)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 4009, 4195);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 4075, 4127);

                        f_1132_4075_4126(this, XmlTags.TableRowEntriesNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 4149, 4161);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 4009, 4195);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 4288, 5245) || true) && (f_1132_4292_4341(tableBody.header.columnHeaderDefinitionList) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 4288, 5245);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 4541, 5226) || true) && (f_1132_4545_4594(tableBody.header.columnHeaderDefinitionList) !=
                        f_1132_4623_4678(tableBody.defaultDefinition.rowItemDefinitionList))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 4541, 5226);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 4857, 5148);

                            f_1132_4857_5147(                        // Error at XPath {0} in file {1}: Header item count = {2} does not match default row item count = {3}.
                                                    this, f_1132_4874_5146(f_1132_4892_4946(), f_1132_4948_4969(this), f_1132_4971_4979(), f_1132_5010_5059(tableBody.header.columnHeaderDefinitionList), f_1132_5090_5145(tableBody.defaultDefinition.rowItemDefinitionList)));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 5176, 5188);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 4541, 5226);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 4288, 5245);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 5371, 6389) || true) && (f_1132_5375_5413(tableBody.optionalDefinitionList) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 5371, 6389);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 5460, 5470);

                        int
                        k = 0
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 5492, 6370);
                            foreach (TableRowDefinition trd in f_1132_5527_5559_I(tableBody.optionalDefinitionList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 5492, 6370);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 5609, 6315) || true) && (f_1132_5613_5644(trd.rowItemDefinitionList) !=
                                f_1132_5677_5732(tableBody.defaultDefinition.rowItemDefinitionList))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 5609, 6315);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 5944, 6229);

                                    f_1132_5944_6228(                            // Error at XPath {0} in file {1}: Row item count = {2} on alternative set #{3} does not match default row item count = {4}.
                                                                this, f_1132_5961_6227(f_1132_5979_6030(), f_1132_6032_6053(this), f_1132_6055_6063(), f_1132_6098_6129(trd.rowItemDefinitionList), f_1132_6164_6219(tableBody.defaultDefinition.rowItemDefinitionList), k + 1));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 6261, 6273);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 5609, 6315);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 6343, 6347);

                                k++;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 5492, 6370);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1132, 1, 879);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1132, 1, 879);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 5371, 6389);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 6409, 6426);

                    return tableBody;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1132, 605, 6441);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1132, 523, 6452);

                System.IDisposable
                f_1132_612_640(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 612, 640);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableControlBody
                f_1132_703_725()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableControlBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 703, 725);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1132_1056_1078(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 1056, 1078);
                    return return_v;
                }


                bool
                f_1132_1124_1170(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 1124, 1170);
                    return return_v;
                }


                int
                f_1132_1302_1330(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 1302, 1330);
                    return 0;
                }


                bool
                f_1132_1502_1558(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                collectionElement, out bool
                val)
                {
                    var return_v = this_param.ReadBooleanNode(collectionElement, out val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 1502, 1558);
                    return return_v;
                }


                bool
                f_1132_1724_1762(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 1724, 1762);
                    return return_v;
                }


                int
                f_1132_1891_1919(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 1891, 1919);
                    return 0;
                }


                bool
                f_1132_2127_2163(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                collectionElement, out bool
                val)
                {
                    var return_v = this_param.ReadBooleanNode(collectionElement, out val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 2127, 2163);
                    return return_v;
                }


                bool
                f_1132_2386_2428(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 2386, 2428);
                    return return_v;
                }


                int
                f_1132_2556_2584(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 2556, 2584);
                    return 0;
                }


                int
                f_1132_2813_2845(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableControlBody
                tableBody, System.Xml.XmlNode
                headersNode)
                {
                    this_param.LoadHeadersSection(tableBody, headersNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 2813, 2845);
                    return 0;
                }


                bool
                f_1132_3180_3225(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 3180, 3225);
                    return return_v;
                }


                int
                f_1132_3356_3384(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 3356, 3384);
                    return 0;
                }


                int
                f_1132_3609_3644(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableControlBody
                tableBody, System.Xml.XmlNode
                rowEntriesNode)
                {
                    this_param.LoadRowEntriesSection(tableBody, rowEntriesNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 3609, 3644);
                    return 0;
                }


                int
                f_1132_3920_3946(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 3920, 3946);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1132_1056_1078_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 1056, 1078);
                    return return_v;
                }


                int
                f_1132_4075_4126(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                name)
                {
                    this_param.ReportMissingNode(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 4075, 4126);
                    return 0;
                }


                int
                f_1132_4292_4341(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 4292, 4341);
                    return return_v;
                }


                int
                f_1132_4545_4594(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 4545, 4594);
                    return return_v;
                }


                int
                f_1132_4623_4678(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 4623, 4678);
                    return return_v;
                }


                string
                f_1132_4892_4946()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.IncorrectHeaderItemCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 4892, 4946);
                    return return_v;
                }


                string
                f_1132_4948_4969(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 4948, 4969);
                    return return_v;
                }


                string
                f_1132_4971_4979()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 4971, 4979);
                    return return_v;
                }


                int
                f_1132_5010_5059(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 5010, 5059);
                    return return_v;
                }


                int
                f_1132_5090_5145(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 5090, 5145);
                    return return_v;
                }


                string
                f_1132_4874_5146(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 4874, 5146);
                    return return_v;
                }


                int
                f_1132_4857_5147(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 4857, 5147);
                    return 0;
                }


                int
                f_1132_5375_5413(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 5375, 5413);
                    return return_v;
                }


                int
                f_1132_5613_5644(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 5613, 5644);
                    return return_v;
                }


                int
                f_1132_5677_5732(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 5677, 5732);
                    return return_v;
                }


                string
                f_1132_5979_6030()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.IncorrectRowItemCount;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 5979, 6030);
                    return return_v;
                }


                string
                f_1132_6032_6053(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 6032, 6053);
                    return return_v;
                }


                string
                f_1132_6055_6063()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 6055, 6063);
                    return return_v;
                }


                int
                f_1132_6098_6129(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 6098, 6129);
                    return return_v;
                }


                int
                f_1132_6164_6219(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 6164, 6219);
                    return return_v;
                }


                string
                f_1132_5961_6227(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 5961, 6227);
                    return return_v;
                }


                int
                f_1132_5944_6228(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 5944, 6228);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
                f_1132_5527_5559_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 5527, 5559);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1132, 523, 6452);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1132, 523, 6452);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadHeadersSection(TableControlBody tableBody, XmlNode headersNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1132, 6464, 7832);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 6569, 7821);
                using (f_1132_6576_6604(this, headersNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 6638, 6658);

                    int
                    columnIndex = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 6676, 7731);
                        foreach (XmlNode n in f_1132_6698_6720_I(f_1132_6698_6720(headersNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 6676, 7731);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 6762, 7712) || true) && (f_1132_6766_6813(this, n, XmlTags.TableColumnHeaderNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 6762, 7712);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 6863, 6942);

                                TableColumnHeaderDefinition
                                chd = f_1132_6897_6941(this, n, columnIndex++)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 6970, 7564) || true) && (chd != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 6970, 7564);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 7016, 7069);

                                    f_1132_7016_7068(tableBody.header.columnHeaderDefinitionList, chd);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 6970, 7564);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 6970, 7564);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 7284, 7404);

                                    f_1132_7284_7403(                            // Error at XPath {0} in file {1}: Column header definition is invalid; all headers are discarded.
                                                                this, f_1132_7301_7402(f_1132_7319_7368(), f_1132_7370_7391(this), f_1132_7393_7401()));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 7434, 7485);

                                    tableBody.header.columnHeaderDefinitionList = null;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 7515, 7522);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 6970, 7564);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 6762, 7712);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 6762, 7712);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 7662, 7689);

                                f_1132_7662_7688(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 6762, 7712);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 6676, 7731);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1132, 1, 1056);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1132, 1, 1056);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1132, 6569, 7821);
                    // NOTICE: the list can be empty if no entries were found
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1132, 6464, 7832);

                System.IDisposable
                f_1132_6576_6604(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 6576, 6604);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1132_6698_6720(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 6698, 6720);
                    return return_v;
                }


                bool
                f_1132_6766_6813(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 6766, 6813);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition
                f_1132_6897_6941(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                columnHeaderNode, int
                index)
                {
                    var return_v = this_param.LoadColumnHeaderDefinition(columnHeaderNode, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 6897, 6941);
                    return return_v;
                }


                int
                f_1132_7016_7068(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 7016, 7068);
                    return 0;
                }


                string
                f_1132_7319_7368()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.InvalidColumnHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 7319, 7368);
                    return return_v;
                }


                string
                f_1132_7370_7391(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 7370, 7391);
                    return return_v;
                }


                string
                f_1132_7393_7401()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 7393, 7401);
                    return return_v;
                }


                string
                f_1132_7301_7402(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 7301, 7402);
                    return return_v;
                }


                int
                f_1132_7284_7403(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 7284, 7403);
                    return 0;
                }


                int
                f_1132_7662_7688(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 7662, 7688);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1132_6698_6720_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 6698, 6720);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1132, 6464, 7832);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1132, 6464, 7832);
            }
        }

        private TableColumnHeaderDefinition LoadColumnHeaderDefinition(XmlNode columnHeaderNode, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1132, 7844, 10753);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 7968, 10742);
                using (f_1132_7975_8015(this, columnHeaderNode, index))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 8049, 8117);

                    TableColumnHeaderDefinition
                    chd = f_1132_8083_8116()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 8137, 8165);

                    bool
                    labelNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 8203, 8231);

                    bool
                    widthNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 8269, 8301);

                    bool
                    alignmentNodeFound = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 8341, 10696);
                        foreach (XmlNode n in f_1132_8363_8390_I(f_1132_8363_8390(columnHeaderNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 8341, 10696);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 8432, 10677) || true) && (f_1132_8436_8485(this, n, XmlTags.LabelNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 8432, 10677);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 8535, 8724) || true) && (labelNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 8535, 8724);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 8611, 8640);

                                    f_1132_8611_8639(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 8670, 8682);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 8535, 8724);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 8752, 8774);

                                labelNodeFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 8800, 8825);

                                chd.label = f_1132_8812_8824(this, n);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 8851, 8984) || true) && (chd.label == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 8851, 8984);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 8930, 8942);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 8851, 8984);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 8432, 10677);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 8432, 10677);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 9034, 10677) || true) && (f_1132_9038_9073(this, n, XmlTags.WidthNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 9034, 10677);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 9123, 9312) || true) && (widthNodeFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 9123, 9312);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 9199, 9228);

                                        f_1132_9199_9227(this, n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 9258, 9270);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 9123, 9312);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 9340, 9362);

                                    widthNodeFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 9388, 9397);

                                    int
                                    wVal
                                    = default(int);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 9423, 9956) || true) && (f_1132_9427_9464(this, n, out wVal))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 9423, 9956);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 9522, 9539);

                                        chd.width = wVal;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 9423, 9956);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 9423, 9956);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 9736, 9872);

                                        f_1132_9736_9871(                            // Error at XPath {0} in file {1}: Invalid {2} value.
                                                                    this, f_1132_9753_9870(f_1132_9771_9817(), f_1132_9819_9840(this), f_1132_9842_9850(), XmlTags.WidthNode));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 9902, 9914);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 9423, 9956);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 9034, 10677);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 9034, 10677);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 10006, 10677) || true) && (f_1132_10010_10049(this, n, XmlTags.AlignmentNode))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 10006, 10677);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 10099, 10292) || true) && (alignmentNodeFound)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 10099, 10292);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 10179, 10208);

                                            f_1132_10179_10207(this, n);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 10238, 10250);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 10099, 10292);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 10320, 10346);

                                        alignmentNodeFound = true;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 10372, 10529) || true) && (!f_1132_10377_10417(this, n, out chd.alignment))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 10372, 10529);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 10475, 10487);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 10372, 10529);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 10006, 10677);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 10006, 10677);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 10627, 10654);

                                        f_1132_10627_10653(this, n);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 10006, 10677);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 9034, 10677);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 8432, 10677);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 8341, 10696);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1132, 1, 2356);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1132, 1, 2356);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 10716, 10727);

                    return chd;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1132, 7968, 10742);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1132, 7844, 10753);

                System.IDisposable
                f_1132_7975_8015(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 7975, 8015);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition
                f_1132_8083_8116()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 8083, 8116);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1132_8363_8390(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 8363, 8390);
                    return return_v;
                }


                bool
                f_1132_8436_8485(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeNameWithAttributes(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 8436, 8485);
                    return return_v;
                }


                int
                f_1132_8611_8639(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 8611, 8639);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1132_8812_8824(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                textNode)
                {
                    var return_v = this_param.LoadLabel(textNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 8812, 8824);
                    return return_v;
                }


                bool
                f_1132_9038_9073(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 9038, 9073);
                    return return_v;
                }


                int
                f_1132_9199_9227(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 9199, 9227);
                    return 0;
                }


                bool
                f_1132_9427_9464(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, out int
                val)
                {
                    var return_v = this_param.ReadPositiveIntegerValue(n, out val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 9427, 9464);
                    return return_v;
                }


                string
                f_1132_9771_9817()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.InvalidNodeValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 9771, 9817);
                    return return_v;
                }


                string
                f_1132_9819_9840(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 9819, 9840);
                    return return_v;
                }


                string
                f_1132_9842_9850()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 9842, 9850);
                    return return_v;
                }


                string
                f_1132_9753_9870(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 9753, 9870);
                    return return_v;
                }


                int
                f_1132_9736_9871(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 9736, 9871);
                    return 0;
                }


                bool
                f_1132_10010_10049(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 10010, 10049);
                    return return_v;
                }


                int
                f_1132_10179_10207(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 10179, 10207);
                    return 0;
                }


                bool
                f_1132_10377_10417(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, out int
                alignmentValue)
                {
                    var return_v = this_param.LoadAlignmentValue(n, out alignmentValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 10377, 10417);
                    return return_v;
                }


                int
                f_1132_10627_10653(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 10627, 10653);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1132_8363_8390_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 8363, 8390);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1132, 7844, 10753);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1132, 7844, 10753);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ReadPositiveIntegerValue(XmlNode n, out int val)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1132, 10765, 11399);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 10851, 10860);

                val = -1;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 10874, 10913);

                string
                text = f_1132_10888_10912(this, n)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 10927, 10975) || true) && (text == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 10927, 10975);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 10962, 10975);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 10927, 10975);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 10989, 11034);

                bool
                isInteger = f_1132_11006_11033(text, out val)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 11048, 11360) || true) && (!isInteger || (DynAbs.Tracing.TraceSender.Expression_False(1132, 11052, 11074) || val <= 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 11048, 11360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 11192, 11314);

                    f_1132_11192_11313(                // Error at XPath {0} in file {1}: A positive integer is expected.
                                    this, f_1132_11209_11312(f_1132_11227_11278(), f_1132_11280_11301(this), f_1132_11303_11311()));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 11332, 11345);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 11048, 11360);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 11376, 11388);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1132, 10765, 11399);

                string
                f_1132_10888_10912(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.GetMandatoryInnerText(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 10888, 10912);
                    return return_v;
                }


                bool
                f_1132_11006_11033(string
                s, out int
                result)
                {
                    var return_v = int.TryParse(s, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 11006, 11033);
                    return return_v;
                }


                string
                f_1132_11227_11278()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.ExpectPositiveInteger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 11227, 11278);
                    return return_v;
                }


                string
                f_1132_11280_11301(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 11280, 11301);
                    return return_v;
                }


                string
                f_1132_11303_11311()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 11303, 11311);
                    return return_v;
                }


                string
                f_1132_11209_11312(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 11209, 11312);
                    return return_v;
                }


                int
                f_1132_11192_11313(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 11192, 11313);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1132, 10765, 11399);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1132, 10765, 11399);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LoadAlignmentValue(XmlNode n, out int alignmentValue)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1132, 11411, 12712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 11502, 11543);

                alignmentValue = TextAlignment.Undefined;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 11557, 11607);

                string
                alignmentString = f_1132_11582_11606(this, n)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 11621, 11725) || true) && (alignmentString == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 11621, 11725);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 11682, 11695);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 11621, 11725);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 11741, 12673) || true) && (f_1132_11745_11838(f_1132_11759_11770(n), XMLStringValues.AlignmentLeft, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 11741, 12673);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 11872, 11908);

                    alignmentValue = TextAlignment.Left;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 11741, 12673);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 11741, 12673);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 11942, 12673) || true) && (f_1132_11946_12040(f_1132_11960_11971(n), XMLStringValues.AlignmentRight, StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 11942, 12673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 12074, 12111);

                        alignmentValue = TextAlignment.Right;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 11942, 12673);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 11942, 12673);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 12145, 12673) || true) && (f_1132_12149_12244(f_1132_12163_12174(n), XMLStringValues.AlignmentCenter, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 12145, 12673);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 12278, 12316);

                            alignmentValue = TextAlignment.Center;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 12145, 12673);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 12145, 12673);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 12473, 12612);

                            f_1132_12473_12611(                // Error at XPath {0} in file {1}: "{2}" is not an valid alignment value.
                                            this, f_1132_12490_12610(f_1132_12508_12559(), f_1132_12561_12582(this), f_1132_12584_12592(), alignmentString));
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 12630, 12643);

                            return false;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 12145, 12673);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 11942, 12673);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 11741, 12673);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 12689, 12701);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1132, 11411, 12712);

                string
                f_1132_11582_11606(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.GetMandatoryInnerText(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 11582, 11606);
                    return return_v;
                }


                string
                f_1132_11759_11770(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.InnerText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 11759, 11770);
                    return return_v;
                }


                bool
                f_1132_11745_11838(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 11745, 11838);
                    return return_v;
                }


                string
                f_1132_11960_11971(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.InnerText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 11960, 11971);
                    return return_v;
                }


                bool
                f_1132_11946_12040(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 11946, 12040);
                    return return_v;
                }


                string
                f_1132_12163_12174(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.InnerText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 12163, 12174);
                    return return_v;
                }


                bool
                f_1132_12149_12244(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 12149, 12244);
                    return return_v;
                }


                string
                f_1132_12508_12559()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.InvalidAlignmentValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 12508, 12559);
                    return return_v;
                }


                string
                f_1132_12561_12582(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 12561, 12582);
                    return return_v;
                }


                string
                f_1132_12584_12592()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 12584, 12592);
                    return return_v;
                }


                string
                f_1132_12490_12610(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 12490, 12610);
                    return return_v;
                }


                int
                f_1132_12473_12611(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 12473, 12611);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1132, 11411, 12712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1132, 11411, 12712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadRowEntriesSection(TableControlBody tableBody, XmlNode rowEntriesNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1132, 12724, 15296);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 12835, 15285);
                using (f_1132_12842_12873(this, rowEntriesNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 12907, 12929);

                    int
                    rowEntryIndex = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 12947, 14907);
                        foreach (XmlNode n in f_1132_12969_12994_I(f_1132_12969_12994(rowEntriesNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 12947, 14907);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 13036, 14888) || true) && (f_1132_13040_13083(this, n, XmlTags.TableRowEntryNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 13036, 14888);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 13133, 13201);

                                TableRowDefinition
                                trd = f_1132_13158_13200(this, n, rowEntryIndex++)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 13227, 13669) || true) && (trd == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 13227, 13669);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 13384, 13525);

                                    f_1132_13384_13524(                            // Error at XPath {0} in file {1}: {2} failed to load.
                                                                this, f_1132_13401_13523(f_1132_13419_13462(), f_1132_13464_13485(this), f_1132_13487_13495(), XmlTags.TableRowEntryNode));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 13555, 13590);

                                    tableBody.defaultDefinition = null;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 13620, 13627);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 13227, 13669);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 13786, 14740) || true) && (trd.appliesTo == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 13786, 14740);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 13869, 14557) || true) && (tableBody.defaultDefinition == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 13869, 14557);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 13974, 14008);

                                        tableBody.defaultDefinition = trd;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 13869, 14557);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 13869, 14557);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 14249, 14401);

                                        f_1132_14249_14400(                                // Error at XPath {0} in file {1}: There cannot be more than one default {2}.
                                                                        this, f_1132_14266_14399(f_1132_14284_14338(), f_1132_14340_14361(this), f_1132_14363_14371(), XmlTags.TableRowEntryNode));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 14435, 14470);

                                        tableBody.defaultDefinition = null;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 14504, 14511);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 13869, 14557);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 13786, 14740);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 13786, 14740);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 14671, 14713);

                                    f_1132_14671_14712(tableBody.optionalDefinitionList, trd);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 13786, 14740);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 13036, 14888);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 13036, 14888);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 14838, 14865);

                                f_1132_14838_14864(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 13036, 14888);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 12947, 14907);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1132, 1, 1961);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1132, 1, 1961);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 14927, 15270) || true) && (tableBody.defaultDefinition == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 14927, 15270);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 15104, 15251);

                        f_1132_15104_15250(                    // Error at XPath {0} in file {1}: There must be at least one default {2}.
                                            this, f_1132_15121_15249(f_1132_15139_15188(), f_1132_15190_15211(this), f_1132_15213_15221(), XmlTags.TableRowEntryNode));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 14927, 15270);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1132, 12835, 15285);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1132, 12724, 15296);

                System.IDisposable
                f_1132_12842_12873(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 12842, 12873);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1132_12969_12994(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 12969, 12994);
                    return return_v;
                }


                bool
                f_1132_13040_13083(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 13040, 13083);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition
                f_1132_13158_13200(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                rowEntryNode, int
                index)
                {
                    var return_v = this_param.LoadRowEntryDefinition(rowEntryNode, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 13158, 13200);
                    return return_v;
                }


                string
                f_1132_13419_13462()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.LoadTagFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 13419, 13462);
                    return return_v;
                }


                string
                f_1132_13464_13485(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 13464, 13485);
                    return return_v;
                }


                string
                f_1132_13487_13495()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 13487, 13495);
                    return return_v;
                }


                string
                f_1132_13401_13523(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 13401, 13523);
                    return return_v;
                }


                int
                f_1132_13384_13524(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 13384, 13524);
                    return 0;
                }


                string
                f_1132_14284_14338()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.TooManyDefaultShapeEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 14284, 14338);
                    return return_v;
                }


                string
                f_1132_14340_14361(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 14340, 14361);
                    return return_v;
                }


                string
                f_1132_14363_14371()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 14363, 14371);
                    return return_v;
                }


                string
                f_1132_14266_14399(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 14266, 14399);
                    return return_v;
                }


                int
                f_1132_14249_14400(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 14249, 14400);
                    return 0;
                }


                int
                f_1132_14671_14712(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 14671, 14712);
                    return 0;
                }


                int
                f_1132_14838_14864(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 14838, 14864);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1132_12969_12994_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 12969, 12994);
                    return return_v;
                }


                string
                f_1132_15139_15188()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.NoDefaultShapeEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 15139, 15188);
                    return return_v;
                }


                string
                f_1132_15190_15211(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 15190, 15211);
                    return return_v;
                }


                string
                f_1132_15213_15221()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 15213, 15221);
                    return return_v;
                }


                string
                f_1132_15121_15249(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 15121, 15249);
                    return return_v;
                }


                int
                f_1132_15104_15250(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 15104, 15250);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1132, 12724, 15296);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1132, 12724, 15296);
            }
        }

        private TableRowDefinition LoadRowEntryDefinition(XmlNode rowEntryNode, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1132, 15308, 17690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 15415, 17679);
                using (f_1132_15422_15458(this, rowEntryNode, index))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 15492, 15524);

                    bool
                    appliesToNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 15565, 15601);

                    bool
                    columnEntriesNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 15644, 15672);

                    bool
                    multiLineFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 15715, 15765);

                    TableRowDefinition
                    trd = f_1132_15740_15764()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 15783, 17633);
                        foreach (XmlNode n in f_1132_15805_15828_I(f_1132_15805_15828(rowEntryNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 15783, 17633);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 15870, 17614) || true) && (f_1132_15874_15919(this, n, XmlTags.EntrySelectedByNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 15870, 17614);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 15969, 16162) || true) && (appliesToNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 15969, 16162);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 16049, 16078);

                                    f_1132_16049_16077(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 16108, 16120);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 15969, 16162);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 16190, 16216);

                                appliesToNodeFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 16289, 16335);

                                trd.appliesTo = f_1132_16305_16334(this, n, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 15870, 17614);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 15870, 17614);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 16385, 17614) || true) && (f_1132_16389_16435(this, n, XmlTags.TableColumnItemsNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 16385, 17614);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 16485, 16676) || true) && (columnEntriesNodeFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 16485, 16676);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 16569, 16598);

                                        f_1132_16569_16597(this, n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 16628, 16640);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 16485, 16676);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 16704, 16730);

                                    f_1132_16704_16729(this, n, trd);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 16756, 16905) || true) && (trd.rowItemDefinitionList == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 16756, 16905);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 16851, 16863);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 16756, 16905);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 16385, 17614);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 16385, 17614);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 16955, 17614) || true) && (f_1132_16959_16998(this, n, XmlTags.MultiLineNode))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 16955, 17614);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 17048, 17231) || true) && (multiLineFound)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 17048, 17231);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 17124, 17153);

                                            f_1132_17124_17152(this, n);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 17183, 17195);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 17048, 17231);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 17259, 17281);

                                        multiLineFound = true;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 17307, 17466) || true) && (!f_1132_17312_17354(this, n, out trd.multiLine))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 17307, 17466);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 17412, 17424);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 17307, 17466);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 16955, 17614);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 16955, 17614);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 17564, 17591);

                                        f_1132_17564_17590(this, n);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 16955, 17614);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 16385, 17614);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 15870, 17614);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 15783, 17633);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1132, 1, 1851);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1132, 1, 1851);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 17653, 17664);

                    return trd;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1132, 15415, 17679);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1132, 15308, 17690);

                System.IDisposable
                f_1132_15422_15458(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 15422, 15458);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition
                f_1132_15740_15764()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 15740, 15764);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1132_15805_15828(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 15805, 15828);
                    return return_v;
                }


                bool
                f_1132_15874_15919(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 15874, 15919);
                    return return_v;
                }


                int
                f_1132_16049_16077(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 16049, 16077);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1132_16305_16334(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                appliesToNode, bool
                allowSelectionCondition)
                {
                    var return_v = this_param.LoadAppliesToSection(appliesToNode, allowSelectionCondition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 16305, 16334);
                    return return_v;
                }


                bool
                f_1132_16389_16435(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 16389, 16435);
                    return return_v;
                }


                int
                f_1132_16569_16597(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 16569, 16597);
                    return 0;
                }


                int
                f_1132_16704_16729(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                columnEntriesNode, Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition
                trd)
                {
                    this_param.LoadColumnEntries(columnEntriesNode, trd);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 16704, 16729);
                    return 0;
                }


                bool
                f_1132_16959_16998(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 16959, 16998);
                    return return_v;
                }


                int
                f_1132_17124_17152(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 17124, 17152);
                    return 0;
                }


                bool
                f_1132_17312_17354(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                collectionElement, out bool
                val)
                {
                    var return_v = this_param.ReadBooleanNode(collectionElement, out val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 17312, 17354);
                    return return_v;
                }


                int
                f_1132_17564_17590(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 17564, 17590);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1132_15805_15828_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 15805, 15828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1132, 15308, 17690);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1132, 15308, 17690);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadColumnEntries(XmlNode columnEntriesNode, TableRowDefinition trd)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1132, 17702, 18874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 17808, 18863);
                using (f_1132_17815_17849(this, columnEntriesNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 17883, 17908);

                    int
                    columnEntryIndex = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 17926, 18848);
                        foreach (XmlNode n in f_1132_17948_17976_I(f_1132_17948_17976(columnEntriesNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 17926, 18848);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 18018, 18829) || true) && (f_1132_18022_18067(this, n, XmlTags.TableColumnItemNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 18018, 18829);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 18117, 18185);

                                TableRowItemDefinition
                                rid = f_1132_18146_18184(this, n, columnEntryIndex++)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 18211, 18681) || true) && (rid != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 18211, 18681);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 18284, 18319);

                                    f_1132_18284_18318(trd.rowItemDefinitionList, rid);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 18211, 18681);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 18211, 18681);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 18569, 18602);

                                    trd.rowItemDefinitionList = null;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 18632, 18639);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 18211, 18681);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 18018, 18829);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 18018, 18829);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 18779, 18806);

                                f_1132_18779_18805(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 18018, 18829);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 17926, 18848);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1132, 1, 923);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1132, 1, 923);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1132, 17808, 18863);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1132, 17702, 18874);

                System.IDisposable
                f_1132_17815_17849(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 17815, 17849);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1132_17948_17976(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 17948, 17976);
                    return return_v;
                }


                bool
                f_1132_18022_18067(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 18022, 18067);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition
                f_1132_18146_18184(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                columnEntryNode, int
                index)
                {
                    var return_v = this_param.LoadColumnEntry(columnEntryNode, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 18146, 18184);
                    return return_v;
                }


                int
                f_1132_18284_18318(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 18284, 18318);
                    return 0;
                }


                int
                f_1132_18779_18805(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 18779, 18805);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1132_17948_17976_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 17948, 17976);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1132, 17702, 18874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1132, 17702, 18874);
            }
        }

        private TableRowItemDefinition LoadColumnEntry(XmlNode columnEntryNode, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1132, 18886, 21152);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 18993, 21141);
                using (f_1132_19000_19039(this, columnEntryNode, index))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 19145, 19201);

                    ViewEntryNodeMatch
                    match = f_1132_19172_19200(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 19219, 19272);

                    List<XmlNode>
                    unprocessedNodes = f_1132_19252_19271()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 19290, 19451) || true) && (!f_1132_19295_19363(match, columnEntryNode, unprocessedNodes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 19290, 19451);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 19405, 19417);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 19290, 19451);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 19471, 19529);

                    TableRowItemDefinition
                    rid = f_1132_19500_19528()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 19597, 19629);

                    bool
                    alignmentNodeFound = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 19667, 20437);
                        foreach (XmlNode n in f_1132_19689_19705_I(unprocessedNodes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 19667, 20437);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 19747, 20418) || true) && (f_1132_19751_19790(this, n, XmlTags.AlignmentNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 19747, 20418);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 19840, 20033) || true) && (alignmentNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 19840, 20033);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 19920, 19949);

                                    f_1132_19920_19948(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 19979, 19991);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 19840, 20033);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 20061, 20087);

                                alignmentNodeFound = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 20113, 20270) || true) && (!f_1132_20118_20158(this, n, out rid.alignment))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 20113, 20270);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 20216, 20228);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 20113, 20270);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 19747, 20418);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 19747, 20418);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 20368, 20395);

                                f_1132_20368_20394(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 19747, 20418);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 19667, 20437);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1132, 1, 771);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1132, 1, 771);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 20612, 21095) || true) && (f_1132_20616_20631(match) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 20612, 21095);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 20681, 20722);

                        f_1132_20681_20721(rid.formatTokenList, f_1132_20705_20720(match));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 20612, 21095);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 20612, 21095);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 20764, 21095) || true) && (f_1132_20768_20784(match) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1132, 20764, 21095);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 20834, 20884);

                            FieldPropertyToken
                            fpt = f_1132_20859_20883()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 20906, 20940);

                            fpt.expression = f_1132_20923_20939(match);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 20962, 21025);

                            fpt.fieldFormattingDirective.formatString = f_1132_21006_21024(match);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 21047, 21076);

                            f_1132_21047_21075(rid.formatTokenList, fpt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 20764, 21095);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1132, 20612, 21095);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1132, 21115, 21126);

                    return rid;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1132, 18993, 21141);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1132, 18886, 21152);

                System.IDisposable
                f_1132_19000_19039(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 19000, 19039);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                f_1132_19172_19200(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                loader)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch(loader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 19172, 19200);
                    return return_v;
                }


                System.Collections.Generic.List<System.Xml.XmlNode>
                f_1132_19252_19271()
                {
                    var return_v = new System.Collections.Generic.List<System.Xml.XmlNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 19252, 19271);
                    return return_v;
                }


                bool
                f_1132_19295_19363(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param, System.Xml.XmlNode
                containerNode, System.Collections.Generic.List<System.Xml.XmlNode>
                unprocessedNodes)
                {
                    var return_v = this_param.ProcessExpressionDirectives(containerNode, unprocessedNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 19295, 19363);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition
                f_1132_19500_19528()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 19500, 19528);
                    return return_v;
                }


                bool
                f_1132_19751_19790(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 19751, 19790);
                    return return_v;
                }


                int
                f_1132_19920_19948(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 19920, 19948);
                    return 0;
                }


                bool
                f_1132_20118_20158(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, out int
                alignmentValue)
                {
                    var return_v = this_param.LoadAlignmentValue(n, out alignmentValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 20118, 20158);
                    return return_v;
                }


                int
                f_1132_20368_20394(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 20368, 20394);
                    return 0;
                }


                System.Collections.Generic.List<System.Xml.XmlNode>
                f_1132_19689_19705_I(System.Collections.Generic.List<System.Xml.XmlNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 19689, 19705);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1132_20616_20631(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param)
                {
                    var return_v = this_param.TextToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 20616, 20631);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1132_20705_20720(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param)
                {
                    var return_v = this_param.TextToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 20705, 20720);
                    return return_v;
                }


                int
                f_1132_20681_20721(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TextToken
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 20681, 20721);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1132_20768_20784(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 20768, 20784);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                f_1132_20859_20883()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 20859, 20883);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1132_20923_20939(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 20923, 20939);
                    return return_v;
                }


                string
                f_1132_21006_21024(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1132, 21006, 21024);
                    return return_v;
                }


                int
                f_1132_21047_21075(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1132, 21047, 21075);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1132, 18886, 21152);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1132, 18886, 21152);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
