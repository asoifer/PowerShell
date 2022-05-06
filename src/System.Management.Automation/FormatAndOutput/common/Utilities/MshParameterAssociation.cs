// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class MshResolvedExpressionParameterAssociation
    {
        [TraceSource("MshResolvedExpressionParameterAssociation", "MshResolvedExpressionParameterAssociation")]
        internal static PSTraceSource tracer;

        internal MshResolvedExpressionParameterAssociation(MshParameter parameter, PSPropertyExpression expression)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1139, 881, 1219);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 1231, 1288);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 1300, 1351);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 1013, 1113) || true) && (expression == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 1013, 1113);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 1054, 1113);

                    throw f_1139_1060_1112("expression");
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 1013, 1113);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 1129, 1162);

                OriginatingParameter = parameter;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 1176, 1208);

                ResolvedExpression = expression;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1139, 881, 1219);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1139, 881, 1219);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1139, 881, 1219);
            }
        }

        internal PSPropertyExpression ResolvedExpression { get; }

        internal MshParameter OriginatingParameter { get; }

        static MshResolvedExpressionParameterAssociation()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1139, 423, 1358);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 670, 841);
            tracer = f_1139_679_841("MshResolvedExpressionParameterAssociation", "MshResolvedExpressionParameterAssociation");
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1139, 423, 1358);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1139, 423, 1358);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1139, 423, 1358);

        static System.Management.Automation.PSTraceSource
        f_1139_679_841(string
        name, string
        description)
        {
            var return_v = PSTraceSource.GetTracer(name, description);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 679, 841);
            return return_v;
        }


        System.Management.Automation.PSArgumentNullException
        f_1139_1060_1112(string
        paramName)
        {
            var return_v = PSTraceSource.NewArgumentNullException(paramName);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 1060, 1112);
            return return_v;
        }

    }
    internal static class AssociationManager
    {
        internal static List<MshResolvedExpressionParameterAssociation> SetupActiveProperties(List<MshParameter> rawMshParameterList,
                                                           PSObject target, PSPropertyExpressionFactory expressionFactory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1139, 1423, 3258);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 1759, 1944) || true) && (rawMshParameterList != null && (DynAbs.Tracing.TraceSender.Expression_True(1139, 1763, 1823) && f_1139_1794_1819(rawMshParameterList) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 1759, 1944);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 1857, 1929);

                    return f_1139_1864_1928(rawMshParameterList, target);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 1759, 1944);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 2089, 2232);

                List<MshResolvedExpressionParameterAssociation>
                activeAssociationList = f_1139_2161_2231(target, expressionFactory)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 2248, 2827) || true) && (f_1139_2252_2279(activeAssociationList) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 2248, 2827);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 2471, 2763) || true) && (f_1139_2475_2528(target))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 2471, 2763);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 2570, 2744);

                        f_1139_2570_2743(activeAssociationList, f_1139_2596_2742(null, f_1139_2673_2741(RemotingConstants.ComputerNameNoteProperty)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 2471, 2763);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 2783, 2812);

                    return activeAssociationList;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 2248, 2827);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 2959, 3020);

                activeAssociationList = f_1139_2983_3019(target);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 3123, 3202);

                f_1139_3123_3201(target, activeAssociationList);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 3218, 3247);

                return activeAssociationList;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1139, 1423, 3258);

                int
                f_1139_1794_1819(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1139, 1794, 1819);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1139_1864_1928(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                parameters, System.Management.Automation.PSObject
                target)
                {
                    var return_v = AssociationManager.ExpandParameters(parameters, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 1864, 1928);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1139_2161_2231(System.Management.Automation.PSObject
                target, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = AssociationManager.ExpandDefaultPropertySet(target, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 2161, 2231);
                    return return_v;
                }


                int
                f_1139_2252_2279(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1139, 2252, 2279);
                    return return_v;
                }


                bool
                f_1139_2475_2528(System.Management.Automation.PSObject
                so)
                {
                    var return_v = PSObjectHelper.ShouldShowComputerNameProperty(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 2475, 2528);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1139_2673_2741(string
                s)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpression(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 2673, 2741);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1139_2596_2742(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                parameter, Microsoft.PowerShell.Commands.PSPropertyExpression
                expression)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation(parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 2596, 2742);
                    return return_v;
                }


                int
                f_1139_2570_2743(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 2570, 2743);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1139_2983_3019(System.Management.Automation.PSObject
                target)
                {
                    var return_v = AssociationManager.ExpandAll(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 2983, 3019);
                    return return_v;
                }


                int
                f_1139_3123_3201(System.Management.Automation.PSObject
                so, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                activeAssociationList)
                {
                    AssociationManager.HandleComputerNameProperties(so, activeAssociationList);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 3123, 3201);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1139, 1423, 3258);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1139, 1423, 3258);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static List<MshResolvedExpressionParameterAssociation> ExpandTableParameters(List<MshParameter> parameters, PSObject target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1139, 3270, 4412);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 3428, 3539);

                List<MshResolvedExpressionParameterAssociation>
                retVal = f_1139_3485_3538()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 3555, 4371);
                    foreach (MshParameter par in f_1139_3584_3594_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 3555, 4371);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 3628, 3749);

                        PSPropertyExpression
                        expression = f_1139_3662_3724(par, FormatParameterDefinitionKeys.ExpressionEntryKey) as PSPropertyExpression
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 3767, 3851);

                        List<PSPropertyExpression>
                        expandedExpressionList = f_1139_3819_3850(expression, target)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 3871, 4150) || true) && (f_1139_3875_3908_M(!expression.HasWildCardCharacters) && (DynAbs.Tracing.TraceSender.Expression_True(1139, 3875, 3945) && f_1139_3912_3940(expandedExpressionList) == 0))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 3871, 4150);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 4056, 4131);

                            f_1139_4056_4130(                    // we did not find anything, mark as unresolved
                                                retVal, f_1139_4067_4129(par, expression));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 3871, 4150);
                        }
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 4170, 4356);
                            foreach (PSPropertyExpression ex in f_1139_4206_4228_I(expandedExpressionList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 4170, 4356);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 4270, 4337);

                                f_1139_4270_4336(retVal, f_1139_4281_4335(par, ex));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 4170, 4356);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1139, 1, 187);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1139, 1, 187);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 3555, 4371);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1139, 1, 817);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1139, 1, 817);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 4387, 4401);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1139, 3270, 4412);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1139_3485_3538()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 3485, 3538);
                    return return_v;
                }


                object
                f_1139_3662_3724(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                this_param, string
                key)
                {
                    var return_v = this_param.GetEntry(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 3662, 3724);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1139_3819_3850(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target)
                {
                    var return_v = this_param.ResolveNames(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 3819, 3850);
                    return return_v;
                }


                bool
                f_1139_3875_3908_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1139, 3875, 3908);
                    return return_v;
                }


                int
                f_1139_3912_3940(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1139, 3912, 3940);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1139_4067_4129(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                parameter, Microsoft.PowerShell.Commands.PSPropertyExpression
                expression)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation(parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 4067, 4129);
                    return return_v;
                }


                int
                f_1139_4056_4130(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 4056, 4130);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1139_4281_4335(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                parameter, Microsoft.PowerShell.Commands.PSPropertyExpression
                expression)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation(parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 4281, 4335);
                    return return_v;
                }


                int
                f_1139_4270_4336(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 4270, 4336);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1139_4206_4228_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 4206, 4228);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                f_1139_3584_3594_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 3584, 3594);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1139, 3270, 4412);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1139, 3270, 4412);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static List<MshResolvedExpressionParameterAssociation> ExpandParameters(List<MshParameter> parameters, PSObject target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1139, 4424, 5262);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 4577, 4688);

                List<MshResolvedExpressionParameterAssociation>
                retVal = f_1139_4634_4687()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 4704, 5221);
                    foreach (MshParameter par in f_1139_4733_4743_I(parameters))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 4704, 5221);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 4777, 4898);

                        PSPropertyExpression
                        expression = f_1139_4811_4873(par, FormatParameterDefinitionKeys.ExpressionEntryKey) as PSPropertyExpression
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 4916, 5000);

                        List<PSPropertyExpression>
                        expandedExpressionList = f_1139_4968_4999(expression, target)
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 5020, 5206);
                            foreach (PSPropertyExpression ex in f_1139_5056_5078_I(expandedExpressionList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 5020, 5206);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 5120, 5187);

                                f_1139_5120_5186(retVal, f_1139_5131_5185(par, ex));
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 5020, 5206);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1139, 1, 187);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1139, 1, 187);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 4704, 5221);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1139, 1, 518);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1139, 1, 518);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 5237, 5251);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1139, 4424, 5262);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1139_4634_4687()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 4634, 4687);
                    return return_v;
                }


                object
                f_1139_4811_4873(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                this_param, string
                key)
                {
                    var return_v = this_param.GetEntry(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 4811, 4873);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1139_4968_4999(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target)
                {
                    var return_v = this_param.ResolveNames(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 4968, 4999);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1139_5131_5185(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                parameter, Microsoft.PowerShell.Commands.PSPropertyExpression
                expression)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation(parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 5131, 5185);
                    return return_v;
                }


                int
                f_1139_5120_5186(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 5120, 5186);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1139_5056_5078_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 5056, 5078);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                f_1139_4733_4743_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 4733, 4743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1139, 4424, 5262);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1139, 4424, 5262);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static List<MshResolvedExpressionParameterAssociation> ExpandDefaultPropertySet(PSObject target, PSPropertyExpressionFactory expressionFactory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1139, 5274, 5905);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 5451, 5562);

                List<MshResolvedExpressionParameterAssociation>
                retVal = f_1139_5508_5561()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 5576, 5673);

                List<PSPropertyExpression>
                expandedExpressionList = f_1139_5628_5672(target)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 5689, 5864);
                    foreach (PSPropertyExpression ex in f_1139_5725_5747_I(expandedExpressionList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 5689, 5864);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 5781, 5849);

                        f_1139_5781_5848(retVal, f_1139_5792_5847(null, ex));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 5689, 5864);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1139, 1, 176);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1139, 1, 176);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 5880, 5894);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1139, 5274, 5905);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1139_5508_5561()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 5508, 5561);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1139_5628_5672(System.Management.Automation.PSObject
                so)
                {
                    var return_v = PSObjectHelper.GetDefaultPropertySet(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 5628, 5672);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1139_5792_5847(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                parameter, Microsoft.PowerShell.Commands.PSPropertyExpression
                expression)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation(parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 5792, 5847);
                    return return_v;
                }


                int
                f_1139_5781_5848(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 5781, 5848);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1139_5725_5747_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 5725, 5747);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1139, 5274, 5905);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1139, 5274, 5905);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static List<string> GetPropertyNamesFromView(PSObject source, PSMemberViewTypes viewType)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1139, 5917, 6712);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 6039, 6156);

                Collection<CollectionEntry<PSMemberInfo>>
                memberCollection =
                f_1139_6117_6155(viewType)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 6172, 6333);

                PSMemberInfoIntegratingCollection<PSMemberInfo>
                membersToSearch =
                f_1139_6255_6332(source, memberCollection)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 6349, 6481);

                ReadOnlyPSMemberInfoCollection<PSMemberInfo>
                matchedMembers =
                f_1139_6428_6480(membersToSearch, "*", PSMemberTypes.Properties)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 6497, 6538);

                List<string>
                retVal = f_1139_6519_6537()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 6552, 6671);
                    foreach (PSMemberInfo member in f_1139_6584_6598_I(matchedMembers))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 6552, 6671);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 6632, 6656);

                        f_1139_6632_6655(retVal, f_1139_6643_6654(member));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 6552, 6671);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1139, 1, 120);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1139, 1, 120);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 6687, 6701);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1139, 5917, 6712);

                System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
                f_1139_6117_6155(System.Management.Automation.PSMemberViewTypes
                viewType)
                {
                    var return_v = PSObject.GetMemberCollection(viewType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 6117, 6155);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>
                f_1139_6255_6332(System.Management.Automation.PSObject
                owner, System.Collections.ObjectModel.Collection<System.Management.Automation.CollectionEntry<System.Management.Automation.PSMemberInfo>>
                collections)
                {
                    var return_v = new System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>((object)owner, collections);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 6255, 6332);
                    return return_v;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1139_6428_6480(System.Management.Automation.PSMemberInfoIntegratingCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                name, System.Management.Automation.PSMemberTypes
                memberTypes)
                {
                    var return_v = this_param.Match(name, memberTypes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 6428, 6480);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1139_6519_6537()
                {
                    var return_v = new System.Collections.Generic.List<string>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 6519, 6537);
                    return return_v;
                }


                string
                f_1139_6643_6654(System.Management.Automation.PSMemberInfo
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1139, 6643, 6654);
                    return return_v;
                }


                int
                f_1139_6632_6655(System.Collections.Generic.List<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 6632, 6655);
                    return 0;
                }


                System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1139_6584_6598_I(System.Management.Automation.ReadOnlyPSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 6584, 6598);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1139, 5917, 6712);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1139, 5917, 6712);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static List<MshResolvedExpressionParameterAssociation> ExpandAll(PSObject target)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1139, 6724, 8040);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 6839, 6932);

                List<string>
                adaptedProperties = f_1139_6872_6931(target, PSMemberViewTypes.Adapted)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 6946, 7033);

                List<string>
                baseProperties = f_1139_6976_7032(target, PSMemberViewTypes.Base)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 7047, 7142);

                List<string>
                extendedProperties = f_1139_7081_7141(target, PSMemberViewTypes.Extended)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 7158, 7250);

                var
                displayedProperties = (DynAbs.Tracing.TraceSender.Conditional_F1(1139, 7184, 7212) || ((f_1139_7184_7207(adaptedProperties) != 0 && DynAbs.Tracing.TraceSender.Conditional_F2(1139, 7215, 7232)) || DynAbs.Tracing.TraceSender.Conditional_F3(1139, 7235, 7249))) ? adaptedProperties : baseProperties
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 7264, 7313);

                f_1139_7264_7312(displayedProperties, extendedProperties);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 7329, 7440);

                Dictionary<string, object>
                duplicatesFinder = f_1139_7375_7439(f_1139_7406_7438())
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 7454, 7565);

                List<MshResolvedExpressionParameterAssociation>
                retVal = f_1139_7511_7564()
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 7579, 7999);
                    foreach (string property in f_1139_7607_7626_I(displayedProperties))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 7579, 7999);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 7660, 7984) || true) && (!f_1139_7665_7703(duplicatesFinder, property))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 7660, 7984);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 7745, 7782);

                            f_1139_7745_7781(duplicatesFinder, property, null);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 7804, 7873);

                            PSPropertyExpression
                            expr = f_1139_7832_7872(property, true)
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 7895, 7965);

                            f_1139_7895_7964(retVal, f_1139_7906_7963(null, expr));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 7660, 7984);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 7579, 7999);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1139, 1, 421);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1139, 1, 421);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 8015, 8029);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1139, 6724, 8040);

                System.Collections.Generic.List<string>
                f_1139_6872_6931(System.Management.Automation.PSObject
                source, System.Management.Automation.PSMemberViewTypes
                viewType)
                {
                    var return_v = GetPropertyNamesFromView(source, viewType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 6872, 6931);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1139_6976_7032(System.Management.Automation.PSObject
                source, System.Management.Automation.PSMemberViewTypes
                viewType)
                {
                    var return_v = GetPropertyNamesFromView(source, viewType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 6976, 7032);
                    return return_v;
                }


                System.Collections.Generic.List<string>
                f_1139_7081_7141(System.Management.Automation.PSObject
                source, System.Management.Automation.PSMemberViewTypes
                viewType)
                {
                    var return_v = GetPropertyNamesFromView(source, viewType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 7081, 7141);
                    return return_v;
                }


                int
                f_1139_7184_7207(System.Collections.Generic.List<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1139, 7184, 7207);
                    return return_v;
                }


                int
                f_1139_7264_7312(System.Collections.Generic.List<string>
                this_param, System.Collections.Generic.List<string>
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<string>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 7264, 7312);
                    return 0;
                }


                System.StringComparer
                f_1139_7406_7438()
                {
                    var return_v = StringComparer.OrdinalIgnoreCase;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1139, 7406, 7438);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, object>
                f_1139_7375_7439(System.StringComparer
                comparer)
                {
                    var return_v = new System.Collections.Generic.Dictionary<string, object>((System.Collections.Generic.IEqualityComparer<string>)comparer);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 7375, 7439);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1139_7511_7564()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 7511, 7564);
                    return return_v;
                }


                bool
                f_1139_7665_7703(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key)
                {
                    var return_v = this_param.ContainsKey(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 7665, 7703);
                    return return_v;
                }


                int
                f_1139_7745_7781(System.Collections.Generic.Dictionary<string, object>
                this_param, string
                key, object
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 7745, 7781);
                    return 0;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1139_7832_7872(string
                s, bool
                isResolved)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpression(s, isResolved);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 7832, 7872);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1139_7906_7963(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                parameter, Microsoft.PowerShell.Commands.PSPropertyExpression
                expression)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation(parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 7906, 7963);
                    return return_v;
                }


                int
                f_1139_7895_7964(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 7895, 7964);
                    return 0;
                }


                System.Collections.Generic.List<string>
                f_1139_7607_7626_I(System.Collections.Generic.List<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 7607, 7626);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1139, 6724, 8040);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1139, 6724, 8040);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void HandleComputerNameProperties(PSObject so, List<MshResolvedExpressionParameterAssociation> activeAssociationList)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1139, 8556, 10904);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 8714, 10893) || true) && (f_1139_8718_8779(f_1139_8718_8731(so), RemotingConstants.ShowComputerNameNoteProperty) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 8714, 10893);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 8982, 9112);

                    Collection<MshResolvedExpressionParameterAssociation>
                    itemsToRemove = f_1139_9052_9111()
                    ;
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 9130, 9560);
                        foreach (MshResolvedExpressionParameterAssociation cpProp in f_1139_9191_9212_I(activeAssociationList))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 9130, 9560);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 9254, 9541) || true) && (f_1139_9258_9410(f_1139_9258_9294(f_1139_9258_9283(cpProp)), RemotingConstants.ShowComputerNameNoteProperty, StringComparison.OrdinalIgnoreCase))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 9254, 9541);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 9460, 9486);

                                f_1139_9460_9485(itemsToRemove, cpProp);
                                DynAbs.Tracing.TraceSender.TraceBreak(1139, 9512, 9518);

                                break;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 9254, 9541);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 9130, 9560);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1139, 1, 431);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1139, 1, 431);
                    }
                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 9907, 10574) || true) && ((f_1139_9912_9969(f_1139_9912_9925(so), RemotingConstants.ComputerNameNoteProperty) != null) && (DynAbs.Tracing.TraceSender.Expression_True(1139, 9911, 10055) && (!f_1139_10005_10054(so))))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 9907, 10574);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 10097, 10555);
                            foreach (MshResolvedExpressionParameterAssociation cpProp in f_1139_10158_10179_I(activeAssociationList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 10097, 10555);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 10229, 10532) || true) && (f_1139_10233_10385(f_1139_10233_10269(f_1139_10233_10258(cpProp)), RemotingConstants.ComputerNameNoteProperty, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 10229, 10532);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 10443, 10469);

                                    f_1139_10443_10468(itemsToRemove, cpProp);
                                    DynAbs.Tracing.TraceSender.TraceBreak(1139, 10499, 10505);

                                    break;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 10229, 10532);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 10097, 10555);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1139, 1, 459);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1139, 1, 459);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 9907, 10574);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 10594, 10878) || true) && (f_1139_10598_10617(itemsToRemove) > 0)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 10594, 10878);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 10663, 10859);
                            foreach (MshResolvedExpressionParameterAssociation itemToRemove in f_1139_10730_10743_I(itemsToRemove))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1139, 10663, 10859);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1139, 10793, 10836);

                                f_1139_10793_10835(activeAssociationList, itemToRemove);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 10663, 10859);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1139, 1, 197);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1139, 1, 197);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 10594, 10878);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1139, 8714, 10893);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1139, 8556, 10904);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1139_8718_8731(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1139, 8718, 8731);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1139_8718_8779(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1139, 8718, 8779);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1139_9052_9111()
                {
                    var return_v = new System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 9052, 9111);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1139_9258_9283(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1139, 9258, 9283);
                    return return_v;
                }


                string
                f_1139_9258_9294(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 9258, 9294);
                    return return_v;
                }


                bool
                f_1139_9258_9410(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 9258, 9410);
                    return return_v;
                }


                int
                f_1139_9460_9485(System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 9460, 9485);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1139_9191_9212_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 9191, 9212);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1139_9912_9925(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1139, 9912, 9925);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1139_9912_9969(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1139, 9912, 9969);
                    return return_v;
                }


                bool
                f_1139_10005_10054(System.Management.Automation.PSObject
                so)
                {
                    var return_v = PSObjectHelper.ShouldShowComputerNameProperty(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 10005, 10054);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1139_10233_10258(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1139, 10233, 10258);
                    return return_v;
                }


                string
                f_1139_10233_10269(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 10233, 10269);
                    return return_v;
                }


                bool
                f_1139_10233_10385(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 10233, 10385);
                    return return_v;
                }


                int
                f_1139_10443_10468(System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 10443, 10468);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1139_10158_10179_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 10158, 10179);
                    return return_v;
                }


                int
                f_1139_10598_10617(System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1139, 10598, 10617);
                    return return_v;
                }


                bool
                f_1139_10793_10835(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                item)
                {
                    var return_v = this_param.Remove(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 10793, 10835);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1139_10730_10743_I(System.Collections.ObjectModel.Collection<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1139, 10730, 10743);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1139, 8556, 10904);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1139, 8556, 10904);
            }
        }

        static AssociationManager()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1139, 1366, 10911);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1139, 1366, 10911);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1139, 1366, 10911);
        }

    }
}

