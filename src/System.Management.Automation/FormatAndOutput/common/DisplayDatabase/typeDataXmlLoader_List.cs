// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation.Internal;
using System.Xml;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed partial class TypeInfoDataBaseLoader : XmlLoaderBase
    {
        private ListControlBody LoadListControl(XmlNode controlNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1131, 508, 1933);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 593, 1922);
                using (f_1131_600_628(this, controlNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 662, 711);

                    ListControlBody
                    listBody = f_1131_689_710()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 731, 765);

                    bool
                    listViewEntriesFound = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 785, 1668);
                        foreach (XmlNode n in f_1131_807_829_I(f_1131_807_829(controlNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 785, 1668);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 871, 1649) || true) && (f_1131_875_916(this, n, XmlTags.ListEntriesNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 871, 1649);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 966, 1143) || true) && (listViewEntriesFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 966, 1143);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 1048, 1077);

                                    f_1131_1048_1076(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 1107, 1116);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 966, 1143);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 1171, 1199);

                                listViewEntriesFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 1284, 1320);

                                f_1131_1284_1319(this, n, listBody);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 1346, 1501) || true) && (listBody.defaultEntryDefinition == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 1346, 1501);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 1447, 1459);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 1346, 1501);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 871, 1649);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 871, 1649);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 1599, 1626);

                                f_1131_1599_1625(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 871, 1649);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 785, 1668);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1131, 1, 884);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1131, 1, 884);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 1688, 1871) || true) && (!listViewEntriesFound)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 1688, 1871);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 1755, 1803);

                        f_1131_1755_1802(this, XmlTags.ListEntriesNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 1825, 1837);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 1688, 1871);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 1891, 1907);

                    return listBody;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1131, 593, 1922);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1131, 508, 1933);

                System.IDisposable
                f_1131_600_628(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 600, 628);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListControlBody
                f_1131_689_710()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListControlBody();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 689, 710);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1131_807_829(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 807, 829);
                    return return_v;
                }


                bool
                f_1131_875_916(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 875, 916);
                    return return_v;
                }


                int
                f_1131_1048_1076(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 1048, 1076);
                    return 0;
                }


                int
                f_1131_1284_1319(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                listViewEntriesNode, Microsoft.PowerShell.Commands.Internal.Format.ListControlBody
                listBody)
                {
                    this_param.LoadListControlEntries(listViewEntriesNode, listBody);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 1284, 1319);
                    return 0;
                }


                int
                f_1131_1599_1625(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 1599, 1625);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1131_807_829_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 807, 829);
                    return return_v;
                }


                int
                f_1131_1755_1802(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                name)
                {
                    this_param.ReportMissingNode(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 1755, 1802);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1131, 508, 1933);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1131, 508, 1933);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadListControlEntries(XmlNode listViewEntriesNode, ListControlBody listBody)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1131, 1945, 4539);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 2060, 4528);
                using (f_1131_2067_2103(this, listViewEntriesNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 2137, 2156);

                    int
                    entryIndex = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 2176, 4155);
                        foreach (XmlNode n in f_1131_2198_2228_I(f_1131_2198_2228(listViewEntriesNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 2176, 4155);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 2270, 4136) || true) && (f_1131_2274_2313(this, n, XmlTags.ListEntryNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 2270, 4136);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 2363, 2445);

                                ListControlEntryDefinition
                                lved = f_1131_2397_2444(this, n, entryIndex++)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 2471, 2914) || true) && (lved == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 2471, 2914);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 2629, 2766);

                                    f_1131_2629_2765(                            // Error at XPath {0} in file {1}: {2} failed to load.
                                                                this, f_1131_2646_2764(f_1131_2664_2707(), f_1131_2709_2730(this), f_1131_2732_2740(), XmlTags.ListEntryNode));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 2796, 2835);

                                    listBody.defaultEntryDefinition = null;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 2865, 2872);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 2471, 2914);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 3029, 3988) || true) && (lved.appliesTo == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 3029, 3988);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 3113, 3810) || true) && (listBody.defaultEntryDefinition == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 3113, 3810);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 3222, 3261);

                                        listBody.defaultEntryDefinition = lved;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 3113, 3810);
                                    }

                                    else

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 3113, 3810);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 3502, 3650);

                                        f_1131_3502_3649(                                // Error at XPath {0} in file {1}: There cannot be more than one default {2}.
                                                                        this, f_1131_3519_3648(f_1131_3537_3591(), f_1131_3593_3614(this), f_1131_3616_3624(), XmlTags.ListEntryNode));
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 3684, 3723);

                                        listBody.defaultEntryDefinition = null;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 3757, 3764);

                                        return;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 3113, 3810);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 3029, 3988);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 3029, 3988);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 3924, 3961);

                                    f_1131_3924_3960(listBody.optionalEntryList, lved);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 3029, 3988);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 2270, 4136);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 2270, 4136);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 4086, 4113);

                                f_1131_4086_4112(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 2270, 4136);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 2176, 4155);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1131, 1, 1980);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1131, 1, 1980);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 4175, 4513) || true) && (listBody.optionalEntryList == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 4175, 4513);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 4351, 4494);

                        f_1131_4351_4493(                    // Error at XPath {0} in file {1}: There must be at least one default {2}.
                                            this, f_1131_4368_4492(f_1131_4386_4435(), f_1131_4437_4458(this), f_1131_4460_4468(), XmlTags.ListEntryNode));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 4175, 4513);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1131, 2060, 4528);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1131, 1945, 4539);

                System.IDisposable
                f_1131_2067_2103(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 2067, 2103);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1131_2198_2228(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 2198, 2228);
                    return return_v;
                }


                bool
                f_1131_2274_2313(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 2274, 2313);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                f_1131_2397_2444(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                listViewEntryNode, int
                index)
                {
                    var return_v = this_param.LoadListControlEntryDefinition(listViewEntryNode, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 2397, 2444);
                    return return_v;
                }


                string
                f_1131_2664_2707()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.LoadTagFailed;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 2664, 2707);
                    return return_v;
                }


                string
                f_1131_2709_2730(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 2709, 2730);
                    return return_v;
                }


                string
                f_1131_2732_2740()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 2732, 2740);
                    return return_v;
                }


                string
                f_1131_2646_2764(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 2646, 2764);
                    return return_v;
                }


                int
                f_1131_2629_2765(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 2629, 2765);
                    return 0;
                }


                string
                f_1131_3537_3591()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.TooManyDefaultShapeEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 3537, 3591);
                    return return_v;
                }


                string
                f_1131_3593_3614(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 3593, 3614);
                    return return_v;
                }


                string
                f_1131_3616_3624()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 3616, 3624);
                    return return_v;
                }


                string
                f_1131_3519_3648(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 3519, 3648);
                    return return_v;
                }


                int
                f_1131_3502_3649(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 3502, 3649);
                    return 0;
                }


                int
                f_1131_3924_3960(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 3924, 3960);
                    return 0;
                }


                int
                f_1131_4086_4112(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 4086, 4112);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1131_2198_2228_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 2198, 2228);
                    return return_v;
                }


                string
                f_1131_4386_4435()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.NoDefaultShapeEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 4386, 4435);
                    return return_v;
                }


                string
                f_1131_4437_4458(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 4437, 4458);
                    return return_v;
                }


                string
                f_1131_4460_4468()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 4460, 4468);
                    return return_v;
                }


                string
                f_1131_4368_4492(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 4368, 4492);
                    return return_v;
                }


                int
                f_1131_4351_4493(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 4351, 4493);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1131, 1945, 4539);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1131, 1945, 4539);
            }
        }

        private ListControlEntryDefinition LoadListControlEntryDefinition(XmlNode listViewEntryNode, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1131, 4551, 6558);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 4679, 6547);
                using (f_1131_4686_4727(this, listViewEntryNode, index))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 4761, 4793);

                    bool
                    appliesToNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 4834, 4861);

                    bool
                    bodyNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 4906, 4973);

                    ListControlEntryDefinition
                    lved = f_1131_4940_4972()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 4993, 6152);
                        foreach (XmlNode n in f_1131_5015_5043_I(f_1131_5015_5043(listViewEntryNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 4993, 6152);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 5085, 6133) || true) && (f_1131_5089_5134(this, n, XmlTags.EntrySelectedByNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 5085, 6133);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 5184, 5371) || true) && (appliesToNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 5184, 5371);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 5264, 5293);

                                    f_1131_5264_5292(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 5323, 5335);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 5184, 5371);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 5399, 5425);

                                appliesToNodeFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 5498, 5545);

                                lved.appliesTo = f_1131_5515_5544(this, n, true);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 5085, 6133);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 5085, 6133);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 5595, 6133) || true) && (f_1131_5599_5638(this, n, XmlTags.ListItemsNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 5595, 6133);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 5688, 5870) || true) && (bodyNodeFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 5688, 5870);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 5763, 5792);

                                        f_1131_5763_5791(this, n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 5822, 5834);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 5688, 5870);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 5898, 5919);

                                    bodyNodeFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 5945, 5985);

                                    f_1131_5945_5984(this, lved, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 5595, 6133);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 5595, 6133);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 6083, 6110);

                                    f_1131_6083_6109(this, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 5595, 6133);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 5085, 6133);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 4993, 6152);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1131, 1, 1160);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1131, 1, 1160);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 6172, 6500) || true) && (lved.itemDefinitionList == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 6172, 6500);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 6330, 6447);

                        f_1131_6330_6446(                    // Error at XPath {0} in file {1}: Missing definition list.
                                            this, f_1131_6347_6445(f_1131_6365_6411(), f_1131_6413_6434(this), f_1131_6436_6444()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 6469, 6481);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 6172, 6500);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 6520, 6532);

                    return lved;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1131, 4679, 6547);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1131, 4551, 6558);

                System.IDisposable
                f_1131_4686_4727(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 4686, 4727);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                f_1131_4940_4972()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 4940, 4972);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1131_5015_5043(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 5015, 5043);
                    return return_v;
                }


                bool
                f_1131_5089_5134(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 5089, 5134);
                    return return_v;
                }


                int
                f_1131_5264_5292(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 5264, 5292);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1131_5515_5544(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                appliesToNode, bool
                allowSelectionCondition)
                {
                    var return_v = this_param.LoadAppliesToSection(appliesToNode, allowSelectionCondition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 5515, 5544);
                    return return_v;
                }


                bool
                f_1131_5599_5638(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 5599, 5638);
                    return return_v;
                }


                int
                f_1131_5763_5791(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 5763, 5791);
                    return 0;
                }


                int
                f_1131_5945_5984(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                lved, System.Xml.XmlNode
                bodyNode)
                {
                    this_param.LoadListControlItemDefinitions(lved, bodyNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 5945, 5984);
                    return 0;
                }


                int
                f_1131_6083_6109(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 6083, 6109);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1131_5015_5043_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 5015, 5043);
                    return return_v;
                }


                string
                f_1131_6365_6411()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.NoDefinitionList;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 6365, 6411);
                    return return_v;
                }


                string
                f_1131_6413_6434(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 6413, 6434);
                    return return_v;
                }


                string
                f_1131_6436_6444()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 6436, 6444);
                    return return_v;
                }


                string
                f_1131_6347_6445(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 6347, 6445);
                    return return_v;
                }


                int
                f_1131_6330_6446(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 6330, 6446);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1131, 4551, 6558);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1131, 4551, 6558);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadListControlItemDefinitions(ListControlEntryDefinition lved, XmlNode bodyNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1131, 6570, 8257);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 6689, 8246);
                using (f_1131_6696_6721(this, bodyNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 6755, 6769);

                    int
                    index = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 6789, 7736);
                        foreach (XmlNode n in f_1131_6811_6830_I(f_1131_6811_6830(bodyNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 6789, 7736);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 6872, 7717) || true) && (f_1131_6876_6914(this, n, XmlTags.ListItemNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 6872, 7717);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 6964, 6972);

                                index++;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 6998, 7064);

                                ListControlItemDefinition
                                lvid = f_1131_7031_7063(this, n)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 7090, 7507) || true) && (lvid == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 7090, 7507);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 7252, 7373);

                                    f_1131_7252_7372(                            // Error at XPath {0} in file {1}: Invalid property entry.
                                                                this, f_1131_7269_7371(f_1131_7287_7337(), f_1131_7339_7360(this), f_1131_7362_7370()));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 7403, 7434);

                                    lved.itemDefinitionList = null;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 7464, 7471);

                                    return;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 7090, 7507);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 7535, 7569);

                                f_1131_7535_7568(
                                                        lved.itemDefinitionList, lvid);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 6872, 7717);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 6872, 7717);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 7667, 7694);

                                f_1131_7667_7693(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 6872, 7717);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 6789, 7736);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1131, 1, 948);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1131, 1, 948);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 7823, 8231) || true) && (f_1131_7827_7856(lved.itemDefinitionList) == 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 7823, 8231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 8006, 8121);

                        f_1131_8006_8120(                    // Error at XPath {0} in file {1}: At least one list view item must be specified.
                                            this, f_1131_8023_8119(f_1131_8041_8085(), f_1131_8087_8108(this), f_1131_8110_8118()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 8143, 8174);

                        lved.itemDefinitionList = null;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 8196, 8203);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 7823, 8231);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1131, 6689, 8246);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1131, 6570, 8257);

                System.IDisposable
                f_1131_6696_6721(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 6696, 6721);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1131_6811_6830(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 6811, 6830);
                    return return_v;
                }


                bool
                f_1131_6876_6914(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 6876, 6914);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition
                f_1131_7031_7063(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                propertyEntryNode)
                {
                    var return_v = this_param.LoadListControlItemDefinition(propertyEntryNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 7031, 7063);
                    return return_v;
                }


                string
                f_1131_7287_7337()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.InvalidPropertyEntry;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 7287, 7337);
                    return return_v;
                }


                string
                f_1131_7339_7360(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 7339, 7360);
                    return return_v;
                }


                string
                f_1131_7362_7370()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 7362, 7370);
                    return return_v;
                }


                string
                f_1131_7269_7371(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 7269, 7371);
                    return return_v;
                }


                int
                f_1131_7252_7372(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 7252, 7372);
                    return 0;
                }


                int
                f_1131_7535_7568(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 7535, 7568);
                    return 0;
                }


                int
                f_1131_7667_7693(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 7667, 7693);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1131_6811_6830_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 6811, 6830);
                    return return_v;
                }


                int
                f_1131_7827_7856(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 7827, 7856);
                    return return_v;
                }


                string
                f_1131_8041_8085()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.NoListViewItem;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 8041, 8085);
                    return return_v;
                }


                string
                f_1131_8087_8108(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 8087, 8108);
                    return return_v;
                }


                string
                f_1131_8110_8118()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 8110, 8118);
                    return return_v;
                }


                string
                f_1131_8023_8119(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 8023, 8119);
                    return return_v;
                }


                int
                f_1131_8006_8120(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 8006, 8120);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1131, 6570, 8257);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1131, 6570, 8257);
            }
        }

        private ListControlItemDefinition LoadListControlItemDefinition(XmlNode propertyEntryNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1131, 8269, 11549);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 8384, 11538);
                using (f_1131_8391_8425(this, propertyEntryNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 8531, 8587);

                    ViewEntryNodeMatch
                    match = f_1131_8558_8586(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 8605, 8658);

                    List<XmlNode>
                    unprocessedNodes = f_1131_8638_8657()
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 8676, 8839) || true) && (!f_1131_8681_8751(match, propertyEntryNode, unprocessedNodes))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 8676, 8839);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 8793, 8805);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 8676, 8839);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 8907, 8935);

                    TextToken
                    labelToken = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 8953, 8986);

                    ExpressionToken
                    condition = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 9004, 9032);

                    bool
                    labelNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 9070, 9115);

                    bool
                    itemSelectionConditionNodeFound = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 9155, 10612);
                        foreach (XmlNode n in f_1131_9177_9193_I(unprocessedNodes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 9155, 10612);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 9235, 10593) || true) && (f_1131_9239_9291(this, n, XmlTags.ItemSelectionConditionNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 9235, 10593);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 9341, 9547) || true) && (itemSelectionConditionNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 9341, 9547);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 9434, 9463);

                                    f_1131_9434_9462(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 9493, 9505);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 9341, 9547);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 9575, 9614);

                                itemSelectionConditionNodeFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 9640, 9682);

                                condition = f_1131_9652_9681(this, n);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 9708, 9841) || true) && (condition == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 9708, 9841);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 9787, 9799);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 9708, 9841);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 9235, 10593);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 9235, 10593);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 9891, 10593) || true) && (f_1131_9895_9944(this, n, XmlTags.LabelNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 9891, 10593);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 9994, 10183) || true) && (labelNodeFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 9994, 10183);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 10070, 10099);

                                        f_1131_10070_10098(this, n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 10129, 10141);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 9994, 10183);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 10211, 10233);

                                    labelNodeFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 10259, 10285);

                                    labelToken = f_1131_10272_10284(this, n);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 10311, 10445) || true) && (labelToken == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 10311, 10445);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 10391, 10403);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 10311, 10445);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 9891, 10593);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 9891, 10593);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 10543, 10570);

                                    f_1131_10543_10569(this, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 9891, 10593);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 9235, 10593);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 9155, 10612);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1131, 1, 1458);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1131, 1, 1458);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 10685, 10750);

                    ListControlItemDefinition
                    lvid = f_1131_10718_10749()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 10804, 10828);

                    lvid.label = labelToken;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 10882, 10914);

                    lvid.conditionToken = condition;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 11036, 11491) || true) && (f_1131_11040_11055(match) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 11036, 11491);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 11105, 11147);

                        f_1131_11105_11146(lvid.formatTokenList, f_1131_11130_11145(match));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 11036, 11491);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 11036, 11491);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 11229, 11279);

                        FieldPropertyToken
                        fpt = f_1131_11254_11278()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 11301, 11335);

                        fpt.expression = f_1131_11318_11334(match);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 11357, 11420);

                        fpt.fieldFormattingDirective.formatString = f_1131_11401_11419(match);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 11442, 11472);

                        f_1131_11442_11471(lvid.formatTokenList, fpt);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 11036, 11491);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 11511, 11523);

                    return lvid;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1131, 8384, 11538);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1131, 8269, 11549);

                System.IDisposable
                f_1131_8391_8425(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 8391, 8425);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                f_1131_8558_8586(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                loader)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch(loader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 8558, 8586);
                    return return_v;
                }


                System.Collections.Generic.List<System.Xml.XmlNode>
                f_1131_8638_8657()
                {
                    var return_v = new System.Collections.Generic.List<System.Xml.XmlNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 8638, 8657);
                    return return_v;
                }


                bool
                f_1131_8681_8751(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param, System.Xml.XmlNode
                containerNode, System.Collections.Generic.List<System.Xml.XmlNode>
                unprocessedNodes)
                {
                    var return_v = this_param.ProcessExpressionDirectives(containerNode, unprocessedNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 8681, 8751);
                    return return_v;
                }


                bool
                f_1131_9239_9291(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 9239, 9291);
                    return return_v;
                }


                int
                f_1131_9434_9462(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 9434, 9462);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1131_9652_9681(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                itemNode)
                {
                    var return_v = this_param.LoadItemSelectionCondition(itemNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 9652, 9681);
                    return return_v;
                }


                bool
                f_1131_9895_9944(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeNameWithAttributes(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 9895, 9944);
                    return return_v;
                }


                int
                f_1131_10070_10098(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 10070, 10098);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1131_10272_10284(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                textNode)
                {
                    var return_v = this_param.LoadLabel(textNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 10272, 10284);
                    return return_v;
                }


                int
                f_1131_10543_10569(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 10543, 10569);
                    return 0;
                }


                System.Collections.Generic.List<System.Xml.XmlNode>
                f_1131_9177_9193_I(System.Collections.Generic.List<System.Xml.XmlNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 9177, 9193);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition
                f_1131_10718_10749()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 10718, 10749);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1131_11040_11055(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param)
                {
                    var return_v = this_param.TextToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 11040, 11055);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1131_11130_11145(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param)
                {
                    var return_v = this_param.TextToken;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 11130, 11145);
                    return return_v;
                }


                int
                f_1131_11105_11146(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TextToken
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 11105, 11146);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                f_1131_11254_11278()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 11254, 11278);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1131_11318_11334(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param)
                {
                    var return_v = this_param.Expression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 11318, 11334);
                    return return_v;
                }


                string
                f_1131_11401_11419(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ViewEntryNodeMatch
                this_param)
                {
                    var return_v = this_param.FormatString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 11401, 11419);
                    return return_v;
                }


                int
                f_1131_11442_11471(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 11442, 11471);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1131, 8269, 11549);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1131, 8269, 11549);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ExpressionToken LoadItemSelectionCondition(XmlNode itemNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1131, 11561, 12660);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 11654, 12649);
                using (f_1131_11661_11686(this, itemNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 11720, 11753);

                    bool
                    expressionNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 11794, 11862);

                    ExpressionNodeMatch
                    expressionMatch = f_1131_11832_11861(this)
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 11880, 12565);
                        foreach (XmlNode n in f_1131_11902_11921_I(f_1131_11902_11921(itemNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 11880, 12565);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 11963, 12546) || true) && (f_1131_11967_11995(expressionMatch, n))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 11963, 12546);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 12045, 12239) || true) && (expressionNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 12045, 12239);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 12126, 12155);

                                    f_1131_12126_12154(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 12185, 12197);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 12045, 12239);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 12267, 12294);

                                expressionNodeFound = true;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 12320, 12398) || true) && (!f_1131_12325_12355(expressionMatch, n))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 12320, 12398);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 12386, 12398);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 12320, 12398);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 11963, 12546);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1131, 11963, 12546);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 12496, 12523);

                                f_1131_12496_12522(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 11963, 12546);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1131, 11880, 12565);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1131, 1, 686);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1131, 1, 686);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1131, 12585, 12634);

                    return f_1131_12592_12633(expressionMatch);
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1131, 11654, 12649);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1131, 11561, 12660);

                System.IDisposable
                f_1131_11661_11686(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 11661, 11686);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                f_1131_11832_11861(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                loader)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch(loader);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 11832, 11861);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1131_11902_11921(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1131, 11902, 11921);
                    return return_v;
                }


                bool
                f_1131_11967_11995(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.MatchNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 11967, 11995);
                    return return_v;
                }


                int
                f_1131_12126_12154(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 12126, 12154);
                    return 0;
                }


                bool
                f_1131_12325_12355(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.ProcessNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 12325, 12355);
                    return return_v;
                }


                int
                f_1131_12496_12522(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 12496, 12522);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1131_11902_11921_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 11902, 11921);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1131_12592_12633(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader.ExpressionNodeMatch
                this_param)
                {
                    var return_v = this_param.GenerateExpressionToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1131, 12592, 12633);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1131, 11561, 12660);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1131, 11561, 12660);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
