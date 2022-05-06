// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Management.Automation;

namespace Microsoft.PowerShell.Commands.Internal.Format
{
    internal sealed class WideViewGenerator : ViewGenerator
    {
        internal override void Initialize(TerminatingErrorContext errorContext, PSPropertyExpressionFactory expressionFactory,
                                        PSObject so, TypeInfoDataBase db, FormattingCommandLineParameters parameters)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1094, 349, 731);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 603, 672);

                DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.Initialize(errorContext, expressionFactory, so, db, parameters), 1094, 603, 671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 686, 720);

                this.inputParameters = parameters;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1094, 349, 731);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1094, 349, 731);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1094, 349, 731);
            }
        }

        internal override FormatStartData GenerateStartData(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1094, 743, 1342);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 832, 889);

                FormatStartData
                startFormat = DynAbs.Tracing.TraceSender.TraceInvocationWrapper(() => base.GenerateStartData(so), 1094, 862, 888)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 905, 970);

                WideViewHeaderInfo
                wideViewHeaderInfo = f_1094_945_969()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 984, 1027);

                startFormat.shapeInfo = wideViewHeaderInfo;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 1043, 1296) || true) && (f_1094_1047_1061_M(!this.AutoSize))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 1043, 1296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 1142, 1184);

                    wideViewHeaderInfo.columns = f_1094_1171_1183(this);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 1043, 1296);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 1043, 1296);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 1250, 1281);

                    wideViewHeaderInfo.columns = 0;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 1043, 1296);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 1312, 1331);

                return startFormat;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1094, 743, 1342);

                Microsoft.PowerShell.Commands.Internal.Format.WideViewHeaderInfo
                f_1094_945_969()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.WideViewHeaderInfo();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 945, 969);
                    return return_v;
                }


                bool
                f_1094_1047_1061_M(bool
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 1047, 1061);
                    return return_v;
                }


                int
                f_1094_1171_1183(Microsoft.PowerShell.Commands.Internal.Format.WideViewGenerator
                this_param)
                {
                    var return_v = this_param.Columns;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 1171, 1183);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1094, 743, 1342);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1094, 743, 1342);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private int Columns
        {
            get
            {
                try
                {
                    DynAbs.Tracing.TraceSender.TraceEnterMethod(1094, 1398, 2190);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 1479, 1775) || true) && (parameters != null && (DynAbs.Tracing.TraceSender.Expression_True(1094, 1483, 1539) && parameters.shapeParameters != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 1479, 1775);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 1581, 1660);

                        WideSpecificParameters
                        wp = (WideSpecificParameters)parameters.shapeParameters
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 1682, 1756) || true) && (f_1094_1686_1705(wp.columns))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 1682, 1756);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 1732, 1756);

                            return f_1094_1739_1755(wp.columns);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 1682, 1756);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 1479, 1775);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 1842, 2114) || true) && (this.dataBaseInfo.view != null && (DynAbs.Tracing.TraceSender.Expression_True(1094, 1846, 1922) && this.dataBaseInfo.view.mainControl != null))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 1842, 2114);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 1964, 2046);

                        WideControlBody
                        wideControl = (WideControlBody)this.dataBaseInfo.view.mainControl
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 2068, 2095);

                        return wideControl.columns;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 1842, 2114);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 2166, 2175);

                    return 0;
                    DynAbs.Tracing.TraceSender.TraceExitMethod(1094, 1398, 2190);

                    bool
                    f_1094_1686_1705(int?
                    this_param)
                    {
                        var return_v = this_param.HasValue;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 1686, 1705);
                        return return_v;
                    }


                    int
                    f_1094_1739_1755(int?
                    this_param)
                    {
                        var return_v = this_param.Value;
                        DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 1739, 1755);
                        return return_v;
                    }

                }
                catch
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1094, 1354, 2201);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1094, 1354, 2201);
                }
                throw new System.Exception("Slicer error: unreachable code");
            }
        }

        internal override FormatEntryData GeneratePayload(PSObject so, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1094, 2213, 2671);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 2322, 2366);

                FormatEntryData
                fed = f_1094_2344_2365()
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 2382, 2633) || true) && (this.dataBaseInfo.view != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 2382, 2633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 2435, 2517);

                    fed.formatEntryInfo = f_1094_2457_2516(this, so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 2382, 2633);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 2382, 2633);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 2553, 2633);

                    fed.formatEntryInfo = f_1094_2575_2632(this, so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 2382, 2633);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 2649, 2660);

                return fed;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1094, 2213, 2671);

                Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData
                f_1094_2344_2365()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatEntryData();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 2344, 2365);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.WideViewEntry
                f_1094_2457_2516(Microsoft.PowerShell.Commands.Internal.Format.WideViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit)
                {
                    var return_v = this_param.GenerateWideViewEntryFromDataBaseInfo(so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 2457, 2516);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.WideViewEntry
                f_1094_2575_2632(Microsoft.PowerShell.Commands.Internal.Format.WideViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit)
                {
                    var return_v = this_param.GenerateWideViewEntryFromProperties(so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 2575, 2632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1094, 2213, 2671);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1094, 2213, 2671);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private WideViewEntry GenerateWideViewEntryFromDataBaseInfo(PSObject so, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1094, 2683, 3339);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 2802, 2881);

                WideControlBody
                wideBody = (WideControlBody)this.dataBaseInfo.view.mainControl
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 2897, 3030);

                WideControlEntryDefinition
                activeWideControlEntryDefinition =
                f_1094_2980_3029(this, wideBody, so)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 3046, 3086);

                WideViewEntry
                wve = f_1094_3066_3085()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 3100, 3226);

                wve.formatPropertyField = f_1094_3126_3225(this, activeWideControlEntryDefinition.formatTokenList, so, enumerationLimit);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 3317, 3328);

                return wve;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1094, 2683, 3339);

                Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition
                f_1094_2980_3029(Microsoft.PowerShell.Commands.Internal.Format.WideViewGenerator
                this_param, Microsoft.PowerShell.Commands.Internal.Format.WideControlBody
                wideBody, System.Management.Automation.PSObject
                so)
                {
                    var return_v = this_param.GetActiveWideControlEntryDefinition(wideBody, so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 2980, 3029);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.WideViewEntry
                f_1094_3066_3085()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.WideViewEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 3066, 3085);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                f_1094_3126_3225(Microsoft.PowerShell.Commands.Internal.Format.WideViewGenerator
                this_param, System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.FormatToken>
                formatTokenList, System.Management.Automation.PSObject
                so, int
                enumerationLimit)
                {
                    var return_v = this_param.GenerateFormatPropertyField(formatTokenList, so, enumerationLimit);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 3126, 3225);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1094, 2683, 3339);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1094, 2683, 3339);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private WideControlEntryDefinition GetActiveWideControlEntryDefinition(WideControlBody wideBody, PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1094, 3351, 5047);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 3541, 3578);

                var
                typeNames = f_1094_3557_3577(so)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 3592, 3676);

                TypeMatch
                match = f_1094_3610_3675(expressionFactory, this.dataBaseInfo.db, typeNames)
                ;
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 3690, 3933);
                    foreach (WideControlEntryDefinition x in f_1094_3731_3757_I(wideBody.optionalEntryList))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 3690, 3933);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 3791, 3918) || true) && (f_1094_3795_3848(match, f_1094_3814_3847(x, x.appliesTo)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 3791, 3918);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 3890, 3899);

                            return x;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 3791, 3918);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 3690, 3933);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1094, 1, 244);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1094, 1, 244);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 3949, 5036) || true) && (f_1094_3953_3968(match) != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 3949, 5036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 4010, 4063);

                    return f_1094_4017_4032(match) as WideControlEntryDefinition;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 3949, 5036);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 3949, 5036);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 4129, 4219);

                    Collection<string>
                    typesWithoutPrefix = f_1094_4169_4218(typeNames)
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 4237, 4901) || true) && (typesWithoutPrefix != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 4237, 4901);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 4309, 4392);

                        match = f_1094_4317_4391(expressionFactory, this.dataBaseInfo.db, typesWithoutPrefix);
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 4414, 4705);
                            foreach (WideControlEntryDefinition x in f_1094_4455_4481_I(wideBody.optionalEntryList))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 4414, 4705);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 4531, 4682) || true) && (f_1094_4535_4588(match, f_1094_4554_4587(x, x.appliesTo)))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 4531, 4682);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 4646, 4655);

                                    return x;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 4531, 4682);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 4414, 4705);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1094, 1, 292);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1094, 1, 292);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 4729, 4882) || true) && (f_1094_4733_4748(match) != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 4729, 4882);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 4806, 4859);

                            return f_1094_4813_4828(match) as WideControlEntryDefinition;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 4729, 4882);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 4237, 4901);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 4982, 5021);

                    return wideBody.defaultEntryDefinition;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 3949, 5036);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1094, 3351, 5047);

                System.Management.Automation.Runspaces.ConsolidatedString
                f_1094_3557_3577(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.InternalTypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 3557, 3577);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                f_1094_3610_3675(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatch(expressionFactory, db, (System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 3610, 3675);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                f_1094_3814_3847(Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition
                obj, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                a)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem((object)obj, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 3814, 3847);
                    return return_v;
                }


                bool
                f_1094_3795_3848(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                item)
                {
                    var return_v = this_param.PerfectMatch(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 3795, 3848);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition>
                f_1094_3731_3757_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 3731, 3757);
                    return return_v;
                }


                object
                f_1094_3953_3968(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 3953, 3968);
                    return return_v;
                }


                object
                f_1094_4017_4032(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 4017, 4032);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1094_4169_4218(System.Management.Automation.Runspaces.ConsolidatedString
                typeNames)
                {
                    var return_v = Deserializer.MaskDeserializationPrefix((System.Collections.ObjectModel.Collection<string>)typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 4169, 4218);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                f_1094_4317_4391(Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory, Microsoft.PowerShell.Commands.Internal.Format.TypeInfoDataBase
                db, System.Collections.ObjectModel.Collection<string>
                typeNames)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatch(expressionFactory, db, typeNames);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 4317, 4391);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                f_1094_4554_4587(Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition
                obj, Microsoft.PowerShell.Commands.Internal.Format.AppliesTo
                a)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem((object)obj, a);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 4554, 4587);
                    return return_v;
                }


                bool
                f_1094_4535_4588(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param, Microsoft.PowerShell.Commands.Internal.Format.TypeMatchItem
                item)
                {
                    var return_v = this_param.PerfectMatch(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 4535, 4588);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition>
                f_1094_4455_4481_I(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.WideControlEntryDefinition>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 4455, 4481);
                    return return_v;
                }


                object
                f_1094_4733_4748(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 4733, 4748);
                    return return_v;
                }


                object
                f_1094_4813_4828(Microsoft.PowerShell.Commands.Internal.Format.TypeMatch
                this_param)
                {
                    var return_v = this_param.BestMatch;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 4813, 4828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1094, 3351, 5047);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1094, 3351, 5047);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private WideViewEntry GenerateWideViewEntryFromProperties(PSObject so, int enumerationLimit)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1094, 5059, 6234);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 5229, 5340) || true) && (this.activeAssociationList == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 5229, 5340);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 5301, 5325);

                    f_1094_5301_5324(this, so);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 5229, 5340);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 5356, 5396);

                WideViewEntry
                wve = f_1094_5376_5395()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 5410, 5462);

                FormatPropertyField
                fpf = f_1094_5436_5461()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 5478, 5508);

                wve.formatPropertyField = fpf;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 5522, 6148) || true) && (f_1094_5526_5558(this.activeAssociationList) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 5522, 6148);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 5634, 5710);

                    MshResolvedExpressionParameterAssociation
                    a = f_1094_5680_5709(this.activeAssociationList, 0)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 5728, 5770);

                    FieldFormattingDirective
                    directive = null
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 5788, 6007) || true) && (f_1094_5792_5814(a) != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 5788, 6007);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 5864, 5988);

                        directive = f_1094_5876_5959(f_1094_5876_5898(a), FormatParameterDefinitionKeys.FormatStringEntryKey) as FieldFormattingDirective;
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 5788, 6007);
                    }
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 6027, 6133);

                    fpf.propertyValue = f_1094_6047_6132(this, so, enumerationLimit, f_1094_6100_6120(a), directive);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 5522, 6148);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 6164, 6198);

                this.activeAssociationList = null;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 6212, 6223);

                return wve;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1094, 5059, 6234);

                int
                f_1094_5301_5324(Microsoft.PowerShell.Commands.Internal.Format.WideViewGenerator
                this_param, System.Management.Automation.PSObject
                so)
                {
                    this_param.SetUpActiveProperty(so);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 5301, 5324);
                    return 0;
                }


                Microsoft.PowerShell.Commands.Internal.Format.WideViewEntry
                f_1094_5376_5395()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.WideViewEntry();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 5376, 5395);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField
                f_1094_5436_5461()
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.FormatPropertyField();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 5436, 5461);
                    return return_v;
                }


                int
                f_1094_5526_5558(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 5526, 5558);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1094_5680_5709(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 5680, 5709);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1094_5792_5814(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 5792, 5814);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                f_1094_5876_5898(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.OriginatingParameter;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 5876, 5898);
                    return return_v;
                }


                object
                f_1094_5876_5959(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                this_param, string
                key)
                {
                    var return_v = this_param.GetEntry(key);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 5876, 5959);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1094_6100_6120(Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                this_param)
                {
                    var return_v = this_param.ResolvedExpression;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 6100, 6120);
                    return return_v;
                }


                string
                f_1094_6047_6132(Microsoft.PowerShell.Commands.Internal.Format.WideViewGenerator
                this_param, System.Management.Automation.PSObject
                so, int
                enumerationLimit, Microsoft.PowerShell.Commands.PSPropertyExpression
                ex, Microsoft.PowerShell.Commands.Internal.Format.FieldFormattingDirective
                directive)
                {
                    var return_v = this_param.GetExpressionDisplayValue(so, enumerationLimit, ex, directive);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 6047, 6132);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1094, 5059, 6234);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1094, 5059, 6234);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        private void SetUpActiveProperty(PSObject so)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1094, 6246, 7970);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 6316, 6362);

                List<MshParameter>
                rawMshParameterList = null
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 6378, 6489) || true) && (this.inputParameters != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 6378, 6489);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 6429, 6489);

                    rawMshParameterList = this.inputParameters.mshParameterList;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 6378, 6489);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 6575, 6803) || true) && (rawMshParameterList != null && (DynAbs.Tracing.TraceSender.Expression_True(1094, 6579, 6639) && f_1094_6610_6635(rawMshParameterList) > 0))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 6575, 6803);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 6673, 6763);

                    this.activeAssociationList = f_1094_6702_6762(rawMshParameterList, so);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 6781, 6788);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 6575, 6803);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 6928, 7041);

                PSPropertyExpression
                displayNameExpression = f_1094_6973_7040(so, this.expressionFactory)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 7055, 7370) || true) && (displayNameExpression != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 7055, 7370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 7122, 7205);

                    this.activeAssociationList = f_1094_7151_7204();
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 7223, 7330);

                    f_1094_7223_7329(this.activeAssociationList, f_1094_7254_7328(null, displayNameExpression));
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 7348, 7355);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 7055, 7370);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 7471, 7572);

                this.activeAssociationList = f_1094_7500_7571(so, this.expressionFactory);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 7586, 7765) || true) && (f_1094_7590_7622(this.activeAssociationList) > 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1094, 7586, 7765);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 7743, 7750);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1094, 7586, 7765);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1094, 7897, 7959);

                this.activeAssociationList = f_1094_7926_7958(so);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1094, 6246, 7970);

                int
                f_1094_6610_6635(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 6610, 6635);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1094_6702_6762(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshParameter>
                parameters, System.Management.Automation.PSObject
                target)
                {
                    var return_v = AssociationManager.ExpandParameters(parameters, target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 6702, 6762);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.PSPropertyExpression
                f_1094_6973_7040(System.Management.Automation.PSObject
                target, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = PSObjectHelper.GetDisplayNameExpression(target, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 6973, 7040);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1094_7151_7204()
                {
                    var return_v = new System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 7151, 7204);
                    return return_v;
                }


                Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                f_1094_7254_7328(Microsoft.PowerShell.Commands.Internal.Format.MshParameter
                parameter, Microsoft.PowerShell.Commands.PSPropertyExpression
                expression)
                {
                    var return_v = new Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation(parameter, expression);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 7254, 7328);
                    return return_v;
                }


                int
                f_1094_7223_7329(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param, Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 7223, 7329);
                    return 0;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1094_7500_7571(System.Management.Automation.PSObject
                target, Microsoft.PowerShell.Commands.Internal.Format.PSPropertyExpressionFactory
                expressionFactory)
                {
                    var return_v = AssociationManager.ExpandDefaultPropertySet(target, expressionFactory);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 7500, 7571);
                    return return_v;
                }


                int
                f_1094_7590_7622(System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1094, 7590, 7622);
                    return return_v;
                }


                System.Collections.Generic.List<Microsoft.PowerShell.Commands.Internal.Format.MshResolvedExpressionParameterAssociation>
                f_1094_7926_7958(System.Management.Automation.PSObject
                target)
                {
                    var return_v = AssociationManager.ExpandAll(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1094, 7926, 7958);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1094, 6246, 7970);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1094, 6246, 7970);
            }
        }

        public WideViewGenerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1094, 277, 7977);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1094, 277, 7977);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1094, 277, 7977);
        }


        static WideViewGenerator()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1094, 277, 7977);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1094, 277, 7977);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1094, 277, 7977);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1094, 277, 7977);
    }
}

