// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class ComplexViewGenerator : ViewGenerator
    {
        internal override void Initialize(TerminatingErrorContext errorContext, PSPropertyExpressionFactory expressionFactory,
                    PSObject so, TypeInfoDataBase db, FormattingCommandLineParameters parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 472, 834);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 706, 775);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Initialize(errorContext, expressionFactory, so, db, parameters), 1091, 706, 774);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 789, 823);

                this.inputParameters = parameters;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 472, 834);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 472, 834);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 472, 834);
            }
        }

        internal override FormatStartData GenerateStartData(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 846, 1102);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 935, 992);

                FormatStartData
                startFormat = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GenerateStartData(so), 1091, 965, 991)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 1006, 1058);

                startFormat.shapeInfo = f_1091_1030_1057();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 1072, 1091);

                return startFormat;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 846, 1102);

                Microsoft.PowerShell.Commands.Internal.Format.ComplexViewHeaderInfo
                f_1091_1030_1057()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexViewHeaderInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 1030, 1057);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 846, 1102);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 846, 1102);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override FormatEntryData GeneratePayload(PSObject so, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 1114, 1576);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 1223, 1267);

                FormatEntryData
                fed = f_1091_1245_1266()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 1283, 1540) || true) && (this.dataBaseInfo.view != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 1283, 1540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 1336, 1421);

                    fed.formatEntryInfo = f_1091_1358_1420(this, so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 1283, 1540);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 1283, 1540);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 1457, 1540);

                    fed.formatEntryInfo = f_1091_1479_1539(this, so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 1283, 1540);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 1554, 1565);

                return fed;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 1114, 1576);

                Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                f_1091_1245_1266()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 1245, 1266);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexViewEntry
                f_1091_1358_1420(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit)
                {
                    var return_v = this_param.GenerateComplexViewEntryFromDataBaseInfo(so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 1358, 1420);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexViewEntry
                f_1091_1479_1539(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit)
                {
                    var return_v = this_param.GenerateComplexViewEntryFromProperties(so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 1479, 1539);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 1114, 1576);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 1114, 1576);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ComplexViewEntry GenerateComplexViewEntryFromProperties(PSObject so, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 1588, 1915);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 1711, 1836);

                ComplexViewObjectBrowser
                browser = f_1091_1746_1835(f_1091_1775_1792(this), this.expressionFactory, enumerationLimit)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 1850, 1904);

                return f_1091_1857_1903(browser, so, this.inputParameters);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 1588, 1915);

                Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                f_1091_1775_1792(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewGenerator
                this_param)
                {
                    var return_v = this_param.ErrorManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 1775, 1792);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                f_1091_1746_1835(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                resultErrorManager, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                mshExpressionFactory, int
                enumerationLimit)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser(resultErrorManager, mshExpressionFactory, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 1746, 1835);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexViewEntry
                f_1091_1857_1903(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                inputParameters)
                {
                    var return_v = this_param.GenerateView(so, inputParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 1857, 1903);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 1588, 1915);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 1588, 1915);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ComplexViewEntry GenerateComplexViewEntryFromDataBaseInfo(PSObject so, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 1927, 3005);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 2100, 2146);

                ComplexViewEntry
                cve = f_1091_2123_2145()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 2244, 2272);

                const int
                maxTreeDepth = 50
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 2286, 2822);

                ComplexControlGenerator
                controlGenerator =
                f_1091_2358_2821(this.dataBaseInfo.db, this.dataBaseInfo.view.loadingInfo, this.expressionFactory, this.dataBaseInfo.view.formatControlDefinitionHolder.controlDefinitionList, f_1091_2692_2709(this), enumerationLimit, this.errorContext)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 2838, 2969);

                f_1091_2838_2968(
                            controlGenerator, maxTreeDepth, this.dataBaseInfo.view.mainControl, so, cve.formatValueList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 2983, 2994);

                return cve;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 1927, 3005);

                Microsoft.PowerShell.Commands.Internal.Format.ComplexViewEntry
                f_1091_2123_2145()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexViewEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 2123, 2145);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                f_1091_2692_2709(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewGenerator
                this_param)
                {
                    var return_v = this_param.ErrorManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 2692, 2709);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlGenerator
                f_1091_2358_2821(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                dataBase, Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
                loadingInfo, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition>
                controlDefinitionList, Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                resultErrorManager, int
                enumerationLimit, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexControlGenerator(dataBase, loadingInfo, expressionFactory, controlDefinitionList, resultErrorManager, enumerationLimit, errorContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 2358, 2821);
                    return return_v;
                }


                int
                f_1091_2838_2968(Microsoft.PowerShell.Commands.Internal.Format.ComplexControlGenerator
                this_param, int
                maxTreeDepth, Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control, System.Management.Automation.PSObject
                so, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.GenerateFormatEntries(maxTreeDepth, control, so, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 2838, 2968);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 1927, 3005);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 1927, 3005);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public ComplexViewGenerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1091, 397, 3012);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1091, 397, 3012);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 397, 3012);
        }


        static ComplexViewGenerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1091, 397, 3012);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1091, 397, 3012);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 397, 3012);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1091, 397, 3012);
    }
    internal sealed class ComplexControlGenerator
    {
        internal ComplexControlGenerator(TypeInfoDataBase dataBase,
                                                    DatabaseLoadingInfo loadingInfo,
                                                    PSPropertyExpressionFactory expressionFactory,
                                                    List<ControlDefinition> controlDefinitionList,
                                                    FormatErrorManager resultErrorManager,
                                                    int enumerationLimit,
                                                    TerminatingErrorContext errorContext)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1091, 3234, 4138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 16866, 16869);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 16908, 16920);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 16967, 16985);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 17028, 17050);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 17088, 17101);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 17144, 17157);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 17180, 17197);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 3814, 3829);

                _db = dataBase;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 3843, 3870);

                _loadingInfo = loadingInfo;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 3884, 3923);

                _expressionFactory = expressionFactory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 3937, 3984);

                _controlDefinitionList = controlDefinitionList;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 3998, 4033);

                _errorManager = resultErrorManager;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 4047, 4084);

                _enumerationLimit = enumerationLimit;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 4098, 4127);

                _errorContext = errorContext;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1091, 3234, 4138);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 3234, 4138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 3234, 4138);
            }
        }

        internal void GenerateFormatEntries(int maxTreeDepth, ControlBase control,
                        PSObject so, List<FormatValue> formatValueList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 4150, 4589);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 4314, 4438) || true) && (control == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 4314, 4438);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 4367, 4423);

                    throw f_1091_4373_4422("control");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 4314, 4438);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 4454, 4578);

                f_1091_4454_4577(this, f_1091_4475_4509(0, maxTreeDepth), control, so, formatValueList);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 4150, 4589);

                System.Management.Automation.PSArgumentNullException
                f_1091_4373_4422(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 4373, 4422);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                f_1091_4475_4509(int
                level, int
                maxDepth)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo(level, maxDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 4475, 4509);
                    return return_v;
                }


                bool
                f_1091_4454_4577(Microsoft.PowerShell.Commands.Internal.Format.ComplexControlGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                level, Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control, System.Management.Automation.PSObject
                so, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    var return_v = this_param.ExecuteFormatControl(level, control, so, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 4454, 4577);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 4150, 4589);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 4150, 4589);
            }
        }

        private bool ExecuteFormatControl(TraversalInfo level, ControlBase control,
                PSObject so, List<FormatValue> formatValueList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 4601, 5919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 4822, 4860);

                ComplexControlBody
                complexBody = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 4918, 4982);

                ControlReference
                controlReference = control as ControlReference
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 4996, 5582) || true) && (controlReference != null && (DynAbs.Tracing.TraceSender.Expression_True(1091, 5000, 5086) && controlReference.controlType == typeof(ComplexControlBody)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 4996, 5582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 5163, 5411);

                    complexBody = f_1091_5177_5388(_db, _controlDefinitionList, controlReference) as ComplexControlBody;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 4996, 5582);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 4996, 5582);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 5523, 5567);

                    complexBody = control as ComplexControlBody;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 4996, 5582);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 5648, 5879) || true) && (complexBody != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 5648, 5879);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 5768, 5834);

                    f_1091_5768_5833(this, level, so, complexBody, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 5852, 5864);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 5648, 5879);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 5895, 5908);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 4601, 5919);

                Microsoft.PowerShell.Commands.Internal.Format.ControlBody
                f_1091_5177_5388(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ControlDefinition>
                viewControlDefinitionList, Microsoft.PowerShell.Commands.Internal.Format.ControlReference
                controlReference)
                {
                    var return_v = DisplayDataQuery.ResolveControlReference(db, viewControlDefinitionList, controlReference);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 5177, 5388);
                    return return_v;
                }


                int
                f_1091_5768_5833(Microsoft.PowerShell.Commands.Internal.Format.ComplexControlGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                level, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                complexBody, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.ExecuteFormatControlBody(level, so, complexBody, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 5768, 5833);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 4601, 5919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 4601, 5919);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ExecuteFormatControlBody(TraversalInfo level,
                        PSObject so, ComplexControlBody complexBody, List<FormatValue> formatValueList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 5931, 6422);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 6111, 6249);

                ComplexControlEntryDefinition
                activeControlEntryDefinition =
                f_1091_6193_6248(this, complexBody, so)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 6265, 6411);

                f_1091_6265_6410(this, level, so, activeControlEntryDefinition.itemDefinition.formatTokenList, formatValueList);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 5931, 6422);

                Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition
                f_1091_6193_6248(Microsoft.PowerShell.Commands.Internal.Format.ComplexControlGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ComplexControlBody
                complexBody, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.GetActiveComplexControlEntryDefinition(complexBody, so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 6193, 6248);
                    return return_v;
                }


                int
                f_1091_6265_6410(Microsoft.PowerShell.Commands.Internal.Format.ComplexControlGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                level, System.Management.Automation.PSObject
                so, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                formatTokenList, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.ExecuteFormatTokenList(level, so, formatTokenList, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 6265, 6410);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 5931, 6422);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 5931, 6422);
            }
        }

        private ComplexControlEntryDefinition GetActiveComplexControlEntryDefinition(ComplexControlBody complexBody, PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 6434, 8125);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 6636, 6673);

                var
                typeNames = f_1091_6652_6672(so)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 6687, 6755);

                TypeMatch
                match = f_1091_6705_6754(_expressionFactory, _db, typeNames)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 6769, 7022);
                    foreach (ComplexControlEntryDefinition x in f_1091_6813_6842_I(complexBody.optionalEntryList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 6769, 7022);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 6876, 7007) || true) && (f_1091_6880_6937(match, f_1091_6899_6936(x, x.appliesTo, so)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 6876, 7007);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 6979, 6988);

                            return x;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 6876, 7007);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 6769, 7022);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1091, 1, 254);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1091, 1, 254);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 7038, 8114) || true) && (f_1091_7042_7057(match) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 7038, 8114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 7099, 7155);

                    return f_1091_7106_7121(match) as ComplexControlEntryDefinition;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 7038, 8114);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 7038, 8114);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 7221, 7311);

                    Collection<string>
                    typesWithoutPrefix = f_1091_7261_7310(typeNames)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 7329, 7986) || true) && (typesWithoutPrefix != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 7329, 7986);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 7401, 7468);

                        match = f_1091_7409_7467(_expressionFactory, _db, typesWithoutPrefix);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 7490, 7787);
                            foreach (ComplexControlEntryDefinition x in f_1091_7534_7563_I(complexBody.optionalEntryList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 7490, 7787);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 7613, 7764) || true) && (f_1091_7617_7670(match, f_1091_7636_7669(x, x.appliesTo)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 7613, 7764);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 7728, 7737);

                                    return x;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 7613, 7764);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 7490, 7787);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1091, 1, 298);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1091, 1, 298);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 7811, 7967) || true) && (f_1091_7815_7830(match) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 7811, 7967);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 7888, 7944);

                            return f_1091_7895_7910(match) as ComplexControlEntryDefinition;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 7811, 7967);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 7329, 7986);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 8067, 8099);

                    return complexBody.defaultEntry;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 7038, 8114);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 6434, 8125);

                System.Management.Automation.Runspaces.ConsolidatedString
                f_1091_6652_6672(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 6652, 6672);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                f_1091_6705_6754(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatch(expressionFactory, db, (System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 6705, 6754);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                f_1091_6899_6936(Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition
                obj, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                a, System.Management.Automation.PSObject
                currentObject)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem((object)obj, a, currentObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 6899, 6936);
                    return return_v;
                }


                bool
                f_1091_6880_6937(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                item)
                {
                    var return_v = this_param.PerfectMatch(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 6880, 6937);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition>
                f_1091_6813_6842_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 6813, 6842);
                    return return_v;
                }


                object
                f_1091_7042_7057(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 7042, 7057);
                    return return_v;
                }


                object
                f_1091_7106_7121(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 7106, 7121);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1091_7261_7310(System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = Deserializer.MaskDeserializationPrefix((System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 7261, 7310);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                f_1091_7409_7467(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatch(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 7409, 7467);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                f_1091_7636_7669(Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition
                obj, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                a)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem((object)obj, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 7636, 7669);
                    return return_v;
                }


                bool
                f_1091_7617_7670(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                item)
                {
                    var return_v = this_param.PerfectMatch(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 7617, 7670);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition>
                f_1091_7534_7563_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.ComplexControlEntryDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 7534, 7563);
                    return return_v;
                }


                object
                f_1091_7815_7830(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 7815, 7830);
                    return return_v;
                }


                object
                f_1091_7895_7910(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 7895, 7910);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 6434, 8125);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 6434, 8125);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ExecuteFormatTokenList(TraversalInfo level,
                        PSObject so, List<FormatToken> formatTokenList, List<FormatValue> formatValueList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 8137, 16150);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 8318, 8432) || true) && (so == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 8318, 8432);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 8366, 8417);

                    throw f_1091_8372_8416("so");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 8318, 8432);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 8492, 8581) || true) && (f_1091_8496_8507(level) == f_1091_8511_8525(level))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 8492, 8581);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 8559, 8566);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 8492, 8581);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 8597, 8632);

                FormatEntry
                fe = f_1091_8614_8631()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 8648, 8672);

                f_1091_8648_8671(
                            formatValueList, fe);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 8720, 16102);
                    foreach (FormatToken t in f_1091_8746_8761_I(formatTokenList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 8720, 16102);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 8795, 8825);

                        TextToken
                        tt = t as TextToken
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 8843, 9131) || true) && (tt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 8843, 9131);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 8899, 8943);

                            FormatTextField
                            ftf = f_1091_8921_8942()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 8965, 9031);

                            ftf.text = f_1091_8976_9030(_db.displayResourceManagerCache, tt);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9053, 9081);

                            f_1091_9053_9080(fe.formatValueList, ftf);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9103, 9112);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 8843, 9131);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9151, 9183);

                        var
                        newline = t as NewLineToken
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9201, 9469) || true) && (newline != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 9201, 9469);
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9271, 9276);
                                for (int
            i = 0
            ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9262, 9417) || true) && (i < newline.count)
            ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9297, 9300)
            , i++, DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 9262, 9417))

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 9262, 9417);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9350, 9394);

                                    f_1091_9350_9393(fe.formatValueList, f_1091_9373_9392());
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1091, 1, 156);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1091, 1, 156);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9441, 9450);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 9201, 9469);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9489, 9521);

                        FrameToken
                        ft = t as FrameToken
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9539, 10466) || true) && (ft != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 9539, 10466);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9674, 9714);

                            FormatEntry
                            feFrame = f_1091_9696_9713()
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9736, 9772);

                            feFrame.frameInfo = f_1091_9756_9771();
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9839, 9902);

                            feFrame.frameInfo.firstLine = ft.frameInfoDefinition.firstLine;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 9924, 9999);

                            feFrame.frameInfo.leftIndentation = ft.frameInfoDefinition.leftIndentation;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 10021, 10098);

                            feFrame.frameInfo.rightIndentation = ft.frameInfoDefinition.rightIndentation;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 10180, 10274);

                            f_1091_10180_10273(this, level, so, ft.itemDefinition.formatTokenList, feFrame.formatValueList);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 10384, 10416);

                            f_1091_10384_10415(
                                                // add the frame computation results to the current format entry
                                                fe.formatValueList, feFrame);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 10438, 10447);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 9539, 10466);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 10531, 10586);

                        CompoundPropertyToken
                        cpt = t as CompoundPropertyToken
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 10604, 16037) || true) && (cpt != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 10604, 16037);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 10661, 10850) || true) && (!f_1091_10666_10714(this, so, cpt.conditionToken))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 10661, 10850);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 10818, 10827);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 10661, 10850);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 10931, 10949);

                            object
                            val = null
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 11080, 11925) || true) && (cpt.expression == null || (DynAbs.Tracing.TraceSender.Expression_False(1091, 11084, 11162) || f_1091_11110_11162(cpt.expression.expressionValue)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 11080, 11925);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 11212, 11221);

                                val = so;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 11080, 11925);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 11080, 11925);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 11319, 11420);

                                PSPropertyExpression
                                ex = f_1091_11345_11419(_expressionFactory, cpt.expression, _loadingInfo)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 11446, 11509);

                                List<PSPropertyExpressionResult>
                                resultList = f_1091_11492_11508(ex, so)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 11535, 11902) || true) && (f_1091_11539_11555(resultList) > 0)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 11535, 11902);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 11617, 11644);

                                    val = f_1091_11623_11643(f_1091_11623_11636(resultList, 0));

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 11674, 11875) || true) && (f_1091_11678_11701(f_1091_11678_11691(resultList, 0)) != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 11674, 11875);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 11775, 11844);

                                        f_1091_11775_11843(_errorManager, f_1091_11825_11838(resultList, 0), so);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 11674, 11875);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 11535, 11902);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 11080, 11925);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 12094, 16018) || true) && (cpt.control == null || (DynAbs.Tracing.TraceSender.Expression_False(1091, 12098, 12152) || cpt.control is FieldControlBody))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 12094, 16018);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 12344, 12463) || true) && (val == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 12344, 12463);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 12417, 12436);

                                    val = string.Empty;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 12344, 12463);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 12491, 12548);

                                FieldFormattingDirective
                                fieldFormattingDirective = null
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 12574, 12617);

                                StringFormatError
                                formatErrorObject = null
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 12643, 13084) || true) && (cpt.control != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 12643, 13084);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 12724, 12808);

                                    fieldFormattingDirective = ((FieldControlBody)cpt.control).fieldFormattingDirective;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 12838, 13057) || true) && (fieldFormattingDirective != null && (DynAbs.Tracing.TraceSender.Expression_True(1091, 12842, 12916) && f_1091_12878_12916(_errorManager)))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 12838, 13057);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 12982, 13026);

                                        formatErrorObject = f_1091_13002_13025();
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 12838, 13057);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 12643, 13084);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 13112, 13162);

                                IEnumerable
                                e = f_1091_13128_13161(val)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 13188, 13240);

                                FormatPropertyField
                                fpf = f_1091_13214_13239()
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 13266, 14372) || true) && (cpt.enumerateCollection && (DynAbs.Tracing.TraceSender.Expression_True(1091, 13270, 13306) && e != null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 13266, 14372);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 13364, 13973);
                                        foreach (object x in f_1091_13385_13386_I(e))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 13364, 13973);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 13452, 13642) || true) && (x == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 13452, 13642);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 13598, 13607);

                                                continue;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 13452, 13642);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 13678, 13710);

                                            fpf = f_1091_13684_13709();
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 13746, 13880);

                                            fpf.propertyValue = f_1091_13766_13879(fieldFormattingDirective, x, _enumerationLimit, formatErrorObject, _expressionFactory);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 13914, 13942);

                                            f_1091_13914_13941(fe.formatValueList, fpf);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 13364, 13973);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1091, 1, 610);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1091, 1, 610);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 13266, 14372);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 13266, 14372);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 14087, 14119);

                                    fpf = f_1091_14093_14118();
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 14151, 14287);

                                    fpf.propertyValue = f_1091_14171_14286(fieldFormattingDirective, val, _enumerationLimit, formatErrorObject, _expressionFactory);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 14317, 14345);

                                    f_1091_14317_14344(fe.formatValueList, fpf);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 13266, 14372);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 14400, 14689) || true) && (formatErrorObject != null && (DynAbs.Tracing.TraceSender.Expression_True(1091, 14404, 14468) && formatErrorObject.exception != null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 14400, 14689);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 14526, 14580);

                                    f_1091_14526_14579(_errorManager, formatErrorObject);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 14610, 14662);

                                    fpf.propertyValue = f_1091_14630_14661(_errorManager);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 14400, 14689);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 12094, 16018);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 12094, 16018);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 14878, 14987) || true) && (val == null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 14878, 14987);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 14951, 14960);

                                    continue;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 14878, 14987);
                                }
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 15015, 15065);

                                IEnumerable
                                e = f_1091_15031_15064(val)
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 15091, 15995) || true) && (cpt.enumerateCollection && (DynAbs.Tracing.TraceSender.Expression_True(1091, 15095, 15131) && e != null))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 15091, 15995);
                                    try
                                    {
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 15189, 15692);
                                        foreach (object x in f_1091_15210_15211_I(e))
                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 15189, 15692);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 15277, 15467) || true) && (x == null)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 15277, 15467);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 15423, 15432);

                                                continue;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 15277, 15467);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 15566, 15661);

                                            f_1091_15566_15660(this, f_1091_15587_15602(level), cpt.control, f_1091_15617_15639(x), fe.formatValueList);
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 15189, 15692);
                                        }
                                    }
                                    catch (System.Exception)
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1091, 1, 504);
                                        throw;
                                    }
                                    finally
                                    {
                                        DynAbs.Tracing.TraceSender.TraceExitLoop(1091, 1, 504);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 15091, 15995);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 15091, 15995);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 15865, 15968);

                                    f_1091_15865_15967(this, f_1091_15886_15901(level), cpt.control, f_1091_15916_15946(val), fe.formatValueList);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 15091, 15995);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 12094, 16018);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 10604, 16037);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 8720, 16102);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1091, 1, 7383);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1091, 1, 7383);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 8137, 16150);

                System.Management.Automation.PSArgumentNullException
                f_1091_8372_8416(string
                paramName)
                {
                    var return_v = PSTraceSource.NewArgumentNullException(paramName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 8372, 8416);
                    return return_v;
                }


                int
                f_1091_8496_8507(Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                this_param)
                {
                    var return_v = this_param.Level;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 8496, 8507);
                    return return_v;
                }


                int
                f_1091_8511_8525(Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                this_param)
                {
                    var return_v = this_param.MaxDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 8511, 8525);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                f_1091_8614_8631()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 8614, 8631);
                    return return_v;
                }


                int
                f_1091_8648_8671(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 8648, 8671);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatTextField
                f_1091_8921_8942()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatTextField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 8921, 8942);
                    return return_v;
                }


                string
                f_1091_8976_9030(Microsoft.PowerShell.Commands.Internal.Format.DisplayResourceManagerCache
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TextToken
                tt)
                {
                    var return_v = this_param.GetTextTokenString(tt);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 8976, 9030);
                    return return_v;
                }


                int
                f_1091_9053_9080(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatTextField
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 9053, 9080);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                f_1091_9373_9392()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 9373, 9392);
                    return return_v;
                }


                int
                f_1091_9350_9393(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 9350, 9393);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                f_1091_9696_9713()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 9696, 9713);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FrameInfo
                f_1091_9756_9771()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FrameInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 9756, 9771);
                    return return_v;
                }


                int
                f_1091_10180_10273(Microsoft.PowerShell.Commands.Internal.Format.ComplexControlGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                level, System.Management.Automation.PSObject
                so, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                formatTokenList, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.ExecuteFormatTokenList(level, so, formatTokenList, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 10180, 10273);
                    return 0;
                }


                int
                f_1091_10384_10415(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 10384, 10415);
                    return 0;
                }


                bool
                f_1091_10666_10714(Microsoft.PowerShell.Commands.Internal.Format.ComplexControlGenerator
                this_param, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                conditionToken)
                {
                    var return_v = this_param.EvaluateDisplayCondition(so, conditionToken);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 10666, 10714);
                    return return_v;
                }


                bool
                f_1091_11110_11162(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 11110, 11162);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1091_11345_11419(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                et, Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
                loadingInfo)
                {
                    var return_v = this_param.CreateFromExpressionToken(et, loadingInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 11345, 11419);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                f_1091_11492_11508(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target)
                {
                    var return_v = this_param.GetValues(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 11492, 11508);
                    return return_v;
                }


                int
                f_1091_11539_11555(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 11539, 11555);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1091_11623_11636(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 11623, 11636);
                    return return_v;
                }


                object
                f_1091_11623_11643(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 11623, 11643);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1091_11678_11691(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 11678, 11691);
                    return return_v;
                }


                System.Exception
                f_1091_11678_11701(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 11678, 11701);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1091_11825_11838(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 11825, 11838);
                    return return_v;
                }


                int
                f_1091_11775_11843(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param, Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                result, System.Management.Automation.PSObject
                sourceObject)
                {
                    this_param.LogPSPropertyExpressionFailedResult(result, (object)sourceObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 11775, 11843);
                    return 0;
                }


                bool
                f_1091_12878_12916(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.DisplayFormatErrorString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 12878, 12916);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                f_1091_13002_13025()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.StringFormatError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 13002, 13025);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1091_13128_13161(object
                obj)
                {
                    var return_v = PSObjectHelper.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 13128, 13161);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                f_1091_13214_13239()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 13214, 13239);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                f_1091_13684_13709()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 13684, 13709);
                    return return_v;
                }


                string
                f_1091_13766_13879(Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective
                directive, object
                val, int
                enumerationLimit, Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                formatErrorObject, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = PSObjectHelper.FormatField(directive, val, enumerationLimit, formatErrorObject, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 13766, 13879);
                    return return_v;
                }


                int
                f_1091_13914_13941(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 13914, 13941);
                    return 0;
                }


                System.Collections.IEnumerable
                f_1091_13385_13386_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 13385, 13386);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                f_1091_14093_14118()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 14093, 14118);
                    return return_v;
                }


                string
                f_1091_14171_14286(Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective
                directive, object
                val, int
                enumerationLimit, Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                formatErrorObject, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = PSObjectHelper.FormatField(directive, val, enumerationLimit, formatErrorObject, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 14171, 14286);
                    return return_v;
                }


                int
                f_1091_14317_14344(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 14317, 14344);
                    return 0;
                }


                int
                f_1091_14526_14579(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param, Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                error)
                {
                    this_param.LogStringFormatError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 14526, 14579);
                    return 0;
                }


                string
                f_1091_14630_14661(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.FormatErrorString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 14630, 14661);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1091_15031_15064(object
                obj)
                {
                    var return_v = PSObjectHelper.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 15031, 15064);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                f_1091_15587_15602(Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                this_param)
                {
                    var return_v = this_param.NextLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 15587, 15602);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1091_15617_15639(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 15617, 15639);
                    return return_v;
                }


                bool
                f_1091_15566_15660(Microsoft.PowerShell.Commands.Internal.Format.ComplexControlGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                level, Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control, System.Management.Automation.PSObject
                so, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    var return_v = this_param.ExecuteFormatControl(level, control, so, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 15566, 15660);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1091_15210_15211_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 15210, 15211);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                f_1091_15886_15901(Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                this_param)
                {
                    var return_v = this_param.NextLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 15886, 15901);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1091_15916_15946(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 15916, 15946);
                    return return_v;
                }


                bool
                f_1091_15865_15967(Microsoft.PowerShell.Commands.Internal.Format.ComplexControlGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                level, Microsoft.PowerShell.Commands.Internal.Format.ControlBase
                control, System.Management.Automation.PSObject
                so, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    var return_v = this_param.ExecuteFormatControl(level, control, so, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 15865, 15967);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                f_1091_8746_8761_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 8746, 8761);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 8137, 16150);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 8137, 16150);
            }
        }

        private bool EvaluateDisplayCondition(PSObject so, ExpressionToken conditionToken)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 16162, 16829);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 16269, 16326) || true) && (conditionToken == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 16269, 16326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 16314, 16326);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 16269, 16326);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 16342, 16443);

                PSPropertyExpression
                ex = f_1091_16368_16442(_expressionFactory, conditionToken, _loadingInfo)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 16457, 16501);

                PSPropertyExpressionResult
                expressionResult
                = default(PSPropertyExpressionResult);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 16515, 16585);

                bool
                retVal = f_1091_16529_16584(so, ex, out expressionResult)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 16601, 16788) || true) && (expressionResult != null && (DynAbs.Tracing.TraceSender.Expression_True(1091, 16605, 16667) && f_1091_16633_16659(expressionResult) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 16601, 16788);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 16701, 16773);

                    f_1091_16701_16772(_errorManager, expressionResult, so);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 16601, 16788);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 16804, 16818);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 16162, 16829);

                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1091_16368_16442(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                et, Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
                loadingInfo)
                {
                    var return_v = this_param.CreateFromExpressionToken(et, loadingInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 16368, 16442);
                    return return_v;
                }


                bool
                f_1091_16529_16584(System.Management.Automation.PSObject
                obj, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex, out Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                expressionResult)
                {
                    var return_v = DisplayCondition.Evaluate(obj, ex, out expressionResult);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 16529, 16584);
                    return return_v;
                }


                System.Exception
                f_1091_16633_16659(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 16633, 16659);
                    return return_v;
                }


                int
                f_1091_16701_16772(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param, Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                result, System.Management.Automation.PSObject
                sourceObject)
                {
                    this_param.LogPSPropertyExpressionFailedResult(result, (object)sourceObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 16701, 16772);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 16162, 16829);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 16162, 16829);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private TypeInfoDataBase _db;

        private DatabaseLoadingInfo _loadingInfo;

        private PSPropertyExpressionFactory _expressionFactory;

        private List<ControlDefinition> _controlDefinitionList;

        private FormatErrorManager _errorManager;

        private TerminatingErrorContext _errorContext;

        private int _enumerationLimit;

        static ComplexControlGenerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1091, 3172, 17205);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1091, 3172, 17205);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 3172, 17205);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1091, 3172, 17205);
    }
    internal class TraversalInfo
    {
        internal TraversalInfo(int level, int maxDepth)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1091, 17258, 17391);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 17714, 17720);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 17743, 17752);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 17330, 17345);

                _level = level;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 17359, 17380);

                _maxDepth = maxDepth;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1091, 17258, 17391);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 17258, 17391);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 17258, 17391);
            }
        }

        internal int Level
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 17424, 17446);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 17430, 17444);

                    return _level;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 17424, 17446);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 17403, 17448);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 17403, 17448);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal int MaxDepth
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 17484, 17509);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 17490, 17507);

                    return _maxDepth;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 17484, 17509);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 17460, 17511);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 17460, 17511);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal TraversalInfo NextLevel
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 17580, 17679);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 17616, 17664);

                    return f_1091_17623_17663(_level + 1, _maxDepth);
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 17580, 17679);

                    Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                    f_1091_17623_17663(int
                    level, int
                    maxDepth)
                    {
                        var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo(level, maxDepth);
                        DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 17623, 17663);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 17523, 17690);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 17523, 17690);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private int _level;

        private int _maxDepth;

        static TraversalInfo()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1091, 17213, 17760);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1091, 17213, 17760);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 17213, 17760);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1091, 17213, 17760);
    }
    internal sealed class ComplexViewObjectBrowser
    {
        internal ComplexViewObjectBrowser(FormatErrorManager resultErrorManager, PSPropertyExpressionFactory mshExpressionFactory, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1091, 17929, 18251);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 32110, 32136);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 32271, 32291);
                this._indentationStep = 2;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 32331, 32344);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 32393, 32411);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 32436, 32453);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 18098, 18133);

                _errorManager = resultErrorManager;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 18147, 18189);

                _expressionFactory = mshExpressionFactory;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 18203, 18240);

                _enumerationLimit = enumerationLimit;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1091, 17929, 18251);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 17929, 18251);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 17929, 18251);
            }
        }

        internal ComplexViewEntry GenerateView(PSObject so, FormattingCommandLineParameters inputParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 18618, 20271);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 18743, 18831);

                _complexSpecificParameters = (ComplexSpecificParameters)inputParameters.shapeParameters;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 18847, 18898);

                int
                maxDepth = _complexSpecificParameters.maxDepth
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 18912, 18965);

                TraversalInfo
                level = f_1091_18934_18964(0, maxDepth)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 18981, 19024);

                List<MshParameter>
                mshParameterList = null
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 19038, 19090);

                mshParameterList = inputParameters.mshParameterList;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 19167, 19213);

                ComplexViewEntry
                cve = f_1091_19190_19212()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 19227, 19264);

                var
                typeNames = f_1091_19243_19263(so)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 19278, 20233) || true) && (f_1091_19282_19310(typeNames))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 19278, 20233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 19344, 19379);

                    FormatEntry
                    fe = f_1091_19361_19378()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 19399, 19427);

                    f_1091_19399_19426(
                                    cve.formatValueList, fe);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 19445, 19486);

                    f_1091_19445_19485(this, so, fe.formatValueList);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 19278, 20233);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 19278, 20233);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 19620, 19669);

                    IEnumerable
                    e = f_1091_19636_19668(so)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 19689, 20218) || true) && (e != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 19689, 20218);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 19814, 19849);

                        FormatEntry
                        fe = f_1091_19831_19848()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 19873, 19901);

                        f_1091_19873_19900(
                                            cve.formatValueList, fe);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 19923, 19972);

                        f_1091_19923_19971(this, e, level, fe.formatValueList);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 19689, 20218);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 19689, 20218);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 20135, 20199);

                        f_1091_20135_20198(this, so, level, mshParameterList, cve.formatValueList);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 19689, 20218);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 19278, 20233);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 20249, 20260);

                return cve;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 18618, 20271);

                Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                f_1091_18934_18964(int
                level, int
                maxDepth)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo(level, maxDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 18934, 18964);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexViewEntry
                f_1091_19190_19212()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexViewEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 19190, 19212);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1091_19243_19263(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 19243, 19263);
                    return return_v;
                }


                bool
                f_1091_19282_19310(System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = TreatAsScalarType((System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 19282, 19310);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                f_1091_19361_19378()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 19361, 19378);
                    return return_v;
                }


                int
                f_1091_19399_19426(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 19399, 19426);
                    return 0;
                }


                int
                f_1091_19445_19485(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Management.Automation.PSObject
                so, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.DisplayRawObject(so, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 19445, 19485);
                    return 0;
                }


                System.Collections.IEnumerable
                f_1091_19636_19668(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObjectHelper.GetEnumerable((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 19636, 19668);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                f_1091_19831_19848()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 19831, 19848);
                    return return_v;
                }


                int
                f_1091_19873_19900(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 19873, 19900);
                    return 0;
                }


                int
                f_1091_19923_19971(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Collections.IEnumerable
                e, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                level, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.DisplayEnumeration(e, level, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 19923, 19971);
                    return 0;
                }


                int
                f_1091_20135_20198(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                currentLevel, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                parameterList, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.DisplayObject(so, currentLevel, parameterList, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 20135, 20198);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 18618, 20271);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 18618, 20271);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void DisplayRawObject(PSObject so, List<FormatValue> formatValueList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 20283, 21541);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 20385, 20437);

                FormatPropertyField
                fpf = f_1091_20411_20436()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 20453, 20496);

                StringFormatError
                formatErrorObject = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 20510, 20797) || true) && (f_1091_20514_20552(_errorManager))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 20510, 20797);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 20738, 20782);

                    formatErrorObject = f_1091_20758_20781();
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 20510, 20797);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 20813, 20924);

                fpf.propertyValue = f_1091_20833_20923(so, _expressionFactory, _enumerationLimit, formatErrorObject);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 20940, 21434) || true) && (formatErrorObject != null && (DynAbs.Tracing.TraceSender.Expression_True(1091, 20944, 21008) && formatErrorObject.exception != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 20940, 21434);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 21192, 21246);

                    f_1091_21192_21245(                // if we did no thave any errors in the expression evaluation
                                                       // we might have errors in the formatting, if present
                                    _errorManager, formatErrorObject);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 21264, 21419) || true) && (f_1091_21268_21306(_errorManager))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 21264, 21419);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 21348, 21400);

                        fpf.propertyValue = f_1091_21368_21399(_errorManager);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 21264, 21419);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 20940, 21434);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 21450, 21475);

                f_1091_21450_21474(
                            formatValueList, fpf);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 21489, 21530);

                f_1091_21489_21529(formatValueList, f_1091_21509_21528());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 20283, 21541);

                Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                f_1091_20411_20436()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 20411, 20436);
                    return return_v;
                }


                bool
                f_1091_20514_20552(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.DisplayFormatErrorString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 20514, 20552);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                f_1091_20758_20781()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.StringFormatError();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 20758, 20781);
                    return return_v;
                }


                string
                f_1091_20833_20923(System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, int
                enumerationLimit, Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                formatErrorObject)
                {
                    var return_v = PSObjectHelper.SmartToString(so, expressionFactory, enumerationLimit, formatErrorObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 20833, 20923);
                    return return_v;
                }


                int
                f_1091_21192_21245(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param, Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                error)
                {
                    this_param.LogStringFormatError(error);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 21192, 21245);
                    return 0;
                }


                bool
                f_1091_21268_21306(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.DisplayFormatErrorString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 21268, 21306);
                    return return_v;
                }


                string
                f_1091_21368_21399(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.FormatErrorString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 21368, 21399);
                    return return_v;
                }


                int
                f_1091_21450_21474(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 21450, 21474);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                f_1091_21509_21528()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 21509, 21528);
                    return return_v;
                }


                int
                f_1091_21489_21529(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 21489, 21529);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 20283, 21541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 20283, 21541);
            }
        }

        private void DisplayObject(PSObject so, TraversalInfo currentLevel, List<MshParameter> parameterList,
                                                List<FormatValue> formatValueList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 21962, 23009);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 22216, 22393);

                List<MshResolvedExpressionParameterAssociation>
                activeAssociationList =
                f_1091_22313_22392(parameterList, so, _expressionFactory)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 22447, 22482);

                FormatEntry
                fe = f_1091_22464_22481()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 22496, 22520);

                f_1091_22496_22519(formatValueList, fe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 22587, 22639);

                string
                objectDisplayName = f_1091_22614_22638(this, so)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 22653, 22750) || true) && (objectDisplayName != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 22653, 22750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 22701, 22750);

                    objectDisplayName = "class " + objectDisplayName;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 22653, 22750);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 22766, 22822);

                f_1091_22766_22821(fe.formatValueList, "{", objectDisplayName);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 22836, 22947);

                f_1091_22836_22946(this, so, currentLevel, activeAssociationList, f_1091_22906_22945(this, fe.formatValueList));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 22961, 22998);

                f_1091_22961_22997(fe.formatValueList, "}");
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 21962, 23009);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1091_22313_22392(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                rawMshParameterList, System.Management.Automation.PSObject
                target, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = AssociationManager.SetupActiveProperties(rawMshParameterList, target, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 22313, 22392);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                f_1091_22464_22481()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 22464, 22481);
                    return return_v;
                }


                int
                f_1091_22496_22519(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 22496, 22519);
                    return 0;
                }


                string
                f_1091_22614_22638(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.GetObjectDisplayName(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 22614, 22638);
                    return return_v;
                }


                int
                f_1091_22766_22821(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList, string
                openTag, string
                label)
                {
                    AddPrologue(formatValueList, openTag, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 22766, 22821);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                f_1091_22906_22945(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    var return_v = this_param.AddIndentationLevel(formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 22906, 22945);
                    return return_v;
                }


                int
                f_1091_22836_22946(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                currentLevel, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                activeAssociationList, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.ProcessActiveAssociationList(so, currentLevel, activeAssociationList, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 22836, 22946);
                    return 0;
                }


                int
                f_1091_22961_22997(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList, string
                closeTag)
                {
                    AddEpilogue(formatValueList, closeTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 22961, 22997);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 21962, 23009);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 21962, 23009);
            }
        }

        private void ProcessActiveAssociationList(PSObject so,
                                        TraversalInfo currentLevel,
                                        List<MshResolvedExpressionParameterAssociation> activeAssociationList,
                                                            List<FormatValue> formatValueList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 23021, 26077);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 23353, 26066);
                    foreach (MshResolvedExpressionParameterAssociation a in f_1091_23409_23430_I(activeAssociationList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 23353, 26066);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 23464, 23508);

                        FormatTextField
                        ftf = f_1091_23486_23507()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 23528, 23579);

                        ftf.text = f_1091_23539_23570(f_1091_23539_23559(a)) + " = ";
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 23597, 23622);

                        f_1091_23597_23621(formatValueList, ftf);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 23693, 23771);

                        List<PSPropertyExpressionResult>
                        resList = f_1091_23736_23770(f_1091_23736_23756(a), so)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 23789, 23807);

                        object
                        val = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 23825, 24571) || true) && (f_1091_23829_23842(resList) >= 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 23825, 24571);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 23889, 23936);

                            PSPropertyExpressionResult
                            result = f_1091_23925_23935(resList, 0)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 23958, 24552) || true) && (f_1091_23962_23978(result) != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 23958, 24552);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 24036, 24098);

                                f_1091_24036_24097(_errorManager, result, so);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 24124, 24411) || true) && (f_1091_24128_24161(_errorManager))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 24124, 24411);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 24219, 24251);

                                    val = f_1091_24225_24250(_errorManager);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 24124, 24411);
                                }

                                else

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 24124, 24411);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 24365, 24384);

                                    val = string.Empty;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 24124, 24411);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 23958, 24552);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 23958, 24552);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 24509, 24529);

                                val = f_1091_24515_24528(result);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 23958, 24552);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 23825, 24571);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 24642, 24677);

                        TraversalInfo
                        level = currentLevel
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 24695, 25152) || true) && (f_1091_24699_24721(a) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 24695, 25152);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 24771, 24869);

                            object
                            maxDepthKey = f_1091_24792_24868(f_1091_24792_24814(a), FormatParameterDefinitionKeys.DepthEntryKey)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 24891, 25133) || true) && (maxDepthKey != f_1091_24910_24930())
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 24891, 25133);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 24980, 25020);

                                int
                                parameterMaxDept = (int)maxDepthKey
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 25046, 25110);

                                level = f_1091_25054_25109(f_1091_25072_25090(currentLevel), parameterMaxDept);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 24891, 25133);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 24695, 25152);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 25172, 25193);

                        IEnumerable
                        e = null
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 25211, 25322) || true) && (val != null || (DynAbs.Tracing.TraceSender.Expression_False(1091, 25215, 25261) || (f_1091_25231_25242(level) >= f_1091_25246_25260(level))))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 25211, 25322);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 25284, 25322);

                            e = f_1091_25288_25321(val);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 25211, 25322);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 25342, 26051) || true) && (e != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 25342, 26051);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 25397, 25438);

                            f_1091_25397_25437(formatValueList, f_1091_25417_25436());
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 25460, 25537);

                            f_1091_25460_25536(this, e, f_1091_25482_25497(level), f_1091_25499_25535(this, formatValueList));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 25342, 26051);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 25342, 26051);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 25579, 26051) || true) && (val == null || (DynAbs.Tracing.TraceSender.Expression_False(1091, 25583, 25625) || f_1091_25598_25625(val, level)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 25579, 26051);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 25667, 25701);

                                f_1091_25667_25700(this, val, formatValueList);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 25579, 26051);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 25579, 26051);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 25783, 25824);

                                f_1091_25783_25823(formatValueList, f_1091_25803_25822());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 25906, 26032);

                                f_1091_25906_26031(this, f_1091_25920_25944(val), f_1091_25946_25961(level), null, f_1091_25994_26030(this, formatValueList));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 25579, 26051);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 25342, 26051);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 23353, 26066);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1091, 1, 2714);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1091, 1, 2714);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 23021, 26077);

                Microsoft.PowerShell.Commands.Internal.Format.FormatTextField
                f_1091_23486_23507()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatTextField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 23486, 23507);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1091_23539_23559(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 23539, 23559);
                    return return_v;
                }


                string
                f_1091_23539_23570(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 23539, 23570);
                    return return_v;
                }


                int
                f_1091_23597_23621(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatTextField
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 23597, 23621);
                    return 0;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1091_23736_23756(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 23736, 23756);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                f_1091_23736_23770(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target)
                {
                    var return_v = this_param.GetValues(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 23736, 23770);
                    return return_v;
                }


                int
                f_1091_23829_23842(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 23829, 23842);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1091_23925_23935(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 23925, 23935);
                    return return_v;
                }


                System.Exception
                f_1091_23962_23978(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 23962, 23978);
                    return return_v;
                }


                int
                f_1091_24036_24097(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param, Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                result, System.Management.Automation.PSObject
                sourceObject)
                {
                    this_param.LogPSPropertyExpressionFailedResult(result, (object)sourceObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 24036, 24097);
                    return 0;
                }


                bool
                f_1091_24128_24161(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.DisplayErrorStrings;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 24128, 24161);
                    return return_v;
                }


                string
                f_1091_24225_24250(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.ErrorString;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 24225, 24250);
                    return return_v;
                }


                object
                f_1091_24515_24528(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 24515, 24528);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1091_24699_24721(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 24699, 24721);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1091_24792_24814(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 24792, 24814);
                    return return_v;
                }


                object
                f_1091_24792_24868(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                this_param, string
                key)
                {
                    var return_v = this_param.GetEntry(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 24792, 24868);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1091_24910_24930()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 24910, 24930);
                    return return_v;
                }


                int
                f_1091_25072_25090(Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                this_param)
                {
                    var return_v = this_param.Level;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 25072, 25090);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                f_1091_25054_25109(int
                level, int
                maxDepth)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo(level, maxDepth);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 25054, 25109);
                    return return_v;
                }


                int
                f_1091_25231_25242(Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                this_param)
                {
                    var return_v = this_param.Level;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 25231, 25242);
                    return return_v;
                }


                int
                f_1091_25246_25260(Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                this_param)
                {
                    var return_v = this_param.MaxDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 25246, 25260);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1091_25288_25321(object
                obj)
                {
                    var return_v = PSObjectHelper.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 25288, 25321);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                f_1091_25417_25436()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 25417, 25436);
                    return return_v;
                }


                int
                f_1091_25397_25437(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 25397, 25437);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                f_1091_25482_25497(Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                this_param)
                {
                    var return_v = this_param.NextLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 25482, 25497);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                f_1091_25499_25535(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    var return_v = this_param.AddIndentationLevel(formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 25499, 25535);
                    return return_v;
                }


                int
                f_1091_25460_25536(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Collections.IEnumerable
                e, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                level, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.DisplayEnumeration(e, level, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 25460, 25536);
                    return 0;
                }


                bool
                f_1091_25598_25625(object
                val, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                level)
                {
                    var return_v = TreatAsLeafNode(val, level);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 25598, 25625);
                    return return_v;
                }


                int
                f_1091_25667_25700(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, object
                val, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.DisplayLeaf(val, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 25667, 25700);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                f_1091_25803_25822()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 25803, 25822);
                    return return_v;
                }


                int
                f_1091_25783_25823(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 25783, 25823);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1091_25920_25944(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 25920, 25944);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                f_1091_25946_25961(Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                this_param)
                {
                    var return_v = this_param.NextLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 25946, 25961);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                f_1091_25994_26030(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    var return_v = this_param.AddIndentationLevel(formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 25994, 26030);
                    return return_v;
                }


                int
                f_1091_25906_26031(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                currentLevel, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                parameterList, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.DisplayObject(so, currentLevel, parameterList, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 25906, 26031);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1091_23409_23430_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 23409, 23430);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 23021, 26077);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 23021, 26077);
            }
        }

        private void DisplayEnumeration(IEnumerable e, TraversalInfo level, List<FormatValue> formatValueList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 26404, 26773);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 26531, 26571);

                f_1091_26531_26570(formatValueList, "[", null);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 26585, 26657);

                f_1091_26585_26656(this, e, level, f_1091_26619_26655(this, formatValueList));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 26671, 26705);

                f_1091_26671_26704(formatValueList, "]");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 26721, 26762);

                f_1091_26721_26761(
                            formatValueList, f_1091_26741_26760());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 26404, 26773);

                int
                f_1091_26531_26570(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList, string
                openTag, string
                label)
                {
                    AddPrologue(formatValueList, openTag, label);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 26531, 26570);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                f_1091_26619_26655(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    var return_v = this_param.AddIndentationLevel(formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 26619, 26655);
                    return return_v;
                }


                int
                f_1091_26585_26656(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Collections.IEnumerable
                e, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                level, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.DisplayEnumerationInner(e, level, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 26585, 26656);
                    return 0;
                }


                int
                f_1091_26671_26704(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList, string
                closeTag)
                {
                    AddEpilogue(formatValueList, closeTag);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 26671, 26704);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                f_1091_26741_26760()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 26741, 26760);
                    return return_v;
                }


                int
                f_1091_26721_26761(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 26721, 26761);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 26404, 26773);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 26404, 26773);
            }
        }

        private void DisplayEnumerationInner(IEnumerable e, TraversalInfo level, List<FormatValue> formatValueList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 26785, 28318);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 26917, 26935);

                int
                enumCount = 0
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 26949, 28307);
                    foreach (object x in f_1091_26970_26971_I(e))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 26949, 28307);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 27005, 27173) || true) && (f_1091_27009_27075(f_1091_27009_27051()))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 27005, 27173);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 27117, 27154);

                            throw f_1091_27123_27153();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 27005, 27173);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 27193, 27509) || true) && (_enumerationLimit >= 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 27193, 27509);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 27261, 27454) || true) && (_enumerationLimit == enumCount)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 27261, 27454);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 27345, 27399);

                                f_1091_27345_27398(this, PSObjectHelper.Ellipsis, formatValueList);
                                DynAbs.Tracing.TraceSender.TraceBreak(1091, 27425, 27431);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 27261, 27454);
                            }
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 27478, 27490);

                            enumCount++;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 27193, 27509);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 27529, 28292) || true) && (f_1091_27533_27558(x, level))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 27529, 28292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 27600, 27632);

                            f_1091_27600_27631(this, x, formatValueList);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 27529, 28292);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 27529, 28292);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 27786, 27835);

                            IEnumerable
                            e1 = f_1091_27803_27834(x)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 27859, 28273) || true) && (e1 != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 27859, 28273);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 27923, 27964);

                                f_1091_27923_27963(formatValueList, f_1091_27943_27962());
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 27990, 28068);

                                f_1091_27990_28067(this, e1, f_1091_28013_28028(level), f_1091_28030_28066(this, formatValueList));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 27859, 28273);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 27859, 28273);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 28166, 28250);

                                f_1091_28166_28249(this, f_1091_28180_28208(x), f_1091_28210_28225(level), null, formatValueList);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 27859, 28273);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 27529, 28292);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 26949, 28307);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1091, 1, 1359);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1091, 1, 1359);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 26785, 28318);

                System.Management.Automation.ExecutionContext
                f_1091_27009_27051()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 27009, 27051);
                    return return_v;
                }


                bool
                f_1091_27009_27075(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 27009, 27075);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1091_27123_27153()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 27123, 27153);
                    return return_v;
                }


                int
                f_1091_27345_27398(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, char
                val, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.DisplayLeaf((object)val, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 27345, 27398);
                    return 0;
                }


                bool
                f_1091_27533_27558(object
                val, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                level)
                {
                    var return_v = TreatAsLeafNode(val, level);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 27533, 27558);
                    return return_v;
                }


                int
                f_1091_27600_27631(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, object
                val, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.DisplayLeaf(val, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 27600, 27631);
                    return 0;
                }


                System.Collections.IEnumerable
                f_1091_27803_27834(object
                obj)
                {
                    var return_v = PSObjectHelper.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 27803, 27834);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                f_1091_27943_27962()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 27943, 27962);
                    return return_v;
                }


                int
                f_1091_27923_27963(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 27923, 27963);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                f_1091_28013_28028(Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                this_param)
                {
                    var return_v = this_param.NextLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 28013, 28028);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                f_1091_28030_28066(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    var return_v = this_param.AddIndentationLevel(formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 28030, 28066);
                    return return_v;
                }


                int
                f_1091_27990_28067(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Collections.IEnumerable
                e, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                level, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.DisplayEnumeration(e, level, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 27990, 28067);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1091_28180_28208(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 28180, 28208);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                f_1091_28210_28225(Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                this_param)
                {
                    var return_v = this_param.NextLevel;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 28210, 28225);
                    return return_v;
                }


                int
                f_1091_28166_28249(Microsoft.PowerShell.Commands.Internal.Format.ComplexViewObjectBrowser
                this_param, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                currentLevel, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                parameterList, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                formatValueList)
                {
                    this_param.DisplayObject(so, currentLevel, parameterList, formatValueList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 28166, 28249);
                    return 0;
                }


                System.Collections.IEnumerable
                f_1091_26970_26971_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 26970, 26971);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 26785, 28318);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 26785, 28318);
            }
        }

        private void DisplayLeaf(object val, List<FormatValue> formatValueList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 28554, 28953);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 28650, 28702);

                FormatPropertyField
                fpf = f_1091_28676_28701()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 28718, 28848);

                fpf.propertyValue = f_1091_28738_28847(null, f_1091_28771_28801(val), _enumerationLimit, null, _expressionFactory);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 28862, 28887);

                f_1091_28862_28886(formatValueList, fpf);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 28901, 28942);

                f_1091_28901_28941(formatValueList, f_1091_28921_28940());
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 28554, 28953);

                Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                f_1091_28676_28701()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 28676, 28701);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1091_28771_28801(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 28771, 28801);
                    return return_v;
                }


                string
                f_1091_28738_28847(Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective
                directive, System.Management.Automation.PSObject
                val, int
                enumerationLimit, Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                formatErrorObject, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = PSObjectHelper.FormatField(directive, (object)val, enumerationLimit, formatErrorObject, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 28738, 28847);
                    return return_v;
                }


                int
                f_1091_28862_28886(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 28862, 28886);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                f_1091_28921_28940()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 28921, 28940);
                    return return_v;
                }


                int
                f_1091_28901_28941(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 28901, 28941);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 28554, 28953);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 28554, 28953);
            }
        }

        private static bool TreatAsLeafNode(object val, TraversalInfo level)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1091, 29228, 29480);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 29321, 29400) || true) && (f_1091_29325_29336(level) >= f_1091_29340_29354(level) || (DynAbs.Tracing.TraceSender.Expression_False(1091, 29325, 29369) || val == null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 29321, 29400);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 29388, 29400);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 29321, 29400);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 29416, 29469);

                return f_1091_29423_29468(f_1091_29441_29467(val));
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1091, 29228, 29480);

                int
                f_1091_29325_29336(Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                this_param)
                {
                    var return_v = this_param.Level;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 29325, 29336);
                    return return_v;
                }


                int
                f_1091_29340_29354(Microsoft.PowerShell.Commands.Internal.Format.TraversalInfo
                this_param)
                {
                    var return_v = this_param.MaxDepth;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 29340, 29354);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1091_29441_29467(object
                obj)
                {
                    var return_v = PSObject.GetTypeNames(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 29441, 29467);
                    return return_v;
                }


                bool
                f_1091_29423_29468(System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = TreatAsScalarType((System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 29423, 29468);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 29228, 29480);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 29228, 29480);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static bool TreatAsScalarType(Collection<string> typeNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1091, 29721, 29874);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 29813, 29863);

                return f_1091_29820_29862(typeNames);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1091, 29721, 29874);

                bool
                f_1091_29820_29862(System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = DefaultScalarTypes.IsTypeInList(typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 29820, 29862);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 29721, 29874);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 29721, 29874);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private string GetObjectDisplayName(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 29886, 30651);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 29959, 30084) || true) && (_complexSpecificParameters.classDisplay == ComplexSpecificParameters.ClassInfoDisplay.none)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 29959, 30084);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 30072, 30084);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 29959, 30084);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 30100, 30137);

                var
                typeNames = f_1091_30116_30136(so)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 30151, 30242) || true) && (f_1091_30155_30170(typeNames) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 30151, 30242);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 30209, 30227);

                    return "PSObject";
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 30151, 30242);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 30258, 30604) || true) && (_complexSpecificParameters.classDisplay == ComplexSpecificParameters.ClassInfoDisplay.shortName)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 30258, 30604);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 30447, 30503);

                    string[]
                    arr = f_1091_30462_30502(f_1091_30462_30474(typeNames, 0), Utils.Separators.Dot)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 30521, 30589) || true) && (f_1091_30525_30535(arr) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 30521, 30589);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 30562, 30589);

                        return arr[f_1091_30573_30583(arr) - 1];
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 30521, 30589);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 30258, 30604);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 30620, 30640);

                return f_1091_30627_30639(typeNames, 0);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 29886, 30651);

                System.Management.Automation.Runspaces.ConsolidatedString
                f_1091_30116_30136(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 30116, 30136);
                    return return_v;
                }


                int
                f_1091_30155_30170(System.Management.Automation.Runspaces.ConsolidatedString
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 30155, 30170);
                    return return_v;
                }


                string
                f_1091_30462_30474(System.Management.Automation.Runspaces.ConsolidatedString
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 30462, 30474);
                    return return_v;
                }


                string[]
                f_1091_30462_30502(string
                this_param, params char[]
                separator)
                {
                    var return_v = this_param.Split(separator);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 30462, 30502);
                    return return_v;
                }


                int
                f_1091_30525_30535(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 30525, 30535);
                    return return_v;
                }


                int
                f_1091_30573_30583(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 30573, 30583);
                    return return_v;
                }


                string
                f_1091_30627_30639(System.Management.Automation.Runspaces.ConsolidatedString
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1091, 30627, 30639);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 29886, 30651);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 29886, 30651);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static void AddPrologue(List<FormatValue> formatValueList, string openTag, string label)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1091, 30663, 31246);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 30784, 31046) || true) && (label != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1091, 30784, 31046);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 30835, 30884);

                    FormatTextField
                    ftfLabel = f_1091_30862_30883()
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 30902, 30924);

                    ftfLabel.text = label;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 30942, 30972);

                    f_1091_30942_30971(formatValueList, ftfLabel);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 30990, 31031);

                    f_1091_30990_31030(formatValueList, f_1091_31010_31029());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1091, 30784, 31046);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 31062, 31106);

                FormatTextField
                ftf = f_1091_31084_31105()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 31120, 31139);

                ftf.text = openTag;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 31153, 31178);

                f_1091_31153_31177(formatValueList, ftf);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 31194, 31235);

                f_1091_31194_31234(
                            formatValueList, f_1091_31214_31233());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1091, 30663, 31246);

                Microsoft.PowerShell.Commands.Internal.Format.FormatTextField
                f_1091_30862_30883()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatTextField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 30862, 30883);
                    return return_v;
                }


                int
                f_1091_30942_30971(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatTextField
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 30942, 30971);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                f_1091_31010_31029()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 31010, 31029);
                    return return_v;
                }


                int
                f_1091_30990_31030(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 30990, 31030);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatTextField
                f_1091_31084_31105()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatTextField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 31084, 31105);
                    return return_v;
                }


                int
                f_1091_31153_31177(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatTextField
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 31153, 31177);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                f_1091_31214_31233()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 31214, 31233);
                    return return_v;
                }


                int
                f_1091_31194_31234(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 31194, 31234);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 30663, 31246);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 30663, 31246);
            }
        }

        private static void AddEpilogue(List<FormatValue> formatValueList, string closeTag)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1091, 31258, 31553);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 31366, 31410);

                FormatTextField
                ftf = f_1091_31388_31409()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 31426, 31446);

                ftf.text = closeTag;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 31460, 31485);

                f_1091_31460_31484(formatValueList, ftf);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 31501, 31542);

                f_1091_31501_31541(
                            formatValueList, f_1091_31521_31540());
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1091, 31258, 31553);

                Microsoft.PowerShell.Commands.Internal.Format.FormatTextField
                f_1091_31388_31409()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatTextField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 31388, 31409);
                    return return_v;
                }


                int
                f_1091_31460_31484(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatTextField
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 31460, 31484);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                f_1091_31521_31540()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 31521, 31540);
                    return return_v;
                }


                int
                f_1091_31501_31541(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 31501, 31541);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 31258, 31553);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 31258, 31553);
            }
        }

        private List<FormatValue> AddIndentationLevel(List<FormatValue> formatValueList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1091, 31565, 32064);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 31670, 31710);

                FormatEntry
                feFrame = f_1091_31692_31709()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 31724, 31760);

                feFrame.frameInfo = f_1091_31744_31759();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 31811, 31843);

                feFrame.frameInfo.firstLine = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 31857, 31910);

                feFrame.frameInfo.leftIndentation = _indentationStep;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 31924, 31963);

                feFrame.frameInfo.rightIndentation = 0;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 31977, 32006);

                f_1091_31977_32005(formatValueList, feFrame);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1091, 32022, 32053);

                return feFrame.formatValueList;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1091, 31565, 32064);

                Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                f_1091_31692_31709()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 31692, 31709);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FrameInfo
                f_1091_31744_31759()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FrameInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 31744, 31759);
                    return return_v;
                }


                int
                f_1091_31977_32005(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1091, 31977, 32005);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1091, 31565, 32064);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 31565, 32064);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private ComplexSpecificParameters _complexSpecificParameters;

        private int _indentationStep;

        private FormatErrorManager _errorManager;

        private PSPropertyExpressionFactory _expressionFactory;

        private int _enumerationLimit;

        static ComplexViewObjectBrowser()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1091, 17866, 32461);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1091, 17866, 32461);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1091, 17866, 32461);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1091, 17866, 32461);
    }
}

