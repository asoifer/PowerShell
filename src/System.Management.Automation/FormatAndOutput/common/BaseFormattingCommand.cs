// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management.Automation;
using System.Management.Automation.Internal;
using System.Management.Automation.Runspaces;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal class InnerFormatShapeCommandBase : ImplementationCommandBase
    {
        internal InnerFormatShapeCommandBase()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1081, 753, 876);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 1259, 1311);
                this.contextManager = f_1081_1276_1311();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 816, 865);

                f_1081_816_864(contextManager, FormattingContextState.none);
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1081, 753, 876);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 753, 876);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 753, 876);
            }
        }

        /// <summary>
        /// Enum listing the possible states the context is in.
        /// </summary>
        internal enum FormattingContextState { none, document, group }

        protected Stack<FormattingContextState> contextManager;

        static InnerFormatShapeCommandBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1081, 560, 1319);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1081, 560, 1319);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 560, 1319);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1081, 560, 1319);

        int
        f_1081_816_864(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState>
        this_param, Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState
        item)
        {
            this_param.Push(item);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 816, 864);
            return 0;
        }


        System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState>
        f_1081_1276_1311()
        {
            var return_v = new System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState>();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 1276, 1311);
            return return_v;
        }

    }
    internal class InnerFormatShapeCommand : InnerFormatShapeCommandBase
    {
        internal InnerFormatShapeCommand(FormatShape shape)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1081, 1603, 1705);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 17798, 17804);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 18219, 18237);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 18303, 18328);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 18366, 18390);
                this._typeInfoDataBase = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 18443, 18461);
                this._parameters = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 18498, 18536);
                this._viewManager = f_1081_18513_18536();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 18561, 18630);
                this._enumerationLimit = InitialSessionState.DefaultFormatEnumerationLimit;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 1679, 1694);

                _shape = shape;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1081, 1603, 1705);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 1603, 1705);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 1603, 1705);
            }
        }

        internal static int FormatEnumerationLimit()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1081, 1717, 2686);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 1786, 1813);

                object
                enumLimitVal = null
                ;
                try
                {

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 1896, 2210) || true) && (f_1081_1900_1942() != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 1896, 2210);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 1992, 2191);

                        enumLimitVal = f_1081_2007_2190(f_1081_2007_2099(f_1081_2007_2088(f_1081_2007_2049())), "global:" + InitialSessionState.FormatEnumerationLimit);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 1896, 2210);
                    }
                }
                // Eat the following exceptions, enumerationLimit will use the default value
                catch (ProviderNotFoundException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1081, 2329, 2392);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1081, 2329, 2392);
                }
                catch (ProviderInvocationException)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1081, 2406, 2471);
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1081, 2406, 2471);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 2576, 2675);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1081, 2583, 2602) || ((enumLimitVal is int && DynAbs.Tracing.TraceSender.Conditional_F2(1081, 2605, 2622)) || DynAbs.Tracing.TraceSender.Conditional_F3(1081, 2625, 2674))) ? (int)enumLimitVal : InitialSessionState.DefaultFormatEnumerationLimit;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1081, 1717, 2686);

                System.Management.Automation.ExecutionContext
                f_1081_1900_1942()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 1900, 1942);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1081_2007_2049()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 2007, 2049);
                    return return_v;
                }


                System.Management.Automation.SessionState
                f_1081_2007_2088(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.SessionState;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 2007, 2088);
                    return return_v;
                }


                System.Management.Automation.PSVariableIntrinsics
                f_1081_2007_2099(System.Management.Automation.SessionState
                this_param)
                {
                    var return_v = this_param.PSVariable
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 2007, 2099);
                    return return_v;
                }


                object
                f_1081_2007_2190(System.Management.Automation.PSVariableIntrinsics
                this_param, string
                name)
                {
                    var return_v = this_param.GetValue(name);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 2007, 2190);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 1717, 2686);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 1717, 2686);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 2698, 3106);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 2763, 2786);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(), 1081, 2763, 2785);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 2852, 2921);

                _enumerationLimit = f_1081_2872_2920();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 2937, 2992);

                _expressionFactory = f_1081_2958_2991();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 3008, 3095);

                _formatObjectDeserializer = f_1081_3036_3094(f_1081_3065_3093(this));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 2698, 3106);

                int
                f_1081_2872_2920()
                {
                    var return_v = InnerFormatShapeCommand.FormatEnumerationLimit();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 2872, 2920);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                f_1081_2958_2991()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 2958, 2991);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1081_3065_3093(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param)
                {
                    var return_v = this_param.TerminatingErrorContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 3065, 3093);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                f_1081_3036_3094(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer(errorContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 3036, 3094);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 2698, 3106);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 2698, 3106);
            }
        }

        internal override void ProcessRecord()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 3201, 4863);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 3264, 3349);

                _typeInfoDataBase = f_1081_3284_3348(f_1081_3284_3326(f_1081_3284_3310(f_1081_3284_3302(this))));
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 3365, 3397);

                PSObject
                so = f_1081_3379_3396(this)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 3411, 3481) || true) && (so == null || (DynAbs.Tracing.TraceSender.Expression_False(1081, 3415, 3455) || so == f_1081_3435_3455()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 3411, 3481);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 3474, 3481);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 3411, 3481);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 3497, 3546);

                IEnumerable
                e = f_1081_3513_3545(so)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 3560, 3665) || true) && (e == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 3560, 3665);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 3607, 3625);

                    f_1081_3607_3624(this, so);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 3643, 3650);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 3560, 3665);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 3763, 3827);

                EnumerableExpansion
                expansionState = f_1081_3800_3826(this, so)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 3843, 4852);

                switch (expansionState)
                {

                    case EnumerableExpansion.EnumOnly:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 3843, 4852);
                        {
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 3982, 4137);
                                foreach (object obj in f_1081_4005_4006_I(e))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 3982, 4137);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 4064, 4110);

                                    f_1081_4064_4109(this, f_1081_4078_4108(obj));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 3982, 4137);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1081, 1, 156);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1081, 1, 156);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1081, 4184, 4190);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 3843, 4852);

                    case EnumerableExpansion.Both:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 3843, 4852);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 4287, 4325);

                            var
                            objs = f_1081_4298_4324(f_1081_4298_4314(e))
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 4353, 4391);

                            f_1081_4353_4390(this, so, f_1081_4378_4389(objs));
                            try
                            {
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 4417, 4575);
                                foreach (object obj in f_1081_4440_4444_I(objs))
                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 4417, 4575);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 4502, 4548);

                                    f_1081_4502_4547(this, f_1081_4516_4546(obj));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 4417, 4575);
                                }
                            }
                            catch (System.Exception)
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoopByException(1081, 1, 159);
                                throw;
                            }
                            finally
                            {
                                DynAbs.Tracing.TraceSender.TraceExitLoop(1081, 1, 159);
                            }
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1081, 4622, 4628);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 3843, 4852);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 3843, 4852);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 4766, 4784);

                            f_1081_4766_4783(this, so);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1081, 4831, 4837);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 3843, 4852);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 3201, 4863);

                System.Management.Automation.PSCmdlet
                f_1081_3284_3302(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param)
                {
                    var return_v = this_param.OuterCmdlet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 3284, 3302);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1081_3284_3310(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.Context;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 3284, 3310);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager
                f_1081_3284_3326(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.FormatDBManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 3284, 3326);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                f_1081_3284_3348(Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBaseManager
                this_param)
                {
                    var return_v = this_param.GetTypeInfoDataBase();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 3284, 3348);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1081_3379_3396(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param)
                {
                    var return_v = this_param.ReadObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 3379, 3396);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1081_3435_3455()
                {
                    var return_v = AutomationNull.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 3435, 3455);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1081_3513_3545(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObjectHelper.GetEnumerable((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 3513, 3545);
                    return return_v;
                }


                int
                f_1081_3607_3624(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so)
                {
                    this_param.ProcessObject(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 3607, 3624);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansion
                f_1081_3800_3826(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.GetExpansionState(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 3800, 3826);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1081_4078_4108(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 4078, 4108);
                    return return_v;
                }


                int
                f_1081_4064_4109(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so)
                {
                    this_param.ProcessObject(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 4064, 4109);
                    return 0;
                }


                System.Collections.IEnumerable
                f_1081_4005_4006_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 4005, 4006);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<object>
                f_1081_4298_4314(System.Collections.IEnumerable
                source)
                {
                    var return_v = source.Cast<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 4298, 4314);
                    return return_v;
                }


                object[]
                f_1081_4298_4324(System.Collections.Generic.IEnumerable<object>
                source)
                {
                    var return_v = source.ToArray<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 4298, 4324);
                    return return_v;
                }


                int
                f_1081_4378_4389(object[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 4378, 4389);
                    return return_v;
                }


                int
                f_1081_4353_4390(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so, int
                count)
                {
                    this_param.ProcessCoreOutOfBand(so, count);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 4353, 4390);
                    return 0;
                }


                System.Management.Automation.PSObject
                f_1081_4516_4546(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 4516, 4546);
                    return return_v;
                }


                int
                f_1081_4502_4547(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so)
                {
                    this_param.ProcessObject(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 4502, 4547);
                    return 0;
                }


                object[]
                f_1081_4440_4444_I(object[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 4440, 4444);
                    return return_v;
                }


                int
                f_1081_4766_4783(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so)
                {
                    this_param.ProcessObject(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 4766, 4783);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 3201, 4863);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 3201, 4863);
            }
        }

        private EnumerableExpansion GetExpansionState(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 4875, 5456);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 5045, 5186) || true) && (_parameters != null && (DynAbs.Tracing.TraceSender.Expression_True(1081, 5049, 5102) && f_1081_5072_5102(_parameters.expansion)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 5045, 5186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 5136, 5171);

                    return f_1081_5143_5170(_parameters.expansion);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 5045, 5186);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 5271, 5308);

                var
                typeNames = f_1081_5287_5307(so)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 5322, 5445);

                return f_1081_5329_5444(_expressionFactory, _typeInfoDataBase, typeNames);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 4875, 5456);

                bool
                f_1081_5072_5102(Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansion?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 5072, 5102);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansion
                f_1081_5143_5170(Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansion?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 5143, 5170);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1081_5287_5307(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 5287, 5307);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansion
                f_1081_5329_5444(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = DisplayDataQuery.GetEnumerableExpansionFromType(expressionFactory, db, (System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 5329, 5444);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 4875, 5456);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 4875, 5456);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void ProcessCoreOutOfBand(PSObject so, int count)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 5468, 6540);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 5595, 5654);

                f_1081_5595_5653(this, f_1081_5616_5652());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 5717, 5764);

                f_1081_5717_5763(this, so, isProcessingError: false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 5780, 5791);

                string
                msg
                = default(string);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 5895, 6487);

                switch (count)
                {

                    case 0:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 5895, 6487);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 5998, 6044);

                            msg = f_1081_6004_6043();
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1081, 6091, 6097);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 5895, 6487);

                    case 1:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 5895, 6487);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 6171, 6217);

                            msg = f_1081_6177_6216();
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1081, 6264, 6270);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 5895, 6487);

                    default:
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 5895, 6487);
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 6345, 6419);

                            msg = f_1081_6351_6418(f_1081_6369_6410(), count);
                        }
                        DynAbs.Tracing.TraceSender.TraceBreak(1081, 6466, 6472);

                        break;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 5895, 6487);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 6503, 6529);

                f_1081_6503_6528(this, msg);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 5468, 6540);

                string
                f_1081_5616_5652()
                {
                    var return_v = FormatAndOut_format_xxx.IEnum_Header;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 5616, 5652);
                    return return_v;
                }


                int
                f_1081_5595_5653(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, string
                msg)
                {
                    this_param.SendCommentOutOfBand(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 5595, 5653);
                    return 0;
                }


                bool
                f_1081_5717_5763(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so, bool
                isProcessingError)
                {
                    var return_v = this_param.ProcessOutOfBand(so, isProcessingError: isProcessingError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 5717, 5763);
                    return return_v;
                }


                string
                f_1081_6004_6043()
                {
                    var return_v = FormatAndOut_format_xxx.IEnum_NoObjects;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 6004, 6043);
                    return return_v;
                }


                string
                f_1081_6177_6216()
                {
                    var return_v = FormatAndOut_format_xxx.IEnum_OneObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 6177, 6216);
                    return return_v;
                }


                string
                f_1081_6369_6410()
                {
                    var return_v = FormatAndOut_format_xxx.IEnum_ManyObjects;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 6369, 6410);
                    return return_v;
                }


                string
                f_1081_6351_6418(string
                formatSpec, int
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, (object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 6351, 6418);
                    return return_v;
                }


                int
                f_1081_6503_6528(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, string
                msg)
                {
                    this_param.SendCommentOutOfBand(msg);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 6503, 6528);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 5468, 6540);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 5468, 6540);
            }
        }

        private void SendCommentOutOfBand(string msg)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 6552, 6848);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 6622, 6737);

                FormatEntryData
                fed = f_1081_6644_6736(f_1081_6705_6735(msg))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 6751, 6837) || true) && (fed != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 6751, 6837);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 6800, 6822);

                    f_1081_6800_6821(this, fed);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 6751, 6837);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 6552, 6848);

                System.Management.Automation.PSObject
                f_1081_6705_6735(string
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 6705, 6735);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                f_1081_6644_6736(System.Management.Automation.PSObject
                so)
                {
                    var return_v = OutOfBandFormatViewManager.GenerateOutOfBandObjectAsToString(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 6644, 6736);
                    return return_v;
                }


                int
                f_1081_6800_6821(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                o)
                {
                    this_param.WriteObject((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 6800, 6821);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 6552, 6848);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 6552, 6848);
            }
        }

        private void ProcessObject(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 7016, 9627);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 7177, 7370) || true) && (f_1081_7181_7227(_formatObjectDeserializer, so))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 7177, 7370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 7309, 7330);

                    f_1081_7309_7329(                // we are already formatted...
                                    this, so);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 7348, 7355);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 7177, 7370);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 7588, 7697) || true) && (f_1081_7592_7641(this, so))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 7588, 7697);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 7675, 7682);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 7588, 7697);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 7770, 7821);

                FormattingContextState
                ctx = f_1081_7799_7820(contextManager)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 7835, 8311) || true) && (ctx == FormattingContextState.none)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 7835, 8311);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 7955, 8073);

                    f_1081_7955_8072(                // initialize the view manager
                                    _viewManager, f_1081_7979_8007(this), _expressionFactory, _typeInfoDataBase, so, _shape, _parameters);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 8151, 8176);

                    f_1081_8151_8175(this, so);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 8243, 8296);

                    f_1081_8243_8295(
                                    // enter the document context
                                    contextManager, FormattingContextState.document);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 7835, 8311);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 8510, 8618) || true) && (f_1081_8514_8562(this, so))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 8510, 8618);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 8596, 8603);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 8510, 8618);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 8692, 8748);

                GroupTransition
                transition = f_1081_8721_8747(this, so)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 8762, 9616) || true) && (transition == GroupTransition.enter)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 8762, 9616);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 8885, 8899);

                    f_1081_8885_8898(this, so);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 8917, 8945);

                    f_1081_8917_8944(this, so);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 8762, 9616);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 8762, 9616);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 8979, 9616) || true) && (transition == GroupTransition.exit)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 8979, 9616);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 9051, 9079);

                        f_1081_9051_9078(this, so);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 9145, 9156);

                        f_1081_9145_9155(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 8979, 9616);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 8979, 9616);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 9190, 9616) || true) && (transition == GroupTransition.startNew)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 9190, 9616);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 9304, 9315);

                            f_1081_9304_9314(this);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 9357, 9371);

                            f_1081_9357_9370(this, so);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 9414, 9442);

                            f_1081_9414_9441(this, so);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 9190, 9616);
                        }

                        else // none, we did not have any transitions, just push out the data

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 9190, 9616);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 9573, 9601);

                            f_1081_9573_9600(this, so);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 9190, 9616);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 8979, 9616);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 8762, 9616);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 7016, 9627);

                bool
                f_1081_7181_7227(Microsoft.PowerShell.Commands.Internal.Format.FormatObjectDeserializer
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.IsFormatInfoData(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 7181, 7227);
                    return return_v;
                }


                int
                f_1081_7309_7329(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                o)
                {
                    this_param.WriteObject((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 7309, 7329);
                    return 0;
                }


                bool
                f_1081_7592_7641(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.ProcessOutOfBandObjectOutsideDocumentSequence(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 7592, 7641);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState
                f_1081_7799_7820(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 7799, 7820);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1081_7979_8007(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param)
                {
                    var return_v = this_param.TerminatingErrorContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 7979, 8007);
                    return return_v;
                }


                int
                f_1081_7955_8072(Microsoft.PowerShell.Commands.Internal.Format.FormatViewManager
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.FormatShape
                shape, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                parameters)
                {
                    this_param.Initialize(errorContext, expressionFactory, db, so, shape, parameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 7955, 8072);
                    return 0;
                }


                int
                f_1081_8151_8175(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so)
                {
                    this_param.WriteFormatStartData(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 8151, 8175);
                    return 0;
                }


                int
                f_1081_8243_8295(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 8243, 8295);
                    return 0;
                }


                bool
                f_1081_8514_8562(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.ProcessOutOfBandObjectInsideDocumentSequence(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 8514, 8562);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand.GroupTransition
                f_1081_8721_8747(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.ComputeGroupTransition(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 8721, 8747);
                    return return_v;
                }


                int
                f_1081_8885_8898(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                firstObjectInGroup)
                {
                    this_param.PushGroup(firstObjectInGroup);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 8885, 8898);
                    return 0;
                }


                int
                f_1081_8917_8944(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so)
                {
                    this_param.WritePayloadObject(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 8917, 8944);
                    return 0;
                }


                int
                f_1081_9051_9078(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so)
                {
                    this_param.WritePayloadObject(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 9051, 9078);
                    return 0;
                }


                int
                f_1081_9145_9155(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param)
                {
                    this_param.PopGroup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 9145, 9155);
                    return 0;
                }


                int
                f_1081_9304_9314(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param)
                {
                    this_param.PopGroup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 9304, 9314);
                    return 0;
                }


                int
                f_1081_9357_9370(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                firstObjectInGroup)
                {
                    this_param.PushGroup(firstObjectInGroup);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 9357, 9370);
                    return 0;
                }


                int
                f_1081_9414_9441(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so)
                {
                    this_param.WritePayloadObject(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 9414, 9441);
                    return 0;
                }


                int
                f_1081_9573_9600(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so)
                {
                    this_param.WritePayloadObject(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 9573, 9600);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 7016, 9627);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 7016, 9627);
            }
        }

        private bool ShouldProcessOutOfBand
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 9699, 9952);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 9735, 9866) || true) && (_shape == FormatShape.Undefined || (DynAbs.Tracing.TraceSender.Expression_False(1081, 9739, 9793) || _parameters == null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 9735, 9866);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 9835, 9847);

                        return true;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 9735, 9866);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 9886, 9937);

                    return !_parameters.forceFormattingAlsoOnOutOfBand;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 9699, 9952);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 9639, 9963);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 9639, 9963);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        private bool ProcessOutOfBandObjectOutsideDocumentSequence(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 9975, 10727);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10071, 10160) || true) && (f_1081_10075_10098_M(!ShouldProcessOutOfBand))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 10071, 10160);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10132, 10145);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 10071, 10160);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10176, 10273) || true) && (f_1081_10180_10206(f_1081_10180_10200(so)) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 10176, 10273);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10245, 10258);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 10176, 10273);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10289, 10314);

                List<ErrorRecord>
                errors
                = default(List<ErrorRecord>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10328, 10515);

                var
                fed = f_1081_10338_10514(f_1081_10387_10415(this), _expressionFactory, _typeInfoDataBase, so, _enumerationLimit, false, out errors)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10529, 10555);

                f_1081_10529_10554(this, errors);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10571, 10687) || true) && (fed != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 10571, 10687);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10620, 10642);

                    f_1081_10620_10641(this, fed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10660, 10672);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 10571, 10687);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10703, 10716);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 9975, 10727);

                bool
                f_1081_10075_10098_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 10075, 10098);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1081_10180_10200(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 10180, 10200);
                    return return_v;
                }


                int
                f_1081_10180_10206(System.Management.Automation.Runspaces.ConsolidatedString
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 10180, 10206);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1081_10387_10415(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param)
                {
                    var return_v = this_param.TerminatingErrorContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 10387, 10415);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                f_1081_10338_10514(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Management.Automation.PSObject
                so, int
                enumerationLimit, bool
                useToStringFallback, out System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
                errors)
                {
                    var return_v = OutOfBandFormatViewManager.GenerateOutOfBandData(errorContext, expressionFactory, db, so, enumerationLimit, useToStringFallback, out errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 10338, 10514);
                    return return_v;
                }


                int
                f_1081_10529_10554(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
                errorRecordList)
                {
                    this_param.WriteErrorRecords(errorRecordList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 10529, 10554);
                    return 0;
                }


                int
                f_1081_10620_10641(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                o)
                {
                    this_param.WriteObject((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 10620, 10641);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 9975, 10727);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 9975, 10727);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ProcessOutOfBandObjectInsideDocumentSequence(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 10739, 11193);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10834, 10923) || true) && (f_1081_10838_10861_M(!ShouldProcessOutOfBand))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 10834, 10923);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10895, 10908);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 10834, 10923);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10939, 10976);

                var
                typeNames = f_1081_10955_10975(so)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 10990, 11112) || true) && (f_1081_10994_11050(f_1081_10994_11020(_viewManager), typeNames))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 10990, 11112);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 11084, 11097);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 10990, 11112);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 11128, 11182);

                return f_1081_11135_11181(this, so, isProcessingError: false);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 10739, 11193);

                bool
                f_1081_10838_10861_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 10838, 10861);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1081_10955_10975(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 10955, 10975);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1081_10994_11020(Microsoft.PowerShell.Commands.Internal.Format.FormatViewManager
                this_param)
                {
                    var return_v = this_param.ViewGenerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 10994, 11020);
                    return return_v;
                }


                bool
                f_1081_10994_11050(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = this_param.IsObjectApplicable((System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 10994, 11050);
                    return return_v;
                }


                bool
                f_1081_11135_11181(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so, bool
                isProcessingError)
                {
                    var return_v = this_param.ProcessOutOfBand(so, isProcessingError: isProcessingError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 11135, 11181);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 10739, 11193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 10739, 11193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private bool ProcessOutOfBand(PSObject so, bool isProcessingError)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 11205, 11806);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 11296, 11321);

                List<ErrorRecord>
                errors
                = default(List<ErrorRecord>);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 11335, 11553);

                FormatEntryData
                fed = f_1081_11357_11552(f_1081_11406_11434(this), _expressionFactory, _typeInfoDataBase, so, _enumerationLimit, true, out errors)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 11567, 11634) || true) && (!isProcessingError)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 11567, 11634);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 11608, 11634);

                    f_1081_11608_11633(this, errors);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 11567, 11634);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 11650, 11766) || true) && (fed != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 11650, 11766);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 11699, 11721);

                    f_1081_11699_11720(this, fed);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 11739, 11751);

                    return true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 11650, 11766);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 11782, 11795);

                return false;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 11205, 11806);

                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1081_11406_11434(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param)
                {
                    var return_v = this_param.TerminatingErrorContext;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 11406, 11434);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                f_1081_11357_11552(Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                errorContext, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Management.Automation.PSObject
                so, int
                enumerationLimit, bool
                useToStringFallback, out System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
                errors)
                {
                    var return_v = OutOfBandFormatViewManager.GenerateOutOfBandData(errorContext, expressionFactory, db, so, enumerationLimit, useToStringFallback, out errors);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 11357, 11552);
                    return return_v;
                }


                int
                f_1081_11608_11633(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
                errorRecordList)
                {
                    this_param.WriteErrorRecords(errorRecordList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 11608, 11633);
                    return 0;
                }


                int
                f_1081_11699_11720(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                o)
                {
                    this_param.WriteObject((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 11699, 11720);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 11205, 11806);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 11205, 11806);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected void WriteInternalErrorMessage(string message)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 11818, 12521);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 11899, 11943);

                FormatEntryData
                fed = f_1081_11921_11942()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 11957, 11978);

                fed.outOfBand = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 11994, 12040);

                ComplexViewEntry
                cve = f_1081_12017_12039()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 12054, 12089);

                FormatEntry
                fe = f_1081_12071_12088()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 12103, 12131);

                f_1081_12103_12130(cve.formatValueList, fe);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 12147, 12191);

                f_1081_12147_12190(
                            fe.formatValueList, f_1081_12170_12189());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 12251, 12295);

                FormatTextField
                ftf = f_1081_12273_12294()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 12309, 12328);

                ftf.text = message;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 12342, 12370);

                f_1081_12342_12369(fe.formatValueList, ftf);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 12386, 12430);

                f_1081_12386_12429(
                            fe.formatValueList, f_1081_12409_12428());
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 12446, 12472);

                fed.formatEntryInfo = cve;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 12488, 12510);

                f_1081_12488_12509(
                            this, fed);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 11818, 12521);

                Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                f_1081_11921_11942()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 11921, 11942);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ComplexViewEntry
                f_1081_12017_12039()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ComplexViewEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 12017, 12039);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                f_1081_12071_12088()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 12071, 12088);
                    return return_v;
                }


                int
                f_1081_12103_12130(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntry
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 12103, 12130);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                f_1081_12170_12189()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 12170, 12189);
                    return return_v;
                }


                int
                f_1081_12147_12190(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 12147, 12190);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatTextField
                f_1081_12273_12294()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatTextField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 12273, 12294);
                    return return_v;
                }


                int
                f_1081_12342_12369(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatTextField
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 12342, 12369);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                f_1081_12409_12428()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 12409, 12428);
                    return return_v;
                }


                int
                f_1081_12386_12429(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatValue>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatNewLine
                item)
                {
                    this_param.Add((Microsoft.PowerShell.Commands.Internal.Format.FormatValue)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 12386, 12429);
                    return 0;
                }


                int
                f_1081_12488_12509(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                o)
                {
                    this_param.WriteObject((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 12488, 12509);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 11818, 12521);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 11818, 12521);
            }
        }

        private void WriteErrorRecords(List<ErrorRecord> errorRecordList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 12533, 13286);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 12623, 12676) || true) && (errorRecordList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 12623, 12676);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 12669, 12676);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 12623, 12676);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 13027, 13275);
                    foreach (ErrorRecord errorRecord in f_1081_13063_13078_I(errorRecordList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 13027, 13275);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 13197, 13260);

                        f_1081_13197_13259(this, f_1081_13214_13252(errorRecord), true);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 13027, 13275);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1081, 1, 249);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1081, 1, 249);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 12533, 13286);

                System.Management.Automation.PSObject
                f_1081_13214_13252(System.Management.Automation.ErrorRecord
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 13214, 13252);
                    return return_v;
                }


                bool
                f_1081_13197_13259(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Management.Automation.PSObject
                so, bool
                isProcessingError)
                {
                    var return_v = this_param.ProcessOutOfBand(so, isProcessingError);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 13197, 13259);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
                f_1081_13063_13078_I(System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 13063, 13078);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 12533, 13286);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 12533, 13286);
            }
        }

        internal override void EndProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 13298, 14207);
                try
                {
                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 13473, 14196) || true) && (true)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 13473, 14196);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 13518, 13569);

                        FormattingContextState
                        ctx = f_1081_13547_13568(contextManager)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 13589, 14181) || true) && (ctx == FormattingContextState.none)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 13589, 14181);
                            DynAbs.Tracing.TraceSender.TraceBreak(1081, 13669, 13675);

                            break;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 13589, 14181);
                        }

                        else
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 13589, 14181);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 13747, 14181) || true) && (ctx == FormattingContextState.group)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 13747, 14181);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 13828, 13839);

                                f_1081_13828_13838(this);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 13747, 14181);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 13747, 14181);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 13881, 14181) || true) && (ctx == FormattingContextState.document)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 13881, 14181);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 14023, 14069);

                                    FormatEndData
                                    endFormat = f_1081_14049_14068()
                                    ;
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 14091, 14119);

                                    f_1081_14091_14118(this, endFormat);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 14141, 14162);

                                    f_1081_14141_14161(contextManager);
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 13881, 14181);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 13747, 14181);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 13589, 14181);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 13473, 14196);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1081, 13473, 14196);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1081, 13473, 14196);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 13298, 14207);

                Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState
                f_1081_13547_13568(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 13547, 13568);
                    return return_v;
                }


                int
                f_1081_13828_13838(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param)
                {
                    this_param.PopGroup();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 13828, 13838);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatEndData
                f_1081_14049_14068()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEndData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 14049, 14068);
                    return return_v;
                }


                int
                f_1081_14091_14118(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEndData
                o)
                {
                    this_param.WriteObject((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 14091, 14118);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState
                f_1081_14141_14161(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 14141, 14161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 13298, 14207);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 13298, 14207);
            }
        }

        internal void SetCommandLineParameters(FormattingCommandLineParameters commandLineParameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 14219, 14491);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 14337, 14430);

                f_1081_14337_14429(commandLineParameters != null, "the caller has to pass a valid instance");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 14444, 14480);

                _parameters = commandLineParameters;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 14219, 14491);

                int
                f_1081_14337_14429(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 14337, 14429);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 14219, 14491);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 14219, 14491);
            }
        }

        /// <summary>
        /// Group transitions:
        /// none: stay in the same group
        /// enter: start a new group
        /// exit: exit from the current group.
        /// </summary>
        private enum GroupTransition { none, enter, exit, startNew }

        private GroupTransition ComputeGroupTransition(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 15035, 15814);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 15169, 15220);

                FormattingContextState
                ctx = f_1081_15198_15219(contextManager)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 15234, 15542) || true) && (ctx == FormattingContextState.document)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 15234, 15542);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 15359, 15413);

                    f_1081_15359_15412(f_1081_15359_15385(_viewManager), so);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 15498, 15527);

                    return GroupTransition.enter;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 15234, 15542);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 15692, 15803);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1081, 15699, 15752) || ((f_1081_15699_15752(f_1081_15699_15725(_viewManager), so) && DynAbs.Tracing.TraceSender.Conditional_F2(1081, 15755, 15779)) || DynAbs.Tracing.TraceSender.Conditional_F3(1081, 15782, 15802))) ? GroupTransition.startNew : GroupTransition.none;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 15035, 15814);

                Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState
                f_1081_15198_15219(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState>
                this_param)
                {
                    var return_v = this_param.Peek();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 15198, 15219);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1081_15359_15385(Microsoft.PowerShell.Commands.Internal.Format.FormatViewManager
                this_param)
                {
                    var return_v = this_param.ViewGenerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 15359, 15385);
                    return return_v;
                }


                bool
                f_1081_15359_15412(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.UpdateGroupingKeyValue(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 15359, 15412);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1081_15699_15725(Microsoft.PowerShell.Commands.Internal.Format.FormatViewManager
                this_param)
                {
                    var return_v = this_param.ViewGenerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 15699, 15725);
                    return return_v;
                }


                bool
                f_1081_15699_15752(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.UpdateGroupingKeyValue(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 15699, 15752);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 15035, 15814);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 15035, 15814);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void WriteFormatStartData(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 15826, 16031);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 15897, 15976);

                FormatStartData
                startFormat = f_1081_15927_15975(f_1081_15927_15953(_viewManager), so)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 15990, 16020);

                f_1081_15990_16019(this, startFormat);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 15826, 16031);

                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1081_15927_15953(Microsoft.PowerShell.Commands.Internal.Format.FormatViewManager
                this_param)
                {
                    var return_v = this_param.ViewGenerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 15927, 15953);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatStartData
                f_1081_15927_15975(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.GenerateStartData(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 15927, 15975);
                    return return_v;
                }


                int
                f_1081_15990_16019(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatStartData
                o)
                {
                    this_param.WriteObject((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 15990, 16019);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 15826, 16031);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 15826, 16031);
            }
        }

        private void WritePayloadObject(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 16247, 16718);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 16316, 16375);

                f_1081_16316_16374(so != null, "object so cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 16389, 16477);

                FormatEntryData
                fed = f_1081_16411_16476(f_1081_16411_16437(_viewManager), so, _enumerationLimit)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 16491, 16524);

                fed.writeStream = f_1081_16509_16523(so);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 16538, 16560);

                f_1081_16538_16559(this, fed);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 16576, 16667);

                List<ErrorRecord>
                errors = f_1081_16603_16666(f_1081_16603_16642(f_1081_16603_16629(_viewManager)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 16681, 16707);

                f_1081_16681_16706(this, errors);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 16247, 16718);

                int
                f_1081_16316_16374(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 16316, 16374);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1081_16411_16437(Microsoft.PowerShell.Commands.Internal.Format.FormatViewManager
                this_param)
                {
                    var return_v = this_param.ViewGenerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 16411, 16437);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                f_1081_16411_16476(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit)
                {
                    var return_v = this_param.GeneratePayload(so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 16411, 16476);
                    return return_v;
                }


                System.Management.Automation.WriteStreamType
                f_1081_16509_16523(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.WriteStream;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 16509, 16523);
                    return return_v;
                }


                int
                f_1081_16538_16559(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                o)
                {
                    this_param.WriteObject((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 16538, 16559);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1081_16603_16629(Microsoft.PowerShell.Commands.Internal.Format.FormatViewManager
                this_param)
                {
                    var return_v = this_param.ViewGenerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 16603, 16629);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                f_1081_16603_16642(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param)
                {
                    var return_v = this_param.ErrorManager;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 16603, 16642);
                    return return_v;
                }


                System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
                f_1081_16603_16666(Microsoft.PowerShell.Commands.Internal.Format.FormatErrorManager
                this_param)
                {
                    var return_v = this_param.DrainFailedResultList();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 16603, 16666);
                    return return_v;
                }


                int
                f_1081_16681_16706(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, System.Collections.Generic.List<System.Management.Automation.ErrorRecord>
                errorRecordList)
                {
                    this_param.WriteErrorRecords(errorRecordList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 16681, 16706);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 16247, 16718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 16247, 16718);
            }
        }

        private void PushGroup(PSObject firstObjectInGroup)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 16989, 17300);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 17065, 17182);

                GroupStartData
                startGroup = f_1081_17093_17181(f_1081_17093_17119(_viewManager), firstObjectInGroup, _enumerationLimit)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 17196, 17225);

                f_1081_17196_17224(this, startGroup);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 17239, 17289);

                f_1081_17239_17288(contextManager, FormattingContextState.group);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 16989, 17300);

                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1081_17093_17119(Microsoft.PowerShell.Commands.Internal.Format.FormatViewManager
                this_param)
                {
                    var return_v = this_param.ViewGenerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 17093, 17119);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.GroupStartData
                f_1081_17093_17181(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param, System.Management.Automation.PSObject
                firstObjectInGroup, int
                enumerationLimit)
                {
                    var return_v = this_param.GenerateGroupStartData(firstObjectInGroup, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 17093, 17181);
                    return return_v;
                }


                int
                f_1081_17196_17224(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, Microsoft.PowerShell.Commands.Internal.Format.GroupStartData
                o)
                {
                    this_param.WriteObject((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 17196, 17224);
                    return 0;
                }


                int
                f_1081_17239_17288(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState
                item)
                {
                    this_param.Push(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 17239, 17288);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 16989, 17300);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 16989, 17300);
            }
        }

        private void PopGroup()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 17454, 17663);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 17502, 17576);

                GroupEndData
                endGroup = f_1081_17526_17575(f_1081_17526_17552(_viewManager))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 17590, 17617);

                f_1081_17590_17616(this, endGroup);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 17631, 17652);

                f_1081_17631_17651(contextManager);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 17454, 17663);

                Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                f_1081_17526_17552(Microsoft.PowerShell.Commands.Internal.Format.FormatViewManager
                this_param)
                {
                    var return_v = this_param.ViewGenerator;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 17526, 17552);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.GroupEndData
                f_1081_17526_17575(Microsoft.PowerShell.Commands.Internal.Format.ViewGenerator
                this_param)
                {
                    var return_v = this_param.GenerateGroupEndData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 17526, 17575);
                    return return_v;
                }


                int
                f_1081_17590_17616(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, Microsoft.PowerShell.Commands.Internal.Format.GroupEndData
                o)
                {
                    this_param.WriteObject((object)o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 17590, 17616);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState
                f_1081_17631_17651(System.Collections.Generic.Stack<Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommandBase.FormattingContextState>
                this_param)
                {
                    var return_v = this_param.Pop();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 17631, 17651);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 17454, 17663);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 17454, 17663);
            }
        }

        private FormatShape _shape;

        internal ScriptBlock CreateScriptBlock(string scriptText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 17914, 18171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 17996, 18074);

                var
                scriptBlock = f_1081_18014_18073(f_1081_18014_18046(f_1081_18014_18032(this)), scriptText)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 18088, 18127);

                scriptBlock.DebuggerStepThrough = true;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 18141, 18160);

                return scriptBlock;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 17914, 18171);

                System.Management.Automation.PSCmdlet
                f_1081_18014_18032(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param)
                {
                    var return_v = this_param.OuterCmdlet();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 18014, 18032);
                    return return_v;
                }


                System.Management.Automation.CommandInvocationIntrinsics
                f_1081_18014_18046(System.Management.Automation.PSCmdlet
                this_param)
                {
                    var return_v = this_param.InvokeCommand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 18014, 18046);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1081_18014_18073(System.Management.Automation.CommandInvocationIntrinsics
                this_param, string
                scriptText)
                {
                    var return_v = this_param.NewScriptBlock(scriptText);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 18014, 18073);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 17914, 18171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 17914, 18171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private PSPropertyExpressionFactory _expressionFactory;

        private FormatObjectDeserializer _formatObjectDeserializer;

        private TypeInfoDataBase _typeInfoDataBase;

        private FormattingCommandLineParameters _parameters;

        private FormatViewManager _viewManager;

        private int _enumerationLimit;

        static InnerFormatShapeCommand()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1081, 1426, 18638);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1081, 1426, 18638);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 1426, 18638);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1081, 1426, 18638);

        Microsoft.PowerShell.Commands.Internal.Format.FormatViewManager
        f_1081_18513_18536()
        {
            var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatViewManager();
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 18513, 18536);
            return return_v;
        }

    }
    public class OuterFormatShapeCommandBase : FrontEndCommandBase
    {
        [Parameter]
        public object GroupBy { get; set; }

        [Parameter]
        public string View { get; set; }

        [Parameter]
        public SwitchParameter ShowError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 19424, 19596);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 19460, 19550) || true) && (f_1081_19464_19493(showErrorsAsMessages))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 19460, 19550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 19516, 19550);

                        return f_1081_19523_19549(showErrorsAsMessages);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 19460, 19550);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 19568, 19581);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 19424, 19596);

                    bool
                    f_1081_19464_19493(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 19464, 19493);
                        return return_v;
                    }


                    bool
                    f_1081_19523_19549(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 19523, 19549);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 19346, 19660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 19346, 19660);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 19612, 19649);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 19618, 19647);

                    showErrorsAsMessages = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 19612, 19649);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 19346, 19660);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 19346, 19660);
                }
            }
        }

        internal bool? showErrorsAsMessages;

        [Parameter]
        public SwitchParameter DisplayError
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 19933, 20119);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 19969, 20073) || true) && (f_1081_19973_20009(showErrorsInFormattedOutput))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 19969, 20073);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 20032, 20073);

                        return f_1081_20039_20072(showErrorsInFormattedOutput);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 19969, 20073);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 20091, 20104);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 19933, 20119);

                    bool
                    f_1081_19973_20009(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 19973, 20009);
                        return return_v;
                    }


                    bool
                    f_1081_20039_20072(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 20039, 20072);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 19852, 20190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 19852, 20190);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 20135, 20179);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 20141, 20177);

                    showErrorsInFormattedOutput = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 20135, 20179);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 19852, 20190);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 19852, 20190);
                }
            }
        }

        internal bool? showErrorsInFormattedOutput;

        [Parameter]
        public SwitchParameter Force
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 20463, 20510);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 20469, 20508);

                    return _forceFormattingAlsoOnOutOfBand;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 20463, 20510);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 20389, 20585);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 20389, 20585);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 20526, 20574);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 20532, 20572);

                    _forceFormattingAlsoOnOutOfBand = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 20526, 20574);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 20389, 20585);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 20389, 20585);
                }
            }
        }

        private bool _forceFormattingAlsoOnOutOfBand;

        [Parameter]
        [ValidateSet(EnumerableExpansionConversion.CoreOnlyString,
                                EnumerableExpansionConversion.EnumOnlyString,
                                EnumerableExpansionConversion.BothString, IgnoreCase = true)]
        public string Expand { get; set; }

        internal EnumerableExpansion? expansion;

        internal EnumerableExpansion? ProcessExpandParameter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 21139, 21905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 21218, 21253);

                EnumerableExpansion?
                retVal = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 21267, 21360) || true) && (f_1081_21271_21299(f_1081_21292_21298()))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 21267, 21360);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 21333, 21345);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 21267, 21360);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 21376, 21401);

                EnumerableExpansion
                temp
                = default(EnumerableExpansion);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 21415, 21486);

                bool
                success = f_1081_21430_21485(f_1081_21468_21474(), out temp)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 21500, 21836) || true) && (!success)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 21500, 21836);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 21711, 21821);

                    throw f_1081_21717_21820("Expand", f_1081_21762_21819());
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 21500, 21836);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 21852, 21866);

                retVal = temp;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 21880, 21894);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 21139, 21905);

                string
                f_1081_21292_21298()
                {
                    var return_v = Expand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 21292, 21298);
                    return return_v;
                }


                bool
                f_1081_21271_21299(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 21271, 21299);
                    return return_v;
                }


                string
                f_1081_21468_21474()
                {
                    var return_v = Expand;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 21468, 21474);
                    return return_v;
                }


                bool
                f_1081_21430_21485(string
                expansionString, out Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansion
                expansion)
                {
                    var return_v = EnumerableExpansionConversion.Convert(expansionString, out expansion);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 21430, 21485);
                    return return_v;
                }


                string
                f_1081_21762_21819()
                {
                    var return_v = FormatAndOut_MshParameter.IllegalEnumerableExpansionValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 21762, 21819);
                    return return_v;
                }


                System.Management.Automation.PSArgumentException
                f_1081_21717_21820(string
                paramName, string
                resourceString, params object[]
                args)
                {
                    var return_v = PSTraceSource.NewArgumentException(paramName, resourceString, args);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 21717, 21820);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 21139, 21905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 21139, 21905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal MshParameter ProcessGroupByParameter()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 21917, 22617);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 21989, 22578) || true) && (f_1081_21993_22000() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 21989, 22578);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 22042, 22145);

                    TerminatingErrorContext
                    invocationContext =
                    f_1081_22111_22144(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 22163, 22257);

                    ParameterProcessor
                    processor = f_1081_22194_22256(f_1081_22217_22255())
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 22275, 22458);

                    List<MshParameter>
                    groupParameterList =
                    f_1081_22336_22457(processor, new object[] { f_1081_22379_22386() }, invocationContext)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 22478, 22563) || true) && (f_1081_22482_22506(groupParameterList) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 22478, 22563);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 22534, 22563);

                        return f_1081_22541_22562(groupParameterList, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 22478, 22563);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 21989, 22578);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 22594, 22606);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 21917, 22617);

                object
                f_1081_21993_22000()
                {
                    var return_v = GroupBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 21993, 22000);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1081_22111_22144(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatShapeCommandBase
                command)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext((System.Management.Automation.PSCmdlet)command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 22111, 22144);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatGroupByParameterDefinition
                f_1081_22217_22255()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatGroupByParameterDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 22217, 22255);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ParameterProcessor
                f_1081_22194_22256(Microsoft.PowerShell.Commands.Internal.Format.FormatGroupByParameterDefinition
                p)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ParameterProcessor((Microsoft.PowerShell.Commands.Internal.Format.CommandParameterDefinition)p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 22194, 22256);
                    return return_v;
                }


                object
                f_1081_22379_22386()
                {
                    var return_v = GroupBy;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 22379, 22386);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                f_1081_22336_22457(Microsoft.PowerShell.Commands.Internal.Format.ParameterProcessor
                this_param, object[]
                p, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext)
                {
                    var return_v = this_param.ProcessParameters(p, invocationContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 22336, 22457);
                    return return_v;
                }


                int
                f_1081_22482_22506(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 22482, 22506);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1081_22541_22562(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 22541, 22562);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 21917, 22617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 21917, 22617);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void BeginProcessing()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 22698, 23229);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 22764, 22883);

                InnerFormatShapeCommand
                innerFormatCommand =
                                            (InnerFormatShapeCommand)this.implementation
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 22977, 23049);

                FormattingCommandLineParameters
                parameters = f_1081_23022_23048(this)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 23063, 23119);

                f_1081_23063_23118(innerFormatCommand, parameters);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 23195, 23218);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.BeginProcessing(), 1081, 23195, 23217);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 22698, 23229);

                Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                f_1081_23022_23048(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatShapeCommandBase
                this_param)
                {
                    var return_v = this_param.GetCommandLineParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 23022, 23048);
                    return return_v;
                }


                int
                f_1081_23063_23118(Microsoft.PowerShell.Commands.Internal.Format.InnerFormatShapeCommand
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                commandLineParameters)
                {
                    this_param.SetCommandLineParameters(commandLineParameters);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 23063, 23118);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 22698, 23229);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 22698, 23229);
            }
        }

        internal virtual FormattingCommandLineParameters GetCommandLineParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 23544, 23667);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 23644, 23656);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 23544, 23667);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 23544, 23667);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 23544, 23667);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void ReportCannotSpecifyViewAndProperty()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 23679, 24204);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 23754, 23844);

                string
                msg = f_1081_23767_23843(f_1081_23785_23842())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 23860, 24074);

                ErrorRecord
                errorRecord = f_1081_23886_24073(f_1081_23920_23946(), "FormatCannotSpecifyViewAndProperty", ErrorCategory.InvalidArgument, null)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 24090, 24139);

                errorRecord.ErrorDetails = f_1081_24117_24138(msg);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 24153, 24193);

                f_1081_24153_24192(this, errorRecord);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 23679, 24204);

                string
                f_1081_23785_23842()
                {
                    var return_v = FormatAndOut_format_xxx.CannotSpecifyViewAndPropertyError;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 23785, 23842);
                    return return_v;
                }


                string
                f_1081_23767_23843(string
                formatSpec, params object[]
                o)
                {
                    var return_v = StringUtil.Format(formatSpec, o);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 23767, 23843);
                    return return_v;
                }


                System.IO.InvalidDataException
                f_1081_23920_23946()
                {
                    var return_v = new System.IO.InvalidDataException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 23920, 23946);
                    return return_v;
                }


                System.Management.Automation.ErrorRecord
                f_1081_23886_24073(System.IO.InvalidDataException
                exception, string
                errorId, System.Management.Automation.ErrorCategory
                errorCategory, object
                targetObject)
                {
                    var return_v = new System.Management.Automation.ErrorRecord((System.Exception)exception, errorId, errorCategory, targetObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 23886, 24073);
                    return return_v;
                }


                System.Management.Automation.ErrorDetails
                f_1081_24117_24138(string
                message)
                {
                    var return_v = new System.Management.Automation.ErrorDetails(message);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 24117, 24138);
                    return return_v;
                }


                int
                f_1081_24153_24192(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatShapeCommandBase
                this_param, System.Management.Automation.ErrorRecord
                errorRecord)
                {
                    this_param.ThrowTerminatingError(errorRecord);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 24153, 24192);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 23679, 24204);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 23679, 24204);
            }
        }

        public OuterFormatShapeCommandBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1081, 18685, 24211);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 18947, 19011);
            this.GroupBy = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 19148, 19209);
            this.View = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 19687, 19714);
            this.showErrorsAsMessages = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 20217, 20251);
            this.showErrorsInFormattedOutput = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 20610, 20641);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 20779, 21068);
            this.Expand = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 21110, 21126);
            this.expansion = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1081, 18685, 24211);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 18685, 24211);
        }


        static OuterFormatShapeCommandBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1081, 18685, 24211);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1081, 18685, 24211);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 18685, 24211);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1081, 18685, 24211);
    }
    public class OuterFormatTableAndListBase : OuterFormatShapeCommandBase
    {
        [Parameter(Position = 0)]
        public object[] Property { get; set; }

        internal override FormattingCommandLineParameters GetCommandLineParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 24780, 25562);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 24881, 24964);

                FormattingCommandLineParameters
                parameters = f_1081_24926_24963()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 24980, 25024);

                f_1081_24980_25023(this, parameters, false);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 25038, 25099);

                parameters.groupByParameter = f_1081_25068_25098(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 25115, 25170);

                parameters.forceFormattingAlsoOnOutOfBand = f_1081_25159_25169(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 25184, 25301) || true) && (f_1081_25188_25222(this.showErrorsAsMessages))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 25184, 25301);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 25241, 25301);

                    parameters.showErrorsAsMessages = this.showErrorsAsMessages;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 25184, 25301);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 25315, 25453) || true) && (f_1081_25319_25360(this.showErrorsInFormattedOutput))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 25315, 25453);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 25379, 25453);

                    parameters.showErrorsInFormattedOutput = this.showErrorsInFormattedOutput;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 25315, 25453);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 25469, 25517);

                parameters.expansion = f_1081_25492_25516(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 25533, 25551);

                return parameters;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 24780, 25562);

                Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                f_1081_24926_24963()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 24926, 24963);
                    return return_v;
                }


                int
                f_1081_24980_25023(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatTableAndListBase
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                parameters, bool
                isTable)
                {
                    this_param.GetCommandLineProperties(parameters, isTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 24980, 25023);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1081_25068_25098(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatTableAndListBase
                this_param)
                {
                    var return_v = this_param.ProcessGroupByParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 25068, 25098);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1081_25159_25169(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatTableAndListBase
                this_param)
                {
                    var return_v = this_param.Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 25159, 25169);
                    return return_v;
                }


                bool
                f_1081_25188_25222(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 25188, 25222);
                    return return_v;
                }


                bool
                f_1081_25319_25360(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 25319, 25360);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansion?
                f_1081_25492_25516(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatTableAndListBase
                this_param)
                {
                    var return_v = this_param.ProcessExpandParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 25492, 25516);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 24780, 25562);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 24780, 25562);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal void GetCommandLineProperties(FormattingCommandLineParameters parameters, bool isTable)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 25574, 26617);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 25695, 26258) || true) && (f_1081_25699_25707() != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 25695, 26258);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 25749, 25780);

                    CommandParameterDefinition
                    def
                    = default(CommandParameterDefinition);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 25800, 25963) || true) && (isTable)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 25800, 25963);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 25834, 25877);

                        def = f_1081_25840_25876();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 25800, 25963);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 25800, 25963);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 25921, 25963);

                        def = f_1081_25927_25962();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 25800, 25963);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 25981, 26040);

                    ParameterProcessor
                    processor = f_1081_26012_26039(def)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 26058, 26136);

                    TerminatingErrorContext
                    invocationContext = f_1081_26102_26135(this)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 26156, 26243);

                    parameters.mshParameterList = f_1081_26186_26242(processor, f_1081_26214_26222(), invocationContext);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 25695, 26258);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 26274, 26606) || true) && (!f_1081_26279_26310(f_1081_26300_26309(this)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 26274, 26606);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 26399, 26539) || true) && (f_1081_26403_26436(parameters.mshParameterList) != 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 26399, 26539);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 26483, 26520);

                        f_1081_26483_26519(this);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 26399, 26539);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 26559, 26591);

                    parameters.viewName = f_1081_26581_26590(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 26274, 26606);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 25574, 26617);

                object[]
                f_1081_25699_25707()
                {
                    var return_v = Property;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 25699, 25707);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatTableParameterDefinition
                f_1081_25840_25876()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatTableParameterDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 25840, 25876);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatListParameterDefinition
                f_1081_25927_25962()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatListParameterDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 25927, 25962);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.ParameterProcessor
                f_1081_26012_26039(Microsoft.PowerShell.Commands.Internal.Format.CommandParameterDefinition
                p)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.ParameterProcessor(p);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 26012, 26039);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                f_1081_26102_26135(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatTableAndListBase
                command)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext((System.Management.Automation.PSCmdlet)command);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 26102, 26135);
                    return return_v;
                }


                object[]
                f_1081_26214_26222()
                {
                    var return_v = Property;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 26214, 26222);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                f_1081_26186_26242(Microsoft.PowerShell.Commands.Internal.Format.ParameterProcessor
                this_param, object[]
                p, Microsoft.PowerShell.Commands.Internal.Format.TerminatingErrorContext
                invocationContext)
                {
                    var return_v = this_param.ProcessParameters(p, invocationContext);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 26186, 26242);
                    return return_v;
                }


                string
                f_1081_26300_26309(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatTableAndListBase
                this_param)
                {
                    var return_v = this_param.View;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 26300, 26309);
                    return return_v;
                }


                bool
                f_1081_26279_26310(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 26279, 26310);
                    return return_v;
                }


                int
                f_1081_26403_26436(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 26403, 26436);
                    return return_v;
                }


                int
                f_1081_26483_26519(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatTableAndListBase
                this_param)
                {
                    this_param.ReportCannotSpecifyViewAndProperty();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 26483, 26519);
                    return 0;
                }


                string
                f_1081_26581_26590(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatTableAndListBase
                this_param)
                {
                    var return_v = this_param.View;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 26581, 26590);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 25574, 26617);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 25574, 26617);
            }
        }

        public OuterFormatTableAndListBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1081, 24258, 26624);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 24673, 24746);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1081, 24258, 26624);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 24258, 26624);
        }


        static OuterFormatTableAndListBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1081, 24258, 26624);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1081, 24258, 26624);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 24258, 26624);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1081, 24258, 26624);
    }
    public class OuterFormatTableBase : OuterFormatTableAndListBase
    {
        [Parameter]
        public SwitchParameter AutoSize
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 26994, 27144);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 27030, 27098) || true) && (f_1081_27034_27052(_autosize))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 27030, 27098);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 27075, 27098);

                        return f_1081_27082_27097(_autosize);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 27030, 27098);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 27116, 27129);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 26994, 27144);

                    bool
                    f_1081_27034_27052(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 27034, 27052);
                        return return_v;
                    }


                    bool
                    f_1081_27082_27097(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 27082, 27097);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 26917, 27197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 26917, 27197);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 27160, 27186);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 27166, 27184);

                    _autosize = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 27160, 27186);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 26917, 27197);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 26917, 27197);
                }
            }
        }

        private bool? _autosize;

        [Parameter]
        public SwitchParameter RepeatHeader { get; set; }

        [Parameter]
        public SwitchParameter HideTableHeaders
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 27651, 27807);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 27687, 27761) || true) && (f_1081_27691_27712(_hideHeaders))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 27687, 27761);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 27735, 27761);

                        return f_1081_27742_27760(_hideHeaders);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 27687, 27761);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 27779, 27792);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 27651, 27807);

                    bool
                    f_1081_27691_27712(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 27691, 27712);
                        return return_v;
                    }


                    bool
                    f_1081_27742_27760(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 27742, 27760);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 27566, 27863);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 27566, 27863);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 27823, 27852);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 27829, 27850);

                    _hideHeaders = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 27823, 27852);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 27566, 27863);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 27566, 27863);
                }
            }
        }

        private bool? _hideHeaders;

        [Parameter]
        public SwitchParameter Wrap
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 28119, 28271);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 28155, 28225) || true) && (f_1081_28159_28178(_multiLine))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 28155, 28225);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 28201, 28225);

                        return f_1081_28208_28224(_multiLine);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 28155, 28225);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 28243, 28256);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 28119, 28271);

                    bool
                    f_1081_28159_28178(bool?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 28159, 28178);
                        return return_v;
                    }


                    bool
                    f_1081_28208_28224(bool?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 28208, 28224);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 28046, 28325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 28046, 28325);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
            set
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 28287, 28314);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 28293, 28312);

                    _multiLine = value;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 28287, 28314);
                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 28046, 28325);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 28046, 28325);
                }
            }
        }

        private bool? _multiLine;

        internal override FormattingCommandLineParameters GetCommandLineParameters()
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1081, 28401, 29808);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 28502, 28585);

                FormattingCommandLineParameters
                parameters = f_1081_28547_28584()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 28601, 28644);

                f_1081_28601_28643(this, parameters, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 28658, 28713);

                parameters.forceFormattingAlsoOnOutOfBand = f_1081_28702_28712(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 28727, 28844) || true) && (f_1081_28731_28765(this.showErrorsAsMessages))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 28727, 28844);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 28784, 28844);

                    parameters.showErrorsAsMessages = this.showErrorsAsMessages;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 28727, 28844);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 28858, 28996) || true) && (f_1081_28862_28903(this.showErrorsInFormattedOutput))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 28858, 28996);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 28922, 28996);

                    parameters.showErrorsInFormattedOutput = this.showErrorsInFormattedOutput;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 28858, 28996);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 29012, 29060);

                parameters.expansion = f_1081_29035_29059(this);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 29076, 29155) || true) && (f_1081_29080_29098(_autosize))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 29076, 29155);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 29117, 29155);

                    parameters.autosize = f_1081_29139_29154(_autosize);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 29076, 29155);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 29171, 29267) || true) && (f_1081_29175_29187())
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 29171, 29267);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 29221, 29252);

                    parameters.repeatHeader = true;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 29171, 29267);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 29283, 29344);

                parameters.groupByParameter = f_1081_29313_29343(this);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 29360, 29432);

                TableSpecificParameters
                tableParameters = f_1081_29402_29431()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 29446, 29491);

                parameters.shapeParameters = tableParameters;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 29507, 29630) || true) && (f_1081_29511_29532(_hideHeaders))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 29507, 29630);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 29566, 29615);

                    tableParameters.hideHeaders = f_1081_29596_29614(_hideHeaders);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 29507, 29630);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 29646, 29763) || true) && (f_1081_29650_29669(_multiLine))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1081, 29646, 29763);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 29703, 29748);

                    tableParameters.multiLine = f_1081_29731_29747(_multiLine);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1081, 29646, 29763);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 29779, 29797);

                return parameters;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1081, 28401, 29808);

                Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                f_1081_28547_28584()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 28547, 28584);
                    return return_v;
                }


                int
                f_1081_28601_28643(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatTableBase
                this_param, Microsoft.PowerShell.Commands.Internal.Format.FormattingCommandLineParameters
                parameters, bool
                isTable)
                {
                    this_param.GetCommandLineProperties(parameters, isTable);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 28601, 28643);
                    return 0;
                }


                System.Management.Automation.SwitchParameter
                f_1081_28702_28712(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatTableBase
                this_param)
                {
                    var return_v = this_param.Force;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 28702, 28712);
                    return return_v;
                }


                bool
                f_1081_28731_28765(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 28731, 28765);
                    return return_v;
                }


                bool
                f_1081_28862_28903(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 28862, 28903);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.EnumerableExpansion?
                f_1081_29035_29059(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatTableBase
                this_param)
                {
                    var return_v = this_param.ProcessExpandParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 29035, 29059);
                    return return_v;
                }


                bool
                f_1081_29080_29098(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 29080, 29098);
                    return return_v;
                }


                bool
                f_1081_29139_29154(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 29139, 29154);
                    return return_v;
                }


                System.Management.Automation.SwitchParameter
                f_1081_29175_29187()
                {
                    var return_v = RepeatHeader;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 29175, 29187);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1081_29313_29343(Microsoft.PowerShell.Commands.Internal.Format.OuterFormatTableBase
                this_param)
                {
                    var return_v = this_param.ProcessGroupByParameter();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 29313, 29343);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TableSpecificParameters
                f_1081_29402_29431()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TableSpecificParameters();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1081, 29402, 29431);
                    return return_v;
                }


                bool
                f_1081_29511_29532(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 29511, 29532);
                    return return_v;
                }


                bool
                f_1081_29596_29614(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 29596, 29614);
                    return return_v;
                }


                bool
                f_1081_29650_29669(bool?
                this_param)
                {
                    var return_v = this_param.HasValue;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 29650, 29669);
                    return return_v;
                }


                bool
                f_1081_29731_29747(bool?
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1081, 29731, 29747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1081, 28401, 29808);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 28401, 29808);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        public OuterFormatTableBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1081, 26671, 29815);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 27223, 27239);
            this._autosize = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 27889, 27908);
            this._hideHeaders = null;
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1081, 28351, 28368);
            this._multiLine = null;
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1081, 26671, 29815);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 26671, 29815);
        }


        static OuterFormatTableBase()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1081, 26671, 29815);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1081, 26671, 29815);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1081, 26671, 29815);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1081, 26671, 29815);
    }
}

