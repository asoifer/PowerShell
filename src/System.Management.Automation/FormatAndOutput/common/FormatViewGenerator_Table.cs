// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Internal;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class TableViewGenerator : ViewGenerator
    {
        private TableControlBody _tableBody;

        internal override void Initialize(TerminatingErrorContext terminatingErrorContext, PSPropertyExpressionFactory mshExpressionFactory, TypeInfoDataBase db, ViewDefinition view, FormattingCommandLineParameters formatParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1093, 528, 1075);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 777, 868);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Initialize(terminatingErrorContext, mshExpressionFactory, db, view, formatParameters), 1093, 777, 867);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 882, 1064) || true) && ((this.dataBaseInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1093, 886, 949) && (this.dataBaseInfo.view != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 882, 1064);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 983, 1049);

                    _tableBody = (TableControlBody)this.dataBaseInfo.view.mainControl;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 882, 1064);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1093, 528, 1075);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1093, 528, 1075);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 528, 1075);
            }
        }

        internal override void Initialize(TerminatingErrorContext errorContext, PSPropertyExpressionFactory expressionFactory,
                                                PSObject so, TypeInfoDataBase db,
                    FormattingCommandLineParameters parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1093, 1087, 3624);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 1362, 1431);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Initialize(errorContext, expressionFactory, so, db, parameters), 1093, 1362, 1430);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 1447, 1629) || true) && ((this.dataBaseInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1093, 1451, 1514) && (this.dataBaseInfo.view != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 1447, 1629);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 1548, 1614);

                    _tableBody = (TableControlBody)this.dataBaseInfo.view.mainControl;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 1447, 1629);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 1645, 1691);

                List<MshParameter>
                rawMshParameterList = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 1707, 1798) || true) && (parameters != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 1707, 1798);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 1748, 1798);

                    rawMshParameterList = parameters.mshParameterList;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 1707, 1798);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 1884, 2117) || true) && (rawMshParameterList != null && (DynAbs.Tracing.TraceSender.Expression_True(1093, 1888, 1948) && f_1093_1919_1944(rawMshParameterList) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 1884, 2117);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 1982, 2077);

                    this.activeAssociationList = f_1093_2011_2076(rawMshParameterList, so);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 2095, 2102);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 1884, 2117);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 2262, 2363);

                this.activeAssociationList = f_1093_2291_2362(so, this.expressionFactory);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 2377, 2935) || true) && (f_1093_2381_2413(this.activeAssociationList) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 2377, 2935);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 2605, 2893) || true) && (f_1093_2609_2658(so))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 2605, 2893);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 2700, 2874);

                        f_1093_2700_2873(activeAssociationList, f_1093_2726_2872(null, f_1093_2803_2871(RemotingConstants.ComputerNameNoteProperty)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 2605, 2893);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 2913, 2920);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 2377, 2935);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 3023, 3085);

                this.activeAssociationList = f_1093_3052_3084(so);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 3099, 3429) || true) && (f_1093_3103_3135(this.activeAssociationList) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 3099, 3429);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 3266, 3341);

                    f_1093_3266_3340(so, activeAssociationList);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 3359, 3389);

                    f_1093_3359_3388(this);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 3407, 3414);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 3099, 3429);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 3530, 3613);

                this.activeAssociationList = f_1093_3559_3612();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1093, 1087, 3624);

                int
                f_1093_1919_1944(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 1919, 1944);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1093_2011_2076(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                parameters, System.Management.Automation.PSObject
                target)
                {
                    var return_v = AssociationManager.ExpandTableParameters(parameters, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 2011, 2076);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1093_2291_2362(System.Management.Automation.PSObject
                target, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = AssociationManager.ExpandDefaultPropertySet(target, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 2291, 2362);
                    return return_v;
                }


                int
                f_1093_2381_2413(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 2381, 2413);
                    return return_v;
                }


                bool
                f_1093_2609_2658(System.Management.Automation.PSObject
                so)
                {
                    var return_v = PSObjectHelper.ShouldShowComputerNameProperty(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 2609, 2658);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1093_2803_2871(string
                s)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpression(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 2803, 2871);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1093_2726_2872(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                parameter, Microsoft.PowerShell.Commands.PSPropertyExpression
                expression)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation(parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 2726, 2872);
                    return return_v;
                }


                int
                f_1093_2700_2873(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 2700, 2873);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1093_3052_3084(System.Management.Automation.PSObject
                target)
                {
                    var return_v = AssociationManager.ExpandAll(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 3052, 3084);
                    return return_v;
                }


                int
                f_1093_3103_3135(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 3103, 3135);
                    return return_v;
                }


                int
                f_1093_3266_3340(System.Management.Automation.PSObject
                so, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                activeAssociationList)
                {
                    AssociationManager.HandleComputerNameProperties(so, activeAssociationList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 3266, 3340);
                    return 0;
                }


                int
                f_1093_3359_3388(Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator
                this_param)
                {
                    this_param.FilterActiveAssociationList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 3359, 3388);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1093_3559_3612()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 3559, 3612);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1093, 1087, 3624);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 1087, 3624);
            }
        }

        internal override void PrepareForRemoteObjects(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1093, 3846, 5625);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 3930, 3982);

                f_1093_3930_3981(so != null, "so cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 4054, 4257);

                f_1093_4054_4256(f_1093_4073_4130(f_1093_4073_4086(so), RemotingConstants.ComputerNameNoteProperty) != null, "PrepareForRemoteObjects cannot be called when the object does not contain ComputerName property.");

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 4273, 5614) || true) && ((dataBaseInfo != null) && (DynAbs.Tracing.TraceSender.Expression_True(1093, 4277, 4330) && (dataBaseInfo.view != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1093, 4277, 4373) && (dataBaseInfo.view.mainControl != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 4273, 5614);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 4547, 4620);

                    _tableBody = (TableControlBody)f_1093_4578_4619(this.dataBaseInfo.view.mainControl);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 4640, 4710);

                    TableRowItemDefinition
                    cnRowDefinition = f_1093_4681_4709()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 4728, 4783);

                    PropertyTokenBase
                    propToken = f_1093_4758_4782()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 4801, 4895);

                    propToken.expression = f_1093_4824_4894(RemotingConstants.ComputerNameNoteProperty, false);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 4913, 4960);

                    f_1093_4913_4959(cnRowDefinition.formatTokenList, propToken);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 4978, 5050);

                    f_1093_4978_5049(_tableBody.defaultDefinition.rowItemDefinitionList, cnRowDefinition);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 5144, 5599) || true) && (f_1093_5148_5198(_tableBody.header.columnHeaderDefinitionList) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 5144, 5599);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 5244, 5327);

                        TableColumnHeaderDefinition
                        cnHeaderDefinition = f_1093_5293_5326()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 5349, 5392);

                        cnHeaderDefinition.label = f_1093_5376_5391();
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 5414, 5489);

                        cnHeaderDefinition.label.text = RemotingConstants.ComputerNameNoteProperty;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 5511, 5580);

                        f_1093_5511_5579(_tableBody.header.columnHeaderDefinitionList, cnHeaderDefinition);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 5144, 5599);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 4273, 5614);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1093, 3846, 5625);

                int
                f_1093_3930_3981(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 3930, 3981);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1093_4073_4086(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 4073, 4086);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1093_4073_4130(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 4073, 4130);
                    return return_v;
                }


                int
                f_1093_4054_4256(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 4054, 4256);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                f_1093_4578_4619(Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                this_param)
                {
                    var return_v = this_param.Copy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 4578, 4619);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition
                f_1093_4681_4709()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 4681, 4709);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken
                f_1093_4758_4782()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FieldPropertyToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 4758, 4782);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                f_1093_4824_4894(string
                expressionValue, bool
                isScriptBlock)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken(expressionValue, isScriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 4824, 4894);
                    return return_v;
                }


                int
                f_1093_4913_4959(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.PropertyTokenBase
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatToken)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 4913, 4959);
                    return 0;
                }


                int
                f_1093_4978_5049(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 4978, 5049);
                    return 0;
                }


                int
                f_1093_5148_5198(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 5148, 5198);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition
                f_1093_5293_5326()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 5293, 5326);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TextToken
                f_1093_5376_5391()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TextToken();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 5376, 5391);
                    return return_v;
                }


                int
                f_1093_5511_5579(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 5511, 5579);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1093, 3846, 5625);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 3846, 5625);
            }
        }

        internal override FormatStartData GenerateStartData(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1093, 5637, 6066);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 5726, 5783);

                FormatStartData
                startFormat = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GenerateStartData(so), 1093, 5756, 5782)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 5799, 6022) || true) && (this.dataBaseInfo.view != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 5799, 6022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 5852, 5920);

                    startFormat.shapeInfo = f_1093_5876_5919(this, so);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 5799, 6022);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 5799, 6022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 5956, 6022);

                    startFormat.shapeInfo = f_1093_5980_6021(this, so);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 5799, 6022);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 6036, 6055);

                return startFormat;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1093, 5637, 6066);

                Microsoft.PowerShell.Commands.Internal.Format.TableHeaderInfo
                f_1093_5876_5919(Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.GenerateTableHeaderInfoFromDataBaseInfo(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 5876, 5919);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableHeaderInfo
                f_1093_5980_6021(Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.GenerateTableHeaderInfoFromProperties(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 5980, 6021);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1093, 5637, 6066);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 5637, 6066);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void FilterActiveAssociationList()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1093, 6498, 7233);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 6791, 6805);

                int
                nMax = 10
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 6821, 7199) || true) && (f_1093_6825_6852(activeAssociationList) > nMax)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 6821, 7199);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 6893, 6974);

                    List<MshResolvedExpressionParameterAssociation>
                    tmp = this.activeAssociationList
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 6992, 7075);

                    this.activeAssociationList = f_1093_7021_7074();
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7102, 7107);
                        for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7093, 7184) || true) && (k < nMax)
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7119, 7122)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 7093, 7184))

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 7093, 7184);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7145, 7184);

                            f_1093_7145_7183(this.activeAssociationList, f_1093_7176_7182(tmp, k));
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1093, 1, 92);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1093, 1, 92);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 6821, 7199);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7215, 7222);

                return;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1093, 6498, 7233);

                int
                f_1093_6825_6852(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 6825, 6852);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1093_7021_7074()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 7021, 7074);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1093_7176_7182(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 7176, 7182);
                    return return_v;
                }


                int
                f_1093_7145_7183(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 7145, 7183);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1093, 6498, 7233);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 6498, 7233);
            }
        }

        private TableHeaderInfo GenerateTableHeaderInfoFromDataBaseInfo(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1093, 7245, 9775);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7346, 7390);

                TableHeaderInfo
                thi = f_1093_7368_7389()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7406, 7417);

                bool
                dummy
                = default(bool);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7431, 7545);

                List<TableRowItemDefinition>
                activeRowItemDefinitionList = f_1093_7490_7544(this, _tableBody, so, out dummy)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7559, 7593);

                thi.hideHeader = f_1093_7576_7592(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7607, 7644);

                thi.repeatHeader = f_1093_7626_7643(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7660, 7672);

                int
                col = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7686, 9737);
                    foreach (TableRowItemDefinition rowItem in f_1093_7729_7756_I(activeRowItemDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 7686, 9737);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7790, 7833);

                        TableColumnInfo
                        ci = f_1093_7811_7832()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7851, 7896);

                        TableColumnHeaderDefinition
                        colHeader = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7914, 8057) || true) && (f_1093_7918_7968(_tableBody.header.columnHeaderDefinitionList) > 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 7914, 8057);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 7995, 8057);

                            colHeader = f_1093_8007_8056(_tableBody.header.columnHeaderDefinitionList, col);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 7914, 8057);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 8077, 8415) || true) && (colHeader != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 8077, 8415);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 8140, 8167);

                            ci.width = colHeader.width;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 8189, 8224);

                            ci.alignment = colHeader.alignment;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 8246, 8396) || true) && (colHeader.label != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 8246, 8396);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 8300, 8396);

                                ci.label = f_1093_8311_8395(this.dataBaseInfo.db.displayResourceManagerCache, colHeader.label);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 8246, 8396);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 8077, 8415);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 8435, 8572) || true) && (ci.alignment == TextAlignment.Undefined)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 8435, 8572);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 8520, 8553);

                            ci.alignment = rowItem.alignment;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 8435, 8572);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 8592, 9646) || true) && (ci.label == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 8592, 9646);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 8654, 8679);

                            FormatToken
                            token = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 8701, 8800) || true) && (f_1093_8705_8734(rowItem.formatTokenList) > 0)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 8701, 8800);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 8765, 8800);

                                token = f_1093_8773_8799(rowItem.formatTokenList, 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 8701, 8800);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 8822, 9627) || true) && (token != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 8822, 9627);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 8889, 8942);

                                FieldPropertyToken
                                fpt = token as FieldPropertyToken
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 8968, 9482) || true) && (fpt != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 8968, 9482);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 9041, 9083);

                                    ci.label = fpt.expression.expressionValue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 8968, 9482);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 8968, 9482);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 9197, 9231);

                                    TextToken
                                    tt = token as TextToken
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 9261, 9455) || true) && (tt != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 9261, 9455);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 9341, 9424);

                                        ci.label = f_1093_9352_9423(this.dataBaseInfo.db.displayResourceManagerCache, tt);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 9261, 9455);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 8968, 9482);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 8822, 9627);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 8822, 9627);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 9580, 9604);

                                ci.label = string.Empty;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 8822, 9627);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 8592, 9646);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 9666, 9698);

                        f_1093_9666_9697(
                                        thi.tableColumnInfoList, ci);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 9716, 9722);

                        col++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 7686, 9737);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1093, 1, 2052);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1093, 1, 2052);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 9753, 9764);

                return thi;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1093, 7245, 9775);

                Microsoft.PowerShell.Commands.Internal.Format.TableHeaderInfo
                f_1093_7368_7389()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableHeaderInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 7368, 7389);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                f_1093_7490_7544(Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableControlBody
                tableBody, System.Management.Automation.PSObject
                so, out bool
                multiLine)
                {
                    var return_v = this_param.GetActiveTableRowDefinition(tableBody, so, out multiLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 7490, 7544);
                    return return_v;
                }


                bool
                f_1093_7576_7592(Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator
                this_param)
                {
                    var return_v = this_param.HideHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 7576, 7592);
                    return return_v;
                }


                bool
                f_1093_7626_7643(Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator
                this_param)
                {
                    var return_v = this_param.RepeatHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 7626, 7643);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo
                f_1093_7811_7832()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 7811, 7832);
                    return return_v;
                }


                int
                f_1093_7918_7968(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 7918, 7968);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition
                f_1093_8007_8056(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnHeaderDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 8007, 8056);
                    return return_v;
                }


                string
                f_1093_8311_8395(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TextToken
                tt)
                {
                    var return_v = this_param.GetTextTokenString(tt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 8311, 8395);
                    return return_v;
                }


                int
                f_1093_8705_8734(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 8705, 8734);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatToken
                f_1093_8773_8799(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 8773, 8799);
                    return return_v;
                }


                string
                f_1093_9352_9423(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TextToken
                tt)
                {
                    var return_v = this_param.GetTextTokenString(tt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 9352, 9423);
                    return return_v;
                }


                int
                f_1093_9666_9697(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 9666, 9697);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                f_1093_7729_7756_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 7729, 7756);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1093, 7245, 9775);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 7245, 9775);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TableHeaderInfo GenerateTableHeaderInfoFromProperties(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1093, 9787, 12145);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 9886, 9930);

                TableHeaderInfo
                thi = f_1093_9908_9929()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 9946, 9980);

                thi.hideHeader = f_1093_9963_9979(this);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 10005, 10010);

                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 9996, 12107) || true) && (k < f_1093_10016_10048(this.activeAssociationList))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 10050, 10053)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 9996, 12107))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 9996, 12107);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 10087, 10163);

                        MshResolvedExpressionParameterAssociation
                        a = f_1093_10133_10162(this.activeAssociationList, k)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 10181, 10224);

                        TableColumnInfo
                        ci = f_1093_10202_10223()
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 10292, 10587) || true) && (f_1093_10296_10318(a) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 10292, 10587);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 10368, 10458);

                            object
                            key = f_1093_10381_10457(f_1093_10381_10403(a), FormatParameterDefinitionKeys.LabelEntryKey)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 10480, 10568) || true) && (key != f_1093_10491_10511())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 10480, 10568);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 10538, 10568);

                                ci.propertyName = (string)key;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 10480, 10568);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 10292, 10587);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 10607, 10773) || true) && (ci.propertyName == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 10607, 10773);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 10676, 10754);

                            ci.propertyName = f_1093_10694_10753(f_1093_10694_10742(f_1093_10694_10723(this.activeAssociationList, k)));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 10607, 10773);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 10840, 11423) || true) && (f_1093_10844_10866(a) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 10840, 11423);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 10916, 11006);

                            object
                            key = f_1093_10929_11005(f_1093_10929_10951(a), FormatParameterDefinitionKeys.WidthEntryKey)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 11030, 11264) || true) && (key != f_1093_11041_11061())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 11030, 11264);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 11088, 11108);

                                ci.width = (int)key;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 11030, 11264);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 11030, 11264);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 11183, 11196);

                                ci.width = 0;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 11030, 11264);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 10840, 11423);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 10840, 11423);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 11346, 11359);

                            ci.width = 0;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 10840, 11423);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 11481, 12040) || true) && (f_1093_11485_11507(a) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 11481, 12040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 11557, 11651);

                            object
                            key = f_1093_11570_11650(f_1093_11570_11592(a), FormatParameterDefinitionKeys.AlignmentEntryKey)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 11675, 11874) || true) && (key != f_1093_11686_11706())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 11675, 11874);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 11733, 11757);

                                ci.alignment = (int)key;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 11675, 11874);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 11675, 11874);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 11809, 11874);

                                ci.alignment = f_1093_11824_11873(so, f_1093_11852_11872(a));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 11675, 11874);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 11481, 12040);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 11481, 12040);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 11956, 12021);

                            ci.alignment = f_1093_11971_12020(so, f_1093_11999_12019(a));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 11481, 12040);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 12060, 12092);

                        f_1093_12060_12091(
                                        thi.tableColumnInfoList, ci);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1093, 1, 2112);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1093, 1, 2112);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 12123, 12134);

                return thi;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1093, 9787, 12145);

                Microsoft.PowerShell.Commands.Internal.Format.TableHeaderInfo
                f_1093_9908_9929()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableHeaderInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 9908, 9929);
                    return return_v;
                }


                bool
                f_1093_9963_9979(Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator
                this_param)
                {
                    var return_v = this_param.HideHeaders;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 9963, 9979);
                    return return_v;
                }


                int
                f_1093_10016_10048(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 10016, 10048);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1093_10133_10162(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 10133, 10162);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo
                f_1093_10202_10223()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 10202, 10223);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1093_10296_10318(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 10296, 10318);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1093_10381_10403(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 10381, 10403);
                    return return_v;
                }


                object
                f_1093_10381_10457(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                this_param, string
                key)
                {
                    var return_v = this_param.GetEntry(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 10381, 10457);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1093_10491_10511()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 10491, 10511);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1093_10694_10723(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 10694, 10723);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1093_10694_10742(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 10694, 10742);
                    return return_v;
                }


                string
                f_1093_10694_10753(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 10694, 10753);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1093_10844_10866(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 10844, 10866);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1093_10929_10951(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 10929, 10951);
                    return return_v;
                }


                object
                f_1093_10929_11005(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                this_param, string
                key)
                {
                    var return_v = this_param.GetEntry(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 10929, 11005);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1093_11041_11061()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 11041, 11061);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1093_11485_11507(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 11485, 11507);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1093_11570_11592(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 11570, 11592);
                    return return_v;
                }


                object
                f_1093_11570_11650(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                this_param, string
                key)
                {
                    var return_v = this_param.GetEntry(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 11570, 11650);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1093_11686_11706()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 11686, 11706);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1093_11852_11872(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 11852, 11872);
                    return return_v;
                }


                int
                f_1093_11824_11873(System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex)
                {
                    var return_v = ComputeDefaultAlignment(so, ex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 11824, 11873);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1093_11999_12019(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 11999, 12019);
                    return return_v;
                }


                int
                f_1093_11971_12020(System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex)
                {
                    var return_v = ComputeDefaultAlignment(so, ex);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 11971, 12020);
                    return return_v;
                }


                int
                f_1093_12060_12091(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableColumnInfo
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 12060, 12091);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1093, 9787, 12145);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 9787, 12145);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool HideHeaders
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1093, 12206, 12997);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 12312, 12737) || true) && (this.parameters != null && (DynAbs.Tracing.TraceSender.Expression_True(1093, 12316, 12382) && this.parameters.shapeParameters != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 12312, 12737);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 12424, 12521);

                        TableSpecificParameters
                        tableSpecific = (TableSpecificParameters)this.parameters.shapeParameters
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 12543, 12718) || true) && (tableSpecific != null && (DynAbs.Tracing.TraceSender.Expression_True(1093, 12547, 12606) && f_1093_12572_12606(tableSpecific.hideHeaders)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 12543, 12718);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 12656, 12695);

                            return f_1093_12663_12694(tableSpecific.hideHeaders);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 12543, 12718);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 12312, 12737);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 12818, 12949) || true) && (this.dataBaseInfo.view != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 12818, 12949);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 12894, 12930);

                        return _tableBody.header.hideHeader;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 12818, 12949);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 12969, 12982);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1093, 12206, 12997);

                    bool
                    f_1093_12572_12606(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 12572, 12606);
                        return return_v;
                    }


                    bool
                    f_1093_12663_12694(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 12663, 12694);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1093, 12157, 13008);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 12157, 13008);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool RepeatHeaders
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1093, 13071, 13279);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 13107, 13231) || true) && (this.parameters != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 13107, 13231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 13176, 13212);

                        return this.parameters.repeatHeader;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 13107, 13231);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 13251, 13264);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1093, 13071, 13279);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1093, 13020, 13290);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 13020, 13290);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private static int ComputeDefaultAlignment(PSObject so, PSPropertyExpression ex)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1093, 13302, 14183);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 13407, 13465);

                List<PSPropertyExpressionResult>
                rList = f_1093_13448_13464(ex, so)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 13481, 13580) || true) && ((f_1093_13486_13497(rList) == 0) || (DynAbs.Tracing.TraceSender.Expression_False(1093, 13485, 13535) || (f_1093_13508_13526(f_1093_13508_13516(rList, 0)) != null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 13481, 13580);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 13554, 13580);

                    return TextAlignment.Left;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 13481, 13580);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 13596, 13625);

                object
                val = f_1093_13609_13624(f_1093_13609_13617(rList, 0))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 13639, 13699) || true) && (val == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 13639, 13699);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 13673, 13699);

                    return TextAlignment.Left;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 13639, 13699);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 13715, 13757);

                PSObject
                soVal = f_1093_13732_13756(val)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 13771, 13811);

                var
                typeNames = f_1093_13787_13810(soVal)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 13825, 14022) || true) && (f_1093_13829_13977(f_1093_13843_13890(typeNames), "System.String", StringComparison.OrdinalIgnoreCase))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 13825, 14022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 13996, 14022);

                    return TextAlignment.Left;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 13825, 14022);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 14038, 14130) || true) && (f_1093_14042_14084(typeNames))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 14038, 14130);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 14103, 14130);

                    return TextAlignment.Right;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 14038, 14130);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 14146, 14172);

                return TextAlignment.Left;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1093, 13302, 14183);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                f_1093_13448_13464(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target)
                {
                    var return_v = this_param.GetValues(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 13448, 13464);
                    return return_v;
                }


                int
                f_1093_13486_13497(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 13486, 13497);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1093_13508_13516(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 13508, 13516);
                    return return_v;
                }


                System.Exception
                f_1093_13508_13526(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 13508, 13526);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1093_13609_13617(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 13609, 13617);
                    return return_v;
                }


                object
                f_1093_13609_13624(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 13609, 13624);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1093_13732_13756(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 13732, 13756);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1093_13787_13810(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 13787, 13810);
                    return return_v;
                }


                string
                f_1093_13843_13890(System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = PSObjectHelper.PSObjectIsOfExactType((System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 13843, 13890);
                    return return_v;
                }


                bool
                f_1093_13829_13977(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 13829, 13977);
                    return return_v;
                }


                bool
                f_1093_14042_14084(System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = DefaultScalarTypes.IsTypeInList((System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 14042, 14084);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1093, 13302, 14183);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 13302, 14183);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override FormatEntryData GeneratePayload(PSObject so, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1093, 14195, 15381);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 14304, 14348);

                FormatEntryData
                fed = f_1093_14326_14347()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 14364, 14382);

                TableRowEntry
                tre
                = default(TableRowEntry);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 14396, 14830) || true) && (this.dataBaseInfo.view != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 14396, 14830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 14464, 14530);

                    tre = f_1093_14470_14529(this, so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 14396, 14830);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 14396, 14830);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 14596, 14664);

                    tre = f_1093_14602_14663(this, so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 14739, 14815);

                    tre.multiLine = f_1093_14755_14814(this.dataBaseInfo.db.defaultSettingsSection);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 14396, 14830);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 14846, 14872);

                fed.formatEntryInfo = tre;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 14941, 15343) || true) && (this.parameters != null && (DynAbs.Tracing.TraceSender.Expression_True(1093, 14945, 15011) && this.parameters.shapeParameters != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 14941, 15343);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 15045, 15142);

                    TableSpecificParameters
                    tableSpecific = (TableSpecificParameters)this.parameters.shapeParameters
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 15160, 15328) || true) && (tableSpecific != null && (DynAbs.Tracing.TraceSender.Expression_True(1093, 15164, 15221) && f_1093_15189_15221(tableSpecific.multiLine)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 15160, 15328);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 15263, 15309);

                        tre.multiLine = f_1093_15279_15308(tableSpecific.multiLine);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 15160, 15328);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 14941, 15343);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 15359, 15370);

                return fed;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1093, 14195, 15381);

                Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                f_1093_14326_14347()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 14326, 14347);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableRowEntry
                f_1093_14470_14529(Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit)
                {
                    var return_v = this_param.GenerateTableRowEntryFromDataBaseInfo(so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 14470, 14529);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableRowEntry
                f_1093_14602_14663(Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit)
                {
                    var return_v = this_param.GenerateTableRowEntryFromFromProperties(so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 14602, 14663);
                    return return_v;
                }


                bool
                f_1093_14755_14814(Microsoft.PowerShell.Commands.Internal.Format.DefaultSettingsSection
                this_param)
                {
                    var return_v = this_param.MultilineTables;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 14755, 14814);
                    return return_v;
                }


                bool
                f_1093_15189_15221(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 15189, 15221);
                    return return_v;
                }


                bool
                f_1093_15279_15308(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 15279, 15308);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1093, 14195, 15381);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 14195, 15381);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private List<TableRowItemDefinition> GetActiveTableRowDefinition(TableControlBody tableBody, PSObject so,
                                                        out bool multiLine)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1093, 15393, 18861);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 15592, 15642);

                multiLine = tableBody.defaultDefinition.multiLine;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 15656, 15870) || true) && (f_1093_15660_15698(tableBody.optionalDefinitionList) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 15656, 15870);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 15798, 15855);

                    return tableBody.defaultDefinition.rowItemDefinitionList;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 15656, 15870);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 15942, 15990);

                TableRowDefinition
                matchingRowDefinition = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 16006, 16043);

                var
                typeNames = f_1093_16022_16042(so)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 16057, 16141);

                TypeMatch
                match = f_1093_16075_16140(expressionFactory, this.dataBaseInfo.db, typeNames)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 16157, 16443);
                    foreach (TableRowDefinition x in f_1093_16190_16222_I(tableBody.optionalDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 16157, 16443);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 16256, 16428) || true) && (f_1093_16260_16313(match, f_1093_16279_16312(x, x.appliesTo)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 16256, 16428);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 16355, 16381);

                            matchingRowDefinition = x;
                            DynAbs.Tracing.TraceSender.TraceBreak(1093, 16403, 16409);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 16256, 16428);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 16157, 16443);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1093, 1, 287);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1093, 1, 287);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 16459, 16603) || true) && (matchingRowDefinition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 16459, 16603);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 16526, 16588);

                    matchingRowDefinition = f_1093_16550_16565(match) as TableRowDefinition;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 16459, 16603);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 16619, 17541) || true) && (matchingRowDefinition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 16619, 17541);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 16686, 16776);

                    Collection<string>
                    typesWithoutPrefix = f_1093_16726_16775(typeNames)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 16794, 17526) || true) && (typesWithoutPrefix != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 16794, 17526);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 16866, 16949);

                        match = f_1093_16874_16948(expressionFactory, this.dataBaseInfo.db, typesWithoutPrefix);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 16973, 17315);
                            foreach (TableRowDefinition x in f_1093_17006_17038_I(tableBody.optionalDefinitionList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 16973, 17315);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 17088, 17292) || true) && (f_1093_17092_17145(match, f_1093_17111_17144(x, x.appliesTo)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 17088, 17292);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 17203, 17229);

                                    matchingRowDefinition = x;
                                    DynAbs.Tracing.TraceSender.TraceBreak(1093, 17259, 17265);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 17088, 17292);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 16973, 17315);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1093, 1, 343);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1093, 1, 343);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 17339, 17507) || true) && (matchingRowDefinition == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 17339, 17507);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 17422, 17484);

                            matchingRowDefinition = f_1093_17446_17461(match) as TableRowDefinition;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 17339, 17507);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 16794, 17526);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 16619, 17541);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 17557, 17750) || true) && (matchingRowDefinition == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 17557, 17750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 17678, 17735);

                    return tableBody.defaultDefinition.rowItemDefinitionList;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 17557, 17750);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 17833, 17931) || true) && (matchingRowDefinition.multiLine)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 17833, 17931);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 17887, 17931);

                    multiLine = matchingRowDefinition.multiLine;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 17833, 17931);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 18033, 18127);

                List<TableRowItemDefinition>
                activeRowItemDefinitionList = f_1093_18092_18126()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 18141, 18153);

                int
                col = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 18167, 18799);
                    foreach (TableRowItemDefinition rowItem in f_1093_18210_18253_I(matchingRowDefinition.rowItemDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 18167, 18799);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 18346, 18758) || true) && (f_1093_18350_18379(rowItem.formatTokenList) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 18346, 18758);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 18487, 18575);

                            f_1093_18487_18574(                    // it's a place holder, use the default
                                                activeRowItemDefinitionList, f_1093_18519_18573(tableBody.defaultDefinition.rowItemDefinitionList, col));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 18346, 18758);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 18346, 18758);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 18698, 18739);

                            f_1093_18698_18738(                    // use the override
                                                activeRowItemDefinitionList, rowItem);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 18346, 18758);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 18778, 18784);

                        col++;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 18167, 18799);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1093, 1, 633);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1093, 1, 633);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 18815, 18850);

                return activeRowItemDefinitionList;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1093, 15393, 18861);

                int
                f_1093_15660_15698(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 15660, 15698);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1093_16022_16042(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 16022, 16042);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                f_1093_16075_16140(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatch(expressionFactory, db, (System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 16075, 16140);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                f_1093_16279_16312(Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition
                obj, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                a)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem((object)obj, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 16279, 16312);
                    return return_v;
                }


                bool
                f_1093_16260_16313(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                item)
                {
                    var return_v = this_param.PerfectMatch(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 16260, 16313);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
                f_1093_16190_16222_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 16190, 16222);
                    return return_v;
                }


                object
                f_1093_16550_16565(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 16550, 16565);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1093_16726_16775(System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = Deserializer.MaskDeserializationPrefix((System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 16726, 16775);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                f_1093_16874_16948(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatch(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 16874, 16948);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                f_1093_17111_17144(Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition
                obj, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                a)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem((object)obj, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 17111, 17144);
                    return return_v;
                }


                bool
                f_1093_17092_17145(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                item)
                {
                    var return_v = this_param.PerfectMatch(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 17092, 17145);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
                f_1093_17006_17038_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 17006, 17038);
                    return return_v;
                }


                object
                f_1093_17446_17461(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 17446, 17461);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                f_1093_18092_18126()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 18092, 18126);
                    return return_v;
                }


                int
                f_1093_18350_18379(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 18350, 18379);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition
                f_1093_18519_18573(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 18519, 18573);
                    return return_v;
                }


                int
                f_1093_18487_18574(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 18487, 18574);
                    return 0;
                }


                int
                f_1093_18698_18738(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 18698, 18738);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                f_1093_18210_18253_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 18210, 18253);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1093, 15393, 18861);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 15393, 18861);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TableRowEntry GenerateTableRowEntryFromDataBaseInfo(PSObject so, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1093, 18873, 19701);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 18992, 19032);

                TableRowEntry
                tre = f_1093_19012_19031()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 19048, 19170);

                List<TableRowItemDefinition>
                activeRowItemDefinitionList = f_1093_19107_19169(this, _tableBody, so, out tre.multiLine)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 19184, 19663);
                    foreach (TableRowItemDefinition rowItem in f_1093_19227_19254_I(activeRowItemDefinitionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 19184, 19663);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 19288, 19389);

                        FormatPropertyField
                        fpf = f_1093_19314_19388(this, rowItem.formatTokenList, so, enumerationLimit)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 19557, 19591);

                        fpf.alignment = rowItem.alignment;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 19611, 19648);

                        f_1093_19611_19647(
                                        tre.formatPropertyFieldList, fpf);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 19184, 19663);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1093, 1, 480);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1093, 1, 480);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 19679, 19690);

                return tre;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1093, 18873, 19701);

                Microsoft.PowerShell.Commands.Internal.Format.TableRowEntry
                f_1093_19012_19031()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableRowEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 19012, 19031);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                f_1093_19107_19169(Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TableControlBody
                tableBody, System.Management.Automation.PSObject
                so, out bool
                multiLine)
                {
                    var return_v = this_param.GetActiveTableRowDefinition(tableBody, so, out multiLine);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 19107, 19169);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                f_1093_19314_19388(Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator
                this_param, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                formatTokenList, System.Management.Automation.PSObject
                so, int
                enumerationLimit)
                {
                    var return_v = this_param.GenerateFormatPropertyField(formatTokenList, so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 19314, 19388);
                    return return_v;
                }


                int
                f_1093_19611_19647(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 19611, 19647);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                f_1093_19227_19254_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.TableRowItemDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 19227, 19254);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1093, 18873, 19701);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 18873, 19701);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TableRowEntry GenerateTableRowEntryFromFromProperties(PSObject so, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1093, 19713, 20636);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 19834, 19874);

                TableRowEntry
                tre = f_1093_19854_19873()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 19897, 19902);
                    for (int
        k = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 19888, 20598) || true) && (k < f_1093_19908_19940(this.activeAssociationList))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 19942, 19945)
        , k++, DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 19888, 20598))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 19888, 20598);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 19979, 20031);

                        FormatPropertyField
                        fpf = f_1093_20005_20030()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 20049, 20091);

                        FieldFormattingDirective
                        directive = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 20109, 20374) || true) && (f_1093_20113_20158(f_1093_20113_20137(activeAssociationList, k)) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1093, 20109, 20374);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 20208, 20355);

                            directive = f_1093_20220_20326(f_1093_20220_20265(f_1093_20220_20244(activeAssociationList, k)), FormatParameterDefinitionKeys.FormatStringEntryKey) as FieldFormattingDirective;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1093, 20109, 20374);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 20394, 20528);

                        fpf.propertyValue = f_1093_20414_20527(this, so, enumerationLimit, f_1093_20467_20515(f_1093_20467_20496(this.activeAssociationList, k)), directive);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 20546, 20583);

                        f_1093_20546_20582(tre.formatPropertyFieldList, fpf);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1093, 1, 711);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1093, 1, 711);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 20614, 20625);

                return tre;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1093, 19713, 20636);

                Microsoft.PowerShell.Commands.Internal.Format.TableRowEntry
                f_1093_19854_19873()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableRowEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 19854, 19873);
                    return return_v;
                }


                int
                f_1093_19908_19940(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 19908, 19940);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                f_1093_20005_20030()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 20005, 20030);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1093_20113_20137(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 20113, 20137);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1093_20113_20158(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 20113, 20158);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1093_20220_20244(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 20220, 20244);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1093_20220_20265(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 20220, 20265);
                    return return_v;
                }


                object
                f_1093_20220_20326(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                this_param, string
                key)
                {
                    var return_v = this_param.GetEntry(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 20220, 20326);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1093_20467_20496(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 20467, 20496);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1093_20467_20515(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1093, 20467, 20515);
                    return return_v;
                }


                string
                f_1093_20414_20527(Microsoft.PowerShell.Commands.Internal.Format.TableViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex, Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective
                directive)
                {
                    var return_v = this_param.GetExpressionDisplayValue(so, enumerationLimit, ex, directive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 20414, 20527);
                    return return_v;
                }


                int
                f_1093_20546_20582(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1093, 20546, 20582);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1093, 19713, 20636);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 19713, 20636);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public TableViewGenerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1093, 338, 20643);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1093, 505, 515);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1093, 338, 20643);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 338, 20643);
        }


        static TableViewGenerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1093, 338, 20643);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1093, 338, 20643);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1093, 338, 20643);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1093, 338, 20643);
    }
}

