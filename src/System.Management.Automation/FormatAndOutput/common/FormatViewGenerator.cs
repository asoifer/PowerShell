// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Internal;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal abstract class ViewGenerator
    {
        internal virtual void Initialize(TerminatingErrorContext terminatingErrorContext,
                                                PSPropertyExpressionFactory mshExpressionFactory,
                                                TypeInfoDataBase db,
                                                ViewDefinition view,
                                                FormattingCommandLineParameters formatParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 480, 1496);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 892, 980);

                f_1090_892_979(mshExpressionFactory != null, "mshExpressionFactory cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 994, 1046);

                f_1090_994_1045(db != null, "db cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 1060, 1116);

                f_1090_1060_1115(view != null, "view cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 1132, 1171);

                errorContext = terminatingErrorContext;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 1185, 1226);

                expressionFactory = mshExpressionFactory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 1240, 1270);

                parameters = formatParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 1286, 1307);

                dataBaseInfo.db = db;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 1321, 1346);

                dataBaseInfo.view = view;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 1360, 1450);

                dataBaseInfo.applicableTypes = f_1090_1391_1449(db, view.appliesTo);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 1466, 1485);

                f_1090_1466_1484(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 480, 1496);

                int
                f_1090_892_979(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 892, 979);
                    return 0;
                }


                int
                f_1090_994_1045(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 994, 1045);
                    return 0;
                }


                int
                f_1090_1060_1115(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 1060, 1115);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                f_1090_1391_1449(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                appliesTo)
                {
                    var return_v = DisplayDataQuery.GetAllApplicableTypes(db, appliesTo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 1391, 1449);
                    return return_v;
                }


                int
                f_1090_1466_1484(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param)
                {
                    this_param.InitializeHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 1466, 1484);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 480, 1496);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 480, 1496);
            }
        }

        internal virtual void Initialize(TerminatingErrorContext terminatingErrorContext,
                                                    PSPropertyExpressionFactory mshExpressionFactory,
                                                    PSObject so,
                                                    TypeInfoDataBase db,
                                                    FormattingCommandLineParameters formatParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 1508, 2147);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 1928, 1967);

                errorContext = terminatingErrorContext;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 1981, 2022);

                expressionFactory = mshExpressionFactory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 2036, 2066);

                parameters = formatParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 2080, 2101);

                dataBaseInfo.db = db;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 2117, 2136);

                f_1090_2117_2135(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 1508, 2147);

                int
                f_1090_2117_2135(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param)
                {
                    this_param.InitializeHelper();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 2117, 2135);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 1508, 2147);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 1508, 2147);
            }
        }

        internal virtual void PrepareForRemoteObjects(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 2461, 2541);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 2461, 2541);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 2461, 2541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 2461, 2541);
            }
        }

        private void InitializeHelper()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 2553, 2759);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 2609, 2640);

                f_1090_2609_2639(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 2654, 2674);

                f_1090_2654_2673(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 2688, 2709);

                f_1090_2688_2708(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 2723, 2748);

                f_1090_2723_2747(this);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 2553, 2759);

                int
                f_1090_2609_2639(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param)
                {
                    this_param.InitializeFormatErrorManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 2609, 2639);
                    return 0;
                }


                int
                f_1090_2654_2673(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param)
                {
                    this_param.InitializeGroupBy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 2654, 2673);
                    return 0;
                }


                int
                f_1090_2688_2708(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param)
                {
                    this_param.InitializeAutoSize();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 2688, 2708);
                    return 0;
                }


                int
                f_1090_2723_2747(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param)
                {
                    this_param.InitializeRepeatHeader();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 2723, 2747);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 2553, 2759);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 2553, 2759);
            }
        }

        private void InitializeFormatErrorManager()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 2771, 3819);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 2839, 2901);

                FormatErrorPolicy
                formatErrorPolicy = f_1090_2877_2900()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 2915, 3299) || true) && (parameters != null && (DynAbs.Tracing.TraceSender.Expression_True(1090, 2919, 2981) && f_1090_2941_2981(parameters.showErrorsAsMessages)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 2915, 3299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 3015, 3094);

                    formatErrorPolicy.ShowErrorsAsMessages = f_1090_3056_3093(parameters.showErrorsAsMessages);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 2915, 3299);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 2915, 3299);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 3160, 3284);

                    formatErrorPolicy.ShowErrorsAsMessages = f_1090_3201_3283(this.dataBaseInfo.db.defaultSettingsSection.formatErrorPolicy);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 2915, 3299);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 3315, 3734) || true) && (parameters != null && (DynAbs.Tracing.TraceSender.Expression_True(1090, 3319, 3388) && f_1090_3341_3388(parameters.showErrorsInFormattedOutput)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 3315, 3734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 3422, 3515);

                    formatErrorPolicy.ShowErrorsInFormattedOutput = f_1090_3470_3514(parameters.showErrorsInFormattedOutput);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 3315, 3734);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 3315, 3734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 3581, 3719);

                    formatErrorPolicy.ShowErrorsInFormattedOutput = f_1090_3629_3718(this.dataBaseInfo.db.defaultSettingsSection.formatErrorPolicy);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 3315, 3734);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 3750, 3808);

                _errorManager = f_1090_3766_3807(formatErrorPolicy);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 2771, 3819);

                Microsoft.PowerShell.Commands.Internal.Format.FormatErrorPolicy
                f_1090_2877_2900()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatErrorPolicy();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 2877, 2900);
                    return return_v;
                }


                bool
                f_1090_2941_2981(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 2941, 2981);
                    return return_v;
                }


                bool
                f_1090_3056_3093(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 3056, 3093);
                    return return_v;
                }


                bool
                f_1090_3201_3283(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorPolicy
                this_param)
                {
                    var return_v = this_param.ShowErrorsAsMessages;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 3201, 3283);
                    return return_v;
                }


                bool
                f_1090_3341_3388(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 3341, 3388);
                    return return_v;
                }


                bool
                f_1090_3470_3514(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 3470, 3514);
                    return return_v;
                }


                bool
                f_1090_3629_3718(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorPolicy
                this_param)
                {
                    var return_v = this_param.ShowErrorsInFormattedOutput;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 3629, 3718);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                f_1090_3766_3807(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorPolicy
                formatErrorPolicy)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager(formatErrorPolicy);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 3766, 3807);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 2771, 3819);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 2771, 3819);
            }
        }

        private void InitializeGroupBy()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 3831, 5514);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 3962, 4774) || true) && (parameters != null && (DynAbs.Tracing.TraceSender.Expression_True(1090, 3966, 4023) && parameters.groupByParameter != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 3962, 4774);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 4103, 4259);

                    PSPropertyExpression
                    groupingKeyExpression = f_1090_4148_4234(parameters.groupByParameter, FormatParameterDefinitionKeys.ExpressionEntryKey) as PSPropertyExpression
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 4313, 4333);

                    string
                    label = null
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 4351, 4451);

                    object
                    labelKey = f_1090_4369_4450(parameters.groupByParameter, FormatParameterDefinitionKeys.LabelEntryKey)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 4469, 4593) || true) && (labelKey != f_1090_4485_4505())
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 4469, 4593);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 4547, 4574);

                        label = labelKey as string;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 4469, 4593);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 4613, 4658);

                    _groupingManager = f_1090_4632_4657();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 4676, 4734);

                    f_1090_4676_4733(_groupingManager, groupingKeyExpression, label);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 4752, 4759);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 3962, 4774);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 4849, 5503) || true) && (this.dataBaseInfo.view != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 4849, 5503);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 4917, 4961);

                    GroupBy
                    gb = this.dataBaseInfo.view.groupBy
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 4979, 5061) || true) && (gb == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 4979, 5061);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 5035, 5042);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 4979, 5061);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 5081, 5210) || true) && (gb.startGroup == null || (DynAbs.Tracing.TraceSender.Expression_False(1090, 5085, 5142) || gb.startGroup.expression == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 5081, 5210);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 5184, 5191);

                        return;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 5081, 5210);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 5230, 5367);

                    PSPropertyExpression
                    ex = f_1090_5256_5366(this.expressionFactory, gb.startGroup.expression, this.dataBaseInfo.view.loadingInfo)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 5387, 5432);

                    _groupingManager = f_1090_5406_5431();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 5450, 5488);

                    f_1090_5450_5487(_groupingManager, ex, null);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 4849, 5503);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 3831, 5514);

                object
                f_1090_4148_4234(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                this_param, string
                key)
                {
                    var return_v = this_param.GetEntry(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 4148, 4234);
                    return return_v;
                }


                object
                f_1090_4369_4450(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                this_param, string
                key)
                {
                    var return_v = this_param.GetEntry(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 4369, 4450);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1090_4485_4505()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 4485, 4505);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.GroupingInfoManager
                f_1090_4632_4657()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.GroupingInfoManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 4632, 4657);
                    return return_v;
                }


                int
                f_1090_4676_4733(Microsoft.PowerShell.Commands.Internal.Format.GroupingInfoManager
                this_param, Microsoft.PowerShell.Commands.PSPropertyExpression
                groupingExpression, string
                displayLabel)
                {
                    this_param.Initialize(groupingExpression, displayLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 4676, 4733);
                    return 0;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1090_5256_5366(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                et, Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
                loadingInfo)
                {
                    var return_v = this_param.CreateFromExpressionToken(et, loadingInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 5256, 5366);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.GroupingInfoManager
                f_1090_5406_5431()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.GroupingInfoManager();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 5406, 5431);
                    return return_v;
                }


                int
                f_1090_5450_5487(Microsoft.PowerShell.Commands.Internal.Format.GroupingInfoManager
                this_param, Microsoft.PowerShell.Commands.PSPropertyExpression
                groupingExpression, string
                displayLabel)
                {
                    this_param.Initialize(groupingExpression, displayLabel);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 5450, 5487);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 3831, 5514);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 3831, 5514);
            }
        }

        private void InitializeAutoSize()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 5526, 6262);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 5630, 5796) || true) && (parameters != null && (DynAbs.Tracing.TraceSender.Expression_True(1090, 5634, 5684) && f_1090_5656_5684(parameters.autosize)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 5630, 5796);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 5718, 5756);

                    _autosize = f_1090_5730_5755(parameters.autosize);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 5774, 5781);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 5630, 5796);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 5872, 6251) || true) && (this.dataBaseInfo.view != null && (DynAbs.Tracing.TraceSender.Expression_True(1090, 5876, 5952) && this.dataBaseInfo.view.mainControl != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 5872, 6251);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 5986, 6062);

                    ControlBody
                    controlBody = this.dataBaseInfo.view.mainControl as ControlBody
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 6080, 6236) || true) && (controlBody != null && (DynAbs.Tracing.TraceSender.Expression_True(1090, 6084, 6136) && f_1090_6107_6136(controlBody.autosize)))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 6080, 6236);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 6178, 6217);

                        _autosize = f_1090_6190_6216(controlBody.autosize);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 6080, 6236);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 5872, 6251);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 5526, 6262);

                bool
                f_1090_5656_5684(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 5656, 5684);
                    return return_v;
                }


                bool
                f_1090_5730_5755(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 5730, 5755);
                    return return_v;
                }


                bool
                f_1090_6107_6136(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 6107, 6136);
                    return return_v;
                }


                bool
                f_1090_6190_6216(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 6190, 6216);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 5526, 6262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 5526, 6262);
            }
        }

        private void InitializeRepeatHeader()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 6274, 6458);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 6336, 6447) || true) && (parameters != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 6336, 6447);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 6392, 6432);

                    _repeatHeader = parameters.repeatHeader;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 6336, 6447);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 6274, 6458);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 6274, 6458);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 6274, 6458);
            }
        }

        internal virtual FormatStartData GenerateStartData(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 6470, 6780);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 6558, 6610);

                FormatStartData
                startFormat = f_1090_6588_6609()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 6626, 6734) || true) && (_autosize)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 6626, 6734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 6673, 6719);

                    startFormat.autosizeInfo = f_1090_6700_6718();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 6626, 6734);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 6750, 6769);

                return startFormat;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 6470, 6780);

                Microsoft.PowerShell.Commands.Internal.Format.FormatStartData
                f_1090_6588_6609()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatStartData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 6588, 6609);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.AutosizeInfo
                f_1090_6700_6718()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.AutosizeInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 6700, 6718);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 6470, 6780);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 6470, 6780);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal abstract FormatEntryData GeneratePayload(PSObject so, int enumerationLimit);

        internal GroupStartData GenerateGroupStartData(PSObject firstObjectInGroup, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 6889, 11464);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 7011, 7060);

                GroupStartData
                startGroup = f_1090_7039_7059()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 7074, 7139) || true) && (_groupingManager == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 7074, 7139);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 7121, 7139);

                    return startGroup;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 7074, 7139);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 7155, 7234);

                object
                currentGroupingValue = f_1090_7185_7233(_groupingManager)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 7250, 7335) || true) && (currentGroupingValue == f_1090_7278_7298())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 7250, 7335);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 7317, 7335);

                    return startGroup;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 7250, 7335);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 7351, 7413);

                PSObject
                so = f_1090_7365_7412(currentGroupingValue)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 7498, 7525);

                ControlBase
                control = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 7539, 7571);

                TextToken
                labelTextToken = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 7585, 8102) || true) && (this.dataBaseInfo.view != null && (DynAbs.Tracing.TraceSender.Expression_True(1090, 7589, 7661) && this.dataBaseInfo.view.groupBy != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 7585, 8102);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 7695, 8087) || true) && (this.dataBaseInfo.view.groupBy.startGroup != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 7695, 8087);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 7912, 7972);

                        control = this.dataBaseInfo.view.groupBy.startGroup.control;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 7994, 8068);

                        labelTextToken = this.dataBaseInfo.view.groupBy.startGroup.labelTextToken;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 7695, 8087);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 7585, 8102);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 8118, 8165);

                startGroup.groupingEntry = f_1090_8145_8164();

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 8181, 11419) || true) && (control == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 8181, 11419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 8362, 8405);

                    StringFormatError
                    formatErrorObject = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 8423, 8730) || true) && (f_1090_8427_8465(_errorManager))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 8423, 8730);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 8667, 8711);

                        formatErrorObject = f_1090_8687_8710();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 8423, 8730);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 8750, 8881);

                    string
                    currentGroupingValueDisplay = f_1090_8787_8880(so, this.expressionFactory, enumerationLimit, formatErrorObject)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 8901, 9441) || true) && (formatErrorObject != null && (DynAbs.Tracing.TraceSender.Expression_True(1090, 8905, 8969) && formatErrorObject.exception != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 8901, 9441);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 9169, 9223);

                        f_1090_9169_9222(                    // if we did no thave any errors in the expression evaluation
                                                             // we might have errors in the formatting, if present
                                            _errorManager, formatErrorObject);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 9245, 9422) || true) && (f_1090_9249_9287(_errorManager))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 9245, 9422);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 9337, 9399);

                            currentGroupingValueDisplay = f_1090_9367_9398(_errorManager);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 9245, 9422);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 8901, 9441);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 9461, 9496);

                    FormatEntry
                    fe = f_1090_9478_9495()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 9514, 9563);

                    f_1090_9514_9562(startGroup.groupingEntry.formatValueList, fe);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 9583, 9627);

                    FormatTextField
                    ftf = f_1090_9605_9626()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 9857, 9870);

                    string
                    label
                    = default(string);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 9888, 10121) || true) && (labelTextToken != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 9888, 10121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 9937, 10029);

                        label = f_1090_9945_10028(this.dataBaseInfo.db.displayResourceManagerCache, labelTextToken);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 9888, 10121);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 9888, 10121);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 10073, 10121);

                        label = f_1090_10081_10120(_groupingManager);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 9888, 10121);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 10141, 10243);

                    ftf.text = f_1090_10152_10242(f_1090_10170_10234(), label);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 10263, 10291);

                    f_1090_10263_10290(
                                    fe.formatValueList, ftf);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 10311, 10363);

                    FormatPropertyField
                    fpf = f_1090_10337_10362()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 10383, 10431);

                    fpf.propertyValue = currentGroupingValueDisplay;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 10449, 10477);

                    f_1090_10449_10476(fe.formatValueList, fpf);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 8181, 11419);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 8181, 11419);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 10629, 10657);

                    const int
                    maxTreeDepth = 50
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 10675, 11239);

                    ComplexControlGenerator
                    controlGenerator =
                    f_1090_10751_11238(this.dataBaseInfo.db, this.dataBaseInfo.view.loadingInfo, this.expressionFactory, this.dataBaseInfo.view.formatControlDefinitionHolder.controlDefinitionList, f_1090_11101_11118(this), enumerationLimit, this.errorContext)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 11259, 11404);

                    f_1090_11259_11403(
                                    controlGenerator, maxTreeDepth, control, firstObjectInGroup, startGroup.groupingEntry.formatValueList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 8181, 11419);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 11435, 11453);

                return startGroup;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 6889, 11464);

                Microsoft.PowerShell.Commands.Internal.Format.GroupStartData
                f_1090_7039_7059()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.GroupStartData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 7039, 7059);
                    return return_v;
                }


                object
                f_1090_7185_7233(Microsoft.PowerShell.Commands.Internal.Format.GroupingInfoManager
                this_param)
                {
                    var return_v = this_param.CurrentGroupingKeyPropertyValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 7185, 7233);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1090_7278_7298()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 7278, 7298);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1090_7365_7412(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 7365, 7412);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.GroupingEntry
                f_1090_8145_8164()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.GroupingEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 8145, 8164);
                    return return_v;
                }


                bool
                f_1090_8427_8465(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.DisplayFormatErrorString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 8427, 8465);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                f_1090_8687_8710()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.StringFormatError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 8687, 8710);
                    return return_v;
                }


                string
                f_1090_8787_8880(System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, int
                enumerationLimit, Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                formatErrorObject)
                {
                    var return_v = PSObjectHelper.SmartToString(so, expressionFactory, enumerationLimit, formatErrorObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 8787, 8880);
                    return return_v;
                }


                int
                f_1090_9169_9222(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param, Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                error)
                {
                    this_param.LogStringFormatError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 9169, 9222);
                    return 0;
                }


                bool
                f_1090_9249_9287(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.DisplayFormatErrorString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 9249, 9287);
                    return return_v;
                }


                string
                f_1090_9367_9398(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.FormatErrorString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 9367, 9398);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                f_1090_9478_9495()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 9478, 9495);
                    return return_v;
                }


                int
                f_1090_9514_9562(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 9514, 9562);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatTextField
                f_1090_9605_9626()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatTextField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 9605, 9626);
                    return return_v;
                }


                string
                f_1090_9945_10028(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TextToken
                tt)
                {
                    var return_v = this_param.GetTextTokenString(tt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 9945, 10028);
                    return return_v;
                }


                string
                f_1090_10081_10120(Microsoft.PowerShell.Commands.Internal.Format.GroupingInfoManager
                this_param)
                {
                    var return_v = this_param.GroupingKeyDisplayName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 10081, 10120);
                    return return_v;
                }


                string
                f_1090_10170_10234()
                {
                    var return_v = FormatAndOut_format_xxx.GroupStartDataIndentedAutoGeneratedLabel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 10170, 10234);
                    return return_v;
                }


                string
                f_1090_10152_10242(string
                formatSpec, string
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 10152, 10242);
                    return return_v;
                }


                int
                f_1090_10263_10290(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatTextField
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 10263, 10290);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                f_1090_10337_10362()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 10337, 10362);
                    return return_v;
                }


                int
                f_1090_10449_10476(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 10449, 10476);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                f_1090_11101_11118(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param)
                {
                    var return_v = this_param.ErrorManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 11101, 11118);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlGenerator
                f_1090_10751_11238(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                dataBase, Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
                loadingInfo, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition>
                controlDefinitionList, Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                resultErrorManager, int
                enumerationLimit, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexControlGenerator(dataBase, loadingInfo, expressionFactory, controlDefinitionList, resultErrorManager, enumerationLimit, errorContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 10751, 11238);
                    return return_v;
                }


                int
                f_1090_11259_11403(Microsoft.PowerShell.Commands.Internal.Format.ComplexControlGenerator
                this_param, int
                maxTreeDepth, Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control, System.Management.Automation.PSObject
                so, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.GenerateFormatEntries(maxTreeDepth, control, so, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 11259, 11403);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 6889, 11464);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 6889, 11464);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool UpdateGroupingKeyValue(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 11720, 11930);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 11794, 11854) || true) && (_groupingManager == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 11794, 11854);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 11841, 11854);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 11794, 11854);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 11868, 11919);

                return f_1090_11875_11918(_groupingManager, so);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 11720, 11930);

                bool
                f_1090_11875_11918(Microsoft.PowerShell.Commands.Internal.Format.GroupingInfoManager
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.UpdateGroupingKeyValue(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 11875, 11918);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 11720, 11930);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 11720, 11930);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal GroupEndData GenerateGroupEndData()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 11942, 12048);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 12011, 12037);

                return f_1090_12018_12036();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 11942, 12048);

                Microsoft.PowerShell.Commands.Internal.Format.GroupEndData
                f_1090_12018_12036()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.GroupEndData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 12018, 12036);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 11942, 12048);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 11942, 12048);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal bool IsObjectApplicable(Collection<string> typeNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 12060, 13118);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 12147, 12207) || true) && (dataBaseInfo.view == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 12147, 12207);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 12195, 12207);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 12147, 12207);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 12223, 12279) || true) && (f_1090_12227_12242(typeNames) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 12223, 12279);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 12266, 12279);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 12223, 12279);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 12295, 12374);

                TypeMatch
                match = f_1090_12313_12373(expressionFactory, dataBaseInfo.db, typeNames)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 12388, 12526) || true) && (f_1090_12392_12465(match, f_1090_12411_12464(this, dataBaseInfo.applicableTypes)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 12388, 12526);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 12499, 12511);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 12388, 12526);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 12542, 12580);

                bool
                result = f_1090_12556_12571(match) != null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 12762, 13077) || true) && (false == result)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 12762, 13077);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 12815, 12905);

                    Collection<string>
                    typesWithoutPrefix = f_1090_12855_12904(typeNames)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 12923, 13062) || true) && (typesWithoutPrefix != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 12923, 13062);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 12995, 13043);

                        result = f_1090_13004_13042(this, typesWithoutPrefix);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 12923, 13062);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 12762, 13077);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 13093, 13107);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 12060, 13118);

                int
                f_1090_12227_12242(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 12227, 12242);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                f_1090_12313_12373(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatch(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 12313, 12373);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                f_1090_12411_12464(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                obj, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                a)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem((object)obj, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 12411, 12464);
                    return return_v;
                }


                bool
                f_1090_12392_12465(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                item)
                {
                    var return_v = this_param.PerfectMatch(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 12392, 12465);
                    return return_v;
                }


                object
                f_1090_12556_12571(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 12556, 12571);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1090_12855_12904(System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = Deserializer.MaskDeserializationPrefix(typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 12855, 12904);
                    return return_v;
                }


                bool
                f_1090_13004_13042(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = this_param.IsObjectApplicable(typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 13004, 13042);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 12060, 13118);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 12060, 13118);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private GroupingInfoManager _groupingManager;

        protected bool AutoSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 13242, 13267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 13248, 13265);

                    return _autosize;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 13242, 13267);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 13194, 13278);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 13194, 13278);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _autosize;

        protected bool RepeatHeader
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 13385, 13414);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 13391, 13412);

                    return _repeatHeader;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 13385, 13414);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 13333, 13425);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 13333, 13425);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool _repeatHeader;
        protected class DataBaseInfo
        {
            internal TypeInfoDataBase db;

            internal ViewDefinition view;

            internal AppliesTo applicableTypes;

            public DataBaseInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1090, 13484, 13690);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 13563, 13572);
                this.db = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 13611, 13622);
                this.view = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 13656, 13678);
                this.applicableTypes = null;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1090, 13484, 13690);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 13484, 13690);
            }


            static DataBaseInfo()
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1090, 13484, 13690);
                DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1090, 13484, 13690);

                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 13484, 13690);
            }

            int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1090, 13484, 13690);
        }

        protected TerminatingErrorContext errorContext;

        protected FormattingCommandLineParameters parameters;

        protected PSPropertyExpressionFactory expressionFactory;

        protected DataBaseInfo dataBaseInfo;

        protected List<MshResolvedExpressionParameterAssociation> activeAssociationList;

        protected FormattingCommandLineParameters inputParameters;

        protected string GetExpressionDisplayValue(PSObject so, int enumerationLimit, PSPropertyExpression ex,
                            FieldFormattingDirective directive)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 14137, 14486);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 14321, 14367);

                PSPropertyExpressionResult
                resolvedExpression
                = default(PSPropertyExpressionResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 14381, 14475);

                return f_1090_14388_14474(this, so, enumerationLimit, ex, directive, out resolvedExpression);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 14137, 14486);

                string
                f_1090_14388_14474(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex, Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective
                directive, out Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                expressionResult)
                {
                    var return_v = this_param.GetExpressionDisplayValue(so, enumerationLimit, ex, directive, out expressionResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 14388, 14474);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 14137, 14486);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 14137, 14486);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected string GetExpressionDisplayValue(PSObject so, int enumerationLimit, PSPropertyExpression ex,
                            FieldFormattingDirective directive, out PSPropertyExpressionResult expressionResult)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 14498, 16356);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 14731, 14774);

                StringFormatError
                formatErrorObject = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 14788, 15075) || true) && (f_1090_14792_14830(_errorManager))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 14788, 15075);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 15016, 15060);

                    formatErrorObject = f_1090_15036_15059();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 14788, 15075);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 15091, 15278);

                string
                retVal = f_1090_15107_15277(so, enumerationLimit, ex, directive, formatErrorObject, expressionFactory, out expressionResult)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 15294, 16315) || true) && (expressionResult != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 15294, 16315);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 15425, 16300) || true) && (f_1090_15429_15455(expressionResult) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 15425, 16300);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 15505, 15577);

                        f_1090_15505_15576(_errorManager, expressionResult, so);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 15599, 15744) || true) && (f_1090_15603_15636(_errorManager))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 15599, 15744);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 15686, 15721);

                            retVal = f_1090_15695_15720(_errorManager);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 15599, 15744);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 15425, 16300);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 15425, 16300);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 15786, 16300) || true) && (formatErrorObject != null && (DynAbs.Tracing.TraceSender.Expression_True(1090, 15790, 15854) && formatErrorObject.exception != null))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 15786, 16300);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 16054, 16108);

                            f_1090_16054_16107(                    // if we did no thave any errors in the expression evaluation
                                                                   // we might have errors in the formatting, if present
                                                _errorManager, formatErrorObject);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 16130, 16281) || true) && (f_1090_16134_16167(_errorManager))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 16130, 16281);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 16217, 16258);

                                retVal = f_1090_16226_16257(_errorManager);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 16130, 16281);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 15786, 16300);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 15425, 16300);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 15294, 16315);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 16331, 16345);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 14498, 16356);

                bool
                f_1090_14792_14830(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.DisplayFormatErrorString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 14792, 14830);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                f_1090_15036_15059()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.StringFormatError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 15036, 15059);
                    return return_v;
                }


                string
                f_1090_15107_15277(System.Management.Automation.PSObject
                so, int
                enumerationLimit, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex, Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective
                directive, Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                formatErrorObject, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, out Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                result)
                {
                    var return_v = PSObjectHelper.GetExpressionDisplayValue(so, enumerationLimit, ex, directive, formatErrorObject, expressionFactory, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 15107, 15277);
                    return return_v;
                }


                System.Exception
                f_1090_15429_15455(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 15429, 15455);
                    return return_v;
                }


                int
                f_1090_15505_15576(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param, Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                result, System.Management.Automation.PSObject
                sourceObject)
                {
                    this_param.LogPSPropertyExpressionFailedResult(result, (object)sourceObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 15505, 15576);
                    return 0;
                }


                bool
                f_1090_15603_15636(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.DisplayErrorStrings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 15603, 15636);
                    return return_v;
                }


                string
                f_1090_15695_15720(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.ErrorString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 15695, 15720);
                    return return_v;
                }


                int
                f_1090_16054_16107(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param, Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                error)
                {
                    this_param.LogStringFormatError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 16054, 16107);
                    return 0;
                }


                bool
                f_1090_16134_16167(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.DisplayErrorStrings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 16134, 16167);
                    return return_v;
                }


                string
                f_1090_16226_16257(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.FormatErrorString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 16226, 16257);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 14498, 16356);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 14498, 16356);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected bool EvaluateDisplayCondition(PSObject so, ExpressionToken conditionToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 16368, 17063);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 16477, 16534) || true) && (conditionToken == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 16477, 16534);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 16522, 16534);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 16477, 16534);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 16550, 16677);

                PSPropertyExpression
                ex = f_1090_16576_16676(this.expressionFactory, conditionToken, this.dataBaseInfo.view.loadingInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 16691, 16735);

                PSPropertyExpressionResult
                expressionResult
                = default(PSPropertyExpressionResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 16749, 16819);

                bool
                retVal = f_1090_16763_16818(so, ex, out expressionResult)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 16835, 17022) || true) && (expressionResult != null && (DynAbs.Tracing.TraceSender.Expression_True(1090, 16839, 16901) && f_1090_16867_16893(expressionResult) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 16835, 17022);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 16935, 17007);

                    f_1090_16935_17006(_errorManager, expressionResult, so);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 16835, 17022);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 17038, 17052);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 16368, 17063);

                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1090_16576_16676(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                et, Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
                loadingInfo)
                {
                    var return_v = this_param.CreateFromExpressionToken(et, loadingInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 16576, 16676);
                    return return_v;
                }


                bool
                f_1090_16763_16818(System.Management.Automation.PSObject
                obj, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex, out Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                expressionResult)
                {
                    var return_v = DisplayCondition.Evaluate(obj, ex, out expressionResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 16763, 16818);
                    return return_v;
                }


                System.Exception
                f_1090_16867_16893(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 16867, 16893);
                    return return_v;
                }


                int
                f_1090_16935_17006(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param, Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                result, System.Management.Automation.PSObject
                sourceObject)
                {
                    this_param.LogPSPropertyExpressionFailedResult(result, (object)sourceObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 16935, 17006);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 16368, 17063);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 16368, 17063);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal FormatErrorManager ErrorManager
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 17140, 17169);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 17146, 17167);

                    return _errorManager;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 17140, 17169);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 17075, 17180);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 17075, 17180);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private FormatErrorManager _errorManager;

        protected FormatPropertyField GenerateFormatPropertyField(List<FormatToken> formatTokenList, PSObject so, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 17272, 17569);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 17424, 17458);

                PSPropertyExpressionResult
                result
                = default(PSPropertyExpressionResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 17472, 17558);

                return f_1090_17479_17557(this, formatTokenList, so, enumerationLimit, out result);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 17272, 17569);

                Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                f_1090_17479_17557(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                formatTokenList, System.Management.Automation.PSObject
                so, int
                enumerationLimit, out Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                result)
                {
                    var return_v = this_param.GenerateFormatPropertyField(formatTokenList, so, enumerationLimit, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 17479, 17557);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 17272, 17569);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 17272, 17569);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected FormatPropertyField GenerateFormatPropertyField(List<FormatToken> formatTokenList, PSObject so, int enumerationLimit, out PSPropertyExpressionResult result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1090, 17581, 18825);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 17772, 17786);

                result = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 17800, 17852);

                FormatPropertyField
                fpf = f_1090_17826_17851()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 17866, 18787) || true) && (f_1090_17870_17891(formatTokenList) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 17866, 18787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 17930, 17969);

                    FormatToken
                    token = f_1090_17950_17968(formatTokenList, 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 17987, 18040);

                    FieldPropertyToken
                    fpt = token as FieldPropertyToken
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 18058, 18673) || true) && (fpt != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 18058, 18673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 18115, 18242);

                        PSPropertyExpression
                        ex = f_1090_18141_18241(this.expressionFactory, fpt.expression, this.dataBaseInfo.view.loadingInfo)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 18264, 18383);

                        fpf.propertyValue = f_1090_18284_18382(this, so, enumerationLimit, ex, fpt.fieldFormattingDirective, out result);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 18058, 18673);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 18058, 18673);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 18465, 18499);

                        TextToken
                        tt = token as TextToken
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 18521, 18654) || true) && (tt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 18521, 18654);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 18562, 18654);

                            fpf.propertyValue = f_1090_18582_18653(this.dataBaseInfo.db.displayResourceManagerCache, tt);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 18521, 18654);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 18058, 18673);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 17866, 18787);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1090, 17866, 18787);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 18739, 18772);

                    fpf.propertyValue = string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1090, 17866, 18787);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 18803, 18814);

                return fpf;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1090, 17581, 18825);

                Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                f_1090_17826_17851()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 17826, 17851);
                    return return_v;
                }


                int
                f_1090_17870_17891(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 17870, 17891);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatToken
                f_1090_17950_17968(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1090, 17950, 17968);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1090_18141_18241(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                et, Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
                loadingInfo)
                {
                    var return_v = this_param.CreateFromExpressionToken(et, loadingInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 18141, 18241);
                    return return_v;
                }


                string
                f_1090_18284_18382(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex, Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective
                directive, out Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                expressionResult)
                {
                    var return_v = this_param.GetExpressionDisplayValue(so, enumerationLimit, ex, directive, out expressionResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 18284, 18382);
                    return return_v;
                }


                string
                f_1090_18582_18653(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TextToken
                tt)
                {
                    var return_v = this_param.GetTextTokenString(tt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 18582, 18653);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1090, 17581, 18825);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 17581, 18825);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ViewGenerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1090, 426, 18854);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 13158, 13181);
            this._groupingManager = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 13303, 13320);
            this._autosize = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 13450, 13471);
            this._repeatHeader = false;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 13736, 13748);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 13803, 13813);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 13864, 13881);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 13917, 13950);
            this.dataBaseInfo = f_1090_13932_13950();
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 14021, 14049);
            this.activeAssociationList = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 14102, 14124);
            this.inputParameters = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1090, 17219, 17232);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1090, 426, 18854);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 426, 18854);
        }


        static ViewGenerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1090, 426, 18854);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1090, 426, 18854);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1090, 426, 18854);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1090, 426, 18854);

        Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator.DataBaseInfo
        f_1090_13932_13950()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator.DataBaseInfo();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1090, 13932, 13950);
            return return_v;
        }

    }
}
