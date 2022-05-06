// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;

using Microsoft.PowerShell;

namespace System.Management.Automation
{
    internal class ComAdapter : Adapter
    {
        private readonly ComTypeInfo _comTypeInfo;

        internal ComAdapter(ComTypeInfo typeinfo)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterConstructor(1376, 681, 875);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 473, 485);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 747, 826);

                f_1376_747_825(typeinfo != null, "Caller to verify typeinfo is not null.");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 840, 864);

                _comTypeInfo = typeinfo;
                DynAbs.Tracing.TraceSender.TraceExitConstructor(1376, 681, 875);
            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 681, 875);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 681, 875);
            }
        }

        internal static string GetComTypeName(string clsid)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterStaticMethod(1376, 887, 1193);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 963, 1029);

                StringBuilder
                firstType = f_1376_989_1028("System.__ComObject")
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 1043, 1066);

                f_1376_1043_1065(firstType, "#{");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 1080, 1104);

                f_1376_1080_1103(firstType, clsid);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 1118, 1140);

                f_1376_1118_1139(firstType, "}");
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 1154, 1182);

                return f_1376_1161_1181(firstType);
                DynAbs.Tracing.TraceSender.TraceExitStaticMethod(1376, 887, 1193);

                System.Text.StringBuilder
                f_1376_989_1028(string
                value)
                {
                    var return_v = new System.Text.StringBuilder(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 989, 1028);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1376_1043_1065(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 1043, 1065);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1376_1080_1103(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 1080, 1103);
                    return return_v;
                }


                System.Text.StringBuilder
                f_1376_1118_1139(System.Text.StringBuilder
                this_param, string
                value)
                {
                    var return_v = this_param.Append(value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 1118, 1139);
                    return return_v;
                }


                string
                f_1376_1161_1181(System.Text.StringBuilder
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 1161, 1181);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 887, 1193);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 887, 1193);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override IEnumerable<string> GetTypeNameHierarchy(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 1394, 1693);

                var listYield = new List<String>();
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 1490, 1538);

                listYield.Add(f_1376_1503_1537(f_1376_1518_1536(_comTypeInfo)));
                try
                {
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 1552, 1682);
                    foreach (string baseType in f_1376_1580_1611_I(f_1376_1580_1611(obj)))
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 1552, 1682);
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 1645, 1667);

                        listYield.Add(baseType);
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 1552, 1682);
                    }
                }
                catch (System.Exception)
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoopByException(1376, 1, 131);
                    throw;
                }
                finally
                {
                    DynAbs.Tracing.TraceSender.TraceExitLoop(1376, 1, 131);
                }
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 1394, 1693);

                return listYield;

                string
                f_1376_1518_1536(System.Management.Automation.ComTypeInfo
                this_param)
                {
                    var return_v = this_param.Clsid;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 1518, 1536);
                    return return_v;
                }


                string
                f_1376_1503_1537(string
                clsid)
                {
                    var return_v = GetComTypeName(clsid);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 1503, 1537);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1376_1580_1611(object
                obj)
                {
                    var return_v = GetDotNetTypeNameHierarchy(obj);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 1580, 1611);
                    return return_v;
                }


                System.Collections.Generic.IEnumerable<string>
                f_1376_1580_1611_I(System.Collections.Generic.IEnumerable<string>
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 1580, 1611);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 1394, 1693);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 1394, 1693);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override T GetMember<T>(object obj, string memberName)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 2121, 3223);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 2210, 2227);

                ComProperty
                prop
                = default(ComProperty);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 2241, 2829) || true) && (f_1376_2245_2302(f_1376_2245_2268(_comTypeInfo), memberName, out prop))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 2241, 2829);

                    if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 2336, 2814) || true) && (f_1376_2340_2360(prop))
                    )

                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 2336, 2814);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 2402, 2606) || true) && (f_1376_2406_2465(typeof(T), typeof(PSParameterizedProperty)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 2402, 2606);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 2515, 2583);

                            return f_1376_2522_2577(f_1376_2550_2559(prop), this, obj, prop) as T;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 2402, 2606);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 2336, 2814);
                    }

                    else
                    {
                        DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 2336, 2814);

                        if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 2648, 2814) || true) && (f_1376_2652_2698(typeof(T), typeof(PSProperty)))
                        )

                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 2648, 2814);
                            DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 2740, 2795);

                            return f_1376_2747_2789(f_1376_2762_2771(prop), this, obj, prop) as T;
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 2648, 2814);
                        }
                        DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 2336, 2814);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 2241, 2829);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 2845, 2862);

                ComMethod
                method
                = default(ComMethod);

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 2876, 3184) || true) && (f_1376_2880_2924(typeof(T), typeof(PSMethod)) && (DynAbs.Tracing.TraceSender.Expression_True(1376, 2880, 2967) && (_comTypeInfo != null)) && (DynAbs.Tracing.TraceSender.Expression_True(1376, 2880, 3029) && (f_1376_2972_3028(f_1376_2972_2992(_comTypeInfo), memberName, out method))))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 2876, 3184);
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 3063, 3129);

                    PSMethod
                    mshMethod = f_1376_3084_3128(f_1376_3097_3108(method), this, obj, method)
                    ;
                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 3147, 3169);

                    return mshMethod as T;
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 2876, 3184);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 3200, 3212);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 2121, 3223);

                System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>
                f_1376_2245_2268(System.Management.Automation.ComTypeInfo
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 2245, 2268);
                    return return_v;
                }


                bool
                f_1376_2245_2302(System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>
                this_param, string
                key, out System.Management.Automation.ComProperty
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 2245, 2302);
                    return return_v;
                }


                bool
                f_1376_2340_2360(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.IsParameterized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 2340, 2360);
                    return return_v;
                }


                bool
                f_1376_2406_2465(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 2406, 2465);
                    return return_v;
                }


                string
                f_1376_2550_2559(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 2550, 2559);
                    return return_v;
                }


                System.Management.Automation.PSParameterizedProperty
                f_1376_2522_2577(string
                name, System.Management.Automation.ComAdapter
                adapter, object
                baseObject, System.Management.Automation.ComProperty
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSParameterizedProperty(name, (System.Management.Automation.Adapter)adapter, baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 2522, 2577);
                    return return_v;
                }


                bool
                f_1376_2652_2698(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 2652, 2698);
                    return return_v;
                }


                string
                f_1376_2762_2771(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 2762, 2771);
                    return return_v;
                }


                System.Management.Automation.PSProperty
                f_1376_2747_2789(string
                name, System.Management.Automation.ComAdapter
                adapter, object
                baseObject, System.Management.Automation.ComProperty
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSProperty(name, (System.Management.Automation.Adapter)adapter, baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 2747, 2789);
                    return return_v;
                }


                bool
                f_1376_2880_2924(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 2880, 2924);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>
                f_1376_2972_2992(System.Management.Automation.ComTypeInfo
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 2972, 2992);
                    return return_v;
                }


                bool
                f_1376_2972_3028(System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>
                this_param, string
                key, out System.Management.Automation.ComMethod
                value)
                {
                    var return_v = this_param.TryGetValue(key, out value);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 2972, 3028);
                    return return_v;
                }


                string
                f_1376_3097_3108(System.Management.Automation.ComMethod
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 3097, 3108);
                    return return_v;
                }


                System.Management.Automation.PSMethod
                f_1376_3084_3128(string
                name, System.Management.Automation.ComAdapter
                adapter, object
                baseObject, System.Management.Automation.ComMethod
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSMethod(name, (System.Management.Automation.Adapter)adapter, baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 3084, 3128);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 2121, 3223);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 2121, 3223);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override T GetFirstMemberOrDefault<T>(object obj, MemberNamePredicate predicate)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 3394, 4955);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 3509, 3584);

                bool
                lookingForProperties = f_1376_3537_3583(typeof(T), typeof(PSProperty))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 3598, 3699);

                bool
                lookingForParameterizedProperties = f_1376_3639_3698(typeof(T), typeof(PSParameterizedProperty))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 3713, 4419) || true) && (lookingForProperties || (DynAbs.Tracing.TraceSender.Expression_False(1376, 3717, 3774) || lookingForParameterizedProperties))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 3713, 4419);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 3808, 4404);
                        foreach (ComProperty prop in f_1376_3837_3867_I(f_1376_3837_3867(f_1376_3837_3860(_comTypeInfo))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 3808, 4404);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 3909, 4185) || true) && (f_1376_3913_3933(prop) && (DynAbs.Tracing.TraceSender.Expression_True(1376, 3913, 3995) && lookingForParameterizedProperties
                            ) && (DynAbs.Tracing.TraceSender.Expression_True(1376, 3913, 4044) && f_1376_4024_4044(predicate, f_1376_4034_4043(prop))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 3909, 4185);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 4094, 4162);

                                return f_1376_4101_4156(f_1376_4129_4138(prop), this, obj, prop) as T;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 3909, 4185);
                            }

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 4209, 4385) || true) && (lookingForProperties && (DynAbs.Tracing.TraceSender.Expression_True(1376, 4213, 4257) && f_1376_4237_4257(predicate, f_1376_4247_4256(prop))))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 4209, 4385);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 4307, 4362);

                                return f_1376_4314_4356(f_1376_4329_4338(prop), this, obj, prop) as T;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 4209, 4385);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 3808, 4404);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1376, 1, 597);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1376, 1, 597);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 3713, 4419);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 4435, 4505);

                bool
                lookingForMethods = f_1376_4460_4504(typeof(T), typeof(PSMethod))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 4521, 4916) || true) && (lookingForMethods)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 4521, 4916);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 4576, 4901);
                        foreach (ComMethod method in f_1376_4605_4632_I(f_1376_4605_4632(f_1376_4605_4625(_comTypeInfo))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 4576, 4901);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 4674, 4882) || true) && (f_1376_4678_4700(predicate, f_1376_4688_4699(method)))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 4674, 4882);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 4750, 4811);

                                var
                                mshMethod = f_1376_4766_4810(f_1376_4779_4790(method), this, obj, method)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 4837, 4859);

                                return mshMethod as T;
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 4674, 4882);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 4576, 4901);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1376, 1, 326);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1376, 1, 326);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 4521, 4916);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 4932, 4944);

                return null;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 3394, 4955);

                bool
                f_1376_3537_3583(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 3537, 3583);
                    return return_v;
                }


                bool
                f_1376_3639_3698(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 3639, 3698);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>
                f_1376_3837_3860(System.Management.Automation.ComTypeInfo
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 3837, 3860);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>.ValueCollection
                f_1376_3837_3867(System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 3837, 3867);
                    return return_v;
                }


                bool
                f_1376_3913_3933(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.IsParameterized
                    ;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 3913, 3933);
                    return return_v;
                }


                string
                f_1376_4034_4043(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 4034, 4043);
                    return return_v;
                }


                bool
                f_1376_4024_4044(System.Management.Automation.MemberNamePredicate
                this_param, string
                memberName)
                {
                    var return_v = this_param.Invoke(memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 4024, 4044);
                    return return_v;
                }


                string
                f_1376_4129_4138(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 4129, 4138);
                    return return_v;
                }


                System.Management.Automation.PSParameterizedProperty
                f_1376_4101_4156(string
                name, System.Management.Automation.ComAdapter
                adapter, object
                baseObject, System.Management.Automation.ComProperty
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSParameterizedProperty(name, (System.Management.Automation.Adapter)adapter, baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 4101, 4156);
                    return return_v;
                }


                string
                f_1376_4247_4256(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 4247, 4256);
                    return return_v;
                }


                bool
                f_1376_4237_4257(System.Management.Automation.MemberNamePredicate
                this_param, string
                memberName)
                {
                    var return_v = this_param.Invoke(memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 4237, 4257);
                    return return_v;
                }


                string
                f_1376_4329_4338(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 4329, 4338);
                    return return_v;
                }


                System.Management.Automation.PSProperty
                f_1376_4314_4356(string
                name, System.Management.Automation.ComAdapter
                adapter, object
                baseObject, System.Management.Automation.ComProperty
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSProperty(name, (System.Management.Automation.Adapter)adapter, baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 4314, 4356);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>.ValueCollection
                f_1376_3837_3867_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 3837, 3867);
                    return return_v;
                }


                bool
                f_1376_4460_4504(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 4460, 4504);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>
                f_1376_4605_4625(System.Management.Automation.ComTypeInfo
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 4605, 4625);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>.ValueCollection
                f_1376_4605_4632(System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 4605, 4632);
                    return return_v;
                }


                string
                f_1376_4688_4699(System.Management.Automation.ComMethod
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 4688, 4699);
                    return return_v;
                }


                bool
                f_1376_4678_4700(System.Management.Automation.MemberNamePredicate
                this_param, string
                memberName)
                {
                    var return_v = this_param.Invoke(memberName);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 4678, 4700);
                    return return_v;
                }


                string
                f_1376_4779_4790(System.Management.Automation.ComMethod
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 4779, 4790);
                    return return_v;
                }


                System.Management.Automation.PSMethod
                f_1376_4766_4810(string
                name, System.Management.Automation.ComAdapter
                adapter, object
                baseObject, System.Management.Automation.ComMethod
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSMethod(name, (System.Management.Automation.Adapter)adapter, baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 4766, 4810);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>.ValueCollection
                f_1376_4605_4632_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 4605, 4632);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 3394, 4955);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 3394, 4955);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override PSMemberInfoInternalCollection<T> GetMembers<T>(object obj)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 5732, 7421);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 5835, 5922);

                PSMemberInfoInternalCollection<T>
                collection = f_1376_5882_5921()
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 5938, 6013);

                bool
                lookingForProperties = f_1376_5966_6012(typeof(T), typeof(PSProperty))
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 6027, 6128);

                bool
                lookingForParameterizedProperties = f_1376_6068_6127(typeof(T), typeof(PSParameterizedProperty))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 6142, 6856) || true) && (lookingForProperties || (DynAbs.Tracing.TraceSender.Expression_False(1376, 6146, 6203) || lookingForParameterizedProperties))
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 6142, 6856);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 6237, 6841);
                        foreach (ComProperty prop in f_1376_6266_6296_I(f_1376_6266_6296(f_1376_6266_6289(_comTypeInfo))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 6237, 6841);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 6338, 6822) || true) && (f_1376_6342_6362(prop))
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 6338, 6822);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 6412, 6611) || true) && (lookingForParameterizedProperties)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 6412, 6611);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 6507, 6584);

                                    f_1376_6507_6583(collection, f_1376_6522_6577(f_1376_6550_6559(prop), this, obj, prop));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 6412, 6611);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 6338, 6822);
                            }

                            else
                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 6338, 6822);

                                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 6661, 6822) || true) && (lookingForProperties)
                                )

                                {
                                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 6661, 6822);
                                    DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 6735, 6799);

                                    f_1376_6735_6798(collection, f_1376_6750_6792(f_1376_6765_6774(prop), this, obj, prop));
                                    DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 6661, 6822);
                                }
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 6338, 6822);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 6237, 6841);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1376, 1, 605);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1376, 1, 605);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 6142, 6856);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 6872, 6942);

                bool
                lookingForMethods = f_1376_6897_6941(typeof(T), typeof(PSMethod))
                ;

                if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 6958, 7376) || true) && (lookingForMethods)
                )

                {
                    DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 6958, 7376);
                    try
                    {
                        DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 7013, 7361);
                        foreach (ComMethod method in f_1376_7042_7069_I(f_1376_7042_7069(f_1376_7042_7062(_comTypeInfo))))
                        {
                            DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 7013, 7361);

                            if ((DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 7111, 7342) || true) && (f_1376_7115_7138(collection, f_1376_7126_7137(method)) == null)
                            )

                            {
                                DynAbs.Tracing.TraceSender.TraceEnterCondition(1376, 7111, 7342);
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 7196, 7262);

                                PSMethod
                                mshmethod = f_1376_7217_7261(f_1376_7230_7241(method), this, obj, method)
                                ;
                                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 7288, 7319);

                                f_1376_7288_7318(collection, mshmethod);
                                DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 7111, 7342);
                            }
                            DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 7013, 7361);
                        }
                    }
                    catch (System.Exception)
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoopByException(1376, 1, 349);
                        throw;
                    }
                    finally
                    {
                        DynAbs.Tracing.TraceSender.TraceExitLoop(1376, 1, 349);
                    }
                    DynAbs.Tracing.TraceSender.TraceExitCondition(1376, 6958, 7376);
                }
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 7392, 7410);

                return collection;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 5732, 7421);

                System.Management.Automation.PSMemberInfoInternalCollection<T>
                f_1376_5882_5921()
                {
                    var return_v = new System.Management.Automation.PSMemberInfoInternalCollection<T>();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 5882, 5921);
                    return return_v;
                }


                bool
                f_1376_5966_6012(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 5966, 6012);
                    return return_v;
                }


                bool
                f_1376_6068_6127(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 6068, 6127);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>
                f_1376_6266_6289(System.Management.Automation.ComTypeInfo
                this_param)
                {
                    var return_v = this_param.Properties;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 6266, 6289);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>.ValueCollection
                f_1376_6266_6296(System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 6266, 6296);
                    return return_v;
                }


                bool
                f_1376_6342_6362(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.IsParameterized;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 6342, 6362);
                    return return_v;
                }


                string
                f_1376_6550_6559(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 6550, 6559);
                    return return_v;
                }


                System.Management.Automation.PSParameterizedProperty
                f_1376_6522_6577(string
                name, System.Management.Automation.ComAdapter
                adapter, object
                baseObject, System.Management.Automation.ComProperty
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSParameterizedProperty(name, (System.Management.Automation.Adapter)adapter, baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 6522, 6577);
                    return return_v;
                }


                int
                f_1376_6507_6583(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, System.Management.Automation.PSParameterizedProperty
                member)
                {
                    this_param.Add(member as T);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 6507, 6583);
                    return 0;
                }


                string
                f_1376_6765_6774(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 6765, 6774);
                    return return_v;
                }


                System.Management.Automation.PSProperty
                f_1376_6750_6792(string
                name, System.Management.Automation.ComAdapter
                adapter, object
                baseObject, System.Management.Automation.ComProperty
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSProperty(name, (System.Management.Automation.Adapter)adapter, baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 6750, 6792);
                    return return_v;
                }


                int
                f_1376_6735_6798(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, System.Management.Automation.PSProperty
                member)
                {
                    this_param.Add(member as T);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 6735, 6798);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>.ValueCollection
                f_1376_6266_6296_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ComProperty>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 6266, 6296);
                    return return_v;
                }


                bool
                f_1376_6897_6941(System.Type
                this_param, System.Type
                c)
                {
                    var return_v = this_param.IsAssignableFrom(c);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 6897, 6941);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>
                f_1376_7042_7062(System.Management.Automation.ComTypeInfo
                this_param)
                {
                    var return_v = this_param.Methods;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 7042, 7062);
                    return return_v;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>.ValueCollection
                f_1376_7042_7069(System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>
                this_param)
                {
                    var return_v = this_param.Values;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 7042, 7069);
                    return return_v;
                }


                string
                f_1376_7126_7137(System.Management.Automation.ComMethod
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 7126, 7137);
                    return return_v;
                }


                T
                f_1376_7115_7138(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, string
                i0)
                {
                    var return_v = this_param[i0];
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 7115, 7138);
                    return return_v;
                }


                string
                f_1376_7230_7241(System.Management.Automation.ComMethod
                this_param)
                {
                    var return_v = this_param.Name;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 7230, 7241);
                    return return_v;
                }


                System.Management.Automation.PSMethod
                f_1376_7217_7261(string
                name, System.Management.Automation.ComAdapter
                adapter, object
                baseObject, System.Management.Automation.ComMethod
                adapterData)
                {
                    var return_v = new System.Management.Automation.PSMethod(name, (System.Management.Automation.Adapter)adapter, baseObject, (object)adapterData);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 7217, 7261);
                    return return_v;
                }


                int
                f_1376_7288_7318(System.Management.Automation.PSMemberInfoInternalCollection<T>
                this_param, System.Management.Automation.PSMethod
                member)
                {
                    this_param.Add(member as T);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 7288, 7318);
                    return 0;
                }


                System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>.ValueCollection
                f_1376_7042_7069_I(System.Collections.Generic.Dictionary<string, System.Management.Automation.ComMethod>.ValueCollection
                i)
                {
                    var return_v = i;
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 7042, 7069);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 5732, 7421);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 5732, 7421);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override AttributeCollection PropertyAttributes(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 7693, 7840);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 7796, 7829);

                return f_1376_7803_7828();
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 7693, 7840);

                System.ComponentModel.AttributeCollection
                f_1376_7803_7828(params System.Attribute[]
                attributes)
                {
                    var return_v = new System.ComponentModel.AttributeCollection(attributes);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 7803, 7828);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 7693, 7840);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 7693, 7840);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override object PropertyGet(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 8152, 8355);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 8235, 8288);

                ComProperty
                prop = (ComProperty)property.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 8302, 8344);

                return f_1376_8309_8343(prop, property.baseObject);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 8152, 8355);

                object
                f_1376_8309_8343(System.Management.Automation.ComProperty
                this_param, object
                target)
                {
                    var return_v = this_param.GetValue(target);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 8309, 8343);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 8152, 8355);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 8152, 8355);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void PropertySet(PSProperty property, object setValue, bool convertIfPossible)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 8817, 9062);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 8939, 8992);

                ComProperty
                prop = (ComProperty)property.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 9006, 9051);

                f_1376_9006_9050(prop, property.baseObject, setValue);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 8817, 9062);

                int
                f_1376_9006_9050(System.Management.Automation.ComProperty
                this_param, object
                target, object
                setValue)
                {
                    this_param.SetValue(target, setValue);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 9006, 9050);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 8817, 9062);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 8817, 9062);
            }
        }

        protected override bool PropertyIsSettable(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 9305, 9494);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 9393, 9446);

                ComProperty
                prop = (ComProperty)property.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 9460, 9483);

                return f_1376_9467_9482(prop);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 9305, 9494);

                bool
                f_1376_9467_9482(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.IsSettable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 9467, 9482);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 9305, 9494);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 9305, 9494);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool PropertyIsGettable(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 9737, 9926);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 9825, 9878);

                ComProperty
                prop = (ComProperty)property.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 9892, 9915);

                return f_1376_9899_9914(prop);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 9737, 9926);

                bool
                f_1376_9899_9914(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.IsGettable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 9899, 9914);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 9737, 9926);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 9737, 9926);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override string PropertyType(PSProperty property, bool forDisplay)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 10330, 10586);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 10431, 10484);

                ComProperty
                prop = (ComProperty)property.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 10498, 10575);

                return (DynAbs.Tracing.TraceSender.Conditional_F1(1376, 10505, 10515) || ((forDisplay && DynAbs.Tracing.TraceSender.Conditional_F2(1376, 10518, 10553)) || DynAbs.Tracing.TraceSender.Conditional_F3(1376, 10556, 10574))) ? f_1376_10518_10553(f_1376_10543_10552(prop)) : f_1376_10556_10574(f_1376_10556_10565(prop));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 10330, 10586);

                System.Type
                f_1376_10543_10552(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 10543, 10552);
                    return return_v;
                }


                string
                f_1376_10518_10553(System.Type
                type)
                {
                    var return_v = ToStringCodeMethods.Type(type);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 10518, 10553);
                    return return_v;
                }


                System.Type
                f_1376_10556_10565(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 10556, 10565);
                    return return_v;
                }


                string
                f_1376_10556_10574(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 10556, 10574);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 10330, 10586);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 10330, 10586);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override string PropertyToString(PSProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 10854, 11043);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 10942, 10995);

                ComProperty
                prop = (ComProperty)property.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 11009, 11032);

                return f_1376_11016_11031(prop);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 10854, 11043);

                string
                f_1376_11016_11031(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 11016, 11031);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 10854, 11043);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 10854, 11043);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override object MethodInvoke(PSMethod method, object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 11463, 11689);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 11563, 11615);

                ComMethod
                commethod = (ComMethod)method.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 11629, 11678);

                return f_1376_11636_11677(commethod, method, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 11463, 11689);

                object
                f_1376_11636_11677(System.Management.Automation.ComMethod
                this_param, System.Management.Automation.PSMethod
                method, object[]
                arguments)
                {
                    var return_v = this_param.InvokeMethod(method, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 11636, 11677);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 11463, 11689);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 11463, 11689);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Collection<string> MethodDefinitions(PSMethod method)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 11940, 12151);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 12037, 12089);

                ComMethod
                commethod = (ComMethod)method.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 12103, 12140);

                return f_1376_12110_12139(commethod);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 11940, 12151);

                System.Collections.ObjectModel.Collection<string>
                f_1376_12110_12139(System.Management.Automation.ComMethod
                this_param)
                {
                    var return_v = this_param.MethodDefinitions();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 12110, 12139);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 11940, 12151);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 11940, 12151);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override string ParameterizedPropertyType(PSParameterizedProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 12522, 12736);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 12632, 12685);

                ComProperty
                prop = (ComProperty)property.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 12699, 12725);

                return f_1376_12706_12724(f_1376_12706_12715(prop));
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 12522, 12736);

                System.Type
                f_1376_12706_12715(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.Type;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 12706, 12715);
                    return return_v;
                }


                string
                f_1376_12706_12724(System.Type
                this_param)
                {
                    var return_v = this_param.FullName;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 12706, 12724);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 12522, 12736);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 12522, 12736);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool ParameterizedPropertyIsSettable(PSParameterizedProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 12979, 13194);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 13093, 13146);

                ComProperty
                prop = (ComProperty)property.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 13160, 13183);

                return f_1376_13167_13182(prop);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 12979, 13194);

                bool
                f_1376_13167_13182(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.IsSettable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 13167, 13182);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 12979, 13194);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 12979, 13194);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override bool ParameterizedPropertyIsGettable(PSParameterizedProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 13437, 13652);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 13551, 13604);

                ComProperty
                prop = (ComProperty)property.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 13618, 13641);

                return f_1376_13625_13640(prop);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 13437, 13652);

                bool
                f_1376_13625_13640(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.IsGettable;
                    DynAbs.Tracing.TraceSender.TraceEndMemberAccess(1376, 13625, 13640);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 13437, 13652);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 13437, 13652);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override object ParameterizedPropertyGet(PSParameterizedProperty property, object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 14012, 14272);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 14141, 14194);

                ComProperty
                prop = (ComProperty)property.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 14208, 14261);

                return f_1376_14215_14260(prop, property.baseObject, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 14012, 14272);

                object
                f_1376_14215_14260(System.Management.Automation.ComProperty
                this_param, object
                target, object[]
                arguments)
                {
                    var return_v = this_param.GetValue(target, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 14215, 14260);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 14012, 14272);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 14012, 14272);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override void ParameterizedPropertySet(PSParameterizedProperty property, object setValue, object[] arguments)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 14641, 14919);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 14785, 14838);

                ComProperty
                prop = (ComProperty)property.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 14852, 14908);

                f_1376_14852_14907(prop, property.baseObject, setValue, arguments);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 14641, 14919);

                int
                f_1376_14852_14907(System.Management.Automation.ComProperty
                this_param, object
                target, object
                setValue, object[]
                arguments)
                {
                    this_param.SetValue(target, setValue, arguments);
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 14852, 14907);
                    return 0;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 14641, 14919);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 14641, 14919);
            }
        }

        protected override string ParameterizedPropertyToString(PSParameterizedProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 15232, 15447);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 15346, 15399);

                ComProperty
                prop = (ComProperty)property.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 15413, 15436);

                return f_1376_15420_15435(prop);
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 15232, 15447);

                string
                f_1376_15420_15435(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.ToString();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 15420, 15435);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 15232, 15447);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 15232, 15447);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        protected override Collection<string> ParameterizedPropertyDefinitions(PSParameterizedProperty property)
        {
            try
            {
                DynAbs.Tracing.TraceSender.TraceEnterMethod(1376, 15659, 15980);
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 15788, 15841);

                ComProperty
                prop = (ComProperty)property.adapterData
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 15855, 15936);

                Collection<string>
                returnValue = new Collection<string> { DynAbs.Tracing.TraceSender.TraceInitializationWrapper(() => f_1376_15913_15933(prop), 1376, 15888, 15935) }
                ;
                DynAbs.Tracing.TraceSender.TraceSimpleStatement(1376, 15950, 15969);

                return returnValue;
                DynAbs.Tracing.TraceSender.TraceExitMethod(1376, 15659, 15980);

                string
                f_1376_15913_15933(System.Management.Automation.ComProperty
                this_param)
                {
                    var return_v = this_param.GetDefinition();
                    DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 15913, 15933);
                    return return_v;
                }

            }
            catch
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalCatch(1376, 15659, 15980);
                throw;
            }
            finally
            {
                DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 15659, 15980);
            }
            throw new System.Exception("Slicer error: unreachable code");
        }

        static ComAdapter()
        {
            DynAbs.Tracing.TraceSender.TraceEnterStaticConstructor(1376, 392, 16032);
            DynAbs.Tracing.TraceSender.TraceExitStaticConstructor(1376, 392, 16032);

            DynAbs.Tracing.TraceSender.TraceEnterFinalFinally(1376, 392, 16032);
        }

        int ___ignore_me___ = DynAbs.Tracing.TraceSender.TraceBeforeConstructor(1376, 392, 16032);

        int
        f_1376_747_825(bool
        condition, string
        whyThisShouldNeverHappen)
        {
            Diagnostics.Assert(condition, whyThisShouldNeverHappen);
            DynAbs.Tracing.TraceSender.TraceEndInvocation(1376, 747, 825);
            return 0;
        }

    }
}
