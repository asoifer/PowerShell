// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation.Internal;
using System.Xml;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed partial class TypeInfoDataBaseLoader : XmlLoaderBase
    {
        private WideControlBody LoadWideControl(XmlNode controlNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1134, 508, 3815);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 593, 3804);
                using (f_1134_600_628(this, controlNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 662, 711);

                    WideControlBody
                    wideBody = f_1134_689_710()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 731, 765);

                    bool
                    wideViewEntriesFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 824, 855);

                    bool
                    autosizeNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 895, 925);

                    bool
                    columnsNodeFound = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 965, 3296);
                        foreach (XmlNode n in f_1134_987_1009_I(f_1134_987_1009(controlNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 965, 3296);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 1051, 3277) || true) && (f_1134_1055_1093(this, n, XmlTags.AutoSizeNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 1051, 3277);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 1143, 1392) || true) && (autosizeNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 1143, 1392);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 1222, 1308);

                                    f_1134_1222_1307(this, n, XmlTags.AutoSizeNode, XmlTags.ColumnNumberNode);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 1338, 1350);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 1143, 1392);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 1420, 1445);

                                autosizeNodeFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 1471, 1484);

                                bool
                                tempVal
                                = default(bool);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 1510, 1663) || true) && (!f_1134_1515_1551(this, n, out tempVal))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 1510, 1663);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 1609, 1621);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 1510, 1663);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 1691, 1719);

                                wideBody.autosize = tempVal;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 1051, 3277);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 1051, 3277);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 1769, 3277) || true) && (f_1134_1773_1815(this, n, XmlTags.ColumnNumberNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 1769, 3277);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 1865, 2113) || true) && (columnsNodeFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 1865, 2113);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 1943, 2029);

                                        f_1134_1943_2028(this, n, XmlTags.AutoSizeNode, XmlTags.ColumnNumberNode);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 2059, 2071);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 1865, 2113);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 2141, 2165);

                                    columnsNodeFound = true;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 2193, 2359) || true) && (!f_1134_2198_2247(this, n, out wideBody.columns))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 2193, 2359);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 2305, 2317);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 2193, 2359);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 1769, 3277);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 1769, 3277);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 2409, 3277) || true) && (f_1134_2413_2454(this, n, XmlTags.WideEntriesNode))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 2409, 3277);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 2504, 2681) || true) && (wideViewEntriesFound)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 2504, 2681);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 2586, 2615);

                                            f_1134_2586_2614(this, n);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 2645, 2654);

                                            continue;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 2504, 2681);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 2709, 2737);

                                        wideViewEntriesFound = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 2822, 2858);

                                        f_1134_2822_2857(this, n, wideBody);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 2884, 3129) || true) && (wideBody.defaultEntryDefinition == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 2884, 3129);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 3075, 3087);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 2884, 3129);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 2409, 3277);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 2409, 3277);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 3227, 3254);

                                        f_1134_3227_3253(this, n);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 2409, 3277);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 1769, 3277);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 1051, 3277);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 965, 3296);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1134, 1, 2332);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1134, 1, 2332);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 3316, 3550) || true) && (autosizeNodeFound && (DynAbs.Tracing.TraceSender.Expression_True(1134, 3320, 3357) && columnsNodeFound))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 3316, 3550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 3399, 3482);

                        f_1134_3399_3481(this, XmlTags.AutoSizeNode, XmlTags.ColumnNumberNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 3504, 3516);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 3316, 3550);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 3570, 3753) || true) && (!wideViewEntriesFound)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 3570, 3753);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 3637, 3685);

                        f_1134_3637_3684(this, XmlTags.WideEntriesNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 3707, 3719);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 3570, 3753);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 3773, 3789);

                    return wideBody;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1134, 593, 3804);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1134, 508, 3815);

                System.IDisposable
                f_1134_600_628(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 600, 628);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.WideControlBody
                f_1134_689_710()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.WideControlBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 689, 710);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1134_987_1009(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 987, 1009);
                    return return_v;
                }


                bool
                f_1134_1055_1093(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 1055, 1093);
                    return return_v;
                }


                int
                f_1134_1222_1307(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                node1, string
                node2)
                {
                    this_param.ProcessDuplicateAlternateNode(n, node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 1222, 1307);
                    return 0;
                }


                bool
                f_1134_1515_1551(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                collectionElement, out bool
                val)
                {
                    var return_v = this_param.ReadBooleanNode(collectionElement, out val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 1515, 1551);
                    return return_v;
                }


                bool
                f_1134_1773_1815(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 1773, 1815);
                    return return_v;
                }


                int
                f_1134_1943_2028(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                node1, string
                node2)
                {
                    this_param.ProcessDuplicateAlternateNode(n, node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 1943, 2028);
                    return 0;
                }


                bool
                f_1134_2198_2247(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, out int
                val)
                {
                    var return_v = this_param.ReadPositiveIntegerValue(n, out val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 2198, 2247);
                    return return_v;
                }


                bool
                f_1134_2413_2454(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 2413, 2454);
                    return return_v;
                }


                int
                f_1134_2586_2614(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 2586, 2614);
                    return 0;
                }


                int
                f_1134_2822_2857(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                wideControlEntriesNode, Microsoft.PowerShell.Commands.Internal.Format.WideControlBody
                wideBody)
                {
                    this_param.LoadWideControlEntries(wideControlEntriesNode, wideBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 2822, 2857);
                    return 0;
                }


                int
                f_1134_3227_3253(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 3227, 3253);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1134_987_1009_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 987, 1009);
                    return return_v;
                }


                int
                f_1134_3399_3481(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                node1, string
                node2)
                {
                    this_param.ProcessDuplicateAlternateNode(node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 3399, 3481);
                    return 0;
                }


                int
                f_1134_3637_3684(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                name)
                {
                    this_param.ReportMissingNode(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 3637, 3684);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1134, 508, 3815);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1134, 508, 3815);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadWideControlEntries(XmlNode wideControlEntriesNode, WideControlBody wideBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1134, 3827, 6332);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 3945, 6321);
                using (f_1134_3952_3991(this, wideControlEntriesNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 4025, 4044);

                    int
                    entryIndex = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 4064, 5943);
                        foreach (XmlNode n in f_1134_4086_4119_I(f_1134_4086_4119(wideControlEntriesNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 4064, 5943);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 4161, 5924) || true) && (f_1134_4165_4204(this, n, XmlTags.WideEntryNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 4161, 5924);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 4254, 4326);

                                WideControlEntryDefinition
                                wved = f_1134_4288_4325(this, n, entryIndex++)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 4352, 4702) || true) && (wved == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 4352, 4702);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 4503, 4638);

                                    f_1134_4503_4637(                            // Error at XPath {0} in file {1}: Invalid {2}.
                                                                this, f_1134_4520_4636(f_1134_4538_4579(), f_1134_4581_4602(this), f_1134_4604_4612(), XmlTags.WideEntryNode));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 4668, 4675);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 4352, 4702);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 4817, 5776) || true) && (wved.appliesTo == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 4817, 5776);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 4901, 5598) || true) && (wideBody.defaultEntryDefinition == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 4901, 5598);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 5010, 5049);

                                        wideBody.defaultEntryDefinition = wved;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 4901, 5598);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 4901, 5598);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 5290, 5438);

                                        f_1134_5290_5437(                                // Error at XPath {0} in file {1}: There cannot be more than one default {2}.
                                                                        this, f_1134_5307_5436(f_1134_5325_5379(), f_1134_5381_5402(this), f_1134_5404_5412(), XmlTags.WideEntryNode));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 5472, 5511);

                                        wideBody.defaultEntryDefinition = null;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 5545, 5552);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 4901, 5598);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 4817, 5776);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 4817, 5776);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 5712, 5749);

                                    f_1134_5712_5748(wideBody.optionalEntryList, wved);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 4817, 5776);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 4161, 5924);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 4161, 5924);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 5874, 5901);

                                f_1134_5874_5900(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 4161, 5924);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 4064, 5943);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1134, 1, 1880);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1134, 1, 1880);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 5963, 6306) || true) && (wideBody.defaultEntryDefinition == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 5963, 6306);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 6144, 6287);

                        f_1134_6144_6286(                    // Error at XPath {0} in file {1}: There must be at least one default {2}.
                                            this, f_1134_6161_6285(f_1134_6179_6228(), f_1134_6230_6251(this), f_1134_6253_6261(), XmlTags.WideEntryNode));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 5963, 6306);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1134, 3945, 6321);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1134, 3827, 6332);

                System.IDisposable
                f_1134_3952_3991(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 3952, 3991);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1134_4086_4119(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 4086, 4119);
                    return return_v;
                }


                bool
                f_1134_4165_4204(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 4165, 4204);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition
                f_1134_4288_4325(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                wideControlEntryNode, int
                index)
                {
                    var return_v = this_param.LoadWideControlEntry(wideControlEntryNode, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 4288, 4325);
                    return return_v;
                }


                string
                f_1134_4538_4579()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.InvalidNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 4538, 4579);
                    return return_v;
                }


                string
                f_1134_4581_4602(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 4581, 4602);
                    return return_v;
                }


                string
                f_1134_4604_4612()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 4604, 4612);
                    return return_v;
                }


                string
                f_1134_4520_4636(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 4520, 4636);
                    return return_v;
                }


                int
                f_1134_4503_4637(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 4503, 4637);
                    return 0;
                }


                string
                f_1134_5325_5379()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.TooManyDefaultShapeEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 5325, 5379);
                    return return_v;
                }


                string
                f_1134_5381_5402(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 5381, 5402);
                    return return_v;
                }


                string
                f_1134_5404_5412()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 5404, 5412);
                    return return_v;
                }


                string
                f_1134_5307_5436(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 5307, 5436);
                    return return_v;
                }


                int
                f_1134_5290_5437(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 5290, 5437);
                    return 0;
                }


                int
                f_1134_5712_5748(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 5712, 5748);
                    return 0;
                }


                int
                f_1134_5874_5900(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 5874, 5900);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1134_4086_4119_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 4086, 4119);
                    return return_v;
                }


                string
                f_1134_6179_6228()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.NoDefaultShapeEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 6179, 6228);
                    return return_v;
                }


                string
                f_1134_6230_6251(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 6230, 6251);
                    return return_v;
                }


                string
                f_1134_6253_6261()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 6253, 6261);
                    return return_v;
                }


                string
                f_1134_6161_6285(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 6161, 6285);
                    return return_v;
                }


                int
                f_1134_6144_6286(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 6144, 6286);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1134, 3827, 6332);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1134, 3827, 6332);
            }
        }

        private WideControlEntryDefinition LoadWideControlEntry(XmlNode wideControlEntryNode, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1134, 6344, 8662);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 6465, 8651);
                using (f_1134_6472_6516(this, wideControlEntryNode, index))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 6550, 6582);

                    bool
                    appliesToNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 6624, 6660);

                    bool
                    propertyEntryNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 6697, 6764);

                    WideControlEntryDefinition
                    wved = f_1134_6731_6763()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 6784, 8320);
                        foreach (XmlNode n in f_1134_6806_6837_I(f_1134_6806_6837(wideControlEntryNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 6784, 8320);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 6879, 8301) || true) && (f_1134_6883_6928(this, n, XmlTags.EntrySelectedByNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 6879, 8301);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 6978, 7165) || true) && (appliesToNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 6978, 7165);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 7058, 7087);

                                    f_1134_7058_7086(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 7117, 7129);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 6978, 7165);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 7193, 7219);

                                appliesToNodeFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 7245, 7292);

                                wved.appliesTo = f_1134_7262_7291(this, n, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 6879, 8301);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 6879, 8301);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 7342, 8301) || true) && (f_1134_7346_7384(this, n, XmlTags.WideItemNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 7342, 8301);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 7434, 7625) || true) && (propertyEntryNodeFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 7434, 7625);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 7518, 7547);

                                        f_1134_7518_7546(this, n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 7577, 7589);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 7434, 7625);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 7653, 7683);

                                    propertyEntryNodeFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 7709, 7753);

                                    wved.formatTokenList = f_1134_7732_7752(this, n);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 7779, 8158) || true) && (wved.formatTokenList == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 7779, 8158);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 7946, 8080);

                                        f_1134_7946_8079(                            // Error at XPath {0} in file {1}: Invalid {2}.
                                                                    this, f_1134_7963_8078(f_1134_7981_8022(), f_1134_8024_8045(this), f_1134_8047_8055(), XmlTags.WideItemNode));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 8110, 8122);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 7779, 8158);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 7342, 8301);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 7342, 8301);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 8256, 8278);

                                    f_1134_8256_8277(this, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 7342, 8301);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 6879, 8301);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 6784, 8320);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1134, 1, 1537);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1134, 1, 1537);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 8340, 8604) || true) && (f_1134_8344_8370(wved.formatTokenList) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 8340, 8604);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 8491, 8536);

                        f_1134_8491_8535(                    // Error at XPath {0} in file {1}: Missing WideItem.
                                            this, XmlTags.WideItemNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 8558, 8570);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 8340, 8604);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 8624, 8636);

                    return wved;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1134, 6465, 8651);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1134, 6344, 8662);

                System.IDisposable
                f_1134_6472_6516(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 6472, 6516);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition
                f_1134_6731_6763()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 6731, 6763);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1134_6806_6837(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 6806, 6837);
                    return return_v;
                }


                bool
                f_1134_6883_6928(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 6883, 6928);
                    return return_v;
                }


                int
                f_1134_7058_7086(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 7058, 7086);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1134_7262_7291(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                appliesToNode, bool
                allowSelectionCondition)
                {
                    var return_v = this_param.LoadAppliesToSection(appliesToNode, allowSelectionCondition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 7262, 7291);
                    return return_v;
                }


                bool
                f_1134_7346_7384(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 7346, 7384);
                    return return_v;
                }


                int
                f_1134_7518_7546(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 7518, 7546);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                f_1134_7732_7752(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                propertyEntryNode)
                {
                    var return_v = this_param.LoadPropertyEntry(propertyEntryNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 7732, 7752);
                    return return_v;
                }


                string
                f_1134_7981_8022()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.InvalidNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 7981, 8022);
                    return return_v;
                }


                string
                f_1134_8024_8045(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 8024, 8045);
                    return return_v;
                }


                string
                f_1134_8047_8055()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 8047, 8055);
                    return return_v;
                }


                string
                f_1134_7963_8078(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 7963, 8078);
                    return return_v;
                }


                int
                f_1134_7946_8079(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 7946, 8079);
                    return 0;
                }


                int
                f_1134_8256_8277(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 8256, 8277);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1134_6806_6837_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 6806, 6837);
                    return return_v;
                }


                int
                f_1134_8344_8370(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 8344, 8370);
                    return return_v;
                }


                int
                f_1134_8491_8535(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                name)
                {
                    this_param.ReportMissingNode(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 8491, 8535);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1134, 6344, 8662);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1134, 6344, 8662);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<FormatToken> LoadPropertyEntry(XmlNode propertyEntryNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1134, 8674, 10189);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 8769, 10178);
                using (f_1134_8776_8810(this, propertyEntryNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 8916, 8972);

                    ViewEntryNodeMatch
                    match = f_1134_8943_8971(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 8990, 9043);

                    List<XmlNode>
                    unprocessedNodes = f_1134_9023_9042()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 9061, 9224) || true) && (!f_1134_9066_9136(match, propertyEntryNode, unprocessedNodes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 9061, 9224);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 9178, 9190);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 9061, 9224);
                    }
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 9294, 9420);
                        foreach (XmlNode n in f_1134_9316_9332_I(unprocessedNodes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 9294, 9420);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 9374, 9401);

                            f_1134_9374_9400(this, n);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 9294, 9420);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1134, 1, 127);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1134, 1, 127);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 9493, 9553);

                    List<FormatToken>
                    formatTokenList = f_1134_9529_9552()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 9675, 10120) || true) && (f_1134_9679_9694(match) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 9675, 10120);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 9744, 9781);

                        f_1134_9744_9780(formatTokenList, f_1134_9764_9779(match));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 9675, 10120);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1134, 9675, 10120);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 9863, 9913);

                        FieldPropertyToken
                        fpt = f_1134_9888_9912()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 9935, 9969);

                        fpt.expression = f_1134_9952_9968(match);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 9991, 10054);

                        fpt.fieldFormattingDirective.formatString = f_1134_10035_10053(match);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 10076, 10101);

                        f_1134_10076_10100(formatTokenList, fpt);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1134, 9675, 10120);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1134, 10140, 10163);

                    return formatTokenList;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1134, 8769, 10178);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1134, 8674, 10189);

                System.IDisposable
                f_1134_8776_8810(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 8776, 8810);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                f_1134_8943_8971(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                loader)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch(loader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 8943, 8971);
                    return return_v;
                }


                System.Collections.Generic.List<System.Xml.XmlNode>
                f_1134_9023_9042()
                {
                    var return_v = new System.Collections.Generic.List<System.Xml.XmlNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 9023, 9042);
                    return return_v;
                }


                bool
                f_1134_9066_9136(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param, System.Xml.XmlNode
                containerNode, System.Collections.Generic.List<System.Xml.XmlNode>
                unprocessedNodes)
                {
                    var return_v = this_param.ProcessExpressionDirectives(containerNode, unprocessedNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 9066, 9136);
                    return return_v;
                }


                int
                f_1134_9374_9400(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 9374, 9400);
                    return 0;
                }


                System.Collections.Generic.List<System.Xml.XmlNode>
                f_1134_9316_9332_I(System.Collections.Generic.List<System.Xml.XmlNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 9316, 9332);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                f_1134_9529_9552()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 9529, 9552);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1134_9679_9694(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param)
                {
                    var return_v = this_param.TextToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 9679, 9694);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1134_9764_9779(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param)
                {
                    var return_v = this_param.TextToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 9764, 9779);
                    return return_v;
                }


                int
                f_1134_9744_9780(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TextToken
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 9744, 9780);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                f_1134_9888_9912()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 9888, 9912);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1134_9952_9968(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 9952, 9968);
                    return return_v;
                }


                string
                f_1134_10035_10053(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1134, 10035, 10053);
                    return return_v;
                }


                int
                f_1134_10076_10100(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1134, 10076, 10100);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1134, 8674, 10189);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1134, 8674, 10189);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
