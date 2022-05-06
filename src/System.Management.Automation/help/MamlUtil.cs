// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Management.Automation.Help;

namespace System.Management.Automation
{
    internal class MamlUtil
    {
        internal static void OverrideName(PSObject maml1, PSObject maml2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1166, 533, 791);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 623, 689);

                f_1166_623_688(maml1, maml2, new string[] { "Name" }, true);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 703, 780);

                f_1166_703_779(maml1, maml2, new string[] { "Details", "Name" }, true);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1166, 533, 791);

                int
                f_1166_623_688(System.Management.Automation.PSObject
                maml1, System.Management.Automation.PSObject
                maml2, string[]
                path, bool
                shouldOverride)
                {
                    PrependPropertyValue(maml1, maml2, path, shouldOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 623, 688);
                    return 0;
                }


                int
                f_1166_703_779(System.Management.Automation.PSObject
                maml1, System.Management.Automation.PSObject
                maml2, string[]
                path, bool
                shouldOverride)
                {
                    PrependPropertyValue(maml1, maml2, path, shouldOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 703, 779);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1166, 533, 791);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1166, 533, 791);
            }
        }

        internal static void OverridePSTypeNames(PSObject maml1, PSObject maml2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1166, 1002, 1718);
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 1099, 1489);
                    foreach (var typename in f_1166_1124_1139_I(f_1166_1124_1139(maml2)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 1099, 1489);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 1173, 1474) || true) && (f_1166_1177_1288(typename, DefaultCommandHelpObjectBuilder.TypeNameForDefaultHelp, StringComparison.OrdinalIgnoreCase))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 1173, 1474);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 1448, 1455);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 1173, 1474);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 1099, 1489);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1166, 1, 391);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1166, 1, 391);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 1505, 1529);

                f_1166_1505_1528(f_1166_1505_1520(maml1));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 1585, 1707);
                    foreach (string typeName in f_1166_1613_1628_I(f_1166_1613_1628(maml2)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 1585, 1707);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 1662, 1692);

                        f_1166_1662_1691(f_1166_1662_1677(maml1), typeName);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 1585, 1707);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1166, 1, 123);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1166, 1, 123);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1166, 1002, 1718);

                System.Collections.ObjectModel.Collection<string>
                f_1166_1124_1139(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 1124, 1139);
                    return return_v;
                }


                bool
                f_1166_1177_1288(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.StartsWith(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 1177, 1288);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1166_1124_1139_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 1124, 1139);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1166_1505_1520(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 1505, 1520);
                    return return_v;
                }


                int
                f_1166_1505_1528(System.Collections.ObjectModel.Collection<string>
                this_param)
                {
                    this_param.Clear();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 1505, 1528);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1166_1613_1628(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 1613, 1628);
                    return return_v;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1166_1662_1677(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.TypeNames;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 1662, 1677);
                    return return_v;
                }


                int
                f_1166_1662_1691(System.Collections.ObjectModel.Collection<string>
                this_param, string
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 1662, 1691);
                    return 0;
                }


                System.Collections.ObjectModel.Collection<string>
                f_1166_1613_1628_I(System.Collections.ObjectModel.Collection<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 1613, 1628);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1166, 1002, 1718);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1166, 1002, 1718);
            }
        }

        internal static void AddCommonProperties(PSObject maml1, PSObject maml2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1166, 1943, 2745);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 2040, 2370) || true) && (f_1166_2044_2072(f_1166_2044_2060(maml1), "PSSnapIn") == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 2040, 2370);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 2114, 2175);

                    PSPropertyInfo
                    snapInProperty = f_1166_2146_2174(f_1166_2146_2162(maml2), "PSSnapIn")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 2193, 2355) || true) && (snapInProperty != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 2193, 2355);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 2261, 2336);

                        f_1166_2261_2335(f_1166_2261_2277(maml1), f_1166_2282_2334("PSSnapIn", f_1166_2313_2333(snapInProperty)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 2193, 2355);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 2040, 2370);
                }

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 2386, 2734) || true) && (f_1166_2390_2420(f_1166_2390_2406(maml1), "ModuleName") == null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 2386, 2734);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 2462, 2529);

                    PSPropertyInfo
                    moduleNameProperty = f_1166_2498_2528(f_1166_2498_2514(maml2), "ModuleName")
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 2547, 2719) || true) && (moduleNameProperty != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 2547, 2719);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 2619, 2700);

                        f_1166_2619_2699(f_1166_2619_2635(maml1), f_1166_2640_2698("ModuleName", f_1166_2673_2697(moduleNameProperty)));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 2547, 2719);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 2386, 2734);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1166, 1943, 2745);

                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1166_2044_2060(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 2044, 2060);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1166_2044_2072(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 2044, 2072);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1166_2146_2162(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 2146, 2162);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1166_2146_2174(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 2146, 2174);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1166_2261_2277(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 2261, 2277);
                    return return_v;
                }


                object
                f_1166_2313_2333(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 2313, 2333);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1166_2282_2334(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 2282, 2334);
                    return return_v;
                }


                int
                f_1166_2261_2335(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 2261, 2335);
                    return 0;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1166_2390_2406(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 2390, 2406);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1166_2390_2420(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 2390, 2420);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1166_2498_2514(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 2498, 2514);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1166_2498_2528(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 2498, 2528);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1166_2619_2635(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 2619, 2635);
                    return return_v;
                }


                object
                f_1166_2673_2697(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 2673, 2697);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1166_2640_2698(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 2640, 2698);
                    return return_v;
                }


                int
                f_1166_2619_2699(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSNoteProperty
                member)
                {
                    this_param.Add((System.Management.Automation.PSPropertyInfo)member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 2619, 2699);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1166, 1943, 2745);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1166, 1943, 2745);
            }
        }

        internal static void PrependSyntax(PSObject maml1, PSObject maml2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1166, 2895, 3080);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 2986, 3069);

                f_1166_2986_3068(maml1, maml2, new string[] { "Syntax", "SyntaxItem" }, false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1166, 2895, 3080);

                int
                f_1166_2986_3068(System.Management.Automation.PSObject
                maml1, System.Management.Automation.PSObject
                maml2, string[]
                path, bool
                shouldOverride)
                {
                    PrependPropertyValue(maml1, maml2, path, shouldOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 2986, 3068);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1166, 2895, 3080);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1166, 2895, 3080);
            }
        }

        internal static void PrependDetailedDescription(PSObject maml1, PSObject maml2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1166, 3256, 3445);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 3360, 3434);

                f_1166_3360_3433(maml1, maml2, new string[] { "Description" }, false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1166, 3256, 3445);

                int
                f_1166_3360_3433(System.Management.Automation.PSObject
                maml1, System.Management.Automation.PSObject
                maml2, string[]
                path, bool
                shouldOverride)
                {
                    PrependPropertyValue(maml1, maml2, path, shouldOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 3360, 3433);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1166, 3256, 3445);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1166, 3256, 3445);
            }
        }

        internal static void OverrideParameters(PSObject maml1, PSObject maml2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1166, 3685, 7144);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 3781, 3850);

                string[]
                parametersPath = new string[] { "Parameters", "Parameter" }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 3911, 3956);

                List<object>
                maml2items = f_1166_3937_3955()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 4101, 4171);

                PSPropertyInfo
                propertyInfo2 = f_1166_4132_4170(maml2, parametersPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 4185, 4226);

                var
                array = f_1166_4197_4216(propertyInfo2) as Array
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 4240, 4479) || true) && (array != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 4240, 4479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 4291, 4341);

                    f_1166_4291_4340(maml2items, array);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 4240, 4479);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 4240, 4479);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 4407, 4464);

                    f_1166_4407_4463(maml2items, f_1166_4422_4462(f_1166_4442_4461(propertyInfo2)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 4240, 4479);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 4598, 4650);

                f_1166_4598_4649(maml1, parametersPath);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 4764, 4834);

                PSPropertyInfo
                propertyInfo1 = f_1166_4795_4833(maml1, parametersPath)
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 4848, 4893);

                List<object>
                maml1items = f_1166_4874_4892()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 4907, 4944);

                array = f_1166_4915_4934(propertyInfo1) as Array;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 4958, 5197) || true) && (array != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 4958, 5197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 5009, 5059);

                    f_1166_5009_5058(maml1items, array);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 4958, 5197);
                }

                else

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 4958, 5197);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 5125, 5182);

                    f_1166_5125_5181(maml1items, f_1166_5140_5180(f_1166_5160_5179(propertyInfo1)));
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 4958, 5197);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 5295, 5304);

                    // copy parameters from maml2 that are not present in maml1
                    for (int
        index = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 5286, 6773) || true) && (index < f_1166_5314_5330(maml2items))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 5332, 5339)
        , index++, DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 5286, 6773))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 5286, 6773);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 5373, 5434);

                        PSObject
                        m2paramObj = f_1166_5395_5433(f_1166_5415_5432(maml2items, index))
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 5452, 5485);

                        string
                        param2Name = string.Empty
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 5503, 5565);

                        PSPropertyInfo
                        m2propertyInfo = f_1166_5535_5564(f_1166_5535_5556(m2paramObj), "Name")
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 5585, 5836) || true) && (m2propertyInfo != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 5585, 5836);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 5653, 5817) || true) && (!f_1166_5658_5735(f_1166_5698_5718(m2propertyInfo), out param2Name))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 5653, 5817);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 5785, 5794);

                                continue;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 5653, 5817);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 5585, 5836);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 5856, 5889);

                        bool
                        isParamFoundInMaml1 = false
                        ;
                        try
                        {
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 5907, 6619);
                            foreach (PSObject m1ParamObj in f_1166_5939_5949_I(maml1items))
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 5907, 6619);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 5991, 6024);

                                string
                                param1Name = string.Empty
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 6046, 6108);

                                PSPropertyInfo
                                m1PropertyInfo = f_1166_6078_6107(f_1166_6078_6099(m1ParamObj), "Name")
                                ;

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 6132, 6407) || true) && (m1PropertyInfo != null)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 6132, 6407);

                                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 6208, 6384) || true) && (!f_1166_6213_6290(f_1166_6253_6273(m1PropertyInfo), out param1Name))
                                    )

                                    {
                                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 6208, 6384);
                                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 6348, 6357);

                                        continue;
                                        DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 6208, 6384);
                                    }
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 6132, 6407);
                                }

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 6431, 6600) || true) && (f_1166_6435_6500(param1Name, param2Name, StringComparison.OrdinalIgnoreCase))
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 6431, 6600);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 6550, 6577);

                                    isParamFoundInMaml1 = true;
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 6431, 6600);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 5907, 6619);
                            }
                        }
                        catch (System.Exception)
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoopByException(1166, 1, 713);
                            throw;
                        }
                        finally
                        {
                            DynAbs.Tracing.TraceSender.TraceExitLoop(1166, 1, 713);
                        }
                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 6639, 6758) || true) && (!isParamFoundInMaml1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 6639, 6758);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 6705, 6739);

                            f_1166_6705_6738(maml1items, f_1166_6720_6737(maml2items, index));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 6639, 6758);
                        }
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1166, 1, 1488);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1166, 1, 1488);
                }
                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 6887, 7133) || true) && (f_1166_6891_6907(maml1items) == 1)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 6887, 7133);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 6946, 6982);

                    propertyInfo1.Value = f_1166_6968_6981(maml1items, 0);
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 6887, 7133);
                }

                else
                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 6887, 7133);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 7016, 7133) || true) && (f_1166_7020_7036(maml1items) >= 2)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 7016, 7133);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 7075, 7118);

                        propertyInfo1.Value = f_1166_7097_7117(maml1items);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 7016, 7133);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 6887, 7133);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1166, 3685, 7144);

                System.Collections.Generic.List<object>
                f_1166_3937_3955()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 3937, 3955);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1166_4132_4170(System.Management.Automation.PSObject
                psObject, string[]
                path)
                {
                    var return_v = GetPropertyInfo(psObject, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 4132, 4170);
                    return return_v;
                }


                object
                f_1166_4197_4216(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 4197, 4216);
                    return return_v;
                }


                int
                f_1166_4291_4340(System.Collections.Generic.List<object>
                this_param, System.Array
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<object>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 4291, 4340);
                    return 0;
                }


                object
                f_1166_4442_4461(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 4442, 4461);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1166_4422_4462(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 4422, 4462);
                    return return_v;
                }


                int
                f_1166_4407_4463(System.Collections.Generic.List<object>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 4407, 4463);
                    return 0;
                }


                int
                f_1166_4598_4649(System.Management.Automation.PSObject
                psObject, string[]
                path)
                {
                    EnsurePropertyInfoPathExists(psObject, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 4598, 4649);
                    return 0;
                }


                System.Management.Automation.PSPropertyInfo
                f_1166_4795_4833(System.Management.Automation.PSObject
                psObject, string[]
                path)
                {
                    var return_v = GetPropertyInfo(psObject, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 4795, 4833);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1166_4874_4892()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 4874, 4892);
                    return return_v;
                }


                object
                f_1166_4915_4934(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 4915, 4934);
                    return return_v;
                }


                int
                f_1166_5009_5058(System.Collections.Generic.List<object>
                this_param, System.Array
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<object>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 5009, 5058);
                    return 0;
                }


                object
                f_1166_5160_5179(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 5160, 5179);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1166_5140_5180(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 5140, 5180);
                    return return_v;
                }


                int
                f_1166_5125_5181(System.Collections.Generic.List<object>
                this_param, System.Management.Automation.PSObject
                item)
                {
                    this_param.Add((object)item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 5125, 5181);
                    return 0;
                }


                int
                f_1166_5314_5330(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 5314, 5330);
                    return return_v;
                }


                object
                f_1166_5415_5432(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 5415, 5432);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1166_5395_5433(object
                obj)
                {
                    var return_v = PSObject.AsPSObject(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 5395, 5433);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1166_5535_5556(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 5535, 5556);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1166_5535_5564(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 5535, 5564);
                    return return_v;
                }


                object
                f_1166_5698_5718(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 5698, 5718);
                    return return_v;
                }


                bool
                f_1166_5658_5735(object
                valueToConvert, out string
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo<string>(valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 5658, 5735);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1166_6078_6099(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 6078, 6099);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1166_6078_6107(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 6078, 6107);
                    return return_v;
                }


                object
                f_1166_6253_6273(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 6253, 6273);
                    return return_v;
                }


                bool
                f_1166_6213_6290(object
                valueToConvert, out string
                result)
                {
                    var return_v = LanguagePrimitives.TryConvertTo<string>(valueToConvert, out result);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 6213, 6290);
                    return return_v;
                }


                bool
                f_1166_6435_6500(string
                this_param, string
                value, System.StringComparison
                comparisonType)
                {
                    var return_v = this_param.Equals(value, comparisonType);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 6435, 6500);
                    return return_v;
                }


                System.Collections.Generic.List<object>
                f_1166_5939_5949_I(System.Collections.Generic.List<object>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 5939, 5949);
                    return return_v;
                }


                object
                f_1166_6720_6737(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 6720, 6737);
                    return return_v;
                }


                int
                f_1166_6705_6738(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 6705, 6738);
                    return 0;
                }


                int
                f_1166_6891_6907(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 6891, 6907);
                    return return_v;
                }


                object
                f_1166_6968_6981(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 6968, 6981);
                    return return_v;
                }


                int
                f_1166_7020_7036(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 7020, 7036);
                    return return_v;
                }


                object[]
                f_1166_7097_7117(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 7097, 7117);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1166, 3685, 7144);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1166, 3685, 7144);
            }
        }

        internal static void PrependNotes(PSObject maml1, PSObject maml2)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1166, 7292, 7473);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 7382, 7462);

                f_1166_7382_7461(maml1, maml2, new string[] { "AlertSet", "Alert" }, false);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1166, 7292, 7473);

                int
                f_1166_7382_7461(System.Management.Automation.PSObject
                maml1, System.Management.Automation.PSObject
                maml2, string[]
                path, bool
                shouldOverride)
                {
                    PrependPropertyValue(maml1, maml2, path, shouldOverride);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 7382, 7461);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1166, 7292, 7473);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1166, 7292, 7473);
            }
        }

        internal static PSPropertyInfo GetPropertyInfo(PSObject psObject, string[] path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1166, 7564, 8426);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 7669, 7750) || true) && (f_1166_7673_7684(path) <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 7669, 7750);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 7723, 7735);

                    return null;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 7669, 7750);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 7775, 7780);

                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 7766, 8300) || true) && (i < f_1166_7786_7797(path))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 7799, 7802)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 7766, 8300))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 7766, 8300);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 7836, 7866);

                        string
                        propertyName = path[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 7884, 7948);

                        PSPropertyInfo
                        propertyInfo = f_1166_7914_7947(f_1166_7914_7933(psObject), propertyName)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 7966, 8071) || true) && (i == f_1166_7975_7986(path) - 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 7966, 8071);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 8032, 8052);

                            return propertyInfo;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 7966, 8071);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 8091, 8225) || true) && (propertyInfo == null || (DynAbs.Tracing.TraceSender.Expression_False(1166, 8095, 8152) || !(f_1166_8121_8139(propertyInfo) is PSObject)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 8091, 8225);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 8194, 8206);

                            return null;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 8091, 8225);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 8245, 8285);

                        psObject = (PSObject)f_1166_8266_8284(propertyInfo);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1166, 1, 535);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1166, 1, 535);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 8403, 8415);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1166, 7564, 8426);

                int
                f_1166_7673_7684(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 7673, 7684);
                    return return_v;
                }


                int
                f_1166_7786_7797(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 7786, 7797);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1166_7914_7933(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 7914, 7933);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1166_7914_7947(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 7914, 7947);
                    return return_v;
                }


                int
                f_1166_7975_7986(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 7975, 7986);
                    return return_v;
                }


                object
                f_1166_8121_8139(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 8121, 8139);
                    return return_v;
                }


                object
                f_1166_8266_8284(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 8266, 8284);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1166, 7564, 8426);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1166, 7564, 8426);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        internal static void PrependPropertyValue(PSObject maml1, PSObject maml2, string[] path, bool shouldOverride)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1166, 8830, 10888);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 9011, 9051);

                List<object>
                items = f_1166_9032_9050()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 9196, 9256);

                PSPropertyInfo
                propertyInfo2 = f_1166_9227_9255(maml2, path)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 9272, 9655) || true) && (propertyInfo2 != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 9272, 9655);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 9331, 9372);

                    var
                    array = f_1166_9343_9362(propertyInfo2) as Array
                    ;

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 9390, 9640) || true) && (array != null)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 9390, 9640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 9449, 9508);

                        f_1166_9449_9507(items, f_1166_9464_9483(propertyInfo2) as IEnumerable<object>);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 9390, 9640);
                    }

                    else

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 9390, 9640);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 9590, 9621);

                        f_1166_9590_9620(items, f_1166_9600_9619(propertyInfo2));
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 9390, 9640);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 9272, 9655);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 9774, 9816);

                f_1166_9774_9815(maml1, path);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 9930, 9990);

                PSPropertyInfo
                propertyInfo1 = f_1166_9961_9989(maml1, path)
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 10006, 10877) || true) && (propertyInfo1 != null)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 10006, 10877);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 10065, 10486) || true) && (!shouldOverride)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 10065, 10486);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 10126, 10167);

                        var
                        array = f_1166_10138_10157(propertyInfo1) as Array
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 10189, 10467) || true) && (array != null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 10189, 10467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 10256, 10315);

                            f_1166_10256_10314(items, f_1166_10271_10290(propertyInfo1) as IEnumerable<object>);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 10189, 10467);
                        }

                        else

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 10189, 10467);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 10413, 10444);

                            f_1166_10413_10443(items, f_1166_10423_10442(propertyInfo1));
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 10189, 10467);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 10065, 10486);
                    }

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 10608, 10862) || true) && (f_1166_10612_10623(items) == 1)
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 10608, 10862);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 10670, 10701);

                        propertyInfo1.Value = f_1166_10692_10700(items, 0);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 10608, 10862);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 10608, 10862);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 10743, 10862) || true) && (f_1166_10747_10758(items) >= 2)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 10743, 10862);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 10805, 10843);

                            propertyInfo1.Value = f_1166_10827_10842(items);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 10743, 10862);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 10608, 10862);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 10006, 10877);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1166, 8830, 10888);

                System.Collections.Generic.List<object>
                f_1166_9032_9050()
                {
                    var return_v = new System.Collections.Generic.List<object>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 9032, 9050);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1166_9227_9255(System.Management.Automation.PSObject
                psObject, string[]
                path)
                {
                    var return_v = GetPropertyInfo(psObject, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 9227, 9255);
                    return return_v;
                }


                object
                f_1166_9343_9362(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 9343, 9362);
                    return return_v;
                }


                object
                f_1166_9464_9483(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 9464, 9483);
                    return return_v;
                }


                int
                f_1166_9449_9507(System.Collections.Generic.List<object>
                this_param, object
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<object>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 9449, 9507);
                    return 0;
                }


                object
                f_1166_9600_9619(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 9600, 9619);
                    return return_v;
                }


                int
                f_1166_9590_9620(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 9590, 9620);
                    return 0;
                }


                int
                f_1166_9774_9815(System.Management.Automation.PSObject
                psObject, string[]
                path)
                {
                    EnsurePropertyInfoPathExists(psObject, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 9774, 9815);
                    return 0;
                }


                System.Management.Automation.PSPropertyInfo
                f_1166_9961_9989(System.Management.Automation.PSObject
                psObject, string[]
                path)
                {
                    var return_v = GetPropertyInfo(psObject, path);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 9961, 9989);
                    return return_v;
                }


                object
                f_1166_10138_10157(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 10138, 10157);
                    return return_v;
                }


                object
                f_1166_10271_10290(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 10271, 10290);
                    return return_v;
                }


                int
                f_1166_10256_10314(System.Collections.Generic.List<object>
                this_param, object
                collection)
                {
                    this_param.AddRange((System.Collections.Generic.IEnumerable<object>)collection);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 10256, 10314);
                    return 0;
                }


                object
                f_1166_10423_10442(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 10423, 10442);
                    return return_v;
                }


                int
                f_1166_10413_10443(System.Collections.Generic.List<object>
                this_param, object
                item)
                {
                    this_param.Add(item);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 10413, 10443);
                    return 0;
                }


                int
                f_1166_10612_10623(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 10612, 10623);
                    return return_v;
                }


                object
                f_1166_10692_10700(System.Collections.Generic.List<object>
                this_param, int
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 10692, 10700);
                    return return_v;
                }


                int
                f_1166_10747_10758(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.Count;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 10747, 10758);
                    return return_v;
                }


                object[]
                f_1166_10827_10842(System.Collections.Generic.List<object>
                this_param)
                {
                    var return_v = this_param.ToArray();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 10827, 10842);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1166, 8830, 10888);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1166, 8830, 10888);
            }
        }

        internal static void EnsurePropertyInfoPathExists(PSObject psObject, string[] path)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1166, 10994, 12561);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 11102, 11178) || true) && (f_1166_11106_11117(path) <= 0)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 11102, 11178);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 11156, 11163);

                    return;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 11102, 11178);
                }
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 11261, 11266);

                    // Walk the path and extend it if necessary.
                    for (int
        i = 0
        ; (DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 11252, 12550) || true) && (i < f_1166_11272_11283(path))
        ; DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 11285, 11288)
        , ++i, DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 11252, 12550))

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 11252, 12550);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 11322, 11352);

                        string
                        propertyName = path[i]
                        ;
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 11370, 11434);

                        PSPropertyInfo
                        propertyInfo = f_1166_11400_11433(f_1166_11400_11419(psObject), propertyName)
                        ;

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 11518, 11911) || true) && (propertyInfo == null)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 11518, 11911);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 11678, 11747);

                            object
                            propertyValue = (DynAbs.Tracing.TraceSender.Conditional_F1(1166, 11701, 11722) || (((i < f_1166_11706_11717(path) - 1) && DynAbs.Tracing.TraceSender.Conditional_F2(1166, 11725, 11739)) || DynAbs.Tracing.TraceSender.Conditional_F3(1166, 11742, 11746))) ? f_1166_11725_11739() : null
                            ;
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 11769, 11832);

                            propertyInfo = f_1166_11784_11831(propertyName, propertyValue);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 11854, 11892);

                            f_1166_11854_11891(f_1166_11854_11873(psObject), propertyInfo);
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 11518, 11911);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 12037, 12129) || true) && (i == f_1166_12046_12057(path) - 1)
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 12037, 12129);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 12103, 12110);

                            return;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 12037, 12129);
                        }

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 12249, 12413) || true) && (f_1166_12253_12271(propertyInfo) == null || (DynAbs.Tracing.TraceSender.Expression_False(1166, 12253, 12316) || !(f_1166_12285_12303(propertyInfo) is PSObject)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1166, 12249, 12413);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 12358, 12394);

                            propertyInfo.Value = f_1166_12379_12393();
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1166, 12249, 12413);
                        }
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1166, 12495, 12535);

                        psObject = (PSObject)f_1166_12516_12534(propertyInfo);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1166, 1, 1299);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1166, 1, 1299);
                }
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1166, 10994, 12561);

                int
                f_1166_11106_11117(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 11106, 11117);
                    return return_v;
                }


                int
                f_1166_11272_11283(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 11272, 11283);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1166_11400_11419(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 11400, 11419);
                    return return_v;
                }


                System.Management.Automation.PSPropertyInfo
                f_1166_11400_11433(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 11400, 11433);
                    return return_v;
                }


                int
                f_1166_11706_11717(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 11706, 11717);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1166_11725_11739()
                {
                    var return_v = new System.Management.Automation.PSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 11725, 11739);
                    return return_v;
                }


                System.Management.Automation.PSNoteProperty
                f_1166_11784_11831(string
                name, object
                value)
                {
                    var return_v = new System.Management.Automation.PSNoteProperty(name, value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 11784, 11831);
                    return return_v;
                }


                System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                f_1166_11854_11873(System.Management.Automation.PSObject
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 11854, 11873);
                    return return_v;
                }


                int
                f_1166_11854_11891(System.Management.Automation.PSMemberInfoCollection<System.Management.Automation.PSPropertyInfo>
                this_param, System.Management.Automation.PSPropertyInfo
                member)
                {
                    this_param.Add(member);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 11854, 11891);
                    return 0;
                }


                int
                f_1166_12046_12057(string[]
                this_param)
                {
                    var return_v = this_param.Length;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 12046, 12057);
                    return return_v;
                }


                object
                f_1166_12253_12271(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 12253, 12271);
                    return return_v;
                }


                object
                f_1166_12285_12303(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 12285, 12303);
                    return return_v;
                }


                System.Management.Automation.PSObject
                f_1166_12379_12393()
                {
                    var return_v = new System.Management.Automation.PSObject();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1166, 12379, 12393);
                    return return_v;
                }


                object
                f_1166_12516_12534(System.Management.Automation.PSPropertyInfo
                this_param)
                {
                    var return_v = this_param.Value;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1166, 12516, 12534);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1166, 10994, 12561);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1166, 10994, 12561);
            }
        }

        public MamlUtil()
        {
            DynAbs.Tracing.TraceSender.TraceEnterConstructor(1166, 294, 12568);
            DynAbs.Tracing.TraceSender.TraceExitConstructor(1166, 294, 12568);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1166, 294, 12568);
        }


        static MamlUtil()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1166, 294, 12568);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1166, 294, 12568);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1166, 294, 12568);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1166, 294, 12568);
    }
}
