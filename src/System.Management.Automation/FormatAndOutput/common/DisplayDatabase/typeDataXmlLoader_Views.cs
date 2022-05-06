// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Xml;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed partial class TypeInfoDataBaseLoader : XmlLoaderBase
    {
        private void LoadViewDefinitions(TypeInfoDataBase db, XmlNode viewDefinitionsNode)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1133, 574, 1770);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 681, 1759);
                using (f_1133_688_724(this, viewDefinitionsNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 758, 772);

                    int
                    index = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 790, 1744);
                        foreach (XmlNode n in f_1133_812_842_I(f_1133_812_842(viewDefinitionsNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 790, 1744);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 884, 1725) || true) && (f_1133_888_922(this, n, XmlTags.ViewNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 884, 1725);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 972, 1015);

                                ViewDefinition
                                view = f_1133_994_1014(this, n, index++)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 1041, 1582) || true) && (view != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 1041, 1582);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 1115, 1400);

                                    f_1133_1115_1399(this, f_1133_1127_1398(f_1133_1141_1169(), "{0} view {1} is loaded from file {2}", f_1133_1277_1326(view.mainControl), view.name, view.loadingInfo.filePath));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 1500, 1555);

                                    f_1133_1500_1554(                            // we are fine, add the view to the list
                                                                db.viewDefinitionsSection.viewDefinitionList, view);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 1041, 1582);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 884, 1725);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 884, 1725);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 1680, 1702);

                                f_1133_1680_1701(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 884, 1725);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 790, 1744);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1133, 1, 955);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1133, 1, 955);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1133, 681, 1759);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1133, 574, 1770);

                System.IDisposable
                f_1133_688_724(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 688, 724);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1133_812_842(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1133, 812, 842);
                    return return_v;
                }


                bool
                f_1133_888_922(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 888, 922);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1133_994_1014(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                viewNode, int
                index)
                {
                    var return_v = this_param.LoadView(viewNode, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 994, 1014);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1133_1141_1169()
                {
                    var return_v = CultureInfo.InvariantCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1133, 1141, 1169);
                    return return_v;
                }


                string
                f_1133_1277_1326(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control)
                {
                    var return_v = ControlBase.GetControlShapeName(control);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 1277, 1326);
                    return return_v;
                }


                string
                f_1133_1127_1398(System.Globalization.CultureInfo
                provider, string
                format, string
                arg0, string
                arg1, string
                arg2)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0, (object)arg1, (object)arg2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 1127, 1398);
                    return return_v;
                }


                int
                f_1133_1115_1399(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportTrace(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 1115, 1399);
                    return 0;
                }


                int
                f_1133_1500_1554(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 1500, 1554);
                    return 0;
                }


                int
                f_1133_1680_1701(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 1680, 1701);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1133_812_842_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 812, 842);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1133, 574, 1770);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1133, 574, 1770);
            }
        }

        private ViewDefinition LoadView(XmlNode viewNode, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1133, 1782, 5989);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 1867, 5978);
                using (f_1133_1874_1906(this, viewNode, index))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 1981, 2024);

                    ViewDefinition
                    view = f_1133_2003_2023()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 2042, 2095);

                    List<XmlNode>
                    unprocessedNodes = f_1133_2075_2094()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 2113, 2181);

                    bool
                    success = f_1133_2128_2180(this, viewNode, view, unprocessedNodes)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 2201, 2516) || true) && (!success)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 2201, 2516);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 2334, 2448);

                        f_1133_2334_2447(                    // Error at XPath {0} in file {1}: View cannot be loaded.
                                            this, f_1133_2351_2446(f_1133_2369_2412(), f_1133_2414_2435(this), f_1133_2437_2445()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 2470, 2482);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 2201, 2516);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 2723, 2988);

                    string[]
                    controlNodeTags = new string[]
                                    {
                    XmlTags.TableControlNode,
                    XmlTags.ListControlNode,
                    XmlTags.WideControlNode,
                    XmlTags.ComplexControlNode
                                    }
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 3008, 3071);

                    List<XmlNode>
                    secondPassUnprocessedNodes = f_1133_3051_3070()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 3091, 3121);

                    bool
                    mainControlFound = false
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 3156, 5098);
                        foreach (XmlNode n in f_1133_3178_3194_I(unprocessedNodes))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 3156, 5098);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 3236, 5079) || true) && (f_1133_3240_3282(this, n, XmlTags.TableControlNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 3236, 5079);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 3332, 3503) || true) && (mainControlFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 3332, 3503);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 3410, 3434);

                                    f_1133_3410_3433(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 3464, 3476);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 3332, 3503);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 3531, 3555);

                                mainControlFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 3581, 3620);

                                view.mainControl = f_1133_3600_3619(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 3236, 5079);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 3236, 5079);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 3670, 5079) || true) && (f_1133_3674_3715(this, n, XmlTags.ListControlNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 3670, 5079);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 3765, 3936) || true) && (mainControlFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 3765, 3936);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 3843, 3867);

                                        f_1133_3843_3866(this, n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 3897, 3909);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 3765, 3936);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 3964, 3988);

                                    mainControlFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 4014, 4052);

                                    view.mainControl = f_1133_4033_4051(this, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 3670, 5079);
                                }

                                else
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 3670, 5079);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 4104, 5079) || true) && (f_1133_4108_4149(this, n, XmlTags.WideControlNode))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 4104, 5079);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 4199, 4370) || true) && (mainControlFound)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 4199, 4370);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 4277, 4301);

                                            f_1133_4277_4300(this, n);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 4331, 4343);

                                            return null;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 4199, 4370);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 4398, 4422);

                                        mainControlFound = true;
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 4448, 4486);

                                        view.mainControl = f_1133_4467_4485(this, n);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 4104, 5079);
                                    }

                                    else
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 4104, 5079);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 4536, 5079) || true) && (f_1133_4540_4584(this, n, XmlTags.ComplexControlNode))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 4536, 5079);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 4634, 4805) || true) && (mainControlFound)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 4634, 4805);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 4712, 4736);

                                                f_1133_4712_4735(this, n);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 4766, 4778);

                                                return null;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 4634, 4805);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 4833, 4857);

                                            mainControlFound = true;
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 4883, 4924);

                                            view.mainControl = f_1133_4902_4923(this, n);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 4536, 5079);
                                        }

                                        else

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 4536, 5079);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 5022, 5056);

                                            f_1133_5022_5055(secondPassUnprocessedNodes, n);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 4536, 5079);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 4104, 5079);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 3670, 5079);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 3236, 5079);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 3156, 5098);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1133, 1, 1943);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1133, 1, 1943);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 5118, 5291) || true) && (view.mainControl == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 5118, 5291);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 5188, 5229);

                        f_1133_5188_5228(this, controlNodeTags);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 5251, 5263);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 5118, 5291);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 5311, 5460) || true) && (!f_1133_5316_5378(this, secondPassUnprocessedNodes, view))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 5311, 5460);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 5420, 5432);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 5311, 5460);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 5480, 5931) || true) && (view.outOfBand && (DynAbs.Tracing.TraceSender.Expression_True(1133, 5484, 5524) && (view.groupBy != null)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 5480, 5931);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 5744, 5869);

                        f_1133_5744_5868(                    // we cannot have grouping and out of band at the same time
                                                             // Error at XPath {0} in file {1}: An Out Of Band view cannot have GroupBy.
                                            this, f_1133_5761_5867(f_1133_5779_5833(), f_1133_5835_5856(this), f_1133_5858_5866()));
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 5891, 5903);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 5480, 5931);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 5951, 5963);

                    return view;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1133, 1867, 5978);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1133, 1782, 5989);

                System.IDisposable
                f_1133_1874_1906(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 1874, 1906);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                f_1133_2003_2023()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 2003, 2023);
                    return return_v;
                }


                System.Collections.Generic.List<System.Xml.XmlNode>
                f_1133_2075_2094()
                {
                    var return_v = new System.Collections.Generic.List<System.Xml.XmlNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 2075, 2094);
                    return return_v;
                }


                bool
                f_1133_2128_2180(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                viewNode, Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                view, System.Collections.Generic.List<System.Xml.XmlNode>
                unprocessedNodes)
                {
                    var return_v = this_param.LoadCommonViewData(viewNode, view, unprocessedNodes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 2128, 2180);
                    return return_v;
                }


                string
                f_1133_2369_2412()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.ViewNotLoaded;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1133, 2369, 2412);
                    return return_v;
                }


                string
                f_1133_2414_2435(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 2414, 2435);
                    return return_v;
                }


                string
                f_1133_2437_2445()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1133, 2437, 2445);
                    return return_v;
                }


                string
                f_1133_2351_2446(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 2351, 2446);
                    return return_v;
                }


                int
                f_1133_2334_2447(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 2334, 2447);
                    return 0;
                }


                System.Collections.Generic.List<System.Xml.XmlNode>
                f_1133_3051_3070()
                {
                    var return_v = new System.Collections.Generic.List<System.Xml.XmlNode>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 3051, 3070);
                    return return_v;
                }


                bool
                f_1133_3240_3282(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 3240, 3282);
                    return return_v;
                }


                int
                f_1133_3410_3433(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 3410, 3433);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                f_1133_3600_3619(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                controlNode)
                {
                    var return_v = this_param.LoadTableControl(controlNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 3600, 3619);
                    return return_v;
                }


                bool
                f_1133_3674_3715(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 3674, 3715);
                    return return_v;
                }


                int
                f_1133_3843_3866(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 3843, 3866);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListControlBody
                f_1133_4033_4051(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                controlNode)
                {
                    var return_v = this_param.LoadListControl(controlNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 4033, 4051);
                    return return_v;
                }


                bool
                f_1133_4108_4149(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 4108, 4149);
                    return return_v;
                }


                int
                f_1133_4277_4300(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 4277, 4300);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.WideControlBody
                f_1133_4467_4485(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                controlNode)
                {
                    var return_v = this_param.LoadWideControl(controlNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 4467, 4485);
                    return return_v;
                }


                bool
                f_1133_4540_4584(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 4540, 4584);
                    return return_v;
                }


                int
                f_1133_4712_4735(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 4712, 4735);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                f_1133_4902_4923(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                controlNode)
                {
                    var return_v = this_param.LoadComplexControl(controlNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 4902, 4923);
                    return return_v;
                }


                int
                f_1133_5022_5055(System.Collections.Generic.List<System.Xml.XmlNode>
                this_param, System.Xml.XmlNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 5022, 5055);
                    return 0;
                }


                System.Collections.Generic.List<System.Xml.XmlNode>
                f_1133_3178_3194_I(System.Collections.Generic.List<System.Xml.XmlNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 3178, 3194);
                    return return_v;
                }


                int
                f_1133_5188_5228(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string[]
                names)
                {
                    this_param.ReportMissingNodes(names);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 5188, 5228);
                    return 0;
                }


                bool
                f_1133_5316_5378(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Collections.Generic.List<System.Xml.XmlNode>
                unprocessedNodes, Microsoft.PowerShell.Commands.Internal.Format.ViewDefinition
                view)
                {
                    var return_v = this_param.LoadMainControlDependentData(unprocessedNodes, view);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 5316, 5378);
                    return return_v;
                }


                string
                f_1133_5779_5833()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.OutOfBandGroupByConflict;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1133, 5779, 5833);
                    return return_v;
                }


                string
                f_1133_5835_5856(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 5835, 5856);
                    return return_v;
                }


                string
                f_1133_5858_5866()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1133, 5858, 5866);
                    return return_v;
                }


                string
                f_1133_5761_5867(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 5761, 5867);
                    return return_v;
                }


                int
                f_1133_5744_5868(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 5744, 5868);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1133, 1782, 5989);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1133, 1782, 5989);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LoadMainControlDependentData(List<XmlNode> unprocessedNodes, ViewDefinition view)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1133, 6001, 7896);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 6120, 7857);
                    foreach (XmlNode n in f_1133_6142_6158_I(unprocessedNodes))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 6120, 7857);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 6192, 6224);

                        bool
                        outOfBandNodeFound = false
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 6262, 6299);

                        bool
                        controlDefinitionsFound = false
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 6339, 7842) || true) && (f_1133_6343_6382(this, n, XmlTags.OutOfBandNode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 6339, 7842);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 6424, 6587) || true) && (outOfBandNodeFound)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 6424, 6587);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 6496, 6525);

                                f_1133_6496_6524(this, n);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 6551, 6564);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 6424, 6587);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 6611, 6637);

                            outOfBandNodeFound = true;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 6659, 6793) || true) && (!f_1133_6664_6707(this, n, out view.outOfBand))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 6659, 6793);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 6757, 6770);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 6659, 6793);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 6817, 7264) || true) && (!(view.mainControl is ComplexControlBody) && (DynAbs.Tracing.TraceSender.Expression_True(1133, 6821, 6904) && !(view.mainControl is ListControlBody)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 6817, 7264);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 7076, 7202);

                                f_1133_7076_7201(this, f_1133_7088_7200(f_1133_7106_7166(), f_1133_7168_7189(this), f_1133_7191_7199()));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 7228, 7241);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 6817, 7264);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 6339, 7842);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 6339, 7842);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 7306, 7842) || true) && (f_1133_7310_7348(this, n, XmlTags.ControlsNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 7306, 7842);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 7390, 7558) || true) && (controlDefinitionsFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 7390, 7558);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 7467, 7496);

                                    f_1133_7467_7495(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 7522, 7535);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 7390, 7558);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 7582, 7613);

                                controlDefinitionsFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 7635, 7719);

                                f_1133_7635_7718(this, n, view.formatControlDefinitionHolder.controlDefinitionList);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 7306, 7842);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 7306, 7842);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 7801, 7823);

                                f_1133_7801_7822(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 7306, 7842);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 6339, 7842);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 6120, 7857);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1133, 1, 1738);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1133, 1, 1738);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 7873, 7885);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1133, 6001, 7896);

                bool
                f_1133_6343_6382(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 6343, 6382);
                    return return_v;
                }


                int
                f_1133_6496_6524(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 6496, 6524);
                    return 0;
                }


                bool
                f_1133_6664_6707(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                collectionElement, out bool
                val)
                {
                    var return_v = this_param.ReadBooleanNode(collectionElement, out val);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 6664, 6707);
                    return return_v;
                }


                string
                f_1133_7106_7166()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.InvalidControlForOutOfBandView;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1133, 7106, 7166);
                    return return_v;
                }


                string
                f_1133_7168_7189(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 7168, 7189);
                    return return_v;
                }


                string
                f_1133_7191_7199()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1133, 7191, 7199);
                    return return_v;
                }


                string
                f_1133_7088_7200(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 7088, 7200);
                    return return_v;
                }


                int
                f_1133_7076_7201(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 7076, 7201);
                    return 0;
                }


                bool
                f_1133_7310_7348(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 7310, 7348);
                    return return_v;
                }


                int
                f_1133_7467_7495(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 7467, 7495);
                    return 0;
                }


                int
                f_1133_7635_7718(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                definitionsNode, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition>
                controlDefinitionList)
                {
                    this_param.LoadControlDefinitions(definitionsNode, controlDefinitionList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 7635, 7718);
                    return 0;
                }


                int
                f_1133_7801_7822(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 7801, 7822);
                    return 0;
                }


                System.Collections.Generic.List<System.Xml.XmlNode>
                f_1133_6142_6158_I(System.Collections.Generic.List<System.Xml.XmlNode>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 6142, 6158);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1133, 6001, 7896);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1133, 6001, 7896);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool LoadCommonViewData(XmlNode viewNode, ViewDefinition view, List<XmlNode> unprocessedNodes)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1133, 7908, 10892);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 8035, 8131) || true) && (viewNode == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 8035, 8131);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 8074, 8131);

                    throw f_1133_8080_8130("viewNode");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 8035, 8131);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 8147, 8235) || true) && (view == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 8147, 8235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 8182, 8235);

                    throw f_1133_8188_8234("view");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 8147, 8235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 8291, 8327);

                view.loadingInfo = f_1133_8310_8326(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 8341, 8393);

                view.loadingInfo.xPath = f_1133_8366_8392(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 8451, 8478);

                bool
                nameNodeFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 8521, 8553);

                bool
                appliesToNodeFound = false
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 8591, 8617);

                bool
                groupByFound = false
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 8666, 10528);
                    foreach (XmlNode n in f_1133_8688_8707_I(f_1133_8688_8707(viewNode)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 8666, 10528);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 8741, 10513) || true) && (f_1133_8745_8779(this, n, XmlTags.NameNode))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 8741, 10513);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 8821, 8979) || true) && (nameNodeFound)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 8821, 8979);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 8888, 8917);

                                f_1133_8888_8916(this, n);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 8943, 8956);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 8821, 8979);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 9003, 9024);

                            nameNodeFound = true;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 9046, 9083);

                            view.name = f_1133_9058_9082(this, n);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 9105, 9212) || true) && (view.name == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 9105, 9212);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 9176, 9189);

                                return false;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 9105, 9212);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 8741, 10513);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 8741, 10513);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 9254, 10513) || true) && (f_1133_9258_9302(this, n, XmlTags.ViewSelectedByNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 9254, 10513);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 9344, 9507) || true) && (appliesToNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 9344, 9507);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 9416, 9445);

                                    f_1133_9416_9444(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 9471, 9484);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 9344, 9507);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 9531, 9557);

                                appliesToNodeFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 9637, 9685);

                                view.appliesTo = f_1133_9654_9684(this, n, false);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 9707, 9819) || true) && (view.appliesTo == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 9707, 9819);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 9783, 9796);

                                    return false;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 9707, 9819);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 9254, 10513);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 9254, 10513);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 9861, 10513) || true) && (f_1133_9865_9902(this, n, XmlTags.GroupByNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 9861, 10513);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 9944, 10101) || true) && (groupByFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 9944, 10101);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 10010, 10039);

                                        f_1133_10010_10038(this, n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 10065, 10078);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 9944, 10101);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 10125, 10145);

                                    groupByFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 10167, 10204);

                                    view.groupBy = f_1133_10182_10203(this, n);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 10226, 10336) || true) && (view.groupBy == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 10226, 10336);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 10300, 10313);

                                        return false;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 10226, 10336);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 9861, 10513);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 9861, 10513);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 10470, 10494);

                                    f_1133_10470_10493(                    // save for further processing
                                                        unprocessedNodes, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 9861, 10513);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 9254, 10513);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 8741, 10513);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 8666, 10528);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1133, 1, 1863);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1133, 1, 1863);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 10544, 10683) || true) && (!nameNodeFound)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 10544, 10683);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 10596, 10637);

                    f_1133_10596_10636(this, XmlTags.NameNode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 10655, 10668);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 10544, 10683);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 10699, 10853) || true) && (!appliesToNodeFound)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 10699, 10853);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 10756, 10807);

                    f_1133_10756_10806(this, XmlTags.ViewSelectedByNode);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 10825, 10838);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 10699, 10853);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 10869, 10881);

                return true;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1133, 7908, 10892);

                System.Management.Automation.PSArgumentNullException
                f_1133_8080_8130(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 8080, 8130);
                    return return_v;
                }


                System.Management.Automation.PSArgumentNullException
                f_1133_8188_8234(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 8188, 8234);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
                f_1133_8310_8326(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.LoadingInfo;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1133, 8310, 8326);
                    return return_v;
                }


                string
                f_1133_8366_8392(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 8366, 8392);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1133_8688_8707(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1133, 8688, 8707);
                    return return_v;
                }


                bool
                f_1133_8745_8779(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 8745, 8779);
                    return return_v;
                }


                int
                f_1133_8888_8916(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 8888, 8916);
                    return 0;
                }


                string
                f_1133_9058_9082(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.GetMandatoryInnerText(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 9058, 9082);
                    return return_v;
                }


                bool
                f_1133_9258_9302(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 9258, 9302);
                    return return_v;
                }


                int
                f_1133_9416_9444(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 9416, 9444);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1133_9654_9684(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                appliesToNode, bool
                allowSelectionCondition)
                {
                    var return_v = this_param.LoadAppliesToSection(appliesToNode, allowSelectionCondition);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 9654, 9684);
                    return return_v;
                }


                bool
                f_1133_9865_9902(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 9865, 9902);
                    return return_v;
                }


                int
                f_1133_10010_10038(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 10010, 10038);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.GroupBy
                f_1133_10182_10203(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                groupByNode)
                {
                    var return_v = this_param.LoadGroupBySection(groupByNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 10182, 10203);
                    return return_v;
                }


                int
                f_1133_10470_10493(System.Collections.Generic.List<System.Xml.XmlNode>
                this_param, System.Xml.XmlNode
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 10470, 10493);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1133_8688_8707_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 8688, 8707);
                    return return_v;
                }


                int
                f_1133_10596_10636(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                name)
                {
                    this_param.ReportMissingNode(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 10596, 10636);
                    return 0;
                }


                int
                f_1133_10756_10806(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                name)
                {
                    this_param.ReportMissingNode(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 10756, 10806);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1133, 7908, 10892);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1133, 7908, 10892);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void LoadControlDefinitions(XmlNode definitionsNode, List<ControlDefinition> controlDefinitionList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1133, 10904, 11759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 11036, 11748);
                using (f_1133_11043_11075(this, definitionsNode))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 11109, 11140);

                    int
                    controlDefinitionIndex = 0
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 11158, 11733);
                        foreach (XmlNode n in f_1133_11180_11206_I(f_1133_11180_11206(definitionsNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 11158, 11733);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 11248, 11714) || true) && (f_1133_11252_11289(this, n, XmlTags.ControlNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 11248, 11714);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 11339, 11414);

                                ControlDefinition
                                def = f_1133_11363_11413(this, n, controlDefinitionIndex++)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 11440, 11571) || true) && (def != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 11440, 11571);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 11513, 11544);

                                    f_1133_11513_11543(controlDefinitionList, def);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 11440, 11571);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 11248, 11714);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 11248, 11714);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 11669, 11691);

                                f_1133_11669_11690(this, n);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 11248, 11714);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 11158, 11733);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1133, 1, 576);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1133, 1, 576);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1133, 11036, 11748);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1133, 10904, 11759);

                System.IDisposable
                f_1133_11043_11075(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.StackFrame(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 11043, 11075);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1133_11180_11206(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1133, 11180, 11206);
                    return return_v;
                }


                bool
                f_1133_11252_11289(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 11252, 11289);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition
                f_1133_11363_11413(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                controlDefinitionNode, int
                index)
                {
                    var return_v = this_param.LoadControlDefinition(controlDefinitionNode, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 11363, 11413);
                    return return_v;
                }


                int
                f_1133_11513_11543(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 11513, 11543);
                    return 0;
                }


                int
                f_1133_11669_11690(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 11669, 11690);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1133_11180_11206_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 11180, 11206);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1133, 10904, 11759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1133, 10904, 11759);
            }
        }

        private ControlDefinition LoadControlDefinition(XmlNode controlDefinitionNode, int index)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1133, 11771, 14385);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 11885, 14374);
                using (f_1133_11892_11937(this, controlDefinitionNode, index))
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 11971, 11998);

                    bool
                    nameNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 12041, 12071);

                    bool
                    controlNodeFound = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 12116, 12164);

                    ControlDefinition
                    def = f_1133_12140_12163()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 12184, 13941);
                        foreach (XmlNode n in f_1133_12206_12238_I(f_1133_12206_12238(controlDefinitionNode)))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 12184, 13941);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 12280, 13922) || true) && (f_1133_12284_12318(this, n, XmlTags.NameNode))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 12280, 13922);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 12368, 12538) || true) && (nameNodeFound)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 12368, 12538);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 12443, 12472);

                                    f_1133_12443_12471(this, n);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 12502, 12511);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 12368, 12538);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 12566, 12587);

                                nameNodeFound = true;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 12613, 12649);

                                def.name = f_1133_12624_12648(this, n);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 12675, 13050) || true) && (def.name == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 12675, 13050);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 12850, 12966);

                                    f_1133_12850_12965(                            // Error at XPath {0} in file {1}: Control cannot have a null Name.
                                                                this, f_1133_12867_12964(f_1133_12885_12930(), f_1133_12932_12953(this), f_1133_12955_12963()));
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 12996, 13008);

                                    return null;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 12675, 13050);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 12280, 13922);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 12280, 13922);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 13100, 13922) || true) && (f_1133_13104_13148(this, n, XmlTags.ComplexControlNode))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 13100, 13922);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 13306, 13491) || true) && (controlNodeFound)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 13306, 13491);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 13384, 13413);

                                        f_1133_13384_13412(this, n);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 13443, 13455);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 13306, 13491);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 13519, 13543);

                                    controlNodeFound = true;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 13569, 13609);

                                    def.controlBody = f_1133_13587_13608(this, n);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 13635, 13774) || true) && (def.controlBody == null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 13635, 13774);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 13720, 13732);

                                        return null;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 13635, 13774);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 13100, 13922);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 13100, 13922);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 13872, 13899);

                                    f_1133_13872_13898(this, n);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 13100, 13922);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 12280, 13922);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 12184, 13941);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1133, 1, 1758);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1133, 1, 1758);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 13961, 14126) || true) && (def.name == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 13961, 14126);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 14023, 14064);

                        f_1133_14023_14063(this, XmlTags.NameNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 14086, 14098);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 13961, 14126);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 14146, 14328) || true) && (def.controlBody == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1133, 14146, 14328);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 14215, 14266);

                        f_1133_14215_14265(this, XmlTags.ComplexControlNode);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 14288, 14300);

                        return null;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1133, 14146, 14328);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1133, 14348, 14359);

                    return def;
                    DynAbs.Tracing.TraceSender.TraceExitUsing(1133, 11885, 14374);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1133, 11771, 14385);

                System.IDisposable
                f_1133_11892_11937(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, int
                index)
                {
                    var return_v = this_param.StackFrame(n, index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 11892, 11937);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition
                f_1133_12140_12163()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 12140, 12163);
                    return return_v;
                }


                System.Xml.XmlNodeList
                f_1133_12206_12238(System.Xml.XmlNode
                this_param)
                {
                    var return_v = this_param.ChildNodes;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1133, 12206, 12238);
                    return return_v;
                }


                bool
                f_1133_12284_12318(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 12284, 12318);
                    return return_v;
                }


                int
                f_1133_12443_12471(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 12443, 12471);
                    return 0;
                }


                string
                f_1133_12624_12648(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    var return_v = this_param.GetMandatoryInnerText(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 12624, 12648);
                    return return_v;
                }


                string
                f_1133_12885_12930()
                {
                    var return_v = FormatAndOutXmlLoadingStrings.NullControlName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1133, 12885, 12930);
                    return return_v;
                }


                string
                f_1133_12932_12953(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param)
                {
                    var return_v = this_param.ComputeCurrentXPath();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 12932, 12953);
                    return return_v;
                }


                string
                f_1133_12955_12963()
                {
                    var return_v = FilePath;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1133, 12955, 12963);
                    return return_v;
                }


                string
                f_1133_12867_12964(string
                formatSpec, string
                o1, string
                o2)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o1, (object)o2);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 12867, 12964);
                    return return_v;
                }


                int
                f_1133_12850_12965(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                message)
                {
                    this_param.ReportError(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 12850, 12965);
                    return 0;
                }


                bool
                f_1133_13104_13148(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n, string
                s)
                {
                    var return_v = this_param.MatchNodeName(n, s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 13104, 13148);
                    return return_v;
                }


                int
                f_1133_13384_13412(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessDuplicateNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 13384, 13412);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                f_1133_13587_13608(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                controlNode)
                {
                    var return_v = this_param.LoadComplexControl(controlNode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 13587, 13608);
                    return return_v;
                }


                int
                f_1133_13872_13898(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, System.Xml.XmlNode
                n)
                {
                    this_param.ProcessUnknownNode(n);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 13872, 13898);
                    return 0;
                }


                System.Xml.XmlNodeList
                f_1133_12206_12238_I(System.Xml.XmlNodeList
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 12206, 12238);
                    return return_v;
                }


                int
                f_1133_14023_14063(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                name)
                {
                    this_param.ReportMissingNode(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 14023, 14063);
                    return 0;
                }


                int
                f_1133_14215_14265(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseLoader
                this_param, string
                name)
                {
                    this_param.ReportMissingNode(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1133, 14215, 14265);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1133, 11771, 14385);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1133, 11771, 14385);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }
    }
}
