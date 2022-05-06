// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Internal;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class ListViewGenerator : ViewGenerator
    {
        private ListControlBody _listBody;

        internal override void Initialize(TerminatingErrorContext terminatingErrorContext, PSPropertyExpressionFactory mshExpressionFactory, TypeInfoDataBase db, ViewDefinition view, FormattingCommandLineParameters formatParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1092, 510, 1055);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 759, 850);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Initialize(terminatingErrorContext, mshExpressionFactory, db, view, formatParameters), 1092, 759, 849);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 864, 1044) || true) && ((this.dataBaseInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1092, 868, 931) && (this.dataBaseInfo.view != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 864, 1044);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 965, 1029);

                    _listBody = (ListControlBody)this.dataBaseInfo.view.mainControl;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 864, 1044);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1092, 510, 1055);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1092, 510, 1055);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1092, 510, 1055);
            }
        }

        internal override void Initialize(TerminatingErrorContext errorContext, PSPropertyExpressionFactory expressionFactory,
                                            PSObject so, TypeInfoDataBase db, FormattingCommandLineParameters parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1092, 1067, 1689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 1325, 1394);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Initialize(errorContext, expressionFactory, so, db, parameters), 1092, 1325, 1393);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 1408, 1588) || true) && ((this.dataBaseInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1092, 1412, 1475) && (this.dataBaseInfo.view != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 1408, 1588);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 1509, 1573);

                    _listBody = (ListControlBody)this.dataBaseInfo.view.mainControl;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 1408, 1588);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 1604, 1638);

                this.inputParameters = parameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 1652, 1678);

                f_1092_1652_1677(this, so);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1092, 1067, 1689);

                int
                f_1092_1652_1677(Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator
                this_param, System.Management.Automation.PSObject
                so)
                {
                    this_param.SetUpActiveProperties(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 1652, 1677);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1092, 1067, 1689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1092, 1067, 1689);
            }
        }

        internal override void PrepareForRemoteObjects(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1092, 1911, 3225);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 1995, 2047);

                f_1092_1995_2046(so != null, "so cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 2119, 2322);

                f_1092_2119_2321(f_1092_2138_2195(f_1092_2138_2151(so), RemotingConstants.ComputerNameNoteProperty) != null, "PrepareForRemoteObjects cannot be called when the object does not contain ComputerName property.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 2338, 3214) || true) && ((dataBaseInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1092, 2342, 2395) && (dataBaseInfo.view != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1092, 2342, 2438) && (dataBaseInfo.view.mainControl != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 2338, 3214);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 2472, 2543);

                    _listBody = (ListControlBody)f_1092_2501_2542(this.dataBaseInfo.view.mainControl);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 2624, 2705);

                    ListControlItemDefinition
                    cnListItemDefinition = f_1092_2673_2704()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 2723, 2768);

                    cnListItemDefinition.label = f_1092_2752_2767();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 2786, 2863);

                    cnListItemDefinition.label.text = RemotingConstants.ComputerNameNoteProperty;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 2881, 2931);

                    FieldPropertyToken
                    fpt = f_1092_2906_2930()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 2949, 3037);

                    fpt.expression = f_1092_2966_3036(RemotingConstants.ComputerNameNoteProperty, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 3055, 3101);

                    f_1092_3055_3100(cnListItemDefinition.formatTokenList, fpt);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 3121, 3199);

                    f_1092_3121_3198(
                                    _listBody.defaultEntryDefinition.itemDefinitionList, cnListItemDefinition);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 2338, 3214);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1092, 1911, 3225);

                int
                f_1092_1995_2046(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 1995, 2046);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1092_2138_2151(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 2138, 2151);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1092_2138_2195(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 2138, 2195);
                    return return_v;
                }


                int
                f_1092_2119_2321(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 2119, 2321);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                f_1092_2501_2542(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 2501, 2542);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition
                f_1092_2673_2704()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 2673, 2704);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1092_2752_2767()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TextToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 2752, 2767);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                f_1092_2906_2930()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 2906, 2930);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1092_2966_3036(string
                expressionValue, bool
                isScriptBlock)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken(expressionValue, isScriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 2966, 3036);
                    return return_v;
                }


                int
                f_1092_3055_3100(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 3055, 3100);
                    return 0;
                }


                int
                f_1092_3121_3198(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 3121, 3198);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1092, 1911, 3225);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1092, 1911, 3225);
            }
        }

        internal override FormatStartData GenerateStartData(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1092, 3237, 3490);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 3326, 3383);

                FormatStartData
                startFormat = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GenerateStartData(so), 1092, 3356, 3382)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 3397, 3446);

                startFormat.shapeInfo = f_1092_3421_3445();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 3460, 3479);

                return startFormat;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1092, 3237, 3490);

                Microsoft.PowerShell.Commands.Internal.Format.ListViewHeaderInfo
                f_1092_3421_3445()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListViewHeaderInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 3421, 3445);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1092, 3237, 3490);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1092, 3237, 3490);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override FormatEntryData GeneratePayload(PSObject so, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1092, 3502, 3958);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 3611, 3655);

                FormatEntryData
                fed = f_1092_3633_3654()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 3671, 3922) || true) && (this.dataBaseInfo.view != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 3671, 3922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 3724, 3806);

                    fed.formatEntryInfo = f_1092_3746_3805(this, so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 3671, 3922);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 3671, 3922);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 3842, 3922);

                    fed.formatEntryInfo = f_1092_3864_3921(this, so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 3671, 3922);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 3936, 3947);

                return fed;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1092, 3502, 3958);

                Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                f_1092_3633_3654()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 3633, 3654);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListViewEntry
                f_1092_3746_3805(Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit)
                {
                    var return_v = this_param.GenerateListViewEntryFromDataBaseInfo(so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 3746, 3805);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListViewEntry
                f_1092_3864_3921(Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit)
                {
                    var return_v = this_param.GenerateListViewEntryFromProperties(so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 3864, 3921);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1092, 3502, 3958);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1092, 3502, 3958);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ListViewEntry GenerateListViewEntryFromDataBaseInfo(PSObject so, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1092, 3970, 6578);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 4089, 4129);

                ListViewEntry
                lve = f_1092_4109_4128()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 4145, 4275);

                ListControlEntryDefinition
                activeListControlEntryDefinition =
                f_1092_4224_4274(this, _listBody, so)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 4291, 6540);
                    foreach (ListControlItemDefinition listItem in f_1092_4338_4389_I(activeListControlEntryDefinition.itemDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 4291, 6540);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 4423, 4513) || true) && (!f_1092_4428_4481(this, so, listItem.conditionToken))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 4423, 4513);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 4504, 4513);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 4423, 4513);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 4533, 4573);

                        ListViewField
                        lvf = f_1092_4553_4572()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 4591, 4625);

                        PSPropertyExpressionResult
                        result
                        = default(PSPropertyExpressionResult);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 4643, 4757);

                        lvf.formatPropertyField = f_1092_4669_4756(this, listItem.formatTokenList, so, enumerationLimit, out result);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 4828, 6474) || true) && (listItem.label != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 4828, 6474);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 4961, 5057);

                            lvf.label = f_1092_4973_5056(this.dataBaseInfo.db.displayResourceManagerCache, listItem.label);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 4828, 6474);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 4828, 6474);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 5099, 6474) || true) && (result != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 5099, 6474);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 5249, 5298);

                                lvf.label = f_1092_5261_5297(f_1092_5261_5286(result));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 5099, 6474);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 5099, 6474);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 5579, 5627);

                                FormatToken
                                token = f_1092_5599_5626(listItem.formatTokenList, 0)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 5649, 5702);

                                FieldPropertyToken
                                fpt = token as FieldPropertyToken
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 5724, 6455) || true) && (fpt != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 5724, 6455);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 5789, 5916);

                                    PSPropertyExpression
                                    ex = f_1092_5815_5915(this.expressionFactory, fpt.expression, this.dataBaseInfo.view.loadingInfo)
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 6031, 6057);

                                    lvf.label = f_1092_6043_6056(ex);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 5724, 6455);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 5724, 6455);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 6155, 6189);

                                    TextToken
                                    tt = token as TextToken
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 6215, 6432) || true) && (tt != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 6215, 6432);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 6348, 6432);

                                        lvf.label = f_1092_6360_6431(this.dataBaseInfo.db.displayResourceManagerCache, tt);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 6215, 6432);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 5724, 6455);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 5099, 6474);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 4828, 6474);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 6494, 6525);

                        f_1092_6494_6524(
                                        lve.listViewFieldList, lvf);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 4291, 6540);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1092, 1, 2250);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1092, 1, 2250);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 6556, 6567);

                return lve;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1092, 3970, 6578);

                Microsoft.PowerShell.Commands.Internal.Format.ListViewEntry
                f_1092_4109_4128()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListViewEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 4109, 4128);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                f_1092_4224_4274(Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ListControlBody
                listBody, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.GetActiveListControlEntryDefinition(listBody, so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 4224, 4274);
                    return return_v;
                }


                bool
                f_1092_4428_4481(Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator
                this_param, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                conditionToken)
                {
                    var return_v = this_param.EvaluateDisplayCondition(so, conditionToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 4428, 4481);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListViewField
                f_1092_4553_4572()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListViewField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 4553, 4572);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                f_1092_4669_4756(Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator
                this_param, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                formatTokenList, System.Management.Automation.PSObject
                so, int
                enumerationLimit, out Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                result)
                {
                    var return_v = this_param.GenerateFormatPropertyField(formatTokenList, so, enumerationLimit, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 4669, 4756);
                    return return_v;
                }


                string
                f_1092_4973_5056(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TextToken
                tt)
                {
                    var return_v = this_param.GetTextTokenString(tt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 4973, 5056);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1092_5261_5286(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 5261, 5286);
                    return return_v;
                }


                string
                f_1092_5261_5297(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 5261, 5297);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatToken
                f_1092_5599_5626(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 5599, 5626);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1092_5815_5915(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                et, Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
                loadingInfo)
                {
                    var return_v = this_param.CreateFromExpressionToken(et, loadingInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 5815, 5915);
                    return return_v;
                }


                string
                f_1092_6043_6056(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 6043, 6056);
                    return return_v;
                }


                string
                f_1092_6360_6431(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TextToken
                tt)
                {
                    var return_v = this_param.GetTextTokenString(tt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 6360, 6431);
                    return return_v;
                }


                int
                f_1092_6494_6524(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListViewField>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ListViewField
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 6494, 6524);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition>
                f_1092_4338_4389_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlItemDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 4338, 4389);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1092, 3970, 6578);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1092, 3970, 6578);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ListControlEntryDefinition GetActiveListControlEntryDefinition(ListControlBody listBody, PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1092, 6590, 8290);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 6780, 6817);

                var
                typeNames = f_1092_6796_6816(so)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 6831, 6915);

                TypeMatch
                match = f_1092_6849_6914(expressionFactory, this.dataBaseInfo.db, typeNames)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 6929, 7176);
                    foreach (ListControlEntryDefinition x in f_1092_6970_6996_I(listBody.optionalEntryList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 6929, 7176);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 7030, 7161) || true) && (f_1092_7034_7091(match, f_1092_7053_7090(x, x.appliesTo, so)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 7030, 7161);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 7133, 7142);

                            return x;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 7030, 7161);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 6929, 7176);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1092, 1, 248);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1092, 1, 248);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 7192, 8279) || true) && (f_1092_7196_7211(match) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 7192, 8279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 7253, 7306);

                    return f_1092_7260_7275(match) as ListControlEntryDefinition;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 7192, 8279);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 7192, 8279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 7372, 7462);

                    Collection<string>
                    typesWithoutPrefix = f_1092_7412_7461(typeNames)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 7480, 8144) || true) && (typesWithoutPrefix != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 7480, 8144);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 7552, 7635);

                        match = f_1092_7560_7634(expressionFactory, this.dataBaseInfo.db, typesWithoutPrefix);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 7657, 7948);
                            foreach (ListControlEntryDefinition x in f_1092_7698_7724_I(listBody.optionalEntryList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 7657, 7948);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 7774, 7925) || true) && (f_1092_7778_7831(match, f_1092_7797_7830(x, x.appliesTo)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 7774, 7925);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 7889, 7898);

                                    return x;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 7774, 7925);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 7657, 7948);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1092, 1, 292);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1092, 1, 292);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 7972, 8125) || true) && (f_1092_7976_7991(match) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 7972, 8125);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 8049, 8102);

                            return f_1092_8056_8071(match) as ListControlEntryDefinition;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 7972, 8125);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 7480, 8144);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 8225, 8264);

                    return listBody.defaultEntryDefinition;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 7192, 8279);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1092, 6590, 8290);

                System.Management.Automation.Runspaces.ConsolidatedString
                f_1092_6796_6816(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 6796, 6816);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                f_1092_6849_6914(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatch(expressionFactory, db, (System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 6849, 6914);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                f_1092_7053_7090(Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                obj, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                a, System.Management.Automation.PSObject
                currentObject)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem((object)obj, a, currentObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 7053, 7090);
                    return return_v;
                }


                bool
                f_1092_7034_7091(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                item)
                {
                    var return_v = this_param.PerfectMatch(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 7034, 7091);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition>
                f_1092_6970_6996_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 6970, 6996);
                    return return_v;
                }


                object
                f_1092_7196_7211(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 7196, 7211);
                    return return_v;
                }


                object
                f_1092_7260_7275(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 7260, 7275);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1092_7412_7461(System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = Deserializer.MaskDeserializationPrefix((System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 7412, 7461);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                f_1092_7560_7634(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatch(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 7560, 7634);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                f_1092_7797_7830(Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition
                obj, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                a)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem((object)obj, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 7797, 7830);
                    return return_v;
                }


                bool
                f_1092_7778_7831(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                item)
                {
                    var return_v = this_param.PerfectMatch(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 7778, 7831);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition>
                f_1092_7698_7724_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListControlEntryDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 7698, 7724);
                    return return_v;
                }


                object
                f_1092_7976_7991(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 7976, 7991);
                    return return_v;
                }


                object
                f_1092_8056_8071(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 8056, 8071);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1092, 6590, 8290);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1092, 6590, 8290);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ListViewEntry GenerateListViewEntryFromProperties(PSObject so, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1092, 8302, 10123);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 8472, 8585) || true) && (this.activeAssociationList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 8472, 8585);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 8544, 8570);

                    f_1092_8544_8569(this, so);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 8472, 8585);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 8601, 8641);

                ListViewEntry
                lve = f_1092_8621_8640()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 8666, 8671);

                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 8657, 10037) || true) && (k < f_1092_8677_8709(this.activeAssociationList))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 8711, 8714)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 8657, 10037))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 8657, 10037);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 8748, 8824);

                        MshResolvedExpressionParameterAssociation
                        a = f_1092_8794_8823(this.activeAssociationList, k)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 8842, 8882);

                        ListViewField
                        lvf = f_1092_8862_8881()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 8902, 9528) || true) && (f_1092_8906_8928(a) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 8902, 9528);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 8978, 9068);

                            object
                            key = f_1092_8991_9067(f_1092_8991_9013(a), FormatParameterDefinitionKeys.LabelEntryKey)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 9092, 9376) || true) && (key != f_1092_9103_9123())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 9092, 9376);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 9173, 9204);

                                lvf.propertyName = (string)key;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 9092, 9376);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 9092, 9376);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 9302, 9353);

                                lvf.propertyName = f_1092_9321_9352(f_1092_9321_9341(a));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 9092, 9376);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 8902, 9528);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 8902, 9528);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 9458, 9509);

                            lvf.propertyName = f_1092_9477_9508(f_1092_9477_9497(a));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 8902, 9528);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 9548, 9590);

                        FieldFormattingDirective
                        directive = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 9608, 9827) || true) && (f_1092_9612_9634(a) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 9608, 9827);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 9684, 9808);

                            directive = f_1092_9696_9779(f_1092_9696_9718(a), FormatParameterDefinitionKeys.FormatStringEntryKey) as FieldFormattingDirective;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 9608, 9827);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 9847, 9973);

                        lvf.formatPropertyField.propertyValue = f_1092_9887_9972(this, so, enumerationLimit, f_1092_9940_9960(a), directive);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 9991, 10022);

                        f_1092_9991_10021(lve.listViewFieldList, lvf);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1092, 1, 1381);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1092, 1, 1381);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 10053, 10087);

                this.activeAssociationList = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 10101, 10112);

                return lve;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1092, 8302, 10123);

                int
                f_1092_8544_8569(Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator
                this_param, System.Management.Automation.PSObject
                so)
                {
                    this_param.SetUpActiveProperties(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 8544, 8569);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListViewEntry
                f_1092_8621_8640()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListViewEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 8621, 8640);
                    return return_v;
                }


                int
                f_1092_8677_8709(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 8677, 8709);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1092_8794_8823(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 8794, 8823);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ListViewField
                f_1092_8862_8881()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ListViewField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 8862, 8881);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1092_8906_8928(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 8906, 8928);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1092_8991_9013(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 8991, 9013);
                    return return_v;
                }


                object
                f_1092_8991_9067(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                this_param, string
                key)
                {
                    var return_v = this_param.GetEntry(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 8991, 9067);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1092_9103_9123()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 9103, 9123);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1092_9321_9341(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 9321, 9341);
                    return return_v;
                }


                string
                f_1092_9321_9352(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 9321, 9352);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1092_9477_9497(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 9477, 9497);
                    return return_v;
                }


                string
                f_1092_9477_9508(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 9477, 9508);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1092_9612_9634(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 9612, 9634);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1092_9696_9718(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 9696, 9718);
                    return return_v;
                }


                object
                f_1092_9696_9779(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                this_param, string
                key)
                {
                    var return_v = this_param.GetEntry(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 9696, 9779);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1092_9940_9960(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1092, 9940, 9960);
                    return return_v;
                }


                string
                f_1092_9887_9972(Microsoft.PowerShell.Commands.Internal.Format.ListViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex, Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective
                directive)
                {
                    var return_v = this_param.GetExpressionDisplayValue(so, enumerationLimit, ex, directive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 9887, 9972);
                    return return_v;
                }


                int
                f_1092_9991_10021(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ListViewField>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ListViewField
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 9991, 10021);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1092, 8302, 10123);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1092, 8302, 10123);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetUpActiveProperties(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1092, 10135, 10517);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 10207, 10250);

                List<MshParameter>
                mshParameterList = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 10266, 10374) || true) && (this.inputParameters != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1092, 10266, 10374);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 10317, 10374);

                    mshParameterList = this.inputParameters.mshParameterList;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1092, 10266, 10374);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 10390, 10506);

                this.activeAssociationList = f_1092_10419_10505(mshParameterList, so, this.expressionFactory);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1092, 10135, 10517);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1092_10419_10505(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                rawMshParameterList, System.Management.Automation.PSObject
                target, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = AssociationManager.SetupActiveProperties(rawMshParameterList, target, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1092, 10419, 10505);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1092, 10135, 10517);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1092, 10135, 10517);
            }
        }

        public ListViewGenerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1092, 323, 10524);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1092, 488, 497);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1092, 323, 10524);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1092, 323, 10524);
        }


        static ListViewGenerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1092, 323, 10524);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1092, 323, 10524);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1092, 323, 10524);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1092, 323, 10524);
    }
}

