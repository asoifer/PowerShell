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
        private ComplexControlBody LoadComplexControl(XmlNode controlNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1130, 523, 1939);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 614, 1928);
                using (f_1130_621_649(this, controlNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 683, 741);

                    ComplexControlBody
                    complexBody = f_1130_716_740()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 761, 787);

                    bool
                    entriesFound = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 807, 1676);
                        foreach (XmlNode n in f_1130_829_851_I(f_1130_829_851(controlNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 807, 1676);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 893, 1657) || true) && (f_1130_897_941(this, n, XmlTags.ComplexEntriesNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 893, 1657);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 991, 1160) || true) && (entriesFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 991, 1160);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 1065, 1094);

                                    f_1130_1065_1093(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 1124, 1133);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 991, 1160);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 1188, 1208);

                                entriesFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 1293, 1335);

                                f_1130_1293_1334(this, n, complexBody);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 1361, 1509) || true) && (complexBody.defaultEntry == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 1361, 1509);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 1455, 1467);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 1361, 1509);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 893, 1657);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 893, 1657);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 1607, 1634);

                                f_1130_1607_1633(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 893, 1657);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 807, 1676);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1130, 1, 870);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1130, 1, 870);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 1696, 1874) || true) && (!entriesFound)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 1696, 1874);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 1755, 1806);

                        f_1130_1755_1805(this, XmlTags.ComplexEntriesNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 1828, 1840);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 1696, 1874);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 1894, 1913);

                    return complexBody;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1130, 614, 1928);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1130, 523, 1939);

                System.IDisposable
                f_1130_621_649(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 621, 649);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                f_1130_716_740()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 716, 740);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1130_829_851(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 829, 851);
                    return return_v;
                }


                bool
                f_1130_897_941(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 897, 941);
                    return return_v;
                }


                int
                f_1130_1065_1093(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 1065, 1093);
                    return 0;
                }


                int
                f_1130_1293_1334(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                complexControlEntriesNode, Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                complexBody)
                {
                    this_param.LoadComplexControlEntries(complexControlEntriesNode, complexBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 1293, 1334);
                    return 0;
                }


                int
                f_1130_1607_1633(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 1607, 1633);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1130_829_851_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 829, 851);
                    return return_v;
                }


                int
                f_1130_1755_1805(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                name)
                {
                    this_param.ReportMissingNode(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 1755, 1805);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1130, 523, 1939);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1130, 523, 1939);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadComplexControlEntries(XmlNode complexControlEntriesNode, ComplexControlBody complexBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1130, 1951, 4563);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 2081, 4552);
                using (f_1130_2088_2130(this, complexControlEntriesNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 2164, 2183);

                    int
                    entryIndex = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 2203, 4178);
                        foreach (XmlNode n in f_1130_2225_2261_I(f_1130_2225_2261(complexControlEntriesNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 2203, 4178);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 2303, 4159) || true) && (f_1130_2307_2349(this, n, XmlTags.ComplexEntryNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 2303, 4159);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 2399, 2487);

                                ComplexControlEntryDefinition
                                cced = f_1130_2436_2486(this, n, entryIndex++)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 2513, 2952) || true) && (cced == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 2513, 2952);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 2671, 2811);

                                    f_1130_2671_2810(                            // Error at XPath {0} in file {1}: {2} failed to load.
                                                                this, f_1130_2688_2809(f_1130_2706_2749(), f_1130_2751_2772(this), f_1130_2774_2782(), XmlTags.ComplexEntryNode));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 2841, 2873);

                                    complexBody.defaultEntry = null;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 2903, 2910);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 2513, 2952);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 3067, 4011) || true) && (cced.appliesTo == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 3067, 4011);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 3151, 3830) || true) && (complexBody.defaultEntry == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 3151, 3830);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 3253, 3285);

                                        complexBody.defaultEntry = cced;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 3151, 3830);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 3151, 3830);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 3526, 3677);

                                        f_1130_3526_3676(                                // Error at XPath {0} in file {1}: There cannot be more than one default {2}.
                                                                        this, f_1130_3543_3675(f_1130_3561_3615(), f_1130_3617_3638(this), f_1130_3640_3648(), XmlTags.ComplexEntryNode));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 3711, 3743);

                                        complexBody.defaultEntry = null;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 3777, 3784);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 3151, 3830);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 3067, 4011);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 3067, 4011);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 3944, 3984);

                                    f_1130_3944_3983(complexBody.optionalEntryList, cced);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 3067, 4011);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 2303, 4159);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 2303, 4159);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 4109, 4136);

                                f_1130_4109_4135(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 2303, 4159);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 2203, 4178);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1130, 1, 1976);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1130, 1, 1976);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 4198, 4537) || true) && (complexBody.defaultEntry == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 4198, 4537);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 4372, 4518);

                        f_1130_4372_4517(                    // Error at XPath {0} in file {1}: There must be at least one default {2}.
                                            this, f_1130_4389_4516(f_1130_4407_4456(), f_1130_4458_4479(this), f_1130_4481_4489(), XmlTags.ComplexEntryNode));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 4198, 4537);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1130, 2081, 4552);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1130, 1951, 4563);

                System.IDisposable
                f_1130_2088_2130(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 2088, 2130);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1130_2225_2261(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 2225, 2261);
                    return return_v;
                }


                bool
                f_1130_2307_2349(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 2307, 2349);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition
                f_1130_2436_2486(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                complexControlEntryNode, int
                index)
                {
                    var return_v = this_param.LoadComplexControlEntryDefinition(complexControlEntryNode, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 2436, 2486);
                    return return_v;
                }


                string
                f_1130_2706_2749()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.LoadTagFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 2706, 2749);
                    return return_v;
                }


                string
                f_1130_2751_2772(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 2751, 2772);
                    return return_v;
                }


                string
                f_1130_2774_2782()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 2774, 2782);
                    return return_v;
                }


                string
                f_1130_2688_2809(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 2688, 2809);
                    return return_v;
                }


                int
                f_1130_2671_2810(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 2671, 2810);
                    return 0;
                }


                string
                f_1130_3561_3615()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.TooManyDefaultShapeEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 3561, 3615);
                    return return_v;
                }


                string
                f_1130_3617_3638(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 3617, 3638);
                    return return_v;
                }


                string
                f_1130_3640_3648()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 3640, 3648);
                    return return_v;
                }


                string
                f_1130_3543_3675(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 3543, 3675);
                    return return_v;
                }


                int
                f_1130_3526_3676(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 3526, 3676);
                    return 0;
                }


                int
                f_1130_3944_3983(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 3944, 3983);
                    return 0;
                }


                int
                f_1130_4109_4135(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 4109, 4135);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1130_2225_2261_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 2225, 2261);
                    return return_v;
                }


                string
                f_1130_4407_4456()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.NoDefaultShapeEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 4407, 4456);
                    return return_v;
                }


                string
                f_1130_4458_4479(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 4458, 4479);
                    return return_v;
                }


                string
                f_1130_4481_4489()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 4481, 4489);
                    return return_v;
                }


                string
                f_1130_4389_4516(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 4389, 4516);
                    return return_v;
                }


                int
                f_1130_4372_4517(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 4372, 4517);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1130, 1951, 4563);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1130, 1951, 4563);
            }
        }

        private ComplexControlEntryDefinition LoadComplexControlEntryDefinition(XmlNode complexControlEntryNode, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1130, 4575, 6691);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 4715, 6680);
                using (f_1130_4722_4769(this, complexControlEntryNode, index))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 4803, 4835);

                    bool
                    appliesToNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 4876, 4903);

                    bool
                    bodyNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 4948, 5021);

                    ComplexControlEntryDefinition
                    cced = f_1130_4985_5020()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 5041, 6248);
                        foreach (XmlNode n in f_1130_5063_5097_I(f_1130_5063_5097(complexControlEntryNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 5041, 6248);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 5139, 6229) || true) && (f_1130_5143_5188(this, n, XmlTags.EntrySelectedByNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 5139, 6229);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 5238, 5425) || true) && (appliesToNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 5238, 5425);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 5318, 5347);

                                    f_1130_5318_5346(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 5377, 5389);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 5238, 5425);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 5453, 5479);

                                appliesToNodeFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 5552, 5599);

                                cced.appliesTo = f_1130_5569_5598(this, n, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 5139, 6229);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 5139, 6229);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 5649, 6229) || true) && (f_1130_5653_5694(this, n, XmlTags.ComplexItemNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 5649, 6229);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 5744, 5926) || true) && (bodyNodeFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 5744, 5926);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 5819, 5848);

                                        f_1130_5819_5847(this, n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 5878, 5890);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 5744, 5926);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 5954, 5975);

                                    bodyNodeFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 6001, 6081);

                                    cced.itemDefinition.formatTokenList = f_1130_6039_6080(this, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 5649, 6229);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 5649, 6229);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 6179, 6206);

                                    f_1130_6179_6205(this, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 5649, 6229);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 5139, 6229);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 5041, 6248);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1130, 1, 1208);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1130, 1, 1208);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 6268, 6633) || true) && (cced.itemDefinition.formatTokenList == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 6268, 6633);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 6443, 6580);

                        f_1130_6443_6579(                    // MissingNode=Error at XPath {0} in file {1}: Missing Node {2}.
                                            this, f_1130_6460_6578(f_1130_6478_6519(), f_1130_6521_6542(this), f_1130_6544_6552(), XmlTags.ComplexItemNode));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 6602, 6614);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 6268, 6633);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 6653, 6665);

                    return cced;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1130, 4715, 6680);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1130, 4575, 6691);

                System.IDisposable
                f_1130_4722_4769(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 4722, 4769);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition
                f_1130_4985_5020()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 4985, 5020);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1130_5063_5097(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 5063, 5097);
                    return return_v;
                }


                bool
                f_1130_5143_5188(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 5143, 5188);
                    return return_v;
                }


                int
                f_1130_5318_5346(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 5318, 5346);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1130_5569_5598(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                appliesToNode, bool
                allowSelectionCondition)
                {
                    var return_v = this_param.LoadAppliesToSection(appliesToNode, allowSelectionCondition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 5569, 5598);
                    return return_v;
                }


                bool
                f_1130_5653_5694(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 5653, 5694);
                    return return_v;
                }


                int
                f_1130_5819_5847(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 5819, 5847);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                f_1130_6039_6080(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                bodyNode)
                {
                    var return_v = this_param.LoadComplexControlTokenListDefinitions(bodyNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 6039, 6080);
                    return return_v;
                }


                int
                f_1130_6179_6205(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 6179, 6205);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1130_5063_5097_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 5063, 5097);
                    return return_v;
                }


                string
                f_1130_6478_6519()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.MissingNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 6478, 6519);
                    return return_v;
                }


                string
                f_1130_6521_6542(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 6521, 6542);
                    return return_v;
                }


                string
                f_1130_6544_6552()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 6544, 6552);
                    return return_v;
                }


                string
                f_1130_6460_6578(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 6460, 6578);
                    return return_v;
                }


                int
                f_1130_6443_6579(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 6443, 6579);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1130, 4575, 6691);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1130, 4575, 6691);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<FormatToken> LoadComplexControlTokenListDefinitions(XmlNode bodyNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1130, 6703, 10325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 6810, 10314);
                using (f_1130_6817_6842(this, bodyNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 6876, 6936);

                    List<FormatToken>
                    formatTokenList = f_1130_6912_6935()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 6956, 6986);

                    int
                    compoundPropertyIndex = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 7004, 7025);

                    int
                    newLineIndex = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 7043, 7061);

                    int
                    textIndex = 0
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 7079, 7098);

                    int
                    frameIndex = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 7118, 9899);
                        foreach (XmlNode n in f_1130_7140_7159_I(f_1130_7140_7159(bodyNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 7118, 9899);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 7201, 9880) || true) && (f_1130_7205_7252(this, n, XmlTags.ExpressionBindingNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 7201, 9880);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 7302, 7379);

                                CompoundPropertyToken
                                cpt = f_1130_7330_7378(this, n, compoundPropertyIndex++)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 7407, 7778) || true) && (cpt == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 7407, 7778);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 7564, 7709);

                                    f_1130_7564_7708(                            // Error at XPath {0} in file {1}: {2} failed to load.
                                                                this, f_1130_7581_7707(f_1130_7599_7642(), f_1130_7644_7665(this), f_1130_7667_7675(), XmlTags.ExpressionBindingNode));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 7739, 7751);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 7407, 7778);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 7806, 7831);

                                f_1130_7806_7830(
                                                        formatTokenList, cpt);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 7201, 9880);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 7201, 9880);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 7881, 9880) || true) && (f_1130_7885_7922(this, n, XmlTags.NewLineNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 7881, 9880);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 7972, 8022);

                                    NewLineToken
                                    nlt = f_1130_7991_8021(this, n, newLineIndex++)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 8050, 8411) || true) && (nlt == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 8050, 8411);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 8207, 8342);

                                        f_1130_8207_8341(                            // Error at XPath {0} in file {1}: {2} failed to load.
                                                                    this, f_1130_8224_8340(f_1130_8242_8285(), f_1130_8287_8308(this), f_1130_8310_8318(), XmlTags.NewLineNode));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 8372, 8384);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 8050, 8411);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 8439, 8464);

                                    f_1130_8439_8463(
                                                            formatTokenList, nlt);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 7881, 9880);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 7881, 9880);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 8514, 9880) || true) && (f_1130_8518_8566(this, n, XmlTags.TextNode))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 8514, 9880);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 8616, 8656);

                                        TextToken
                                        tt = f_1130_8631_8655(this, n, textIndex++)
                                        ;

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 8684, 9041) || true) && (tt == null)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 8684, 9041);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 8840, 8972);

                                            f_1130_8840_8971(                            // Error at XPath {0} in file {1}: {2} failed to load.
                                                                        this, f_1130_8857_8970(f_1130_8875_8918(), f_1130_8920_8941(this), f_1130_8943_8951(), XmlTags.TextNode));
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 9002, 9014);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 8684, 9041);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 9069, 9093);

                                        f_1130_9069_9092(
                                                                formatTokenList, tt);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 8514, 9880);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 8514, 9880);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 9143, 9880) || true) && (f_1130_9147_9182(this, n, XmlTags.FrameNode))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 9143, 9880);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 9232, 9288);

                                            FrameToken
                                            frame = f_1130_9251_9287(this, n, frameIndex++)
                                            ;

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 9316, 9677) || true) && (frame == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 9316, 9677);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 9475, 9608);

                                                f_1130_9475_9607(                            // Error at XPath {0} in file {1}: {2} failed to load.
                                                                            this, f_1130_9492_9606(f_1130_9510_9553(), f_1130_9555_9576(this), f_1130_9578_9586(), XmlTags.FrameNode));
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 9638, 9650);

                                                return null;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 9316, 9677);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 9705, 9732);

                                            f_1130_9705_9731(
                                                                    formatTokenList, frame);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 9143, 9880);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 9143, 9880);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 9830, 9857);

                                            f_1130_9830_9856(this, n);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 9143, 9880);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 8514, 9880);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 7881, 9880);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 7201, 9880);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 7118, 9899);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1130, 1, 2782);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1130, 1, 2782);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 9919, 10256) || true) && (f_1130_9923_9944(formatTokenList) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 9919, 10256);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 10080, 10203);

                        f_1130_10080_10202(                    // Error at XPath {0} in file {1}: Empty custom control token list.
                                            this, f_1130_10097_10201(f_1130_10115_10167(), f_1130_10169_10190(this), f_1130_10192_10200()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 10225, 10237);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 9919, 10256);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 10276, 10299);

                    return formatTokenList;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1130, 6810, 10314);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1130, 6703, 10325);

                System.IDisposable
                f_1130_6817_6842(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 6817, 6842);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                f_1130_6912_6935()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 6912, 6935);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1130_7140_7159(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 7140, 7159);
                    return return_v;
                }


                bool
                f_1130_7205_7252(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 7205, 7252);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.CompoundPropertyToken
                f_1130_7330_7378(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                compoundPropertyNode, int
                index)
                {
                    var return_v = this_param.LoadCompoundProperty(compoundPropertyNode, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 7330, 7378);
                    return return_v;
                }


                string
                f_1130_7599_7642()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.LoadTagFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 7599, 7642);
                    return return_v;
                }


                string
                f_1130_7644_7665(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 7644, 7665);
                    return return_v;
                }


                string
                f_1130_7667_7675()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 7667, 7675);
                    return return_v;
                }


                string
                f_1130_7581_7707(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 7581, 7707);
                    return return_v;
                }


                int
                f_1130_7564_7708(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 7564, 7708);
                    return 0;
                }


                int
                f_1130_7806_7830(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.CompoundPropertyToken
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 7806, 7830);
                    return 0;
                }


                bool
                f_1130_7885_7922(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 7885, 7922);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.NewLineToken
                f_1130_7991_8021(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                newLineNode, int
                index)
                {
                    var return_v = this_param.LoadNewLine(newLineNode, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 7991, 8021);
                    return return_v;
                }


                string
                f_1130_8242_8285()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.LoadTagFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 8242, 8285);
                    return return_v;
                }


                string
                f_1130_8287_8308(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 8287, 8308);
                    return return_v;
                }


                string
                f_1130_8310_8318()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 8310, 8318);
                    return return_v;
                }


                string
                f_1130_8224_8340(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 8224, 8340);
                    return return_v;
                }


                int
                f_1130_8207_8341(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 8207, 8341);
                    return 0;
                }


                int
                f_1130_8439_8463(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.NewLineToken
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 8439, 8463);
                    return 0;
                }


                bool
                f_1130_8518_8566(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeNameWithAttributes(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 8518, 8566);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1130_8631_8655(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                textNode, int
                index)
                {
                    var return_v = this_param.LoadText(textNode, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 8631, 8655);
                    return return_v;
                }


                string
                f_1130_8875_8918()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.LoadTagFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 8875, 8918);
                    return return_v;
                }


                string
                f_1130_8920_8941(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 8920, 8941);
                    return return_v;
                }


                string
                f_1130_8943_8951()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 8943, 8951);
                    return return_v;
                }


                string
                f_1130_8857_8970(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 8857, 8970);
                    return return_v;
                }


                int
                f_1130_8840_8971(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 8840, 8971);
                    return 0;
                }


                int
                f_1130_9069_9092(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TextToken
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 9069, 9092);
                    return 0;
                }


                bool
                f_1130_9147_9182(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 9147, 9182);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FrameToken
                f_1130_9251_9287(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                frameNode, int
                index)
                {
                    var return_v = this_param.LoadFrameDefinition(frameNode, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 9251, 9287);
                    return return_v;
                }


                string
                f_1130_9510_9553()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.LoadTagFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 9510, 9553);
                    return return_v;
                }


                string
                f_1130_9555_9576(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 9555, 9576);
                    return return_v;
                }


                string
                f_1130_9578_9586()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 9578, 9586);
                    return return_v;
                }


                string
                f_1130_9492_9606(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 9492, 9606);
                    return return_v;
                }


                int
                f_1130_9475_9607(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 9475, 9607);
                    return 0;
                }


                int
                f_1130_9705_9731(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FrameToken
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 9705, 9731);
                    return 0;
                }


                int
                f_1130_9830_9856(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 9830, 9856);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1130_7140_7159_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 7140, 7159);
                    return return_v;
                }


                int
                f_1130_9923_9944(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 9923, 9944);
                    return return_v;
                }


                string
                f_1130_10115_10167()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.EmptyCustomControlList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 10115, 10167);
                    return return_v;
                }


                string
                f_1130_10169_10190(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 10169, 10190);
                    return return_v;
                }


                string
                f_1130_10192_10200()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 10192, 10200);
                    return return_v;
                }


                string
                f_1130_10097_10201(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 10097, 10201);
                    return return_v;
                }


                int
                f_1130_10080_10202(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 10080, 10202);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1130, 6703, 10325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1130, 6703, 10325);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LoadPropertyBaseHelper(XmlNode propertyBaseNode, PropertyTokenBase ptb, List<XmlNode> unprocessedNodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1130, 10337, 13069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 10478, 10546);

                ExpressionNodeMatch
                expressionMatch = f_1130_10516_10545(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 10562, 10595);

                bool
                expressionNodeFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 10633, 10666);

                bool
                collectionNodeFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 10706, 10751);

                bool
                itemSelectionConditionNodeFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 10787, 10820);

                ExpressionToken
                condition = null
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 10836, 12565);
                    foreach (XmlNode n in f_1130_10858_10885_I(f_1130_10858_10885(propertyBaseNode)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 10836, 12565);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 10919, 12550) || true) && (f_1130_10923_10951(expressionMatch, n))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 10919, 12550);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 10993, 11172) || true) && (expressionNodeFound)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 10993, 11172);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 11066, 11095);

                                f_1130_11066_11094(this, n);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 11121, 11134);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 10993, 11172);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 11196, 11223);

                            expressionNodeFound = true;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 11245, 11320) || true) && (!f_1130_11250_11280(expressionMatch, n))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 11245, 11320);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 11307, 11320);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 11245, 11320);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 10919, 12550);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 10919, 12550);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 11377, 12550) || true) && (f_1130_11381_11430(this, n, XmlTags.EnumerateCollectionNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 11377, 12550);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 11472, 11636) || true) && (collectionNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 11472, 11636);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 11545, 11574);

                                    f_1130_11545_11573(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 11600, 11613);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 11472, 11636);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 11660, 11687);

                                collectionNodeFound = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 11709, 11801) || true) && (!f_1130_11714_11761(this, n, out ptb.enumerateCollection))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 11709, 11801);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 11788, 11801);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 11709, 11801);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 11377, 12550);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 11377, 12550);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 11843, 12550) || true) && (f_1130_11847_11899(this, n, XmlTags.ItemSelectionConditionNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 11843, 12550);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 11941, 12117) || true) && (itemSelectionConditionNodeFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 11941, 12117);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 12026, 12055);

                                        f_1130_12026_12054(this, n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 12081, 12094);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 11941, 12117);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 12141, 12180);

                                    itemSelectionConditionNodeFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 12202, 12244);

                                    condition = f_1130_12214_12243(this, n);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 12266, 12373) || true) && (condition == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 12266, 12373);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 12337, 12350);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 12266, 12373);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 11843, 12550);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 11843, 12550);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 12455, 12531) || true) && (!f_1130_12460_12480(n))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 12455, 12531);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 12507, 12531);

                                        f_1130_12507_12530(unprocessedNodes, n);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 12455, 12531);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 11843, 12550);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 11377, 12550);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 10919, 12550);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 10836, 12565);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1130, 1, 1730);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1130, 1, 1730);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 12581, 13030) || true) && (expressionNodeFound)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 12581, 13030);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 12718, 12789);

                    ExpressionToken
                    expression = f_1130_12747_12788(expressionMatch)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 12807, 12918) || true) && (expression == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 12807, 12918);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 12871, 12884);

                        return false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 12807, 12918);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 12938, 12966);

                    ptb.expression = expression;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 12984, 13015);

                    ptb.conditionToken = condition;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 12581, 13030);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 13046, 13058);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1130, 10337, 13069);

                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                f_1130_10516_10545(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                loader)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch(loader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 10516, 10545);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1130_10858_10885(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 10858, 10885);
                    return return_v;
                }


                bool
                f_1130_10923_10951(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.MatchNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 10923, 10951);
                    return return_v;
                }


                int
                f_1130_11066_11094(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 11066, 11094);
                    return 0;
                }


                bool
                f_1130_11250_11280(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.ProcessNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 11250, 11280);
                    return return_v;
                }


                bool
                f_1130_11381_11430(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 11381, 11430);
                    return return_v;
                }


                int
                f_1130_11545_11573(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 11545, 11573);
                    return 0;
                }


                bool
                f_1130_11714_11761(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                collectionElement, out bool
                val)
                {
                    var return_v = this_param.ReadBooleanNode(collectionElement, out val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 11714, 11761);
                    return return_v;
                }


                bool
                f_1130_11847_11899(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 11847, 11899);
                    return return_v;
                }


                int
                f_1130_12026_12054(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 12026, 12054);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1130_12214_12243(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                itemNode)
                {
                    var return_v = this_param.LoadItemSelectionCondition(itemNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 12214, 12243);
                    return return_v;
                }


                bool
                f_1130_12460_12480(System.Xml.XmlNode
                n)
                {
                    var return_v = IsFilteredOutNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 12460, 12480);
                    return return_v;
                }


                int
                f_1130_12507_12530(System.Collections.Generic.List<System.Xml.XmlNode>
                this_param, System.Xml.XmlNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 12507, 12530);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1130_10858_10885_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 10858, 10885);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1130_12747_12788(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                this_param)
                {
                    var return_v = this_param.GenerateExpressionToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 12747, 12788);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1130, 10337, 13069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1130, 10337, 13069);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private CompoundPropertyToken LoadCompoundProperty(XmlNode compoundPropertyNode, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1130, 13914, 17322);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 14030, 17311);
                using (f_1130_14037_14081(this, compoundPropertyNode, index))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 14115, 14171);

                    CompoundPropertyToken
                    cpt = f_1130_14143_14170()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 14189, 14242);

                    List<XmlNode>
                    unprocessedNodes = f_1130_14222_14241()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 14260, 14343);

                    bool
                    success = f_1130_14275_14342(this, compoundPropertyNode, cpt, unprocessedNodes)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 14363, 14448) || true) && (!success)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 14363, 14448);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 14417, 14429);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 14363, 14448);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 14468, 14487);

                    cpt.control = null;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 14546, 14579);

                    bool
                    complexControlFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 14618, 14649);

                    bool
                    fieldControlFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 14690, 14755);

                    ComplexControlMatch
                    controlMatch = f_1130_14725_14754(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 14773, 14814);

                    FieldControlBody
                    fieldControlBody = null
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 14834, 16414);
                        foreach (XmlNode n in f_1130_14856_14872_I(unprocessedNodes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 14834, 16414);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 14914, 16395) || true) && (f_1130_14918_14943(controlMatch, n))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 14914, 16395);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 14993, 15241) || true) && (complexControlFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 14993, 15241);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 15074, 15172);

                                    f_1130_15074_15171(this, n, XmlTags.ComplexControlNode, XmlTags.ComplexControlNameNode);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 15202, 15214);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 14993, 15241);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 15269, 15296);

                                complexControlFound = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 15322, 15397) || true) && (!f_1130_15327_15354(controlMatch, n))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 15322, 15397);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 15385, 15397);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 15322, 15397);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 14914, 16395);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 14914, 16395);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 15462, 16395) || true) && (f_1130_15466_15508(this, n, XmlTags.FieldControlNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 15462, 16395);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 15558, 15819) || true) && (fieldControlFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 15558, 15819);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 15637, 15735);

                                        f_1130_15637_15734(this, n, XmlTags.ComplexControlNode, XmlTags.ComplexControlNameNode);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 15765, 15777);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 15558, 15819);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 15847, 15872);

                                    fieldControlFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 15898, 15940);

                                    fieldControlBody = f_1130_15917_15939();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 15966, 16048);

                                    fieldControlBody.fieldFormattingDirective.formatString = f_1130_16023_16047(this, n);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 16074, 16252) || true) && (fieldControlBody.fieldFormattingDirective.formatString == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 16074, 16252);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 16198, 16210);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 16074, 16252);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 15462, 16395);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 15462, 16395);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 16350, 16372);

                                    f_1130_16350_16371(this, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 15462, 16395);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 14914, 16395);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 14834, 16414);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1130, 1, 1581);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1130, 1, 1581);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 16434, 16683) || true) && (fieldControlFound && (DynAbs.Tracing.TraceSender.Expression_True(1130, 16438, 16478) && complexControlFound))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 16434, 16683);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 16520, 16615);

                        f_1130_16520_16614(this, XmlTags.ComplexControlNode, XmlTags.ComplexControlNameNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 16637, 16649);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 16434, 16683);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 16703, 16933) || true) && (fieldControlFound)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 16703, 16933);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 16766, 16797);

                        cpt.control = fieldControlBody;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 16703, 16933);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 16703, 16933);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 16879, 16914);

                        cpt.control = f_1130_16893_16913(controlMatch);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 16703, 16933);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 17285, 17296);

                    return cpt;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1130, 14030, 17311);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1130, 13914, 17322);

                System.IDisposable
                f_1130_14037_14081(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 14037, 14081);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.CompoundPropertyToken
                f_1130_14143_14170()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.CompoundPropertyToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 14143, 14170);
                    return return_v;
                }


                System.Collections.Generic.List<System.Xml.XmlNode>
                f_1130_14222_14241()
                {
                    var return_v = new System.Collections.Generic.List<System.Xml.XmlNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 14222, 14241);
                    return return_v;
                }


                bool
                f_1130_14275_14342(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                propertyBaseNode, Microsoft.PowerShell.Commands.Internal.Format.CompoundPropertyToken
                ptb, System.Collections.Generic.List<System.Xml.XmlNode>
                unprocessedNodes)
                {
                    var return_v = this_param.LoadPropertyBaseHelper(propertyBaseNode, (Microsoft.PowerShell.Commands.Internal.Format.PropertyTokenBase)ptb, unprocessedNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 14275, 14342);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ComplexControlMatch
                f_1130_14725_14754(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                loader)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ComplexControlMatch(loader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 14725, 14754);
                    return return_v;
                }


                bool
                f_1130_14918_14943(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ComplexControlMatch
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.MatchNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 14918, 14943);
                    return return_v;
                }


                int
                f_1130_15074_15171(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                node1, string
                node2)
                {
                    this_param.ProcessDuplicateAlternateNode(n, node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 15074, 15171);
                    return 0;
                }


                bool
                f_1130_15327_15354(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ComplexControlMatch
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.ProcessNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 15327, 15354);
                    return return_v;
                }


                bool
                f_1130_15466_15508(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 15466, 15508);
                    return return_v;
                }


                int
                f_1130_15637_15734(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                node1, string
                node2)
                {
                    this_param.ProcessDuplicateAlternateNode(n, node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 15637, 15734);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FieldControlBody
                f_1130_15917_15939()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FieldControlBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 15917, 15939);
                    return return_v;
                }


                string
                f_1130_16023_16047(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.GetMandatoryInnerText(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 16023, 16047);
                    return return_v;
                }


                int
                f_1130_16350_16371(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 16350, 16371);
                    return 0;
                }


                System.Collections.Generic.List<System.Xml.XmlNode>
                f_1130_14856_14872_I(System.Collections.Generic.List<System.Xml.XmlNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 14856, 14872);
                    return return_v;
                }


                int
                f_1130_16520_16614(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                node1, string
                node2)
                {
                    this_param.ProcessDuplicateAlternateNode(node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 16520, 16614);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                f_1130_16893_16913(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ComplexControlMatch
                this_param)
                {
                    var return_v = this_param.Control;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 16893, 16913);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1130, 13914, 17322);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1130, 13914, 17322);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private NewLineToken LoadNewLine(XmlNode newLineNode, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1130, 17334, 17728);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 17423, 17717);
                using (f_1130_17430_17465(this, newLineNode, index))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 17499, 17613) || true) && (!f_1130_17504_17540(this, newLineNode))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 17499, 17613);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 17582, 17594);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 17499, 17613);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 17633, 17671);

                    NewLineToken
                    nlt = f_1130_17652_17670()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 17691, 17702);

                    return nlt;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1130, 17423, 17717);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1130, 17334, 17728);

                System.IDisposable
                f_1130_17430_17465(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 17430, 17465);
                    return return_v;
                }


                bool
                f_1130_17504_17540(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.VerifyNodeHasNoChildren(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 17504, 17540);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.NewLineToken
                f_1130_17652_17670()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.NewLineToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 17652, 17670);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1130, 17334, 17728);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1130, 17334, 17728);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TextToken LoadText(XmlNode textNode, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1130, 17740, 17950);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 17820, 17939);
                using (f_1130_17827_17859(this, textNode, index))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 17893, 17924);

                    return f_1130_17900_17923(this, textNode);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1130, 17820, 17939);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1130, 17740, 17950);

                System.IDisposable
                f_1130_17827_17859(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 17827, 17859);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1130_17900_17923(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.LoadTextToken(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 17900, 17923);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1130, 17740, 17950);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1130, 17740, 17950);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal TextToken LoadText(XmlNode textNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1130, 17962, 18155);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 18032, 18144);
                using (f_1130_18039_18064(this, textNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 18098, 18129);

                    return f_1130_18105_18128(this, textNode);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1130, 18032, 18144);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1130, 17962, 18155);

                System.IDisposable
                f_1130_18039_18064(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 18039, 18064);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1130_18105_18128(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.LoadTextToken(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 18105, 18128);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1130, 17962, 18155);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1130, 17962, 18155);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int LoadIntegerValue(XmlNode node, out bool success)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1130, 18167, 19325);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 18252, 19314);
                using (f_1130_18259_18280(this, node))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 18314, 18330);

                    success = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 18348, 18363);

                    int
                    retVal = 0
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 18381, 18490) || true) && (!f_1130_18386_18415(this, node))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 18381, 18490);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 18457, 18471);

                        return retVal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 18381, 18490);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 18510, 18556);

                    string
                    val = f_1130_18523_18555(this, node)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 18576, 18887) || true) && (val == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 18576, 18887);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 18715, 18832);

                        f_1130_18715_18831(                    // Error at XPath {0} in file {1}: Missing inner text value.
                                            this, f_1130_18732_18830(f_1130_18750_18796(), f_1130_18798_18819(this), f_1130_18821_18829()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 18854, 18868);

                        return retVal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 18576, 18887);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 18907, 19232) || true) && (!f_1130_18912_18941(val, out retVal))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 18907, 19232);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 19063, 19177);

                        f_1130_19063_19176(                    // Error at XPath {0} in file {1}: An integer is expected.
                                            this, f_1130_19080_19175(f_1130_19098_19141(), f_1130_19143_19164(this), f_1130_19166_19174()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 19199, 19213);

                        return retVal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 18907, 19232);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 19252, 19267);

                    success = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 19285, 19299);

                    return retVal;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1130, 18252, 19314);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1130, 18167, 19325);

                System.IDisposable
                f_1130_18259_18280(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 18259, 18280);
                    return return_v;
                }


                bool
                f_1130_18386_18415(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.VerifyNodeHasNoChildren(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 18386, 18415);
                    return return_v;
                }


                string
                f_1130_18523_18555(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.GetMandatoryInnerText(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 18523, 18555);
                    return return_v;
                }


                string
                f_1130_18750_18796()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.MissingInnerText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 18750, 18796);
                    return return_v;
                }


                string
                f_1130_18798_18819(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 18798, 18819);
                    return return_v;
                }


                string
                f_1130_18821_18829()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 18821, 18829);
                    return return_v;
                }


                string
                f_1130_18732_18830(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 18732, 18830);
                    return return_v;
                }


                int
                f_1130_18715_18831(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 18715, 18831);
                    return 0;
                }


                bool
                f_1130_18912_18941(string
                s, out int
                result)
                {
                    var return_v = int.TryParse(s, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 18912, 18941);
                    return return_v;
                }


                string
                f_1130_19098_19141()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.ExpectInteger;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 19098, 19141);
                    return return_v;
                }


                string
                f_1130_19143_19164(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 19143, 19164);
                    return return_v;
                }


                string
                f_1130_19166_19174()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 19166, 19174);
                    return return_v;
                }


                string
                f_1130_19080_19175(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 19080, 19175);
                    return return_v;
                }


                int
                f_1130_19063_19176(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 19063, 19176);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1130, 18167, 19325);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1130, 18167, 19325);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int LoadPositiveOrZeroIntegerValue(XmlNode node, out bool success)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1130, 19337, 19993);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 19436, 19482);

                int
                val = f_1130_19446_19481(this, node, out success)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 19496, 19538) || true) && (!success)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 19496, 19538);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 19527, 19538);

                    return val;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 19496, 19538);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 19552, 19982);
                using (f_1130_19559_19580(this, node))
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 19614, 19936) || true) && (val < 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 19614, 19936);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 19759, 19879);

                        f_1130_19759_19878(                    // Error at XPath {0} in file {1}: A non-negative integer is expected.
                                            this, f_1130_19776_19877(f_1130_19794_19843(), f_1130_19845_19866(this), f_1130_19868_19876()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 19901, 19917);

                        success = false;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 19614, 19936);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 19956, 19967);

                    return val;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1130, 19552, 19982);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1130, 19337, 19993);

                int
                f_1130_19446_19481(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                node, out bool
                success)
                {
                    var return_v = this_param.LoadIntegerValue(node, out success);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 19446, 19481);
                    return return_v;
                }


                System.IDisposable
                f_1130_19559_19580(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 19559, 19580);
                    return return_v;
                }


                string
                f_1130_19794_19843()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.ExpectNaturalNumber;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 19794, 19843);
                    return return_v;
                }


                string
                f_1130_19845_19866(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 19845, 19866);
                    return return_v;
                }


                string
                f_1130_19868_19876()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 19868, 19876);
                    return return_v;
                }


                string
                f_1130_19776_19877(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 19776, 19877);
                    return return_v;
                }


                int
                f_1130_19759_19878(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 19759, 19878);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1130, 19337, 19993);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1130, 19337, 19993);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private FrameToken LoadFrameDefinition(XmlNode frameNode, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1130, 20005, 24781);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 20098, 24770);
                using (f_1130_20105_20138(this, frameNode, index))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 20172, 20199);

                    bool
                    itemNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 20234, 20263);

                    bool
                    leftIndentFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 20303, 20333);

                    bool
                    rightIndentFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 20413, 20447);

                    bool
                    firstLineIndentFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 20486, 20521);

                    bool
                    firstLineHangingFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 20562, 20575);

                    bool
                    success
                    = default(bool);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 20615, 20651);

                    FrameToken
                    frame = f_1130_20634_20650()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 20669, 24063);
                        foreach (XmlNode n in f_1130_20691_20711_I(f_1130_20691_20711(frameNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 20669, 24063);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 20753, 24044) || true) && (f_1130_20757_20797(this, n, XmlTags.LeftIndentNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 20753, 24044);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 20847, 21031) || true) && (leftIndentFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 20847, 21031);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 20924, 20953);

                                    f_1130_20924_20952(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 20983, 20995);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 20847, 21031);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 21059, 21082);

                                leftIndentFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 21155, 21246);

                                frame.frameInfoDefinition.leftIndentation = f_1130_21199_21245(this, n, out success);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 21272, 21327) || true) && (!success)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 21272, 21327);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 21315, 21327);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 21272, 21327);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 20753, 24044);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 20753, 24044);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 21377, 24044) || true) && (f_1130_21381_21422(this, n, XmlTags.RightIndentNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 21377, 24044);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 21472, 21657) || true) && (rightIndentFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 21472, 21657);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 21550, 21579);

                                        f_1130_21550_21578(this, n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 21609, 21621);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 21472, 21657);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 21685, 21709);

                                    rightIndentFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 21782, 21874);

                                    frame.frameInfoDefinition.rightIndentation = f_1130_21827_21873(this, n, out success);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 21900, 21955) || true) && (!success)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 21900, 21955);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 21943, 21955);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 21900, 21955);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 21377, 24044);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 21377, 24044);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 22005, 24044) || true) && (f_1130_22009_22054(this, n, XmlTags.FirstLineIndentNode))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 22005, 24044);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 22104, 22352) || true) && (firstLineIndentFound)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 22104, 22352);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 22186, 22283);

                                            f_1130_22186_22282(this, n, XmlTags.FirstLineIndentNode, XmlTags.FirstLineHangingNode);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 22313, 22325);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 22104, 22352);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 22380, 22408);

                                        firstLineIndentFound = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 22436, 22521);

                                        frame.frameInfoDefinition.firstLine = f_1130_22474_22520(this, n, out success);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 22547, 22602) || true) && (!success)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 22547, 22602);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 22590, 22602);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 22547, 22602);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 22005, 24044);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 22005, 24044);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 22652, 24044) || true) && (f_1130_22656_22702(this, n, XmlTags.FirstLineHangingNode))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 22652, 24044);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 22752, 23001) || true) && (firstLineHangingFound)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 22752, 23001);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 22835, 22932);

                                                f_1130_22835_22931(this, n, XmlTags.FirstLineIndentNode, XmlTags.FirstLineHangingNode);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 22962, 22974);

                                                return null;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 22752, 23001);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 23029, 23058);

                                            firstLineHangingFound = true;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 23086, 23171);

                                            frame.frameInfoDefinition.firstLine = f_1130_23124_23170(this, n, out success);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 23197, 23252) || true) && (!success)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 23197, 23252);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 23240, 23252);

                                                return null;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 23197, 23252);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 23338, 23413);

                                            frame.frameInfoDefinition.firstLine = -frame.frameInfoDefinition.firstLine;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 22652, 24044);
                                        }

                                        else
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 22652, 24044);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 23463, 24044) || true) && (f_1130_23467_23508(this, n, XmlTags.ComplexItemNode))
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 23463, 24044);

                                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 23558, 23740) || true) && (itemNodeFound)
                                                )

                                                {
                                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 23558, 23740);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 23633, 23662);

                                                    f_1130_23633_23661(this, n);
                                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 23692, 23704);

                                                    return null;
                                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 23558, 23740);
                                                }
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 23768, 23789);

                                                itemNodeFound = true;
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 23815, 23896);

                                                frame.itemDefinition.formatTokenList = f_1130_23854_23895(this, n);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 23463, 24044);
                                            }

                                            else

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 23463, 24044);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 23994, 24021);

                                                f_1130_23994_24020(this, n);
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 23463, 24044);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 22652, 24044);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 22005, 24044);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 21377, 24044);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 20753, 24044);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 20669, 24063);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1130, 1, 3395);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1130, 1, 3395);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 24083, 24336) || true) && (firstLineHangingFound && (DynAbs.Tracing.TraceSender.Expression_True(1130, 24087, 24132) && firstLineIndentFound))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 24083, 24336);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 24174, 24268);

                        f_1130_24174_24267(this, XmlTags.FirstLineIndentNode, XmlTags.FirstLineHangingNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 24290, 24302);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 24083, 24336);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 24356, 24722) || true) && (frame.itemDefinition.formatTokenList == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 24356, 24722);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 24532, 24669);

                        f_1130_24532_24668(                    // MissingNode=Error at XPath {0} in file {1}: Missing Node {2}.
                                            this, f_1130_24549_24667(f_1130_24567_24608(), f_1130_24610_24631(this), f_1130_24633_24641(), XmlTags.ComplexItemNode));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 24691, 24703);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 24356, 24722);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 24742, 24755);

                    return frame;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1130, 20098, 24770);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1130, 20005, 24781);

                System.IDisposable
                f_1130_20105_20138(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 20105, 20138);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FrameToken
                f_1130_20634_20650()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FrameToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 20634, 20650);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1130_20691_20711(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 20691, 20711);
                    return return_v;
                }


                bool
                f_1130_20757_20797(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 20757, 20797);
                    return return_v;
                }


                int
                f_1130_20924_20952(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 20924, 20952);
                    return 0;
                }


                int
                f_1130_21199_21245(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                node, out bool
                success)
                {
                    var return_v = this_param.LoadPositiveOrZeroIntegerValue(node, out success);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 21199, 21245);
                    return return_v;
                }


                bool
                f_1130_21381_21422(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 21381, 21422);
                    return return_v;
                }


                int
                f_1130_21550_21578(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 21550, 21578);
                    return 0;
                }


                int
                f_1130_21827_21873(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                node, out bool
                success)
                {
                    var return_v = this_param.LoadPositiveOrZeroIntegerValue(node, out success);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 21827, 21873);
                    return return_v;
                }


                bool
                f_1130_22009_22054(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 22009, 22054);
                    return return_v;
                }


                int
                f_1130_22186_22282(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                node1, string
                node2)
                {
                    this_param.ProcessDuplicateAlternateNode(n, node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 22186, 22282);
                    return 0;
                }


                int
                f_1130_22474_22520(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                node, out bool
                success)
                {
                    var return_v = this_param.LoadPositiveOrZeroIntegerValue(node, out success);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 22474, 22520);
                    return return_v;
                }


                bool
                f_1130_22656_22702(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 22656, 22702);
                    return return_v;
                }


                int
                f_1130_22835_22931(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                node1, string
                node2)
                {
                    this_param.ProcessDuplicateAlternateNode(n, node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 22835, 22931);
                    return 0;
                }


                int
                f_1130_23124_23170(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                node, out bool
                success)
                {
                    var return_v = this_param.LoadPositiveOrZeroIntegerValue(node, out success);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 23124, 23170);
                    return return_v;
                }


                bool
                f_1130_23467_23508(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 23467, 23508);
                    return return_v;
                }


                int
                f_1130_23633_23661(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 23633, 23661);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                f_1130_23854_23895(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                bodyNode)
                {
                    var return_v = this_param.LoadComplexControlTokenListDefinitions(bodyNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 23854, 23895);
                    return return_v;
                }


                int
                f_1130_23994_24020(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 23994, 24020);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1130_20691_20711_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 20691, 20711);
                    return return_v;
                }


                int
                f_1130_24174_24267(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                node1, string
                node2)
                {
                    this_param.ProcessDuplicateAlternateNode(node1, node2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 24174, 24267);
                    return 0;
                }


                string
                f_1130_24567_24608()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.MissingNode;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 24567, 24608);
                    return return_v;
                }


                string
                f_1130_24610_24631(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 24610, 24631);
                    return return_v;
                }


                string
                f_1130_24633_24641()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 24633, 24641);
                    return return_v;
                }


                string
                f_1130_24549_24667(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 24549, 24667);
                    return return_v;
                }


                int
                f_1130_24532_24668(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 24532, 24668);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1130, 20005, 24781);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1130, 20005, 24781);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ReadBooleanNode(XmlNode collectionElement, out bool val)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1130, 24793, 25830);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 24887, 24899);

                val = false;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 24915, 25024) || true) && (!f_1130_24920_24962(this, collectionElement))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 24915, 25024);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 24996, 25009);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 24915, 25024);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 25040, 25079);

                string
                s = f_1130_25051_25078(collectionElement)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 25095, 25212) || true) && (f_1130_25099_25122(s))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 25095, 25212);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 25156, 25167);

                    val = true;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 25185, 25197);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 25095, 25212);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 25228, 25585) || true) && (f_1130_25232_25307(s, XMLStringValues.False, StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 25228, 25585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 25341, 25353);

                    val = false;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 25371, 25383);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 25228, 25585);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 25228, 25585);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 25417, 25585) || true) && (f_1130_25421_25495(s, XMLStringValues.True, StringComparison.OrdinalIgnoreCase))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1130, 25417, 25585);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 25529, 25540);

                        val = true;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 25558, 25570);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 25417, 25585);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1130, 25228, 25585);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 25676, 25790);

                f_1130_25676_25789(            // Error at XPath {0} in file {1}: A Boolean value is expected.
                            this, f_1130_25693_25788(f_1130_25711_25754(), f_1130_25756_25777(this), f_1130_25779_25787()));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1130, 25806, 25819);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1130, 24793, 25830);

                bool
                f_1130_24920_24962(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.VerifyNodeHasNoChildren(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 24920, 24962);
                    return return_v;
                }


                string
                f_1130_25051_25078(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.InnerText;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 25051, 25078);
                    return return_v;
                }


                bool
                f_1130_25099_25122(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 25099, 25122);
                    return return_v;
                }


                bool
                f_1130_25232_25307(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 25232, 25307);
                    return return_v;
                }


                bool
                f_1130_25421_25495(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 25421, 25495);
                    return return_v;
                }


                string
                f_1130_25711_25754()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.ExpectBoolean;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 25711, 25754);
                    return return_v;
                }


                string
                f_1130_25756_25777(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 25756, 25777);
                    return return_v;
                }


                string
                f_1130_25779_25787()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1130, 25779, 25787);
                    return return_v;
                }


                string
                f_1130_25693_25788(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 25693, 25788);
                    return return_v;
                }


                int
                f_1130_25676_25789(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1130, 25676, 25789);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1130, 24793, 25830);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1130, 24793, 25830);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
