// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Management.Automation;
using System.Management.Automation.Runspaces;
using System.Reflection;
using System.Text;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal static class PSObjectHelper
    {
        internal const char
        Ellipsis = '\u2026'
        ;

        internal static string PSObjectIsOfExactType(Collection<string> typeNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 678, 877);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 777, 840) || true) && (f_1137_781_796(typeNames) != 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 777, 840);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 820, 840);

                    return f_1137_827_839(typeNames, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 777, 840);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 854, 866);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 678, 877);

                int
                f_1137_781_796(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 781, 796);
                    return return_v;
                }


                string
                f_1137_827_839(System.Collections.ObjectModel.Collection<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 827, 839);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 678, 877);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 678, 877);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool PSObjectIsEnum(Collection<string> typeNames)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 889, 1173);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 979, 1072) || true) && (f_1137_983_998(typeNames) < 2 || (DynAbs.Tracing.TraceSender.Expression_False(1137, 983, 1040) || f_1137_1006_1040(f_1137_1027_1039(typeNames, 1))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 979, 1072);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 1059, 1072);

                    return false;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 979, 1072);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 1086, 1162);

                return f_1137_1093_1161(f_1137_1107_1119(typeNames, 1), "System.Enum", StringComparison.Ordinal);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 889, 1173);

                int
                f_1137_983_998(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 983, 998);
                    return return_v;
                }


                string
                f_1137_1027_1039(System.Collections.ObjectModel.Collection<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 1027, 1039);
                    return return_v;
                }


                bool
                f_1137_1006_1040(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 1006, 1040);
                    return return_v;
                }


                string
                f_1137_1107_1119(System.Collections.ObjectModel.Collection<string>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 1107, 1119);
                    return return_v;
                }


                bool
                f_1137_1093_1161(string
                a, string
                b, System.StringComparison
                comparisonType)
                {
                    var return_v = string.Equals(a, b, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 1093, 1161);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 889, 1173);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 889, 1173);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSPropertyExpression GetDisplayNameExpression(PSObject target, PSPropertyExpressionFactory expressionFactory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 1649, 3599);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 1883, 1960);

                PSPropertyExpression
                expressionFromObject = f_1137_1927_1959(target)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 1974, 2083) || true) && (expressionFromObject != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 1974, 2083);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 2040, 2068);

                    return expressionFromObject;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 1974, 2083);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 2242, 2359);

                string[]
                knownPatterns = new string[] {
                "name", "id", "key", "*key", "*name", "*id",
                            }
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 2441, 3519);
                    foreach (string pattern in f_1137_2468_2481_I(knownPatterns))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 2441, 3519);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 2515, 2575);

                        PSPropertyExpression
                        ex = f_1137_2541_2574(pattern)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 2593, 2655);

                        List<PSPropertyExpression>
                        exprList = f_1137_2631_2654(ex, target)
                        ;
                        try
                        {
                            while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 2675, 3320) || true) && ((f_1137_2683_2697(exprList) > 0) && (DynAbs.Tracing.TraceSender.Expression_True(1137, 2682, 3238) && (
                            f_1137_2729_2838(f_1137_2729_2751(f_1137_2729_2740(exprList, 0)), RemotingConstants.ComputerNameNoteProperty, StringComparison.OrdinalIgnoreCase) || (DynAbs.Tracing.TraceSender.Expression_False(1137, 2729, 2976) || f_1137_2863_2976(f_1137_2863_2885(f_1137_2863_2874(exprList, 0)), RemotingConstants.ShowComputerNameNoteProperty, StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1137, 2729, 3108) || f_1137_3001_3108(f_1137_3001_3023(f_1137_3001_3012(exprList, 0)), RemotingConstants.RunspaceIdNoteProperty, StringComparison.OrdinalIgnoreCase)) || (DynAbs.Tracing.TraceSender.Expression_False(1137, 2729, 3237) || f_1137_3133_3237(f_1137_3133_3155(f_1137_3133_3144(exprList, 0)), RemotingConstants.SourceJobInstanceId, StringComparison.OrdinalIgnoreCase)))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 2675, 3320);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 3280, 3301);

                                f_1137_3280_3300(exprList, 0);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 2675, 3320);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1137, 2675, 3320);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1137, 2675, 3320);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 3340, 3395) || true) && (f_1137_3344_3358(exprList) == 0)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 3340, 3395);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 3386, 3395);

                            continue;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 3340, 3395);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 3485, 3504);

                        return f_1137_3492_3503(exprList, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 2441, 3519);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1137, 1, 1079);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1137, 1, 1079);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 3576, 3588);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 1649, 3599);

                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_1927_1959(System.Management.Automation.PSObject
                so)
                {
                    var return_v = GetDefaultNameExpression(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 1927, 1959);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_2541_2574(string
                s)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpression(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 2541, 2574);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1137_2631_2654(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target)
                {
                    var return_v = this_param.ResolveNames(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 2631, 2654);
                    return return_v;
                }


                int
                f_1137_2683_2697(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 2683, 2697);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_2729_2740(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 2729, 2740);
                    return return_v;
                }


                string
                f_1137_2729_2751(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 2729, 2751);
                    return return_v;
                }


                bool
                f_1137_2729_2838(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 2729, 2838);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_2863_2874(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 2863, 2874);
                    return return_v;
                }


                string
                f_1137_2863_2885(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 2863, 2885);
                    return return_v;
                }


                bool
                f_1137_2863_2976(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 2863, 2976);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_3001_3012(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 3001, 3012);
                    return return_v;
                }


                string
                f_1137_3001_3023(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 3001, 3023);
                    return return_v;
                }


                bool
                f_1137_3001_3108(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 3001, 3108);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_3133_3144(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 3133, 3144);
                    return return_v;
                }


                string
                f_1137_3133_3155(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 3133, 3155);
                    return return_v;
                }


                bool
                f_1137_3133_3237(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 3133, 3237);
                    return return_v;
                }


                int
                f_1137_3280_3300(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param, int
                index)
                {
                    this_param.RemoveAt(index);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 3280, 3300);
                    return 0;
                }


                int
                f_1137_3344_3358(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 3344, 3358);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_3492_3503(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 3492, 3503);
                    return return_v;
                }


                string[]
                f_1137_2468_2481_I(string[]
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 2468, 2481);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 1649, 3599);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 1649, 3599);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static PSPropertyExpressionResult GetDisplayName(PSObject target, PSPropertyExpressionFactory expressionFactory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 3964, 4732);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 4157, 4235);

                PSPropertyExpression
                ex = f_1137_4183_4234(target, expressionFactory)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 4249, 4294) || true) && (ex == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 4249, 4294);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 4282, 4294);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 4249, 4294);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 4350, 4414);

                List<PSPropertyExpressionResult>
                resList = f_1137_4393_4413(ex, target)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 4430, 4617) || true) && (f_1137_4434_4447(resList) == 0 || (DynAbs.Tracing.TraceSender.Expression_False(1137, 4434, 4484) || f_1137_4456_4476(f_1137_4456_4466(resList, 0)) != null))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 4430, 4617);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 4590, 4602);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 4430, 4617);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 4703, 4721);

                return f_1137_4710_4720(resList, 0);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 3964, 4732);

                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_4183_4234(System.Management.Automation.PSObject
                target, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = GetDisplayNameExpression(target, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 4183, 4234);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                f_1137_4393_4413(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target)
                {
                    var return_v = this_param.GetValues(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 4393, 4413);
                    return return_v;
                }


                int
                f_1137_4434_4447(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 4434, 4447);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1137_4456_4466(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 4456, 4466);
                    return return_v;
                }


                System.Exception
                f_1137_4456_4476(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 4456, 4476);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1137_4710_4720(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 4710, 4720);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 3964, 4732);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 3964, 4732);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static IEnumerable GetEnumerable(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 4998, 5398);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 5076, 5110);

                PSObject
                mshObj = obj as PSObject
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 5124, 5215) || true) && (mshObj != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 5124, 5215);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 5176, 5200);

                    obj = f_1137_5182_5199(mshObj);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 5124, 5215);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 5231, 5326) || true) && (obj is IDictionary)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 5231, 5326);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 5287, 5311);

                    return (IEnumerable)obj;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 5231, 5326);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 5342, 5387);

                return f_1137_5349_5386(obj);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 4998, 5398);

                object
                f_1137_5182_5199(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 5182, 5199);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1137_5349_5386(object
                obj)
                {
                    var return_v = LanguagePrimitives.GetEnumerable(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 5349, 5386);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 4998, 5398);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 4998, 5398);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetSmartToStringDisplayName(object x, PSPropertyExpressionFactory expressionFactory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 5410, 5932);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 5541, 5651);

                PSPropertyExpressionResult
                r = f_1137_5572_5650(f_1137_5602_5630(x), expressionFactory)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 5665, 5921) || true) && ((r != null) && (DynAbs.Tracing.TraceSender.Expression_True(1137, 5669, 5705) && (f_1137_5685_5696(r) == null)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 5665, 5921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 5739, 5793);

                    return f_1137_5746_5792(f_1137_5746_5781(f_1137_5772_5780(r)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 5665, 5921);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 5665, 5921);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 5859, 5906);

                    return f_1137_5866_5905(f_1137_5866_5894(x));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 5665, 5921);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 5410, 5932);

                System.Management.Automation.PSObject
                f_1137_5602_5630(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 5602, 5630);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1137_5572_5650(System.Management.Automation.PSObject
                target, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = PSObjectHelper.GetDisplayName(target, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 5572, 5650);
                    return return_v;
                }


                System.Exception
                f_1137_5685_5696(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 5685, 5696);
                    return return_v;
                }


                object
                f_1137_5772_5780(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 5772, 5780);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1137_5746_5781(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 5746, 5781);
                    return return_v;
                }


                string
                f_1137_5746_5792(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 5746, 5792);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1137_5866_5894(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 5866, 5894);
                    return return_v;
                }


                string
                f_1137_5866_5905(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 5866, 5905);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 5410, 5932);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 5410, 5932);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static string GetObjectName(object x, PSPropertyExpressionFactory expressionFactory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 5944, 8277);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 6061, 6076);

                string
                objName
                = default(string);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 6204, 8235) || true) && (x is PSObject && (DynAbs.Tracing.TraceSender.Expression_True(1137, 6208, 6480) && (f_1137_6243_6327(f_1137_6290_6326((f_1137_6291_6315(((PSObject)x))))) || (DynAbs.Tracing.TraceSender.Expression_False(1137, 6243, 6430) || f_1137_6348_6430(f_1137_6377_6429((f_1137_6378_6414((f_1137_6379_6403(((PSObject)x)))))))) || (DynAbs.Tracing.TraceSender.Expression_False(1137, 6243, 6479) || f_1137_6451_6479(x)))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 6204, 8235);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 6514, 6537);

                    objName = f_1137_6524_6536(x);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 6204, 8235);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 6204, 8235);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 6571, 8235) || true) && (x == null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 6571, 8235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 6708, 6726);

                        objName = "$null";
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 6571, 8235);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 6571, 8235);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 6792, 6871);

                        MethodInfo
                        toStringMethod = f_1137_6820_6870(f_1137_6820_6831(x), "ToString", Type.EmptyTypes)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 7184, 8220) || true) && (f_1137_7188_7216(toStringMethod) == f_1137_7220_7231(x))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 7184, 8220);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 7273, 7323);

                            objName = f_1137_7283_7322(f_1137_7283_7311(x));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 7184, 8220);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 7184, 8220);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 7405, 7515);

                            PSPropertyExpressionResult
                            r = f_1137_7436_7514(f_1137_7466_7494(x), expressionFactory)
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 7537, 8201) || true) && ((r != null) && (DynAbs.Tracing.TraceSender.Expression_True(1137, 7541, 7577) && (f_1137_7557_7568(r) == null)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 7537, 8201);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 7627, 7684);

                                objName = f_1137_7637_7683(f_1137_7637_7672(f_1137_7663_7671(r)));
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 7685, 7686);
                                ;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 7537, 8201);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 7537, 8201);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 7784, 7834);

                                objName = f_1137_7794_7833(f_1137_7794_7822(x));

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 7860, 8178) || true) && (objName == string.Empty)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 7860, 8178);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 7945, 7976);

                                    var
                                    baseObj = f_1137_7959_7975(x)
                                    ;

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 8006, 8151) || true) && (baseObj != null)
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 8006, 8151);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 8091, 8120);

                                        objName = f_1137_8101_8119(baseObj);
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 8006, 8151);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 7860, 8178);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 7537, 8201);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 7184, 8220);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 6571, 8235);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 6204, 8235);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 8251, 8266);

                return objName;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 5944, 8277);

                object
                f_1137_6291_6315(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 6291, 6315);
                    return return_v;
                }


                System.Type
                f_1137_6290_6326(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 6290, 6326);
                    return return_v;
                }


                bool
                f_1137_6243_6327(System.Type
                type)
                {
                    var return_v = LanguagePrimitives.IsBoolOrSwitchParameterType(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 6243, 6327);
                    return return_v;
                }


                object
                f_1137_6379_6403(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.BaseObject;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 6379, 6403);
                    return return_v;
                }


                System.Type
                f_1137_6378_6414(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 6378, 6414);
                    return return_v;
                }


                System.TypeCode
                f_1137_6377_6429(System.Type
                type)
                {
                    var return_v = type.GetTypeCode();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 6377, 6429);
                    return return_v;
                }


                bool
                f_1137_6348_6430(System.TypeCode
                typeCode)
                {
                    var return_v = LanguagePrimitives.IsNumeric(typeCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 6348, 6430);
                    return return_v;
                }


                bool
                f_1137_6451_6479(object
                obj)
                {
                    var return_v = LanguagePrimitives.IsNull(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 6451, 6479);
                    return return_v;
                }


                string?
                f_1137_6524_6536(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 6524, 6536);
                    return return_v;
                }


                System.Type
                f_1137_6820_6831(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 6820, 6831);
                    return return_v;
                }


                System.Reflection.MethodInfo?
                f_1137_6820_6870(System.Type
                this_param, string
                name, System.Type[]
                types)
                {
                    var return_v = this_param.GetMethod(name, types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 6820, 6870);
                    return return_v;
                }


                System.Type
                f_1137_7188_7216(System.Reflection.MethodInfo
                this_param)
                {
                    var return_v = this_param.DeclaringType;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 7188, 7216);
                    return return_v;
                }


                System.Type
                f_1137_7220_7231(object
                this_param)
                {
                    var return_v = this_param.GetType();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 7220, 7231);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1137_7283_7311(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 7283, 7311);
                    return return_v;
                }


                string
                f_1137_7283_7322(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 7283, 7322);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1137_7466_7494(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 7466, 7494);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1137_7436_7514(System.Management.Automation.PSObject
                target, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = PSObjectHelper.GetDisplayName(target, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 7436, 7514);
                    return return_v;
                }


                System.Exception
                f_1137_7557_7568(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 7557, 7568);
                    return return_v;
                }


                object
                f_1137_7663_7671(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 7663, 7671);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1137_7637_7672(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 7637, 7672);
                    return return_v;
                }


                string
                f_1137_7637_7683(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 7637, 7683);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1137_7794_7822(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 7794, 7822);
                    return return_v;
                }


                string
                f_1137_7794_7833(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 7794, 7833);
                    return return_v;
                }


                object
                f_1137_7959_7975(object
                obj)
                {
                    var return_v = PSObject.Base(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 7959, 7975);
                    return return_v;
                }


                string?
                f_1137_8101_8119(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 8101, 8119);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 5944, 8277);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 5944, 8277);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string SmartToString(PSObject so, PSPropertyExpressionFactory expressionFactory, int enumerationLimit, StringFormatError formatErrorObject)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 8861, 12887);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9041, 9094) || true) && (so == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 9041, 9094);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9074, 9094);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 9041, 9094);
                }

                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9146, 9195);

                    IEnumerable
                    e = f_1137_9162_9194(so)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9213, 12293) || true) && (e != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 9213, 12293);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9268, 9307);

                        StringBuilder
                        sb = f_1137_9287_9306()
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9329, 9344);

                        f_1137_9329_9343(sb, "{");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9368, 9386);

                        bool
                        first = true
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9408, 9426);

                        int
                        enumCount = 0
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9448, 9491);

                        IEnumerator
                        enumerator = f_1137_9473_9490(e)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9513, 12192) || true) && (enumerator != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 9513, 12192);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9585, 9660);

                            IBlockingEnumerator<object>
                            be = enumerator as IBlockingEnumerator<object>
                            ;

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9686, 12169) || true) && (be != null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 9686, 12169);
                                try
                                {
                                    while ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9758, 10899) || true) && (f_1137_9765_9783(be, false))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 9758, 10899);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9849, 10065) || true) && (f_1137_9853_9919(f_1137_9853_9895()))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 9849, 10065);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 9993, 10030);

                                            throw f_1137_9999_10029();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 9849, 10065);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 10101, 10509) || true) && (enumerationLimit >= 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 10101, 10509);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 10200, 10422) || true) && (enumCount == enumerationLimit)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 10200, 10422);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 10315, 10335);

                                                f_1137_10315_10334(sb, Ellipsis);
                                                DynAbs.Tracing.TraceSender.TraceBreak(1137, 10377, 10383);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 10200, 10422);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 10462, 10474);

                                            enumCount++;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 10101, 10509);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 10545, 10680) || true) && (!first)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 10545, 10680);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 10629, 10645);

                                            f_1137_10629_10644(sb, ", ");
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 10545, 10680);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 10716, 10772);

                                        f_1137_10716_10771(
                                                                        sb, f_1137_10726_10770(f_1137_10740_10750(be), expressionFactory));

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 10806, 10868) || true) && (first)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 10806, 10868);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 10854, 10868);

                                            first = false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 10806, 10868);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 9758, 10899);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1137, 9758, 10899);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1137, 9758, 10899);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 9686, 12169);
                            }

                            else

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 9686, 12169);
                                try
                                {
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 11013, 12142);
                                    foreach (object x in f_1137_11034_11035_I(e))
                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 11013, 12142);

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 11101, 11317) || true) && (f_1137_11105_11171(f_1137_11105_11147()))
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 11101, 11317);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 11245, 11282);

                                            throw f_1137_11251_11281();
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 11101, 11317);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 11353, 11761) || true) && (enumerationLimit >= 0)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 11353, 11761);

                                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 11452, 11674) || true) && (enumCount == enumerationLimit)
                                            )

                                            {
                                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 11452, 11674);
                                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 11567, 11587);

                                                f_1137_11567_11586(sb, Ellipsis);
                                                DynAbs.Tracing.TraceSender.TraceBreak(1137, 11629, 11635);

                                                break;
                                                DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 11452, 11674);
                                            }
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 11714, 11726);

                                            enumCount++;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 11353, 11761);
                                        }

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 11797, 11932) || true) && (!first)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 11797, 11932);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 11881, 11897);

                                            f_1137_11881_11896(sb, ", ");
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 11797, 11932);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 11968, 12015);

                                        f_1137_11968_12014(
                                                                        sb, f_1137_11978_12013(x, expressionFactory));

                                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 12049, 12111) || true) && (first)
                                        )

                                        {
                                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 12049, 12111);
                                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 12097, 12111);

                                            first = false;
                                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 12049, 12111);
                                        }
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 11013, 12142);
                                    }
                                }
                                catch (System.Exception)
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1137, 1, 1130);
                                    throw;
                                }
                                finally
                                {
                                    DynAbs.Tracing.TraceSender.TraceExitLoop(1137, 1, 1130);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 9686, 12169);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 9513, 12192);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 12216, 12231);

                        f_1137_12216_12230(
                                            sb, "}");
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 12253, 12274);

                        return f_1137_12260_12273(sb);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 9213, 12293);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 12379, 12400);

                    return f_1137_12386_12399(so);
                }
                catch (ExtendedTypeSystemException e)
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCatch(1137, 12429, 12876);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 12641, 12821) || true) && (formatErrorObject != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 12641, 12821);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 12712, 12748);

                        formatErrorObject.sourceObject = so;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 12770, 12802);

                        formatErrorObject.exception = e;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 12641, 12821);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 12841, 12861);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCatch(1137, 12429, 12876);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 8861, 12887);

                System.Collections.IEnumerable
                f_1137_9162_9194(System.Management.Automation.PSObject
                obj)
                {
                    var return_v = PSObjectHelper.GetEnumerable((object)obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 9162, 9194);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1137_9287_9306()
                {
                    var return_v = new System.Text.StringBuilder();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 9287, 9306);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1137_9329_9343(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 9329, 9343);
                    return return_v;
                }


                System.Collections.IEnumerator
                f_1137_9473_9490(System.Collections.IEnumerable
                this_param)
                {
                    var return_v = this_param.GetEnumerator();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 9473, 9490);
                    return return_v;
                }


                bool
                f_1137_9765_9783(System.Management.Automation.IBlockingEnumerator<object>
                this_param, bool
                block)
                {
                    var return_v = this_param.MoveNext(block);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 9765, 9783);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1137_9853_9895()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 9853, 9895);
                    return return_v;
                }


                bool
                f_1137_9853_9919(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 9853, 9919);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1137_9999_10029()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 9999, 10029);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1137_10315_10334(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 10315, 10334);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1137_10629_10644(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 10629, 10644);
                    return return_v;
                }


                object
                f_1137_10740_10750(System.Management.Automation.IBlockingEnumerator<object>
                this_param)
                {
                    var return_v = this_param.Current;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 10740, 10750);
                    return return_v;
                }


                string
                f_1137_10726_10770(object
                x, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = GetObjectName(x, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 10726, 10770);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1137_10716_10771(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 10716, 10771);
                    return return_v;
                }


                System.Management.Automation.ExecutionContext
                f_1137_11105_11147()
                {
                    var return_v = LocalPipeline.GetExecutionContextFromTLS();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 11105, 11147);
                    return return_v;
                }


                bool
                f_1137_11105_11171(System.Management.Automation.ExecutionContext
                this_param)
                {
                    var return_v = this_param.CurrentPipelineStopping;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 11105, 11171);
                    return return_v;
                }


                System.Management.Automation.PipelineStoppedException
                f_1137_11251_11281()
                {
                    var return_v = new System.Management.Automation.PipelineStoppedException();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 11251, 11281);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1137_11567_11586(System.Text.StringBuilder
                this_param, char
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 11567, 11586);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1137_11881_11896(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 11881, 11896);
                    return return_v;
                }


                string
                f_1137_11978_12013(object
                x, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = GetObjectName(x, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 11978, 12013);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1137_11968_12014(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 11968, 12014);
                    return return_v;
                }


                System.Collections.IEnumerable
                f_1137_11034_11035_I(System.Collections.IEnumerable
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 11034, 11035);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1137_12216_12230(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 12216, 12230);
                    return return_v;
                }


                string
                f_1137_12260_12273(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 12260, 12273);
                    return return_v;
                }


                string
                f_1137_12386_12399(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 12386, 12399);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 8861, 12887);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 8861, 12887);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static readonly PSObject s_emptyPSObject;

        internal static PSObject AsPSObject(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 12989, 13138);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 13061, 13127);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1137, 13068, 13081) || (((obj == null) && DynAbs.Tracing.TraceSender.Conditional_F2(1137, 13084, 13099)) || DynAbs.Tracing.TraceSender.Conditional_F3(1137, 13102, 13126))) ? s_emptyPSObject : f_1137_13102_13126(obj);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 12989, 13138);

                System.Management.Automation.PSObject
                f_1137_13102_13126(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 13102, 13126);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 12989, 13138);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 12989, 13138);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string FormatField(FieldFormattingDirective directive, object val, int enumerationLimit,
                    StringFormatError formatErrorObject, PSPropertyExpressionFactory expressionFactory)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 13738, 16171);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 13964, 14009);

                PSObject
                so = f_1137_13978_14008(val)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 14023, 15824) || true) && (directive != null && (DynAbs.Tracing.TraceSender.Expression_True(1137, 14027, 14093) && !f_1137_14049_14093(directive.formatString)))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 14023, 15824);
                    // we have a formatting directive, apply it
                    // NOTE: with a format directive, we do not make any attempt
                    // to deal with IEnumerable
                    try
                    {

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 14530, 14816) || true) && (f_1137_14534_14571(directive.formatString, "{0") || (DynAbs.Tracing.TraceSender.Expression_False(1137, 14534, 14611) || f_1137_14575_14611(directive.formatString, "}")))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 14530, 14816);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 14716, 14793);

                            return f_1137_14723_14792(f_1137_14737_14763(), directive.formatString, so);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 14530, 14816);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 14969, 15018);

                        return f_1137_14976_15017(so, directive.formatString, null);
                    }
                    catch (Exception e) // 2004/11/17-JonN This covers exceptions thrown in
                                        // string.Format and PSObject.ToString().
                                        // I think we can swallow these.
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1137, 15055, 15809);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 15466, 15790) || true) && (formatErrorObject != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 15466, 15790);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 15545, 15581);

                            formatErrorObject.sourceObject = so;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 15607, 15639);

                            formatErrorObject.exception = e;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 15665, 15721);

                            formatErrorObject.formatString = directive.formatString;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 15747, 15767);

                            return string.Empty;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 15466, 15790);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1137, 15055, 15809);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 14023, 15824);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 16064, 16160);

                return f_1137_16071_16159(so, expressionFactory, enumerationLimit, formatErrorObject);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 13738, 16171);

                System.Management.Automation.PSObject
                f_1137_13978_14008(object
                obj)
                {
                    var return_v = PSObjectHelper.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 13978, 14008);
                    return return_v;
                }


                bool
                f_1137_14049_14093(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 14049, 14093);
                    return return_v;
                }


                bool
                f_1137_14534_14571(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 14534, 14571);
                    return return_v;
                }


                bool
                f_1137_14575_14611(string
                this_param, string
                value)
                {
                    var return_v = this_param.Contains(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 14575, 14611);
                    return return_v;
                }


                System.Globalization.CultureInfo
                f_1137_14737_14763()
                {
                    var return_v = CultureInfo.CurrentCulture;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 14737, 14763);
                    return return_v;
                }


                string
                f_1137_14723_14792(System.Globalization.CultureInfo
                provider, string
                format, System.Management.Automation.PSObject
                arg0)
                {
                    var return_v = string.Format((System.IFormatProvider)provider, format, (object)arg0);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 14723, 14792);
                    return return_v;
                }


                string
                f_1137_14976_15017(System.Management.Automation.PSObject
                this_param, string
                format, System.IFormatProvider
                formatProvider)
                {
                    var return_v = this_param.ToString(format, formatProvider);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 14976, 15017);
                    return return_v;
                }


                string
                f_1137_16071_16159(System.Management.Automation.PSObject
                so, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, int
                enumerationLimit, Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                formatErrorObject)
                {
                    var return_v = PSObjectHelper.SmartToString(so, expressionFactory, enumerationLimit, formatErrorObject);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 16071, 16159);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 13738, 16171);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 13738, 16171);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSMemberSet MaskDeserializedAndGetStandardMembers(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 16183, 17069);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 16285, 16358);

                f_1137_16285_16357(so != null, "Shell object to process cannot be null");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 16372, 16409);

                var
                typeNames = f_1137_16388_16408(so)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 16423, 16529);

                Collection<string>
                typeNamesWithoutDeserializedPrefix = f_1137_16479_16528(typeNames)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 16543, 16650) || true) && (typeNamesWithoutDeserializedPrefix == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 16543, 16650);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 16623, 16635);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 16543, 16650);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 16666, 16706);

                TypeTable
                typeTable = f_1137_16688_16705(so)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 16720, 16802) || true) && (typeTable == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 16720, 16802);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 16775, 16787);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 16720, 16802);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 16818, 16985);

                PSMemberInfoInternalCollection<PSMemberInfo>
                members =
                f_1137_16890_16984(typeTable, f_1137_16925_16983(typeNamesWithoutDeserializedPrefix))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 16999, 17058);

                return f_1137_17006_17042(members, TypeTable.PSStandardMembers) as PSMemberSet;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 16183, 17069);

                int
                f_1137_16285_16357(bool
                condition, string
                whyThisShouldNeverHappen)
                {
                    Diagnostics.Assert(condition, whyThisShouldNeverHappen);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 16285, 16357);
                    return 0;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1137_16388_16408(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 16388, 16408);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1137_16479_16528(System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = Deserializer.MaskDeserializationPrefix((System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 16479, 16528);
                    return return_v;
                }


                System.Management.Automation.Runspaces.TypeTable
                f_1137_16688_16705(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.GetTypeTable();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 16688, 16705);
                    return return_v;
                }


                System.Management.Automation.Runspaces.ConsolidatedString
                f_1137_16925_16983(System.Collections.ObjectModel.Collection<string>
                strings)
                {
                    var return_v = new System.Management.Automation.Runspaces.ConsolidatedString((System.Collections.Generic.IEnumerable<string>)strings);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 16925, 16983);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                f_1137_16890_16984(System.Management.Automation.Runspaces.TypeTable
                this_param, System.Management.Automation.Runspaces.ConsolidatedString
                types)
                {
                    var return_v = this_param.GetMembers<System.Management.Automation.PSMemberInfo>(types);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 16890, 16984);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1137_17006_17042(System.Management.Automation.PSMemberInfoInternalCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 17006, 17042);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 16183, 17069);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 16183, 17069);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static List<PSPropertyExpression> GetDefaultPropertySet(PSMemberSet standardMembersSet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 17081, 18020);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 17201, 17953) || true) && (standardMembersSet != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 17201, 17953);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 17265, 17388);

                    PSPropertySet
                    defaultDisplayPropertySet = f_1137_17307_17370(f_1137_17307_17333(standardMembersSet), TypeTable.DefaultDisplayPropertySet) as PSPropertySet
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 17406, 17938) || true) && (defaultDisplayPropertySet != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 17406, 17938);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 17485, 17554);

                        List<PSPropertyExpression>
                        retVal = f_1137_17521_17553()
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 17576, 17881);
                            foreach (string prop in f_1137_17600_17649_I(f_1137_17600_17649(defaultDisplayPropertySet)))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 17576, 17881);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 17699, 17858) || true) && (!f_1137_17704_17730(prop))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 17699, 17858);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 17788, 17831);

                                    f_1137_17788_17830(retVal, f_1137_17799_17829(prop));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 17699, 17858);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 17576, 17881);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1137, 1, 306);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1137, 1, 306);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 17905, 17919);

                        return retVal;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 17406, 17938);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 17201, 17953);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 17969, 18009);

                return f_1137_17976_18008();
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 17081, 18020);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1137_17307_17333(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 17307, 17333);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1137_17307_17370(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 17307, 17370);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1137_17521_17553()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 17521, 17553);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1137_17600_17649(System.Management.Automation.PSPropertySet
                this_param)
                {
                    var return_v = this_param.ReferencedPropertyNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 17600, 17649);
                    return return_v;
                }


                bool
                f_1137_17704_17730(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 17704, 17730);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_17799_17829(string
                s)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpression(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 17799, 17829);
                    return return_v;
                }


                int
                f_1137_17788_17830(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param, Microsoft.PowerShell.Commands.PSPropertyExpression
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 17788, 17830);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1137_17600_17649_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 17600, 17649);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1137_17976_18008()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 17976, 18008);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 17081, 18020);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 17081, 18020);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static List<PSPropertyExpression> GetDefaultPropertySet(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 18296, 18677);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 18398, 18478);

                List<PSPropertyExpression>
                retVal = f_1137_18434_18477(f_1137_18456_18476(so))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 18492, 18636) || true) && (f_1137_18496_18508(retVal) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 18492, 18636);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 18547, 18621);

                    retVal = f_1137_18556_18620(f_1137_18578_18619(so));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 18492, 18636);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 18652, 18666);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 18296, 18677);

                System.Management.Automation.PSMemberSet
                f_1137_18456_18476(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.PSStandardMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 18456, 18476);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1137_18434_18477(System.Management.Automation.PSMemberSet
                standardMembersSet)
                {
                    var return_v = GetDefaultPropertySet(standardMembersSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 18434, 18477);
                    return return_v;
                }


                int
                f_1137_18496_18508(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 18496, 18508);
                    return return_v;
                }


                System.Management.Automation.PSMemberSet
                f_1137_18578_18619(System.Management.Automation.PSObject
                so)
                {
                    var return_v = MaskDeserializedAndGetStandardMembers(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 18578, 18619);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1137_18556_18620(System.Management.Automation.PSMemberSet
                standardMembersSet)
                {
                    var return_v = GetDefaultPropertySet(standardMembersSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 18556, 18620);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 18296, 18677);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 18296, 18677);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSPropertyExpression GetDefaultNameExpression(PSMemberSet standardMembersSet)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 18689, 19583);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 18806, 19544) || true) && (standardMembersSet != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 18806, 19544);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 18870, 18989);

                    PSNoteProperty
                    defaultDisplayProperty = f_1137_18910_18970(f_1137_18910_18936(standardMembersSet), TypeTable.DefaultDisplayProperty) as PSNoteProperty
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 19007, 19529) || true) && (defaultDisplayProperty != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 19007, 19529);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 19083, 19149);

                        string
                        expressionString = f_1137_19109_19148(f_1137_19109_19137(defaultDisplayProperty))
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 19171, 19510) || true) && (f_1137_19175_19213(expressionString))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 19171, 19510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 19327, 19339);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 19171, 19510);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 19171, 19510);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 19437, 19487);

                            return f_1137_19444_19486(expressionString);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 19171, 19510);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 19007, 19529);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 18806, 19544);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 19560, 19572);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 18689, 19583);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                f_1137_18910_18936(System.Management.Automation.PSMemberSet
                this_param)
                {
                    var return_v = this_param.Members;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 18910, 18936);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfo
                f_1137_18910_18970(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSMemberInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 18910, 18970);
                    return return_v;
                }


                object
                f_1137_19109_19137(System.Management.Automation.PSNoteProperty
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 19109, 19137);
                    return return_v;
                }


                string?
                f_1137_19109_19148(object
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 19109, 19148);
                    return return_v;
                }


                bool
                f_1137_19175_19213(string
                value)
                {
                    var return_v = string.IsNullOrEmpty(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 19175, 19213);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_19444_19486(string
                s)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpression(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 19444, 19486);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 18689, 19583);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 18689, 19583);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private static PSPropertyExpression GetDefaultNameExpression(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 19595, 19918);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 19693, 19877);

                PSPropertyExpression
                retVal = f_1137_19723_19769(f_1137_19748_19768(so)) ?? (DynAbs.Tracing.TraceSender.Expression_Null<Microsoft.PowerShell.Commands.PSPropertyExpression>(1137, 19723, 19876) ?? f_1137_19809_19876(f_1137_19834_19875(so)))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 19893, 19907);

                return retVal;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 19595, 19918);

                System.Management.Automation.PSMemberSet
                f_1137_19748_19768(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.PSStandardMembers;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 19748, 19768);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_19723_19769(System.Management.Automation.PSMemberSet
                standardMembersSet)
                {
                    var return_v = GetDefaultNameExpression(standardMembersSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 19723, 19769);
                    return return_v;
                }


                System.Management.Automation.PSMemberSet
                f_1137_19834_19875(System.Management.Automation.PSObject
                so)
                {
                    var return_v = MaskDeserializedAndGetStandardMembers(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 19834, 19875);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_19809_19876(System.Management.Automation.PSMemberSet
                standardMembersSet)
                {
                    var return_v = GetDefaultNameExpression(standardMembersSet);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 19809, 19876);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 19595, 19918);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 19595, 19918);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static string GetExpressionDisplayValue(
                    PSObject so,
                    int enumerationLimit,
                    PSPropertyExpression ex,
                    FieldFormattingDirective directive,
                    StringFormatError formatErrorObject,
                    PSPropertyExpressionFactory expressionFactory,
                    out PSPropertyExpressionResult result)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 20657, 21526);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 21041, 21055);

                result = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 21069, 21129);

                List<PSPropertyExpressionResult>
                resList = f_1137_21112_21128(ex, so)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 21145, 21236) || true) && (f_1137_21149_21162(resList) == 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 21145, 21236);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 21201, 21221);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 21145, 21236);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 21252, 21272);

                result = f_1137_21261_21271(resList, 0);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 21286, 21383) || true) && (f_1137_21290_21306(result) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 21286, 21383);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 21348, 21368);

                    return string.Empty;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 21286, 21383);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 21399, 21515);

                return f_1137_21406_21514(directive, f_1137_21444_21457(result), enumerationLimit, formatErrorObject, expressionFactory);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 20657, 21526);

                System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                f_1137_21112_21128(Microsoft.PowerShell.Commands.PSPropertyExpression
                this_param, System.Management.Automation.PSObject
                target)
                {
                    var return_v = this_param.GetValues(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 21112, 21128);
                    return return_v;
                }


                int
                f_1137_21149_21162(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 21149, 21162);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                f_1137_21261_21271(System.Collections.Generic.List<Microsoft.PowerShell.Commands.PSPropertyExpressionResult>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 21261, 21271);
                    return return_v;
                }


                System.Exception
                f_1137_21290_21306(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Exception;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 21290, 21306);
                    return return_v;
                }


                object
                f_1137_21444_21457(Microsoft.PowerShell.Commands.PSPropertyExpressionResult
                this_param)
                {
                    var return_v = this_param.Result;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 21444, 21457);
                    return return_v;
                }


                string
                f_1137_21406_21514(Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective
                directive, object
                val, int
                enumerationLimit, Microsoft.PowerShell.Commands.Internal.Format.StringFormatError
                formatErrorObject, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = PSObjectHelper.FormatField(directive, val, enumerationLimit, formatErrorObject, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 21406, 21514);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 20657, 21526);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 20657, 21526);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static bool ShouldShowComputerNameProperty(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1137, 21744, 23089);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 21833, 21853);

                bool
                result = false
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 21867, 23048) || true) && (so != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 21867, 23048);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 21959, 22055);

                        PSPropertyInfo
                        computerNameProperty = f_1137_21997_22054(f_1137_21997_22010(so), RemotingConstants.ComputerNameNoteProperty)
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 22077, 22181);

                        PSPropertyInfo
                        showComputerNameProperty = f_1137_22119_22180(f_1137_22119_22132(so), RemotingConstants.ShowComputerNameNoteProperty)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 22349, 22576) || true) && ((computerNameProperty != null) && (DynAbs.Tracing.TraceSender.Expression_True(1137, 22353, 22421) && (showComputerNameProperty != null)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 22349, 22576);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 22471, 22553);

                            f_1137_22471_22552(f_1137_22509_22539(showComputerNameProperty), out result);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 22349, 22576);
                        }
                    }
                    catch (ArgumentException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1137, 22613, 22809);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1137, 22613, 22809);
                        // ignore any exceptions thrown retrieving the *ComputerName properties
                        // from the object
                    }
                    catch (ExtendedTypeSystemException)
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCatch(1137, 22827, 23033);
                        DynAbs.Tracing.TraceSender.TraceExitCatch(1137, 22827, 23033);
                        // ignore any exceptions thrown retrieving the *ComputerName properties
                        // from the object
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 21867, 23048);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 23064, 23078);

                return result;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1137, 21744, 23089);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1137_21997_22010(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 21997, 22010);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1137_21997_22054(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 21997, 22054);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1137_22119_22132(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 22119, 22132);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1137_22119_22180(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 22119, 22180);
                    return return_v;
                }


                object
                f_1137_22509_22539(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1137, 22509, 22539);
                    return return_v;
                }


                bool
                f_1137_22471_22552(object
                valueToConvert, out bool
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo<bool>(valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 22471, 22552);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 21744, 23089);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 21744, 23089);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static PSObjectHelper()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1137, 573, 23096);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 646, 665);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 12932, 12976);
            s_emptyPSObject = f_1137_12950_12976(string.Empty);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1137, 573, 23096);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 573, 23096);
        }


        static System.Management.Automation.PSObject
        f_1137_12950_12976(string
        obj)
        {
            var return_v = new System.Management.Automation.PSObject((object)obj);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 12950, 12976);
            return return_v;
        }

    }
    internal abstract class FormattingError
    {
        internal object sourceObject;

        public FormattingError()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1137, 23104, 23196);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 23176, 23188);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1137, 23104, 23196);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 23104, 23196);
        }


        static FormattingError()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1137, 23104, 23196);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1137, 23104, 23196);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 23104, 23196);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1137, 23104, 23196);
    }
    internal sealed class PSPropertyExpressionError : FormattingError
    {
        internal PSPropertyExpressionResult result;

        public PSPropertyExpressionError()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1137, 23204, 23336);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 23322, 23328);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1137, 23204, 23336);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 23204, 23336);
        }


        static PSPropertyExpressionError()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1137, 23204, 23336);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1137, 23204, 23336);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 23204, 23336);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1137, 23204, 23336);
    }
    internal sealed class StringFormatError : FormattingError
    {
        internal string formatString;

        internal Exception exception;

        public StringFormatError()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1137, 23344, 23493);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 23434, 23446);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 23476, 23485);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1137, 23344, 23493);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 23344, 23493);
        }


        static StringFormatError()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1137, 23344, 23493);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1137, 23344, 23493);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 23344, 23493);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1137, 23344, 23493);
    }

    internal delegate ScriptBlock CreateScriptBlockFromString(string scriptBlockString);
    internal sealed class PSPropertyExpressionFactory
    {
        internal void VerifyScriptBlockText(string scriptText)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1137, 23848, 23969);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 23927, 23958);

                f_1137_23927_23957(scriptText);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1137, 23848, 23969);

                System.Management.Automation.ScriptBlock
                f_1137_23927_23957(string
                script)
                {
                    var return_v = ScriptBlock.Create(script);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 23927, 23957);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 23848, 23969);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 23848, 23969);
            }
        }

        internal PSPropertyExpression CreateFromExpressionToken(ExpressionToken et)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1137, 24266, 24420);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 24366, 24409);

                return f_1137_24373_24408(this, et, null);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1137, 24266, 24420);

                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_24373_24408(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                et, Microsoft.PowerShell.Commands.Internal.Format.DatabaseLoadingInfo
                loadingInfo)
                {
                    var return_v = this_param.CreateFromExpressionToken(et, loadingInfo);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 24373, 24408);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 24266, 24420);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 24266, 24420);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal PSPropertyExpression CreateFromExpressionToken(ExpressionToken et, DatabaseLoadingInfo loadingInfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1137, 24808, 26541);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 24941, 26400) || true) && (et.isScriptBlock)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 24941, 26400);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 25061, 25553) || true) && (_expressionCache != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 25061, 25553);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 25131, 25158);

                        PSPropertyExpression
                        value
                        = default(PSPropertyExpression);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 25180, 25377) || true) && (f_1137_25184_25227(_expressionCache, et, out value))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 25180, 25377);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 25341, 25354);

                            return value;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 25180, 25377);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 25061, 25553);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 25061, 25553);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 25459, 25534);

                        _expressionCache = f_1137_25478_25533();
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 25061, 25553);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 25573, 25601);

                    bool
                    isFullyTrusted = false
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 25619, 25646);

                    bool
                    isProductCode = false
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 25664, 25856) || true) && (loadingInfo != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 25664, 25856);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 25729, 25773);

                        isFullyTrusted = loadingInfo.isFullyTrusted;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 25795, 25837);

                        isProductCode = loadingInfo.isProductCode;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 25664, 25856);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 25930, 26038);

                    ScriptBlock
                    sb = f_1137_25947_26037(et.expressionValue, isProductCode: isProductCode)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 26056, 26086);

                    sb.DebuggerStepThrough = true;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 26106, 26231) || true) && (isFullyTrusted)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1137, 26106, 26231);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 26166, 26212);

                        sb.LanguageMode = PSLanguageMode.FullLanguage;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 26106, 26231);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 26251, 26306);

                    PSPropertyExpression
                    ex = f_1137_26277_26305(sb)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 26326, 26355);

                    f_1137_26326_26354(
                                    _expressionCache, et, ex);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 26375, 26385);

                    return ex;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1137, 24941, 26400);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 26478, 26530);

                return f_1137_26485_26529(et.expressionValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1137, 24808, 26541);

                bool
                f_1137_25184_25227(System.Collections.Generic.Dictionary<Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken, Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                key, out Microsoft.PowerShell.Commands.PSPropertyExpression
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 25184, 25227);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken, Microsoft.PowerShell.Commands.PSPropertyExpression>
                f_1137_25478_25533()
                {
                    var return_v = new System.Collections.Generic.Dictionary<Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken, Microsoft.PowerShell.Commands.PSPropertyExpression>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 25478, 25533);
                    return return_v;
                }


                System.Management.Automation.ScriptBlock
                f_1137_25947_26037(string
                script, bool
                isProductCode)
                {
                    var return_v = ScriptBlock.CreateDelayParsedScriptBlock(script, isProductCode: isProductCode);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 25947, 26037);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_26277_26305(System.Management.Automation.ScriptBlock
                scriptBlock)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpression(scriptBlock);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 26277, 26305);
                    return return_v;
                }


                int
                f_1137_26326_26354(System.Collections.Generic.Dictionary<Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken, Microsoft.PowerShell.Commands.PSPropertyExpression>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.ExpressionToken
                key, Microsoft.PowerShell.Commands.PSPropertyExpression
                value)
                {
                    this_param.Add(key, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 26326, 26354);
                    return 0;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1137_26485_26529(string
                s)
                {
                    var return_v = new Microsoft.PowerShell.Commands.PSPropertyExpression(s);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1137, 26485, 26529);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1137, 24808, 26541);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 24808, 26541);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private Dictionary<ExpressionToken, PSPropertyExpression> _expressionCache;

        public PSPropertyExpressionFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1137, 23723, 26635);
            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1137, 26611, 26627);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1137, 23723, 26635);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 23723, 26635);
        }


        static PSPropertyExpressionFactory()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1137, 23723, 26635);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1137, 23723, 26635);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1137, 23723, 26635);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1137, 23723, 26635);
    }
}

